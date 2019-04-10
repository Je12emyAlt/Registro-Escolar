<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimiento_sedes
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
        Me.grid_sede = New MetroFramework.Controls.MetroGrid()
        Me.tab_mantenimiento = New MetroFramework.Controls.MetroTabPage()
        Me.btn_salir = New MetroFramework.Controls.MetroButton()
        Me.btn_borrar = New MetroFramework.Controls.MetroButton()
        Me.btn_modificar = New MetroFramework.Controls.MetroButton()
        Me.btn_agregar = New MetroFramework.Controls.MetroButton()
        Me.btn_buscar = New MetroFramework.Controls.MetroButton()
        Me.txt_direccion = New MetroFramework.Controls.MetroTextBox()
        Me.txt_descripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txt_nombre = New MetroFramework.Controls.MetroTextBox()
        Me.txt_id_sede = New MetroFramework.Controls.MetroTextBox()
        Me.label_direccion = New MetroFramework.Controls.MetroLabel()
        Me.label_descripcion = New MetroFramework.Controls.MetroLabel()
        Me.label_nombre = New MetroFramework.Controls.MetroLabel()
        Me.label_id = New MetroFramework.Controls.MetroLabel()
        Me.label_titulo = New MetroFramework.Controls.MetroLabel()
        Me.tab_control.SuspendLayout()
        Me.tab_ver.SuspendLayout()
        CType(Me.grid_sede, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tab_ver.Controls.Add(Me.grid_sede)
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
        'grid_sede
        '
        Me.grid_sede.AllowUserToResizeRows = False
        Me.grid_sede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_sede.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_sede.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_sede.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_sede.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_sede.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_sede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_sede.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_sede.EnableHeadersVisualStyles = False
        Me.grid_sede.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grid_sede.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid_sede.Location = New System.Drawing.Point(4, 14)
        Me.grid_sede.Name = "grid_sede"
        Me.grid_sede.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_sede.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_sede.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_sede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_sede.Size = New System.Drawing.Size(600, 304)
        Me.grid_sede.TabIndex = 2
        '
        'tab_mantenimiento
        '
        Me.tab_mantenimiento.Controls.Add(Me.btn_salir)
        Me.tab_mantenimiento.Controls.Add(Me.btn_borrar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_modificar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_agregar)
        Me.tab_mantenimiento.Controls.Add(Me.btn_buscar)
        Me.tab_mantenimiento.Controls.Add(Me.txt_direccion)
        Me.tab_mantenimiento.Controls.Add(Me.txt_descripcion)
        Me.tab_mantenimiento.Controls.Add(Me.txt_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.txt_id_sede)
        Me.tab_mantenimiento.Controls.Add(Me.label_direccion)
        Me.tab_mantenimiento.Controls.Add(Me.label_descripcion)
        Me.tab_mantenimiento.Controls.Add(Me.label_nombre)
        Me.tab_mantenimiento.Controls.Add(Me.label_id)
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
        Me.btn_salir.Location = New System.Drawing.Point(449, 196)
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
        Me.btn_borrar.Location = New System.Drawing.Point(345, 196)
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
        Me.btn_modificar.Location = New System.Drawing.Point(241, 196)
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
        Me.btn_agregar.Location = New System.Drawing.Point(137, 196)
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
        Me.btn_buscar.Location = New System.Drawing.Point(33, 196)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 40)
        Me.btn_buscar.TabIndex = 34
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseSelectable = True
        '
        'txt_direccion
        '
        '
        '
        '
        Me.txt_direccion.CustomButton.Image = Nothing
        Me.txt_direccion.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.txt_direccion.CustomButton.Name = ""
        Me.txt_direccion.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_direccion.CustomButton.TabIndex = 1
        Me.txt_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_direccion.CustomButton.UseSelectable = True
        Me.txt_direccion.CustomButton.Visible = False
        Me.txt_direccion.Lines = New String(-1) {}
        Me.txt_direccion.Location = New System.Drawing.Point(396, 131)
        Me.txt_direccion.MaxLength = 32767
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_direccion.SelectedText = ""
        Me.txt_direccion.SelectionLength = 0
        Me.txt_direccion.SelectionStart = 0
        Me.txt_direccion.ShortcutsEnabled = True
        Me.txt_direccion.Size = New System.Drawing.Size(184, 29)
        Me.txt_direccion.TabIndex = 10
        Me.txt_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_direccion.UseSelectable = True
        Me.txt_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_direccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_descripcion
        '
        '
        '
        '
        Me.txt_descripcion.CustomButton.Image = Nothing
        Me.txt_descripcion.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.txt_descripcion.CustomButton.Name = ""
        Me.txt_descripcion.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_descripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_descripcion.CustomButton.TabIndex = 1
        Me.txt_descripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_descripcion.CustomButton.UseSelectable = True
        Me.txt_descripcion.CustomButton.Visible = False
        Me.txt_descripcion.Lines = New String(-1) {}
        Me.txt_descripcion.Location = New System.Drawing.Point(396, 65)
        Me.txt_descripcion.MaxLength = 32767
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_descripcion.SelectedText = ""
        Me.txt_descripcion.SelectionLength = 0
        Me.txt_descripcion.SelectionStart = 0
        Me.txt_descripcion.ShortcutsEnabled = True
        Me.txt_descripcion.Size = New System.Drawing.Size(184, 29)
        Me.txt_descripcion.TabIndex = 9
        Me.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_descripcion.UseSelectable = True
        Me.txt_descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_descripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_nombre
        '
        '
        '
        '
        Me.txt_nombre.CustomButton.Image = Nothing
        Me.txt_nombre.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.txt_nombre.CustomButton.Name = ""
        Me.txt_nombre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nombre.CustomButton.TabIndex = 1
        Me.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nombre.CustomButton.UseSelectable = True
        Me.txt_nombre.CustomButton.Visible = False
        Me.txt_nombre.Lines = New String(-1) {}
        Me.txt_nombre.Location = New System.Drawing.Point(114, 131)
        Me.txt_nombre.MaxLength = 32767
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nombre.SelectedText = ""
        Me.txt_nombre.SelectionLength = 0
        Me.txt_nombre.SelectionStart = 0
        Me.txt_nombre.ShortcutsEnabled = True
        Me.txt_nombre.Size = New System.Drawing.Size(184, 29)
        Me.txt_nombre.TabIndex = 8
        Me.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_nombre.UseSelectable = True
        Me.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_id_sede
        '
        '
        '
        '
        Me.txt_id_sede.CustomButton.Image = Nothing
        Me.txt_id_sede.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.txt_id_sede.CustomButton.Name = ""
        Me.txt_id_sede.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_id_sede.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id_sede.CustomButton.TabIndex = 1
        Me.txt_id_sede.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id_sede.CustomButton.UseSelectable = True
        Me.txt_id_sede.CustomButton.Visible = False
        Me.txt_id_sede.Lines = New String(-1) {}
        Me.txt_id_sede.Location = New System.Drawing.Point(114, 65)
        Me.txt_id_sede.MaxLength = 32767
        Me.txt_id_sede.Name = "txt_id_sede"
        Me.txt_id_sede.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id_sede.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id_sede.SelectedText = ""
        Me.txt_id_sede.SelectionLength = 0
        Me.txt_id_sede.SelectionStart = 0
        Me.txt_id_sede.ShortcutsEnabled = True
        Me.txt_id_sede.Size = New System.Drawing.Size(184, 29)
        Me.txt_id_sede.TabIndex = 7
        Me.txt_id_sede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id_sede.UseSelectable = True
        Me.txt_id_sede.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id_sede.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label_direccion
        '
        Me.label_direccion.AutoSize = True
        Me.label_direccion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_direccion.Location = New System.Drawing.Point(302, 130)
        Me.label_direccion.Name = "label_direccion"
        Me.label_direccion.Size = New System.Drawing.Size(83, 25)
        Me.label_direccion.TabIndex = 6
        Me.label_direccion.Text = "Direccion"
        '
        'label_descripcion
        '
        Me.label_descripcion.AutoSize = True
        Me.label_descripcion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_descripcion.Location = New System.Drawing.Point(298, 66)
        Me.label_descripcion.Name = "label_descripcion"
        Me.label_descripcion.Size = New System.Drawing.Size(100, 25)
        Me.label_descripcion.TabIndex = 5
        Me.label_descripcion.Text = "Descripcion"
        '
        'label_nombre
        '
        Me.label_nombre.AutoSize = True
        Me.label_nombre.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_nombre.Location = New System.Drawing.Point(18, 128)
        Me.label_nombre.Name = "label_nombre"
        Me.label_nombre.Size = New System.Drawing.Size(75, 25)
        Me.label_nombre.TabIndex = 4
        Me.label_nombre.Text = "Nombre"
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_id.Location = New System.Drawing.Point(18, 66)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(94, 25)
        Me.label_id.TabIndex = 3
        Me.label_id.Text = "ID de Sede"
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.label_titulo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.label_titulo.Location = New System.Drawing.Point(190, 18)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(223, 25)
        Me.label_titulo.TabIndex = 2
        Me.label_titulo.Text = "Mantenimiento de Sedes"
        '
        'mantenimiento_sedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "mantenimiento_sedes"
        Me.Text = "Mantenimiento de Sedes"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.tab_control.ResumeLayout(False)
        Me.tab_ver.ResumeLayout(False)
        CType(Me.grid_sede, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_mantenimiento.ResumeLayout(False)
        Me.tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_control As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tab_ver As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grid_sede As MetroFramework.Controls.MetroGrid
    Friend WithEvents tab_mantenimiento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_direccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_descripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_nombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_id_sede As MetroFramework.Controls.MetroTextBox
    Friend WithEvents label_direccion As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_descripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_nombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents label_titulo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_salir As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_borrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_modificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_agregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_buscar As MetroFramework.Controls.MetroButton
End Class
