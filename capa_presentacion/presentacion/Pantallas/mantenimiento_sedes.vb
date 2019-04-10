Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_sedes
    Private Sub cargar_datasource()
        grid_sede.DataSource = acceso_logica.buscar_info_sede_todo
        grid_sede.Columns(0).HeaderCell.Value = "ID de Sede"
        grid_sede.Columns(1).HeaderCell.Value = "Nombre de Sede"
        grid_sede.Columns(2).HeaderCell.Value = "Descripcion de Sede"
        grid_sede.Columns(3).HeaderCell.Value = "Direccion"
    End Sub

    Private Sub refresh_all()
        cargar_datasource()
    End Sub

    Private Sub limpiar()
        txt_id_sede.Text = ""
        txt_nombre.Text = ""
        txt_descripcion.Text = ""
        txt_direccion.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub

    Private Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub


    Private Sub mantenimiento_sedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datasource()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_sede.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_sede(txt_id_sede.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_nombre.Text = tabla.Rows(0)(1).ToString
                txt_descripcion.Text = tabla.Rows(0)(2).ToString
                txt_direccion.Text = tabla.Rows(0)(3).ToString
                habilitar()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Profesor", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_sede.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_sede(txt_id_sede.Text, txt_nombre.Text, txt_descripcion.Text, txt_direccion.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Sede", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_sede.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_sede(txt_id_sede.Text, txt_nombre.Text, txt_descripcion.Text, txt_direccion.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Sede", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_sede.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_sede(txt_id_sede.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Sede", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub
End Class