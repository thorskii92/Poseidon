Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmChangeClass
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        If cboClass.Text = "" Then
            MessageBox.Show("Nothing Selected", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("Confirm Change of Classification?", "Change Class", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                selectedChangeClassID = arrChangeClassID(cboClass.SelectedIndex)
                Cons()
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET classID=" & selectedChangeClassID & " WHERE acctID=" & selectedAcctIDLedger, con)
                cmd.ExecuteNonQuery()
                frmAccountsList.lvwAccounts.Items(accountListIndex).SubItems(9).Text = cboClass.Text
                Me.Close()
            End If
        End If

    End Sub

    Private Sub cboClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClass.SelectedIndexChanged
        selectedChangeClassID = arrChangeClassID(cboClass.SelectedIndex)
    End Sub
End Class