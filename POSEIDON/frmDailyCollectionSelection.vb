Public Class frmDailyCollectionSelection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmORGroupSelection.StartPosition = FormStartPosition.CenterScreen
        frmORGroupSelection.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmDateSelectionDailyCollectionReport.ShowInTaskbar = False
        frmDateSelectionDailyCollectionReport.StartPosition = FormStartPosition.CenterScreen
        frmDateSelectionDailyCollectionReport.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmDailyCollectionORRange.StartPosition = FormStartPosition.CenterScreen
        frmDailyCollectionORRange.ShowDialog()

    End Sub
End Class