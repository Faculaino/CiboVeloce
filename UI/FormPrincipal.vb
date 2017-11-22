Imports Servicios
Public Class FormPrincipal


    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatoVista()

        If SessionManager.Instance.Usuario.IDPerfil = 1 Or SessionManager.Instance.Usuario.IDPerfil = 3 Then
            administrador()
        ElseIf SessionManager.Instance.Usuario.IDPerfil = 2 Then
            cocina()
        End If

    End Sub

    Sub administrador()
        Dim newAdministrar = New FormAdministrador
        newAdministrar.MdiParent = Me
        newAdministrar.WindowState = FormWindowState.Maximized
        newAdministrar.Show()
    End Sub

    Sub cocina()
        Dim newAdministrar = New FormResponsableCocina
        newAdministrar.MdiParent = Me
        'newAdministrar.WindowState = FormWindowState.Maximized
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

        If SessionManager.Instance.Usuario.IDPerfil = 1 Or SessionManager.Instance.Usuario.IDPerfil = 3 Then
            administrador()
        ElseIf SessionManager.Instance.Usuario.IDPerfil = 2 Then
            cocina()
        End If

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class