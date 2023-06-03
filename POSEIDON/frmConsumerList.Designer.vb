<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsumerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsumerList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvwConsumerList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotConsumers = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnNewConsumer = New System.Windows.Forms.ToolStripButton()
        Me.btnUpdateConsumer = New System.Windows.Forms.ToolStripButton()
        Me.btnViewConsumer = New System.Windows.Forms.ToolStripButton()
        Me.btnRemoveConsumer = New System.Windows.Forms.ToolStripButton()
        Me.btnPrev = New System.Windows.Forms.ToolStripButton()
        Me.lblPage = New System.Windows.Forms.ToolStripLabel()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearchConsumer = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAddAccount = New System.Windows.Forms.ToolStripButton()
        Me.btnViewAccount = New System.Windows.Forms.ToolStripButton()
        Me.btnDisableAccount = New System.Windows.Forms.ToolStripButton()
        Me.btnUpdateAccount = New System.Windows.Forms.ToolStripButton()
        Me.btnTransferOwner = New System.Windows.Forms.ToolStripButton()
        Me.btnTransferMeter = New System.Windows.Forms.ToolStripButton()
        Me.btnDisconnect = New System.Windows.Forms.ToolStripButton()
        Me.btnReconnect = New System.Windows.Forms.ToolStripButton()
        Me.btnEnable = New System.Windows.Forms.ToolStripButton()
        Me.btnChangeConsumer = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteAccount = New System.Windows.Forms.ToolStripButton()
        Me.btnDisc = New System.Windows.Forms.ToolStripButton()
        Me.btnForceConnection = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblTotAccounts = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lvwAccountList = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Barangay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwPaymentHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewOR = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvwConsumerList)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.ToolStrip3)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 570)
        Me.Panel1.TabIndex = 0
        '
        'lvwConsumerList
        '
        Me.lvwConsumerList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader10})
        Me.lvwConsumerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwConsumerList.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwConsumerList.FullRowSelect = True
        Me.lvwConsumerList.GridLines = True
        Me.lvwConsumerList.HideSelection = False
        Me.lvwConsumerList.Location = New System.Drawing.Point(0, 63)
        Me.lvwConsumerList.MultiSelect = False
        Me.lvwConsumerList.Name = "lvwConsumerList"
        Me.lvwConsumerList.Size = New System.Drawing.Size(572, 485)
        Me.lvwConsumerList.TabIndex = 4
        Me.lvwConsumerList.UseCompatibleStateImageBehavior = False
        Me.lvwConsumerList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "Consumer Name"
        Me.ColumnHeader1.Width = 255
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 2
        Me.ColumnHeader2.Text = "Accounts"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.DisplayIndex = 0
        Me.ColumnHeader10.Text = "#"
        Me.ColumnHeader10.Width = 45
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotConsumers})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(572, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTotConsumers
        '
        Me.lblTotConsumers.Name = "lblTotConsumers"
        Me.lblTotConsumers.Size = New System.Drawing.Size(107, 17)
        Me.lblTotConsumers.Text = "Total Consumers: 0"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewConsumer, Me.btnUpdateConsumer, Me.btnViewConsumer, Me.btnRemoveConsumer, Me.btnPrev, Me.lblPage, Me.btnNext})
        Me.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(572, 32)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnNewConsumer
        '
        Me.btnNewConsumer.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnNewConsumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNewConsumer.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewConsumer.Image = CType(resources.GetObject("btnNewConsumer.Image"), System.Drawing.Image)
        Me.btnNewConsumer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewConsumer.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.btnNewConsumer.Name = "btnNewConsumer"
        Me.btnNewConsumer.Size = New System.Drawing.Size(101, 21)
        Me.btnNewConsumer.Text = "New Consumer"
        '
        'btnUpdateConsumer
        '
        Me.btnUpdateConsumer.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnUpdateConsumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpdateConsumer.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateConsumer.Image = CType(resources.GetObject("btnUpdateConsumer.Image"), System.Drawing.Image)
        Me.btnUpdateConsumer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdateConsumer.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.btnUpdateConsumer.Name = "btnUpdateConsumer"
        Me.btnUpdateConsumer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnUpdateConsumer.Size = New System.Drawing.Size(124, 21)
        Me.btnUpdateConsumer.Text = "Update Consumer"
        '
        'btnViewConsumer
        '
        Me.btnViewConsumer.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnViewConsumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewConsumer.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewConsumer.Image = CType(resources.GetObject("btnViewConsumer.Image"), System.Drawing.Image)
        Me.btnViewConsumer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewConsumer.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.btnViewConsumer.Name = "btnViewConsumer"
        Me.btnViewConsumer.Size = New System.Drawing.Size(83, 21)
        Me.btnViewConsumer.Text = "View Details"
        Me.btnViewConsumer.Visible = False
        '
        'btnRemoveConsumer
        '
        Me.btnRemoveConsumer.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnRemoveConsumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRemoveConsumer.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveConsumer.Image = CType(resources.GetObject("btnRemoveConsumer.Image"), System.Drawing.Image)
        Me.btnRemoveConsumer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveConsumer.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.btnRemoveConsumer.Name = "btnRemoveConsumer"
        Me.btnRemoveConsumer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnRemoveConsumer.Size = New System.Drawing.Size(128, 21)
        Me.btnRemoveConsumer.Text = "Remove Consumer"
        Me.btnRemoveConsumer.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPrev.AutoSize = False
        Me.btnPrev.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrev.Image = Global.POSEIDON.My.Resources.Resources.LEFT_ARROW
        Me.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(29, 29)
        Me.btnPrev.Text = "Previous"
        '
        'lblPage
        '
        Me.lblPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(48, 18)
        Me.lblPage.Text = "1 of 10"
        '
        'btnNext
        '
        Me.btnNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnNext.AutoSize = False
        Me.btnNext.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Image = Global.POSEIDON.My.Resources.Resources.RIGHT_ARROW
        Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNext.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(29, 29)
        Me.btnNext.Text = "Next"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSearchConsumer, Me.btnSearch, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(572, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(119, 28)
        Me.ToolStripLabel1.Text = "Search Consumer:"
        '
        'txtSearchConsumer
        '
        Me.txtSearchConsumer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchConsumer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchConsumer.Margin = New System.Windows.Forms.Padding(1, 3, 1, 2)
        Me.txtSearchConsumer.Name = "txtSearchConsumer"
        Me.txtSearchConsumer.Size = New System.Drawing.Size(150, 26)
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(53, 27)
        Me.btnSearch.Text = "Search"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(88, 27)
        Me.ToolStripButton1.Text = "Clear Search"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddAccount, Me.btnViewAccount, Me.btnDisableAccount, Me.btnUpdateAccount, Me.btnTransferOwner, Me.btnTransferMeter, Me.btnDisconnect, Me.btnReconnect, Me.btnEnable, Me.btnChangeConsumer, Me.btnDeleteAccount, Me.btnDisc, Me.btnForceConnection})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(572, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(960, 29)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAddAccount
        '
        Me.btnAddAccount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAddAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAddAccount.Enabled = False
        Me.btnAddAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAccount.Image = CType(resources.GetObject("btnAddAccount.Image"), System.Drawing.Image)
        Me.btnAddAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(80, 19)
        Me.btnAddAccount.Text = "Add Account"
        '
        'btnViewAccount
        '
        Me.btnViewAccount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnViewAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewAccount.Enabled = False
        Me.btnViewAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAccount.Image = CType(resources.GetObject("btnViewAccount.Image"), System.Drawing.Image)
        Me.btnViewAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.btnViewAccount.Name = "btnViewAccount"
        Me.btnViewAccount.Size = New System.Drawing.Size(86, 19)
        Me.btnViewAccount.Text = "View Account"
        Me.btnViewAccount.Visible = False
        '
        'btnDisableAccount
        '
        Me.btnDisableAccount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDisableAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDisableAccount.Enabled = False
        Me.btnDisableAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisableAccount.Image = CType(resources.GetObject("btnDisableAccount.Image"), System.Drawing.Image)
        Me.btnDisableAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDisableAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDisableAccount.Name = "btnDisableAccount"
        Me.btnDisableAccount.Size = New System.Drawing.Size(102, 19)
        Me.btnDisableAccount.Text = "Temporary Close"
        Me.btnDisableAccount.Visible = False
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnUpdateAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpdateAccount.Enabled = False
        Me.btnUpdateAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAccount.Image = CType(resources.GetObject("btnUpdateAccount.Image"), System.Drawing.Image)
        Me.btnUpdateAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdateAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Size = New System.Drawing.Size(89, 19)
        Me.btnUpdateAccount.Text = "Update Meter"
        Me.btnUpdateAccount.Visible = False
        '
        'btnTransferOwner
        '
        Me.btnTransferOwner.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnTransferOwner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTransferOwner.Enabled = False
        Me.btnTransferOwner.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferOwner.Image = CType(resources.GetObject("btnTransferOwner.Image"), System.Drawing.Image)
        Me.btnTransferOwner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTransferOwner.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTransferOwner.Name = "btnTransferOwner"
        Me.btnTransferOwner.Size = New System.Drawing.Size(118, 19)
        Me.btnTransferOwner.Text = "Transfer Ownership"
        Me.btnTransferOwner.Visible = False
        '
        'btnTransferMeter
        '
        Me.btnTransferMeter.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnTransferMeter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTransferMeter.Enabled = False
        Me.btnTransferMeter.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferMeter.Image = CType(resources.GetObject("btnTransferMeter.Image"), System.Drawing.Image)
        Me.btnTransferMeter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTransferMeter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTransferMeter.Name = "btnTransferMeter"
        Me.btnTransferMeter.Size = New System.Drawing.Size(93, 19)
        Me.btnTransferMeter.Text = "Transfer Meter"
        Me.btnTransferMeter.Visible = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.Image = CType(resources.GetObject("btnDisconnect.Image"), System.Drawing.Image)
        Me.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDisconnect.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(70, 19)
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.Visible = False
        '
        'btnReconnect
        '
        Me.btnReconnect.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnReconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnReconnect.Enabled = False
        Me.btnReconnect.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReconnect.Image = CType(resources.GetObject("btnReconnect.Image"), System.Drawing.Image)
        Me.btnReconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReconnect.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReconnect.Name = "btnReconnect"
        Me.btnReconnect.Size = New System.Drawing.Size(68, 19)
        Me.btnReconnect.Text = "Reconnect"
        Me.btnReconnect.Visible = False
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEnable.Enabled = False
        Me.btnEnable.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.Image = CType(resources.GetObject("btnEnable.Image"), System.Drawing.Image)
        Me.btnEnable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnable.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(94, 19)
        Me.btnEnable.Text = "Enable Account"
        Me.btnEnable.Visible = False
        '
        'btnChangeConsumer
        '
        Me.btnChangeConsumer.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnChangeConsumer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnChangeConsumer.Enabled = False
        Me.btnChangeConsumer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeConsumer.Image = CType(resources.GetObject("btnChangeConsumer.Image"), System.Drawing.Image)
        Me.btnChangeConsumer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeConsumer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChangeConsumer.Name = "btnChangeConsumer"
        Me.btnChangeConsumer.Size = New System.Drawing.Size(110, 19)
        Me.btnChangeConsumer.Text = "Change Consumer"
        Me.btnChangeConsumer.Visible = False
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDeleteAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDeleteAccount.Enabled = False
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAccount.Image = CType(resources.GetObject("btnDeleteAccount.Image"), System.Drawing.Image)
        Me.btnDeleteAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(95, 19)
        Me.btnDeleteAccount.Text = "Delete Account"
        Me.btnDeleteAccount.Visible = False
        '
        'btnDisc
        '
        Me.btnDisc.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDisc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDisc.Enabled = False
        Me.btnDisc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisc.Image = CType(resources.GetObject("btnDisc.Image"), System.Drawing.Image)
        Me.btnDisc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDisc.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDisc.Name = "btnDisc"
        Me.btnDisc.Size = New System.Drawing.Size(103, 19)
        Me.btnDisc.Text = "Force Disconnect"
        Me.btnDisc.Visible = False
        '
        'btnForceConnection
        '
        Me.btnForceConnection.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnForceConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnForceConnection.Enabled = False
        Me.btnForceConnection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForceConnection.Image = CType(resources.GetObject("btnForceConnection.Image"), System.Drawing.Image)
        Me.btnForceConnection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnForceConnection.Margin = New System.Windows.Forms.Padding(5)
        Me.btnForceConnection.Name = "btnForceConnection"
        Me.btnForceConnection.Size = New System.Drawing.Size(106, 19)
        Me.btnForceConnection.Text = "Force Connection"
        Me.btnForceConnection.Visible = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotAccounts})
        Me.StatusStrip2.Location = New System.Drawing.Point(572, 548)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(960, 22)
        Me.StatusStrip2.TabIndex = 4
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblTotAccounts
        '
        Me.lblTotAccounts.Name = "lblTotAccounts"
        Me.lblTotAccounts.Size = New System.Drawing.Size(164, 17)
        Me.lblTotAccounts.Text = "Total Account of Consumer: 0"
        '
        'lvwAccountList
        '
        Me.lvwAccountList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.Barangay, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvwAccountList.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvwAccountList.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwAccountList.FullRowSelect = True
        Me.lvwAccountList.GridLines = True
        Me.lvwAccountList.HideSelection = False
        Me.lvwAccountList.Location = New System.Drawing.Point(572, 29)
        Me.lvwAccountList.MultiSelect = False
        Me.lvwAccountList.Name = "lvwAccountList"
        Me.lvwAccountList.Size = New System.Drawing.Size(960, 244)
        Me.lvwAccountList.TabIndex = 5
        Me.lvwAccountList.UseCompatibleStateImageBehavior = False
        Me.lvwAccountList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 1
        Me.ColumnHeader3.Text = "Account #"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 2
        Me.ColumnHeader4.Text = "SEQ#"
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 3
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 4
        Me.ColumnHeader6.Text = "Balance"
        Me.ColumnHeader6.Width = 220
        '
        'Barangay
        '
        Me.Barangay.DisplayIndex = 5
        Me.Barangay.Text = "Barangay"
        Me.Barangay.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 6
        Me.ColumnHeader7.Text = "Cluster"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 0
        Me.ColumnHeader8.Text = "Account Name"
        Me.ColumnHeader8.Width = 180
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Classification"
        Me.ColumnHeader9.Width = 200
        '
        'lvwPaymentHistory
        '
        Me.lvwPaymentHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwPaymentHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.lvwPaymentHistory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwPaymentHistory.FullRowSelect = True
        Me.lvwPaymentHistory.GridLines = True
        Me.lvwPaymentHistory.HideSelection = False
        Me.lvwPaymentHistory.Location = New System.Drawing.Point(572, 305)
        Me.lvwPaymentHistory.MultiSelect = False
        Me.lvwPaymentHistory.Name = "lvwPaymentHistory"
        Me.lvwPaymentHistory.Size = New System.Drawing.Size(960, 243)
        Me.lvwPaymentHistory.TabIndex = 6
        Me.lvwPaymentHistory.UseCompatibleStateImageBehavior = False
        Me.lvwPaymentHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Date"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Nature of Collection"
        Me.ColumnHeader12.Width = 300
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Amount"
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "OR Number"
        Me.ColumnHeader14.Width = 150
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "E.F."
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Penalty"
        Me.ColumnHeader16.Width = 100
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Discount"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Payment Type"
        Me.ColumnHeader18.Width = 120
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Billing Period"
        Me.ColumnHeader19.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Payment History"
        '
        'btnViewOR
        '
        Me.btnViewOR.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOR.Location = New System.Drawing.Point(712, 276)
        Me.btnViewOR.Name = "btnViewOR"
        Me.btnViewOR.Size = New System.Drawing.Size(111, 26)
        Me.btnViewOR.TabIndex = 8
        Me.btnViewOR.Text = "View OR"
        Me.btnViewOR.UseVisualStyleBackColor = True
        Me.btnViewOR.Visible = False
        '
        'frmConsumerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnViewOR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwPaymentHistory)
        Me.Controls.Add(Me.lvwAccountList)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsumerList"
        Me.Text = "Consumer List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearchConsumer As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNewConsumer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdateConsumer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPage As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblTotConsumers As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblTotAccounts As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lvwConsumerList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnViewConsumer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDisableAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdateAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnViewAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvwAccountList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnTransferOwner As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTransferMeter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReconnect As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDisconnect As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEnable As System.Windows.Forms.ToolStripButton
    Friend WithEvents Barangay As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents btnChangeConsumer As ToolStripButton
    Friend WithEvents btnRemoveConsumer As ToolStripButton
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnDeleteAccount As ToolStripButton
    Friend WithEvents btnDisc As ToolStripButton
    Friend WithEvents btnForceConnection As ToolStripButton
    Friend WithEvents lvwPaymentHistory As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents btnViewOR As Button
    Friend WithEvents ColumnHeader19 As ColumnHeader
End Class
