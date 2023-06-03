Imports MySql.Data
Imports MySql.Data.MySqlClient
Module AccountCodes
    Dim codename As String
    Dim codeser As Integer
    Dim acCode As String
    Public pAmount As Double
    Dim serAdd As Integer
    Public specifiedAmount As Double
    Public intType As Integer
    Public Function GetAccountCodes(CodeType As Integer) As String
        If CodeType = 1 Then
            'New Connection
            codename = "NC"
            pAmount = 1500
        ElseIf CodeType = 2 Then
            'Tramsfer Water Meter
            codename = "TM"
            pAmount = 250
        ElseIf CodeType = 3 Then
            'For Reconnection
            codename = "RC"
            pAmount = 250
        ElseIf CodeType = 4 Then
            'Transfer of Ownership
            codename = "TO"
            pAmount = 500
        ElseIf CodeType = 5 Then
            'Service Fee
            codename = "SF"
            pAmount = specifiedAmount
        ElseIf CodeType = 6 Then
            'Advance Payment
            codename = "AP"
            pAmount = specifiedAmount
        End If
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT series FROM acctcodeconnection WHERE code='" & codename & "' and MONTH=" & Today.Month & " and YEAR=" & Today.Year, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            codeser = Val(dt.Rows(0).Item(0).ToString)
            acCode = codename & "-" & Today.Month.ToString & Today.Year.ToString & "-" & Format(Val(codeser) + 1, "000#")
            serAdd = codeser + 1
        Else
            Dim cmd As New MySqlCommand("INSERT INTO acctcodeconnection(CODE, MONTH, YEAR, SERIES) VALUES('" & codename & "'," & Today.Month & "," & Today.Year & ",0)", con)
            cmd.ExecuteNonQuery()
            acCode = codename & "-" & Today.Month.ToString & Today.Year.ToString & "-" & Format(1, "000#")
            serAdd = 1
        End If
        GetAccountCodes = acCode
        Dim cmdUp As New MySqlCommand("UPDATE acctcodeconnection SET SERIES=" & serAdd & " WHERE CODE='" & codename & "' AND MONTH=" & Today.Month & " AND YEAR=" & Today.Year, con)
        cmdUp.ExecuteNonQuery()
    End Function
End Module
