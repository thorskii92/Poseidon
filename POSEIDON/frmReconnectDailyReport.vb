Public Class frmReconnectDailyReport

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        DailyReconnect(dtpDate.Value)
    End Sub
End Class