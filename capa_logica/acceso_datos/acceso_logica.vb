Imports capa_datos
Imports System.Data.SqlClient

Public Class acceso_logica

#Region "info estudiante"

#Region "buscar"
    Public Shared Function buscar_id_cedula() As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_id_cedula()
        Return tabla
    End Function

    Public Shared Function buscar_info_estudiante_plano(id_cedula As String) As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_info_estudiante_plano(id_cedula)
        Return tabla
    End Function

    Public Shared Function buscar_info_estudiante(id_cedula As String) As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_info_estudiante(id_cedula)
        Return tabla
    End Function

    Public Shared Function buscar_info_estudiante_todo() As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_info_estudiante_todo()
        Return tabla
    End Function
#End Region

#Region "agregar"
    Public Shared Function agregar_info_estudiante(id_cedula As String, nombre As String, apellido As String, direccion As String,
                                                   telefono As String, celular As String, correo As String, id_carrera As String) As Integer
        Dim i As Integer
        i = acceso_datos.agregar_info_estudiante(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carrera)
        Return i
    End Function
#End Region
#Region "modificar"
    Public Shared Function modificar_info_estudiante(id_cedula As String, nombre As String, apellido As String, direccion As String,
                                               telefono As String, celular As String, correo As String, id_carrera As String) As Integer
        Dim i As Integer
        i = acceso_datos.modificar_info_estudiante(id_cedula, nombre, apellido, direccion, telefono, celular, correo, id_carrera)
        Return i
    End Function
#End Region

#Region "eliminar"
    Public Shared Function borrar_info_estudiante(id_cedula As String) As Integer
        Dim i As Integer
        i = acceso_datos.borrar_info_estudiante(id_cedula)
        Return i
    End Function
#End Region

#End Region

#Region "info_carrera"

