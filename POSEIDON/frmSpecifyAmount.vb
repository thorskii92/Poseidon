Public Class frmSpecifyAmount

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtAmount.Text = "" Or txtAmount.Text = Val(0) Then
            MsgBox("Please Specify Amount", MsgBoxStyle.Exclamation, "Specify Amount")
        Else
            specifiedAmount = Val(txtAmount.Text)
            Dim lst As New ListViewItem
            If intType = 5 Then
                lst.Text = "Service Fee"
            ElseIf intType = 6 Then
                lst.Text = "Advance Payment"
            End If
            lst.SubItems.Add(GetAccountCodes(intType))
            lst.SubItems.Add(pAmount)
            If intType = 5 Then
                lst.SubItems.Add("Service")
            ElseIf intType = 6 Then
                lst.SubItems.Add("Advance")
            End If

            frmPaymentCollection.lvwCollection.Items.Add(lst)
            CountAmount()
            Me.txtAmount.Text = ""
            Me.Close()
        End If
    End Sub
End Class