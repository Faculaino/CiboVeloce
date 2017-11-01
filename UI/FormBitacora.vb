Imports BLL
Imports EE
Public Class FormBitacora
    Private Sub FormBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub

    Sub llenarGrilla()
        Dim bitacora = New BitacoraBussines
        Dim lista = New List(Of BitacoraEntity)
        lista = bitacora.listarEventos()

        dgvEventos.DataSource = Nothing

        For Each item As BitacoraEntity In lista
            dgvEventos.Rows.Add(item.fechahora, item.usuario, item.mensaje)
        Next


    End Sub



End Class