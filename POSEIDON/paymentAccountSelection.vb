Public Class paymentAccountSelection
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        appOpenForm = 2
        LoadApplicationBalance(arrApplicationAccountID(lvw.FocusedItem.Index))
        'frmApplicationBalance.acctNo =
        Me.Close()
    End Sub
End Class