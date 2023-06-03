Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmRevFromConsumpSelect

    Dim dtAll As New DataTable
    Dim rbrgyID() As Integer
    Dim rzoneNum() As Integer
    Dim rAddBrgy() As String
    Dim rPlantName() As String
    Dim rPlantAbbr() As String
    Dim rResCub() As Integer
    Dim rResAmt() As Decimal
    Dim rInsCub() As Integer
    Dim rInsAmt() As Decimal
    Dim rComCub() As Integer
    Dim rComAmt() As Decimal
    Dim rIndCub() As Integer
    Dim rIndAmt() As Decimal
    Dim rMonths() As String
    Dim rYears() As Integer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        LoadRevConsumptionRerport(cboMonth.Text, cboYear.Text)
    End Sub

    Private Sub frmRevFromConsumpSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonths()
        LoadYears()
    End Sub

    Private Sub LoadMonths()
        cboMonth.Items.Clear()
        For x As Integer = 1 To 12
            cboMonth.Items.Add(MonthName(x))
        Next
    End Sub

    Private Sub LoadYears()
        Cons()
        cboYear.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT min(billYear), max(billYear) FROM billing", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim i As Integer = Val(dt.Rows(0).Item(0).ToString)
            Dim j As Integer = Val(dt.Rows(0).Item(1).ToString)
            For x As Integer = i To j
                cboYear.Items.Add(x)
            Next
        End If
    End Sub

    Private Sub LoadRevConsumptionRerport(rMonth As String, rYear As Integer)
        Cons()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT *  FROM brgylist AS R LEFT JOIN zones AS Z ON R.zoneID=Z.zoneID ORDER BY Z.zoneNum", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDec(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                rbrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                rzoneNum(x) = Val(dt.Rows(x).Item(8).ToString)
                rAddBrgy(x) = dt.Rows(x).Item(2).ToString
                rPlantName(x) = dt.Rows(x).Item(10).ToString
                rPlantAbbr(x) = dt.Rows(x).Item(11).ToString
                rMonths(x) = rMonth
                rYears(x) = rYear
                rResCub(x) = 0
                rResAmt(x) = 0
                rInsCub(x) = 0
                rInsAmt(x) = 0
                rComCub(x) = 0
                rComAmt(x) = 0
                rIndCub(x) = 0
                rIndAmt(x) = 0
            Next
            Dim dtRes As New DataTable
            Dim daRes As New MySqlDataAdapter("SELECT B.brgyID, R.AddBrgy, Z.zoneNum, Z.PlantName, Z.Abbrv, SUM(consump), sum(amount), SUM(useAmount) FROM billing AS B LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID LEFT JOIN zones AS Z ON R.zoneID=Z.zoneID WHERE B.billMonth='" & rMonth & "' and B.billYear=" & rYear & " and B.classID=1 GROUP BY B.brgyID ORDER BY Z.zoneNum", con)
            daRes.Fill(dtRes)
            If dtRes.Rows.Count > 0 Then
                For x As Integer = 0 To dt.Rows.Count - 1
                    For y As Integer = 0 To dtRes.Rows.Count - 1
                        If rbrgyID(x) = Val(dtRes.Rows(y).Item(0).ToString) Then
                            rResCub(x) = Val(dtRes.Rows(y).Item(5).ToString)
                            rResAmt(x) = Val(dtRes.Rows(y).Item(6).ToString)
                        End If
                    Next
                Next
            End If

            Dim dtIns As New DataTable
            Dim daIns As New MySqlDataAdapter("SELECT B.brgyID, R.AddBrgy, Z.zoneNum, Z.PlantName, Z.Abbrv, SUM(consump), sum(amount), SUM(useAmount) FROM billing AS B LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID LEFT JOIN zones AS Z ON R.zoneID=Z.zoneID WHERE B.billMonth='" & rMonth & "' and B.billYear=" & rYear & " and B.classID=2 GROUP BY B.brgyID ORDER BY Z.zoneNum", con)
            daIns.Fill(dtIns)
            If dtIns.Rows.Count > 0 Then
                For x As Integer = 0 To dt.Rows.Count - 1
                    For y As Integer = 0 To dtIns.Rows.Count - 1
                        If rbrgyID(x) = Val(dtIns.Rows(y).Item(0).ToString) Then
                            rInsCub(x) = Val(dtIns.Rows(y).Item(5).ToString)
                            rInsAmt(x) = Val(dtIns.Rows(y).Item(6).ToString)
                        End If
                    Next
                Next
            End If

            Dim dtCom As New DataTable
            Dim daCom As New MySqlDataAdapter("SELECT B.brgyID, R.AddBrgy, Z.zoneNum, Z.PlantName, Z.Abbrv, SUM(consump), sum(amount), SUM(useAmount) FROM billing AS B LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID LEFT JOIN zones AS Z ON R.zoneID=Z.zoneID WHERE B.billMonth='" & rMonth & "' and B.billYear=" & rYear & " and B.classID=4 GROUP BY B.brgyID ORDER BY Z.zoneNum", con)
            daCom.Fill(dtCom)
            If dtCom.Rows.Count > 0 Then
                For x As Integer = 0 To dt.Rows.Count - 1
                    For y As Integer = 0 To dtCom.Rows.Count - 1
                        If rbrgyID(x) = Val(dtCom.Rows(y).Item(0).ToString) Then
                            rComCub(x) = Val(dtCom.Rows(y).Item(5).ToString)
                            rComAmt(x) = Val(dtCom.Rows(y).Item(6).ToString)
                        End If
                    Next
                Next
            End If

            Dim dtInd As New DataTable
            Dim daInd As New MySqlDataAdapter("SELECT B.brgyID, R.AddBrgy, Z.zoneNum, Z.PlantName, Z.Abbrv, SUM(consump), sum(amount), SUM(useAmount) FROM billing AS B LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID LEFT JOIN zones AS Z ON R.zoneID=Z.zoneID WHERE B.billMonth='" & rMonth & "' and B.billYear=" & rYear & " and B.classID=5 GROUP BY B.brgyID ORDER BY Z.zoneNum", con)
            daInd.Fill(dtInd)
            If dtCom.Rows.Count > 0 Then
                For x As Integer = 0 To dt.Rows.Count - 1
                    For y As Integer = 0 To dtInd.Rows.Count - 1
                        If rbrgyID(x) = Val(dtInd.Rows(y).Item(0).ToString) Then
                            rIndCub(x) = Val(dtInd.Rows(y).Item(5).ToString)
                            rIndAmt(x) = Val(dtInd.Rows(y).Item(6).ToString)
                        End If
                    Next
                Next
            End If
            RevConsumpDatatable = New DataTable
            RevConsumpDatatable.Columns.AddRange(New DataColumn() {New DataColumn("brgyID", GetType(Integer)), New DataColumn("AddBrgy", GetType(String)), New DataColumn("PlantName", GetType(String)), New DataColumn("ResCub", GetType(Integer)), New DataColumn("ResAmount", GetType(Decimal)), New DataColumn("InsCub", GetType(Integer)), New DataColumn("InsAmount", GetType(Decimal)), New DataColumn("ComCub", GetType(Integer)), New DataColumn("ComAmount", GetType(Decimal)), New DataColumn("IndCub", GetType(Integer)), New DataColumn("IndAmount", GetType(Decimal)), New DataColumn("billMonth", GetType(String)), New DataColumn("billYear", GetType(Integer))})
            For y As Integer = 0 To dt.Rows.Count - 1
                RevConsumpDatatable.Rows.Add(rbrgyID(y), rAddBrgy(y), rPlantAbbr(y), rResCub(y), rResAmt(y), rInsCub(y), rInsAmt(y), rComCub(y), rComAmt(y), rIndCub(y), rIndAmt(y), rMonths(y), rYears(y))
            Next

            Dim report As New crptRevenueConsumption
            report.SetDataSource(RevConsumpDatatable)
            frmRevConsumptionReportViewer.CrystalReportViewer1.ReportSource = report
            frmRevConsumptionReportViewer.CrystalReportViewer1.Zoom(100%)
            frmRevConsumptionReportViewer.CrystalReportViewer1.Refresh()
            frmRevConsumptionReportViewer.WindowState = FormWindowState.Maximized
            frmRevConsumptionReportViewer.ShowDialog()
        End If
    End Sub

    Private Sub ReDec(i As Integer)
        ReDim rbrgyID(i)
        ReDim rzoneNum(i)
        ReDim rAddBrgy(i)
        ReDim rPlantName(i)
        ReDim rPlantAbbr(i)
        ReDim rResCub(i)
        ReDim rResAmt(i)
        ReDim rInsCub(i)
        ReDim rInsAmt(i)
        ReDim rComCub(i)
        ReDim rComAmt(i)
        ReDim rIndCub(i)
        ReDim rIndAmt(i)
        ReDim rMonths(i)
        ReDim rYears(i)
    End Sub

End Class