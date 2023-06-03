Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmDateSelectionDailyCollectionReport
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM poseidondb.tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE O.pDate='" & Format(dtpDate.Value.Date, "yyyy-MM-dd") & "' ORDER BY ORNum", con)
        da.Fill(dt)
        Dim report As New crptDailyCollection
        report.SetDataSource(dt)
        frmDailyCollectionReport.CrystalReportViewer1.ReportSource = report
        frmDailyCollectionReport.CrystalReportViewer1.Zoom(100%)
        frmDailyCollectionReport.CrystalReportViewer1.Refresh()
        'frmCrystalOR.CrystalReportViewer1.RefreshReport()
        frmDailyCollectionReport.WindowState = FormWindowState.Maximized
        frmDailyCollectionReport.ShowDialog()

    End Sub
End Class