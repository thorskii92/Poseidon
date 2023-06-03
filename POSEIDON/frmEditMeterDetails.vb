Imports MySql.Data.MySqlClient
Public Class frmEditMeterDetails
    Dim cl As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cl = 1
        Me.Close()
    End Sub

    Private Sub frmEditMeterDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cl = 1 Then
            If MsgBox("Cancel changes?", MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                txtCurReading.Text = ""
                txtMetBrand.Text = ""
                txtMetNo.Text = ""
                txtMetSize.Text = ""
            End If
        Else
            txtCurReading.Text = ""
            txtMetBrand.Text = ""
            txtMetNo.Text = ""
            txtMetSize.Text = ""
        End If
    End Sub

    Private Sub frmEditMeterDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl = 1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Confirm Changes?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET MeterNo='" & txtMetNo.Text & "', MeterBrand='" & txtMetBrand.Text.Replace("'", "''") & "', MeterSize='" & txtMetSize.Text.Replace("'", "''") & "',MeterReference='" & txtCurReading.Text & "' WHERE acctID=" & selectedAcctLedgerID, con)
            cmd.ExecuteNonQuery()
            MsgBox("Saved", MsgBoxStyle.Information, "Saved")
            frmAccountLedger.lblMetBrand.Text = txtMetBrand.Text
            frmAccountLedger.lblMetNum.Text = txtMetNo.Text
            frmAccountLedger.lblMetSize.Text = txtMetSize.Text
            frmAccountLedger.lblCurRead.Text = txtCurReading.Text
            cl = 2
            Me.Close()
        End If

    End Sub
End Class