Imports System.Data.OracleClient
Public Class FormTransaction
    Dim ff As Integer
    Dim id_pembelian As String



    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetKu.menu' table. You can move, or remove it, as needed.
        Me.TBL_PRODUKTableAdapter.Fill(Me.DataSetKu.TBL_PRODUK)
        tampildata2()
        TextBoxTotalSementara.Text = 0

    End Sub
    Public Function totalsementara()
        Dim mm As Integer = 0
        Dim ChaceTotal As Integer
        For Each items As ListViewItem In ListViewTransaksi.Items
            ChaceTotal += ListViewTransaksi.Items(mm).SubItems(4).Text
            mm += 1
        Next
        Return ChaceTotal
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

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
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
                    totalsementara()
                End If
            End If
        End If
        TextBoxTotalSementara.Text = totalsementara()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxTotalSementara.Text = 0 Then
            MsgBox("Mohon Masukkan Pesanan Pembeli!")
        Else
            If TextBoxUangPembeli.Text = "" Then
                MsgBox("Mohon Masukkan Uang Pembeli!")
            Else
                If (TextBoxUangPembeli.Text - TextBoxTotalSementara.Text) < 0 Then
                    MsgBox("Uang Pembeli Kurang")
                Else

                    checkout()
                    FormUtama.ButtonTransaction.PerformClick()

                End If
            End If
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

    Sub checkout()
        Dim nn As Integer = 0
        Dim URUTAN As Integer = 0
        konek()
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
                                        ('" & nn & "','" & TextBoxTotalSementara.Text & "','" & myDate & "')"
        perintah.Connection = conn
        perintah.ExecuteNonQuery()


        Dim idtransa As String = getLastIdTransaksi()

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

    Private Sub TextBoxUangPembeli_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUangPembeli.TextChanged
        TextBoxKembalian.Text = TextBoxUangPembeli.Text - TextBoxTotalSementara.Text
    End Sub

End Class