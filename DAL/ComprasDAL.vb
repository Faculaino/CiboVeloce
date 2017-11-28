Imports System.Data.SqlClient
Imports EE
Public Class ComprasDAL
    Inherits Connection

    Public Sub insertCompra(compra As ComprasEntity)

        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Compra"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@estado", compra.estado)
            cmd.Parameters.AddWithValue("@fecha", compra.fecha)
            cmd.Parameters.AddWithValue("@monto", compra.monto)
            cmd.Parameters.AddWithValue("@idProveedor", compra.proveedor.ID)
            cmd.Parameters.AddWithValue("@listaItems", compra.listaItems)

            cmd.Transaction = Tx


            cmd.ExecuteNonQuery()
            Tx.Commit()

            CloseBD()

        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try



    End Sub

    Public Function listarComprasProveedor(id As Integer) As List(Of ComprasEntity)
        Dim nuevaLista = New List(Of ComprasEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Compras WHERE IDProveedor= " & id
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaCompra = New ComprasEntity()
                nuevaCompra.ID = reader(0)
                nuevaCompra.estado = reader(1)
                nuevaCompra.fecha = reader(2)
                nuevaCompra.monto = reader(3)
                Dim nuevoProveedor = New ProveedorDAL
                nuevaCompra.proveedor = nuevoProveedor.buscarProveedor(reader(4))
                nuevaCompra.listaItems = reader(5)
                nuevaLista.Add(nuevaCompra)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try



    End Function

    Public Function listarEstados() As List(Of String)
        Dim nuevaLista = New List(Of String)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT DISTINCT Estado FROM Compras"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                nuevaLista.Add(CStr(reader(0).ToString()))
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function listarCompras() As List(Of ComprasEntity)
        Dim nuevaLista = New List(Of ComprasEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Compras"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaCompra = New ComprasEntity()
                nuevaCompra.ID = reader(0)
                nuevaCompra.estado = reader(1)
                nuevaCompra.fecha = reader(2)
                nuevaCompra.monto = reader(3)
                Dim nuevoProveedor = New ProveedorDAL
                nuevaCompra.proveedor = nuevoProveedor.buscarProveedor(reader(4))
                nuevaCompra.listaItems = reader(5)
                nuevaLista.Add(nuevaCompra)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try




    End Function


    Public Function listarComprasEstado(estado As String) As List(Of ComprasEntity)
        Dim nuevaLista = New List(Of ComprasEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Compras WHERE Estado= '" + estado + "'"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaCompra = New ComprasEntity()
                nuevaCompra.ID = reader(0)
                nuevaCompra.estado = reader(1)
                nuevaCompra.fecha = reader(2)
                nuevaCompra.monto = reader(3)
                Dim nuevoProveedor = New ProveedorDAL
                nuevaCompra.proveedor = nuevoProveedor.buscarProveedor(reader(4))
                nuevaCompra.listaItems = reader(5)
                nuevaLista.Add(nuevaCompra)
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
