Imports MySql.Data
Imports MySql.Data.MySqlClient
Module ReportModule
    Public arBrgyID() As Integer
    Public Function LoadAccountsReceivables(brgyID As Integer, billMonth As String, billYear As Integer) As DataTable
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, A.acctID, R.brgyID, C.classID, O.consID, A.AccountNo, O.ConsumerName, A.StreetAddress, R.AddBrgy, C.classification, B.amount AS useAmount, B.penalty, B.useADue, B.consump, B.prevRead, B.presRead, B.fromDate, B.toDate, B.dueDate, B.billMonth, B.billYear, B.prevPenalty FROM billing AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS C ON B.classID=C.classID LEFT JOIN consumerlist AS O ON B.consID=O.consID LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID WHERE B.brgyID=" & brgyID & " and B.billMonth='" & billMonth & "' and B.billYear=" & billYear, con)
        da.Fill(dt)
        Return dt
    End Function

End Module
