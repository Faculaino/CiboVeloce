Imports System.Data.SqlClient

Public Class BaseDeDatosDAL
    Inherits Connection

    Function backupDatos() As Boolean
        OpenBD()

        Dim archivo = Date.Now.Year.ToString() & "-" & Date.Now.Month.ToString() & "-" & Date.Now.Day.ToString() & "@" & "CiboVeloce.bak"
        Dim ubicacion = "C:\BackupSQL\" & archivo
        Dim SP = "SP_BackupSQL"

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = SP
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", ubicacion)


            cmd.ExecuteNonQuery()

            CloseBD()
            Return True

        Catch ex As SqlException
            Return False
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function restoreBD(ByVal archivo As String) As Boolean
        OpenBD()
        Dim query = "RESTORE DATABASE CiboVeloce 
                    FROM DISK = 'C:\BackupSQL\" & archivo & "';"

        'deleteDataBase()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            CloseBD()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Sub deleteDataBase()

        Dim query = "DROP DATABASE CiboVeloce;"
        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()


        Catch ex As Exception

        End Try
    End Sub


End Class
