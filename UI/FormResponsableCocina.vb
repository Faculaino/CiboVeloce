Imports BLL
Imports Servicios

Public Class FormResponsableCocina
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim nuevoPedido = New FormPedidos
        nuevoPedido.StartPosition = FormStartPosition.CenterParent
        nuevoPedido.Show()
    End Sub

    Private Sub btnAdminComida_Click(sender As Object, e As EventArgs) Handles btnAdminComida.Click
        Dim nuevaComida = New FormAdministracionCarta
        nuevaComida.StartPosition = FormStartPosition.CenterParent
        nuevaComida.Show()
    End Sub

    Private Sub btnPedidosHistorial_Click(sender As Object, e As EventArgs) Handles btnPedidosHistorial.Click
        Dim nuevoHistorial = New FormPedidosPendientes
        nuevoHistorial.StartPosition = FormStartPosition.CenterParent
        nuevoHistorial.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim nuevaBitacora = New BitacoraBussines
        nuevaBitacora.guardarEvento("Logout", SessionManager.Instance.Usuario)

        Me.Close()

        SessionManager.Instance.Logout()
        Application.Restart()
    End Sub
End Class