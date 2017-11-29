Imports EE
Imports BLL
Imports System.Text
Imports System.Security.Cryptography
Imports Servicios
Imports MetroFramework
Imports System.IO
Imports System.Data.Sql
Imports System.Management

Public Class FormLogin



    Private Sub lnkNuevoUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Dim oNuevoUsuario As New FormNuevoUsuario
        'oNuevoUsuario.StartPosition = FormStartPosition.CenterScreen
        'oNuevoUsuario.Show()
    End Sub

    Sub SQLInstalado()
        Dim servidores As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
        Dim tablaServidores As DataTable = servidores.GetDataSources()

        For Each row As DataRow In tablaServidores.Rows

            Dim instanceName As String = Convert.ToString(row("InstanceName"))
            Dim serverName As String = Convert.ToString(row("ServerName"))

            If (instanceName = String.Empty) Then
                ' Instancia predeterminada
                cmbInstancias.Items.Add(serverName)

            Else
                ' Instancias con nombre
                cmbInstancias.Items.Add(String.Format("{0}\{1}", serverName, instanceName))

            End If

        Next
    End Sub


    Sub verBD()
        If Directory.Exists("C:\BackupSQL\") Then

        Else
            My.Computer.FileSystem.CreateDirectory("C:\BackupSQL\")
            'Dim path = "C:\Usuarios\" + SystemInformation.UserName + "\Escritorio\CiboVeloce.bak"
            'Dim path2 = "C:\Users\" + SystemInformation.UserName + "\Desktop\CiboVeloce.bak"
            My.Computer.FileSystem.CopyFile("", "C:\BackupSQL12\CiboVeloce.bak")

        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'verBD()
        limpiarCampos()
        txtUsername.Select()

        'txtUsername.Text = "Facu"
        'txtPassword.Text = "1234"


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


    Private Sub codeLogin()
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
                        'MetroMessageBox.Show(Me, "Bienvenido " & usuarioOK.User, "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.Question)

                        SessionManager.Instance.Login(usuarioOK)


                        Dim nuevaBitacora = New BitacoraBussines
                        nuevaBitacora.guardarEvento("Login", usuarioOK)

                        Dim oPrincipal = New FormPrincipal
                        oPrincipal.Show()

                        Me.Close()
                    End If

                Else
                    'MsgBox("Error al Iniciar Sesión", MsgBoxStyle.Critical, "Usuario o Contraseña Incorrecto")
                    'MetroMessageBox.Show(Me, "Usuario o Contraseña Incorrecto", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarCampos()
                End If


            Catch ex As Exception

            End Try

        Else

        End If
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        codeLogin()
    End Sub

    Private Sub lnkNuevoUsuario_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNuevoUsuario.LinkClicked
        Dim oNuevoUsuario As New FormNuevoUsuario
        oNuevoUsuario.StartPosition = FormStartPosition.CenterScreen
        oNuevoUsuario.Show()
    End Sub

    Private Sub btnLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnLogin.KeyPress

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            codeLogin()
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            codeLogin()
        End If
    End Sub

    Private Sub btnSQL_Click(sender As Object, e As EventArgs) Handles btnSQL.Click
        Dim original = New Point(333, 366)
        If btnSQL.Text = "->" Then
            Width = Width + 300
            btnSQL.Text = "<-"
        Else
            btnSQL.Text = "->"
            Size = original
            StartPosition = FormStartPosition.CenterParent
        End If


    End Sub

    Private Sub btnVerInstancias_Click(sender As Object, e As EventArgs) Handles btnVerInstancias.Click
        SQLInstalado()
        TimerProgress.Start()
        If cmbInstancias.Items.Count <= 0 Then
            btnInstalarSQL.Visible = True
        End If
    End Sub

    Private Sub TimerProgress_Tick(sender As Object, e As EventArgs) Handles TimerProgress.Tick
        progressBar.Increment(10)

        If progressBar.Value = 50 Then
            lblMensajeProgress.Text = "Buscando Instancias de SQL"
        ElseIf progressBar.Value = 80 Then
            lblMensajeProgress.Text = "...finalizando"
        End If
        If progressBar.Value = progressBar.Maximum Then
            TimerProgress.Stop()
            lblMensajeProgress.Text = "Listo!"
        End If
        lblMensajeProgress.Text = ""
    End Sub

    Private Sub btnInstalarSQL_Click(sender As Object, e As EventArgs) Handles btnInstalarSQL.Click
        Dim OS As String = ""
        OS = getVersionOS()

        If OS = "64 bits" Then
            'Ver la manera de ejecutar esto por CMD y transportar el Instalador

            'SQLEXPR_x64_ESN /x
            'Setup.exe /q /Action=Install /features=sql,tools /IACCEPTSQLSERVERLICENSETERMS /InstanceName=SQLExpress
            'C:\Setup.exe /ConfigurationFile="C:\ConfigurationFile.ini"
        ElseIf OS = "32 bits" Then

            'Ver la manera de ejecutar esto por CMD y transportar el Instalador

            'SQLEXPR_x86_ESN /x
            'Setup.exe /q /Action=Install /features=sql,tools /IACCEPTSQLSERVERLICENSETERMS /InstanceName=SQLExpress
            'C:\Setup.exe /ConfigurationFile="C:\ConfigurationFile.ini"
        End If

        Dim original = New Point(333, 366)

    End Sub


    Public Function getVersionOS() As String
        Dim osClass As ManagementClass = Nothing
        Dim result As String = "32-bit"
        Try
            osClass = New ManagementClass("Win32_OperatingSystem")
            For Each mgo As ManagementObject In osClass.GetInstances
                For Each prop As PropertyData In mgo.Properties
                    If prop.Name = "OSArchitecture" Then
                        result = prop.Value.ToString
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            result = String.Empty
        Finally
            If osClass IsNot Nothing Then osClass.Dispose()
        End Try
        Return result
    End Function

End Class
