Imports MySql.Data
Imports MySql.Data.MySqlClient
'Imports CrystalDecisions.CrystalReports
'Imports CrystalDecisions.CrystalReports.Engine

Public Class frmBilling
    Dim mySelQuery As String
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If strQueryBill = "" Then
            MsgBox("Please Load Bills.")
        Else
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(strQueryBill, con)
            da.Fill(dt)
            Dim report As New crptBill
            report.SetDataSource(dt)
            frmCrystalBillReport.CrystalReportViewer1.ReportSource = report
            frmCrystalBillReport.CrystalReportViewer1.Zoom(100%)
            frmCrystalBillReport.CrystalReportViewer1.Refresh()
            frmCrystalBillReport.WindowState = FormWindowState.Maximized
            frmCrystalBillReport.ShowDialog()
            'CollectionNoticeReport(strQueryBill)
            'recordBill()
            'MsgBox(strQueryBill)
            'frmBillPrint.ReportViewer1.ConsumeContainerWhiteSpace = True
            'frmBillPrint.ReportViewer1.RefreshReport()
            'frmBillPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            'frmBillPrint.ReportViewer1.ZoomPercent = 100%
            'frmBillPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            'frmBillPrint.ReportViewer1.Width = 75
            'frmBillPrint.WindowState = FormWindowState.Maximized
            'frmBillPrint.Show()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        LoadWaterBilling.StartPosition = FormStartPosition.CenterScreen
        LoadWaterBilling.ShowDialog()
    End Sub


    Private Sub btnBillingNotice_Click(sender As Object, e As EventArgs) Handles btnBillingNotice.Click
        If lvw.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT * FROM meterreading AS MR LEFT JOIN consumeraccounts AS A ON MR.acctID=A.AcctID LEFT JOIN consumerlist AS C ON A.consID=C.ConsID LEFT JOIN classifications AS CL ON A.classID=CL.classID WHERE MR.metID=" & arrBillMetID(lvw.FocusedItem.Index) & " ORDER BY A.Sequence", con)
            Dim da As New MySqlDataAdapter("SELECT B.billID, A.acctID, A.accountno, A.meterno, C.consumername, A.streetaddress, CL.classification, B.duedate, B.billperiod B.presreading, B.prevreading, B.consumption, B.amountbilled, B.prevmonthbal, B.dueamount, B.balancepayable, B.servfee, B.transmetfee, B.transownfee, B.reconnectfee, B.advancepaymentfee FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN classifications AS CL ON A.classID=CL.classID WHERE B.billID=" & arrBillMetID(lvw.FocusedItem.Index) & " ORDER BY A.Sequence", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                With frmNoticeOfCollection
                    .lblAccountNum.Text = dt.Rows(0).Item(2).ToString
                    .lblMeterNum.Text = dt.Rows(0).Item(3).ToString
                    .lblName.Text = dt.Rows(0).Item(4).ToString
                    .lblAddress.Text = dt.Rows(0).Item(5).ToString
                    .lblAccountType.Text = dt.Rows(0).Item(6).ToString
                    .lblDueDate.Text = Format(dt.Rows(0).Item(7), "MM-dd-yyyy")
                    .lblPerFrom.Text = Format(dt.Rows(0).Item(8), "MM-dd-yyyy")
                    .lblPerTo.Text = Format(dt.Rows(0).Item(9), "MM-dd-yyyy")
                    .lblPresentReading.Text = dt.Rows(0).Item(10).ToString
                    .lblPrevReading.Text = dt.Rows(0).Item(11).ToString
                    .lblConsumption.Text = dt.Rows(0).Item(12).ToString
                    .lblBillAmount.Text = Format(Val(dt.Rows(0).Item(13).ToString), "#,##0.#0")
                    .lblPrevMonthBalance.Text = Format(Val(dt.Rows(0).Item(14).ToString), "#,##0.#0")
                    .lblDueAmount.Text = Format(Val(dt.Rows(0).Item(15).ToString), "#,##0.#0")
                    .lblBalancePayable.Text = Format(Val(dt.Rows(0).Item(16).ToString), "#,##0.#0")
                    .lblServFee.Text = Format(Val(dt.Rows(0).Item(17).ToString), "#,##0.#0")
                    .lblMetTransFee.Text = Format(Val(dt.Rows(0).Item(18).ToString), "#,##0.#0")
                    .lblOwnTransFee.Text = Format(Val(dt.Rows(0).Item(19).ToString), "#,##0.#0")
                    .lblReconFee.Text = Format(Val(dt.Rows(0).Item(20).ToString), "#,##0.#0")
                    selBillMetID = Val(dt.Rows(0).Item(0).ToString)
                    selBillAccID = Val(dt.Rows(0).Item(1).ToString)
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()

                End With
            End If
        End If
    End Sub

    Private Sub btnPrintSelBill_Click(sender As Object, e As EventArgs) Handles btnPrintSelBill.Click
        If lvw.SelectedItems.Count > 0 Then

            mySelQuery = "SELECT B.billID, A.acctID, C.consID, CC.classID, Z.zoneID, BR.brgyID, 1, M.addmunid, M.municipality, BR.addbrgy, '', A.StreetAddress, A.AccountName, C.contactNum, A.AccountNo, A.MeterNo, B.billMonth, B.billYear, B.billPeriod, B.dueDate, B.prevread, B.presRead, B.consump, B.amount, B.EnviFee, B.isSC, B.SCDiscount, B.prevAmountDue, B.prevPenalty, B.prevTotal, B.applicationfee, B.penalty, B.billNote, B.readDate, B.fromDate, B.toDate, B.overpayment, B.useAmount, B.useADue, B.billDate FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN classifications AS CC ON B.classID=CC.classID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID LEFT JOIN zones AS Z ON Z.zoneID=BR.zoneID LEFT JOIN munlist AS M ON M.addmunID=Z.addmunID where B.billID=" & arrBillMetID(lvw.FocusedItem.Index)
            CollectionNoticeReport(mySelQuery)
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

        End If
    End Sub

    Private Sub frmBilling_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        strQueryBill = ""
        mySelQuery = ""
    End Sub

    Private Sub frmBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BdateGen = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmEnterBillingNum.txtBillID.Text = ""
        frmEnterBillingNum.StartPosition = FormStartPosition.CenterScreen
        frmEnterBillingNum.ShowDialog()
    End Sub

    Private Sub btnAdjust_Click(sender As Object, e As EventArgs) Handles btnAdjust.Click
        If lvw.SelectedItems.Count > 0 Then
            If checkAdjustment(arrBillingMetID(lvw.FocusedItem.Index)) = True Then
                billAdjustForm = 2
                BillAdjustmentLoad(arrBillingMetID(lvw.FocusedItem.Index))
                frmBillAdjustment.txtConsumption.Text = ""
                frmBillAdjustment.StartPosition = FormStartPosition.CenterScreen
                frmBillAdjustment.ShowDialog()
            End If
        Else
            MsgBox("Nothing Selected", MsgBoxStyle.Exclamation, "Nothing Selected")
            Exit Sub
        End If
    End Sub

    Private Sub btnDispute_Click(sender As Object, e As EventArgs) Handles btnDispute.Click
        billAdjustForm = 2
    End Sub
End Class