Imports System.Data.OracleClient

Module koneksi
    Public MySQLReader As OracleDataAdapter
    Public CMD As New OracleCommand
    Public DA As New OracleDataAdapter
    Public mystring As String = "data source=XE; user id=DBWARUNG; password=123;"
    Public conn As New OracleConnection(mystring)
    Public perintah As New OracleCommand
    Public ds As New DataSet
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer

    Public Sub Konek()
        If conn.State = ConnectionState.Closed Then
            Try
                conn.ConnectionString = mystring
                conn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("Koneksi Gagal" & vbCrLf & "Mohon cek apakah server sudah siap!", "Koneksi ke server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub


    Public Sub Tampildata()


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
