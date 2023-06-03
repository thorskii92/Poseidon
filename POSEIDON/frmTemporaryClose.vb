Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmTemporaryClose
    Private Sub frmTemporaryClose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' dtpDate.DropDownAlign = LeftRightAlignment.Right
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MessageBox.Show("Confirm Temporary Disconnection of Account?", "Temporary Disconnection", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=8 WHERE acctID=" & acctTempCloseID, con)
            cmd.ExecuteNonQuery()
            Dim cmdT As New MySqlCommand("INSERT INTO tbltempcloselog(acctID, tempCloseDate, tempCloseReason) VALUES(@aID, @tcDate, @tcReason)", con)
            cmdT.Parameters.AddWithValue("@aID", acctTempCloseID)
            cmdT.Parameters.AddWithValue("@tcDate", dtpDate.Value.Date)
            cmdT.Parameters.AddWithValue("@tcReason", txtReason.Text)
            cmdT.ExecuteNonQuery()
            Dim cmdL As New MySqlCommand("INSERT INTO tblaccountlogs(AcctID, logDate, LogType, DateOfTransaction) VALUES(@aID, current_date(), @lType, @dateTrans)", con)
            cmdL.Parameters.AddWithValue("@aID", acctTempCloseID)
            cmdL.Parameters.AddWithValue("@lType", "Pending Temporary Closure")
            cmdL.Parameters.AddWithValue("@dateTrans", dtpDate.Value.Date)
            cmdL.ExecuteNonQuery()
            txtReason.Text = ""
            Me.Close()
        End If
    End Sub
End Class