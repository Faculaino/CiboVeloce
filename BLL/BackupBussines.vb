Imports DAL
Public Class BackupBussines

    Function backup(query As String, ubicacion As String) As Boolean
        Dim newBackup = New BackupDAL
        Dim resultado = newBackup.backupDatos(query, ubicacion)
        Return resultado
    End Function

End Class
