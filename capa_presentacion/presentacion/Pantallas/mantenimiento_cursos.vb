Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_cursos
    Private Sub limpiar()
        txt_id_curso.Text = ""
        txt_nombre_curso.Text = ""
        txt_descripcion_curso.Text = ""
        txt_requisito.Text = ""
        txt_costo.Text = ""
        txt_creditos.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub

    Private Sub refresh_all()
        cargar_datasource()
    End Sub

    Private Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_cursos.CellContentClick

    End Sub

    Private Sub mantenimiento_cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datasource()
    End Sub

    Private Sub cargar_datasource()
        grid_cursos.DataSource = acceso_logica.buscar_info_curso_todo
        grid_cursos.Columns(0).HeaderCell.Value = "ID del curso"
        grid_cursos.Columns(1).HeaderCell.Value = "Nombre Carrera"
        grid_cursos.Columns(2).HeaderCell.Value = "Dia"
        grid_cursos.Columns(3).HeaderCell.Value = "Hora"
        grid_cursos.Columns(4).HeaderCell.Value = "Nombre de Curso"
        grid_cursos.Columns(5).HeaderCell.Value = "Descripcion de Curso"
        grid_cursos.Columns(6).HeaderCell.Value = "Nombre de Profesor"
        grid_cursos.Columns(7).HeaderCell.Value = "Apellido de Profesor"
        grid_cursos.Columns(8).HeaderCell.Value = "Requisito del Curso"
        grid_cursos.Columns(9).HeaderCell.Value = "Nombre de sede"
        grid_cursos.Columns(10).HeaderCell.Value = "Costo"
        grid_cursos.Columns(11).HeaderCell.Value = "Creditos"

        txt_id_carrera.DataSource = acceso_logica.buscar_id_carrera()
        txt_id_carrera.DisplayMember = "id_carrera"

        txt_id_horario.DataSource = acceso_logica.buscar_id_horario()
        txt_id_horario.DisplayMember = "id_horario"

        txt_id_profesor.DataSource = acceso_logica.buscar_id_profesor()
        txt_id_profesor.DisplayMember = "id_profesor"

        txt_id_sede.DataSource = acceso_logica.buscar_id_sede()
        txt_id_sede.DisplayMember = "id_sede"

    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles label_id_carrera.Click

    End Sub

    Private Sub tab_mantenimiento_Click(sender As Object, e As EventArgs) Handles tab_mantenimiento.Click

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_id_carrera.SelectedIndexChanged

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txt_nombre_curso.Click

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles label_profesor.Click

    End Sub

    Private Sub label_titulo_Click(sender As Object, e As EventArgs) Handles label_titulo.Click

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles label_id_curso.Click

    End Sub

    Private Sub MetroTextBox7_Click(sender As Object, e As EventArgs) Handles txt_id_curso.Click

    End Sub

    Private Sub MetroTextBox4_Click(sender As Object, e As EventArgs) Handles txt_creditos.Click

    End Sub

    Private Sub MetroTextBox5_Click(sender As Object, e As EventArgs) Handles txt_costo.Click

    End Sub

    Private Sub MetroLabel11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTextBox2_Click(sender As Object, e As EventArgs) Handles txt_descripcion_curso.Click

    End Sub

    Private Sub label_descripcion_Click(sender As Object, e As EventArgs) Handles label_descripcion.Click

    End Sub

    Private Sub MetroComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_id_profesor.SelectedIndexChanged

    End Sub

    Private Sub label_nombre_Click(sender As Object, e As EventArgs) Handles label_nombre.Click

    End Sub

    Private Sub txt_requisito_Click(sender As Object, e As EventArgs) Handles txt_requisito.Click

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_curso.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_curso(txt_id_curso.Text, txt_id_carrera.Text, txt_id_horario.Text, txt_nombre_curso.Text, txt_id_profesor.Text, txt_descripcion_curso.Text, txt_requisito.Text, txt_id_sede.Text, txt_costo.Text, txt_creditos.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de curso", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_curso.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_curso(txt_id_curso.Text, txt_id_carrera.Text, txt_id_horario.Text, txt_nombre_curso.Text, txt_id_profesor.Text, txt_descripcion_curso.Text, txt_requisito.Text, txt_id_sede.Text, txt_costo.Text, txt_creditos.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de curso", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_curso.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_curso_plano(txt_id_curso.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_id_carrera.SelectedIndex = txt_id_carrera.FindStringExact(tabla.Rows(0)(1).ToString)
                txt_id_horario.SelectedIndex = txt_id_horario.FindStringExact(tabla.Rows(0)(2).ToString)
                txt_nombre_curso.Text = tabla.Rows(0)(3).ToString
                txt_id_profesor.SelectedIndex = txt_id_profesor.FindStringExact(tabla.Rows(0)(4).ToString)
                txt_descripcion_curso.Text = tabla.Rows(0)(5).ToString
                txt_requisito.Text = tabla.Rows(0)(6).ToString
                txt_id_sede.SelectedIndex = txt_id_sede.FindStringExact(tabla.Rows(0)(7))
                txt_costo.Text = tabla.Rows(0)(8).ToString
                txt_creditos.Text = tabla.Rows(0)(9).ToString

                habilitar()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Curso", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_curso.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_curso(txt_id_curso.Text)

            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                refresh_all()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Curso", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class