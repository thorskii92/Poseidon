Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmNewMeterReader
    Dim CountAccounts As Integer
    Dim fDay As Integer
    Dim brgID() As Integer
    Dim clusID() As Integer
    Dim metID() As Integer
    Dim readConsID() As Integer
    Dim readAcctID() As Integer
    Dim readAcctNo() As String
    Dim readAcctName() As String
    Dim readClassID() As Integer
    Dim readClassification() As String
    Dim readAddress() As String
    Dim readBrgy() As String
    Dim readIsSC() As String
    Dim readPrevRead() As Integer
    Dim readPresRead() As Integer
    Dim readConsump() As Integer
    Dim readAmount() As Decimal
    Dim readInitialAmount() As Decimal
    Dim readAdjusted() As Decimal
    Dim readAdjustment() As Decimal
    Dim readBaseRate() As Decimal
    Dim readFlatRate() As Decimal
    Dim readExcess() As Decimal
    Dim readEF() As Decimal
    Dim readDiscount() As Decimal
    Dim readPenalty() As Decimal
    Dim readSequence() As Integer
    Dim disNote As String
    Dim readBrgyID() As Integer
    Dim discDate As Date
    Dim readAppFee() As Decimal
    Dim readOverpayment() As Decimal
    Dim readBillCounter() As Integer
    Dim metGenerated As Boolean
    Dim readPrevBal() As Decimal
    Dim readPrevConsump() As Integer
    Dim readPrevEnv() As Decimal
    Dim readPrevAdj() As Decimal
    Dim readPrevAdjRate() As Decimal
    Dim readPrevPen() As Decimal
    Dim readPrevAmountDue() As Decimal
    Dim readPrevTotal() As Decimal
    Dim readPrevSCDis() As Decimal
    Dim readConDate() As Date
    Dim readStandPipe() As String

    Dim readMaxAmt() As Decimal
    Dim readMaxCons() As Integer
    Dim readNR() As Decimal
    Dim readAR() As Decimal
    Dim readTotal() As Decimal
    Dim readSCAmt() As Decimal
    Dim ReadSCPen() As Decimal
    Dim readTP() As Decimal
    Dim readTotalAmount() As Decimal
    Dim readTotalADue() As Decimal
    Dim readRemOverpayment() As Decimal

    Dim readZoneID() As Integer
    Dim readClusterID() As Integer
    Dim loadAutosaveOpt As Boolean

    Dim readFConsump() As Integer
    Dim readSConsump() As Integer
    Dim readFExcess() As Decimal
    Dim readSExcess() As Decimal
    Dim readFLabel() As String
    Dim readSLabel() As String
    Dim readFRateCub() As Decimal
    Dim readSRateCub() As Decimal
    Dim dtRates As New DataTable
    Dim dtResidentialRates As New DataTable
    Dim dtInstitutionalRates As New DataTable
    Dim dtGovernmentRates As New DataTable
    Dim dtCommercialRates As New DataTable
    Dim dtIndustrialRates As New DataTable

    Private Sub frmNewMeterReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metGenerated = False
        LoadRates()
        LoadYear()
        LoadBrgy()
        LoadReaders()
        'cboCluster.Items.Clear()
        LoadMonth()
        fDay = 0
        dgvReading.Rows.Clear()
        If checkAutosave(loggedUserID) = True Then
            If MessageBox.Show("Previous Reading have been autosaved, would you like to continue your previous work, or create a new one? Press 'YES' if you would like to continue, 'NO' if you want to create a new one and erase the Autosaved Reading", "Continue Autosaved Reading", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                loadAutosaveOpt = True
                LoadAutosave(loggedUserID)

            Else
                loadAutosaveOpt = False
                deleteAutosave(loggedUserID)

            End If
        End If
    End Sub

    Private Sub LoadRates()
        dtRates.Clear()
        Dim da1 As New MySqlDataAdapter("SELECT * FROM tblclassrates where classID=1", con)
        da1.Fill(dtResidentialRates)
        Dim da2 As New MySqlDataAdapter("SELECT * FROM tblclassrates where classID=2", con)
        da2.Fill(dtInstitutionalRates)
        Dim da3 As New MySqlDataAdapter("SELECT * FROM tblclassrates where classID=3", con)
        da3.Fill(dtGovernmentRates)
        Dim da4 As New MySqlDataAdapter("SELECT * FROM tblclassrates where classID=4", con)
        da4.Fill(dtCommercialRates)
        Dim da5 As New MySqlDataAdapter("SELECT * FROM tblclassrates where classID=5", con)
        da5.Fill(dtIndustrialRates)
    End Sub

    Private Sub LoadYear()

        cboYearRead.Items.Clear()
        For x As Integer = 2020 To Now.Year
            cboYearRead.Items.Add(x)
        Next
    End Sub

    Private Sub LoadBrgy()
        cboBrgy.Items.Clear()
        cboCluster.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE stat='Active'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim brgID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                brgID(x) = Val(dt.Rows(x).Item(0))
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next

        End If
    End Sub

    Private Sub loadCluster(i As Integer)
        cboCluster.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE brgyID=" & i & " and stat='Active'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim clusID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                clusID(x) = Val(dt.Rows(x).Item(0))
                cboCluster.Items.Add(dt.Rows(x).Item(2))
            Next
        End If
    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged
        loadCluster(brgID(cboBrgy.SelectedIndex))
    End Sub

    Private Sub LoadReaders()
        cboReader.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM meterreader WHERE metStat='Active'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim metID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                metID(x) = Val(dt.Rows(x).Item(0))
                cboReader.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Private Sub UpdateAutosaveMainDetails(uID As Integer, readDate As Date, dueDate As Date, billDate As Date, perMonth As String, perYear As Integer, readName As String)
        Cons()
        Dim cmd As New MySqlCommand("UPDATE autosavemaindetails SET readDate=@rDate, dueDate=@dDate, billDate=@bDate, periodMonth=@pMon, periodYear=@pYear, readerName=@rName WHERE uID=" & uID, con)
        cmd.Parameters.AddWithValue("@rDate", Format(readDate.Date, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@dDate", Format(dueDate.Date, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@bDate", Format(billDate.Date, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@pMon", perMonth)
        cmd.Parameters.AddWithValue("@pYear", perYear)
        cmd.Parameters.AddWithValue("@rName", readName)

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub CreateAutosaveDetails(uID As Integer, brgyID As Integer, readDate As Date, dueDate As Date, billDate As Date, perMonth As String, perYear As Integer, brgyName As String, readName As String, clusName As String, disDate As Date)
        deleteAutosave(uID)
        Cons()
        Dim cmd As New MySqlCommand("INSERT INTO autosavemaindetails(uID, brgyID, readDate, dueDate, billDate, periodMonth, periodYear, brgyName, readerName, clusterName, disconnectionDate) VALUES(@usID, @bID, @rDate, @dDate, @bDate, @pMon, @pYea, @bName, @rName, @clusName, @disDate)", con)
        cmd.Parameters.AddWithValue("@usID", uID)
        cmd.Parameters.AddWithValue("@bID", brgyID)
        cmd.Parameters.AddWithValue("@rDate", Format(readDate.Date, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@dDate", Format(dueDate.Date, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@bDate", Format(billDate.Date, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@pMon", perMonth)
        cmd.Parameters.AddWithValue("@pYea", perYear)
        cmd.Parameters.AddWithValue("@bName", brgyName)
        cmd.Parameters.AddWithValue("@rName", readName)
        cmd.Parameters.AddWithValue("@clusName", clusName)
        cmd.Parameters.AddWithValue("@disDate", disDate)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub CreateAutosaver(brgyID As Integer, acctID As Integer, uID As Integer, pread As Integer, clusterID As Integer)
        Cons()
        Dim cmd As New MySqlCommand("INSERT INTO tempreadautosave(acctID, brgyID, uID, prevRead, presRead, consump, clusterID) VALUES(@aID, @bID, @usID, @pvR, @psR, @cmp, @clusID)", con)
        cmd.Parameters.AddWithValue("@aID", acctID)
        cmd.Parameters.AddWithValue("@bID", brgyID)
        cmd.Parameters.AddWithValue("@usID", uID)
        cmd.Parameters.AddWithValue("@pvR", pread)
        cmd.Parameters.AddWithValue("@psR", pread)
        cmd.Parameters.AddWithValue("@cmp", 0)
        cmd.Parameters.AddWithValue("@clusID", clusterID)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub UpDateAutosaver(brgyID As Integer, acctID As Integer, uID As Integer, pvread As Integer, psread As Integer, consump As Integer, clusterID As Integer)
        Cons()
        Dim cmd As New MySqlCommand("UPDATE tempreadautosave set prevRead=@pvRead, presRead=@psRead, consump=@cmp, clusterID=@clusID where acctID=" & acctID & " and brgyID=" & brgyID & " and uID=" & uID, con)
        cmd.Parameters.AddWithValue("@pvRead", pvread)
        cmd.Parameters.AddWithValue("@psRead", psread)
        cmd.Parameters.AddWithValue("@cmp", consump)
        cmd.Parameters.AddWithValue("@clusID", clusterID)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub LoadAutosave(uID As Integer)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM autosavemaindetails WHERE uID=" & uID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            dtpReadDate.Value = dt.Rows(0).Item(3)
            dtpDueDate.Value = dt.Rows(0).Item(4)
            dtpBillDate.Value = dt.Rows(0).Item(5)
            cboMonthRead.Text = dt.Rows(0).Item(6)
            cboYearRead.Text = dt.Rows(0).Item(7)
            cboBrgy.Text = dt.Rows(0).Item(8)
            cboReader.Text = dt.Rows(0).Item(9)
            cboCluster.Text = dt.Rows(0).Item(10)
            dtpDisconnection.Value = dt.Rows(0).Item(11)
            GenerateReading()
        End If
    End Sub

    Private Function checkAutosave(uID As Integer) As Boolean
        Dim a As Boolean
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tempreadautosave WHERE uID=" & uID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            a = True
        Else
            a = False
        End If
        checkAutosave = a
    End Function

    Private Sub deleteAutosave(uID As Integer)
        Cons()
        Dim cmd As New MySqlCommand("DELETE FROM tempreadautosave WHERE uID=" & uID, con)
        cmd.ExecuteNonQuery()
        Dim cmdM As New MySqlCommand("DELETE FROM autosavemaindetails where uID=" & uID, con)
        cmdM.ExecuteNonQuery()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReading()
    End Sub

    Private Sub LoadAutosavedValues(uID As Integer)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tempreadautosave where uID=" & uID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Try
                    dgvReading.Rows(x).Cells(4).Value = Val(dt.Rows(x).Item(4).ToString)
                    dgvReading.Rows(x).Cells(5).Value = Val(dt.Rows(x).Item(5).ToString)
                Catch ex As Exception

                End Try

            Next
        End If
    End Sub

    Private Sub GenerateReading()
        metGenerated = True
        discDate = dtpDueDate.Value.AddDays(6)
        lblLoad.Text = ""
        lblLoad.Visible = True
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, A.accountNo, A.AccountName, A.streetaddress, A.meterreference, C.classID, C.classification, A.isSenior, BR.addbrgy, A.consID, A.Sequence, BR.zoneID, A.clusterID, BR.brgyID, A.ConnectionDate, A.standpipe FROM consumeraccounts AS A LEFT JOIN classifications AS C ON A.classID=C.classID LEFT JOIN brgylist AS BR ON A.brgyID=BR.brgyID LEFT JOIN zones AS Z ON BR.zoneID=Z.zoneID WHERE A.acctstatus=1 and A.clusterID=" & clusID(cboCluster.SelectedIndex) & " AND NOT (SELECT COUNT(*) FROM billing AS B WHERE B.AcctID=A.AcctID AND B.billmonth='" & cboMonthRead.Text & "' AND B.billyear=" & cboYearRead.Text & ") > 0 ORDER BY A.standpipe, A.AccountName", con)
        da.Fill(dt)
        dgvReading.Rows.Clear()

        If dt.Rows.Count > 0 Then
            If loadAutosaveOpt = False Then
                CreateAutosaveDetails(loggedUserID, brgID(cboBrgy.SelectedIndex), dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboBrgy.Text, cboReader.Text, cboCluster.Text, dtpDisconnection.Value.Date)
            End If
            billperiod = Format(dtpFrom.Value.Date, "MM/dd/yyyy") & " - " & Format(dtpTo.Value.Date, "MM/dd/yyyy")
            CountAccounts = dt.Rows.Count
            prb.Value = 0
            prb.Visible = True
            prb.Maximum = dt.Rows.Count
            'Threading.Thread.Sleep(1000)
            'lblLoad.Text = "Loading Variables"
            ReDim readAcctID(dt.Rows.Count - 1)
            ReDim readAcctName(dt.Rows.Count - 1)
            ReDim readAcctNo(dt.Rows.Count - 1)
            ReDim readAddress(dt.Rows.Count - 1)
            ReDim readPrevRead(dt.Rows.Count - 1)
            ReDim readPresRead(dt.Rows.Count - 1)
            ReDim readConsump(dt.Rows.Count - 1)
            ReDim readClassID(dt.Rows.Count - 1)
            ReDim readIsSC(dt.Rows.Count - 1)
            ReDim readClassification(dt.Rows.Count - 1)
            ReDim readBrgy(dt.Rows.Count - 1)
            ReDim readPrevBal(dt.Rows.Count - 1)
            ReDim readConsID(dt.Rows.Count - 1)
            ReDim readSequence(dt.Rows.Count - 1)
            ReDim readZoneID(dt.Rows.Count - 1)
            ReDim readClusterID(dt.Rows.Count - 1)
            ReDim readBrgyID(dt.Rows.Count - 1)
            ReDim readAppFee(dt.Rows.Count - 1)
            ReDim readConDate(dt.Rows.Count - 1)

            ReDim readPrevConsump(dt.Rows.Count - 1)
            ReDim readPrevEnv(dt.Rows.Count - 1)
            ReDim readPrevAdj(dt.Rows.Count - 1)
            ReDim readPrevAdjRate(dt.Rows.Count - 1)
            ReDim readPrevPen(dt.Rows.Count - 1)
            ReDim readPrevAmountDue(dt.Rows.Count - 1)
            ReDim readPrevTotal(dt.Rows.Count - 1)
            ReDim readOverpayment(dt.Rows.Count - 1)
            ReDim readBillCounter(dt.Rows.Count - 1)

            ReDim readAmount(dt.Rows.Count - 1)
            ReDim readAdjusted(dt.Rows.Count - 1)
            ReDim readAdjustment(dt.Rows.Count - 1)
            ReDim readBaseRate(dt.Rows.Count - 1)
            ReDim readFlatRate(dt.Rows.Count - 1)
            ReDim readExcess(dt.Rows.Count - 1)
            ReDim readEF(dt.Rows.Count - 1)
            ReDim readDiscount(dt.Rows.Count - 1)
            ReDim readPenalty(dt.Rows.Count - 1)
            ReDim readPrevSCDis(dt.Rows.Count - 1)
            ReDim readInitialAmount(dt.Rows.Count - 1)
            ReDim readMaxAmt(dt.Rows.Count - 1)
            ReDim readMaxCons(dt.Rows.Count - 1)
            ReDim readNR(dt.Rows.Count - 1)
            ReDim readAR(dt.Rows.Count - 1)
            ReDim readTotal(dt.Rows.Count - 1)
            ReDim readSCAmt(dt.Rows.Count - 1)
            ReDim ReadSCPen(dt.Rows.Count - 1)
            ReDim readTP(dt.Rows.Count - 1)
            ReDim readStandPipe(dt.Rows.Count - 1)

            ReDim readFConsump(dt.Rows.Count - 1)
            ReDim readSConsump(dt.Rows.Count - 1)
            ReDim readFExcess(dt.Rows.Count - 1)
            ReDim readSExcess(dt.Rows.Count - 1)
            ReDim readFLabel(dt.Rows.Count - 1)
            ReDim readSLabel(dt.Rows.Count - 1)
            ReDim readFRateCub(dt.Rows.Count - 1)
            ReDim readSRateCub(dt.Rows.Count - 1)
            ReDim readRemOverpayment(dt.Rows.Count - 1)

            ReDim readTotalAmount(dt.Rows.Count - 1)
            ReDim readTotalADue(dt.Rows.Count - 1)
            'Threading.Thread.Sleep(1000)
            'lblLoad.Text = "Loading Account Details"
            For x As Integer = 0 To dt.Rows.Count - 1
                readAcctID(x) = Val(dt.Rows(x).Item(0))
                readAcctNo(x) = dt.Rows(x).Item(1).ToString
                readAcctName(x) = dt.Rows(x).Item(2).ToString
                readAddress(x) = dt.Rows(x).Item(3).ToString
                readPrevRead(x) = Val(dt.Rows(x).Item(4))
                readPresRead(x) = Val(dt.Rows(x).Item(4))
                readConsump(x) = readPresRead(x) - readPrevRead(x)
                readClassID(x) = Val(dt.Rows(x).Item(5))
                readClassification(x) = dt.Rows(x).Item(6).ToString
                readIsSC(x) = dt.Rows(x).Item(7).ToString
                readBrgy(x) = dt.Rows(x).Item(8).ToString
                readConsID(x) = Val(dt.Rows(x).Item(9).ToString)
                readSequence(x) = Val(dt.Rows(x).Item(10).ToString)
                readZoneID(x) = Val(dt.Rows(x).Item(11).ToString)
                readClusterID(x) = Val(dt.Rows(x).Item(12).ToString)
                readBrgyID(x) = Val(dt.Rows(x).Item(13).ToString)
                readConDate(x) = dt.Rows(x).Item(14)
                readStandPipe(x) = dt.Rows(x).Item(15)
                If loadAutosaveOpt = False Then
                    CreateAutosaver(readBrgyID(x), readAcctID(x), loggedUserID, readPrevRead(x), readClusterID(x))
                End If
                prb.Value = x + 1
            Next

            prb.Value = 0
            For M As Integer = 0 To dt.Rows.Count - 1
                readAppFee(M) = getRemAppFee(readAcctID(M))
                prb.Value = M + 1
            Next

            prb.Value = 0
            'Threading.Thread.Sleep(1000)
            'lblLoad.Text = "Loading Class Rates"
            For j As Integer = 0 To dt.Rows.Count - 1
                Cons()
                Dim dtClass As New DataTable
                Dim daClass As New MySqlDataAdapter("SELECT * FROM tblclassrates WHERE classID=" & readClassID(j) & " AND IsMin=1", con)
                daClass.Fill(dtClass)
                If dtClass.Rows.Count > 0 Then
                    readMaxAmt(j) = Val(dtClass.Rows(0).Item(2))
                    readMaxCons(j) = Val(dtClass.Rows(0).Item(4))
                End If
                prb.Value = j + 1
            Next
            prb.Value = 0
            'Threading.Thread.Sleep(1000)
            'lblLoad.Text = "Loading Previous Balance"
            For z As Integer = 0 To dt.Rows.Count - 1

                readPrevBal(z) = 0
                readPrevConsump(z) = 0
                readPrevEnv(z) = 0
                readPrevAdj(z) = 0
                readPrevAdjRate(z) = 0
                readPrevPen(z) = 0
                readPrevAmountDue(z) = 0
                readPrevTotal(z) = 0
                readPrevSCDis(z) = 0
                readOverpayment(z) = 0
                readBillCounter(z) = 0
                Dim dtG As New DataTable
                Dim daG As New MySqlDataAdapter("SELECT useADue, consump, EnviFee, adjusted, adjustedRate, penalty, useAmount, useAdue, SCDiscount, prevOutstanding, prevOutPenalty, prevOutEF, prevOutDiscount FROM billing WHERE billStat='UNPAID' AND acctID=" & readAcctID(z), con)
                daG.Fill(dtG)
                If dtG.Rows.Count > 0 Then
                    readBillCounter(z) = dt.Rows.Count
                    For i As Integer = 0 To dtG.Rows.Count - 1
                        readPrevBal(z) = readPrevBal(z) + Val(dtG.Rows(i).Item(0).ToString) + Val(dtG.Rows(i).Item(9).ToString)
                        readPrevConsump(z) = readPrevConsump(z) + Val(dtG.Rows(i).Item(1).ToString)
                        readPrevEnv(z) = readPrevEnv(z) + Val(dtG.Rows(i).Item(2).ToString) + Val(dtG.Rows(i).Item(11).ToString)
                        readPrevAdj(z) = readPrevAdj(z) + Val(dtG.Rows(i).Item(3).ToString)
                        readPrevAdjRate(z) = readPrevAdjRate(z) + Val(dtG.Rows(i).Item(4).ToString)
                        readPrevPen(z) = readPrevPen(z) + Val(dtG.Rows(i).Item(5).ToString) + Val(dtG.Rows(i).Item(10).ToString)
                        readPrevAmountDue(z) = readPrevAmountDue(z) + Val(dtG.Rows(i).Item(6).ToString) + Val(dtG.Rows(i).Item(9).ToString) - Val(dtG.Rows(i).Item(10).ToString)
                        readPrevTotal(z) = readPrevTotal(z) + Val(dtG.Rows(i).Item(7).ToString) + Val(dtG.Rows(i).Item(9).ToString)
                        readPrevSCDis(z) = readPrevSCDis(z) + Val(dtG.Rows(i).Item(8).ToString) + Val(dtG.Rows(i).Item(12).ToString)

                    Next
                End If
                Dim dtOver As New DataTable
                Dim daOver As New MySqlDataAdapter("SELECT balamt FROM tbloverpayment WHERE acctID=" & readAcctID(z), con)
                daOver.Fill(dtOver)
                If dtOver.Rows.Count > 0 Then
                    readOverpayment(z) = Val(dtOver(0).Item(0).ToString)
                Else
                    readOverpayment(z) = 0
                End If

                prb.Value = z + 1
            Next
            prb.Value = 0
            For K As Integer = 0 To dt.Rows.Count - 1
                readInitialAmount(K) = CalculateRate(readClassID(K), Val(readConsump(K)))
                'ReaderComputation(K, readConsump(K), readAmount(K), readMaxAmt(K), readMaxCons(K), readIsSC(K))
                mComputation(K, readConsump(K), readInitialAmount(K), readIsSC(K), readOverpayment(K), readConDate(K))
                'BillLabels(readClassID(K), K, readConsump(K))
                prb.Value = K + 1
                'lblLoad.Text = "Preparing Computations"
            Next

            prb.Value = 0
            For y As Integer = 0 To dt.Rows.Count - 1
                dgvReading.Rows.Add(readStandPipe(y), readAcctNo(y), readAcctName(y), readClassification(y), If(readIsSC(y) = "YES", "Senior/PWD", "Regular"), readPrevRead(y), readPresRead(y), readConsump(y), Format(readAmount(y) - readEF(y), "#,##0.#0"), Format(readEF(y), "#,##0.#0"), Format(readDiscount(y), "#,##0.#0"), Format(readTotal(y), "#,##0.#0"), Format(readAppFee(y), "#,##0.#0"), Format(readTotalAmount(y) + readAppFee(y), "#,##0.#0"), Format(readPenalty(y), "#,##0.#0"), Format(readTotalADue(y) + readAppFee(y), "#,##0.#0"), Format(readPrevBal(y), "#,##0.#0"), Format(readOverpayment(y), "#,##0.#0"))
                prb.Value = y + 1
                'lblLoad.Text = "Loading Values to Grid"
                dgvReading.Rows(y).Cells(4).Style.BackColor = Color.White
                dgvReading.Rows(y).Cells(5).Style.BackColor = Color.White
                dgvReading.Rows(y).Cells(6).Style.BackColor = Color.White
            Next
            If loadAutosaveOpt = True Then LoadAutosavedValues(loggedUserID)
        End If
    End Sub
    Private Function getRemAppFee(acctID As Integer) As Decimal
        Dim fee As Decimal
        Dim curBal As Decimal
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM applicationfeetotalbalance WHERE acctID=" & acctID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            curBal = Val(dt.Rows(0).Item(2).ToString)
            fee = curBal
        Else
            fee = 0
        End If
        Return fee
    End Function

    Private Function NewRateAmount(consump As Integer, classID As Integer) As Decimal
        Dim compRate As Decimal = 0
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblclassrates WHERE classID=" & classID, con)
        da.Fill(dt)
        Return compRate
    End Function



    Private Sub dgvReading_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReading.CellValueChanged
        If dgvReading.Rows.Count > 0 Then
            If e.ColumnIndex = 6 Or e.ColumnIndex = 5 Then
                readPrevRead(e.RowIndex) = CInt(dgvReading.Rows(e.RowIndex).Cells(5).Value)
                readPresRead(e.RowIndex) = CInt(dgvReading.Rows(e.RowIndex).Cells(6).Value)
                readConsump(e.RowIndex) = readPresRead(e.RowIndex) - readPrevRead(e.RowIndex)
                UpDateAutosaver(readBrgyID(e.RowIndex), readAcctID(e.RowIndex), loggedUserID, readPrevRead(e.RowIndex), readPresRead(e.RowIndex), readConsump(e.RowIndex), readClusterID(e.RowIndex))
                'readAmount(e.RowIndex) = DirectRate(Val(readConsump(e.RowIndex)), readClassID(e.RowIndex), 2)
                readAmount(e.RowIndex) = CalculateRate(readClassID(e.RowIndex), Val(readConsump(e.RowIndex)))
                'ReaderComputation(e.RowIndex, readConsump(e.RowIndex), readAmount(e.RowIndex), readMaxAmt(e.RowIndex), readMaxCons(e.RowIndex), readIsSC(e.RowIndex))
                mComputation(e.RowIndex, readConsump(e.RowIndex), readAmount(e.RowIndex), readIsSC(e.RowIndex), readOverpayment(e.RowIndex), readConDate(e.RowIndex))
                dgvReading.Rows(e.RowIndex).Cells(7).Value = readConsump(e.RowIndex)
                dgvReading.Rows(e.RowIndex).Cells(8).Value = Format(readAmount(e.RowIndex) - readEF(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(9).Value = Format(readEF(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(10).Value = Format(readDiscount(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(11).Value = Format(readTotalAmount(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(12).Value = Format(readAppFee(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(13).Value = Format(readTotalAmount(e.RowIndex) + readAppFee(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(14).Value = Format(readPenalty(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(15).Value = Format(readTotalADue(e.RowIndex) + readAppFee(e.RowIndex), "#,##0.#0")
                'BillLabels(readClassID(e.RowIndex), e.RowIndex, readConsump(e.RowIndex))
            ElseIf e.ColumnIndex = 4 Then
                Dim strType As String = dgvReading.Rows(e.RowIndex).Cells(4).Value.ToString
                If strType = "Regular" Then
                    readIsSC(e.RowIndex) = "NO"
                Else
                    readIsSC(e.RowIndex) = "YES"
                End If
                'ReaderComputation(e.RowIndex, readConsump(e.RowIndex), readAmount(e.RowIndex), readMaxAmt(e.RowIndex), readMaxCons(e.RowIndex), readIsSC(e.RowIndex))
                mComputation(e.RowIndex, readConsump(e.RowIndex), readAmount(e.RowIndex), readIsSC(e.RowIndex), readOverpayment(e.RowIndex), readConDate(e.RowIndex))
                dgvReading.Rows(e.RowIndex).Cells(7).Value = readConsump(e.RowIndex)
                dgvReading.Rows(e.RowIndex).Cells(8).Value = Format(readAmount(e.RowIndex) - readEF(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(9).Value = Format(readEF(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(10).Value = Format(readDiscount(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(11).Value = Format(readTotalAmount(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(12).Value = Format(readAppFee(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(13).Value = Format(readTotalAmount(e.RowIndex) + readAppFee(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(14).Value = Format(readPenalty(e.RowIndex), "#,##0.#0")
                dgvReading.Rows(e.RowIndex).Cells(15).Value = Format(readTotalADue(e.RowIndex) + readAppFee(e.RowIndex), "#,##0.#0")
                'BillLabels(readClassID(e.RowIndex), e.RowIndex, readConsump(e.RowIndex))
                'MessageBox.Show(readIsSC(e.RowIndex) & " " & e.RowIndex.ToString)
            End If
        End If

    End Sub

    Private Sub dgvReading_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReading.CellContentClick
        If dgvReading.Rows.Count > 0 Then

        End If
    End Sub

    Private Sub BillLabels(clID As Integer, i As Integer, consump As Integer)
        Dim excescon As Integer
        readFConsump(i) = 0
        readSConsump(i) = 0
        'readFExcess(i) = 0
        'readSExcess(i) = 0
        readFLabel(i) = ""
        readSLabel(i) = ""
        readFRateCub(i) = 0
        readSRateCub(i) = 0
        'dtRates.Select()
        Dim dt As New DataTable
        dt.Clear()
        If clID = 1 Then
            dt = dtResidentialRates
        ElseIf clID = 2 Then
            dt = dtInstitutionalRates
        ElseIf clID = 3 Then
            dt = dtGovernmentRates
        ElseIf clID = 4 Then
            dt = dtCommercialRates
        ElseIf clID = 5 Then
            dt = dtIndustrialRates
        End If
        'Dim da As New MySqlDataAdapter("SELECT * FROM tblclassrates WHERE classID=" & clID & " ORDER BY cubits", con)
        'da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim rCo As Integer = dt.Rows.Count
            If rCo = 3 Then
                Dim fN As Integer = Val(dt.Rows(1).Item(4).ToString)
                Dim lN As Integer = Val(dt.Rows(2).Item(4).ToString)
                readFLabel(i) = fN & " to " & (lN - 1)
                readSLabel(i) = lN & " and above"
                readFRateCub(i) = Val(dt.Rows(1).Item(2).ToString)
                readSRateCub(i) = Val(dt.Rows(2).Item(2).ToString)
                If consump > readMaxCons(i) Then
                    excescon = consump - readMaxCons(i)
                    If excescon > lN Then
                        readFConsump(i) = lN - fN
                        readSConsump(i) = excescon - readFConsump(i)
                        readFExcess(i) = readFConsump(i) * readFRateCub(i)
                        readSExcess(i) = readSConsump(i) * readSRateCub(i)
                    Else
                        readFConsump(i) = excescon
                        readSConsump(i) = 0
                        readFExcess(i) = readFConsump(i) * readFRateCub(i)
                        readSExcess(i) = 0
                    End If
                Else
                    excescon = 0
                    readFConsump(i) = 0
                    readSConsump(i) = 0
                    readFExcess(i) = 0
                    readSExcess(i) = 0
                End If
            ElseIf rCo = 2 Then
                Dim fN As Integer = Val(dt.Rows(1).Item(4).ToString)
                readFLabel(i) = fN & " and above"
                readSLabel(i) = ""
                readFRateCub(i) = Val(dt.Rows(1).Item(2).ToString)
                readSRateCub(i) = 0
                If consump > readMaxCons(i) Then
                    excescon = consump - readMaxCons(i)
                    readFConsump(i) = excescon
                    readSConsump(i) = 0
                    readFExcess(i) = readFConsump(i) * readFRateCub(i)
                    readSExcess(i) = 0
                Else
                    excescon = 0
                    readFConsump(i) = 0
                    readSConsump(i) = 0
                    readFExcess(i) = 0
                    readSExcess(i) = 0
                End If
            End If
        End If
    End Sub


    Private Sub ReaderComputation(i As Integer, C As Integer, A As Decimal, mA As Decimal, mC As Integer, isSC As String)
        If C <= mC Then
            readExcess(i) = 0
            readAdjustment(i) = 0
            readEF(i) = C
        Else
            readExcess(i) = A - mA
            readAdjustment(i) = (readExcess(i) - (C - mC)) * 0.1
            readEF(i) = C - ((C - mC) * 0.1)
        End If
        readBaseRate(i) = A
        readFlatRate(i) = mA
        readNR(i) = A - readEF(i)
        readAR(i) = readNR(i) - readAdjustment(i)
        readAdjusted(i) = readAR(i)
        readTotal(i) = readAR(i) + readEF(i)

        readPenalty(i) = (readNR(i) - readAdjustment(i)) * 0.1
        readTP(i) = (readTotal(i) + readPenalty(i))
        If C < 31 Then
            If isSC = "YES" Then
                If readClassID(i) = 1 Or readClassID(i) = 2 Then
                    readDiscount(i) = (A - readAdjustment(i) - readEF(i)) * 0.05
                    readSCAmt(i) = readTotal(i) - readDiscount(i)
                    ReadSCPen(i) = (readSCAmt(i) + readPenalty(i))
                Else
                    readDiscount(i) = 0
                    readSCAmt(i) = 0
                    ReadSCPen(i) = 0
                End If

            Else
                readDiscount(i) = 0
                readSCAmt(i) = 0
                ReadSCPen(i) = 0
            End If
        Else
            readDiscount(i) = 0
            readSCAmt(i) = 0
            ReadSCPen(i) = 0
        End If

        readTotalAmount(i) = readTotal(i) - readDiscount(i)
        readTotalADue(i) = readTotalAmount(i) + readPenalty(i)
    End Sub

    Private Sub mComputation(i As Integer, C As Integer, A As Decimal, isSC As String, overpay As Decimal, conDate As Date)
        'NEW COMPUTATION
        Dim nowDate As Date = Date.Now
        Dim dDif As Integer = DateDiff(DateInterval.Year, conDate, nowDate)
        'MessageBox.Show(dDif)
        Dim curReadAmount As Decimal = A
        Dim actualAmount As Decimal = A
        Dim tempReadAmount As Decimal = curReadAmount - overpay
        Dim remOverpay As Decimal = 0
        readRemOverpayment(i) = 0
        If tempReadAmount < 0 Then
            'readAmount(i) = 0
            remOverpay = overpay - curReadAmount
        Else
            'readAmount(i) = tempReadAmount
            remOverpay = 0
        End If
        readRemOverpayment(i) = remOverpay
        readConsump(i) = C

        readEF(i) = C
        readAmount(i) = curReadAmount
        'End If
        If tempReadAmount <= 100 Then
            readPenalty(i) = 0
        Else
            readPenalty(i) = actualAmount * 0.1
        End If

        'read(i) = (metAmt(i) + metP(i))
        If dDif > 0 Then
            If C < 31 Then
                If isSC = "YES" Then
                    'Dim mult As Decimal
                    'If C >= 0 And C <= 10 Then
                    '    mult = 0.2
                    'ElseIf C >= 11 And C <= 20 Then
                    '    mult = 0.1
                    'ElseIf C >= 21 And C <= 30 Then
                    '    mult = 0.05
                    'End If
                    readDiscount(i) = Format(DiscountBracket(C), "#.#0")
                    readSCAmt(i) = tempReadAmount - readDiscount(i)
                    ReadSCPen(i) = (readSCAmt(i) + readPenalty(i))
                Else
                    readDiscount(i) = 0
                    readSCAmt(i) = 0
                    ReadSCPen(i) = 0
                End If
            Else
                readDiscount(i) = 0
                readSCAmt(i) = 0
                ReadSCPen(i) = 0
            End If
        End If

        If tempReadAmount < 0 Then
            readTotal(i) = 0

        Else
            readTotal(i) = tempReadAmount - readDiscount(i)

        End If
        readTotalAmount(i) = readTotal(i)
        readTotalADue(i) = readTotalAmount(i) + readPenalty(i)
    End Sub
    Private Sub ComputeAmount()

    End Sub

    Private Function DiscountBracket(consump As Integer) As Decimal
        Dim disc As Decimal = 0
        Dim minCons As Integer = 0
        If consump <= 10 Then
            disc = 30
        ElseIf consump > 10 And consump <= 15 Then
            minCons = consump - 10
            disc = 30 + ((19 * minCons) * 0.1)
        ElseIf consump > 15 And consump <= 20 Then
            minCons = consump - 15
            disc = 39.5 + ((23 * minCons) * 0.1)
        ElseIf consump > 20 And consump <= 25 Then
            minCons = consump - 20
            disc = 51 + ((27 * minCons) * 0.05)
        ElseIf consump > 25 And consump <= 30 Then
            minCons = consump - 25
            disc = 57.75 + ((31 * minCons) * 0.05)
        ElseIf consump > 30 Then
            disc = 0
        End If

        Return disc
    End Function

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If CountAccounts > 0 Then
            If MessageBox.Show("Complete Reading?", "Preparing to Save Reading", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim dtDisc As New DataTable
                Dim daDisc As New MySqlDataAdapter("SELECT discNote FROM disconnectionnote WHERE discID=1", con)
                daDisc.Fill(dtDisc)
                disNote = dtDisc.Rows(0).Item(0).ToString
                prb.Maximum = CountAccounts
                prb.Value = 0
                For x As Integer = 0 To CountAccounts - 1
                    If dgvReading.Rows(x).Cells(17).Value = False Then
                        Dim getPrevAmtTotal As Decimal = readPrevBal(x)

                        Dim cmdB As New MySqlCommand("INSERT INTO billing(acctID, consID, classID, dueDate, fromDate, toDate, billMonth, billYear, prevRead, presRead, prevBal, prevPenalty, prevAmountDue, prevTotal, Consump, Amount, EnviFee, totalAmountDue, useAmount, useADue,Penalty, isSC, SCdiscount, SCPenalty, seqNum, isAdjusted, billStat, metReadID, billNote, UID, billPeriod, billDate, readDate, brgyID, applicationfee, adjRemark, overpayment, clusterID) VALUES(@aID, @cID, @clID, @dDate, @fDate, @tDate, @bMonth, @bYear, @pvRead, @psRead, @prBal, @prPenalty, @prADue, @prTotal, @Cons, @Amt, @EFee, @totAmountDue, @useA, @useAD, @Pen, @iSC, @SCdis, @SCPen, @sNum, @isAd, @bStat, @metID, @bNote, @UserID, @bPer, @bDate, @rDate, @bgID, @appfee, 'None', @opay, @clusID)", con)
                        cmdB.Parameters.AddWithValue("@aID", readAcctID(x))
                        cmdB.Parameters.AddWithValue("@cID", readConsID(x))
                        cmdB.Parameters.AddWithValue("@clID", readClassID(x))
                        cmdB.Parameters.AddWithValue("@dDate", dtpDueDate.Value)
                        cmdB.Parameters.AddWithValue("@fDate", dtpFrom.Value)
                        cmdB.Parameters.AddWithValue("@tDate", dtpTo.Value)
                        cmdB.Parameters.AddWithValue("@bMonth", cboMonthRead.Text)
                        cmdB.Parameters.AddWithValue("@bYear", cboYearRead.Text)
                        cmdB.Parameters.AddWithValue("@pvRead", readPrevRead(x))
                        cmdB.Parameters.AddWithValue("@psRead", readPresRead(x))
                        cmdB.Parameters.AddWithValue("@prBal", 0)
                        cmdB.Parameters.AddWithValue("@prPenalty", readPrevPen(x))
                        cmdB.Parameters.AddWithValue("@prADue", readPrevAmountDue(x))
                        cmdB.Parameters.AddWithValue("@prTotal", readPrevTotal(x))
                        cmdB.Parameters.AddWithValue("@Cons", readConsump(x))
                        cmdB.Parameters.AddWithValue("@Amt", readAmount(x))
                        cmdB.Parameters.AddWithValue("@EFee", readEF(x))
                        cmdB.Parameters.AddWithValue("@totAmountDue", readTotal(x))
                        cmdB.Parameters.AddWithValue("@useA", readTotalAmount(x))
                        cmdB.Parameters.AddWithValue("@useAD", readTotalADue(x))
                        cmdB.Parameters.AddWithValue("@Pen", readPenalty(x))
                        cmdB.Parameters.AddWithValue("@iSC", readIsSC(x))
                        cmdB.Parameters.AddWithValue("@SCdis", readDiscount(x))
                        cmdB.Parameters.AddWithValue("@SCPen", ReadSCPen(x))
                        cmdB.Parameters.AddWithValue("@sNum", readSequence(x))
                        cmdB.Parameters.AddWithValue("@isAd", "None")
                        cmdB.Parameters.AddWithValue("@bStat", "UNPAID")
                        cmdB.Parameters.AddWithValue("@metID", metID(cboReader.SelectedIndex))
                        'Dim getPrevAmtTotal As Double = arrPrevTotal(x) + billOutstandTotal(x)
                        If getPrevAmtTotal > 0 Then
                            If readBillCounter(x) >= 1 Then
                                cmdB.Parameters.AddWithValue("@bNote", disNote.Replace("$amt", getPrevAmtTotal).Replace("$dat", Format(dtpDisconnection.Value.Date, "MMMM dd, yyyy")))
                            Else
                                cmdB.Parameters.AddWithValue("@bNote", "")
                            End If
                        Else
                            cmdB.Parameters.AddWithValue("@bNote", "")
                        End If
                        cmdB.Parameters.AddWithValue("@UserID", loggedUserID)
                        cmdB.Parameters.AddWithValue("@bPer", billperiod)
                        cmdB.Parameters.AddWithValue("@bDate", dtpBillDate.Value)
                        cmdB.Parameters.AddWithValue("@rDate", dtpReadDate.Value)
                        'cmdB.Parameters.AddWithValue("@srate", readSCAmt(x))
                        cmdB.Parameters.AddWithValue("@bgID", readBrgyID(x))
                        cmdB.Parameters.AddWithValue("@appfee", readAppFee(x))
                        cmdB.Parameters.AddWithValue("@opay", readOverpayment(x))
                        cmdB.Parameters.AddWithValue("clusID", readClusterID(x))
                        cmdB.ExecuteNonQuery()
                        UpdateReference(readAcctID(x), readPresRead(x))
                        UpdateOverpayment(readAcctID(x), readRemOverpayment(x))
                        'Dim getPrevAmtTotal As Decimal = readPrevBal(x)
                        'Dim cmd As New MySqlCommand("INSERT INTO billing(acctID,consID,classID,dueDate,fromDate,toDate,billMonth,billYear,prevRead,presRead,prevBal,prevConsump,prevEnv,prevAdj,prevAdjustedRate,prevPenalty,prevAmountDue,prevTotal,consump,amount,flatRate,excess,adjusted,adjustedRate,EnviFee,totalAmountDue,useAmount,useADue,penalty,AmountADue,isSC,SCDiscount,SCPenalty,seqNum,isAdjusted,billStat,metReadID,billNote,uID,zoneID,clusterID,billPeriod,billDate,FConsump,SConsump,FExcess,SExcess,FLabel,SLabel,readDate,minConsump,FRatePerCub,SRatePerCub,prevSCDis,billNo,SCRate,BaseRate,brgyID,adjRemark) VALUES(@aID,@cID,@csID,@dDate,@fDate,@tDate,@bMonth,@bYear,@pvRead,@psRead,@pvBal,@pvConsump,@pvEnv,@pvAdj,@pvAdjRate,@pvPen,@pvAmtDue,@pvTot,@consp,@amt,@ftRate,@exc,@adj,@adjRate,@EFee,@totAmtDue,@useAmt,@useAmtDue,@pen,@AmtADue,@isSen,@SCDis,@SCPen,@sNum,@isAdj,@bStat,@metrID,@bNote,@useID,@zID,@clusID,@billPer,@bDate,@FCons,@SCons,@FExc,@SExc,@FLab,@SLab,@readDat,@minCons,@FRateCub,@SRateCub,@prevSCDiscount,@billNum,@SenRate,@BasRate,@brgID,'None')", con)
                        'cmd.Parameters.AddWithValue("@aID", readAcctID(x))
                        'cmd.Parameters.AddWithValue("@cID", readConsID(x))
                        'cmd.Parameters.AddWithValue("@csID", readClassID(x))
                        'cmd.Parameters.AddWithValue("@dDate", dtpDueDate.Value)
                        'cmd.Parameters.AddWithValue("@fDate", dtpFrom.Value)
                        'cmd.Parameters.AddWithValue("@tDate", dtpTo.Value)
                        'cmd.Parameters.AddWithValue("@bMonth", cboMonthRead.Text)
                        'cmd.Parameters.AddWithValue("@bYear", cboYearRead.Text)
                        'cmd.Parameters.AddWithValue("@pvRead", readPrevRead(x))
                        'cmd.Parameters.AddWithValue("@psRead", readPresRead(x))
                        'cmd.Parameters.AddWithValue("@pvBal", readPrevBal(x))
                        'cmd.Parameters.AddWithValue("@pvConsump", readPrevConsump(x))
                        'cmd.Parameters.AddWithValue("@pvEnv", readPrevEnv(x))
                        'cmd.Parameters.AddWithValue("@pvAdj", readPrevAdj(x))
                        'cmd.Parameters.AddWithValue("@pvAdjRate", readPrevAdjRate(x))
                        'cmd.Parameters.AddWithValue("@pvPen", readPrevPen(x))
                        'cmd.Parameters.AddWithValue("@pvAmtDue", readPrevAmountDue(x))
                        'cmd.Parameters.AddWithValue("@pvTot", readPrevTotal(x))
                        'cmd.Parameters.AddWithValue("@consp", readConsump(x))
                        'cmd.Parameters.AddWithValue("@amt", readAmount(x))
                        'cmd.Parameters.AddWithValue("@ftRate", readFlatRate(x))
                        'cmd.Parameters.AddWithValue("@exc", readExcess(x))
                        'cmd.Parameters.AddWithValue("@adj", readAdjustment(x))
                        'cmd.Parameters.AddWithValue("@adjRate", readAdjusted(x))
                        'cmd.Parameters.AddWithValue("@EFee", readEF(x))
                        'cmd.Parameters.AddWithValue("@totAmtDue", readTotal(x))
                        'cmd.Parameters.AddWithValue("@useAmt", readTotalAmount(x))
                        'cmd.Parameters.AddWithValue("@useAmtDue", readTotalADue(x))
                        'cmd.Parameters.AddWithValue("@pen", readPenalty(x))
                        'cmd.Parameters.AddWithValue("@AmtADue", readTP(x))
                        'cmd.Parameters.AddWithValue("@isSen", readIsSC(x))
                        'cmd.Parameters.AddWithValue("@SCDis", readDiscount(x))
                        'cmd.Parameters.AddWithValue("@SCPen", ReadSCPen(x))
                        'cmd.Parameters.AddWithValue("@sNum", readSequence(x))
                        'cmd.Parameters.AddWithValue("@isAdj", "None")
                        'cmd.Parameters.AddWithValue("@bStat", "UNPAID")
                        'cmd.Parameters.AddWithValue("@metrID", metID(cboReader.SelectedIndex))
                        'If readPrevBal(x) > 0 Then
                        '    cmd.Parameters.AddWithValue("@bNote", disNote.Replace("$amt", readPrevBal(x)).Replace("$dat", Format(discDate, "MMMM dd, yyyy")))
                        'Else
                        '    cmd.Parameters.AddWithValue("@bNote", "")
                        'End If
                        'cmd.Parameters.AddWithValue("@useID", loggedUserID)
                        'cmd.Parameters.AddWithValue("@zID", readZoneID(x))
                        'cmd.Parameters.AddWithValue("@clusID", readClusterID(x))
                        'cmd.Parameters.AddWithValue("@billPer", billperiod)
                        'cmd.Parameters.AddWithValue("@bDate", dtpBillDate.Value)
                        'cmd.Parameters.AddWithValue("@FCons", readFConsump(x))
                        'cmd.Parameters.AddWithValue("@SCons", readSConsump(x))
                        'cmd.Parameters.AddWithValue("@FExc", readFExcess(x))
                        'cmd.Parameters.AddWithValue("@SExc", readSExcess(x))
                        'cmd.Parameters.AddWithValue("@FLab", readFLabel(x))
                        'cmd.Parameters.AddWithValue("@SLab", readSLabel(x))
                        'cmd.Parameters.AddWithValue("@readDat", dtpReadDate.Value)
                        'cmd.Parameters.AddWithValue("@minCons", readMaxCons(x))
                        'cmd.Parameters.AddWithValue("@FRateCub", readFRateCub(x))
                        'cmd.Parameters.AddWithValue("@SRateCub", readSRateCub(x))
                        'cmd.Parameters.AddWithValue("@prevSCDiscount", readPrevSCDis(x))
                        'cmd.Parameters.AddWithValue("@billNum", getLatestBillNo())
                        'cmd.Parameters.AddWithValue("@SenRate", readSCAmt(x))
                        'cmd.Parameters.AddWithValue("@BasRate", readBaseRate(x))
                        'cmd.Parameters.AddWithValue("@brgID", readBrgyID(x))
                        'cmd.ExecuteNonQuery()
                        'prb.Value = x + 1
                    End If
                Next
                MessageBox.Show("Reading Finished", "Reading Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvReading.Rows.Clear()
                deleteAutosave(loggedUserID)
                metGenerated = False
                CountAccounts = 0
            End If
        End If

    End Sub
    Public Sub UpdateOverpayment(acctID As Integer, Amount As Decimal)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tbloverpayment WHERE acctID=" & acctID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim cmd As New MySqlCommand("UPDATE tbloverpayment SET balamt=" & Amount & " WHERE acctID=" & acctID, con)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Public Function CheckBillCount(acctID As Integer) As Integer
        Dim cCount As Integer = 0
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT count(*) as UnpaidBillCount FROM billing WHERE acctID=" & acctID & " AND billstat='UNPAID'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

        Else
            cCount = 0
        End If
        Return cCount
    End Function

    Private Sub UpdateReference(aID As Integer, reading As Integer)
        Cons()
        Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET meterreference=" & reading & " WHERE acctID=" & aID, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub cboMonthRead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonthRead.SelectedIndexChanged
        Try
            'SelectedMonth(cboMonthRead.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboYearRead.Text, cboMonthRead.SelectedIndex + 1)
            fDay = finalday

            Dim f As DateTime
            f = New DateTime(cboYearRead.Text, cboMonthRead.SelectedIndex + 1, 20)
            Dim i As Integer
            Dim y As Integer
            If cboMonthRead.SelectedIndex + 1 = 1 Then
                i = 12
                y = Val(cboYearRead.Text) - 1
            Else
                i = cboMonthRead.SelectedIndex
                y = Val(cboYearRead.Text)
            End If
            Dim d As DateTime
            d = New DateTime(y, i, 20)
            dtpFrom.Value = d
            dtpTo.Value = f
            setDueDate(f.Year, f.Month, f.Day)
            If metGenerated = True Then
                UpdateAutosaveMainDetails(loggedUserID, dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboReader.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SelectedMonth(i As Integer)
        'If i = 0 Then
        '    lblMonth.Text = "February"
        'ElseIf i = 1 Then
        '    lblMonth.Text = "March"
        'ElseIf i = 2 Then
        '    lblMonth.Text = "April"
        'ElseIf i = 3 Then
        '    lblMonth.Text = "May"
        'ElseIf i = 4 Then
        '    lblMonth.Text = "June"
        'ElseIf i = 5 Then
        '    lblMonth.Text = "July"
        'ElseIf i = 6 Then
        '    lblMonth.Text = "August"
        'ElseIf i = 7 Then
        '    lblMonth.Text = "September"
        'ElseIf i = 8 Then
        '    lblMonth.Text = "October"
        'ElseIf i = 9 Then
        '    lblMonth.Text = "November"
        'ElseIf i = 10 Then
        '    lblMonth.Text = "December"
        'ElseIf i = 11 Then
        '    lblMonth.Text = "January"
        'Else
        '    lblMonth.Text = ""
        'End If
    End Sub

    Private Sub cboYearRead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearRead.SelectedIndexChanged
        Try
            'SelectedMonth(cboMonthRead.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboYearRead.Text, cboMonthRead.SelectedIndex + 1)
            fDay = finalday

            Dim f As DateTime
            f = New DateTime(cboYearRead.Text, cboMonthRead.SelectedIndex + 1, 20)
            Dim i As Integer
            Dim y As Integer
            If cboMonthRead.SelectedIndex + 1 = 1 Then
                i = 12
                y = Val(cboYearRead.Text) - 1
            Else
                i = cboMonthRead.SelectedIndex
                y = Val(cboYearRead.Text)
            End If
            Dim d As DateTime
            d = New DateTime(y, i, 20)
            dtpFrom.Value = d
            dtpTo.Value = f
            setDueDate(f.Year, f.Month, f.Day)
            If metGenerated = True Then
                UpdateAutosaveMainDetails(loggedUserID, dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboReader.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadMonth()
        Dim monthInt As Integer = Now.Date.Month
        Dim yearInt As Integer = Now.Date.Year
        Dim newYearInt As Integer
        Dim newMonthInt As Integer
        If monthInt = 1 Then
            newMonthInt = 12
            newYearInt = yearInt - 1
        Else
            newMonthInt = monthInt - 1
            newYearInt = yearInt
        End If
        Dim curMonth As String = MonthName(newMonthInt)
        cboMonthRead.Text = curMonth
        cboYearRead.Text = newYearInt
    End Sub

    Public Function getLatestBillNo() As Integer
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT max(billNo) FROM billing", con)
        da.Fill(dt)
        Dim curNo As Integer = Val(dt.Rows(0).Item(0).ToString)
        Dim newNum As Integer = curNo + 1
        Return newNum
    End Function

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        For x As Integer = 0 To dgvReading.Rows.Count - 1
            dgvReading.Rows(x).Cells(18).Value = True
        Next
    End Sub

    Private Sub btnUnselect_Click(sender As Object, e As EventArgs) Handles btnUnselect.Click
        For x As Integer = 0 To dgvReading.Rows.Count - 1
            dgvReading.Rows(x).Cells(18).Value = False
        Next
    End Sub

    Private Sub dtpReadDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReadDate.ValueChanged
        If metGenerated = True Then
            UpdateAutosaveMainDetails(loggedUserID, dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboReader.Text)
        End If
    End Sub

    Private Sub dtpDueDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDueDate.ValueChanged
        If metGenerated = True Then
            UpdateAutosaveMainDetails(loggedUserID, dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboReader.Text)
        End If
    End Sub

    Private Sub dtpBillDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBillDate.ValueChanged
        If metGenerated = True Then
            UpdateAutosaveMainDetails(loggedUserID, dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboReader.Text)
        End If
    End Sub

    Private Sub cboReader_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReader.SelectedIndexChanged
        If metGenerated = True Then
            UpdateAutosaveMainDetails(loggedUserID, dtpReadDate.Value, dtpDueDate.Value, dtpBillDate.Value, cboMonthRead.Text, cboYearRead.Text, cboReader.Text)
        End If
    End Sub

    Private Sub setDueDate(y As Integer, m As Integer, d As Integer)
        Dim i As DateTime
        Dim j As DateTime

        i = New DateTime(y, m, d)
        j = New DateTime(y, m, 23)
        Dim n As DateTime
        n = i.AddDays(15)
        If n.DayOfWeek = DayOfWeek.Saturday Then
            n = n.AddDays(2)
        ElseIf n.DayOfWeek = DayOfWeek.Sunday Then
            n = n.AddDays(1)
        End If
        dtpDueDate.Value = n
        Dim dis As New DateTime
        dis = j.AddDays(6)
        If dis.DayOfWeek = DayOfWeek.Saturday Then
            dis = dis.AddDays(2)
        ElseIf dis.DayOfWeek = DayOfWeek.Sunday Then
            dis = dis.AddDays(1)
        End If
        dtpDisconnection.Value = dis

    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        setDueDate(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day)
    End Sub
End Class