Public Class frmSystemHistory

    Private Sub frmSystemHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSystemHistory()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSystemHistory()
    End Sub
End Class