Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_carreras
    Private Sub mantenimiento_carreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datasoruce()
    End Sub

    Private Sub cargar_datasoruce()
        grid_info_carrera.DataSource = acceso_logica.buscar_info_carrera_todo()
        grid_info_carrera.Columns(0).HeaderCell.Value = "ID de Carrera"
        grid_info_carrera.Columns(1).HeaderCell.Value = "Nombre"
        grid_info_carrera.Columns(2).HeaderCell.Value = "Descripcion"
    End Sub

    Private Sub label_nombre_Click(sender As Object, e As EventArgs) Handles label_nombre.Click

    End Sub

    Private Sub label_titulo_Click(sender As Object, e As EventArgs) Handles label_titulo.Click

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txt_id_carrera.Click

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_carrera.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_carrera(txt_id_carrera.Text, txt_nombre.Text, txt_descripcion.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Carrera", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_carrera.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_carrera(txt_id_carrera.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                refresh_all()
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Cedula del Estudiante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            limpiar()
            refresh_all()
        End If

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_carrera.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_carrera(txt_id_carrera.Text)
            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_nombre.Text = tabla.Rows(0)(1).ToString
                txt_descripcion.Text = tabla.Rows(0)(2).ToString
                habilitar()
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Carrera", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_id_carrera.Text = ""
        txt_nombre.Text = ""
        txt_descripcion.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub
    Private Sub refresh_all()
        cargar_datasoruce()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_carrera.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_carrera(txt_id_carrera.Text, txt_nombre.Text, txt_descripcion.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de carrera", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub
End Class