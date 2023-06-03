Imports MySql.Data.MySqlClient
Public Class frmUpdateReference

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If txtNewReference.Text = "" Then
            MsgBox("Please enter Reference", MsgBoxStyle.Information, "")
        Else
            If MsgBox("Save changes?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET meterreference='" & Val(txtNewReference.Text) & "' WHERE acctID=" & selectedAcctIDReferenceChange, con)
                cmd.ExecuteNonQuery()
                MsgBox("Saved!", MsgBoxStyle.Information, "Saved")
                Me.txtNewReference.Text = ""
                InsertLog(loggedUserID, "Update of Reference #", "Update Reference", "Updated Reference of AcctID=" & selectedAcctIDReferenceChange & " FROM Ref# " & lblReference.Text & " To Ref# " & txtNewReference.Text)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmUpdateReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNewReference_TextChanged(sender As Object, e As EventArgs) Handles txtNewReference.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.txtNewReference.Text = ""
        Me.Close()
    End Sub
End Class