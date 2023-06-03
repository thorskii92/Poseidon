Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAddUType

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Me.Text = "Add User Type" Then
            If MsgBox("Save this new User Type?", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM usertypes WHERE utype='" & txtUserType.Text.Replace("'", "''") & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("This user type is already Listed", MsgBoxStyle.Information, "Same User type Found")
                    Exit Sub
                Else
                    Dim cmd As New MySqlCommand("INSERT INTO usertypes(utype) VALUES('" & txtUserType.Text.Replace("'", "''") & "')", con)
                    cmd.ExecuteNonQuery()
                    InsertLog(loggedUserID, "New User Type", "Add User Type", "Added New User Type '" & txtUserType.Text.Replace("'", "''") & "'")
                    txtUserType.Text = ""
                    Me.Close()
                End If
            End If

        Else
            If MsgBox("Confirm Changes?", MsgBoxStyle.YesNo, "Update User Type") = MsgBoxResult.Yes Then
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM usertypes WHERE utype='" & txtUserType.Text.Replace("'", "''") & "' AND NOT utypeid=" & selectedUtypeID, con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("Same User Type Found! Please try another", MsgBoxStyle.Information, "Same User Type Found")
                    Exit Sub
                Else
                    Dim cmd As New MySqlCommand("UPDATE usertypes SET utype='" & txtUserType.Text.Replace("'", "''") & "' WHERE utypeid=" & selectedUtypeID, con)
                    cmd.ExecuteNonQuery()
                    InsertLog(loggedUserID, "Updated Usertype", "Update User Type", "Updated User Type ID# " & selectedUtypeID & " TO " & txtUserType.Text.Replace("'", "''"))
                    txtUserType.Text = ""
                    Me.Close()
                End If
            End If

        End If
    End Sub
End Class