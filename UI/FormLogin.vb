Imports EE
Imports BLL
Imports System.Text
Imports System.Security.Cryptography
Imports Servicios

Public Class FormLogin


    Private Sub lnkNuevoUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNuevoUsuario.LinkClicked
        Dim oNuevoUsuario As New FormNuevoUsuario
        oNuevoUsuario.StartPosition = FormStartPosition.CenterScreen
        oNuevoUsuario.Show()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiarCampos()
        txtUsername.Select()

    End Sub

    Sub limpiarCampos()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub


    Function validarCampos(ByVal Usuario As String, ByVal Contraseña As String) As Boolean
        If (Usuario = "" And Contraseña = "") Then
            MsgBox("Favor de completar los campos")
            Return False
        ElseIf (Usuario = "" And Contraseña <> "") Then
            MsgBox("Falta completar el campo Usuario")
            Return False
        ElseIf (Usuario <> "" And Contraseña = "") Then
            MsgBox("Falta completar el campo Contraseña")
            Return False
        End If
        Return True
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim usuarioOK = New UsuarioEntity
        Dim encriptar = New CryptoManager

        If (validarCampos(txtUsername.Text.Trim(), txtPassword.Text.Trim())) Then
            Try

                Dim PasswordHash() As Byte = encriptar.hashearPassword(txtPassword.Text)
                Dim oUsuario = New UsuarioEntity


                oUsuario.User = txtUsername.Text
                oUsuario.Password = txtPassword.Text



                Dim oUsuarioBussines = New UsuarioBussines
                usuarioOK = oUsuarioBussines.buscarUsuario(oUsuario)

                If usuarioOK.User = txtUsername.Text Then
                    If PasswordHash.Length = usuarioOK.Password.Length Then
                        MsgBox("Bienvenido " + usuarioOK.User, MsgBoxStyle.Information, "Login Correcto!")

                        SessionManager.Instance.Login(usuarioOK)

                        Dim oPrincipal = New FormPrincipal
                        oPrincipal.Show()

                        Me.Close()
                    End If

                Else
                    MsgBox("Error al Iniciar Sesión", MsgBoxStyle.Critical, "Usuario o Contraseña Incorrecto")
                    limpiarCampos()
                End If


            Catch ex As Exception

            End Try

        Else

        End If


    End Sub
End Class
