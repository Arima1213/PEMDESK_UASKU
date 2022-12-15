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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataSetKu = New UAS_WARUNG.DataSetKu()
        Me.TBL_PRODUKTableAdapter = New UAS_WARUNG.DataSetKuTableAdapters.TBL_PRODUKTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxHargaMenu2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxIdMenu2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaMenu2 = New System.Windows.Forms.TextBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ListViewTransaksi = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxKembalian = New System.Windows.Forms.TextBox()
        Me.TextBoxUangPembeli = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalSementara = New System.Windows.Forms.TextBox()
        Me.DataGridViewMenu = New System.Windows.Forms.DataGridView()
        Me.IDPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGAPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOKPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPRODUKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumericUpDown1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        CType(Me.DataSetKu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPRODUKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxHargaMenu2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxIdMenu2)
        Me.GroupBox2.Controls.Add(Me.TextBoxNamaMenu2)
        Me.GroupBox2.Controls.Add(Me.ButtonTambah)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(481, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 211)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tambah Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "JUMLAH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "HARGA_MENU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Silahkan Klik Menu Yang ingin Di Tambahkan pada tabel di kiri"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NAMA_MENU"
        '
        'TextBoxHargaMenu2
        '
        Me.TextBoxHargaMenu2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHargaMenu2.Location = New System.Drawing.Point(104, 102)
        Me.TextBoxHargaMenu2.Name = "TextBoxHargaMenu2"
        Me.TextBoxHargaMenu2.ReadOnly = True
        Me.TextBoxHargaMenu2.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxHargaMenu2.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ID_MENU"
        '
        'TextBoxIdMenu2
        '
        Me.TextBoxIdMenu2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdMenu2.Location = New System.Drawing.Point(104, 46)
        Me.TextBoxIdMenu2.Name = "TextBoxIdMenu2"
        Me.TextBoxIdMenu2.ReadOnly = True
        Me.TextBoxIdMenu2.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxIdMenu2.TabIndex = 10
        '
        'TextBoxNamaMenu2
        '
        Me.TextBoxNamaMenu2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaMenu2.Location = New System.Drawing.Point(104, 74)
        Me.TextBoxNamaMenu2.Name = "TextBoxNamaMenu2"
        Me.TextBoxNamaMenu2.ReadOnly = True
        Me.TextBoxNamaMenu2.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxNamaMenu2.TabIndex = 11
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Location = New System.Drawing.Point(104, 161)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(240, 33)
        Me.ButtonTambah.TabIndex = 9
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ListViewTransaksi
        '
        Me.ListViewTransaksi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewTransaksi.FullRowSelect = True
        Me.ListViewTransaksi.GridLines = True
        Me.ListViewTransaksi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewTransaksi.HideSelection = False
        Me.ListViewTransaksi.HoverSelection = True
        Me.ListViewTransaksi.Location = New System.Drawing.Point(12, 229)
        Me.ListViewTransaksi.MultiSelect = False
        Me.ListViewTransaksi.Name = "ListViewTransaksi"
        Me.ListViewTransaksi.Size = New System.Drawing.Size(463, 218)
        Me.ListViewTransaksi.TabIndex = 8
        Me.ListViewTransaksi.UseCompatibleStateImageBehavior = False
        Me.ListViewTransaksi.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 61
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAMA"
        Me.ColumnHeader2.Width = 174
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "HARGA"
        Me.ColumnHeader3.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "JUMLAH"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SUB TOTAL"
        Me.ColumnHeader5.Width = 101
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBoxKembalian)
        Me.GroupBox1.Controls.Add(Me.TextBoxUangPembeli)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalSementara)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(481, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 218)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(13, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "UANG KEMBALIAN :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(15, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "UANG PEMBELI :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxKembalian
        '
        Me.TextBoxKembalian.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKembalian.Location = New System.Drawing.Point(151, 118)
        Me.TextBoxKembalian.Name = "TextBoxKembalian"
        Me.TextBoxKembalian.ReadOnly = True
        Me.TextBoxKembalian.Size = New System.Drawing.Size(205, 30)
        Me.TextBoxKembalian.TabIndex = 15
        Me.TextBoxKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxUangPembeli
        '
        Me.TextBoxUangPembeli.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUangPembeli.Location = New System.Drawing.Point(151, 73)
        Me.TextBoxUangPembeli.Name = "TextBoxUangPembeli"
        Me.TextBoxUangPembeli.Size = New System.Drawing.Size(205, 30)
        Me.TextBoxUangPembeli.TabIndex = 14
        '
        'TextBoxTotalSementara
        '
        Me.TextBoxTotalSementara.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalSementara.Location = New System.Drawing.Point(18, 19)
        Me.TextBoxTotalSementara.Name = "TextBoxTotalSementara"
        Me.TextBoxTotalSementara.ReadOnly = True
        Me.TextBoxTotalSementara.Size = New System.Drawing.Size(338, 36)
        Me.TextBoxTotalSementara.TabIndex = 13
        Me.TextBoxTotalSementara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewMenu
        '
        Me.DataGridViewMenu.AllowUserToAddRows = False
        Me.DataGridViewMenu.AllowUserToDeleteRows = False
        Me.DataGridViewMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewMenu.AutoGenerateColumns = False
        Me.DataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewMenu.ColumnHeadersHeight = 21
        Me.DataGridViewMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRODUKDataGridViewTextBoxColumn, Me.NAMAPRODUKDataGridViewTextBoxColumn, Me.HARGAPRODUKDataGridViewTextBoxColumn, Me.STOKPRODUKDataGridViewTextBoxColumn})
        Me.DataGridViewMenu.DataSource = Me.TBLPRODUKBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewMenu.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewMenu.EnableHeadersVisualStyles = False
        Me.DataGridViewMenu.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewMenu.Name = "DataGridViewMenu"
        Me.DataGridViewMenu.ReadOnly = True
        Me.DataGridViewMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMenu.Size = New System.Drawing.Size(463, 211)
        Me.DataGridViewMenu.TabIndex = 21
        '
        'IDPRODUKDataGridViewTextBoxColumn
        '
        Me.IDPRODUKDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUK"
        Me.IDPRODUKDataGridViewTextBoxColumn.HeaderText = "ID_PRODUK"
        Me.IDPRODUKDataGridViewTextBoxColumn.Name = "IDPRODUKDataGridViewTextBoxColumn"
        Me.IDPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMAPRODUKDataGridViewTextBoxColumn
        '
        Me.NAMAPRODUKDataGridViewTextBoxColumn.DataPropertyName = "NAMA_PRODUK"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.HeaderText = "NAMA_PRODUK"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.Name = "NAMAPRODUKDataGridViewTextBoxColumn"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HARGAPRODUKDataGridViewTextBoxColumn
        '
        Me.HARGAPRODUKDataGridViewTextBoxColumn.DataPropertyName = "HARGA_PRODUK"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.HeaderText = "HARGA_PRODUK"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.Name = "HARGAPRODUKDataGridViewTextBoxColumn"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STOKPRODUKDataGridViewTextBoxColumn
        '
        Me.STOKPRODUKDataGridViewTextBoxColumn.DataPropertyName = "STOK_PRODUK"
        Me.STOKPRODUKDataGridViewTextBoxColumn.HeaderText = "STOK_PRODUK"
        Me.STOKPRODUKDataGridViewTextBoxColumn.Name = "STOKPRODUKDataGridViewTextBoxColumn"
        Me.STOKPRODUKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBLPRODUKBindingSource
        '
        Me.TBLPRODUKBindingSource.DataMember = "TBL_PRODUK"
        Me.TBLPRODUKBindingSource.DataSource = Me.DataSetKu
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.Transparent
        Me.NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(104, 128)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(70, 27)
        Me.NumericUpDown1.TabIndex = 18
        Me.NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.DarkGray
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FormTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 471)
        Me.Controls.Add(Me.DataGridViewMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListViewTransaksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormTransaction"
        Me.Text = "Form2"
        CType(Me.DataSetKu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPRODUKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetKu As DataSetKu
    Friend WithEvents TBL_PRODUKTableAdapter As DataSetKuTableAdapters.TBL_PRODUKTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxHargaMenu2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxIdMenu2 As TextBox
    Friend WithEvents TextBoxNamaMenu2 As TextBox
    Friend WithEvents ButtonTambah As Button
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxKembalian As TextBox
    Friend WithEvents TextBoxUangPembeli As TextBox
    Friend WithEvents TextBoxTotalSementara As TextBox
    Friend WithEvents DataGridViewMenu As DataGridView
    Friend WithEvents TBLPRODUKBindingSource As BindingSource
    Friend WithEvents IDPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMAPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGAPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOKPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumericUpDown1 As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
