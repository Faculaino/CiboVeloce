Imports System.Data.SqlClient
Imports EE
Public Class ComidaDAL
    Inherits Connection

    Public Function listarComidas() As List(Of ComidaEntity)
        Dim nuevaLista = New List(Of ComidaEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Comidas"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaComida = New ComidaEntity()
                nuevaComida.ID = reader(0)
                nuevaComida.detalle = reader(1)
                nuevaLista.Add(nuevaComida)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try




    End Function
End Class
