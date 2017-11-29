Imports EE
Imports DAL
Public Class ComidaBussines



    Function listarComidas() As List(Of ComidaEntity)
        Dim nuevoDatos = New ComidaDAL
        Dim nuevaLista = New List(Of ComidaEntity)
        nuevaLista = nuevoDatos.listarComidas()
        Return nuevaLista
    End Function

    Sub insertComida(comida As ComidaEntity)
        Dim nuevoDatos = New ComidaDAL
        Dim nuevoDVV = New DVVBussines
        comida.dvh = comida.detalle.Length
        comida.dvv = nuevoDVV.buscarDVV("Comidas") + 1

        nuevoDatos.insertComida(comida)
        nuevoDVV.actualizarDVV("Comidas", comida.dvv)

    End Sub

    Function consultaDVVComida() As Integer
        Dim valor As Integer
        Dim nuevoDatos = New ComidaDAL
        valor = nuevoDatos.buscaDVV()
        Return valor
    End Function

    Sub borrarRegistros(id As Integer)
        Dim nuevoDatos = New ComidaDAL
        nuevoDatos.borrarReg(id)
    End Sub

    Public Sub insertComidaLista(listaComida As List(Of ComidaEntity))
        Dim nuevoDatos = New ComidaDAL
        Dim nuevoDVV = New DVVBussines

        For Each item As ComidaEntity In listaComida
            Dim nuevaComida = New ComidaEntity
            nuevaComida.detalle = item.detalle
            nuevaComida.idcategoria = item.idcategoria
            nuevaComida.precio = item.precio
            nuevaComida.dvh = item.detalle.Length
            nuevaComida.dvv = nuevoDVV.buscarDVV("Comidas") + 1

            nuevoDatos.insertComida(nuevaComida)
            nuevoDVV.actualizarDVV("Comidas", nuevaComida.dvv)
        Next

    End Sub
End Class
