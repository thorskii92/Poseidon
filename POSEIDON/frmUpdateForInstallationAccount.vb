Imports MySql.Data.MySqlClient
Public Class frmUpdateForInstallationAccount

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearFields()
        Me.Close()
    End Sub

    Private Sub ClearFields()
        txtAccountNo.Text = ""
        txtConsumerName.Text = ""
        txtMetBrand.Text = ""
        txtMeterNo.Text = ""
        txtMetReference.Text = ""
        txtMetSize.Text = ""
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("The Account will be set to Connected. Please confirm by Pressing Yes.", MsgBoxStyle.YesNo, "Confirm Changes") = MsgBoxResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET MeterNo='" & txtMeterNo.Text.Replace("'", "`") & "', MeterBrand='" & txtMetBrand.Text.Replace("'", "`") & "', MeterSize='" & txtMetSize.Text.Replace("'", "`") & "', MeterReference='" & txtMetReference.Text.Replace("'", "`") & "', ConnectionDate='" & Format(dtpConDate.Value, "yyyy-MM-dd") & "', AcctStatus = 1 WHERE acctID=" & selectedPendingAccountID, con)
            cmd.ExecuteNonQuery()
            Dim cmdAL As New MySqlCommand("Insert Into tblaccountlogs(acctID,consid,logdate,logtype,dateoftransaction) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & ",'" & Format(dtpConDate.Value, "yyyy-MM-dd") & "','Installation',current_date())", con)
            cmdAL.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblinstallationlog(acctID, consID, uID, installdate, transactDate) VALUES(" & selectedPendingAccountID & "," & SelectedPendingConsumerID & "," & loggedUserID & ",'" & Format(dtpConDate.Value, "yyyy-MM-dd") & "',current_date())", con)
            cmdL.ExecuteNonQuery()
            Dim cmdTL As New MySqlCommand("INSERT INTO transactionlog(acctID,logType,transactDate) VALUES(@aID, @lType,@tDate)", con)
            cmdTL.Parameters.AddWithValue("@aID", selectedPendingAccountID)
            cmdTL.Parameters.AddWithValue("@lType", 2)
            cmdTL.Parameters.AddWithValue("@tDate", Format(dtpConDate.Value.Date, "yyyy-MM-dd"))
            cmdTL.ExecuteNonQuery()
            MsgBox("Account No.: " & txtAccountNo.Text & " is now set to Connected Status.", MsgBoxStyle.Information, "Connected")
            ClearFields()
            frmPendingList.cboFilter.Text = ""
            frmPendingList.txtSearch.Text = ""
            ViewPendingList(frmPendingList.cboFilter.Text, frmPendingList.txtSearch.Text.Replace("'", "''"))
            Me.Close()
        End If
    End Sub
End Class