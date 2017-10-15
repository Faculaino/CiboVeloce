Imports System.Data.SqlClient
Imports EE
Imports Servicios
Public Class BitacoraDAL
    Inherits Connection




    Sub guardarCambios(cambio As String, usuario As UsuarioEntity, fecha As Date)


    End Sub

    Sub guardarEventos(evento As String, usuario As UsuarioEntity)
        OpenBD()

        Dim Tx As SqlTransaction
        Tx = cnn.BeginTransaction()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO Bitacora (Mensaje, IDUsuario, FechaHora) VALUES ('" & evento & "', " & usuario.ID & ", GETDATE())"
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

    Function listarBitacora() As List(Of BitacoraEntity)
        Dim nuevaLista = New List(Of BitacoraEntity)
        Dim nuevaBitacora = New BitacoraEntity


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT B.Mensaje, B.FechaHora, U.Usuario, U.ID FROM Bitacora AS B INNER JOIN Usuarios AS U ON B.IDUsuario = U.ID"
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoEvento = New BitacoraEntity()
                nuevoEvento.mensaje = reader(0)
                nuevoEvento.fechahora = reader(1)


                Dim nuevoUsuario = New UsuarioDAL
                Dim user = New UsuarioEntity
                user = nuevoUsuario.buscarUserID("SP_Select_UsuariosPorID", reader(3))
                nuevoEvento.usuario = user.User

                nuevoEvento.mensaje = reader(0) & " " & "del Usuario = " & user.User

                nuevaLista.Add(nuevoEvento)
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
