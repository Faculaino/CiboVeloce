Imports EE
Public MustInherit Class Objeto

    Private Shared _listObserver As New List(Of IObserver)

    Public Shared Sub agregarObserver(observer As IObserver)
        _listObserver.Add(observer)
    End Sub


    Public Shared Sub quitarObserver(observer As IObserver)
        _listObserver.Remove(observer)
    End Sub

    Public Shared Sub modificaObserver(idioma As IdiomaEntity)
        For Each observer In _listObserver
            observer.modificarIdioma(idioma)
        Next
    End Sub

End Class
