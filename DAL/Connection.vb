Imports System.Data
Imports System.Data.SqlClient

Public Class Connection

    Public cnn As SqlConnection
    Public cmd As SqlCommand

    Sub OpenBD()
        Try

            cnn = New SqlConnection("Data Source=.\SQL_UAI;Initial Catalog=CiboVeloce;Integrated Security=True")
            cnn.Open()

        Catch ex As SqlException
            MsgBox("Error al conectarse a la BD ", ex.Message)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Sub CloseBD()
        Try
            cnn.Close()
            cnn = Nothing
        Catch ex As SqlException
            MsgBox(ex)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub









End Class
