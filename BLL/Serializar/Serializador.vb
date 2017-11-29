Imports EE
Imports DAL
Imports System.IO
Public Class Serializador

    Private _strategy As AbstractSerializador


    Public Sub SetStrategy(strategy As AbstractSerializador)
        _strategy = strategy
    End Sub

    Public Function Deserializar(str As Stream) As Object
        Try

            _strategy.Deserializar(str)
            str.Close()
            MsgBox("Deserialización completa!", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Sub Serializar(strategy As AbstractSerializador, que As Object)

        Try
            strategy.Serializar(que)
            MsgBox("Serialización completa!", MsgBoxStyle.Information)

        Catch e As Exception
            MsgBox("Serialización con errores! " + vbNewLine + e.Message, MsgBoxStyle.Critical)

        End Try


    End Sub


End Class
