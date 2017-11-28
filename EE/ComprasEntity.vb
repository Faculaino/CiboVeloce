Public Class ComprasEntity
    Inherits BaseEntity


    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

    Private _monto As Decimal
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property

    Private _estado As String
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Private _proveedor As ProveedorEntity
    Public Property proveedor() As ProveedorEntity
        Get
            Return _proveedor
        End Get
        Set(ByVal value As ProveedorEntity)
            _proveedor = value
        End Set
    End Property

    Private _listaItems As String
    Public Property listaItems() As String
        Get
            Return _listaItems
        End Get
        Set(ByVal value As String)
            _listaItems = value
        End Set
    End Property

End Class
