<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidosHistorial
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPedidosHistorial = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFecha2 = New MetroFramework.Controls.MetroDateTime()
        Me.dtFecha1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.txtCantidadVentas = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cmbLocalidades = New MetroFramework.Controls.MetroComboBox()
        Me.btnBuscaLocalidad = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtTelefono = New MetroFramework.Controls.MetroTextBox()
        Me.btnBuscarPedidoCliente = New MetroFramework.Controls.MetroButton()
        Me.btnComandaCliente = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvPedidosHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidosHistorial
        '
        Me.dgvPedidosHistorial.AllowUserToAddRows = False
        Me.dgvPedidosHistorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidosHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPedidosHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidosHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidosHistorial.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPedidosHistorial.Location = New System.Drawing.Point(23, 187)
        Me.dgvPedidosHistorial.Name = "dgvPedidosHistorial"
        Me.dgvPedidosHistorial.ReadOnly = True
        Me.dgvPedidosHistorial.RowHeadersVisible = False
        Me.dgvPedidosHistorial.Size = New System.Drawing.Size(774, 303)
        Me.dgvPedidosHistorial.TabIndex = 9
        '
        'C1
        '
        DataGridViewCellStyle6.Format = "g"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.C1.DefaultCellStyle = DataGridViewCellStyle6
        Me.C1.HeaderText = "Fecha"
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        Me.C1.Width = 95
        '
        'C2
        '
        Me.C2.HeaderText = "Detalle Pedido"
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        Me.C2.Width = 315
        '
        'C3
        '
        Me.C3.HeaderText = "Cliente"
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        Me.C3.Width = 125
        '
        'C4
        '
        Me.C4.HeaderText = "Dirección"
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        Me.C4.Width = 150
        '
        'C5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.C5.DefaultCellStyle = DataGridViewCellStyle7
        Me.C5.HeaderText = "Total"
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        Me.C5.Width = 80
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(125, 107)
        Me.dtFecha2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(106, 29)
        Me.dtFecha2.TabIndex = 8
        '
        'dtFecha1
        '
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(125, 68)
        Me.dtFecha1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(106, 29)
        Me.dtFecha1.TabIndex = 7
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 113)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Fecha de Fin:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 72)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Fecha de Inicio:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscar.BackgroundImage = Global.UI.My.Resources.Resources.system_search
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(237, 66)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 70)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(657, 91)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel3.TabIndex = 17
        Me.MetroLabel3.Text = "TOTAL Vendido:"
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.CustomButton.Image = Nothing
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(63, 1)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTotal.Lines = New String() {"0"}
        Me.txtTotal.Location = New System.Drawing.Point(666, 113)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.ShortcutsEnabled = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 23)
        Me.txtTotal.TabIndex = 18
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCantidadVentas
        '
        '
        '
        '
        Me.txtCantidadVentas.CustomButton.Image = Nothing
        Me.txtCantidadVentas.CustomButton.Location = New System.Drawing.Point(63, 1)
        Me.txtCantidadVentas.CustomButton.Name = ""
        Me.txtCantidadVentas.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCantidadVentas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCantidadVentas.CustomButton.TabIndex = 1
        Me.txtCantidadVentas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCantidadVentas.CustomButton.UseSelectable = True
        Me.txtCantidadVentas.CustomButton.Visible = False
        Me.txtCantidadVentas.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCantidadVentas.Lines = New String() {"0"}
        Me.txtCantidadVentas.Location = New System.Drawing.Point(666, 68)
        Me.txtCantidadVentas.MaxLength = 32767
        Me.txtCantidadVentas.Name = "txtCantidadVentas"
        Me.txtCantidadVentas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidadVentas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCantidadVentas.SelectedText = ""
        Me.txtCantidadVentas.SelectionLength = 0
        Me.txtCantidadVentas.SelectionStart = 0
        Me.txtCantidadVentas.ShortcutsEnabled = True
        Me.txtCantidadVentas.Size = New System.Drawing.Size(85, 23)
        Me.txtCantidadVentas.TabIndex = 20
        Me.txtCantidadVentas.Text = "0"
        Me.txtCantidadVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCantidadVentas.UseSelectable = True
        Me.txtCantidadVentas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCantidadVentas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(657, 46)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel4.TabIndex = 19
        Me.MetroLabel4.Text = "Cantidad Ventas:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(316, 72)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "Localidad:"
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.ItemHeight = 23
        Me.cmbLocalidades.Location = New System.Drawing.Point(390, 68)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(135, 29)
        Me.cmbLocalidades.TabIndex = 22
        Me.cmbLocalidades.UseSelectable = True
        '
        'btnBuscaLocalidad
        '
        Me.btnBuscaLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscaLocalidad.BackgroundImage = Global.UI.My.Resources.Resources.system_search
        Me.btnBuscaLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscaLocalidad.Location = New System.Drawing.Point(531, 66)
        Me.btnBuscaLocalidad.Name = "btnBuscaLocalidad"
        Me.btnBuscaLocalidad.Size = New System.Drawing.Size(67, 31)
        Me.btnBuscaLocalidad.TabIndex = 23
        Me.btnBuscaLocalidad.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(316, 117)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel6.TabIndex = 24
        Me.MetroLabel6.Text = "Tel Cliente:"
        '
        'txtTelefono
        '
        '
        '
        '
        Me.txtTelefono.CustomButton.Image = Nothing
        Me.txtTelefono.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.txtTelefono.CustomButton.Name = ""
        Me.txtTelefono.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelefono.CustomButton.TabIndex = 1
        Me.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelefono.CustomButton.UseSelectable = True
        Me.txtTelefono.CustomButton.Visible = False
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(390, 116)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.SelectionLength = 0
        Me.txtTelefono.SelectionStart = 0
        Me.txtTelefono.ShortcutsEnabled = True
        Me.txtTelefono.Size = New System.Drawing.Size(135, 23)
        Me.txtTelefono.TabIndex = 25
        Me.txtTelefono.UseSelectable = True
        Me.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBuscarPedidoCliente
        '
        Me.btnBuscarPedidoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscarPedidoCliente.BackgroundImage = Global.UI.My.Resources.Resources.system_search
        Me.btnBuscarPedidoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarPedidoCliente.Location = New System.Drawing.Point(531, 113)
        Me.btnBuscarPedidoCliente.Name = "btnBuscarPedidoCliente"
        Me.btnBuscarPedidoCliente.Size = New System.Drawing.Size(67, 31)
        Me.btnBuscarPedidoCliente.TabIndex = 26
        Me.btnBuscarPedidoCliente.UseSelectable = True
        '
        'btnComandaCliente
        '
        Me.btnComandaCliente.Location = New System.Drawing.Point(390, 150)
        Me.btnComandaCliente.Name = "btnComandaCliente"
        Me.btnComandaCliente.Size = New System.Drawing.Size(208, 23)
        Me.btnComandaCliente.TabIndex = 27
        Me.btnComandaCliente.Text = "Generar Comanda del Cliente"
        Me.btnComandaCliente.UseSelectable = True
        '
        'FormPedidosHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 502)
        Me.Controls.Add(Me.btnComandaCliente)
        Me.Controls.Add(Me.btnBuscarPedidoCliente)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnBuscaLocalidad)
        Me.Controls.Add(Me.cmbLocalidades)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtCantidadVentas)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvPedidosHistorial)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.dtFecha1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormPedidosHistorial"
        Me.Resizable = False
        Me.Text = "Administración de Historial de Pedidos"
        CType(Me.dgvPedidosHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPedidosHistorial As DataGridView
    Friend WithEvents dtFecha2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtFecha1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCantidadVentas As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbLocalidades As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBuscaLocalidad As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTelefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBuscarPedidoCliente As MetroFramework.Controls.MetroButton
    Friend WithEvents btnComandaCliente As MetroFramework.Controls.MetroButton
End Class
