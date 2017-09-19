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

        Dim nuevoPermisos = New PermisosBussines

        dgvPermisosFaltantes.DataSource = Nothing
        dgvPermisosFaltantes.DataSource = nuevoPermisos.listarPermisos()

    End Sub
End Class