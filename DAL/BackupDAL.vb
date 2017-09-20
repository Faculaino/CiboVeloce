Imports System.Data.SqlClient

Public Class BackupDAL
    Inherits Connection


    'Function backupDatos(ByVal Query As String) As Boolean
    '    OpenBD()

    '    Dim Tx As SqlTransaction
    '    Tx = cnn.BeginTransaction()

    '    Try
    '        cmd = New SqlCommand
    '        cmd.Connection = cnn
    '        cmd.CommandText = Query
    '        cmd.CommandType = CommandType.Text

    '        cmd.Transaction = Tx

    '        cmd.ExecuteNonQuery()
    '        Tx.Commit()
    '        CloseBD()
    '        Return True

    '    Catch ex As SqlException
    '        Tx.Rollback()
    '        MsgBox(ex.Message)
    '        Return False
    '    Catch ex As Exception
    '        Tx.Rollback()
    '        Return False
    '    End Try

    'End Function

    Function backupDatos(ByVal Query As String, ubicacion As String) As Boolean
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = Query
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", ubicacion)

            cmd.Transaction = Tx

            cmd.ExecuteNonQuery()
            Tx.Commit()
            CloseBD()
            Return True

        Catch ex As SqlException
            Tx.Rollback()
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            Tx.Rollback()
            Return False
        End Try

    End Function

End Class
