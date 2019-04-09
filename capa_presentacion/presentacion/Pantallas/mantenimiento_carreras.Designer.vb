<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_carreras
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
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabControl()
        Me.tab_ver = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.grid_info_carrera = New MetroFramework.Controls.MetroGrid()
        Me.label_titulo = New MetroFramework.Controls.MetroLabel()
        Me.label_id = New MetroFramework.Controls.MetroLabel()
        Me.label_nombre = New MetroFramework.Controls.MetroLabel()
        Me.label_descripcion = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_carrera = New MetroFramework.Controls.MetroTextBox()
        Me.txt_nombre = New MetroFramework.Controls.MetroTextBox()
        Me.txt_descripcion = New MetroFramework.Controls.MetroTextBox()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.tab_mantenimiento.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.grid_info_carrera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.tab_ver)
        Me.tab_mantenimiento.Controls.Add(Me.MetroTabPage2)
        Me.tab_mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_mantenimiento.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tab_mantenimiento.Location = New System.Drawing.Point(20, 60)
        Me.tab_mantenimiento.Name = "tab_mantenimiento"
        Me.tab_mantenimiento.SelectedIndex = 1
        Me.tab_mantenimiento.Size = New System.Drawing.Size(615, 362)
        Me.tab_mantenimiento.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tab_mantenimiento.TabIndex = 0
        Me.tab_mantenimiento.UseSelectable = True
        '
        'tab_ver
        '
        Me.tab_ver.Controls.Add(Me.grid_info_carrera)
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
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.btn_salir)
        Me.MetroTabPage2.Controls.Add(Me.btn_borrar)
        Me.MetroTabPage2.Controls.Add(Me.btn_modificar)
        Me.MetroTabPage2.Controls.Add(Me.btn_agregar)
        Me.MetroTabPage2.Controls.Add(Me.btn_buscar)
        Me.MetroTabPage2.Controls.Add(Me.txt_descripcion)
        Me.MetroTabPage2.Controls.Add(Me.txt_nombre)
        Me.MetroTabPage2.Controls.Add(Me.txt_id_carrera)
        Me.MetroTabPage2.Controls.Add(Me.label_descripcion)
        Me.MetroTabPage2.Controls.Add(Me.label_nombre)
        Me.MetroTabPage2.Controls.Add(Me.label_id)
        Me.MetroTabPage2.Controls.Add(Me.label_titulo)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 44)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(607, 314)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Mantenimiento"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'grid_info_carrera
        '
        Me.grid_info_carrera.AllowUserToResizeRows = False
        Me.grid_info_carrera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_info_carrera.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_carrera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_info_carrera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_info_carrera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_carrera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.grid_info_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_info_carrera.DefaultCellStyle = DataGridViewCellStyle17
        Me.grid_info_carrera.EnableHeadersVisualStyles = False
        Me.grid_info_carrera.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_info_carrera.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_info_carrera.Location = New System.Drawing.Point(-4, 13)
        Me.grid_info_carrera.Name = "grid_info_carrera"
        Me.grid_info_carrera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_info_carrera.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.grid_info_carrera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid_info_carrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_info_carrera.Size = New System.Drawing.Size(608, 260)
        Me.grid_info_carrera.TabIndex = 2
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_titulo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_titulo.Location = New System.Drawing.Point(176, 21)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(244, 25)
        Me.label_titulo.TabIndex = 2
        Me.label_titulo.Text = "Mantenimiento de Carreras"
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id.Location = New System.Drawing.Point(18, 67)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(113, 25)
        Me.label_id.TabIndex = 3
        Me.label_id.Text = "ID de Carrera"
        '
        'label_nombre
        '
        Me.label_nombre.AutoSize = True
        Me.label_nombre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_nombre.Location = New System.Drawing.Point(18, 115)
        Me.label_nombre.Name = "label_nombre"
        Me.label_nombre.Size = New System.Drawing.Size(178, 25)
        Me.label_nombre.TabIndex = 4
        Me.label_nombre.Text = "Nombre de la Carrera"
        '
        'label_descripcion
        '
        Me.label_descripcion.AutoSize = True
        Me.label_descripcion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_descripcion.Location = New System.Drawing.Point(18, 165)
        Me.label_descripcion.Name = "label_descripcion"
        Me.label_descripcion.Size = New System.Drawing.Size(203, 25)
        Me.label_descripcion.TabIndex = 5
        Me.label_descripcion.Text = "Descripcion de la Carrera"
        '
        'txt_id_carrera
        '
        '
        '
        '
        Me.txt_id_carrera.CustomButton.Image = Nothing
        Me.txt_id_carrera.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txt_id_carrera.CustomButton.Name = ""
        Me.txt_id_carrera.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_carrera.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_carrera.CustomButton.TabIndex = 1
        Me.txt_id_carrera.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_carrera.CustomButton.UseSelectable = True
        Me.txt_id_carrera.CustomButton.Visible = False
        Me.txt_id_carrera.Lines = New String(-1) {}
        Me.txt_id_carrera.Location = New System.Drawing.Point(279, 67)
        Me.txt_id_carrera.MaxLength = 32767
        Me.txt_id_carrera.Name = "txt_id_carrera"
        Me.txt_id_carrera.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_carrera.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_carrera.SelectedText = ""
        Me.txt_id_carrera.SelectionLength = 0
        Me.txt_id_carrera.SelectionStart = 0
        Me.txt_id_carrera.ShortcutsEnabled = True
        Me.txt_id_carrera.Size = New System.Drawing.Size(224, 29)
        Me.txt_id_carrera.TabIndex = 6
        Me.txt_id_carrera.UseSelectable = True
        Me.txt_id_carrera.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_carrera.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_nombre
        '
        '
        '
        '
        Me.txt_nombre.CustomButton.Image = Nothing
        Me.txt_nombre.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txt_nombre.CustomButton.Name = ""
        Me.txt_nombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nombre.CustomButton.TabIndex = 1
        Me.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nombre.CustomButton.UseSelectable = True
        Me.txt_nombre.CustomButton.Visible = False
        Me.txt_nombre.Lines = New String(-1) {}
        Me.txt_nombre.Location = New System.Drawing.Point(279, 115)
        Me.txt_nombre.MaxLength = 32767
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nombre.SelectedText = ""
        Me.txt_nombre.SelectionLength = 0
        Me.txt_nombre.SelectionStart = 0
        Me.txt_nombre.ShortcutsEnabled = True
        Me.txt_nombre.Size = New System.Drawing.Size(224, 29)
        Me.txt_nombre.TabIndex = 7
        Me.txt_nombre.UseSelectable = True
        Me.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_descripcion
        '
        '
        '
        '
        Me.txt_descripcion.CustomButton.Image = Nothing
        Me.txt_descripcion.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txt_descripcion.CustomButton.Name = ""
        Me.txt_descripcion.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_descripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_descripcion.CustomButton.TabIndex = 1
        Me.txt_descripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_descripcion.CustomButton.UseSelectable = True
        Me.txt_descripcion.CustomButton.Visible = False
        Me.txt_descripcion.Lines = New String(-1) {}
        Me.txt_descripcion.Location = New System.Drawing.Point(279, 165)
        Me.txt_descripcion.MaxLength = 32767
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_descripcion.SelectedText = ""
        Me.txt_descripcion.SelectionLength = 0
        Me.txt_descripcion.SelectionStart = 0
        Me.txt_descripcion.ShortcutsEnabled = True
        Me.txt_descripcion.Size = New System.Drawing.Size(224, 29)
        Me.txt_descripcion.TabIndex = 8
        Me.txt_descripcion.UseSelectable = True
        Me.txt_descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_descripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_salir
        '
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_salir.Location = New System.Drawing.Point(435, 231)
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
        Me.btn_borrar.Location = New System.Drawing.Point(331, 231)
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
        Me.btn_modificar.Location = New System.Drawing.Point(227, 231)
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
        Me.btn_agregar.Location = New System.Drawing.Point(123, 231)
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
        Me.btn_buscar.Location = New System.Drawing.Point(19, 231)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 24
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'mantenimiento_carreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_mantenimiento)
        Me.Name = "mantenimiento_carreras"
        Me.Text = "Mantenimiento de Carreras"
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.grid_info_carrera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_info_carrera As MetroFramework.Controls.MetroGrid
    Friend WithEvents label_descripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_nombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_titulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_descripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_nombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_id_carrera As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
End Class
