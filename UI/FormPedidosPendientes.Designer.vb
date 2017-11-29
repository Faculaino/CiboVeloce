<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPedidosPendientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPedidosCocina = New System.Windows.Forms.DataGridView()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmbEstado = New MetroFramework.Controls.MetroComboBox()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.cmbCambiarEstado = New MetroFramework.Controls.MetroButton()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvPedidosCocina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidosCocina
        '
        Me.dgvPedidosCocina.AllowUserToAddRows = False
        Me.dgvPedidosCocina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidosCocina.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidosCocina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidosCocina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidosCocina.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPedidosCocina.Location = New System.Drawing.Point(4, 148)
        Me.dgvPedidosCocina.Name = "dgvPedidosCocina"
        Me.dgvPedidosCocina.ReadOnly = True
        Me.dgvPedidosCocina.RowHeadersVisible = False
        Me.dgvPedidosCocina.Size = New System.Drawing.Size(806, 312)
        Me.dgvPedidosCocina.TabIndex = 21
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel1.TabIndex = 22
        Me.MetroLabel1.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.ItemHeight = 23
        Me.cmbEstado.Location = New System.Drawing.Point(82, 70)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(162, 29)
        Me.cmbEstado.TabIndex = 23
        Me.cmbEstado.UseSelectable = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(113, 108)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 30)
        Me.btnBuscar.TabIndex = 24
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseSelectable = True
        '
        'cmbCambiarEstado
        '
        Me.cmbCambiarEstado.Location = New System.Drawing.Point(687, 108)
        Me.cmbCambiarEstado.Name = "cmbCambiarEstado"
        Me.cmbCambiarEstado.Size = New System.Drawing.Size(123, 30)
        Me.cmbCambiarEstado.TabIndex = 25
        Me.cmbCambiarEstado.Text = "Cambiar Estados"
        Me.cmbCambiarEstado.UseSelectable = True
        '
        'C1
        '
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.C1.DefaultCellStyle = DataGridViewCellStyle2
        Me.C1.HeaderText = "Fecha"
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        Me.C1.Width = 140
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
        Me.C4.HeaderText = "Estado"
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        Me.C4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.C4.Width = 120
        '
        'C5
        '
        Me.C5.HeaderText = "Selec."
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        '
        'FormPedidosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 462)
        Me.Controls.Add(Me.cmbCambiarEstado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dgvPedidosCocina)
        Me.Name = "FormPedidosPendientes"
        Me.Resizable = False
        Me.Text = "Pedidos Pendientes"
        CType(Me.dgvPedidosCocina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPedidosCocina As DataGridView
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbEstado As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbCambiarEstado As MetroFramework.Controls.MetroButton
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewCheckBoxColumn
End Class
