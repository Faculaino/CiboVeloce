Imports EE
Imports DAL
Public Class ComidaBussines



    Function listarComidas() As List(Of ComidaEntity)
        Dim nuevoDatos = New ComidaDAL
        Dim nuevaLista = New List(Of ComidaEntity)
        nuevaLista = nuevoDatos.listarComidas()
        Return nuevaLista
    End Function



End Class
