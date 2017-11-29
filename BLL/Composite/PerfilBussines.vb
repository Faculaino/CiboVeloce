Imports EE
Imports DAL
Imports BLL

Public Class PerfilBussines
    Inherits Componente


    'Private elementos As New List(Of Componente)()


    'Public Sub New(name As String)
    '    MyBase.New(name)
    'End Sub


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

    Sub cambiarPerfil(idPerfil As Integer, idUsuario As Integer)
        Dim nuevoDatos = New PerfilDAL
        nuevoDatos.setearPerfil(idPerfil, idUsuario)
    End Sub

    Public Overrides Sub agregar(c As Componente)
        'elementos.Add(c)

    End Sub

    Public Overrides Sub eliminar(c As Componente)
        'elementos.Remove(c)
    End Sub

    Public Overrides Sub mostrar(perfil As PerfilEntity, permiso As PermisoEntity)
        Throw New NotImplementedException()
    End Sub
End Class
