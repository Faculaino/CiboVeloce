<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoProveedor
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefono = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 78)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 120)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Dirección:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(24, 163)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Teléfono:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(23, 208)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(254, 39)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(164, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(91, 78)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(186, 23)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDireccion
        '
        '
        '
        '
        Me.txtDireccion.CustomButton.Image = Nothing
        Me.txtDireccion.CustomButton.Location = New System.Drawing.Point(164, 1)
        Me.txtDireccion.CustomButton.Name = ""
        Me.txtDireccion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccion.CustomButton.TabIndex = 1
        Me.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccion.CustomButton.UseSelectable = True
        Me.txtDireccion.CustomButton.Visible = False
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(91, 120)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = True
        Me.txtDireccion.Size = New System.Drawing.Size(186, 23)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.UseSelectable = True
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelefono
        '
        '
        '
        '
        Me.txtTelefono.CustomButton.Image = Nothing
        Me.txtTelefono.CustomButton.Location = New System.Drawing.Point(164, 1)
        Me.txtTelefono.CustomButton.Name = ""
        Me.txtTelefono.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelefono.CustomButton.TabIndex = 1
        Me.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelefono.CustomButton.UseSelectable = True
        Me.txtTelefono.CustomButton.Visible = False
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(91, 163)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.SelectionLength = 0
        Me.txtTelefono.SelectionStart = 0
        Me.txtTelefono.ShortcutsEnabled = True
        Me.txtTelefono.Size = New System.Drawing.Size(186, 23)
        Me.txtTelefono.TabIndex = 6
        Me.txtTelefono.UseSelectable = True
        Me.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FormNuevoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 258)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormNuevoProveedor"
        Me.Resizable = False
        Me.Text = "Nuevo Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefono As MetroFramework.Controls.MetroTextBox
End Class
