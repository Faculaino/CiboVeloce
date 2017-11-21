Imports EE
Imports BLL
Public Class FormCaja
    Private Sub FormCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCaja.Rows.Clear()
        listarRegistros()
    End Sub


    Sub listarRegistros()
        Dim nuevaCaja = New CajaBussines
        Dim nuevaLista = New List(Of CajaEntity)

        nuevaLista = nuevaCaja.listarRegistros()

        dgvCaja.Rows.Clear()
        For Each item In nuevaLista
            Dim nuevoCliente = New ClienteBussines
            Dim cliente = nuevoCliente.buscarClienteID(item.idCliente)

            Dim nuevoPedido = New PedidoBussines
            Dim pedido = nuevoPedido.buscarPedidoID(item.idPedido)

            Dim nuevoUsuario = New UsuarioBussines
            Dim usuario = nuevoUsuario.buscarUserID(item.idUsuario)
            dgvCaja.Rows.Add(item.fechahora, item.descripcion, cliente.apyn, pedido.listaComida, usuario.Nombre, item.importe)
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nuevaCaja = New CajaBussines
        Dim nuevaLista = New List(Of CajaEntity)


        nuevaLista = nuevaCaja.registrosFechas(dtFecha1.Value, dtFecha2.Value)

        dgvCaja.DataSource = Nothing
        dgvCaja.DataSource = nuevaLista

    End Sub
End Class