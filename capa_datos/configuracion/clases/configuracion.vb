Public Class configuracion
    Shared _cadenaConexion As String = "Data Source=.;Initial Catalog=registro-escolar;Integrated Security=True"
    Public Shared ReadOnly Property CadenaConexion() As String
        Get
            Return _cadenaConexion
        End Get
    End Property
End Class
