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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dgvPermisosFaltantes = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnAgregarPermiso = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnQuitarPermiso = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblPerfil = New MetroFramework.Controls.MetroLabel()
        Me.tvPermisos = New System.Windows.Forms.TreeView()
        CType(Me.dgvPermisosFaltantes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroLabel2.Location = New System.Drawing.Point(62, 42)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel2.TabIndex = 15
        Me.MetroLabel2.Text = "Lista de Permisos"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(279, 42)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(163, 19)
        Me.MetroLabel3.TabIndex = 16
        Me.MetroLabel3.Text = "Lista de Permisos Faltantes"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'dgvPermisosFaltantes
        '
        Me.dgvPermisosFaltantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPermisosFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPermisosFaltantes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPermisosFaltantes.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvPermisosFaltantes.Location = New System.Drawing.Point(279, 71)
        Me.dgvPermisosFaltantes.Name = "dgvPermisosFaltantes"
        Me.dgvPermisosFaltantes.RowHeadersVisible = False
        Me.dgvPermisosFaltantes.Size = New System.Drawing.Size(370, 150)
        Me.dgvPermisosFaltantes.TabIndex = 17
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
        Me.MetroLabel4.Location = New System.Drawing.Point(259, 9)
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
        'FormPermisosUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 368)
        Me.Controls.Add(Me.tvPermisos)
        Me.Controls.Add(Me.lblPerfil)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnQuitarPermiso)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregarPermiso)
        Me.Controls.Add(Me.dgvPermisosFaltantes)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Name = "FormPermisosUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Permisos de Usuarios"
        CType(Me.dgvPermisosFaltantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUsuario As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvPermisosFaltantes As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnAgregarPermiso As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnQuitarPermiso As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPerfil As MetroFramework.Controls.MetroLabel
    Friend WithEvents tvPermisos As TreeView
End Class
