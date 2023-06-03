Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmPrintReadingSelection
    Dim brgyID() As Integer
    Dim clusterID() As Integer
    Dim myQ As String
    Private Sub frmPrintReadingSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrgy()
        LoadYear()
    End Sub

    Private Sub LoadBrgy()
        cboBrgy.Items.Clear()
        cboCluster.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE stat='Active'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim brgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                brgyID(x) = dt.Rows(x).Item(0)
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Private Sub LoadCluster(brgyID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist where brgyID=" & brgyID & " and stat='Active'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim clusterID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                clusterID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboCluster.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Private Sub LoadYear()
        cboYear.Items.Clear()
        For x As Integer = 2021 To Now.Year
            cboYear.Items.Add(x)
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim newIndex As Integer
        Dim newYear As Integer
        If cboMonth.SelectedIndex = 0 Then
            newIndex = 11
            newYear = cboYear.Text - 1
        Else
            newIndex = cboMonth.SelectedIndex - 1
            newYear = cboYear.Text
        End If
        Dim currentMonth As String = cboMonth.Items(newIndex)
        Dim currentYear As String = newYear
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.AcctID, A.Sequence, A.AccountNo, A.AccountName, A.StreetAddress, B.AddBrgy, A.meterno, A.ConnectionDate, S.StatusName, A.MeterReference, '" & currentMonth & " " & currentYear & "' AS CurrentMonth, '" & cboMonth.Text & " " & cboYear.Text & "' AS ReadingMonth, A.standpipe, CL.clusterName FROM consumeraccounts AS A LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN accountstatus AS S ON A.acctstatus=S.staID LEFT JOIN clusterlist AS CL ON A.clusterID=CL.clusterID WHERE CL.clusterID=" & clusterID(cboBrgy.SelectedIndex) & " and (A.acctstatus=1 or A.acctstatus=2) ORDER BY A.standpipe", con)
        da.Fill(dt)
        Dim report As New crptReadingList
        report.SetDataSource(dt)
        frmReadingListPrint.CrystalReportViewer1.ReportSource = report
        frmReadingListPrint.CrystalReportViewer1.Zoom(100%)
        frmReadingListPrint.CrystalReportViewer1.Refresh()
        frmReadingListPrint.WindowState = FormWindowState.Maximized
        frmReadingListPrint.ShowDialog()
    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged
        LoadCluster(brgyID(cboBrgy.SelectedIndex))
    End Sub

    Private Sub cboCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCluster.SelectedIndexChanged
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT billmonth, billyear FROM billing Where clusterID=" & clusterID(cboCluster.SelectedIndex) & " order by billID DESC limit 1", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cboMonth.Text = dt.Rows(0).Item(0).ToString
            cboYear.Text = dt.Rows(0).Item(1).ToString
        End If
    End Sub
End Class