Public Class BaseEntity


#Region "Propiedades"
    Private _ID As Integer
#End Region

#Region "Get/Set"

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

#End Region








End Class
