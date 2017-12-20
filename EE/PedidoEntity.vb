Public Class PedidoEntity
    Inherits BaseEntity

    Private _fechahora As DateTime
    Private _total As Decimal
    Private _idUsuario As Integer
    Private _idCliente As Integer
    Private _listaComida As String
    Private _idEstado As Integer
    Private _dvv As Integer
    Private _dvh As Integer



    Public Property dvh() As Integer
        Get
            Return _dvh
        End Get
        Set(ByVal value As Integer)
            _dvh = value
        End Set
    End Property



    Public Property dvv() As Integer
        Get
            Return _dvv
        End Get
        Set(ByVal value As Integer)
            _dvv = value
        End Set
    End Property





    Public Property idEstado() As Integer
        Get
            Return _idEstado
        End Get
        Set(ByVal value As Integer)
            _idEstado = value
        End Set
    End Property




    Public Property listaComida() As String
        Get
            Return _listaComida
        End Get
        Set(ByVal value As String)
            _listaComida = value
        End Set
    End Property


    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property


    Public Property total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property
    Public Property fechahora() As DateTime
        Get
            Return _fechahora
        End Get
        Set(ByVal value As DateTime)
            _fechahora = value
        End Set
    End Property


    Public Property idUsuario() As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

End Class
