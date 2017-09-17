Imports Servicios
Public Class FormPrincipal
    'Property menuUsuario As Integer = 0

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


    'Private Sub linkUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    '    Dim oCerrar = New FormLogout()
    '    If menuUsuario = 0 Then
    '        oCerrar.Show()
    '        oCerrar.Text = SessionManager.Instance.Usuario.User
    '        oCerrar.Location = New Point(Me.Width - 230, 50)
    '        menuUsuario = 1
    '    ElseIf menuUsuario = 1 Then
    '        oCerrar.Close()
    '        menuUsuario = 0
    '        oCerrar = Nothing
    '    End If


    'End Sub

    'Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click

    '    Dim frmUsuarios = New FormUsuarios
    '    frmUsuarios.MdiParent = Me
    '    frmUsuarios.StartPosition = FormStartPosition.CenterScreen
    '    frmUsuarios.Show()

    'End Sub

    Private Sub SeleccionarIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ubicarUsuario()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
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