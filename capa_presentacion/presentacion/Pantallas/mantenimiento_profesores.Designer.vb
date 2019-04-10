<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_profesores
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
        Me.tab_control = New MetroFramework.Controls.MetroTabControl()
        Me.tab_ver = New MetroFramework.Controls.MetroTabPage()
        Me.grid_profesores = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.txt_telefono = New MetroFramework.Controls.MetroTextBox()
        Me.txt_correo = New MetroFramework.Controls.MetroTextBox()
        Me.txt_apellido = New MetroFramework.Controls.MetroTextBox()
        Me.txt_nombre = New MetroFramework.Controls.MetroTextBox()
        Me.txt_id_profesor = New MetroFramework.Controls.MetroTextBox()
        Me.label_telefono = New MetroFramework.Controls.MetroLabel()
        Me.label_correo = New MetroFramework.Controls.MetroLabel()
        Me.label_apellido = New MetroFramework.Controls.MetroLabel()
        Me.label_nombre = New MetroFramework.Controls.MetroLabel()
        Me.label_id_profesor = New MetroFramework.Controls.MetroLabel()
        Me.label_titulo = New MetroFramework.Controls.MetroLabel()
        Me.tab_control.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        CType(Me.grid_profesores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tab_ver.Controls.Add(Me.grid_profesores)
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
        'grid_profesores
        '
        Me.grid_profesores.AllowUserToResizeRows = False
        Me.grid_profesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_profesores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_profesores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_profesores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_profesores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_profesores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_profesores.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_profesores.EnableHeadersVisualStyles = False
        Me.grid_profesores.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_profesores.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_profesores.Location = New System.Drawing.Point(4, 16)
        Me.grid_profesores.Name = "grid_profesores"
        Me.grid_profesores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_profesores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_profesores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_profesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_profesores.Size = New System.Drawing.Size(600, 286)
        Me.grid_profesores.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.txt_telefono)
        Me.tab_mantenimiento.Controls.Add(Me.txt_correo)
        Me.tab_mantenimiento.Controls.Add(Me.txt_apellido)
        Me.tab_mantenimiento.Controls.Add(Me.txt_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_profesor)
        Me.tab_mantenimiento.Controls.Add(Me.label_telefono)
        Me.tab_mantenimiento.Controls.Add(Me.label_correo)
        Me.tab_mantenimiento.Controls.Add(Me.label_apellido)
        Me.tab_mantenimiento.Controls.Add(Me.label_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_profesor)
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
        'btn_salir
        '
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_salir.Location = New System.Drawing.Point(428, 236)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(98, 40)
        Me.btn_salir.TabIndex = 33
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseSelectable = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_borrar.Enabled = False
        Me.btn_borrar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_borrar.Location = New System.Drawing.Point(324, 236)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(98, 40)
        Me.btn_borrar.TabIndex = 32
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseSelectable = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_modificar.Location = New System.Drawing.Point(220, 236)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(98, 40)
        Me.btn_modificar.TabIndex = 31
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseSelectable = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_agregar.Location = New System.Drawing.Point(116, 236)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(98, 40)
        Me.btn_agregar.TabIndex = 30
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseSelectable = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_buscar.Location = New System.Drawing.Point(12, 236)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 29
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'txt_telefono
        '
        '
        '
        '
        Me.txt_telefono.CustomButton.Image = Nothing
        Me.txt_telefono.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_telefono.CustomButton.Name = ""
        Me.txt_telefono.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_telefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_telefono.CustomButton.TabIndex = 1
        Me.txt_telefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_telefono.CustomButton.UseSelectable = True
        Me.txt_telefono.CustomButton.Visible = False
        Me.txt_telefono.Lines = New String(-1) {}
        Me.txt_telefono.Location = New System.Drawing.Point(407, 167)
        Me.txt_telefono.MaxLength = 32767
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_telefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_telefono.SelectedText = ""
        Me.txt_telefono.SelectionLength = 0
        Me.txt_telefono.SelectionStart = 0
        Me.txt_telefono.ShortcutsEnabled = True
        Me.txt_telefono.Size = New System.Drawing.Size(185, 29)
        Me.txt_telefono.TabIndex = 12
        Me.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_telefono.UseSelectable = True
        Me.txt_telefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_telefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_correo
        '
        '
        '
        '
        Me.txt_correo.CustomButton.Image = Nothing
        Me.txt_correo.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_correo.CustomButton.Name = ""
        Me.txt_correo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_correo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_correo.CustomButton.TabIndex = 1
        Me.txt_correo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_correo.CustomButton.UseSelectable = True
        Me.txt_correo.CustomButton.Visible = False
        Me.txt_correo.Lines = New String(-1) {}
        Me.txt_correo.Location = New System.Drawing.Point(407, 115)
        Me.txt_correo.MaxLength = 32767
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_correo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_correo.SelectedText = ""
        Me.txt_correo.SelectionLength = 0
        Me.txt_correo.SelectionStart = 0
        Me.txt_correo.ShortcutsEnabled = True
        Me.txt_correo.Size = New System.Drawing.Size(185, 29)
        Me.txt_correo.TabIndex = 11
        Me.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_correo.UseSelectable = True
        Me.txt_correo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_correo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_apellido
        '
        '
        '
        '
        Me.txt_apellido.CustomButton.Image = Nothing
        Me.txt_apellido.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_apellido.CustomButton.Name = ""
        Me.txt_apellido.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_apellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_apellido.CustomButton.TabIndex = 1
        Me.txt_apellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_apellido.CustomButton.UseSelectable = True
        Me.txt_apellido.CustomButton.Visible = False
        Me.txt_apellido.Lines = New String(-1) {}
        Me.txt_apellido.Location = New System.Drawing.Point(133, 163)
        Me.txt_apellido.MaxLength = 32767
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_apellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_apellido.SelectedText = ""
        Me.txt_apellido.SelectionLength = 0
        Me.txt_apellido.SelectionStart = 0
        Me.txt_apellido.ShortcutsEnabled = True
        Me.txt_apellido.Size = New System.Drawing.Size(185, 29)
        Me.txt_apellido.TabIndex = 10
        Me.txt_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_apellido.UseSelectable = True
        Me.txt_apellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_apellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_nombre
        '
        '
        '
        '
        Me.txt_nombre.CustomButton.Image = Nothing
        Me.txt_nombre.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_nombre.CustomButton.Name = ""
        Me.txt_nombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nombre.CustomButton.TabIndex = 1
        Me.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nombre.CustomButton.UseSelectable = True
        Me.txt_nombre.CustomButton.Visible = False
        Me.txt_nombre.Lines = New String(-1) {}
        Me.txt_nombre.Location = New System.Drawing.Point(133, 114)
        Me.txt_nombre.MaxLength = 32767
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nombre.SelectedText = ""
        Me.txt_nombre.SelectionLength = 0
        Me.txt_nombre.SelectionStart = 0
        Me.txt_nombre.ShortcutsEnabled = True
        Me.txt_nombre.Size = New System.Drawing.Size(185, 29)
        Me.txt_nombre.TabIndex = 9
        Me.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_nombre.UseSelectable = True
        Me.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_id_profesor
        '
        '
        '
        '
        Me.txt_id_profesor.CustomButton.Image = Nothing
        Me.txt_id_profesor.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_id_profesor.CustomButton.Name = ""
        Me.txt_id_profesor.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_profesor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_profesor.CustomButton.TabIndex = 1
        Me.txt_id_profesor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_profesor.CustomButton.UseSelectable = True
        Me.txt_id_profesor.CustomButton.Visible = False
        Me.txt_id_profesor.Lines = New String(-1) {}
        Me.txt_id_profesor.Location = New System.Drawing.Point(133, 69)
        Me.txt_id_profesor.MaxLength = 32767
        Me.txt_id_profesor.Name = "txt_id_profesor"
        Me.txt_id_profesor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_profesor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_profesor.SelectedText = ""
        Me.txt_id_profesor.SelectionLength = 0
        Me.txt_id_profesor.SelectionStart = 0
        Me.txt_id_profesor.ShortcutsEnabled = True
        Me.txt_id_profesor.Size = New System.Drawing.Size(185, 29)
        Me.txt_id_profesor.TabIndex = 8
        Me.txt_id_profesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id_profesor.UseSelectable = True
        Me.txt_id_profesor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_profesor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_telefono
        '
        Me.label_telefono.AutoSize = True
        Me.label_telefono.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_telefono.Location = New System.Drawing.Point(334, 167)
        Me.label_telefono.Name = "label_telefono"
        Me.label_telefono.Size = New System.Drawing.Size(75, 25)
        Me.label_telefono.TabIndex = 7
        Me.label_telefono.Text = "Telefono"
        '
        'label_correo
        '
        Me.label_correo.AutoSize = True
        Me.label_correo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_correo.Location = New System.Drawing.Point(337, 114)
        Me.label_correo.Name = "label_correo"
        Me.label_correo.Size = New System.Drawing.Size(64, 25)
        Me.label_correo.TabIndex = 6
        Me.label_correo.Text = "Correo"
        '
        'label_apellido
        '
        Me.label_apellido.AutoSize = True
        Me.label_apellido.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_apellido.Location = New System.Drawing.Point(3, 167)
        Me.label_apellido.Name = "label_apellido"
        Me.label_apellido.Size = New System.Drawing.Size(74, 25)
        Me.label_apellido.TabIndex = 5
        Me.label_apellido.Text = "Apellido"
        '
        'label_nombre
        '
        Me.label_nombre.AutoSize = True
        Me.label_nombre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_nombre.Location = New System.Drawing.Point(3, 116)
        Me.label_nombre.Name = "label_nombre"
        Me.label_nombre.Size = New System.Drawing.Size(75, 25)
        Me.label_nombre.TabIndex = 4
        Me.label_nombre.Text = "Nombre"
        '
        'label_id_profesor
        '
        Me.label_id_profesor.AutoSize = True
        Me.label_id_profesor.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_profesor.Location = New System.Drawing.Point(3, 69)
        Me.label_id_profesor.Name = "label_id_profesor"
        Me.label_id_profesor.Size = New System.Drawing.Size(120, 25)
        Me.label_id_profesor.TabIndex = 3
        Me.label_id_profesor.Text = "ID de Profesor"
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_titulo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_titulo.Location = New System.Drawing.Point(145, 23)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(264, 25)
        Me.label_titulo.TabIndex = 2
        Me.label_titulo.Text = "Mantenimiento de Profesores"
        '
        'mantenimiento_profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "mantenimiento_profesores"
        Me.Text = "Mantenimiento de Profesores"
        Me.tab_control.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        CType(Me.grid_profesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_control As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_profesores As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_telefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_correo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_apellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_nombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_id_profesor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_telefono As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_correo As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_apellido As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_nombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_profesor As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_titulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
End Class
