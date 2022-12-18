Public Class FormUtama
    Public currentChildForm As Form
    Dim dt As DataTable
    Dim adapter As OracleDataAdapter
    Dim sqlstr As String
    Dim data As Integer

    Private Sub FormUtama_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))
        If GetTanggal() = myDate Then
        Else
            UpdateStokHarian()
        End If
        OpenChildForm(New FormTransaction)
        koneksi.Konek()
        koneksi.Tampildata()
        ButtonTransaction.Focus()
        FormLogin.Hide()
    End Sub
    Public Sub OpenChildForm(childForm As Form)
        currentChildForm?.Close()
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OpenChildForm(New FormReport)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        OpenChildForm(New FormTransaction)
    End Sub
    Private Sub ButtonWarehouse_Click(sender As Object, e As EventArgs)
        OpenChildForm(New FormWarehouse)
        koneksi.Tampildata()
    End Sub

    Public Function GetNilai() As String

        Dim nilai As String

        sqlstr = "select * from tbl_stokharian order by tanggalstocking desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        nilai = dt.Rows(0)(0).ToString()
        Return nilai
    End Function

    Public Function GetTanggal() As String

        Dim nilai As String

        sqlstr = "select * from tbl_stokharian order by tanggalstocking desc"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        nilai = dt.Rows(0)(1).ToString()
        Return nilai
    End Function

    Public Function UpdateStok(nilai As String) As String
        Dim adapter As OracleDataAdapter
        Dim sqlstr As String
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        'mengambil nilai jumlah produk di database
        sqlstr = "UPDATE " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_PRODUK" & ControlChars.Quote & " SET STOK_PRODUK = '" & nilai & "'"
        adapter = New OracleDataAdapter(sqlstr, conn)
    End Function



    Public Function UpdateStokHarian()

        Dim Tanggal As String
        Dim myDate = Convert.ToDateTime(Now.ToString("dd-MMM-yyyy"))

        sqlstr = "select tanggalstocking from tbl_stokharian where tanggalstocking like(to_date('" & myDate & "', 'dd/mm/yyyy'))"
        adapter = New OracleDataAdapter(sqlstr, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data = 0 Then
            sqlstr = "INSERT INTO " & ControlChars.Quote & "DBWARUNG" & ControlChars.Quote & "." & ControlChars.Quote & "TBL_STOKHARIAN" & ControlChars.Quote & "   (STOK_HARIAN, TANGGALSTOCKING) VALUES ('" & GetNilai() & "', TO_DATE('" & myDate & "', 'dd/mm/yyyy'))"
            adapter = New OracleDataAdapter(sqlstr, conn)
            UpdateStok(GetNilai())
        Else
            UpdateStok(GetNilai())
        End If
    End Function

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles ButtonTransaction.Click
        OpenChildForm(New FormTransaction)
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub ButtonWarehouse_Click_1(sender As Object, e As EventArgs) Handles ButtonWarehouse.Click

        OpenChildForm(New FormWarehouse)
        Button2.Visible = True
        Button1.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click

        OpenChildForm(New FormReport)
        Button3.Visible = True
        Button1.Visible = False
        Button2.Visible = False
    End Sub
End Class
