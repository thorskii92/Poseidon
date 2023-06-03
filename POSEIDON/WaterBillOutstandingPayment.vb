Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Math
Imports System.Globalization
Imports System.ComponentModel

Public Class WaterBillOutstandingPayment
    Dim balAmount As Decimal
    Public EFBal As Decimal
    Public DiscBal As Decimal
    Public PENBal As Decimal
    Public InstallBal As Decimal
    Public InstallCount As Integer

    Public strRemYear As Integer
    Public newEFBal As Decimal
    Public newDiscBal As Decimal
    Public newPenBal As Decimal
    Public newMonthRem As String
    Public newYearRem As Integer
    Public newInstallBal As Decimal
    Public newInstallCount As Integer

    Private Sub WaterBillOutstandingPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setYearFrom()
        tmr.Enabled = True
        cboPType.SelectedIndex = 0
        cboMonthFrom.Text = strRemMon
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboYearFrom.Text = "" Or cboMonthFrom.Text = "" Or cboYearTo.Text = "" Then
            MessageBox.Show("Please Enter Missing months", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If MessageBox.Show("Confirm Payment?", "Water Bill Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                SaveValues()
                WaterBillPayment.ConsumerSelection(WaterBillPayment.cboConsumerName.SelectedIndex)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub SaveValues()

        Dim strMonthTo As String = ""
        Dim strYearTo As String = ""
        Dim strSenDis As String
        Dim strSendDisAmt As String
        Dim strInstall As String
        Dim strInstallAmt As String
        'MessageBox.Show(cboYearFrom.SelectedIndex)

        If cboYearTo.Text = "(None)" Then
            strMonthTo = ""
            strYearTo = ""
        Else
            strMonthTo = " to " & Mid(cboMonthTo.Text, 1, 3)
            strYearTo = " " & Mid(cboYearTo.Text, 3, 4)
        End If
        If senRmk = "YES" Then
            strSenDis = "DISCOUNT"
            strSendDisAmt = "(" & Format(Val(txtDiscount.Text), "#,##0.#0") & ")"
        Else
            strSenDis = ""
            strSendDisAmt = ""
        End If

        If Val(txtInstallment.Text) > 0 Then
            strInstall = "Installment Fee"
            strInstallAmt = Format(Val(txtInstallment.Text), "#,##0.#0")
        Else
            strInstall = ""
            strInstallAmt = ""
        End If
        Dim pTypeCash As String = ""
        Dim pTypeCheck As String = ""
        Dim pTypeMO As String = ""
        If cboPType.Text = "Cash" Then
            pTypeCash = "✓"
            pTypeCheck = ""
            pTypeMO = ""
        ElseIf cboPType.Text = "Check" Then
            pTypeCash = ""
            pTypeCheck = "✓"
            pTypeMO = ""
        ElseIf cboPType.Text = "Money Order" Then
            pTypeCash = ""
            pTypeCheck = ""
            pTypeMO = "✓"
        End If
        Dim strUpdateBalance As String
        If balAmount <= 0 Then
            strUpdateBalance = "PAID"
            balAmount = 0
        Else
            strUpdateBalance = "UNPAID"
        End If
        Dim dura As String
        Dim todur As String = ""
        If cboYearTo.SelectedIndex = 0 Then
            todur = " to " & cboMonthTo.Text & " " & cboYearTo.Text
        End If
        dura = cboMonthFrom.Text & " " & cboYearFrom.Text & todur


        'Dim monthNumTo As Integer = DateTime.ParseExact(cboMonthTo.Text, "MMMM", CultureInfo.CurrentCulture).Month

        Dim cmd As New MySqlCommand("UPDATE billing SET prevOutstanding=@pBal, prevOutstandingStat=@pStat, prevOutstandingOR=@pOR, prevOutstandingDuration=@pDur, prevOutPenalty=@nPen, prevOutEF=@nEF, prevStartMonth=@nSMonth, prevStartYear=@nYear, prevOutDiscount=@nDisc, outstandingInstallmentFee=@outInsfee, outstandingInstallmentCount=@outInsCount, prevbal=@pbalance WHERE billID=" & prevBalBillID, con)
        cmd.Parameters.AddWithValue("@pBal", balAmount)
        cmd.Parameters.AddWithValue("@pStat", strUpdateBalance)
        cmd.Parameters.AddWithValue("@pOR", lblOR.Text)
        cmd.Parameters.AddWithValue("@pDur", dura)
        cmd.Parameters.AddWithValue("@nPen", newPenBal)
        cmd.Parameters.AddWithValue("@nEF", newEFBal)
        cmd.Parameters.AddWithValue("@outInsFee", newInstallBal)
        cmd.Parameters.AddWithValue("@outInsCount", newInstallCount)
        cmd.Parameters.AddWithValue("@pbalance", balAmount - newPenBal)
        Dim monthNumFrom As Integer = DateTime.ParseExact(cboMonthFrom.Text, "MMMM", CultureInfo.CurrentCulture).Month
        'MessageBox.Show(cboYearTo.SelectedIndex)
        If balAmount > 0 Then
            If (cboYearFrom.Text = "2022" And cboMonthFrom.Text = "August") Or (cboYearTo.Text = "2022" And cboMonthTo.Text = "August") Then
                cmd.Parameters.AddWithValue("@nYear", Nothing)
                cmd.Parameters.AddWithValue("@nSMonth", Nothing)
            Else
                If cboYearTo.Text = "(None)" Then
                    Dim mMonthSel As Integer = DateTime.ParseExact(cboMonthFrom.Text, "MMMM", CultureInfo.CurrentCulture).Month
                    Dim mYearSel As Integer = Val(cboYearFrom.Text)
                    If mMonthSel = 12 Then
                        mMonthSel = 1
                        mYearSel = mYearSel + 1
                    Else
                        mMonthSel = mMonthSel + 1
                    End If
                    cmd.Parameters.AddWithValue("@nYear", mYearSel)
                    cmd.Parameters.AddWithValue("@nSMonth", DateAndTime.MonthName(mMonthSel))
                Else
                    Dim mMonthSel As Integer = DateTime.ParseExact(cboMonthTo.Text, "MMMM", CultureInfo.CurrentCulture).Month
                    Dim mYearSel As Integer = Val(cboYearTo.Text)
                    If mMonthSel = 12 Then
                        mMonthSel = 1
                        mYearSel = mYearSel + 1
                    Else
                        mMonthSel = mMonthSel + 1
                    End If
                    cmd.Parameters.AddWithValue("@nYear", mYearSel)
                    cmd.Parameters.AddWithValue("@nSMonth", DateAndTime.MonthName(mMonthSel))
                End If
            End If
        Else
            cmd.Parameters.AddWithValue("@nYear", Nothing)
            cmd.Parameters.AddWithValue("@nSMonth", Nothing)
        End If
        cmd.Parameters.AddWithValue("@nDisc", newDiscBal)
        cmd.ExecuteNonQuery()
        Dim firstWords As String = ""
        Dim secondWords As String = ""
        Dim strWords() As String = Split(UCase(ConvertNumberToWords(Val(txtAmtPayment.Text) + Val(txtInstallment.Text))), " ")
        If strWords.Count > 5 Then
            For x As Integer = 0 To 3
                firstWords = firstWords & " " & strWords(x)
            Next
            For y As Integer = 4 To strWords.Count - 1
                secondWords = secondWords & " " & strWords(y)
            Next
        Else
            firstWords = UCase(ConvertNumberToWords(Val(txtAmtPayment.Text) + Val(txtInstallment.Text)))
            secondWords = ""
        End If
        'MessageBox.Show(firstWords)
        'MessageBox.Show(secondWords)
        If senRmk = "YES" Then
            InsertToOR(lblOR.Text, Val(txtAmtPayment.Text) + Val(txtInstallment.Text), cboPType.Text, txtBank.Text, txtNum.Text, dtpDate.Value, firstWords, secondWords, loggedUserID, dtpPaymentDate.Value, selectedConsIDPayment, senRmk, senIDPayment, Val(txtDiscount.Text), "WATER BILL FOR", UCase(Mid(cboMonthFrom.Text, 1, 3) & " " & Mid(cboYearFrom.Text, 3, 4) & strMonthTo) & strYearTo, "E.F.", "Penalty", strSenDis, strInstall, "", "", "", "", "", "", "", "", "", "", Format(Val(txtAmtPayment.Text) - Val(txtEnvi.Text) + Val(txtDiscount.Text) - Val(txtPenalty.Text), "#,##0.#0"), "", Format(Val(txtEnvi.Text), "#,##0.#0"), Format(Val(txtPenalty.Text), "#,##0.#0"), strSendDisAmt, strInstallAmt, "", "", "RUFINA B. BUNGALSO", pTypeCash, pTypeCheck, pTypeMO, txtNum.Text, dtpDate.Value, UCase(Mid(cboMonthFrom.Text, 1, 3) & " " & Mid(cboYearFrom.Text, 3, 4) & strMonthTo) & strYearTo, Val(txtAmtPayment.Text) - Val(txtEnvi.Text) + Val(txtDiscount.Text) - Val(txtPenalty.Text), 0, Val(txtPenalty.Text), Val(txtEnvi.Text), Val(txtInstallment.Text), 0, 0, 0, selPayAcctID)
        Else
            InsertToOR(lblOR.Text, Val(txtAmtPayment.Text) + Val(txtInstallment.Text), cboPType.Text, txtBank.Text, txtNum.Text, dtpDate.Value, firstWords, secondWords, loggedUserID, dtpPaymentDate.Value, selectedConsIDPayment, senRmk, senIDPayment, Val(txtDiscount.Text), "WATER BILL FOR", UCase(Mid(cboMonthFrom.Text, 1, 3) & " " & Mid(cboYearFrom.Text, 3, 4) & strMonthTo) & strYearTo, "E.F.", "Penalty", strInstall, "", "", "", "", "", "", "", "", "", "", "", Format(Val(txtAmtPayment.Text) - Val(txtEnvi.Text) + Val(txtDiscount.Text) - Val(txtPenalty.Text), "#,##0.#0"), "", Format(Val(txtEnvi.Text), "#,##0.#0"), Format(Val(txtPenalty.Text), "#,##0.#0"), strInstallAmt, "", "", "", "RUFINA B. BUNGALSO", pTypeCash, pTypeCheck, pTypeMO, txtNum.Text, dtpDate.Value, UCase(Mid(cboMonthFrom.Text, 1, 3) & " " & Mid(cboYearFrom.Text, 3, 4) & strMonthTo) & strYearTo, Val(txtAmtPayment.Text) - Val(txtEnvi.Text) + Val(txtDiscount.Text) - Val(txtPenalty.Text), 0, Val(txtPenalty.Text), Val(txtEnvi.Text), Val(txtInstallment.Text), 0, 0, 0, selPayAcctID)
        End If
        Dim firstNum As Integer = Val(lblOR.Text)
        Dim down As Integer = Math.Floor(firstNum / 50) * 50 + 1
        Dim lastNum As Integer = Val(Val(lblOR.Text))
        Dim upper As Integer = Math.Ceiling(lastNum / 50) * 50
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblORGroup WHERE Initial=" & down & " and Final=" & upper, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            'MessageBox.Show("A group for that receipt has already been created", "Group Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("Confirm creation of new OR Group?", "New Group", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim cmdOR As New MySqlCommand("INSERT INTO tblORGroup(GroupName, Initial, Final) VALUES(@gName, @init, @fina)", con)
                cmdOR.Parameters.AddWithValue("@gName", Format(down, "000000#") & " to " & Format(upper, "000000#"))
                cmdOR.Parameters.AddWithValue("@init", down)
                cmdOR.Parameters.AddWithValue("@fina", upper)
                cmdOR.ExecuteNonQuery()
                'MessageBox.Show("Group has been created", "Group creation successful.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'LoadGroup()
                'LoadORGroup()
                'txtORNumber.Text = ""
            End If
        End If
        insertPaymentLog(selectedConsIDPayment, "Water Bill", Val(txtAmtPayment.Text), DateAndTime.MonthName(dtpPaymentDate.Value.Month), DateAndTime.Year(dtpPaymentDate.Value), dtpPaymentDate.Value, selPayAcctID, Val(txtEnvi.Text), lblOR.Text, Val(txtDiscount.Text), Val(txtPenalty.Text))
        insertPayment(selectedConsIDPayment, lblOR.Text, txtAmtPayment.Text, "", "Water Bill", "Prev Bill", loggedUserID, cboPType.Text, DateAndTime.MonthName(dtpPaymentDate.Value.Month), Now.Year, selPayAcctID, prevBalBillID, Val(txtPenalty.Text), lastPLID, txtEnvi.Text, Val(txtMoney.Text), Val(lblChange.Text), dtpPaymentDate.Value, Val(txtDiscount.Text), Val(Val(txtAmtPayment.Text) - Val(txtPenalty.Text) + Val(txtDiscount.Text)))
        Dim dtPrevID As New DataTable
        Dim daPrevID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
        daPrevID.Fill(dtPrevID)
        Dim cmdDT As New MySqlCommand("INSERT INTO tbldailytransaction(consID,acctID,ORNum,collection,Consumption,Surcharge,drDate,pID,enviFee,discount) VALUES(@cID,@aID,@ORN,@coll,@consump,@surc,@dDate,@payID,@eF,@disc)", con)
        cmdDT.Parameters.AddWithValue("@cID", selectedConsIDPayment)
        cmdDT.Parameters.AddWithValue("@aID", selPayAcctID)
        cmdDT.Parameters.AddWithValue("@ORN", lblOR.Text)
        cmdDT.Parameters.AddWithValue("@coll", Val(txtAmtPayment.Text))
        cmdDT.Parameters.AddWithValue("@consump", Val(txtEnvi.Text))
        cmdDT.Parameters.AddWithValue("@surc", Val(txtPenalty.Text))
        cmdDT.Parameters.AddWithValue("@dDate", dtpDate.Value)
        cmdDT.Parameters.AddWithValue("@payID", dtPrevID.Rows(0).Item(0))
        cmdDT.Parameters.AddWithValue("@eF", Val(txtEnvi.Text))
        cmdDT.Parameters.AddWithValue("@disc", Val(txtDiscount.Text))
        cmdDT.ExecuteNonQuery()

        If Val(txtInstallment.Text) > 0 Then
            insertPaymentLog(selectedConsIDPayment, "Installation", Val(txtInstallment.Text), DateAndTime.MonthName(dtpPaymentDate.Value.Month), DateAndTime.Year(dtpPaymentDate.Value), dtpPaymentDate.Value, selPayAcctID, 0, lblOR.Text, 0, 0)
            insertPayment(selectedConsIDPayment, lblOR.Text, Val(txtInstallment.Text), "", "Installation Fee", "Installation", loggedUserID, cboPType.Text, DateAndTime.MonthName(dtpPaymentDate.Value.Month), Now.Year, selPayAcctID, Nothing, Nothing, lastPLID, Nothing, Val(txtMoney.Text), Val(lblChange.Text), dtpPaymentDate.Value, Nothing, Nothing)
            Dim dtInsID As New DataTable
            Dim daInsID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
            daInsID.Fill(dtInsID)
            Dim cmdIns As New MySqlCommand("INSERT INTO tbldailytransaction(consID,acctID,ORNum,connectionfee,drDate,pID) VALUES(@cID,@aID,@ORN,@confee,@dDate,@payID)", con)
            cmdIns.Parameters.AddWithValue("@cID", selectedConsIDPayment)
            cmdIns.Parameters.AddWithValue("@aID", selPayAcctID)
            cmdIns.Parameters.AddWithValue("@ORN", lblOR.Text)
            'cmdDT.Parameters.AddWithValue("@coll", Val(txtInstallment.Text))
            cmdIns.Parameters.AddWithValue("@confee", Val(txtInstallment.Text))
            'cmdDT.Parameters.AddWithValue("@surc", Val(txtPenalty.Text))
            cmdIns.Parameters.AddWithValue("@dDate", dtpDate.Value)
            cmdIns.Parameters.AddWithValue("@payID", dtInsID.Rows(0).Item(0))
            cmdIns.ExecuteNonQuery()
        End If
        WaterBillAccountsList(arrConsWaterID(WaterBillPayment.cboConsumerName.SelectedIndex))
        WaterBillPayment.optionenablers()
        updateCurOR(Val(lblOR.Text))
        WaterBillPayment.txtORNum.Text = currentOR(loggedUserID)
        MessageBox.Show("Payment Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub setYearTo()
        cboYearTo.Items.Clear()
        cboYearTo.Items.Add("(None)")
        For x As Integer = Val(cboYearFrom.Text) To 2022
            cboYearTo.Items.Add(x)
        Next

    End Sub

    Private Sub setMonthTo()
        cboMonthTo.Items.Clear()
        Try
            Dim date1 As New DateTime(cboYearFrom.Text, cboMonthFrom.SelectedIndex + 1, 1)
            Dim maxNumMonth As Integer
            If cboYearTo.Text = 2022 Then
                maxNumMonth = 8
            Else
                maxNumMonth = 12
            End If

            Dim date2 As New DateTime(cboYearTo.Text, maxNumMonth, 1)
            Dim numOfMonths = MonthDifference(date1, date2)
            If Now.Year = Val(cboYearFrom.Text) Then
                For x As Integer = 1 To maxNumMonth
                    cboMonthTo.Items.Add(DateAndTime.MonthName(x))
                Next
            ElseIf cboYearFrom.Text = cboYearTo.Text Then
                If Val(cboYearTo.Text) = 2021 Then
                    Dim monthNum = DateTime.ParseExact(cboMonthFrom.Text, "MMMM", CultureInfo.CurrentCulture).Month
                    For x As Integer = monthNum + 1 To 12
                        cboMonthTo.Items.Add(DateAndTime.MonthName(x))
                    Next
                Else
                    Dim monthNum = DateTime.ParseExact(cboMonthFrom.Text, "MMMM", CultureInfo.CurrentCulture).Month
                    For x As Integer = monthNum + 1 To 12
                        cboMonthTo.Items.Add(DateAndTime.MonthName(x))
                    Next
                End If
            Else
                If Val(cboYearTo.Text) = 2021 Then
                    Dim monthNum = DateTime.ParseExact(cboMonthFrom.Text, "MMMM", CultureInfo.CurrentCulture).Month
                    For x As Integer = 1 To 10
                        cboMonthTo.Items.Add(DateAndTime.MonthName(x))
                    Next
                Else
                    Dim monthNum = DateTime.ParseExact(cboMonthFrom.Text, "MMMM", CultureInfo.CurrentCulture).Month
                    For x As Integer = 1 To 12
                        cboMonthTo.Items.Add(DateAndTime.MonthName(x))
                    Next
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Shared Function MonthDifference(ByVal first As DateTime, ByVal second As DateTime) As Integer
        Return Math.Abs((first.Month - second.Month) + 12 * (first.Year - second.Year))
    End Function

    Private Sub cboYearFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearFrom.SelectedIndexChanged
        'MessageBox.Show(dtpPaymentDate.Value.Year)
        cboMonthFrom.Items.Clear()

        'MessageBox.Show(strRemMon)
        If dtpPaymentDate.Value.Year = Val(cboYearFrom.Text) Then
            For x As Integer = 1 To Now.Month
                cboMonthFrom.Items.Add(DateAndTime.MonthName(x))
            Next
        ElseIf dtpPaymentDate.Value.Year > Val(cboYearFrom.Text) Then
            For x As Integer = 1 To 12
                cboMonthFrom.Items.Add(DateAndTime.MonthName(x))
            Next
        End If
        cboMonthFrom.Text = strRemMon
        setYearTo()
    End Sub

    Private Sub cboYearTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearTo.SelectedIndexChanged
        If cboYearTo.SelectedIndex = 0 Then
            cboMonthTo.Enabled = False
        Else
            cboMonthTo.Enabled = True
            setMonthTo()
        End If

    End Sub

    Private Sub cboMonthTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonthTo.SelectedIndexChanged

    End Sub

    Private Sub WaterBillOutstandingPayment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        tmr.Enabled = False
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick

    End Sub

    Private Sub cboPType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPType.SelectedIndexChanged
        If cboPType.SelectedIndex = 0 Then
            lblBank.Visible = False
            lblCheckDate.Visible = False
            lblNum.Visible = False
            txtBank.Visible = False
            txtNum.Visible = False
            dtpDate.Visible = False
        ElseIf cboPType.SelectedIndex = 1 Then
            lblBank.Visible = True
            lblCheckDate.Visible = True
            lblNum.Visible = True
            txtBank.Visible = True
            txtNum.Visible = True
            dtpDate.Visible = True
        ElseIf cboPType.SelectedIndex = 2 Then
            lblBank.Visible = False
            lblCheckDate.Visible = True
            lblNum.Visible = True
            txtBank.Visible = False
            txtNum.Visible = True
            dtpDate.Visible = True
        End If
    End Sub

    Private Sub cboMonthFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonthFrom.SelectedIndexChanged

    End Sub

    Private Sub txtMoney_TextChanged(sender As Object, e As EventArgs) Handles txtMoney.TextChanged
        Dim mChange As Double = Val(txtMoney.Text) - Val(txtAmtPayment.Text) - Val(txtInstallment.Text)
        lblChange.Text = Format(mChange, "#,##0.#0")
    End Sub

    Private Sub txtAmtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtAmtPayment.TextChanged

        balAmount = totalPrevToPay - Val(txtAmtPayment.Text)
        lblRemainingAmount.Text = Format(balAmount, "#,##0.#0")
        lblBalance.Text = Format(balAmount - Val(txtInstallment.Text), "#,##0.#0")
        Dim mChange As Double = Val(txtMoney.Text) - Val(txtAmtPayment.Text) - Val(txtInstallment.Text)
        lblChange.Text = Format(mChange, "#,##0.#0")
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If cboYearFrom.Text = "" Or cboMonthFrom.Text = "" Or cboYearTo.Text = "" Then
            MessageBox.Show("Please Enter Missing months", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If MessageBox.Show("Confirm Payment?", "Water Bill Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM tblOR WHERE ORNum='" & lblOR.Text & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("OR has already been used", "Same O.R. Number existing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    SaveValues()
                    WaterBillPayment.ConsumerSelection(WaterBillPayment.cboConsumerName.SelectedIndex)
                    Me.Close()
                    Dim dtR As New DataTable
                    Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lblOR.Text & "'", con)
                    daR.Fill(dtR)
                    'daR.Fill(frmORReport.reportingdataset.ORDataTable)
                    'frmORReport.ORReport.RefreshReport()
                    'frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    'frmORReport.ORReport.ZoomPercent = 100%
                    'frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                    'frmORReport.ORReport.Width = 75
                    'frmORReport.WindowState = FormWindowState.Maximized
                    'frmORReport.ShowDialog()
                    Dim report As New crptOR
                    report.SetDataSource(dtR)
                    frmCrystalOR.CrystalReportViewer1.ReportSource = report
                    frmCrystalOR.CrystalReportViewer1.Zoom(100%)
                    frmCrystalOR.CrystalReportViewer1.Refresh()
                    'frmCrystalOR.CrystalReportViewer1.RefreshReport()
                    frmCrystalOR.WindowState = FormWindowState.Maximized
                    frmCrystalOR.ShowDialog()
                End If
            End If
        End If



    End Sub

    Private Sub txtEnvi_TextChanged(sender As Object, e As EventArgs) Handles txtEnvi.TextChanged
        newEFBal = EFBal - Val(txtEnvi.Text)
        lblRemainingEnvi.Text = Format(newEFBal, "#,##0.#0")
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        newDiscBal = DiscBal - Val(txtDiscount.Text)
        lblRemainingDiscount.Text = Format(newDiscBal, "#,##0.#0")
    End Sub

    Private Sub txtPenalty_TextChanged(sender As Object, e As EventArgs) Handles txtPenalty.TextChanged
        newPenBal = PENBal - Val(txtPenalty.Text)
        lblRemainingPenalty.Text = Format(newPenBal, "#,##0.#0")
    End Sub

    Private Sub txtInstallment_TextChanged(sender As Object, e As EventArgs) Handles txtInstallment.TextChanged
        newInstallBal = InstallBal - Val(txtInstallment.Text)
        lblRemainingInstall.Text = Format(newInstallBal, "#,##0.#0")
        balAmount = totalPrevToPay - Val(txtAmtPayment.Text)
        lblRemainingAmount.Text = Format(balAmount, "#,##0.#0")
        lblBalance.Text = Format(balAmount - Val(txtInstallment.Text), "#,##0.#0")
        Dim mChange As Double = Val(txtMoney.Text) - Val(txtAmtPayment.Text) - Val(txtInstallment.Text)
        lblChange.Text = Format(mChange, "#,##0.#0")
    End Sub

    Private Sub txtInstallment_LostFocus(sender As Object, e As EventArgs) Handles txtInstallment.LostFocus
        Dim check As Integer = Val(txtInstallment.Text) Mod 240
        If check > 0 Then
            MessageBox.Show("Amount should be exactly divided by 240", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtInstallment.Focus()
        Else
            newInstallCount = InstallCount - (Val(txtInstallment.Text) \ 240)
        End If
    End Sub
End Class