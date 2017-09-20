Imports System.Data.SqlClient
Imports EE
Public Class PerfilDAL
    Inherits Connection


    Function perfilUsuario(query As String, id As Integer) As PerfilEntity

        Dim nuevoPerfil = New PerfilEntity

        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", id)


            Dim reader = cmd.ExecuteReader
            While reader.Read
                nuevoPerfil.descripcion = reader(0)
            End While
            reader.Close()


            CloseBD()

            Return nuevoPerfil
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
