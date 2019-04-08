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

    End Sub

    Private Sub grid_info_estudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_info_estudiantes.CellClick

    End Sub
End Class
