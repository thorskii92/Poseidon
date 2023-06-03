Public Class frmPendingPrintView

    Private Sub frmPendingPrintView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDataSet.PendingListDataSet' table. You can move, or remove it, as needed.
        'Me.PendingListDataSetTableAdapter.Fill(Me.ReportDataSet.PendingListDataSet)
        'TODO: This line of code loads data into the 'ReportDataSet.PendingListDataSet' table. You can move, or remove it, as needed.
        'Me.PendingListDataSetTableAdapter.Fill(Me.ReportDataSet.PendingListDataSet)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class