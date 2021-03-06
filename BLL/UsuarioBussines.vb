﻿Imports EE
Imports DAL
Imports System.Security.Cryptography
Imports System.Text
Imports Servicios

Public Class UsuarioBussines

    Private encriptar = New CryptoManager

    Sub insertUsuario(ByVal nuevoUsuario As UsuarioEntity)
        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim nuevoDVV = New DVVBussines
        Dim PasswordHash() As Byte = encriptar.hashearPassword(nuevoUsuario.Password)
        Dim dvv = oDatos.buscarDVV() + 1

        oHash.Add("@Nombre", nuevoUsuario.Nombre)
        oHash.Add("@Usuario", nuevoUsuario.User)
        oHash.Add("@Contraseña", PasswordHash)
        oHash.Add("@DVV", dvv)
        oHash.Add("@DVH", nuevoUsuario.DVH)
        oHash.Add("@Activo", nuevoUsuario.Activo)
        oHash.Add("@IDPerfil", nuevoUsuario.IDPerfil)
        oHash.Add("@IDIdioma", nuevoUsuario.IDIdioma)

        oDatos.insertUsuario(oHash)
        nuevoDVV.actualizarDVV("Usuarios", dvv)

    End Sub

    Sub deleteUsuario(ByVal nuevoUsuario As UsuarioEntity)
        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable

        oHash.Add("@Nombre", nuevoUsuario.Nombre)
        oHash.Add("@Usuario", nuevoUsuario.User)
        oHash.Add("@DVV", nuevoUsuario.DVV)
        oHash.Add("@DVH", nuevoUsuario.DVH)
        oHash.Add("@Activo", nuevoUsuario.Activo)
        oHash.Add("@IDPerfil", nuevoUsuario.IDPerfil)
        oHash.Add("@IDIdioma", nuevoUsuario.IDIdioma)

        oDatos.deleteUsuario(oHash)

    End Sub

    Sub modificaIdioma(idIdioma As Integer, iduser As Integer)
        Dim nuevoDatos = New UsuarioDAL
        nuevoDatos.modificaIdioma(idIdioma, iduser)
    End Sub

    Function buscarUsuario(ByVal nuevoUsuario) As UsuarioEntity

        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim oUsuario As New UsuarioEntity
        Dim PasswordHash() As Byte = encriptar.hashearPassword(nuevoUsuario.Password)

        oHash.Add("@Usuario", nuevoUsuario.User)
        oHash.Add("@Contraseña", PasswordHash)

        oUsuario = oDatos.buscarUsuario(oHash)

        Return oUsuario
    End Function

    Function listarUsuarios() As List(Of UsuarioEntity)

        Dim oDatos As New UsuarioDAL
        Dim oHash As New Hashtable
        Dim listaUsuarios As New List(Of UsuarioEntity)

        listarUsuarios = oDatos.listarUsuarios()

        Return listarUsuarios
    End Function

    Sub updateUsuarios(dvh As Integer)
        Dim nuevoDatos = New UsuarioDAL
        nuevoDatos.updateUsuariosDVH(dvh)
    End Sub

    Function buscarUserID(id As Integer) As UsuarioEntity
        Dim nuevoDatos = New UsuarioDAL
        Dim nuevoUsuario = nuevoDatos.buscarUserID(id)
        Return nuevoUsuario
    End Function

    Public Sub modificarPerfil(IDUser As Integer, id As Integer)
        Dim nuevoDatos = New UsuarioDAL
        nuevoDatos.modificarPerfil(IDUser, id)
    End Sub
End Class
