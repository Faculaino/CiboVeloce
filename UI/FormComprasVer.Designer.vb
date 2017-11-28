<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComprasVer
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModificarCompra = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmbProveedores = New MetroFramework.Controls.MetroComboBox()
        Me.btnBuscarEstado = New MetroFramework.Controls.MetroButton()
        Me.btnBuscarProveedor = New MetroFramework.Controls.MetroButton()
        Me.cmbEstados = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5})
        Me.dgvCompras.Location = New System.Drawing.Point(13, 118)
        Me.dgvCompras.Name = "dgvCompras"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCompras.RowHeadersVisible = False
        Me.dgvCompras.Size = New System.Drawing.Size(704, 221)
        Me.dgvCompras.TabIndex = 0
        '
        'C1
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.C1.DefaultCellStyle = DataGridViewCellStyle2
        Me.C1.HeaderText = "Fecha"
        Me.C1.Name = "C1"
        Me.C1.Width = 80
        '
        'C2
        '
        Me.C2.HeaderText = "Proveedor"
        Me.C2.Name = "C2"
        Me.C2.Width = 150
        '
        'C3
        '
        Me.C3.HeaderText = "Lista Items"
        Me.C3.Name = "C3"
        Me.C3.Width = 300
        '
        'C4
        '
        Me.C4.HeaderText = "Estado"
        Me.C4.Name = "C4"
        '
        'C5
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.C5.DefaultCellStyle = DataGridViewCellStyle3
        Me.C5.HeaderText = "Monto"
        Me.C5.Name = "C5"
        Me.C5.Width = 70
        '
        'btnModificarCompra
        '
        Me.btnModificarCompra.Location = New System.Drawing.Point(579, 345)
        Me.btnModificarCompra.Name = "btnModificarCompra"
        Me.btnModificarCompra.Size = New System.Drawing.Size(138, 23)
        Me.btnModificarCompra.TabIndex = 1
        Me.btnModificarCompra.Text = "Modificar"
        Me.btnModificarCompra.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 69)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Proveedor"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.ItemHeight = 23
        Me.cmbProveedores.Location = New System.Drawing.Point(90, 63)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(163, 29)
        Me.cmbProveedores.TabIndex = 3
        Me.cmbProveedores.UseSelectable = True
        '
        'btnBuscarEstado
        '
        Me.btnBuscarEstado.Location = New System.Drawing.Point(627, 63)
        Me.btnBuscarEstado.Name = "btnBuscarEstado"
        Me.btnBuscarEstado.Size = New System.Drawing.Size(80, 29)
        Me.btnBuscarEstado.TabIndex = 4
        Me.btnBuscarEstado.Text = "Buscar"
        Me.btnBuscarEstado.UseSelectable = True
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(271, 63)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(80, 29)
        Me.btnBuscarProveedor.TabIndex = 7
        Me.btnBuscarProveedor.Text = "Buscar"
        Me.btnBuscarProveedor.UseSelectable = True
        '
        'cmbEstados
        '
        Me.cmbEstados.FormattingEnabled = True
        Me.cmbEstados.ItemHeight = 23
        Me.cmbEstados.Location = New System.Drawing.Point(446, 63)
        Me.cmbEstados.Name = "cmbEstados"
        Me.cmbEstados.Size = New System.Drawing.Size(163, 29)
        Me.cmbEstados.TabIndex = 6
        Me.cmbEstados.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(383, 69)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Estado"
        '
        'FormComprasVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 379)
        Me.Controls.Add(Me.btnBuscarProveedor)
        Me.Controls.Add(Me.cmbEstados)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnBuscarEstado)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnModificarCompra)
        Me.Controls.Add(Me.dgvCompras)
        Me.Name = "FormComprasVer"
        Me.Resizable = False
        Me.Text = " Lista de Compras"
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents btnModificarCompra As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbProveedores As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBuscarEstado As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscarProveedor As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbEstados As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
