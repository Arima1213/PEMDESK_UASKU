Imports System.Data.OracleClient

Module koneksi
    Public MySQLReader As OracleDataAdapter
    Public CMD As New OracleCommand
    Public DA As New OracleDataAdapter
    Public mystring As String = "data source=XE; user id=DBWARUNG; password=123;"
    Public conn As New OracleConnection(mystring)
    Public perintah As New OracleCommand
    Public dataku As New OracleDataAdapter
    Public ds As New DataSet
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer

    Public Sub konek()
        If conn.State = ConnectionState.Closed Then
            Try
                conn.ConnectionString = myString
                conn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("Koneksi Gagal" & vbCrLf & "Mohon cek apakah server sudah siap!", "Koneksi ke server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub


    Public Sub tampildata2()


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

    Public Function getDataPenjualan() As String

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




    Public Function getLastIdTransaksi() As String

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


    Public Function GetDataharian() As String

        Dim dataharian As String

        sqlstr = "SELECT * FROM TBL_STOKHARIAN"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            dataharian = dt.Rows(0)(0).ToString()
        End If
        Return dataharian
    End Function



    Public Sub tampildata()


        sqlstr = "SELECT * FROM TBL_PRODUK"
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

End Module
