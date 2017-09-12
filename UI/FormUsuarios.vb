Imports BLL
Public Class FormUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub



    Sub llenarGrilla()

        Dim usuarioBussines = New BLL.UsuarioBussines

        dgvUsuarios.DataSource = Nothing
        dgvUsuarios.DataSource = usuarioBussines.listarUsuarios

    End Sub
End Class