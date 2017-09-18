Imports EE
Imports DAL
Public Class BitacoraBussines


    Sub guardarEvento(evento As String, user As UsuarioEntity)

        Dim nuevoLog = New BitacoraDAL
        Dim query = "INSERT INTO Bitacora (Mensaje, IDUsuario, FechaHora) VALUES ('" & evento & "', " & user.ID & ", GETDATE())"
        nuevoLog.guardarEventos(query, user)

    End Sub

    Function listarEventos() As List(Of BitacoraEntity)

        Dim nuevalista = New List(Of BitacoraEntity)
        Dim query = "SELECT * FROM Bitacora"
        Dim nuevaConsulta = New BitacoraDAL

        nuevalista = nuevaConsulta.listarBitacora(query)


        Return nuevalista
    End Function



End Class
