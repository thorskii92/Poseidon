Imports MySql.Data.MySqlClient
Module Rate_Module
    Dim arrCub() As Integer
    Dim arrRate() As Double
    Public arrFcubCons() As Integer
    Public arrScubCons() As Integer

    Public Function DirectRate(ByVal cubicmet As Integer, ByVal clID As Integer, compType As Integer) As Double
        Dim compRate As Decimal = 0
        Dim rate As Decimal = 0
        Dim query As String = "SELECT * FROM tblclassrates WHERE ((cubits <= " & cubicmet & ") OR (Cubits > " & cubicmet & " and Cubits <= (SELECT cubits FROM tblclassrates WHERE IsMin=1 AND classid=" & clID & "))) AND classid=" & clID
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(query, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim minC As Integer = Val(dt.Rows(0).Item(4))
            Dim minAmt As Decimal = Val(dt.Rows(0).Item(2))
            If dt.Rows.Count > 0 Then
                rate = Val(dt.Rows(dt.Rows.Count - 1).Item(2))
            End If
            Dim eFamt As Integer = 0
            If cubicmet < 11 Then
                eFamt = 10
            Else
                eFamt = cubicmet
            End If
            If compType = 1 Then
                If dt.Rows.Count = 1 Then
                    compRate = rate + eFamt
                Else
                    compRate = ((cubicmet - minC) * rate) + minAmt - cubicmet + eFamt
                End If
            Else
                If dt.Rows.Count = 1 Then
                    compRate = rate + eFamt
                Else
                    compRate = (rate * cubicmet) + eFamt
                End If
            End If
        End If

        Return compRate
    End Function

    Public Function RateAmount(ByVal cubitsmet As Integer, ByVal clID As Integer) As Double
        Dim compRate As Double
        Dim baseCub As Integer
        Dim baseRate As Double
        Dim newBase As Integer
        Dim maxCub As Integer = cubitsmet
        Dim maxCount As Integer
        compRate = 0
        Dim query As String = "SELECT * FROM tblclassrates WHERE ((cubits <= " & cubitsmet & ") OR (Cubits > " & cubitsmet & " and Cubits <= (SELECT cubits FROM tblclassrates WHERE IsMin=1 AND classid=" & clID & "))) AND classid=" & clID
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(query, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrCub(dt.Rows.Count - 1)
            ReDim arrRate(dt.Rows.Count - 1)
            If dt.Rows.Count > 1 Then
                baseCub = Val(dt.Rows(0).Item(4).ToString)
                baseRate = Val(dt.Rows(0).Item(2).ToString)
                newBase = baseCub + 1
                compRate = baseRate
                maxCount = dt.Rows.Count
                For x As Integer = 0 To dt.Rows.Count - 1
                    arrCub(x) = Val(dt.Rows(x).Item(4).ToString)
                    arrRate(x) = Val(dt.Rows(x).Item(2).ToString)
                Next
                Dim z As Integer = 1
                For y = newBase To maxCub
                    compRate = compRate + Val(arrRate(z))
                    Try
                        If y + 1 = arrCub(z + 1) Then
                            If z <> maxCount Then
                                z = z + 1
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Next
            ElseIf dt.Rows.Count = 1 Then
                arrCub(0) = Val(dt.Rows(0).Item(4).ToString)
                arrRate(0) = Val(dt.Rows(0).Item(2).ToString)
                compRate = arrRate(0)
            End If

        End If
        RateAmount = compRate
    End Function

    Public Sub ConsumptionLabel(ByVal clID As Integer, index As Integer)
        Cons()
        Dim query As String = "SELECT * FROM tblClassrates WHERE classID=" & clID
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(query, con)
        da.Fill(dt)
        Dim rowCount As Integer = dt.Rows.Count
        If dt.Rows.Count > 0 Then
            If rowCount > 0 Then
                arrMinCons(index) = dt.Rows(0).Item(4)
            End If

            If rowCount = 3 Then
                For x As Integer = 0 To dt.Rows.Count - 1
                    If x = rowCount Then
                        arrFLabel(index) = dt.Rows(1).Item(4) & " and above"
                        arrSLabel(index) = ""
                        arrFAmtPerCub(index) = dt.Rows(1).Item(2)
                        arrSAmtPerCub(index) = 0
                        arrFcubCons(index) = dt.Rows(1).Item(4)
                        arrScubCons(index) = 0
                    Else
                        arrFLabel(index) = dt.Rows(1).Item(4) & " to " & (dt.Rows(2).Item(4) - 1)
                        arrSLabel(index) = dt.Rows(2).Item(4) & " and above"
                        arrFAmtPerCub(index) = dt.Rows(1).Item(2)
                        arrSAmtPerCub(index) = dt.Rows(2).Item(2)
                        arrFcubCons(index) = dt.Rows(1).Item(4)
                        arrScubCons(index) = dt.Rows(2).Item(4)
                    End If
                Next
            ElseIf rowCount = 2 Then
                For x As Integer = 0 To dt.Rows.Count - 1
                    If x = rowCount Then
                        arrFLabel(index) = dt.Rows(1).Item(4) & " and above"
                        arrSLabel(index) = ""
                        arrFAmtPerCub(index) = dt.Rows(1).Item(2)
                        arrSAmtPerCub(index) = 0
                        arrFcubCons(index) = dt.Rows(1).Item(4)
                        arrScubCons(index) = 0
                    End If
                Next
            Else
                arrFLabel(index) = ""
                arrFAmtPerCub(index) = 0
                arrSAmtPerCub(index) = 0
                arrSLabel(index) = ""
                arrFcubCons(index) = 0
                arrScubCons(index) = 0
            End If
        End If
    End Sub

    Public Sub ConsumptionExcessLabel(index As Integer, consumpAmt As Integer)
        'MessageBox.Show(arrMinCons(index))
        If consumpAmt <= arrMinCons(index) Then
            arrFConsump(index) = 0
            arrSConsump(index) = 0
        Else
            If consumpAmt > arrMinCons(index) Then
                If consumpAmt >= arrFcubCons(index) And arrScubCons(index) = 0 Then
                    arrFConsump(index) = consumpAmt - arrMinCons(index)
                    arrSConsump(index) = 0
                ElseIf consumpAmt >= arrFcubCons(index) And consumpAmt < arrScubCons(index) Then
                    arrFConsump(index) = consumpAmt - arrMinCons(index)
                    arrSConsump(index) = 0
                ElseIf consumpAmt >= arrScubCons(index) Then
                    arrFConsump(index) = arrScubCons(index) - arrFcubCons(index)
                    arrSConsump(index) = consumpAmt - (arrScubCons(index) - 1)
                End If
            End If
        End If
        arrFExcess(index) = arrFConsump(index) * arrFAmtPerCub(index)
        arrSExcess(index) = arrSConsump(index) * arrSAmtPerCub(index)
    End Sub

    Public Function getDueAmount(Amount As Decimal, prevAmount As Decimal) As Decimal
        Dim addedAmount As Decimal = (Amount + prevAmount) * 0.1
        getDueAmount = Amount + addedAmount
    End Function

    Public Function getPenaltyAmount(Amount As Decimal, prevAmount As Decimal) As Decimal
        Dim pen As Decimal = (Amount + prevAmount) * 0.1
        Return pen
    End Function

    Public Function CalculateRate(classID As Integer, consump As Integer) As Decimal
        Dim rate As Decimal = 0
        If classID = 1 Then 'RES
            If consump < 11 Then
                rate = 150
            ElseIf consump > 10 And consump < 16 Then
                rate = 150 + ((consump - 10) * 19)
            ElseIf consump > 15 And consump < 21 Then
                rate = 245 + ((consump - 15) * 23)
            ElseIf consump > 20 And consump < 26 Then
                rate = 360 + ((consump - 20) * 27)
            ElseIf consump > 25 And consump < 31 Then
                rate = 495 + ((consump - 25) * 31)
            ElseIf consump > 30 Then
                rate = 650 + ((consump - 30) * 35)
            End If
        ElseIf classID = 2 Then 'INS
            If consump < 11 Then
                rate = 200
            ElseIf consump > 10 And consump < 16 Then
                rate = 200 + ((consump - 10) * 24)
            ElseIf consump > 15 And consump < 21 Then
                rate = 320 + ((consump - 15) * 28)
            ElseIf consump > 20 And consump < 26 Then
                rate = 460 + ((consump - 20) * 32)
            ElseIf consump > 25 And consump < 31 Then
                rate = 620 + ((consump - 25) * 36)
            ElseIf consump > 30 Then
                rate = 800 + ((consump - 30) * 40)
            End If
        ElseIf classID = 3 Then 'GOV
            If consump < 11 Then
                rate = 200
            ElseIf consump > 10 And consump < 16 Then
                rate = 200 + ((consump - 10) * 24)
            ElseIf consump > 15 And consump < 21 Then
                rate = 320 + ((consump - 15) * 28)
            ElseIf consump > 20 And consump < 26 Then
                rate = 460 + ((consump - 20) * 32)
            ElseIf consump > 25 And consump < 31 Then
                rate = 620 + ((consump - 25) * 36)
            ElseIf consump > 30 Then
                rate = 800 + ((consump - 30) * 40)
            End If
        ElseIf classID = 4 Then 'COM
            If consump < 11 Then
                rate = 250
            ElseIf consump > 10 And consump < 21 Then
                rate = 250 + ((consump - 10) * 29)
            ElseIf consump > 20 And consump < 31 Then
                rate = 540 + ((consump - 20) * 33)
            ElseIf consump > 30 Then
                rate = 870 + ((consump - 30) * 37)
            End If
        ElseIf classID = 5 Then 'IND
            If consump < 11 Then
                rate = 250
            ElseIf consump > 10 And consump < 21 Then
                rate = 250 + ((consump - 10) * 29)
            ElseIf consump > 20 And consump < 31 Then
                rate = 540 + ((consump - 20) * 33)
            ElseIf consump > 30 Then
                rate = 870 + ((consump - 30) * 37)
            End If
        End If

        Return rate
    End Function
End Module
