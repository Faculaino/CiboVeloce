Imports System.Data.SqlClient
Imports EE
Public Class CajaDAL
    Inherits Connection


    Sub insertRegistro(caja As CajaEntity, motivo As String)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO Caja (IDPedido, IDCliente, Fecha, Total, Descripcion, IDUsuario) VALUES (" & caja.idPedido & ", " & caja.idCliente & ", GETDATE(), " & caja.importe & ", '" & motivo & "', " & caja.idUsuario & ")"
            cmd.CommandType = CommandType.Text

            cmd.Transaction = Tx

            cmd.ExecuteNonQuery()
            Tx.Commit()
            CloseBD()


        Catch ex As SqlException
            Tx.Rollback()
            MsgBox(ex.Message)
        Catch ex As Exception
            Tx.Rollback()

        End Try
    End Sub

    Public Function registrosFechas(fecha1 As Date, fecha2 As Date) As List(Of CajaEntity)
        OpenBD()

        Dim Fecha1Convert As String = fecha1.ToString("yyyy-MM-dd")
        Dim Fecha2Convert As String = fecha2.ToString("yyyy-MM-dd")
        Dim nuevaLista = New List(Of CajaEntity)

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ListarCaja"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Fecha1", fecha1)
            cmd.Parameters.AddWithValue("@Fecha2", fecha2)



            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaCaja = New CajaEntity()
                nuevaCaja.ID = reader(0)
                nuevaCaja.idPedido = reader(1)
                nuevaCaja.idCliente = reader(2)
                nuevaCaja.fechahora = reader(3)
                nuevaCaja.importe = reader(4)
                nuevaCaja.descripcion = reader(5)
                nuevaCaja.idUsuario = reader(6)
                nuevaLista.Add(nuevaCaja)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function listarCaja() As List(Of CajaEntity)
        Dim nuevaLista = New List(Of CajaEntity)



        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Caja"
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaCaja = New CajaEntity()
                nuevaCaja.ID = reader(0)
                nuevaCaja.idPedido = reader(1)
                nuevaCaja.idCliente = reader(2)
                nuevaCaja.fechahora = reader(3)
                nuevaCaja.importe = reader(4)
                nuevaCaja.descripcion = reader(5)
                nuevaCaja.idUsuario = reader(6)
                nuevaLista.Add(nuevaCaja)
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
