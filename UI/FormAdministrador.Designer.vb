<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnCompras = New MetroFramework.Controls.MetroButton()
        Me.btnCerrarSesion = New MetroFramework.Controls.MetroButton()
        Me.btnBitacora = New MetroFramework.Controls.MetroButton()
        Me.btnIdioma = New MetroFramework.Controls.MetroButton()
        Me.btnBackup = New MetroFramework.Controls.MetroButton()
        Me.btnClientes = New MetroFramework.Controls.MetroButton()
        Me.btnUsuarios = New MetroFramework.Controls.MetroButton()
        Me.btnPedidos = New MetroFramework.Controls.MetroButton()
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.SuspendLayout()
        '
        'btnCompras
        '
        Me.btnCompras.BackgroundImage = Global.UI.My.Resources.Resources.compra
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompras.Location = New System.Drawing.Point(402, 197)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(149, 119)
        Me.btnCompras.TabIndex = 6
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCompras.UseSelectable = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackgroundImage = Global.UI.My.Resources.Resources.sinsesion
        Me.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrarSesion.Location = New System.Drawing.Point(908, 63)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(149, 119)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrarSesion.UseSelectable = True
        '
        'btnBitacora
        '
        Me.btnBitacora.BackgroundImage = Global.UI.My.Resources.Resources.bitacora
        Me.btnBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBitacora.Location = New System.Drawing.Point(231, 197)
        Me.btnBitacora.Name = "btnBitacora"
        Me.btnBitacora.Size = New System.Drawing.Size(149, 119)
        Me.btnBitacora.TabIndex = 4
        Me.btnBitacora.Text = "Bitacora"
        Me.btnBitacora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBitacora.UseSelectable = True
        '
        'btnIdioma
        '
        Me.btnIdioma.BackgroundImage = Global.UI.My.Resources.Resources.bandera_world
        Me.btnIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIdioma.Location = New System.Drawing.Point(743, 63)
        Me.btnIdioma.Name = "btnIdioma"
        Me.btnIdioma.Size = New System.Drawing.Size(149, 119)
        Me.btnIdioma.TabIndex = 3
        Me.btnIdioma.Text = "Idioma"
        Me.btnIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIdioma.UseSelectable = True
        '
        'btnBackup
        '
        Me.btnBackup.BackgroundImage = Global.UI.My.Resources.Resources.DataBase
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBackup.Location = New System.Drawing.Point(571, 63)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(149, 119)
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.UseSelectable = True
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImage = Global.UI.My.Resources.Resources.Clientes
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Location = New System.Drawing.Point(402, 63)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(149, 119)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.UseSelectable = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackgroundImage = Global.UI.My.Resources.Resources.usuarios
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUsuarios.Location = New System.Drawing.Point(231, 63)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(149, 119)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuarios.UseSelectable = True
        '
        'btnPedidos
        '
        Me.btnPedidos.BackgroundImage = Global.UI.My.Resources.Resources.pedido
        Me.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPedidos.Location = New System.Drawing.Point(571, 197)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(149, 119)
        Me.btnPedidos.TabIndex = 7
        Me.btnPedidos.Text = "Nuevo Pedido"
        Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPedidos.UseSelectable = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(13, 63)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 29)
        Me.dtpFecha.TabIndex = 8
        '
        'FormAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 351)
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
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

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
End Class
