Imports MySql.Data.MySqlClient
Public Class frmEditAccountSeries

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSearial.Text = "" Then
            MsgBox("Please complete Information", MsgBoxStyle.Information, "Missing Information")
            Exit Sub
        Else
            If Val(txtSearial.Text) < 1 Then
                MsgBox("Serial Number should start at 1", MsgBoxStyle.Exclamation, "Starting number out of bounds")
                Exit Sub
            Else
                If MsgBox("Save Changes?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                    Dim cmd As New MySqlCommand("UPDATE acctcodegen SET series=" & Val(txtSearial.Text) - 1 & " WHERE brgyID=" & selBaraID, con)
                    cmd.ExecuteNonQuery()
                    InsertLog(loggedUserID, "Updated Account Code Series", "Edit Account Series", "Updated Series for brgyID# " & selBaraID & " , Series# " & txtSearial.Text)
                    LoadAccountSeries()
                    Me.Close()
                End If

            End If
        End If

    End Sub

    Private Sub txtSearial_TextChanged(sender As Object, e As EventArgs) Handles txtSearial.TextChanged
        'Try
        '    lblAccountNo.Text = SetAccountCode(selBaraID, selClasID, Val(txtSearial.Text))
        'Catch ex As Exception

        'End Try
    End Sub
End Class