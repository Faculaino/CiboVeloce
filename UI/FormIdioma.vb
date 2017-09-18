Imports BLL
Imports EE

Public Class FormIdioma
    Implements IObserver



    Private Sub FormIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
        Objeto.agregarObserver(Me)
    End Sub

    Sub llenarCombo()

        Dim newIdioma = New IdiomaBussines

        cmbIdioma.DataSource = Nothing
        cmbIdioma.DataSource = newIdioma.listarIdiomas


        cmbIdioma.DisplayMember = "Idioma"
        cmbIdioma.ValueMember = "ID"
        cmbIdioma.SelectedIndex = -1
    End Sub

    Public Sub modificarIdioma(idioma As IdiomaEntity) Implements IObserver.modificarIdioma

        If cmbIdioma.SelectedItem = "Español" Then

        ElseIf cmbIdioma.SelectedItem = "Inglés" Then

        ElseIf cmbIdioma.SelectedItem = "Italiano" Then

        End If



    End Sub
End Class