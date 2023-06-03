Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAddZone


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "New Zone" Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE zoneID=" & Val(txtZone.Text) & " and addmunid=" & selectedMunID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Already have the same Zone Number From this Municipality", MsgBoxStyle.Information, "Same Zone Number Found")
                Exit Sub
            Else
                Dim cmd As New MySqlCommand("INSERT INTO zones(addmunid,zonenum,readday) VALUES(" & selectedMunID & "," & Val(txtZone.Text) & "," & Val(txtReading.Text) & ")", con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Added New Zone", "Add Zone", "Added Zone #: " & txtZone.Text & " w/ Read Day: " & txtReading.Text)
                ViewZoneSettings(selectedMunID)
                Me.Close()
            End If
        Else
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE (zonenum=" & Val(txtZone.Text) & " and (NOT zonenum=" & selSetZoneID & ")) and addmunid=" & selSetMunID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Already have the same Zone Number from this Municipality", MsgBoxStyle.Information, "Same Zone Number Found")
                Exit Sub
            Else
                Dim cmd As New MySqlCommand("UPDATE zones SET zonenum=" & Val(txtZone.Text) & ",readday=" & Val(txtReading.Text) & " WHERE zonenum=" & selSetZoneID & " AND addmunid=" & selSetMunID, con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Updated Zone", "Edit Zone", "Editted Zone #: " & selectedZoneID & " to " & Val(txtZone.Text) & " w/ Read Day: " & txtReading.Text)
                ViewZoneSettings(selSetMunID)
                Me.Close()
            End If
        End If

    End Sub
End Class