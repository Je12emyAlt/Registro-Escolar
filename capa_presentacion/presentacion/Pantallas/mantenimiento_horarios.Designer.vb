<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_horarios
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_control = New MetroFramework.Controls.MetroTabControl()
        Me.tab_ver = New MetroFramework.Controls.MetroTabPage()
        Me.grid_horarios = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.txt_dia = New MetroFramework.Controls.MetroComboBox()
        Me.txt_hora = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_horario = New MetroFramework.Controls.MetroTextBox()
        Me.txt_id_sede = New MetroFramework.Controls.MetroComboBox()
        Me.txt_id_carrera = New MetroFramework.Controls.MetroComboBox()
        Me.label_id_sede = New MetroFramework.Controls.MetroLabel()
        Me.label_id_carrera = New MetroFramework.Controls.MetroLabel()
        Me.label_horario = New MetroFramework.Controls.MetroLabel()
        Me.label_titulo = New MetroFramework.Controls.MetroLabel()
        Me.tab_control.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        CType(Me.grid_horarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tab_control.TabIndex = 0
        Me.tab_control.UseSelectable = True
        '
        'tab_ver
        '
        Me.tab_ver.Controls.Add(Me.grid_horarios)
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
        'grid_horarios
        '
        Me.grid_horarios.AllowUserToResizeRows = False
        Me.grid_horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_horarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_horarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_horarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_horarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_horarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_horarios.DefaultCellStyle = DataGridViewCellStyle8
        Me.grid_horarios.EnableHeadersVisualStyles = False
        Me.grid_horarios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_horarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_horarios.Location = New System.Drawing.Point(4, 13)
        Me.grid_horarios.Name = "grid_horarios"
        Me.grid_horarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_horarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grid_horarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_horarios.Size = New System.Drawing.Size(600, 305)
        Me.grid_horarios.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.txt_dia)
        Me.tab_mantenimiento.Controls.Add(Me.txt_hora)
        Me.tab_mantenimiento.Controls.Add(Me.MetroLabel7)
        Me.tab_mantenimiento.Controls.Add(Me.MetroLabel6)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_horario)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_sede)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_carrera)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_sede)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_carrera)
        Me.tab_mantenimiento.Controls.Add(Me.label_horario)
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
        Me.btn_salir.Location = New System.Drawing.Point(455, 245)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(98, 40)
        Me.btn_salir.TabIndex = 38
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseSelectable = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_borrar.Enabled = False
        Me.btn_borrar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_borrar.Location = New System.Drawing.Point(351, 245)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(98, 40)
        Me.btn_borrar.TabIndex = 37
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseSelectable = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_modificar.Location = New System.Drawing.Point(247, 245)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(98, 40)
        Me.btn_modificar.TabIndex = 36
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseSelectable = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_agregar.Location = New System.Drawing.Point(143, 245)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(98, 40)
        Me.btn_agregar.TabIndex = 35
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseSelectable = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn_buscar.Location = New System.Drawing.Point(39, 245)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 34
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'txt_dia
        '
        Me.txt_dia.FormattingEnabled = True
        Me.txt_dia.ItemHeight = 23
        Me.txt_dia.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.txt_dia.Location = New System.Drawing.Point(178, 149)
        Me.txt_dia.Name = "txt_dia"
        Me.txt_dia.Size = New System.Drawing.Size(147, 29)
        Me.txt_dia.TabIndex = 14
        Me.txt_dia.UseSelectable = True
        '
        'txt_hora
        '
        '
        '
        '
        Me.txt_hora.CustomButton.Image = Nothing
        Me.txt_hora.CustomButton.Location = New System.Drawing.Point(119, 1)
        Me.txt_hora.CustomButton.Name = ""
        Me.txt_hora.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_hora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_hora.CustomButton.TabIndex = 1
        Me.txt_hora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_hora.CustomButton.UseSelectable = True
        Me.txt_hora.CustomButton.Visible = False
        Me.txt_hora.Lines = New String(-1) {}
        Me.txt_hora.Location = New System.Drawing.Point(178, 199)
        Me.txt_hora.MaxLength = 32767
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_hora.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_hora.SelectedText = ""
        Me.txt_hora.SelectionLength = 0
        Me.txt_hora.SelectionStart = 0
        Me.txt_hora.ShortcutsEnabled = True
        Me.txt_hora.Size = New System.Drawing.Size(147, 29)
        Me.txt_hora.TabIndex = 13
        Me.txt_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_hora.UseSelectable = True
        Me.txt_hora.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_hora.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(57, 196)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(49, 25)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Hora"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(57, 149)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(37, 25)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Dia"
        '
        'txt_id_horario
        '
        '
        '
        '
        Me.txt_id_horario.CustomButton.Image = Nothing
        Me.txt_id_horario.CustomButton.Location = New System.Drawing.Point(119, 1)
        Me.txt_id_horario.CustomButton.Name = ""
        Me.txt_id_horario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_horario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_horario.CustomButton.TabIndex = 1
        Me.txt_id_horario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_horario.CustomButton.UseSelectable = True
        Me.txt_id_horario.CustomButton.Visible = False
        Me.txt_id_horario.Lines = New String(-1) {}
        Me.txt_id_horario.Location = New System.Drawing.Point(178, 57)
        Me.txt_id_horario.MaxLength = 32767
        Me.txt_id_horario.Name = "txt_id_horario"
        Me.txt_id_horario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_horario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_horario.SelectedText = ""
        Me.txt_id_horario.SelectionLength = 0
        Me.txt_id_horario.SelectionStart = 0
        Me.txt_id_horario.ShortcutsEnabled = True
        Me.txt_id_horario.Size = New System.Drawing.Size(147, 29)
        Me.txt_id_horario.TabIndex = 9
        Me.txt_id_horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id_horario.UseSelectable = True
        Me.txt_id_horario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_horario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_id_sede
        '
        Me.txt_id_sede.FormattingEnabled = True
        Me.txt_id_sede.ItemHeight = 23
        Me.txt_id_sede.Location = New System.Drawing.Point(441, 57)
        Me.txt_id_sede.Name = "txt_id_sede"
        Me.txt_id_sede.Size = New System.Drawing.Size(121, 29)
        Me.txt_id_sede.TabIndex = 8
        Me.txt_id_sede.UseSelectable = True
        '
        'txt_id_carrera
        '
        Me.txt_id_carrera.FormattingEnabled = True
        Me.txt_id_carrera.ItemHeight = 23
        Me.txt_id_carrera.Location = New System.Drawing.Point(178, 99)
        Me.txt_id_carrera.Name = "txt_id_carrera"
        Me.txt_id_carrera.Size = New System.Drawing.Size(147, 29)
        Me.txt_id_carrera.TabIndex = 7
        Me.txt_id_carrera.UseSelectable = True
        '
        'label_id_sede
        '
        Me.label_id_sede.AutoSize = True
        Me.label_id_sede.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_sede.Location = New System.Drawing.Point(340, 54)
        Me.label_id_sede.Name = "label_id_sede"
        Me.label_id_sede.Size = New System.Drawing.Size(94, 25)
        Me.label_id_sede.TabIndex = 6
        Me.label_id_sede.Text = "ID de Sede"
        '
        'label_id_carrera
        '
        Me.label_id_carrera.AutoSize = True
        Me.label_id_carrera.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_carrera.Location = New System.Drawing.Point(57, 106)
        Me.label_id_carrera.Name = "label_id_carrera"
        Me.label_id_carrera.Size = New System.Drawing.Size(113, 25)
        Me.label_id_carrera.TabIndex = 4
        Me.label_id_carrera.Text = "ID de Carrera"
        '
        'label_horario
        '
        Me.label_horario.AutoSize = True
        Me.label_horario.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_horario.Location = New System.Drawing.Point(57, 54)
        Me.label_horario.Name = "label_horario"
        Me.label_horario.Size = New System.Drawing.Size(114, 25)
        Me.label_horario.TabIndex = 3
        Me.label_horario.Text = "ID de Horario"
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_titulo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_titulo.Location = New System.Drawing.Point(196, 14)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(247, 25)
        Me.label_titulo.TabIndex = 2
        Me.label_titulo.Text = "Mantenimiento de Horarios"
        '
        'mantenimiento_horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "mantenimiento_horarios"
        Me.Text = "Mantenimiento de Horarios"
        Me.tab_control.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        CType(Me.grid_horarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_control As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_horarios As MetroFramework.Controls.MetroGrid
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_dia As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_hora As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_id_horario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_id_sede As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_id_carrera As MetroFramework.Controls.MetroComboBox
    Friend WithEvents label_id_sede As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_carrera As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_horario As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_titulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
End Class
