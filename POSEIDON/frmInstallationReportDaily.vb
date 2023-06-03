Public Class frmInstallationReportDaily

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        DailyInstallationReport(dtpDate.Value)
    End Sub
End Class