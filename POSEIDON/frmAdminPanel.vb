Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAdminPanel

    Private Sub CloseChildForms()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub Tabs(index As Integer)
        Dim tab As Integer
        tab = index
        Call CloseChildForms()
        If tab = 0 Then
            frmCustomers.MdiParent = Me
            frmCustomers.WindowState = FormWindowState.Maximized
            frmCustomers.Show()
        End If
    End Sub

    Private Sub frmAdminPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Confirm Exit?", MsgBoxStyle.YesNo, "Exit Poseidon") = MsgBoxResult.Yes Then
            InsertLog(loggedUserID, "Log", "Exit", "Exit Only")
            UserLogData(loggedUserID, "Logout")
            If closingSelect = 2 Then
                closingSelect = 1
                InsertLog(loggedUserID, "Log", "Login Form", "Logout Only")
                frmLog.Show()
            End If
        Else
            closingSelect = 1
            e.Cancel = True
        End If

    End Sub

    Private Sub frmAdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(loggedUserID)
        closingSelect = 1
        loggedID = 0
        Cons()
        PendingStatus()
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        TabSelection(3)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles btnMeterReading.Click
        TabSelection(4)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        TabSelection(2)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles btnConsumers.Click
        TabSelection(6)
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles btnPendList.Click
        TabSelection(8)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnAccounting.Click
        TabSelection(1)
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles btnSequencing.Click
        TabSelection(9)
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles btnConsumerAccounts.Click
        TabSelection(7)
    End Sub

    Private Sub UpdateBillingDueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBillingDueToolStripMenuItem.Click
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT metID, DueDate FROM meterReading WHERE metStatus='UNPAID'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim arMetID(dt.Rows.Count - 1) As Integer
            Dim arDueDate(dt.Rows.Count - 1) As Date
            Dim getRange(dt.Rows.Count - 1) As Integer
            For x As Integer = 0 To dt.Rows.Count - 1
                arMetID(x) = Val(dt.Rows(x).Item(0).ToString)
                arDueDate(x) = dt.Rows(x).Item(1)
                getRange(x) = DateRange(arDueDate(x), Now.Date)
                If getRange(x) < 0 Then
                    Dim cmdUpdateDue As New MySqlCommand("UPDATE meterReading SET metStatus='LAPSE' WHERE metID=" & arMetID(x), con)
                    cmdUpdateDue.ExecuteNonQuery()
                End If
            Next
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        TabSelection(5)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menSettings.Click
        frmSettings.StartPosition = FormStartPosition.CenterScreen
        frmSettings.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        closingSelect = 2
        Me.Close()
    End Sub

    Private Sub CheckDisconnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckDisconnectionToolStripMenuItem.Click
        frmDisconnectionList.WindowState = FormWindowState.Maximized
        frmDisconnectionList.ShowDialog()
    End Sub

    Private Sub ContactSystemDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactSystemDeveloperToolStripMenuItem.Click
        frmHelp.StartPosition = FormStartPosition.CenterScreen
        frmHelp.ShowDialog()
    End Sub

    Private Sub ChangeColor()
        btnAccounting.BackColor = Color.SteelBlue
        btnBilling.BackColor = Color.SteelBlue
        btnCollection.BackColor = Color.SteelBlue
        btnConsumerAccounts.BackColor = Color.SteelBlue
        btnConsumers.BackColor = Color.SteelBlue
        btnMeterReading.BackColor = Color.SteelBlue
        btnPendList.BackColor = Color.SteelBlue
        btnReports.BackColor = Color.SteelBlue
        btnSequencing.BackColor = Color.SteelBlue
        btnApprovalReq.BackColor = Color.SteelBlue
    End Sub

    Private Sub TabSelection(i As Integer)
        Call CloseChildForms()
        ChangeColor()

        If i = 1 Then
            MsgBox("Unavailable", MsgBoxStyle.Information, "Unavailable")
        ElseIf i = 2 Then
            btnBilling.BackColor = Color.DeepSkyBlue
            frmBilling.MdiParent = Me
            frmBilling.WindowState = FormWindowState.Maximized
            frmBilling.ShowIcon = False
            frmBilling.Show()
        ElseIf i = 3 Then
            btnCollection.BackColor = Color.DeepSkyBlue
            'paymentMenu.MdiParent = Me
            'paymentMenu.StartPosition = FormStartPosition.CenterParent
            'paymentMenu.WindowState = FormWindowState.Maximized
            'paymentMenu.Show()
            'Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT * FROM userlist WHERE uID=" & loggedUserID, con)
            'da.Fill(dt)
            WaterBillPayment.lblCollectionOfficer.Text = ""
            WaterBillPayment.MdiParent = Me
            WaterBillPayment.WindowState = FormWindowState.Maximized
            WaterBillPayment.StartPosition = FormStartPosition.CenterParent
            WaterBillPayment.Show()

            'Me.Close()
        ElseIf i = 4 Then
            MetReadForValsClear()
            MetReadEnabler()
            btnMeterReading.BackColor = Color.DeepSkyBlue
            'frmMeterReading.MdiParent = Me
            'frmMeterReading.WindowState = FormWindowState.Maximized
            'frmMeterReading.Show()
            frmNewMeterReader.MdiParent = Me
            frmNewMeterReader.WindowState = FormWindowState.Maximized
            frmNewMeterReader.Show()
        ElseIf i = 5 Then
            btnReports.BackColor = Color.DeepSkyBlue
            frmReportMenu.MdiParent = Me
            frmReportMenu.WindowState = FormWindowState.Maximized
            frmReportMenu.Show()
        ElseIf i = 6 Then
            btnConsumers.BackColor = Color.DeepSkyBlue
            frmConsumerList.MdiParent = Me
            frmConsumerList.WindowState = FormWindowState.Maximized
            frmConsumerList.txtSearchConsumer.Text = ""
            frmConsumerList.Show()
        ElseIf i = 7 Then
            btnConsumerAccounts.BackColor = Color.DeepSkyBlue
            acctFormProvListCombo()
            frmAccountsList.MdiParent = Me
            frmAccountsList.WindowState = FormWindowState.Maximized
            frmAccountsList.Show()
        ElseIf i = 8 Then
            btnPendList.BackColor = Color.DeepSkyBlue
            frmPendingMenu.MdiParent = Me
            frmPendingMenu.WindowState = FormWindowState.Maximized
            frmPendingMenu.Show()


        ElseIf i = 9 Then
            btnSequencing.BackColor = Color.DeepSkyBlue
            frmSequencing.MdiParent = Me
            frmSequencing.WindowState = FormWindowState.Maximized
            frmSequencing.Show()
        ElseIf i = 10 Then
            btnApprovalReq.BackColor = Color.DeepSkyBlue
            frmApprovalRequests.MdiParent = Me
            frmApprovalRequests.WindowState = FormWindowState.Maximized
            frmApprovalRequests.Show()
        End If
    End Sub

    Private Sub ImportExcelToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MyAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyAccountToolStripMenuItem.Click
        myAccountInfo(loggedUserID)
        frmUserAccount.ShowInTaskbar = False
        frmUserAccount.StartPosition = FormStartPosition.CenterScreen
        frmUserAccount.ShowDialog()
    End Sub

    Private Sub UsersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem1.Click
        frmSystemUsers.StartPosition = FormStartPosition.CenterScreen
        frmSystemUsers.ShowInTaskbar = False
        frmSystemUsers.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        closingSelect = 1
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnApprovalReq.Click
        TabSelection(10)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmNotes.StartPosition = FormStartPosition.CenterScreen
        frmNotes.ShowDialog()
    End Sub

    Private Sub SystemLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemLogsToolStripMenuItem.Click
        frmSystemHistory.ShowDialog()
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        PendingStatus()
       
    End Sub
End Class