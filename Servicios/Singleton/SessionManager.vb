Imports EE
Public NotInheritable Class SessionManager

    Private Sub New()

    End Sub

    Private Shared _Instance As SessionManager = Nothing

    Public Traductor As Dictionary(Of String, String)

    Public Property NewProperty() As Dictionary(Of String, String)
        Get
            Return Traductor
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            Traductor = value
        End Set
    End Property
    Public Shared ReadOnly Property Instance() As SessionManager
        Get
            If _Instance Is Nothing Then
                _Instance = New SessionManager()
            End If
            Return _Instance
        End Get
    End Property


    Public Property Usuario As UsuarioEntity

    Public Sub Login(user As UsuarioEntity)
        _Usuario = user
    End Sub

    Public Sub Logout()
        Usuario = Nothing
    End Sub



End Class
