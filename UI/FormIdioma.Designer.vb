<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIdioma
    Inherits System.Windows.Forms.Form

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmbIdioma = New MetroFramework.Controls.MetroComboBox()
        Me.btnSeleccionar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Tag = "1"
        Me.MetroLabel1.Text = "Idioma"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'cmbIdioma
        '
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.ItemHeight = 23
        Me.cmbIdioma.Location = New System.Drawing.Point(79, 14)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(179, 29)
        Me.cmbIdioma.TabIndex = 4
        Me.cmbIdioma.UseSelectable = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(14, 60)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(244, 23)
        Me.btnSeleccionar.TabIndex = 5
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseSelectable = True
        '
        'FormIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 97)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.cmbIdioma)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormIdioma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Idiomas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbIdioma As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSeleccionar As MetroFramework.Controls.MetroButton
End Class
