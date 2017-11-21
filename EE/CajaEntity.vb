Public Class CajaEntity
    Inherits BaseEntity


    Private _fechahora As DateTime
    Public Property fechahora() As DateTime
        Get
            Return _fechahora
        End Get
        Set(ByVal value As DateTime)
            _fechahora = value
        End Set
    End Property

    Private _importe As Decimal
    Public Property importe() As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _idUsuario As Integer
    Public Property idUsuario() As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Private _idCliente As Integer
    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _idPedido As Integer
    Public Property idPedido() As Integer
        Get
            Return _idPedido
        End Get
        Set(ByVal value As Integer)
            _idPedido = value
        End Set
    End Property



End Class
