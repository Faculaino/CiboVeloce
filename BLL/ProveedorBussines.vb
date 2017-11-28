Imports EE
Imports DAL
Public Class ProveedorBussines

    Sub nuevoProveedor(proveedor As ProveedorEntity)
        Dim nuevoDatos = New ProveedorDAL
        nuevoDatos.insertProveedor(proveedor)
    End Sub

    Function listarProveedores() As List(Of ProveedorEntity)
        Dim nuevoDatos = New ProveedorDAL
        Dim nuevaLista = New List(Of ProveedorEntity)
        nuevaLista = nuevoDatos.listarProveedores()
        Return nuevaLista
    End Function

    Function buscarProveedor(id As Integer) As ProveedorEntity
        Dim nuevoDatos = New ProveedorDAL
        Dim nuevoProveedor = New ProveedorEntity
        nuevoProveedor = nuevoDatos.buscarProveedor(id)
        Return nuevoProveedor
    End Function





End Class
