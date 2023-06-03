Imports MySql.Data.MySqlClient
Public Class frmUpdateMyPassword

    Dim myPass As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT upass FROM userlist WHERE uID=" & loggedUserID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            myPass = dt.Rows(0).Item(0).ToString
            If myPass = Me.txtOldPass.Text Then
                If Me.txtNewPass.Text <> Me.txtRepPass.Text Then
                    MsgBox("Password did not match, Please try again.", MsgBoxStyle.Exclamation, "Invalid Password")
                Else
                    If MsgBox("Confirm Change Password?", MsgBoxStyle.YesNo, "Change Password") = MsgBoxResult.Yes Then
                        Cons()
                        Dim cmd As New MySqlCommand("UPDATE userlist SET upass='" & txtNewPass.Text.Replace("'", "''") & "' WHERE uID=" & loggedUserID, con)
                        cmd.ExecuteNonQuery()
                        Me.txtNewPass.Text = ""
                        Me.txtOldPass.Text = ""
                        Me.txtRepPass.Text = ""
                        MsgBox("Password has been updated", MsgBoxStyle.Information, "Password Update Successful!")
                        Me.Close()
                    End If
                End If
            Else
                MsgBox("Old password is Invalid, Please try again.", MsgBoxStyle.Exclamation, "Old password did not match")
            End If
        End If
    End Sub
End Class