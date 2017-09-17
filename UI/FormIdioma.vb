Imports BLL
Public Class FormIdioma
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
End Class