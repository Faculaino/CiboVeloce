Imports DAL
Public Class ReporteBussines



    Function generarReporte(fecha1 As DateTime, fecha2 As DateTime, tipo As String) As DataSet
        Dim nuevoReporte = New ReportesDAL
        Dim ds = New DataSet
        ds.Reset()

        If tipo = "Ventas" Then
            ds = nuevoReporte.reportePedidos(fecha1, fecha2)
        ElseIf tipo = "Movimiento Caja" Then
            ds = nuevoReporte.reporteCaja(fecha1, fecha2)
        ElseIf tipo = "Compras" Then
            ds = nuevoReporte.reporteCompras(fecha1, fecha2)
        End If

        Return ds
    End Function




End Class
