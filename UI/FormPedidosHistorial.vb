Imports BLL
Imports EE
Public Class FormPedidosHistorial

    Private total As Decimal
    Private ventas As Integer

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim pedidosBussines = New PedidoBussines
        Dim nuevaLista = New List(Of PedidoEntity)


        nuevaLista = pedidosBussines.buscarPedidos(dtFecha1.Value, dtFecha2.Value)
        Dim nuevoCliente = New ClienteBussines

        dgvPedidosHistorial.Rows.Clear()
        total = 0
        ventas = 0

        For Each item In nuevaLista
            Dim clientePedido = nuevoCliente.buscarClienteID(item.idCliente)
            dgvPedidosHistorial.Rows.Add(item.fechahora.ToString("dd/MM/yyyy"), item.listaComida, clientePedido.apyn, clientePedido.direccion + ", " + clientePedido.localidad, item.total)
            total = total + item.total
        Next

        txtTotal.Text = total.ToString("C")
        txtCantidadVentas.Text = nuevaLista.Count().ToString()

    End Sub

    Sub cargarCombo()
        Dim nuevaLocalidad = New PedidoBussines
        cmbLocalidades.DataSource = Nothing
        cmbLocalidades.DataSource = nuevaLocalidad.buscarLocalidades()

        cmbLocalidades.SelectedIndex = -1
    End Sub

    Private Sub FormPedidosHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub

    Private Sub btnBuscaLocalidad_Click(sender As Object, e As EventArgs) Handles btnBuscaLocalidad.Click
        Dim nuevoPedidos = New PedidoBussines
        Dim lista = New List(Of PedidoEntity)
        Dim nuevoCliente = New ClienteBussines
        lista = nuevoPedidos.buscaPedidosLocalidad(cmbLocalidades.Text)
        total = 0
        ventas = 0
        dgvPedidosHistorial.Rows.Clear()
        For Each item In lista
            Dim clientePedido = nuevoCliente.buscarClienteID(item.idCliente)
            dgvPedidosHistorial.Rows.Add(item.fechahora, item.listaComida, clientePedido.apyn, clientePedido.direccion + ", " + clientePedido.localidad, item.total)
            total = total + item.total
        Next

        txtTotal.Text = total.ToString("C")
        txtCantidadVentas.Text = lista.Count().ToString()

    End Sub
End Class