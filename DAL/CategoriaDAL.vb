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
