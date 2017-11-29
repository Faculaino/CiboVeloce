Imports System.Data.SqlClient
Imports EE
Public Class PerfilDAL
    Inherits Connection


    Function perfilUsuario(id As Integer) As PerfilEntity

        Dim nuevoPerfil = New PerfilEntity

        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SP_Select_UsuarioPerfil"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", id)


            Dim reader = cmd.ExecuteReader
            While reader.Read
                nuevoPerfil.descripcion = reader(0)
            End While
            reader.Close()


            CloseBD()

            Return nuevoPerfil
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarPerfil(usuario As UsuarioEntity) As String
        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT P.Descripcion FROM Usuarios as U INNER JOIN Perfil as P ON
                               (U.IDPerfil = P.ID) WHERE U.ID = " & usuario.ID
            cmd.CommandType = CommandType.Text
            Dim perfil As String = ""
            Dim reader = cmd.ExecuteReader
            While reader.Read
                perfil = reader(0)
            End While
            reader.Close()
            CloseBD()
            Return perfil
        Catch ex As Exception
            Return Nothing
        End Try




    End Function

    Public Sub setearPerfil(idPerfil As Integer, idUsuario As Integer)
        OpenBD()

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE Usuarios SET IDPerfil= " & idPerfil & "WHERE ID= " & idUsuario
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            CloseBD()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Function listarPerfiles() As List(Of PerfilEntity)

        Dim nuevaLista = New List(Of PerfilEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Perfil"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoPerfil = New PerfilEntity()
                nuevoPerfil.ID = reader(0)
                nuevoPerfil.descripcion = reader(1)

                Dim listaPerfiles = buscarPermisosPorPerfil(reader(0))
                nuevoPerfil.listaPermisos = listaPerfiles
                nuevaLista.Add(nuevoPerfil)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarPermisosPorPerfil(idPerfil As Integer) As List(Of PermisoEntity)
        OpenBD()
        Dim query = "SELECT M.ID, M.Descripcion FROM PerfilPermisos as Per INNER JOIN Perfil as P ON
                    (Per.IDPerfil = p.ID) INNER JOIN Permisos as M ON (M.ID = Per.IDPermiso) WHERE P.ID = " & idPerfil
        Dim lista = New List(Of PermisoEntity)

        Try
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text

            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoPermiso = New PermisoEntity
                nuevoPermiso.ID = reader(0)
                nuevoPermiso.descripcion = reader(1)
                lista.Add(nuevoPermiso)
            End While
            reader.Close()

            Return lista

        Catch ex As Exception
            Return Nothing
        End Try


    End Function
End Class
