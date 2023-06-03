Public Class frmPendingMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPendingList.MdiParent = frmAdminPanel
        frmPendingList.WindowState = FormWindowState.Maximized
        frmPendingList.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmBillAdjustmentRequestForm.MdiParent = frmAdminPanel
        frmBillAdjustmentRequestForm.WindowState = FormWindowState.Maximized
        frmBillAdjustmentRequestForm.Show()
        Me.Close()
    End Sub
End Class