Imports Servicios
Public Class FormLogout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SessionManager.Instance.Logout()
        Application.Restart()
    End Sub
End Class