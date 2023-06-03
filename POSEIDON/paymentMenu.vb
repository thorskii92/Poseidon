Imports MySql.Data.MySqlClient
Public Class paymentMenu

    Private Sub btnWaterBill_Click(sender As Object, e As EventArgs) Handles btnWaterBill.Click

    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM userlist WHERE uID=" & loggedUserID, con)
        da.Fill(dt)
        frmPaymentCollection.lblCollectingOfficer.Text = dt.Rows(0).Item(3).ToString
        frmPaymentCollection.lblPosition.Text = dt.Rows(0).Item(5).ToString
        frmPaymentCollection.cID.Text = ""
        frmPaymentCollection.MdiParent = frmAdminPanel
        'frmPaymentCollection.WindowState = FormWindowState.Maximized
        frmPaymentCollection.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class