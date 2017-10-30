<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidos
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPedidos))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtBuscaTel = New MetroFramework.Controls.MetroTextBox()
        Me.txtBuscaDir = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.txtEntreCalles = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefonos = New MetroFramework.Controls.MetroTextBox()
        Me.txtDetallesDir = New MetroFramework.Controls.MetroTextBox()
        Me.txtLocalidad = New MetroFramework.Controls.MetroTextBox()
        Me.txtCosto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.dgvPedido = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numericCantidad = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.btnNuevoPedido = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.wbMaps = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregarComida = New System.Windows.Forms.Button()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.tvComidas = New System.Windows.Forms.TreeView()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.printDocument = New System.Drawing.Printing.PrintDocument()
        Me.printPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 117)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 149)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Dirección:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(247, 149)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Localidad:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 184)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "E/ Calles:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(247, 117)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Detalle Dir:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(24, 219)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Teléfonos:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(247, 184)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Costo:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 72)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "Teléfono:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(246, 72)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel9.TabIndex = 16
        Me.MetroLabel9.Text = "Dirección:"
        '
        'txtBuscaTel
        '
        Me.txtBuscaTel.Lines = New String(-1) {}
        Me.txtBuscaTel.Location = New System.Drawing.Point(90, 72)
        Me.txtBuscaTel.MaxLength = 32767
        Me.txtBuscaTel.Name = "txtBuscaTel"
        Me.txtBuscaTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscaTel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscaTel.SelectedText = ""
        Me.txtBuscaTel.Size = New System.Drawing.Size(150, 23)
        Me.txtBuscaTel.TabIndex = 17
        Me.txtBuscaTel.UseSelectable = True
        '
        'txtBuscaDir
        '
        Me.txtBuscaDir.Lines = New String(-1) {}
        Me.txtBuscaDir.Location = New System.Drawing.Point(327, 72)
        Me.txtBuscaDir.MaxLength = 32767
        Me.txtBuscaDir.Name = "txtBuscaDir"
        Me.txtBuscaDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscaDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscaDir.SelectedText = ""
        Me.txtBuscaDir.Size = New System.Drawing.Size(150, 23)
        Me.txtBuscaDir.TabIndex = 18
        Me.txtBuscaDir.UseSelectable = True
        '
        'txtNombre
        '
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(91, 117)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(150, 23)
        Me.txtNombre.TabIndex = 19
        Me.txtNombre.UseSelectable = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(91, 149)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.Size = New System.Drawing.Size(150, 23)
        Me.txtDireccion.TabIndex = 20
        Me.txtDireccion.UseSelectable = True
        '
        'txtEntreCalles
        '
        Me.txtEntreCalles.Lines = New String(-1) {}
        Me.txtEntreCalles.Location = New System.Drawing.Point(91, 184)
        Me.txtEntreCalles.MaxLength = 32767
        Me.txtEntreCalles.Name = "txtEntreCalles"
        Me.txtEntreCalles.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEntreCalles.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEntreCalles.SelectedText = ""
        Me.txtEntreCalles.Size = New System.Drawing.Size(150, 23)
        Me.txtEntreCalles.TabIndex = 21
        Me.txtEntreCalles.UseSelectable = True
        '
        'txtTelefonos
        '
        Me.txtTelefonos.Lines = New String(-1) {}
        Me.txtTelefonos.Location = New System.Drawing.Point(91, 219)
        Me.txtTelefonos.MaxLength = 32767
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefonos.SelectedText = ""
        Me.txtTelefonos.Size = New System.Drawing.Size(385, 23)
        Me.txtTelefonos.TabIndex = 22
        Me.txtTelefonos.UseSelectable = True
        '
        'txtDetallesDir
        '
        Me.txtDetallesDir.Lines = New String(-1) {}
        Me.txtDetallesDir.Location = New System.Drawing.Point(327, 117)
        Me.txtDetallesDir.MaxLength = 32767
        Me.txtDetallesDir.Name = "txtDetallesDir"
        Me.txtDetallesDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetallesDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDetallesDir.SelectedText = ""
        Me.txtDetallesDir.Size = New System.Drawing.Size(149, 23)
        Me.txtDetallesDir.TabIndex = 23
        Me.txtDetallesDir.UseSelectable = True
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Lines = New String(-1) {}
        Me.txtLocalidad.Location = New System.Drawing.Point(327, 149)
        Me.txtLocalidad.MaxLength = 32767
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLocalidad.SelectedText = ""
        Me.txtLocalidad.Size = New System.Drawing.Size(149, 23)
        Me.txtLocalidad.TabIndex = 24
        Me.txtLocalidad.UseSelectable = True
        '
        'txtCosto
        '
        Me.txtCosto.Lines = New String(-1) {}
        Me.txtCosto.Location = New System.Drawing.Point(327, 184)
        Me.txtCosto.MaxLength = 32767
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCosto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCosto.SelectedText = ""
        Me.txtCosto.Size = New System.Drawing.Size(149, 23)
        Me.txtCosto.TabIndex = 25
        Me.txtCosto.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(23, 260)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel10.TabIndex = 27
        Me.MetroLabel10.Text = "Lista de Comidas"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(309, 296)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel11.TabIndex = 29
        Me.MetroLabel11.Text = "Cantidad"
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedido.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvPedido.Location = New System.Drawing.Point(309, 359)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPedido.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPedido.Size = New System.Drawing.Size(610, 241)
        Me.dgvPedido.TabIndex = 30
        '
        'C1
        '
        Me.C1.HeaderText = "Comida"
        Me.C1.Name = "C1"
        Me.C1.Width = 200
        '
        'C2
        '
        Me.C2.HeaderText = "Cant"
        Me.C2.Name = "C2"
        Me.C2.Width = 50
        '
        'C3
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.C3.DefaultCellStyle = DataGridViewCellStyle7
        Me.C3.HeaderText = "PU"
        Me.C3.Name = "C3"
        Me.C3.Width = 70
        '
        'C4
        '
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.C4.DefaultCellStyle = DataGridViewCellStyle8
        Me.C4.HeaderText = "SubTotal"
        Me.C4.Name = "C4"
        Me.C4.Width = 80
        '
        'C5
        '
        Me.C5.HeaderText = "Agregado"
        Me.C5.Name = "C5"
        Me.C5.Width = 200
        '
        'numericCantidad
        '
        Me.numericCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.numericCantidad.Location = New System.Drawing.Point(309, 324)
        Me.numericCantidad.Name = "numericCantidad"
        Me.numericCantidad.Size = New System.Drawing.Size(98, 23)
        Me.numericCantidad.TabIndex = 31
        Me.numericCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(992, 428)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel12.TabIndex = 32
        Me.MetroLabel12.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTotal.Lines = New String(-1) {}
        Me.txtTotal.Location = New System.Drawing.Point(976, 452)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.Size = New System.Drawing.Size(83, 30)
        Me.txtTotal.TabIndex = 35
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotal.UseSelectable = True
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.Location = New System.Drawing.Point(327, 30)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoPedido.TabIndex = 37
        Me.btnNuevoPedido.Text = "Nuevo"
        Me.btnNuevoPedido.UseSelectable = True
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.BackColor = System.Drawing.Color.LightGray
        Me.btnGuardarCliente.Location = New System.Drawing.Point(483, 214)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(67, 28)
        Me.btnGuardarCliente.TabIndex = 38
        Me.btnGuardarCliente.Text = "Guardar"
        Me.btnGuardarCliente.UseVisualStyleBackColor = False
        '
        'wbMaps
        '
        Me.wbMaps.Location = New System.Drawing.Point(20, 13)
        Me.wbMaps.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMaps.Name = "wbMaps"
        Me.wbMaps.Size = New System.Drawing.Size(523, 292)
        Me.wbMaps.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.wbMaps)
        Me.Panel1.Location = New System.Drawing.Point(556, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 326)
        Me.Panel1.TabIndex = 40
        '
        'btnAgregarComida
        '
        Me.btnAgregarComida.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarComida.Image = Global.UI.My.Resources.Resources.down
        Me.btnAgregarComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarComida.Location = New System.Drawing.Point(413, 296)
        Me.btnAgregarComida.Name = "btnAgregarComida"
        Me.btnAgregarComida.Size = New System.Drawing.Size(136, 60)
        Me.btnAgregarComida.TabIndex = 36
        Me.btnAgregarComida.Text = "Agregar "
        Me.btnAgregarComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarComida.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.UI.My.Resources.Resources.printer
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimir.Location = New System.Drawing.Point(967, 505)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 95)
        Me.btnImprimir.TabIndex = 34
        Me.btnImprimir.Text = "Confirmar Pedido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[F5]"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.UI.My.Resources.Resources.delete
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(925, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 59)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Eliminar Descripción"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscar.BackgroundImage = Global.UI.My.Resources.Resources.system_search
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(483, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 135)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.UseSelectable = True
        '
        'tvComidas
        '
        Me.tvComidas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tvComidas.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.tvComidas.Location = New System.Drawing.Point(23, 282)
        Me.tvComidas.Name = "tvComidas"
        Me.tvComidas.Size = New System.Drawing.Size(270, 318)
        Me.tvComidas.TabIndex = 41
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(949, 457)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(21, 25)
        Me.MetroLabel13.TabIndex = 42
        Me.MetroLabel13.Text = "$"
        '
        'printDocument
        '
        '
        'printPreview
        '
        Me.printPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreview.Enabled = True
        Me.printPreview.Icon = CType(resources.GetObject("printPreview.Icon"), System.Drawing.Icon)
        Me.printPreview.Name = "printPreview"
        Me.printPreview.Visible = False
        '
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 623)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.tvComidas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Controls.Add(Me.btnAgregarComida)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.numericCantidad)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDetallesDir)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.txtEntreCalles)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtBuscaDir)
        Me.Controls.Add(Me.txtBuscaTel)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormPedidos"
        Me.Resizable = False
        Me.Text = "Administración de Pedidos"
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBuscaTel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBuscaDir As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEntreCalles As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefonos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDetallesDir As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLocalidad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCosto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvPedido As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents numericCantidad As NumericUpDown
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAgregarComida As Button
    Friend WithEvents btnNuevoPedido As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarCliente As Button
    Friend WithEvents wbMaps As WebBrowser
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tvComidas As TreeView
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents printDocument As Printing.PrintDocument
    Friend WithEvents printPreview As PrintPreviewDialog
End Class
