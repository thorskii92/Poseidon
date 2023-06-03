Imports MySql.Data.MySqlClient
Public Class frmRateAdder


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "Rate" Then
            Cons()
            Dim cmd As New MySqlCommand("INSERT INTO tempclassrate(rate, ismin, cubitrange) VALUES(" & Val(txtRate.Text) & ",0," & Val(txtCub.Text) & ")", con)
            cmd.ExecuteNonQuery()
        Else
            Dim cmd As New MySqlCommand("INSERT INTO tempclassrate(rate, ismin, cubitrange) VALUES(" & Val(txtRate.Text) & ",1," & Val(txtCub.Text) & ")", con)
            cmd.ExecuteNonQuery()
        End If
        tempClassRate()
        Me.Close()
    End Sub

    Private Sub frmRateAdder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class