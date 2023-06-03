Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmDisconnectionList
    Public dtDisc As New DataTable
    Dim arrSelBrgy() As Integer
    Private Sub frmDisconnectionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrgy()
        'Control.CheckForIllegalCrossthreads.
        'frmLoadDisconnectionListProgress.StartPosition = FormStartPosition.CenterScreen
        'frmLoadDisconnectionListProgress.ShowDialog()
        'frmLoadDisconnectionListProgress.bgwProress.RunWorkerAsync()

        'BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'For i As Integer = 0 To 100
        'BackgroundWorker1.ReportProgress(i)

        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT B.acctID, A.accountno, A.AccountName, SUM(ifnull(B.useAmount,0)) AS TotalBalance, A.AcctStatus, sum(B.amount) FROM billing AS B left join consumeraccounts AS A ON B.acctID=A.acctID group by A.acctID", con)
        'da.Fill(dt)

        'If dt.Rows.Count > 0 Then
        '    ReDim arrDiscAcctID(dt.Rows.Count - 1)
        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        Dim lst As New ListViewItem
        '        lst.Text = ""
        '        lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
        '        lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
        '        lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
        '        lst.SubItems.Add(dt.Rows(x).Item(5).ToString)
        '        lvw.Items.Add(lst)
        '        Dim z As Integer = ((x / (dt.Rows.Count - 1)) * 100)
        '        'progbar.Value = i
        '        BackgroundWorker1.ReportProgress(z)
        '        Threading.Thread.Sleep(100)
        '    Next
        'End If

        'Threading.Thread.Sleep(100)
        'Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'prg.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' MessageBox.Show("Done loading list", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        lvw.Items.Clear()
        Dim countRows As Integer = 0
        If txtFrom.Text = "" Or txtTo.Text = "" Then
            If dtDisc.Rows.Count > 0 Then
                For x As Integer = 0 To dtDisc.Rows.Count - 1
                    countRows = countRows + 1
                    Dim lst As New ListViewItem
                    lst.Text = ""
                    lst.SubItems.Add(dtDisc.Rows(x).Item(1).ToString)
                    lst.SubItems.Add(dtDisc.Rows(x).Item(2).ToString)
                    lst.SubItems.Add(Format(Val(dtDisc.Rows(x).Item(3)), "#,##0.#0"))
                    lst.SubItems.Add(dtDisc.Rows(x).Item(5).ToString)
                    lst.SubItems.Add(dtDisc.Rows(x).Item(6).ToString)
                    lst.SubItems.Add(dtDisc.Rows(x).Item(7).ToString)
                    lst.SubItems.Add(dtDisc.Rows(x).Item(8).ToString)
                    lst.SubItems.Add(dtDisc.Rows(x).Item(0).ToString)
                    lvw.Items.Add(lst)
                Next
            End If
        Else
            If dtDisc.Rows.Count > 0 Then
                For x As Integer = 0 To dtDisc.Rows.Count - 1
                    Dim getAmount As Double = Val(dtDisc.Rows(x).Item(3))
                    If getAmount >= Val(txtFrom.Text) And getAmount <= (txtTo.Text) Then
                        countRows = countRows + 1
                        Dim lst As New ListViewItem
                        lst.Text = ""
                        lst.SubItems.Add(dtDisc.Rows(x).Item(1).ToString)
                        lst.SubItems.Add(dtDisc.Rows(x).Item(2).ToString)
                        lst.SubItems.Add(Format(Val(dtDisc.Rows(x).Item(3)), "#,##0.#0"))
                        lst.SubItems.Add(dtDisc.Rows(x).Item(5).ToString)
                        lst.SubItems.Add(dtDisc.Rows(x).Item(6).ToString)
                        lst.SubItems.Add(dtDisc.Rows(x).Item(7).ToString)
                        lst.SubItems.Add(dtDisc.Rows(x).Item(8).ToString)
                        lst.SubItems.Add(dtDisc.Rows(x).Item(0).ToString)
                        lvw.Items.Add(lst)
                    End If
                Next
            End If

        ReDim arrDiscAcctID(countRows)
            For y As Integer = 0 To countRows

            Next

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim countRows As Integer = 0
        lvw.Items.Clear()

        If dtDisc.Rows.Count > 0 Then
            For x As Integer = 0 To dtDisc.Rows.Count - 1
                countRows = countRows + 1
                Dim lst As New ListViewItem
                lst.Text = ""
                lst.SubItems.Add(dtDisc.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dtDisc.Rows(x).Item(2).ToString)
                lst.SubItems.Add(Format(Val(dtDisc.Rows(x).Item(3)), "#,##0.#0"))
                lst.SubItems.Add(dtDisc.Rows(x).Item(5).ToString)
                lst.SubItems.Add(dtDisc.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dtDisc.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dtDisc.Rows(x).Item(8).ToString)
                lst.SubItems.Add(dtDisc.Rows(x).Item(0).ToString)
                lvw.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        If lvw.Items.Count > 0 Then
            For x As Integer = 0 To lvw.Items.Count - 1
                lvw.Items(x).Checked = True
            Next
        End If
    End Sub

    Private Sub btnUnselect_Click(sender As Object, e As EventArgs) Handles btnUnselect.Click
        If lvw.Items.Count > 0 Then
            For x As Integer = 0 To lvw.Items.Count - 1
                lvw.Items(x).Checked = False
            Next
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If lvw.CheckedItems.Count > 0 Then
            If MessageBox.Show("Set selected Accounts for Disconnection?", "Set for Disconnection", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cons()
                Dim discCount As Integer = lvw.CheckedItems.Count
                For x As Integer = 0 To lvw.CheckedItems.Count - 1
                    Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET acctstatus=4 WHERE acctID=" & Val(lvw.CheckedItems(x).SubItems(7).Text), con)
                    cmd.ExecuteNonQuery()
                Next
                LoadForDisconnectionList(arrBrgyID(cboBrgy.SelectedIndex))
                MessageBox.Show(discCount & " Accounts has been set for disconnection, Please see pending list", "Accounts has been set for disconnection", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged

    End Sub

    Private Sub LoadBrgy()
        lvw.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadForDisconnectionList(arrBrgyID(cboBrgy.SelectedIndex))
    End Sub

    Private Sub btnPendingDisconnectionList_Click(sender As Object, e As EventArgs) Handles btnPendingDisconnectionList.Click
        frmPendingDisconnection.WindowState = FormWindowState.Maximized
        frmPendingDisconnection.ShowDialog()
    End Sub
End Class