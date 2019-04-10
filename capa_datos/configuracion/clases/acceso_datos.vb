Imports System.Data.SqlClient
Public Class acceso_datos

#Region "info_estudiantes"

#Region "Buscar informacion"
    Public Shared Function buscar_id_cedula() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "SELECT id_cedula FROM info_estudiante"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_estudiante_plano(id_cedula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "SELECT * FROM info_estudiante WHERE id_cedula = @id_cedula"                                                         'Ejecucion del SP

        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_cedula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

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
                                            telefono As String, celular As String, correo As String, id_carrera As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "INSERT INTO info_estudiante VALUES(@id_cedula, @nombre, @apellido, @direccion, @telefono, @celular, @correo, @id_carrera)"

        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@apellido", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@direccion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@telefono", SqlDbType.Int)
        sql_command.Parameters.Add("@celular", SqlDbType.Int)
        sql_command.Parameters.Add("@correo", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_cedula
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = apellido
        sql_command.Parameters(3).Value = direccion
        sql_command.Parameters(4).Value = telefono
        sql_command.Parameters(5).Value = celular
        sql_command.Parameters(6).Value = correo
        sql_command.Parameters(7).Value = id_carrera

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_estudiante(id_cedula As String, nombre As String, apellido As String, direccion As String,
                                            telefono As String, celular As String, correo As String, id_carrera As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand
        sql_command = metodos_datos.CrearComando

        sql_command.CommandText = "UPDATE info_estudiante SET nombre = @nombre, apellido = @apellido, direccion = @direccion,telefono = @telefono, celular = @celular, correo = @correo, id_carrera = @id_carrera WHERE id_cedula = @id_cedula"

        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@apellido", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@direccion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@telefono", SqlDbType.Int)
        sql_command.Parameters.Add("@celular", SqlDbType.Int)
        sql_command.Parameters.Add("@correo", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_cedula
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = apellido
        sql_command.Parameters(3).Value = direccion
        sql_command.Parameters(4).Value = telefono
        sql_command.Parameters(5).Value = celular
        sql_command.Parameters(6).Value = correo
        sql_command.Parameters(7).Value = id_carrera

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

    Public Shared Function buscar_id_carrera() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT id_carrera FROM info_carrera"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
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
        sql_command.CommandText = "SELECT * FROM info_carrera "

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

        sql_command = metodos_datos.CrearComando()
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
    Public Shared Function buscar_id_curso() As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT id_curso FROM info_curso"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function


    Public Shared Function buscar_info_curso_plano(id_curso As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_curso WHERE id_curso = @id_curso"
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_curso

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
    Public Shared Function buscar_info_curso_carrera(id_curso As String, id_carrera As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetCurso @id_curso, @id_carrera"
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_curso
        sql_command.Parameters(1).Value = id_carrera

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla

    End Function

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

    Public Shared Function buscar_info_curso_todo() As DataTable
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

#Region "Info_matricula"

#Region "buscar"

    Public Shared Function buscar_id_matricula() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT id_matricula FROM info_matricula"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function


    Public Shared Function buscar_info_matricula_estudiante_plano(id_matricula As String, id_cedula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_matricula WHERE id_matricula = @id_matricula AND id_cedula = @id_cedula"
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_matricula
        sql_command.Parameters(1).Value = id_cedula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    '*******************************************************************************
    Public Shared Function buscar_info_matricula_estudiante(id_matricula As String, id_cedula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetMatriculaEstudiante @id_matricula,@id_cedula"
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_matricula
        sql_command.Parameters(1).Value = id_cedula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function


    Public Shared Function buscar_info_matricula(id_matricula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetMatricula @id_matricula"
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters(0).Value = id_matricula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_matricula_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetMatricula_todo"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
#End Region

#Region "Agregar"
    Public Shared Function agregar_info_matricula(id_matricula As String, id_cedula As String, id_curso As String, año As String, cuatrimestre As String)
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "INSERT INTO info_matricula VALUES (@id_matricula, @id_cedula, @id_curso, @año, @cuatrimestre)"
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@año", SqlDbType.Int)
        sql_command.Parameters.Add("@cuatrimestre", SqlDbType.Int)

        sql_command.Parameters(0).Value = id_matricula
        sql_command.Parameters(1).Value = id_cedula
        sql_command.Parameters(2).Value = id_curso
        sql_command.Parameters(3).Value = año
        sql_command.Parameters(4).Value = cuatrimestre

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_matricula(id_matricula As String, id_cedula As String, id_curso As String, año As String, cuatrimestre As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "UPDATE info_matricula SET id_curso = @id_curso, año = @año, cuatrimestre = @cuatrimestre WHERE id_matricula = @id_matricula AND id_cedula = @id_cedula"
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_curso", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@año", SqlDbType.Int)
        sql_command.Parameters.Add("@cuatrimestre", SqlDbType.Int)

        sql_command.Parameters(0).Value = id_matricula
        sql_command.Parameters(1).Value = id_cedula
        sql_command.Parameters(2).Value = id_curso
        sql_command.Parameters(3).Value = año
        sql_command.Parameters(4).Value = cuatrimestre

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borar_info_matricula(id_matricula As String, id_cedula As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "DELETE FROM info_matricula WHERE id_matricula = @id_matricula AND id_cedula = @id_cedula"
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_cedula", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_matricula
        sql_command.Parameters(1).Value = id_cedula

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region
#End Region

#Region "info_horario"

#Region "Buscar"
    Public Shared Function buscar_id_horario() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT id_horario FROM info_horario"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario_plano(id_horario As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_horario WHERE id_horario = @id_horario"
        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_horario

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario_carrera(id_horario As String, id_carrera As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetHorarioCarrera @id_horario, @id_carrera"
        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_horario
        sql_command.Parameters(1).Value = id_carrera

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario(id_horario As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetHorarioCarrera @id_horario"
        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_horario

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetHorario_todo"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
#End Region

#Region "agregar"

    Public Shared Function agregar_info_horario(id_horario As String, id_carrera As String, dia As String, hora As String, id_sede As String) As Integer
        Dim i As Integer
        Dim sql_commmand As New SqlCommand

        sql_commmand = metodos_datos.CrearComando()
        sql_commmand.CommandText = "INSERT INTO info_horario VALUES(@id_horario, @id_carrera, @dia, @hora, @id_sede)"
        sql_commmand.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        sql_commmand.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_commmand.Parameters.Add("@dia", SqlDbType.VarChar)
        sql_commmand.Parameters.Add("@hora", SqlDbType.Int)
        sql_commmand.Parameters.Add("@id_sede", SqlDbType.NVarChar)

        sql_commmand.Parameters(0).Value = id_horario
        sql_commmand.Parameters(1).Value = id_carrera
        sql_commmand.Parameters(2).Value = dia
        sql_commmand.Parameters(3).Value = hora
        sql_commmand.Parameters(4).Value = id_sede

        i = metodos_datos.EjecutarComando(sql_commmand)
        Return i
    End Function
#End Region

#Region "modificar"
    Public Shared Function modificar_info_horario(id_horario As String, id_carrera As String, dia As String, hora As String, id_sede As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando()
        sql_command.CommandText = "UPDATE info_horario SET id_carrera = @id_carrera, dia = @dia, hora = @hora, id_sede = @id_sede WHERE id_horario = @id_horario"
        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_carrera", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@dia", SqlDbType.VarChar)
        sql_command.Parameters.Add("@hora", SqlDbType.Int)
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_horario
        sql_command.Parameters(1).Value = id_carrera
        sql_command.Parameters(2).Value = dia
        sql_command.Parameters(3).Value = hora
        sql_command.Parameters(4).Value = id_sede

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_horario(id_horario As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando()
        sql_command.CommandText = "DELETE FROM info_horario WHERE id_horario = @id_horario"

        sql_command.Parameters.Add("@id_horario", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_horario

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#End Region

#Region "info_profesores"

#Region "Buscar"

    Public Shared Function buscar_id_profesor() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT id_profesor FROM info_profesor"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function


    Public Shared Function buscar_info_profesor(id_profesor As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_profesor WHERE id_profesor = @id_profesor"
        sql_command.Parameters.Add("@id_profesor", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_profesor

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_profesor_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_profesor"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

#End Region

#Region "agregar"
    Public Shared Function agregar_info_profesor(id_profesor As String, nombre As String, apellido As String, correo As String, telefono As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "INSERT INTO info_profesor VALUES(@id_profesor, @nombre, @apellido, @correo, @telefono)"
        sql_command.Parameters.Add("@id_profesor", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@apellido", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@correo", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@telefono", SqlDbType.Int)

        sql_command.Parameters(0).Value = id_profesor
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = apellido
        sql_command.Parameters(3).Value = correo
        sql_command.Parameters(4).Value = telefono

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "modificar"
    Public Shared Function modificar_info_profesor(id_profesor As String, nombre As String, apellido As String, correo As String, telefono As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "UPDATE info_profesor SET nombre = @nombre, apellido = @apellido, correo = @correo, telefono = @telefono WHERE id_profesor = @id_profesor"
        sql_command.Parameters.Add("@id_profesor", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@apellido", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@correo", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@telefono", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_profesor
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = apellido
        sql_command.Parameters(3).Value = correo
        sql_command.Parameters(4).Value = telefono

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_profesor(id_profesor As String) As String
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando()
        sql_command.CommandText = "DELETE FROM info_profesor WHERE id_profesor = @id_profesor"
        sql_command.Parameters.Add("@id_profesor", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_profesor
        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function

#End Region

#End Region

#Region "info_notas"
    Public Shared Function buscar_info_notas_plano(id_notas As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_notas WHERE id_nota = @id_nota"
        sql_command.Parameters.Add("@id_nota", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_notas

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_notas_estudiante_curso() As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetNotas_Estudiante_Curso_Todos"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
    Public Shared Function buscar_info_notas_matricula(id_notas As String, id_matricula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetNotasMatricula @id_notas, @id_matricula"
        sql_command.Parameters.Add("@id_notas", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_notas
        sql_command.Parameters(1).Value = id_matricula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function
    Public Shared Function buscar_info_notas(id_notas As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetNotas @id_notas"
        sql_command.Parameters.Add("@id_notas", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_notas

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_notas_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetNotas"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function agregar_info_notas(id_nota As String, id_matricula As String, primera_nota As String, segunda_nota As String, tercera_nota As String, nota_final As String, status As String) As Integer
        Dim i As Integer
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "INSERT INTO info_notas VALUES (@id_nota, @id_matricula, @primera_nota, @segunda_nota, @tercera_nota, @nota_final, @status)"

        sql_command.Parameters.Add("@id_nota", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@primera_nota", SqlDbType.Int)
        sql_command.Parameters.Add("@segunda_nota", SqlDbType.Int)
        sql_command.Parameters.Add("@tercera_nota", SqlDbType.Int)
        sql_command.Parameters.Add("@nota_final", SqlDbType.Int)
        sql_command.Parameters.Add("@status", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_nota
        sql_command.Parameters(1).Value = id_matricula
        sql_command.Parameters(2).Value = primera_nota
        sql_command.Parameters(3).Value = segunda_nota
        sql_command.Parameters(4).Value = tercera_nota
        sql_command.Parameters(5).Value = nota_final
        sql_command.Parameters(6).Value = status

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function

    Public Shared Function modificar_info_notas(id_nota As String, id_matricula As String, primera_nota As String, segunda_nota As String, tercera_nota As String, nota_final As String, status As String) As Integer
        Dim i As Integer
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "UPDATE info_notas SET id_matricula = @id_matricula ,primera_nota = @primera_nota, segunda_nota = @segunda_nota, tercera_nota = @tercera_nota, nota_final = @nota_final, status = @status WHERE id_nota = @id_nota"

        sql_command.Parameters.Add("@id_nota", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@id_matricula", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@primera_nota", SqlDbType.Int)
        sql_command.Parameters.Add("@segunda_nota", SqlDbType.Int)
        sql_command.Parameters.Add("@tercera_nota", SqlDbType.Int)
        sql_command.Parameters.Add("@nota_final", SqlDbType.Int)
        sql_command.Parameters.Add("@status", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_nota
        sql_command.Parameters(1).Value = id_matricula
        sql_command.Parameters(2).Value = primera_nota
        sql_command.Parameters(3).Value = segunda_nota
        sql_command.Parameters(4).Value = tercera_nota
        sql_command.Parameters(5).Value = nota_final
        sql_command.Parameters(6).Value = status

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
    Public Shared Function borrar_info_notas(id_nota As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "DELETE FROM info_notas WHERE id_nota = @id_nota"
        sql_command.Parameters.Add("@id_nota", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_nota

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "info_sede"

#Region "Buscar"

    Public Shared Function buscar_id_sede() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT id_sede FROM info_sede"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla


    End Function

    Public Shared Function buscar_info_sede(id_sede As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_sede WHERE id_sede = @id_sede"
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_sede

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

    Public Shared Function buscar_info_sede_todo() As DataTable
        Dim tabla As DataTable
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "SELECT * FROM info_sede"

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function

#End Region

#Region "agregar"
    Public Shared Function agregar_info_sede(id_sede As String, nombre As String, descripcion As String, direccion As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "INSERT INTO info_sede VALUES(@id_sede, @nombre, @descripcion, @direccion)"
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@direccion", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_sede
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = descripcion
        sql_command.Parameters(3).Value = direccion

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "modificar"
    Public Shared Function modificar_info_sede(id_sede As String, nombre As String, descripcion As String, direccion As String) As Integer
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "UPDATE info_sede SET nombre = @nombre, descripcion =@descripcion, direccion = @direccion"
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@nombre", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@descripcion", SqlDbType.NVarChar)
        sql_command.Parameters.Add("@direccion", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_sede
        sql_command.Parameters(1).Value = nombre
        sql_command.Parameters(2).Value = descripcion
        sql_command.Parameters(3).Value = direccion

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_sede(id_sede As String) As String
        Dim i As Integer
        Dim sql_command As New SqlCommand

        sql_command = metodos_datos.CrearComando()
        sql_command.CommandText = "DELETE FROM info_sede WHERE id_sede = @id_sede"
        sql_command.Parameters.Add("@id_sede", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = id_sede

        i = metodos_datos.EjecutarComando(sql_command)
        Return i
    End Function

#End Region

#End Region

    Public Shared Function buscar_aprobados(txt_id_cedula As String) As DataTable
        Dim tabla As DataTable
        Dim sql_command As SqlCommand

        sql_command = metodos_datos.CrearComando
        sql_command.CommandText = "EXEC GetAprobados @cedula"
        sql_command.Parameters.Add("@cedula", SqlDbType.NVarChar)

        sql_command.Parameters(0).Value = txt_id_cedula

        tabla = metodos_datos.EjecutarBusqueda(sql_command)
        Return tabla
    End Function


End Class
