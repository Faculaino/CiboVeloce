Imports BLL
Imports EE
Public Class FormPedidosPendientes
    Private Sub FormPedidosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarCombo()
    End Sub

    Sub cargarCombo()
        Dim nuevoEstado = New EstadoBussines
        cmbEstado.DataSource = Nothing
        cmbEstado.DataSource = nuevoEstado.listarEstados()

        cmbEstado.DisplayMember = "Estado"
        cmbEstado.ValueMember = "ID"
        cmbEstado.SelectedIndex = -1

    End Sub

    Sub cargarGrilla(id As Integer)
        Dim listaPedidos = New EstadoBussines
        Dim lista = listaPedidos.listarPedidosEstados(id)
        Dim nuevoCliente = New ClienteBussines


        'celda = dgvPedidosCocina.Columns("Estado")
        'celda.DataSource = listaPedidos.listarEstados()
        'celda.DisplayMember = "Estado"
        'celda.ValueMember = "ID"


        dgvPedidosCocina.Rows.Clear()
        For Each item In lista
            Dim clientePedido = nuevoCliente.buscarClienteID(item.idCliente)
            Dim estadoPedido = listaPedidos.buscarEstadoID(item.idEstado)
            dgvPedidosCocina.Rows.Add(item.fechahora, item.listaComida, clientePedido.apyn, estadoPedido.estado)
            Try
                Dim celda = New DataGridViewComboBoxColumn
                celda = DirectCast(dgvPedidosCocina.Columns("C4"), DataGridViewComboBoxColumn)
                celda.DataSource = listaPedidos.listarEstados()
                celda.DisplayMember = "Estado"
                celda.ValueMember = "ID"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next





    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        'If cmbEstado.SelectedIndex = 0 Or cmbEstado.SelectedIndex = -1 Then

        'Else

        '    cargarGrilla(cmbEstado.SelectedValue)
        'End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarGrilla(cmbEstado.SelectedValue)
    End Sub

    Private Sub dgvPedidosCocina_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidosCocina.CellContentClick

    End Sub

    Private Sub dgvPedidosCocina_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidosCocina.CellClick
        'Dim columna As Integer
        'Dim fila As Integer
        'Dim nuevoEstado = New EstadoBussines
        'columna = dgvPedidosCocina.CurrentCellAddress.X
        'fila = dgvPedidosCocina.CurrentCellAddress.Y

        'Dim comboboxColumn As DataGridViewComboBoxCell = TryCast(dgvPedidosCocina.Rows(fila).Cells(columna), DataGridViewComboBoxCell)
        'comboboxColumn.DataSource = nuevoEstado.listarEstados()
        'comboboxColumn.DisplayMember = "Estado"
        'comboboxColumn.ValueMember = "ID"
    End Sub

    Private Sub dgvPedidosCocina_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvPedidosCocina.DataError

    End Sub

    Private Sub dgvPedidosCocina_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidosCocina.CellEnter
        dgvPedidosCocina.BeginEdit(False)

        If e.ColumnIndex = 1 Then

            If Not IsNothing(dgvPedidosCocina.EditingControl) Then

                Dim cmb As ComboBox = dgvPedidosCocina.EditingControl
                cmb.DroppedDown = True

            End If
        End If
    End Sub

    Private Sub cmbCambiarEstado_Click(sender As Object, e As EventArgs) Handles cmbCambiarEstado.Click
        Dim nuevaLista = New List(Of PedidoEntity)





    End Sub
End Class