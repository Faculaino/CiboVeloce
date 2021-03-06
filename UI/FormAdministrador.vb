﻿Imports MetroFramework
Imports BLL
Imports Servicios
Imports System.Globalization
Imports EE

Public Class FormAdministrador


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.StartPosition = FormStartPosition.CenterScreen
        frmUsuarios.Show()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim nuevoDatos = New FormBaseDeDatos
        nuevoDatos.StartPosition = FormStartPosition.CenterScreen
        nuevoDatos.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim nuevaBitacora = New BitacoraBussines
        nuevaBitacora.guardarEvento("Logout", SessionManager.Instance.Usuario)

        Me.Close()

        SessionManager.Instance.Logout()
        Application.Restart()
    End Sub

    Private Sub btnBitacora_Click(sender As Object, e As EventArgs) Handles btnBitacora.Click
        Dim frmbitacora = New FormBitacora
        frmbitacora.StartPosition = FormStartPosition.CenterScreen
        frmbitacora.Show()
    End Sub

    Private Sub btnIdioma_Click(sender As Object, e As EventArgs) Handles btnIdioma.Click
        Dim frmIdioma = New FormIdioma
        frmIdioma.StartPosition = FormStartPosition.CenterScreen
        frmIdioma.Show()
    End Sub

    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarIdioma()
    End Sub

    Sub cambiarIdioma()
        Dim traducir As New TraduccionBussines
        Dim idioma = New TraduccionEntity

        Dim ht As New Hashtable
        ht = traducir.palabrasTraducidas(SessionManager.Instance.Usuario.IDIdioma)

        For Each control As Control In Me.Controls
            If control.Tag Is Nothing Then
            Else
                For Each item As DictionaryEntry In ht
                    If control.Tag.Equals(item.Key) Then
                        control.Text = item.Value
                        Exit For
                    End If
                Next
            End If

        Next

        'Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
        'Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
        'Threading.Thread.CurrentThread.CurrentCulture = culturaObj

    End Sub


    Sub administrador()
        btnUsuarios.Enabled = True
        btnClientes.Enabled = True
        btnBackup.Enabled = True
        btnIdioma.Enabled = True
        btnBitacora.Enabled = True
        btnCompras.Enabled = True
        btnPedidos.Enabled = True
        btnAdminComida.Enabled = True
        btnCaja.Enabled = True
        btnPedidosHistorial.Enabled = True
        btnReportes.Enabled = True
    End Sub

    Sub responsableCocina()
        btnUsuarios.Enabled = False
        btnClientes.Enabled = False
        btnBackup.Enabled = False
        btnIdioma.Enabled = False
        btnBitacora.Enabled = False
        btnCompras.Enabled = False
        btnPedidos.Enabled = True
        btnAdminComida.Enabled = True
        btnCaja.Enabled = False
        btnPedidosHistorial.Enabled = True
        btnReportes.Enabled = False
    End Sub

    Private Sub FormAdministrador_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim nuevoPedido = New FormPedidos
        nuevoPedido.StartPosition = FormStartPosition.CenterParent
        nuevoPedido.Show()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim nuevoClientes = New FormClientes
        nuevoClientes.StartPosition = FormStartPosition.CenterParent
        nuevoClientes.Show()
    End Sub

    Private Sub btnAdminComida_Click(sender As Object, e As EventArgs) Handles btnAdminComida.Click
        Dim nuevaComida = New FormAdministracionCarta
        nuevaComida.StartPosition = FormStartPosition.CenterParent
        nuevaComida.Show()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Dim nuevaCaja = New FormCaja
        nuevaCaja.StartPosition = FormStartPosition.CenterParent
        nuevaCaja.Show()
    End Sub

    Private Sub btnPedidosHistorial_Click(sender As Object, e As EventArgs) Handles btnPedidosHistorial.Click
        Dim nuevoHistorial = New FormPedidosHistorial
        nuevoHistorial.StartPosition = FormStartPosition.CenterParent
        nuevoHistorial.Show()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim nuevoReportes = New FormReportes
        nuevoReportes.StartPosition = FormStartPosition.CenterParent
        nuevoReportes.Show()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Dim nuevaCompra = New FormCompras
        nuevaCompra.StartPosition = FormStartPosition.CenterParent
        nuevaCompra.Show()
    End Sub
End Class