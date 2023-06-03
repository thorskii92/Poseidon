Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmPendingDisconnection
    Dim brgyID() As Integer
    Dim strQ As String
    Dim gaID() As Integer
    Private Sub frmPendingDisconnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrgy()
        strQ = ""
    End Sub

    Private Sub LoadBrgy()
        cboBrgy.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim brgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                brgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ItemsLoader(brgyID(cboBrgy.SelectedIndex))
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If strQ <> "" Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(strQ, con)
            da.Fill(dt)
            Dim report As New crptPendingDisconnection
            report.SetDataSource(dt)
            frmPrintPendingDisconnection.CrystalReportViewer1.ReportSource = report
            frmPrintPendingDisconnection.CrystalReportViewer1.Zoom(100%)
            frmPrintPendingDisconnection.CrystalReportViewer1.Refresh()
            frmPrintPendingDisconnection.WindowState = FormWindowState.Maximized
            frmPrintPendingDisconnection.ShowDialog()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For x As Integer = 0 To lvw.Items.Count - 1
            lvw.Items(x).Checked = True
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For x As Integer = 0 To lvw.Items.Count - 1
            lvw.Items(x).Checked = False
        Next
    End Sub

    Private Sub btnCancelDisconnection_Click(sender As Object, e As EventArgs) Handles btnCancelDisconnection.Click
        If lvw.CheckedItems.Count > 0 Then
            If MessageBox.Show("Confirm Cancellation", "Cancel Disconnection", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                For x As Integer = 0 To lvw.CheckedItems.Count - 1
                    Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=1 WHERE acctID=" & gaID(lvw.CheckedItems(x).Index), con)
                    cmd.ExecuteNonQuery()
                Next
                MessageBox.Show("Accounts has been cancelled from Disconnection", "Cancel Disconnection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ItemsLoader(brgyID(cboBrgy.SelectedIndex))
            End If
        Else
            MessageBox.Show("Select items to Cancel", "Cancel Disconnection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ItemsLoader(bryID)
        strQ = "SELECT A.acctID, A.Sequence, A.AccountNo, A.AccountName, A.MeterNo, A.StreetAddress, R.AddBrgy, sum(B.useAmount + ifnull(B.prevOutstanding, 0)) AS Balance, monthname(Min(B.fromDate)) AS dFromMonth,year(Min(B.fromDate)) AS dFromYear, monthname(Max(B.todate)) AS dToMonth, year(Max(B.todate)) AS dToYear FROM consumeraccounts AS A LEFT JOIN brgylist AS R ON R.brgyID=A.brgyID LEFT JOIN billing AS B ON A.acctID=B.acctID WHERE acctstatus=4 and B.billstat='UNPAID' and A.brgyID=" & bryID & " GROUP BY A.acctID ORDER BY A.Sequence"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(strQ, con)
        da.Fill(dt)
        lvw.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim gaID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = ""
                gaID(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(8).ToString & " - " & dt.Rows(x).Item(9).ToString & " to " & dt.Rows(x).Item(10).ToString & " - " & dt.Rows(x).Item(11).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(7).ToString), "#,##0.#0"))
                lvw.Items.Add(lst)
            Next
        End If
    End Sub
End Class