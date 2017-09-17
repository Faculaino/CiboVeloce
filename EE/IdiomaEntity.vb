Public Class IdiomaEntity
    Inherits BaseEntity

    Private _idioma As String


    Public Property idioma() As String
        Get
            Return _idioma
        End Get
        Set(ByVal value As String)
            _idioma = value
        End Set
    End Property




End Class
