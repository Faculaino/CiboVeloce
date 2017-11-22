<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportes
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
        Me.crReportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnGenerarReporte = New MetroFramework.Controls.MetroButton()
        Me.dtFecha2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dtFecha1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cmbTipoReportes = New MetroFramework.Controls.MetroComboBox()
        Me.msManager = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.btnNuevoReporte = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.msManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crReportes
        '
        Me.crReportes.ActiveViewIndex = -1
        Me.crReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crReportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crReportes.Location = New System.Drawing.Point(1, 122)
        Me.crReportes.Name = "crReportes"
        Me.crReportes.Size = New System.Drawing.Size(925, 519)
        Me.crReportes.TabIndex = 0
        Me.crReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Tipo:"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.White
        Me.MetroPanel1.Controls.Add(Me.btnGenerarReporte)
        Me.MetroPanel1.Controls.Add(Me.dtFecha2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.dtFecha1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.cmbTipoReportes)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(1, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(925, 53)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(759, 13)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(145, 29)
        Me.btnGenerarReporte.TabIndex = 7
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseSelectable = True
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(562, 13)
        Me.dtFecha2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(106, 29)
        Me.dtFecha2.TabIndex = 6
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(505, 16)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Fecha2:"
        '
        'dtFecha1
        '
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(372, 13)
        Me.dtFecha1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(106, 29)
        Me.dtFecha1.TabIndex = 4
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(315, 16)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Fecha1:"
        '
        'cmbTipoReportes
        '
        Me.cmbTipoReportes.FormattingEnabled = True
        Me.cmbTipoReportes.ItemHeight = 23
        Me.cmbTipoReportes.Items.AddRange(New Object() {"Ventas", "Movimiento Caja", "Compras"})
        Me.cmbTipoReportes.Location = New System.Drawing.Point(67, 13)
        Me.cmbTipoReportes.Name = "cmbTipoReportes"
        Me.cmbTipoReportes.Size = New System.Drawing.Size(179, 29)
        Me.cmbTipoReportes.TabIndex = 2
        Me.cmbTipoReportes.UseSelectable = True
        '
        'msManager
        '
        Me.msManager.Owner = Nothing
        '
        'btnNuevoReporte
        '
        Me.btnNuevoReporte.Location = New System.Drawing.Point(329, 29)
        Me.btnNuevoReporte.Name = "btnNuevoReporte"
        Me.btnNuevoReporte.Size = New System.Drawing.Size(124, 23)
        Me.btnNuevoReporte.TabIndex = 3
        Me.btnNuevoReporte.Text = "Nuevo Reporte"
        Me.btnNuevoReporte.UseSelectable = True
        '
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 643)
        Me.Controls.Add(Me.btnNuevoReporte)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.crReportes)
        Me.Name = "FormReportes"
        Me.Resizable = False
        Me.Text = "Administración de Reportes"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.msManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crReportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents msManager As MetroFramework.Components.MetroStyleManager
    Friend WithEvents dtFecha1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbTipoReportes As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnGenerarReporte As MetroFramework.Controls.MetroButton
    Friend WithEvents dtFecha2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNuevoReporte As MetroFramework.Controls.MetroButton
End Class
