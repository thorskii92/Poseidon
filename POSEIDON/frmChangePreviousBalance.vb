Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmChangePreviousBalance
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strStat As String
        Dim amt As Double = Val(txtAmount.Text)
        'MessageBox.Show(amt & " " & arrBillChangePrevID)
        If amt > 0 Then
            strStat = "UNPAID"
        Else
            strStat = "PAID"
        End If
        Dim cmd As New MySqlCommand("UPDATE billing SET prevOutstanding=" & amt & ", prevoutstandingstat='" & strStat & "' WHERE billID=" & arrBillChangePrevID, con)
        cmd.ExecuteNonQuery()
        txtAmount.Text = ""
        MessageBox.Show("Previous Balance has been changed", "Previous Balance Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class