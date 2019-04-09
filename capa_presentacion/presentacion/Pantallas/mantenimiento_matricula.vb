Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_matricula
    Private Sub cargar_dataset()
        grid_matricula.DataSource = acceso_logica.buscar_info_matricula_todo
        grid_matricula.Columns(0).HeaderCell.Value = "ID de Matricula"
        grid_matricula.Columns(1).HeaderCell.Value = "Nombre del Estudiante"
        grid_matricula.Columns(2).HeaderCell.Value = "Apellido del Estudiante"
        grid_matricula.Columns(3).HeaderCell.Value = "Curso"
        grid_matricula.Columns(4).HeaderCell.Value = "Año"
        grid_matricula.Columns(5).HeaderCell.Value = "Cuatrimestre"

        txt_id_cedula.DataSource = acceso_logica.buscar_id_cedula
        txt_id_cedula.DisplayMember = "id_cedula"

        txt_id_curso.DataSource = acceso_logica.buscar_id_curso
        txt_id_curso.DisplayMember = "id_curso"
    End Sub

    Private Sub refresh_all()
        cargar_dataset()
    End Sub

    Private Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_id_matricula.Text = ""
        txt_año.Text = ""
        txt_cuatrimestre.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub

    Private Sub mantenimiento_matricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_dataset()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_id_cedula.SelectedIndexChanged

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_matricula.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_matricula_estudiante_plano(txt_id_matricula.Text, txt_id_cedula.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_id_curso.SelectedIndex = txt_id_curso.FindStringExact(tabla.Rows(0)(2))
                txt_año.Text = tabla.Rows(0)(3).ToString
                txt_cuatrimestre.Text = tabla.Rows(0)(4).ToString

                habilitar()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Matricula", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_matricula.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_matricula(txt_id_matricula.Text, txt_id_cedula.Text, txt_id_curso.Text, txt_año.Text, txt_cuatrimestre.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Matricula", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_matricula.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_matricula(txt_id_matricula.Text, txt_id_cedula.Text, txt_id_curso.Text, txt_año.Text, txt_cuatrimestre.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Matricula", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_matricula.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_matricula(txt_id_matricula.Text, txt_id_cedula.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Matricula", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class