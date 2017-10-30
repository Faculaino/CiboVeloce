Imports System.Text
Imports System.Security
Imports System.Security.Cryptography
Public Class CryptoManager


    Public Function hashearPassword(ByVal contraseña As String) As Byte()
        Dim PasswordOrigen() As Byte
        Dim PasswordHash() As Byte
        PasswordOrigen = Encoding.ASCII.GetBytes(contraseña)
        PasswordHash = New MD5CryptoServiceProvider().ComputeHash(PasswordOrigen)

        Return PasswordHash
    End Function

    Public Function hashearDato(dato As String) As Byte()
        Dim datoOriginal() As Byte
        Dim datoModificado() As Byte
        datoOriginal = Encoding.ASCII.GetBytes(dato)
        datoModificado = New MD5CryptoServiceProvider().ComputeHash(datoOriginal)

        Return datoModificado
    End Function




End Class
