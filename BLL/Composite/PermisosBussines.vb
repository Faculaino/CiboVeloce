Imports EE
Imports DAL
Imports BLL

Public Class PermisosBussines
    Inherits Componente


    'Public Sub New(name As String)
    '    MyBase.New(name)
    'End Sub

    Function buscarPermisoName(name As String) As PermisoEntity
        Dim nuevoDatos = New PermisoDAL
        Dim nuevoPermiso = New PermisoEntity
        nuevoPermiso = nuevoDatos.buscarPermisoName(name)
        Return nuevoPermiso
    End Function

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

    Public Overrides Sub eliminar(c As Componente)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub agregar(c As Componente)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub mostrar(perfil As PerfilEntity, permiso As PermisoEntity)
        Throw New NotImplementedException()
    End Sub

    Public Sub insertPermisos(listaPermisos As List(Of PermisoEntity), id As Integer)
        Dim nuevoDatos = New PermisoDAL
        nuevoDatos.insertPermisos(listaPermisos, id)
    End Sub
End Class
