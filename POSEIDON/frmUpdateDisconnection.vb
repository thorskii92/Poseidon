Imports MySql.Data.MySqlClient
Public Class frmUpdateDisconnection

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("Confirm Disconnection of Account?", MsgBoxStyle.YesNo, "Account is now Disconnected") = MsgBoxResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=2 WHERE AcctID=" & selectedPendingAccountID, con)
            cmd.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblAccountLogs(acctID, ConsID, logDate, logType, DateOfTransaction, resName, lastReading) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & ",'" & Format(dtpDate.Value, "yyyy-MM-dd") & "','Disconnection',current_date()),@rName,@lRead", con)
            cmdL.Parameters.AddWithValue("@rName", txtPerson.Text)
            cmdL.Parameters.AddWithValue("@lRead", txtLastReading.Text)
            cmdL.ExecuteNonQuery()

            Dim cmdTL As New MySqlCommand("INSERT INTO transactionlog(acctID,logType,transactDate) VALUES(@aID, @lType,@tDate)", con)
            cmdTL.Parameters.AddWithValue("@aID", selectedPendingAccountID)
            cmdTL.Parameters.AddWithValue("@lType", 3)
            cmdTL.Parameters.AddWithValue("@tDate", Format(dtpDate.Value.Date, "yyyy-MM-dd"))

            cmdTL.ExecuteNonQuery()

            selectedPendingAccountID = 0
            ViewPendingList(frmPendingList.cboFilter.Text, frmPendingList.txtSearch.Text.Replace("'", "''"))
            MsgBox("Account has been Disconnected", MsgBoxStyle.Information, "Successful")
            selectedPendingAccountID = 0
            txtPerson.Text = ""
            Me.Close()
        End If
    End Sub
End Class