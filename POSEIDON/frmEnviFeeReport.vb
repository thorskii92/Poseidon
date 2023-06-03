Imports MySql.Data.MySqlClient
Public Class frmEnviFeeReport

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ViewEnviFeeReport(dtpFrom.Value, dtpTo.Value)
    End Sub

    Private Sub frmEnviFeeReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strQuertyEnvi = ""
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If strQuertyEnvi = "" Then
            MsgBox("Please generate report", MsgBoxStyle.Exclamation, "Nothing to Print")
        Else
            If enFeeCount > 0 Then
                Cons()
                Dim da As New MySqlDataAdapter(strQuertyEnvi, con)
                da.Fill(frmEnviFeeReportPrint.ReportDataSet.EnvironmentalReport)
                frmEnviFeeReportPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                frmEnviFeeReportPrint.ReportViewer1.ZoomPercent = 100%
                frmEnviFeeReportPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                frmEnviFeeReportPrint.ReportViewer1.Width = 75
                frmEnviFeeReportPrint.WindowState = FormWindowState.Maximized
                frmEnviFeeReportPrint.Show()
            Else
                MsgBox("Nothing to Print", MsgBoxStyle.Exclamation, "No Report")
            End If
        End If
    End Sub
End Class