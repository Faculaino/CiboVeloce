Imports BLL
Imports EE
Public Class FormPermisosUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
        llenarGrilla()
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
        dgvPermisosFaltantes.DataSource = nuevoPermisos.listarPermisos

        dgvPermisosFaltantes.Columns("ID").Visible = False
        dgvPermisosFaltantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim ancho = dgvPermisosFaltantes.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        dgvPermisosFaltantes.Width = ancho + 20

    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged

        'No Funciona
        'If cmbUsuario.SelectedItem.ToString() = "" Then

        'Else
        '    Dim nuevoPerfil = New PerfilBussines
        '    Dim perfilEE = New PerfilEntity
        '    perfilEE = nuevoPerfil.perfilUsuario(cmbUsuario.SelectedValue)

        '    lblPerfil.Text = perfilEE.descripcion

        'End If

    End Sub
End Class