Imports EE
Imports DAL
Imports System.Security.Cryptography
Imports System.Text
Imports Servicios

Public Class UsuarioBussines

    Private encriptar = New CryptoManager

    Sub insertUsuario(ByVal nuevoUsuario As UsuarioEntity)
        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim Consulta As String = "SP_Insert_Usuario"
        Dim PasswordHash() As Byte = encriptar.hashearPassword(nuevoUsuario.Password)

        oHash.Add("@Nombre", nuevoUsuario.Nombre)
        oHash.Add("@Usuario", nuevoUsuario.User)
        oHash.Add("@Contraseña", PasswordHash)
        oHash.Add("@DVV", nuevoUsuario.DVV)
        oHash.Add("@DVH", nuevoUsuario.DVH)
        oHash.Add("@Activo", nuevoUsuario.Activo)
        oHash.Add("@IDPerfil", nuevoUsuario.IDPerfil)

        oDatos.insertUsuario(Consulta, oHash)

    End Sub

    Sub deleteUsuario(ByVal nuevoUsuario As UsuarioEntity)
        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim Consulta As String = "VER"

        oHash.Add("@Nombre", nuevoUsuario.Nombre)
        oHash.Add("@Usuario", nuevoUsuario.User)
        oHash.Add("@DVV", nuevoUsuario.DVV)
        oHash.Add("@DVH", nuevoUsuario.DVH)
        oHash.Add("@Activo", nuevoUsuario.Activo)
        oHash.Add("@IDPerfil", nuevoUsuario.IDPerfil)

        oDatos.insertUsuario(Consulta, oHash)

    End Sub

    Function buscarUsuario(ByVal nuevoUsuario) As UsuarioEntity

        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim oUsuario As New UsuarioEntity
        Dim Consulta As String = "SP_Select_Usuario"
        Dim PasswordHash() As Byte = encriptar.hashearPassword(nuevoUsuario.Password)

        oHash.Add("@Usuario", nuevoUsuario.User)
        oHash.Add("@Contraseña", PasswordHash)

        oUsuario = oDatos.buscarUsuario(Consulta, oHash)

        Return oUsuario
    End Function

    Function listarUsuarios() As List(Of UsuarioEntity)

        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim listaUsuarios As New List(Of UsuarioEntity)
        Dim Consulta As String = "SP_Select_ListarUsuarios"

        listarUsuarios = oDatos.listarUsuarios(Consulta)

        Return listarUsuarios
    End Function





End Class
