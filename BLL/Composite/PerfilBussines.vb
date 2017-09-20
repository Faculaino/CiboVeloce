Imports EE
Imports DAL
Public Class PerfilBussines




    Function perfilUsuario(id As Integer) As PerfilEntity

        Dim nuevoDatos = New PerfilDAL
        Dim nuevoPerfil = New PerfilEntity
        nuevoPerfil = nuevoDatos.perfilUsuario("SP_Select_UsuarioPerfil", id)


        Return nuevoPerfil
    End Function



End Class
