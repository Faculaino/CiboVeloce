Imports System.Data.SqlClient
Imports EE
Public Class ProveedorDAL
    Inherits Connection




    Function buscarProveedor(id As Integer) As ProveedorEntity

        OpenBD()
        Dim proveedor = New ProveedorEntity

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Proveedores WHERE ID= " & id
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                proveedor.ID = reader(0)
                proveedor.nombre = reader(1)
                proveedor.telefono = reader(2)
                proveedor.direccion = reader(3)
            End While
            reader.Close()


            CloseBD()

            Return proveedor



        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try



    End Function

    Public Sub insertProveedor(proveedor As ProveedorEntity)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Proveedor"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@nombre", proveedor.nombre)
            cmd.Parameters.AddWithValue("@telefono", proveedor.telefono)
            cmd.Parameters.AddWithValue("@direccion", proveedor.direccion)

            cmd.Transaction = Tx


            cmd.ExecuteNonQuery()
            Tx.Commit()

            CloseBD()

        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try
    End Sub

    Public Function listarProveedores() As List(Of ProveedorEntity)
        Dim nuevaLista = New List(Of ProveedorEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Proveedores"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoProveedor = New ProveedorEntity()
                nuevoProveedor.ID = reader(0)
                nuevoProveedor.nombre = reader(1)
                nuevoProveedor.telefono = reader(2)
                nuevoProveedor.direccion = reader(3)
                nuevaLista.Add(nuevoProveedor)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
End Class
