Public Class BitacoraEntity
    Inherits BaseEntity



    Private _mensaje As String
    Private _fechahora As DateTime
    Private _usuario As String






    Private _listaEventos As List(Of EventoEntity)




    Public Property listaEventos() As List(Of EventoEntity)
        Get
            Return _listaEventos
        End Get
        Set(ByVal value As List(Of EventoEntity))
            _listaEventos = value
        End Set
    End Property


    Public Property fechahora() As DateTime
        Get
            Return _fechahora
        End Get
        Set(ByVal value As DateTime)
            _fechahora = value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property



    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
        End Set
    End Property




End Class
