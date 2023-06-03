Imports MySql.Data.MySqlClient
Public Class frmNewUser

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "New User" Then
            If MsgBox("Add this new User?", MsgBoxStyle.YesNo, "New User") = MsgBoxResult.Yes Then
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM userlist WHERE uname='" & txtUsername.Text.Replace("'", "''") & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("The username you entered has already been used, Please try another.", MsgBoxStyle.Exclamation, "Same Username")
                Else
                    Cons()
                    Dim cmd As New MySqlCommand("INSERT INTO userlist(uname,upass,fullname,utypeid,position,userstatus,candel) VALUES(@unm,@ups,@fun,@utid,@posi,'Active','Yes')", con)
                    cmd.Parameters.AddWithValue("@unm", txtUsername.Text.Replace("'", "''"))
                    cmd.Parameters.AddWithValue("@ups", "password")
                    cmd.Parameters.AddWithValue("@fun", txtFullName.Text.Replace("'", "''"))
                    cmd.Parameters.AddWithValue("@utid", arrUTypeID(cboUType.SelectedIndex))
                    cmd.Parameters.AddWithValue("@posi", txtPosition.Text)
                    cmd.ExecuteNonQuery()
                    loadSystemUsers()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub frmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadComboUTypes()
    End Sub
End Class