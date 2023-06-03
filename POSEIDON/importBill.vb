Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data
Public Class importBill
    Dim xlApp As Excel.Application
    Dim xlWorkbook As Excel.Workbook
    Dim xlWorkbooks As Excel.Workbooks
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlRange As Excel.Range
    Dim xlSheetNames As Excel.Sheets
    Dim xlFileFormat As Excel.XlFileFormat
    Dim rowCount As Integer
    Dim Data(0 To 100) As String
    Dim strDestination As String
    Dim ImpAcctNo() As String
    Dim ImpDueDate() As Date
    Dim ImpFromDate() As Date
    Dim ImpToDate() As Date
    Dim ImpBillDate() As Date
    Dim ImpReadDate() As Date
    Dim ImpPaymentDate() As String
    Dim ImpPrevRead() As Integer
    Dim ImpPresRead() As Integer
    Dim ImpConsump() As Integer
    Dim ImpEnvi() As Double
    Dim ImpWSF() As Decimal
    Dim ImpBillAmt() As Decimal
    Dim ImpPrevBal() As Decimal
    Dim ImpPrevSurcharge() As Decimal
    Dim ImpPrevTotal() As Decimal
    Dim ImpAmtPaid() As Decimal
    Dim ImpAdjusted() As Decimal
    Dim ImpServiceFee() As Decimal
    Dim ImpTransMetFee() As Decimal
    Dim ImpTransOwnFee() As Decimal
    Dim ImpReconnectFee() As Decimal
    Dim ImpAdvancePay() As Decimal
    Dim ImpBillStat() As String
    Dim ImpAdjustedAmt() As Decimal
    Dim ImpUID() As Integer
    Dim ImpPrepID() As Integer
    Dim ImpApprID() As Integer
    Dim ImpAdjConf() As String
    Dim ImpAdjReason() As String
    Dim ImpAdjDate() As String
    Dim ImpAdjRmk() As String
    Dim ImpBillNote() As String
    Dim ImpBillNo() As Integer
    Dim impName() As String
    Dim impClassification() As String
    Dim impClassID() As Integer
    Dim impBillPeriod() As String
    Dim impbaserate() As Decimal
    Dim impExcess() As Decimal
    Dim impTotal() As Decimal
    Dim impSCDIs() As Decimal
    Dim imptotalSC() As Decimal
    Dim imptotalPenalty() As Decimal
    Dim impSCPen() As Decimal
    Dim impSCRem() As String
    Dim impAmtDue() As Decimal
    Dim impAmtADue() As Decimal
    Dim impSur() As Decimal
    Dim impORNum() As String
    Dim impDispute() As String
    Dim impPrevCons() As Decimal
    Dim impMetID() As Integer
    Dim impBillMonth() As String
    Dim impBillYear() As String
    Dim impOutstanding() As Decimal
    Dim impAcctID() As Integer
    Dim impConsID() As Integer
    Dim impZoneID() As Integer
    Dim impClusterID() As Integer
    Dim impAmount() As Decimal
    Dim impSeq() As Integer
    Dim impPrevEF() As Decimal
    Dim impPrevSC() As Decimal
    Dim oldRate() As Decimal
    Dim oldRatePen() As Decimal
    Dim impBrgyID() As Integer
    Dim impAppFee() As Decimal
    Dim impPrevAppFee() As Decimal
    Dim impPrevAppCount() As Integer
    Dim impPrevStartMonth() As String
    Dim impPrevStartYear() As String
    Dim strCheckAccount() As String
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            With opPath
                .Filter = "Excel Office|*.xls;*.xlsx;*.xlsm"
                .FileName = ""
                .ShowDialog()
                strDestination = .FileName
                lblFilePath.Text = .FileName
            End With
            cbo.Items.Clear()
            xlApp = New Excel.Application
            xlWorkbook = xlApp.Workbooks.Open(strDestination)
            For Each Sheets In xlWorkbook.Sheets
                cbo.Items.Add(Sheets.Name)
            Next
            cbo.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_Click(sender As Object, e As EventArgs) Handles cbo.Click

    End Sub

    Private Sub cbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo.SelectedIndexChanged
        Me.btnImport.Enabled = True

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If MsgBox("Do you want to start Importing the Accounts?", MsgBoxStyle.YesNo, "Poseidon Database System") = MsgBoxResult.Yes Then
            'Try
            lvw.Items.Clear()
            prb.Value = 0
            prb.Visible = True
            lbl.Visible = True
            lblImp.Visible = True
            lblImp.Text = 0
            'Dim xlCol As Integer
            Dim xlRow As Integer
            With lvw
                If strDestination <> "" And lblFilePath.Text <> "" Then
                    'xlApp = New Excel.Application
                    'xlWorkSheet = xlWorkbook.Worksheets(cbo.Text
                    xlWorkSheet = DirectCast(xlWorkbook.Worksheets(cbo.Text), Excel.Worksheet)
                    xlRange = xlWorkSheet.UsedRange

                    If xlRange.Columns.Count > 0 Then
                        If xlRange.Rows.Count > 0 Then
                            Me.lblImp.Text = xlRange.Rows.Count - 1
                            rowCount = xlRange.Rows.Count - 1
                            ReDim ImpAcctNo(rowCount)
                            ReDim ImpDueDate(rowCount)
                            ReDim ImpFromDate(rowCount)
                            ReDim ImpToDate(rowCount)
                            ReDim ImpBillDate(rowCount)
                            ReDim ImpReadDate(rowCount)
                            ReDim ImpPaymentDate(rowCount)
                            ReDim ImpPrevRead(rowCount)
                            ReDim ImpPresRead(rowCount)
                            ReDim ImpConsump(rowCount)
                            ReDim ImpEnvi(rowCount)
                            ReDim ImpWSF(rowCount)
                            ReDim ImpBillAmt(rowCount)
                            ReDim ImpPrevBal(rowCount)
                            ReDim ImpPrevSurcharge(rowCount)
                            ReDim ImpPrevTotal(rowCount)
                            ReDim ImpAmtPaid(rowCount)
                            ReDim ImpAdjusted(rowCount)
                            ReDim ImpServiceFee(rowCount)
                            ReDim ImpTransMetFee(rowCount)
                            ReDim ImpTransOwnFee(rowCount)
                            ReDim ImpReconnectFee(rowCount)
                            ReDim ImpAdvancePay(rowCount)
                            ReDim ImpBillStat(rowCount)
                            ReDim ImpAdjustedAmt(rowCount)
                            ReDim ImpUID(rowCount)
                            ReDim ImpPrepID(rowCount)
                            ReDim ImpApprID(rowCount)
                            ReDim ImpAdjConf(rowCount)
                            ReDim ImpAdjReason(rowCount)
                            ReDim ImpAdjDate(rowCount)
                            ReDim ImpAdjRmk(rowCount)
                            ReDim ImpBillNote(rowCount)
                            ReDim ImpBillNo(rowCount)
                            ReDim impOutstanding(rowCount)
                            ReDim impAcctID(rowCount)
                            ReDim impConsID(rowCount)
                            ReDim impZoneID(rowCount)
                            ReDim impClusterID(rowCount)
                            ReDim ImpBillAmt(rowCount)
                            ReDim ImpBillStat(rowCount)
                            ReDim impName(rowCount)
                            ReDim impClassification(rowCount)
                            ReDim impClassID(rowCount)
                            ReDim impBillPeriod(rowCount)
                            ReDim impbaserate(rowCount)
                            ReDim impExcess(rowCount)
                            ReDim impTotal(rowCount)
                            ReDim impSCDIs(rowCount)
                            ReDim imptotalSC(rowCount)
                            ReDim imptotalPenalty(rowCount)
                            ReDim impSCPen(rowCount)
                            ReDim impSCRem(rowCount)
                            ReDim impAmtDue(rowCount)
                            ReDim impAmtADue(rowCount)
                            ReDim impSur(rowCount)
                            ReDim impORNum(rowCount)
                            ReDim impDispute(rowCount)
                            ReDim impPrevCons(rowCount)
                            ReDim impMetID(rowCount)
                            ReDim impBillMonth(rowCount)
                            ReDim impBillYear(rowCount)
                            ReDim impAmount(rowCount)
                            ReDim impSeq(rowCount)
                            ReDim impPrevEF(rowCount)
                            ReDim impPrevSC(rowCount)
                            ReDim oldRate(rowCount)
                            ReDim oldRatePen(rowCount)
                            ReDim impBrgyID(rowCount)
                            ReDim impAppFee(rowCount)
                            ReDim impPrevAppFee(rowCount)
                            ReDim impPrevAppCount(rowCount)
                            ReDim impPrevStartMonth(rowCount)
                            ReDim impPrevStartYear(rowCount)
                            ReDim strCheckAccount(rowCount)
                            For xlRow = 1 To xlRange.Rows.Count - 1
                                ImpAcctNo(xlRow - 1) = xlRange.Cells(xlRow + 1, 1).text
                                impName(xlRow - 1) = xlRange.Cells(xlRow + 1, 2).text
                                impClassification(xlRow - 1) = xlRange.Cells(xlRow + 1, 3).text
                                impClassID(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 4).text)
                                ImpDueDate(xlRow - 1) = Convert.ToDateTime(xlRange.Cells(xlRow + 1, 5).text)
                                ImpFromDate(xlRow - 1) = Convert.ToDateTime(xlRange.Cells(xlRow + 1, 6).text)
                                ImpToDate(xlRow - 1) = Convert.ToDateTime(xlRange.Cells(xlRow + 1, 7).text)
                                impBillPeriod(xlRow - 1) = Format(ImpFromDate(xlRow - 1).Date, "MM-dd-yyyy").ToString & " - " & Format(ImpToDate(xlRow - 1).Date, "MM-dd-yyyy").ToString
                                ImpBillDate(xlRow - 1) = Convert.ToDateTime(xlRange.Cells(xlRow + 1, 8).text)
                                ImpReadDate(xlRow - 1) = Convert.ToDateTime(xlRange.Cells(xlRow + 1, 9).text)
                                ImpPrevRead(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 10).text)
                                ImpPresRead(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 11).text)
                                ImpConsump(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 12).text)
                                ImpEnvi(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 13).text)
                                ImpWSF(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 14).text)
                                impAmount(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 15).text)
                                impSCDIs(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 16).text)
                                impTotal(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 17).text)
                                impSur(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 18).text)
                                imptotalPenalty(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 19).text)
                                ImpBillAmt(xlRow - 1) = impAmount(xlRow - 1)
                                impAmtDue(xlRow - 1) = impAmount(xlRow - 1)
                                impAmtADue(xlRow - 1) = impTotal(xlRow - 1)
                                impAppFee(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 31).text)

                                ImpPrevBal(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 20).text)
                                impPrevEF(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 21).text)
                                impPrevSC(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 22).text)
                                ImpPrevSurcharge(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 23).text)
                                ImpPrevTotal(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 24).text)
                                If impSCDIs(xlRow - 1) > 0 Then
                                    impSCRem(xlRow - 1) = "YES"
                                Else
                                    impSCRem(xlRow - 1) = "NO"
                                End If
                                ImpBillStat(xlRow - 1) = "UNPAID"
                                ImpUID(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 25).text)
                                ''ImpBillNote(xlRow - 1) = xlRange.Cells(xlRow + 1, 24).text
                                impMetID(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 26).text)
                                impBillMonth(xlRow - 1) = xlRange.Cells(xlRow + 1, 27).text
                                impBillYear(xlRow - 1) = xlRange.Cells(xlRow + 1, 28).text
                                ''impPrevAppFee(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 28).text)
                                ''impPrevAppCount(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 29).text)
                                impPrevStartMonth(xlRow - 1) = xlRange.Cells(xlRow + 1, 29).text
                                impPrevStartYear(xlRow - 1) = xlRange.Cells(xlRow + 1, 30).text
                                lbl.Text = "Import in progress: "
                                lblImp.Text = xlRow
                                prb.Value = (xlRow / rowCount) * 100
                            Next
                            For xlRow = 1 To xlRange.Rows.Count - 1
                                impAcctID(xlRow - 1) = FinAcctID(ImpAcctNo(xlRow - 1), (xlRow - 1))
                                impConsID(xlRow - 1) = FinConsID(ImpAcctNo(xlRow - 1))
                                impSeq(xlRow - 1) = FinSeq(ImpAcctNo(xlRow - 1))
                                impBrgyID(xlRow - 1) = FinBrgyID(ImpAcctNo(xlRow - 1))
                                impClusterID(xlRow - 1) = FinClusterID(ImpAcctNo(xlRow - 1))
                                impZoneID(xlRow - 1) = FinZoneID(impBrgyID(xlRow - 1))
                            Next
                            For xlRow = 1 To xlRange.Rows.Count - 1
                                .Items.Add(ImpAcctNo(xlRow - 1)) '0
                                .Items(xlRow - 1).SubItems.Add(impName(xlRow - 1)) '1
                                .Items(xlRow - 1).SubItems.Add(impClassification(xlRow - 1)) '2
                                .Items(xlRow - 1).SubItems.Add(impClassID(xlRow - 1)) '3
                                .Items(xlRow - 1).SubItems.Add(ImpDueDate(xlRow - 1)) '4
                                .Items(xlRow - 1).SubItems.Add(ImpFromDate(xlRow - 1)) '5
                                .Items(xlRow - 1).SubItems.Add(ImpToDate(xlRow - 1)) '6
                                .Items(xlRow - 1).SubItems.Add(impBillPeriod(xlRow - 1)) '7
                                .Items(xlRow - 1).SubItems.Add(ImpBillDate(xlRow - 1)) '8
                                .Items(xlRow - 1).SubItems.Add(ImpReadDate(xlRow - 1)) ' 9
                                .Items(xlRow - 1).SubItems.Add(ImpPrevRead(xlRow - 1)) '10
                                .Items(xlRow - 1).SubItems.Add(ImpPresRead(xlRow - 1)) '11
                                .Items(xlRow - 1).SubItems.Add(ImpConsump(xlRow - 1)) '12
                                .Items(xlRow - 1).SubItems.Add(Format(ImpEnvi(xlRow - 1), "#,##0.#0")) '13
                                .Items(xlRow - 1).SubItems.Add(Format(ImpWSF(xlRow - 1), "#,##0.#0")) '14
                                .Items(xlRow - 1).SubItems.Add(Format(impAmount(xlRow - 1), "#,##0.#0")) '15
                                .Items(xlRow - 1).SubItems.Add(Format(impSCDIs(xlRow - 1), "#,##0.#0")) '16
                                .Items(xlRow - 1).SubItems.Add(Format(impTotal(xlRow - 1), "#,##0.#0")) '17
                                .Items(xlRow - 1).SubItems.Add(Format(impSur(xlRow - 1), "#,##0.#0")) '18
                                .Items(xlRow - 1).SubItems.Add(Format(imptotalPenalty(xlRow - 1), "#,##0.#0")) '19
                                .Items(xlRow - 1).SubItems.Add(Format(ImpPrevBal(xlRow - 1), "#,##0.#0")) '20
                                .Items(xlRow - 1).SubItems.Add(Format(impPrevEF(xlRow - 1), "#,##0.#0")) '21
                                .Items(xlRow - 1).SubItems.Add(Format(impPrevSC(xlRow - 1), "#,##0.#0")) '22
                                .Items(xlRow - 1).SubItems.Add(Format(ImpPrevSurcharge(xlRow - 1), "#,##0.#0")) '23
                                .Items(xlRow - 1).SubItems.Add(Format(ImpPrevTotal(xlRow - 1), "#,##0.#0")) '24
                                '.Items(xlRow - 1).SubItems.Add(ImpBillStat(xlRow - 1)) '20
                                .Items(xlRow - 1).SubItems.Add(ImpUID(xlRow - 1)) '25
                                '.Items(xlRow - 1).SubItems.Add(ImpBillNote(xlRow - 1)) '22
                                .Items(xlRow - 1).SubItems.Add(impMetID(xlRow - 1)) '26
                                .Items(xlRow - 1).SubItems.Add(impBillMonth(xlRow - 1)) '27
                                .Items(xlRow - 1).SubItems.Add(impBillYear(xlRow - 1)) '28
                                .Items(xlRow - 1).SubItems.Add(impPrevStartMonth(xlRow - 1)) '29
                                .Items(xlRow - 1).SubItems.Add(impPrevStartYear(xlRow - 1)) '30
                                .Items(xlRow - 1).SubItems.Add(impAppFee(xlRow - 1)) '31
                                .Items(xlRow - 1).SubItems.Add(strCheckAccount(xlRow - 1)) '26
                                If strCheckAccount(xlRow - 1) = "Account Okay" Then
                                    .Items(xlRow - 1).BackColor = Color.White
                                Else
                                    .Items(xlRow - 1).BackColor = Color.Red
                                End If
                                .Items(xlRow - 1).SubItems.Add(FindBill(impBillMonth(xlRow - 1), impBillYear(xlRow - 1), impAcctID(xlRow - 1), ImpAcctNo(xlRow - 1))) '26
                                lbl.Text = "Ready to Save: "
                                lblImp.Text = xlRow
                                prb.Value = (lvw.Items.Count / rowCount) * 100
                            Next
                            If prb.Value = 100 Then
                                prb.Visible = False
                                prb.Value = 0
                            End If
                            'codessplit()
                            xlApp.Application.DisplayAlerts = False
                            If xlApp.ActiveWorkbook.Saved = False Then
                                xlApp.ActiveWorkbook.Save()
                            End If
                            xlWorkbook.Close()
                            xlApp.Quit()
                            releaseobject(xlApp)
                            releaseobject(xlWorkbook)
                            Me.lblFilePath.Text = ""
                            Me.cbo.Items.Clear()
                            Me.cbo.Text = ""
                            Me.btnImport.Enabled = False
                            Me.btnSaveBills.Enabled = True
                        End If
                    End If
                Else
                    MessageBox.Show("Please input correct attributes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With
        End If
    End Sub
    Private Function FinAcctID(acctNo As String, i As Integer) As Integer
        Dim aID As Integer
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT acctID FROM consumeraccounts WHERE AccountNo='" & acctNo & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            aID = dt.Rows(0).Item(0)
            strCheckAccount(i) = "Account Okay"
            'lvw.Items(i).BackColor = Color.White
        Else
            strCheckAccount(i) = acctNo & " Not Found"
            'lvw.Items(i).BackColor = Color.Red
        End If

        Return aID

    End Function

    Private Function FinZoneID(brgyID As Integer) As Integer
        Dim zID As Integer = 0
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT ZoneID FROM brgylist WHERE brgyID=" & brgyID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            zID = Val(dt.Rows(0).Item(0).ToString)
        End If
        Return zID
    End Function

    Private Function FinConsID(acctNo As String) As Integer
        Try
            Dim cID As Integer = 0
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT consID FROM consumeraccounts WHERE AccountNo='" & acctNo & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cID = dt.Rows(0).Item(0)
            End If

            Return cID
        Catch ex As Exception
            MessageBox.Show("Account Not Found")
        End Try

    End Function

    Private Function FinSeq(acctNo As String) As Integer
        Try
            Dim seq As Integer = 0
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT sequence FROM consumeraccounts WHERE AccountNo='" & acctNo & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                seq = dt.Rows(0).Item(0)
            End If

            Return seq
        Catch ex As Exception

        End Try
    End Function

    Private Function FinBrgyID(acctNo As String) As Integer
        Dim bID As Integer = 0
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT brgyID FROM consumeraccounts WHERE AccountNo='" & acctNo & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            bID = dt.Rows(0).Item(0)
        End If

        Return Bid
    End Function

    Private Function FinClusterID(acctNo As String) As Integer
        Dim cID As Integer = 0
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT clusterID FROM consumeraccounts WHERE AccountNo='" & acctNo & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cID = dt.Rows(0).Item(0)
        End If
        Return cID
    End Function

    Private Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Function FindBill(billMonth As String, billyear As Integer, acctID As Integer, acctNo As String) As String
        Dim strBillInfo As String
        Dim daA As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE accountNo='" & acctNo & "'", con)
        Dim dtA As New DataTable
        daA.Fill(dtA)
        If dtA.Rows.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM billing WHERE acctID=" & acctID & " AND billMonth='" & billMonth & "' and billyear=" & billyear, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                strBillInfo = "Bill Existed"

            Else
                strBillInfo = "Bill Available"
            End If
        Else
            strBillInfo = "Account Unavailable"
        End If
        Return strBillInfo
    End Function



    Private Sub codessplit()
        'MessageBox.Show("Split")
        For x As Integer = 0 To Me.lvw.Items.Count - 1
            If lvw.Items(x).Text = "" Then
                lvw.Items(x).SubItems(32).Text = "Account No is Empty!"
            Else
                Cons()
                Dim daA As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE accountNo='" & ImpAcctNo(x) & "'", con)
                Dim dtA As New DataTable
                daA.Fill(dtA)
                If dtA.Rows.Count > 0 Then
                    Cons()
                    'Dim dt As New DataTable
                    'Dim da As New MySqlDataAdapter("SELECT acctID, AccountNo, AcctStatus FROM consumeraccounts WHERE accountNo='" & Me.lvw.Items(x).Text & "'", con)
                    'da.Fill(dt)
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter("SELECT * FROM billing WHERE acctID=" & impAcctID(x) & " AND billMonth='" & impBillMonth(x) & "' and billyear=" & impBillYear(x), con)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        lvw.Items(x).SubItems(33).Text = "Bill Existed"

                    Else
                        lvw.Items(x).SubItems(33).Text = "Bill Available"
                    End If

                    If ImpPrevTotal(x) > 0 Then
                        If impBillMonth(x) = "APRIL" Or impBillMonth(x) = "April" Then
                            If impPrevStartMonth(x) = "" Or impPrevStartYear(x) = "" Then
                                lvw.Items(x).SubItems(33).Text = "MISSING PREVIOUS DETAILS"
                                lvw.Items(x).BackColor = Color.Red
                            End If
                        End If
                    End If
                Else
                    lvw.Items(x).SubItems(32).Text = "MISSING ACCOUNT NUMBER"
                    lvw.Items(x).BackColor = Color.Red
                End If

            End If
        Next
    End Sub

    Private Sub SaveAttribs(itemcount As Integer)
        If MsgBox("Confirm Saving Imported Data to Database?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Cons()
            Dim counter As Integer = 0
            Dim allitemcount As Integer = itemcount

            For x As Integer = 0 To itemcount - 1
                If lvw.Items(x).SubItems(33).Text = "Bill Available" Then
                    counter = counter + 1

                    Dim cmd As New MySqlCommand("INSERT INTO billing(acctID, consID, classID, dueDate, fromDate, toDate, billMonth, billYear, prevRead, presRead, prevBal, prevConsump, prevEnv, prevPenalty, prevAmountDue, prevTotal, consump, amount, enviFee, totalAmountDue, useAmount, useADue, penalty, AmountADue, isSC, SCDiscount, adjRemark, billStat, metReadID, uID, zoneID, billPeriod, billDate, readDate, prevOutstanding, prevOutstandingStat, prevOutPenalty, prevOutEF, prevStartMonth, prevStartYear, prevOutDiscount, brgyID, clusterID, prevSCDis, applicationfee) VALUES(@aID, @cID, @clID, @dDate, @fDate, @tDate, @bMonth, @bYear, @pvRead, @psRead, @pvBal, @pvConsump, @pvEnv, @pvPenalty, @pvAmountDue, @pvTotal, @cons, @amt, @eFee, @totAmountDue, @uAmount, @uADue, @pen, @AmtADue, @isSen, @sDis,@adjRmk, @bStat, @metID, @userID, @zID, @bPeriod, @bDate, @rDate, @pvOutstanding, @pvOutstandingStat, @pvOutPenalty, @pvOutEF, @pvStartMonth, @pvStartYear, @pvOutDiscount, @brID, @clusID, @pSCDis, @appf)", con)
                    cmd.Parameters.AddWithValue("@aID", impAcctID(x))
                    cmd.Parameters.AddWithValue("@cID", impConsID(x))
                    cmd.Parameters.AddWithValue("@clID", impClassID(x))
                    cmd.Parameters.AddWithValue("@dDate", ImpDueDate(x))
                    cmd.Parameters.AddWithValue("@fDate", ImpFromDate(x))
                    cmd.Parameters.AddWithValue("@tDate", ImpToDate(x))
                    cmd.Parameters.AddWithValue("@bMonth", impBillMonth(x))
                    cmd.Parameters.AddWithValue("@bYear", impBillYear(x))
                    cmd.Parameters.AddWithValue("@pvRead", ImpPrevRead(x))
                    cmd.Parameters.AddWithValue("@psRead", ImpPresRead(x))
                    cmd.Parameters.AddWithValue("@pvBal", ImpPrevBal(x))
                    cmd.Parameters.AddWithValue("@pvConsump", impPrevEF(x))
                    cmd.Parameters.AddWithValue("@pvEnv", impPrevEF(x))
                    cmd.Parameters.AddWithValue("@pvPenalty", ImpPrevSurcharge(x))
                    cmd.Parameters.AddWithValue("@pvAmountDue", ImpPrevBal(x))
                    cmd.Parameters.AddWithValue("@pvTotal", ImpPrevTotal(x))
                    cmd.Parameters.AddWithValue("@cons", ImpConsump(x))
                    cmd.Parameters.AddWithValue("@amt", impAmount(x))
                    cmd.Parameters.AddWithValue("@eFee", ImpEnvi(x))
                    cmd.Parameters.AddWithValue("@totAmountDue", impTotal(x))
                    cmd.Parameters.AddWithValue("@uAmount", impTotal(x))
                    cmd.Parameters.AddWithValue("@uADue", imptotalPenalty(x))
                    cmd.Parameters.AddWithValue("@pen", impSur(x))
                    cmd.Parameters.AddWithValue("@AmtADue", imptotalPenalty(x))
                    cmd.Parameters.AddWithValue("@isSen", impSCRem(x))
                    cmd.Parameters.AddWithValue("@sDis", impSCDIs(x))
                    cmd.Parameters.AddWithValue("@adjRmk", "None")
                    cmd.Parameters.AddWithValue("@bStat", "UNPAID")
                    cmd.Parameters.AddWithValue("@metID", impMetID(x))
                    cmd.Parameters.AddWithValue("@userID", ImpUID(x))
                    cmd.Parameters.AddWithValue("@zID", impZoneID(x))
                    cmd.Parameters.AddWithValue("@bPeriod", impBillPeriod(x))
                    cmd.Parameters.AddWithValue("@bDate", ImpBillDate(x))
                    cmd.Parameters.AddWithValue("@rDate", ImpReadDate(x))
                    cmd.Parameters.AddWithValue("@pvOutstanding", ImpPrevTotal(x))
                    If ImpPrevTotal(x) > 0 Then
                        cmd.Parameters.AddWithValue("@pvOutstandingStat", "UNPAID")
                        cmd.Parameters.AddWithValue("@pvOutPenalty", ImpPrevSurcharge(x))
                        cmd.Parameters.AddWithValue("@pvOutEF", impPrevEF(x))
                        cmd.Parameters.AddWithValue("@pvStartMonth", impPrevStartMonth(x))
                        cmd.Parameters.AddWithValue("@pvStartYear", impPrevStartYear(x))
                        cmd.Parameters.AddWithValue("@pvOutDiscount", impPrevSC(x))
                    Else
                        cmd.Parameters.AddWithValue("@pvOutstandingStat", "PAID")
                        cmd.Parameters.AddWithValue("@pvOutPenalty", Nothing)
                        cmd.Parameters.AddWithValue("@pvOutEF", 0)
                        cmd.Parameters.AddWithValue("@pvStartMonth", Nothing)
                        cmd.Parameters.AddWithValue("@pvStartYear", Nothing)
                        cmd.Parameters.AddWithValue("@pvOutDiscount", 0)
                    End If

                    cmd.Parameters.AddWithValue("@brID", impBrgyID(x))
                    cmd.Parameters.AddWithValue("@clusID", impClusterID(x))
                    cmd.Parameters.AddWithValue("@pSCDis", impPrevSC(x))
                    cmd.Parameters.AddWithValue("@appf", impAppFee(x))
                    cmd.ExecuteNonQuery()
                    lbl.Text = "Saving: "
                    lblImp.Text = x + 1
                    prb.Value = ((x + 1) / itemcount) * 100
                End If

            Next
            If prb.Value = 100 Then
                prb.Visible = False
                prb.Value = 0
            End If
            MsgBox("All Data has been saved Successfully! Bill saved: " & counter, MsgBoxStyle.Information, "POSEIDON DATABASE SYSTEM")
            Me.lvw.Items.Clear()
            Me.btnSaveBills.Enabled = False
        End If
    End Sub

    Private Sub importBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnSaveBills.Click
        SaveAttribs(rowCount)
    End Sub
End Class