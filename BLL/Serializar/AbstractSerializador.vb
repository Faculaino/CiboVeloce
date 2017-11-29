Imports System.IO

Public MustInherit Class AbstractSerializador
    Public MustOverride Function Serializar(que As Object)
    Public MustOverride Function Deserializar(str As Stream) As Object
    Protected _extension As String

    Protected fs As FileStream
    Protected writer As TextWriter
End Class
