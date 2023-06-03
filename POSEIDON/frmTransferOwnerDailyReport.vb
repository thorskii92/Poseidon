Public Class frmTransferOwnerDailyReport

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        DailyTransferOwnReport(dtpDate.Value)
    End Sub
End Class