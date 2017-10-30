Imports EE
Imports BLL
Imports MetroFramework
Imports System.Text
Public Class FormPedidos
    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBuscaTel.Select()
        formatControls()
        clearFields()
        cargarTree()

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
            wbMaps.Navigate(query.ToString())
            'wbMaps.Navigate("https://www.google.com.ar/maps/search/" & txtDireccion.Text & "+" & txtLocalidad.Text & "+" & "Buenos Aires" & "+" & "Argentina" & "+")
        Catch ex As Exception
            wbMaps.Navigate("")
            MsgBox("Error en el Servicio de Google Maps")
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

        bandera = False
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
                MsgBox("Ingrese una dirección válido")
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
        wbMaps.Navigate("")
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

        nuevoCliente.insertCliente(datosCliente)
        MsgBox("Cliente ingresado correctamente")
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

    'Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDocument.PrintPage
    '    Dim fuente As New Font("Calibri", 12)
    '    Dim nombre = "Nombre Empresa" + " - " + Now.ToShortDateString("dd/mm/yyyy") + " - HS: " + Now.ToShortTimeString

    '    'e.Graphics.DrawString(nombre, fuente, Brushes.Black, 200, 0)
    '    'e.Graphics.DrawString("N°: ", fuente, Brushes.Black, 530, 0)
    '    'e.Graphics.DrawString(Comanda.Text, fuente, Brushes.Black, 560, 0)
    '    'e.Graphics.DrawString("Nombre: ", fuente, Brushes.Black, 200, 20)
    '    'e.Graphics.DrawString(cliente, fuente, Brushes.Black, 270, 20)
    '    'e.Graphics.DrawString("Dir: ", fuente, Brushes.Black, 200, 40)
    '    'e.Graphics.DrawString(direccion, fuente, Brushes.Black, 230, 40)
    '    'e.Graphics.DrawString("E/: ", fuente, Brushes.Black, 200, 60)
    '    'e.Graphics.DrawString(TextBoxCalles.Text, fuente, Brushes.Black, 230, 60)

    '    e.Graphics.DrawString(nombre, fuente, Brushes.Black, 0, 0)
    '    e.Graphics.DrawString("N°: ", fuente, Brushes.Black, 330, 0)
    '    'e.Graphics.DrawString(Comanda.Text, fuente, Brushes.Black, 360, 0)
    '    e.Graphics.DrawString("Nombre: ", fuente, Brushes.Black, 0, 20)
    '    e.Graphics.DrawString(txtNombre.Text, fuente, Brushes.Black, 70, 20)
    '    e.Graphics.DrawString("Dirección: ", fuente, Brushes.Black, 0, 40)
    '    e.Graphics.DrawString(txtDireccion.Text, fuente, Brushes.Black, 80, 40)
    '    e.Graphics.DrawString("E/: ", fuente, Brushes.Black, 0, 60)
    '    e.Graphics.DrawString(txtEntreCalles.Text, fuente, Brushes.Black, 30, 60)

    '    'e.Graphics.DrawString("Cant", fuente, Brushes.Black, 200, 80)
    '    e.Graphics.DrawString("Cant", fuente, Brushes.Black, 0, 80)


    '    For i = 0 To dgvPedido.Rows.Count

    '        'cantidad
    '        'e.Graphics.DrawString(dgvPedido.Rows(i).Cells(1).Value, fuente, Brushes.Black, xPosCant, yPosCant)
    '        'e.Graphics.DrawString("Detalles", fuente, Brushes.Black, 250, 80)
    '        e.Graphics.DrawString("Detalles", fuente, Brushes.Black, 50, 80)
    '        'e.Graphics.DrawString(dgvPedido.Rows(i).Cells(0).Value, fuente, Brushes.Black, New RectangleF(xPosDesc, yPosDesc, e.MarginBounds.Right - 160, altoNecesario))
    '        'e.Graphics.DrawString("Guarnición", fuente, Brushes.Black, 400, 80)
    '        e.Graphics.DrawString("Guarnición", fuente, Brushes.Black, 180, 80)
    '        e.Graphics.DrawString("Precio", fuente, Brushes.Black, 530, 80)
    '        'e.Graphics.DrawString(dgvPedido.Rows(i).Cells(3).Value, fuente, Brushes.Black, xPosPrec, yPosPrec)




    '        'Pregunto si hubo observacion
    '        If dgvPedido.Rows(i).Cells(4).Value = "" Then
    '            'yPosDesc += 20
    '            'yPosCant += 20
    '            'yPosPrec += 20
    '        Else
    '            'yPosObs = yPosDesc
    '            'e.Graphics.DrawString(DataGridViewPedido.Rows(i).Cells(4).Value, fuente, Brushes.Black, New RectangleF(xPosObs, yPosObs, e.MarginBounds.Right - 160, altoNecesario))
    '            'yPosDesc += 20
    '            'yPosCant += 20
    '            'yPosPrec += 20
    '        End If

    '    Next





    'End Sub



    Sub imprimir()
        Dim comanda As Image = My.Resources.ComandaA6
        Dim g As Graphics = Graphics.FromImage(comanda)

        printPreview.Show(comanda)

    End Sub

    Private Sub FormPedidos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        imprimir()
    End Sub

    Private Sub btnImprimir_KeyDown(sender As Object, e As KeyEventArgs) Handles btnImprimir.KeyDown
        If e.KeyValue = Keys.F5 Then
            MsgBox("Hola")
        End If
    End Sub
End Class