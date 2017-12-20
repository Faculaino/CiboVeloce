Imports System.IO

Public Class FileStreamManager
    Private Shared _instance As FileStreamManager
    Private Shared ReadOnly _lock As Object = New Object()

    Public Shared ReadOnly Property Instance() As FileStreamManager
        Get
            SyncLock _lock
                If (_instance Is Nothing) Then
                    _instance = New FileStreamManager()
                End If
            End SyncLock

            Return _instance
        End Get

    End Property

    Public Function CreateFile(ext As String) As FileStream

        Dim file As String
        file = "Clientes"
        Return New FileStream("\XML\" + file, FileMode.Create)
    End Function

End Class
