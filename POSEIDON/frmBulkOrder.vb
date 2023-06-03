Public Class frmBulkOrder
    Dim cub As Integer
    Dim totAmount As Decimal
    Dim percub As Decimal
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBulkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cub = 0
        totAmount = 0
        percub = 250
        txtCubic.Focus()
    End Sub

    Private Sub txtCubic_TextChanged(sender As Object, e As EventArgs) Handles txtCubic.TextChanged
        totAmount = totalBulkAmount(Val(txtCubic.Text), percub)
        lblAmount.Text = Format(totAmount, "#,##0.#0")
    End Sub

    Private Function totalBulkAmount(cubic As Integer, percubic As Decimal)
        Dim mybulk As Decimal = 0
        mybulk = cubic * percubic
        Return mybulk
    End Function

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MessageBox.Show("Confirm Amount?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim lstReconnect As New ListViewItem
            lstReconnect.Text = ""
            lstReconnect.SubItems.Add("Bulk Order")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add(Format(totAmount, "0.#0"))
            lstReconnect.SubItems.Add("")
            lstReconnect.SubItems.Add("")
            WaterBillPayment.lvwAccounts.Items.Add(lstReconnect)
            Me.Close()
        End If

    End Sub
End Class