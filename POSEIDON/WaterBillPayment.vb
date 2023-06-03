Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class WaterBillPayment
    Dim prevOutstandStat As String
    'Dim totalDiscount As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Confirm cancellation?", MsgBoxStyle.YesNo, "Water Bill Payment") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub cboConsumerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConsumerName.SelectedIndexChanged
        ConsumerSelection(cboConsumerName.SelectedIndex)
    End Sub

    Public Sub ConsumerSelection(conIndex As Integer)
        chkDiscount.CheckState = CheckState.Unchecked
        WaterBillAccountsList(arrConsWaterID(conIndex))
        lblConsumerID.Text = arrConsWaterID(conIndex)
        Dim chkSC As String = arrCheckSC(conIndex)

        If chkSC = "YES" Then
            chkDiscount.CheckState = CheckState.Checked
            txtSeniorID.Enabled = True
            txtSeniorID.Text = arrSenIDCons(conIndex)
        Else
            chkDiscount.CheckState = CheckState.Unchecked
            txtSeniorID.Enabled = False
            txtSeniorID.Text = ""
        End If
        optionenablers()
        TotalAmountToPay(arrConsWaterID(conIndex))
    End Sub

    Private Sub WaterBillPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtORNum.Text = currentOR(loggedUserID)
        WaterBillConsumerList()
        cboConsumerName.SelectedIndex = 0
        TotalAmountToPay(arrConsWaterID(cboConsumerName.SelectedIndex))
    End Sub

    Private Sub TotalAmountToPay(conID As Integer)
        If lvwAccounts.CheckedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT isSC FROM consumerlist WHERE consID=" & conID, con)
            da.Fill(dt)
            Dim checkSen As String = dt.Rows(0).Item(0).ToString
            Dim getTotAmount As Double = 0
            If checkSen = "YES" Then

            End If

            For x As Integer = 0 To lvwAccounts.CheckedItems.Count - 1
                'MessageBox.Show(Val(lvwAccounts.CheckedItems(x).SubItems(14).Text))
                Dim getAmount As Double = (Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))) ' + Val(lvwAccounts.CheckedItems(x).SubItems(14).Text.Replace(",", "")))
                getTotAmount = getTotAmount + getAmount
                PDtotalAmountToPay = getTotAmount
            Next
            lblTotalAmount.Text = Format(getTotAmount, "#,##0.#0")
        Else
            lblTotalAmount.Text = "0.00"
        End If

    End Sub
    Private Sub lvwAccounts_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwAccounts.ItemCheck

    End Sub
    Private Sub lvwAccounts_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvwAccounts.ItemChecked
        Dim getX As Integer = lvwAccounts.Items.Count - 1
        For x As Integer = 0 To getX
            If lvwAccounts.Items(x).Checked = True Then
                If lvwAccounts.Items(x).SubItems(1).Text = "Water Bill" Then
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter("select isAdjusted, adjApprov, adjApprovStat FROM billing WHERE billID=" & arrPaymentBillID(lvwAccounts.Items(x).Index), con)
                    da.Fill(dt)
                    Dim getAdj As String = dt.Rows(0).Item(0).ToString
                    Dim getAppr As Integer = Val(dt.Rows(0).Item(1).ToString)
                    Dim getConf As String = Val(dt.Rows(0).Item(2).ToString)
                    Dim strAdj As String
                    If getAdj = "" Then
                        strAdj = "None"
                    Else
                        strAdj = getAdj
                    End If
                    If strAdj <> "None" Then
                        If getConf <> "Approved" Then
                            MsgBox("Bill is not yet approved for payment", MsgBoxStyle.Exclamation, "For approval of adjustment/dispute")
                            lvwAccounts.Items(x).Checked = False
                        End If
                    End If
                    For y As Integer = 0 To getX
                        If lvwAccounts.Items(y).SubItems(1).Text = "Installation" Then
                            lvwAccounts.Items(y).Checked = False
                        End If
                    Next
                ElseIf lvwAccounts.Items(x).SubItems(1).Text = "Installation" Then
                    For y As Integer = 0 To getX
                        If lvwAccounts.Items(y).SubItems(1).Text <> "Installation" Then
                            lvwAccounts.Items(y).Checked = False
                        End If
                    Next
                ElseIf lvwAccounts.Items(x).SubItems(1).Text = "Transfer Meter" Then
                    For y As Integer = 0 To getX
                        'If lvwAccounts.Items(y).SubItems(1).Text <> "Transfer Meter" Then
                        '    lvwAccounts.Items(y).Checked = False
                        'End If
                    Next
                ElseIf lvwAccounts.Items(x).SubItems(1).Text = "Transfer Owner" Then
                    For y As Integer = 0 To getX
                        'If lvwAccounts.Items(y).SubItems(1).Text <> "Transfer Owner" Then
                        '    lvwAccounts.Items(y).Checked = False
                        'End If
                    Next
                ElseIf lvwAccounts.Items(x).SubItems(1).Text = "Reconnection" Then
                    For y As Integer = 0 To getX
                        'If lvwAccounts.Items(y).SubItems(1).Text <> "Reconnection" Then
                        '    lvwAccounts.Items(y).Checked = False
                        'End If
                    Next
                End If
            End If
        Next

        TotalAmountToPay(arrConsWaterID(cboConsumerName.SelectedIndex))
    End Sub
    Private Sub lvwAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwAccounts.SelectedIndexChanged
        optionenablers()
        If lvwAccounts.SelectedItems.Count > 0 Then
            Dim txtType As String = lvwAccounts.FocusedItem.SubItems(1).Text
            If txtType = "Installment Fee" Then
                btnInstallmentFeeEdit.Visible = True
            Else
                btnInstallmentFeeEdit.Visible = False
            End If
        End If

    End Sub
    Private Sub btnAdjust_Click(sender As Object, e As EventArgs) Handles btnAdjust.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            MessageBox.Show("Feature Soon")
            'Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT isAdjusted FROM billing WHERE billID=" & arrWaterBillMetID(lvwAccounts.FocusedItem.Index), con)
            'da.Fill(dt)
            'Dim chkAdj As String = dt.Rows(0).Item(0).ToString
            'If chkAdj = "None" Then
            '    'CODES HERE FOR ADJUSTMENT
            '    If (MessageBox.Show("Mark Bill for Adjustment", "Bill Dispute", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            '        Cons()
            '        Dim cmd As New MySqlCommand("UPDATE billing SET isAdjusted='Yes', adjRemark='Marked' WHERE billID=" & arrWaterBillMetID(lvwAccounts.FocusedItem.Index), con)
            '        cmd.ExecuteNonQuery()
            '        ConsumerSelection(cboConsumerName.SelectedIndex)
            '        MessageBox.Show("Bill has been marked for adjustment")
            '    End If
            'Else
            '    MsgBox("Bill Already Adjusted", MsgBoxStyle.Exclamation, "Bill Adjustment")
            '    Exit Sub
            'End If

        End If
    End Sub

    Public Sub PaymentFormBillDetails(billID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, B.billmonth, B.billyear, B.billdate, B.dueDate, A.AccountNo, B.prevRead, B.presRead, B.consump, B.amount, B.EnviFee, B.SCDiscount, B.applicationfee, B.penalty, B.prevAmountDue, B.prevPenalty, B.prevInstallmentFee, B.prevTotal, B.origAmount,B.origEnvi, B.origSCDis, B.origPenalty, B.origTotalAmountDue, B.isAdjusted, B.adjRemark FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID WHERE B.billID=" & billID, con)
        da.Fill(dt)
        lblBillNo.Text = dt.Rows(0).Item(0).ToString
        lblBillPer.Text = dt.Rows(0).Item(1).ToString & " " & dt.Rows(0).Item(2).ToString
        lblBillDate.Text = Format(dt.Rows(0).Item(3), "MM-dd-yyyy")
        lblDueDate.Text = Format(dt.Rows(0).Item(4), "MM-dd-yyyy")
        lblAccountNo.Text = dt.Rows(0).Item(5).ToString
        lblPrevRead.Text = dt.Rows(0).Item(6).ToString
        lblPresRead.Text = dt.Rows(0).Item(7).ToString
        lblConsump.Text = dt.Rows(0).Item(8).ToString
        lblWSF.Text = Format((Val(dt.Rows(0).Item(9).ToString) - Val(dt.Rows(0).Item(10).ToString)), "#,##0.#0")
        lblEF.Text = Format(Val(dt.Rows(0).Item(10).ToString), "#,##0.#0")
        lblDiscount.Text = Format(Val(dt.Rows(0).Item(11).ToString), "#,##0.#0")
        lblInstallmentFee.Text = Format(Val(dt.Rows(0).Item(12).ToString), "#,##0.#0")
        lblTotalAmountDue.Text = Format((Val(dt.Rows(0).Item(9).ToString) - Val(dt.Rows(0).Item(11).ToString) + Val(dt.Rows(0).Item(12).ToString)), "#,##0.#0")
        lblPenalty.Text = Format(Val(dt.Rows(0).Item(13).ToString), "#,##0.#0")
        lblAmountADue.Text = Format((Val(dt.Rows(0).Item(9).ToString) - Val(dt.Rows(0).Item(11).ToString) + Val(dt.Rows(0).Item(12).ToString) + Val(dt.Rows(0).Item(13).ToString)), "#,##0.#0")
        lblPrevWSF.Text = Format(Val(dt.Rows(0).Item(14).ToString), "#,##0.#0")
        lblPrevPen.Text = Format(Val(dt.Rows(0).Item(15).ToString), "#,##0.#0")
        lblPrevIns.Text = Format(Val(dt.Rows(0).Item(16).ToString), "#,##0.#0")
        lblPrevTotal.Text = Format((Val(dt.Rows(0).Item(17).ToString) + Val(dt.Rows(0).Item(16).ToString)), "#,##0.#0")
        lblAdjWSF.Text = Format(Val(dt.Rows(0).Item(18).ToString) - Val(dt.Rows(0).Item(19).ToString), "#,##0.#0")
        lblAdjEF.Text = Format(Val(dt.Rows(0).Item(19).ToString), "#,##0.#0")
        lblAdjDis.Text = Format(Val(dt.Rows(0).Item(20).ToString), "#,##0.#0")
        lblAdjPen.Text = Format(Val(dt.Rows(0).Item(21).ToString), "#,##0.#0")
        lblAdjTot.Text = Format(Val(dt.Rows(0).Item(22).ToString), "#,##0.#0")
        lblisADJ.Text = dt.Rows(0).Item(23).ToString
        lblAdjRem.Text = dt.Rows(0).Item(24).ToString
    End Sub

    Public Sub optionenablers()
        If lvwAccounts.SelectedItems.Count > 0 Then
            If lvwAccounts.FocusedItem.SubItems(1).Text = "Water Bill" Then
                gbxBill.Visible = True
                PaymentFormBillDetails(arrPaymentBillID(lvwAccounts.FocusedItem.Index))
                Dim checkAdjust As String = lvwAccounts.FocusedItem.SubItems(14).Text
                Dim checkRemark As String = lvwAccounts.FocusedItem.SubItems(15).Text
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT prevOutstanding FROM billing WHERE billID=" & arrPaymentBillID(lvwAccounts.FocusedItem.Index), con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Dim strCheckPrevOutstand As Decimal = Val(dt.Rows(0).Item(0).ToString)
                    If strCheckPrevOutstand > 0 Then
                        btnPayPrev.Visible = True
                    End If
                End If

                If checkAdjust = "None" Then

                    btnAdjust.Enabled = True
                    btnAdjust.Text = "Request Adjustment"

                ElseIf checkAdjust = "Yes" Then
                    If checkRemark = "Pending" Then
                        btnAdjust.Enabled = True
                        btnAdjust.Text = "Disregard Adjustment"
                    Else
                        btnAdjust.Enabled = False
                        btnAdjust.Text = "Disregard Adjustment"
                    End If

                End If
            End If
        Else
            'btnDisregard.Visible = False
            btnAdjust.Enabled = False
            btnPayPrev.Visible = False
            gbxBill.Visible = False
        End If
        TotalAmountToPay(arrConsWaterID(cboConsumerName.SelectedIndex))
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If txtORNum.Text = "" Then
            MsgBox("OR Number is Required", MsgBoxStyle.Exclamation, "No OR Number")
        Else
            paymentConsumerID = arrConsWaterID(cboConsumerName.SelectedIndex)
            Dim dtChOR As New DataTable
            Dim daChOR As New MySqlDataAdapter("SELECT * FROM tblor WHERE ORNum='" & txtORNum.Text.Replace("'", "''") & "'", con)
            daChOR.Fill(dtChOR)
            If dtChOR.Rows.Count > 0 Then
                MsgBox("Same OR Number found", MsgBoxStyle.Exclamation, "Same OR Number Found")
                Exit Sub
            Else

                If chkDiscount.CheckState = CheckState.Checked Then
                    If txtSeniorID.Text = "" Then
                        If MessageBox.Show("There are no Details for Senior Citizen ID/PWD ID, do you want to proceed to payment?", "No SC/PWD ID#", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                            Exit Sub
                        End If
                    End If
                End If
                If lvwAccounts.CheckedItems.Count > 0 Then
                    prevOutstandStat = ""
                    billCount = lvwAccounts.CheckedItems.Count
                    totalAjustedRate = 0
                    totalEnvi = 0
                    totalWSF = 0
                    totalInstallment = 0
                    totalApplication = 0
                    totalWaterBill = 0
                    totalDiscount = 0
                    totalPenalty = 0
                    totalReqPayment = 0
                    totalPrevBal = 0
                    totPrevPen = 0
                    totPrevEF = 0
                    totPrevDis = 0
                    startMonth = ""
                    startYear = 0
                    totalAdjustmentBill = 0
                    totalOverpayment = 0
                    Cons()
                    senRmk = arrCheckSC(cboConsumerName.SelectedIndex)
                    senIDPayment = txtSeniorID.Text
                    Dim iC As Integer = lvwAccounts.CheckedItems.Count - 1
                    ReDim paymentBillID(iC)
                    ReDim paymentAccountNo(iC)
                    ReDim paymentAcctID(iC)
                    ReDim arrPDbillPeriod(iC)
                    ReDim arrPDDueDate(iC)
                    Dim FirstMonth As String = ""
                    Dim LastMonth As String = ""
                    Dim monthCount As Integer
                    ' ReDim arrPDbillPeriod(iC)
                    ReDim arrPDDueDate(iC)
                    ReDim arrAcctPaymentID(iC)
                    ReDim arrConsPaymentID(iC)
                    ReDim arrPaymentType(iC)
                    ReDim arrPDReadDate(iC)
                    ReDim arrPDBillDate(iC)
                    ReDim arrPDPrevRead(iC)
                    ReDim arrPDPresRead(iC)
                    ReDim arrPDConsump(iC)
                    'ReDim arrPDBRate(iC)
                    ReDim arrPDEnFee(iC)
                    'ReDim arrPDAdj(iC)
                    'ReDim arrPDAdjRate(iC)
                    ReDim arrPDTotAmt(iC)
                    ReDim arrPDAmount(iC)
                    ReDim arrPDPen(iC)
                    ReDim arrPDSCDis(iC)
                    ReDim arrPDInstallment(iC)
                    ReDim arrPDReq(iC)
                    ReDim arrPrevBal(iC)
                    'ReDim arrPDSCPen(iC)
                    'ReDim arrPDSCRate(iC)
                    ReDim arrPDAmtADue(iC)
                    ReDim arrPRDMetID(iC)
                    ReDim arrPDMetName(iC)
                    ReDim paymentbillNo(iC)
                    ReDim arrBillYear(iC)
                    ReDim arrBillMonth(iC)
                    ReDim arrOtherFees(iC)
                    ReDim arrPDWSF(iC)
                    ReDim arrPDPrevPenalty(iC)
                    ReDim arrPDPrevEF(iC)
                    ReDim arrPDPrevDiscount(iC)
                    ReDim arrPDPrevAmount(iC)
                    ReDim arrInstallmentAmount(iC)
                    ReDim arrInstallmentCount(iC)
                    ReDim arrOverpay(iC)
                    'ReDim arrPrevBal(iC)
                    ReDim arrPDPrevMonths(iC)
                    totalReqPayment = PDtotalAmountToPay
                    TotalPreviousToPay = 0
                    amountWords = ConvertNumberToWords(totalReqPayment.ToString)

                    Dim countBillOnlyMonths As Integer = 0
                    Dim totalOtherFees As Double = 0

                    For z As Integer = 0 To lvwAccounts.CheckedItems.Count - 1
                        If lvwAccounts.CheckedItems(z).SubItems(1).Text = "Water Bill" Then
                            countBillOnlyMonths = countBillOnlyMonths + 1
                        End If
                    Next
                    pubBillCount = countBillOnlyMonths

                    For x As Integer = 0 To lvwAccounts.CheckedItems.Count - 1
                        arrPaymentType(x) = lvwAccounts.CheckedItems(x).SubItems(1).Text

                        If lvwAccounts.CheckedItems(x).SubItems(1).Text = "Water Bill" Then

                            arrOtherFees(x) = 0
                            TotalPreviousToPay = TotalPreviousToPay + Val(lvwAccounts.CheckedItems(x).SubItems(16).Text.Replace(",", ""))
                            Dim dt As New DataTable
                            Dim da As New MySqlDataAdapter("SELECT B.billID, CL.ConsumerName, CA.AccountNo, CA.StreetAddress, CA.brgyID, BR.AddBrgy, CA.classID, CF.classification, B.dueDate, B.fromdate, B.toDate, B.billMonth, B.billYear, B.prevRead, B.presRead, B.consump, B.amount, B.EnviFee, B.penalty, B.isSC, B.SCDiscount, B.applicationfee, B.billPeriod, B.billDate, B.readDate, B.metReadID, MR.metName, B.prevOutstanding, B.acctID, B.prevOutPenalty, B.prevOutEF, B.prevStartMonth, B.prevStartYear, B.prevOutDiscount, B.prevOutstandingStat, B.outstandingInstallmentFee, B.outstandingInstallmentCount, B.useAmount, B.useADue FROM billing AS B LEFT JOIN consumerlist as CL ON B.consID=CL.consID LEFT JOIN consumeraccounts AS CA ON B.acctID=CA.acctID LEFT JOIN meterreader AS MR ON B.metReadID=MR.metID LEFT JOIN brgylist AS BR ON CA.brgyID=BR.brgyID LEFT JOIN classifications AS CF ON CA.classID=CF.classID WHERE B.billID=" & arrPaymentBillID(lvwAccounts.CheckedItems(x).Index), con)
                            da.Fill(dt)
                            Dim biMonth As String = dt.Rows(0).Item(11).ToString
                            arrBillMonth(x) = DateTime.ParseExact(dt.Rows(0).Item(11), "MMMM", CultureInfo.CurrentCulture).Month
                            arrBillYear(x) = Val(dt.Rows(0).Item(12).ToString)
                            Dim tempDate As Date = dt.Rows(0).Item(8)
                            paymentAccountNo(x) = dt.Rows(0).Item(2).ToString
                            paymentAcctID(x) = Val(dt.Rows(0).Item(28).ToString)
                            waterbillpaymentaccountIDSelected = paymentAcctID(x)
                            If x > 0 Then
                                Dim dayRange As Integer = DateDiff(DateInterval.Day, tempDate, latestBillDate)
                                If dayRange < 0 Then
                                    latestBillDate = tempDate
                                    latestMonth = dt.Rows(0).Item(11).ToString
                                    latestYear = dt.Rows(0).Item(12)
                                Else
                                    initialMonth = dt.Rows(0).Item(11).ToString
                                    initialYear = dt.Rows(0).Item(12)
                                End If
                            Else
                                latestBillDate = tempDate
                                latestMonth = dt.Rows(0).Item(11).ToString
                                latestYear = dt.Rows(0).Item(12)
                                initialMonth = dt.Rows(0).Item(11).ToString
                                initialYear = dt.Rows(0).Item(12)
                            End If

                            Dim xDate As Date = dt.Rows(0).Item(8)
                            'Dim nowDate As Date = Now.Date
                            Dim xnowDate As Date = dtp.Value.Date
                            Dim xComputeDays As TimeSpan = xDate - xnowDate
                            Dim xintDays As Integer = xComputeDays.Days

                            'Dim amountRequired As Double

                            If xintDays < 0 Then
                                arrPDPen(x) = Val(dt.Rows(0).Item(18).ToString)
                            Else
                                arrPDPen(x) = 0
                                'arrPaymentReqAmt(x) = arrPaymentBillAmt(x) + arrPaymentBillApp(x)
                            End If
                            paymentBillID(x) = dt.Rows(0).Item(0)
                            'paymentbillNo(x) = dt.Rows(0).Item(0).ToString
                            arrPDbillPeriod(x) = dt.Rows(0).Item(22).ToString
                            arrPDDueDate(x) = dt.Rows(0).Item(8)
                            arrPDReadDate(x) = dt.Rows(0).Item(24)
                            arrPDBillDate(x) = dt.Rows(0).Item(23)
                            arrPDPrevRead(x) = dt.Rows(0).Item(13)
                            arrPDPresRead(x) = dt.Rows(0).Item(14)
                            arrPDConsump(x) = dt.Rows(0).Item(15)
                            arrPDAmount(x) = Val(dt.Rows(0).Item(37).ToString) '16
                            'arrPDBRate(x) = Val(dt.Rows(0).Item(41).ToString)
                            arrPDEnFee(x) = Val(dt.Rows(0).Item(17).ToString)
                            arrPDWSF(x) = arrPDAmount(x) - arrPDEnFee(x)
                            'arrPDInstallment(x) = Val(dt.Rows(0).Item(21).ToString)
                            'arrPDAdj(x) = Val(dt.Rows(0).Item(22).ToString)
                            'arrPDAdjRate(x) = Val(dt.Rows(0).Item(23).ToString)

                            'arrPDPen(x) = Val(dt.Rows(0).Item(18).ToString)
                            arrPDSCDis(x) = Val(dt.Rows(0).Item(20).ToString)
                            arrPDTotAmt(x) = arrPDAmount(x) + arrPDPen(x) - arrPDSCDis(x)
                            arrPRDMetID(x) = Val(dt.Rows(0).Item(25).ToString)
                            arrPDMetName(x) = dt.Rows(0).Item(26).ToString
                            arrPrevBal(x) = Val(dt.Rows(0).Item(27).ToString)
                            'arrInstallmentAmount(x) = Val(dt.Rows(0).Item(35).ToString)
                            'arrInstallmentCount(x) = Val(dt.Rows(0).Item(36).ToString)
                            '================================================================================================
                            '================================================================================================
                            '================================================================================================
                            '================================================================================================
                            arrPDReq(x) = arrPDTotAmt(x) + arrPrevBal(x) + arrPDInstallment(x)
                            arrAcctPaymentID(x) = Val(dt.Rows(0).Item(28).ToString)

                            'totalPenalty = totalPenalty + arrPDPen(x)

                            totPrevPen = 0
                            totPrevEF = 0
                            totPrevDis = 0
                            prevOutstandStat = dt.Rows(0).Item(34).ToString
                            If prevOutstandStat = "UNPAID" Then
                                totPrevPen = Val(dt.Rows(0).Item(29).ToString)
                                totPrevEF = Val(dt.Rows(0).Item(30).ToString)
                                totPrevDis = Val(dt.Rows(0).Item(33).ToString)
                                startMonth = dt.Rows(0).Item(31).ToString
                                startYear = Val(dt.Rows(0).Item(32).ToString)
                                totalPrevBal = totalPrevBal + arrPrevBal(x)
                                totalEnvi = totalEnvi + totPrevEF + arrPDEnFee(x)
                                'totalPenalty = totalPenalty + totPrevPen + arrPDPen(x)
                                totalDiscount = totalDiscount + totPrevDis + arrPDSCDis(x)
                            Else
                                totPrevPen = 0
                                totPrevEF = 0
                                totPrevDis = 0
                                totalEnvi = totalEnvi + arrPDEnFee(x)
                                totalDiscount = totalDiscount + arrPDSCDis(x)
                                'totalPenalty = totalPenalty + arrPDPen(x)
                            End If
                            Dim gDate As Date = lvwAccounts.CheckedItems(x).SubItems(6).Text
                            'Dim nowDate As Date = Now.Date
                            Dim nowDate As Date = dtp.Value.Date
                            Dim ComputeDays As TimeSpan = gDate - nowDate
                            Dim intDays As Integer = ComputeDays.Days

                            If intDays < 0 Then
                                totalPenalty = totalPenalty + totPrevPen + arrPDPen(x)
                            End If

                            totalWSF = totalWSF + arrPDWSF(x) + (totalPrevBal + totPrevDis - totPrevPen)
                            totalWaterBill = totalWaterBill + arrPDAmount(x) + (totalPrevBal + totPrevDis - totPrevPen)
                            If totalPrevBal > 0 Then
                                prevBalExisting = 1
                            Else
                                prevBalExisting = 0
                            End If
                            payAddress = dt.Rows(0).Item(5).ToString & ", " & dt.Rows(0).Item(5).ToString & ", Narra, Palawan"
                            paymentDate = dtp.Value
                            If lvwAccounts.CheckedItems.Count > 1 Then

                                If countBillOnlyMonths = 1 Then
                                    monthCount = 1
                                    FirstMonth = Mid(dt.Rows(0).Item(11).ToString(), 1, 3)
                                    payYearF = Mid(dt.Rows(0).Item(12).ToString(), 3, 4)
                                    payyearFinal1 = payYearF
                                ElseIf countBillOnlyMonths > 1 Then
                                    monthCount = 2
                                    If x = 0 Then FirstMonth = Mid(dt.Rows(x).Item(11).ToString(), 1, 3)
                                    If x = 0 Then payYearF = Mid(dt.Rows(x).Item(12).ToString(), 3, 4)
                                    If x = lvwAccounts.CheckedItems.Count - 1 Then LastMonth = Mid(dt.Rows(0).Item(11).ToString(), 1, 3)
                                    If x = lvwAccounts.CheckedItems.Count - 1 Then payYearT = Mid(dt.Rows(0).Item(12).ToString(), 3, 4)
                                    If payYearF = payYearT Then
                                        payyearFinal1 = payYearF
                                    Else
                                        payyearFinal1 = payYearF
                                        payyearFinal2 = payYearT
                                    End If
                                ElseIf countBillOnlyMonths = 0 Then
                                    FirstMonth = ""
                                    payYearF = Nothing
                                    payyearFinal1 = Nothing
                                    LastMonth = ""
                                    payYearT = Nothing
                                    payyearFinal2 = Nothing
                                End If

                            ElseIf lvwAccounts.CheckedItems.Count = 1 Then
                                If countBillOnlyMonths = 1 Then
                                    monthCount = 1
                                    FirstMonth = Mid(dt.Rows(0).Item(11).ToString(), 1, 3)
                                    payYearF = Mid(dt.Rows(0).Item(12).ToString(), 3, 4)
                                    payyearFinal1 = payYearF
                                ElseIf countBillOnlyMonths = 0 Then
                                    FirstMonth = ""
                                    payYearF = ""
                                    payyearFinal1 = ""
                                    LastMonth = ""
                                    payYearT = ""
                                    payyearFinal2 = ""
                                End If

                            End If
                        ElseIf lvwAccounts.CheckedItems(x).SubItems(1).Text = "Installment Fee" Then
                            arrPDDueDate(x) = Nothing
                            arrPDReadDate(x) = Nothing
                            arrPDBillDate(x) = Nothing
                            Dim dt As New DataTable
                            Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE AccountNo='" & lvwAccounts.CheckedItems(x).SubItems(3).Text & "'", con)
                            da.Fill(dt)

                            paymentAccountNo(x) = dt.Rows(0).Item(6).ToString
                            arrAcctPaymentID(x) = Val(dt.Rows(0).Item(0).ToString)
                            waterbillpaymentaccountIDSelected = arrAcctPaymentID(x)
                            arrPDReq(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            'arrOtherFees(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            arrPDInstallment(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            totalInstallment = totalInstallment + arrPDInstallment(x)
                        ElseIf lvwAccounts.CheckedItems(x).SubItems(1).Text = "Overpayment" Then
                            Dim dt As New DataTable
                            Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE accountno='" & lvwAccounts.CheckedItems(x).SubItems(3).Text & "'", con)
                            da.Fill(dt)
                            paymentAccountNo(x) = dt.Rows(0).Item(6).ToString
                            arrAcctPaymentID(x) = Val(dt.Rows(0).Item(0).ToString)
                            arrPDDueDate(x) = Nothing
                            arrPDReadDate(x) = Nothing
                            arrPDBillDate(x) = Nothing
                            arrPDReq(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            arrOverpay(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                        ElseIf lvwAccounts.CheckedItems(x).SubItems(1).Text = "Installation" Then
                            paymentAccountNo(x) = Nothing
                            arrPDDueDate(x) = Nothing
                            arrPDReadDate(x) = Nothing
                            arrPDBillDate(x) = Nothing
                            waterbillpaymentaccountIDSelected = 0
                            arrPDReq(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            'arrPDInstallment(x) = arrPDReq(x)
                            totalApplication = totalApplication + arrPDReq(x)
                            'arrInstallmentAmount(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                        ElseIf lvwAccounts.CheckedItems(x).SubItems(1).Text = "Bulk Order" Then
                            paymentAccountNo(x) = Nothing
                            arrPDDueDate(x) = Nothing
                            arrPDReadDate(x) = Nothing
                            arrPDBillDate(x) = Nothing
                            waterbillpaymentaccountIDSelected = 0
                            arrPDReq(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            arrPDConsump(x) = arrPDReq(x) / 250
                            totalBulk = totalBulk + arrPDReq(x)
                            'arrPDInstallment(x) = arrPDReq(x)
                            'totalApplication = totalApplication + arrPDReq(x)
                        Else
                            arrPDDueDate(x) = Nothing
                            arrPDReadDate(x) = Nothing
                            arrPDBillDate(x) = Nothing
                            Dim dt As New DataTable
                            Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE AccountNo='" & lvwAccounts.CheckedItems(x).SubItems(3).Text & "'", con)
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                paymentAccountNo(x) = dt.Rows(0).Item(6).ToString
                                arrAcctPaymentID(x) = Val(dt.Rows(0).Item(0).ToString)
                            End If

                            waterbillpaymentaccountIDSelected = arrAcctPaymentID(x)
                            arrPDReq(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                            arrOtherFees(x) = Val(lvwAccounts.CheckedItems(x).SubItems(13).Text.Replace(",", ""))
                        End If
                        totalOtherFees = totalOtherFees + arrOtherFees(x)
                        totalOverpayment = totalOverpayment + arrOverpay(x)
                    Next
                    'MessageBox.Show(countBillOnlyMonths)
                    If countBillOnlyMonths = 1 Then
                        paymentPeriod = FirstMonth & " " & Mid(initialYear, 3, 4)
                    ElseIf countBillOnlyMonths > 1 Then
                        paymentPeriod = FirstMonth & " " & Mid(initialYear, 3, 4) & " to " & LastMonth & " " & Mid(latestYear, 3, 4)
                    ElseIf countBillOnlyMonths = 0 Then
                        paymentPeriod = ""
                    End If
                    paymentORNum = txtORNum.Text
                    paymentConName = cboConsumerName.Text
                    paymentConID = arrConsWaterID(cboConsumerName.SelectedIndex)
                    'MessageBox.Show(totalWaterBill)
                    With frmPaymentTypeSelection
                        .dtpPaymentDate.Value = dtp.Value
                        .lblPaymentDate.Text = Now.ToString()
                        .lblConsName.Text = paymentConName
                        .lblAddress.Text = payAddress
                        .lblORNum.Text = paymentORNum
                        .lblTotalWSF.Text = Format(totalWSF, "#,##0.#0")
                        .lblTotalEnvi.Text = Format(totalEnvi, "#,##0.#0")
                        .lblTotalDiscount.Text = Format(totalDiscount, "#,##0.#0")
                        .lblTotalPen.Text = Format(totalPenalty, "#,##0.#0")
                        .lblTotalAmount.Text = Format(totalReqPayment, "#,##0.#0")
                        .lblTotalInstallment.Text = Format(totalInstallment + totalApplication, "#,##0.#0")
                        .lblBulkAmount.Text = Format(totalBulk, "#,##0.#0")
                        .lblPaymentPeriod.Text = UCase(paymentPeriod)
                        .cboBillNum.Items.Clear()
                        .txtAmount.Text = ""
                        .txtBank.Text = ""
                        .txtNumber.Text = ""
                        .lblOthers.Text = Format(totalOtherFees, "#,##0.#0")
                        .lblOverpayment.Text = Format(totalOverpayment, "#,##0.#0")
                        For y As Integer = 0 To lvwAccounts.CheckedItems.Count - 1
                            If lvwAccounts.CheckedItems(y).SubItems(1).Text = "Water Bill" Then
                                .cboBillNum.Items.Add("Water Bill#: " & paymentBillID(y))
                            Else
                                .cboBillNum.Items.Add(lvwAccounts.CheckedItems(y).SubItems(1).Text)
                            End If
                        Next
                        .cboBillNum.SelectedIndex = 0
                        If prevBalExisting = 1 Then
                            .cboYear.Items.Add(startYear)
                            .lblPrevBillDetails.Visible = True
                            .lblStartMonth.Visible = True
                            .lblPrevEF.Visible = True
                            .cboMonth.Visible = True
                            .cboYear.Visible = True
                            .lblStartYear.Visible = True
                            .txtEF.Visible = True
                            .lblPrevDiscount.Visible = True
                            .txtDiscount.Visible = True
                            .txtDiscount.Text = ""
                            .txtEF.Text = ""
                            .txtPenalty.Visible = True
                            .txtPenalty.Text = ""
                            .lblPrevPen.Visible = True

                            frmPaymentTypeSelection.txtPenalty.Text = totPrevPen
                            frmPaymentTypeSelection.txtDiscount.Text = totPrevDis
                            frmPaymentTypeSelection.txtEF.Text = totPrevEF
                            frmPaymentTypeSelection.cboMonth.Text = startMonth
                            frmPaymentTypeSelection.cboYear.Text = startYear

                        Else
                            .lblPrevBillDetails.Visible = False
                            .lblStartMonth.Visible = False
                            .lblPrevEF.Visible = False
                            .cboMonth.Visible = False
                            .cboYear.Visible = False
                            .lblStartYear.Visible = False
                            .txtEF.Visible = False
                            .lblPrevDiscount.Visible = False
                            .txtDiscount.Visible = False
                            .txtDiscount.Text = ""
                            .txtEF.Text = ""
                            .txtPenalty.Visible = False
                            .txtPenalty.Text = ""
                            .lblPrevPen.Visible = False
                            '.lblTotalInstallment.Text = ""
                            .txtPenalty.Text = ""
                            .txtDiscount.Text = ""
                            .txtEF.Text = ""
                            .cboMonth.Text = ""
                            .cboYear.Text = ""
                        End If
                    End With
                    'MessageBox.Show(TotalPreviousToPay)
                    frmPaymentSelection.StartPosition = FormStartPosition.CenterScreen
                    frmPaymentTypeSelection.ShowDialog()
                Else
                    MessageBox.Show("Nothing Selected", "Please select a Bill for Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Public Shared Function MonthDifference(ByVal Month1 As Integer, ByVal Year1 As Integer, ByVal Month2 As Integer, ByVal Year2 As Integer) As Integer
        ' Return Math.Abs()

    End Function

    Private Sub chkDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiscount.CheckedChanged
        'ConsumerSelection(cboConsumerName.SelectedIndex)

        'If chkDiscount.CheckState = CheckState.Checked Then
        '    txtSeniorID.Enabled = True
        '    If lvwAccounts.Items.Count > 0 Then
        '        For x As Integer = 0 To countBillsPayment
        '            arrPaymentReqAmt(x) = arrPaymentBillAmt(x) + arrPaymentBillApp(x) + arrPaymentBillPen(x) - arrPaymentBillDis(x)
        '            lvwAccounts.Items(x).SubItems(13).Text = Format(arrPaymentReqAmt(x), "#,##0.#0")
        '        Next
        '    End If
        'Else
        '    If lvwAccounts.Items.Count > 0 Then
        '        For x As Integer = 0 To countBillsPayment
        '            arrPaymentReqAmt(x) = arrPaymentBillAmt(x) + arrPaymentBillApp(x) + arrPaymentBillPen(x)
        '            lvwAccounts.Items(x).SubItems(13).Text = Format(arrPaymentReqAmt(x), "#,##0.#0")
        '        Next
        '    End If
        '    txtSeniorID.Enabled = False
        'End If
        TotalAmountToPay(arrConsWaterID(cboConsumerName.SelectedIndex))
    End Sub
    Private Sub txtORNum_TextChanged(sender As Object, e As EventArgs) Handles txtORNum.TextChanged

    End Sub
    Private Sub btnSearchBill_Click(sender As Object, e As EventArgs) Handles btnSearchBill.Click
        cboConsumerName.Text = ""
        'btnDisregard.Visible = False
        lblConsumerID.Text = ""
        lvwAccounts.Items.Clear()

        WaterBillSpecNum2(Val(txtBill.Text))

        TotalAmountToPay(arrConsWaterID(cboConsumerName.SelectedIndex))
    End Sub

    Private Sub btnDisregard_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to Disregard the Adjustment and roll back to its original price rate?", MsgBoxStyle.YesNo, "Disregard Adjustment") = MsgBoxResult.Yes Then
            Dim cmd As New MySqlCommand("UPDATE tblbills SET origamount=null, adjustedamount=null, adjapprover=null, adjconf=null, adjreason=null, adjdate=null, adjsurcharge=null, adjdueamount=null, adjordisprmk='None' WHERE billID=" & arrWaterBillMetID(lvwAccounts.FocusedItem.Index), con)
            cmd.ExecuteNonQuery()
            WaterBillAccountsList(arrConsWaterID(cboConsumerName.SelectedIndex))
            lblConsumerID.Text = arrConsWaterID(cboConsumerName.SelectedIndex)
            chkDiscount.CheckState = CheckState.Unchecked
            TotalAmountToPay(arrConsWaterID(cboConsumerName.SelectedIndex))
            'btnDisregard.Visible = False
            MsgBox("Adjustment/Dispute has been disregarded", MsgBoxStyle.Information, "Disregard Adjustment")
        End If
    End Sub


    Private Sub btnDispute_Click(sender As Object, e As EventArgs)
        If lvwAccounts.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT AdjOrDispRmk FROM tblBills WHERE billID=" & arrWaterBillMetID(lvwAccounts.FocusedItem.Index), con)
            da.Fill(dt)
            Dim chkAdj As String = dt.Rows(0).Item(0).ToString
            If chkAdj = "None" Then

                billAdjustForm = 1
                BillDisputeLoad(arrWaterBillMetID(lvwAccounts.FocusedItem.Index))
            Else
                MsgBox("Bill Already Adjusted/Disputed", MsgBoxStyle.Exclamation, "Bill Dispute")
                Exit Sub
            End If
        Else
            MsgBox("Please select an Item to Dispute", MsgBoxStyle.Exclamation, "Nothing selected")
            Exit Sub
        End If
    End Sub

    Private Sub chkSameName_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPayPrev_Click(sender As Object, e As EventArgs) Handles btnPayPrev.Click
        If txtORNum.Text = "" Then
            MsgBox("OR Number is Required", MsgBoxStyle.Exclamation, "No OR Number")
        Else
            Dim dtChOR As New DataTable
            Dim daChOR As New MySqlDataAdapter("SELECT * FROM tblor WHERE ORNum='" & txtORNum.Text.Replace("'", "''") & "'", con)
            daChOR.Fill(dtChOR)
            If dtChOR.Rows.Count > 0 Then
                MsgBox("Same OR Number found", MsgBoxStyle.Exclamation, "Same OR Number Found")
                Exit Sub
            Else

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT B.billID, B.billNo, B.prevOutstanding, A.streetAddress, CT.clusterName, BR.AddBrgy, B.isSC, CLI.seniorID, A.acctID, B.PrevOutPenalty, prevOutEF, PrevStartMonth, prevStartYear, prevOutDiscount, outstandingInstallmentFee, outstandingInstallmentCount FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN clusterlist AS CT ON A.clusterID=CT.clusterID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID LEFT JOIN consumerlist AS CLI ON B.consID=CLI.consID WHERE billID=" & arrPaymentBillID(lvwAccounts.FocusedItem.Index), con)
                da.Fill(dt)
                With WaterBillOutstandingPayment
                    prevBalBillID = Val(dt.Rows(0).Item(0))
                    selectedConsIDPayment = Val(lblConsumerID.Text)
                    senRmk = dt.Rows(0).Item(6).ToString
                    senIDPayment = dt.Rows(0).Item(7).ToString
                    selPayAcctID = dt.Rows(0).Item(8)
                    Dim scType As String = dt.Rows(0).Item(6).ToString
                    If scType = "YES" Then
                        .lblConsType.Text = "SC/PWD"
                        .txtDiscount.Enabled = True
                    Else
                        .lblConsType.Text = "Regular"
                        .txtDiscount.Enabled = False
                    End If
                    .cboYearFrom.Items.Clear()

                    .lblRemEnvi.Text = Format(Val(dt.Rows(0).Item(10).ToString), "#,##0.#0")
                    .lblRemPenalty.Text = Format(Val(dt.Rows(0).Item(9).ToString), "#,##0.#0")
                    .lblRemDisc.Text = Format(Val(dt.Rows(0).Item(13).ToString), "#,##0.#0")
                    .lblRemInstall.Text = Format(Val(dt.Rows(0).Item(14).ToString), "#,##0.#0")

                    .lblRemainingAmount.Text = Format(Val(dt.Rows(0).Item(2).ToString), "#,##0.#0")
                    .lblRemainingEnvi.Text = Format(Val(dt.Rows(0).Item(10).ToString), "#,##0.#0")
                    .lblRemainingPenalty.Text = Format(Val(dt.Rows(0).Item(9).ToString), "#,##0.#0")
                    .lblRemainingDiscount.Text = Format(Val(dt.Rows(0).Item(13).ToString), "#,##0.#0")
                    .lblRemainingInstall.Text = Format(Val(dt.Rows(0).Item(14).ToString), "#,##0.#0")

                    .EFBal = Val(dt.Rows(0).Item(10).ToString)
                    .PENBal = Val(dt.Rows(0).Item(9).ToString)
                    .DiscBal = Val(dt.Rows(0).Item(13).ToString)
                    .InstallBal = Val(dt.Rows(0).Item(14).ToString)
                    .InstallCount = Val(dt.Rows(0).Item(15).ToString)

                    Dim yYear As Integer = Val(dt.Rows(0).Item(12).ToString)
                    If yYear > 0 Then
                        For xYear As Integer = yYear To 2022
                            .cboYearFrom.Items.Add(xYear)
                        Next
                    Else
                        For xYear As Integer = 2018 To 2022
                            .cboYearFrom.Items.Add(xYear)
                        Next
                    End If


                    .cboMonthFrom.Enabled = True
                    .cboYearFrom.Text = dt.Rows(0).Item(12).ToString
                    .cboYearFrom.Enabled = True
                    strRemMon = dt.Rows(0).Item(11).ToString
                    .lblName.Text = cboConsumerName.Text
                    .lblAddress.Text = dt.Rows(0).Item(3).ToString() & ", " & dt.Rows(0).Item(4).ToString() & ", " & dt.Rows(0).Item(5).ToString() & ", Sofronio Española, Palawan"
                    .lblOR.Text = txtORNum.Text
                    .lblBillNo.Text = dt.Rows(0).Item(1).ToString()
                    .lblTotalPrevious.Text = Format(Val(dt.Rows(0).Item(2).ToString) + Val(dt.Rows(0).Item(14).ToString), "#,##0.#0")
                    totalPrevToPay = Val(dt.Rows(0).Item(2)) + Val(dt.Rows(0).Item(14).ToString)
                    .txtAmtPayment.Text = ""
                    .txtDiscount.Text = ""
                    .txtEnvi.Text = ""
                    .txtMoney.Text = ""
                    .txtInstallment.Text = ""
                    .lblCollector.Text = lblCollectionOfficer.Text
                End With
                WaterBillOutstandingPayment.ShowDialog()

            End If


        End If

    End Sub

    Private Sub btnAddTransferMeter_Click(sender As Object, e As EventArgs) Handles btnAddTransferMeter.Click
        Dim acct As String = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT accountNo FROM consumeraccounts WHERE consID=" & arrConsWaterID(cboConsumerName.SelectedIndex), con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            acct = dt.Rows(0).Item(0).ToString
        Else
            acct = ""
        End If
        Dim lstTransMeter As New ListViewItem
        lstTransMeter.Text = ""
        lstTransMeter.SubItems.Add("Transfer Meter")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add(acct)
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("250.00")
        lstTransMeter.SubItems.Add("")
        lstTransMeter.SubItems.Add("")
        lvwAccounts.Items.Add(lstTransMeter)
    End Sub

    Private Sub btnAddTransferOwner_Click(sender As Object, e As EventArgs) Handles btnAddTransferOwner.Click
        Dim acct As String = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT accountNo FROM consumeraccounts WHERE consID=" & arrConsWaterID(cboConsumerName.SelectedIndex), con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            acct = dt.Rows(0).Item(0).ToString
        Else
            acct = ""
        End If
        Dim lstTransferOwner As New ListViewItem
        lstTransferOwner.Text = ""
        lstTransferOwner.SubItems.Add("Transfer Owner")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add(acct)
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("500.00")
        lstTransferOwner.SubItems.Add("")
        lstTransferOwner.SubItems.Add("")
        lvwAccounts.Items.Add(lstTransferOwner)
    End Sub

    Private Sub btnAddReconnection_Click(sender As Object, e As EventArgs) Handles btnAddReconnection.Click
        Dim acct As String = ""
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT accountNo FROM consumeraccounts WHERE consID=" & arrConsWaterID(cboConsumerName.SelectedIndex), con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            acct = dt.Rows(0).Item(0).ToString
        Else
            acct = ""
        End If
        Dim lstReconnect As New ListViewItem
        lstReconnect.Text = ""
        lstReconnect.SubItems.Add("Reconnection")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add(acct)
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("250.00")
        lstReconnect.SubItems.Add("")
        lstReconnect.SubItems.Add("")
        lvwAccounts.Items.Add(lstReconnect)

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        ConsumerSelection(cboConsumerName.SelectedIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNewInstallationPayment.StartPosition = FormStartPosition.CenterScreen
        frmNewInstallationPayment.txtAmount.Text = ""
        frmNewInstallationPayment.Focus()
        frmNewInstallationPayment.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnInstallmentFeeEdit.Click


        If lvwAccounts.SelectedItems.Count > 0 Then
            frmEditApplicationFeePaymentAmount.index = lvwAccounts.FocusedItem.Index
            frmEditApplicationFeePaymentAmount.StartPosition = FormStartPosition.CenterScreen
            frmEditApplicationFeePaymentAmount.txtNewAmount.Focus()
            frmEditApplicationFeePaymentAmount.ShowDialog()
        End If
        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT acctID, AccountNo, AccountName FROM consumeraccounts WHERE consID=" & arrConsWaterID(cboConsumerName.SelectedIndex), con)
        'da.Fill(dt)
        ''MessageBox.s
        'If dt.Rows.Count > 0 Then
        '    paymentAccountSelection.lvw.Items.Clear()
        '    ReDim arrApplicationAccountID(dt.Rows.Count - 1)
        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        arrApplicationAccountID(x) = Val(dt.Rows(x).Item(0).ToString)
        '        Dim lst As New ListViewItem
        '        lst.Text = dt.Rows(x).Item(1).ToString
        '        lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
        '        paymentAccountSelection.lvw.Items.Add(lst)
        '    Next
        '    paymentAccountSelection.StartPosition = FormStartPosition.CenterScreen
        '    paymentAccountSelection.ShowDialog()
        'Else
        '    MessageBox.Show("No Accounts Available", "Accounts Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If

    End Sub

    Private Sub btnPartial_Click(sender As Object, e As EventArgs)
        If lvwAccounts.SelectedItems.Count > 0 Then
            MessageBox.Show("Feature Soon")
        End If
    End Sub

    Private Sub btnOverpayment_Click(sender As Object, e As EventArgs) Handles btnOverpayment.Click
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT acctID, accountno FROM consumeraccounts WHERE consID=" & arrConsWaterID(cboConsumerName.SelectedIndex), con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim frmAddOverpayment.AcctID(dt.Rows.Count - 1)
            ReDim frmAddOverpayment.acctNo(dt.Rows.Count - 1)

            frmAddOverpayment.cboAccount.Items.Clear()
            For x As Integer = 0 To dt.Rows.Count - 1
                frmAddOverpayment.AcctID(x) = Val(dt.Rows(0).Item(0).ToString)
                frmAddOverpayment.acctNo(x) = dt.Rows(0).Item(1).ToString
                frmAddOverpayment.cboAccount.Items.Add(frmAddOverpayment.acctNo(x))
            Next
            frmAddOverpayment.StartPosition = FormStartPosition.CenterScreen
            frmAddOverpayment.ShowDialog()
        End If

    End Sub

    Private Sub btnBulkOrder_Click(sender As Object, e As EventArgs)
        frmBulkOrder.StartPosition = FormStartPosition.CenterScreen
        frmBulkOrder.ShowDialog()
    End Sub
End Class