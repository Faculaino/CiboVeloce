Public Class UsuarioEntity
    Inherits BaseEntity


#Region "Propiedades"
    Private _Nombre As String
    Private _User As String
    Private _Password As String
    Private _DVV As Integer
    Private _DVH As Integer
    Private _Activo As Boolean
    Private _IDPerfil As Integer




#End Region


#Region "Get/Set"
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property




    Public Property DVH() As Integer
        Get
            Return _DVH
        End Get
        Set(ByVal value As Integer)
            _DVH = value
        End Set
    End Property



    Public Property DVV() As Integer
        Get
            Return _DVV
        End Get
        Set(ByVal value As Integer)
            _DVV = value
        End Set
    End Property





    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property






    Public Property User() As String
        Get
            Return _User
        End Get
        Set(ByVal value As String)
            _User = value
        End Set
    End Property







    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property IDPerfil() As Integer
        Get
            Return _IDPerfil
        End Get
        Set(ByVal value As Integer)
            _IDPerfil = value
        End Set
    End Property
#End Region




End Class
