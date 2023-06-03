Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmEditOverpayment
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MessageBox.Show("Save Changes?", "Save New Overpayment Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If isNew = False Then
                Dim cmd As New MySqlCommand("UPDATE tbloverpayment SET balamt=" & Val(txtBalance.Text) & " WHERE opID=" & OverpayID, con)
                cmd.ExecuteNonQuery()

            Else
                Dim cmd As New MySqlCommand("INSERT INTO tbloverpayment(acctID,balamt) VALUES(@aID,@balm)", con)
                cmd.Parameters.AddWithValue("@aID", OverpayEditID)
                cmd.Parameters.AddWithValue("@balm", txtBalance.Text)
                cmd.ExecuteNonQuery()
            End If
            AccountFormList(arrAcctListBrgyID(frmAccountsList.cboBarangay.SelectedIndex), frmAccountsList.txtSearch.Text.Replace("'", "`"), acFilter)
            Me.Close()
        End If
    End Sub
End Class