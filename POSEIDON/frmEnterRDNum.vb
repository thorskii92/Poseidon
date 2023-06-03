Public Class frmEnterRDNum
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtRDNum.Text = "" Then
            MessageBox.Show("Please enter a Value", "No Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            EnteredRD = txtRDNum.Text
            Me.Close()
        End If

    End Sub
End Class