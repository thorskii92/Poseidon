Public Class frmNewInstallationPayment
    Private Sub frmNewInstallationPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If MessageBox.Show("Confirm Amount?", "Confirm Amount", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim lstInstall As New ListViewItem
            lstInstall.Text = ""
            lstInstall.SubItems.Add("Installation")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add(txtAmount.Text)
            lstInstall.SubItems.Add("")
            lstInstall.SubItems.Add("")
            WaterBillPayment.lvwAccounts.Items.Add(lstInstall)
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub txtAmount_LostFocus(sender As Object, e As EventArgs) Handles txtAmount.LostFocus
        Dim amt As Decimal = Val(txtAmount.Text)
        If amt < 500 Then
            txtAmount.Text = "500"
        ElseIf amt >= 500 And amt <= 1500 Then
            txtAmount.Text = txtAmount.Text
        ElseIf amt > 1500 Then
            txtAmount.Text = "1500"
        End If

    End Sub
End Class