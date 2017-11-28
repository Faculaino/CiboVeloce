Imports BLL
Imports EE
Public MustInherit Class Sujeto

    Protected listaObservador As List(Of IObserver)


    Sub agregar(observer As IObserver)
        listaObservador.Add(observer)
    End Sub

    Sub eliminar(observer As IObserver)
        listaObservador.Remove(observer)
    End Sub

    Sub notificar()
        For Each observador In listaObservador
            'observador.actulizar(session.traducciones)
        Next
    End Sub

End Class
