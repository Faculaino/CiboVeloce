<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResponsableCocina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResponsableCocina))
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.Calculator1 = New DevComponents.Editors.Calculator()
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnPedidos = New MetroFramework.Controls.MetroButton()
        Me.btnAdminComida = New MetroFramework.Controls.MetroButton()
        Me.btnPedidosHistorial = New MetroFramework.Controls.MetroButton()
        Me.btnCerrarSesion = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(81, 370)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(128, 128)
        Me.ReflectionImage1.TabIndex = 13
        '
        'Calculator1
        '
        Me.Calculator1.AutoSize = True
        Me.Calculator1.Location = New System.Drawing.Point(45, 137)
        Me.Calculator1.Name = "Calculator1"
        Me.Calculator1.Size = New System.Drawing.Size(190, 211)
        Me.Calculator1.Text = "Calculator1"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(23, 83)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(252, 29)
        Me.dtpFecha.TabIndex = 12
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(603, 404)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(207, 70)
        Me.ReflectionLabel1.TabIndex = 18
        Me.ReflectionLabel1.Text = "<b><font size=""+18""><i>Cibo</i><font color=""#33CCFF"">Veloce</font></font></b>"
        '
        'btnPedidos
        '
        Me.btnPedidos.BackgroundImage = Global.UI.My.Resources.Resources.pedido
        Me.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPedidos.Location = New System.Drawing.Point(304, 83)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(149, 119)
        Me.btnPedidos.TabIndex = 19
        Me.btnPedidos.Text = "Nuevo Pedido"
        Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPedidos.UseSelectable = True
        '
        'btnAdminComida
        '
        Me.btnAdminComida.BackgroundImage = Global.UI.My.Resources.Resources.comida
        Me.btnAdminComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdminComida.Location = New System.Drawing.Point(483, 83)
        Me.btnAdminComida.Name = "btnAdminComida"
        Me.btnAdminComida.Size = New System.Drawing.Size(149, 119)
        Me.btnAdminComida.TabIndex = 20
        Me.btnAdminComida.Text = "Administración de Carta"
        Me.btnAdminComida.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdminComida.UseSelectable = True
        '
        'btnPedidosHistorial
        '
        Me.btnPedidosHistorial.BackgroundImage = Global.UI.My.Resources.Resources.registrosPedidos
        Me.btnPedidosHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPedidosHistorial.Location = New System.Drawing.Point(661, 83)
        Me.btnPedidosHistorial.Name = "btnPedidosHistorial"
        Me.btnPedidosHistorial.Size = New System.Drawing.Size(149, 119)
        Me.btnPedidosHistorial.TabIndex = 24
        Me.btnPedidosHistorial.Text = "Adm. de Pedidos"
        Me.btnPedidosHistorial.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPedidosHistorial.UseSelectable = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackgroundImage = Global.UI.My.Resources.Resources.sinsesion
        Me.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrarSesion.Location = New System.Drawing.Point(661, 229)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(149, 119)
        Me.btnCerrarSesion.TabIndex = 25
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrarSesion.UseSelectable = True
        '
        'FormResponsableCocina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 507)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnPedidosHistorial)
        Me.Controls.Add(Me.btnAdminComida)
        Me.Controls.Add(Me.btnPedidos)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Controls.Add(Me.Calculator1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Name = "FormResponsableCocina"
        Me.Resizable = False
        Me.Text = "Menú Principal Cocina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents Calculator1 As DevComponents.Editors.Calculator
    Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnPedidos As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdminComida As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPedidosHistorial As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrarSesion As MetroFramework.Controls.MetroButton
End Class
