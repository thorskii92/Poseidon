Public Class frmPaymentSelection
    Dim acctCode As String
    Private Sub btnNewCon_Click(sender As Object, e As EventArgs) Handles btnNewCon.Click
        Dim lst As New ListViewItem
        lst.Text = "Application for New Connection"
        'lst.SubItems.Add(GetAccountCodes(1))
        acctCode = GetAccountCodes(1)
        lst.SubItems.Add("")
        lst.SubItems.Add(Format(pAmount, "#.#0"))
        lst.SubItems.Add("Installation")
        frmPaymentCollection.lvwCollection.Items.Add(lst)
        CountAmount()
        Me.Close()
    End Sub

    Private Sub btnTransMeter_Click(sender As Object, e As EventArgs) Handles btnTransMeter.Click
        Dim lst As New ListViewItem
        lst.Text = "Transfer of Meter"
        'lst.SubItems.Add(GetAccountCodes(2))
        acctCode = GetAccountCodes(2)
        lst.SubItems.Add("")
        lst.SubItems.Add(Format(pAmount, "#.#0"))
        lst.SubItems.Add("Meter")
        frmPaymentCollection.lvwCollection.Items.Add(lst)
        CountAmount()
        Me.Close()
    End Sub

    Private Sub btnRecon_Click(sender As Object, e As EventArgs) Handles btnRecon.Click
        Dim lst As New ListViewItem
        lst.Text = "Reconnection"
        'lst.SubItems.Add(GetAccountCodes(3))
        acctCode = GetAccountCodes(3)
        lst.SubItems.Add("")
        lst.SubItems.Add(Format(pAmount, "#.#0"))
        lst.SubItems.Add("Reconnection")
        frmPaymentCollection.lvwCollection.Items.Add(lst)
        CountAmount()
        Me.Close()
    End Sub

    Private Sub btnTransOwner_Click(sender As Object, e As EventArgs) Handles btnTransOwner.Click
        Dim lst As New ListViewItem
        lst.Text = "Transfer of Ownership"
        acctCode = GetAccountCodes(4)
        'lst.SubItems.Add(GetAccountCodes(4))
        lst.SubItems.Add("")
        lst.SubItems.Add(Format(pAmount, "#.#0"))
        lst.SubItems.Add("Ownership")
        frmPaymentCollection.lvwCollection.Items.Add(lst)
        CountAmount()
        Me.Close()
    End Sub

    Private Sub btnPWaterBill_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnServiceFee_Click(sender As Object, e As EventArgs) Handles btnServiceFee.Click
        frmSpecifyAmount.StartPosition = FormStartPosition.CenterScreen
        intType = 5
        frmSpecifyAmount.txtAmount.Text = ""
        frmSpecifyAmount.ShowDialog()
    End Sub

    Private Sub btnAdvPayment_Click(sender As Object, e As EventArgs) Handles btnAdvPayment.Click
        frmSpecifyAmount.StartPosition = FormStartPosition.CenterScreen
        intType = 6
        frmSpecifyAmount.txtAmount.Text = ""
        frmSpecifyAmount.ShowDialog()
    End Sub
End Class