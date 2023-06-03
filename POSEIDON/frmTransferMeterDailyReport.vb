Public Class frmTransferMeterDailyReport

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        DailyTransferMeterReport(dtpDate.Value)
    End Sub
End Class