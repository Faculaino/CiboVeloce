Imports EE
Imports DAL
Public Class BitacoraBussines


    Sub guardarEvento(evento As String, user As UsuarioEntity)

        Dim nuevoLog = New BitacoraDAL
        nuevoLog.guardarEventos(evento, user)

    End Sub

    Function listarEventos() As List(Of BitacoraEntity)

        Dim nuevalista = New List(Of BitacoraEntity)
        Dim nuevaConsulta = New BitacoraDAL

        nuevalista = nuevaConsulta.listarBitacora()


        Return nuevalista
    End Function



End Class
