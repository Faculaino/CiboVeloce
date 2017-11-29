Imports BLL
Imports EE
Public Class FormNuevoProveedor
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nuevoProveedor = New ProveedorBussines
        Dim proveedor = New ProveedorEntity
        proveedor.nombre = txtNombre.Text
        proveedor.direccion = txtDireccion.Text
        proveedor.telefono = txtTelefono.Text
        nuevoProveedor.nuevoProveedor(proveedor)
        MsgBox("Se guardo correctamente al Proveedor")
        actualizarFormulario()
        txtNombre.Select()
    End Sub

    Sub actualizarFormulario()
        Dim formCompras = New FormCompras
        formCompras.cargarGrilla()
    End Sub
End Class