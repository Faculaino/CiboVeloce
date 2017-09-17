Imports BLL
Public Class FormPermisosUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
    End Sub


    Sub llenarCombo()
        Dim userBussines = New UsuarioBussines

        cmbUsuario.DataSource = Nothing
        cmbUsuario.DataSource = userBussines.listarUsuarios


        cmbUsuario.DisplayMember = "User"
        cmbUsuario.ValueMember = "ID"
        cmbUsuario.SelectedIndex = -1
    End Sub


    Sub llenarGrilla()

        'Dim usuarioBussines = New UsuarioBussines

        'dgvUsuarios.DataSource = Nothing
        'dgvUsuarios.DataSource = usuarioBussines.listarUsuarios

    End Sub
End Class