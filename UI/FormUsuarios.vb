Imports BLL
Public Class FormUsuarios
    Private Sub btnPermisosUsuarios_Click(sender As Object, e As EventArgs) Handles btnPermisosUsuarios.Click
        Dim nuevoPermisos = New FormPermisosUsuarios
        nuevoPermisos.StartPosition = FormStartPosition.CenterScreen
        nuevoPermisos.Show()
    End Sub

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub

    Sub llenarGrilla()
        Dim userBussines = New UsuarioBussines

        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = userBussines.listarUsuarios()

        dgvUsuarios.Columns("Password").Visible = False
        dgvUsuarios.Columns("DVV").Visible = False
        dgvUsuarios.Columns("DVH").Visible = False
        dgvUsuarios.Columns("IDPerfil").Visible = False




    End Sub

    Private Sub btnAltaUsuario_Click(sender As Object, e As EventArgs) Handles btnAltaUsuario.Click
        Dim nuevoUsuario = New FormNuevoUsuario
        nuevoUsuario.StartPosition = FormStartPosition.CenterScreen
        nuevoUsuario.Show()
    End Sub
End Class