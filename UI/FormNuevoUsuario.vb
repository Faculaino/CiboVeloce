Imports EE
Imports BLL
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
            oUsuario.DVV = 10
            oUsuario.DVH = 10

            Dim oUsuarioBLL As New UsuarioBussines
            oUsuarioBLL.insertUsuario(oUsuario)

            MsgBox("Usuario creado con exito!")
            limpiarCampos()
            Me.Close()
        Catch ex As Exception
            MsgBox("Hubo un error al Crear el Usuari0, inténtelo más tarde!")
        End Try



    End Sub

    Sub limpiarCampos()
        txtNombre.Text = ""
        txtPassword.Text = ""
        txtUserName.Text = ""
    End Sub


End Class