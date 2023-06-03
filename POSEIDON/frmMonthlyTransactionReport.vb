Public Class frmMonthlyTransactionReport

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged

    End Sub

    Private Sub frmMonthlyTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Integer = 2000 To Now.Year
            Me.cboYear.Items.Add(x)
        Next
        Me.cboYear.Text = Now.Year
        Me.cboMonth.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        MonthlyTransactionRerortViewer(cboMonth.SelectedIndex + 1, cboYear.Text, repType)
    End Sub
End Class