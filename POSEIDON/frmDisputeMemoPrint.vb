Public Class frmDisputeMemoPrint

    Private Sub frmDisputeMemoPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDataSet.DisputeMemoAdapter' table. You can move, or remove it, as needed.
        'Me.DisputeMemoAdapterTableAdapter.Fill(Me.ReportDataSet.DisputeMemoAdapter)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class