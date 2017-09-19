Imports BLL
Public Class FormBitacora
    Private Sub FormBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub

    Sub llenarGrilla()
        Dim bitacora = New BitacoraBussines

        dgvEventos.DataSource = Nothing
        dgvEventos.DataSource = bitacora.listarEventos()


        dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

End Class