Public Class PaisDAO
    Public ReadOnly Property paises As Collection

    Public Sub New()
        Me.paises = New Collection
    End Sub

    Public Sub leerTodos()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Paises ORDER BY NombrePais asc")

        For Each aux In col
            p = New Pais(aux(1).ToString, aux(2).ToString)
            Me.paises.Add(p)
        Next
    End Sub


End Class
