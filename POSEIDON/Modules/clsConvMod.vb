Module clsConvMod
    Dim mOnesArray(8) As String
    Dim mOneTensArray(9) As String
    Dim mTensArray(7) As String
    Dim mPlaceValues(4) As String


    Sub New()

        mOnesArray(0) = "One"
        mOnesArray(1) = "Two"
        mOnesArray(2) = "Three"
        mOnesArray(3) = "Four"
        mOnesArray(4) = "Five"
        mOnesArray(5) = "Six"
        mOnesArray(6) = "Seven"
        mOnesArray(7) = "Eight"
        mOnesArray(8) = "Nine"

        mOneTensArray(0) = "Ten"
        mOneTensArray(1) = "Eleven"
        mOneTensArray(2) = "Twelve"
        mOneTensArray(3) = "Thirteen"
        mOneTensArray(4) = "Fourteen"
        mOneTensArray(5) = "Fifteen"
        mOneTensArray(6) = "Sixteen"
        mOneTensArray(7) = "Seventeen"
        mOneTensArray(8) = "Eightteen"
        mOneTensArray(9) = "Nineteen"

        mTensArray(0) = "Twenty"
        mTensArray(1) = "Thirty"
        mTensArray(2) = "Forty"
        mTensArray(3) = "Fifty"
        mTensArray(4) = "Sixty"
        mTensArray(5) = "Seventy"
        mTensArray(6) = "Eighty"
        mTensArray(7) = "Ninety"

        mPlaceValues(0) = "Hundred"
        mPlaceValues(1) = "Thousand"
        mPlaceValues(2) = "Million"
        mPlaceValues(3) = "Billion"
        mPlaceValues(4) = "Trillion"

    End Sub


    Public Function GetOnes(ByVal OneDigit As Integer) As String
        GetOnes = ""
        If OneDigit = 0 Then
            Exit Function
        End If
        GetOnes = mOnesArray(OneDigit - 1)
    End Function

    Public Function GetTens(ByVal TensDigit As Integer) As String
        GetTens = ""
        If TensDigit = 0 Or TensDigit = 1 Then
            Exit Function
        End If

        GetTens = mTensArray(TensDigit - 2)

    End Function


    Public Function ConvertNumberToWords(ByVal NumberValue As String) As String

        Dim Delimiter As String = " "
        Dim TensDelimiter As String = "-"
        Dim mNumberValue As String = ""
        Dim mNumbers As String = ""
        Dim mNumWord As String = ""
        Dim mFraction As String = ""
        Dim mNumberStack() As String
        Dim j As Integer = 0
        Dim i As Integer = 0
        Dim mOneTens As Boolean = False

        ConvertNumberToWords = ""

        ' validate input
        Try
            j = CDbl(NumberValue)
        Catch ex As Exception
            ConvertNumberToWords = "Invalid input."
            Exit Function
        End Try

        ' get fractional part {if any}
        If InStr(NumberValue, ".") = 0 Then
            ' no fraction
            mNumberValue = NumberValue
        Else
            mNumberValue = Microsoft.VisualBasic.Left(NumberValue, InStr(NumberValue, ".") - 1)
            mFraction = Mid(NumberValue, InStr(NumberValue, ".")) ' + 1)
            mFraction = Math.Round(CSng(mFraction), 2) * 100

            If CInt(mFraction) = 0 Then
                mFraction = ""
            Else
                mFraction = "& " & mFraction & "/100 "
            End If
        End If
        mNumbers = mNumberValue.ToCharArray

        ' move numbers to stack/array backwards
        For j = mNumbers.Length - 1 To 0 Step -1
            ReDim Preserve mNumberStack(i)

            mNumberStack(i) = mNumbers(j)
            i += 1
        Next

        For j = mNumbers.Length - 1 To 0 Step -1
            Select Case j
                Case 0, 3, 6, 9, 12
                    ' ones  value
                    If Not mOneTens Then
                        mNumWord &= GetOnes(Val(mNumberStack(j))) & Delimiter
                    End If

                    Select Case j
                        Case 3
                            ' thousands
                            mNumWord &= mPlaceValues(1) & Delimiter

                        Case 6
                            ' millions
                            mNumWord &= mPlaceValues(2) & Delimiter

                        Case 9
                            ' billions
                            mNumWord &= mPlaceValues(3) & Delimiter

                        Case 12
                            ' trillions
                            mNumWord &= mPlaceValues(4) & Delimiter
                    End Select
                Case Is = 1, 4, 7, 10, 13
                    ' tens value
                    If Val(mNumberStack(j)) = 0 Then
                        mNumWord &= GetOnes(Val(mNumberStack(j - 1))) & Delimiter
                        mOneTens = True
                        Exit Select
                    End If

                    If Val(mNumberStack(j)) = 1 Then
                        mNumWord &= mOneTensArray(Val(mNumberStack(j - 1))) & Delimiter
                        mOneTens = True
                        Exit Select
                    End If
                    mNumWord &= GetTens(Val(mNumberStack(j)))
                    ' this places the tensdelimiter; check for succeeding 0
                    If Val(mNumberStack(j - 1)) <> 0 Then
                        mNumWord &= TensDelimiter
                    End If
                    mOneTens = False

                Case Else
                    ' hundreds value 
                    mNumWord &= GetOnes(Val(mNumberStack(j))) & Delimiter

                    If Val(mNumberStack(j)) <> 0 Then
                        mNumWord &= mPlaceValues(0) & Delimiter
                    End If
            End Select
        Next
        Return mNumWord & mFraction & " Pesos Only"
    End Function
End Module
