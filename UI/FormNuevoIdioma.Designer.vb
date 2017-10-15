<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoIdioma
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtNuevoIdioma = New MetroFramework.Controls.MetroTextBox()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre:"
        '
        'txtNuevoIdioma
        '
        Me.txtNuevoIdioma.Lines = New String(-1) {}
        Me.txtNuevoIdioma.Location = New System.Drawing.Point(92, 73)
        Me.txtNuevoIdioma.MaxLength = 32767
        Me.txtNuevoIdioma.Name = "txtNuevoIdioma"
        Me.txtNuevoIdioma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNuevoIdioma.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNuevoIdioma.SelectedText = ""
        Me.txtNuevoIdioma.Size = New System.Drawing.Size(185, 23)
        Me.txtNuevoIdioma.TabIndex = 1
        Me.txtNuevoIdioma.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(296, 72)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(89, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseSelectable = True
        '
        'FormNuevoIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 123)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNuevoIdioma)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FormNuevoIdioma"
        Me.Resizable = False
        Me.Text = "Nuevo Idioma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNuevoIdioma As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
End Class
