Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmUpdateAccountDetails
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Confirm Update of Account?", "Account Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AccountName=@acctName, AccountNo=@AcctNo, classID=@cID, StreetAddress=@sAdd, brgyID=@bID, clusterID=@clID WHERE acctID=" & selectedAcctLedgerID, con)
            cmd.Parameters.AddWithValue("@acctName", txtAccountName.Text)
            cmd.Parameters.AddWithValue("@AcctNo", txtAccountNum.Text)
            cmd.Parameters.AddWithValue("@cID", arrAccountUpdateClassID(cboClassification.SelectedIndex))
            cmd.Parameters.AddWithValue("@sAdd", txtStreetAddress.Text)
            cmd.Parameters.AddWithValue("@bID", SELacctBrgyID)
            cmd.Parameters.AddWithValue("@clID", SELacctClusterID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account Updated", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtStreetAddress.Text = ""
            txtAccountName.Text = ""
            txtAccountNum.Text = ""
            cboClassification.Items.Clear()
            ViewLedger(selectedAcctIDLedger)
            Me.Close()
        End If
    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged
        SELacctZoneID = ARRacctZoneID(cboZone.SelectedIndex)
        AccountEditorBrgy(SELacctZoneID)
    End Sub

    Private Sub cboBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarangay.SelectedIndexChanged
        SELacctBrgyID = ARRacctBrgyID(cboBarangay.SelectedIndex)
        AccountEditorCluster(SELacctBrgyID)
    End Sub

    Private Sub cboCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCluster.SelectedIndexChanged
        SELacctClusterID = ARRacctClusterID(cboCluster.SelectedIndex)
    End Sub

    Private Sub frmUpdateAccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class