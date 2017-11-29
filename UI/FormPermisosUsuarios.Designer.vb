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
        Me.btnAgregarPermiso = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnQuitarPermiso = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblPerfil = New MetroFramework.Controls.MetroLabel()
        Me.tvPermisos = New System.Windows.Forms.TreeView()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cmbPerfiles = New MetroFramework.Controls.MetroComboBox()
        Me.btnElegirPerfil = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cmbUsuario
        '
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.ItemHeight = 23
        Me.cmbUsuario.Location = New System.Drawing.Point(73, 4)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(166, 29)
        Me.cmbUsuario.TabIndex = 12
        Me.cmbUsuario.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 13
        Me.MetroLabel1.Text = "Usuario:"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(78, 46)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel2.TabIndex = 15
        Me.MetroLabel2.Text = "Lista de Permisos"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'btnAgregarPermiso
        '
        Me.btnAgregarPermiso.Location = New System.Drawing.Point(279, 227)
        Me.btnAgregarPermiso.Name = "btnAgregarPermiso"
        Me.btnAgregarPermiso.Size = New System.Drawing.Size(105, 32)
        Me.btnAgregarPermiso.TabIndex = 19
        Me.btnAgregarPermiso.Text = "Agregar"
        Me.btnAgregarPermiso.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(283, 296)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(366, 57)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnQuitarPermiso
        '
        Me.btnQuitarPermiso.Location = New System.Drawing.Point(13, 319)
        Me.btnQuitarPermiso.Name = "btnQuitarPermiso"
        Me.btnQuitarPermiso.Size = New System.Drawing.Size(226, 34)
        Me.btnQuitarPermiso.TabIndex = 21
        Me.btnQuitarPermiso.Text = "Quitar"
        Me.btnQuitarPermiso.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(279, 9)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 22
        Me.MetroLabel4.Text = "Perfil:"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Location = New System.Drawing.Point(301, 9)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(0, 0)
        Me.lblPerfil.TabIndex = 23
        Me.lblPerfil.UseCustomBackColor = True
        '
        'tvPermisos
        '
        Me.tvPermisos.Location = New System.Drawing.Point(12, 71)
        Me.tvPermisos.Name = "tvPermisos"
        Me.tvPermisos.Size = New System.Drawing.Size(261, 242)
        Me.tvPermisos.TabIndex = 24
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(283, 46)
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
        Me.cmbPerfiles.Location = New System.Drawing.Point(365, 42)
        Me.cmbPerfiles.Name = "cmbPerfiles"
        Me.cmbPerfiles.Size = New System.Drawing.Size(303, 29)
        Me.cmbPerfiles.TabIndex = 26
        Me.cmbPerfiles.UseSelectable = True
        '
        'btnElegirPerfil
        '
        Me.btnElegirPerfil.Location = New System.Drawing.Point(674, 41)
        Me.btnElegirPerfil.Name = "btnElegirPerfil"
        Me.btnElegirPerfil.Size = New System.Drawing.Size(82, 30)
        Me.btnElegirPerfil.TabIndex = 27
        Me.btnElegirPerfil.Text = "Cambiar"
        Me.btnElegirPerfil.UseSelectable = True
        '
        'FormPermisosUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 368)
        Me.Controls.Add(Me.btnElegirPerfil)
        Me.Controls.Add(Me.cmbPerfiles)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.tvPermisos)
        Me.Controls.Add(Me.lblPerfil)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnQuitarPermiso)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregarPermiso)
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
    Friend WithEvents btnAgregarPermiso As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnQuitarPermiso As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPerfil As MetroFramework.Controls.MetroLabel
    Friend WithEvents tvPermisos As TreeView
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbPerfiles As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnElegirPerfil As MetroFramework.Controls.MetroButton
End Class
