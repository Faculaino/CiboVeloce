<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBaseDeDatos
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
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.BackgroundImage = Global.UI.My.Resources.Resources.data_up
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBackup.Location = New System.Drawing.Point(82, 118)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(149, 119)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.BackgroundImage = Global.UI.My.Resources.Resources.data_redo
        Me.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestore.Location = New System.Drawing.Point(367, 118)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(149, 119)
        Me.btnRestore.TabIndex = 6
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'FormBaseDeDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 294)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.Name = "FormBaseDeDatos"
        Me.Resizable = False
        Me.Text = "Administración de Base de Datos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnRestore As Button
End Class
