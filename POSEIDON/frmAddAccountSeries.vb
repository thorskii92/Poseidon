Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAddAccountSeries

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSerial.Text = "" Then
            MsgBox("Please complete Information", MsgBoxStyle.Information, "Missing Information")
            Exit Sub
        Else
            If Val(txtSerial.Text) < 1 Then
                MsgBox("Serial Number should start at 1", MsgBoxStyle.Exclamation, "Starting number out of bounds")
                Exit Sub
            Else
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM acctcodegen WHERE brgyID=" & arrBaraID(cboBarangay.SelectedIndex), con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    If MsgBox("Already have the same type of account series. Do you want to Update this series?", MsgBoxStyle.YesNo, "Same Series Found") = MsgBoxResult.Yes Then
                        Dim cmd As New MySqlCommand("UPDATE acctcodegen SET series=" & Val(txtSerial.Text) - 1 & " WHERE brgyID=" & arrBaraID(cboBarangay.SelectedIndex), con)
                        cmd.ExecuteNonQuery()
                        InsertLog(loggedUserID, "Updated Account Code Series", "Account Series", "Updated Account Code Series For BrgyID#" & arrBaraID(cboBarangay.SelectedIndex) & ", Latest Serial# " & txtSerial.Text)
                        LoadAccountSeries()
                        Me.Close()
                    End If
                Else
                    If MsgBox("Save new series?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                        Dim cmd As New MySqlCommand("INSERT INTO acctcodegen(brgyID, series) VALUES(" & arrBaraID(cboBarangay.SelectedIndex) & "," & Val(txtSerial.Text) - 1 & ")", con)
                        cmd.ExecuteNonQuery()
                        InsertLog(loggedUserID, "New Account Code Series", "Account Series", "Inserted New Account Code Series")
                        LoadAccountSeries()
                        Me.Close()
                    End If
                End If
            End If

            
        End If
       
    End Sub

    Private Sub frmAddAccountSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAllBars()

        ' lblAccountNo.Text = ""
    End Sub

    Private Sub txtSerial_TextChanged(sender As Object, e As EventArgs) Handles txtSerial.TextChanged
        Try
            'lblAccountNo.Text = SetAccountCode(arrBaraID(cboBarangay.SelectedIndex), arrClasID(cboClass.SelectedIndex), Val(txtSerial.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboClass_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            ' lblAccountNo.Text = SetAccountCode(arrBaraID(cboBarangay.SelectedIndex), arrClasID(cboClass.SelectedIndex), Val(txtSerial.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarangay.SelectedIndexChanged
        Try
            'lblAccountNo.Text = SetAccountCode(arrBaraID(cboBarangay.SelectedIndex), arrClasID(cboClass.SelectedIndex), Val(txtSerial.Text))
        Catch ex As Exception

        End Try

    End Sub
End Class