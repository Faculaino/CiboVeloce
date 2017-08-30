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




End Class
