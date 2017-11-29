<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListaClientes = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtCosto = New MetroFramework.Controls.MetroTextBox()
        Me.txtLocalidad = New MetroFramework.Controls.MetroTextBox()
        Me.txtDetallesDir = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefonos = New MetroFramework.Controls.MetroTextBox()
        Me.txtEntreCalles = New MetroFramework.Controls.MetroTextBox()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarXML = New MetroFramework.Controls.MetroButton()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaClientes
        '
        Me.dgvListaClientes.AllowUserToAddRows = False
        Me.dgvListaClientes.AllowUserToDeleteRows = False
        Me.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5, Me.C6, Me.C7, Me.C8})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaClientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvListaClientes.Location = New System.Drawing.Point(24, 203)
        Me.dgvListaClientes.Name = "dgvListaClientes"
        Me.dgvListaClientes.ReadOnly = True
        Me.dgvListaClientes.RowHeadersVisible = False
        Me.dgvListaClientes.Size = New System.Drawing.Size(860, 359)
        Me.dgvListaClientes.TabIndex = 0
        '
        'txtCosto
        '
        '
        '
        '
        Me.txtCosto.CustomButton.Image = Nothing
        Me.txtCosto.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.txtCosto.CustomButton.Name = ""
        Me.txtCosto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCosto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCosto.CustomButton.TabIndex = 1
        Me.txtCosto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCosto.CustomButton.UseSelectable = True
        Me.txtCosto.CustomButton.Visible = False
        Me.txtCosto.Lines = New String(-1) {}
        Me.txtCosto.Location = New System.Drawing.Point(327, 130)
        Me.txtCosto.MaxLength = 32767
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCosto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCosto.SelectedText = ""
        Me.txtCosto.SelectionLength = 0
        Me.txtCosto.SelectionStart = 0
        Me.txtCosto.ShortcutsEnabled = True
        Me.txtCosto.Size = New System.Drawing.Size(149, 23)
        Me.txtCosto.TabIndex = 39
        Me.txtCosto.UseSelectable = True
        Me.txtCosto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCosto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLocalidad
        '
        '
        '
        '
        Me.txtLocalidad.CustomButton.Image = Nothing
        Me.txtLocalidad.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.txtLocalidad.CustomButton.Name = ""
        Me.txtLocalidad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLocalidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLocalidad.CustomButton.TabIndex = 1
        Me.txtLocalidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLocalidad.CustomButton.UseSelectable = True
        Me.txtLocalidad.CustomButton.Visible = False
        Me.txtLocalidad.Lines = New String(-1) {}
        Me.txtLocalidad.Location = New System.Drawing.Point(327, 95)
        Me.txtLocalidad.MaxLength = 32767
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLocalidad.SelectedText = ""
        Me.txtLocalidad.SelectionLength = 0
        Me.txtLocalidad.SelectionStart = 0
        Me.txtLocalidad.ShortcutsEnabled = True
        Me.txtLocalidad.Size = New System.Drawing.Size(149, 23)
        Me.txtLocalidad.TabIndex = 38
        Me.txtLocalidad.UseSelectable = True
        Me.txtLocalidad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLocalidad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDetallesDir
        '
        '
        '
        '
        Me.txtDetallesDir.CustomButton.Image = Nothing
        Me.txtDetallesDir.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.txtDetallesDir.CustomButton.Name = ""
        Me.txtDetallesDir.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDetallesDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDetallesDir.CustomButton.TabIndex = 1
        Me.txtDetallesDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDetallesDir.CustomButton.UseSelectable = True
        Me.txtDetallesDir.CustomButton.Visible = False
        Me.txtDetallesDir.Lines = New String(-1) {}
        Me.txtDetallesDir.Location = New System.Drawing.Point(327, 63)
        Me.txtDetallesDir.MaxLength = 32767
        Me.txtDetallesDir.Name = "txtDetallesDir"
        Me.txtDetallesDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetallesDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDetallesDir.SelectedText = ""
        Me.txtDetallesDir.SelectionLength = 0
        Me.txtDetallesDir.SelectionStart = 0
        Me.txtDetallesDir.ShortcutsEnabled = True
        Me.txtDetallesDir.Size = New System.Drawing.Size(149, 23)
        Me.txtDetallesDir.TabIndex = 37
        Me.txtDetallesDir.UseSelectable = True
        Me.txtDetallesDir.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDetallesDir.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelefonos
        '
        '
        '
        '
        Me.txtTelefonos.CustomButton.Image = Nothing
        Me.txtTelefonos.CustomButton.Location = New System.Drawing.Point(363, 1)
        Me.txtTelefonos.CustomButton.Name = ""
        Me.txtTelefonos.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelefonos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelefonos.CustomButton.TabIndex = 1
        Me.txtTelefonos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelefonos.CustomButton.UseSelectable = True
        Me.txtTelefonos.CustomButton.Visible = False
        Me.txtTelefonos.Lines = New String(-1) {}
        Me.txtTelefonos.Location = New System.Drawing.Point(91, 165)
        Me.txtTelefonos.MaxLength = 32767
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefonos.SelectedText = ""
        Me.txtTelefonos.SelectionLength = 0
        Me.txtTelefonos.SelectionStart = 0
        Me.txtTelefonos.ShortcutsEnabled = True
        Me.txtTelefonos.Size = New System.Drawing.Size(385, 23)
        Me.txtTelefonos.TabIndex = 36
        Me.txtTelefonos.UseSelectable = True
        Me.txtTelefonos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelefonos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEntreCalles
        '
        '
        '
        '
        Me.txtEntreCalles.CustomButton.Image = Nothing
        Me.txtEntreCalles.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtEntreCalles.CustomButton.Name = ""
        Me.txtEntreCalles.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEntreCalles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEntreCalles.CustomButton.TabIndex = 1
        Me.txtEntreCalles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEntreCalles.CustomButton.UseSelectable = True
        Me.txtEntreCalles.CustomButton.Visible = False
        Me.txtEntreCalles.Lines = New String(-1) {}
        Me.txtEntreCalles.Location = New System.Drawing.Point(91, 130)
        Me.txtEntreCalles.MaxLength = 32767
        Me.txtEntreCalles.Name = "txtEntreCalles"
        Me.txtEntreCalles.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEntreCalles.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEntreCalles.SelectedText = ""
        Me.txtEntreCalles.SelectionLength = 0
        Me.txtEntreCalles.SelectionStart = 0
        Me.txtEntreCalles.ShortcutsEnabled = True
        Me.txtEntreCalles.Size = New System.Drawing.Size(150, 23)
        Me.txtEntreCalles.TabIndex = 35
        Me.txtEntreCalles.UseSelectable = True
        Me.txtEntreCalles.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEntreCalles.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDireccion
        '
        '
        '
        '
        Me.txtDireccion.CustomButton.Image = Nothing
        Me.txtDireccion.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtDireccion.CustomButton.Name = ""
        Me.txtDireccion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccion.CustomButton.TabIndex = 1
        Me.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccion.CustomButton.UseSelectable = True
        Me.txtDireccion.CustomButton.Visible = False
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(91, 95)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = True
        Me.txtDireccion.Size = New System.Drawing.Size(150, 23)
        Me.txtDireccion.TabIndex = 34
        Me.txtDireccion.UseSelectable = True
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(91, 63)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(150, 23)
        Me.txtNombre.TabIndex = 33
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(247, 130)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel7.TabIndex = 32
        Me.MetroLabel7.Text = "Costo:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(24, 165)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel6.TabIndex = 31
        Me.MetroLabel6.Text = "Teléfonos:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(247, 63)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel5.TabIndex = 30
        Me.MetroLabel5.Text = "Detalle Dir:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 130)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel4.TabIndex = 29
        Me.MetroLabel4.Text = "E/ Calles:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(247, 95)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 28
        Me.MetroLabel3.Text = "Localidad:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 95)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 27
        Me.MetroLabel2.Text = "Dirección:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel1.TabIndex = 26
        Me.MetroLabel1.Text = "Nombre:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGuardar.BackgroundImage = Global.UI.My.Resources.Resources.Save
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(482, 63)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 125)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.UseSelectable = True
        '
        'btnGuardarXML
        '
        Me.btnGuardarXML.Location = New System.Drawing.Point(745, 174)
        Me.btnGuardarXML.Name = "btnGuardarXML"
        Me.btnGuardarXML.Size = New System.Drawing.Size(139, 23)
        Me.btnGuardarXML.TabIndex = 41
        Me.btnGuardarXML.Text = "Guardar en XML"
        Me.btnGuardarXML.UseSelectable = True
        '
        'C1
        '
        Me.C1.HeaderText = "Nombre"
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        '
        'C2
        '
        Me.C2.HeaderText = "Dirección"
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        Me.C2.Width = 150
        '
        'C3
        '
        Me.C3.HeaderText = "Entre Calles"
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        Me.C3.Width = 150
        '
        'C4
        '
        Me.C4.HeaderText = "Localidad"
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        '
        'C5
        '
        Me.C5.HeaderText = "Detalle Dirección"
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        Me.C5.Width = 150
        '
        'C6
        '
        Me.C6.HeaderText = "Teléfonos"
        Me.C6.Name = "C6"
        Me.C6.ReadOnly = True
        Me.C6.Width = 150
        '
        'C7
        '
        Me.C7.HeaderText = "Costo"
        Me.C7.Name = "C7"
        Me.C7.ReadOnly = True
        Me.C7.Width = 50
        '
        'C8
        '
        Me.C8.HeaderText = "ID"
        Me.C8.Name = "C8"
        Me.C8.ReadOnly = True
        Me.C8.Visible = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 585)
        Me.Controls.Add(Me.btnGuardarXML)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDetallesDir)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.txtEntreCalles)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dgvListaClientes)
        Me.Name = "FormClientes"
        Me.Resizable = False
        Me.Text = "Lista de Clientes"
        CType(Me.dgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListaClientes As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtCosto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLocalidad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDetallesDir As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefonos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEntreCalles As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarXML As MetroFramework.Controls.MetroButton
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents C6 As DataGridViewTextBoxColumn
    Friend WithEvents C7 As DataGridViewTextBoxColumn
    Friend WithEvents C8 As DataGridViewTextBoxColumn
End Class
