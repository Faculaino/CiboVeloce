Imports EE
Imports BLL
Imports MetroFramework

Public Class FormNuevoUsuario


    Private Sub btnVerContraseña_Click(sender As Object, e As EventArgs) Handles btnVerContraseña.Click

        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        ElseIf txtPassword.PasswordChar = vbNullChar Then
            txtPassword.PasswordChar = "*"
        End If


    End Sub

    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click

        Try
            Dim oUsuario As New UsuarioEntity

            oUsuario.Nombre = txtNombre.Text
            oUsuario.Password = txtPassword.Text
            oUsuario.User = txtUserName.Text
            oUsuario.Activo = 1
            oUsuario.DVV = txtNombre.Text.Length + txtUserName.Text.Length

            Dim nuevoUsuario = New UsuarioBussines
            Dim lista As New List(Of UsuarioEntity)

            lista = nuevoUsuario.listarUsuarios
            Dim nuevoDVH As Integer = 0
            For Each user In lista
                nuevoDVH += user.DVV
            Next




            oUsuario.DVH = nuevoDVH + oUsuario.DVV
            oUsuario.IDPerfil = 4 'Usuario Comun

            Dim oUsuarioBLL As New UsuarioBussines
            oUsuarioBLL.insertUsuario(oUsuario)
            oUsuarioBLL.updateUsuarios(oUsuario.DVH)

            MetroMessageBox.Show(Me, "Se dió de alta correctamente al Usuario", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Question)

            'Dim nuevaBitacora = New BitacoraBussines
            'nuevaBitacora.guardarEvento("Alta", oUsuario)

            limpiarCampos()
            Me.Close()
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Hubo un error al dar de alta al Usuario. Por favor, inténtelo más tarde", "Error al Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Sub limpiarCampos()
        txtNombre.Text = ""
        txtPassword.Text = ""
        txtUserName.Text = ""
    End Sub


End Class