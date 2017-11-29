Public Class FormCargaMapa
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        metroProgress.Increment(5)
        If metroProgress.Value = 20 Then
            lblTexto.Text = "Iniciando Busqueda"
        ElseIf metroProgress.Value = 50 Then
            lblTexto.Text = "Buscando Direccion"
        ElseIf metroProgress.Value = 70 Then
            lblTexto.Text = "Geolocalización"
        End If

        If metroProgress.Value = metroProgress.Maximum Then
            Timer.Stop()
            lblTexto.Text = ""
            metroProgress.Visible = False
            Me.Close()
        End If

    End Sub

    Private Sub FormCargaMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub
End Class