Imports EE
Imports DAL
Public Class PerfilBussines
    Inherits Componente

    Public Overrides Sub AsignarPerfil(Usuario As UsuarioEntity)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub AsignarPermisos(Usuario As UsuarioEntity, Permisos As PermisoEntity)
        Throw New NotImplementedException()
    End Sub

    Function perfilUsuario(id As Integer) As PerfilEntity

        Dim nuevoDatos = New PerfilDAL
        Dim nuevoPerfil = New PerfilEntity
        nuevoPerfil = nuevoDatos.perfilUsuario(id)

        Return nuevoPerfil
    End Function

    Function buscarPerfil(usuario As UsuarioEntity) As String
        Dim nuevoDatos = New PerfilDAL
        Dim perfil = nuevoDatos.buscarPerfil(usuario)
        Return perfil
    End Function

    Function listarPerfiles() As List(Of PerfilEntity)

        Dim nuevoDatos = New PerfilDAL
        Dim listado = nuevoDatos.listarPerfiles()

        Return listado
    End Function

    Function buscarPermisosPorPerfil(idPerfil As Integer) As List(Of PermisoEntity)
        Dim lista = New List(Of PermisoEntity)
        Dim nuevoDatos = New PerfilDAL
        lista = nuevoDatos.buscarPermisosPorPerfil(idPerfil)

        Return lista
    End Function

End Class
