Imports MySql.Data.MySqlClient
Public Class NewBarangay
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "New Barangay" Then
            Cons()
            Dim cmd As New MySqlCommand("INSERT INTO brgylist(ZoneID, addbrgy, brgycode, clustersize, bclass) values(" & selectedZoneID & ",'" & txtBrgyName.Text.Replace("'", "`") & "','" & txtBrgyCode.Text.Replace("'", "`") & "'," & Val(txtCluster.Text) & ",'" & cboClass.Text & "')", con)
            cmd.ExecuteNonQuery()
            ViewBrgySettings(selectedZoneID)
            Me.Close()
        Else
            Cons()
            'Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE zoneID=" & selSetZoneID & " AND (addbrgy='" & txtBrgyName.Text.Replace("'", "''") & "' and NOT brgyID=" & selSetBarID & ")", con)
            'da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            Dim cmd As New MySqlCommand("UPDATE brgylist SET addbrgy='" & txtBrgyName.Text.Replace("'", "''") & "', brgycode='" & txtBrgyCode.Text & "', clustersize=" & Val(txtCluster.Text) & ", bClass='" & cboClass.Text & "' WHERE brgyID=" & selSetBarID, con)
            cmd.ExecuteNonQuery()
            ViewBrgySettings(selSetZoneID)
            Me.Close()
            'End If
        End If
    End Sub

    Private Sub NewBarangay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class