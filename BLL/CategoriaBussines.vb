Imports EE
Imports DAL
Public Class CategoriaBussines


    Function listarCategorias() As List(Of CategoriaEntity)
        Dim nuevoDatos = New CategoriaDAL
        Dim nuevaLista = New List(Of CategoriaEntity)
        nuevaLista = nuevoDatos.listarCategorias()
        Return nuevaLista
    End Function



End Class
