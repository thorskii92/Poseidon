Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Math
Module modRatesCalculator
    Public rcBillID() As Integer
    Public rcAcctID() As Integer
    Public rcConsID() As Integer
    Public rcClassID() As Integer
    Public rcBrgyID() As Integer
    Public rcAccountNo() As String
    Public rcAccountName() As String
    Public rcClassification() As String
    Public rcType() As String
    Public rcSAddress() As String
    Public rcBrgy() As String
    Public rcReadDate() As Date
    Public rcBillDate() As Date
    Public rcDueDate() As Date
    Public rcFromDate() As Date
    Public rcToDate() As Date
    Public rcBillMonth() As String
    Public rcBillYear() As Integer
    Public rcPrevRead() As Integer
    Public rcPresRead() As Integer
    Public rcConsump() As Integer
    Public rcWSF() As Decimal
    Public rcEF() As Decimal
    Public rcDis() As Decimal
    Public rcAmount() As Decimal
    Public rcPenalty() As Decimal
    Public rcTotalAmount() As Decimal
    Public rcPrevAmount() As Decimal
    Public rcPrevPenalty() As Decimal
    Public rcPrevTotal() As Decimal
    Public rcPeriod() As String
    Public rcOverpay() As Decimal

    Public Sub DeclareRCVars(i As Integer)
        ReDim rcBillID(i)
        ReDim rcAcctID(i)
        ReDim rcConsID(i)
        ReDim rcClassID(i)
        ReDim rcBrgyID(i)
        ReDim rcAccountNo(i)
        ReDim rcAccountName(i)
        ReDim rcClassification(i)
        ReDim rcType(i)
        ReDim rcSAddress(i)
        ReDim rcBrgy(i)
        ReDim rcReadDate(i)
        ReDim rcBillDate(i)
        ReDim rcDueDate(i)
        ReDim rcFromDate(i)
        ReDim rcToDate(i)
        ReDim rcBillMonth(i)
        ReDim rcBillYear(i)
        ReDim rcPrevRead(i)
        ReDim rcPresRead(i)
        ReDim rcConsump(i)
        ReDim rcWSF(i)
        ReDim rcEF(i)
        ReDim rcDis(i)
        ReDim rcAmount(i)
        ReDim rcPenalty(i)
        ReDim rcTotalAmount(i)
        ReDim rcPrevAmount(i)
        ReDim rcPrevPenalty(i)
        ReDim rcPrevTotal(i)
        ReDim rcPeriod(i)
        ReDim rcOverpay(i)
    End Sub

    Public Function MultipleBillDataTable(queryFilter As String) As DataTable
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, B.acctID, B.consID, B.classID, B.brgyID, A.AccountNo, A.AccountName, C.classification, B.isSC, A.StreetAddress, R.AddBrgy, B.readDate, B.billDate, B.dueDate, B.fromDate, B.toDate, B.billMonth, B.billYear, B.prevRead, B.presRead, B.consump, B.amount, B.EnviFee, B.SCDiscount, B.totalAmountDue, B.useAmount, B.penalty, B.AmountADue, B.useADue, B.prevAmountDue, B.prevPenalty, B.prevTotal, B.overpayment FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS C ON B.classID=C.classID LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID " & queryFilter, con)
        da.Fill(dt)
        Return dt
    End Function


    Public Sub ComputeRate(i As Integer, consump As Integer, classID As Integer, isSC As String, overpay As Decimal)
        Dim curReadAmount As Decimal = getAmount(consump, classID)
        Dim tempReadAmount As Decimal = curReadAmount - overpay
        'Dim remOverpay As Decimal = 0
        'readRemOverpayment(i) = 0
        'If tempReadAmount < 0 Then
        '    'readAmount(i) = 0
        '    remOverpay = overpay - curReadAmount
        'Else
        '    'readAmount(i) = tempReadAmount
        '    remOverpay = 0
        'End If
        'readRemOverpayment(i) = remOverpay
        'readConsump(i) = C
        'readEF(i) = C
        'readAmount(i) = curReadAmount
        ''End If
        'If tempReadAmount <= 100 Then
        '    readPenalty(i) = 0
        'Else
        '    readPenalty(i) = (tempReadAmount + readPrevBal(i)) * 0.1
        'End If

        ''read(i) = (metAmt(i) + metP(i))
        'If C < 31 Then
        '    If isSC = "YES" Then
        '        readDiscount(i) = Format((tempReadAmount * 0.05), "#.#0")
        '        readSCAmt(i) = tempReadAmount - readDiscount(i)
        '        ReadSCPen(i) = (readSCAmt(i) + readPenalty(i))
        '    Else
        '        readDiscount(i) = 0
        '        readSCAmt(i) = 0
        '        ReadSCPen(i) = 0
        '    End If
        'Else
        '    readDiscount(i) = 0
        '    readSCAmt(i) = 0
        '    ReadSCPen(i) = 0
        'End If
        'If tempReadAmount < 0 Then
        '    readTotal(i) = 0

        'Else
        '    readTotal(i) = tempReadAmount - readDiscount(i)

        'End If
        'readTotalAmount(i) = readTotal(i)
        'readTotalADue(i) = readTotalAmount(i) + readPenalty(i)
    End Sub

    Private Function getAmount(consump As Integer, classID As Integer) As Decimal
        Dim cAmount As Decimal = 0
        If classID = 1 Then
            If consump < 11 Then
                cAmount = 150
            ElseIf consump > 10 And consump < 16 Then
                cAmount = 150 + ((consump - 10) * 20)
            ElseIf consump > 15 And consump < 21 Then
                cAmount = 250 + ((consump - 15) * 23)
            ElseIf consump > 20 And consump < 26 Then
                cAmount = 365 + ((consump - 20) * 27)
            ElseIf consump > 25 And consump < 31 Then
                cAmount = 500 + ((consump - 25) * 32)
            ElseIf consump > 30 Then
                cAmount = 660 + ((consump - 30) * 38)
            End If
        ElseIf classID = 2 Then
            If consump < 11 Then
                cAmount = 150
            ElseIf consump > 10 And consump < 16 Then
                cAmount = 150 + ((consump - 10) * 20)
            ElseIf consump > 15 And consump < 21 Then
                cAmount = 250 + ((consump - 15) * 23)
            ElseIf consump > 20 And consump < 26 Then
                cAmount = 365 + ((consump - 20) * 27)
            ElseIf consump > 25 And consump < 31 Then
                cAmount = 500 + ((consump - 25) * 32)
            ElseIf consump > 30 Then
                cAmount = 660 + ((consump - 30) * 38)
            End If
        ElseIf classID = 3 Then
            If consump < 11 Then
                cAmount = 150
            ElseIf consump > 10 And consump < 16 Then
                cAmount = 150 + ((consump - 10) * 20)
            ElseIf consump > 15 And consump < 21 Then
                cAmount = 250 + ((consump - 15) * 23)
            ElseIf consump > 20 And consump < 26 Then
                cAmount = 365 + ((consump - 20) * 27)
            ElseIf consump > 25 And consump < 31 Then
                cAmount = 500 + ((consump - 25) * 32)
            ElseIf consump > 30 Then
                cAmount = 660 + ((consump - 30) * 38)
            End If
        ElseIf classID = 4 Then
            If consump < 11 Then
                cAmount = 250
            ElseIf consump > 10 And consump < 21 Then
                cAmount = 250 + ((consump - 10) * 27)
            ElseIf consump > 20 And consump < 31 Then
                cAmount = 520 + ((consump - 20) * 32)
            ElseIf consump > 30 Then
                cAmount = 840 + ((consump - 30) * 38)
            End If
        ElseIf classID = 5 Then
            If consump < 11 Then
                cAmount = 250
            ElseIf consump > 10 Then
                cAmount = 250 + ((consump - 10) * 32)
            End If
        ElseIf classID = 6 Then
            cAmount = 200
        Else
            cAmount = 0
        End If
        Return cAmount
    End Function

End Module
