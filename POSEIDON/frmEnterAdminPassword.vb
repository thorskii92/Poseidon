Option Strict On
Imports MySql.Data.MySqlClient
Public Class frmEnterAdminPassword

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        authenticatingPassword = ""
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT upass FROM userlist WHERE position='System Administrator'", con)
        da.Fill(dt)
        authenticatingPassword = dt.Rows(0).Item(0).ToString
        enteredPassword = txtPass.Text
        If authenticatingPassword = enteredPassword Then
            authenticate = True
            Me.txtPass.Text = ""
            Me.Close()
        Else
            MsgBox("Invalid Password, Please try again", MsgBoxStyle.Information, "Invalid Password")
            authenticate = False
        End If
    End Sub

    Private Sub frmEnterAdminPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtPass.Text = ""
        authenticate = False
    End Sub
End Class