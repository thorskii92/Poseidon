Public Class frmSOAMenu
    Private Sub cboFilter_Click(sender As Object, e As EventArgs) Handles cboFilter.Click

    End Sub

    Private Sub cboFilter_LostFocus(sender As Object, e As EventArgs) Handles cboFilter.LostFocus
        If cboFilter.SelectedIndex = 0 Then 'full term

        ElseIf cboFilter.SelectedIndex = 1 Then

        ElseIf cboFilter.SelectedIndex = 2 Then

        End If
    End Sub
End Class