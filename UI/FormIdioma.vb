Imports BLL
Imports EE

Public Class FormIdioma
    Implements IObserver

    Private Sub FormIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()

    End Sub

    Sub llenarCombo()

        Dim newIdioma = New IdiomaBussines

        cmbIdioma.DataSource = Nothing
        cmbIdioma.DataSource = newIdioma.listarIdiomas


        cmbIdioma.DisplayMember = "Idioma"
        cmbIdioma.ValueMember = "ID"
        cmbIdioma.SelectedIndex = -1
    End Sub

    Public Sub actulizar() Implements IObserver.actulizar
        Dim nuevoIdioma = New IdiomaBussines
        Dim idiomaEE = New IdiomaEntity
        idiomaEE = nuevoIdioma.buscarIdiomaID(CInt(cmbIdioma.SelectedValue))


        If cmbIdioma.Text = idiomaEE.idioma Then
            Dim nuevaTraduccion = New TraduccionBussines
            Dim nuevaLista = New List(Of TraduccionEntity)
            nuevaLista = nuevaTraduccion.listarTraduccion(cmbIdioma.SelectedValue)


            For Each c In Me.Controls

                For Each item In nuevaLista
                    If item.PalabraTraducida = "Language" Then
                        Me.Text = "Language List"
                        If c.text = "Idioma" Then
                            c.text = item.PalabraTraducida
                        End If
                    End If

                    If item.PalabraTraducida = "Select" Then

                        If c.text = "Seleccionar" Then
                            c.text = item.PalabraTraducida
                        End If
                    End If

                    If item.PalabraTraducida = "List" Then

                        If c.text = "Lista" Then
                            c.text = item.PalabraTraducida
                        End If
                    End If

                Next


            Next




        End If
    End Sub

    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        actulizar()
    End Sub
End Class