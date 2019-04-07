Imports System.Data.SqlClient
Public Class metodos_datos

    Public Shared Function CrearComando() As SqlCommand
        Dim cadenaConexion = configuracion.CadenaConexion
        Dim conexion As New SqlConnection()
        conexion.ConnectionString = cadenaConexion
        Dim comando As New SqlCommand()
        comando = conexion.CreateCommand()
        comando.CommandType = CommandType.Text
        Return comando
    End Function

    Public Shared Function CrearComando_sp() As SqlCommand                          'Comando para los Stored Procedures
        Dim cadenaConexion = configuracion.CadenaConexion
        Dim conexion As New SqlConnection()
        conexion.ConnectionString = cadenaConexion
        Dim comando As New SqlCommand()
        comando = conexion.CreateCommand()
        comando.CommandType = CommandType.StoredProcedure
        Return comando
    End Function

    Public Shared Function EjecutarComando(comando As SqlCommand) As Integer
        Dim i As Integer
        Try
            comando.Connection.Open()
            i = comando.ExecuteNonQuery()
            Return i
        Catch ex As Exception
            Return -1 'Se genera un error
        Finally
            comando.Connection.Close()
        End Try
    End Function
    Public Shared Function EjecutarBusqueda(comando As SqlCommand) As DataTable
        Dim tabla As New DataTable
        Dim adaptador As New SqlDataAdapter
        Try
            comando.Connection.Open()
            adaptador.SelectCommand = comando
            adaptador.Fill(tabla)
        Catch ex As Exception
        Finally
            comando.Connection.Close()
        End Try
        Return tabla
    End Function
    Public Shared Function EjecutarBusqueda_sp(comando As SqlCommand) As DataTable
        Dim tabla As New DataTable
        Dim adaptador As New SqlDataAdapter
        Try
            comando.Connection.Open()
            adaptador.SelectCommand = comando
            adaptador.Fill(tabla)
        Catch ex As Exception
        Finally
            comando.Connection.Close()
        End Try
        Return tabla
    End Function



End Class
