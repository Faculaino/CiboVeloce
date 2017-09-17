Imports System.Data
Imports System.Data.SqlClient
Imports EE
Public Class UsuarioDAL
    Inherits Connection



    Sub insertUsuario(ByVal Query As String, ByVal hdatos As Hashtable)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = Query
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Transaction = Tx

            If Not hdatos Is Nothing Then

                For Each dato As String In hdatos.Keys
                    cmd.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If

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

    Sub deleteUsuario(ByVal Query As String, ByVal hdatos As Hashtable)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = Query
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Transaction = Tx

            If Not hdatos Is Nothing Then

                For Each dato As String In hdatos.Keys
                    cmd.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If

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



    Function buscarUsuario(ByVal Query As String, ByVal hdatos As Hashtable) As UsuarioEntity
        Dim oUsuario As New UsuarioEntity
        OpenBD()
        Try

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = Query
            cmd.CommandType = CommandType.StoredProcedure

            If Not hdatos Is Nothing Then
                For Each dato As String In hdatos.Keys
                    cmd.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            Else

            End If

            Dim reader = cmd.ExecuteReader
            While reader.Read
                oUsuario.User = reader(2)
                oUsuario.Password = reader(3)
            End While
            reader.Close()


            CloseBD()
            Return oUsuario
        Catch ex As SqlException
            MsgBox(ex)
            Return Nothing
        Catch ex As Exception
            MsgBox(ex)
            Return Nothing


        End Try

    End Function

    Function listarUsuarios(ByVal query As String) As List(Of UsuarioEntity)
        Dim nuevaLista = New List(Of UsuarioEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim oUsuario = New UsuarioEntity()
                oUsuario.ID = reader(0)
                oUsuario.User = reader(1)
                oUsuario.Nombre = reader(2)
                oUsuario.Activo = reader(3)

                nuevaLista.Add(oUsuario)
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
