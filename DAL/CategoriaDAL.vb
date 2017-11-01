Imports System.Data.SqlClient
Imports EE

Public Class CategoriaDAL
    Inherits Connection

    Public Function listarCategorias() As List(Of CategoriaEntity)
        Dim nuevaLista = New List(Of CategoriaEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Categorias"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaCategoria = New CategoriaEntity()
                nuevaCategoria.ID = reader(0)
                nuevaCategoria.tipo = reader(1)

                Dim listacomidas = buscarComidas(reader(0))
                nuevaCategoria.listaComidas = listacomidas


                nuevaLista.Add(nuevaCategoria)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function listarComidas(id As Integer) As List(Of ComidaEntity)
        Dim nuevaLista = New List(Of ComidaEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ComidasPorCategoria"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", id)


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaComida = New ComidaEntity()
                nuevaComida.ID = reader(0)
                nuevaComida.detalle = reader(1)
                nuevaComida.precio = reader(2)

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
            cmd.CommandText = "Select valor FROM DVV WHERE Tabla = 'Categorias'"
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

    Public Sub insertCategoria(categoria As CategoriaEntity)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Categoria"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@tipo", categoria.tipo)
            cmd.Parameters.AddWithValue("@DVV", categoria.dvv)
            cmd.Parameters.AddWithValue("@DVH", categoria.dvh)


            cmd.Transaction = Tx



            cmd.ExecuteNonQuery()
            Tx.Commit()
            CloseBD()

        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try
    End Sub

    Private Function buscarComidas(idcategoria As Integer) As List(Of ComidaEntity)

        OpenBD()
        Dim query = "SELECT * FROM Comidas WHERE IDCategoria = " & idcategoria
        Dim lista = New List(Of ComidaEntity)

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevaComida = New ComidaEntity
                nuevaComida.ID = reader(0)
                nuevaComida.detalle = reader(1)
                nuevaComida.precio = reader(2)
                lista.Add(nuevaComida)
            End While
            reader.Close()

            Return lista

        Catch ex As Exception
            Return Nothing
        End Try


    End Function
End Class
