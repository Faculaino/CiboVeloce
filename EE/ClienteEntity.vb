<Serializable>
Public Class ClienteEntity
    Inherits BaseEntity

    Private _apyn As String
    Private _direccion As String
    Private _localidad As String
    Private _entreCalles As String
    Private _detalleDireccion As String
    Private _telefonos As String
    Private _costo As Decimal
    'Private _idPedidos As Integer
    <NonSerialized>
    Private _dvv As Integer
    <NonSerialized>
    Private _dvh As Integer



#Region "Propiedades Publicas"
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
    'Public Property idPedidos() As Integer
    '    Get
    '        Return _idPedidos
    '    End Get
    '    Set(ByVal value As Integer)
    '        _idPedidos = value
    '    End Set
    'End Property
    Public Property costo() As Decimal
        Get
            Return _costo
        End Get
        Set(ByVal value As Decimal)
            _costo = value
        End Set
    End Property
    Public Property telefonos() As String
        Get
            Return _telefonos
        End Get
        Set(ByVal value As String)
            _telefonos = value
        End Set
    End Property
    Public Property detalleDireccion() As String
        Get
            Return _detalleDireccion
        End Get
        Set(ByVal value As String)
            _detalleDireccion = value
        End Set
    End Property
    Public Property entreCalles() As String
        Get
            Return _entreCalles
        End Get
        Set(ByVal value As String)
            _entreCalles = value
        End Set
    End Property
    Public Property localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property




    Public Property apyn() As String
        Get
            Return _apyn
        End Get
        Set(ByVal value As String)
            _apyn = value
        End Set
    End Property
#End Region







End Class
