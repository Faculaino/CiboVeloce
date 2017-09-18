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
        Me.btnUsuarios = New MetroFramework.Controls.MetroButton()
        Me.btnClientes = New MetroFramework.Controls.MetroButton()
        Me.btnCerrarSesion = New MetroFramework.Controls.MetroButton()
        Me.btnBitacora = New MetroFramework.Controls.MetroButton()
        Me.btnIdioma = New MetroFramework.Controls.MetroButton()
        Me.btnBackup = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(184, 63)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(149, 119)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseSelectable = True
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImage = Global.UI.My.Resources.Resources.Clientes
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Location = New System.Drawing.Point(355, 63)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(149, 119)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.UseSelectable = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackgroundImage = Global.UI.My.Resources.Resources.logout
        Me.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrarSesion.Location = New System.Drawing.Point(861, 63)
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
        Me.btnBitacora.Location = New System.Drawing.Point(184, 197)
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
        Me.btnIdioma.Location = New System.Drawing.Point(696, 63)
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
        Me.btnBackup.Location = New System.Drawing.Point(524, 63)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(149, 119)
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.UseSelectable = True
        '
        'FormAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 351)
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
End Class
