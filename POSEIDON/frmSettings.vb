Imports MySql.Data.MySqlClient
Public Class frmSettings

    Private Sub btnAddressList_Click(sender As Object, e As EventArgs) Handles btnAddressList.Click
        ViewProvListSettings()
        frmAddressList.ShowDialog()
    End Sub


    Private Sub btnClassificationList_Click(sender As Object, e As EventArgs) Handles btnClassificationList.Click
        frmClassifications.StartPosition = FormStartPosition.CenterScreen
        classificationList()
        frmClassifications.ShowDialog()
    End Sub

    Private Sub btnUList_Click(sender As Object, e As EventArgs) Handles btnUList.Click
        userTypes.StartPosition = FormStartPosition.CenterScreen
        userTypes.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisconnectionNotice()
        'frmDisconnectionNoticeSetting.txtNote.Text = discNote
        frmDisconnectionNoticeSetting.StartPosition = FormStartPosition.CenterScreen
        frmDisconnectionNoticeSetting.ShowInTaskbar = False
        frmDisconnectionNoticeSetting.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmORUpdater.StartPosition = FormStartPosition.CenterScreen
        frmORUpdater.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmAccountNumberSeries.ShowInTaskbar = False
        frmAccountNumberSeries.StartPosition = FormStartPosition.CenterScreen
        frmAccountNumberSeries.ShowDialog()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            If MsgBox("This will delete all data from the database. make sure you backup your data. Do you wish to proceed?", MsgBoxStyle.YesNo, "Reset to Factory") = MsgBoxResult.Yes Then
                Cons()
                'Dim cmd1 As New MySqlCommand("DELETE FROM acctcodeconnection", con)
                'cmd1.ExecuteNonQuery()
                'Dim cmd2 As New MySqlCommand("DELETE FROM acctcodegen", con)
                'cmd2.ExecuteNonQuery()
                'Dim cmd3 As New MySqlCommand("", con)
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmImportExcel.WindowState = FormWindowState.Maximized
        frmImportExcel.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        importBill.WindowState = FormWindowState.Maximized
        importBill.ShowDialog()
    End Sub

    Private Sub btnRecom_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Confirm Recomputing OR Amount?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT orID, amount1, amount5 FROM tblOR WHERE nature5='Penalty'", con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim gID(dt.Rows.Count - 1) As Integer
                Dim gAmt1(dt.Rows.Count - 1) As Double
                Dim gAmt2(dt.Rows.Count - 1) As Double
                Dim newAmt(dt.Rows.Count - 1) As Double
                Dim ct As Integer = 0
                For x As Integer = 0 To dt.Rows.Count - 1
                    ct = ct + 1
                    gID(x) = Val(dt.Rows(x).Item(0).ToString)
                    gAmt1(x) = Val(dt.Rows(x).Item(1).ToString)
                    gAmt2(x) = Val(dt.Rows(x).Item(2).ToString)
                    newAmt(x) = gAmt1(x) - gAmt2(x)
                    Dim cmd As New MySqlCommand("UPDATE tblOR SET amount1='" & newAmt(x) & "' WHERE orID=" & gID(x), con)
                    cmd.ExecuteNonQuery()
                Next
                MessageBox.Show("OR has been updated, number of OR affected: " & ct)
            End If
        End If


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmBatchReadingUpdate.StartPosition = FormStartPosition.CenterScreen
        frmBatchReadingUpdate.WindowState = FormWindowState.Maximized
        frmBatchReadingUpdate.ShowInTaskbar = False
        frmBatchReadingUpdate.ShowDialog()
    End Sub

    Private Sub btnUpdateBills_Click(sender As Object, e As EventArgs) Handles btnUpdateBills.Click
        frmUpdateBillDetails.StartPosition = FormStartPosition.CenterScreen
        frmUpdateBillDetails.ShowDialog()
    End Sub

    Private Sub btnMultipleBillEditor_Click(sender As Object, e As EventArgs) Handles btnMultipleBillEditor.Click
        frmMultipleBillEditor.WindowState = FormWindowState.Maximized
        frmMultipleBillEditor.ShowDialog()
    End Sub
End Class