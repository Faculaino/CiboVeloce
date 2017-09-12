<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Me.txtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarPermiso = New System.Windows.Forms.Button()
        Me.txtBuscarPermiso = New System.Windows.Forms.TextBox()
        Me.dgvPermisos = New System.Windows.Forms.DataGridView()
        Me.btnAgregarPermiso = New System.Windows.Forms.Button()
        Me.btnGuardarPermisos = New System.Windows.Forms.Button()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarUsuario
        '
        Me.txtBuscarUsuario.Location = New System.Drawing.Point(102, 13)
        Me.txtBuscarUsuario.Name = "txtBuscarUsuario"
        Me.txtBuscarUsuario.Size = New System.Drawing.Size(252, 20)
        Me.txtBuscarUsuario.TabIndex = 0
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(457, 10)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(160, 23)
        Me.btnBuscarUsuario.TabIndex = 1
        Me.btnBuscarUsuario.Text = "Buscar Usuario"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(13, 39)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.Size = New System.Drawing.Size(604, 150)
        Me.dgvUsuarios.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(685, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lista de Permisos"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(623, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(216, 290)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre Permiso:"
        '
        'btnBuscarPermiso
        '
        Me.btnBuscarPermiso.Location = New System.Drawing.Point(457, 198)
        Me.btnBuscarPermiso.Name = "btnBuscarPermiso"
        Me.btnBuscarPermiso.Size = New System.Drawing.Size(160, 23)
        Me.btnBuscarPermiso.TabIndex = 8
        Me.btnBuscarPermiso.Text = "Buscar Permiso"
        Me.btnBuscarPermiso.UseVisualStyleBackColor = True
        '
        'txtBuscarPermiso
        '
        Me.txtBuscarPermiso.Location = New System.Drawing.Point(105, 201)
        Me.txtBuscarPermiso.Name = "txtBuscarPermiso"
        Me.txtBuscarPermiso.Size = New System.Drawing.Size(252, 20)
        Me.txtBuscarPermiso.TabIndex = 7
        '
        'dgvPermisos
        '
        Me.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPermisos.Location = New System.Drawing.Point(15, 227)
        Me.dgvPermisos.Name = "dgvPermisos"
        Me.dgvPermisos.Size = New System.Drawing.Size(602, 150)
        Me.dgvPermisos.TabIndex = 9
        '
        'btnAgregarPermiso
        '
        Me.btnAgregarPermiso.Location = New System.Drawing.Point(457, 383)
        Me.btnAgregarPermiso.Name = "btnAgregarPermiso"
        Me.btnAgregarPermiso.Size = New System.Drawing.Size(160, 23)
        Me.btnAgregarPermiso.TabIndex = 10
        Me.btnAgregarPermiso.Text = "Agregar Permiso"
        Me.btnAgregarPermiso.UseVisualStyleBackColor = True
        '
        'btnGuardarPermisos
        '
        Me.btnGuardarPermisos.Location = New System.Drawing.Point(655, 335)
        Me.btnGuardarPermisos.Name = "btnGuardarPermisos"
        Me.btnGuardarPermisos.Size = New System.Drawing.Size(160, 42)
        Me.btnGuardarPermisos.TabIndex = 11
        Me.btnGuardarPermisos.Text = "Guardar Permisos"
        Me.btnGuardarPermisos.UseVisualStyleBackColor = True
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 413)
        Me.Controls.Add(Me.btnGuardarPermisos)
        Me.Controls.Add(Me.btnAgregarPermiso)
        Me.Controls.Add(Me.dgvPermisos)
        Me.Controls.Add(Me.btnBuscarPermiso)
        Me.Controls.Add(Me.txtBuscarPermiso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.btnBuscarUsuario)
        Me.Controls.Add(Me.txtBuscarUsuario)
        Me.Name = "FormUsuarios"
        Me.Text = "Administracion de Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarUsuario As TextBox
    Friend WithEvents btnBuscarUsuario As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarPermiso As Button
    Friend WithEvents txtBuscarPermiso As TextBox
    Friend WithEvents dgvPermisos As DataGridView
    Friend WithEvents btnAgregarPermiso As Button
    Friend WithEvents btnGuardarPermisos As Button
End Class
