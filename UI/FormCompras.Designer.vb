﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompras
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionarProveedor = New MetroFramework.Controls.MetroButton()
        Me.dgvListaItems = New System.Windows.Forms.DataGridView()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblIDProveedor = New MetroFramework.Controls.MetroLabel()
        Me.btnNuevaCompra = New MetroFramework.Controls.MetroButton()
        Me.btnCargarLista = New MetroFramework.Controls.MetroButton()
        Me.btnVerCompras = New MetroFramework.Controls.MetroButton()
        Me.btnNuevoProveedor = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C1, Me.C2, Me.C3, Me.C4})
        Me.dgvProveedores.Location = New System.Drawing.Point(15, 64)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RowHeadersVisible = False
        Me.dgvProveedores.Size = New System.Drawing.Size(454, 150)
        Me.dgvProveedores.TabIndex = 0
        '
        'C1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1.DefaultCellStyle = DataGridViewCellStyle2
        Me.C1.HeaderText = "Nombre"
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        Me.C1.Width = 150
        '
        'C2
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2.DefaultCellStyle = DataGridViewCellStyle3
        Me.C2.HeaderText = "Dirección"
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        Me.C2.Width = 150
        '
        'C3
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3.DefaultCellStyle = DataGridViewCellStyle4
        Me.C3.HeaderText = "Teléfono"
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        Me.C3.Width = 150
        '
        'C4
        '
        Me.C4.HeaderText = "ID"
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        Me.C4.Visible = False
        '
        'btnSeleccionarProveedor
        '
        Me.btnSeleccionarProveedor.Location = New System.Drawing.Point(15, 221)
        Me.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor"
        Me.btnSeleccionarProveedor.Size = New System.Drawing.Size(110, 23)
        Me.btnSeleccionarProveedor.TabIndex = 1
        Me.btnSeleccionarProveedor.Text = "Seleccionar"
        Me.btnSeleccionarProveedor.UseSelectable = True
        '
        'dgvListaItems
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C5, Me.C6})
        Me.dgvListaItems.Location = New System.Drawing.Point(493, 64)
        Me.dgvListaItems.Name = "dgvListaItems"
        Me.dgvListaItems.RowHeadersVisible = False
        Me.dgvListaItems.Size = New System.Drawing.Size(304, 223)
        Me.dgvListaItems.TabIndex = 2
        '
        'C5
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5.DefaultCellStyle = DataGridViewCellStyle6
        Me.C5.HeaderText = "Cant"
        Me.C5.Name = "C5"
        Me.C5.Width = 50
        '
        'C6
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C6.DefaultCellStyle = DataGridViewCellStyle7
        Me.C6.HeaderText = "Detalle Item"
        Me.C6.Name = "C6"
        Me.C6.Width = 250
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.AutoSize = True
        Me.lblIDProveedor.Location = New System.Drawing.Point(140, 221)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(0, 0)
        Me.lblIDProveedor.TabIndex = 3
        Me.lblIDProveedor.Visible = False
        '
        'btnNuevaCompra
        '
        Me.btnNuevaCompra.Location = New System.Drawing.Point(15, 269)
        Me.btnNuevaCompra.Name = "btnNuevaCompra"
        Me.btnNuevaCompra.Size = New System.Drawing.Size(454, 47)
        Me.btnNuevaCompra.TabIndex = 4
        Me.btnNuevaCompra.Text = "Generar Orden de Compra"
        Me.btnNuevaCompra.UseSelectable = True
        '
        'btnCargarLista
        '
        Me.btnCargarLista.Location = New System.Drawing.Point(687, 293)
        Me.btnCargarLista.Name = "btnCargarLista"
        Me.btnCargarLista.Size = New System.Drawing.Size(110, 23)
        Me.btnCargarLista.TabIndex = 5
        Me.btnCargarLista.Text = "Cargar Lista"
        Me.btnCargarLista.UseSelectable = True
        '
        'btnVerCompras
        '
        Me.btnVerCompras.Location = New System.Drawing.Point(316, 27)
        Me.btnVerCompras.Name = "btnVerCompras"
        Me.btnVerCompras.Size = New System.Drawing.Size(110, 23)
        Me.btnVerCompras.TabIndex = 6
        Me.btnVerCompras.Text = "Ver Compras"
        Me.btnVerCompras.UseSelectable = True
        '
        'btnNuevoProveedor
        '
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(359, 220)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(110, 23)
        Me.btnNuevoProveedor.TabIndex = 7
        Me.btnNuevoProveedor.Text = "Nuevo Proveedor"
        Me.btnNuevoProveedor.UseSelectable = True
        '
        'FormCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 340)
        Me.Controls.Add(Me.btnNuevoProveedor)
        Me.Controls.Add(Me.btnVerCompras)
        Me.Controls.Add(Me.btnCargarLista)
        Me.Controls.Add(Me.btnNuevaCompra)
        Me.Controls.Add(Me.lblIDProveedor)
        Me.Controls.Add(Me.dgvListaItems)
        Me.Controls.Add(Me.btnSeleccionarProveedor)
        Me.Controls.Add(Me.dgvProveedores)
        Me.Name = "FormCompras"
        Me.Resizable = False
        Me.Text = "Administración de Compras"
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents btnSeleccionarProveedor As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvListaItems As DataGridView
    Friend WithEvents lblIDProveedor As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNuevaCompra As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargarLista As MetroFramework.Controls.MetroButton
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents C6 As DataGridViewTextBoxColumn
    Friend WithEvents btnVerCompras As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevoProveedor As MetroFramework.Controls.MetroButton
End Class
