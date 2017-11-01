Imports BLL
Imports EE
Imports Servicios
Public Class FormClientes
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub

    Sub cargarGrilla()
        Dim clienteBussines = New ClienteBussines
        Dim listaClientes = clienteBussines.listarCliente()
        Dim hash = New CryptoManager
        Dim telefonoByte() As Byte

        dgvListaClientes.Rows.Clear()
        For Each item In listaClientes
            telefonoByte = hash.hashearDato(item.telefonos)
            dgvListaClientes.Rows.Add(item.apyn, item.direccion, item.entreCalles, item.localidad, item.detalleDireccion, telefonoByte, item.costo)
        Next

        dgvListaClientes.Sort(dgvListaClientes.Columns("C2"), ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nuevoCliente = New ClienteBussines
        Dim datosCliente = New ClienteEntity

        datosCliente.apyn = txtNombre.Text
        datosCliente.direccion = txtDireccion.Text
        datosCliente.localidad = txtLocalidad.Text
        datosCliente.telefonos = txtTelefonos.Text
        datosCliente.entreCalles = txtEntreCalles.Text
        datosCliente.detalleDireccion = txtDetallesDir.Text
        datosCliente.costo = txtCosto.Text

        nuevoCliente.insertCliente(datosCliente)
        MsgBox("Cliente ingresado correctamente")
    End Sub
End Class