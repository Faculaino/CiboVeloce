Imports EE
Imports BLL
Public Class FormComprasVer
    Private Sub FormComprasVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
        cargarGrilla()
    End Sub


    Sub cargarGrilla()
        Dim nuevaCompra = New ComprasBussines
        Dim lista = New List(Of ComprasEntity)
        lista = nuevaCompra.listarCompras()

        dgvCompras.Rows.Clear()
        For Each item As ComprasEntity In lista
            dgvCompras.Rows.Add(item.fecha, item.proveedor, item.listaItems, item.estado, item.monto)
        Next

    End Sub

    Sub cargarGrillaEstado(estado As String)
        Dim nuevaCompra = New ComprasBussines
        Dim lista = New List(Of ComprasEntity)
        lista = nuevaCompra.listarComprasEstado(estado)
        dgvCompras.Rows.Clear()
        For Each item As ComprasEntity In lista
            dgvCompras.Rows.Add(item.fecha, item.proveedor, item.listaItems, item.estado, item.monto)
        Next

    End Sub

    Sub cargarGrillaProveedor(idProveedor As Integer)
        Dim nuevaCompra = New ComprasBussines
        Dim lista = New List(Of ComprasEntity)
        lista = nuevaCompra.listarComprasProveedor(idProveedor)
        dgvCompras.Rows.Clear()
        For Each item As ComprasEntity In lista
            dgvCompras.Rows.Add(item.fecha, item.proveedor, item.listaItems, item.estado, item.monto)
        Next

    End Sub

    Sub cargarCombo()
        Dim nuevoProveedor = New ProveedorBussines

        cmbProveedores.DataSource = Nothing
        cmbProveedores.DataSource = nuevoProveedor.listarProveedores()

        cmbProveedores.DisplayMember = "Nombre"
        cmbProveedores.ValueMember = "ID"
        cmbProveedores.SelectedIndex = -1

        Dim nuevaCompra = New ComprasBussines

        cmbEstados.DataSource = Nothing
        cmbEstados.DataSource = nuevaCompra.listarEstados()

        cmbEstados.DisplayMember = "Estado"
        cmbEstados.SelectedIndex = -1




    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarEstado.Click
        cargarGrillaEstado(cmbProveedores.Text)
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        cargarGrillaProveedor(cmbProveedores.SelectedValue)
    End Sub
End Class