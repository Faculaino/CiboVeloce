Imports EE
Imports DAL
Imports System.Globalization

Public Class IdiomaBussines

    Function listarIdiomas() As List(Of IdiomaEntity)

        Dim oDatos As New IdiomasDAL
        Dim lista As New List(Of IdiomaEntity)

        lista = oDatos.listaIdiomas()

        Return lista
    End Function


    Function buscarIdiomaID(id As Integer) As IdiomaEntity

        Dim oDatos As New IdiomasDAL
        Dim nuevoIdioma = New IdiomaEntity

        nuevoIdioma = oDatos.buscarIdiomaID(id)

        Return nuevoIdioma

    End Function



End Class
