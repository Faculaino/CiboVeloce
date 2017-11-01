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

    Sub controlCambios(cambio As String, user As UsuarioEntity)
        Dim nuevoLog = New BitacoraDAL
        nuevoLog.guardarCambios(cambio, user, Now.ToShortDateString)
    End Sub



End Class
