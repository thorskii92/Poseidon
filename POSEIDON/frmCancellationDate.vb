Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmCancellationDate
    Public orNum As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblOR WHERE ORNum='" & orNum & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE tblOR SET orRemark=@oRem ,pDate=@payDate where ORNum='" & orNum & "'", con)
            cmd.Parameters.AddWithValue("@oRem", "Cancelled")
            'cmd.Parameters.AddWithValue("@oNum", orNum)
            cmd.Parameters.AddWithValue("@payDate", Format(dtpCancelDate.Value, "yyyy-MM-dd"))
            cmd.ExecuteNonQuery()
            MessageBox.Show("O.R. has been cancelled", "O.R. Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmORList.SelectedORGroupList(arrGrORID(frmORList.cboGroup.SelectedIndex))
            Me.Close()
        Else
            Cons()
            Dim cmd As New MySqlCommand("INSERT INTO tblOR(orRemark,ORNum,pDate) VALUES(@oRem, @oNum, @payDate)", con)
            cmd.Parameters.AddWithValue("@oRem", "Cancelled")
            cmd.Parameters.AddWithValue("@oNum", orNum)
            cmd.Parameters.AddWithValue("@payDate", Format(dtpCancelDate.Value, "yyyy-MM-dd"))
            cmd.ExecuteNonQuery()
            MessageBox.Show("O.R. has been cancelled", "O.R. Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmORList.SelectedORGroupList(arrGrORID(frmORList.cboGroup.SelectedIndex))
            Me.Close()
        End If

    End Sub
End Class