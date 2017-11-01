Imports System.Data.SqlClient

Public Class DVVDAL
    Inherits Connection

    Public Sub actualiarDVV(tabla As String, valor As Integer)

        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Update_DVV"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@valor", valor)
            cmd.Parameters.AddWithValue("@tabla", tabla)

            cmd.Transaction = Tx

            cmd.ExecuteNonQuery()
            Tx.Commit()
            CloseBD()

        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try

    End Sub


    Function buscarValor(tabla As String) As Integer


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_DVV"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@tabla", tabla)


            Dim reader = cmd.ExecuteReader
            Dim valor As Integer
            While reader.Read
                valor = reader(0)
            End While
            reader.Close()


            CloseBD()

            Return valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function



End Class
