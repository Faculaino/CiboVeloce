Imports EE
Public MustInherit Class Componente

    'MustOverride Sub AsignarPerfil(Usuario As UsuarioEntity)
    'MustOverride Sub AsignarPermisos(Usuario As UsuarioEntity, Permisos As PermisoEntity)

    'Protected name As String

    'Public Sub New(name As String)
    '    Me.name = name
    'End Sub

    Public MustOverride Sub agregar(c As Componente)
    Public MustOverride Sub eliminar(c As Componente)
    Public MustOverride Sub mostrar(depth As Integer)


End Class
