Imports MySql.Data.MySqlClient
Public Class frmUpdateReconnection

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("Confirm Reconnection?", MsgBoxStyle.YesNo, "Account Reconnection Confirmation") = MsgBoxResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=1 WHERE AcctID=" & selectedPendingAccountID, con)
            cmd.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblAccountLogs(acctID, ConsID, logDate, logType, DateOfTransaction, resName) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & ",'" & Format(dtpDate.Value, "yyyy-MM-dd") & "','Reconnection',current_date(),@rName)", con)
            cmdL.Parameters.AddWithValue("@rName", txtPlumber.Text)
            cmdL.ExecuteNonQuery()
            Dim cmdLR As New MySqlCommand("UPDATE tblreconnectionlog SET recUID=" & loggedUserID & ", reconDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "', transactReconDate=current_date(), recstat=1", con)
            cmdLR.ExecuteNonQuery()
            Dim cmdTL As New MySqlCommand("INSERT INTO transactionlog(acctID,logType,transactDate) VALUES(@aID, @lType,@tDate)", con)
            cmdTL.Parameters.AddWithValue("@aID", selectedPendingAccountID)
            cmdTL.Parameters.AddWithValue("@lType", 4)
            cmdTL.Parameters.AddWithValue("@tDate", Format(dtpDate.Value.Date, "yyyy-MM-dd"))
            cmdTL.ExecuteNonQuery()
            uaID = 0
            ViewPendingList(frmPendingList.cboFilter.Text, frmPendingList.txtSearch.Text.Replace("'", "''"))
            MsgBox("Reconnection Successful", MsgBoxStyle.Information, "Successful")
            uaID = 0
            Me.Close()
        End If
    End Sub
End Class