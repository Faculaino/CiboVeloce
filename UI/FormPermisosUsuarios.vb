Imports BLL
Imports EE
Public Class FormPermisosUsuarios

    Private bandera = True

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
        llenarGrilla()
        clearFields()
    End Sub

    Sub clearFields()
        lbPermisos.Items.Clear()
        lbPermisosFaltantes.Items.Clear()
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
        Dim listaTemp = New List(Of PermisoEntity)
        Dim listaFaltante = New List(Of PermisoEntity)
        lblPerfil.Text = perfil
        lbPermisos.Items.Clear()
        lbPermisosFaltantes.Items.Clear()
        Dim nuevoUsuario = New UsuarioBussines
        Dim usuarioOK = New UsuarioEntity

        Try
            usuarioOK = nuevoUsuario.buscarUserID(CInt(cmbUsuario.SelectedValue.ToString()))
        Catch ex As Exception

        End Try



        If cmbUsuario.SelectedItem Is Nothing Then

        Else

            lista = permisosB.buscarPermisos(usuarioOK)
            listaTemp = permisosB.listarPermisos()

            For Each item As PermisoEntity In lista
                lbPermisos.Items.Add(item.descripcion)
            Next

            For Each item As PermisoEntity In listaTemp
                If lbPermisos.Items.Contains(item.descripcion) Then
                Else
                    lbPermisosFaltantes.Items.Add(item.descripcion)
                End If

            Next

            For Each item As PermisoEntity In listaFaltante
                lbPermisosFaltantes.Items.Add(item.descripcion)
            Next

            'lista = permisosB.buscarPermisos(cmbUsuario.SelectedItem)

            'For Each nodo In lista
            '    Dim NodoPerfil As New TreeNode(nodo.descripcion)
            '    NodoPerfil.Tag = nodo.ID
            '    tvPermisos.Nodes.Add(NodoPerfil)
            'Next
            bandera = False
        End If

    End Sub

    Private Sub btnAgregarPermiso_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim listaPermisos = New List(Of PermisoEntity)

        For Each item In lbPermisos.Items
            Dim nuevoPermiso = New PermisoEntity
            Dim permisoB = New PermisosBussines
            nuevoPermiso = permisoB.buscarPermisoName(item)

            listaPermisos.Add(nuevoPermiso)
        Next

        Dim nuevoNamePerfil As String = ""
        Dim user = New UsuarioEntity
        user = cmbUsuario.SelectedItem
        nuevoNamePerfil = lblPerfil.Text + "-" + user.User.ToString()


        Dim nuevoPerfil = New PerfilBussines
        nuevoPerfil.nuevo(nuevoNamePerfil)

        Dim buscaPerfil = New PerfilBussines
        Dim id As Integer = 0
        id = buscaPerfil.buscarIDPerfil(nuevoNamePerfil)

        Dim nuevosPermisos = New PermisosBussines
        nuevosPermisos.insertPermisos(listaPermisos, id)

        Dim nuevPer = New UsuarioBussines
        nuevPer.modificarPerfil(user.ID, id)

    End Sub


    Private Sub btnQuitarPermiso_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnElegirPerfil_Click(sender As Object, e As EventArgs) Handles btnElegirPerfil.Click
        Dim nuevoPerfil = New PerfilBussines
        Try
            nuevoPerfil.cambiarPerfil(cmbPerfiles.SelectedValue, cmbUsuario.SelectedValue)
            lblPerfil.Text = ""
            cmbUsuario.SelectedIndex = -1
            cmbPerfiles.SelectedIndex = -1
            lbPermisos.Items.Clear()
            lbPermisosFaltantes.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            Dim permiso = lbPermisos.SelectedItem.ToString()
            lbPermisosFaltantes.Items.Add(permiso)
            lbPermisos.Items.Remove(lbPermisos.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim permiso = lbPermisosFaltantes.SelectedItem.ToString()
            lbPermisos.Items.Add(permiso)
            lbPermisosFaltantes.Items.Remove(lbPermisosFaltantes.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub
End Class