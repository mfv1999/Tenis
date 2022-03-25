Public Class Pais
    Public Property idPais As String
    Public Property nombrePais As String
    Public ReadOnly Property paisDao As PaisDAO

    Public Sub New()
        Me.paisDao = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.paisDao = New PaisDAO
        Me.idPais = id
    End Sub

    Public Sub New(id As String, nombre As String)
        Me.idPais = id
        Me.nombrePais = nombre
    End Sub

    Public Sub leerTodosPaises()
        Me.paisDao.leerTodos()
    End Sub

    Public Function insertarPais() As Integer
        Return Me.paisDao.insertar(Me)
    End Function

    Public Function actualizarPais() As Integer
        Return Me.paisDao.Actualizar(Me)
    End Function

    Public Function borrarPais() As Integer
        Return Me.paisDao.Borrar(Me)
    End Function
End Class
