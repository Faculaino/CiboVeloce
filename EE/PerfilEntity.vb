Public Class PerfilEntity
    Inherits BaseEntity

    Private _descripcion As String
    Private _listaPermisos As List(Of PermisoEntity)




    Public Property listaPermisos() As List(Of PermisoEntity)
        Get
            Return _listaPermisos
        End Get
        Set(ByVal value As List(Of PermisoEntity))
            _listaPermisos = value
        End Set
    End Property




    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

End Class
