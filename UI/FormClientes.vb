Imports BLL
Imports EE
Imports Servicios
Imports System.Xml.Serialization
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
            dgvListaClientes.Rows.Add(item.apyn, item.direccion, item.entreCalles, item.localidad, item.detalleDireccion, telefonoByte, item.costo, item.ID)
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

    Private Sub btnGuardarXML_Click(sender As Object, e As EventArgs) Handles btnGuardarXML.Click
        Dim lista = New List(Of ClienteEntity)
        Dim serializador = New Serializador

        For Each item As DataGridViewRow In dgvListaClientes.Rows
            Dim nuevoCliente = New ClienteEntity
            nuevoCliente.apyn = item.Cells("C1").Value.ToString()
            nuevoCliente.direccion = item.Cells("C2").Value.ToString()
            nuevoCliente.detalleDireccion = item.Cells("C5").Value.ToString()
            nuevoCliente.entreCalles = item.Cells("C3").Value.ToString()
            nuevoCliente.localidad = item.Cells("C4").Value.ToString()
            nuevoCliente.telefonos = item.Cells("C6").Value.ToString()
            nuevoCliente.costo = CDec(item.Cells("C7").Value.ToString())
            nuevoCliente.ID = CInt(item.Cells("C8").Value.ToString())
            lista.Add(nuevoCliente)
        Next

        Try
            serializador.Serializar(New XMLSerializator(Of List(Of ClienteEntity)), lista)
        Catch ex As Exception
            MsgBox("Error al Serializar Datos")
        End Try



    End Sub
End Class