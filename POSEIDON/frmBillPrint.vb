Public Class frmBillPrint

    Private Sub frmBillPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Me.BillNoticeTableAdapter.Fill(Me.reportingdataset.BillNotice)
        'Me.ReportViewer1.ConsumeContainerWhiteSpace = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class