Imports System.Data
Imports System.Data.SqlClient
Imports EE
Public Class UsuarioDAL
    Inherits Connection



    Sub insertUsuario(ByVal hdatos As Hashtable)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Insert_Usuario"
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

    Sub updateUsuariosDVH(dvh As Integer)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Update_UsuariosDVH"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@DVH", dvh)

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

    Sub modificaIdioma(id As Integer, idUser As Integer)
        OpenBD()
        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE Usuarios SET IDIdioma = " & id & " WHERE ID = " & idUser
            cmd.CommandType = CommandType.Text

            cmd.ExecuteNonQuery()

            CloseBD()

        Catch ex As SqlException

            MsgBox(ex.Message)
        Catch ex As Exception

            MsgBox(ex)
        End Try
    End Sub

    Public Function buscarDVV() As Integer

        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_DVVUsuarios"
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


    Sub deleteUsuario(ByVal hdatos As Hashtable)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "FALTA"
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

    Public Sub modificarPerfil(iDUser As Integer, id As Integer)
        OpenBD()
        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE Usuarios SET IDPerfil = " & id & " WHERE ID = " & iDUser
            cmd.CommandType = CommandType.Text

            cmd.ExecuteNonQuery()

            CloseBD()

        Catch ex As SqlException

            MsgBox(ex.Message)
        Catch ex As Exception

            MsgBox(ex)
        End Try
    End Sub

    Function buscarUsuario(ByVal hdatos As Hashtable) As UsuarioEntity
        Dim oUsuario As New UsuarioEntity
        OpenBD()
        Try

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_Usuario"
            cmd.CommandType = CommandType.StoredProcedure

            If Not hdatos Is Nothing Then
                For Each dato As String In hdatos.Keys
                    cmd.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            Else

            End If

            Dim reader = cmd.ExecuteReader
            While reader.Read
                oUsuario.ID = reader(0)
                oUsuario.User = reader(2)
                oUsuario.Password = reader(3)
                oUsuario.IDPerfil = reader(7)
                oUsuario.IDIdioma = reader(8)
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


    Function buscarUserID(id As Integer) As UsuarioEntity
        Dim oUsuario = New UsuarioEntity()


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Usuarios WHERE ID= " & id
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read

                oUsuario.ID = reader(0)
                oUsuario.User = reader(1)
                oUsuario.Nombre = reader(2)
                oUsuario.IDPerfil = reader(7)



            End While
            reader.Close()


            CloseBD()

            Return oUsuario
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Function listarUsuarios() As List(Of UsuarioEntity)
        Dim nuevaLista = New List(Of UsuarioEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_ListarUsuarios"
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim oUsuario = New UsuarioEntity()
                oUsuario.ID = reader(0)
                oUsuario.User = reader(1)
                oUsuario.Nombre = reader(2)
                oUsuario.Activo = reader(3)
                oUsuario.DVV = reader(4)
                oUsuario.DVH = reader(5)
                oUsuario.IDPerfil = reader(6)
                oUsuario.IDIdioma = reader(7)

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
