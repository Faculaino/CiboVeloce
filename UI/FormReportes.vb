Imports BLL
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormReportes



    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function corrigePath(location As String) As String
        Dim index As Integer
        Dim path As String
        index = location.IndexOf("bin")
        If index > 0 Then
            path = location.Remove(index, 10)
        Else
            path = location
        End If
        Return path
    End Function


    Sub generaReporte()
        Dim reporteBussines = New ReporteBussines
        Dim ds = New DataSet
        Dim tipo = cmbTipoReportes.Text
        Dim repor = New ReportDocument()
        Dim location = AppDomain.CurrentDomain.BaseDirectory
        Dim path As String

        If tipo = "Ventas" Then
            location = location + "Reportes\ReportePedidos.rpt"
        ElseIf tipo = "Movimiento Caja" Then
            location = location + "Reportes\ReporteCaja.rpt"
        End If

        path = corrigePath(location)

        Try
            repor.Load(path)
        Catch ex As Exception
            MsgBox("Error al leer el Reporte")
            Exit Sub
        End Try

        ds = reporteBussines.generarReporte(dtFecha1.Value, dtFecha2.Value, tipo)

        repor.SetDataSource(ds.Tables(0))

        crReportes.ReportSource = repor
        crReportes.Refresh()


        repor.Close()

    End Sub

    Private Sub crReportes_Load(sender As Object, e As EventArgs) Handles crReportes.Load

    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        generaReporte()
    End Sub

    Private Sub btnNuevoReporte_Click(sender As Object, e As EventArgs) Handles btnNuevoReporte.Click
        crReportes.ReportSource = Nothing
        crReportes.Refresh()

        cmbTipoReportes.Text = ""

        dtFecha1.ResetText()
        dtFecha2.ResetText()



    End Sub
End Class