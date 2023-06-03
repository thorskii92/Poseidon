Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmBillAdjustment
    Dim AdjSurChargeAmount As Double
    Dim AdjDueAmount As Double
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBillAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMemoNum.Text = memoSeq(Now.Year)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If lblNewAmount.Text = "" Then
            MsgBox("Please enter amount of adjustment", MsgBoxStyle.Exclamation, "Billing Adjustment")
            Exit Sub
        Else
            If MsgBox("Confirm Adjustment?", MsgBoxStyle.YesNo, "Billing Adjustment Confirmations") = MsgBoxResult.Yes Then

                Cons()
                Dim cmd As New MySqlCommand("UPDATE tblbills SET origamount=" & Val(lblBillAmount.Text) & ", AdjustedAmount=" & Val(lblNewAmount.Text) & ", adjPrep=" & loggedUserID & ", adjConf='Pending', adjReason='" & txtReason.Text.Replace("'", "''") & "', adjDate=current_date(), adjSurcharge=" & AdjSurChargeAmount & " ,AdjDueAmount=" & AdjDueAmount & " ,AdjOrDispRmk='Adjustment', enviFee=" & Val(lblEnvi.Text.Replace("Php", "")) & ", consumption=" & Val(txtConsumption.Text) & ", prevconsump=" & gotConsump & " WHERE billID=" & lblBillNum.Text, con)
                cmd.ExecuteNonQuery()
                Dim cmdMem As New MySqlCommand("INSERT INTO tblAdjMemo(memoNo,consID,acctID,billID,adjDate,adjReason,adjAsBilled,adjPrevMoBal,adjNewAmt,adjSurcharge,adjDueAmt,adjIncDec,adjAmtIncDec,prepID,enviFee,adjConsump) VALUES(@mNo,@cID,@aID,@bID,current_date(),@aReason,@aAsBilled,@aPrevMoBal,@aNewAmt,@aSurcharge,@aDueAmt,@aIncDec,@aAmtIncDec,@uID,@eFee,@consump)", con)
                cmdMem.Parameters.AddWithValue("@mNo", lblMemoNum.Text)
                cmdMem.Parameters.AddWithValue("@cID", adjConID)
                cmdMem.Parameters.AddWithValue("@aID", adjAcctID)
                cmdMem.Parameters.AddWithValue("@bID", adjBillID)
                'cmdMem.Parameters.AddWithValue("@aDate", Format(Now.Date, "yyyy-MM-dd"))
                cmdMem.Parameters.AddWithValue("@aReason", txtReason.Text.Replace("'", "''"))
                cmdMem.Parameters.AddWithValue("@aAsBilled", Val(lblBillAmount.Text.Replace("Php", "")))
                cmdMem.Parameters.AddWithValue("@aPrevMoBal", Val(lblPrevMonthBalance.Text.Replace("Php", "")))
                cmdMem.Parameters.AddWithValue("@aNewAmt", Val(lblNewAmount.Text.Replace("'", "''")))
                cmdMem.Parameters.AddWithValue("@aSurcharge", Val(lblSurcharge.Text.Replace("Php", "")))
                cmdMem.Parameters.AddWithValue("@aDueAmt", Val(lblDueAmount.Text.Replace("Php", "")))
                cmdMem.Parameters.AddWithValue("@aIncDec", lblIncDec.Text)
                cmdMem.Parameters.AddWithValue("@aAmtIncDec", Val(lblChange.Text.Replace("Php", "")))
                cmdMem.Parameters.AddWithValue("@uID", loggedUserID)
                cmdMem.Parameters.AddWithValue("@eFee", Val(lblEnvi.Text.Replace("Php", "")))
                cmdMem.Parameters.AddWithValue("@consump", Val(txtConsumption.Text))
                cmdMem.ExecuteNonQuery()
                updateMemo(Now.Year)
                MsgBox("Bill has been adjusted.", MsgBoxStyle.Information, "BIlling Adjustment")
                Dim da As New MySqlDataAdapter("SELECT M.memID, C.consumername, M.memoNo, C.consID, A.AccountNo, M.acctID, M.billID, M.adjDate, M.adjReason, M.adjAsbilled, M.adjPrevMoBal, M.adjNewAmt, M.adjSurcharge, M.adjDueAmt, M.adjIncDec, M.adjAmtIncDec, M.prepID, U.fullname AS Preparee, M.apprvID, V.fullname AS Approver, M.envifee, M.adjconsump FROM tblAdjMemo AS M LEFT JOIN consumerlist AS C ON M.consID=C.consID LEFT JOIN consumeraccounts AS A ON M.acctID=A.acctID LEFT JOIN tblBills AS B ON M.billID=B.billID LEFT JOIN userlist AS U ON M.prepID=U.uID LEFT JOIN userlist AS V ON M.apprvID=V.uID WHERE M.memoNo=" & Val(lblMemoNum.Text), con)
                da.Fill(frmMemoPrint.ReportDataSet.BillAdjustment)
                frmMemoPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                frmMemoPrint.ReportViewer1.ZoomPercent = 100%
                frmMemoPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                frmMemoPrint.ReportViewer1.Width = 75
                frmMemoPrint.WindowState = FormWindowState.Maximized
                frmMemoPrint.ReportViewer1.RefreshReport()
                frmMemoPrint.ShowDialog()
                If billAdjustForm = 1 Then
                    Try
                        WaterBillAccountsList(arrConsWaterID(WaterBillPayment.cboConsumerName.SelectedIndex))
                        Exit Try
                    Catch ex As Exception
                        WaterBillSpecNum(Val(WaterBillPayment.txtBill.Text))
                    End Try
                Else
                    WaterBillingQuery(strQueryBill)
                End If
                Me.txtReason.Text = ""
                Me.lblNewAmount.Text = ""
                'Me.txtEnviFee.Text = ""
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtNewAmount_TextChanged(sender As Object, e As EventArgs)
        'Dim nAmount As Double
        'Dim cAmount As Double
        'nAmount = Val(txtNewAmount.Text)
        'cAmount = Val(lblBillAmount.Text) - nAmount
        'If cAmount < 0 Then
        '    pbxIncDec.Visible = True
        '    pbxDec.Visible = False
        '    lblIncDec.Visible = True
        '    lblIncDec.Text = "INCREASED"
        '    lblChange.Text = "Php" & Format(Math.Abs(cAmount), "#,##0.#0")
        'ElseIf cAmount > 0 Then
        '    pbxIncDec.Visible = False
        '    pbxDec.Visible = True
        '    lblIncDec.Visible = True
        '    lblIncDec.Text = "DECREASED"
        '    lblChange.Text = "Php" & Format(Math.Abs(cAmount), "#,##0.#0")
        'Else
        '    lblIncDec.Visible = False
        '    pbxIncDec.Visible = False
        '    pbxDec.Visible = False
        '    lblChange.Text = "Php" & Format(Math.Abs(cAmount), "#,##0.#0")
        'End If
        'ComputeSurCharge(Val(txtNewAmount.Text))
    End Sub

    Private Sub ComputeSurCharge(NewAmount As Double)
        AdjDueAmount = ((NewAmount + AdjustPrevMonthTotal) * 1.1) - AdjustPrevMonthTotal
        lblDueAmount.Text = Format(AdjDueAmount, "#,##0.#0")
        AdjSurChargeAmount = (NewAmount + AdjustPrevMonthTotal) * 0.1
        lblSurcharge.Text = Format(AdjSurChargeAmount, "#,##0.#0")
    End Sub

    Private Sub lblNewAmount_Click(sender As Object, e As EventArgs) Handles lblNewAmount.Click
      
    End Sub

    Private Sub lblNewAmount_TextChanged(sender As Object, e As EventArgs) Handles lblNewAmount.TextChanged
        
    End Sub

    Private Sub txtConsumption_TextChanged(sender As Object, e As EventArgs) Handles txtConsumption.TextChanged
        lblNewAmount.Text = Format(Val(DirectRate(Val(txtConsumption.Text), Val(lblClass.Text), 2)), "#,##0.#0")
        lblEnvi.Text = Format(Val(txtConsumption.Text), "#,##0.#0")
        Dim nAmount As Double = Val(lblNewAmount.Text.Replace("Php", ""))
        Dim cAmount As Double = Val(lblBillAmount.Text)
        'nAmount()
        'cAmount()
        If cAmount < nAmount Then
            pbxIncDec.Visible = True
            pbxDec.Visible = False
            lblIncDec.Visible = True
            lblIncDec.Text = "INCREASED"
            lblChange.Text = "Php" & Format(Math.Abs(cAmount - nAmount), "#,##0.#0")
        ElseIf cAmount > nAmount Then
            pbxIncDec.Visible = False
            pbxDec.Visible = True
            lblIncDec.Visible = True
            lblIncDec.Text = "DECREASED"
            lblChange.Text = "Php" & Format(Math.Abs(cAmount - nAmount), "#,##0.#0")
        ElseIf cAmount = nAmount Then
            lblIncDec.Visible = True
            pbxIncDec.Visible = False
            pbxDec.Visible = False
            lblIncDec.Text = "SAME"
            lblChange.Text = "Php" & Format(Math.Abs(cAmount - nAmount), "#,##0.#0")
        End If
        ComputeSurCharge(Val(lblNewAmount.Text.Replace("Php", "")))
    End Sub

    Private Function txtNewAmount() As Object
        Throw New NotImplementedException
    End Function

End Class