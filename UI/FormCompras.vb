Imports EE
Imports BLL
Public Class FormCompras

    Private compra As New ComprasEntity
    Private lista As String

    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub


    Sub cargarGrilla()
        Dim nuevoProveedores = New ProveedorBussines
        Dim listaProveedores = New List(Of ProveedorEntity)

        listaProveedores = nuevoProveedores.listarProveedores()

        dgvProveedores.Rows.Clear()
        For Each item As ProveedorEntity In listaProveedores
            dgvProveedores.Rows.Add(item.nombre, item.direccion, item.telefono, item.ID)
        Next
    End Sub

    Private Sub btnCargarLista_Click(sender As Object, e As EventArgs) Handles btnCargarLista.Click
        lista = ""

        For Each item As DataGridViewRow In dgvListaItems.Rows
            If item.Cells("C5").Value Is Nothing Then
            Else
                lista = lista + item.Cells("C5").Value.ToString() + " " + item.Cells("C6").Value.ToString() + ", "
            End If

        Next
        lista.Remove(lista.Length - 3)
        compra.listaItems = lista
        MsgBox("Lista cargada correctamente")
    End Sub

    Private Sub btnSeleccionarProveedor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProveedor.Click
        lblIDProveedor.Text = dgvProveedores.CurrentRow.Cells("C4").Value.ToString()
        Dim prov = New ProveedorBussines
        Dim provOK = New ProveedorEntity
        provOK = prov.buscarProveedor(CInt(lblIDProveedor.Text.ToString()))
        compra.proveedor = provOK
        dgvProveedores.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
    End Sub

    Private Sub btnNuevaCompra_Click(sender As Object, e As EventArgs) Handles btnNuevaCompra.Click
        Dim nuevaCompra = New ComprasBussines
        compra.fecha = Now
        compra.estado = "Pendiente"
        nuevaCompra.nuevaCompra(compra)
        MsgBox("Se generó Compra con Éxito")
    End Sub

    Private Sub btnVerCompras_Click(sender As Object, e As EventArgs) Handles btnVerCompras.Click
        Dim listaCompras = New FormComprasVer
        listaCompras.StartPosition = FormStartPosition.CenterParent
        listaCompras.Show()
    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        Dim nuevoProveedor = New FormNuevoProveedor
        nuevoProveedor.StartPosition = FormStartPosition.CenterScreen
        nuevoProveedor.ShowDialog()
    End Sub
End Class