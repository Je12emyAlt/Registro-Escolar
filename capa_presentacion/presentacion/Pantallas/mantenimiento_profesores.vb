Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_profesores
    Public Sub cargar_datasource()
        grid_profesores.DataSource = acceso_logica.buscar_info_profesor_todo()
        grid_profesores.Columns(0).HeaderCell.Value = "ID de Profesor"
        grid_profesores.Columns(1).HeaderCell.Value = "Nombre"
        grid_profesores.Columns(2).HeaderCell.Value = "Apellido"
        grid_profesores.Columns(3).HeaderCell.Value = "Correo"
        grid_profesores.Columns(4).HeaderCell.Value = "Telefono"
    End Sub

    Public Sub limpiar()
        txt_id_profesor.Text = ""
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_telefono.Text = ""
        txt_correo.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub

    Public Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Public Sub refresh_all()
        cargar_datasource()
    End Sub

    Private Sub mantenimiento_profesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datasource()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_profesor.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_profesor(txt_id_profesor.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_nombre.Text = tabla.Rows(0)(1).ToString
                txt_apellido.Text = tabla.Rows(0)(2).ToString
                txt_correo.Text = tabla.Rows(0)(3).ToString
                txt_telefono.Text = tabla.Rows(0)(4).ToString

                habilitar()

            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Profesor", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_profesor.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_profesor(txt_id_profesor.Text, txt_nombre.Text, txt_apellido.Text, txt_correo.Text, txt_telefono.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Profesor", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_profesor.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_profesor(txt_id_profesor.Text, txt_nombre.Text, txt_apellido.Text, txt_correo.Text, txt_telefono.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Profesor", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_profesor.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_profesor(txt_id_profesor.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Profesor", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class