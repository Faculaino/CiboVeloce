Public Class BitacoraEntity



    Private _mensaje As String
    Private _registroCambio As String
    Private _tipoEvento As String
    Private _listaEventos As List(Of EventoEntity)




    Public Property listaEventos() As List(Of EventoEntity)
        Get
            Return _listaEventos
        End Get
        Set(ByVal value As List(Of EventoEntity))
            _listaEventos = value
        End Set
    End Property






    Public Property tipoEvento() As String
        Get
            Return _tipoEvento
        End Get
        Set(ByVal value As String)
            _tipoEvento = value
        End Set
    End Property

    Public Property registroCambio() As String
        Get
            Return _registroCambio
        End Get
        Set(ByVal value As String)
            _registroCambio = value
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
