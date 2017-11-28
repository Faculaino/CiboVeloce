Imports EE
Imports DAL
Public Class ComprasBussines


    Sub nuevaCompra(compra As ComprasEntity)
        Dim nuevoDatos = New ComprasDAL
        nuevoDatos.insertCompra(compra)
    End Sub

    Function listarCompras() As List(Of ComprasEntity)
        Dim nuevoDatos = New ComprasDAL
        Dim nuevaLista = New List(Of ComprasEntity)
        nuevaLista = nuevoDatos.listarCompras()
        Return nuevaLista
    End Function

    Function listarComprasEstado(estado As String) As List(Of ComprasEntity)
        Dim nuevoDatos = New ComprasDAL
        Dim nuevaLista = New List(Of ComprasEntity)
        nuevaLista = nuevoDatos.listarComprasEstado(estado)
        Return nuevaLista
    End Function

    Function listarComprasProveedor(id As Integer) As List(Of ComprasEntity)
        Dim nuevoDatos = New ComprasDAL
        Dim nuevaLista = New List(Of ComprasEntity)
        nuevaLista = nuevoDatos.listarComprasProveedor(id)
        Return nuevaLista
    End Function

    Function listarEstados() As List(Of String)
        Dim nuevoDatos = New ComprasDAL
        Dim nuevaLista = New List(Of String)
        nuevaLista = nuevoDatos.listarEstados()
        Return nuevaLista
    End Function





End Class
