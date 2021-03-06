﻿Imports System.Data.SqlClient
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


    Sub modificarEstado(lista As List(Of PedidoEntity), idEstado As Integer)
        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            For Each item As PedidoEntity In lista
                cmd.CommandText = "UPDATE Pedidos SET IDEstado = " & idEstado & "WHERE ID= " & item.ID
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
            Next


            CloseBD()

        Catch ex As Exception
            MsgBox(ex.Message)
            CloseBD()
        End Try
    End Sub


    Function listarPedidosEstado(id As Integer) As List(Of PedidoEntity)

        Dim nuevaLista = New List(Of PedidoEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Pedidos WHERE IDEstado = " & id
            cmd.CommandType = CommandType.Text


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

    Public Function buscarPedidoCliente(telefono As String, fecha As Date) As List(Of PedidoEntity)
        Dim nuevaLista = New List(Of PedidoEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ReportePedidoCliente"
            cmd.CommandType = CommandType.StoredProcedure


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

    Public Function buscaUltimoID() As Integer
        Dim valor As Integer = 0

        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT MAX(ID) FROM Pedidos"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                valor = reader(0)
            End While
            reader.Close()


            CloseBD()

            Return valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function buscarLocalidades() As List(Of String)
        Dim nuevaLista = New List(Of String)

        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT DISTINCT C.Localidad FROM Pedidos as P INNER JOIN Clientes as C ON (P.IDCliente = C.ID)"
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

    Function buscarPedidosLOCALIDAD(localidad As String) As List(Of PedidoEntity)
        Dim nuevaLista = New List(Of PedidoEntity)

        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT P.ID, P.FechaHora, p.Total, C.ID, p.ListaComida FROM Pedidos as P INNER JOIN Clientes as C ON (P.IDCliente = C.ID) WHERE C.Localidad = '" + localidad + "'"
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoPedido = New PedidoEntity()
                nuevoPedido.ID = reader(0)
                nuevoPedido.fechahora = reader(1)
                nuevoPedido.total = reader(2)
                nuevoPedido.idCliente = reader(3)
                nuevoPedido.listaComida = reader(4)

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
