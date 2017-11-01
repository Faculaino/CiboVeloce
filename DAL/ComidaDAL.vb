Imports System.Data.SqlClient
Imports EE
Public Class ComidaDAL
    Inherits Connection

    Public Function listarComidas() As List(Of ComidaEntity)
        Dim nuevaLista = New List(Of ComidaEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Comidas"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaComida = New ComidaEntity()
                nuevaComida.ID = reader(0)
                nuevaComida.detalle = reader(1)
                nuevaLista.Add(nuevaComida)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try




    End Function

    Public Function buscaDVV() As Integer
        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "Select valor FROM DVV WHERE Tabla = 'Comidas'"
            cmd.CommandType = CommandType.Text

            Dim valor As Integer
            Dim reader = cmd.ExecuteReader
            While reader.Read

                valor = reader(0)

            End While
            reader.Close()


            CloseBD()

            Return valor
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub insertComida(comida As ComidaEntity)

        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Comida"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@detalle", comida.detalle)
            cmd.Parameters.AddWithValue("@IDCategoria", comida.idcategoria)
            cmd.Parameters.AddWithValue("@precio", comida.precio)
            cmd.Parameters.AddWithValue("@DVV", comida.dvv)
            cmd.Parameters.AddWithValue("@DVH", comida.dvh)

            cmd.Transaction = Tx


            cmd.ExecuteNonQuery()
            Tx.Commit()




            CloseBD()



        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try



    End Sub
End Class
