Imports BLL
Imports EE
Public Class FormAdministracionCarta

    Private bandera = True

    Private Sub btnNuevaCategoria_Click(sender As Object, e As EventArgs) Handles btnNuevaCategoria.Click
        Dim nuevaCate = New FormNuevaCategoria
        nuevaCate.StartPosition = FormStartPosition.CenterScreen
        nuevaCate.ShowDialog()
        cargarCombo()
    End Sub

    Private Sub FormAdministracionCarta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()


    End Sub

    Sub cargarCombo()
        Dim nuevaCategoria = New CategoriaBussines

        cmbCategorias.DataSource = Nothing
        cmbCategorias.DataSource = nuevaCategoria.listarCategorias()
        cmbCategorias.DisplayMember = "Tipo"
        cmbCategorias.ValueMember = "ID"

        cmbCategorias.SelectedIndex = -1

    End Sub

    Private Sub btnNuevaComida_Click(sender As Object, e As EventArgs) Handles btnNuevaComida.Click
        habilitaEdicion()
        habilitarAgregar()
        txtComida.Select()
    End Sub

    Sub habilitarAgregar()
        lblComida.Visible = True
        lblPrecio.Visible = True
        txtComida.Visible = True
        txtPrecio.Visible = True
        btnAgregarComida.Visible = True
    End Sub

    Sub cargarGrilla(id As Integer)
        Dim listaComida = New List(Of ComidaEntity)
        Dim categoriaBussines = New CategoriaBussines
        listaComida = categoriaBussines.listarComidas(id)

        dgvComidas.Rows.Clear()
        For Each item As ComidaEntity In listaComida
            dgvComidas.Rows.Add(item.detalle, item.precio)
        Next

    End Sub

    Sub habilitaEdicion()
        cmbCategorias.Enabled = True
        dgvComidas.Enabled = True
        bandera = False
    End Sub

    Private Sub btnEditarComidas_Click(sender As Object, e As EventArgs)
        habilitaEdicion()
    End Sub

    Private Sub cmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategorias.SelectedIndexChanged

        dgvComidas.Rows.Clear()
        If bandera = True Then
        Else
            cargarGrilla(cmbCategorias.SelectedValue)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim listaComida = New List(Of ComidaEntity)
        Dim IDCategoria = cmbCategorias.SelectedValue
        Dim comidaBussines = New ComidaBussines


        For Each item As DataGridViewRow In dgvComidas.Rows
            If item.Cells(1).Value Is Nothing Then
            Else
                Dim comida = New ComidaEntity
                comida.detalle = item.Cells(0).Value.ToString()
                comida.precio = CDec(item.Cells(1).Value.ToString())
                comida.idcategoria = cmbCategorias.SelectedValue
                listaComida.Add(comida)
            End If

        Next

        comidaBussines.borrarRegistros(cmbCategorias.SelectedValue)
        comidaBussines.insertComidaLista(listaComida)



    End Sub

    Private Sub btnAgregarComida_Click(sender As Object, e As EventArgs) Handles btnAgregarComida.Click
        Dim comidaBussines = New ComidaBussines
        Dim comida = New ComidaEntity
        comida.detalle = txtComida.Text
        comida.precio = CDec(txtPrecio.Text.ToString())
        comida.idcategoria = cmbCategorias.SelectedValue
        comidaBussines.insertComida(comida)
        dgvComidas.Rows.Add(txtComida.Text, txtPrecio.Text)

        cargarGrilla(cmbCategorias.SelectedValue)

        txtComida.Text = ""
        txtPrecio.Text = ""
        txtComida.Select()

    End Sub

    Private Sub metroCheck_CheckedChanged(sender As Object, e As EventArgs) Handles metroCheck.CheckedChanged
        If metroCheck.Checked = True Then
            habilitaEdicion()
        End If
    End Sub
End Class