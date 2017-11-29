<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargaMapa
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTexto = New MetroFramework.Controls.MetroLabel()
        Me.metroProgress = New MetroFramework.Controls.MetroProgressBar()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Location = New System.Drawing.Point(164, 99)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(0, 0)
        Me.lblTexto.TabIndex = 60
        '
        'metroProgress
        '
        Me.metroProgress.Location = New System.Drawing.Point(47, 49)
        Me.metroProgress.Name = "metroProgress"
        Me.metroProgress.Size = New System.Drawing.Size(335, 37)
        Me.metroProgress.TabIndex = 59
        '
        'Timer
        '
        '
        'FormCargaMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 135)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.metroProgress)
        Me.Name = "FormCargaMapa"
        Me.Resizable = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTexto As MetroFramework.Controls.MetroLabel
    Friend WithEvents metroProgress As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Timer As Timer
End Class
