Imports MySql.Data.MySqlClient
Public Class frmUpdateUName
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If Me.Text = "Update Full Name" Then
            Cons()
            If Me.txtNewName.Text = "" Then
                MsgBox("Please fill in Necessary Information", MsgBoxStyle.Exclamation, "Name Update Invalid")
            Else
                If MsgBox("Confirm Update of Name?", MsgBoxStyle.YesNo, "Name Update Confirmation") = MsgBoxResult.Yes Then
                    Dim cmd As New MySqlCommand("UPDATE userlist SET fullname='" & Me.txtNewName.Text.Replace("'", "''") & "' WHERE uID=" & loggedUserID, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Name has been Updated!", MsgBoxStyle.Information, "Name Update")
                    myAccountInfo(loggedUserID)
                    txtNewName.Text = ""
                    Me.Close()
                    Exit Sub
                End If
            End If
        Else
            Cons()
            If Me.txtNewName.Text = "" Then
                MsgBox("Please fill in Necessary Information", MsgBoxStyle.Exclamation, "Username Update Invalid")
            Else
                If MsgBox("Confirm Username Update?", MsgBoxStyle.YesNo, "Username Update Confirmation") = MsgBoxResult.Yes Then
                    Dim cmd As New MySqlCommand("UPDATE userlist SET uname='" & Me.txtNewName.Text.Replace("'", "''") & "' WHERE uID=" & loggedUserID, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Username has been Updated!", MsgBoxStyle.Information, "Username Upadte")
                    myAccountInfo(loggedUserID)
                    txtNewName.Text = ""
                    Me.Close()
                    Exit Sub
                End If
            End If
        End If
    End Sub
End Class