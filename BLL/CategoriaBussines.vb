Imports EE
Imports DAL
Public Class CategoriaBussines


    Function listarCategorias() As List(Of CategoriaEntity)
        Dim nuevoDatos = New CategoriaDAL
        Dim nuevaLista = New List(Of CategoriaEntity)
        nuevaLista = nuevoDatos.listarCategorias()
        Return nuevaLista
    End Function

    Sub insertCategoria(nombre As String)
        Dim nuevoDatos = New CategoriaDAL
        Dim nuevaCategoria = New CategoriaEntity
        Dim nuevoDVV = New DVVBussines
        nuevaCategoria.tipo = nombre
        nuevaCategoria.dvh = nombre.Length
        nuevaCategoria.dvv = buscaDVVCategoria() + 1


        nuevoDatos.insertCategoria(nuevaCategoria)
        nuevoDVV.actualizarDVV("Categorias", nuevaCategoria.dvv)


    End Sub

    Function buscaDVVCategoria() As Integer
        Dim valor As Integer
        Dim nuevoDatos = New CategoriaDAL
        valor = nuevoDatos.buscaDVV()
        Return valor
    End Function

    Function listarComidas(idCategoria As Integer) As List(Of ComidaEntity)
        Dim nuevoDatos = New CategoriaDAL
        Dim nuevaLista = New List(Of ComidaEntity)
        nuevaLista = nuevoDatos.listarComidas(idCategoria)
        Return nuevaLista
    End Function



End Class
