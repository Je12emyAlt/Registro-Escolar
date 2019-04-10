<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_dashboard = New MetroFramework.Controls.MetroTabControl()
        Me.tab_hogar = New MetroFramework.Controls.MetroTabPage()
        Me.grid_cursos = New MetroFramework.Controls.MetroGrid()
        Me.grid_info_carrera = New MetroFramework.Controls.MetroGrid()
        Me.grid_info_estudiantes = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.tile_sede = New MetroFramework.Controls.MetroTile()
        Me.tile_notas = New MetroFramework.Controls.MetroTile()
        Me.tile_profesores = New MetroFramework.Controls.MetroTile()
        Me.tile_horarios = New MetroFramework.Controls.MetroTile()
        Me.tile_matricula = New MetroFramework.Controls.MetroTile()
        Me.tile_cursos = New MetroFramework.Controls.MetroTile()
        Me.tile_carreras = New MetroFramework.Controls.MetroTile()
        Me.tile_estudiantes = New MetroFramework.Controls.MetroTile()
        Me.tab_notas = New MetroFramework.Controls.MetroTabPage()
        Me.grid_aprobados = New MetroFramework.Controls.MetroGrid()
        Me.txt_id_cedula = New MetroFramework.Controls.MetroComboBox()
        Me.label_id_cedula = New MetroFramework.Controls.MetroLabel()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.grid_sedes = New MetroFramework.Controls.MetroGrid()
        Me.tab_dashboard.SuspendLayout()
        Me.tab_hogar.SuspendLayout()
        CType(Me.grid_cursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_info_carrera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_info_estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mantenimiento.SuspendLayout()
        Me.tab_notas.SuspendLayout()
        CType(Me.grid_aprobados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sedes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_dashboard
        '
        Me.tab_dashboard.Controls.Add(Me.tab_hogar)
        Me.tab_dashboard.Controls.Add(Me.tab_mantenimiento)
        Me.tab_dashboard.Controls.Add(Me.tab_notas)
        Me.tab_dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_dashboard.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tab_dashboard.Location = New System.Drawing.Point(20, 60)
        Me.tab_dashboard.Name = "tab_dashboard"
        Me.tab_dashboard.SelectedIndex = 1
        Me.tab_dashboard.Size = New System.Drawing.Size(778, 476)
        Me.tab_dashboard.TabIndex = 0
        Me.tab_dashboard.UseSelectable = True
        '
        'tab_hogar
        '
        Me.tab_hogar.Controls.Add(Me.grid_sedes)
        Me.tab_hogar.Controls.Add(Me.grid_cursos)
        Me.tab_hogar.Controls.Add(Me.grid_info_carrera)
        Me.tab_hogar.Controls.Add(Me.grid_info_estudiantes)
        Me.tab_hogar.HorizontalScrollbarBarColor = True
        Me.tab_hogar.HorizontalScrollbarHighlightOnWheel = False
        Me.tab_hogar.HorizontalScrollbarSize = 10
        Me.tab_hogar.Location = New System.Drawing.Point(4, 44)
        Me.tab_hogar.Name = "tab_hogar"
        Me.tab_hogar.Size = New System.Drawing.Size(770, 428)
        Me.tab_hogar.TabIndex = 0
        Me.tab_hogar.Text = "Inicio"
        Me.tab_hogar.VerticalScrollbarBarColor = True
        Me.tab_hogar.VerticalScrollbarHighlightOnWheel = False
        Me.tab_hogar.VerticalScrollbarSize = 10
        '
        'grid_cursos
        '
        Me.grid_cursos.AllowUserToAddRows = False
        Me.grid_cursos.AllowUserToDeleteRows = False
        Me.grid_cursos.AllowUserToResizeRows = False
        Me.grid_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_cursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_cursos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_cursos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_cursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_cursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.grid_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cursos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_cursos.DefaultCellStyle = DataGridViewCellStyle17
        Me.grid_cursos.EnableHeadersVisualStyles = False
        Me.grid_cursos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_cursos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_cursos.Location = New System.Drawing.Point(0, 204)
        Me.grid_cursos.Name = "grid_cursos"
        Me.grid_cursos.ReadOnly = True
        Me.grid_cursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cursos.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.grid_cursos.RowHeadersVisible = False
        Me.grid_cursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cursos.Size = New System.Drawing.Size(770, 77)
        Me.grid_cursos.TabIndex = 4
        '
        'grid_info_carrera
        '
        Me.grid_info_carrera.AllowUserToResizeRows = False
        Me.grid_info_carrera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_info_carrera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_info_carrera.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_carrera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_info_carrera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_info_carrera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_carrera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.grid_info_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info_carrera.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_info_carrera.DefaultCellStyle = DataGridViewCellStyle20
        Me.grid_info_carrera.EnableHeadersVisualStyles = False
        Me.grid_info_carrera.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_info_carrera.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_carrera.Location = New System.Drawing.Point(4, 95)
        Me.grid_info_carrera.Name = "grid_info_carrera"
        Me.grid_info_carrera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_carrera.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.grid_info_carrera.RowHeadersVisible = False
        Me.grid_info_carrera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_info_carrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_info_carrera.Size = New System.Drawing.Size(763, 103)
        Me.grid_info_carrera.TabIndex = 3
        '
        'grid_info_estudiantes
        '
        Me.grid_info_estudiantes.AllowUserToAddRows = False
        Me.grid_info_estudiantes.AllowUserToDeleteRows = False
        Me.grid_info_estudiantes.AllowUserToResizeRows = False
        Me.grid_info_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_info_estudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_info_estudiantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_info_estudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_info_estudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_estudiantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.grid_info_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info_estudiantes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_info_estudiantes.DefaultCellStyle = DataGridViewCellStyle23
        Me.grid_info_estudiantes.EnableHeadersVisualStyles = False
        Me.grid_info_estudiantes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_info_estudiantes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_estudiantes.Location = New System.Drawing.Point(4, 12)
        Me.grid_info_estudiantes.Name = "grid_info_estudiantes"
        Me.grid_info_estudiantes.ReadOnly = True
        Me.grid_info_estudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_estudiantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.grid_info_estudiantes.RowHeadersVisible = False
        Me.grid_info_estudiantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_info_estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_info_estudiantes.Size = New System.Drawing.Size(770, 77)
        Me.grid_info_estudiantes.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.tile_sede)
        Me.tab_mantenimiento.Controls.Add(Me.tile_notas)
        Me.tab_mantenimiento.Controls.Add(Me.tile_profesores)
        Me.tab_mantenimiento.Controls.Add(Me.tile_horarios)
        Me.tab_mantenimiento.Controls.Add(Me.tile_matricula)
        Me.tab_mantenimiento.Controls.Add(Me.tile_cursos)
        Me.tab_mantenimiento.Controls.Add(Me.tile_carreras)
        Me.tab_mantenimiento.Controls.Add(Me.tile_estudiantes)
        Me.tab_mantenimiento.HorizontalScrollbarBarColor = True
        Me.tab_mantenimiento.HorizontalScrollbarHighlightOnWheel = False
        Me.tab_mantenimiento.HorizontalScrollbarSize = 10
        Me.tab_mantenimiento.Location = New System.Drawing.Point(4, 44)
        Me.tab_mantenimiento.Name = "tab_mantenimiento"
        Me.tab_mantenimiento.Size = New System.Drawing.Size(770, 428)
        Me.tab_mantenimiento.TabIndex = 1
        Me.tab_mantenimiento.Text = "Mantenimiento"
        Me.tab_mantenimiento.VerticalScrollbarBarColor = True
        Me.tab_mantenimiento.VerticalScrollbarHighlightOnWheel = False
        Me.tab_mantenimiento.VerticalScrollbarSize = 10
        '
        'tile_sede
        '
        Me.tile_sede.ActiveControl = Nothing
        Me.tile_sede.Location = New System.Drawing.Point(593, 210)
        Me.tile_sede.Name = "tile_sede"
        Me.tile_sede.Size = New System.Drawing.Size(181, 138)
        Me.tile_sede.TabIndex = 9
        Me.tile_sede.Text = "Sede"
        Me.tile_sede.UseSelectable = True
        '
        'tile_notas
        '
        Me.tile_notas.ActiveControl = Nothing
        Me.tile_notas.Location = New System.Drawing.Point(398, 210)
        Me.tile_notas.Name = "tile_notas"
        Me.tile_notas.Size = New System.Drawing.Size(181, 138)
        Me.tile_notas.TabIndex = 8
        Me.tile_notas.Text = "Notas"
        Me.tile_notas.UseSelectable = True
        '
        'tile_profesores
        '
        Me.tile_profesores.ActiveControl = Nothing
        Me.tile_profesores.Location = New System.Drawing.Point(202, 210)
        Me.tile_profesores.Name = "tile_profesores"
        Me.tile_profesores.Size = New System.Drawing.Size(181, 138)
        Me.tile_profesores.TabIndex = 7
        Me.tile_profesores.Text = "Profesores"
        Me.tile_profesores.UseSelectable = True
        '
        'tile_horarios
        '
        Me.tile_horarios.ActiveControl = Nothing
        Me.tile_horarios.Location = New System.Drawing.Point(3, 210)
        Me.tile_horarios.Name = "tile_horarios"
        Me.tile_horarios.Size = New System.Drawing.Size(181, 138)
        Me.tile_horarios.TabIndex = 6
        Me.tile_horarios.Text = "Horarios"
        Me.tile_horarios.UseSelectable = True
        '
        'tile_matricula
        '
        Me.tile_matricula.ActiveControl = Nothing
        Me.tile_matricula.Location = New System.Drawing.Point(593, 34)
        Me.tile_matricula.Name = "tile_matricula"
        Me.tile_matricula.Size = New System.Drawing.Size(181, 138)
        Me.tile_matricula.TabIndex = 5
        Me.tile_matricula.Text = "Matricula"
        Me.tile_matricula.UseSelectable = True
        '
        'tile_cursos
        '
        Me.tile_cursos.ActiveControl = Nothing
        Me.tile_cursos.Location = New System.Drawing.Point(398, 34)
        Me.tile_cursos.Name = "tile_cursos"
        Me.tile_cursos.Size = New System.Drawing.Size(181, 138)
        Me.tile_cursos.TabIndex = 4
        Me.tile_cursos.Text = "Cursos"
        Me.tile_cursos.UseSelectable = True
        '
        'tile_carreras
        '
        Me.tile_carreras.ActiveControl = Nothing
        Me.tile_carreras.Location = New System.Drawing.Point(202, 34)
        Me.tile_carreras.Name = "tile_carreras"
        Me.tile_carreras.Size = New System.Drawing.Size(181, 138)
        Me.tile_carreras.TabIndex = 3
        Me.tile_carreras.Text = "Carreras"
        Me.tile_carreras.UseSelectable = True
        '
        'tile_estudiantes
        '
        Me.tile_estudiantes.ActiveControl = Nothing
        Me.tile_estudiantes.Location = New System.Drawing.Point(3, 34)
        Me.tile_estudiantes.Name = "tile_estudiantes"
        Me.tile_estudiantes.Size = New System.Drawing.Size(181, 138)
        Me.tile_estudiantes.TabIndex = 2
        Me.tile_estudiantes.Text = "Estudiantes"
        Me.tile_estudiantes.UseSelectable = True
        '
        'tab_notas
        '
        Me.tab_notas.Controls.Add(Me.btn_buscar)
        Me.tab_notas.Controls.Add(Me.grid_aprobados)
        Me.tab_notas.Controls.Add(Me.txt_id_cedula)
        Me.tab_notas.Controls.Add(Me.label_id_cedula)
        Me.tab_notas.HorizontalScrollbarBarColor = True
        Me.tab_notas.HorizontalScrollbarHighlightOnWheel = False
        Me.tab_notas.HorizontalScrollbarSize = 10
        Me.tab_notas.Location = New System.Drawing.Point(4, 44)
        Me.tab_notas.Name = "tab_notas"
        Me.tab_notas.Size = New System.Drawing.Size(770, 428)
        Me.tab_notas.TabIndex = 2
        Me.tab_notas.Text = "Consultar Notas"
        Me.tab_notas.VerticalScrollbarBarColor = True
        Me.tab_notas.VerticalScrollbarHighlightOnWheel = False
        Me.tab_notas.VerticalScrollbarSize = 10
        '
        'grid_aprobados
        '
        Me.grid_aprobados.AllowUserToResizeRows = False
        Me.grid_aprobados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_aprobados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_aprobados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_aprobados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_aprobados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.grid_aprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_aprobados.DefaultCellStyle = DataGridViewCellStyle26
        Me.grid_aprobados.EnableHeadersVisualStyles = False
        Me.grid_aprobados.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_aprobados.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_aprobados.Location = New System.Drawing.Point(21, 74)
        Me.grid_aprobados.Name = "grid_aprobados"
        Me.grid_aprobados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_aprobados.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.grid_aprobados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_aprobados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_aprobados.Size = New System.Drawing.Size(716, 217)
        Me.grid_aprobados.TabIndex = 4
        '
        'txt_id_cedula
        '
        Me.txt_id_cedula.FormattingEnabled = True
        Me.txt_id_cedula.ItemHeight = 23
        Me.txt_id_cedula.Location = New System.Drawing.Point(119, 31)
        Me.txt_id_cedula.Name = "txt_id_cedula"
        Me.txt_id_cedula.Size = New System.Drawing.Size(199, 29)
        Me.txt_id_cedula.TabIndex = 3
        Me.txt_id_cedula.UseSelectable = True
        '
        'label_id_cedula
        '
        Me.label_id_cedula.AutoSize = True
        Me.label_id_cedula.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_cedula.Location = New System.Drawing.Point(21, 33)
        Me.label_id_cedula.Name = "label_id_cedula"
        Me.label_id_cedula.Size = New System.Drawing.Size(86, 25)
        Me.label_id_cedula.TabIndex = 2
        Me.label_id_cedula.Text = "ID Cedula"
        '
        'btn_buscar
        '
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_buscar.Location = New System.Drawing.Point(329, 25)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 20
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'grid_sedes
        '
        Me.grid_sedes.AllowUserToAddRows = False
        Me.grid_sedes.AllowUserToDeleteRows = False
        Me.grid_sedes.AllowUserToResizeRows = False
        Me.grid_sedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_sedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_sedes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_sedes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_sedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_sedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_sedes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.grid_sedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_sedes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_sedes.DefaultCellStyle = DataGridViewCellStyle29
        Me.grid_sedes.EnableHeadersVisualStyles = False
        Me.grid_sedes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_sedes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_sedes.Location = New System.Drawing.Point(1, 337)
        Me.grid_sedes.Name = "grid_sedes"
        Me.grid_sedes.ReadOnly = True
        Me.grid_sedes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_sedes.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.grid_sedes.RowHeadersVisible = False
        Me.grid_sedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_sedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_sedes.Size = New System.Drawing.Size(770, 77)
        Me.grid_sedes.TabIndex = 5
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 556)
        Me.Controls.Add(Me.tab_dashboard)
        Me.Name = "dashboard"
        Me.Text = "Registro Escolar"
        Me.tab_dashboard.ResumeLayout(False)
        Me.tab_hogar.ResumeLayout(False)
        CType(Me.grid_cursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_info_carrera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_info_estudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_notas.ResumeLayout(False)
        Me.tab_notas.PerformLayout()
        CType(Me.grid_aprobados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sedes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_dashboard As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_hogar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_info_estudiantes As MetroFramework.Controls.MetroGrid
    Friend WithEvents grid_info_carrera As MetroFramework.Controls.MetroGrid
    Friend WithEvents grid_cursos As MetroFramework.Controls.MetroGrid
    Friend WithEvents tile_sede As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_notas As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_profesores As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_horarios As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_matricula As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_cursos As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_carreras As MetroFramework.Controls.MetroTile
    Friend WithEvents tile_estudiantes As MetroFramework.Controls.MetroTile
    Friend WithEvents tab_notas As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_aprobados As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_id_cedula As MetroFramework.Controls.MetroComboBox
    Friend WithEvents label_id_cedula As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
    Friend WithEvents grid_sedes As MetroFramework.Controls.MetroGrid
End Class
