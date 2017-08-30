﻿Imports Servicios
Public Class FormPrincipal
    Property menuUsuario As Integer = 0

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatoVista()
    End Sub

    Sub formatoVista()
        linkUsuario.Text = "Usuario: " + SessionManager.Instance.Usuario.User
        linkUsuario.Location = New Point(Me.Width - 160, 6)
    End Sub


    Private Sub linkUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUsuario.LinkClicked
        Dim oCerrar = New FormLogout()
        If menuUsuario = 0 Then
            oCerrar.Show()
            oCerrar.Text = SessionManager.Instance.Usuario.User
            oCerrar.Location = New Point(Me.Width - 230, 50)
            menuUsuario = 1
        ElseIf menuUsuario = 1 Then
            oCerrar.Close()
            menuUsuario = 0
            oCerrar = Nothing
        End If


    End Sub
End Class