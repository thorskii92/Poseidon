Imports MySql.Data.MySqlClient
Public Class frmORUpdater

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Cons()
        Dim cmd As New MySqlCommand("UPDATE tblcurrentor SET currentornum=" & Val(txtNewOR.Text) & " WHERE curorID=1", con)
        cmd.ExecuteNonQuery()
        Me.txtNewOR.Text = ""
        Me.Close()
    End Sub

    Private Sub frmORUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurOR.Text = currentOR(loggedUserID)
    End Sub
End Class