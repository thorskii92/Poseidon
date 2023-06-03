Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmPaymentTypeSelection
    Dim pSelection As Integer
    Dim newPen As Double
    Public totalAdjustedAmt As Double


    Private Sub frmPaymentTypeSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPType.SelectedIndex = 0
        changeAmt = Val(txtAmount.Text) - totalReqPayment
        moneyAmount = Val(txtAmount.Text)
        newPen = totalPenalty
        lblChange.Text = Format(changeAmt, "#,##0.#0")
        tmr.Enabled = True

        'txtPenalty.Text = totPrevPen
        'txtDiscount.Text = totPrevDis
        'txtEF.Text = totPrevEF
        'cboMonth.Text = startMonth
        'cboYear.Text = startYear
    End Sub

    Private Sub cboPType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPType.SelectedIndexChanged
        If cboPType.SelectedIndex = 0 Then
            pSelection = 1
            lblDrawee.Visible = False
            lblNumber.Visible = False
            lblDate.Visible = False
            txtBank.Visible = False
            txtNumber.Visible = False
            dtpDate.Visible = False
            'Me.Height = 620
        ElseIf cboPType.SelectedIndex = 1 Then
            pSelection = 2
            lblDrawee.Visible = True
            lblNumber.Visible = True
            lblDate.Visible = True
            txtAmount.Visible = True
            txtBank.Visible = True
            txtNumber.Visible = True
            dtpDate.Visible = True
            'Me.Height = 658
        ElseIf cboPType.SelectedIndex = 2 Then
            pSelection = 3
            lblDrawee.Visible = False
            lblNumber.Visible = True
            lblDate.Visible = True
            txtBank.Visible = False
            txtNumber.Visible = True
            dtpDate.Visible = True
            'Me.Height = 622
        Else
            pSelection = 0
            lblDrawee.Visible = False
            lblNumber.Visible = False
            lblDate.Visible = False
            dtpDate.Visible = False
            txtBank.Visible = False
            txtNumber.Visible = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboBillNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBillNum.SelectedIndexChanged

        If arrPaymentType(cboBillNum.SelectedIndex) = "Water Bill" Then
            lblHide.Visible = False
            'If cboBillNum.SelectedItem > 0 Then
            lblAccountNo.Text = paymentAccountNo(cboBillNum.SelectedIndex)
            lblMeterReader.Text = arrPDMetName(cboBillNum.SelectedIndex)
            lblBillPeriod.Text = arrPDbillPeriod(cboBillNum.SelectedIndex)
            lblDueDate.Text = arrPDDueDate(cboBillNum.SelectedIndex)
            lblReadDate.Text = arrPDReadDate(cboBillNum.SelectedIndex)
            lblBillDate.Text = arrPDBillDate(cboBillNum.SelectedIndex)
            billPrevRead.Text = arrPDPrevRead(cboBillNum.SelectedIndex)
            lblPresRead.Text = arrPDPresRead(cboBillNum.SelectedIndex)
            lblConsump.Text = arrPDConsump(cboBillNum.SelectedIndex)
            lblWSF.Text = Format(arrPDWSF(cboBillNum.SelectedIndex), "#,##0.#0")
            lblEnviFee.Text = Format(arrPDEnFee(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustment.Text = Format(arrPDAdj(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustRate.Text = Format(arrPDAdjRate(cboBillNum.SelectedIndex), "#,##0.#0")
            lblTotalAmt.Text = Format(arrPDTotAmt(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPenalty.Text = Format(arrPDPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblSCDis.Text = Format(arrPDSCDis(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCRate.Text = Format(arrPDSCRate(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAmountADue.Text = Format(arrPDAmtADue(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCPen.Text = Format(arrPDSCPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPrevBalance.Text = Format(arrPrevBal(cboBillNum.SelectedIndex), "#,##0.#0")
            lblReq.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
            lblInstallment.Text = Format(arrPDInstallment(cboBillNum.SelectedIndex), "#,##0.#0")
            'End If
        ElseIf arrPaymentType(cboBillNum.SelectedIndex) = "Overpayment" Then
            lblHide.Visible = True
            lblAccountNo.Text = paymentAccountNo(cboBillNum.SelectedIndex)
            lblBillPeriod.Text = ""
            lblMeterReader.Text = ""
            lblDueDate.Text = ""
            lblReadDate.Text = ""
            lblBillDate.Text = ""
            billPrevRead.Text = ""
            lblPresRead.Text = ""
            lblConsump.Text = ""
            lblWSF.Text = ""
            lblEnviFee.Text = ""
            lblReq.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
            lblTotalAmt.Text = ""
            lblPenalty.Text = ""
            lblSCDis.Text = ""
            lblPrevBalance.Text = Format(arrPrevBal(cboBillNum.SelectedIndex), "#,##0.#0")
            lblInstallment.Text = ""
        ElseIf arrPaymentType(cboBillNum.SelectedIndex) = "Installment Fee" Then
            lblAccountNo.Text = paymentAccountNo(cboBillNum.SelectedIndex)
            lblHide.Visible = True
            lblMeterReader.Text = arrPDMetName(cboBillNum.SelectedIndex)
            lblBillPeriod.Text = arrPDbillPeriod(cboBillNum.SelectedIndex)
            lblDueDate.Text = ""
            lblReadDate.Text = ""
            lblBillDate.Text = ""
            billPrevRead.Text = arrPDPrevRead(cboBillNum.SelectedIndex)
            lblPresRead.Text = arrPDPresRead(cboBillNum.SelectedIndex)
            lblConsump.Text = arrPDConsump(cboBillNum.SelectedIndex)
            lblWSF.Text = Format(arrPDWSF(cboBillNum.SelectedIndex), "#,##0.#0")
            lblEnviFee.Text = Format(arrPDEnFee(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustment.Text = Format(arrPDAdj(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustRate.Text = Format(arrPDAdjRate(cboBillNum.SelectedIndex), "#,##0.#0")
            lblTotalAmt.Text = Format(arrPDTotAmt(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPenalty.Text = Format(arrPDPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblSCDis.Text = Format(arrPDSCDis(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCRate.Text = Format(arrPDSCRate(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAmountADue.Text = Format(arrPDAmtADue(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCPen.Text = Format(arrPDSCPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPrevBalance.Text = Format(arrPrevBal(cboBillNum.SelectedIndex), "#,##0.#0")
            lblReq.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
            lblInstallment.Text = Format(arrPDInstallment(cboBillNum.SelectedIndex), "#,##0.#0")
        ElseIf arrPaymentType(cboBillNum.SelectedIndex) = "Installation" Then
            lblAccountNo.Text = ""
            lblHide.Visible = True
            lblMeterReader.Text = ""
            lblBillPeriod.Text = ""
            lblDueDate.Text = ""
            lblReadDate.Text = ""
            lblBillDate.Text = ""
            billPrevRead.Text = ""
            lblPresRead.Text = ""
            lblConsump.Text = ""
            lblWSF.Text = ""
            lblEnviFee.Text = ""
            'lblAdjustment.Text = Format(arrPDAdj(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustRate.Text = Format(arrPDAdjRate(cboBillNum.SelectedIndex), "#,##0.#0")
            lblTotalAmt.Text = Format(arrPDTotAmt(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPenalty.Text = ""
            lblSCDis.Text = ""
            'lblSCRate.Text = Format(arrPDSCRate(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAmountADue.Text = Format(arrPDAmtADue(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCPen.Text = Format(arrPDSCPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPrevBalance.Text = ""
            lblReq.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
            lblInstallment.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
        ElseIf arrPaymentType(cboBillNum.SelectedIndex) = "Bulk Order" Then
            lblAccountNo.Text = ""
            lblHide.Visible = False
            lblMeterReader.Text = ""
            lblBillPeriod.Text = ""
            lblDueDate.Text = ""
            lblReadDate.Text = ""
            lblBillDate.Text = ""
            billPrevRead.Text = ""
            lblPresRead.Text = ""
            lblConsump.Text = arrPDConsump(cboBillNum.SelectedIndex)
            lblWSF.Text = ""
            lblEnviFee.Text = ""
            'lblAdjustment.Text = Format(arrPDAdj(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustRate.Text = Format(arrPDAdjRate(cboBillNum.SelectedIndex), "#,##0.#0")
            lblTotalAmt.Text = Format(arrPDTotAmt(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPenalty.Text = ""
            lblSCDis.Text = ""
            'lblSCRate.Text = Format(arrPDSCRate(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAmountADue.Text = Format(arrPDAmtADue(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCPen.Text = Format(arrPDSCPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPrevBalance.Text = ""
            lblReq.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
            lblInstallment.Text = ""
        Else
            lblAccountNo.Text = paymentAccountNo(cboBillNum.SelectedIndex)
            lblHide.Visible = True
            lblMeterReader.Text = arrPDMetName(cboBillNum.SelectedIndex)
            lblBillPeriod.Text = arrPDbillPeriod(cboBillNum.SelectedIndex)
            lblDueDate.Text = ""
            lblReadDate.Text = ""
            lblBillDate.Text = ""
            billPrevRead.Text = arrPDPrevRead(cboBillNum.SelectedIndex)
            lblPresRead.Text = arrPDPresRead(cboBillNum.SelectedIndex)
            lblConsump.Text = arrPDConsump(cboBillNum.SelectedIndex)
            lblWSF.Text = Format(arrPDWSF(cboBillNum.SelectedIndex), "#,##0.#0")
            lblEnviFee.Text = Format(arrPDEnFee(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustment.Text = Format(arrPDAdj(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAdjustRate.Text = Format(arrPDAdjRate(cboBillNum.SelectedIndex), "#,##0.#0")
            lblTotalAmt.Text = Format(arrPDTotAmt(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPenalty.Text = Format(arrPDPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblSCDis.Text = Format(arrPDSCDis(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCRate.Text = Format(arrPDSCRate(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblAmountADue.Text = Format(arrPDAmtADue(cboBillNum.SelectedIndex), "#,##0.#0")
            'lblSCPen.Text = Format(arrPDSCPen(cboBillNum.SelectedIndex), "#,##0.#0")
            lblPrevBalance.Text = Format(arrPrevBal(cboBillNum.SelectedIndex), "#,##0.#0")
            lblReq.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")
            lblInstallment.Text = Format(arrPDReq(cboBillNum.SelectedIndex), "#,##0.#0")

        End If

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        changeAmt = Val(txtAmount.Text) - totalReqPayment
        moneyAmount = Val(txtAmount.Text)
        lblChange.Text = Format(changeAmt, "#,##0.#0")
    End Sub

    Private Sub frmPaymentTypeSelection_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        tmr.Enabled = False
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        lblPaymentDate.Text = Now.ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cboMonth.Visible = True Then
            If cboMonth.Text = "" Or cboYear.Text = "" Or txtEF.Text = "" Then
                MessageBox.Show("Please Fill Missing Values", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If MessageBox.Show("Confirm Payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    SaveValues()
                    WaterBillPayment.ConsumerSelection(WaterBillPayment.cboConsumerName.SelectedIndex)
                    Me.Close()
                End If
            End If
        Else
            If MessageBox.Show("Confirm Payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                SaveValues()
                WaterBillPayment.ConsumerSelection(WaterBillPayment.cboConsumerName.SelectedIndex)
                Me.Close()
            End If
        End If


    End Sub

    Private Sub SaveValues()
        Dim oBillAmt As Double
        'Dim oTotalAdjusted As Double
        'Dim oTotalPenalty As Double
        'Dim oTotalEF As Double
        'Dim oTotalApplicationFee As Double
        'Dim oTotalReconnectionFee As Double
        'Dim oTotalTransferFee As Double

        Dim pTypeCash As String = ""
        Dim pTypeCheck As String = ""
        Dim pTypeMO As String = ""
        Dim strCBank As String
        Dim strCNum As String
        Dim strCDate As String
        Dim strMNum As String
        Dim strMDate As String
        strCBank = ""
        strCNum = ""
        strCDate = ""
        strMNum = ""
        strMDate = ""
        If cboPType.Text = "Cash" Then
            pTypeCash = "✓"
            pTypeCheck = ""
            pTypeMO = ""
            strCBank = ""
            strCNum = ""
            strCDate = ""
            strMNum = ""
            strMDate = ""
        ElseIf cboPType.Text = "Check" Then
            pTypeCash = ""
            pTypeCheck = "✓"
            pTypeMO = ""
            strCBank = txtBank.Text
            strCNum = txtNumber.Text
            strCDate = dtpDate.Value.Date
            strMNum = ""
            strMDate = ""
        ElseIf cboPType.Text = "Money Order" Then
            pTypeCash = ""
            pTypeCheck = ""
            pTypeMO = "✓"
            strCBank = ""
            strCNum = ""
            strCDate = ""
            strMNum = txtNumber.Text
            strMDate = dtpDate.Value.Date
        End If
        Dim newTotalPenalty As Double = totalPenalty

        'newTotalPenalty = newTotalPenalty + Val(txtPenalty.Text)
        Dim firstWords As String = ""
        Dim secondWords As String = ""
        Dim strWords() As String = Split(UCase(ConvertNumberToWords(totalReqPayment.ToString)), " ")
        If strWords.Count > 5 Then
            For x As Integer = 0 To 3
                firstWords = firstWords & " " & strWords(x)
            Next
            For y As Integer = 4 To strWords.Count - 1
                secondWords = secondWords & " " & strWords(y)
            Next
        Else
            firstWords = UCase(ConvertNumberToWords(totalReqPayment.ToString))
            secondWords = ""
        End If

        Dim allDiscount As Double
        allDiscount = Val(lblTotalDiscount.Text.Replace(",", "")) + Val(txtDiscount.Text)
        Dim strMonthIncluded As String = ""
        If prevBalExisting = 1 Then
            strMonthIncluded = UCase(Mid(cboMonth.Text, 1, 3)) & " " & Mid(cboYear.Text, 3, 4) & " TO " & UCase(Mid(latestMonth, 1, 3)) & " " & Mid(latestYear, 3, 4)
        Else
            If pubBillCount > 1 Then
                strMonthIncluded = UCase(Mid(initialMonth, 1, 3)) & " " & Mid(initialYear, 3, 4) & " TO " & UCase(Mid(latestMonth, 1, 3)) & " " & Mid(latestYear, 3, 4)
            Else
                strMonthIncluded = UCase(Mid(initialMonth, 1, 3)) & " " & Mid(initialYear, 3, 4)
            End If
        End If
        Dim strPenLabel As String = ""
        Dim amtPenLabel As String = ""
        Dim naturePayment(7) As String
        Dim acctCodePayment(7) As String
        Dim amtPayment(7) As String
        Dim billsCount As Integer = 0
        Dim installmentCount As Integer = 0
        Dim overpaymentCount As Integer = 0
        Dim bulkordercount As Integer = 0
        Dim installCount As Integer = 0
        Dim reconCount As Integer = 0
        Dim tOwner As Integer = 0
        Dim tMeter As Integer = 0
        Dim strInstall As String = ""
        Dim strRecon As String = ""
        Dim strTOwner As String = ""
        Dim strTMeter As String = ""
        Dim strInstallFee As String = ""
        Dim strReconFee As String = ""
        Dim strTOwnerFee As String = ""
        Dim strTMeterFee As String = ""
        Dim strPenalty As String = ""
        Dim strOverpay As String = ""
        Dim strOverpayFee As String = ""
        Dim strBulk As String = ""
        Dim strBulkAmount As String = ""

        If newTotalPenalty > 0 Then
            strPenLabel = "PENALTY"
            amtPenLabel = Format(newTotalPenalty, "#,##0.#0")
        Else
            strPenLabel = ""
            amtPenLabel = ""
        End If
        'MessageBox.Show(arrPaymentType(iCount))
        For iCount As Integer = 0 To cboBillNum.Items.Count - 1

            If arrPaymentType(iCount) = "Water Bill" Then
                billsCount = billsCount + 1
            ElseIf arrPaymentType(iCount) = "Installation" Then
                installCount = installCount + 1
            ElseIf arrPaymentType(iCount) = "Reconnection" Then
                reconCount = reconCount + 1
            ElseIf arrPaymentType(iCount) = "Transfer Owner" Then
                tOwner = tOwner + 1
            ElseIf arrPaymentType(iCount) = "Transfer Meter" Then
                tMeter = tMeter + 1
            ElseIf arrPaymentType(iCount) = "Installment Fee" Then
                installmentCount = installmentCount + 1
            ElseIf arrPaymentType(iCount) = "Overpayment" Then
                overpaymentCount = overpaymentCount + 1
            ElseIf arrPaymentType(iCount) = "Bulk Order" Then
                bulkordercount = bulkordercount + 1
            End If
        Next
        'MessageBox.Show(reconCount)
        If installCount > 0 Then
            strInstall = "INSTALLATION FEE"
            strInstallFee = Format(Val(totalApplication), "#,##0.#0")
        Else
            strInstall = ""
            strInstallFee = ""
        End If

        If reconCount > 0 Then
            If reconCount = 1 Then
                strRecon = "RECONNECTION FEE"
                strReconFee = "250.00"
            ElseIf reconCount > 1 Then
                strRecon = "RECONNECTION FEE x " & reconCount
                strReconFee = Format(500 * reconCount, "#.#0")
            End If
        Else
            strRecon = ""
            strReconFee = ""
        End If

        If tOwner > 0 Then
            If tOwner = 1 Then
                strTOwner = "OWNERSHIP TRANSFER FEE"
                strTOwnerFee = "500.00"
            ElseIf tOwner > 1 Then
                strTOwner = "OWNERSHIP TRANSFER FEE x " & tOwner
                strTOwnerFee = Format(500 * tOwner, "#.#0")
            End If
        Else
            strTOwner = ""
            strTOwnerFee = ""
        End If

        If tMeter > 0 Then
            If tMeter = 1 Then
                strTMeter = "METER TRANSFER FEE"
                strTMeterFee = "250.00"
            ElseIf tMeter > 1 Then
                strTMeter = "METER TRANSFER FEE x " & tMeter
                strTMeterFee = Format(250 * tMeter, "#.#0")
            End If
        Else
            strTMeter = ""
            strTMeterFee = ""
        End If
        Dim strInstallLabel As String = ""
        Dim strInstallAmt As String = ""
        If totalInstallment > 0 Then
            strInstallLabel = "INSTALLATION FEE"
            strInstallAmt = Format(Val(totalInstallment), "#,##0.#0")
        Else
            strInstallLabel = ""
            strInstallAmt = ""
        End If

        If overpaymentCount > 0 Then
            strOverpay = "OVERPAYMENT"
            strOverpayFee = Format(Val(totalOverpayment), "#,##0.#0")
        End If

        If bulkordercount > 0 Then
            strBulk = "BULK WATER"
            strBulkAmount = Format(Val(totalBulk), "#,##0.#0")
        End If
        ' OR BUILDUP
        naturePayment(0) = ""
        naturePayment(1) = ""
        naturePayment(2) = ""
        naturePayment(3) = ""
        naturePayment(4) = ""
        naturePayment(5) = ""
        naturePayment(6) = ""
        naturePayment(7) = ""
        acctCodePayment(0) = ""
        acctCodePayment(1) = ""
        acctCodePayment(2) = ""
        acctCodePayment(3) = ""
        acctCodePayment(4) = ""
        acctCodePayment(5) = ""
        acctCodePayment(6) = ""
        acctCodePayment(7) = ""
        amtPayment(0) = ""
        amtPayment(1) = ""
        amtPayment(2) = ""
        amtPayment(3) = ""
        amtPayment(4) = ""
        amtPayment(5) = ""
        amtPayment(6) = ""
        amtPayment(7) = ""

        Dim myDiscount As Decimal = totalDiscount
        Dim myPenalty As Decimal = newTotalPenalty
        Dim myInstallment As Decimal = totalInstallment
        Dim strSenDis As String = ""
        Dim strSendDisAmt As String = ""

        If myDiscount > 0 Then
            strSenDis = "DISCOUNT"
            strSendDisAmt = Format(Val(txtDiscount.Text), "#,##0.#0")
        Else
            strSenDis = ""
            strSendDisAmt = ""
        End If

        If installCount > 0 Then
            naturePayment(0) = strInstall
            amtPayment(0) = strInstallFee
        ElseIf pubBillCount > 0 Then
            naturePayment(0) = "WATER BILL FOR"
            naturePayment(1) = strMonthIncluded
            naturePayment(2) = "E.F."
            amtPayment(0) = Format(Val(totalWaterBill) - Val(totalEnvi), "#,##0.#0")
            oBillAmt = totalWaterBill
            amtPayment(1) = ""
            amtPayment(2) = Format(Val(totalEnvi), "#,##0.#0")
            If myDiscount > 0 And myPenalty = 0 And totalInstallment = 0 And totalOverpayment = 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
            ElseIf myDiscount > 0 And myPenalty > 0 And totalInstallment = 0 And totalOverpayment = 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strPenLabel
                amtPayment(4) = amtPenLabel
            ElseIf myDiscount > 0 And myPenalty > 0 And totalInstallment > 0 And totalOverpayment = 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strPenLabel
                amtPayment(4) = amtPenLabel
                naturePayment(5) = strInstallLabel
                amtPayment(5) = strInstallAmt
            ElseIf myDiscount = 0 And myPenalty > 0 And totalInstallment > 0 And totalOverpayment = 0 Then
                naturePayment(3) = strPenLabel
                amtPayment(3) = amtPenLabel
                naturePayment(4) = strInstallLabel
                amtPayment(4) = strInstallAmt
            ElseIf myDiscount = 0 And myPenalty > 0 And totalInstallment = 0 And totalOverpayment = 0 Then
                naturePayment(3) = strPenLabel
                amtPayment(3) = amtPenLabel
            ElseIf myDiscount = 0 And myPenalty = 0 And totalInstallment > 0 And totalOverpayment = 0 Then
                naturePayment(3) = strInstallLabel
                amtPayment(3) = strInstallAmt
            ElseIf myDiscount > 0 And myPenalty = 0 And totalInstallment > 0 And totalOverpayment = 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strInstallLabel
                amtPayment(4) = strInstallAmt
            ElseIf myDiscount = 0 And myPenalty = 0 And totalInstallment = 0 And totalOverpayment > 0 Then
                naturePayment(3) = strOverpay
                amtPayment(3) = strOverpayFee
            ElseIf myDiscount = 0 And myPenalty = 0 And totalInstallment > 0 And totalOverpayment > 0 Then
                naturePayment(3) = strOverpay
                amtPayment(3) = strOverpayFee
                naturePayment(4) = strInstallLabel
                amtPayment(4) = strInstallAmt
            ElseIf myDiscount = 0 And myPenalty > 0 And totalInstallment = 0 And totalOverpayment > 0 Then
                naturePayment(3) = strOverpay
                amtPayment(3) = strOverpayFee
                naturePayment(4) = strPenLabel
                amtPayment(4) = amtPenLabel
            ElseIf myDiscount = 0 And myPenalty > 0 And totalInstallment > 0 And totalOverpayment > 0 Then
                naturePayment(3) = strOverpay
                amtPayment(3) = strOverpayFee
                naturePayment(4) = strPenLabel
                amtPayment(4) = amtPenLabel
                naturePayment(5) = strInstallLabel
                amtPayment(5) = strInstallAmt
            ElseIf myDiscount > 0 And myPenalty = 0 And totalInstallment = 0 And totalOverpayment > 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strOverpay
                amtPayment(4) = strOverpayFee
            ElseIf myDiscount > 0 And myPenalty = 0 And totalInstallment > 0 And totalOverpayment > 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strOverpay
                amtPayment(4) = strOverpayFee
                naturePayment(5) = strInstallLabel
                amtPayment(5) = strInstallAmt
            ElseIf myDiscount > 0 And myPenalty > 0 And totalInstallment = 0 And totalOverpayment > 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strOverpay
                amtPayment(4) = strOverpayFee
                naturePayment(5) = strPenLabel
                amtPayment(5) = amtPenLabel
            ElseIf myDiscount > 0 And myPenalty > 0 And totalInstallment > 0 And totalOverpayment > 0 Then
                naturePayment(3) = strSenDis
                amtPayment(3) = "(" & Format(myDiscount, "#,##0.#0") & ")"
                naturePayment(4) = strOverpay
                amtPayment(4) = strOverpayFee
                naturePayment(5) = strPenLabel
                amtPayment(5) = amtPenLabel
                naturePayment(6) = strInstallLabel
                amtPayment(6) = strInstallAmt
            End If

        ElseIf pubBillCount = 0 And totalInstallment > 0 Then
            naturePayment(0) = strInstallLabel
            amtPayment(0) = strInstallAmt
        ElseIf pubBillCount = 0 And totalBulk > 0 Then
            naturePayment(0) = strBulk
            amtPayment(0) = strBulkAmount
        Else
            If reconCount > 0 And tMeter = 0 And tOwner = 0 Then
                naturePayment(0) = strRecon
                amtPayment(0) = strReconFee
            ElseIf reconCount > 0 And tMeter > 0 And tOwner = 0 Then
                naturePayment(0) = strRecon
                amtPayment(0) = strReconFee
                naturePayment(1) = strTMeter
                amtPayment(1) = strTMeterFee
            ElseIf reconCount > 0 And tMeter > 0 And tOwner > 0 Then
                naturePayment(0) = strRecon
                amtPayment(0) = strReconFee
                naturePayment(1) = strTMeter
                amtPayment(1) = strTMeterFee
                naturePayment(2) = strTOwner
                amtPayment(2) = strTOwnerFee
            ElseIf reconCount = 0 And tMeter > 0 And tOwner = 0 Then
                naturePayment(0) = strTMeter
                amtPayment(0) = strTMeterFee
            ElseIf reconCount = 0 And tMeter > 0 And tOwner > 0 Then
                naturePayment(0) = strTMeter
                amtPayment(0) = strTMeterFee
                naturePayment(1) = strTOwner
                amtPayment(1) = strTOwnerFee
            ElseIf reconCount = 0 And tMeter = 0 And tOwner > 0 Then
                naturePayment(0) = strTOwner
                amtPayment(0) = strTOwnerFee
            End If
        End If

        Dim remarkbuild As String = ""
        If installCount > 0 Or totalInstallment > 0 Then
            remarkbuild = "APP FEE"
        ElseIf pubBillCount > 0 Then
            remarkbuild = strMonthIncluded
            If reconCount > 0 Then
                remarkbuild = remarkbuild & ", " & "RECONNECTION"
            End If
            If tMeter > 0 Then
                remarkbuild = remarkbuild & ", " & "TRANSFER METER"
            End If
            If tOwner > 0 Then
                remarkbuild = remarkbuild & ", " & "TRANSFER OWNER"
            End If
        ElseIf totalBulk > 0 Then
            remarkbuild = "BULK WATER"
        Else
            If reconCount > 0 And tMeter = 0 And tOwner = 0 Then
                remarkbuild = "RECONNECTION"
            ElseIf reconCount > 0 And tMeter > 0 And tOwner = 0 Then
                remarkbuild = "RECONNECTION, TRANSFER METER"
            ElseIf reconCount > 0 And tMeter > 0 And tOwner > 0 Then
                remarkbuild = "RECONNECTION, TRANSFER METER, TRANSFER OWNER"
            ElseIf reconCount = 0 And tMeter > 0 And tOwner = 0 Then
                remarkbuild = "TRANSFER METER"
            ElseIf reconCount = 0 And tMeter > 0 And tOwner > 0 Then
                remarkbuild = "TRANSFER METER, TRANSFER OWNER"
            ElseIf reconCount = 0 And tMeter = 0 And tOwner > 0 Then
                remarkbuild = "TRANSFER OWNER"
            End If
        End If

        InsertToOR(lblORNum.Text, totalReqPayment, cboPType.Text, strCBank, strCNum, strCDate, firstWords, secondWords, loggedUserID, dtpPaymentDate.Value, paymentConsumerID, senRmk, senIDPayment, allDiscount, naturePayment(0), naturePayment(1), naturePayment(2), naturePayment(3), naturePayment(4), naturePayment(5), naturePayment(6), naturePayment(7), "", "", "", "", "", "", "", "", amtPayment(0), amtPayment(1), amtPayment(2), amtPayment(3), amtPayment(4), amtPayment(5), amtPayment(6), amtPayment(7), "RUFINA B. BUNGALSO", pTypeCash, pTypeCheck, pTypeMO, strMNum.ToString(), strMDate, remarkbuild, oBillAmt, totalAdjustmentBill, myPenalty, Val(lblTotalEnvi.Text.Replace(",", "")) + Val(txtEF.Text), Val(strInstallFee) + Val(strInstallAmt), Val(strReconFee), Val(strTMeterFee) + Val(strTOwnerFee), totalOverpayment, waterbillpaymentaccountIDSelected)
        Dim firstNum As Integer = Val(lblORNum.Text)
        Dim down As Integer = Math.Floor(firstNum / 50) * 50 + 1
        Dim lastNum As Integer = Val(Val(lblORNum.Text))
        Dim upper As Integer = Math.Ceiling(lastNum / 50) * 50
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblORGroup WHERE Initial=" & down & " and Final=" & upper, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

        Else
            Dim cmd As New MySqlCommand("INSERT INTO tblORGroup(GroupName, Initial, Final) VALUES(@gName, @init, @fina)", con)
            cmd.Parameters.AddWithValue("@gName", Format(down, "000000#") & " to " & Format(upper, "000000#"))
            cmd.Parameters.AddWithValue("@init", down)
            cmd.Parameters.AddWithValue("@fina", upper)
            cmd.ExecuteNonQuery()
        End If
        For z As Integer = 0 To billCount - 1
            If arrPaymentType(z) = "Water Bill" Then
                Dim enAmt As Double
                If arrPrevBal(z) > 0 Then
                    enAmt = Val(txtEF.Text)
                Else
                    enAmt = 0
                End If
                Dim getSurDate As Date
                Dim getBillMonth As String
                Dim getBillYear As Integer
                Dim dtGetSDate As New DataTable
                Dim daGetSDate As New MySqlDataAdapter("SELECT duedate, billmonth, billyear FROM billing WHERE billID=" & paymentBillID(z), con)
                daGetSDate.Fill(dtGetSDate)
                getSurDate = dtGetSDate.Rows(0).Item(0)
                getBillMonth = dtGetSDate.Rows(0).Item(1).ToString
                getBillYear = dtGetSDate.Rows(0).Item(2)
                Dim nowDate As Date = dtpPaymentDate.Value
                Dim ComputeDays As TimeSpan = getSurDate - nowDate
                Dim intDays As Integer = ComputeDays.Days
                Dim surAmount As Double
                If getBillMonth = "December" And getBillYear = 2020 Then
                    surAmount = 0
                Else
                    If intDays < 0 Then
                        surAmount = arrPDPen(z)
                    Else
                        surAmount = 0
                    End If
                End If
                Dim addSCDisc As Double = 0
                Dim addPen As Double = 0
                Dim monthNum As Integer = DateTime.ParseExact(getBillMonth, "MMMM", CultureInfo.CurrentCulture).Month
                Dim yearNum As Integer = Val(arrBillYear(z))
                '===========================================================================
                If ((getBillMonth = "September" And getBillYear = 2022) Or (yearNum <= 2022 And Not (monthNum = 9 And yearNum = 2022))) And prevBalExisting = 1 Then
                    addSCDisc = Val(txtDiscount.Text)
                    addPen = Val(txtPenalty.Text)
                Else
                    addSCDisc = 0
                    addPen = 0
                End If
                '===========================================================================
                insertPaymentLog(paymentConsumerID, "Water Bill", arrPDAmount(z), DateAndTime.MonthName(dtpPaymentDate.Value.Month), DateAndTime.Year(dtpPaymentDate.Value), dtpPaymentDate.Value, arrAcctPaymentID(z), Val(arrPDEnFee(z)), lblORNum.Text, Val(arrPDSCDis(z)), Val(arrPDPen(z)))
                insertPayment(paymentConsumerID, lblORNum.Text, arrPDTotAmt(z), "", "Water Bill", "Current Bill", loggedUserID, cboPType.Text, DateAndTime.MonthName(dtpPaymentDate.Value.Month), dtpPaymentDate.Value.Year, arrAcctPaymentID(z), paymentBillID(z), surAmount, lastPLID, Val(arrPDEnFee(z)), Val(txtAmount.Text), Val(lblChange.Text), dtpPaymentDate.Value, Val(arrPDSCDis(z)), Val(arrPDAmount(z)))

                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,acctID,ORNum,periodcovered,collection,consumption,surcharge,drdate,pID,enviFee,discount) VALUES(@cID,@aID,@ORN,@pcovered,@collect,@consump,@sur,@transDate,@paymentID,@eFee,@disc)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@aID", arrAcctPaymentID(z))
                cmdDR.Parameters.AddWithValue("@ORN", lblORNum.Text)
                cmdDR.Parameters.AddWithValue("@pcovered", arrPDbillPeriod(z))
                cmdDR.Parameters.AddWithValue("@collect", Val(arrPDTotAmt(z)))
                cmdDR.Parameters.AddWithValue("@consump", arrPDConsump(z))
                cmdDR.Parameters.AddWithValue("@sur", surAmount)
                'cmdDR.Parameters.AddWithValue("@conFee", arrPDInstallment(z))
                cmdDR.Parameters.AddWithValue("@transDate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@paymentID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.Parameters.AddWithValue("@eFee", arrPDEnFee(z))
                cmdDR.Parameters.AddWithValue("@disc", arrPDSCDis(z))
                cmdDR.ExecuteNonQuery()

                If prevBalExisting = 1 Then
                    insertPaymentLog(paymentConsumerID, "Water Bill", (arrPrevBal(z) - addPen + addSCDisc), DateAndTime.MonthName(dtpPaymentDate.Value.Month), DateAndTime.Year(dtpPaymentDate.Value), dtpPaymentDate.Value, arrAcctPaymentID(z), enAmt, lblORNum.Text, addSCDisc, addPen)
                    insertPayment(paymentConsumerID, lblORNum.Text, arrPrevBal(z), "", "Water Bill", "Prev Bill", loggedUserID, cboPType.Text, DateAndTime.MonthName(dtpPaymentDate.Value.Month), dtpPaymentDate.Value.Year, arrAcctPaymentID(z), paymentBillID(z), addPen, lastPLID, enAmt, Val(txtAmount.Text), Val(lblChange.Text), dtpPaymentDate.Value, addSCDisc, Val(arrPrevBal(z) - addPen + addSCDisc))
                    Dim dtPrevID As New DataTable
                    Dim daPrevID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                    daPrevID.Fill(dtPrevID)
                    Dim cmdPDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,acctID,ORNum,periodcovered,collection,consumption,surcharge,drdate,pID,enviFee,discount) VALUES(@cID,@aID,@ORN,@pcovered,@collect,@consump,@sur,@transDate,@paymentID,@eFee,@disc)", con)
                    cmdPDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdPDR.Parameters.AddWithValue("@aID", arrAcctPaymentID(z))
                    cmdPDR.Parameters.AddWithValue("@ORN", lblORNum.Text)
                    cmdPDR.Parameters.AddWithValue("@pcovered", "")
                    cmdPDR.Parameters.AddWithValue("@collect", Val(arrPrevBal(z)) - Val(arrInstallmentAmount(z)))
                    cmdPDR.Parameters.AddWithValue("@consump", enAmt)
                    cmdPDR.Parameters.AddWithValue("@sur", addPen)
                    cmdPDR.Parameters.AddWithValue("@transDate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                    cmdPDR.Parameters.AddWithValue("@paymentID", Val(dtPID.Rows(0).Item(0).ToString))
                    cmdPDR.Parameters.AddWithValue("@eFee", enAmt)
                    cmdPDR.Parameters.AddWithValue("@disc", addSCDisc)
                    cmdPDR.ExecuteNonQuery()
                End If

                'PAYMENT FOR INSTALLMENT APPLICATION FEE/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                'PAYMENT FOR INSTALLMENT APPLICATION FEE/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                If arrPDInstallment(z) > 0 Then
                    UpdateInstallment(arrAcctPaymentID(z), arrPDInstallment(z), dtpPaymentDate.Value.Date)

                    Dim payCol As String
                    Dim payvalue As Double
                    payCol = "installpayment"
                    payvalue = Val(arrPDInstallment(z))
                    Dim cmdPL As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,@dPay)", con)
                    cmdPL.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdPL.Parameters.AddWithValue("@pval", payvalue)
                    cmdPL.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                    cmdPL.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                    cmdPL.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                    cmdPL.ExecuteNonQuery()
                    Dim dtLog As New DataTable
                    Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                    daLog.Fill(dtLog)
                    Dim plogID As Integer = Val(dtLog.Rows(0).Item(0).ToString)
                    Dim cmdPay As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,collectionnature,Remark,uID,paymentType,MonthofPayment,YearofPayment,acctID,plID,moneyamount,mchange,paymentDate) VALUES(@cID,@ORN,@pAmt,@colnat,@Rmk,@useID,@payType,@MPayment,@YPayment,@acID,@plogID,@mamt,@mcnge,@pDate)", con)
                    cmdPay.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdPay.Parameters.AddWithValue("@ORN", lblORNum.Text)
                    cmdPay.Parameters.AddWithValue("@pAmt", arrPDInstallment(z))
                    cmdPay.Parameters.AddWithValue("@colnat", "Installation Fee")
                    cmdPay.Parameters.AddWithValue("@Rmk", "Installation")
                    cmdPay.Parameters.AddWithValue("@useID", loggedUserID)
                    cmdPay.Parameters.AddWithValue("@payType", cboPType.Text)
                    cmdPay.Parameters.AddWithValue("@MPayment", DateAndTime.MonthName(dtpPaymentDate.Value.Month))
                    cmdPay.Parameters.AddWithValue("@YPayment", dtpPaymentDate.Value.Year)
                    cmdPay.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                    cmdPay.Parameters.AddWithValue("@plogID", plogID)
                    cmdPay.Parameters.AddWithValue("@mamt", Val(txtAmount.Text))
                    cmdPay.Parameters.AddWithValue("@mcnge", Val(lblChange.Text))
                    cmdPay.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value)
                    cmdPay.ExecuteNonQuery()

                    Dim cmdDT As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,connectionfee,drdate,pID) VALUES(@cID,@ORn,@other,@ddate,@payID)", con)
                    cmdDT.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdDT.Parameters.AddWithValue("@ORn", lblORNum.Text)
                    'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                    cmdDT.Parameters.AddWithValue("@other", Val(arrPDInstallment(z)))
                    cmdDT.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                    cmdDT.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                    cmdDT.ExecuteNonQuery()
                End If

                If arrInstallmentAmount(z) > 0 Then
                    UpdateInstallment(arrAcctPaymentID(z), arrInstallmentAmount(z), dtpPaymentDate.Value.Date)

                    Dim payCol As String
                    Dim payvalue As Double
                    payCol = "installpayment"
                    payvalue = Val(arrInstallmentAmount(z))
                    Dim cmdPL As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,@dPay)", con)
                    cmdPL.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdPL.Parameters.AddWithValue("@pval", payvalue)
                    cmdPL.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                    cmdPL.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                    cmdPL.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                    cmdPL.ExecuteNonQuery()
                    Dim dtLog As New DataTable
                    Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                    daLog.Fill(dtLog)
                    Dim plogID As Integer = Val(dtLog.Rows(0).Item(0).ToString)
                    Dim cmdPay As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,collectionnature,Remark,uID,paymentType,MonthofPayment,YearofPayment,acctID,plID,moneyamount,mchange,paymentDate) VALUES(@cID,@ORN,@pAmt,@colnat,@Rmk,@useID,@payType,@MPayment,@YPayment,@acID,@plogID,@mamt,@mcnge,@pDate)", con)
                    cmdPay.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdPay.Parameters.AddWithValue("@ORN", lblORNum.Text)
                    cmdPay.Parameters.AddWithValue("@pAmt", arrInstallmentAmount(z))
                    cmdPay.Parameters.AddWithValue("@colnat", "Installation Fee")
                    cmdPay.Parameters.AddWithValue("@Rmk", "Installation")
                    cmdPay.Parameters.AddWithValue("@useID", loggedUserID)
                    cmdPay.Parameters.AddWithValue("@payType", cboPType.Text)
                    cmdPay.Parameters.AddWithValue("@MPayment", DateAndTime.MonthName(dtpPaymentDate.Value.Month))
                    cmdPay.Parameters.AddWithValue("@YPayment", dtpPaymentDate.Value.Year)
                    cmdPay.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                    cmdPay.Parameters.AddWithValue("@plogID", plogID)
                    cmdPay.Parameters.AddWithValue("@mamt", Val(txtAmount.Text))
                    cmdPay.Parameters.AddWithValue("@mcnge", Val(lblChange.Text))
                    cmdPay.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value)
                    cmdPay.ExecuteNonQuery()

                    Dim cmdDT As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,connectionfee,drdate,pID) VALUES(@cID,@ORn,@other,@ddate,@payID)", con)
                    cmdDT.Parameters.AddWithValue("@cID", paymentConsumerID)
                    cmdDT.Parameters.AddWithValue("@ORn", lblORNum.Text)
                    cmdDT.Parameters.AddWithValue("@other", Val(arrInstallmentAmount(z)))
                    cmdDT.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                    cmdDT.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                    cmdDT.ExecuteNonQuery()
                End If
                'PAYMENT FOR INSTALLMENT APPLICATION FEE/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                'PAYMENT FOR INSTALLMENT APPLICATION FEE/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                Dim dtBill As New DataTable
                Dim daBill As New MySqlDataAdapter("Select * FROM billing WHERE billID=" & paymentBillID(z) & " And prevOutstandingStat='UNPAID'", con)
                daBill.Fill(dtBill)

                If dtBill.Rows.Count > 0 Then
                    Dim cmd As New MySqlCommand("UPDATE billing SET billstat='PAID', prevOutstandingStat='PAID', prevOutstanding=0, prevOutstandingOR='" & lblORNum.Text & "', prevOutstandingDuration='" & strMonthIncluded & "', ORNUMPAID='" & lblORNum.Text & "', AmountPaid=" & totalReqPayment & ", MoneyAmount=" & Val(txtAmount.Text) & ", mChange=" & Val(lblChange.Text) & ", paymentDate=@pDate, prevOutPenalty=0, prevOutEF=0, prevStartMonth=null, prevStartYear=null, prevOutDiscount=0 WHERE billID=" & paymentBillID(z), con)
                    cmd.Parameters.AddWithValue("@pDate", dtpDate.Value.Date)
                    cmd.ExecuteNonQuery()
                Else
                    Dim cmd As New MySqlCommand("UPDATE billing SET billstat='PAID', ORNUMPAID='" & lblORNum.Text & "', AmountPaid=" & totalReqPayment & ", MoneyAmount=" & Val(txtAmount.Text) & ", mChange=" & Val(lblChange.Text) & ", paymentDate=@pDate WHERE billID=" & paymentBillID(z), con)
                    cmd.Parameters.AddWithValue("@pDate", dtpDate.Value.Date)
                    cmd.ExecuteNonQuery()
                End If
            ElseIf arrPaymentType(z) = "Installation" Then
                'insertPaymentLog(paymentConsumerID, "Installation", Val(arrPDReq(z)), DateAndTime.MonthName(dtpPaymentDate.Value.Month), DateAndTime.Year(dtpPaymentDate.Value), dtpPaymentDate.Value, selPayAcctID, 0, lblORNum.Text)
                'insertPayment(paymentConsumerID, lblORNum.Text, Val(arrPDReq(z)), "", "Installation Fee", "", loggedUserID, cboPType.Text, DateAndTime.MonthName(dtpPaymentDate.Value.Month), Now.Year, selPayAcctID, prevBalBillID, 0, lastPLID, 0, Val(txtAmount.Text), Val(lblChange.Text), dtpPaymentDate.Value)
                'PAYMENT LOG
                Dim payCol As String
                Dim payvalue As Double
                payCol = "installpayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdIns As New MySqlCommand("INSERT INTO applicationfeetotalbalance(acctID,balance,consID) VALUES(0," & paymentConsumerID & "," & Val(arrPDReq(z)) & ")", con)
                cmdIns.ExecuteNonQuery()
                Dim dtApp As New DataTable
                Dim daApp As New MySqlDataAdapter("SELECT MAX(afeetotID) FROM applicationfeetotalbalance WHERE consID=" & paymentConsumerID & " and acctID=0", con)
                daApp.Fill(dtApp)
                Dim afeetotID As Integer = Val(dtApp.Rows(0).Item(0).ToString)
                Dim cmdInsPB As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotID,Amount,paymentDate) VALUES(" & afeetotID & "," & Val(arrPDReq(z)) & ",@pDate)", con)
                cmdInsPB.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmdInsPB.ExecuteNonQuery()
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,@dPay)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.ExecuteNonQuery()
                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)
                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Installation Fee")
                cmd.Parameters.AddWithValue("@rmk", "Installation")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,connectionfee,drdate,pID) VALUES(@cID,@ORn,@confee,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                cmdDR.Parameters.AddWithValue("@confee", Val(arrPDReq(z)))
                'cmdDR.Parameters.AddWithValue("@other", Nothing)
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()
                'OR USAGE INSERT
                Dim cmdORUsage As New MySqlCommand("INSERT INTO tblorusage(ORNum,uID,conID,FeeType,Status)values(@ORN,@userID,@cID,@FType,@Stat)", con)
                cmdORUsage.Parameters.AddWithValue("@ORN", lblORNum.Text)
                cmdORUsage.Parameters.AddWithValue("@userID", loggedUserID)
                cmdORUsage.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdORUsage.Parameters.AddWithValue("@FType", "Installation")
                cmdORUsage.Parameters.AddWithValue("@Stat", "Unused")
                cmdORUsage.ExecuteNonQuery()
            ElseIf arrPaymentType(z) = "Reconnection" Then
                Dim payCol As String
                Dim payvalue As Double
                payCol = "ReconnectPayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,@dPay)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.ExecuteNonQuery()

                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)

                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Reconnection Fee")
                cmd.Parameters.AddWithValue("@rmk", "Reconnection")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,others,drdate,pID) VALUES(@cID,@ORn,@other,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                cmdDR.Parameters.AddWithValue("@other", Val(arrPDReq(z)))
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()
                'OR USAGE INSERT
                Dim cmdORUsage As New MySqlCommand("INSERT INTO tblorusage(ORNum,uID,conID,FeeType,Status)values(@ORN,@userID,@cID,@FType,@Stat)", con)
                cmdORUsage.Parameters.AddWithValue("@ORN", lblORNum.Text)
                cmdORUsage.Parameters.AddWithValue("@userID", loggedUserID)
                cmdORUsage.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdORUsage.Parameters.AddWithValue("@FType", "Reconnection")
                cmdORUsage.Parameters.AddWithValue("@Stat", "Unused")
                cmdORUsage.ExecuteNonQuery()

            ElseIf arrPaymentType(z) = "Transfer Owner" Then
                Dim payCol As String
                Dim payvalue As Double
                payCol = "OwnerPayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,@dPay)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.ExecuteNonQuery()

                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)

                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Owner Transfer Fee")
                cmd.Parameters.AddWithValue("@rmk", "Owner Transfer")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,others,drdate,pID) VALUES(@cID,@ORn,@other,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                cmdDR.Parameters.AddWithValue("@other", Val(arrPDReq(z)))
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()
                'OR USAGE INSERT
                Dim cmdORUsage As New MySqlCommand("INSERT INTO tblorusage(ORNum,uID,conID,FeeType,Status)values(@ORN,@userID,@cID,@FType,@Stat)", con)
                cmdORUsage.Parameters.AddWithValue("@ORN", lblORNum.Text)
                cmdORUsage.Parameters.AddWithValue("@userID", loggedUserID)
                cmdORUsage.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdORUsage.Parameters.AddWithValue("@FType", "Ownership")
                cmdORUsage.Parameters.AddWithValue("@Stat", "Unused")
                cmdORUsage.ExecuteNonQuery()
            ElseIf arrPaymentType(z) = "Transfer Meter" Then
                Dim payCol As String
                Dim payvalue As Double
                payCol = "MeterPayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,@dPay)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.ExecuteNonQuery()

                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)

                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Meter Transfer Fee")
                cmd.Parameters.AddWithValue("@rmk", "Meter Transfer")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,others,drdate,pID) VALUES(@cID,@ORn,@other,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                cmdDR.Parameters.AddWithValue("@other", Val(arrPDReq(z)))
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()
                'OR USAGE INSERT
                Dim cmdORUsage As New MySqlCommand("INSERT INTO tblorusage(ORNum,uID,conID,FeeType,Status)values(@ORN,@userID,@cID,@FType,@Stat)", con)
                cmdORUsage.Parameters.AddWithValue("@ORN", lblORNum.Text)
                cmdORUsage.Parameters.AddWithValue("@userID", loggedUserID)
                cmdORUsage.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdORUsage.Parameters.AddWithValue("@FType", "Meter")
                cmdORUsage.Parameters.AddWithValue("@Stat", "Unused")
                cmdORUsage.ExecuteNonQuery()
            ElseIf arrPaymentType(z) = "Installment Fee" Then
                UpdateInstallment(arrAcctPaymentID(z), Val(arrPDReq(z)), dtpPaymentDate.Value.Date)
                Dim payCol As String
                Dim payvalue As Double
                payCol = "installPayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment,acctID) VALUES(@cID,@pval,@mPay,@yPay,@dPay,@acID)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmdP.ExecuteNonQuery()

                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)

                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,acctID,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @acID,@ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Installation Fee")
                cmd.Parameters.AddWithValue("@rmk", "Installation")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,acctID,ORNum,connectionfee,drdate,pID) VALUES(@cID,@acID,@ORn,@other,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                cmdDR.Parameters.AddWithValue("@other", Val(arrPDReq(z)))
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()

                'Cons()
                'Dim dtCurIns As New DataTable
                'Dim daCurIns As New MySqlDataAdapter("SELECT * FROM applicationfeetotalbalance WHERE acctID=" & arrAcctPaymentID(z), con)
                'daCurIns.Fill(dtCurIns)
                'If dtCurIns.Rows.Count > 0 Then
                '    Dim getTotID As Integer = Val(dtCurIns.Rows(0).Item(0).ToString)
                '    Dim getBal As Decimal = Val(dtCurIns.Rows(0).Item(2).ToString)
                '    Dim getRem As Integer = Val(dtCurIns.Rows(0).Item(3).ToString)
                '    Dim newRem As Integer = getRem - ((3600 - (720 + Val(arrPDReq(z)))) / 240)
                '    Dim newBal As Decimal = getBal + Val(arrPDReq(z))
                '    Dim cmdI As New MySqlCommand("UPDATE applicationfeetotalbalance SET balance=" & newBal & " AND remMonths=" & newRem & " WHERE acctID=" & arrAcctPaymentID(z), con)
                '    cmdI.ExecuteNonQuery()
                '    Dim cmdA As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotID,Amount,paymentDate) VALUES(@fID,@fAmt,@pDate)", con)
                '    cmdA.Parameters.AddWithValue("@fID", getTotID)
                '    cmdA.Parameters.AddWithValue("@fAmt", Val(arrPDReq(z)))
                '    cmdA.Parameters.AddWithValue("@pDate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                '    cmdA.ExecuteNonQuery()
                'Else
                '    Dim cRem As Integer = ((3600 - (720 + Val(arrPDReq(z)))) / 240)
                '    Dim cmdI As New MySqlCommand("INSERT INTO applicationfeetotalbalance(acctID,balance,remMonths)VALUES(" & arrAcctPaymentID(z) & "," & (720 + arrPDInstallment(z)) & "," & cRem & ")", con)
                '    cmdI.ExecuteNonQuery()
                '    Dim dtGID As New DataTable
                '    Dim daGID As New MySqlDataAdapter("SELECT * FROM applicationfeetotalbalance WHERE acctID=" & arrAcctPaymentID(z), con)
                '    daGID.Fill(dtGID)
                '    Dim gID As Integer = Val(dtGID.Rows(0).Item(0).ToString)
                '    Dim cmdIns As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotID,Amount,paymentDate) VALUES(@fID,@fAmt,@pDate)", con)
                '    cmdIns.Parameters.AddWithValue("@fID", gID)
                '    cmdIns.Parameters.AddWithValue("@fAmt", 720)
                '    cmdIns.Parameters.AddWithValue("@pDate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                '    cmdIns.ExecuteNonQuery()
                '    Dim cmdIns2 As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotID,Amount,paymentDate) VALUES(@fID,@fAmt,@pDate)", con)
                '    cmdIns2.Parameters.AddWithValue("@fID", gID)
                '    cmdIns2.Parameters.AddWithValue("@fAmt", Val(arrPDReq(z)))
                '    cmdIns2.Parameters.AddWithValue("@pDate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                '    cmdIns2.ExecuteNonQuery()
                'End If
                'OR USAGE INSERT
                'Dim cmdORUsage As New MySqlCommand("INSERT INTO tblorusage(ORNum,uID,conID,FeeType,Status)values(@ORN,@userID,@cID,@FType,@Stat)", con)
                'cmdORUsage.Parameters.AddWithValue("@ORN", lblORNum.Text)
                'cmdORUsage.Parameters.AddWithValue("@userID", loggedUserID)
                'cmdORUsage.Parameters.AddWithValue("@cID", paymentConsumerID)
                'cmdORUsage.Parameters.AddWithValue("@FType", "Meter")
                'cmdORUsage.Parameters.AddWithValue("@Stat", "Unused")
                'cmdORUsage.ExecuteNonQuery()
            ElseIf arrPaymentType(z) = "Overpayment" Then

                Dim dtOP As New DataTable
                Dim daOP As New MySqlDataAdapter("SELECT * FROM tbloverpayment WHERE acctID=" & arrAcctPaymentID(z), con)
                daOP.Fill(dtOP)
                If dtOP.Rows.Count > 0 Then
                    Dim getAmt As Decimal = Val(dtOP.Rows(0).Item(2).ToString)
                    Dim newAmt As Decimal = getAmt + totalOverpayment
                    Dim cmdOverPay As New MySqlCommand("UPDATE tbloverpayment SET balamt=" & newAmt & " WHERE acctID=" & arrAcctPaymentID(z), con)
                    cmdOverPay.ExecuteNonQuery()
                Else
                    Dim cmdOverPay As New MySqlCommand("INSERT INTO tbloverpayment(acctID, balamt) VALUES(" & arrAcctPaymentID(z) & "," & totalOverpayment & ")", con)
                    cmdOverPay.ExecuteNonQuery()
                End If
                Dim payCol As String
                Dim payvalue As Decimal
                payCol = "Overpayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment,acctID) VALUES(@cID,@pval,@mPay,@yPay,@dPay,@acID)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmdP.ExecuteNonQuery()

                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)

                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,acctID,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay,@acID, @ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Overpayment")
                cmd.Parameters.AddWithValue("@rmk", "Overpayment")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,acctID,ORNum,others,drdate,pID) VALUES(@cID,@acID,@ORn,@other,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                cmdDR.Parameters.AddWithValue("@other", Val(arrPDReq(z)))
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()
                'OR USAGE INSERT
            ElseIf arrPaymentType(z) = "Bulk Order" Then
                Dim payCol As String
                Dim payvalue As Double
                payCol = "bulkpayment"
                payvalue = Val(arrPDReq(z))
                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment,acctID) VALUES(@cID,@pval,@mPay,@yPay,@dPay,@acID)", con)
                cmdP.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdP.Parameters.AddWithValue("@pval", payvalue)
                cmdP.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmdP.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmdP.Parameters.AddWithValue("@dPay", dtpPaymentDate.Value.Date)
                cmdP.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmdP.ExecuteNonQuery()

                Dim dtLog As New DataTable
                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                daLog.Fill(dtLog)

                'PAYMENT RECORD
                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,acctID,plID,paymentdate) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @acID,@ploID, @pDate)", con)
                cmd.Parameters.AddWithValue("@cusID", paymentConsumerID)
                cmd.Parameters.AddWithValue("@ORNum", lblORNum.Text)
                cmd.Parameters.AddWithValue("@amt", Val(arrPDReq(z)))
                cmd.Parameters.AddWithValue("@actCode", "")
                cmd.Parameters.AddWithValue("@colnat", "Bulk Water")
                cmd.Parameters.AddWithValue("@rmk", "Bulk")
                cmd.Parameters.AddWithValue("@usID", loggedUserID)
                cmd.Parameters.AddWithValue("@ptype", cboPType.Text)
                cmd.Parameters.AddWithValue("@mPay", (Format(dtpPaymentDate.Value.Date, "MMMM")))
                cmd.Parameters.AddWithValue("@yPay", dtpPaymentDate.Value.Year)
                cmd.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                cmd.Parameters.AddWithValue("@pDate", dtpPaymentDate.Value.Date)
                cmd.ExecuteNonQuery()
                Dim dtPID As New DataTable
                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                daPID.Fill(dtPID)
                'TRANSACTION LOG
                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,acctID,ORNum,Collection,Consumption,bulk,drdate,pID) VALUES(@cID,@acID,@ORn,@Coll,@Consu,@other,@ddate,@payID)", con)
                cmdDR.Parameters.AddWithValue("@cID", paymentConsumerID)
                cmdDR.Parameters.AddWithValue("@acID", arrAcctPaymentID(z))
                cmdDR.Parameters.AddWithValue("@ORn", lblORNum.Text)
                cmdDR.Parameters.AddWithValue("@Coll", arrPDReq(z))
                cmdDR.Parameters.AddWithValue("@Consu", arrPDConsump(z))
                'cmdDR.Parameters.AddWithValue("@confee", Nothing)
                cmdDR.Parameters.AddWithValue("@other", Val(arrPDReq(z)))
                cmdDR.Parameters.AddWithValue("@ddate", Format(dtpPaymentDate.Value.Date, "yyyy-MM-dd"))
                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                cmdDR.ExecuteNonQuery()
            End If
        Next
        updateCurOR(Val(lblORNum.Text))
        WaterBillPayment.txtORNum.Text = currentOR(loggedUserID)
        MessageBox.Show("Payment Confirmed", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If totalReqPayment <= Val(txtAmount.Text) Then
            If cboMonth.Visible = True Then
                If cboMonth.Text = "" Or cboYear.Text = "" Or txtEF.Text = "" Then
                    MessageBox.Show("Please Fill Missing Values", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    If MessageBox.Show("Confirm Payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        SaveValues()
                        WaterBillPayment.ConsumerSelection(WaterBillPayment.cboConsumerName.SelectedIndex)

                        Dim dtR As New DataTable
                        Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lblORNum.Text & "'", con)
                        daR.Fill(dtR)
                        'daR.Fill(frmORReport.reportingdataset.ORDataTable)
                        'frmORReport.ORReport.RefreshReport()
                        'frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                        'frmORReport.ORReport.ZoomPercent = 100%
                        'frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                        'frmORReport.ORReport.Width = 75
                        'frmORReport.WindowState = FormWindowState.Maximized
                        'Me.Close()
                        'frmORReport.ShowDialog()
                        Dim report As New crptOR
                        report.SetDataSource(dtR)
                        frmCrystalOR.CrystalReportViewer1.ReportSource = report
                        frmCrystalOR.CrystalReportViewer1.Zoom(100%)
                        frmCrystalOR.CrystalReportViewer1.Refresh()
                        'frmCrystalOR.CrystalReportViewer1.RefreshReport()
                        frmCrystalOR.WindowState = FormWindowState.Maximized
                        Me.Close()
                        frmCrystalOR.ShowDialog()
                    End If
                End If
            Else
                If MessageBox.Show("Confirm Payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    SaveValues()
                    WaterBillPayment.ConsumerSelection(WaterBillPayment.cboConsumerName.SelectedIndex)

                    Dim dtR As New DataTable
                    Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lblORNum.Text & "'", con)
                    daR.Fill(dtR)
                    'daR.Fill(frmORReport.reportingdataset.ORDataTable)
                    'frmORReport.ORReport.RefreshReport()
                    'frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    'frmORReport.ORReport.ZoomPercent = 100%
                    'frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                    'frmORReport.ORReport.Width = 75
                    'frmORReport.WindowState = FormWindowState.Maximized
                    'Me.Close()
                    'frmORReport.ShowDialog()
                    Dim report As New crptOR
                    report.SetDataSource(dtR)
                    frmCrystalOR.CrystalReportViewer1.ReportSource = report
                    frmCrystalOR.CrystalReportViewer1.Zoom(100%)
                    frmCrystalOR.CrystalReportViewer1.Refresh()
                    'frmCrystalOR.CrystalReportViewer1.RefreshReport()
                    frmCrystalOR.WindowState = FormWindowState.Maximized
                    Me.Close()
                    frmCrystalOR.ShowDialog()
                End If
            End If
        Else
            MessageBox.Show("Insufficient payment amount.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        lblPaymentPeriod.Text = UCase(Mid(cboMonth.Text, 1, 3)) & " " & Mid(cboYear.Text, 3, 4) & " TO " & UCase(Mid(latestMonth, 1, 3)) & " " & Mid(latestYear, 3, 4)
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        lblPaymentPeriod.Text = UCase(Mid(cboMonth.Text, 1, 3)) & " " & Mid(cboYear.Text, 3, 4) & " TO " & UCase(Mid(latestMonth, 1, 3)) & " " & Mid(latestYear, 3, 4)
    End Sub

    Private Sub txtPenalty_TextChanged(sender As Object, e As EventArgs) Handles txtPenalty.TextChanged
        'newPen = totalPenalty + Val(txtPenalty.Text)
        'lblTotalPen.Text = Format(newPen, "#,##0.#0")
    End Sub

    Private Sub dtpPaymentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpPaymentDate.ValueChanged

    End Sub
End Class