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

    Public Function buscarPermisoName(name As String) As PermisoEntity
        Dim nuevoPermiso = New PermisoEntity()
        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM Permisos WHERE Descripcion = '" + name + "'"
            cmd.CommandType = CommandType.Text


            Dim reader = cmd.ExecuteReader
            While reader.Read

                nuevoPermiso.ID = reader(0)
                nuevoPermiso.descripcion = reader(1)

            End While
            reader.Close()
            CloseBD()

            Return nuevoPermiso
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub insertPermisos(listaPermisos As List(Of PermisoEntity), Id As Integer)
        Try
            OpenBD()

            cmd = New SqlCommand
            cmd.Connection = cnn

            For Each item As PermisoEntity In listaPermisos
                cmd.CommandText = "INSERT INTO PerfilPermisos (IDPerfil, IDPermiso, Familia) VALUES (" & Id & ", " & item.ID & ", 0)"

                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
            Next

            CloseBD()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

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
