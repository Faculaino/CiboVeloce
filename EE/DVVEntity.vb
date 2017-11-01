Public Class DVVEntity
    Inherits BaseEntity

    Private _tabla As String
    Private _valor As Integer

#Region "Public Property"
    Public Property valor() As Integer
        Get
            Return _valor
        End Get
        Set(ByVal value As Integer)
            _valor = value
        End Set
    End Property


    Public Property tabla() As String
        Get
            Return _tabla
        End Get
        Set(ByVal value As String)
            _tabla = value
        End Set
    End Property

#End Region





End Class
