<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_estudiantes
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
        Me.tab_estudiantes = New MetroFramework.Controls.MetroTabControl()
        Me.tab_vista = New MetroFramework.Controls.MetroTabPage()
        Me.grid_info_estudiantes = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt_correo = New MetroFramework.Controls.MetroTextBox()
        Me.label_correo = New MetroFramework.Controls.MetroLabel()
        Me.txt_celular = New MetroFramework.Controls.MetroTextBox()
        Me.label_celular = New MetroFramework.Controls.MetroLabel()
        Me.txt_telefono = New MetroFramework.Controls.MetroTextBox()
        Me.label_telefono = New MetroFramework.Controls.MetroLabel()
        Me.txt_direccion = New MetroFramework.Controls.MetroTextBox()
        Me.label_direccion = New MetroFramework.Controls.MetroLabel()
        Me.txt_apellido = New MetroFramework.Controls.MetroTextBox()
        Me.label_apellido = New MetroFramework.Controls.MetroLabel()
        Me.txt_nombre = New MetroFramework.Controls.MetroTextBox()
        Me.label_nombre = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.label_id_cedula = New MetroFramework.Controls.MetroLabel()
        Me.txt_cedula = New MetroFramework.Controls.MetroTextBox()
        Me.txt_id_carrera = New MetroFramework.Controls.MetroComboBox()
        Me.tab_estudiantes.SuspendLayout()
        Me.tab_vista.SuspendLayout()
        CType(Me.grid_info_estudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_estudiantes
        '
        Me.tab_estudiantes.Controls.Add(Me.tab_vista)
        Me.tab_estudiantes.Controls.Add(Me.tab_mantenimiento)
        Me.tab_estudiantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_estudiantes.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tab_estudiantes.Location = New System.Drawing.Point(20, 60)
        Me.tab_estudiantes.Name = "tab_estudiantes"
        Me.tab_estudiantes.SelectedIndex = 1
        Me.tab_estudiantes.Size = New System.Drawing.Size(615, 362)
        Me.tab_estudiantes.TabIndex = 0
        Me.tab_estudiantes.UseSelectable = True
        '
        'tab_vista
        '
        Me.tab_vista.Controls.Add(Me.grid_info_estudiantes)
        Me.tab_vista.HorizontalScrollbarBarColor = True
        Me.tab_vista.HorizontalScrollbarHighlightOnWheel = False
        Me.tab_vista.HorizontalScrollbarSize = 10
        Me.tab_vista.Location = New System.Drawing.Point(4, 44)
        Me.tab_vista.Name = "tab_vista"
        Me.tab_vista.Size = New System.Drawing.Size(607, 314)
        Me.tab_vista.TabIndex = 0
        Me.tab_vista.Text = "Ver"
        Me.tab_vista.VerticalScrollbarBarColor = True
        Me.tab_vista.VerticalScrollbarHighlightOnWheel = False
        Me.tab_vista.VerticalScrollbarSize = 10
        '
        'grid_info_estudiantes
        '
        Me.grid_info_estudiantes.AllowUserToResizeColumns = False
        Me.grid_info_estudiantes.AllowUserToResizeRows = False
        Me.grid_info_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_info_estudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_info_estudiantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_info_estudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_info_estudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_estudiantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_info_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info_estudiantes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_info_estudiantes.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_info_estudiantes.EnableHeadersVisualStyles = False
        Me.grid_info_estudiantes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_info_estudiantes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_estudiantes.Location = New System.Drawing.Point(-4, 19)
        Me.grid_info_estudiantes.Name = "grid_info_estudiantes"
        Me.grid_info_estudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_estudiantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_info_estudiantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_info_estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_info_estudiantes.ShowRowErrors = False
        Me.grid_info_estudiantes.Size = New System.Drawing.Size(608, 301)
        Me.grid_info_estudiantes.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_carrera)
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.MetroLabel7)
        Me.tab_mantenimiento.Controls.Add(Me.txt_correo)
        Me.tab_mantenimiento.Controls.Add(Me.label_correo)
        Me.tab_mantenimiento.Controls.Add(Me.txt_celular)
        Me.tab_mantenimiento.Controls.Add(Me.label_celular)
        Me.tab_mantenimiento.Controls.Add(Me.txt_telefono)
        Me.tab_mantenimiento.Controls.Add(Me.label_telefono)
        Me.tab_mantenimiento.Controls.Add(Me.txt_direccion)
        Me.tab_mantenimiento.Controls.Add(Me.label_direccion)
        Me.tab_mantenimiento.Controls.Add(Me.txt_apellido)
        Me.tab_mantenimiento.Controls.Add(Me.label_apellido)
        Me.tab_mantenimiento.Controls.Add(Me.txt_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.label_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.MetroLabel2)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_cedula)
        Me.tab_mantenimiento.Controls.Add(Me.txt_cedula)
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
        Me.btn_salir.Location = New System.Drawing.Point(436, 253)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(98, 40)
        Me.btn_salir.TabIndex = 23
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseSelectable = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_borrar.Enabled = False
        Me.btn_borrar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_borrar.Location = New System.Drawing.Point(332, 253)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(98, 40)
        Me.btn_borrar.TabIndex = 22
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseSelectable = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_modificar.Location = New System.Drawing.Point(228, 253)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(98, 40)
        Me.btn_modificar.TabIndex = 21
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseSelectable = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_agregar.Location = New System.Drawing.Point(124, 253)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(98, 40)
        Me.btn_agregar.TabIndex = 20
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseSelectable = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_buscar.Location = New System.Drawing.Point(20, 253)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 19
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(300, 194)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(113, 25)
        Me.MetroLabel7.TabIndex = 17
        Me.MetroLabel7.Text = "ID de Carrera"
        '
        'txt_correo
        '
        '
        '
        '
        Me.txt_correo.CustomButton.Image = Nothing
        Me.txt_correo.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_correo.CustomButton.Name = ""
        Me.txt_correo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_correo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_correo.CustomButton.TabIndex = 1
        Me.txt_correo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_correo.CustomButton.UseSelectable = True
        Me.txt_correo.CustomButton.Visible = False
        Me.txt_correo.Lines = New String(-1) {}
        Me.txt_correo.Location = New System.Drawing.Point(412, 148)
        Me.txt_correo.MaxLength = 32767
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_correo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_correo.SelectedText = ""
        Me.txt_correo.SelectionLength = 0
        Me.txt_correo.SelectionStart = 0
        Me.txt_correo.ShortcutsEnabled = True
        Me.txt_correo.Size = New System.Drawing.Size(178, 29)
        Me.txt_correo.TabIndex = 16
        Me.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_correo.UseSelectable = True
        Me.txt_correo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_correo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_correo
        '
        Me.label_correo.AutoSize = True
        Me.label_correo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_correo.Location = New System.Drawing.Point(300, 148)
        Me.label_correo.Name = "label_correo"
        Me.label_correo.Size = New System.Drawing.Size(64, 25)
        Me.label_correo.TabIndex = 15
        Me.label_correo.Text = "Correo"
        '
        'txt_celular
        '
        '
        '
        '
        Me.txt_celular.CustomButton.Image = Nothing
        Me.txt_celular.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_celular.CustomButton.Name = ""
        Me.txt_celular.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_celular.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_celular.CustomButton.TabIndex = 1
        Me.txt_celular.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_celular.CustomButton.UseSelectable = True
        Me.txt_celular.CustomButton.Visible = False
        Me.txt_celular.Lines = New String(-1) {}
        Me.txt_celular.Location = New System.Drawing.Point(412, 104)
        Me.txt_celular.MaxLength = 32767
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_celular.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_celular.SelectedText = ""
        Me.txt_celular.SelectionLength = 0
        Me.txt_celular.SelectionStart = 0
        Me.txt_celular.ShortcutsEnabled = True
        Me.txt_celular.Size = New System.Drawing.Size(178, 29)
        Me.txt_celular.TabIndex = 14
        Me.txt_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_celular.UseSelectable = True
        Me.txt_celular.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_celular.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_celular
        '
        Me.label_celular.AutoSize = True
        Me.label_celular.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_celular.Location = New System.Drawing.Point(300, 104)
        Me.label_celular.Name = "label_celular"
        Me.label_celular.Size = New System.Drawing.Size(65, 25)
        Me.label_celular.TabIndex = 13
        Me.label_celular.Text = "Celular"
        '
        'txt_telefono
        '
        '
        '
        '
        Me.txt_telefono.CustomButton.Image = Nothing
        Me.txt_telefono.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_telefono.CustomButton.Name = ""
        Me.txt_telefono.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_telefono.CustomButton.TabIndex = 1
        Me.txt_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_telefono.CustomButton.UseSelectable = True
        Me.txt_telefono.CustomButton.Visible = False
        Me.txt_telefono.Lines = New String(-1) {}
        Me.txt_telefono.Location = New System.Drawing.Point(412, 64)
        Me.txt_telefono.MaxLength = 32767
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_telefono.SelectedText = ""
        Me.txt_telefono.SelectionLength = 0
        Me.txt_telefono.SelectionStart = 0
        Me.txt_telefono.ShortcutsEnabled = True
        Me.txt_telefono.Size = New System.Drawing.Size(178, 29)
        Me.txt_telefono.TabIndex = 12
        Me.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_telefono.UseSelectable = True
        Me.txt_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_telefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_telefono
        '
        Me.label_telefono.AutoSize = True
        Me.label_telefono.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_telefono.Location = New System.Drawing.Point(300, 64)
        Me.label_telefono.Name = "label_telefono"
        Me.label_telefono.Size = New System.Drawing.Size(75, 25)
        Me.label_telefono.TabIndex = 11
        Me.label_telefono.Text = "Telefono"
        '
        'txt_direccion
        '
        '
        '
        '
        Me.txt_direccion.CustomButton.Image = Nothing
        Me.txt_direccion.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_direccion.CustomButton.Name = ""
        Me.txt_direccion.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_direccion.CustomButton.TabIndex = 1
        Me.txt_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_direccion.CustomButton.UseSelectable = True
        Me.txt_direccion.CustomButton.Visible = False
        Me.txt_direccion.Lines = New String(-1) {}
        Me.txt_direccion.Location = New System.Drawing.Point(120, 194)
        Me.txt_direccion.MaxLength = 32767
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_direccion.SelectedText = ""
        Me.txt_direccion.SelectionLength = 0
        Me.txt_direccion.SelectionStart = 0
        Me.txt_direccion.ShortcutsEnabled = True
        Me.txt_direccion.Size = New System.Drawing.Size(178, 29)
        Me.txt_direccion.TabIndex = 10
        Me.txt_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_direccion.UseSelectable = True
        Me.txt_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_direccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_direccion
        '
        Me.label_direccion.AutoSize = True
        Me.label_direccion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_direccion.Location = New System.Drawing.Point(8, 194)
        Me.label_direccion.Name = "label_direccion"
        Me.label_direccion.Size = New System.Drawing.Size(83, 25)
        Me.label_direccion.TabIndex = 9
        Me.label_direccion.Text = "Direccion"
        '
        'txt_apellido
        '
        '
        '
        '
        Me.txt_apellido.CustomButton.Image = Nothing
        Me.txt_apellido.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_apellido.CustomButton.Name = ""
        Me.txt_apellido.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_apellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_apellido.CustomButton.TabIndex = 1
        Me.txt_apellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_apellido.CustomButton.UseSelectable = True
        Me.txt_apellido.CustomButton.Visible = False
        Me.txt_apellido.Lines = New String(-1) {}
        Me.txt_apellido.Location = New System.Drawing.Point(120, 148)
        Me.txt_apellido.MaxLength = 32767
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_apellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_apellido.SelectedText = ""
        Me.txt_apellido.SelectionLength = 0
        Me.txt_apellido.SelectionStart = 0
        Me.txt_apellido.ShortcutsEnabled = True
        Me.txt_apellido.Size = New System.Drawing.Size(178, 29)
        Me.txt_apellido.TabIndex = 8
        Me.txt_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_apellido.UseSelectable = True
        Me.txt_apellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_apellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_apellido
        '
        Me.label_apellido.AutoSize = True
        Me.label_apellido.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_apellido.Location = New System.Drawing.Point(8, 148)
        Me.label_apellido.Name = "label_apellido"
        Me.label_apellido.Size = New System.Drawing.Size(74, 25)
        Me.label_apellido.TabIndex = 7
        Me.label_apellido.Text = "Apellido"
        '
        'txt_nombre
        '
        '
        '
        '
        Me.txt_nombre.CustomButton.Image = Nothing
        Me.txt_nombre.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_nombre.CustomButton.Name = ""
        Me.txt_nombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nombre.CustomButton.TabIndex = 1
        Me.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nombre.CustomButton.UseSelectable = True
        Me.txt_nombre.CustomButton.Visible = False
        Me.txt_nombre.Lines = New String(-1) {}
        Me.txt_nombre.Location = New System.Drawing.Point(120, 104)
        Me.txt_nombre.MaxLength = 32767
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nombre.SelectedText = ""
        Me.txt_nombre.SelectionLength = 0
        Me.txt_nombre.SelectionStart = 0
        Me.txt_nombre.ShortcutsEnabled = True
        Me.txt_nombre.Size = New System.Drawing.Size(178, 29)
        Me.txt_nombre.TabIndex = 6
        Me.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_nombre.UseSelectable = True
        Me.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_nombre
        '
        Me.label_nombre.AutoSize = True
        Me.label_nombre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_nombre.Location = New System.Drawing.Point(8, 104)
        Me.label_nombre.Name = "label_nombre"
        Me.label_nombre.Size = New System.Drawing.Size(75, 25)
        Me.label_nombre.TabIndex = 5
        Me.label_nombre.Text = "Nombre"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(114, 19)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(368, 25)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Mantenimiento al Registro de Estudiantes"
        '
        'label_id_cedula
        '
        Me.label_id_cedula.AutoSize = True
        Me.label_id_cedula.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_cedula.Location = New System.Drawing.Point(8, 64)
        Me.label_id_cedula.Name = "label_id_cedula"
        Me.label_id_cedula.Size = New System.Drawing.Size(110, 25)
        Me.label_id_cedula.TabIndex = 3
        Me.label_id_cedula.Text = "ID de Cedula"
        '
        'txt_cedula
        '
        '
        '
        '
        Me.txt_cedula.CustomButton.Image = Nothing
        Me.txt_cedula.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txt_cedula.CustomButton.Name = ""
        Me.txt_cedula.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_cedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_cedula.CustomButton.TabIndex = 1
        Me.txt_cedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_cedula.CustomButton.UseSelectable = True
        Me.txt_cedula.CustomButton.Visible = False
        Me.txt_cedula.Lines = New String(-1) {}
        Me.txt_cedula.Location = New System.Drawing.Point(120, 64)
        Me.txt_cedula.MaxLength = 32767
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cedula.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cedula.SelectedText = ""
        Me.txt_cedula.SelectionLength = 0
        Me.txt_cedula.SelectionStart = 0
        Me.txt_cedula.ShortcutsEnabled = True
        Me.txt_cedula.Size = New System.Drawing.Size(178, 29)
        Me.txt_cedula.TabIndex = 2
        Me.txt_cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_cedula.UseSelectable = True
        Me.txt_cedula.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_cedula.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_id_carrera
        '
        Me.txt_id_carrera.FormattingEnabled = True
        Me.txt_id_carrera.ItemHeight = 23
        Me.txt_id_carrera.Location = New System.Drawing.Point(412, 194)
        Me.txt_id_carrera.Name = "txt_id_carrera"
        Me.txt_id_carrera.Size = New System.Drawing.Size(178, 29)
        Me.txt_id_carrera.TabIndex = 24
        Me.txt_id_carrera.UseSelectable = True
        '
        'mantenimiento_estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_estudiantes)
        Me.Name = "mantenimiento_estudiantes"
        Me.Text = "Mantenimiento de Estudiantes"
        Me.tab_estudiantes.ResumeLayout(False)
        Me.tab_vista.ResumeLayout(False)
        CType(Me.grid_info_estudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_estudiantes As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_vista As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_info_estudiantes As MetroFramework.Controls.MetroGrid
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_cedula As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_cedula As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_nombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_correo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_correo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_celular As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_celular As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_telefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_telefono As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_direccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_direccion As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_apellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_apellido As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_nombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_id_carrera As MetroFramework.Controls.MetroComboBox
End Class
