Imports System.Data.SqlClient
Public Class acceso_datos

#Region "info_estudiantes"

#Region "Buscar informacion"

    Public Shared Function buscar_info_estudiante(id_cedula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "EXEC GetEstudiante @id_cedula = @id"                                                         'Ejecucion del SP

        sql_command.Parameters.Add("@id", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_cedula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
    Public Shared Function buscar_info_estudiante_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "exec GetEstudiante_todo"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

#End Region

#Region "Agregar"
    Public Shared Function agregar_info_estudiante(id_cedula As String, nombre As String, apellido As String, direccion As String,
                                            telefono As String, correo As String, id_carrera As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "INSERT INTO info_estudiante VALUES(@id_cedula, @nombre, @apellido, @direccion, @telefono, @correo, @id_carrera)"

        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@apellido", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@direccion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@telefono", SqlDbType.Int)
        sql_command.Parameters.Add("@correo", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_cedula
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = apellido
        sql_command.Parameters(3).Value = direccion
        sql_command.Parameters(4).Value = telefono
        sql_command.Parameters(5).Value = correo
        sql_command.Parameters(6).Value = id_carrera

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_estudiante(id_cedula As String, nombre As String, apellido As String, direccion As String,
                                            telefono As String, correo As String, id_carrera As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "UPDATE info_estudiante SET nombre = @nombre, apellido = @apellido, direccion = @direccion, celular = @telefono, correo = @correo, id_carrera = @id_carrera WHERE id_cedula = @id_cedula"

        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@apellido", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@direccion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@telefono", SqlDbType.Int)
        sql_command.Parameters.Add("@correo", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_cedula
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = apellido
        sql_command.Parameters(3).Value = direccion
        sql_command.Parameters(4).Value = telefono
        sql_command.Parameters(5).Value = correo
        sql_command.Parameters(6).Value = id_carrera

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Borrar"
    Public Shared Function borrar_info_estudiante(id_estudiante As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "DELETE FROM info_estudiante WHERE id_cedula = @id_cedula"
        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_estudiante

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#End Region

#Region "info_carrera"
#Region "buscar"
    Public Shared Function buscar_info_carrera(id_carrera As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_carrera WHERE id_carrera = @id_carrera"
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_carrera

        tabla = metodos_datos.EjecutarBusqueda(sql_command)

        Return tabla
    End Function

    Public Shared Function buscar_info_carrera_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_carrera"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)

        Return tabla
    End Function
#End Region

#Region "Agregar"
    Public Shared Function agregar_info_carrera(id_carrera As String, nombre As String, descripcion As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "INSERT INTO info_carrera VALUES(@id_carrera, @nombre, @descripcion)"
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@descripcion", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_carrera
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = descripcion

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_carrera(id_carrera As String, nombre As String, descripcion As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command.CommandText = "UPDATE info_carrera SET nombre = @nombre, descripcion = @descripcion WHERE id_carrera = @id_carrera"
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@descripcion", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_carrera
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = descripcion

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Borrar"
    Public Shared Function borrar_info_carrera(id_carrera As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "DELETE FROM info_carrera WHERE id_carrera = @id_carrera"
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_carrera

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#End Region

#Region "Info_cursos"
#Region "buscar"
    Public Shared Function buscar_info_curso(id_curso As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetCurso @id_curso"
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_curso

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_curso() As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetCurso_todo"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
#End Region

#Region "Agregar"
    Public Shared Function agregar_info_curso(id_curso As String, id_carrera As String, id_horario As String, nombre As String, id_profesor As String, descripcion As String,
                                              requisito As String, id_sede As String, costo As String, creditos As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "INSERT INTO info_curso VALUES(@id_curso, @id_carrera, @id_horario, @nombre, @id_profesor, @descripcion, @requisito, @id_sede, @costo, @creditos)"
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_profesor", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@requisito", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@costo", SqlDbType.Int)
        sql_command.Parameters.Add("@creditos", SqlDbType.Int)

        sql_command.Parameters(0).Value = id_curso
        sql_command.Parameters(1).Value = id_carrera
        sql_command.Parameters(2).Value = id_horario
        sql_command.Parameters(3).Value = nombre
        sql_command.Parameters(4).Value = id_profesor
        sql_command.Parameters(5).Value = descripcion
        sql_command.Parameters(6).Value = requisito
        sql_command.Parameters(7).Value = id_sede
        sql_command.Parameters(8).Value = costo
        sql_command.Parameters(9).Value = creditos

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_curso(id_curso As String, id_carrera As String, id_horario As String, nombre As String, id_profesor As String, descripcion As String,
                                              requisito As String, id_sede As String, costo As String, creditos As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "UPDATE info_curso SET id_carrera = @id_carrera, id_horario = @id_horario, nombre = @nombre, id_profesor = @id_profesor, descripcion = @descripcion, requisito = @requisito, id_sede = @id_sede, costo = @costo, creditos = @creditos WHERE id_curso = @id_curso"
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_profesor", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@requisito", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@costo", SqlDbType.Int)
        sql_command.Parameters.Add("@creditos", SqlDbType.Int)

        sql_command.Parameters(0).Value = id_curso
        sql_command.Parameters(1).Value = id_carrera
        sql_command.Parameters(2).Value = id_horario
        sql_command.Parameters(3).Value = nombre
        sql_command.Parameters(4).Value = id_profesor
        sql_command.Parameters(5).Value = descripcion
        sql_command.Parameters(6).Value = requisito
        sql_command.Parameters(7).Value = id_sede
        sql_command.Parameters(8).Value = costo
        sql_command.Parameters(9).Value = creditos

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Borrar"
    Public Shared Function borrar_info_curso(id_curso As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "DELETE FROM info_curso WHERE id_curso = @id_curso"
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_curso

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#End Region

End Class
