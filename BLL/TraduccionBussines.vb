Imports EE
Imports DAL
Public Class TraduccionBussines


    Function listarTraduccion(id As Integer) As List(Of TraduccionEntity)

        Dim nuevaLista = New List(Of TraduccionEntity)
        Dim nuevoDatos = New IdiomasDAL
        nuevaLista = nuevoDatos.listarPalabras(id)

        Return nuevaLista
    End Function

    Function palabrasTraducidas(id As Integer) As Hashtable

        Dim lista = New List(Of TraduccionEntity)
        Dim nuevoDatos = New IdiomasDAL
        lista = nuevoDatos.listarPalabras(id)

        Dim diccionario = New Dictionary(Of String, String)

        For Each item In lista
            diccionario.Add(item.IDPalabra.ToString(), item.PalabraTraducida)
        Next
        Dim ht As New Hashtable(diccionario)

        Return ht

    End Function






End Class



