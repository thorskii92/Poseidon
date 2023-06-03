Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmApplicationBalance
    Dim newAmt As Decimal
    Dim remBal As Decimal
    Dim countRemMonths As Integer
    Public acctNo As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmApplicationBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub checkedAmount()
        newAmt = 0
        countRemMonths = 0
        For x As Integer = 0 To 12
            If chkAmt(x).Checked = True Then
                newAmt = newAmt + AppFeeAmt(x)
            End If
            If chkAmt(x).Checked = False Then
                countRemMonths = countRemMonths + 1
            End If
        Next
        remBal = 3600 - newAmt
        lblPaid.Text = Format(newAmt, "#,##0.#0")
        lblRemBal.Text = Format(remBal, "#,##0.#0")
    End Sub

    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            If chkInitial.Checked = False Then
                chkInitial.Checked = True
            End If
        Else
            If chk2.Checked = True Then
                chk2.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            If chk1.Checked = False Then
                chk1.Checked = True
            End If
        Else
            If chk3.Checked = True Then
                chk3.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            If chk2.Checked = False Then
                chk2.Checked = True
            End If
        Else
            If chk4.Checked = True Then
                chk4.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk4_CheckedChanged(sender As Object, e As EventArgs) Handles chk4.CheckedChanged
        If chk4.Checked = True Then
            If chk3.Checked = False Then
                chk3.Checked = True
            End If
        Else
            If chk5.Checked = True Then
                chk5.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk5_CheckedChanged(sender As Object, e As EventArgs) Handles chk5.CheckedChanged
        If chk5.Checked = True Then
            If chk4.Checked = False Then
                chk4.Checked = True
            End If
        Else
            If chk6.Checked = True Then
                chk6.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk6_CheckedChanged(sender As Object, e As EventArgs) Handles chk6.CheckedChanged
        If chk6.Checked = True Then
            If chk5.Checked = False Then
                chk5.Checked = True
            End If
        Else
            If chk7.Checked = True Then
                chk7.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk7_CheckedChanged(sender As Object, e As EventArgs) Handles chk7.CheckedChanged
        If chk7.Checked = True Then
            If chk6.Checked = False Then
                chk6.Checked = True
            End If
        Else
            If chk8.Checked = True Then
                chk8.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk8_CheckedChanged(sender As Object, e As EventArgs) Handles chk8.CheckedChanged
        If chk8.Checked = True Then
            If chk7.Checked = False Then
                chk7.Checked = True
            End If
        Else
            If chk9.Checked = True Then
                chk9.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk9_CheckedChanged(sender As Object, e As EventArgs) Handles chk9.CheckedChanged
        If chk9.Checked = True Then
            If chk8.Checked = False Then
                chk8.Checked = True
            End If
        Else
            If chk10.Checked = True Then
                chk10.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk10_CheckedChanged(sender As Object, e As EventArgs) Handles chk10.CheckedChanged
        If chk10.Checked = True Then
            If chk9.Checked = False Then
                chk9.Checked = True
            End If
        Else
            If chk11.Checked = True Then
                chk11.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk11_CheckedChanged(sender As Object, e As EventArgs) Handles chk11.CheckedChanged
        If chk11.Checked = True Then
            If chk10.Checked = False Then
                chk10.Checked = True
            End If
        Else
            If chk12.Checked = True Then
                chk12.Checked = False
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub chk12_CheckedChanged(sender As Object, e As EventArgs) Handles chk12.CheckedChanged
        If chk12.Checked = True Then
            If chk11.Checked = False Then
                chk11.Checked = True
            End If
        End If
        checkedAmount()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If appOpenForm = 1 Then
            If MessageBox.Show("Confirm Application Payment", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                For x As Integer = 0 To 12
                    If chkAmt(x).Enabled = True Then
                        If chkAmt(x).Checked = True Then
                            Cons()
                            Dim cmd As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotid,Amount) VALUES(@aaID, @aaAmt)", con)
                            cmd.Parameters.AddWithValue("@aaID", applicationAcctID)
                            cmd.Parameters.AddWithValue("@aaAmt", AppFeeAmt(x))
                            cmd.ExecuteNonQuery()
                            Dim cmdA As New MySqlCommand("UPDATE applicationfeetotalbalance SET balance=" & newAmt & ", remMonths=" & countRemMonths & " WHERE acctID=" & applicationAcctID, con)
                            cmdA.ExecuteNonQuery()
                        End If
                    End If
                Next
                Me.Close()
            End If
        ElseIf appOpenForm = 2 Then
            If MessageBox.Show("Confirm Application Payment", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim getTotAmt As Decimal
                Dim counter As Integer = 0
                For x As Integer = 0 To 12
                    If chkAmt(x).Enabled = True Then
                        If chkAmt(x).Checked = True Then
                            getTotAmt = getTotAmt + AppFeeAmt(x)
                            counter = counter + 1
                        End If
                    End If
                Next
                If counter > 0 Then
                    Dim lstInstall As New ListViewItem
                    lstInstall.Text = ""
                    lstInstall.SubItems.Add("Installment Fee")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add(lblAccountNo.Text)
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add(getTotAmt)
                    lstInstall.SubItems.Add("")
                    lstInstall.SubItems.Add("")
                    WaterBillPayment.lvwAccounts.Items.Add(lstInstall)
                End If
                Me.Close()
            End If
        End If

    End Sub
End Class