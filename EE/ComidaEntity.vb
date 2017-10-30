Public Class ComidaEntity
    Inherits BaseEntity

    Private _detalle As String
    Private _precio As Decimal
    Private _idcategoria As Integer
    Private _dvv As Integer
    Private _dvh As Integer


#Region "Public Property"
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



    Public Property idcategoria() As Integer
        Get
            Return _idcategoria
        End Get
        Set(ByVal value As Integer)
            _idcategoria = value
        End Set
    End Property




    Public Property precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property







    Public Property detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
        End Set
    End Property

#End Region





End Class
