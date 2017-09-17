Imports System.Data.SqlClient
Imports EE
Public Class IdiomasDAL
    Inherits Connection


    Function listaIdiomas(ByVal query As String) As List(Of IdiomaEntity)
        Dim nuevaLista = New List(Of IdiomaEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim newIdioma = New IdiomaEntity()
                newIdioma.ID = reader(0)
                newIdioma.idioma = reader(1)
                nuevaLista.Add(newIdioma)
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
