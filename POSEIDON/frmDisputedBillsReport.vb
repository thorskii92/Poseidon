Public Class frmDisputedBillsReport

    Private Sub frmDisputedBillsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDataSet.AdjustedBills' table. You can move, or remove it, as needed.
        'Me.AdjustedBillsTableAdapter.Fill(Me.ReportDataSet.AdjustedBills)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class