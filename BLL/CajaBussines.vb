Imports EE
Imports DAL
Public Class CajaBussines


    Sub insertRegistro(caja As CajaEntity, motivo As String)
        Dim nuevoDatos = New CajaDAL
        nuevoDatos.insertRegistro(caja, motivo)
    End Sub

    Function listarRegistros() As List(Of CajaEntity)
        Dim nuevaLista = New List(Of CajaEntity)
        Dim nuevoDatos = New CajaDAL
        nuevaLista = nuevoDatos.listarCaja()
        Return nuevaLista
    End Function

    Function registrosFechas(fecha1 As DateTime, fecha2 As DateTime) As List(Of CajaEntity)
        Dim nuevaLista = New List(Of CajaEntity)
        Dim nuevoDatos = New CajaDAL
        nuevaLista = nuevoDatos.registrosFechas(fecha1, fecha2)
        Return nuevaLista
    End Function


End Class
