Public Class frmAnnualTransactionReport

    Private Sub frmAnnualTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Integer = 2000 To Now.Year
            Me.cboYear.Items.Add(x)
        Next
        cboYear.Text = Now.Year
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        AnnualTransactionReport(cboYear.Text, repType)
    End Sub
End Class