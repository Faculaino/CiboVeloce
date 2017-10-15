Imports EE
Imports DAL
Public Class PermisosBussines
    Inherits Componente

    Public Overrides Sub AsignarPerfil(Usuario As UsuarioEntity)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub AsignarPermisos(Usuario As UsuarioEntity, Permisos As PermisoEntity)
        Throw New NotImplementedException()
    End Sub

    Function listarPermisos() As List(Of PermisoEntity)

        Dim nuevoDatos = New PermisoDAL
        Dim listado = nuevoDatos.listarPermisos()

        Return listado
    End Function

    Function buscarPermisos(usuario As UsuarioEntity) As List(Of PermisoEntity)
        Dim lista = New List(Of PermisoEntity)
        Dim nuevoDatos = New PermisoDAL
        lista = nuevoDatos.buscarPermisos(usuario)

        Return lista
    End Function







End Class
