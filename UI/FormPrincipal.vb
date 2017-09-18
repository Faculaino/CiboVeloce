Imports Servicios
Public Class FormPrincipal


    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatoVista()

        Dim newAdministrar = New FormAdministrador
        newAdministrar.MdiParent = Me
        newAdministrar.WindowState = FormWindowState.Maximized
        newAdministrar.Show()
    End Sub

    Sub formatoVista()
        ubicarUsuario()
    End Sub

    Sub ubicarUsuario()
        panelNombre.Width = Me.Width
        panelNombre.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height - 65)

        lblUsuario.Text = "Usuario: " + SessionManager.Instance.Usuario.User
    End Sub

    Private Sub SeleccionarIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ubicarUsuario()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SessionManager.Instance.Logout()
        Application.Restart()
    End Sub

    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        Dim frmBK = New FormAdministrador
        frmBK.MdiParent = Me
        frmBK.WindowState = FormWindowState.Maximized
        frmBK.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class