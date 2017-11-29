Imports System.Data.SqlClient
Imports System.Globalization

Public Class ReportesDAL
    Inherits Connection



    Function reportePedidos(fecha1 As DateTime, fecha2 As DateTime) As DataSet

        Dim ds = New DataSet
        Dim da = New SqlDataAdapter
        OpenBD()

        Dim Fecha1Convert As String = fecha1.ToString("yyyy-MM-dd")
        Dim Fecha2Convert As String = fecha2.ToString("yyyy-MM-dd")

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ReportePedidos"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Fecha1", fecha1)
            cmd.Parameters.AddWithValue("@Fecha2", fecha2)
            da.SelectCommand = cmd

            da.Fill(ds)

            cmd.ExecuteNonQuery()

            CloseBD()

            Return ds

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Function reporteCompras(fecha1 As DateTime, fecha2 As DateTime) As DataSet

        Dim ds = New DataSet
        Dim da = New SqlDataAdapter
        OpenBD()

        Dim Fecha1Convert As String = fecha1.ToString("yyyy-MM-dd")
        Dim Fecha2Convert As String = fecha2.ToString("yyyy-MM-dd")

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ReporteCompras"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Fecha1", fecha1)
            cmd.Parameters.AddWithValue("@Fecha2", fecha2)
            da.SelectCommand = cmd

            da.Fill(ds)

            cmd.ExecuteNonQuery()

            CloseBD()

            Return ds

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Function reporteCaja(fecha1 As DateTime, fecha2 As DateTime) As DataSet

        Dim ds = New DataSet
        Dim da = New SqlDataAdapter
        OpenBD()

        Dim Fecha1Convert As String = fecha1.ToString("yyyy-MM-dd")
        Dim Fecha2Convert As String = fecha2.ToString("yyyy-MM-dd")

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ReporteCaja"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Fecha1", fecha1)
            cmd.Parameters.AddWithValue("@Fecha2", fecha2)
            da.SelectCommand = cmd

            da.Fill(ds)

            cmd.ExecuteNonQuery()

            CloseBD()

            Return ds

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function














End Class
