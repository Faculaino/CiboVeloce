Imports EE
Public Class Bitacora

    Private _fecha As Date
    Private _mensaje As String
    Private _registroCambio As String
    Private _tipoEvento As String


    Public Shared Sub guardarLog(detalle As String, usuario As UsuarioEntity, fecha As Date)

    End Sub

    Function listarBitacora() As List(Of Bitacora)

        Return Nothing
    End Function





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

    Public Property fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property




End Class
