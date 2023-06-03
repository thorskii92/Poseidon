Public Class frmNoticeOfCollection

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CollectionNoticeSelected(selBillMetID)
        frmCollectionNotice.Show()
    End Sub
End Class