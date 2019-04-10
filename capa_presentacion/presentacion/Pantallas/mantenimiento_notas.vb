Imports capa_logica
Imports MetroFramework
Public Class mantenimiento_notas
    Private Sub habilitar()
        btn_modificar.Enabled = True
        btn_borrar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_id_nota.Text = ""
        txt_id_matricula.Text = ""
        txt_primera_nota.Text = ""
        txt_segunda_nota.Text = ""
        txt_tercera_nota.Text = ""
        txt_nota_final.Text = ""
        txt_status.Text = ""

        btn_modificar.Enabled = False
        btn_borrar.Enabled = False
    End Sub

    Private Sub refresh_all()
        cargar_dataset()
    End Sub

    Private Sub cargar_dataset()
        grid_notas.DataSource = acceso_logica.buscar_info_notas_estudiante()
        grid_notas.Columns(0).HeaderCell.Value = "ID de Nota"
        grid_notas.Columns(1).HeaderCell.Value = "Nombre del Estudiante"
        grid_notas.Columns(2).HeaderCell.Value = "Apellido del Estudiante"
        grid_notas.Columns(3).HeaderCell.Value = "Nombre del Curso"
        grid_notas.Columns(4).HeaderCell.Value = "Primera nota"
        grid_notas.Columns(5).HeaderCell.Value = "Segunda nota"
        grid_notas.Columns(6).HeaderCell.Value = "Tercera nota"
        grid_notas.Columns(7).HeaderCell.Value = "Nota Final"
        grid_notas.Columns(8).HeaderCell.Value = "Status"

        txt_id_matricula.DataSource = acceso_logica.buscar_id_matricula
        txt_id_matricula.DisplayMember = "id_matricula"

    End Sub



    Private Sub mantenimiento_notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_dataset()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_id_nota.Text <> "" Then
            Dim tabla As DataTable
            tabla = acceso_logica.buscar_info_notas_plano(txt_id_nota.Text)

            If tabla.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "Se ha encontrado el registro con exito!", "Busqueda de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_id_matricula.SelectedIndex = txt_id_matricula.FindStringExact(tabla.Rows(0)(1).ToString)
                txt_primera_nota.Text = tabla.Rows(0)(2).ToString
                txt_segunda_nota.Text = tabla.Rows(0)(3).ToString
                txt_tercera_nota.Text = tabla.Rows(0)(4).ToString
                habilitar()
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato erroneo o no existente", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Nota", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_id_nota.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.agregar_info_notas(txt_id_nota.Text, txt_id_matricula.Text, txt_primera_nota.Text, txt_segunda_nota.Text, txt_tercera_nota.Text, txt_nota_final.Text, txt_status.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha agregado el registro con exito", "Agregar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Nota", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub txt_tercera_nota_TextChanged(sender As Object, e As EventArgs) Handles txt_tercera_nota.TextChanged, txt_segunda_nota.TextChanged, txt_primera_nota.TextChanged
        If txt_primera_nota.Text <> "" And txt_segunda_nota.Text <> "" And txt_tercera_nota.Text <> "" Then
            calcular_nota()
        End If
    End Sub
    Private Sub calcular_nota()
        Dim promedio As Double = 0
        Dim primera_nota As Integer = 0
        Dim segunda_nota As Integer = 0
        Dim tercera_nota As Integer = 0

        promedio = (Convert.ToInt32(txt_primera_nota.Text) + Convert.ToInt32(txt_segunda_nota.Text) + Convert.ToInt32(txt_tercera_nota.Text)) / 3

        txt_nota_final.Text = (Convert.ToInt32(promedio)).ToString
        If promedio >= 70 Then
            txt_status.Text = "Aprobado"
        Else
            txt_status.Text = "Reprobado"
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_id_nota.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.modificar_info_notas(txt_id_nota.Text, txt_id_matricula.Text, txt_primera_nota.Text, txt_segunda_nota.Text, txt_tercera_nota.Text, txt_nota_final.Text, txt_status.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha modificado el registro con exito", "Modificar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Nota", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If txt_id_nota.Text <> "" Then
            Dim i As Integer
            i = acceso_logica.borrar_info_notas(txt_id_nota.Text)
            If i > 0 Then
                MetroMessageBox.Show(Me, "Se ha borrado el registro con exito", "Borrar a un registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Error, puede que haya ingresado un dato con un formato erroneo", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Aviso, asegurese de rellenar el campo de ID de Nota", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        limpiar()
        refresh_all()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class