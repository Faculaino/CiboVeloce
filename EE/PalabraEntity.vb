Public Class PalabraEntity
    Inherits BaseEntity


    Private _Palabra As String



    Public Property Palabra() As String
        Get
            Return _Palabra
        End Get
        Set(ByVal value As String)
            _Palabra = value
        End Set
    End Property




End Class
