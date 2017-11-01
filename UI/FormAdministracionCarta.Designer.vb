<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministracionCarta
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
        Me.btnNuevaCategoria = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmbCategorias = New MetroFramework.Controls.MetroComboBox()
        Me.btnNuevaComida = New MetroFramework.Controls.MetroButton()
        Me.dgvComidas = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnEditarComidas = New MetroFramework.Controls.MetroButton()
        Me.lblComida = New MetroFramework.Controls.MetroLabel()
        Me.txtComida = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecio = New MetroFramework.Controls.MetroTextBox()
        Me.lblPrecio = New MetroFramework.Controls.MetroLabel()
        Me.btnAgregarComida = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevaCategoria
        '
        Me.btnNuevaCategoria.Location = New System.Drawing.Point(24, 64)
        Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
        Me.btnNuevaCategoria.Size = New System.Drawing.Size(114, 23)
        Me.btnNuevaCategoria.TabIndex = 0
        Me.btnNuevaCategoria.Text = "Nueva Categoría"
        Me.btnNuevaCategoria.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(303, 64)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Categorías"
        '
        'cmbCategorias
        '
        Me.cmbCategorias.Enabled = False
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.ItemHeight = 23
        Me.cmbCategorias.Location = New System.Drawing.Point(381, 61)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(157, 29)
        Me.cmbCategorias.TabIndex = 3
        Me.cmbCategorias.UseSelectable = True
        '
        'btnNuevaComida
        '
        Me.btnNuevaComida.Location = New System.Drawing.Point(163, 64)
        Me.btnNuevaComida.Name = "btnNuevaComida"
        Me.btnNuevaComida.Size = New System.Drawing.Size(114, 23)
        Me.btnNuevaComida.TabIndex = 4
        Me.btnNuevaComida.Text = "Nueva Comida"
        Me.btnNuevaComida.UseSelectable = True
        '
        'dgvComidas
        '
        Me.dgvComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2})
        Me.dgvComidas.Enabled = False
        Me.dgvComidas.Location = New System.Drawing.Point(303, 107)
        Me.dgvComidas.Name = "dgvComidas"
        Me.dgvComidas.RowHeadersVisible = False
        Me.dgvComidas.Size = New System.Drawing.Size(235, 259)
        Me.dgvComidas.TabIndex = 5
        '
        'C1
        '
        Me.C1.HeaderText = "Nombre"
        Me.C1.Name = "C1"
        Me.C1.Width = 180
        '
        'C2
        '
        Me.C2.HeaderText = "Precio"
        Me.C2.Name = "C2"
        Me.C2.Width = 50
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(59, 296)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(207, 70)
        Me.ReflectionLabel1.TabIndex = 18
        Me.ReflectionLabel1.Text = "<b><font size=""+18""><i>Cibo</i><font color=""#33CCFF"">Veloce</font></font></b>"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(424, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 23)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar Comidas"
        Me.btnGuardar.UseSelectable = True
        '
        'btnEditarComidas
        '
        Me.btnEditarComidas.Location = New System.Drawing.Point(303, 372)
        Me.btnEditarComidas.Name = "btnEditarComidas"
        Me.btnEditarComidas.Size = New System.Drawing.Size(114, 23)
        Me.btnEditarComidas.TabIndex = 20
        Me.btnEditarComidas.Text = "Editar Comidas"
        Me.btnEditarComidas.UseSelectable = True
        '
        'lblComida
        '
        Me.lblComida.AutoSize = True
        Me.lblComida.Location = New System.Drawing.Point(163, 107)
        Me.lblComida.Name = "lblComida"
        Me.lblComida.Size = New System.Drawing.Size(56, 19)
        Me.lblComida.TabIndex = 21
        Me.lblComida.Text = "Comida"
        Me.lblComida.Visible = False
        '
        'txtComida
        '
        Me.txtComida.Lines = New String(-1) {}
        Me.txtComida.Location = New System.Drawing.Point(163, 130)
        Me.txtComida.MaxLength = 32767
        Me.txtComida.Name = "txtComida"
        Me.txtComida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComida.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComida.SelectedText = ""
        Me.txtComida.Size = New System.Drawing.Size(114, 23)
        Me.txtComida.TabIndex = 22
        Me.txtComida.UseSelectable = True
        Me.txtComida.Visible = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Lines = New String(-1) {}
        Me.txtPrecio.Location = New System.Drawing.Point(163, 179)
        Me.txtPrecio.MaxLength = 32767
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.Size = New System.Drawing.Size(114, 23)
        Me.txtPrecio.TabIndex = 24
        Me.txtPrecio.UseSelectable = True
        Me.txtPrecio.Visible = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(163, 156)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(46, 19)
        Me.lblPrecio.TabIndex = 23
        Me.lblPrecio.Text = "Precio"
        Me.lblPrecio.Visible = False
        '
        'btnAgregarComida
        '
        Me.btnAgregarComida.Location = New System.Drawing.Point(163, 222)
        Me.btnAgregarComida.Name = "btnAgregarComida"
        Me.btnAgregarComida.Size = New System.Drawing.Size(114, 23)
        Me.btnAgregarComida.TabIndex = 25
        Me.btnAgregarComida.Text = "Agregar"
        Me.btnAgregarComida.UseSelectable = True
        Me.btnAgregarComida.Visible = False
        '
        'FormAdministracionCarta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 408)
        Me.Controls.Add(Me.btnAgregarComida)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtComida)
        Me.Controls.Add(Me.lblComida)
        Me.Controls.Add(Me.btnEditarComidas)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.dgvComidas)
        Me.Controls.Add(Me.btnNuevaComida)
        Me.Controls.Add(Me.cmbCategorias)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnNuevaCategoria)
        Me.Name = "FormAdministracionCarta"
        Me.Resizable = False
        Me.Text = "Administración de Carta"
        CType(Me.dgvComidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevaCategoria As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbCategorias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnNuevaComida As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvComidas As DataGridView
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEditarComidas As MetroFramework.Controls.MetroButton
    Friend WithEvents lblComida As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtComida As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPrecio As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAgregarComida As MetroFramework.Controls.MetroButton
End Class
