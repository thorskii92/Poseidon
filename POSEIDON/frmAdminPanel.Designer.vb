<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminPanel))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateBillingDueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckDisconnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactSystemDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAccounting = New System.Windows.Forms.ToolStripButton()
        Me.btnBilling = New System.Windows.Forms.ToolStripButton()
        Me.btnCollection = New System.Windows.Forms.ToolStripButton()
        Me.btnMeterReading = New System.Windows.Forms.ToolStripButton()
        Me.btnReports = New System.Windows.Forms.ToolStripButton()
        Me.btnConsumers = New System.Windows.Forms.ToolStripButton()
        Me.btnConsumerAccounts = New System.Windows.Forms.ToolStripButton()
        Me.btnPendList = New System.Windows.Forms.ToolStripButton()
        Me.btnSequencing = New System.Windows.Forms.ToolStripButton()
        Me.btnApprovalReq = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statlblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPendingStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAccConsCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menTools, Me.menAdmin, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1484, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateBillingDueToolStripMenuItem, Me.MyAccountToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UpdateBillingDueToolStripMenuItem
        '
        Me.UpdateBillingDueToolStripMenuItem.Name = "UpdateBillingDueToolStripMenuItem"
        Me.UpdateBillingDueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.UpdateBillingDueToolStripMenuItem.Text = "Update Billing Due"
        Me.UpdateBillingDueToolStripMenuItem.Visible = False
        '
        'MyAccountToolStripMenuItem
        '
        Me.MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem"
        Me.MyAccountToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.MyAccountToolStripMenuItem.Text = "My Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'menTools
        '
        Me.menTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.menSettings, Me.CheckDisconnectionToolStripMenuItem})
        Me.menTools.Name = "menTools"
        Me.menTools.Size = New System.Drawing.Size(46, 20)
        Me.menTools.Text = "Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        Me.OptionsToolStripMenuItem.Visible = False
        '
        'menSettings
        '
        Me.menSettings.Name = "menSettings"
        Me.menSettings.Size = New System.Drawing.Size(186, 22)
        Me.menSettings.Text = "Settings"
        '
        'CheckDisconnectionToolStripMenuItem
        '
        Me.CheckDisconnectionToolStripMenuItem.Name = "CheckDisconnectionToolStripMenuItem"
        Me.CheckDisconnectionToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CheckDisconnectionToolStripMenuItem.Text = "Check Disconnection"
        '
        'menAdmin
        '
        Me.menAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem1, Me.SystemLogsToolStripMenuItem})
        Me.menAdmin.Name = "menAdmin"
        Me.menAdmin.Size = New System.Drawing.Size(92, 20)
        Me.menAdmin.Text = "Administrator"
        '
        'UsersToolStripMenuItem1
        '
        Me.UsersToolStripMenuItem1.Name = "UsersToolStripMenuItem1"
        Me.UsersToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.UsersToolStripMenuItem1.Text = "Users"
        '
        'SystemLogsToolStripMenuItem
        '
        Me.SystemLogsToolStripMenuItem.Name = "SystemLogsToolStripMenuItem"
        Me.SystemLogsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SystemLogsToolStripMenuItem.Text = "System Logs"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactSystemDeveloperToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContactSystemDeveloperToolStripMenuItem
        '
        Me.ContactSystemDeveloperToolStripMenuItem.Name = "ContactSystemDeveloperToolStripMenuItem"
        Me.ContactSystemDeveloperToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ContactSystemDeveloperToolStripMenuItem.Text = "Contact Us"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAccounting, Me.btnBilling, Me.btnCollection, Me.btnMeterReading, Me.btnReports, Me.btnConsumers, Me.btnConsumerAccounts, Me.btnPendList, Me.btnSequencing, Me.btnApprovalReq, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(134, 837)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAccounting
        '
        Me.btnAccounting.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAccounting.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounting.ForeColor = System.Drawing.Color.White
        Me.btnAccounting.Image = Global.POSEIDON.My.Resources.Resources.Accounting_Icon_1
        Me.btnAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAccounting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAccounting.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccounting.Name = "btnAccounting"
        Me.btnAccounting.Size = New System.Drawing.Size(133, 36)
        Me.btnAccounting.Text = "Accounting"
        Me.btnAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBilling
        '
        Me.btnBilling.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.ForeColor = System.Drawing.Color.White
        Me.btnBilling.Image = Global.POSEIDON.My.Resources.Resources.Billing_Icon
        Me.btnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBilling.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBilling.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(133, 36)
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCollection
        '
        Me.btnCollection.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollection.ForeColor = System.Drawing.Color.White
        Me.btnCollection.Image = Global.POSEIDON.My.Resources.Resources.Collection_Icon_2
        Me.btnCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCollection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCollection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCollection.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(133, 36)
        Me.btnCollection.Text = "Collection"
        Me.btnCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMeterReading
        '
        Me.btnMeterReading.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeterReading.ForeColor = System.Drawing.Color.White
        Me.btnMeterReading.Image = Global.POSEIDON.My.Resources.Resources.Meter_Reading_Icon
        Me.btnMeterReading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMeterReading.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMeterReading.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMeterReading.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMeterReading.Name = "btnMeterReading"
        Me.btnMeterReading.Size = New System.Drawing.Size(133, 36)
        Me.btnMeterReading.Text = "Meter Reading"
        Me.btnMeterReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = Global.POSEIDON.My.Resources.Resources.reports
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReports.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(133, 36)
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConsumers
        '
        Me.btnConsumers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsumers.ForeColor = System.Drawing.Color.White
        Me.btnConsumers.Image = Global.POSEIDON.My.Resources.Resources.consumer_icons
        Me.btnConsumers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsumers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConsumers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsumers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConsumers.Name = "btnConsumers"
        Me.btnConsumers.Size = New System.Drawing.Size(133, 36)
        Me.btnConsumers.Text = "Consumers"
        Me.btnConsumers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConsumerAccounts
        '
        Me.btnConsumerAccounts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsumerAccounts.ForeColor = System.Drawing.Color.White
        Me.btnConsumerAccounts.Image = Global.POSEIDON.My.Resources.Resources.cosumer_Accounts_Icon
        Me.btnConsumerAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsumerAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConsumerAccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsumerAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConsumerAccounts.Name = "btnConsumerAccounts"
        Me.btnConsumerAccounts.Size = New System.Drawing.Size(133, 36)
        Me.btnConsumerAccounts.Text = "Accounts"
        Me.btnConsumerAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPendList
        '
        Me.btnPendList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendList.ForeColor = System.Drawing.Color.White
        Me.btnPendList.Image = Global.POSEIDON.My.Resources.Resources.pendings_Icon
        Me.btnPendList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPendList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPendList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPendList.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPendList.Name = "btnPendList"
        Me.btnPendList.Size = New System.Drawing.Size(133, 36)
        Me.btnPendList.Text = "Pending List"
        Me.btnPendList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSequencing
        '
        Me.btnSequencing.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSequencing.ForeColor = System.Drawing.Color.White
        Me.btnSequencing.Image = Global.POSEIDON.My.Resources.Resources.sequence_Icon
        Me.btnSequencing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSequencing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSequencing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSequencing.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSequencing.Name = "btnSequencing"
        Me.btnSequencing.Size = New System.Drawing.Size(133, 36)
        Me.btnSequencing.Text = "Sequencing"
        Me.btnSequencing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnApprovalReq
        '
        Me.btnApprovalReq.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprovalReq.ForeColor = System.Drawing.Color.White
        Me.btnApprovalReq.Image = Global.POSEIDON.My.Resources.Resources.approvals_icon
        Me.btnApprovalReq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprovalReq.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnApprovalReq.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApprovalReq.Margin = New System.Windows.Forms.Padding(0)
        Me.btnApprovalReq.Name = "btnApprovalReq"
        Me.btnApprovalReq.Size = New System.Drawing.Size(133, 36)
        Me.btnApprovalReq.Text = "Approvals"
        Me.btnApprovalReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.POSEIDON.My.Resources.Resources.note_icon
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(133, 36)
        Me.ToolStripButton1.Text = "Notes"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statlblUser, Me.lblPendingStatus, Me.lblAccConsCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(134, 839)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statlblUser
        '
        Me.statlblUser.BackColor = System.Drawing.SystemColors.Control
        Me.statlblUser.Name = "statlblUser"
        Me.statlblUser.Size = New System.Drawing.Size(33, 17)
        Me.statlblUser.Text = "User:"
        '
        'lblPendingStatus
        '
        Me.lblPendingStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblPendingStatus.Name = "lblPendingStatus"
        Me.lblPendingStatus.Size = New System.Drawing.Size(569, 17)
        Me.lblPendingStatus.Text = "Pending Accounts(|Installation: 0 |Disconnection: 0 | Reconnection: 0 | Name Tran" &
    "sfer: 0 |Meter Transfer: 0 |)"
        '
        'lblAccConsCount
        '
        Me.lblAccConsCount.BackColor = System.Drawing.SystemColors.Control
        Me.lblAccConsCount.Name = "lblAccConsCount"
        Me.lblAccConsCount.Size = New System.Drawing.Size(733, 17)
        Me.lblAccConsCount.Spring = True
        Me.lblAccConsCount.Text = "Accounts and Consumers"
        Me.lblAccConsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'frmAdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1484, 861)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1500, 850)
        Me.Name = "frmAdminPanel"
        Me.Text = "Administrator Panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAccounting As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReports As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMeterReading As System.Windows.Forms.ToolStripButton
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactSystemDeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCollection As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBilling As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnConsumers As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsumerAccounts As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPendList As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSequencing As System.Windows.Forms.ToolStripButton
    Friend WithEvents UpdateBillingDueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statlblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPendingStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckDisconnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAccConsCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnApprovalReq As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
End Class
