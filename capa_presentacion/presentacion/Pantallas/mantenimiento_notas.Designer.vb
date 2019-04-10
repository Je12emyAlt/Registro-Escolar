<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_notas
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_control = New MetroFramework.Controls.MetroTabControl()
        Me.tab_ver = New MetroFramework.Controls.MetroTabPage()
        Me.grid_notas = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.txt_id_matricula = New MetroFramework.Controls.MetroComboBox()
        Me.txt_status = New MetroFramework.Controls.MetroTextBox()
        Me.txt_nota_final = New MetroFramework.Controls.MetroTextBox()
        Me.txt_tercera_nota = New MetroFramework.Controls.MetroTextBox()
        Me.txt_segunda_nota = New MetroFramework.Controls.MetroTextBox()
        Me.txt_primera_nota = New MetroFramework.Controls.MetroTextBox()
        Me.txt_id_nota = New MetroFramework.Controls.MetroTextBox()
        Me.label_notal_final = New MetroFramework.Controls.MetroLabel()
        Me.label_tercera_nota = New MetroFramework.Controls.MetroLabel()
        Me.label_status = New MetroFramework.Controls.MetroLabel()
        Me.label_segunda_nota = New MetroFramework.Controls.MetroLabel()
        Me.label_primera_nota = New MetroFramework.Controls.MetroLabel()
        Me.label_id_matricula = New MetroFramework.Controls.MetroLabel()
        Me.label_id_nota = New MetroFramework.Controls.MetroLabel()
        Me.label_texto = New MetroFramework.Controls.MetroLabel()
        Me.tab_control.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        CType(Me.grid_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.tab_ver)
        Me.tab_control.Controls.Add(Me.tab_mantenimiento)
        Me.tab_control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_control.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tab_control.Location = New System.Drawing.Point(20, 60)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedIndex = 1
        Me.tab_control.Size = New System.Drawing.Size(615, 362)
        Me.tab_control.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tab_control.TabIndex = 0
        Me.tab_control.UseSelectable = True
        '
        'tab_ver
        '
        Me.tab_ver.Controls.Add(Me.grid_notas)
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
        'grid_notas
        '
        Me.grid_notas.AllowUserToResizeRows = False
        Me.grid_notas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_notas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_notas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_notas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_notas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grid_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_notas.DefaultCellStyle = DataGridViewCellStyle14
        Me.grid_notas.EnableHeadersVisualStyles = False
        Me.grid_notas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_notas.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_notas.Location = New System.Drawing.Point(-4, 16)
        Me.grid_notas.Name = "grid_notas"
        Me.grid_notas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_notas.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grid_notas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_notas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_notas.Size = New System.Drawing.Size(608, 270)
        Me.grid_notas.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_matricula)
        Me.tab_mantenimiento.Controls.Add(Me.txt_status)
        Me.tab_mantenimiento.Controls.Add(Me.txt_nota_final)
        Me.tab_mantenimiento.Controls.Add(Me.txt_tercera_nota)
        Me.tab_mantenimiento.Controls.Add(Me.txt_segunda_nota)
        Me.tab_mantenimiento.Controls.Add(Me.txt_primera_nota)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_nota)
        Me.tab_mantenimiento.Controls.Add(Me.label_notal_final)
        Me.tab_mantenimiento.Controls.Add(Me.label_tercera_nota)
        Me.tab_mantenimiento.Controls.Add(Me.label_status)
        Me.tab_mantenimiento.Controls.Add(Me.label_segunda_nota)
        Me.tab_mantenimiento.Controls.Add(Me.label_primera_nota)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_matricula)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_nota)
        Me.tab_mantenimiento.Controls.Add(Me.label_texto)
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
        'btn_salir
        '
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_salir.Location = New System.Drawing.Point(442, 248)
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
        Me.btn_borrar.Location = New System.Drawing.Point(338, 248)
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
        Me.btn_modificar.Location = New System.Drawing.Point(234, 248)
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
        Me.btn_agregar.Location = New System.Drawing.Point(130, 248)
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
        Me.btn_buscar.Location = New System.Drawing.Point(26, 248)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 24
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'txt_id_matricula
        '
        Me.txt_id_matricula.FormattingEnabled = True
        Me.txt_id_matricula.ItemHeight = 23
        Me.txt_id_matricula.Location = New System.Drawing.Point(145, 114)
        Me.txt_id_matricula.Name = "txt_id_matricula"
        Me.txt_id_matricula.Size = New System.Drawing.Size(176, 29)
        Me.txt_id_matricula.TabIndex = 16
        Me.txt_id_matricula.UseSelectable = True
        '
        'txt_status
        '
        '
        '
        '
        Me.txt_status.CustomButton.Image = Nothing
        Me.txt_status.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.txt_status.CustomButton.Name = ""
        Me.txt_status.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_status.CustomButton.TabIndex = 1
        Me.txt_status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_status.CustomButton.UseSelectable = True
        Me.txt_status.CustomButton.Visible = False
        Me.txt_status.Enabled = False
        Me.txt_status.Lines = New String(-1) {}
        Me.txt_status.Location = New System.Drawing.Point(430, 154)
        Me.txt_status.MaxLength = 32767
        Me.txt_status.Name = "txt_status"
        Me.txt_status.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_status.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_status.SelectedText = ""
        Me.txt_status.SelectionLength = 0
        Me.txt_status.SelectionStart = 0
        Me.txt_status.ShortcutsEnabled = True
        Me.txt_status.Size = New System.Drawing.Size(174, 29)
        Me.txt_status.TabIndex = 15
        Me.txt_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_status.UseSelectable = True
        Me.txt_status.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_status.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_nota_final
        '
        '
        '
        '
        Me.txt_nota_final.CustomButton.Image = Nothing
        Me.txt_nota_final.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.txt_nota_final.CustomButton.Name = ""
        Me.txt_nota_final.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nota_final.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nota_final.CustomButton.TabIndex = 1
        Me.txt_nota_final.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nota_final.CustomButton.UseSelectable = True
        Me.txt_nota_final.CustomButton.Visible = False
        Me.txt_nota_final.Enabled = False
        Me.txt_nota_final.Lines = New String(-1) {}
        Me.txt_nota_final.Location = New System.Drawing.Point(430, 111)
        Me.txt_nota_final.MaxLength = 32767
        Me.txt_nota_final.Name = "txt_nota_final"
        Me.txt_nota_final.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nota_final.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nota_final.SelectedText = ""
        Me.txt_nota_final.SelectionLength = 0
        Me.txt_nota_final.SelectionStart = 0
        Me.txt_nota_final.ShortcutsEnabled = True
        Me.txt_nota_final.Size = New System.Drawing.Size(174, 29)
        Me.txt_nota_final.TabIndex = 14
        Me.txt_nota_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_nota_final.UseSelectable = True
        Me.txt_nota_final.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nota_final.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_tercera_nota
        '
        '
        '
        '
        Me.txt_tercera_nota.CustomButton.Image = Nothing
        Me.txt_tercera_nota.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.txt_tercera_nota.CustomButton.Name = ""
        Me.txt_tercera_nota.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_tercera_nota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_tercera_nota.CustomButton.TabIndex = 1
        Me.txt_tercera_nota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_tercera_nota.CustomButton.UseSelectable = True
        Me.txt_tercera_nota.CustomButton.Visible = False
        Me.txt_tercera_nota.Lines = New String(-1) {}
        Me.txt_tercera_nota.Location = New System.Drawing.Point(430, 72)
        Me.txt_tercera_nota.MaxLength = 32767
        Me.txt_tercera_nota.Name = "txt_tercera_nota"
        Me.txt_tercera_nota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_tercera_nota.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_tercera_nota.SelectedText = ""
        Me.txt_tercera_nota.SelectionLength = 0
        Me.txt_tercera_nota.SelectionStart = 0
        Me.txt_tercera_nota.ShortcutsEnabled = True
        Me.txt_tercera_nota.Size = New System.Drawing.Size(174, 29)
        Me.txt_tercera_nota.TabIndex = 13
        Me.txt_tercera_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_tercera_nota.UseSelectable = True
        Me.txt_tercera_nota.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_tercera_nota.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_segunda_nota
        '
        '
        '
        '
        Me.txt_segunda_nota.CustomButton.Image = Nothing
        Me.txt_segunda_nota.CustomButton.Location = New System.Drawing.Point(148, 1)
        Me.txt_segunda_nota.CustomButton.Name = ""
        Me.txt_segunda_nota.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_segunda_nota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_segunda_nota.CustomButton.TabIndex = 1
        Me.txt_segunda_nota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_segunda_nota.CustomButton.UseSelectable = True
        Me.txt_segunda_nota.CustomButton.Visible = False
        Me.txt_segunda_nota.Lines = New String(-1) {}
        Me.txt_segunda_nota.Location = New System.Drawing.Point(145, 193)
        Me.txt_segunda_nota.MaxLength = 32767
        Me.txt_segunda_nota.Name = "txt_segunda_nota"
        Me.txt_segunda_nota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_segunda_nota.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_segunda_nota.SelectedText = ""
        Me.txt_segunda_nota.SelectionLength = 0
        Me.txt_segunda_nota.SelectionStart = 0
        Me.txt_segunda_nota.ShortcutsEnabled = True
        Me.txt_segunda_nota.Size = New System.Drawing.Size(176, 29)
        Me.txt_segunda_nota.TabIndex = 12
        Me.txt_segunda_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_segunda_nota.UseSelectable = True
        Me.txt_segunda_nota.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_segunda_nota.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_primera_nota
        '
        '
        '
        '
        Me.txt_primera_nota.CustomButton.Image = Nothing
        Me.txt_primera_nota.CustomButton.Location = New System.Drawing.Point(148, 1)
        Me.txt_primera_nota.CustomButton.Name = ""
        Me.txt_primera_nota.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_primera_nota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_primera_nota.CustomButton.TabIndex = 1
        Me.txt_primera_nota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_primera_nota.CustomButton.UseSelectable = True
        Me.txt_primera_nota.CustomButton.Visible = False
        Me.txt_primera_nota.Lines = New String(-1) {}
        Me.txt_primera_nota.Location = New System.Drawing.Point(145, 154)
        Me.txt_primera_nota.MaxLength = 32767
        Me.txt_primera_nota.Name = "txt_primera_nota"
        Me.txt_primera_nota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_primera_nota.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_primera_nota.SelectedText = ""
        Me.txt_primera_nota.SelectionLength = 0
        Me.txt_primera_nota.SelectionStart = 0
        Me.txt_primera_nota.ShortcutsEnabled = True
        Me.txt_primera_nota.Size = New System.Drawing.Size(176, 29)
        Me.txt_primera_nota.TabIndex = 11
        Me.txt_primera_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_primera_nota.UseSelectable = True
        Me.txt_primera_nota.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_primera_nota.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_id_nota
        '
        '
        '
        '
        Me.txt_id_nota.CustomButton.Image = Nothing
        Me.txt_id_nota.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.txt_id_nota.CustomButton.Name = ""
        Me.txt_id_nota.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_nota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_nota.CustomButton.TabIndex = 1
        Me.txt_id_nota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_nota.CustomButton.UseSelectable = True
        Me.txt_id_nota.CustomButton.Visible = False
        Me.txt_id_nota.Lines = New String(-1) {}
        Me.txt_id_nota.Location = New System.Drawing.Point(147, 72)
        Me.txt_id_nota.MaxLength = 32767
        Me.txt_id_nota.Name = "txt_id_nota"
        Me.txt_id_nota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_nota.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_nota.SelectedText = ""
        Me.txt_id_nota.SelectionLength = 0
        Me.txt_id_nota.SelectionStart = 0
        Me.txt_id_nota.ShortcutsEnabled = True
        Me.txt_id_nota.Size = New System.Drawing.Size(174, 29)
        Me.txt_id_nota.TabIndex = 10
        Me.txt_id_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id_nota.UseSelectable = True
        Me.txt_id_nota.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_nota.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_notal_final
        '
        Me.label_notal_final.AutoSize = True
        Me.label_notal_final.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_notal_final.Location = New System.Drawing.Point(323, 111)
        Me.label_notal_final.Name = "label_notal_final"
        Me.label_notal_final.Size = New System.Drawing.Size(89, 25)
        Me.label_notal_final.TabIndex = 9
        Me.label_notal_final.Text = "Nota Final"
        '
        'label_tercera_nota
        '
        Me.label_tercera_nota.AutoSize = True
        Me.label_tercera_nota.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_tercera_nota.Location = New System.Drawing.Point(323, 71)
        Me.label_tercera_nota.Name = "label_tercera_nota"
        Me.label_tercera_nota.Size = New System.Drawing.Size(107, 25)
        Me.label_tercera_nota.TabIndex = 8
        Me.label_tercera_nota.Text = "Tercera Nota"
        '
        'label_status
        '
        Me.label_status.AutoSize = True
        Me.label_status.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_status.Location = New System.Drawing.Point(323, 154)
        Me.label_status.Name = "label_status"
        Me.label_status.Size = New System.Drawing.Size(57, 25)
        Me.label_status.TabIndex = 7
        Me.label_status.Text = "Status"
        '
        'label_segunda_nota
        '
        Me.label_segunda_nota.AutoSize = True
        Me.label_segunda_nota.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_segunda_nota.Location = New System.Drawing.Point(18, 195)
        Me.label_segunda_nota.Name = "label_segunda_nota"
        Me.label_segunda_nota.Size = New System.Drawing.Size(121, 25)
        Me.label_segunda_nota.TabIndex = 6
        Me.label_segunda_nota.Text = "Segunda Nota"
        '
        'label_primera_nota
        '
        Me.label_primera_nota.AutoSize = True
        Me.label_primera_nota.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_primera_nota.Location = New System.Drawing.Point(18, 154)
        Me.label_primera_nota.Name = "label_primera_nota"
        Me.label_primera_nota.Size = New System.Drawing.Size(113, 25)
        Me.label_primera_nota.TabIndex = 5
        Me.label_primera_nota.Text = "Primera Nota"
        '
        'label_id_matricula
        '
        Me.label_id_matricula.AutoSize = True
        Me.label_id_matricula.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_matricula.Location = New System.Drawing.Point(18, 111)
        Me.label_id_matricula.Name = "label_id_matricula"
        Me.label_id_matricula.Size = New System.Drawing.Size(127, 25)
        Me.label_id_matricula.TabIndex = 4
        Me.label_id_matricula.Text = "ID de Matricula"
        '
        'label_id_nota
        '
        Me.label_id_nota.AutoSize = True
        Me.label_id_nota.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_nota.Location = New System.Drawing.Point(18, 71)
        Me.label_id_nota.Name = "label_id_nota"
        Me.label_id_nota.Size = New System.Drawing.Size(94, 25)
        Me.label_id_nota.TabIndex = 3
        Me.label_id_nota.Text = "ID de Nota"
        '
        'label_texto
        '
        Me.label_texto.AutoSize = True
        Me.label_texto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_texto.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_texto.Location = New System.Drawing.Point(198, 19)
        Me.label_texto.Name = "label_texto"
        Me.label_texto.Size = New System.Drawing.Size(224, 25)
        Me.label_texto.TabIndex = 2
        Me.label_texto.Text = "Mantenimiento de Notas"
        '
        'mantenimiento_notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "mantenimiento_notas"
        Me.Text = "Mantenimiento de Notas"
        Me.tab_control.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        CType(Me.grid_notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_control As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_notas As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_id_matricula As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_status As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_nota_final As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_tercera_nota As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_segunda_nota As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_primera_nota As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_id_nota As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_notal_final As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_tercera_nota As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_status As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_segunda_nota As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_primera_nota As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_matricula As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_nota As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_texto As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
End Class
