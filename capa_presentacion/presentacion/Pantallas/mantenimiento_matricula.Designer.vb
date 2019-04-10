<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_matricula
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
        Me.grid_matricula = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.txt_id_curso = New MetroFramework.Controls.MetroComboBox()
        Me.txt_id_cedula = New MetroFramework.Controls.MetroComboBox()
        Me.txt_cuatrimestre = New MetroFramework.Controls.MetroTextBox()
        Me.txt_año = New MetroFramework.Controls.MetroTextBox()
        Me.label_cuatrimestre = New MetroFramework.Controls.MetroLabel()
        Me.txt_id_matricula = New MetroFramework.Controls.MetroTextBox()
        Me.label_año = New MetroFramework.Controls.MetroLabel()
        Me.label_id_curso = New MetroFramework.Controls.MetroLabel()
        Me.label_id_cedula = New MetroFramework.Controls.MetroLabel()
        Me.label_id_matricula = New MetroFramework.Controls.MetroLabel()
        Me.label_titulo = New MetroFramework.Controls.MetroLabel()
        Me.tab_control.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        CType(Me.grid_matricula, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tab_ver.Controls.Add(Me.grid_matricula)
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
        'grid_matricula
        '
        Me.grid_matricula.AllowUserToResizeRows = False
        Me.grid_matricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_matricula.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_matricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_matricula.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_matricula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_matricula.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_matricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_matricula.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_matricula.EnableHeadersVisualStyles = False
        Me.grid_matricula.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_matricula.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_matricula.Location = New System.Drawing.Point(0, 15)
        Me.grid_matricula.Name = "grid_matricula"
        Me.grid_matricula.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_matricula.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_matricula.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_matricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_matricula.Size = New System.Drawing.Size(604, 296)
        Me.grid_matricula.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_curso)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_cedula)
        Me.tab_mantenimiento.Controls.Add(Me.txt_cuatrimestre)
        Me.tab_mantenimiento.Controls.Add(Me.txt_año)
        Me.tab_mantenimiento.Controls.Add(Me.label_cuatrimestre)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_matricula)
        Me.tab_mantenimiento.Controls.Add(Me.label_año)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_curso)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_cedula)
        Me.tab_mantenimiento.Controls.Add(Me.label_id_matricula)
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
        Me.btn_salir.Location = New System.Drawing.Point(429, 229)
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
        Me.btn_borrar.Location = New System.Drawing.Point(325, 229)
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
        Me.btn_modificar.Location = New System.Drawing.Point(221, 229)
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
        Me.btn_agregar.Location = New System.Drawing.Point(117, 229)
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
        Me.btn_buscar.Location = New System.Drawing.Point(13, 229)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 29
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'txt_id_curso
        '
        Me.txt_id_curso.FormattingEnabled = True
        Me.txt_id_curso.ItemHeight = 23
        Me.txt_id_curso.Location = New System.Drawing.Point(409, 86)
        Me.txt_id_curso.Name = "txt_id_curso"
        Me.txt_id_curso.Size = New System.Drawing.Size(183, 29)
        Me.txt_id_curso.TabIndex = 12
        Me.txt_id_curso.UseSelectable = True
        '
        'txt_id_cedula
        '
        Me.txt_id_cedula.FormattingEnabled = True
        Me.txt_id_cedula.ItemHeight = 23
        Me.txt_id_cedula.Location = New System.Drawing.Point(117, 124)
        Me.txt_id_cedula.Name = "txt_id_cedula"
        Me.txt_id_cedula.Size = New System.Drawing.Size(182, 29)
        Me.txt_id_cedula.TabIndex = 11
        Me.txt_id_cedula.UseSelectable = True
        '
        'txt_cuatrimestre
        '
        '
        '
        '
        Me.txt_cuatrimestre.CustomButton.Image = Nothing
        Me.txt_cuatrimestre.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.txt_cuatrimestre.CustomButton.Name = ""
        Me.txt_cuatrimestre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_cuatrimestre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_cuatrimestre.CustomButton.TabIndex = 1
        Me.txt_cuatrimestre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_cuatrimestre.CustomButton.UseSelectable = True
        Me.txt_cuatrimestre.CustomButton.Visible = False
        Me.txt_cuatrimestre.Lines = New String(-1) {}
        Me.txt_cuatrimestre.Location = New System.Drawing.Point(409, 156)
        Me.txt_cuatrimestre.MaxLength = 32767
        Me.txt_cuatrimestre.Name = "txt_cuatrimestre"
        Me.txt_cuatrimestre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cuatrimestre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cuatrimestre.SelectedText = ""
        Me.txt_cuatrimestre.SelectionLength = 0
        Me.txt_cuatrimestre.SelectionStart = 0
        Me.txt_cuatrimestre.ShortcutsEnabled = True
        Me.txt_cuatrimestre.Size = New System.Drawing.Size(183, 29)
        Me.txt_cuatrimestre.TabIndex = 10
        Me.txt_cuatrimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_cuatrimestre.UseSelectable = True
        Me.txt_cuatrimestre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_cuatrimestre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_año
        '
        '
        '
        '
        Me.txt_año.CustomButton.Image = Nothing
        Me.txt_año.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.txt_año.CustomButton.Name = ""
        Me.txt_año.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_año.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_año.CustomButton.TabIndex = 1
        Me.txt_año.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_año.CustomButton.UseSelectable = True
        Me.txt_año.CustomButton.Visible = False
        Me.txt_año.Lines = New String(-1) {}
        Me.txt_año.Location = New System.Drawing.Point(409, 121)
        Me.txt_año.MaxLength = 32767
        Me.txt_año.Name = "txt_año"
        Me.txt_año.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_año.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_año.SelectedText = ""
        Me.txt_año.SelectionLength = 0
        Me.txt_año.SelectionStart = 0
        Me.txt_año.ShortcutsEnabled = True
        Me.txt_año.Size = New System.Drawing.Size(183, 29)
        Me.txt_año.TabIndex = 9
        Me.txt_año.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_año.UseSelectable = True
        Me.txt_año.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_año.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_cuatrimestre
        '
        Me.label_cuatrimestre.AutoSize = True
        Me.label_cuatrimestre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_cuatrimestre.Location = New System.Drawing.Point(300, 159)
        Me.label_cuatrimestre.Name = "label_cuatrimestre"
        Me.label_cuatrimestre.Size = New System.Drawing.Size(108, 25)
        Me.label_cuatrimestre.TabIndex = 8
        Me.label_cuatrimestre.Text = "Cuatrimestre"
        '
        'txt_id_matricula
        '
        '
        '
        '
        Me.txt_id_matricula.CustomButton.Image = Nothing
        Me.txt_id_matricula.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.txt_id_matricula.CustomButton.Name = ""
        Me.txt_id_matricula.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_matricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_matricula.CustomButton.TabIndex = 1
        Me.txt_id_matricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_matricula.CustomButton.UseSelectable = True
        Me.txt_id_matricula.CustomButton.Visible = False
        Me.txt_id_matricula.Lines = New String(-1) {}
        Me.txt_id_matricula.Location = New System.Drawing.Point(117, 86)
        Me.txt_id_matricula.MaxLength = 32767
        Me.txt_id_matricula.Name = "txt_id_matricula"
        Me.txt_id_matricula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_matricula.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_matricula.SelectedText = ""
        Me.txt_id_matricula.SelectionLength = 0
        Me.txt_id_matricula.SelectionStart = 0
        Me.txt_id_matricula.ShortcutsEnabled = True
        Me.txt_id_matricula.Size = New System.Drawing.Size(182, 29)
        Me.txt_id_matricula.TabIndex = 7
        Me.txt_id_matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id_matricula.UseSelectable = True
        Me.txt_id_matricula.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_matricula.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_año
        '
        Me.label_año.AutoSize = True
        Me.label_año.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_año.Location = New System.Drawing.Point(301, 125)
        Me.label_año.Name = "label_año"
        Me.label_año.Size = New System.Drawing.Size(43, 25)
        Me.label_año.TabIndex = 6
        Me.label_año.Text = "Año"
        '
        'label_id_curso
        '
        Me.label_id_curso.AutoSize = True
        Me.label_id_curso.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_curso.Location = New System.Drawing.Point(302, 85)
        Me.label_id_curso.Name = "label_id_curso"
        Me.label_id_curso.Size = New System.Drawing.Size(101, 25)
        Me.label_id_curso.TabIndex = 5
        Me.label_id_curso.Text = "ID de Curso"
        '
        'label_id_cedula
        '
        Me.label_id_cedula.AutoSize = True
        Me.label_id_cedula.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_cedula.Location = New System.Drawing.Point(-5, 126)
        Me.label_id_cedula.Name = "label_id_cedula"
        Me.label_id_cedula.Size = New System.Drawing.Size(110, 25)
        Me.label_id_cedula.TabIndex = 4
        Me.label_id_cedula.Text = "ID de Cedula"
        '
        'label_id_matricula
        '
        Me.label_id_matricula.AutoSize = True
        Me.label_id_matricula.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id_matricula.Location = New System.Drawing.Point(-5, 83)
        Me.label_id_matricula.Name = "label_id_matricula"
        Me.label_id_matricula.Size = New System.Drawing.Size(127, 25)
        Me.label_id_matricula.TabIndex = 3
        Me.label_id_matricula.Text = "ID de Matricula"
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_titulo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_titulo.Location = New System.Drawing.Point(194, 25)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(255, 25)
        Me.label_titulo.TabIndex = 2
        Me.label_titulo.Text = "Mantenimiento de Matricula"
        '
        'mantenimiento_matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "mantenimiento_matricula"
        Me.Text = "Mantenimiento de Matricula"
        Me.tab_control.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        CType(Me.grid_matricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_control As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_matricula As MetroFramework.Controls.MetroGrid
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_id_curso As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_id_cedula As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_cuatrimestre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_año As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_cuatrimestre As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_id_matricula As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_año As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_curso As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_cedula As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id_matricula As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_titulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
End Class
