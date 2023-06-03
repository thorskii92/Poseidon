Imports MySql.Data.MySqlClient
Public Class frmNewUserType

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "New User Type" Then
            If MsgBox("Save?", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("INSERT INTO usertypes(utype) VALUES('" & txtUserType.Text.Replace("'", "''") & "')", con)
                cmd.ExecuteNonQuery()
                txtUserType.Text = ""
                ViewUserTypes()
                Me.Close()
            End If
        Else
            If MsgBox("Save Changes?", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("UPDATE usertypes SET utype='" & txtUserType.Text.Replace("'", "''") & "' WHERE utypeid=" & selUTID, con)
                cmd.ExecuteNonQuery()
                txtUserType.Text = ""
                ViewUserTypes()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class