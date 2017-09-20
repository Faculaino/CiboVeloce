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



    Function listarPalabras(ByVal query As String, id As Integer) As List(Of TraduccionEntity)


        Dim nuevaLista = New List(Of TraduccionEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IDIdioma", id)

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim newTraduccion = New TraduccionEntity()
                newTraduccion.ID = reader(0)
                newTraduccion.IDPalabra = reader(1)
                newTraduccion.IDIdioma = reader(2)
                newTraduccion.PalabraTraducida = reader(3)
                nuevaLista.Add(newTraduccion)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Function buscarIdiomaID(id As Integer, query As String) As IdiomaEntity
        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", id)
            Dim nuevoIdioma = New IdiomaEntity()
            Dim reader = cmd.ExecuteReader
            While reader.Read
                nuevoIdioma.ID = reader(0)
                nuevoIdioma.idioma = reader(1)

            End While
            Return nuevoIdioma

        Catch ex As Exception
            Return Nothing
        End Try

    End Function










End Class
