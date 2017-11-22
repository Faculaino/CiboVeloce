Imports DAL
Imports EE
Public Class PedidoBussines


    Sub nuevoPedido(pedido As PedidoEntity)
        Dim nuevoDatos = New PedidoDAL
        Dim nuevoDVV = New DVVBussines

        pedido.dvh = pedido.listaComida.Length
        pedido.dvv = nuevoDatos.buscarDVV()
        nuevoDatos.insertPedido(pedido)
        nuevoDVV.actualizarDVV("Pedidos", pedido.dvv)

    End Sub

    Function buscaPedidosLocalidad(localidad As String) As List(Of PedidoEntity)
        Dim nuevoDatos = New PedidoDAL
        Dim nuevaLista = New List(Of PedidoEntity)
        nuevaLista = nuevoDatos.buscarPedidosLOCALIDAD(localidad)
        Return nuevaLista
    End Function

    Function buscarLocalidades() As List(Of String)
        Dim nuevoDatos = New PedidoDAL
        Dim nuevaLista = New List(Of String)
        nuevaLista = nuevoDatos.buscarLocalidades()
        Return nuevaLista
    End Function

    Function buscarPedidos(fecha1 As DateTime, fecha2 As DateTime) As List(Of PedidoEntity)
        Dim nuevoDatos = New PedidoDAL
        Dim nuevaLista = New List(Of PedidoEntity)
        nuevaLista = nuevoDatos.buscarPedidos(fecha1, fecha2)
        Return nuevaLista
    End Function

    Public Function buscarPedidoID(idPedido As Integer) As PedidoEntity
        Dim nuevoDatos = New PedidoDAL
        Dim nuevoPedido = nuevoDatos.buscarPedidoID(idPedido)
        Return nuevoPedido
    End Function

    Public Function consultaUltimoID() As Integer
        Dim id As Integer = 0
        Dim nuevoDatos = New PedidoDAL
        id = nuevoDatos.buscaUltimoID()
        Return id
    End Function
End Class
