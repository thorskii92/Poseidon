Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmBillEditorvb
    Dim cConsump As Double
    Dim cAMT As Double
    Dim cFRate As Double
    Dim cBRate As Double
    Dim cExcess As Double
    Dim cAdjusted As Double
    Dim cAdjRate As Double
    Dim cEFee As Double
    Dim cTotAmtDue As Double
    Dim cPen As Double
    Dim cAmtADue As Double
    Dim cSCDis As Double
    Dim cSCRate As Double
    Dim cSCPen As Double
    Public conDate As Date

    Private Sub frmBillEditorvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadClassifications()
    End Sub

    Public Sub LoadClassifications()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM classifications", con)
        da.Fill(dt)
        cboClassification.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBillEditorClassID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillEditorClassID(x) = Val(dt.Rows(x).Item(0))
                cboClassification.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Public Sub LoadYear()
        cboBillYear.Items.Clear()
        For x As Integer = 2010 To Now.Year
            cboBillYear.Items.Add(x)
        Next
    End Sub

    Private Sub cboBillMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBillMonth.SelectedIndexChanged
        'dtpFromDate.Value = 
        Try
            'SelectedMonth(cboPeriodMonth.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboBillYear.Text, cboBillMonth.SelectedIndex + 1)
            Dim d As DateTime
            d = New DateTime(cboBillYear.Text, cboBillMonth.SelectedIndex + 1, 1)
            Dim f As DateTime
            f = New DateTime(cboBillYear.Text, cboBillMonth.SelectedIndex + 1, finalday)
            dtpFromDate.Value = d
            dtpToDate.Value = f
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrevRead_TextChanged(sender As Object, e As EventArgs) Handles txtPrevRead.TextChanged

    End Sub

    Private Sub txtPresRead_TextChanged(sender As Object, e As EventArgs) Handles txtPresRead.TextChanged


    End Sub

    Private Sub compute(consump As Double, scType As Integer, classType As Integer)
        'SingleVarMetCompute(consump, A As Double, mA As Double, mC As Double, isSC As Double)
    End Sub

    Private Sub txtPresRead_LostFocus(sender As Object, e As EventArgs) Handles txtPresRead.LostFocus
        ComputeAll()
    End Sub

    Private Sub txtPrevRead_LostFocus(sender As Object, e As EventArgs) Handles txtPrevRead.LostFocus
        ComputeAll()
    End Sub

    Public Sub ComputeAll()
        Dim getSC As String
        If cboAccountType.Text = "Regular" Then
            getSC = "NO"
        Else
            getSC = "YES"
        End If
        'Dim compT As Integer
        'If rdbOld.Checked = True Then
        '    compT = 1
        'Else
        '    compT = 2
        'End If

        'Dim sql As String = "("
        'Dim dtMinRate As New DataTable
        'Dim daMinRate As New MySqlDataAdapter("SELECT Rate FROM tblclassrates WHERE classID=" & arrBillEditorClassID(cboClassification.SelectedIndex) & " AND IsMin=1", con)
        'daMinRate.Fill(dtMinRate)
        'Dim dtMinCub As New DataTable
        'Dim daMinCub As New MySqlDataAdapter("SELECT Cubits FROM tblclassrates WHERE classID=" & arrBillEditorClassID(cboClassification.SelectedIndex) & " AND IsMin=1", con)
        'daMinCub.Fill(dtMinCub)
        'Dim MinCub As Integer = dtMinCub.Rows(0).Item(0)
        'Dim MinRate As Double = dtMinRate.Rows(0).Item(0)
        cConsump = Val(txtPresRead.Text) - Val(txtPrevRead.Text)
        lblConsump.Text = cConsump
        'RateAmount(cConsump, arrBillEditorClassID(cboClassification.SelectedIndex))
        If rdbManual.Checked = False Then
            cAMT = CalculateRate(arrBillEditorClassID(cboClassification.SelectedIndex), cConsump)
            SingleVarMetCompute(cConsump, cAMT, getSC, Val(txtPrevTotal.Text), conDate, dtpBillDate.Value.Date)
            txtWSF.Text = Format(mAmt - mEF, "#,##0.#0")
            txtEF.Text = Format(mEF, "#,##0.#0")
            txtTotal.Text = Format(mAmt - mSC, "#,##0.#0")
            txtTotalAmt.Text = Format(mAmt - mSC, "#,##0.#0")
            txtPenalty.Text = Format(mP, "#,##0.#0")
            txtAmountAfterDue.Text = Format(mTP, "#,##0.#0")
            txtDiscount.Text = Format(mSC, "#,##0.#0")
        End If


    End Sub

    Private Sub cboClassification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClassification.SelectedIndexChanged
        ComputeAll()
    End Sub

    Private Sub cboAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccountType.SelectedIndexChanged
        ComputeAll()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboBillYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBillYear.SelectedIndexChanged
        Try
            'SelectedMonth(cboPeriodMonth.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboBillYear.Text, cboBillMonth.SelectedIndex + 1)
            Dim d As DateTime
            d = New DateTime(cboBillYear.Text, cboBillMonth.SelectedIndex + 1, 1)
            Dim f As DateTime
            f = New DateTime(cboBillYear.Text, cboBillMonth.SelectedIndex + 1, finalday)
            dtpFromDate.Value = d
            dtpToDate.Value = f
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Save Bill?", "Bill Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            Cons()
                Dim cmd As New MySqlCommand("UPDATE billing SET classID=@cID,isSC=@isSen,prevRead=@pvRead,presRead=@psRead,consump=@consp,amount=@amt,envifee=@efee,totalamountdue=@totamtdue,penalty=@pen,amountADue=@amtADue,useAmount=@useAmt,useADue=@uAdue,SCDIscount=@SCDis,SCRate=@scR,SCPenalty=@SCPen,dueDate=@dDate,billMonth=@bMonth,billYear=@bYear,prevTotal=@pvTot,prevBal=@pvBal, prevPenalty=@pvPen, prevAmountDue=@pvAmtDue, billDate=@bDate, readDate=@rDate, billPeriod=@bPeriod, prevOutstanding=@prevOut, prevOutstandingStat=@prevOutStat, prevOutPenalty=@pOutPen, prevOutEF=@pOutEF, prevStartMonth=@pStartM, prevStartYear=@pStartY, prevOutDiscount=@pOutDisc, applicationfee=@appFee, fromDate=@frDate, toDate=@trDate, prevInstallmentFee=@pvInstallFee, outstandingInstallmentFee=@outInstallFee, outstandingInstallmentCount=@outInstallCount, billNote=@bNote  WHERE billID=" & selectedBillLedgerID, con)
                cmd.Parameters.AddWithValue("@cID", arrBillEditorClassID(cboClassification.SelectedIndex))
                Dim strSen As String
            Dim usedAmount As Double = mAmt - mSC
            Dim usedAmountADue As Double = mAmt - mSC + mP
            If cboAccountType.Text = "Regular" Then
                strSen = "NO"
                usedAmount = mTot
                usedAmountADue = mTP
            Else
                strSen = "YES"
                usedAmount = mSCTot
                usedAmountADue = mTPSC
            End If
            cmd.Parameters.AddWithValue("@isSen", strSen)
                cmd.Parameters.AddWithValue("@pvRead", txtPrevRead.Text)
                cmd.Parameters.AddWithValue("@psRead", txtPresRead.Text)
                cmd.Parameters.AddWithValue("@consp", lblConsump.Text)
                cmd.Parameters.AddWithValue("@amt", mAmt)
                ''cmd.Parameters.AddWithValue("@frate", mMaxA)
                ''cmd.Parameters.AddWithValue("@brate", mNR)
                ''cmd.Parameters.AddWithValue("@exc", mExcess)
                ''cmd.Parameters.AddWithValue("@adj", mAdj)
                ''cmd.Parameters.AddWithValue("@adjR", mAR)
                cmd.Parameters.AddWithValue("@efee", mEF)
                cmd.Parameters.AddWithValue("@totamtdue", usedAmount)
                cmd.Parameters.AddWithValue("@pen", mP)
                cmd.Parameters.AddWithValue("@amtADue", usedAmountADue)
                cmd.Parameters.AddWithValue("@useAmt", usedAmount)
                cmd.Parameters.AddWithValue("@uAdue", usedAmountADue)
                cmd.Parameters.AddWithValue("@SCDis", mSC)
            cmd.Parameters.AddWithValue("@scR", mAmt - mSC)
            cmd.Parameters.AddWithValue("@SCPen", mTPSC + Val(txtAppFee.Text))
                cmd.Parameters.AddWithValue("@dDate", dtpDueDate.Value.Date)
                cmd.Parameters.AddWithValue("@bMonth", cboBillMonth.Text)
                cmd.Parameters.AddWithValue("@bYear", cboBillYear.Text)
                cmd.Parameters.AddWithValue("@pvTot", Val(txtPrevTotal.Text))
                cmd.Parameters.AddWithValue("@pvAmtDue", Val(txtPrevAmount.Text))
                cmd.Parameters.AddWithValue("@pvPen", Val(txtPrevPenalty.Text))

                cmd.Parameters.AddWithValue("@bDate", dtpBillDate.Value.Date)
                cmd.Parameters.AddWithValue("@rDate", dtpReadDate.Value.Date)
                cmd.Parameters.AddWithValue("@appFee", Val(txtAppFee.Text))
                cmd.Parameters.AddWithValue("@pvInstallFee", Val(txtPrevInstallment.Text))
                cmd.Parameters.AddWithValue("@frDate", dtpFromDate.Value)
                cmd.Parameters.AddWithValue("@trDate", dtpToDate.Value)
                cmd.Parameters.AddWithValue("@bNote", txtBillNote.Text)
                cmd.Parameters.AddWithValue("@bPeriod", dtpFromDate.Value.Month.ToString() & "/" & dtpFromDate.Value.Day.ToString() & "-" & dtpToDate.Value.Day.ToString() & "/" & dtpFromDate.Value.Year.ToString)
                Dim monthNum As Integer = DateTime.ParseExact(cboBillMonth.Text, "MMMM", CultureInfo.CurrentCulture).Month
                Dim yearNum As Integer = Val(cboBillYear.Text)


                'If (cboBillMonth.Text = "November" And cboBillYear.Text = "2021") Or (yearNum <= 2021 And Not (monthNum = 12 And yearNum = 2021)) Then
                If txtTotalAmount.Text > 0 Then
                    cmd.Parameters.AddWithValue("@prevOut", Val(txtTotalAmount.Text))
                    cmd.Parameters.AddWithValue("@prevOutStat", "UNPAID")
                    cmd.Parameters.AddWithValue("@pOutPen", Val(outTotPen.Text))
                    cmd.Parameters.AddWithValue("@pOutEF", Val(outTotEF.Text))
                    cmd.Parameters.AddWithValue("@pStartM", cboStartingMonth.Text)
                    cmd.Parameters.AddWithValue("@pStartY", cboStartingYear.Text)
                    cmd.Parameters.AddWithValue("@pOutDisc", Val(outTotDisc.Text))
                    cmd.Parameters.AddWithValue("@pvBal", Val(txtOutstandingAmount.Text))
                    cmd.Parameters.AddWithValue("@outInstallFee", Val(txtOutInstallmentFee.Text))
                    cmd.Parameters.AddWithValue("@outInstallCount", Val(cboInstallmentCount.Text))
                Else
                    cmd.Parameters.AddWithValue("@prevOut", 0)
                    cmd.Parameters.AddWithValue("@prevOutStat", "PAID")
                    cmd.Parameters.AddWithValue("@pOutPen", 0)
                    cmd.Parameters.AddWithValue("@pOutEF", 0)
                    cmd.Parameters.AddWithValue("@pStartM", Nothing)
                    cmd.Parameters.AddWithValue("@pStartY", Nothing)
                    cmd.Parameters.AddWithValue("@pOutDisc", 0)
                    cmd.Parameters.AddWithValue("@pvBal", 0)
                    cmd.Parameters.AddWithValue("@outInstallFee", 0)
                    cmd.Parameters.AddWithValue("@outInstallCount", 0)
                End If
                'Else
                '    cmd.Parameters.AddWithValue("@prevOut", Nothing)
                '    cmd.Parameters.AddWithValue("@prevOutStat", Nothing)
                '    cmd.Parameters.AddWithValue("@pOutPen", Nothing)
                '    cmd.Parameters.AddWithValue("@pOutEF", Nothing)
                '    cmd.Parameters.AddWithValue("@pStartM", Nothing)
                '    cmd.Parameters.AddWithValue("@pStartY", Nothing)
                '    cmd.Parameters.AddWithValue("@pOutDisc", Nothing)
                'End If
                cmd.ExecuteNonQuery()
                ViewLedger(selectedAcctIDLedger)
                'ViewLedger(selectedAccountLedgerID)
                MessageBox.Show("Bill Saved", "Bill Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()


        End If
    End Sub

    Private Sub txtAppFee_TextChanged(sender As Object, e As EventArgs) Handles txtAppFee.TextChanged

    End Sub

    Private Sub txtAppFee_LostFocus(sender As Object, e As EventArgs) Handles txtAppFee.LostFocus
        If rdbManual.Checked = True Then
            ManualCompute()
        Else
            ComputeAll()
        End If


    End Sub

    Private Sub rdbNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNew.CheckedChanged
        If rdbNew.Checked = True Then
            txtPenalty.ReadOnly = True
            txtWSF.ReadOnly = True
            txtEF.ReadOnly = True
            txtDiscount.ReadOnly = True

            txtPenalty.Enabled = False
            txtWSF.Enabled = False
            txtEF.Enabled = False
            txtDiscount.Enabled = False
        End If
    End Sub

    Private Sub rdbOld_CheckedChanged(sender As Object, e As EventArgs)
        'If rdbOld.Checked = True Then
        '    txtPenalty.ReadOnly = True
        '    txtWSF.ReadOnly = True
        '    txtEF.ReadOnly = True
        '    txtDiscount.ReadOnly = True

        '    txtPenalty.Enabled = False
        '    txtWSF.Enabled = False
        '    txtEF.Enabled = False
        '    txtDiscount.Enabled = False

        'End If
    End Sub

    Private Sub rdbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rdbManual.CheckedChanged
        If rdbManual.Checked = True Then
            txtPenalty.ReadOnly = False
            txtWSF.ReadOnly = False
            txtEF.ReadOnly = False
            txtDiscount.ReadOnly = False

            txtPenalty.Enabled = True
            txtWSF.Enabled = True
            txtEF.Enabled = True
            txtDiscount.Enabled = True
        End If
    End Sub

    Private Sub txtWSF_TextChanged(sender As Object, e As EventArgs) Handles txtWSF.TextChanged
        If rdbManual.Checked = True Then
            'mAmt = Val(txtWSF.Text) + Val(txtEF.Text)
            ManualCompute()
        End If

    End Sub

    Private Sub txtEF_TextChanged(sender As Object, e As EventArgs) Handles txtEF.TextChanged
        If rdbManual.Checked = True Then
            mEF = Val(txtEF.Text)
            ManualCompute()
        End If

    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        If rdbManual.Checked = True Then
            mSC = Val(txtDiscount.Text)
            ManualCompute()
        End If

    End Sub

    Private Sub txtPenalty_TextChanged(sender As Object, e As EventArgs) Handles txtPenalty.TextChanged
        If rdbManual.Checked = True Then
            mP = Val(txtPenalty.Text)
            ManualCompute()
        End If

    End Sub

    Private Sub ManualCompute()
        ' mSC = Format((mAmt * 0.05), "#.#0")
        mAmt = Val(txtWSF.Text) + mEF

        mSCTot = mAmt - mSC
        mTPSC = mSCTot + mP
        mTot = mAmt
        'mP = (mAmt + mPrev) * 0.1
        mTP = (mAmt + mP)
        txtTotal.Text = Format(mAmt - mSC, "#,##0.#0")
        txtTotalAmt.Text = Format(mAmt - mSC + Val(txtAppFee.Text), "#,##0.#0")
        txtAmountAfterDue.Text = Format(mTP + Val(txtAppFee.Text), "#,##0.#0")
    End Sub
End Class