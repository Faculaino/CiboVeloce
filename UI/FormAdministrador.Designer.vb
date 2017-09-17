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
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnBackup = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(105, 63)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(149, 119)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseSelectable = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(276, 63)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(149, 119)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.BackgroundImage = Global.UI.My.Resources.Resources.cerrar
        Me.MetroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroButton3.Location = New System.Drawing.Point(782, 63)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(149, 119)
        Me.MetroButton3.TabIndex = 5
        Me.MetroButton3.Text = "Cerrar Sesión"
        Me.MetroButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackgroundImage = Global.UI.My.Resources.Resources.bitacora
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Location = New System.Drawing.Point(105, 199)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(149, 119)
        Me.MetroButton2.TabIndex = 4
        Me.MetroButton2.Text = "Bitacora"
        Me.MetroButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = Global.UI.My.Resources.Resources.bandera_world
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroButton1.Location = New System.Drawing.Point(617, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(149, 119)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Idioma"
        Me.MetroButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroButton1.UseSelectable = True
        '
        'btnBackup
        '
        Me.btnBackup.BackgroundImage = Global.UI.My.Resources.Resources.DataBase
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBackup.Location = New System.Drawing.Point(445, 63)
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
        Me.ClientSize = New System.Drawing.Size(942, 351)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
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
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
End Class
