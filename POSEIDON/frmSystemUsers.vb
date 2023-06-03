Imports MySql.Data.MySqlClient
Public Class frmSystemUsers
    Dim canDelete As String
    Dim checkActive As String
    Dim utID As Integer

    Private Sub frmSystemUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSystemUsers()
    End Sub

    Private Sub lvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvw.SelectedIndexChanged
        If lvw.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT uID, userstatus, candel, utypeid FROM userlist WHERE uID=" & arrSysUID(lvw.FocusedItem.Index), con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                canDelete = dt.Rows(0).Item(2).ToString
                checkActive = dt.Rows(0).Item(1).ToString
                utID = Val(dt.Rows(0).Item(3).ToString)
                If utID = 1 Then
                    btnReset.Enabled = False
                Else
                    btnReset.Enabled = True
                End If
                If checkActive = "Active" Then
                    btnDisableAccount.Text = "Deactivate Account"
                Else
                    btnDisableAccount.Text = "Activate Account"
                End If
                If canDelete = "Yes" Then
                    btnDisableAccount.Enabled = True
                Else
                    btnDisableAccount.Enabled = False
                End If
                'btnReset.Enabled = True
            End If
            btnViewUserDetails.Enabled = True
        Else
            btnDisableAccount.Enabled = False
            btnReset.Enabled = False
            btnViewUserDetails.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If lvw.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to Reset Password?", MsgBoxStyle.YesNo, "Password Reset") = MsgBoxResult.Yes Then
                Cons()
                frmEnterAdminPassword.StartPosition = FormStartPosition.CenterScreen
                frmEnterAdminPassword.ShowDialog()
                If authenticate = True Then
                    Dim cmd As New MySqlCommand("Update userlist SET upass='password' WHERE uID=" & arrSysUID(lvw.FocusedItem.Index), con)
                    cmd.ExecuteNonQuery()
                    authenticate = False
                    MsgBox("Password has been resetted, Please advice user to login with Default password.")
                End If
            End If
        End If
    End Sub

    Private Sub btnDisableAccount_Click(sender As Object, e As EventArgs) Handles btnDisableAccount.Click
        If lvw.SelectedItems.Count > 0 Then
            If checkActive = "Active" Then
                If MsgBox("Do you want to Deactivate this User?", MsgBoxStyle.YesNo, "Deactivate User") = MsgBoxResult.Yes Then
                    Cons()
                    frmEnterAdminPassword.StartPosition = FormStartPosition.CenterScreen
                    frmEnterAdminPassword.ShowDialog()
                    If authenticate = True Then
                        authenticate = False
                        Dim cmd As New MySqlCommand("Update userlist SET userStatus='Inactive' WHERE uID=" & arrSysUID(lvw.FocusedItem.Index), con)
                        cmd.ExecuteNonQuery()
                        MsgBox("User has been Deactivated, user can no longer login unless Reactivated.", MsgBoxStyle.Information, "User Deactivated")
                    End If
                End If
            Else
                If MsgBox("Do you want to Activate this User?", MsgBoxStyle.YesNo, "Activate User") = MsgBoxResult.Yes Then
                    Cons()
                    frmEnterAdminPassword.StartPosition = FormStartPosition.CenterScreen
                    frmEnterAdminPassword.ShowDialog()
                    If authenticate = True Then
                        authenticate = False
                        Dim cmd As New MySqlCommand("Update userlist SET userStatus='Active' WHERE uID=" & arrSysUID(lvw.FocusedItem.Index), con)
                        cmd.ExecuteNonQuery()
                        MsgBox("User has been Activated, user can now login.", MsgBoxStyle.Information, "User Activated")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        frmNewUser.StartPosition = FormStartPosition.CenterScreen
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnViewUserDetails_Click(sender As Object, e As EventArgs) Handles btnViewUserDetails.Click
        If lvw.SelectedItems.Count > 0 Then
            frmUserDetails.lvwLog.Items.Clear()
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM userlist AS U LEFT JOIN usertypes AS T ON U.utypeID=T.utypeID LEFT JOIN userlogs AS L ON U.uID=L.uID WHERE U.uID=" & arrSysUID(lvw.FocusedItem.Index) & " ORDER BY L.ulogid DESC", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmUserDetails.lblName.Text = dt.Rows(0).Item(3).ToString
                frmUserDetails.lblPosition.Text = dt.Rows(0).Item(5).ToString
                frmUserDetails.lblStatus.Text = dt.Rows(0).Item(6).ToString
                frmUserDetails.lblType.Text = dt.Rows(0).Item(9).ToString
                frmUserDetails.lblUsername.Text = dt.Rows(0).Item(1).ToString
                For x As Integer = 0 To dt.Rows.Count - 1
                    Dim lst As New ListViewItem
                    Try
                        lst.Text = Format(dt.Rows(x).Item(13), "yyyy-MM-dd")
                    Catch ex As Exception
                        lst.Text = ""
                    End Try
                    Try
                        lst.SubItems.Add(dt.Rows(x).Item(12).ToString)
                    Catch ex As Exception
                        lst.SubItems.Add("")
                    End Try
                    Try
                        lst.SubItems.Add(dt.Rows(x).Item(14).ToString)
                    Catch ex As Exception
                        lst.SubItems.Add("")
                    End Try
                    frmUserDetails.lvwLog.Items.Add(lst)
                Next
                frmUserDetails.StartPosition = FormStartPosition.CenterScreen
                frmUserDetails.ShowInTaskbar = False
                frmUserDetails.ShowDialog()
            End If

        End If
    End Sub
End Class