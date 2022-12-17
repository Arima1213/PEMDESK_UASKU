

Imports TheArtOfDevHtmlRenderer.Adapters

Public Class FormWarehouse
    Dim ff As Integer
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer

    Private Sub FormWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetKu.TBL_PRODUK' table. You can move, or remove it, as needed.
        Me.TBL_PRODUKTableAdapter.Fill(Me.DataSetKu.TBL_PRODUK)
        TextBoxStokHarianSaatIni.Text = GetDataharian()
        Labeltanggal.Text = GetTanggal()

    End Sub

    Public Function GetTanggal() As String

        Dim Tanggal As String

        sqlstr = "SELECT * FROM TBL_STOKHARIAN order by tanggalstocking desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            Tanggal = dt.Rows(0)(1).ToString()
        End If
        Return Tanggal
    End Function

    Private Sub bersih()
        TextBoxStok.Text = ""
        TextBoxNamaMenu.Text = ""
        TextBoxHargaMenu.Text = ""
        TextBoxIdMenu2.Text = ""
        TextBoxNamaMenu2.Text = ""
        TextBoxHargaMenu2.Text = ""
        FormUtama.ButtonWarehouse.PerformClick()

    End Sub

    Public Function GetDataharian() As String

        Dim dataharian As String
        sqlstr = "SELECT * FROM TBL_STOKHARIAN"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        Data = adapter.Fill(dt)
        If Data > 0 Then
            dataharian = dt.Rows(0)(0).ToString()
        End If
        Return dataharian
    End Function

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        koneksi.konek()

        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "INSERT INTO " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_PRODUK" & ControlChars.Quote & " (NAMA_PRODUK, HARGA_PRODUK, STOK_PRODUK) VALUES ('" & TextBoxNamaMenu.Text & "', '" & TextBoxHargaMenu.Text & "', '" & TextBoxStok.Text & "')"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "informasi")
        Catch ex As Exception
            MsgBox("Data gagal disimpan" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        koneksi.tampildata()
        bersih()
    End Sub

    Private Sub DataGridViewMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMenu.CellClick
        ff = e.RowIndex
        If ff < 0 Then

        Else
            TextBoxIdMenu2.Text = Me.DataGridViewMenu(0, ff).Value
            TextBoxNamaMenu2.Text = Me.DataGridViewMenu(1, ff).Value
            TextBoxHargaMenu2.Text = Me.DataGridViewMenu(2, ff).Value
        End If
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        koneksi.konek()

        Try
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "DELETE FROM " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_PRODUK" & ControlChars.Quote & "  WHERE " & ControlChars.Quote & "ID_PRODUK" & ControlChars.Quote & " = '" & Me.DataGridViewMenu(0, ff).Value & "'"
            perintah.Connection = conn
            perintah.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            MsgBox("Data gagal dihapus" + ex.Message, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        koneksi.tampildata()
        bersih()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        konek()
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        'pengurangan stok produk oleh pembelian
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_STOKHARIAN" & ControlChars.Quote & " SET STOK_HARIAN = '" & TextBoxStokHarian.Text & "' WHERE TANGGALSTOCKING = '" & myDate & "'"
        perintah.Connection = conn
        perintah.ExecuteNonQuery()
    End Sub
End Class