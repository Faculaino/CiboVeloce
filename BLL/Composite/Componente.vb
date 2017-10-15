Imports EE
Public MustInherit Class Componente

    MustOverride Sub AsignarPerfil(Usuario As UsuarioEntity)
    MustOverride Sub AsignarPermisos(Usuario As UsuarioEntity, Permisos As PermisoEntity)



End Class
