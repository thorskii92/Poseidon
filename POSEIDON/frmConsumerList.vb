Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmConsumerList

    Private Sub btnNewConsumer_Click(sender As Object, e As EventArgs) Handles btnNewConsumer.Click
        TypeNewCons = 1
        frmNewConsumer.Text = "New Consumer"
        frmNewConsumer.txtAddress.Text = ""
        frmNewConsumer.txtContact.Text = ""
        frmNewConsumer.txtName.Text = ""
        frmNewConsumer.ShowDialog()
    End Sub

    Private Sub lvwConsumerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwConsumerList.SelectedIndexChanged
        'MessageBox.Show("show me")
        lvwAccountList.Items.Clear()
        FalseVisibilityButtons()
        If lvwConsumerList.SelectedItems.Count > 0 Then
            lvwAccountList.Items.Clear()
            'selConsumerID = arrConsumerID(lvwConsumerList.FocusedItem.Index + (curPageNumConsumer * 100))
            selConsumerID = arrConsumerID(Val(lvwConsumerList.FocusedItem.SubItems(2).Text) - 1)
            ViewPaymentHistory(selConsumerID)
            btnAddAccount.Visible = True
            btnAddAccount.Enabled = True
            btnUpdateAccount.Enabled = True
            btnDisableAccount.Enabled = True
            btnViewAccount.Enabled = True
            btnViewOR.Visible = False
            ViewAccountList()
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE consID=" & selConsumerID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                btnRemoveConsumer.Visible = False
                lblTotAccounts.Visible = True
                lblTotAccounts.Text = "Total Number of Accounts: " & dt.Rows.Count
            Else
                btnRemoveConsumer.Visible = True
                lblTotAccounts.Visible = False
            End If
        Else
            btnAddAccount.Visible = False
            btnAddAccount.Enabled = False
            btnUpdateAccount.Enabled = False
            btnDisableAccount.Enabled = False
            btnViewAccount.Enabled = False
            btnViewOR.Visible = False
            ViewAccountList()
            lvwAccountList.Items.Clear()
        End If
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
       
        frmNewAccount.StartPosition = FormStartPosition.CenterScreen
        frmNewAccount.txtAccount.Text = ""
        frmNewAccount.txtName.Text = ""
        frmNewAccount.txtReceipt.Text = ""
        frmNewAccount.txtSeq.Text = ""
        frmNewAccount.txtStreetAddress.Text = ""
        frmNewAccount.cboBrgy.Items.Clear()
        frmNewAccount.cboClass.Items.Clear()
        frmNewAccount.cboCluster.Items.Clear()
        frmNewAccount.cboMun.Items.Clear()
        frmNewAccount.cboProv.Items.Clear()
        nComboProvList()
        nComboClassification()
        selConsumerID = arrConsumerID(lvwConsumerList.FocusedItem.Index)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist WHERE consid=" & selConsumerID, con)
        da.Fill(dt)
        frmNewAccount.txtName.Text = dt.Rows(0).Item(1).ToString
        frmNewAccount.senID = dt.Rows(0).Item(5).ToString
        frmNewAccount.isSen = dt.Rows(0).Item(4).ToString
        frmNewAccount.ShowDialog()
    End Sub

    Private Sub frmConsumerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvwPaymentHistory.Items.Clear()
        curPageNumConsumer = 0
        btnViewOR.Visible = False
        ViewConsumerList(txtSearchConsumer.Text.Replace("'", "`"))
        FalseVisibilityButtons()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist", con)
        da.Fill(dt)
        lblTotConsumers.Text = "Total Consumers: " & dt.Rows.Count
        lblTotAccounts.Visible = False
    End Sub

    Private Sub btnViewAccount_Click(sender As Object, e As EventArgs) Handles btnViewAccount.Click
        If lvwAccountList.SelectedItems.Count > 0 Then
            selectedAcctIDLedger = arrSelectedAcctID(lvwAccountList.FocusedItem.Index)
            ViewLedger(selectedAcctIDLedger)
            frmAccountLedger.StartPosition = FormStartPosition.CenterScreen
            frmAccountLedger.WindowState = FormWindowState.Maximized
            frmAccountLedger.ShowDialog()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        curPageNumConsumer = 0
        ViewConsumerList(txtSearchConsumer.Text.Replace("'", "`"))
        FalseVisibilityButtons()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        curPageNumConsumer = 0
        txtSearchConsumer.Text = ""
        ViewConsumerList(txtSearchConsumer.Text.Replace("'", "`"))
    End Sub

    Private Sub FalseVisibilityButtons()
        btnAddAccount.Visible = False
        btnDisableAccount.Visible = False
        btnUpdateAccount.Visible = False
        btnViewAccount.Visible = False
        btnTransferMeter.Visible = False
        btnTransferOwner.Visible = False
        btnDeleteAccount.Visible = False
        btnForceConnection.Visible = False
        btnDisc.Visible = False
    End Sub

    Private Sub lvwAccountList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwAccountList.SelectedIndexChanged
        Cons()
        ButtonDisablers()
        If lvwAccountList.SelectedItems.Count > 0 Then
            btnViewAccount.Visible = True
            btnChangeConsumer.Visible = True
            btnChangeConsumer.Enabled = True
            btnDeleteAccount.Visible = True
            btnDeleteAccount.Enabled = True
            btnDisc.Enabled = True
            btnDisc.Visible = True
            btnForceConnection.Visible = True
            btnForceConnection.Enabled = True
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT S.statusName FROM consumeraccounts A LEFT JOIN accountstatus AS S ON A.acctStatus=S.staID WHERE acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
            da.Fill(dt)
            Dim getStat As String = dt.Rows(0).Item(0).ToString
            If getStat = "Connected" Then
                btnDisableAccount.Visible = True
                btnUpdateAccount.Visible = True
                btnTransferMeter.Visible = True
                btnTransferOwner.Visible = True
                btnDisableAccount.Visible = True
                btnUpdateAccount.Enabled = True
                btnTransferMeter.Enabled = True
                btnTransferOwner.Enabled = True
                btnDisableAccount.Enabled = True
            ElseIf getStat = "Disabled" Then
                btnTransferMeter.Visible = True
                btnTransferOwner.Visible = True
                btnDisconnect.Visible = True
                btnEnable.Visible = True
                btnTransferMeter.Enabled = True
                btnTransferOwner.Enabled = True
                btnDisconnect.Enabled = True
                btnEnable.Enabled = True
            ElseIf getStat = "Disconnected" Then
                btnReconnect.Visible = True
                btnReconnect.Enabled = True
            ElseIf getStat = "Disconnection" Then

            ElseIf getStat = "Transfer Meter" Then

            ElseIf getStat = "Transfer Owner" Then

            ElseIf getStat = "Reconnection" Then

            ElseIf getStat = "Installation" Then
                btnViewAccount.Visible = True
                btnViewAccount.Enabled = True
            ElseIf getStat = "Temporary Closed" Then
                btnReconnect.Visible = True
                btnReconnect.Enabled = True
            End If
        Else
            btnViewAccount.Visible = False
            btnChangeConsumer.Visible = False
            btnChangeConsumer.Enabled = False
            btnDeleteAccount.Visible = False
            btnDeleteAccount.Enabled = False
            btnDisc.Enabled = False
            btnDisc.Visible = False
            btnForceConnection.Visible = False
            btnForceConnection.Enabled = False
        End If

    End Sub

    Private Sub btnUpdateConsumer_Click(sender As Object, e As EventArgs) Handles btnUpdateConsumer.Click
        If lvwConsumerList.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist WHERE consID=" & arrConsumerID(lvwConsumerList.FocusedItem.Index), con)
            da.Fill(dt)
            TypeNewCons = 1
            Dim isSen As String = dt.Rows(0).Item(4).ToString
            If isSen = "YES" Then
                frmNewConsumer.CheckBox1.Checked = True
            Else
                frmNewConsumer.CheckBox1.Checked = False
            End If
            selConsUpID = dt.Rows(0).Item(0).ToString
            frmNewConsumer.txtAddress.Text = dt.Rows(0).Item(2).ToString
            frmNewConsumer.txtContact.Text = dt.Rows(0).Item(3).ToString
            frmNewConsumer.txtName.Text = dt.Rows(0).Item(1).ToString
            frmNewConsumer.cboGender.Text = dt.Rows(0).Item(7).ToString
            frmNewConsumer.txtAgency.Text = dt.Rows(0).Item(6).ToString
            frmNewConsumer.txtSenID.Text = dt.Rows(0).Item(5).ToString
            frmNewConsumer.Text = "Update Consumer"
            frmNewConsumer.ShowDialog()
        End If

    End Sub

    Private Sub ButtonDisablers()
        btnDisableAccount.Visible = False
        btnUpdateAccount.Visible = False
        btnTransferMeter.Visible = False
        btnTransferOwner.Visible = False
        btnDisconnect.Visible = False
        btnReconnect.Visible = False
        btnEnable.Visible = False
        btnDisableAccount.Enabled = False
        btnUpdateAccount.Enabled = False
        btnTransferMeter.Enabled = False
        btnTransferOwner.Enabled = False
        btnDisconnect.Enabled = False
        btnReconnect.Enabled = False
        btnEnable.Enabled = False
    End Sub

    Private Sub txtSearchConsumer_Click(sender As Object, e As EventArgs) Handles txtSearchConsumer.Click
        
    End Sub

    Private Sub btnDisableAccount_Click(sender As Object, e As EventArgs) Handles btnDisableAccount.Click
        If lvwAccountList.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                acctTempCloseID = arrSelectedAcctID(lvwAccountList.FocusedItem.Index)
                frmTemporaryClose.dtpDate.Value = Now.Date
                frmTemporaryClose.lblAccountName.Text = dt.Rows(0).Item(18).ToString
                frmTemporaryClose.lblAccountNo.Text = dt.Rows(0).Item(6).ToString
                frmTemporaryClose.StartPosition = FormStartPosition.CenterScreen
                frmTemporaryClose.txtReason.Text = ""
                frmTemporaryClose.ShowDialog()
            End If
        End If

    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        If lvwAccountList.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select a.acctid, c.consID, c.consumername, a.accountno ,a.meterReference FROM consumeraccounts as a left join consumerlist as c on a.consID=c.consID WHERE a.acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmEnterAdminPassword.ShowDialog()
                If authenticate = True Then
                    selectedAcctIDReferenceChange = Val(dt.Rows(0).Item(0).ToString)
                    frmUpdateReference.lblAccount.Text = dt.Rows(0).Item(3).ToString
                    frmUpdateReference.lblConsumer.Text = dt.Rows(0).Item(2).ToString
                    frmUpdateReference.lblReference.Text = dt.Rows(0).Item(4).ToString
                    frmUpdateReference.txtNewReference.Text = ""
                    frmUpdateReference.ShowDialog()
                End If
            End If
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Exclamation, "Nothing selected")
        End If
    End Sub

    Private Sub btnTransferOwner_Click(sender As Object, e As EventArgs) Handles btnTransferOwner.Click
        If Me.lvwAccountList.SelectedItems.Count > 0 Then
            If CheckAccountBalance(arrSelectedAcctID(lvwAccountList.FocusedItem.Index), lvwAccountList.FocusedItem.Text) = True Then
                TransferShow(arrSelectedAcctID(lvwAccountList.FocusedItem.Index))
            Else
                MsgBox(lvwAccountList.FocusedItem.Text & " still has a balance of Php" & Format(consBalance, "#,###0.#0") & ", Please settle remaining balance before proceeding to Transfer of Ownership")
                Exit Sub
            End If
        End If
    End Sub


    Private Sub btnTransferMeter_Click(sender As Object, e As EventArgs) Handles btnTransferMeter.Click
        If Me.lvwAccountList.SelectedItems.Count > 0 Then
            If CheckAccountBalance(arrSelectedAcctID(lvwAccountList.FocusedItem.Index), lvwAccountList.FocusedItem.Text) = True Then
                TransMeterShow(arrSelectedAcctID(lvwAccountList.FocusedItem.Index))
            Else
                MsgBox(lvwAccountList.FocusedItem.Text & " still has a balance of Php" & Format(consBalance, "#,###0.#0") & ", Please settle remaining balance before proceeding to Transfer of Water Meter")
                Exit Sub
            End If
        End If
    End Sub

    

    Private Sub btnReconnect_Click(sender As Object, e As EventArgs) Handles btnReconnect.Click
        If lvwAccountList.SelectedItems.Count > 0 Then
            If CheckAccountBalance(arrSelectedAcctID(lvwAccountList.FocusedItem.Index), lvwAccountList.FocusedItem.Text) = True Then
                ReconnectShow(arrSelectedAcctID(lvwAccountList.FocusedItem.Index))
            Else
                MsgBox(lvwAccountList.FocusedItem.Text & " still has a balance of Php" & Format(consBalance, "#,###0.#0") & ", Please settle remaining balance before proceeding to Reconnection")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ReconnectShow(ByVal aID As Integer)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT A.acctID, C.consID, A.AccountNo, C.Consumername FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.AcctID=" & aID, con)
        da.Fill(dt)
        frmReconnection.lblConsName.Text = dt.Rows(0).Item(3).ToString
        frmReconnection.lblAccount.Text = dt.Rows(0).Item(2).ToString
        frmReconnection.txtOR.Text = ""
        RecAcctID = aID
        RecConsID = Val(dt.Rows(0).Item(1).ToString)
        frmReconnection.StartPosition = FormStartPosition.CenterScreen
        frmReconnection.ShowIcon = False
        frmReconnection.ShowInTaskbar = False
        frmReconnection.ShowDialog()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        If lvwAccountList.SelectedItems.Count > 0 Then
            If MsgBox("Force Account for Disconnection?", MsgBoxStyle.YesNo, "Force Disconnection") = MsgBoxResult.Yes Then
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET acctstatus=4 WHERE acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                MsgBox("Account has been set for Disconnection and has been listed on Pending List", MsgBoxStyle.Information, "Disconnection Confirmed")
                ViewAccountList()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtSearchConsumer_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchConsumer.KeyUp
        If e.KeyCode = Keys.Enter Then
            ViewConsumerList(txtSearchConsumer.Text.Replace("'", "`"))
        End If
    End Sub

    Private Sub txtSearchConsumer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchConsumer.KeyPress

    End Sub

    Private Sub btnChangeConsumer_Click(sender As Object, e As EventArgs) Handles btnChangeConsumer.Click
        authenticate = False
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            frmChangeConsumer.StartPosition = FormStartPosition.CenterScreen
            'selectedAcctIDLedger = arrSelectedAcctID(lvwAccountList.FocusedItem.Index)
            selectedAcctIChangeConsumer = arrSelectedAcctID(lvwAccountList.FocusedItem.Index)
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT A.acctID, A.consID, A.accountNo, C.consumername FROM consumeraccounts AS A LEFT JOIN consumerlist AS C ON A.consID=C.consID WHERE A.acctID=" & selectedAcctIChangeConsumer, con)
            da.Fill(dt)
            frmChangeConsumer.lblAccount.Text = dt.Rows(0).Item(2).ToString
            frmChangeConsumer.lblOriginal.Text = dt.Rows(0).Item(3).ToString
            frmChangeConsumer.ShowDialog()
        End If
    End Sub

    Private Sub btnRemoveConsumer_Click(sender As Object, e As EventArgs) Handles btnRemoveConsumer.Click
        authenticate = False
        frmEnterAdminPassword.ShowDialog()
        If authenticate = True Then
            If MessageBox.Show("Confirm removal of consumer?", "Remove Consumer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM consumerlist WHERE consID=" & arrConsumerID(lvwConsumerList.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Consumer has been removed", "Consumer Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ViewConsumerList(txtSearchConsumer.Text.Replace("'", "`"))
                FalseVisibilityButtons()
            End If
        End If

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        curPageNumConsumer = curPageNumConsumer - 1
        ViewConsumerPage(curPageNumConsumer)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        curPageNumConsumer = curPageNumConsumer + 1
        ViewConsumerPage(curPageNumConsumer)
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        If MessageBox.Show("Delete Selected Account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("DELETE FROM consumeraccounts WHERE acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account has been deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ViewAccountList()
        End If
    End Sub

    Private Sub btnDisc_Click(sender As Object, e As EventArgs) Handles btnDisc.Click
        If MessageBox.Show("Confirm Force Disconnection of Account", "Disconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET acctstatus=2 WHERE acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account has been disconnected", "Account Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ViewAccountList()
        End If
    End Sub

    Private Sub btnForceConnection_Click(sender As Object, e As EventArgs) Handles btnForceConnection.Click
        If MessageBox.Show("Confirm Force Connection of Account", "Connect Account", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET acctstatus=1 WHERE acctID=" & arrSelectedAcctID(lvwAccountList.FocusedItem.Index), con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account has been Connected", "Account Connected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ViewAccountList()
        End If
    End Sub

    Private Sub btnViewOR_Click(sender As Object, e As EventArgs) Handles btnViewOR.Click
        If lvwPaymentHistory.SelectedItems.Count > 0 Then
            Cons()
            Dim dtR As New DataTable
            Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lvwPaymentHistory.FocusedItem.SubItems(3).Text & "'", con)
            'daR.Fill(dtR)
            'frmORReport.reportingdataset.ORDataTable.Clear()
            'daR.Fill(frmORReport.reportingdataset.ORDataTable)
            ''frmORReport.ORReport.Refresh()
            'frmORReport.ORReport.RefreshReport()
            'frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            'frmORReport.ORReport.ZoomPercent = 100%
            'frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            'frmORReport.ORReport.Width = 75
            'frmORReport.WindowState = FormWindowState.Maximized
            'frmORReport.ShowDialog()

            'Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lblOR.Text & "'", con)
            'Dim dSet As New reportingdataset
            ''da.Fill(dSet)
            daR.Fill(dtR)
            Dim report As New crptOR
            report.SetDataSource(dtR)
            frmCrystalOR.CrystalReportViewer1.ReportSource = report
            frmCrystalOR.CrystalReportViewer1.Zoom(100%)
            frmCrystalOR.CrystalReportViewer1.Refresh()
            'frmCrystalOR.CrystalReportViewer1.RefreshReport()
            frmCrystalOR.WindowState = FormWindowState.Maximized
            frmCrystalOR.ShowDialog()
        End If
    End Sub

    Private Sub lvwPaymentHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwPaymentHistory.SelectedIndexChanged
        If lvwPaymentHistory.SelectedItems.Count > 0 Then
            btnViewOR.Visible = True
        Else
            btnViewOR.Visible = False
        End If
    End Sub
End Class