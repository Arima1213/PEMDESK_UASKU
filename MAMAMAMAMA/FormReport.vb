
Imports System.Data.OracleClient
Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Public Class FormReport
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GetDataTotalPenjualanHariIni() = "" Then
            Label_totalPemasukanHariini.Text = 0
        Else
            Label_totalPemasukanHariini.Text = GetDataTotalPenjualanHariIni()
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



        loadPie()


    End Sub

    Sub loadPie()
        Dim urutan As Integer = 0
        Dim data() = getAllMenuData()
        Dim nilai() As Integer = getAllMenuJumlah()

        For urutan = 0 To 4
            GunaPieDataset1.DataPoints.Add(data(urutan), nilai(urutan))
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
    Public Function Example()
        Dim kkk As Integer = GetAllMenuCount()

    End Function

    Public Function getAllMenuData()

        Dim menu(0 To GetAllMenuCount() - 1) As String
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

    Public Function getAllMenuJumlah()

        Dim menu(0 To GetAllMenuCount() - 1) As Integer
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

    Public Function GetDataTotalPenjualanHariIni() As String

        Dim total As String
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        sqlstr = "select to_char(sum(TOTAL_TRANSAKSI), '$99,999,999') from TBL_TRANSAKSI where tanggal_transaksi in to_date('" & myDate & "', 'dd-mm-yyyy')"
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

        sqlstr = "select sum(jumlah_pesanan) from tbl_transaksi where tanggal_transaksi <= trunc(sysdate)
and tanggal_transaksi >= trunc(sysdate - 7)"
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

        sqlstr = "select to_char(sum(TOTAL_TRANSAKSI), '$99,999,999') from TBL_TRANSAKSI"
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