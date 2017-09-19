Imports System.Data.SqlClient
Imports EE
Public Class PermisoDAL
    Inherits Connection




    Function listarPermisos(ByVal query As String) As List(Of PermisoEntity)
        Dim nuevaLista = New List(Of PermisoEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoPermiso = New PermisoEntity()


                nuevaLista.Add(nuevoPermiso)
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
