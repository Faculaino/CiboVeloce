<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaja
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtFecha1 = New MetroFramework.Controls.MetroDateTime()
        Me.dtFecha2 = New MetroFramework.Controls.MetroDateTime()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 76)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Fecha de Inicio:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 117)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Fecha de Fin:"
        '
        'dtFecha1
        '
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(126, 72)
        Me.dtFecha1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(106, 29)
        Me.dtFecha1.TabIndex = 2
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(126, 111)
        Me.dtFecha2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(106, 29)
        Me.dtFecha2.TabIndex = 3
        '
        'dgvCaja
        '
        Me.dgvCaja.AllowUserToAddRows = False
        Me.dgvCaja.AllowUserToDeleteRows = False
        Me.dgvCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4, Me.C5, Me.C6})
        Me.dgvCaja.Location = New System.Drawing.Point(4, 164)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.ReadOnly = True
        Me.dgvCaja.RowHeadersVisible = False
        Me.dgvCaja.Size = New System.Drawing.Size(880, 303)
        Me.dgvCaja.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscar.BackgroundImage = Global.UI.My.Resources.Resources.system_search
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Location = New System.Drawing.Point(238, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 70)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.UseSelectable = True
        '
        'C1
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.C1.DefaultCellStyle = DataGridViewCellStyle2
        Me.C1.HeaderText = "Fecha"
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        Me.C1.Width = 120
        '
        'C2
        '
        Me.C2.HeaderText = "Descripcion"
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        Me.C2.Width = 200
        '
        'C3
        '
        Me.C3.HeaderText = "Cliente"
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        '
        'C4
        '
        Me.C4.HeaderText = "Detalle"
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        Me.C4.Width = 220
        '
        'C5
        '
        Me.C5.HeaderText = "Usuario"
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        Me.C5.Width = 135
        '
        'C6
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.C6.DefaultCellStyle = DataGridViewCellStyle3
        Me.C6.HeaderText = "Importe"
        Me.C6.Name = "C6"
        Me.C6.ReadOnly = True
        '
        'FormCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 471)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvCaja)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.dtFecha1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormCaja"
        Me.Resizable = False
        Me.Text = "Administración de Caja"
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtFecha1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtFecha2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dgvCaja As DataGridView
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents C6 As DataGridViewTextBoxColumn
End Class
