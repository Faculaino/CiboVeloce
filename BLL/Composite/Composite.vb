Imports BLL
Imports EE
Public Class Composite
    Inherits Componente

    'Private elementos As New List(Of Componente)()


    'Public Sub New(name As String)
    '    MyBase.New(name)
    'End Sub


    Public Overrides Sub agregar(c As Componente)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub eliminar(c As Componente)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub mostrar(depth As Integer)
        Throw New NotImplementedException()
    End Sub
End Class
