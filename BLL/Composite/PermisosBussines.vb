Imports EE
Imports DAL
Public Class PermisosBussines


    Function listarPermisos() As List(Of PermisoEntity)

        Dim nuevoDatos = New PermisoDAL
        Dim listado = nuevoDatos.listarPermisos("Select * From Permisos")

        Return listado
    End Function





End Class
