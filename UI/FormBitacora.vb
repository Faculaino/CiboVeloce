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
        formatoGrilla()

    End Sub

    Sub formatoGrilla()
        Dim cuenta As Integer = 0
        For Each c In dgvEventos.Columns
            cuenta += c.width

        Next

        dgvEventos.Width = cuenta + 25
        Me.Width = dgvEventos.Width + 50

    End Sub

End Class