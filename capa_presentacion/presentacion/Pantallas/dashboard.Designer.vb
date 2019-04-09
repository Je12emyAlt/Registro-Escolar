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
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle66 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_dashboard = New MetroFramework.Controls.MetroTabControl()
        Me.tab_hogar = New MetroFramework.Controls.MetroTabPage()
        Me.grid_cursos = New MetroFramework.Controls.MetroGrid()
        Me.grid_info_carrera = New MetroFramework.Controls.MetroGrid()
        Me.grid_info_estudiantes = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.tile_estudiantes = New MetroFramework.Controls.MetroTile()
        Me.tile_carreras = New MetroFramework.Controls.MetroTile()
        Me.tile_cursos = New MetroFramework.Controls.MetroTile()
        Me.tile_matricula = New MetroFramework.Controls.MetroTile()
        Me.tile_horarios = New MetroFramework.Controls.MetroTile()
        Me.tile_sede = New MetroFramework.Controls.MetroTile()
        Me.tile_notas = New MetroFramework.Controls.MetroTile()
        Me.tile_profesores = New MetroFramework.Controls.MetroTile()
        Me.tab_dashboard.SuspendLayout()
        Me.tab_hogar.SuspendLayout()
        CType(Me.grid_cursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_info_carrera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_info_estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_dashboard
        '
        Me.tab_dashboard.Controls.Add(Me.tab_hogar)
        Me.tab_dashboard.Controls.Add(Me.tab_mantenimiento)
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
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle64
        Me.grid_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cursos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle65.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_cursos.DefaultCellStyle = DataGridViewCellStyle65
        Me.grid_cursos.EnableHeadersVisualStyles = False
        Me.grid_cursos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_cursos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_cursos.Location = New System.Drawing.Point(0, 204)
        Me.grid_cursos.Name = "grid_cursos"
        Me.grid_cursos.ReadOnly = True
        Me.grid_cursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle66.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cursos.RowHeadersDefaultCellStyle = DataGridViewCellStyle66
        Me.grid_cursos.RowHeadersVisible = False
        Me.grid_cursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cursos.Size = New System.Drawing.Size(770, 77)
        Me.grid_cursos.TabIndex = 4
        '
        'grid_info_carrera
        '
        Me.grid_info_carrera.AllowUserToResizeRows = False
        Me.grid_info_carrera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.grid_info_carrera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_info_carrera.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_carrera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_info_carrera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_info_carrera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle67.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_carrera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle67
        Me.grid_info_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info_carrera.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle68.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_info_carrera.DefaultCellStyle = DataGridViewCellStyle68
        Me.grid_info_carrera.EnableHeadersVisualStyles = False
        Me.grid_info_carrera.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_info_carrera.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_carrera.Location = New System.Drawing.Point(4, 95)
        Me.grid_info_carrera.Name = "grid_info_carrera"
        Me.grid_info_carrera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle69.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_carrera.RowHeadersDefaultCellStyle = DataGridViewCellStyle69
        Me.grid_info_carrera.RowHeadersVisible = False
        Me.grid_info_carrera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_info_carrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_info_carrera.Size = New System.Drawing.Size(385, 103)
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
        DataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle70.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_estudiantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle70
        Me.grid_info_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info_estudiantes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle71.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_info_estudiantes.DefaultCellStyle = DataGridViewCellStyle71
        Me.grid_info_estudiantes.EnableHeadersVisualStyles = False
        Me.grid_info_estudiantes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_info_estudiantes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_estudiantes.Location = New System.Drawing.Point(4, 12)
        Me.grid_info_estudiantes.Name = "grid_info_estudiantes"
        Me.grid_info_estudiantes.ReadOnly = True
        Me.grid_info_estudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle72.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_estudiantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle72
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
End Class
