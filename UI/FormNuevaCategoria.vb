Imports BLL
Imports EE
Public Class FormNuevaCategoria
    Private Sub btnNuevaCategoria_Click(sender As Object, e As EventArgs) Handles btnNuevaCategoria.Click
        Dim nuevaCategoria = New CategoriaBussines
        nuevaCategoria.insertCategoria(txtCategoria.Text)
        MsgBox("Se agregó una Nueva Categoría")
        Me.Close()
    End Sub
End Class