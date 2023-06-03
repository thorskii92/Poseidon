Imports MySql.Data.MySqlClient
Public Class frmPendingList

    Private Sub frmPendingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewPendingList(cboFilter.Text, txtSearch.Text.Replace("'", "''"))
    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        If lvwPendList.SelectedItems.Count > 0 Then
            If lvwPendList.FocusedItem.SubItems(2).Text = "Installation" Then
                selectedPendingAccountID = arrPendAcctID(lvwPendList.FocusedItem.Index)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT A.acctID, A.AccountNo, C.ConsumerName, A.AcctStatus, C.consID FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.acctID=" & selectedPendingAccountID, con)
                da.Fill(dt)
                With frmUpdateForInstallationAccount
                    .txtMetSize.Text = ""
                    .txtMetReference.Text = ""
                    .txtMeterNo.Text = ""
                    .txtMetBrand.Text = ""
                    SelectedPendingConsumerID = Val(dt.Rows(0).Item(4).ToString)
                    .txtConsumerName.Text = dt.Rows(0).Item(2).ToString
                    .txtAccountNo.Text = dt.Rows(0).Item(1).ToString
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf lvwPendList.FocusedItem.SubItems(2).Text = "Meter Transfer" Then
                selectedPendingAccountID = arrPendAcctID(lvwPendList.FocusedItem.Index)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT A.AcctID, C.consID, A.AccountNo, C.consumername, A.StreetAddress, A.clusterid, B.addbrgy, Z.zoneNum, M.municipality, P.ProvName  FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN zones AS Z ON B.ZoneID=Z.ZoneID LEFT JOIN munlist AS M ON Z.addmunID=M.addmunID LEFT JOIN provlist AS P ON M.addprovID=P.addprovID WHERE A.AcctID=" & selectedPendingAccountID, con)
                da.Fill(dt)
                With frmUpdateTransMeter
                    SelectedPendingConsumerID = Val(dt.Rows(0).Item(1).ToString)
                    .lblAccountNo.Text = dt.Rows(0).Item(2).ToString
                    .lblBarangay.Text = dt.Rows(0).Item(6).ToString
                    .lblCluster.Text = dt.Rows(0).Item(5).ToString
                    .lblConsumerName.Text = dt.Rows(0).Item(3).ToString
                    .lblMunicipality.Text = dt.Rows(0).Item(8).ToString
                    .lblProvince.Text = dt.Rows(0).Item(9).ToString
                    .lblStreet.Text = dt.Rows(0).Item(4).ToString
                    .lblZone.Text = dt.Rows(0).Item(7).ToString
                End With
                frmUpdateTransMeter.ShowIcon = False
                frmUpdateTransMeter.StartPosition = FormStartPosition.CenterScreen
                frmUpdateTransMeter.ShowDialog()
            ElseIf lvwPendList.FocusedItem.SubItems(2).Text = "Name Transfer" Then
                selectedPendingAccountID = arrPendAcctID(lvwPendList.FocusedItem.Index)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT A.AcctID, C.consID, A.AccountNo, C.ConsumerName FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.AcctID=" & selectedPendingAccountID, con)
                da.Fill(dt)
                With frmUpdateNameTransfer
                    SelectedPendingConsumerID = Val(dt.Rows(0).Item(1).ToString)
                    .lblAccountNo.Text = dt.Rows(0).Item(2).ToString
                    .lblConsumerName.Text = dt.Rows(0).Item(3).ToString
                    .ShowIcon = False
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf lvwPendList.FocusedItem.SubItems(2).Text = "Reconnection" Then
                selectedPendingAccountID = arrPendAcctID(lvwPendList.FocusedItem.Index)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT A.AcctID, C.consID, A.AccountNo, C.ConsumerName FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.AcctID=" & selectedPendingAccountID, con)
                da.Fill(dt)
                With frmUpdateReconnection
                    SelectedPendingConsumerID = Val(dt.Rows(0).Item(1).ToString)
                    .lblAccountNo.Text = dt.Rows(0).Item(2).ToString
                    .lblConsumerName.Text = dt.Rows(0).Item(3).ToString
                    .ShowIcon = False
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf lvwPendList.FocusedItem.SubItems(2).Text = "Disconnection" Then
                selectedPendingAccountID = arrPendAcctID(lvwPendList.FocusedItem.Index)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT A.AcctID, C.consID, A.AccountNo, C.ConsumerName FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.AcctID=" & selectedPendingAccountID, con)
                da.Fill(dt)

                With frmUpdateDisconnection
                    SelectedPendingConsumerID = Val(dt.Rows(0).Item(1).ToString)
                    selectedAcctIDforDC = dt.Rows(0).Item(0)
                    .lblAccountNo.Text = dt.Rows(0).Item(2).ToString
                    .lblConsumerName.Text = dt.Rows(0).Item(3).ToString
                    .ShowIcon = False
                    .StartPosition = FormStartPosition.CenterScreen
                    frmDisconnectionUpdate.ShowIcon = False
                    frmDisconnectionUpdate.StartPosition = FormStartPosition.CenterScreen
                    frmDisconnectionUpdate.ShowDialog()
                End With
            ElseIf lvwPendList.FocusedItem.SubItems(2).Text = "Temporary Closure" Then
                selectedPendingAccountID = arrPendAcctID(lvwPendList.FocusedItem.Index)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT A.AcctID, C.consID, A.AccountNo, C.ConsumerName FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.AcctID=" & selectedPendingAccountID, con)
                da.Fill(dt)

                With frmUpdateTemporaryClosure
                    SelectedPendingConsumerID = Val(dt.Rows(0).Item(1).ToString)
                    selectedAcctIDforDC = dt.Rows(0).Item(0)
                    .lblAccountNo.Text = dt.Rows(0).Item(2).ToString
                    .lblConsumerName.Text = dt.Rows(0).Item(3).ToString
                    .txtLastReading.Text = ""
                    .txtPlumber.Text = ""
                    .ShowIcon = False
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowIcon = False
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub lvwPendList_Click(sender As Object, e As EventArgs) Handles lvwPendList.Click
        If lvwPendList.SelectedItems.Count > 0 Then
            btnUpdateAccount.Enabled = True
        Else
            btnUpdateAccount.Enabled = False
        End If
    End Sub

    Private Sub lvwPendList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwPendList.SelectedIndexChanged
        If lvwPendList.SelectedItems.Count > 0 Then
            btnUpdateAccount.Enabled = True
        Else
            btnUpdateAccount.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ViewPendingList(cboFilter.Text, txtSearch.Text.Replace("'", "''"))
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lvwPendList.Items.Count > 0 Then
            Cons()
            Dim da As New MySqlDataAdapter(sqlstrPendingItems, con)
            da.Fill((frmPendingPrintView.ReportDataSet.PendingListDataSet))
            frmPendingPrintView.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            frmPendingPrintView.ReportViewer1.ZoomPercent = 100%
            frmPendingPrintView.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            frmPendingPrintView.ReportViewer1.Width = 75
            frmPendingPrintView.ReportViewer1.RefreshReport()
            frmPendingPrintView.WindowState = FormWindowState.Maximized
            frmPendingPrintView.Show()
            'Me.PendingListDataSetTableAdapter.Fill(Me.ReportDataSet.PendingListDataSet)
        Else
            MsgBox("No list has been loaded", MsgBoxStyle.Information, "Nothing to Print")
        End If
    End Sub
End Class