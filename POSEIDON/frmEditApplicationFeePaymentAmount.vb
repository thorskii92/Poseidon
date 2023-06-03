Public Class frmEditApplicationFeePaymentAmount
    Public index As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MessageBox.Show("Done?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim amt As Double = Val(txtNewAmount.Text)
            WaterBillPayment.lvwAccounts.Items(index).SubItems(13).Text = Format(amt, "#,##0.#0")
            Me.Close()
        End If

    End Sub
End Class