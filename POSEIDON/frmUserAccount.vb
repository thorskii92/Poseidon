Public Class frmUserAccount

    Private Sub btnEditName_Click(sender As Object, e As EventArgs) Handles btnEditName.Click
        frmUpdateUName.lblFormName.Text = "Update Full Name"
        frmUpdateUName.Text = "Update Full Name"
        frmUpdateUName.txtNewName.Text = lblFullName.Text
        frmUpdateUName.StartPosition = FormStartPosition.CenterScreen
        frmUpdateUName.ShowDialog()
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        frmUpdateUName.lblFormName.Text = "Update Username"
        frmUpdateUName.Text = "Update Username"
        frmUpdateUName.txtNewName.Text = lblUsername.Text
        frmUpdateUName.StartPosition = FormStartPosition.CenterScreen
        frmUpdateUName.ShowDialog()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        frmUpdateMyPassword.ShowInTaskbar = False
        frmUpdateMyPassword.ShowDialog()
    End Sub
End Class