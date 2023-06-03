Imports MySql.Data.MySqlClient
Public Class frmUpdateTransMeter

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("Confirm Transfer of Water Meter?", MsgBoxStyle.YesNo, "Water Transfer Confirmation") = MsgBoxResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=1 WHERE AcctID=" & selectedPendingAccountID, con)
            cmd.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblAccountLogs(acctID, ConsID, logDate, logType, DateOfTransaction) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & ",'" & Format(dtpDate.Value, "yyyy-MM-dd") & "','Meter Transfer',current_date())", con)
            cmdL.ExecuteNonQuery()
            frmPendingList.cboFilter.Text = ""
            frmPendingList.txtSearch.Text = ""

            Dim cmdTL As New MySqlCommand("INSERT INTO transactionlog(acctID,logType,transactDate) VALUES(@aID, @lType,@tDate)", con)
            cmdTL.Parameters.AddWithValue("@aID", selectedPendingAccountID)
            cmdTL.Parameters.AddWithValue("@lType", 5)
            cmdTL.Parameters.AddWithValue("@tDate", Format(dtpDate.Value.Date, "yyyy-MM-dd"))
            cmdTL.ExecuteNonQuery()
            ViewPendingList(frmPendingList.cboFilter.Text, frmPendingList.txtSearch.Text.Replace("'", "''"))
            MsgBox("Meter Transfer Successful", MsgBoxStyle.Information, "Successful")
            selectedPendingAccountID = 0
            Me.Close()
        End If
    End Sub
End Class