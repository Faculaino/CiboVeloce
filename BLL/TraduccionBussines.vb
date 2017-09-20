Imports EE
Imports DAL
Public Class TraduccionBussines


    Function listarTraduccion(id As Integer) As List(Of TraduccionEntity)

        Dim nuevaLista = New List(Of TraduccionEntity)
        Dim nuevoDatos = New IdiomasDAL
        Dim query = "SP_Select_ListarTraduccion"
        nuevaLista = nuevoDatos.listarPalabras(query, id)

        Return nuevaLista
    End Function



End Class
