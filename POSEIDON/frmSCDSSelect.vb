Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmSCDSSelect

    Private Sub LoadMonths()
        cboMonth.Items.Clear()
        For x As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(x))
        Next
    End Sub

    Private Sub LoadYears()
        cboYear.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT min(billYear), max(billYear) FROM billing", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim i As Integer = Val(dt.Rows(0).Item(0).ToString)
            Dim j As Integer = Val(dt.Rows(0).Item(1).ToString)
            For x As Integer = i To j
                cboYear.Items.Add(x)
            Next
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim dt As New DataTable
        dt = SCDS(cboMonth.Text, cboYear.Text)
        Dim report As New crptSCDS
        report.SetDataSource(dt)
        frmSCDSReport.CrystalReportViewer1.ReportSource = report
        frmSCDSReport.CrystalReportViewer1.Zoom(100%)
        frmSCDSReport.CrystalReportViewer1.Refresh()
        frmSCDSReport.WindowState = FormWindowState.Maximized
        frmSCDSReport.ShowDialog()
    End Sub

    Private Sub frmSCDSSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonths()
        LoadYears()
    End Sub
End Class