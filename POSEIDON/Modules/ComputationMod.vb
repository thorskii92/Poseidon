Module ComputationMod
    Public metCon() As Integer 'CONSUMPTION
    'Public metMaxA() As Decimal 'MAX AMOUNT
    'Public metMaxC() As Integer 'MAX CONSUMPTION
    Public metAmt() As Double 'AMOUNT
    Public metExcess() As Decimal 'EXCESS
    Public metNR() As Decimal 'NEW RATE
    Public metAdj() As Decimal 'ADJUSTMENT
    Public metAR() As Decimal 'ADJUSTED RATE
    Public metEF() As Decimal 'ENVI FEE
    Public metTot() As Decimal 'TOTAL
    Public metSC() As Decimal 'SC DISCOUNT
    Public metSCTot() As Decimal 'SCTOTAL
    Public metP() As Decimal 'PENALTY
    Public metTP() As Decimal 'TOTAL WITH PENALTY
    Public metTPSC() As Decimal 'SC WITH PENALTY
    Public metPrev() As Decimal
    'SINGLE VARIABLE
    Public mCons As Integer 'CONSUMPTION
    'Public mMaxA As Decimal 'MAX AMOUNT
    'Public mMaxC As Integer 'MAX CONSUMPTION
    Public mAmt As Decimal 'AMOUNT
    Public mExcess As Decimal 'EXCESS
    Public mNR As Decimal 'NEW RATE
    Public mAdj As Decimal 'ADJUSTMENT
    Public mAR As Decimal 'ADJUSTED RATE
    Public mEF As Decimal 'ENVI FEE
    Public mTot As Decimal 'TOTAL
    Public mSC As Decimal 'SC DISCOUNT
    Public mSCTot As Decimal 'SCTOTAL
    Public mP As Decimal 'PENALTY
    Public mTP As Decimal 'TOTAL WITH PENALTY
    Public mTPSC As Decimal 'SC WITH PENALTY
    Public mPrev As Decimal

    Public Sub metComputation(i As Integer, C As Integer, A As Double, isSC As String, prev As Decimal)
        'NEW COMPUTATION
        metCon(i) = C
        metAmt(i) = A
        If C < 11 Then
            metEF(i) = 10
        Else
            metEF(i) = C
        End If

        metPrev(i) = prev
        metTot(i) = metAmt(i) - metEF(i)
        metP(i) = (metAmt(i) + metPrev(i)) * 0.1
        metTP(i) = (metAmt(i) + metP(i))
        If isSC = "YES" Then
            metSC(i) = Format((metAmt(i) * 0.05), "#.#0")
            metSCTot(i) = metAmt(i) - metSC(i)
            metTPSC(i) = (metSCTot(i) + metP(i))
        Else
            metSC(i) = 0
            metSCTot(i) = 0
            metTPSC(i) = 0
        End If
    End Sub

    Public Sub SingleVarMetCompute(C As Integer, A As Double, isSC As String, prev As Decimal, conDate As Date, billDate As Date)
        mCons = C
        mAmt = A
        'If mCons < 11 Then
        '    mEF = 10
        'Else
        mEF = mCons
        'End If
        mPrev = prev
        Dim nowDate As Date = billDate.Date
        Dim dDif As Integer = DateDiff(DateInterval.Year, conDate, nowDate)
        mP = (mAmt) * 0.1



        If dDif > 0 Then
            If C < 31 Then
                If isSC = "YES" Then
                    Dim mult As Decimal
                    If C >= 0 And C <= 10 Then
                        mult = 0.2
                    ElseIf C >= 11 And C <= 20 Then
                        mult = 0.1
                    ElseIf C >= 21 And C <= 30 Then
                        mult = 0.05
                    End If
                    mSC = Format((mAmt * mult), "#.#0")
                    mSCTot = mAmt - mSC
                    mTPSC = (mSCTot + mP)
                Else
                    mSC = 0
                    mSCTot = 0
                    mTPSC = 0
                End If
            Else
                mSC = 0
                mSCTot = 0
                mTPSC = 0
            End If
        End If
        mTot = mAmt - mSC
        mTP = (mTot + mP)


        'If isSC = "YES" Then
        '    mSC = Format((mAmt * 0.05), "#.#0")
        '    mSCTot = mAmt - mSC
        '    mTPSC = mSCTot + mP
        'Else
        '    mSC = 0
        '    mSCTot = 0
        '    mTPSC = 0
        'End If
        'mTot = mAmt - mSC


        'Dim nowDate As Date = Date.Now
        'Dim dDif As Integer = DateDiff(DateInterval.Year, conDate, nowDate)
        ''MessageBox.Show(dDif)
        'Dim curReadAmount As Decimal = A
        'Dim actualAmount As Decimal = A
        'Dim tempReadAmount As Decimal = curReadAmount
        'Dim remOverpay As Decimal = 0

        'If tempReadAmount < 0 Then
        '    'readAmount(i) = 0
        '    remOverpay = overPay - curReadAmount
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
        '    readPenalty(i) = actualAmount * 0.1
        'End If

        ''read(i) = (metAmt(i) + metP(i))
        'If dDif > 0 Then
        '    If C < 31 Then
        '        If isSC = "YES" Then
        '            Dim mult As Decimal
        '            If C >= 0 And C <= 10 Then
        '                mult = 0.2
        '            ElseIf C >= 11 And C <= 20 Then
        '                mult = 0.1
        '            ElseIf C >= 21 And C <= 30 Then
        '                mult = 0.05
        '            End If
        '            readDiscount(i) = Format((tempReadAmount * mult), "#.#0")
        '            readSCAmt(i) = tempReadAmount - readDiscount(i)
        '            ReadSCPen(i) = (readSCAmt(i) + readPenalty(i))
        '        Else
        '            readDiscount(i) = 0
        '            readSCAmt(i) = 0
        '            ReadSCPen(i) = 0
        '        End If
        '    Else
        '        readDiscount(i) = 0
        '        readSCAmt(i) = 0
        '        ReadSCPen(i) = 0
        '    End If
        'End If

        'If tempReadAmount < 0 Then
        '    readTotal(i) = 0

        'Else
        '    readTotal(i) = tempReadAmount - readDiscount(i)

        'End If
        'readTotalAmount(i) = readTotal(i)
        'readTotalADue(i) = readTotalAmount(i) + readPenalty(i)

    End Sub

    Public Sub ConsCount(i As Integer)
        ReDim metCon(i)
        'ReDim metMaxA(i)
        'ReDim metMaxC(i)
        ReDim metAmt(i)
        ReDim metExcess(i)
        ReDim metNR(i)
        ReDim metAdj(i)
        ReDim metAR(i)
        ReDim metEF(i)
        ReDim metTot(i)
        ReDim metSC(i)
        ReDim metSCTot(i)
        ReDim metP(i)
        ReDim metTP(i)
        ReDim metTPSC(i)
        ReDim metPrev(i)
    End Sub
End Module
