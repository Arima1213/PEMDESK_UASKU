<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWarehouse
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
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetKuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetKu = New UAS_WARUNG.DataSetKu()
        Me.MenuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.TextBoxStok = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaMenu = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaMenu = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxHargaMenu2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxIdMenu2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaMenu2 = New System.Windows.Forms.TextBox()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.DataGridViewMenu = New System.Windows.Forms.DataGridView()
        Me.IDPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGAPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOKPRODUKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPRODUKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_PRODUKTableAdapter = New UAS_WARUNG.DataSetKuTableAdapters.TBL_PRODUKTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Labeltanggal = New System.Windows.Forms.Label()
        Me.TextBoxStokHarianSaatIni = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxStokHarian = New System.Windows.Forms.TextBox()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetKuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetKu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPRODUKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSetKuBindingSource
        '
        Me.DataSetKuBindingSource.DataSource = Me.DataSetKu
        Me.DataSetKuBindingSource.Position = 0
        '
        'DataSetKu
        '
        Me.DataSetKu.DataSetName = "DataSetKu"
        Me.DataSetKu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Location = New System.Drawing.Point(347, 24)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(67, 76)
        Me.ButtonSimpan.TabIndex = 1
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'TextBoxStok
        '
        Me.TextBoxStok.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStok.Location = New System.Drawing.Point(104, 79)
        Me.TextBoxStok.Name = "TextBoxStok"
        Me.TextBoxStok.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxStok.TabIndex = 2
        '
        'TextBoxNamaMenu
        '
        Me.TextBoxNamaMenu.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaMenu.Location = New System.Drawing.Point(104, 24)
        Me.TextBoxNamaMenu.Name = "TextBoxNamaMenu"
        Me.TextBoxNamaMenu.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxNamaMenu.TabIndex = 3
        '
        'TextBoxHargaMenu
        '
        Me.TextBoxHargaMenu.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHargaMenu.Location = New System.Drawing.Point(104, 50)
        Me.TextBoxHargaMenu.Name = "TextBoxHargaMenu"
        Me.TextBoxHargaMenu.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxHargaMenu.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNamaMenu)
        Me.GroupBox1.Controls.Add(Me.TextBoxHargaMenu)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.TextBoxStok)
        Me.GroupBox1.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(420, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 122)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "HARGA_MENU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NAMA_MENU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "STOK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxHargaMenu2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxIdMenu2)
        Me.GroupBox2.Controls.Add(Me.TextBoxNamaMenu2)
        Me.GroupBox2.Controls.Add(Me.ButtonHapus)
        Me.GroupBox2.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(420, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 138)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hapus Menu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "HARGA_MENU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Silahkan Klik Cell Yang ingin Di hapus pada tabel di kiri"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NAMA_MENU"
        '
        'TextBoxHargaMenu2
        '
        Me.TextBoxHargaMenu2.Enabled = False
        Me.TextBoxHargaMenu2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHargaMenu2.Location = New System.Drawing.Point(104, 98)
        Me.TextBoxHargaMenu2.Name = "TextBoxHargaMenu2"
        Me.TextBoxHargaMenu2.ReadOnly = True
        Me.TextBoxHargaMenu2.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxHargaMenu2.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ID_MENU"
        '
        'TextBoxIdMenu2
        '
        Me.TextBoxIdMenu2.Enabled = False
        Me.TextBoxIdMenu2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdMenu2.Location = New System.Drawing.Point(104, 42)
        Me.TextBoxIdMenu2.Name = "TextBoxIdMenu2"
        Me.TextBoxIdMenu2.ReadOnly = True
        Me.TextBoxIdMenu2.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxIdMenu2.TabIndex = 10
        '
        'TextBoxNamaMenu2
        '
        Me.TextBoxNamaMenu2.Enabled = False
        Me.TextBoxNamaMenu2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaMenu2.Location = New System.Drawing.Point(104, 70)
        Me.TextBoxNamaMenu2.Name = "TextBoxNamaMenu2"
        Me.TextBoxNamaMenu2.ReadOnly = True
        Me.TextBoxNamaMenu2.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxNamaMenu2.TabIndex = 11
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.Location = New System.Drawing.Point(347, 39)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(67, 76)
        Me.ButtonHapus.TabIndex = 9
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'DataGridViewMenu
        '
        Me.DataGridViewMenu.AllowUserToAddRows = False
        Me.DataGridViewMenu.AllowUserToDeleteRows = False
        Me.DataGridViewMenu.AutoGenerateColumns = False
        Me.DataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRODUKDataGridViewTextBoxColumn, Me.NAMAPRODUKDataGridViewTextBoxColumn, Me.HARGAPRODUKDataGridViewTextBoxColumn, Me.STOKPRODUKDataGridViewTextBoxColumn})
        Me.DataGridViewMenu.DataSource = Me.TBLPRODUKBindingSource
        Me.DataGridViewMenu.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewMenu.Name = "DataGridViewMenu"
        Me.DataGridViewMenu.Size = New System.Drawing.Size(402, 447)
        Me.DataGridViewMenu.TabIndex = 7
        '
        'IDPRODUKDataGridViewTextBoxColumn
        '
        Me.IDPRODUKDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUK"
        Me.IDPRODUKDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDPRODUKDataGridViewTextBoxColumn.Name = "IDPRODUKDataGridViewTextBoxColumn"
        Me.IDPRODUKDataGridViewTextBoxColumn.Width = 50
        '
        'NAMAPRODUKDataGridViewTextBoxColumn
        '
        Me.NAMAPRODUKDataGridViewTextBoxColumn.DataPropertyName = "NAMA_PRODUK"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.HeaderText = "PRODUK"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.Name = "NAMAPRODUKDataGridViewTextBoxColumn"
        Me.NAMAPRODUKDataGridViewTextBoxColumn.Width = 130
        '
        'HARGAPRODUKDataGridViewTextBoxColumn
        '
        Me.HARGAPRODUKDataGridViewTextBoxColumn.DataPropertyName = "HARGA_PRODUK"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.HeaderText = "HARGA"
        Me.HARGAPRODUKDataGridViewTextBoxColumn.Name = "HARGAPRODUKDataGridViewTextBoxColumn"
        '
        'STOKPRODUKDataGridViewTextBoxColumn
        '
        Me.STOKPRODUKDataGridViewTextBoxColumn.DataPropertyName = "STOK_PRODUK"
        Me.STOKPRODUKDataGridViewTextBoxColumn.HeaderText = "STOK"
        Me.STOKPRODUKDataGridViewTextBoxColumn.Name = "STOKPRODUKDataGridViewTextBoxColumn"
        Me.STOKPRODUKDataGridViewTextBoxColumn.Width = 80
        '
        'TBLPRODUKBindingSource
        '
        Me.TBLPRODUKBindingSource.DataMember = "TBL_PRODUK"
        Me.TBLPRODUKBindingSource.DataSource = Me.DataSetKuBindingSource
        '
        'TBL_PRODUKTableAdapter
        '
        Me.TBL_PRODUKTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Labeltanggal)
        Me.GroupBox3.Controls.Add(Me.TextBoxStokHarianSaatIni)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBoxStokHarian)
        Me.GroupBox3.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(420, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 122)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stok Harian"
        '
        'Labeltanggal
        '
        Me.Labeltanggal.AutoSize = True
        Me.Labeltanggal.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltanggal.Location = New System.Drawing.Point(6, 24)
        Me.Labeltanggal.Name = "Labeltanggal"
        Me.Labeltanggal.Size = New System.Drawing.Size(40, 12)
        Me.Labeltanggal.TabIndex = 19
        Me.Labeltanggal.Text = "tanggal"
        '
        'TextBoxStokHarianSaatIni
        '
        Me.TextBoxStokHarianSaatIni.Enabled = False
        Me.TextBoxStokHarianSaatIni.Location = New System.Drawing.Point(154, 51)
        Me.TextBoxStokHarianSaatIni.Name = "TextBoxStokHarianSaatIni"
        Me.TextBoxStokHarianSaatIni.Size = New System.Drawing.Size(38, 23)
        Me.TextBoxStokHarianSaatIni.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "STOK HARIAN SAAT INI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 12)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "UBAH STOK HARIAN"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(347, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 76)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxStokHarian
        '
        Me.TextBoxStokHarian.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStokHarian.Location = New System.Drawing.Point(154, 80)
        Me.TextBoxStokHarian.Name = "TextBoxStokHarian"
        Me.TextBoxStokHarian.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxStokHarian.TabIndex = 2
        '
        'FormWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 471)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridViewMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormWarehouse"
        Me.Text = "FormWarehouse"
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetKuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetKu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPRODUKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetKuBindingSource As BindingSource
    Friend WithEvents DataSetKu As DataSetKu
    Friend WithEvents MenuBindingSource As BindingSource
    Friend WithEvents MenuBindingSource1 As BindingSource
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents TextBoxStok As TextBox
    Friend WithEvents TextBoxNamaMenu As TextBox
    Friend WithEvents TextBoxHargaMenu As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxHargaMenu2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxIdMenu2 As TextBox
    Friend WithEvents TextBoxNamaMenu2 As TextBox
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents DataGridViewMenu As DataGridView
    Friend WithEvents TBLPRODUKBindingSource As BindingSource
    Friend WithEvents TBL_PRODUKTableAdapter As DataSetKuTableAdapters.TBL_PRODUKTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxStokHarian As TextBox
    Friend WithEvents TextBoxStokHarianSaatIni As TextBox
    Friend WithEvents Labeltanggal As Label
    Friend WithEvents IDPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMAPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HARGAPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOKPRODUKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
