Imports BLL
Imports EE
Imports Servicios
Public Class FormIdioma
    Implements IObserver

    Private Sub FormIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo()
        cambiarIdioma()
    End Sub

    Sub llenarCombo()

        Dim newIdioma = New IdiomaBussines

        cmbIdioma.DataSource = Nothing
        cmbIdioma.DataSource = newIdioma.listarIdiomas


        cmbIdioma.DisplayMember = "Idioma"
        cmbIdioma.ValueMember = "ID"
        cmbIdioma.SelectedIndex = -1
    End Sub

    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click

        Dim nuevoIdioma = New UsuarioBussines
        nuevoIdioma.modificaIdioma(cmbIdioma.SelectedValue, SessionManager.Instance.Usuario.ID)
        cambiarIdioma()
    End Sub

    Private Sub NuevoIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoIdiomaToolStripMenuItem.Click
        Dim nuevoIdioma = New FormNuevoIdioma
        nuevoIdioma.StartPosition = FormStartPosition.CenterScreen
        nuevoIdioma.Show()
    End Sub

    Sub cambiarIdioma()
        Dim traducir As New TraduccionBussines
        Dim idioma = New TraduccionEntity

        Dim ht As New Hashtable
        ht = traducir.palabrasTraducidas(SessionManager.Instance.Usuario.IDIdioma)

        For Each control As Control In Me.Controls
            If control.Tag Is Nothing Then
            Else
                For Each item As DictionaryEntry In ht
                    If control.Tag.Equals(item.Key) Then
                        control.Text = item.Value
                        Exit For
                    End If
                Next
            End If

        Next

        'Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
        'Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
        'Threading.Thread.CurrentThread.CurrentCulture = culturaObj

    End Sub

    Public Sub actulizar(traducciones As Dictionary(Of String, String)) Implements IObserver.actulizar
        Throw New NotImplementedException()
    End Sub
End Class