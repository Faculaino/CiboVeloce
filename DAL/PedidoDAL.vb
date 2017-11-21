Imports System.Data.SqlClient
Imports EE

Public Class PedidoDAL
    Inherits Connection


    Sub insertPedido(pedido As PedidoEntity)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Pedido"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fechahora", pedido.fechahora)
            cmd.Parameters.AddWithValue("@total", pedido.total)
            cmd.Parameters.AddWithValue("@idCliente", pedido.idCliente)
            cmd.Parameters.AddWithValue("@listaComida", pedido.listaComida)
            cmd.Parameters.AddWithValue("@idUsuario", pedido.idUsuario)
            cmd.Parameters.AddWithValue("@idEstado", pedido.idEstado)
            cmd.Parameters.AddWithValue("@dvv", pedido.dvv)
            cmd.Parameters.AddWithValue("@dvh", pedido.dvh)

            cmd.Transaction = Tx

            cmd.ExecuteNonQuery()
            Tx.Commit()
            CloseBD()

        Catch ex As SqlException
            Tx.Rollback()
            MsgBox(ex.Message)
        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try
    End Sub

    Public Function buscarPedidoID(idPedido As Integer) As PedidoEntity
        OpenBD()



        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Pedidos WHERE ID = " & idPedido
            cmd.CommandType = CommandType.Text

            Dim nuevoPedido = New PedidoEntity()
            Dim reader = cmd.ExecuteReader
            While reader.Read

                nuevoPedido.ID = reader(0)
                nuevoPedido.fechahora = reader(1)
                nuevoPedido.total = reader(2)
                nuevoPedido.idCliente = reader(3)
                nuevoPedido.listaComida = reader(4)
                nuevoPedido.idUsuario = reader(5)
                nuevoPedido.idEstado = reader(6)

            End While
            reader.Close()



            CloseBD()

            Return nuevoPedido

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try


    End Function

    Function buscarPedidos(fecha1 As DateTime, fecha2 As DateTime) As List(Of PedidoEntity)

        OpenBD()

        Dim Fecha1Convert As String = fecha1.ToString("yyyy-MM-dd")
        Dim Fecha2Convert As String = fecha2.ToString("yyyy-MM-dd")
        Dim nuevaLista = New List(Of PedidoEntity)

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ListarPedidos"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Fecha1", fecha1)
            cmd.Parameters.AddWithValue("@Fecha2", fecha2)



            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoPedido = New PedidoEntity()
                nuevoPedido.ID = reader(0)
                nuevoPedido.fechahora = reader(1)
                nuevoPedido.total = reader(2)
                nuevoPedido.idCliente = reader(3)
                nuevoPedido.listaComida = reader(4)
                nuevoPedido.idUsuario = reader(5)
                nuevoPedido.idEstado = reader(6)
                nuevaLista.Add(nuevoPedido)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function buscarDVV() As Integer
        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_DVVPedidos"
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader = cmd.ExecuteReader
            Dim valor As Integer
            While reader.Read
                valor = reader(0)
            End While
            reader.Close()
            Return valor + 1

        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
