Imports MetroFramework
Imports capa_logica
Public Class mantenimiento_estudiantes
    Private Sub mantenimiento_estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datasource()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_cedula.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_estudiante_plano(txt_cedula.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_nombre.Text = tabla.Rows(0)(1).ToString
                txt_apellido.Text = tabla.Rows(0)(2).ToString
                txt_direccion.Text = tabla.Rows(0)(3).ToString
                txt_telefono.Text = tabla.Rows(0)(4).ToString
                txt_celular.Text = tabla.Rows(0)(5).ToString
                txt_correo.Text = tabla.Rows(0)(6).ToString
                txt_id_carrera.SelectedIndex = txt_id_carrera.FindStringExact(tabla.Rows(0)(7).ToString)

                habilitar()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Cedula del Estudiante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_cedula.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_estudiante(txt_cedula.Text, txt_nombre.Text, txt_apellido.Text, txt_direccion.Text, txt_telefono.Text, txt_celular.Text, txt_correo.Text, txt_id_carrera.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Cedula del Estudiante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_bd()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_cedula.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_estudiante(txt_cedula.Text, txt_nombre.Text, txt_apellido.Text, txt_direccion.Text, txt_telefono.Text, txt_celular.Text, txt_correo.Text, txt_id_carrera.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Cedula del Estudiante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_bd()
    End Sub

    Private Sub limpiar()
        txt_cedula.Text = ""
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_celular.Text = ""
        txt_correo.Text = ""
        txt_id_carrera.SelectedIndex = 0

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False

    End Sub

    Private Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_cedula.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_estudiante(txt_cedula.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                refresh_bd()
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Cedula del Estudiante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txt_id_carrera_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub refresh_bd()
        cargar_datasource()
    End Sub

    Private Sub cargar_datasource()
        grid_info_estudiantes.DataSource = acceso_logica.buscar_info_estudiante_todo()

        grid_info_estudiantes.Columns(0).HeaderCell.Value = "ID"
        grid_info_estudiantes.Columns(1).HeaderCell.Value = "Nombre"
        grid_info_estudiantes.Columns(2).HeaderCell.Value = "Apellido"
        grid_info_estudiantes.Columns(3).HeaderCell.Value = "Direccion"
        grid_info_estudiantes.Columns(4).HeaderCell.Value = "Telefono"
        grid_info_estudiantes.Columns(5).HeaderCell.Value = "Celular"
        grid_info_estudiantes.Columns(6).HeaderCell.Value = "Correo"
        grid_info_estudiantes.Columns(7).HeaderCell.Value = "Carrera"


        txt_id_carrera.DataSource = acceso_logica.buscar_id_carrera
        txt_id_carrera.DisplayMember = "id_carrera"
    End Sub

End Class