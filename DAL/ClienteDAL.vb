Imports System.Data.SqlClient
Imports EE
Public Class ClienteDAL
    Inherits Connection


    Function buscarClienteTEL(telefono As String) As ClienteEntity


        Dim oCliente As New ClienteEntity
        OpenBD()
        Try

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ClienteTelefono"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@telefono", telefono)



            Dim reader = cmd.ExecuteReader
            While reader.Read
                oCliente.ID = reader(0)
                oCliente.apyn = reader(1)
                oCliente.direccion = reader(2)
                oCliente.localidad = reader(3)
                oCliente.entreCalles = reader(4)
                If reader(5) Is DBNull.Value Then
                    oCliente.detalleDireccion = ""
                Else
                    oCliente.detalleDireccion = reader(5)
                End If
                oCliente.telefonos = reader(6)
                oCliente.costo = reader(7)

                reader.Close()

                CloseBD()
                Return oCliente
            End While

        Catch ex As SqlException
            MsgBox(ex)
            Return Nothing
        Catch ex As Exception
            MsgBox(ex)
            Return Nothing


        End Try
    End Function

    Public Function buscarDVV() As Integer

        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_DVVClientes"
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

    Public Sub insertCliente(cliente As ClienteEntity)

        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Cliente"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", cliente.apyn)
            cmd.Parameters.AddWithValue("@direccion", cliente.direccion)
            cmd.Parameters.AddWithValue("@localidad", cliente.localidad)
            cmd.Parameters.AddWithValue("@entrecalles", cliente.entreCalles)
            cmd.Parameters.AddWithValue("@detalledir", cliente.detalleDireccion)
            cmd.Parameters.AddWithValue("@telefonos", cliente.telefonos)
            cmd.Parameters.AddWithValue("@costo", cliente.costo)
            cmd.Parameters.AddWithValue("@dvv", cliente.dvv)
            cmd.Parameters.AddWithValue("@dvh", cliente.dvh)


            cmd.Transaction = Tx



            cmd.ExecuteNonQuery()
            Tx.Commit()
            CloseBD()

        Catch ex As Exception
            Tx.Rollback()
            MsgBox(ex)
        End Try




    End Sub

    Public Function listarClientes() As List(Of ClienteEntity)
        OpenBD()
        Dim nuevaLista = New List(Of ClienteEntity)
        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ListarClientes"
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim oCliente = New ClienteEntity
                oCliente.ID = reader(0)
                oCliente.apyn = reader(1)
                oCliente.direccion = reader(2)
                oCliente.localidad = reader(3)
                oCliente.entreCalles = reader(4)
                If reader(5) Is DBNull.Value Then
                    oCliente.detalleDireccion = ""
                Else
                    oCliente.detalleDireccion = reader(5)
                End If
                oCliente.telefonos = reader(6)
                oCliente.costo = reader(7)

                nuevaLista.Add(oCliente)

            End While

            reader.Close()

            CloseBD()
            Return nuevaLista

        Catch ex As Exception
            Return Nothing
        End Try



    End Function

    Function buscarClienteDIR(direccion As String) As ClienteEntity


        Dim oCliente As New ClienteEntity
        OpenBD()
        Try

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ClienteDireccion"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("direccion", direccion)



            Dim reader = cmd.ExecuteReader
            While reader.Read
                oCliente.ID = reader(0)
                oCliente.apyn = reader(1)
                oCliente.direccion = reader(2)
                oCliente.localidad = reader(3)
                oCliente.entreCalles = reader(4)
                If reader(5) Is DBNull.Value Then
                    oCliente.detalleDireccion = ""
                Else
                    oCliente.detalleDireccion = reader(5)
                End If
                oCliente.telefonos = reader(6)
                oCliente.costo = reader(7)
                reader.Close()


                CloseBD()
                Return oCliente
            End While

        Catch ex As SqlException
            MsgBox(ex)
            Return Nothing
        Catch ex As Exception
            MsgBox(ex)
            Return Nothing


        End Try
    End Function




End Class
