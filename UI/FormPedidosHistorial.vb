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

    Private Sub FormPedidosHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class