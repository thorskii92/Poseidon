Imports MySql.Data.MySqlClient
Public Class frmUpdateNameTransfer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("Confirm Transfer of Ownership?", MsgBoxStyle.YesNo, "Transfer of Ownership Confirmed") = MsgBoxResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=1 WHERE acctID=" & selectedPendingAccountID, con)
            cmd.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblAccountLogs(acctID, ConsID, logDate, logType, DateOfTransaction) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & ",'" & Format(dtpDate.Value, "yyyy-MM-dd") & "','Name Transfer',current_date())", con)
            cmdL.ExecuteNonQuery()
            Dim cmdT As New MySqlCommand("UPDATE tbltransferOwnlog SET dateTrans='" & Format(dtpDate.Value, "yyyy-MM-dd") & "', transbyID=" & loggedUserID & ", confirmeddate=current_date(), transstat=1 WHERE acctID=" & selectedPendingAccountID & " and transstat=2", con)
            cmdT.ExecuteNonQuery()
            Dim cmdTL As New MySqlCommand("INSERT INTO transactionlog(acctID,logType,transactDate) VALUES(@aID, @lType,@tDate)", con)
            cmdTL.Parameters.AddWithValue("@aID", selectedPendingAccountID)
            cmdTL.Parameters.AddWithValue("@lType", 6)
            cmdTL.Parameters.AddWithValue("@tDate", Format(dtpDate.Value.Date, "yyyy-MM-dd"))
            cmdTL.ExecuteNonQuery()
            selectedPendingAccountID = 0
            ViewPendingList(frmPendingList.cboFilter.Text, frmPendingList.txtSearch.Text.Replace("'", "''"))
            MsgBox("Name Transfer Successful", MsgBoxStyle.Information, "Successful")
            selectedPendingAccountID = 0
            Me.Close()
        End If
    End Sub
End Class