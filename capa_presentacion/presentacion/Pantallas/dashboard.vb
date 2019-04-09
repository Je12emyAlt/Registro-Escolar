Imports capa_logica
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        grid_cursos.Columns(7).HeaderCell.Value = "Nombre del Curso"
        grid_cursos.Columns(8).HeaderCell.Value = "Requisito del curso"
        grid_cursos.Columns(9).HeaderCell.Value = "Sede"
        grid_cursos.Columns(10).HeaderCell.Value = "Costo"
        grid_cursos.Columns(11).HeaderCell.Value = "Creditos"



    End Sub

    Private Sub grid_info_estudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_info_estudiantes.CellClick

    End Sub

    Private Sub tile_horarios_Click(sender As Object, e As EventArgs) Handles tile_horarios.Click

    End Sub

    Private Sub tile_estudiantes_Click(sender As Object, e As EventArgs) Handles tile_estudiantes.Click
        Dim estudiantes As New mantenimiento_estudiantes
        estudiantes.ShowDialog()
    End Sub

    Private Sub tile_carreras_Click(sender As Object, e As EventArgs) Handles tile_carreras.Click

    End Sub

    Private Sub tile_profesores_Click(sender As Object, e As EventArgs) Handles tile_profesores.Click

    End Sub

    Private Sub tile_cursos_Click(sender As Object, e As EventArgs) Handles tile_cursos.Click

    End Sub

    Private Sub tile_notas_Click(sender As Object, e As EventArgs) Handles tile_notas.Click

    End Sub

    Private Sub tile_matricula_Click(sender As Object, e As EventArgs) Handles tile_matricula.Click

    End Sub

    Private Sub tile_sede_Click(sender As Object, e As EventArgs) Handles tile_sede.Click

    End Sub
End Class