#Region "buscar"

    Public Shared Function buscar_id_carrera() As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_id_carrera()
        Return tabla
    End Function

    Public Shared Function buscar_info_carrera(id_carrera As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_carrera(id_carrera)

        Return tabla
    End Function

    Public Shared Function buscar_info_carrera_todo() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_carrera_todo()

        Return tabla
    End Function
#End Region

#Region "Agregar"
    Public Shared Function agregar_info_carrera(id_carrera As String, nombre As String, descripcion As String) As Integer
        Dim i As Integer

        i = acceso_datos.agregar_info_carrera(id_carrera, nombre, descripcion)

        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_carrera(id_carrera As String, nombre As String, descripcion As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_carrera(id_carrera, nombre, descripcion)

        Return i
    End Function
#End Region

#Region "Borrar"
    Public Shared Function borrar_info_carrera(id_carrera As String) As Integer
        Dim i As Integer

        i = acceso_datos.borrar_info_carrera(id_carrera)

        Return i
    End Function
#End Region

#End Region

#Region "Info_cursos"

#Region "buscar"
    Public Shared Function buscar_id_curso() As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_id_curso()
        Return tabla
    End Function



    Public Shared Function buscar_info_curso_plano(id_curso As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_curso_plano(id_curso)

        Return tabla
    End Function

    Public Shared Function buscar_info_curso_carrera(id_curso As String, id_carrera As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_curso_carrera(id_carrera, id_carrera)

        Return tabla
    End Function

    Public Shared Function buscar_info_curso(id_curso As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_curso(id_curso)

        Return tabla
    End Function

    Public Shared Function buscar_info_curso_todo() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_curso_todo()

        Return tabla
    End Function
#End Region

#Region "Agregar"
    Public Shared Function agregar_info_curso(id_curso As String, id_carrera As String, id_horario As String, nombre As String, id_profesor As String, descripcion As String,
                                              requisito As String, id_sede As String, costo As String, creditos As String) As Integer
        Dim i As Integer

        i = acceso_datos.agregar_info_curso(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_curso(id_curso As String, id_carrera As String, id_horario As String, nombre As String, id_profesor As String, descripcion As String,
                                              requisito As String, id_sede As String, costo As String, creditos As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_curso(id_curso, id_carrera, id_horario, nombre, id_profesor, descripcion, requisito, id_sede, costo, creditos)
        Return i
    End Function
#End Region

#Region "Borrar"
    Public Shared Function borrar_info_curso(id_curso As String) As Integer
        Dim i As Integer

        i = acceso_datos.borrar_info_curso(id_curso)
        Return i
    End Function
#End Region

#End Region

#Region "Info_matricula"

#Region "buscar"

    Public Shared Function buscar_info_matricula_estudiante_plano(id_matricula As String, id_cedula As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_matricula_estudiante_plano(id_matricula, id_cedula)
        Return tabla
    End Function

    '*************************************
    Public Shared Function buscar_info_matricula_estudiante(id_matricula As String, id_cedula As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_matricula_estudiante(id_matricula, id_cedula)
        Return tabla
    End Function


    Public Shared Function buscar_info_matricula(id_matricula As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_matricula(id_matricula)
        Return tabla
    End Function

    Public Shared Function buscar_info_matricula_todo() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_matricula_todo()
        Return tabla
    End Function
#End Region

#Region "Agregar"
    Public Shared Function agregar_info_matricula(id_matricula As String, id_cedula As String, id_curso As String, año As String, cuatrimestre As String)
        Dim i As Integer

        i = acceso_datos.agregar_info_matricula(id_matricula, id_cedula, id_curso, año, cuatrimestre)
        Return i
    End Function
#End Region

#Region "Modificar"
    Public Shared Function modificar_info_matricula(id_matricula As String, id_cedula As String, id_curso As String, año As String, cuatrimestre As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_matricula(id_matricula, id_cedula, id_curso, año, cuatrimestre)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_matricula(id_matricula As String, id_cedula As String) As Integer
        Dim i As Integer

        i = acceso_datos.borar_info_matricula(id_matricula, id_cedula)
        Return i
    End Function
#End Region
#End Region

#Region "info_horario"

#Region "Buscar"

    Public Shared Function buscar_id_horario() As DataTable
        Dim tabla As DataTable
        tabla = acceso_datos.buscar_id_horario
        Return tabla
    End Function

    Public Shared Function buscar_info_horario_plano(id_horario As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_horario_plano(id_horario)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario_carrera(id_horario As String, id_carrera As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_horario_carrera(id_horario, id_carrera)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario(id_horario As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_horario(id_horario)
        Return tabla
    End Function

    Public Shared Function buscar_info_horario_todo() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_horario_todo()
        Return tabla
    End Function
#End Region

#Region "agregar"

    Public Shared Function agregar_info_horario(id_horario As String, id_carrera As String, dia As String, hora As String, id_sede As String) As Integer
        Dim i As Integer

        i = acceso_datos.agregar_info_horario(id_horario, id_carrera, dia, hora, id_sede)
        Return i
    End Function
#End Region

#Region "modificar"
    Public Shared Function modificar_info_horario(id_horario As String, id_carrera As String, dia As String, hora As String, id_sede As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_horario(id_horario, id_carrera, dia, hora, id_sede)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_horario(id_horario As String) As Integer
        Dim i As Integer

        i = acceso_datos.borrar_info_horario(id_horario)
        Return i
    End Function
#End Region

#End Region

#Region "info_profesores"

#Region "Buscar"

    Public Shared Function buscar_id_profesor() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_id_profesor()
        Return tabla
    End Function

    Public Shared Function buscar_info_profesor(id_profesor As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_profesor(id_profesor)
        Return tabla
    End Function

    Public Shared Function buscar_info_profesor_todo() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_profesor_todo()
        Return tabla
    End Function

#End Region

#Region "agregar"
    Public Shared Function agregar_info_profesor(id_profesor As String, nombre As String, apellido As String, correo As String, telefono As String) As Integer
        Dim i As Integer

        i = acceso_datos.agregar_info_profesor(id_profesor, nombre, apellido, correo, telefono)
        Return i
    End Function
#End Region

#Region "modificar"
    Public Shared Function modificar_info_profesor(id_profesor As String, nombre As String, apellido As String, correo As String, telefono As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_profesor(id_profesor, nombre, apellido, correo, telefono)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_profesor(id_profesor As String) As String
        Dim i As Integer

        i = acceso_datos.borrar_info_profesor(id_profesor)
        Return i
    End Function

#End Region

#End Region

#Region "info_notas"
#Region "Buscar"
    Public Shared Function buscar_info_notas_matricula_plano(id_notas As String, id_matricula As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_notas_matricula_plano(id_notas, id_matricula)
        Return tabla
    End Function

    Public Shared Function buscar_info_notas_matricula(id_notas As String, id_matricula As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_notas_matricula(id_notas, id_matricula)
        Return tabla
    End Function
    Public Shared Function buscar_info_notas(id_notas As String) As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_notas(id_notas)
        Return tabla
    End Function

#End Region

    Public Shared Function agregar_info_notas(id_nota As String, id_matricula As String, primera_nota As String, segunda_nota As String, tercera_nota As String, nota_final As String, status As String) As Integer
        Dim i As Integer

        i = acceso_datos.agregar_info_notas(id_nota, id_matricula, primera_nota, segunda_nota, tercera_nota, nota_final, status)
        Return i
    End Function

    Public Shared Function modificar_info_notas(id_nota As String, id_matricula As String, primera_nota As String, segunda_nota As String, tercera_nota As String, nota_final As String, status As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_notas(id_nota, id_matricula, primera_nota, segunda_nota, tercera_nota, nota_final, status)
        Return i
    End Function
    Public Shared Function borrar_info_notas(id_nota As String, id_matricula As String) As Integer
        Dim i As Integer

        i = acceso_datos.borrar_info_notas(id_nota, id_matricula)
        Return i
    End Function
#End Region

#Region "info_sede"

#Region "Buscar"

    Public Shared Function buscar_id_sede() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_id_sede()
        Return tabla
    End Function

    Public Shared Function buscar_info_sede(id_sede As String) As DataTable
        Dim tabla As DataTable

        tabla = buscar_info_sede(id_sede)
        Return tabla
    End Function

    Public Shared Function buscar_info_sede_todo() As DataTable
        Dim tabla As DataTable

        tabla = acceso_datos.buscar_info_sede_todo()
        Return tabla
    End Function

#End Region

#Region "agregar"
    Public Shared Function agregar_info_sede(id_sede As String, nombre As String, descripcion As String, direccion As String) As Integer
        Dim i As Integer

        i = acceso_datos.agregar_info_sede(id_sede, nombre, descripcion, direccion)
        Return i
    End Function
#End Region

#Region "modificar"
    Public Shared Function modificar_info_sede(id_sede As String, nombre As String, descripcion As String, direccion As String) As Integer
        Dim i As Integer

        i = acceso_datos.modificar_info_sede(id_sede, nombre, descripcion, direccion)
        Return i
    End Function
#End Region

#Region "borrar"
    Public Shared Function borrar_info_sede(id_sede As String) As String
        Dim i As Integer

        i = acceso_datos.borrar_info_sede(id_sede)
        Return i
    End Function

#End Region

#End Region

End Class
