Module WaterPaymentModule
    'Public arrPDbillID() As Integer
    Public paymentBillID() As Integer
    Public paymentAccountNo() As String
    Public paymentAcctID() As Integer
    Public paymentbillNo() As Integer
    Public arrPDbillPeriod() As String
    Public arrPDDueDate() As Date
    Public arrPDReadDate() As Date
    Public arrPDBillDate() As Date
    Public arrPDPrevRead() As Integer
    Public arrPDPresRead() As Integer
    Public arrPDConsump() As Integer
    Public arrPDAmount() As Decimal
    Public arrPDWSF() As Decimal
    'Public arrPDBRate() As Double
    Public arrPDEnFee() As Decimal
    'Public arrPDAdj() As Double
    'Public arrPDAdjRate() As Double
    Public arrPDInstallment() As Decimal
    Public arrPDTotAmt() As Decimal
    Public arrPDPen() As Decimal
    Public arrPDSCDis() As Decimal
    'Public arrPDSCRate() As Double
    Public arrPDAmtADue() As Decimal
    'Public arrPDSCPen() As Double
    Public arrPDReq() As Decimal
    Public arrPRDMetID() As Integer
    Public arrPDMetName() As String

    'Public arrPaymentType() As String
    Public arrOtherFees() As Decimal
    Public pubBillCount As Integer
    Public arrOverpay() As Decimal

    Public arrAcctPaymentID() As Integer
    Public arrConsPaymentID() As Integer

    'ARRAY PREVIOUS
    Public arrPDPrevPenalty() As Decimal
    Public arrPDPrevEF() As Decimal
    Public arrPDPrevDiscount() As Decimal
    Public arrPDPrevAmount() As Decimal
    Public arrPrevBal() As Decimal
    Public arrPDPrevMonths() As String
    Public arrInstallmentAmount() As Decimal
    Public arrInstallmentCount() As Integer
    'Public arrPDPrevYear() As String
    Public waterbillpaymentaccountIDSelected As Integer


    Public totalWaterBill As Decimal
    Public totalWSF As Decimal
    Public totalAjustedRate As Decimal
    Public totalEnvi As Decimal
    Public totalDiscount As Decimal
    Public totalPenalty As Decimal
    Public totalReqPayment As Decimal
    Public totalInstallment As Decimal
    Public totalOverpayment As Decimal
    Public totalApplication As Decimal
    Public totalOthers As Decimal
    Public paymentORNum As String
    Public paymentConName As String
    Public paymentConID As Integer
    Public changeAmt As Decimal
    Public moneyAmount As Decimal
    Public totalPrevBal As Decimal
    Public totalBulk As Decimal


    Public paymentPeriod As String
    Public paymentType As String
    Public paymentAmount As Double
    Public paymentChange As Double
    Public draweeBank As String
    Public draweeNum As String
    Public draweeDate As String
    Public arrMeterReaderID() As Integer
    Public arrMeterReaderName() As String
    Public acctAddress As String
    Public paymentDate As DateTime
    Public payAddress As String
    Public payYearF As Integer
    Public payYearT As Integer
    Public payyearFinal1 As Integer
    Public payyearFinal2 As Integer
    Public amountWords As String

    Public totalPrevToPay As Double
    Public totalPrevAmtPay As Double 'amount of payment to previous balance
    Public prevBalBillID As Integer
    Public totalAdjustmentBill As Double



End Module
