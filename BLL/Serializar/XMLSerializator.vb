Imports System.IO
Imports System.Xml.Serialization
Public Class XMLSerializator(Of T)
    Inherits AbstractSerializador

    Public Overrides Function Deserializar(str As Stream) As Object

        Dim serializer As New XmlSerializer(GetType(T))
        Dim tr As TextReader = New StreamReader(str)

        Dim o As Object = serializer.Deserialize(tr)
        tr.Close()
        Return o
    End Function

    Public Overrides Function Serializar(que As Object)

        fs = FileStreamManager.Instance.CreateFile("xml")

        writer = New StreamWriter(fs)
        Dim ser As XmlSerializer = New XmlSerializer(GetType(T))

        ser.Serialize(writer, que)
        writer.Close()
        fs.Close()
        Return fs.Name
    End Function
End Class
