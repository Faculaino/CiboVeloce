<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPermisosUsuarios
    Inherits System.Windows.Forms.Form

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
        Me.cmbUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblPerfil = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cmbPerfiles = New MetroFramework.Controls.MetroComboBox()
        Me.btnElegirPerfil = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lbPermisosFaltantes = New System.Windows.Forms.ListBox()
        Me.lbPermisos = New System.Windows.Forms.ListBox()
        Me.btnQuitar = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbUsuario
        '
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.ItemHeight = 23
        Me.cmbUsuario.Location = New System.Drawing.Point(74, 10)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(166, 29)
        Me.cmbUsuario.TabIndex = 12
        Me.cmbUsuario.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 15)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 13
        Me.MetroLabel1.Text = "Usuario:"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(116, 85)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel2.TabIndex = 15
        Me.MetroLabel2.Text = "Lista de Permisos"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(203, 386)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(366, 57)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 46)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 22
        Me.MetroLabel4.Text = "Perfil:"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Location = New System.Drawing.Point(59, 46)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(0, 0)
        Me.lblPerfil.TabIndex = 23
        Me.lblPerfil.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(287, 14)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel3.TabIndex = 25
        Me.MetroLabel3.Text = "Elegir Perfil:"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'cmbPerfiles
        '
        Me.cmbPerfiles.FormattingEnabled = True
        Me.cmbPerfiles.ItemHeight = 23
        Me.cmbPerfiles.Location = New System.Drawing.Point(369, 10)
        Me.cmbPerfiles.Name = "cmbPerfiles"
        Me.cmbPerfiles.Size = New System.Drawing.Size(303, 29)
        Me.cmbPerfiles.TabIndex = 26
        Me.cmbPerfiles.UseSelectable = True
        '
        'btnElegirPerfil
        '
        Me.btnElegirPerfil.Location = New System.Drawing.Point(678, 9)
        Me.btnElegirPerfil.Name = "btnElegirPerfil"
        Me.btnElegirPerfil.Size = New System.Drawing.Size(82, 30)
        Me.btnElegirPerfil.TabIndex = 27
        Me.btnElegirPerfil.Text = "Cambiar"
        Me.btnElegirPerfil.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(494, 85)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(163, 38)
        Me.MetroLabel5.TabIndex = 28
        Me.MetroLabel5.Text = "Lista de Permisos Faltantes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'lbPermisosFaltantes
        '
        Me.lbPermisosFaltantes.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPermisosFaltantes.FormattingEnabled = True
        Me.lbPermisosFaltantes.ItemHeight = 18
        Me.lbPermisosFaltantes.Location = New System.Drawing.Point(460, 113)
        Me.lbPermisosFaltantes.Name = "lbPermisosFaltantes"
        Me.lbPermisosFaltantes.Size = New System.Drawing.Size(261, 256)
        Me.lbPermisosFaltantes.TabIndex = 29
        '
        'lbPermisos
        '
        Me.lbPermisos.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPermisos.FormattingEnabled = True
        Me.lbPermisos.ItemHeight = 18
        Me.lbPermisos.Location = New System.Drawing.Point(54, 113)
        Me.lbPermisos.Name = "lbPermisos"
        Me.lbPermisos.Size = New System.Drawing.Size(261, 256)
        Me.lbPermisos.TabIndex = 30
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(352, 200)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 31)
        Me.btnQuitar.TabIndex = 31
        Me.btnQuitar.Text = ">>"
        Me.btnQuitar.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(352, 258)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 31)
        Me.btnAgregar.TabIndex = 32
        Me.btnAgregar.Text = "<<"
        Me.btnAgregar.UseSelectable = True
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(352, 124)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(0, 13)
        Me.lblUserID.TabIndex = 33
        '
        'FormPermisosUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 451)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.lbPermisos)
        Me.Controls.Add(Me.lbPermisosFaltantes)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.btnElegirPerfil)
        Me.Controls.Add(Me.cmbPerfiles)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblPerfil)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Name = "FormPermisosUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Permisos de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUsuario As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPerfil As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbPerfiles As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnElegirPerfil As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbPermisosFaltantes As ListBox
    Friend WithEvents lbPermisos As ListBox
    Friend WithEvents btnQuitar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblUserID As Label
End Class
