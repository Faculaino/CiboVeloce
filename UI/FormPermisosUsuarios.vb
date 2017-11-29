Imports BLL
Imports EE
Public Class FormPermisosUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
        llenarGrilla()
        clearFields()
    End Sub

    Sub clearFields()
        tvPermisos.Nodes.Clear()
    End Sub

    Sub llenarTreeViewCompleto()

        Dim PerfilB = New PerfilBussines
        Dim contador = 0

        For Each nodo In PerfilB.listarPerfiles()
            Dim permiso = nodo.listaPermisos
            Dim NodoPerfil As New TreeNode(nodo.descripcion)
            NodoPerfil.Tag = nodo.ID
            tvPermisos.Nodes.Add(NodoPerfil)

            For Each per In permiso
                Dim NodoPermiso As New TreeNode(per.descripcion)
                NodoPermiso.Tag = per.ID
                tvPermisos.Nodes(contador).Nodes.Add(NodoPermiso)

            Next
            contador += 1

        Next
    End Sub


    Sub llenarCombo()
        Dim userBussines = New UsuarioBussines
        Dim listaPerfiles = New PerfilBussines

        cmbUsuario.DataSource = Nothing
        cmbUsuario.DataSource = userBussines.listarUsuarios

        cmbUsuario.DisplayMember = "User"
        cmbUsuario.ValueMember = "ID"
        cmbUsuario.SelectedIndex = -1


        cmbPerfiles.DataSource = Nothing
        cmbPerfiles.DataSource = listaPerfiles.listarPerfiles()

        cmbPerfiles.DisplayMember = "Descripcion"
        cmbPerfiles.ValueMember = "ID"
        cmbPerfiles.SelectedIndex = -1

    End Sub


    Sub llenarGrilla()

        'Dim nuevoPermisos = New PermisosBussines

        'dgvPermisosFaltantes.DataSource = Nothing
        'dgvPermisosFaltantes.DataSource = nuevoPermisos.listarPermisos

        'dgvPermisosFaltantes.Columns("ID").Visible = False
        'dgvPermisosFaltantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Dim ancho = dgvPermisosFaltantes.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        'dgvPermisosFaltantes.Width = ancho + 20

    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged

        Dim perfilB = New PerfilBussines
        Dim permisosB = New PermisosBussines
        Dim perfil = perfilB.buscarPerfil(cmbUsuario.SelectedItem)
        Dim lista = New List(Of PermisoEntity)
        lblPerfil.Text = perfil
        tvPermisos.Nodes.Clear()
        If cmbUsuario.SelectedItem Is Nothing Then

        Else
            lista = permisosB.buscarPermisos(cmbUsuario.SelectedItem)

            For Each nodo In lista
                Dim NodoPerfil As New TreeNode(nodo.descripcion)
                NodoPerfil.Tag = nodo.ID
                tvPermisos.Nodes.Add(NodoPerfil)
            Next
        End If








    End Sub

    Private Sub btnAgregarPermiso_Click(sender As Object, e As EventArgs) Handles btnAgregarPermiso.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnQuitarPermiso_Click(sender As Object, e As EventArgs) Handles btnQuitarPermiso.Click

    End Sub

    Private Sub btnElegirPerfil_Click(sender As Object, e As EventArgs) Handles btnElegirPerfil.Click
        Dim nuevoPerfil = New PerfilBussines
        Try
            nuevoPerfil.cambiarPerfil(cmbPerfiles.SelectedValue, cmbUsuario.SelectedValue)
            lblPerfil.Text = ""
            cmbUsuario.SelectedIndex = -1
            cmbPerfiles.SelectedIndex = -1
            tvPermisos.Nodes.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class