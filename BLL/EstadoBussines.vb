Imports EE
Imports DAL
Public Class EstadoBussines


    Function listarEstados() As List(Of EstadoEntity)
        Dim nuevoDatos = New EstadoDAL
        Dim nuevaLista = nuevoDatos.listarEstados()
        Return nuevaLista
    End Function

    Function listarPedidosEstados(id As Integer) As List(Of PedidoEntity)
        Dim nuevoDatos = New PedidoDAL
        Dim nuevaLista = nuevoDatos.listarPedidosEstado(id)
        Return nuevaLista
    End Function

    Public Function buscarEstadoID(idEstado As Integer) As EstadoEntity
        Dim nuevoDatos = New PedidoDAL
        Dim nuevoDatosEstado = New EstadoDAL
        Dim nuevoEstado = New EstadoEntity
        nuevoEstado = nuevoDatosEstado.buscarEstadoID(idEstado)
        Return nuevoEstado
    End Function
End Class
