﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblMaps = New System.Windows.Forms.Label()
        Me.tvComidas = New System.Windows.Forms.TreeView()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.printDocument = New System.Drawing.Printing.PrintDocument()
        Me.printPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtAbona = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtVuelto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.txtComentario = New MetroFramework.Controls.MetroTextBox()
        Me.lblIDCliente = New System.Windows.Forms.Label()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.lblComanda = New MetroFramework.Controls.MetroLabel()
        Me.TimerMapa = New System.Windows.Forms.Timer(Me.components)
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.panelMaps = New System.Windows.Forms.Panel()
        Me.btnAgregarComida = New System.Windows.Forms.Button()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btnDeleteRow = New System.Windows.Forms.Button()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        '
        '
        Me.txtBuscaTel.CustomButton.Image = Nothing
        Me.txtBuscaTel.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtBuscaTel.CustomButton.Name = ""
        Me.txtBuscaTel.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBuscaTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBuscaTel.CustomButton.TabIndex = 1
        Me.txtBuscaTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBuscaTel.CustomButton.UseSelectable = True
        Me.txtBuscaTel.CustomButton.Visible = False
        Me.txtBuscaTel.Lines = New String(-1) {}
        Me.txtBuscaTel.Location = New System.Drawing.Point(90, 72)
        Me.txtBuscaTel.MaxLength = 32767
        Me.txtBuscaTel.Name = "txtBuscaTel"
        Me.txtBuscaTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscaTel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscaTel.SelectedText = ""
        Me.txtBuscaTel.SelectionLength = 0
        Me.txtBuscaTel.SelectionStart = 0
        Me.txtBuscaTel.ShortcutsEnabled = True
        Me.txtBuscaTel.Size = New System.Drawing.Size(150, 23)
        Me.txtBuscaTel.TabIndex = 17
        Me.txtBuscaTel.UseSelectable = True
        Me.txtBuscaTel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBuscaTel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBuscaDir
        '
        '
        '
        '
        Me.txtBuscaDir.CustomButton.Image = Nothing
        Me.txtBuscaDir.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtBuscaDir.CustomButton.Name = ""
        Me.txtBuscaDir.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBuscaDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBuscaDir.CustomButton.TabIndex = 1
        Me.txtBuscaDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBuscaDir.CustomButton.UseSelectable = True
        Me.txtBuscaDir.CustomButton.Visible = False
        Me.txtBuscaDir.Lines = New String(-1) {}
        Me.txtBuscaDir.Location = New System.Drawing.Point(327, 72)
        Me.txtBuscaDir.MaxLength = 32767
        Me.txtBuscaDir.Name = "txtBuscaDir"
        Me.txtBuscaDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscaDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscaDir.SelectedText = ""
        Me.txtBuscaDir.SelectionLength = 0
        Me.txtBuscaDir.SelectionStart = 0
        Me.txtBuscaDir.ShortcutsEnabled = True
        Me.txtBuscaDir.Size = New System.Drawing.Size(150, 23)
        Me.txtBuscaDir.TabIndex = 18
        Me.txtBuscaDir.UseSelectable = True
        Me.txtBuscaDir.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBuscaDir.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtNombre.Location = New System.Drawing.Point(91, 117)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(150, 23)
        Me.txtNombre.TabIndex = 19
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtDireccion.Location = New System.Drawing.Point(91, 149)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = True
        Me.txtDireccion.Size = New System.Drawing.Size(150, 23)
        Me.txtDireccion.TabIndex = 20
        Me.txtDireccion.UseSelectable = True
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtEntreCalles.Location = New System.Drawing.Point(91, 184)
        Me.txtEntreCalles.MaxLength = 32767
        Me.txtEntreCalles.Name = "txtEntreCalles"
        Me.txtEntreCalles.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEntreCalles.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEntreCalles.SelectedText = ""
        Me.txtEntreCalles.SelectionLength = 0
        Me.txtEntreCalles.SelectionStart = 0
        Me.txtEntreCalles.ShortcutsEnabled = True
        Me.txtEntreCalles.Size = New System.Drawing.Size(150, 23)
        Me.txtEntreCalles.TabIndex = 21
        Me.txtEntreCalles.UseSelectable = True
        Me.txtEntreCalles.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEntreCalles.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtTelefonos.Location = New System.Drawing.Point(91, 219)
        Me.txtTelefonos.MaxLength = 32767
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefonos.SelectedText = ""
        Me.txtTelefonos.SelectionLength = 0
        Me.txtTelefonos.SelectionStart = 0
        Me.txtTelefonos.ShortcutsEnabled = True
        Me.txtTelefonos.Size = New System.Drawing.Size(385, 23)
        Me.txtTelefonos.TabIndex = 22
        Me.txtTelefonos.UseSelectable = True
        Me.txtTelefonos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelefonos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtDetallesDir.Location = New System.Drawing.Point(327, 117)
        Me.txtDetallesDir.MaxLength = 32767
        Me.txtDetallesDir.Name = "txtDetallesDir"
        Me.txtDetallesDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetallesDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDetallesDir.SelectedText = ""
        Me.txtDetallesDir.SelectionLength = 0
        Me.txtDetallesDir.SelectionStart = 0
        Me.txtDetallesDir.ShortcutsEnabled = True
        Me.txtDetallesDir.Size = New System.Drawing.Size(149, 23)
        Me.txtDetallesDir.TabIndex = 23
        Me.txtDetallesDir.UseSelectable = True
        Me.txtDetallesDir.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDetallesDir.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtLocalidad.Location = New System.Drawing.Point(327, 149)
        Me.txtLocalidad.MaxLength = 32767
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLocalidad.SelectedText = ""
        Me.txtLocalidad.SelectionLength = 0
        Me.txtLocalidad.SelectionStart = 0
        Me.txtLocalidad.ShortcutsEnabled = True
        Me.txtLocalidad.Size = New System.Drawing.Size(149, 23)
        Me.txtLocalidad.TabIndex = 24
        Me.txtLocalidad.UseSelectable = True
        Me.txtLocalidad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLocalidad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtCosto.Location = New System.Drawing.Point(327, 184)
        Me.txtCosto.MaxLength = 32767
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCosto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCosto.SelectedText = ""
        Me.txtCosto.SelectionLength = 0
        Me.txtCosto.SelectionStart = 0
        Me.txtCosto.ShortcutsEnabled = True
        Me.txtCosto.Size = New System.Drawing.Size(149, 23)
        Me.txtCosto.TabIndex = 25
        Me.txtCosto.UseSelectable = True
        Me.txtCosto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCosto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.MetroLabel11.Location = New System.Drawing.Point(310, 323)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel11.TabIndex = 29
        Me.MetroLabel11.Text = "Cantidad"
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedido.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvPedido.Location = New System.Drawing.Point(309, 396)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPedido.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPedido.Size = New System.Drawing.Size(610, 204)
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
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.C3.DefaultCellStyle = DataGridViewCellStyle2
        Me.C3.HeaderText = "PU"
        Me.C3.Name = "C3"
        Me.C3.Width = 70
        '
        'C4
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.C4.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.numericCantidad.Location = New System.Drawing.Point(310, 351)
        Me.numericCantidad.Name = "numericCantidad"
        Me.numericCantidad.Size = New System.Drawing.Size(98, 23)
        Me.numericCantidad.TabIndex = 31
        Me.numericCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(975, 414)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel12.TabIndex = 32
        Me.MetroLabel12.Text = "TOTAL"
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.CustomButton.Image = Nothing
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTotal.Lines = New String() {"0"}
        Me.txtTotal.Location = New System.Drawing.Point(1044, 410)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.ShortcutsEnabled = True
        Me.txtTotal.Size = New System.Drawing.Size(83, 30)
        Me.txtTotal.TabIndex = 35
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        'lblMaps
        '
        Me.lblMaps.AutoSize = True
        Me.lblMaps.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaps.Location = New System.Drawing.Point(857, 338)
        Me.lblMaps.Name = "lblMaps"
        Me.lblMaps.Size = New System.Drawing.Size(170, 36)
        Me.lblMaps.TabIndex = 41
        Me.lblMaps.Text = "Google Maps"
        '
        'tvComidas
        '
        Me.tvComidas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tvComidas.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.tvComidas.Location = New System.Drawing.Point(23, 282)
        Me.tvComidas.Name = "tvComidas"
        Me.tvComidas.Size = New System.Drawing.Size(270, 357)
        Me.tvComidas.TabIndex = 41
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(1019, 411)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(791, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Powered by"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(1019, 447)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(21, 25)
        Me.MetroLabel14.TabIndex = 48
        Me.MetroLabel14.Text = "$"
        '
        'txtAbona
        '
        '
        '
        '
        Me.txtAbona.CustomButton.Image = Nothing
        Me.txtAbona.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtAbona.CustomButton.Name = ""
        Me.txtAbona.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAbona.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAbona.CustomButton.TabIndex = 1
        Me.txtAbona.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAbona.CustomButton.UseSelectable = True
        Me.txtAbona.CustomButton.Visible = False
        Me.txtAbona.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAbona.Lines = New String() {"0"}
        Me.txtAbona.Location = New System.Drawing.Point(1044, 446)
        Me.txtAbona.MaxLength = 32767
        Me.txtAbona.Name = "txtAbona"
        Me.txtAbona.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAbona.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAbona.SelectedText = ""
        Me.txtAbona.SelectionLength = 0
        Me.txtAbona.SelectionStart = 0
        Me.txtAbona.ShortcutsEnabled = True
        Me.txtAbona.Size = New System.Drawing.Size(83, 30)
        Me.txtAbona.TabIndex = 47
        Me.txtAbona.Text = "0"
        Me.txtAbona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAbona.UseSelectable = True
        Me.txtAbona.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAbona.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(978, 450)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel15.TabIndex = 46
        Me.MetroLabel15.Text = "Pagó"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel16.Location = New System.Drawing.Point(1019, 483)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(21, 25)
        Me.MetroLabel16.TabIndex = 51
        Me.MetroLabel16.Text = "$"
        '
        'txtVuelto
        '
        '
        '
        '
        Me.txtVuelto.CustomButton.Image = Nothing
        Me.txtVuelto.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtVuelto.CustomButton.Name = ""
        Me.txtVuelto.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtVuelto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtVuelto.CustomButton.TabIndex = 1
        Me.txtVuelto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtVuelto.CustomButton.UseSelectable = True
        Me.txtVuelto.CustomButton.Visible = False
        Me.txtVuelto.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtVuelto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtVuelto.Lines = New String() {"0"}
        Me.txtVuelto.Location = New System.Drawing.Point(1044, 482)
        Me.txtVuelto.MaxLength = 32767
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVuelto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtVuelto.SelectedText = ""
        Me.txtVuelto.SelectionLength = 0
        Me.txtVuelto.SelectionStart = 0
        Me.txtVuelto.ShortcutsEnabled = True
        Me.txtVuelto.Size = New System.Drawing.Size(83, 30)
        Me.txtVuelto.TabIndex = 50
        Me.txtVuelto.Text = "0"
        Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtVuelto.UseSelectable = True
        Me.txtVuelto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtVuelto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(975, 486)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel17.TabIndex = 49
        Me.MetroLabel17.Text = "Vuelto"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(309, 613)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel18.TabIndex = 52
        Me.MetroLabel18.Text = "Comentarios:"
        '
        'txtComentario
        '
        '
        '
        '
        Me.txtComentario.CustomButton.Image = Nothing
        Me.txtComentario.CustomButton.Location = New System.Drawing.Point(494, 2)
        Me.txtComentario.CustomButton.Name = ""
        Me.txtComentario.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtComentario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComentario.CustomButton.TabIndex = 1
        Me.txtComentario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComentario.CustomButton.UseSelectable = True
        Me.txtComentario.CustomButton.Visible = False
        Me.txtComentario.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtComentario.Lines = New String(-1) {}
        Me.txtComentario.Location = New System.Drawing.Point(397, 608)
        Me.txtComentario.MaxLength = 32767
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComentario.SelectedText = ""
        Me.txtComentario.SelectionLength = 0
        Me.txtComentario.SelectionStart = 0
        Me.txtComentario.ShortcutsEnabled = True
        Me.txtComentario.Size = New System.Drawing.Size(522, 30)
        Me.txtComentario.TabIndex = 53
        Me.txtComentario.UseSelectable = True
        Me.txtComentario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComentario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblIDCliente
        '
        Me.lblIDCliente.AutoSize = True
        Me.lblIDCliente.Location = New System.Drawing.Point(327, 260)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblIDCliente.TabIndex = 54
        Me.lblIDCliente.Visible = False
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(822, 374)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel19.TabIndex = 55
        Me.MetroLabel19.Text = "Pedido N°:"
        '
        'lblComanda
        '
        Me.lblComanda.AutoSize = True
        Me.lblComanda.Location = New System.Drawing.Point(890, 374)
        Me.lblComanda.Name = "lblComanda"
        Me.lblComanda.Size = New System.Drawing.Size(0, 0)
        Me.lblComanda.TabIndex = 56
        '
        'TimerMapa
        '
        '
        'wb
        '
        Me.wb.Location = New System.Drawing.Point(556, 52)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(595, 254)
        Me.wb.TabIndex = 59
        Me.wb.Visible = False
        '
        'panelMaps
        '
        Me.panelMaps.BackgroundImage = Global.UI.My.Resources.Resources.googleMaps
        Me.panelMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMaps.Location = New System.Drawing.Point(1033, 312)
        Me.panelMaps.Name = "panelMaps"
        Me.panelMaps.Size = New System.Drawing.Size(75, 70)
        Me.panelMaps.TabIndex = 40
        '
        'btnAgregarComida
        '
        Me.btnAgregarComida.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarComida.Image = Global.UI.My.Resources.Resources.down
        Me.btnAgregarComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarComida.Location = New System.Drawing.Point(414, 323)
        Me.btnAgregarComida.Name = "btnAgregarComida"
        Me.btnAgregarComida.Size = New System.Drawing.Size(113, 60)
        Me.btnAgregarComida.TabIndex = 36
        Me.btnAgregarComida.Text = "Agregar "
        Me.btnAgregarComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarComida.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.UI.My.Resources.Resources.printer
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimir.Location = New System.Drawing.Point(1004, 539)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 80)
        Me.btnImprimir.TabIndex = 34
        Me.btnImprimir.Text = "Confirmar Pedido"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.UseSelectable = True
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRow.Image = Global.UI.My.Resources.Resources.delete
        Me.btnDeleteRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteRow.Location = New System.Drawing.Point(533, 323)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(174, 60)
        Me.btnDeleteRow.TabIndex = 33
        Me.btnDeleteRow.Text = "Eliminar Descripción"
        Me.btnDeleteRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteRow.UseVisualStyleBackColor = True
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
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 652)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.lblComanda)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.lblIDCliente)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.txtVuelto)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.txtAbona)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMaps)
        Me.Controls.Add(Me.panelMaps)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.tvComidas)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Controls.Add(Me.btnAgregarComida)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnDeleteRow)
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
    Friend WithEvents btnDeleteRow As Button
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAgregarComida As Button
    Friend WithEvents btnNuevoPedido As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarCliente As Button
    Friend WithEvents tvComidas As TreeView
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents printDocument As Printing.PrintDocument
    Friend WithEvents printPreview As PrintPreviewDialog
    Friend WithEvents lblMaps As Label
    Friend WithEvents panelMaps As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAbona As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtVuelto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtComentario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblIDCliente As Label
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblComanda As MetroFramework.Controls.MetroLabel
    Friend WithEvents TimerMapa As Timer
    Friend WithEvents wb As WebBrowser
End Class
