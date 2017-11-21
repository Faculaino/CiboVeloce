Imports EE
Imports BLL
Imports MetroFramework
Imports System.Text
Imports System.Drawing.Printing
Imports Servicios

Public Class FormPedidos

    Private direccion As String = ""

    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBuscaTel.Select()
        formatControls()
        clearFields()
        cargarTree()

        'cargarTreeComposite()
    End Sub



    Sub cargarTree()
        Dim categoriaB = New CategoriaBussines
        Dim contador = 0

        tvComidas.Nodes.Clear()
        For Each nodo In categoriaB.listarCategorias()
            Dim comida = nodo.listaComidas
            Dim NodoCategoria As New TreeNode(nodo.tipo)
            NodoCategoria.Tag = nodo.ID
            tvComidas.Nodes.Add(NodoCategoria)

            For Each food In comida
                Dim NodoComida As New TreeNode(food.detalle + " - $" + food.precio.ToString())
                NodoComida.Tag = food.ID
                tvComidas.Nodes(contador).Nodes.Add(NodoComida)

            Next
            contador += 1

        Next
    End Sub

    Sub cargarTreeComposite()

    End Sub



    Sub localizacion()

        Dim query = New StringBuilder
        query.Append("http://maps.google.com/maps?q=")

        If txtDireccion.Text <> "" Then
            query.Append(txtDireccion.Text + "," & "+")
        End If

        If txtLocalidad.Text <> "" Then
            query.Append(txtLocalidad.Text + "," & "+")
        End If
        Try
            'wbMaps.Navigate(query.ToString())

            'wbMaps.Navigate("https://www.google.com.ar/maps/search/" & txtDireccion.Text & "+" & txtLocalidad.Text & "+" & "Buenos Aires" & "+" & "Argentina" & "+")
            WebKitBrowser1.Navigate("www.maps.google.com.ar/maps?q= " + txtDireccion.Text + ",+" + txtLocalidad.Text)
        Catch ex As Exception
            WebKitBrowser1.Navigate("")
            MsgBox("Error en el Servicio de Google Maps")
            lblMaps.Visible = True
            panelMaps.Visible = True
        End Try


    End Sub

    Sub formatControls()
        btnGuardarCliente.BackColor = Color.LightGray
    End Sub

    Sub clearFields()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtEntreCalles.Text = ""
        txtTelefonos.Text = ""
        txtDetallesDir.Text = ""
        txtLocalidad.Text = ""
        txtCosto.Text = ""

        txtBuscaDir.Text = ""
        txtBuscaTel.Text = ""

        dgvPedido.Rows.Clear()

        txtTotal.Text = ""
        WebKitBrowser1.Navigate("")

        lblMaps.Visible = True
        panelMaps.Visible = True

        bandera = False

        cargarTree()
    End Sub

    Dim bandera = False
    Sub buscarCliente()
        Dim nuevoCliente = New ClienteBussines
        Dim clienteBuscado = New ClienteEntity

        If txtBuscaDir.Text = "" Then
            clienteBuscado = nuevoCliente.buscarClienteTEL(txtBuscaTel.Text)
            If clienteBuscado Is Nothing Then
                MsgBox("Realice la busqueda por Dirección")
                txtBuscaTel.Text = ""
                txtBuscaDir.Select()
                bandera = True
            Else
                mostrarCliente(clienteBuscado)
            End If
        ElseIf txtBuscaTel.Text = "" And bandera = True Then
            clienteBuscado = nuevoCliente.buscarClienteDIR(txtBuscaDir.Text)
            If clienteBuscado Is Nothing Then
                Dim resultado = MsgBox("¿Desea agregar un Nuevo Cliente?", MsgBoxStyle.YesNo, "Cliente Inexistente")
                If resultado = MsgBoxResult.Yes Then
                    clearFields()
                    txtNombre.Select()
                    btnGuardarCliente.BackColor = Color.GreenYellow
                ElseIf resultado = MsgBoxResult.No Then
                    clearFields()
                    formatControls()
                    txtBuscaTel.Select()
                End If
            Else
                mostrarCliente(clienteBuscado)
            End If
        ElseIf txtBuscaTel.Text = "" And bandera = False Then
            MsgBox("Realice la busqueda por Teléfono")
            txtBuscaDir.Text = ""
            txtBuscaTel.Select()
        Else
            MsgBox("Ingrese Teléfono o Dirección para buscar")
            clearFields()
        End If
    End Sub



    Sub mostrarCliente(cliente As ClienteEntity)
        If cliente Is Nothing Then
            MetroMessageBox.Show(Me, "Reintente la busqueda por Teléfono o Dirección", "Cliente Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtNombre.Text = cliente.apyn
            txtDireccion.Text = cliente.direccion
            txtEntreCalles.Text = cliente.entreCalles
            txtTelefonos.Text = cliente.telefonos
            txtDetallesDir.Text = cliente.detalleDireccion
            txtLocalidad.Text = cliente.localidad
            txtCosto.Text = cliente.costo
            lblIDCliente.Text = cliente.ID

            direccion = txtDireccion.Text

            txtTotal.Text = CDec(cliente.costo.ToString())

            localizacion()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscaDir.Text = "" And txtBuscaTel.Text = "" Then
            MsgBox("Ingrese Teléfono o Dirección para buscar")
        Else
            buscarCliente()
        End If

    End Sub

    'Private Sub txtBuscaTel_Click(sender As Object, e As EventArgs) Handles txtBuscaTel.Click

    'End Sub

    Private Sub txtBuscaTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscaTel.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBuscaTel.Text = "" Then
                MsgBox("Ingrese un teléfono válido")
            Else
                'Dim nuevoCliente = New ClienteBussines
                'Dim buscaCliente = New ClienteEntity
                'buscaCliente = nuevoCliente.buscarClienteTEL(txtBuscaTel.Text)
                'If buscaCliente Is Nothing Then
                '    MsgBox("Realice la busqueda por Dirección")
                '    txtBuscaTel.Text = ""
                '    txtBuscaDir.Select()
                'Else
                '    mostrarCliente(buscaCliente)
                'End If
                buscarCliente()
            End If
        End If
    End Sub

    'Private Sub txtBuscaDir_Click(sender As Object, e As EventArgs) Handles txtBuscaDir.Click

    'End Sub

    Private Sub txtBuscaDir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscaDir.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBuscaDir.Text = "" Then
                MsgBox("Ingrese una dirección válida")
            Else
                'Dim nuevoCliente = New ClienteBussines
                'Dim buscaCliente = New ClienteEntity
                'buscaCliente = nuevoCliente.buscarClienteDIR(txtBuscaTel.Text)
                'If buscaCliente Is Nothing Then
                '    MsgBox("Realice la busqueda por Teléfono")
                '    txtBuscaDir.Text = ""
                '    txtBuscaTel.Select()
                'Else
                '    mostrarCliente(buscaCliente)
                'End If
                buscarCliente()
            End If
        End If
    End Sub

    Private Sub btnNuevoPedido_Click(sender As Object, e As EventArgs) Handles btnNuevoPedido.Click
        clearFields()
        txtBuscaTel.Select()
        formatControls()
        WebKitBrowser1.Navigate("")
        lblMaps.Visible = True
        panelMaps.Visible = True
        cargarTree()
    End Sub

    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        Dim nuevoCliente = New ClienteBussines
        Dim datosCliente = New ClienteEntity

        datosCliente.apyn = txtNombre.Text
        datosCliente.direccion = txtDireccion.Text
        datosCliente.localidad = txtLocalidad.Text
        datosCliente.telefonos = txtTelefonos.Text
        datosCliente.entreCalles = txtEntreCalles.Text
        datosCliente.detalleDireccion = txtDetallesDir.Text
        datosCliente.costo = txtCosto.Text

        Dim buscaCliente = New ClienteEntity
        buscaCliente = nuevoCliente.searchCliente(datosCliente.apyn, direccion)

        If buscaCliente Is Nothing Then
            datosCliente.direccion = txtDireccion.Text
            nuevoCliente.insertCliente(datosCliente)
            MsgBox("Cliente ingresado correctamente")
        Else
            nuevoCliente.updateCliente(datosCliente, buscaCliente.ID)
            MsgBox("Se actualizó el Cliente correctamente")
            Dim bitacora = New BitacoraBussines
            bitacora.controlCambios("Modificar Datos Cliente", SessionManager.Instance.Usuario)
        End If




    End Sub

    Private Sub btnAgregarComida_Click(sender As Object, e As EventArgs) Handles btnAgregarComida.Click
        If txtNombre.Text = "" Then
            MsgBox("Seleccione un Cliente")
        Else
            Dim nodo = tvComidas.SelectedNode.Text.Split("-")
            Dim categoria = tvComidas.SelectedNode.Parent.Text.ToString()
            Dim comida = nodo(0)
            Dim precio = nodo(1)
            Dim cantidad = numericCantidad.Value

            dgvPedido.Rows.Add(categoria + " - " + comida, cantidad, precio, precio * cantidad)
            Dim total As Decimal = 0
            For Each item As DataGridViewRow In dgvPedido.Rows
                total += item.Cells("C4").Value
                txtTotal.Text = total.ToString()
            Next



        End If
    End Sub



    Sub imprimir()
        printPreview.Document = printDocument
        printPreview.ShowDialog()

        'printDocument.Print()

    End Sub

    Private Sub FormPedidos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'imprimir()
        nuevoPedido()
        'MailManager.enviarMail(txtNombre.Text, "Factura Compra", "Se envía factura por compra de $" + txtTotal.Text)
        clearFields()

    End Sub

    Sub nuevoPedido()
        Dim nuevoPedido = New PedidoEntity
        Dim pedidoBussines = New PedidoBussines
        Dim listaComida As String = ""

        For Each item As DataGridViewRow In dgvPedido.Rows
            If item.Cells("C2").Value.ToString() = "" Then

            Else
                listaComida += item.Cells("C2").Value.ToString() + " " + item.Cells("C1").Value.ToString() + " , "
            End If

        Next
        listaComida = listaComida.Remove(listaComida.Length - 2)
        nuevoPedido.fechahora = Now
        nuevoPedido.idEstado = 1
        nuevoPedido.listaComida = listaComida
        nuevoPedido.idUsuario = SessionManager.Instance.Usuario.ID
        nuevoPedido.idCliente = CInt(lblIDCliente.Text.ToString())
        nuevoPedido.total = CDec(txtTotal.Text.ToString())

        pedidoBussines.nuevoPedido(nuevoPedido)



    End Sub



    Private Sub btnImprimir_KeyDown(sender As Object, e As KeyEventArgs) Handles btnImprimir.KeyDown
        If e.KeyValue = Keys.F5 Then

        End If
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocument.PrintPage
        Dim fuente As New Font("Calibri", 15, FontStyle.Regular)
        Dim empresa As String = "Nombre de la Empresa / " + Now.ToShortDateString() + " / HS: " + Now.ToShortTimeString()
        Dim cliente As String = txtNombre.Text + " - " + txtBuscaTel.Text

        'Formato del PrintDocument
        '----------------------------------------------------------------------------------
        Dim rect As Rectangle = New Rectangle(New Point(0, 0), My.Resources.ComandaA6.Size)
        e.Graphics.DrawImage(My.Resources.ComandaA6, rect)
        Dim pagina As New PaperSize("A6", 399.93701, 599.90551)
        pagina.PaperName = PaperKind.A6
        printDocument.DefaultPageSettings.PaperSize = pagina
        '----------------------------------------------------------------------------------

        e.Graphics.DrawString(empresa, fuente, Brushes.Black, 30, 30)
        e.Graphics.DrawString("Cliente = " + cliente, fuente, Brushes.Black, 30, 50)

        'Impresión de DataGridView
        '-------------------------------------------------------------------------------------------------------------------------------
        Dim xPosCant = 60
        Dim yPosCant = 360

        For i = 0 To dgvPedido.Rows.Count - 1
            e.Graphics.DrawString(dgvPedido.Rows(i).Cells("C2").Value.ToString(), fuente, Brushes.Black, xPosCant, yPosCant)
            e.Graphics.DrawString(dgvPedido.Rows(i).Cells("C1").Value.ToString(), fuente, Brushes.Black, xPosCant + 100, yPosCant)
            If dgvPedido.Rows(i).Cells("C5").Value Is Nothing Then
                e.Graphics.DrawString(" ", fuente, Brushes.Black, xPosCant + 40, yPosCant)
            Else
                e.Graphics.DrawString(dgvPedido.Rows(i).Cells("C5").Value.ToString(), fuente, Brushes.Black, xPosCant + 400, yPosCant)
            End If
            e.Graphics.DrawString("$" + dgvPedido.Rows(i).Cells("C4").Value.ToString(), fuente, Brushes.Black, xPosCant + 650, yPosCant)
            e.Graphics.DrawString(txtTotal.Text, fuente, Brushes.Black, xPosCant + 655, yPosCant + 715)

            yPosCant += 30
        Next
        '-------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        Dim Variable As String = dgvPedido.Item(3, dgvPedido.CurrentRow.Index).Value
        Dim Valor = Variable.Replace("$", "")
        dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index)
        txtTotal.Text = CDec(txtTotal.Text.ToString()) - CDec(Valor.ToString())
    End Sub

    Private Sub txtAbona_Click(sender As Object, e As EventArgs) Handles txtAbona.Click

    End Sub

    Private Sub txtAbona_TextChanged(sender As Object, e As EventArgs) Handles txtAbona.TextChanged
        If txtAbona.Text = "" Then
        Else
            txtVuelto.Text = CDec(txtAbona.Text.ToString()) - CDec(txtTotal.Text.ToString())
        End If

    End Sub
End Class