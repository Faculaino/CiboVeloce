Imports BLL
Imports EE
Public Class Composite
    Inherits Componente


    Private elementos As New List(Of Componente)()


    'Public Sub New(name As String)
    '    MyBase.New(name)
    'End Sub


    Public Overrides Sub agregar(c As Componente)
        elementos.Add(c)
    End Sub

    Public Overrides Sub eliminar(c As Componente)
        elementos.Remove(c)
    End Sub

    Public Overrides Sub mostrar(perfil As PerfilEntity, permiso As PermisoEntity)


    End Sub
End Class
