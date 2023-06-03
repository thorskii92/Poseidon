Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmMonthlyReportDataGridViewer
    Dim RowHeader(21) As String
    Dim cJanuary(21) As Decimal
    Dim cFebruary(21) As Decimal
    Dim cMarch(21) As Decimal
    Dim cApril(21) As Decimal
    Dim cMay(21) As Decimal
    Dim cJune(21) As Decimal
    Dim cJuly(21) As Decimal
    Dim cAugust(21) As Decimal
    Dim cSeptember(21) As Decimal
    Dim cOctober(21) As Decimal
    Dim cNovember(21) As Decimal
    Dim cDecember(21) As Decimal

    Dim cMon() As String
    Dim pMon() As String
    Dim colRem() As String
    Dim cClass() As Integer
    Dim cConsump() As Integer
    Dim countRes As Integer
    Dim countIns As Integer
    Dim countGov As Integer
    Dim countCom As Integer
    Dim countInd As Integer

    Dim consumpRes As Integer
    Dim consumpIns As Integer
    Dim consumpGov As Integer
    Dim consumpCom As Integer
    Dim consumpInd As Integer
    Dim aveConsump As Decimal
    Private Sub frmMonthlyReportDataGridViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadYear()
    End Sub

    Private Sub LoadYear()
        cboYear.Items.Clear()
        For x As Integer = 2019 To Now.Year
            cboYear.Items.Add(x)
        Next
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If cboYear.Text = "" Then
            MessageBox.Show("Please select a year", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            RowHeader(0) = "Consumption Billings"
            RowHeader(1) = "Connection Fee"
            RowHeader(2) = "Penalty"
            RowHeader(3) = "Discount"
            RowHeader(4) = "Environmental Fee"
            RowHeader(5) = "Revenue"
            RowHeader(6) = "Bills Collected"
            RowHeader(7) = "Connection Fee"
            RowHeader(8) = "Penalties"
            RowHeader(9) = "Environmental Fee"
            RowHeader(10) = "Discount"
            RowHeader(11) = "Reconnection Fee"
            RowHeader(12) = "Meter Transfer Fee"
            RowHeader(13) = "Owner Transfer Fee"
            RowHeader(14) = "Cash Receipts"
            RowHeader(15) = "Collection Efficiency"
            RowHeader(16) = "Average Water Consumption/Client (Residential)"
            RowHeader(17) = "Average Billing/Client (Amount)"
            RowHeader(18) = "Average Billing/Client (w/ Penalty)"
            RowHeader(19) = "% Revenue Growth"
            RowHeader(20) = "Existing"
            RowHeader(21) = "Actual Collected"
            'countRes = 0
            'countIns = 0
            'countGov = 0
            'countCom = 0
            'countInd = 0

            'consumpRes = 0
            'consumpIns = 0
            'consumpGov = 0
            'consumpCom = 0
            'consumpInd = 0
            'aveConsump = 0
            For y As Integer = 0 To 21
                'RowHeader(y) = 0
                cJanuary(y) = 0
                cFebruary(y) = 0
                cMarch(y) = 0
                cApril(y) = 0
                cMay(y) = 0
                cJune(y) = 0
                cJuly(y) = 0
                cAugust(y) = 0
                cSeptember(y) = 0
                cOctober(y) = 0
                cNovember(y) = 0
                cDecember(y) = 0
            Next

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT billMonth, billyear, amount, applicationfee, penalty, scdiscount, envifee, consump, classid FROM billing where billyear=" & cboYear.Text, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ReDim cMon(dt.Rows.Count - 1)
                'ReDim cClass(dt.Rows.Count - 1)
                'ReDim cConsump(dt.Rows.Count - 1)
                For x As Integer = 0 To dt.Rows.Count - 1
                    cMon(x) = dt.Rows(x).Item(0).ToString
                    'cClass(x) = Val(dt.Rows(x).Item(8).ToString)
                    'cConsump(x) = Val(dt.Rows(x).Item(7).ToString)
                    'If cClass(x) = 1 Then
                    '    countRes = countRes + 1
                    '    consumpRes = consumpRes + cConsump(x)
                    'ElseIf cClass(x) = 2 Then
                    '    countIns = countIns + 1
                    '    consumpIns = consumpIns + cConsump(x)
                    'ElseIf cClass(x) = 3 Then
                    '    countGov = countGov + 1
                    '    consumpGov = consumpGov + cConsump(x)
                    'ElseIf cClass(x) = 4 Then
                    '    countCom = countCom + 1
                    '    consumpCom = consumpCom + cConsump(x)
                    'ElseIf cClass(x) = 5 Then
                    '    countInd = countInd + 1
                    '    consumpInd = consumpInd + cConsump(x)
                    'End If

                    If cMon(x) = "January" Then

                        cJanuary(20) = cJanuary(20) + 1
                        'Bills
                        cJanuary(0) = cJanuary(0) + Val(dt.Rows(x).Item(2))
                        cJanuary(1) = cJanuary(1) + Val(dt.Rows(x).Item(3).ToString)
                        cJanuary(2) = cJanuary(2) + Val(dt.Rows(x).Item(4).ToString)
                        cJanuary(3) = cJanuary(3) + Val(dt.Rows(x).Item(5).ToString)
                        cJanuary(4) = cJanuary(4) + Val(dt.Rows(x).Item(6).ToString)
                        cJanuary(5) = cJanuary(0) - cJanuary(3) - cJanuary(4)

                        'Collection
                    ElseIf cMon(x) = "Febuary" Then
                        cFebruary(20) = cFebruary(20) + 1
                        'Bills
                        cFebruary(0) = cFebruary(0) + Val(dt.Rows(x).Item(2))
                        cFebruary(1) = cFebruary(1) + Val(dt.Rows(x).Item(3).ToString)
                        cFebruary(2) = cFebruary(2) + Val(dt.Rows(x).Item(4).ToString)
                        cFebruary(3) = cFebruary(3) + Val(dt.Rows(x).Item(5).ToString)
                        cFebruary(4) = cFebruary(4) + Val(dt.Rows(x).Item(6).ToString)
                        cFebruary(5) = cFebruary(0) - cFebruary(3) - cFebruary(4)
                        'Collection
                    ElseIf cMon(x) = "March" Then
                        cMarch(20) = cMarch(20) + 1
                        'Bills
                        cMarch(0) = cMarch(0) + Val(dt.Rows(x).Item(2))
                        cMarch(1) = cMarch(1) + Val(dt.Rows(x).Item(3).ToString)
                        cMarch(2) = cMarch(2) + Val(dt.Rows(x).Item(4).ToString)
                        cMarch(3) = cMarch(3) + Val(dt.Rows(x).Item(5).ToString)
                        cMarch(4) = cMarch(4) + Val(dt.Rows(x).Item(6).ToString)
                        cMarch(5) = cMarch(0) - cMarch(4) - cMarch(3)
                        'Collection
                    ElseIf cMon(x) = "April" Then
                        cApril(20) = cApril(20) + 1
                        'Bills
                        cApril(0) = cApril(0) + Val(dt.Rows(x).Item(2))
                        cApril(1) = cApril(1) + Val(dt.Rows(x).Item(3).ToString)
                        cApril(2) = cApril(2) + Val(dt.Rows(x).Item(4).ToString)
                        cApril(3) = cApril(3) + Val(dt.Rows(x).Item(5).ToString)
                        cApril(4) = cApril(4) + Val(dt.Rows(x).Item(6).ToString)
                        cApril(5) = cApril(0) - cApril(4) - cApril(3)
                        'Collection
                    ElseIf cMon(x) = "May" Then
                        cMay(20) = cMay(20) + 1
                        'Bills
                        cMay(0) = cMay(0) + Val(dt.Rows(x).Item(2))
                        cMay(1) = cMay(1) + Val(dt.Rows(x).Item(3).ToString)
                        cMay(2) = cMay(2) + Val(dt.Rows(x).Item(4).ToString)
                        cMay(3) = cMay(3) + Val(dt.Rows(x).Item(5).ToString)
                        cMay(4) = cMay(4) + Val(dt.Rows(x).Item(6).ToString)
                        cMay(5) = cMay(0) - cMay(4) - cMay(3)

                        'Collection
                    ElseIf cMon(x) = "June" Then
                        cJune(20) = cJune(20) + 1
                        'Bills
                        cJune(0) = cJune(0) + Val(dt.Rows(x).Item(2))
                        cJune(1) = cJune(1) + Val(dt.Rows(x).Item(3).ToString)
                        cJune(2) = cJune(2) + Val(dt.Rows(x).Item(4).ToString)
                        cJune(3) = cJune(3) + Val(dt.Rows(x).Item(5).ToString)
                        cJune(4) = cJune(4) + Val(dt.Rows(x).Item(6).ToString)
                        cJune(5) = cJune(0) - cJune(4) - cJune(3)
                        'Collection
                    ElseIf cMon(x) = "July" Then
                        cJuly(20) = cJuly(20) + 1
                        'Bills
                        cJuly(0) = cJuly(0) + Val(dt.Rows(x).Item(2))
                        cJuly(1) = cJuly(1) + Val(dt.Rows(x).Item(3).ToString)
                        cJuly(2) = cJuly(2) + Val(dt.Rows(x).Item(4).ToString)
                        cJuly(3) = cJuly(3) + Val(dt.Rows(x).Item(5).ToString)
                        cJuly(4) = cJuly(4) + Val(dt.Rows(x).Item(6).ToString)
                        cJuly(5) = cJuly(0) - cJuly(4) - cJuly(3)
                        'Collection
                    ElseIf cMon(x) = "August" Then
                        cAugust(20) = cAugust(20) + 1
                        'Bills
                        cAugust(0) = cAugust(0) + Val(dt.Rows(x).Item(2))
                        cAugust(1) = cAugust(1) + Val(dt.Rows(x).Item(3).ToString)
                        cAugust(2) = cAugust(2) + Val(dt.Rows(x).Item(4).ToString)
                        cAugust(3) = cAugust(3) + Val(dt.Rows(x).Item(5).ToString)
                        cAugust(4) = cAugust(4) + Val(dt.Rows(x).Item(6).ToString)
                        cAugust(5) = cAugust(0) - cAugust(4) - cAugust(3)
                        'Collection
                    ElseIf cMon(x) = "September" Then
                        cSeptember(20) = cSeptember(20) + 1
                        'Bills
                        cSeptember(0) = cSeptember(0) + Val(dt.Rows(x).Item(2))
                        cSeptember(1) = cSeptember(1) + Val(dt.Rows(x).Item(3).ToString)
                        cSeptember(2) = cSeptember(2) + Val(dt.Rows(x).Item(4).ToString)
                        cSeptember(3) = cSeptember(3) + Val(dt.Rows(x).Item(5).ToString)
                        cSeptember(4) = cSeptember(4) + Val(dt.Rows(x).Item(6).ToString)
                        cSeptember(5) = cSeptember(0) - cSeptember(4) - cSeptember(3)
                        'Collection
                    ElseIf cMon(x) = "October" Then
                        cOctober(20) = cOctober(20) + 1
                        'Bills
                        cOctober(0) = cOctober(0) + Val(dt.Rows(x).Item(2))
                        cOctober(1) = cOctober(1) + Val(dt.Rows(x).Item(3).ToString)
                        cOctober(2) = cOctober(2) + Val(dt.Rows(x).Item(4).ToString)
                        cOctober(3) = cOctober(3) + Val(dt.Rows(x).Item(5).ToString)
                        cOctober(4) = cOctober(4) + Val(dt.Rows(x).Item(6).ToString)
                        cOctober(5) = cOctober(0) - cOctober(4) - cOctober(3)
                        'Collection
                    ElseIf cMon(x) = "November" Then
                        cNovember(20) = cNovember(20) + 1
                        'Bills
                        cNovember(0) = cNovember(0) + Val(dt.Rows(x).Item(2))
                        cNovember(1) = cNovember(1) + Val(dt.Rows(x).Item(3).ToString)
                        cNovember(2) = cNovember(2) + Val(dt.Rows(x).Item(4).ToString)
                        cNovember(3) = cNovember(3) + Val(dt.Rows(x).Item(5).ToString)
                        cNovember(4) = cNovember(4) + Val(dt.Rows(x).Item(6).ToString)
                        cNovember(5) = cNovember(0) - cNovember(4) - cNovember(3)
                        'Collection
                    ElseIf cMon(x) = "December" Then
                        cDecember(20) = cDecember(20) + 1
                        'Bills
                        cDecember(0) = cDecember(0) + Val(dt.Rows(x).Item(2))
                        cDecember(1) = cDecember(1) + Val(dt.Rows(x).Item(3).ToString)
                        cDecember(2) = cDecember(2) + Val(dt.Rows(x).Item(4).ToString)
                        cDecember(3) = cDecember(3) + Val(dt.Rows(x).Item(5).ToString)
                        cDecember(4) = cDecember(4) + Val(dt.Rows(x).Item(6).ToString)
                        cDecember(5) = cDecember(0) - cDecember(4) - cDecember(3)
                        'Collection
                    End If
                Next
            End If

            Dim dtP As New DataTable
            Dim daP As New MySqlDataAdapter("SELECT MonthOfPayment, yearofpayment, pamount, collectionnature, remark, surCharge, envifee, discount, billamount FROM tblpayment where yearofpayment=" & cboYear.Text, con)
            daP.Fill(dtP)
            If dtP.Rows.Count > 0 Then
                ReDim pMon(dtP.Rows.Count - 1)
                ReDim colRem(dtP.Rows.Count - 1)
                For i As Integer = 0 To dtP.Rows.Count - 1
                    pMon(i) = dtP.Rows(i).Item(0).ToString
                    colRem(i) = dtP.Rows(i).Item(4).ToString
                    If pMon(i) = "January" Then
                        cJanuary(20) = cJanuary(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cJanuary(6) = cJanuary(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cJanuary(8) = cJanuary(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cJanuary(9) = cJanuary(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cJanuary(10) = cJanuary(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cJanuary(7) = cJanuary(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cJanuary(11) = cJanuary(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cJanuary(13) = cJanuary(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cJanuary(12) = cJanuary(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cJanuary(21) = cJanuary(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "February" Then
                        cFebruary(20) = cFebruary(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cFebruary(6) = cFebruary(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cFebruary(8) = cFebruary(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cFebruary(9) = cFebruary(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cFebruary(10) = cFebruary(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cFebruary(7) = cFebruary(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cFebruary(11) = cFebruary(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cFebruary(13) = cFebruary(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cFebruary(12) = cFebruary(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cFebruary(21) = cFebruary(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "March" Then
                        cMarch(20) = cMarch(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cMarch(6) = cMarch(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cMarch(8) = cMarch(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cMarch(9) = cMarch(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cMarch(10) = cMarch(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cMarch(7) = cMarch(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cMarch(11) = cMarch(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cMarch(13) = cMarch(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cMarch(12) = cMarch(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cMarch(21) = cMarch(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "April" Then
                        cApril(20) = cApril(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cApril(6) = cApril(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cApril(8) = cApril(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cApril(9) = cApril(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cApril(10) = cApril(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cApril(7) = cApril(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cApril(11) = cApril(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cApril(13) = cApril(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cApril(12) = cApril(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cApril(21) = cApril(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "May" Then
                        cMay(20) = cMay(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cMay(6) = cMay(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cMay(8) = cMay(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cMay(9) = cMay(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cMay(10) = cMay(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cMay(7) = cMay(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cMay(11) = cMay(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cMay(13) = cMay(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cMay(12) = cMay(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cMay(21) = cMay(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "June" Then
                        cJune(20) = cJune(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cJune(6) = cJune(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cJune(8) = cJune(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cJune(9) = cJune(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cJune(10) = cJune(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cJune(7) = cJune(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cJune(11) = cJune(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cJune(13) = cJune(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cJune(12) = cJune(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cJune(21) = cJune(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "July" Then
                        cJuly(20) = cJuly(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cJuly(6) = cJuly(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cJuly(8) = cJuly(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cJuly(9) = cJuly(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cJuly(10) = cJuly(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cJuly(7) = cJuly(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cJuly(11) = cJuly(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cJuly(13) = cJuly(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cJuly(12) = cJuly(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cJuly(21) = cJuly(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "August" Then
                        cAugust(20) = cAugust(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cAugust(6) = cAugust(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cAugust(8) = cAugust(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cAugust(9) = cAugust(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cAugust(10) = cAugust(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cAugust(7) = cAugust(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cAugust(11) = cAugust(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cAugust(13) = cAugust(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cAugust(12) = cAugust(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cAugust(21) = cAugust(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "September" Then
                        cSeptember(20) = cSeptember(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cSeptember(6) = cSeptember(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cSeptember(8) = cSeptember(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cSeptember(9) = cSeptember(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cSeptember(10) = cSeptember(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cSeptember(7) = cSeptember(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cSeptember(11) = cSeptember(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cSeptember(13) = cSeptember(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cSeptember(12) = cSeptember(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cSeptember(21) = cSeptember(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "October" Then
                        cOctober(20) = cOctober(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cOctober(6) = cOctober(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cOctober(8) = cOctober(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cOctober(9) = cOctober(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cOctober(10) = cOctober(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cOctober(7) = cOctober(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cOctober(11) = cOctober(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cOctober(13) = cOctober(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cOctober(12) = cOctober(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cOctober(21) = cOctober(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "November" Then
                        cNovember(20) = cNovember(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cNovember(6) = cNovember(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cNovember(8) = cNovember(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cNovember(9) = cNovember(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cNovember(10) = cNovember(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cNovember(7) = cNovember(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cNovember(11) = cNovember(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cNovember(13) = cNovember(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cNovember(12) = cNovember(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cNovember(21) = cNovember(21) + Val(dtP.Rows(i).Item(2).ToString)

                    ElseIf pMon(i) = "December" Then
                        cDecember(20) = cDecember(20) + 1
                        If colRem(i) = "Current Bill" Or colRem(i) = "Prev Bill" Then
                            cDecember(6) = cDecember(6) + Val(dtP.Rows(i).Item(8).ToString)
                            cDecember(8) = cDecember(8) + Val(dtP.Rows(i).Item(5).ToString)
                            cDecember(9) = cDecember(9) + Val(dtP.Rows(i).Item(6).ToString)
                            cDecember(10) = cDecember(10) + Val(dtP.Rows(i).Item(7).ToString)
                        ElseIf colRem(i) = "Installation" Then
                            cDecember(7) = cDecember(7) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Reconnection" Then
                            cDecember(11) = cDecember(11) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Owner Transfer" Then
                            cDecember(13) = cDecember(13) + Val(dtP.Rows(i).Item(2).ToString)
                        ElseIf colRem(i) = "Meter Transfer" Then
                            cDecember(12) = cDecember(12) + Val(dtP.Rows(i).Item(2).ToString)
                        End If
                        cDecember(21) = cDecember(21) + Val(dtP.Rows(i).Item(2).ToString)

                    End If
                Next
            End If

            If cJanuary(20) > 0 Then
                cJanuary(15) = (cJanuary(21) / cJanuary(5)) * 100 'GET PREV YEAR REV DECEMBER
            End If
            If cFebruary(20) > 0 Then
                cFebruary(15) = (cFebruary(21) / cJanuary(5)) * 100
            End If
            If cMarch(20) > 0 Then
                Try
                    cMarch(15) = (cMarch(21) / cFebruary(5)) * 100
                Catch ex As Exception
                    cMarch(15) = 0
                End Try

            End If
            If cApril(20) > 0 Then
                cApril(15) = (cApril(21) / cMarch(5)) * 100
            End If
            If cMay(20) > 0 Then
                cMay(15) = (cMay(21) / cApril(5)) * 100
            End If
            If cJune(20) > 0 Then
                Try
                    cJune(15) = (cJune(21) / cMay(5)) * 100
                Catch ex As Exception
                    cJune(15) = 0
                End Try

            End If
            If cJuly(20) > 0 Then
                Try
                    cJuly(15) = (cJuly(21) / cJune(5)) * 100
                Catch ex As Exception
                    cJuly(15) = 0
                End Try
            End If
            If cAugust(20) > 0 Then
                cAugust(15) = (cAugust(21) / cJuly(5)) * 100
            End If
            If cSeptember(20) > 0 Then
                cSeptember(15) = (cSeptember(21) / cAugust(5)) * 100
            End If
            If cOctober(20) > 0 Then
                cOctober(15) = (cOctober(21) / cSeptember(5)) * 100
            End If
            If cNovember(20) > 0 Then
                cNovember(15) = (cNovember(21) / cOctober(5)) * 100
            End If
            If cDecember(20) > 0 Then
                cDecember(15) = (cDecember(21) / cNovember(5)) * 100
            End If

            dgvMRep.Rows.Clear()
            For z As Integer = 0 To 19
                If z = 3 Or z = 10 Then
                    dgvMRep.Rows.Add(RowHeader(z), "(" & Format(cJanuary(z), "#,##0.#0") & ")", "(" & Format(cFebruary(z), "#,##0.#0") & ")", "(" & Format(cMarch(z), "#,##0.#0") & ")", "(" & Format(cApril(z), "#,##0.#0") & ")", "(" & Format(cMay(z), "#,##0.#0") & ")", "(" & Format(cJune(z), "#,##0.#0") & ")", "(" & Format(cJuly(z), "#,##0.#0") & ")", "(" & Format(cAugust(z), "#,##0.#0") & ")", "(" & Format(cSeptember(z), "#,##0.#0") & ")", "(" & Format(cOctober(z), "#,##0.#0") & ")", "(" & Format(cNovember(z), "#,##0.#0") & ")", "(" & Format(cDecember(z), "#,##0.#0") & ")")
                ElseIf z = 15 Then
                    dgvMRep.Rows.Add(RowHeader(z), Format(cJanuary(z), "#,##0.#0") & " %", Format(cFebruary(z), "#,##0.#0") & " %", Format(cMarch(z), "#,##0.#0") & " %", Format(cApril(z), "#,##0.#0") & " %", Format(cMay(z), "#,##0.#0") & " %", Format(cJune(z), "#,##0.#0") & " %", Format(cJuly(z), "#,##0.#0") & " %", Format(cAugust(z), "#,##0.#0") & " %", Format(cSeptember(z), "#,##0.#0") & " %", Format(cOctober(z), "#,##0.#0") & " %", Format(cNovember(z), "#,##0.#0") & " %", Format(cDecember(z), "#,##0.#0") & " %")
                Else
                    dgvMRep.Rows.Add(RowHeader(z), Format(cJanuary(z), "#,##0.#0"), Format(cFebruary(z), "#,##0.#0"), Format(cMarch(z), "#,##0.#0"), Format(cApril(z), "#,##0.#0"), Format(cMay(z), "#,##0.#0"), Format(cJune(z), "#,##0.#0"), Format(cJuly(z), "#,##0.#0"), Format(cAugust(z), "#,##0.#0"), Format(cSeptember(z), "#,##0.#0"), Format(cOctober(z), "#,##0.#0"), Format(cNovember(z), "#,##0.#0"), Format(cDecember(z), "#,##0.#0"))
                End If

            Next
        End If

    End Sub
End Class