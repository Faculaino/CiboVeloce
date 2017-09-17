Imports EE
Imports DAL
Public Class IdiomaBussines



    Function listarIdiomas() As List(Of IdiomaEntity)

        Dim oDatos As New IdiomasDAL
        Dim oHash As New Hashtable
        Dim lista As New List(Of IdiomaEntity)
        Dim Consulta As String = "SP_Select_Idiomas"

        lista = oDatos.listaIdiomas(Consulta)

        Return lista
    End Function




End Class
