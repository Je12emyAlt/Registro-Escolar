Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_horarios

    Private Sub cargar_dataset()
        grid_horarios.DataSource = acceso_logica.buscar_info_horario_todo
        grid_horarios.Columns(0).HeaderCell.Value = "ID de Horario"
        grid_horarios.Columns(1).HeaderCell.Value = "Nombre de Carrera"
        grid_horarios.Columns(2).HeaderCell.Value = "Dia"
        grid_horarios.Columns(3).HeaderCell.Value = "Hora"
        grid_horarios.Columns(4).HeaderCell.Value = "Sede"

        txt_id_carrera.DataSource = acceso_logica.buscar_id_carrera()
        txt_id_carrera.DisplayMember = "id_carrera"

        txt_id_sede.DataSource = acceso_logica.buscar_id_sede()
        txt_id_sede.DisplayMember = "id_sede"

    End Sub

    Private Sub limpiar()
        txt_id_horario.Text = ""
        txt_dia.Text = ""
        txt_hora.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub

    Private Sub Habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub
    Private Sub refresh_all()
        cargar_dataset()
    End Sub
    Private Sub mantenimiento_horarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_dataset()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_horario.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_horario(txt_id_horario.Text, txt_id_carrera.Text, txt_dia.Text, txt_hora.Text, txt_id_sede.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Horario", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_horario.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_horario_plano(txt_id_horario.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_id_carrera.SelectedIndex = txt_id_carrera.FindStringExact(tabla.Rows(0)(1).ToString)
                txt_dia.SelectedIndex = txt_dia.FindStringExact(tabla.Rows(0)(2).ToString)
                txt_hora.Text = tabla.Rows(0)(3).ToString
                txt_id_sede.SelectedIndex = txt_id_sede.FindStringExact(tabla.Rows(0)(4).ToString)

                Habilitar()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Horario", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_horario.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_horario(txt_id_horario.Text, txt_id_carrera.Text, txt_dia.Text, txt_hora.Text, txt_id_sede.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Horario", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_horario.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_horario(txt_id_horario.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Horario", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class