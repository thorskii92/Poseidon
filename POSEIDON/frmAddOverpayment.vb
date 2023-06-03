Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAddOverpayment
    Public AcctID() As Integer
    Public acctNo() As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MessageBox.Show("Confirm Overpayment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT acctID, accountno, accountname FROM consumeraccounts WHERE acctID=" & AcctID(cboAccount.SelectedIndex), con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim lst As New ListViewItem
                lst.Text = ""
                lst.SubItems.Add("Overpayment")
                lst.SubItems.Add("")
                lst.SubItems.Add(acctNo(cboAccount.SelectedIndex))
                lst.SubItems.Add(dt.Rows(0).Item(2).ToString)
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add(Format(Val(txtAmount.Text), "#,##0.#0"))
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                lst.SubItems.Add("")
                WaterBillPayment.lvwAccounts.Items.Add(lst)
                Me.Close()
            Else
                MessageBox.Show("Please select an account", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub
End Class