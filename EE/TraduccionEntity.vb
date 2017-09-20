Public Class TraduccionEntity
    Inherits BaseEntity


    Private _IDIdioma As Integer
    Private _IDPalabra As Integer
    Private _PalabraTraducida As String



    Public Property PalabraTraducida() As String
        Get
            Return _PalabraTraducida
        End Get
        Set(ByVal value As String)
            _PalabraTraducida = value
        End Set
    End Property



    Public Property IDPalabra() As Integer
        Get
            Return _IDPalabra
        End Get
        Set(ByVal value As Integer)
            _IDPalabra = value
        End Set
    End Property



    Public Property IDIdioma() As Integer
        Get
            Return _IDIdioma
        End Get
        Set(ByVal value As Integer)
            _IDIdioma = value
        End Set
    End Property


End Class
