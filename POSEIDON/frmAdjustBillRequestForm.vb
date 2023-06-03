Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmAdjustBillRequestForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MessageBox.Show("Confirm Submission of Request for Inspection?", "Submit Request", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim intAcctID As Integer
            Dim intConsID As Integer
            Dim intClusterID As Integer
            Dim cmd As New MySqlCommand("UPDATE billing SET adjRemark='Request', adjReason=@reason, adjPrep=" & prepareeID & " WHERE billID=" & selectedPendingBIllID, con)
            cmd.Parameters.AddWithValue("@reason", txtReason.Text)
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT acctID, consID, clusterID FROM billing WHERE billID=" & selectedPendingBIllID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                intAcctID = Val(dt.Rows(0).Item(0))
                intConsID = Val(dt.Rows(1).Item(0))
                intClusterID = Val(dt.Rows(2).Item(0))
            End If
            Dim cmdReq As New MySqlCommand("INSERT INTO tblbilladjustmentrequestform(acctID,clusterID,consID,requestDate,adjReason,preparedby,requestedby,billID) values(@aID,@clID,@coID,@reqDate,@adjRsn,@prep,@req,@bID)", con)
            cmdReq.Parameters.AddWithValue("@aID", intAcctID)
            cmdReq.Parameters.AddWithValue("@clID", intClusterID)
            cmdReq.Parameters.AddWithValue("@coID", intConsID)
            cmdReq.Parameters.AddWithValue("@reqDate", Today.Date.ToShortDateString)
            cmdReq.Parameters.AddWithValue("@adjRsn", txtReason.Text)
            cmdReq.Parameters.AddWithValue("@prep", lblPreparee.Text)
            cmdReq.Parameters.AddWithValue("@req", lblRequestee.Text)
            cmdReq.Parameters.AddWithValue("@bID", selectedPendingBIllID)
            cmdReq.ExecuteNonQuery()
            ShowBillsForRequest()
            Me.Close()
        End If
    End Sub
End Class