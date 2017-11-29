<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    'Inherits System.Windows.Forms.Form
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
        Me.components = New System.ComponentModel.Container()
        Me.lnkNuevoUsuario = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnSQL = New MetroFramework.Controls.MetroButton()
        Me.cmbInstancias = New MetroFramework.Controls.MetroComboBox()
        Me.btnVerInstancias = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.TimerProgress = New System.Windows.Forms.Timer(Me.components)
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblMensajeProgress = New MetroFramework.Controls.MetroLabel()
        Me.btnInstalarSQL = New MetroFramework.Controls.MetroButton()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'lnkNuevoUsuario
        '
        Me.lnkNuevoUsuario.AutoSize = True
        Me.lnkNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lnkNuevoUsuario.Location = New System.Drawing.Point(54, 187)
        Me.lnkNuevoUsuario.Name = "lnkNuevoUsuario"
        Me.lnkNuevoUsuario.Size = New System.Drawing.Size(198, 18)
        Me.lnkNuevoUsuario.TabIndex = 11
        Me.lnkNuevoUsuario.TabStop = True
        Me.lnkNuevoUsuario.Text = "Soy Nuevo, ¿Crear Usuario?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(13, 223)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(275, 42)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(45, 71)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel1.TabIndex = 14
        Me.MetroLabel1.Text = "Usuario"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(45, 130)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel2.TabIndex = 15
        Me.MetroLabel2.Text = "Contraseña"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(57, 271)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(207, 70)
        Me.ReflectionLabel1.TabIndex = 16
        Me.ReflectionLabel1.Text = "<b><font size=""+18""><i>Cibo</i><font color=""#33CCFF"">Veloce</font></font></b>"
        '
        'btnSQL
        '
        Me.btnSQL.Location = New System.Drawing.Point(305, 56)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(28, 298)
        Me.btnSQL.TabIndex = 17
        Me.btnSQL.Text = "->"
        Me.btnSQL.UseSelectable = True
        '
        'cmbInstancias
        '
        Me.cmbInstancias.FormattingEnabled = True
        Me.cmbInstancias.ItemHeight = 23
        Me.cmbInstancias.Location = New System.Drawing.Point(399, 130)
        Me.cmbInstancias.Name = "cmbInstancias"
        Me.cmbInstancias.Size = New System.Drawing.Size(184, 29)
        Me.cmbInstancias.TabIndex = 19
        Me.cmbInstancias.UseSelectable = True
        '
        'btnVerInstancias
        '
        Me.btnVerInstancias.Location = New System.Drawing.Point(440, 94)
        Me.btnVerInstancias.Name = "btnVerInstancias"
        Me.btnVerInstancias.Size = New System.Drawing.Size(92, 23)
        Me.btnVerInstancias.TabIndex = 20
        Me.btnVerInstancias.Text = "Verificar"
        Me.btnVerInstancias.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(416, 60)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(145, 25)
        Me.MetroLabel4.TabIndex = 21
        Me.MetroLabel4.Text = "Instancias de SQL"
        '
        'TimerProgress
        '
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(339, 165)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(305, 31)
        Me.progressBar.TabIndex = 24
        '
        'lblMensajeProgress
        '
        Me.lblMensajeProgress.AutoSize = True
        Me.lblMensajeProgress.Location = New System.Drawing.Point(449, 199)
        Me.lblMensajeProgress.Name = "lblMensajeProgress"
        Me.lblMensajeProgress.Size = New System.Drawing.Size(0, 0)
        Me.lblMensajeProgress.TabIndex = 25
        '
        'btnInstalarSQL
        '
        Me.btnInstalarSQL.Location = New System.Drawing.Point(430, 271)
        Me.btnInstalarSQL.Name = "btnInstalarSQL"
        Me.btnInstalarSQL.Size = New System.Drawing.Size(131, 23)
        Me.btnInstalarSQL.TabIndex = 26
        Me.btnInstalarSQL.Text = "Instalar SQL"
        Me.btnInstalarSQL.UseSelectable = True
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(211, 1)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(45, 93)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(233, 23)
        Me.txtUsername.TabIndex = 27
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(211, 1)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(45, 152)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(233, 23)
        Me.txtPassword.TabIndex = 28
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 366)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnInstalarSQL)
        Me.Controls.Add(Me.lblMensajeProgress)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnVerInstancias)
        Me.Controls.Add(Me.cmbInstancias)
        Me.Controls.Add(Me.btnSQL)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lnkNuevoUsuario)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Name = "FormLogin"
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Iniciar Sesión"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkNuevoUsuario As LinkLabel
    Private WithEvents btnLogin As Button
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnSQL As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbInstancias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnVerInstancias As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TimerProgress As Timer
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents lblMensajeProgress As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnInstalarSQL As MetroFramework.Controls.MetroButton
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
End Class
