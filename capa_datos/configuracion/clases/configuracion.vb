Public Class configuracion
    Shared _cadenaConexion As String = ""
    Public Shared ReadOnly Property CadenaConexion() As String
        Get
            Return _cadenaConexion
        End Get
    End Property
End Class
