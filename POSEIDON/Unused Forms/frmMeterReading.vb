Imports MySql.Data.MySqlClient
Public Class frmMeterReading
    Dim gotFoc(19) As Boolean
    Dim disNote As String
    Dim xCount As Integer
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        txtRead1.Focus()
        curPage = curPage + 1
        MeterPage(curPage)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtRead1.Focus()
        curPage = curPage - 1
        MeterPage(curPage)
    End Sub

    Private Sub btnNewRead_Click(sender As Object, e As EventArgs) Handles btnNewRead.Click
        NewReadingSelection.ShowDialog()
    End Sub

    Private Sub txtRead1_GotFocus(sender As Object, e As EventArgs) Handles txtRead1.GotFocus
        gotFoc(0) = True
    End Sub

    Private Sub txtRead1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead1.KeyDown
        focusTxt(0, e)
    End Sub

    Private Sub txtRead1_LostFocus(sender As Object, e As EventArgs) Handles txtRead1.LostFocus
        txtReadValues(0)
    End Sub

    Private Sub txtRead1_TextChanged(sender As Object, e As EventArgs) Handles txtRead1.TextChanged
        Reading(0)
        'lblMet1.Text = Val(txtRead1.Text) - Val(lblPrevRead1.Text)
        'arrTextRead(0) = Val(txtRead1.Text)
    End Sub

    Private Sub txtRead2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead2.KeyDown
        focusTxt(1, e)
    End Sub

    Private Sub txtRead2_LostFocus(sender As Object, e As EventArgs) Handles txtRead2.LostFocus
        txtReadValues(1)
    End Sub

    Private Sub txtRead2_TextChanged(sender As Object, e As EventArgs) Handles txtRead2.TextChanged
        Reading(1)
        'lblMet2.Text = Val(txtRead2.Text) - Val(lblPrevRead2.Text)
        'arrTextRead(1) = Val(txtRead2.Text)
    End Sub

    Private Sub txtRead3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead3.KeyDown
        focusTxt(2, e)
    End Sub

    Private Sub txtRead3_LostFocus(sender As Object, e As EventArgs) Handles txtRead3.LostFocus
        txtReadValues(2)
    End Sub

    Private Sub txtRead3_TextChanged(sender As Object, e As EventArgs) Handles txtRead3.TextChanged
        Reading(2)
        'lblMet3.Text = Val(txtRead3.Text) - Val(lblPrevRead3.Text)
        'arrTextRead(2) = Val(txtRead3.Text)
    End Sub

    Private Sub txtRead4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead4.KeyDown
        focusTxt(3, e)
    End Sub

    Private Sub txtRead4_LostFocus(sender As Object, e As EventArgs) Handles txtRead4.LostFocus
        txtReadValues(3)
    End Sub

    Private Sub txtRead4_TextChanged(sender As Object, e As EventArgs) Handles txtRead4.TextChanged
        Reading(3)
        'lblMet4.Text = Val(txtRead4.Text) - Val(lblPrevRead4.Text)
        'arrTextRead(3) = Val(txtRead4.Text)
    End Sub

    Private Sub txtRead5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead5.KeyDown
        focusTxt(4, e)
    End Sub

    Private Sub txtRead5_LostFocus(sender As Object, e As EventArgs) Handles txtRead5.LostFocus
        txtReadValues(4)
    End Sub

    Private Sub txtRead5_TextChanged(sender As Object, e As EventArgs) Handles txtRead5.TextChanged
        Reading(4)
        'lblMet5.Text = Val(txtRead5.Text) - Val(lblPrevRead5.Text)
        'arrTextRead(4) = Val(txtRead5.Text)
    End Sub

    Private Sub txtRead6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead6.KeyDown
        focusTxt(5, e)
    End Sub

    Private Sub txtRead6_LostFocus(sender As Object, e As EventArgs) Handles txtRead6.LostFocus
        txtReadValues(5)
    End Sub

    Private Sub txtRead6_TextChanged(sender As Object, e As EventArgs) Handles txtRead6.TextChanged
        Reading(5)
        'lblMet6.Text = Val(txtRead6.Text) - Val(lblPrevRead6.Text)
        'arrTextRead(5) = Val(txtRead6.Text)
    End Sub

    Private Sub txtRead7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead7.KeyDown
        focusTxt(6, e)
    End Sub

    Private Sub txtRead7_LostFocus(sender As Object, e As EventArgs) Handles txtRead7.LostFocus
        txtReadValues(6)
    End Sub

    Private Sub txtRead7_TextChanged(sender As Object, e As EventArgs) Handles txtRead7.TextChanged
        Reading(6)
        'lblMet7.Text = Val(txtRead7.Text) - Val(lblPrevRead7.Text)
        'arrTextRead(6) = Val(txtRead7.Text)
    End Sub

    Private Sub txtRead8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead8.KeyDown
        focusTxt(7, e)
    End Sub

    Private Sub txtRead8_LostFocus(sender As Object, e As EventArgs) Handles txtRead8.LostFocus
        txtReadValues(7)
    End Sub

    Private Sub txtRead8_TextChanged(sender As Object, e As EventArgs) Handles txtRead8.TextChanged
        Reading(7)
        'lblMet8.Text = Val(txtRead8.Text) - Val(lblPrevRead8.Text)
        'arrTextRead(7) = Val(txtRead8.Text)
    End Sub

    Private Sub txtRead9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead9.KeyDown
        focusTxt(8, e)
    End Sub

    Private Sub txtRead9_LostFocus(sender As Object, e As EventArgs) Handles txtRead9.LostFocus
        txtReadValues(8)
    End Sub

    Private Sub txtRead9_TextChanged(sender As Object, e As EventArgs) Handles txtRead9.TextChanged
        Reading(8)
        'lblMet9.Text = Val(txtRead9.Text) - Val(lblPrevRead9.Text)
        'arrTextRead(8) = Val(txtRead9.Text)
    End Sub

    Private Sub txtRead10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead10.KeyDown
        focusTxt(9, e)
    End Sub

    Private Sub txtRead10_LostFocus(sender As Object, e As EventArgs) Handles txtRead10.LostFocus
        txtReadValues(9)
    End Sub

    Private Sub txtRead10_TextChanged(sender As Object, e As EventArgs) Handles txtRead10.TextChanged
        Reading(9)
        'lblMet10.Text = Val(txtRead10.Text) - Val(lblPrevRead10.Text)
        'arrTextRead(9) = Val(txtRead10.Text)
    End Sub

    Private Sub txtRead11_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead11.KeyDown
        focusTxt(10, e)
    End Sub

    Private Sub txtRead11_LostFocus(sender As Object, e As EventArgs) Handles txtRead11.LostFocus
        txtReadValues(10)
    End Sub

    Private Sub txtRead11_TextChanged(sender As Object, e As EventArgs) Handles txtRead11.TextChanged
        Reading(10)
        'lblMet11.Text = Val(txtRead11.Text) - Val(lblPrevRead11.Text)
        'arrTextRead(10) = Val(txtRead11.Text)
    End Sub

    Private Sub txtRead12_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead12.KeyDown
        focusTxt(11, e)
    End Sub

    Private Sub txtRead12_LostFocus(sender As Object, e As EventArgs) Handles txtRead12.LostFocus
        txtReadValues(11)
    End Sub

    Private Sub txtRead12_TextChanged(sender As Object, e As EventArgs) Handles txtRead12.TextChanged
        Reading(11)
        'lblMet12.Text = Val(txtRead12.Text) - Val(lblPrevRead12.Text)
        'arrTextRead(11) = Val(txtRead12.Text)
    End Sub

    Private Sub txtRead13_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead13.KeyDown
        focusTxt(12, e)
    End Sub

    Private Sub txtRead13_LostFocus(sender As Object, e As EventArgs) Handles txtRead13.LostFocus
        txtReadValues(12)
    End Sub

    Private Sub txtRead13_TextChanged(sender As Object, e As EventArgs) Handles txtRead13.TextChanged
        Reading(12)
        'lblMet13.Text = Val(txtRead13.Text) - Val(lblPrevRead13.Text)
        'arrTextRead(12) = Val(txtRead13.Text)
    End Sub

    Private Sub txtRead14_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead14.KeyDown
        focusTxt(13, e)
    End Sub

    Private Sub txtRead14_LostFocus(sender As Object, e As EventArgs) Handles txtRead14.LostFocus
        txtReadValues(13)
    End Sub

    Private Sub txtRead14_TextChanged(sender As Object, e As EventArgs) Handles txtRead14.TextChanged
        Reading(13)
        'lblMet14.Text = Val(txtRead14.Text) - Val(lblPrevRead14.Text)
        'arrTextRead(13) = Val(txtRead14.Text)
    End Sub

    Private Sub txtRead15_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead15.KeyDown
        focusTxt(14, e)
    End Sub

    Private Sub txtRead15_LostFocus(sender As Object, e As EventArgs) Handles txtRead15.LostFocus
        txtReadValues(14)
    End Sub

    Private Sub txtRead15_TextChanged(sender As Object, e As EventArgs) Handles txtRead15.TextChanged
        Reading(14)
        'lblMet15.Text = Val(txtRead15.Text) - Val(lblPrevRead15.Text)
        'arrTextRead(14) = Val(txtRead15.Text)
    End Sub

    Private Sub txtRead16_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead16.KeyDown
        focusTxt(15, e)
    End Sub

    Private Sub txtRead16_LostFocus(sender As Object, e As EventArgs) Handles txtRead16.LostFocus
        txtReadValues(15)
    End Sub

    Private Sub txtRead16_TextChanged(sender As Object, e As EventArgs) Handles txtRead16.TextChanged
        Reading(15)
        'lblMet16.Text = Val(txtRead16.Text) - Val(lblPrevRead16.Text)
        'arrTextRead(15) = Val(txtRead16.Text)
    End Sub

    Private Sub txtRead17_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead17.KeyDown
        focusTxt(16, e)
    End Sub

    Private Sub txtRead17_LostFocus(sender As Object, e As EventArgs) Handles txtRead17.LostFocus
        txtReadValues(16)
    End Sub

    Private Sub txtRead17_TextChanged(sender As Object, e As EventArgs) Handles txtRead17.TextChanged
        Reading(16)
        'lblMet17.Text = Val(txtRead17.Text) - Val(lblPrevRead17.Text)
        'arrTextRead(16) = Val(txtRead17.Text)
    End Sub

    Private Sub txtRead18_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead18.KeyDown
        focusTxt(17, e)
    End Sub

    Private Sub txtRead18_LostFocus(sender As Object, e As EventArgs) Handles txtRead18.LostFocus
        txtReadValues(17)
    End Sub

    Private Sub txtRead18_TextChanged(sender As Object, e As EventArgs) Handles txtRead18.TextChanged
        Reading(17)
        'lblMet18.Text = Val(txtRead18.Text) - Val(lblPrevRead18.Text)
        'arrTextRead(17) = Val(txtRead18.Text)
    End Sub

    Private Sub txtRead19_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead19.KeyDown
        focusTxt(18, e)
    End Sub

    Private Sub txtRead19_LostFocus(sender As Object, e As EventArgs) Handles txtRead19.LostFocus
        txtReadValues(18)
    End Sub

    Private Sub txtRead19_TextChanged(sender As Object, e As EventArgs) Handles txtRead19.TextChanged
        Reading(18)
        'lblMet19.Text = Val(txtRead19.Text) - Val(lblPrevRead19.Text)
        'arrTextRead(18) = Val(txtRead19.Text)
    End Sub

    Private Sub txtRead20_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRead20.KeyDown
        focusTxt(19, e)
    End Sub

    Private Sub txtRead20_LostFocus(sender As Object, e As EventArgs) Handles txtRead20.LostFocus
        txtReadValues(19)
    End Sub

    Private Sub focusText(index As Integer)
        textRead(index).Focus()
        textRead(index).Select(0, textRead(index).TextLength)
    End Sub

    Private Sub Reading(index As Integer)
        'Dim pRead As Integer = Val(textRead(index).Text)
        lblMet(index).Text = Val(textRead(index).Text) - Val(lblPrevRead(index).Text)
        arrTextRead(index) = Val(textRead(index).Text)
    End Sub

    Private Sub focusTxt(index As Integer, e As KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            If index = 19 Then
                textRead(0).Focus()
                textRead(0).Select(0, textRead(0).TextLength)
            Else
                textRead(index + 1).Focus()
                textRead(index + 1).Select(0, textRead(index + 1).TextLength)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If index = 0 Then
                textRead(19).Focus()
                textRead(19).Select(0, textRead(19).TextLength)
            Else
                textRead(index - 1).Focus()
                textRead(index - 1).Select(0, textRead(index - 1).TextLength)
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If index = 19 Then
                textRead(0).Focus()
                textRead(0).Select(0, textRead(0).TextLength)
            Else
                textRead(index + 1).Focus()
                textRead(index + 1).Select(0, textRead(index + 1).TextLength)
            End If
        End If
    End Sub

    Private Sub txtRead20_TextChanged(sender As Object, e As EventArgs) Handles txtRead20.TextChanged
        Reading(19)
        'lblMet20.Text = Val(txtRead20.Text) - Val(lblPrevRead20.Text)
        'arrTextRead(19) = Val(txtRead20.Text)
    End Sub

    Public Function getLatestBillNo() As Integer
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT max(billNo) FROM billing", con)
        da.Fill(dt)
        Dim curNo As Integer = Val(dt.Rows(0).Item(0).ToString)
        Dim newNum As Integer = curNo + 1
        Return newNum
    End Function

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("Press Yes to Finish Meter Reading", MsgBoxStyle.YesNo, "Meter Reading Confirmation") = MsgBoxResult.Yes Then
            lblSaving.Visible = True
            Cons()
            prb.Value = 0
            prb.Visible = True
            Dim dtDisc As New DataTable
            Dim daDisc As New MySqlDataAdapter("SELECT discNote FROM disconnectionnote WHERE discID=1", con)
            daDisc.Fill(dtDisc)
            disNote = dtDisc.Rows(0).Item(0).ToString
            For x As Integer = 0 To accountCount - 1
                lblSaving.Visible = True
                If chkBoolExemp(x) = False Then

                    Dim cmdB As New MySqlCommand("INSERT INTO billing(acctID, consID, classID, dueDate, fromDate, toDate, billMonth, billYear, prevRead, presRead, prevBal, prevPenalty, prevAmountDue, prevTotal, Consump, Amount, EnviFee, totalAmountDue, useAmount, useADue,Penalty, isSC, SCdiscount, SCPenalty, seqNum, isAdjusted, billStat, metReadID, billNote, UID, billPeriod, billDate, readDate, brgyID, applicationfee, adjRemark) VALUES(@aID, @cID, @clID, @dDate, @fDate, @tDate, @bMonth, @bYear, @pvRead, @psRead, @prBal, @prPenalty, @prADue, @prTotal, @Cons, @Amt, @EFee, @totAmountDue, @useA, @useAD, @Pen, @iSC, @SCdis, @SCPen, @sNum, @isAd, @bStat, @metID, @bNote, @UserID, @bPer, current_date(), @rDate, @bgID, @appfee, 'None')", con)
                    cmdB.Parameters.AddWithValue("@aID", arrTempAcctID(x))
                    cmdB.Parameters.AddWithValue("@cID", arrTempConsumerID(x))
                    cmdB.Parameters.AddWithValue("@clID", arrTempClassID(x))
                    cmdB.Parameters.AddWithValue("@dDate", readingDue)
                    cmdB.Parameters.AddWithValue("@fDate", Format(perFromDate, "yyyy-MM-dd"))
                    cmdB.Parameters.AddWithValue("@tDate", Format(perToDate, "yyyy-MM-dd"))
                    cmdB.Parameters.AddWithValue("@bMonth", MonthReadFrom)
                    cmdB.Parameters.AddWithValue("@bYear", MonthReadYear)
                    cmdB.Parameters.AddWithValue("@pvRead", arrTempRef(x))
                    cmdB.Parameters.AddWithValue("@psRead", arrTempCurReading(x))
                    cmdB.Parameters.AddWithValue("@prBal", arrTempPrevBalance(x))
                    'cmdB.Parameters.AddWithValue("@prConsump", arrPrevConsump(x))
                    'cmdB.Parameters.AddWithValue("@prEnv", arrPrevEnv(x) + billOutstandEF(x))
                    'cmdB.Parameters.AddWithValue("@prAdj", arrPrevAdj(x))
                    'cmdB.Parameters.AddWithValue("@prAdjRate", arrPrevAdjRate(x) + billOutstandAdjustedRate(x))
                    cmdB.Parameters.AddWithValue("@prPenalty", arrPrevPenalty(x) + billOutstandPenalty(x))
                    cmdB.Parameters.AddWithValue("@prADue", arrPrevAmountDue(x) + billOutstandBal(x))
                    cmdB.Parameters.AddWithValue("@prTotal", arrPrevTotal(x) + billOutstandTotal(x))
                    cmdB.Parameters.AddWithValue("@Cons", arrTempConsumed(x))
                    cmdB.Parameters.AddWithValue("@Amt", metAmt(x))
                    'cmdB.Parameters.AddWithValue("@FRate", metMaxA(x))
                    'cmdB.Parameters.AddWithValue("@Exc", metAmt(x) - metMaxA(x))
                    'cmdB.Parameters.AddWithValue("@Adjust", metAdj(x))
                    'cmdB.Parameters.AddWithValue("@AdjRate", metAR(x))
                    cmdB.Parameters.AddWithValue("@EFee", metEF(x))
                    cmdB.Parameters.AddWithValue("@totAmountDue", metAmt(x))
                    'If strSenior(x) = "NO" Then
                    cmdB.Parameters.AddWithValue("@useA", metAmt(x) - metSC(x))
                    cmdB.Parameters.AddWithValue("@useAD", metTP(x) - metSC(x))
                    cmdB.Parameters.AddWithValue("@Pen", metP(x))
                    'cmdB.Parameters.AddWithValue("@AmtDue", metTP(x))
                    cmdB.Parameters.AddWithValue("@iSC", strSenior(x))
                    cmdB.Parameters.AddWithValue("@SCdis", metSC(x))
                    cmdB.Parameters.AddWithValue("@SCPen", metTPSC(x))
                    cmdB.Parameters.AddWithValue("@sNum", arrTempSeqNum(x))
                    cmdB.Parameters.AddWithValue("@isAd", "None")
                    cmdB.Parameters.AddWithValue("@bStat", "UNPAID")
                    cmdB.Parameters.AddWithValue("@metID", selectedMetReadID)
                    Dim getPrevAmtTotal As Double = arrPrevTotal(x) + billOutstandTotal(x)
                    If getPrevAmtTotal > 0 Then
                        cmdB.Parameters.AddWithValue("@bNote", disNote.Replace("$amt", getPrevAmtTotal).Replace("$dat", Format(disconDate, "MMMM dd, yyyy")))
                    Else
                        cmdB.Parameters.AddWithValue("@bNote", "")
                    End If
                    cmdB.Parameters.AddWithValue("@UserID", loggedUserID)
                    'cmdB.Parameters.AddWithValue("@zon", mZone)
                    'cmdB.Parameters.AddWithValue("@clus", mCluster)
                    cmdB.Parameters.AddWithValue("@bPer", billperiod)
                    'cmdB.Parameters.AddWithValue("@FCons", arrFConsump(x))
                    'cmdB.Parameters.AddWithValue("@SCons", arrSConsump(x))
                    'cmdB.Parameters.AddWithValue("@FExc", arrFExcess(x))
                    'cmdB.Parameters.AddWithValue("@SExc", arrSExcess(x))
                    'cmdB.Parameters.AddWithValue("@FLbl", arrFLabel(x))
                    'cmdB.Parameters.AddWithValue("@SLbl", arrSLabel(x))
                    cmdB.Parameters.AddWithValue("@rDate", readingDate)
                    'cmdB.Parameters.AddWithValue("@minCons", arrMinCons(x))
                    'cmdB.Parameters.AddWithValue("@fpcub", arrFAmtPerCub(x))
                    'cmdB.Parameters.AddWithValue("@spcub", arrSAmtPerCub(x))
                    'cmdB.Parameters.AddWithValue("@bNo", getLatestBillNo())
                    cmdB.Parameters.AddWithValue("@srate", metSCTot(x))
                    'cmdB.Parameters.AddWithValue("@brate", metNR(x))

                    'cmdB.Parameters.AddWithValue("@pSCDis", arrPrevSCDis(x) + billOutstandDiscount(x))
                    cmdB.Parameters.AddWithValue("@bgID", MetReadSelectedBrgyID)
                    cmdB.Parameters.AddWithValue("@appfee", arrTempAppFee(x))
                    cmdB.ExecuteNonQuery()
                End If
                lblSaving.Visible = True
                xCount = x
                updateprogress(x, accountCount)
            Next
            'update reference
            For y As Integer = 0 To accountCount - 1
                If chkBoolExemp(y) = False Then
                    updateprogress(y + xCount, accountCount)
                    Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET MeterReference = '" & arrTempCurReading(y) & "' WHERE acctID=" & arrTempAcctID(y), con)
                    cmd.ExecuteNonQuery()
                    'Dim cmdMetUpdate As New MySqlCommand("UPDATE meterreading SET metstatus='LAPSE' WHERE metID=" & arrTempPrevMetID(y), con)
                    'cmdMetUpdate.ExecuteNonQuery()
                    'Dim cmdBillUpdate As New MySqlCommand("UPDATE billing SET billstat='LAPSE' WHERE billID=" & arrTempPrevMetID(y), con)
                    'cmdBillUpdate.ExecuteNonQuery()
                End If
            Next
            MetReadForValsClear()
            MetReadEnabler()
            clearLabels()
            MsgBox("Saved!", MsgBoxStyle.Information, "POSEIDON DATABASE SYSTEM")
            lblSaving.Visible = False
            prb.Visible = False
            MeterReadingBool = False
        End If
    End Sub

    Private Sub updateprogress(pValue As Integer, total As Integer)
        If Not lblSaving.Visible = True Then
            lblSaving.Visible = True
        End If
        prb.Value = (pValue / (total * 2)) * 100
    End Sub


    Private Sub frmMeterReading_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MeterReadingBool = False Then

        ElseIf MeterReadingBool = True Then

        End If
    End Sub

    Private Sub frmMeterReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetReadForValsClear()
        clearLabels()
        MetReadEnabler()
        lblSaving.Visible = False
        prb.Visible = False
        MeterReadingBool = False
        LoadMeterReaders()
        cboMeterReader.SelectedIndex = 0
    End Sub

    Private Sub clearLabels()
        lblProv.Text = ""
        lblMunicipality.Text = ""
        lblZone.Text = ""
        lblBrgy.Text = ""
        lblCluster.Text = ""
        lblReadDate.Text = ""
        lblDueDate.Text = ""
        lblPerCovered.Text = ""
    End Sub

    Private Sub LoadMeterReaders()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM meterreader WHERE metStat='Active'", con)
        da.Fill(dt)
        cboMeterReader.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim meterReaderID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                meterReaderID(x) = dt.Rows(x).Item(0)
                cboMeterReader.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Private Sub cboMeterReader_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMeterReader.SelectedIndexChanged
        selectedMetReadID = meterReaderID(cboMeterReader.SelectedIndex)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Cancel Reading?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub chkEx1_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx1.CheckedChanged
        txtReadValues(0)
    End Sub

    Private Sub chkEx2_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx2.CheckedChanged
        txtReadValues(1)
    End Sub

    Private Sub chkEx3_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx3.CheckedChanged
        txtReadValues(2)
    End Sub

    Private Sub chkEx4_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx4.CheckedChanged
        txtReadValues(3)
    End Sub

    Private Sub chkEx5_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx5.CheckedChanged
        txtReadValues(4)
    End Sub

    Private Sub chkEx6_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx6.CheckedChanged
        txtReadValues(5)
    End Sub

    Private Sub chkEx7_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx7.CheckedChanged
        txtReadValues(6)
    End Sub

    Private Sub chkEx8_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx8.CheckedChanged
        txtReadValues(7)
    End Sub

    Private Sub chkEx9_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx9.CheckedChanged
        txtReadValues(8)
    End Sub

    Private Sub chkEx10_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx10.CheckedChanged
        txtReadValues(9)
    End Sub

    Private Sub chkEx11_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx11.CheckedChanged
        txtReadValues(10)
    End Sub

    Private Sub chkEx12_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx12.CheckedChanged
        txtReadValues(11)
    End Sub

    Private Sub chkEx13_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx13.CheckedChanged
        txtReadValues(12)
    End Sub

    Private Sub chkEx14_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx14.CheckedChanged
        txtReadValues(13)
    End Sub

    Private Sub chkEx15_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx15.CheckedChanged
        txtReadValues(14)
    End Sub

    Private Sub chkEx16_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx16.CheckedChanged
        txtReadValues(15)
    End Sub

    Private Sub chkEx17_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx17.CheckedChanged
        txtReadValues(16)
    End Sub

    Private Sub chkEx18_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx18.CheckedChanged
        txtReadValues(17)
    End Sub

    Private Sub chkEx19_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx19.CheckedChanged
        txtReadValues(18)
    End Sub

    Private Sub chkEx20_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx20.CheckedChanged
        txtReadValues(19)
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub
End Class