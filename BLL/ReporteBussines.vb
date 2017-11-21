Imports DAL
Public Class ReporteBussines



    Function generarReporte(fecha1 As DateTime, fecha2 As DateTime, tipo As String) As DataSet
        Dim nuevoReporte = New ReportesDAL
        Dim ds = New DataSet

        If tipo = "Ventas" Then
            ds = nuevoReporte.reportePedidos(fecha1, fecha2)
        End If

        Return ds
    End Function




End Class
