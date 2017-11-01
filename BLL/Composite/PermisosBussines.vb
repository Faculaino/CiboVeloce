Imports EE
Imports DAL
Imports BLL

Public Class PermisosBussines
    Inherits Componente


    'Public Sub New(name As String)
    '    MyBase.New(name)
    'End Sub

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

    'Public Overrides Sub agregar(c As Componente)
    '    Throw New NotImplementedException()
    'End Sub

    Public Overrides Sub eliminar(c As Componente)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub mostrar(depth As Integer)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub agregar(c As Componente)
        Throw New NotImplementedException()
    End Sub
End Class
