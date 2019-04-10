Imports capa_logica
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id_cedula.DataSource = acceso_logica.buscar_id_cedula
        txt_id_cedula.DisplayMember = "id_cedula"

        grid_aprobados.DataSource = acceso_logica.buscar_aprobados("")
        config_grid_aprobados()

        grid_info_estudiantes.DataSource = acceso_logica.buscar_info_estudiante_todo()

        grid_info_estudiantes.Columns(0).HeaderCell.Value = "Nombre"
        grid_info_estudiantes.Columns(1).HeaderCell.Value = "Apellido"
        grid_info_estudiantes.Columns(2).HeaderCell.Value = "Direccion"
        grid_info_estudiantes.Columns(3).HeaderCell.Value = "Telefono"
        grid_info_estudiantes.Columns(4).HeaderCell.Value = "Correo"
        grid_info_estudiantes.Columns(5).HeaderCell.Value = "Carrera"

        grid_info_carrera.DataSource = acceso_logica.buscar_info_carrera_todo()
        grid_info_carrera.Columns(0).HeaderCell.Value = "Nombre"
        grid_info_carrera.Columns(1).HeaderCell.Value = "Descripcion"

        grid_cursos.DataSource = acceso_logica.buscar_info_curso_todo()

        grid_cursos.Columns(0).HeaderCell.Value = "Carrera"
        grid_cursos.Columns(1).HeaderCell.Value = "Dia"
        grid_cursos.Columns(2).HeaderCell.Value = "Hora"
        grid_cursos.Columns(3).HeaderCell.Value = "Nombre Curso"
        grid_cursos.Columns(4).HeaderCell.Value = "Descripcion"
        grid_cursos.Columns(5).HeaderCell.Value = "Nombre Profesor"
        grid_cursos.Columns(6).HeaderCell.Value = "Apellido Profesor"
        grid_cursos.Columns(7).HeaderCell.Value = "Requisito del curso"
        grid_cursos.Columns(8).HeaderCell.Value = "Sede"
        grid_cursos.Columns(9).HeaderCell.Value = "Costo"
        grid_cursos.Columns(10).HeaderCell.Value = "Creditos"



    End Sub

    Private Sub grid_info_estudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_info_estudiantes.CellClick

    End Sub

    Private Sub tile_horarios_Click(sender As Object, e As EventArgs) Handles tile_horarios.Click
        Dim horarios As New mantenimiento_horarios
        horarios.ShowDialog()
    End Sub

    Private Sub tile_estudiantes_Click(sender As Object, e As EventArgs) Handles tile_estudiantes.Click
        Dim estudiantes As New mantenimiento_estudiantes
        estudiantes.ShowDialog()
    End Sub

    Private Sub tile_carreras_Click(sender As Object, e As EventArgs) Handles tile_carreras.Click
        Dim carreras As New mantenimiento_carreras
        carreras.ShowDialog()
    End Sub

    Private Sub tile_profesores_Click(sender As Object, e As EventArgs) Handles tile_profesores.Click
        Dim profesores As New mantenimiento_profesores
        profesores.ShowDialog()
    End Sub

    Private Sub tile_cursos_Click(sender As Object, e As EventArgs) Handles tile_cursos.Click
        Dim cursos As New mantenimiento_cursos
        cursos.ShowDialog()
    End Sub

    Private Sub tile_notas_Click(sender As Object, e As EventArgs) Handles tile_notas.Click
        Dim notas As New mantenimiento_notas
        notas.ShowDialog()
    End Sub

    Private Sub tile_matricula_Click(sender As Object, e As EventArgs) Handles tile_matricula.Click
        Dim matricula As New mantenimiento_matricula
        matricula.ShowDialog()
    End Sub

    Private Sub tile_sede_Click(sender As Object, e As EventArgs) Handles tile_sede.Click
        Dim sede As New mantenimiento_sedes
        sede.ShowDialog()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        grid_aprobados.DataSource = acceso_logica.buscar_aprobados(txt_id_cedula.Text)
        config_grid_aprobados()
    End Sub
    Private Sub config_grid_aprobados()
        grid_aprobados.Columns(0).HeaderCell.Value = "Nombre"
        grid_aprobados.Columns(1).HeaderCell.Value = "Apellido"
        grid_aprobados.Columns(2).HeaderCell.Value = "Nombre del Curso"
        grid_aprobados.Columns(3).HeaderCell.Value = "Año"
        grid_aprobados.Columns(4).HeaderCell.Value = "Cuatrimestre"
        grid_aprobados.Columns(5).HeaderCell.Value = "Nota Final"
    End Sub
End Class
