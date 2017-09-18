﻿Imports System.Data.SqlClient
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
            cmd.CommandText = evento
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

    Function listarBitacora(query As String) As List(Of BitacoraEntity)
        Dim nuevaLista = New List(Of BitacoraEntity)
        Dim nuevaBitacora = New BitacoraEntity


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoEvento = New BitacoraEntity()
                nuevoEvento.tipoEvento = reader(1)
                nuevoEvento.registroCambio = reader(2)

                Dim nuevoUsuario = New UsuarioDAL
                Dim user = New UsuarioEntity
                user = nuevoUsuario.buscarUserID("SP_Select_UsuariosPorID", reader(0))

                nuevoEvento.mensaje = reader(1) & " " & "del Usuario = " & user.Nombre & "/" & user.User

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
