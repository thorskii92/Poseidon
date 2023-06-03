Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmConsumpSummarySelect
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmConsumpSummarySelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonths()
        LoadYears()
    End Sub

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

    Private Sub LoadConsSummaryReport(rMonth As String, rYear As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Z.zoneID, Z.Abbrv, Z.PlantName, R.AddBrgy, SUM(B.consump) as consump, SUM(B.amount) as amount, B.billMonth, B.billYear FROM billing AS B LEFT JOIN brgylist as R ON B.brgyID=R.brgyID LEFT JOIN zones AS Z ON Z.zoneID=R.zoneID WHERE B.billMonth='" & rMonth & "' and B.billYear=" & rYear & " GROUP BY B.brgyID ORDER BY Z.zoneID ", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim report As New crptConsumptionSummary
            report.SetDataSource(dt)
            frmConsumptionSummaryReport.CrystalReportViewer1.ReportSource = report
            frmConsumptionSummaryReport.CrystalReportViewer1.Zoom(100%)
            frmConsumptionSummaryReport.CrystalReportViewer1.Refresh()
            frmConsumptionSummaryReport.WindowState = FormWindowState.Maximized
            frmConsumptionSummaryReport.ShowDialog()
        End If

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If cboYear.Text <> "" Or cboMonth.Text <> "" Then
            LoadConsSummaryReport(cboMonth.Text, cboYear.Text)
        End If


    End Sub
End Class