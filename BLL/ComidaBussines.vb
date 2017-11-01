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


End Class
