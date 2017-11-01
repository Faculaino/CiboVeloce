Imports EE
Imports DAL
Public Class DVVBussines

    Public Sub actualizarDVV(tabla As String, valor As Integer)
        Dim nuevoDatos = New DVVDAL
        nuevoDatos.actualiarDVV(tabla, valor)
    End Sub

    Function buscarDVV(tabla As String) As Integer
        Dim nuevoDatos = New DVVDAL
        Dim resultado As Integer
        resultado = nuevoDatos.buscarValor(tabla)
        Return resultado
    End Function


End Class
