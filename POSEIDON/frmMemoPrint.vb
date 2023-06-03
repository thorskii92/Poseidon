Public Class frmMemoPrint

    Private Sub frmMemoPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDataSet.BillAdjustment' table. You can move, or remove it, as needed.
        'Me.BillAdjustmentTableAdapter.Fill(Me.ReportDataSet.BillAdjustment)
        'TODO: This line of code loads data into the 'ReportDataSet.BillAdjustment' table. You can move, or remove it, as needed.
        'Me.BillAdjustmentTableAdapter.Fill(Me.ReportDataSet.BillAdjustment)
        'TODO: This line of code loads data into the 'ReportDataSet.BillAdjustment' table. You can move, or remove it, as needed.
        'Me.BillAdjustmentTableAdapter.Fill(Me.ReportDataSet.BillAdjustment)
        'TODO: This line of code loads data into the 'ReportDataSet.BillAdjustment' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print

    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin
        InsertLog(loggedUserID, "Print Report", "Memo Print Form", "Printed Adjusted Bill Memo")
    End Sub
End Class