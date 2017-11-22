Imports System.Data.SqlClient
Imports EE
Public Class EstadoDAL
    Inherits Connection



    Function listarEstados() As List(Of EstadoEntity)

        Dim nuevaLista = New List(Of EstadoEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM EstadoPedidos"
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoEstado = New EstadoEntity()
                nuevoEstado.ID = reader(0)
                nuevoEstado.estado = reader(1)
                nuevaLista.Add(nuevoEstado)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarEstadoID(idEstado As Integer) As EstadoEntity
        Dim nuevoEstado = New EstadoEntity()


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM EstadoPedidos WHERE ID= " & idEstado
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read

                nuevoEstado.ID = reader(0)
                nuevoEstado.estado = reader(1)

            End While
            reader.Close()


            CloseBD()

            Return nuevoEstado
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
