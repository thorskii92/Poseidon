Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmDisconnectionUpdate
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmDisconnection_Click(sender As Object, e As EventArgs) Handles btnConfirmDisconnection.Click
        frmUpdateDisconnection.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnCancelDisconnection_Click(sender As Object, e As EventArgs) Handles btnCancelDisconnection.Click
        If MessageBox.Show("Return Account to Connected State?", "Cancel Disconnection", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=1 WHERE AcctID=" & selectedPendingAccountID, con)
            cmd.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblAccountLogs(acctID, ConsID, logDate, logType, DateOfTransaction) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & ",current_date(),'Cancel Disconnection',current_date())", con)
            cmdL.ExecuteNonQuery()

            selectedPendingAccountID = 0

            ViewPendingList(frmPendingList.cboFilter.Text, frmPendingList.txtSearch.Text.Replace("'", "''"))
            MsgBox("Account has been Returned to Connected State", MsgBoxStyle.Information, "Successful")
            selectedPendingAccountID = 0
            Me.Close()
        End If

    End Sub
End Class