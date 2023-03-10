Public Class FormTransaction
    Dim ff As Integer
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer



    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetKu.menu' table. You can move, or remove it, as needed.
        Me.TBL_PRODUKTableAdapter.Fill(Me.DataSetKu.TBL_PRODUK)
        TampilData2()
        TextBoxTotalSementara.Text = 0

    End Sub

    Public Sub TampilData2()


        sqlstr = "SELECT * FROM TBL_PRODUK WHERE STOK_PRODUK is NOT NULL"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        If data > 0 Then
            FormWarehouse.DataGridViewMenu.DataSource = dt
            FormWarehouse.DataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Else
            FormWarehouse.DataGridViewMenu.DataSource = Nothing
        End If

    End Sub

    Public Function TotalSementara()
        Dim mm As Integer = 0
        Dim ChaceTotal As Integer
        For Each items As ListViewItem In ListViewTransaksi.Items
            ChaceTotal += ListViewTransaksi.Items(mm).SubItems(4).Text
            mm += 1
        Next
        Return ChaceTotal
    End Function

    Public Function GetLastIdTransaksi() As String

        Dim idtransaksi As String

        sqlstr = "select ID_TRANSAKSI from TBL_TRANSAKSI order by id_transaksi desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            idtransaksi = dt.Rows(0)(0).ToString()
        End If
        Return idtransaksi
    End Function

    Private Sub DataGridViewMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMenu.CellClick
        ff = e.RowIndex
        If ff < 0 Then
        Else
            TextBoxIdMenu2.Text = DataGridViewMenu(0, ff).Value
            TextBoxNamaMenu2.Text = DataGridViewMenu(1, ff).Value
            TextBoxHargaMenu2.Text = DataGridViewMenu(2, ff).Value
        End If
    End Sub


    Private Function IdChechk(IDPRODUK As String)
        Dim NNN As Integer = 0
        For Each row As DataGridViewRow In DataGridViewMenu.Rows
            If IDPRODUK = DataGridViewMenu(0, NNN).Value Then
                IDPRODUK = DataGridViewMenu(3, NNN).Value

            End If
            NNN += 1
        Next
        Return IDPRODUK
    End Function

    Sub Checkout()
        Dim nn As Integer = 0
        Dim URUTAN As Integer = 0
        Konek()
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        'pengurangan stok produk oleh pembelian
        For Each item As ListViewItem In Me.ListViewTransaksi.Items
            perintah.CommandType = CommandType.Text
            Dim idchek As Integer = IdChechk(ListViewTransaksi.Items(URUTAN).SubItems(0).Text)
            perintah.CommandText = "UPDATE " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_PRODUK" & ControlChars.Quote & " SET STOK_PRODUK = '" & (idchek - ListViewTransaksi.Items(URUTAN).SubItems(3).Text) & "' WHERE ID_PRODUK = '" & ListViewTransaksi.Items(URUTAN).SubItems(0).Text & "'"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            URUTAN += 1
        Next

        'mencari total kolom
        For Each item As ListViewItem In Me.ListViewTransaksi.Items
            nn += 1
        Next

        'Insert TBL_TRANSAKSI VALUE
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_TRANSAKSI" & ControlChars.Quote & "  (JUMLAH_PESANAN,TOTAL_TRANSAKSI,TANGGAL_TRANSAKSI) VALUES
                                        ('" & nn & "','" & TextBoxTotalSementara.Text & "',to_date('" & myDate & "', 'dd-mm-yyyy'))"
        perintah.Connection = conn
        perintah.ExecuteNonQuery()


        Dim idtransa As String = GetLastIdTransaksi()

        'mencari nilai id_transaksi
        Try
            nn = 0
            For Each item As ListViewItem In Me.ListViewTransaksi.Items
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "INSERT INTO " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_DETAIL_TRANSAKSI" & ControlChars.Quote & "  (ID_TRANSAKSI, NOMOR_PESANAN,ID_PRODUK,NAMA_PRODUK, HARGA_PRODUK, JUMLAH,TOTAL_PESANAN) VALUES
                                        ('" & idtransa & "','" & nn + 1 & "','" & ListViewTransaksi.Items(nn).SubItems(0).Text & "','" & ListViewTransaksi.Items(nn).SubItems(1).Text & "','" & ListViewTransaksi.Items(nn).SubItems(2).Text & "','" & ListViewTransaksi.Items(nn).SubItems(3).Text & "','" & ListViewTransaksi.Items(nn).SubItems(4).Text & "')"
                perintah.Connection = conn
                perintah.ExecuteNonQuery()
                nn += 1
            Next
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()
    End Sub

    Private Sub ButtonTambah_Click_1(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim urutan As Integer = 0
        Dim kondisi As Boolean = False

        If TextBoxIdMenu2.Text = "" Then
            MsgBox("Mohon Pilih Baris yang ingin di tambahkan!")
        Else

            If ListViewTransaksi.Items.Count = 0 Then
                ListViewTransaksi.Items.Add(DataGridViewMenu(0, ff).Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewMenu(1, ff).Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewMenu(2, ff).Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(NumericUpDown1.Value)
                ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewMenu(2, ff).Value * NumericUpDown1.Value)

            Else
                'pengecekan setiap baris listview apakah tedapat data yang sama
                For Each items As ListViewItem In ListViewTransaksi.Items
                    If DataGridViewMenu(0, ff).Value = ListViewTransaksi.Items(urutan).SubItems(0).Text Then

                        'pengecekan apakah stok melebihi stok yang tersedia
                        If (ListViewTransaksi.Items(urutan).SubItems(3).Text + NumericUpDown1.Value) <= DataGridViewMenu(3, ff).Value Then
                            ListViewTransaksi.Items(urutan).SubItems(3).Text = NumericUpDown1.Value + ListViewTransaksi.Items(urutan).SubItems(3).Text
                            ListViewTransaksi.Items(urutan).SubItems(4).Text = ListViewTransaksi.Items(urutan).SubItems(3).Text * ListViewTransaksi.Items(urutan).SubItems(2).Text

                        Else
                            MsgBox("jumlah melebihi stok")
                        End If
                    Else
                        'jika tidak ada yg sama akan mengganti boolean ke true
                        If urutan = ListViewTransaksi.Items.Count - 1 Then
                            kondisi = True
                        End If
                    End If
                    urutan += 1
                Next
                'ketika data tidak ada yang sama maka akan di tambh di baris baru
                If kondisi = True Then
                    ListViewTransaksi.Items.Add(DataGridViewMenu(0, ff).Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewMenu(1, ff).Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewMenu(2, ff).Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(NumericUpDown1.Value)
                    ListViewTransaksi.Items(ListViewTransaksi.Items.Count - 1).SubItems.Add(DataGridViewMenu(2, ff).Value * NumericUpDown1.Value)
                    TotalSementara()
                End If
            End If
        End If
        TextBoxTotalSementara.Text = TotalSementara()
    End Sub

    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click
        If TextBoxTotalSementara.Text = 0 Then
            MsgBox("Mohon Masukkan Pesanan Pembeli!")
        Else
            If TextBoxUangPembeli.Text = "" Then
                MsgBox("Mohon Masukkan Uang Pembeli!")
            Else
                If (TextBoxUangPembeli.Text - TextBoxTotalSementara.Text) < 0 Then
                    MsgBox("Uang Pembeli Kurang")
                Else

                    Checkout()
                    FormUtama.ButtonTransaction.PerformClick()

                End If
            End If
        End If
    End Sub

    Private Sub TextBoxUangPembeli_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxUangPembeli.TextChanged
        If TextBoxUangPembeli.Text = "" Then
        Else
            TextBoxKembalian.Text = (TextBoxUangPembeli.Text - TextBoxTotalSementara.Text).ToString
        End If

    End Sub
    Private Sub TextBoxUangPembeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxUangPembeli.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class