Imports System.Data.SqlClient
Imports EE
Public Class PermisoDAL
    Inherits Connection




    Function listarPermisos() As List(Of PermisoEntity)
        Dim nuevaLista = New List(Of PermisoEntity)


        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Permisos"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim nuevoPermiso = New PermisoEntity()
                nuevoPermiso.ID = reader(0)
                nuevoPermiso.descripcion = reader(1)
                nuevaLista.Add(nuevoPermiso)
            End While
            reader.Close()


            CloseBD()

            Return nuevaLista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try


    End Function

    Public Function buscarPermisos(usuario As UsuarioEntity) As List(Of PermisoEntity)
        OpenBD()
        Dim query = "SELECT M.ID, M.Descripcion FROM PerfilPermisos as Per INNER JOIN Perfil as P ON
                    (Per.IDPerfil = p.ID) INNER JOIN Permisos as M ON (M.ID = Per.IDPermiso) WHERE P.ID = " & usuario.IDPerfil
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
            CloseBD()
            Return lista

        Catch ex As Exception
            Return Nothing
        End Try


    End Function


End Class
