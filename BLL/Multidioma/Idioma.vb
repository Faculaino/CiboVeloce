﻿Public Class Idioma
    Private Property idioma As String

    Sub New(_Idioma As String)
        idioma = _Idioma

    End Sub
    Sub New()

    End Sub
    Public Sub CambiarIdioma(nidioma As String)
        idioma = nidioma
    End Sub
    Function getIdioma() As String
        Return idioma
    End Function
End Class
