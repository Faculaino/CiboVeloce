Imports EE
Imports DAL
Public Class TraduccionBussines


    Function listarTraduccion(id As Integer) As List(Of TraduccionEntity)

        Dim nuevaLista = New List(Of TraduccionEntity)
        Dim nuevoDatos = New IdiomasDAL
        nuevaLista = nuevoDatos.listarPalabras(id)

        Return nuevaLista
    End Function



End Class
