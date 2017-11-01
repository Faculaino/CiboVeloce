<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaCategoria
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
        Me.txtCategoria = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnNuevaCategoria = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtCategoria
        '
        Me.txtCategoria.Lines = New String(-1) {}
        Me.txtCategoria.Location = New System.Drawing.Point(98, 63)
        Me.txtCategoria.MaxLength = 32767
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCategoria.SelectedText = ""
        Me.txtCategoria.Size = New System.Drawing.Size(155, 23)
        Me.txtCategoria.TabIndex = 4
        Me.txtCategoria.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(25, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Categoría"
        '
        'btnNuevaCategoria
        '
        Me.btnNuevaCategoria.Location = New System.Drawing.Point(280, 63)
        Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
        Me.btnNuevaCategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevaCategoria.TabIndex = 5
        Me.btnNuevaCategoria.Text = "Agregar"
        Me.btnNuevaCategoria.UseSelectable = True
        '
        'FormNuevaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 112)
        Me.Controls.Add(Me.btnNuevaCategoria)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormNuevaCategoria"
        Me.Resizable = False
        Me.Text = "Nueva Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCategoria As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNuevaCategoria As MetroFramework.Controls.MetroButton
End Class
