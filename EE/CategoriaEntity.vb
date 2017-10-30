Public Class CategoriaEntity
    Inherits BaseEntity


    Private _tipo As String
    Private _dvv As Integer
    Private _dvh As Integer
    Private _listaComidas As List(Of ComidaEntity)





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




    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    Public Property listaComidas() As List(Of ComidaEntity)
        Get
            Return _listaComidas
        End Get
        Set(ByVal value As List(Of ComidaEntity))
            _listaComidas = value
        End Set
    End Property

#End Region


End Class
