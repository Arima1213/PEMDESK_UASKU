<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataSetKu = New UAS_WARUNG.DataSetKu()
        Me.TBL_PRODUKTableAdapter = New UAS_WARUNG.DataSetKuTableAdapters.TBL_PRODUKTableAdapter()
        Me.ButtonTambah = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.NumericUpDown1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListViewTransaksi = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonCheckout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DataGridViewMenu = New System.Windows.Forms.DataGridView()
        Me.TBLPRODUKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TextBoxIdMenu2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxNamaMenu2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxHargaMenu2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IDPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGAPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOKPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TextBoxKembalian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxUangPembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxTotalSementara = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataSetKu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPRODUKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSetKu
        '
        Me.DataSetKu.DataSetName = "DataSetKu"
        Me.DataSetKu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_PRODUKTableAdapter
        '
        Me.TBL_PRODUKTableAdapter.ClearBeforeFill = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Animated = True
        Me.ButtonTambah.BackColor = System.Drawing.Color.Transparent
        Me.ButtonTambah.BorderRadius = 10
        Me.ButtonTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonTambah.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonTambah.FillColor = System.Drawing.Color.Green
        Me.ButtonTambah.FillColor2 = System.Drawing.Color.Teal
        Me.ButtonTambah.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.ForeColor = System.Drawing.Color.White
        Me.ButtonTambah.HoverState.FillColor = System.Drawing.Color.SpringGreen
        Me.ButtonTambah.HoverState.FillColor2 = System.Drawing.Color.Green
        Me.ButtonTambah.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Location = New System.Drawing.Point(202, 159)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.ShadowDecoration.BorderRadius = 10
        Me.ButtonTambah.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.ButtonTambah.ShadowDecoration.Depth = 3
        Me.ButtonTambah.ShadowDecoration.Enabled = True
        Me.ButtonTambah.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.ButtonTambah.Size = New System.Drawing.Size(188, 33)
        Me.ButtonTambah.TabIndex = 19
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseTransparentBackground = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.Transparent
        Me.NumericUpDown1.BorderRadius = 5
        Me.NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(121, 162)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(70, 27)
        Me.NumericUpDown1.TabIndex = 18
        Me.NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.DarkGray
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "JUMLAH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "HARGA_MENU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NAMA_MENU"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ID_MENU"
        '
        'ListViewTransaksi
        '
        Me.ListViewTransaksi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewTransaksi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewTransaksi.FullRowSelect = True
        Me.ListViewTransaksi.GridLines = True
        Me.ListViewTransaksi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewTransaksi.HideSelection = False
        Me.ListViewTransaksi.HoverSelection = True
        Me.ListViewTransaksi.Location = New System.Drawing.Point(12, 229)
        Me.ListViewTransaksi.MultiSelect = False
        Me.ListViewTransaksi.Name = "ListViewTransaksi"
        Me.ListViewTransaksi.Size = New System.Drawing.Size(412, 230)
        Me.ListViewTransaksi.TabIndex = 8
        Me.ListViewTransaksi.UseCompatibleStateImageBehavior = False
        Me.ListViewTransaksi.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAMA"
        Me.ColumnHeader2.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "HARGA"
        Me.ColumnHeader3.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "JLM"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SUB TOTAL"
        Me.ColumnHeader5.Width = 101
        '
        'ButtonCheckout
        '
        Me.ButtonCheckout.Animated = True
        Me.ButtonCheckout.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCheckout.BorderRadius = 10
        Me.ButtonCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonCheckout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonCheckout.FillColor = System.Drawing.Color.Green
        Me.ButtonCheckout.FillColor2 = System.Drawing.Color.Teal
        Me.ButtonCheckout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheckout.ForeColor = System.Drawing.Color.White
        Me.ButtonCheckout.HoverState.FillColor = System.Drawing.Color.SpringGreen
        Me.ButtonCheckout.HoverState.FillColor2 = System.Drawing.Color.Green
        Me.ButtonCheckout.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheckout.Location = New System.Drawing.Point(202, 173)
        Me.ButtonCheckout.Name = "ButtonCheckout"
        Me.ButtonCheckout.ShadowDecoration.BorderRadius = 10
        Me.ButtonCheckout.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.ButtonCheckout.ShadowDecoration.Depth = 3
        Me.ButtonCheckout.ShadowDecoration.Enabled = True
        Me.ButtonCheckout.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.ButtonCheckout.Size = New System.Drawing.Size(188, 33)
        Me.ButtonCheckout.TabIndex = 20
        Me.ButtonCheckout.Text = "Checkout"
        Me.ButtonCheckout.UseTransparentBackground = True
        '
        'DataGridViewMenu
        '
        Me.DataGridViewMenu.AllowUserToAddRows = False
        Me.DataGridViewMenu.AllowUserToDeleteRows = False
        Me.DataGridViewMenu.AllowUserToResizeColumns = False
        Me.DataGridViewMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewMenu.AutoGenerateColumns = False
        Me.DataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMenu.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridViewMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewMenu.ColumnHeadersHeight = 21
        Me.DataGridViewMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRODUKDataGridViewTextBoxColumn, Me.NAMAPRODUKDataGridViewTextBoxColumn, Me.HARGAPRODUKDataGridViewTextBoxColumn, Me.STOKPRODUKDataGridViewTextBoxColumn})
        Me.DataGridViewMenu.DataSource = Me.TBLPRODUKBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewMenu.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewMenu.EnableHeadersVisualStyles = False
        Me.DataGridViewMenu.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewMenu.MultiSelect = False
        Me.DataGridViewMenu.Name = "DataGridViewMenu"
        Me.DataGridViewMenu.ReadOnly = True
        Me.DataGridViewMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMenu.Size = New System.Drawing.Size(412, 211)
        Me.DataGridViewMenu.TabIndex = 21
        '
        'TBLPRODUKBindingSource
        '
        Me.TBLPRODUKBindingSource.DataMember = "TBL_PRODUK"
        Me.TBLPRODUKBindingSource.DataSource = Me.DataSetKu
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.BorderThickness = 0
        Me.Guna2GroupBox1.Controls.Add(Me.TextBoxHargaMenu2)
        Me.Guna2GroupBox1.Controls.Add(Me.TextBoxNamaMenu2)
        Me.Guna2GroupBox1.Controls.Add(Me.TextBoxIdMenu2)
        Me.Guna2GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(440, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(403, 211)
        Me.Guna2GroupBox1.TabIndex = 20
        Me.Guna2GroupBox1.Text = "Tambah Menu"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox1.UseTransparentBackground = True
        '
        'TextBoxIdMenu2
        '
        Me.TextBoxIdMenu2.BorderRadius = 5
        Me.TextBoxIdMenu2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxIdMenu2.DefaultText = ""
        Me.TextBoxIdMenu2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxIdMenu2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxIdMenu2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxIdMenu2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxIdMenu2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxIdMenu2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBoxIdMenu2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxIdMenu2.Location = New System.Drawing.Point(121, 49)
        Me.TextBoxIdMenu2.Name = "TextBoxIdMenu2"
        Me.TextBoxIdMenu2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxIdMenu2.PlaceholderText = ""
        Me.TextBoxIdMenu2.SelectedText = ""
        Me.TextBoxIdMenu2.Size = New System.Drawing.Size(269, 28)
        Me.TextBoxIdMenu2.TabIndex = 20
        '
        'TextBoxNamaMenu2
        '
        Me.TextBoxNamaMenu2.BorderRadius = 5
        Me.TextBoxNamaMenu2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxNamaMenu2.DefaultText = ""
        Me.TextBoxNamaMenu2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxNamaMenu2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxNamaMenu2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxNamaMenu2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxNamaMenu2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxNamaMenu2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBoxNamaMenu2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxNamaMenu2.Location = New System.Drawing.Point(121, 86)
        Me.TextBoxNamaMenu2.Name = "TextBoxNamaMenu2"
        Me.TextBoxNamaMenu2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxNamaMenu2.PlaceholderText = ""
        Me.TextBoxNamaMenu2.SelectedText = ""
        Me.TextBoxNamaMenu2.Size = New System.Drawing.Size(269, 28)
        Me.TextBoxNamaMenu2.TabIndex = 21
        '
        'TextBoxHargaMenu2
        '
        Me.TextBoxHargaMenu2.BorderRadius = 5
        Me.TextBoxHargaMenu2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxHargaMenu2.DefaultText = ""
        Me.TextBoxHargaMenu2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxHargaMenu2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxHargaMenu2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxHargaMenu2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxHargaMenu2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxHargaMenu2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBoxHargaMenu2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxHargaMenu2.Location = New System.Drawing.Point(121, 123)
        Me.TextBoxHargaMenu2.Name = "TextBoxHargaMenu2"
        Me.TextBoxHargaMenu2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxHargaMenu2.PlaceholderText = ""
        Me.TextBoxHargaMenu2.SelectedText = ""
        Me.TextBoxHargaMenu2.Size = New System.Drawing.Size(269, 28)
        Me.TextBoxHargaMenu2.TabIndex = 22
        '
        'IDPRODUKDataGridViewTextBoxColumn
        '
        Me.IDPRODUKDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUK"
        Me.IDPRODUKDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDPRODUKDataGridViewTextBoxColumn.Name = "IDPRODUKDataGridViewTextBoxColumn"
        Me.IDPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMAPRODUKDataGridViewTextBoxColumn
        '
        Me.NAMAPRODUKDataGridViewTextBoxColumn.DataPropertyName = "NAMA_PRODUK"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.Name = "NAMAPRODUKDataGridViewTextBoxColumn"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HARGAPRODUKDataGridViewTextBoxColumn
        '
        Me.HARGAPRODUKDataGridViewTextBoxColumn.DataPropertyName = "HARGA_PRODUK"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.HeaderText = "HARGA"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.Name = "HARGAPRODUKDataGridViewTextBoxColumn"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STOKPRODUKDataGridViewTextBoxColumn
        '
        Me.STOKPRODUKDataGridViewTextBoxColumn.DataPropertyName = "STOK_PRODUK"
        Me.STOKPRODUKDataGridViewTextBoxColumn.HeaderText = "STOK"
        Me.STOKPRODUKDataGridViewTextBoxColumn.Name = "STOKPRODUKDataGridViewTextBoxColumn"
        Me.STOKPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderRadius = 20
        Me.Guna2GroupBox2.BorderThickness = 0
        Me.Guna2GroupBox2.Controls.Add(Me.ButtonCheckout)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBoxKembalian)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBoxUangPembeli)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBoxTotalSementara)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.Label10)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(440, 237)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(403, 222)
        Me.Guna2GroupBox2.TabIndex = 23
        Me.Guna2GroupBox2.Text = "Pembayaran"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox2.UseTransparentBackground = True
        '
        'TextBoxKembalian
        '
        Me.TextBoxKembalian.BorderRadius = 5
        Me.TextBoxKembalian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxKembalian.DefaultText = ""
        Me.TextBoxKembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxKembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxKembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxKembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxKembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxKembalian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBoxKembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxKembalian.Location = New System.Drawing.Point(121, 137)
        Me.TextBoxKembalian.Name = "TextBoxKembalian"
        Me.TextBoxKembalian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxKembalian.PlaceholderText = ""
        Me.TextBoxKembalian.SelectedText = ""
        Me.TextBoxKembalian.Size = New System.Drawing.Size(269, 28)
        Me.TextBoxKembalian.TabIndex = 22
        '
        'TextBoxUangPembeli
        '
        Me.TextBoxUangPembeli.BorderRadius = 5
        Me.TextBoxUangPembeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxUangPembeli.DefaultText = ""
        Me.TextBoxUangPembeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxUangPembeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxUangPembeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxUangPembeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxUangPembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxUangPembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBoxUangPembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxUangPembeli.Location = New System.Drawing.Point(121, 100)
        Me.TextBoxUangPembeli.Name = "TextBoxUangPembeli"
        Me.TextBoxUangPembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxUangPembeli.PlaceholderText = ""
        Me.TextBoxUangPembeli.SelectedText = ""
        Me.TextBoxUangPembeli.Size = New System.Drawing.Size(269, 28)
        Me.TextBoxUangPembeli.TabIndex = 21
        '
        'TextBoxTotalSementara
        '
        Me.TextBoxTotalSementara.BorderRadius = 10
        Me.TextBoxTotalSementara.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxTotalSementara.DefaultText = ""
        Me.TextBoxTotalSementara.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxTotalSementara.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxTotalSementara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxTotalSementara.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxTotalSementara.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxTotalSementara.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBoxTotalSementara.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxTotalSementara.Location = New System.Drawing.Point(22, 49)
        Me.TextBoxTotalSementara.Name = "TextBoxTotalSementara"
        Me.TextBoxTotalSementara.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxTotalSementara.PlaceholderText = ""
        Me.TextBoxTotalSementara.SelectedText = ""
        Me.TextBoxTotalSementara.Size = New System.Drawing.Size(368, 45)
        Me.TextBoxTotalSementara.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Uang Pembeli"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 12)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Uang Kembalian"
        '
        'FormTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(855, 471)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.DataGridViewMenu)
        Me.Controls.Add(Me.ListViewTransaksi)
        Me.Name = "FormTransaction"
        Me.Text = "Form2"
        CType(Me.DataSetKu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPRODUKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetKu As DataSetKu
    Friend WithEvents TBL_PRODUKTableAdapter As DataSetKuTableAdapters.TBL_PRODUKTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents IDMENUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMAMENUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGAMENUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ListViewTransaksi As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents DataGridViewMenu As DataGridView
    Friend WithEvents TBLPRODUKBindingSource As BindingSource
    Friend WithEvents NumericUpDown1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents ButtonTambah As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ButtonCheckout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents IDPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMAPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGAPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOKPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TextBoxHargaMenu2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxNamaMenu2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxIdMenu2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TextBoxKembalian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxUangPembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxTotalSementara As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
End Class
