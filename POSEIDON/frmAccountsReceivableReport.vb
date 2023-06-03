Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAccountsReceivableReport

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim dt As New DataTable
        dt = LoadAccountsReceivables(arBrgyID(cboBrgy.SelectedIndex), cboMonth.Text, Val(cboYear.Text))
        dgvAR.DataSource = dt
    End Sub

    Private Sub frmAccountsReceivableReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAR.Rows.Clear()
        LoadYear()
        LoadBrgy()
        LoadMonths()
    End Sub

    Private Sub LoadMonths()
        cboMonth.Items.Clear()
        For x As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(x).ToString)
        Next
    End Sub

    Private Sub LoadYear()
        cboYear.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT min(billyear), max(billyear) FROM billing", con)
        da.Fill(dt)
        Dim minY As Integer = 2019
        Dim maxY As Integer = 2020
        If dt.Rows.Count > 0 Then
            minY = Val(dt.Rows(0).Item(0).ToString)
            maxY = Val(dt.Rows(0).Item(1).ToString)
        End If
        For x As Integer = minY To maxY
            cboYear.Items.Add(x)
        Next
    End Sub

    Private Sub LoadBrgy()
        cboBrgy.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arBrgyID(x) = dt.Rows(x).Item(0)
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim dt As New DataTable
        dt = LoadAccountsReceivables(arBrgyID(cboBrgy.SelectedIndex), cboMonth.Text, Val(cboYear.Text))
        Dim report As New crptAR
        report.SetDataSource(dt)
        frmAccountsReceivablePrint.CrystalReportViewer1.ReportSource = report
        frmAccountsReceivablePrint.CrystalReportViewer1.Zoom(100%)
        frmAccountsReceivablePrint.CrystalReportViewer1.Refresh()
        frmAccountsReceivablePrint.WindowState = FormWindowState.Maximized
        frmAccountsReceivablePrint.ShowDialog()
    End Sub
End Class