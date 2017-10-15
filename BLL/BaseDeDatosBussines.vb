Imports DAL
Public Class BaseDeDatosBussines

    Function backup() As Boolean
        Dim newBackup = New BaseDeDatosDAL
        Dim resultado = newBackup.backupDatos()
        Return resultado
    End Function

    Function restore(archivo As String) As Boolean
        Dim nuevoRestore = New BaseDeDatosDAL
        Dim resultado = nuevoRestore.restoreBD(archivo)
        Return resultado
    End Function

End Class
