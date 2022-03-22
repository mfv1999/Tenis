Public Class Pais
    Public Property idPais As String
    Public Property nombrePais As String
    Public ReadOnly Property paisDao As PaisDAO

    Public Sub New()
        Me.paisDao = New PaisDAO
    End Sub

End Class
