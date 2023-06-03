Imports MySql.Data.MySqlClient
Public Class frmDisconnectionNoticeSetting
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Save changes?", MsgBoxStyle.YesNo, "Save") Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE disconnectionnote SET discnote='" & txtNote.Text.Replace("'", "''") & "' WHERE discID=1", con)
            cmd.ExecuteNonQuery()
            Me.txtNote.Text = ""
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class