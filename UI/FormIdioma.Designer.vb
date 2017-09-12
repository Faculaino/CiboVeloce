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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbIdiomas = New System.Windows.Forms.ComboBox()
        Me.btnSeleccionarIdioma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Idioma"
        '
        'cmbIdiomas
        '
        Me.cmbIdiomas.FormattingEnabled = True
        Me.cmbIdiomas.Location = New System.Drawing.Point(57, 10)
        Me.cmbIdiomas.Name = "cmbIdiomas"
        Me.cmbIdiomas.Size = New System.Drawing.Size(201, 21)
        Me.cmbIdiomas.TabIndex = 1
        '
        'btnSeleccionarIdioma
        '
        Me.btnSeleccionarIdioma.Location = New System.Drawing.Point(33, 49)
        Me.btnSeleccionarIdioma.Name = "btnSeleccionarIdioma"
        Me.btnSeleccionarIdioma.Size = New System.Drawing.Size(225, 24)
        Me.btnSeleccionarIdioma.TabIndex = 2
        Me.btnSeleccionarIdioma.Text = "Seleccionar Idioma"
        Me.btnSeleccionarIdioma.UseVisualStyleBackColor = True
        '
        'FormIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 85)
        Me.Controls.Add(Me.btnSeleccionarIdioma)
        Me.Controls.Add(Me.cmbIdiomas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormIdioma"
        Me.Text = "Lista de Idiomas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbIdiomas As ComboBox
    Friend WithEvents btnSeleccionarIdioma As Button
End Class
