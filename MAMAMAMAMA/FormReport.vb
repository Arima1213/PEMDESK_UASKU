Public Class FormReport
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GetnilaiPenjualanHariIni() = "" Then
            labelMenuTerjualHariIni.Text = 0
        Else
            labelMenuTerjualHariIni.Text = GetnilaiPenjualanHariIni()
        End If

        If GetDataTotalPenjualan() = "" Then
            LABEL_TOTAL_PENJUALAN.Text = 0
        Else
            LABEL_TOTAL_PENJUALAN.Text = GetDataTotalPenjualan()
        End If

        If GetDataTotalPenjualanHariIni() = "" Then
            Label_totalPemasukanHariini.Text = 0
        Else
            Label_totalPemasukanHariini.Text = GetDataTotalPenjualanHariIni()
        End If

        If GetnilaiPenjualanMingguIni() = "" Then
            labelMenuTerjualMingguIni.Text = 0
        Else
            labelMenuTerjualMingguIni.Text = GetnilaiPenjualanMingguIni()
        End If

        LoadHorizontalBar()

        LoadPie()


    End Sub

    Sub LoadPie()
        Dim urutan As Integer = 0
        Dim data() = getAllMenuData()
        Dim nilai() As Integer = getAllMenuJumlah()

        For urutan = 0 To 4
            GunaPieDataset1.DataPoints.Add(data(urutan), nilai(urutan))
        Next


    End Sub
    Sub LoadHorizontalBar()
        Dim urutan As Integer = 0
        Dim data() = Get7hariPenjualan_hari()
        Dim nilai() As Integer = Get7hariPenjualan_total()

        For urutan = 0 To 3
            GunaHorizontalBarDataset1.DataPoints.Add(data(urutan), nilai(urutan))
        Next


    End Sub

    Public Function GetAllMenuCount()

        Dim Menuku As String


        sqlstr = "select  count(distinct nama_produk) from tbl_detail_transaksi"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        Menuku = dt.Rows(0)(0).ToString()
        Return Menuku
    End Function

    Public Function GetAllMenuData()

        Dim menu(0 To 5) As String
        Dim urutan As Integer = 0
        sqlstr = "select nama_produk, sum(jumlah) as jml from tbl_detail_transaksi group by nama_produk order by jml desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        For urutan = 0 To 4
            menu(urutan) = dt.Rows(urutan)(0).ToString()
        Next urutan
        Return menu
    End Function

    Public Function GetAllMenuJumlah()

        Dim menu(0 To 5) As Integer
        Dim urutan As Integer = 0
        sqlstr = "select nama_produk, sum(jumlah) as jml from tbl_detail_transaksi group by nama_produk order by jml desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        For urutan = 0 To 4
            menu(urutan) = dt.Rows(urutan)(1).ToString()
        Next urutan
        Return menu
    End Function

    Public Function Get7hariPenjualan_hari()

        Dim menu(0 To 5) As String
        Dim urutan As Integer = 0
        sqlstr = "select sum(total_transaksi), to_char(TANGGAL_TRANSAKSI, 'day') from TBL_TRANSAKSI group by tanggal_transaksi order by tanggal_transaksi desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        For urutan = 0 To 3
            menu(urutan) = dt.Rows(urutan)(1).ToString()
        Next urutan
        Return menu
    End Function
    Public Function Get7hariPenjualan_total()

        Dim menu(0 To 5) As Integer
        Dim urutan As Integer = 0
        sqlstr = "select sum(total_transaksi), to_char(TANGGAL_TRANSAKSI, 'day') from TBL_TRANSAKSI group by tanggal_transaksi order by tanggal_transaksi desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)

        For urutan = 0 To 3
            menu(urutan) = dt.Rows(urutan)(0).ToString()
        Next urutan
        Return menu
    End Function

    Public Function GetDataTotalPenjualanHariIni() As String

        Dim total As String
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        sqlstr = "select to_char(sum(TOTAL_TRANSAKSI), '99,999,999') from TBL_TRANSAKSI where tanggal_transaksi in to_date('" & myDate & "', 'dd-mm-yyyy')"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            total = dt.Rows(0)(0).ToString()
        Else
            total = 0
        End If
        Return total
    End Function

    Public Function GetnilaiPenjualanHariIni() As String

        Dim total As String
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        sqlstr = "select sum(jumlah_pesanan) from tbl_transaksi where tanggal_transaksi in to_date('" & myDate & "', 'dd-mm-yyyy')"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            total = dt.Rows(0)(0).ToString()
        Else
            total = 0
        End If
        Return total
    End Function

    Public Function GetnilaiPenjualanMingguIni() As String

        Dim total As String
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        sqlstr = "select sum(jumlah_pesanan) from tbl_transaksi where tanggal_transaksi <= trunc(sysdate)and tanggal_transaksi >= trunc(sysdate - 7)"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            total = dt.Rows(0)(0).ToString()
        Else
            total = 0
        End If
        Return total
    End Function

    Public Function GetDataTotalPenjualan() As String

        Dim total As String

        sqlstr = "select to_char(sum(TOTAL_TRANSAKSI), '99,999,999') from TBL_TRANSAKSI"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            total = dt.Rows(0)(0).ToString()
        Else
            total = 0
        End If
        Return total
    End Function

End Class