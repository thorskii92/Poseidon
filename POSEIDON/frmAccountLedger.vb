Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAccountLedger
    Dim curPrevBal As Double
    Dim editPrevOR As String
    Private Sub frmAccountLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disablebuts()
    End Sub

    Private Sub lvwLedger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwLedger.SelectedIndexChanged
        If lvwLedger.SelectedItems.Count > 0 Then
            btnBillStatement.Visible = True
            btnEditBill.Visible = True
            btnDelBill.Visible = True
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT billID, prevOutstanding, billMonth, ORNumPaid, prevOutstandingOR, billStat, billYear FROM billing WHERE billID=" & arrBillIDLedger(lvwLedger.FocusedItem.Index), con)
            da.Fill(dt)
            arrBillChangePrevID = arrBillIDLedger(lvwLedger.FocusedItem.Index)
            Dim pBal As Double = 0
            Dim pMonth As String = ""
            Dim pStat As String = ""
            Dim pYear As Integer = 0
            If dt.Rows.Count > 0 Then
                pBal = Val(dt.Rows(0).Item(1).ToString)
                pMonth = dt.Rows(0).Item(2).ToString
                pStat = dt.Rows(0).Item(5).ToString
                pYear = Val(dt.Rows(0).Item(6).ToString)
                curPrevBal = pBal
                Dim getOR As String = Format(Val(dt.Rows(0).Item(3).ToString), "000000#")
                Dim getPrevOR As String = dt.Rows(0).Item(4).ToString
                If pBal > 0 Then
                    lblLabelPrev.Visible = True
                    lblPrevBal.Visible = True
                    btnPrevChange.Visible = True
                    lblPrevBal.Text = Format(pBal, "#,##0.#0")
                Else
                    lblLabelPrev.Visible = False
                    lblPrevBal.Visible = False
                    btnPrevChange.Visible = False
                    lblPrevBal.Text = Format(pBal, "#,##0.#0")
                End If

                If getOR = "" Or getOR = Nothing Or getOR = "0000000" Then
                    btnEditOR.Visible = False
                Else
                    btnEditOR.Visible = True
                End If

                If getPrevOR = "" Or getPrevOR = Nothing Or getPrevOR = "0000000" Then
                    btnEditOutstanding.Visible = False
                    btnViewOR.Visible = False
                Else
                    btnEditOutstanding.Visible = True
                    btnViewOR.Visible = True
                    editPrevOR = getPrevOR
                End If

                If pStat = "PAID" Then
                    btnUnpaid.Visible = True
                Else
                    btnUnpaid.Visible = False
                End If
            Else
                    lblLabelPrev.Visible = False
                lblPrevBal.Visible = False
                btnPrevChange.Visible = False
                lblPrevBal.Text = Format(pBal, "#,##0.#0")
            End If

        Else
            btnBillStatement.Visible = False
            btnEditBill.Visible = False
            btnDelBill.Visible = False
            btnUnpaid.Visible = False
        End If
    End Sub

    Private Sub disablebuts()
        btnBillStatement.Visible = False
        btnEditBill.Visible = False
        btnDelBill.Visible = False
        btnEditOR.Visible = False
        btnEditOutstanding.Visible = False
        btnUnpaid.Visible = False
    End Sub

    Private Sub btnBillStatement_Click(sender As Object, e As EventArgs) Handles btnBillStatement.Click
        If lvwLedger.SelectedItems.Count > 0 Then
            selBillIDLedger = arrBillIDLedger(lvwLedger.FocusedItem.Index)
            'MsgBox(selBillIDLedger)
            Dim mySelQuery As String
            mySelQuery = "SELECT B.billID, A.acctID, C.consID, CC.classID, Z.zoneID, BR.brgyID, 1, M.addmunid, M.municipality, BR.addbrgy, '', A.StreetAddress, A.AccountName, C.contactNum, A.AccountNo, A.MeterNo, B.billMonth, B.billYear, B.billPeriod, B.dueDate, B.prevread, B.presRead, B.consump, B.amount, B.EnviFee, B.isSC, B.SCDiscount, B.prevAmountDue, B.prevPenalty, B.prevTotal, B.applicationfee, B.penalty, B.billNote, B.readDate, B.fromDate, B.toDate, B.overpayment, B.useAmount, B.useADue, B.billDate, A.standpipe FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN classifications AS CC ON B.classID=CC.classID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID LEFT JOIN zones AS Z ON Z.zoneID=BR.zoneID LEFT JOIN munlist AS M ON M.addmunID=Z.addmunID where B.billID=" & selBillIDLedger

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(mySelQuery, con)
            da.Fill(dt)
            Dim report As New crptBill
            report.SetDataSource(dt)
            frmCrystalBillReport.CrystalReportViewer1.ReportSource = report
            frmCrystalBillReport.CrystalReportViewer1.Zoom(100%)
            frmCrystalBillReport.CrystalReportViewer1.Refresh()
            frmCrystalBillReport.WindowState = FormWindowState.Maximized
            frmCrystalBillReport.ShowDialog()
            'CollectionNoticeReport(mySelQuery)

            'frmBillPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            'frmBillPrint.ReportViewer1.ZoomPercent = 100%
            'frmBillPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            'frmBillPrint.ReportViewer1.Width = 75
            'frmBillPrint.ReportViewer1.RefreshReport()
            'frmBillPrint.WindowState = FormWindowState.Maximized
            'frmBillPrint.Show()
        End If
    End Sub


    Private Sub btnUpdateMeter_Click(sender As Object, e As EventArgs) Handles btnUpdateMeter.Click
        authenticate = False
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT A.acctID, A.accountNo, C.consumername, A.MeterNo, A.MeterBrand, A.MeterSize, A.MeterReference FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.acctID=" & selectedAcctLedgerID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmEditMeterDetails.lblAccountNo.Text = dt.Rows(0).Item(1).ToString
                frmEditMeterDetails.lblConsumer.Text = dt.Rows(0).Item(2).ToString
                frmEditMeterDetails.txtMetNo.Text = dt.Rows(0).Item(3).ToString
                frmEditMeterDetails.txtMetBrand.Text = dt.Rows(0).Item(4).ToString
                frmEditMeterDetails.txtMetSize.Text = dt.Rows(0).Item(5).ToString
                frmEditMeterDetails.txtCurReading.Text = dt.Rows(0).Item(6).ToString
                frmEditMeterDetails.StartPosition = FormStartPosition.CenterScreen
                frmEditMeterDetails.ShowDialog()
            End If
            
        End If
    End Sub

    Private Sub btnPrevChange_Click(sender As Object, e As EventArgs) Handles btnPrevChange.Click
        frmEnterAdminPassword.Text = ""
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            frmChangePreviousBalance.txtAmount.Text = Format(curPrevBal, "0.#0")
            frmChangePreviousBalance.StartPosition = FormStartPosition.CenterScreen
            frmChangePreviousBalance.ShowDialog()
        End If
    End Sub

    Private Sub btnAccountUpdate_Click(sender As Object, e As EventArgs) Handles btnAccountUpdate.Click
        authenticate = False
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT A.acctID, A.AccountName, A.AccountNo, A.classID, C.classification, A.streetAddress, Z.zoneID, Z.Abbrv, B.brgyID, B.addbrgy, CL.clusterID, CL.clusterName FROM consumeraccounts AS A LEFT JOIN classifications AS C ON A.classID=C.classID LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN zones AS Z ON Z.zoneID=B.zoneID LEFT JOIN clusterlist AS CL ON A.clusterID=CL.clusterID WHERE A.acctID=" & selectedAcctLedgerID, con)
            da.Fill(dt)
            frmUpdateAccountDetails.txtAccountName.Text = ""
            frmUpdateAccountDetails.txtAccountNum.Text = ""
            frmUpdateAccountDetails.txtStreetAddress.Text = ""
            frmUpdateAccountDetails.cboClassification.Items.Clear()

            If dt.Rows.Count > 0 Then
                frmUpdateAccountDetails.txtAccountName.Text = dt.Rows(0).Item(1).ToString
                frmUpdateAccountDetails.txtAccountNum.Text = dt.Rows(0).Item(2).ToString
                frmUpdateAccountDetails.txtStreetAddress.Text = dt.Rows(0).Item(5).ToString

                Dim dtClass As New DataTable
                Dim daClass As New MySqlDataAdapter("SELECT * FROM classifications", con)

                daClass.Fill(dtClass)
                ReDim arrAccountUpdateClassID(dtClass.Rows.Count - 1)
                For x As Integer = 0 To dtClass.Rows.Count - 1
                    arrAccountUpdateClassID(x) = Val(dtClass.Rows(x).Item(0).ToString)
                    frmUpdateAccountDetails.cboClassification.Items.Add(dtClass.Rows(x).Item(1).ToString)
                Next
                frmUpdateAccountDetails.cboClassification.Text = dt.Rows(0).Item(4).ToString
                AccountEditorZones()
                frmUpdateAccountDetails.cboZone.Text = dt.Rows(0).Item(7).ToString
                'MessageBox.Show(dt.Rows(0).Item(6).ToString)
                'AccountEditorBrgy(dt.Rows(0).Item(5).ToString)
                frmUpdateAccountDetails.cboBarangay.Text = dt.Rows(0).Item(9).ToString
                'AccountEditorCluster(dt.Rows(0).Item(7).ToString)
                frmUpdateAccountDetails.cboCluster.Text = dt.Rows(0).Item(11).ToString
                frmUpdateAccountDetails.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnEditBill_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        authenticate = False
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT B.billID, A.acctID, L.consID, C.classID, A.AccountNo, L.consumername, A.accountName, C.classification, B.isSC, B.prevRead, B.presRead, B.consump, B.amount, B.enviFee, B.SCDiscount, B.ApplicationFee, B.Penalty, B.dueDate, B.billMonth, B.billYear, B.prevTotal, B.prevBal, B.prevPenalty, B.billDate, B.readDate, B.fromDate, B.toDate, B.prevOutstanding, B.prevOutPenalty, B.prevOutEF, B.prevStartMonth, B.prevStartYear, B.prevOutDiscount, B.billNote, B.prevInstallmentFee, B.outstandingInstallmentFee, B.outstandingInstallmentCount, B.prevAmountDue, A.ConnectionDate FROM billing AS B LEFT JOIN consumerlist AS L ON B.consID=L.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS C ON B.classID=C.classID WHERE B.billID=" & arrBillIDLedger(lvwLedger.FocusedItem.Index), con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmBillEditorvb.LoadClassifications()
                frmBillEditorvb.LoadYear()

                With frmBillEditorvb
                    .rdbNew.Select()
                    selectedBillLedgerID = Val(dt.Rows(0).Item(0))
                    .lblBillNo.Text = dt.Rows(0).Item(0).ToString
                    .lblAccountNo.Text = dt.Rows(0).Item(4).ToString
                    .lblConsumerName.Text = dt.Rows(0).Item(5).ToString
                    .lblAcctName.Text = dt.Rows(0).Item(6).ToString
                    .cboClassification.Text = dt.Rows(0).Item(7).ToString
                    .conDate = dt.Rows(0).Item(38)
                    Dim scType As String = dt.Rows(0).Item(8).ToString
                    If scType = "YES" Then
                        .cboAccountType.Text = "SC/PWD"
                    Else
                        .cboAccountType.Text = "Regular"
                    End If
                    .cboStartingMonth.Items.Clear()
                    .cboStartingYear.Items.Clear()
                    For x As Integer = 1 To 12
                        .cboStartingMonth.Items.Add(DateAndTime.MonthName(x))
                    Next
                    For y As Integer = 2018 To 2022
                        .cboStartingYear.Items.Add(y)
                    Next
                    .cboBillMonth.Text = dt.Rows(0).Item(18).ToString
                    .cboBillYear.Text = dt.Rows(0).Item(19).ToString
                    .txtPrevRead.Text = dt.Rows(0).Item(9).ToString
                    .txtPresRead.Text = dt.Rows(0).Item(10).ToString
                    .dtpBillDate.Value = dt.Rows(0).Item(23)
                    .dtpReadDate.Value = dt.Rows(0).Item(24)
                    .dtpDueDate.Value = dt.Rows(0).Item(17)
                    '.txtPrevAmount.Text = dt.Rows(0).Item(21).ToString
                    .txtPrevPenalty.Text = dt.Rows(0).Item(22).ToString
                    .txtPrevTotal.Text = dt.Rows(0).Item(20).ToString
                    .txtAppFee.Text = dt.Rows(0).Item(15).ToString
                    .dtpFromDate.Value = dt.Rows(0).Item(25)
                    .dtpToDate.Value = dt.Rows(0).Item(26)
                    .txtBillNote.Text = dt.Rows(0).Item(33).ToString
                    '.txtEnviFee.Text = dt.Rows(0).Item(13).ToString
                    '.txtPrevAdjustment.Text = dt.Rows(0).Item(32).ToString
                    '.txtPrevAdjustedRate.Text = dt.Rows(0).Item(33).ToString
                    '.txtPrevPenalty.Text = dt.Rows(0).Item(34).ToString
                    '.txtPrevAmountDue.Text = dt.Rows(0).Item(35).ToString
                    '.txtOutstandingTotalBalance.Text = dt.Rows(0).Item(39).ToString
                    '.outTotPen.Text = dt.Rows(0).Item(40).ToString
                    '.outTotEF.Text = dt.Rows(0).Item(41).ToString
                    '.outTotDisc.Text = dt.Rows(0).Item(44).ToString
                    .cboStartingMonth.Text = dt.Rows(0).Item(30).ToString
                    .cboStartingYear.Text = dt.Rows(0).Item(31).ToString
                    .txtOutstandingAmount.Text = Val(dt.Rows(0).Item(21).ToString)
                    .outTotPen.Text = Val(dt.Rows(0).Item(28).ToString)
                    .outTotEF.Text = Val(dt.Rows(0).Item(29).ToString)
                    .outTotDisc.Text = Val(dt.Rows(0).Item(32).ToString)
                    .txtTotalAmount.Text = Val(dt.Rows(0).Item(27).ToString)
                    .txtPrevInstallment.Text = Val(dt.Rows(0).Item(34).ToString)
                    .txtOutInstallmentFee.Text = Val(dt.Rows(0).Item(35).ToString)
                    .cboInstallmentCount.Text = Val(dt.Rows(0).Item(36).ToString)
                    .txtPrevAmount.Text = Val(dt.Rows(0).Item(37).ToString)
                    ''.txtAppFee.Text = dt.Rows(0).Item(45).ToString
                End With
                frmBillEditorvb.ComputeAll()
                frmBillEditorvb.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnDelBill_Click(sender As Object, e As EventArgs) Handles btnDelBill.Click
        If MessageBox.Show("Delete selected bill?", "Delete Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("DELETE FROM billing WHERE billID=" & arrBillIDLedger(lvwLedger.FocusedItem.Index), con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Bill has been deleted", "Bill Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ViewLedger(selectedAcctIDLedger)
        End If
    End Sub

    Private Sub btnEditOR_Click(sender As Object, e As EventArgs) Handles btnEditOR.Click
        Cons()
        editORFromForm = 2
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblOR AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE ORNum='" & lvwLedger.FocusedItem.SubItems(11).Text & "'", con)
        da.Fill(dt)
        With frmEditOR

            .defOR = dt.Rows(0).Item(1).ToString
            .selORID = Val(dt.Rows(0).Item(0).ToString)
            .txtOR.Text = dt.Rows(0).Item(1).ToString
            .dtpDate.Value = dt.Rows(0).Item(10)
            .lblConsumerName.Text = dt.Rows(0).Item(47).ToString
            .txtN1.Text = dt.Rows(0).Item(15).ToString
            .txtN2.Text = dt.Rows(0).Item(16).ToString
            .txtN3.Text = dt.Rows(0).Item(17).ToString
            .txtN4.Text = dt.Rows(0).Item(18).ToString
            .txtN5.Text = dt.Rows(0).Item(19).ToString
            .txtN6.Text = dt.Rows(0).Item(20).ToString
            .txtN7.Text = dt.Rows(0).Item(21).ToString
            .txtN8.Text = dt.Rows(0).Item(22).ToString
            .txtC1.Text = dt.Rows(0).Item(23).ToString
            .txtC2.Text = dt.Rows(0).Item(24).ToString
            .txtC3.Text = dt.Rows(0).Item(25).ToString
            .txtC4.Text = dt.Rows(0).Item(26).ToString
            .txtC5.Text = dt.Rows(0).Item(27).ToString
            .txtC6.Text = dt.Rows(0).Item(28).ToString
            .txtC7.Text = dt.Rows(0).Item(29).ToString
            .txtC8.Text = dt.Rows(0).Item(30).ToString
            .txtA1.Text = dt.Rows(0).Item(31).ToString
            .txtA2.Text = dt.Rows(0).Item(32).ToString
            .txtA3.Text = dt.Rows(0).Item(33).ToString
            .txtA4.Text = dt.Rows(0).Item(34).ToString
            .txtA5.Text = dt.Rows(0).Item(35).ToString
            .txtA6.Text = dt.Rows(0).Item(36).ToString
            .txtA7.Text = dt.Rows(0).Item(37).ToString
            .txtA8.Text = dt.Rows(0).Item(38).ToString
            .txtCollectionOfficer.Text = dt.Rows(0).Item(39).ToString
            Dim pType As String = dt.Rows(0).Item(3).ToString
            If pType = "Cash" Then
                .rdbCash.Checked = True
                .rdbCheck.Checked = False
                .rdbMO.Checked = False
                .txtBank.Text = ""
                .txtNum.Text = ""
                .txtCheckDate.Text = ""
                .txtBank.Enabled = False
                .txtNum.Enabled = False
                .txtCheckDate.Enabled = False
            ElseIf pType = "Check" Then
                .rdbCash.Checked = False
                .rdbCheck.Checked = True
                .rdbMO.Checked = False
                .txtBank.Text = dt.Rows(0).Item(4).ToString
                .txtNum.Text = dt.Rows(0).Item(5).ToString
                .txtCheckDate.Text = dt.Rows(0).Item(6).ToString
                .txtBank.Enabled = True
                .txtNum.Enabled = True
                .txtCheckDate.Enabled = True
            Else
                .rdbCash.Checked = False
                .rdbCheck.Checked = False
                .rdbMO.Checked = True
                .txtBank.Text = ""
                .txtNum.Text = dt.Rows(0).Item(43).ToString
                .txtCheckDate.Text = dt.Rows(0).Item(44).ToString
                .txtBank.Enabled = False
                .txtNum.Enabled = True
                .txtCheckDate.Enabled = True
            End If
            Dim disType As String = dt.Rows(0).Item(12).ToString
            If disType = "NO" Then
                .cboDiscountType.Text = "Regular"
                .txtSenID.Text = ""
                .txtDiscount.Text = ""
                .txtSenID.Enabled = False
                .txtDiscount.Enabled = False
            Else
                .cboDiscountType.Text = "Senior/PWD"
                .txtSenID.Text = dt.Rows(0).Item(13).ToString
                .txtDiscount.Text = dt.Rows(0).Item(14).ToString
                .txtSenID.Enabled = True
                .txtDiscount.Enabled = True
            End If
            '.cboDiscountType.Text = ""

            .txtTotal.Text = Format(Val(dt.Rows(0).Item(2).ToString), "#,##0.#0")
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()

        End With
    End Sub

    Private Sub btnEditOutstanding_Click(sender As Object, e As EventArgs) Handles btnEditOutstanding.Click
        Cons()
        editORFromForm = 2
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblOR AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE ORNum='" & editPrevOR & "'", con)
        da.Fill(dt)
        With frmEditOR

            .defOR = dt.Rows(0).Item(1).ToString
            .selORID = Val(dt.Rows(0).Item(0).ToString)
            .txtOR.Text = dt.Rows(0).Item(1).ToString
            .dtpDate.Value = dt.Rows(0).Item(10)
            .lblConsumerName.Text = dt.Rows(0).Item(47).ToString
            .txtN1.Text = dt.Rows(0).Item(15).ToString
            .txtN2.Text = dt.Rows(0).Item(16).ToString
            .txtN3.Text = dt.Rows(0).Item(17).ToString
            .txtN4.Text = dt.Rows(0).Item(18).ToString
            .txtN5.Text = dt.Rows(0).Item(19).ToString
            .txtN6.Text = dt.Rows(0).Item(20).ToString
            .txtN7.Text = dt.Rows(0).Item(21).ToString
            .txtN8.Text = dt.Rows(0).Item(22).ToString
            .txtC1.Text = dt.Rows(0).Item(23).ToString
            .txtC2.Text = dt.Rows(0).Item(24).ToString
            .txtC3.Text = dt.Rows(0).Item(25).ToString
            .txtC4.Text = dt.Rows(0).Item(26).ToString
            .txtC5.Text = dt.Rows(0).Item(27).ToString
            .txtC6.Text = dt.Rows(0).Item(28).ToString
            .txtC7.Text = dt.Rows(0).Item(29).ToString
            .txtC8.Text = dt.Rows(0).Item(30).ToString
            .txtA1.Text = dt.Rows(0).Item(31).ToString
            .txtA2.Text = dt.Rows(0).Item(32).ToString
            .txtA3.Text = dt.Rows(0).Item(33).ToString
            .txtA4.Text = dt.Rows(0).Item(34).ToString
            .txtA5.Text = dt.Rows(0).Item(35).ToString
            .txtA6.Text = dt.Rows(0).Item(36).ToString
            .txtA7.Text = dt.Rows(0).Item(37).ToString
            .txtA8.Text = dt.Rows(0).Item(38).ToString
            .txtCollectionOfficer.Text = dt.Rows(0).Item(39).ToString
            Dim pType As String = dt.Rows(0).Item(3).ToString
            If pType = "Cash" Then
                .rdbCash.Checked = True
                .rdbCheck.Checked = False
                .rdbMO.Checked = False
                .txtBank.Text = ""
                .txtNum.Text = ""
                .txtCheckDate.Text = ""
                .txtBank.Enabled = False
                .txtNum.Enabled = False
                .txtCheckDate.Enabled = False
            ElseIf pType = "Check" Then
                .rdbCash.Checked = False
                .rdbCheck.Checked = True
                .rdbMO.Checked = False
                .txtBank.Text = dt.Rows(0).Item(4).ToString
                .txtNum.Text = dt.Rows(0).Item(5).ToString
                .txtCheckDate.Text = dt.Rows(0).Item(6).ToString
                .txtBank.Enabled = True
                .txtNum.Enabled = True
                .txtCheckDate.Enabled = True
            Else
                .rdbCash.Checked = False
                .rdbCheck.Checked = False
                .rdbMO.Checked = True
                .txtBank.Text = ""
                .txtNum.Text = dt.Rows(0).Item(43).ToString
                .txtCheckDate.Text = dt.Rows(0).Item(44).ToString
                .txtBank.Enabled = False
                .txtNum.Enabled = True
                .txtCheckDate.Enabled = True
            End If
            Dim disType As String = dt.Rows(0).Item(12).ToString
            If disType = "NO" Then
                .cboDiscountType.Text = "Regular"
                .txtSenID.Text = ""
                .txtDiscount.Text = ""
                .txtSenID.Enabled = False
                .txtDiscount.Enabled = False
            Else
                .cboDiscountType.Text = "Senior/PWD"
                .txtSenID.Text = dt.Rows(0).Item(13).ToString
                .txtDiscount.Text = dt.Rows(0).Item(14).ToString
                .txtSenID.Enabled = True
                .txtDiscount.Enabled = True
            End If
            '.cboDiscountType.Text = ""

            .txtTotal.Text = Format(Val(dt.Rows(0).Item(2).ToString), "#,##0.#0")
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()

        End With
    End Sub

    Private Sub btnUnpaid_Click(sender As Object, e As EventArgs) Handles btnUnpaid.Click
        If lvwLedger.SelectedItems.Count > 0 Then
            If MessageBox.Show("Do you want to set the Bill to Unpaid?", "Set to Unpaid", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("UPDATE billing SET billStat='UNPAID', ORNumPaid=NULL WHERE billID=" & arrBillIDLedger(lvwLedger.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                ViewLedger(selectedAcctIDLedger)
            End If
        End If
    End Sub

    Private Sub btnViewOR_Click(sender As Object, e As EventArgs) Handles btnViewOR.Click
        If lvwLedger.SelectedItems.Count > 0 Then
            Dim dtR As New DataTable
            Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & Format(Val(lvwLedger.FocusedItem.SubItems(11).Text), "000000#") & "'", con)
            daR.Fill(dtR)
            daR.Fill(frmORReport.reportingdataset.ORDataTable)
            frmORReport.ORReport.RefreshReport()
            frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            frmORReport.ORReport.ZoomPercent = 100%
            frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            frmORReport.ORReport.Width = 75
            frmORReport.WindowState = FormWindowState.Maximized
            frmORReport.ShowDialog()
        End If
    End Sub

    Private Sub btnSOA_Click(sender As Object, e As EventArgs) Handles btnSOA.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, A.AccountNo, A.AccountName, C.consumername, L.classification, A.isSenior, A.ConnectionDate, A.consID, A.clusterID, A.brgyID FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID LEFT JOIN classifications AS L ON A.classID=L.classID WHERE acctID=" & selectedAcctLedgerID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            frmManuallyAddBill.LoadYear()
            NewBillClassList()

            frmManuallyAddBill.consumerID = Val(dt.Rows(0).Item(7).ToString)
            frmManuallyAddBill.clusterID = Val(dt.Rows(0).Item(8).ToString)
            frmManuallyAddBill.brgyID = Val(dt.Rows(0).Item(9).ToString)

            frmManuallyAddBill.rdbNew.Select()
            frmManuallyAddBill.lblAccountNo.Text = dt.Rows(0).Item(1).ToString
            frmManuallyAddBill.lblConsumerName.Text = dt.Rows(0).Item(2).ToString
            frmManuallyAddBill.lblAcctName.Text = dt.Rows(0).Item(3).ToString
            frmManuallyAddBill.cboClassification.Text = dt.Rows(0).Item(4).ToString
            frmManuallyAddBill.conDate = dt.Rows(0).Item(6)
            Dim actType As String = dt.Rows(0).Item(5).ToString
            If actType = "YES" Then
                frmManuallyAddBill.cboAccountType.Text = "SC/PWD"
            Else
                frmManuallyAddBill.cboAccountType.Text = "Regular"
            End If

            frmManuallyAddBill.txtPrevRead.Text = "0"
            frmManuallyAddBill.txtPresRead.Text = "0"
            frmManuallyAddBill.lblConsump.Text = "0"
            frmManuallyAddBill.txtWSF.Text = "0.00"
            frmManuallyAddBill.txtEF.Text = "0.00"
            frmManuallyAddBill.txtDiscount.Text = "0.00"
            frmManuallyAddBill.txtTotal.Text = "0.00"
            frmManuallyAddBill.txtAppFee.Text = "0.00"
            frmManuallyAddBill.txtTotalAmt.Text = "0.00"
            frmManuallyAddBill.txtPenalty.Text = "0.00"
            frmManuallyAddBill.txtAmountAfterDue.Text = "0.00"

            frmManuallyAddBill.txtPrevAmount.Text = "0.00"
            frmManuallyAddBill.txtPrevEF.Text = "0.00"
            frmManuallyAddBill.txtPrevDiscount.Text = "0.00"
            frmManuallyAddBill.txtPrevInstallment.Text = "0.00"
            frmManuallyAddBill.txtPrevPenalty.Text = "0.00"
            frmManuallyAddBill.txtPrevTotal.Text = "0.00"

            frmManuallyAddBill.txtBillNote.Text = ""

            frmManuallyAddBill.StartPosition = FormStartPosition.CenterScreen
            frmManuallyAddBill.ShowDialog()
        End If

    End Sub
End Class