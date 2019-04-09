<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_cursos
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_control_cursos = New MetroFramework.Controls.MetroTabControl()
        Me.tab_ver = New MetroFramework.Controls.MetroTabPage()
        Me.grid_cursos = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.label_id_curso = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_curso = New MetroFramework.Controls.MetroTextBox()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.label_creditos = New MetroFramework.Controls.MetroLabel()
        Me.txt_costo = New MetroFramework.Controls.MetroTextBox()
        Me.txt_id_sede = New MetroFramework.Controls.MetroComboBox()
        Me.label_costo = New MetroFramework.Controls.MetroLabel()
        Me.label_id_sede = New MetroFramework.Controls.MetroLabel()
        Me.txt_creditos = New MetroFramework.Controls.MetroTextBox()
        Me.label_requisito = New MetroFramework.Controls.MetroLabel()
        Me.txt_requisito = New MetroFramework.Controls.MetroTextBox()
        Me.label_descripcion = New MetroFramework.Controls.MetroLabel()
        Me.txt_descripcion_curso = New MetroFramework.Controls.MetroTextBox()
        Me.label_nombre = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_profesor = New MetroFramework.Controls.MetroComboBox()
        Me.label_profesor = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_horario = New MetroFramework.Controls.MetroComboBox()
        Me.label_id_horario = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_carrera = New MetroFramework.Controls.MetroComboBox()
        Me.txt_nombre_curso = New MetroFramework.Controls.MetroTextBox()
        Me.label_id_carrera = New MetroFramework.Controls.MetroLabel()
        Me.label_titulo = New MetroFramework.Controls.MetroLabel()
        Me.tab_control_cursos.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        CType(Me.grid_cursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_control_cursos
        '
        Me.tab_control_cursos.Controls.Add(Me.tab_ver)
        Me.tab_control_cursos.Controls.Add(Me.tab_mantenimiento)
        Me.tab_control_cursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_control_cursos.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tab_control_cursos.Location = New System.Drawing.Point(20, 60)
        Me.tab_control_cursos.Name = "tab_control_cursos"
        Me.tab_control_cursos.SelectedIndex = 1
        Me.tab_control_cursos.Size = New System.Drawing.Size(615, 362)
        Me.tab_control_cursos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tab_control_cursos.TabIndex = 0
        Me.tab_control_cursos.UseSelectable = True
        '
        'tab_ver
        '
        Me.tab_ver.Controls.Add(Me.grid_cursos)
        Me.tab_ver.HorizontalScrollbarBarColor = True
        Me.tab_ver.HorizontalScrollbarHighlightOnWheel = False
        Me.tab_ver.HorizontalScrollbarSize = 10
        Me.tab_ver.Location = New System.Drawing.Point(4, 44)
        Me.tab_ver.Name = "tab_ver"
        Me.tab_ver.Size = New System.Drawing.Size(607, 314)
        Me.tab_ver.TabIndex = 0
        Me.tab_ver.Text = "Ver"
        Me.tab_ver.VerticalScrollbarBarColor = True
        Me.tab_ver.VerticalScrollbarHighlightOnWheel = False
        Me.tab_ver.VerticalScrollbarSize = 10
        '
        'grid_cursos
        '
        Me.grid_cursos.AllowUserToResizeRows = False
        Me.grid_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_cursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_cursos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_cursos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_cursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_cursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_cursos.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_cursos.EnableHeadersVisualStyles = False
        Me.grid_cursos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_cursos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_cursos.Location = New System.Drawing.Point(4, 15)
        Me.grid_cursos.Name = "grid_cursos"
        Me.grid_cursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cursos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_cursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cursos.Size = New System.Drawing.Size(607, 309)
        Me.grid_cursos.TabIndex = 2
        Me.grid_cursos.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.label_id_curso)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_curso)
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.label_creditos)
        Me.tab_mantenimiento.Controls.Add(Me.txt_costo)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_sede)
        Me.tab_mantenimiento.Controls.Add(Me.label_costo)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_sede)
        Me.tab_mantenimiento.Controls.Add(Me.txt_creditos)
        Me.tab_mantenimiento.Controls.Add(Me.label_requisito)
        Me.tab_mantenimiento.Controls.Add(Me.txt_requisito)
        Me.tab_mantenimiento.Controls.Add(Me.label_descripcion)
        Me.tab_mantenimiento.Controls.Add(Me.txt_descripcion_curso)
        Me.tab_mantenimiento.Controls.Add(Me.label_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_profesor)
        Me.tab_mantenimiento.Controls.Add(Me.label_profesor)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_horario)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_horario)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_carrera)
        Me.tab_mantenimiento.Controls.Add(Me.txt_nombre_curso)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_carrera)
        Me.tab_mantenimiento.Controls.Add(Me.label_titulo)
        Me.tab_mantenimiento.HorizontalScrollbarBarColor = True
        Me.tab_mantenimiento.HorizontalScrollbarHighlightOnWheel = False
        Me.tab_mantenimiento.HorizontalScrollbarSize = 10
        Me.tab_mantenimiento.Location = New System.Drawing.Point(4, 44)
        Me.tab_mantenimiento.Name = "tab_mantenimiento"
        Me.tab_mantenimiento.Size = New System.Drawing.Size(607, 314)
        Me.tab_mantenimiento.TabIndex = 1
        Me.tab_mantenimiento.Text = "Mantenimiento"
        Me.tab_mantenimiento.VerticalScrollbarBarColor = True
        Me.tab_mantenimiento.VerticalScrollbarHighlightOnWheel = False
        Me.tab_mantenimiento.VerticalScrollbarSize = 10
        '
        'label_id_curso
        '
        Me.label_id_curso.AutoSize = True
        Me.label_id_curso.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_curso.Location = New System.Drawing.Point(-6, 71)
        Me.label_id_curso.Name = "label_id_curso"
        Me.label_id_curso.Size = New System.Drawing.Size(101, 25)
        Me.label_id_curso.TabIndex = 30
        Me.label_id_curso.Text = "ID de Curso"
        '
        'txt_id_curso
        '
        '
        '
        '
        Me.txt_id_curso.CustomButton.Image = Nothing
        Me.txt_id_curso.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txt_id_curso.CustomButton.Name = ""
        Me.txt_id_curso.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_curso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_curso.CustomButton.TabIndex = 1
        Me.txt_id_curso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_curso.CustomButton.UseSelectable = True
        Me.txt_id_curso.CustomButton.Visible = False
        Me.txt_id_curso.Lines = New String(-1) {}
        Me.txt_id_curso.Location = New System.Drawing.Point(143, 69)
        Me.txt_id_curso.MaxLength = 32767
        Me.txt_id_curso.Name = "txt_id_curso"
        Me.txt_id_curso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_curso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_curso.SelectedText = ""
        Me.txt_id_curso.SelectionLength = 0
        Me.txt_id_curso.SelectionStart = 0
        Me.txt_id_curso.ShortcutsEnabled = True
        Me.txt_id_curso.Size = New System.Drawing.Size(153, 29)
        Me.txt_id_curso.TabIndex = 29
        Me.txt_id_curso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id_curso.UseSelectable = True
        Me.txt_id_curso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_curso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_salir
        '
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_salir.Location = New System.Drawing.Point(441, 260)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(98, 40)
        Me.btn_salir.TabIndex = 28
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseSelectable = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_borrar.Enabled = False
        Me.btn_borrar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_borrar.Location = New System.Drawing.Point(337, 260)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(98, 40)
        Me.btn_borrar.TabIndex = 27
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseSelectable = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_modificar.Location = New System.Drawing.Point(233, 260)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(98, 40)
        Me.btn_modificar.TabIndex = 26
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseSelectable = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_agregar.Location = New System.Drawing.Point(129, 260)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(98, 40)
        Me.btn_agregar.TabIndex = 25
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseSelectable = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_buscar.Location = New System.Drawing.Point(25, 260)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 24
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'label_creditos
        '
        Me.label_creditos.AutoSize = True
        Me.label_creditos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_creditos.Location = New System.Drawing.Point(297, 207)
        Me.label_creditos.Name = "label_creditos"
        Me.label_creditos.Size = New System.Drawing.Size(74, 25)
        Me.label_creditos.TabIndex = 20
        Me.label_creditos.Text = "Creditos"
        '
        'txt_costo
        '
        '
        '
        '
        Me.txt_costo.CustomButton.Image = Nothing
        Me.txt_costo.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txt_costo.CustomButton.Name = ""
        Me.txt_costo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_costo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_costo.CustomButton.TabIndex = 1
        Me.txt_costo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_costo.CustomButton.UseSelectable = True
        Me.txt_costo.CustomButton.Visible = False
        Me.txt_costo.Lines = New String(-1) {}
        Me.txt_costo.Location = New System.Drawing.Point(451, 172)
        Me.txt_costo.MaxLength = 32767
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_costo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_costo.SelectedText = ""
        Me.txt_costo.SelectionLength = 0
        Me.txt_costo.SelectionStart = 0
        Me.txt_costo.ShortcutsEnabled = True
        Me.txt_costo.Size = New System.Drawing.Size(153, 29)
        Me.txt_costo.TabIndex = 19
        Me.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_costo.UseSelectable = True
        Me.txt_costo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_costo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_id_sede
        '
        Me.txt_id_sede.FormattingEnabled = True
        Me.txt_id_sede.ItemHeight = 23
        Me.txt_id_sede.Location = New System.Drawing.Point(451, 137)
        Me.txt_id_sede.Name = "txt_id_sede"
        Me.txt_id_sede.Size = New System.Drawing.Size(153, 29)
        Me.txt_id_sede.TabIndex = 18
        Me.txt_id_sede.UseSelectable = True
        '
        'label_costo
        '
        Me.label_costo.AutoSize = True
        Me.label_costo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_costo.Location = New System.Drawing.Point(297, 172)
        Me.label_costo.Name = "label_costo"
        Me.label_costo.Size = New System.Drawing.Size(55, 25)
        Me.label_costo.TabIndex = 17
        Me.label_costo.Text = "Costo"
        '
        'label_id_sede
        '
        Me.label_id_sede.AutoSize = True
        Me.label_id_sede.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_sede.Location = New System.Drawing.Point(297, 137)
        Me.label_id_sede.Name = "label_id_sede"
        Me.label_id_sede.Size = New System.Drawing.Size(94, 25)
        Me.label_id_sede.TabIndex = 16
        Me.label_id_sede.Text = "ID de Sede"
        '
        'txt_creditos
        '
        '
        '
        '
        Me.txt_creditos.CustomButton.Image = Nothing
        Me.txt_creditos.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txt_creditos.CustomButton.Name = ""
        Me.txt_creditos.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_creditos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_creditos.CustomButton.TabIndex = 1
        Me.txt_creditos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_creditos.CustomButton.UseSelectable = True
        Me.txt_creditos.CustomButton.Visible = False
        Me.txt_creditos.Lines = New String(-1) {}
        Me.txt_creditos.Location = New System.Drawing.Point(451, 207)
        Me.txt_creditos.MaxLength = 32767
        Me.txt_creditos.Name = "txt_creditos"
        Me.txt_creditos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_creditos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_creditos.SelectedText = ""
        Me.txt_creditos.SelectionLength = 0
        Me.txt_creditos.SelectionStart = 0
        Me.txt_creditos.ShortcutsEnabled = True
        Me.txt_creditos.Size = New System.Drawing.Size(153, 29)
        Me.txt_creditos.TabIndex = 15
        Me.txt_creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_creditos.UseSelectable = True
        Me.txt_creditos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_creditos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_requisito
        '
        Me.label_requisito.AutoSize = True
        Me.label_requisito.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_requisito.Location = New System.Drawing.Point(297, 102)
        Me.label_requisito.Name = "label_requisito"
        Me.label_requisito.Size = New System.Drawing.Size(154, 25)
        Me.label_requisito.TabIndex = 14
        Me.label_requisito.Text = "Requisito de Curso"
        '
        'txt_requisito
        '
        '
        '
        '
        Me.txt_requisito.CustomButton.Image = Nothing
        Me.txt_requisito.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txt_requisito.CustomButton.Name = ""
        Me.txt_requisito.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_requisito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_requisito.CustomButton.TabIndex = 1
        Me.txt_requisito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_requisito.CustomButton.UseSelectable = True
        Me.txt_requisito.CustomButton.Visible = False
        Me.txt_requisito.Lines = New String(-1) {}
        Me.txt_requisito.Location = New System.Drawing.Point(451, 102)
        Me.txt_requisito.MaxLength = 32767
        Me.txt_requisito.Name = "txt_requisito"
        Me.txt_requisito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_requisito.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_requisito.SelectedText = ""
        Me.txt_requisito.SelectionLength = 0
        Me.txt_requisito.SelectionStart = 0
        Me.txt_requisito.ShortcutsEnabled = True
        Me.txt_requisito.Size = New System.Drawing.Size(153, 29)
        Me.txt_requisito.TabIndex = 13
        Me.txt_requisito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_requisito.UseSelectable = True
        Me.txt_requisito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_requisito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_descripcion
        '
        Me.label_descripcion.AutoSize = True
        Me.label_descripcion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_descripcion.Location = New System.Drawing.Point(297, 67)
        Me.label_descripcion.Name = "label_descripcion"
        Me.label_descripcion.Size = New System.Drawing.Size(149, 25)
        Me.label_descripcion.TabIndex = 12
        Me.label_descripcion.Text = "Descripcion Curso"
        '
        'txt_descripcion_curso
        '
        '
        '
        '
        Me.txt_descripcion_curso.CustomButton.Image = Nothing
        Me.txt_descripcion_curso.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txt_descripcion_curso.CustomButton.Name = ""
        Me.txt_descripcion_curso.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_descripcion_curso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_descripcion_curso.CustomButton.TabIndex = 1
        Me.txt_descripcion_curso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_descripcion_curso.CustomButton.UseSelectable = True
        Me.txt_descripcion_curso.CustomButton.Visible = False
        Me.txt_descripcion_curso.Lines = New String(-1) {}
        Me.txt_descripcion_curso.Location = New System.Drawing.Point(451, 67)
        Me.txt_descripcion_curso.MaxLength = 32767
        Me.txt_descripcion_curso.Name = "txt_descripcion_curso"
        Me.txt_descripcion_curso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descripcion_curso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_descripcion_curso.SelectedText = ""
        Me.txt_descripcion_curso.SelectionLength = 0
        Me.txt_descripcion_curso.SelectionStart = 0
        Me.txt_descripcion_curso.ShortcutsEnabled = True
        Me.txt_descripcion_curso.Size = New System.Drawing.Size(153, 29)
        Me.txt_descripcion_curso.TabIndex = 11
        Me.txt_descripcion_curso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_descripcion_curso.UseSelectable = True
        Me.txt_descripcion_curso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_descripcion_curso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_nombre
        '
        Me.label_nombre.AutoSize = True
        Me.label_nombre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_nombre.Location = New System.Drawing.Point(-6, 182)
        Me.label_nombre.Name = "label_nombre"
        Me.label_nombre.Size = New System.Drawing.Size(148, 25)
        Me.label_nombre.TabIndex = 10
        Me.label_nombre.Text = "Nombre de Curso"
        '
        'txt_id_profesor
        '
        Me.txt_id_profesor.FormattingEnabled = True
        Me.txt_id_profesor.ItemHeight = 23
        Me.txt_id_profesor.Location = New System.Drawing.Point(143, 215)
        Me.txt_id_profesor.Name = "txt_id_profesor"
        Me.txt_id_profesor.Size = New System.Drawing.Size(153, 29)
        Me.txt_id_profesor.TabIndex = 9
        Me.txt_id_profesor.UseSelectable = True
        '
        'label_profesor
        '
        Me.label_profesor.AutoSize = True
        Me.label_profesor.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_profesor.Location = New System.Drawing.Point(-6, 217)
        Me.label_profesor.Name = "label_profesor"
        Me.label_profesor.Size = New System.Drawing.Size(120, 25)
        Me.label_profesor.TabIndex = 8
        Me.label_profesor.Text = "ID de Profesor"
        '
        'txt_id_horario
        '
        Me.txt_id_horario.FormattingEnabled = True
        Me.txt_id_horario.ItemHeight = 23
        Me.txt_id_horario.Location = New System.Drawing.Point(143, 145)
        Me.txt_id_horario.Name = "txt_id_horario"
        Me.txt_id_horario.Size = New System.Drawing.Size(153, 29)
        Me.txt_id_horario.TabIndex = 7
        Me.txt_id_horario.UseSelectable = True
        '
        'label_id_horario
        '
        Me.label_id_horario.AutoSize = True
        Me.label_id_horario.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_horario.Location = New System.Drawing.Point(-6, 147)
        Me.label_id_horario.Name = "label_id_horario"
        Me.label_id_horario.Size = New System.Drawing.Size(114, 25)
        Me.label_id_horario.TabIndex = 6
        Me.label_id_horario.Text = "ID de Horario"
        '
        'txt_id_carrera
        '
        Me.txt_id_carrera.FormattingEnabled = True
        Me.txt_id_carrera.ItemHeight = 23
        Me.txt_id_carrera.Location = New System.Drawing.Point(143, 110)
        Me.txt_id_carrera.Name = "txt_id_carrera"
        Me.txt_id_carrera.Size = New System.Drawing.Size(153, 29)
        Me.txt_id_carrera.TabIndex = 5
        Me.txt_id_carrera.UseSelectable = True
        '
        'txt_nombre_curso
        '
        '
        '
        '
        Me.txt_nombre_curso.CustomButton.Image = Nothing
        Me.txt_nombre_curso.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txt_nombre_curso.CustomButton.Name = ""
        Me.txt_nombre_curso.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nombre_curso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nombre_curso.CustomButton.TabIndex = 1
        Me.txt_nombre_curso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nombre_curso.CustomButton.UseSelectable = True
        Me.txt_nombre_curso.CustomButton.Visible = False
        Me.txt_nombre_curso.Lines = New String(-1) {}
        Me.txt_nombre_curso.Location = New System.Drawing.Point(143, 180)
        Me.txt_nombre_curso.MaxLength = 32767
        Me.txt_nombre_curso.Name = "txt_nombre_curso"
        Me.txt_nombre_curso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombre_curso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nombre_curso.SelectedText = ""
        Me.txt_nombre_curso.SelectionLength = 0
        Me.txt_nombre_curso.SelectionStart = 0
        Me.txt_nombre_curso.ShortcutsEnabled = True
        Me.txt_nombre_curso.Size = New System.Drawing.Size(153, 29)
        Me.txt_nombre_curso.TabIndex = 4
        Me.txt_nombre_curso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_nombre_curso.UseSelectable = True
        Me.txt_nombre_curso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nombre_curso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_id_carrera
        '
        Me.label_id_carrera.AutoSize = True
        Me.label_id_carrera.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_carrera.Location = New System.Drawing.Point(-6, 112)
        Me.label_id_carrera.Name = "label_id_carrera"
        Me.label_id_carrera.Size = New System.Drawing.Size(113, 25)
        Me.label_id_carrera.TabIndex = 3
        Me.label_id_carrera.Text = "ID de Carrera"
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_titulo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_titulo.Location = New System.Drawing.Point(233, 15)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(230, 25)
        Me.label_titulo.TabIndex = 2
        Me.label_titulo.Text = "Mantenimiento de Cursos"
        '
        'mantenimiento_cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_control_cursos)
        Me.Name = "mantenimiento_cursos"
        Me.Text = "Mantenimiento de Cursos"
        Me.tab_control_cursos.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        CType(Me.grid_cursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_control_cursos As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_cursos As MetroFramework.Controls.MetroGrid
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_id_carrera As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_nombre_curso As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_id_carrera As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_titulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_nombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_id_profesor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents label_profesor As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_id_horario As MetroFramework.Controls.MetroComboBox
    Friend WithEvents label_id_horario As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_descripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_descripcion_curso As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_id_sede As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_creditos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_requisito As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_requisito As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_id_sede As MetroFramework.Controls.MetroComboBox
    Friend WithEvents label_costo As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_creditos As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_costo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
    Friend WithEvents label_id_curso As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_id_curso As MetroFramework.Controls.MetroTextBox
End Class
