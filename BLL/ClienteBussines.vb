Imports DAL
Imports EE
Imports Servicios
Public Class ClienteBussines


    Function buscarClienteTEL(telefono As String) As ClienteEntity
        Dim nuevoDatos = New ClienteDAL
        Dim nuevoCliente = nuevoDatos.buscarClienteTEL(telefono)
        Return nuevoCliente
    End Function

    Function buscarClienteDIR(direccion As String) As ClienteEntity
        Dim nuevoDatos = New ClienteDAL
        Dim nuevoCliente = nuevoDatos.buscarClienteDIR(direccion)
        Return nuevoCliente
    End Function

    Function listarCliente() As List(Of ClienteEntity)
        Dim nuevaLista = New List(Of ClienteEntity)
        Dim nuevoDatos = New ClienteDAL
        nuevaLista = nuevoDatos.listarClientes()
        Return nuevaLista
    End Function

    Public Sub insertCliente(cliente As ClienteEntity)
        Dim nuevoDatos = New ClienteDAL
        Dim hash = New CryptoManager
        Dim nuevoDVV = New DVVBussines

        cliente.dvh = cliente.apyn.Length + cliente.direccion.Length
        cliente.dvv = nuevoDatos.buscarDVV()
        nuevoDatos.insertCliente(cliente)
        nuevoDVV.actualizarDVV("Clientes", cliente.dvv)


    End Sub

    Function buscarDVVCliente() As Integer
        Dim nuevoDatos = New ClienteDAL
        Dim dvv = nuevoDatos.buscarDVV()
        Return dvv
    End Function

    Function searchCliente(nombre As String, direccion As String) As ClienteEntity
        Dim nuevoDatos = New ClienteDAL
        Dim nuevoCliente = New ClienteEntity
        nuevoCliente = nuevoDatos.buscarCliente(nombre, direccion)
        Return nuevoCliente
    End Function

    Sub updateCliente(cliente As ClienteEntity, id As Integer)
        Dim nuevoDatos = New ClienteDAL
        Dim nuevoCliente = New ClienteEntity
        nuevoCliente = nuevoDatos.updateCliente(cliente, id)
    End Sub

End Class
