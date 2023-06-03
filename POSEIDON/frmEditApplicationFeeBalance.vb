Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmEditApplicationFeeBalance
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim amt As Decimal = txtBalance.Text
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM applicationfeetotalbalance WHERE acctID=" & AppFeeEditID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim cmd As New MySqlCommand("UPDATE applicationfeetotalbalance SET balance=" & amt & " WHERE acctID=" & AppFeeEditID, con)
            cmd.ExecuteNonQuery()
        Else
            Dim cmd As New MySqlCommand("INSERT INTO applicationfeetotalbalance(acctID,balance, consID) VALUES(" & AppFeeEditID & ", " & amt & "," & AppFeeEditConsID & ")", con)
            cmd.ExecuteNonQuery()
        End If
        AccountFormList(arrAcctListBrgyID(frmAccountsList.cboBarangay.SelectedIndex), frmAccountsList.txtSearch.Text.Replace("'", "`"), acFilter)
        Me.Close()
    End Sub
End Class