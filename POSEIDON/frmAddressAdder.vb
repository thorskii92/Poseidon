Public Class frmAddressAdder

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtBCode.Visible = True Then
            If txtBCode.Text = "" Then
                MsgBox("Please Enter a Barangay Code!", MsgBoxStyle.Information, "Barangay Code Missing")
                Exit Sub
            Else
                NewAddress(globalAddressIndex, txtAddress.Text, chkDef.CheckState)
                brgyCode = txtBCode.Text
            End If
        Else
            NewAddress(globalAddressIndex, txtAddress.Text, chkDef.CheckState)
        End If
    End Sub
End Class