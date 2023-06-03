Imports MySql.Data
Imports MySql.Data.MySqlClient
Module paymentModule
    Public lastInsertedPLID As Integer
    Public selectedConsIDPayment As Integer
    Public senRmk As String
    Public senIDPayment As String
    Public selPayAcctID As Integer
    Public selPayBillID As Integer
    Public lastPLID As Integer
    Public prevBalExisting As Integer
    Public paymentConsumerID As Integer
    Public latestMonth As String
    Public latestYear As String
    Public arrBillYear() As Integer
    Public arrBillMonth() As Integer
    Public latestBillDate As Date
    Public initialMonth As String
    Public initialYear As String
    Public billCount As Integer

    Public totPrevPen As Double
    Public totPrevEF As Double
    Public totPrevDis As Double
    Public startMonth As String
    Public startYear As Integer

    Public strRemMon As String
    Public Sub InsertToOR(ByVal ORNum As String, ByVal totPay As Double, ByVal pType As String, ByVal draweeBank As String, ByVal draweeNum As String, ByVal draweeDate As String, ByVal amtWords1 As String, ByVal amtWords2 As String, ByVal uID As Integer, ByVal paymentDate As Date, ByVal consID As Integer, ByVal seniorRemark As String, ByVal seniorID As String, ByVal totalDiscount As Double, ByVal nature1 As String, ByVal nature2 As String, ByVal nature3 As String, ByVal nature4 As String, ByVal nature5 As String, ByVal nature6 As String, ByVal nature7 As String, ByVal nature8 As String, ByVal code1 As String, ByVal code2 As String, ByVal code3 As String, ByVal code4 As String, ByVal code5 As String, ByVal code6 As String, ByVal code7 As String, ByVal code8 As String, ByVal amount1 As String, ByVal amount2 As String, ByVal amount3 As String, ByVal amount4 As String, ByVal amount5 As String, ByVal amount6 As String, ByVal amount7 As String, ByVal amount8 As String, ByVal collectorname As String, ByVal cashCheck As String, ByVal checkCheck As String, ByVal moneyOrderCheck As String, ByVal moneyOrdNum As String, ByVal moneyOrderDate As String, ByVal rmk As String, ByVal bilAmount As Double, ByVal adjustedAmt As Double, ByVal penAmt As Double, ByVal EFAmt As Double, ByVal applAmt As Double, ByVal recAmt As Double, ByVal tranAmt As Double, ByVal OverPay As Decimal, ByVal accID As Integer)
        Dim strPType As String = pType
        Dim strCheckDetails As String = ""
        Dim strMoneyOrderDetails As String = ""
        Dim strCheckValues As String = ""
        Dim strMoneyOrderValues As String = ""
        If strPType = "Cash" Then
            strCheckDetails = ""
            strMoneyOrderDetails = ""
            strCheckValues = ""
            strMoneyOrderValues = ""
        ElseIf strPType = "Check" Then
            strCheckDetails = "draweeBank, draweeNum, draweeDate,"
            strMoneyOrderDetails = ""
            strCheckValues = "@drawBank, @drawNum, @drawDate,"
            strMoneyOrderValues = ""
        ElseIf strPType = "Money Order" Then
            strCheckDetails = ""
            strMoneyOrderDetails = ",moneyordernum, moneyorderdate"
            strCheckValues = ""
            strMoneyOrderValues = ", @monnum, @mondate"
        End If
        Dim cmd As New MySqlCommand("INSERT INTO tblOR(ORNum, totalPayment, pType, " & strCheckDetails & " amountinwords, amountinwords2, uID, pDate, consID, seniorRmk, seniorID, totalDiscount, nature1, nature2, nature3, nature4, nature5, nature6, nature7, nature8, code1, code2, code3, code4, code5, code6, code7, code8, amount1, amount2, amount3, amount4, amount5, amount6, amount7, amount8, collectorname, cashcheck, checkcheck, moneyordercheck, orRemark, billAmount, adjustmentAmount, penaltyAmt, EFAmt, ApplicationFee, ReconnectionFee, TransferFee" & strMoneyOrderDetails & ", overpayment,acctID) values(@ORN, @totPayment, @pTyp, " & strCheckValues & " @amtinwords, @amtinwords2, @userID, @payDate, @cID, @senRmk, @senID, @totDiscount, @nat1, @nat2, @nat3, @nat4, @nat5, @nat6, @nat7, @nat8, @cod1, @cod2, @cod3, @cod4, @cod5, @cod6, @cod7, @cod8, @amt1, @amt2, @amt3, @amt4, @amt5, @amt6, @amt7, @amt8, @colname, @ccheck, @chcheck, @moncheck, @oRmk, @bAmount, @adjAmount, @penAmt, @EFAmount, @AppFee, @RecFee, @TransFee " & strMoneyOrderValues & ", @overpay,@acID)", con)
        cmd.Parameters.AddWithValue("@ORN", ORNum)
        cmd.Parameters.AddWithValue("@totPayment", totPay)
        cmd.Parameters.AddWithValue("@pTyp", pType)

        If strPType = "Check" Then
            cmd.Parameters.AddWithValue("@drawBank", draweeBank)
            cmd.Parameters.AddWithValue("@drawNum", draweeNum)
            cmd.Parameters.AddWithValue("@drawDate", draweeDate)
        End If
        cmd.Parameters.AddWithValue("@amtinwords", amtWords1)
        cmd.Parameters.AddWithValue("@amtinwords2", amtWords2)
        cmd.Parameters.AddWithValue("@userID", uID)
        cmd.Parameters.AddWithValue("@payDate", paymentDate)
        cmd.Parameters.AddWithValue("@cID", consID)
        cmd.Parameters.AddWithValue("@senRmk", seniorRemark)
        cmd.Parameters.AddWithValue("@senID", seniorID)
        cmd.Parameters.AddWithValue("@totDiscount", totalDiscount)
        cmd.Parameters.AddWithValue("@nat1", nature1)
        cmd.Parameters.AddWithValue("@nat2", nature2)
        cmd.Parameters.AddWithValue("@nat3", nature3)
        cmd.Parameters.AddWithValue("@nat4", nature4)
        cmd.Parameters.AddWithValue("@nat5", nature5)
        cmd.Parameters.AddWithValue("@nat6", nature6)
        cmd.Parameters.AddWithValue("@nat7", nature7)
        cmd.Parameters.AddWithValue("@nat8", nature8)
        cmd.Parameters.AddWithValue("@cod1", code1)
        cmd.Parameters.AddWithValue("@cod2", code2)
        cmd.Parameters.AddWithValue("@cod3", code3)
        cmd.Parameters.AddWithValue("@cod4", code4)
        cmd.Parameters.AddWithValue("@cod5", code5)
        cmd.Parameters.AddWithValue("@cod6", code6)
        cmd.Parameters.AddWithValue("@cod7", code7)
        cmd.Parameters.AddWithValue("@cod8", code8)
        cmd.Parameters.AddWithValue("@amt1", amount1)
        cmd.Parameters.AddWithValue("@amt2", amount2)
        cmd.Parameters.AddWithValue("@amt3", amount3)
        cmd.Parameters.AddWithValue("@amt4", amount4)
        cmd.Parameters.AddWithValue("@amt5", amount5)
        cmd.Parameters.AddWithValue("@amt6", amount6)
        cmd.Parameters.AddWithValue("@amt7", amount7)
        cmd.Parameters.AddWithValue("@amt8", amount8)
        cmd.Parameters.AddWithValue("@colname", collectorname)
        cmd.Parameters.AddWithValue("@ccheck", cashCheck)
        cmd.Parameters.AddWithValue("@chcheck", checkCheck)
        cmd.Parameters.AddWithValue("@moncheck", moneyOrderCheck)
        cmd.Parameters.AddWithValue("@oRmk", rmk)
        cmd.Parameters.AddWithValue("@bAmount", bilAmount)
        cmd.Parameters.AddWithValue("@adjAmount", adjustedAmt)
        cmd.Parameters.AddWithValue("@penAmt", penAmt)
        cmd.Parameters.AddWithValue("@EFAmount", EFAmt)
        cmd.Parameters.AddWithValue("@AppFee", applAmt)
        cmd.Parameters.AddWithValue("@RecFee", recAmt)
        cmd.Parameters.AddWithValue("@TransFee", tranAmt)

        If strPType = "Money Order" Then
            cmd.Parameters.AddWithValue("@monnum", moneyOrdNum)
            cmd.Parameters.AddWithValue("@mondate", moneyOrderDate)
        End If
        cmd.Parameters.AddWithValue("@overpay", OverPay)
        If accID > 0 Then
            cmd.Parameters.AddWithValue("@acID", accID)
        Else
            cmd.Parameters.AddWithValue("@acID", Nothing)
        End If

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub insertPayment(ByVal consID As Integer, ByVal ORNum As String, ByVal paymentAmount As Decimal, ByVal accountCode As String, ByVal colnature As String, ByVal remark As String, ByVal userID As Integer, ByVal paymentType As String, ByVal monthpayment As String, ByVal yearpayment As String, ByVal AccountID As Integer, ByVal billID As Integer, ByVal surcharge As Decimal, ByVal plID As Integer, ByVal envFee As Decimal, ByVal moneyAmount As Decimal, ByVal mChange As Decimal, ByVal paymentDate As DateTime, ByVal discount As Decimal, ByVal bAmount As Decimal)
        Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymentType,MonthOfPayment,YearofPayment,acctID,billID,surcharge,plID,enviFee,moneyAmount,mChange,paymentDate,discount,billAmount) values(@consumerID,@ORNum,@paymentAmount,@AccountCode,@collectnature,@rmk,@userID,@payType,@MonthPay,@YearPay,@accountID,@billingID,@surc,@payllogID,@envFee,@monAmt,@moneyChange,@pDate,@disc,@bAmt)", con)
        cmd.Parameters.AddWithValue("@consumerID", consID)
        cmd.Parameters.AddWithValue("@ORNum", ORNum)
        cmd.Parameters.AddWithValue("@paymentAmount", paymentAmount)
        cmd.Parameters.AddWithValue("@AccountCode", accountCode)
        cmd.Parameters.AddWithValue("@collectnature", colnature)
        cmd.Parameters.AddWithValue("@rmk", remark)
        cmd.Parameters.AddWithValue("@userID", userID)
        cmd.Parameters.AddWithValue("@payType", paymentType)
        cmd.Parameters.AddWithValue("@MonthPay", monthpayment)
        cmd.Parameters.AddWithValue("@YearPay", yearpayment)
        cmd.Parameters.AddWithValue("@accountID", AccountID)
        cmd.Parameters.AddWithValue("@billingID", billID)
        cmd.Parameters.AddWithValue("@surc", surcharge)
        cmd.Parameters.AddWithValue("@payllogID", plID)
        cmd.Parameters.AddWithValue("@envFee", envFee)
        cmd.Parameters.AddWithValue("@monAmt", moneyAmount)
        cmd.Parameters.AddWithValue("@moneyChange", mChange)
        cmd.Parameters.AddWithValue("@pDate", paymentDate)
        cmd.Parameters.AddWithValue("@disc", discount)
        cmd.Parameters.AddWithValue("@bAmt", bAmount)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub insertPaymentLog(ByVal consID As Integer, ByVal paymentType As String, ByVal paymentAmount As Decimal, ByVal monthpayment As String, ByVal yearpayment As String, ByVal datepayment As Date, ByVal accountID As Integer, ByVal enviFee As Decimal, ByVal ORNum As String, ByVal discount As Decimal, ByVal penalty As Decimal)
        Dim pType As String = ""
        If paymentType = "Water Bill" Then
            pType = ",billPayment"
        ElseIf paymentType = "Installation" Then
            pType = ",installpayment"
        ElseIf paymentType = "Meter" Then
            pType = ",MeterPayment"
        ElseIf paymentType = "Owner" Then
            pType = ",OwnerPayment"
        ElseIf paymentType = "Reconnect" Then
            pType = ",ReconnectPayment"
        ElseIf paymentType = "Service" Then
            pType = ",ServicePayment"
        ElseIf paymentType = "Advance" Then
            pType = ",AdvancePayment"
        ElseIf paymentType = "Other" Then
            pType = ",OtherPayment"
        End If
        Dim strQ As String = "INSERT INTO tblpaymentlogs(consID" & pType & " ,monthPayment,yearPayment,datepayment,acctID,enviFee,ORNum,discount) VALUES(@cID,@pAmt,@mPayment,@yPayment,@dpayment,@aID,@eFee,@ORN,@disc)"
        'MessageBox.Show(strQ)
        Dim cmd As New MySqlCommand(strQ, con)
        cmd.Parameters.AddWithValue("@cID", consID)
        cmd.Parameters.AddWithValue("@pAmt", paymentAmount)
        cmd.Parameters.AddWithValue("@mPayment", monthpayment)
        cmd.Parameters.AddWithValue("@yPayment", yearpayment)
        cmd.Parameters.AddWithValue("@dpayment", datepayment)
        cmd.Parameters.AddWithValue("@aID", accountID)
        cmd.Parameters.AddWithValue("@eFee", enviFee)
        cmd.Parameters.AddWithValue("@ORN", ORNum)
        cmd.Parameters.AddWithValue("@disc", discount)
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT max(last_insert_id(plID)) FROM tblpaymentlogs", con)
        da.Fill(dt)
        lastPLID = Val(dt.Rows(0).Item(0))
    End Sub

    Public Sub insertDailyTransact(ByVal consID As Integer, ByVal acctID As Integer, ByVal ORNum As String, ByVal PerCovered As String, ByVal collection As String)

    End Sub


End Module
