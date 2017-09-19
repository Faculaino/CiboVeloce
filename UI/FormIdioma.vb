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
        If cmbIdioma.DisplayMember.ToString() = "Español" Then
            MsgBox("vale")
        ElseIf cmbIdioma.SelectedItem = "Inglés" Then
            For Each c In Controls
                MsgBox("Entre")
            Next

        ElseIf cmbIdioma.SelectedItem = "Italiano" Then


        End If
    End Sub

    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        actulizar()
    End Sub
End Class