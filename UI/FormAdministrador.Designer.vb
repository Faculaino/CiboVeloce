﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrador
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministrador))
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.Calculator1 = New DevComponents.Editors.Calculator()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnPedidosHistorial = New MetroFramework.Controls.MetroButton()
        Me.btnCaja = New MetroFramework.Controls.MetroButton()
        Me.btnAdminComida = New MetroFramework.Controls.MetroButton()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.btnPedidos = New MetroFramework.Controls.MetroButton()
        Me.btnCompras = New MetroFramework.Controls.MetroButton()
        Me.btnCerrarSesion = New MetroFramework.Controls.MetroButton()
        Me.btnBitacora = New MetroFramework.Controls.MetroButton()
        Me.btnIdioma = New MetroFramework.Controls.MetroButton()
        Me.btnBackup = New MetroFramework.Controls.MetroButton()
        Me.btnClientes = New MetroFramework.Controls.MetroButton()
        Me.btnUsuarios = New MetroFramework.Controls.MetroButton()
        Me.btnReportes = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(13, 63)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(252, 29)
        Me.dtpFecha.TabIndex = 8
        '
        'Calculator1
        '
        Me.Calculator1.AutoSize = True
        Me.Calculator1.Location = New System.Drawing.Point(35, 117)
        Me.Calculator1.Name = "Calculator1"
        Me.Calculator1.Size = New System.Drawing.Size(190, 211)
        Me.Calculator1.Text = "Calculator1"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(955, 489)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(207, 70)
        Me.ReflectionLabel1.TabIndex = 17
        Me.ReflectionLabel1.Text = "<b><font size=""+18""><i>Cibo</i><font color=""#33CCFF"">Veloce</font></font></b>"
        '
        'btnPedidosHistorial
        '
        Me.btnPedidosHistorial.BackgroundImage = Global.UI.My.Resources.Resources.registrosPedidos
        Me.btnPedidosHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPedidosHistorial.Location = New System.Drawing.Point(449, 334)
        Me.btnPedidosHistorial.Name = "btnPedidosHistorial"
        Me.btnPedidosHistorial.Size = New System.Drawing.Size(149, 119)
        Me.btnPedidosHistorial.TabIndex = 23
        Me.btnPedidosHistorial.Tag = "Adm Pedido"
        Me.btnPedidosHistorial.Text = "Adm. de Pedidos"
        Me.btnPedidosHistorial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPedidosHistorial.UseSelectable = True
        '
        'btnCaja
        '
        Me.btnCaja.BackgroundImage = Global.UI.My.Resources.Resources.caja
        Me.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCaja.Location = New System.Drawing.Point(278, 334)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(149, 119)
        Me.btnCaja.TabIndex = 21
        Me.btnCaja.Tag = "Caja"
        Me.btnCaja.Text = "Caja"
        Me.btnCaja.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCaja.UseSelectable = True
        '
        'btnAdminComida
        '
        Me.btnAdminComida.BackgroundImage = Global.UI.My.Resources.Resources.comida
        Me.btnAdminComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdminComida.Location = New System.Drawing.Point(790, 197)
        Me.btnAdminComida.Name = "btnAdminComida"
        Me.btnAdminComida.Size = New System.Drawing.Size(149, 119)
        Me.btnAdminComida.TabIndex = 19
        Me.btnAdminComida.Tag = "Adm Carta"
        Me.btnAdminComida.Text = "Administración de Carta"
        Me.btnAdminComida.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdminComida.UseSelectable = True
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(67, 394)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(128, 128)
        Me.ReflectionImage1.TabIndex = 10
        '
        'btnPedidos
        '
        Me.btnPedidos.BackgroundImage = Global.UI.My.Resources.Resources.pedido
        Me.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPedidos.Location = New System.Drawing.Point(618, 197)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(149, 119)
        Me.btnPedidos.TabIndex = 7
        Me.btnPedidos.Tag = "Nuevo Pedido"
        Me.btnPedidos.Text = "Nuevo Pedido"
        Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPedidos.UseSelectable = True
        '
        'btnCompras
        '
        Me.btnCompras.BackgroundImage = Global.UI.My.Resources.Resources.compra
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompras.Location = New System.Drawing.Point(449, 197)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(149, 119)
        Me.btnCompras.TabIndex = 6
        Me.btnCompras.Tag = "Compras"
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCompras.UseSelectable = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackgroundImage = Global.UI.My.Resources.Resources.sinsesion
        Me.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrarSesion.Location = New System.Drawing.Point(955, 63)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(149, 119)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Tag = ""
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrarSesion.UseSelectable = True
        '
        'btnBitacora
        '
        Me.btnBitacora.BackgroundImage = Global.UI.My.Resources.Resources.bitacora
        Me.btnBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBitacora.Location = New System.Drawing.Point(278, 197)
        Me.btnBitacora.Name = "btnBitacora"
        Me.btnBitacora.Size = New System.Drawing.Size(149, 119)
        Me.btnBitacora.TabIndex = 4
        Me.btnBitacora.Tag = "Bitacora"
        Me.btnBitacora.Text = "Bitacora"
        Me.btnBitacora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBitacora.UseSelectable = True
        '
        'btnIdioma
        '
        Me.btnIdioma.BackgroundImage = Global.UI.My.Resources.Resources.bandera_world
        Me.btnIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIdioma.Location = New System.Drawing.Point(790, 63)
        Me.btnIdioma.Name = "btnIdioma"
        Me.btnIdioma.Size = New System.Drawing.Size(149, 119)
        Me.btnIdioma.TabIndex = 3
        Me.btnIdioma.Tag = ""
        Me.btnIdioma.Text = "Idioma"
        Me.btnIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIdioma.UseSelectable = True
        '
        'btnBackup
        '
        Me.btnBackup.BackgroundImage = Global.UI.My.Resources.Resources.DataBase
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBackup.Location = New System.Drawing.Point(618, 63)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(149, 119)
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Tag = "37"
        Me.btnBackup.Text = "Base de Datos"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.UseSelectable = True
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImage = Global.UI.My.Resources.Resources.Clientes
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Location = New System.Drawing.Point(449, 63)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(149, 119)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Tag = "Clientes"
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.UseSelectable = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackgroundImage = Global.UI.My.Resources.Resources.usuarios
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUsuarios.Location = New System.Drawing.Point(278, 63)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(149, 119)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Tag = "40"
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuarios.UseSelectable = True
        '
        'btnReportes
        '
        Me.btnReportes.BackgroundImage = Global.UI.My.Resources.Resources.reporte
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReportes.Location = New System.Drawing.Point(618, 334)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(149, 119)
        Me.btnReportes.TabIndex = 25
        Me.btnReportes.Tag = "Reporte"
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReportes.UseSelectable = True
        '
        'FormAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 571)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnPedidosHistorial)
        Me.Controls.Add(Me.btnCaja)
        Me.Controls.Add(Me.btnAdminComida)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Controls.Add(Me.Calculator1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnPedidos)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnBitacora)
        Me.Controls.Add(Me.btnIdioma)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Name = "FormAdministrador"
        Me.Resizable = False
        Me.Tag = "39"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUsuarios As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClientes As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBackup As MetroFramework.Controls.MetroButton
    Friend WithEvents btnIdioma As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBitacora As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrarSesion As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCompras As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPedidos As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Calculator1 As DevComponents.Editors.Calculator
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnAdminComida As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCaja As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPedidosHistorial As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReportes As MetroFramework.Controls.MetroButton
End Class
