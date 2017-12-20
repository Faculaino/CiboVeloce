<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNuevoUsuario
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnVerContraseña = New System.Windows.Forms.Button()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtUserName = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'btnVerContraseña
        '
        Me.btnVerContraseña.BackColor = System.Drawing.Color.White
        Me.btnVerContraseña.Image = Global.UI.My.Resources.Resources.ImagenOjo1
        Me.btnVerContraseña.Location = New System.Drawing.Point(489, 150)
        Me.btnVerContraseña.Name = "btnVerContraseña"
        Me.btnVerContraseña.Size = New System.Drawing.Size(22, 22)
        Me.btnVerContraseña.TabIndex = 15
        Me.btnVerContraseña.UseVisualStyleBackColor = False
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.BackColor = System.Drawing.Color.DarkCyan
        Me.btnNuevoUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(130, 193)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(264, 47)
        Me.btnNuevoUsuario.TabIndex = 14
        Me.btnNuevoUsuario.Text = "Crear Usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 64)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Nombre"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 128)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "UserName"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(261, 128)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Contraseña"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(200, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(24, 87)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(222, 23)
        Me.txtNombre.TabIndex = 11
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.CustomButton.Image = Nothing
        Me.txtUserName.CustomButton.Location = New System.Drawing.Point(200, 1)
        Me.txtUserName.CustomButton.Name = ""
        Me.txtUserName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUserName.CustomButton.TabIndex = 1
        Me.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUserName.CustomButton.UseSelectable = True
        Me.txtUserName.CustomButton.Visible = False
        Me.txtUserName.Lines = New String(-1) {}
        Me.txtUserName.Location = New System.Drawing.Point(24, 150)
        Me.txtUserName.MaxLength = 32767
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.SelectionLength = 0
        Me.txtUserName.SelectionStart = 0
        Me.txtUserName.ShortcutsEnabled = True
        Me.txtUserName.Size = New System.Drawing.Size(222, 23)
        Me.txtUserName.TabIndex = 12
        Me.txtUserName.UseSelectable = True
        Me.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUserName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(200, 1)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(261, 150)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(222, 23)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FormNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 261)
        Me.Controls.Add(Me.btnNuevoUsuario)
        Me.Controls.Add(Me.btnVerContraseña)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Name = "FormNuevoUsuario"
        Me.Resizable = False
        Me.Text = "Alta de Usuario"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevoUsuario As Button
    Friend WithEvents btnVerContraseña As Button
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUserName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
End Class
