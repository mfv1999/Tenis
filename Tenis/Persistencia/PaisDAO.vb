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

    Public Sub leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE idPais='" & p.idPais & "';")

        For Each aux In col
            p.nombrePais = aux(2).ToString
        Next
    End Sub

    Public Function insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSTERT INTO Paises VALUES ('" & p.idPais & "','" & p.nombrePais & "');")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Paises WHERE IDPersona='" & p.idPais & "';")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & p.nombrePais & "' WHERE IDPersona='" & p.idPais & "';")
    End Function

End Class