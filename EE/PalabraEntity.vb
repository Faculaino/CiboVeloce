Public Class PalabraEntity
    Inherits BaseEntity

    Private _IDIdioma As Integer
    Private _Palabra As String



    Public Property Palabra() As String
        Get
            Return _Palabra
        End Get
        Set(ByVal value As String)
            _Palabra = value
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
