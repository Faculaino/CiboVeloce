Imports EE
Imports DAL
Public Class FaltaComida
    Inherits Estado

    Public Overrides Sub setEstado(lista As List(Of PedidoEntity), id As Integer)
        Dim nuevoDatos = New PedidoDAL
        nuevoDatos.modificarEstado(lista, id)
    End Sub
End Class
