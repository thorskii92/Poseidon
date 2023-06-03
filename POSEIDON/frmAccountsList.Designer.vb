<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountsList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountsList))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFilterAccountStatus = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvwAccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cboProvince = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cboMunicipality = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cboZone = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.cboBarangay = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCluster = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTotalAccounts = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.btnChangeClass = New System.Windows.Forms.ToolStripButton()
        Me.btnOverpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboFilter, Me.ToolStripLabel2, Me.txtSearch, Me.btnSearch, Me.ToolStripLabel8, Me.cboFilterAccountStatus})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 36)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1194, 36)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 26)
        Me.ToolStripLabel1.Text = "Filter:"
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilter.Items.AddRange(New Object() {"Account#", "Consumer Name"})
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(5)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(200, 26)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 33)
        Me.ToolStripLabel2.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 26)
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Silver
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(46, 26)
        Me.btnSearch.Text = "Search"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel8.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel8.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(139, 26)
        Me.ToolStripLabel8.Text = "Account Status Filter:"
        '
        'cboFilterAccountStatus
        '
        Me.cboFilterAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterAccountStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterAccountStatus.Items.AddRange(New Object() {"All", "Installation", "Connected", "Disconnected", "For Disconnection", "For Meter Transfer", "For Owner Transfer", "For Reconnection", "Temporary Closed"})
        Me.cboFilterAccountStatus.Margin = New System.Windows.Forms.Padding(5)
        Me.cboFilterAccountStatus.Name = "cboFilterAccountStatus"
        Me.cboFilterAccountStatus.Size = New System.Drawing.Size(200, 26)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvwAccounts)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 385)
        Me.Panel1.TabIndex = 1
        '
        'lvwAccounts
        '
        Me.lvwAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvwAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAccounts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwAccounts.FullRowSelect = True
        Me.lvwAccounts.GridLines = True
        Me.lvwAccounts.HideSelection = False
        Me.lvwAccounts.Location = New System.Drawing.Point(0, 0)
        Me.lvwAccounts.MultiSelect = False
        Me.lvwAccounts.Name = "lvwAccounts"
        Me.lvwAccounts.Size = New System.Drawing.Size(1194, 385)
        Me.lvwAccounts.TabIndex = 0
        Me.lvwAccounts.UseCompatibleStateImageBehavior = False
        Me.lvwAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account #"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Consumer Name"
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Street Address"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Barangay"
        Me.ColumnHeader4.Width = 140
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Zone"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cluster"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Account Status"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Account Balance"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date Installed"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Classification"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Overpayment Balance"
        Me.ColumnHeader11.Width = 150
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Application Fee Balance"
        Me.ColumnHeader12.Width = 150
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.cboProvince, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.cboMunicipality, Me.ToolStripSeparator2, Me.ToolStripLabel5, Me.cboZone, Me.ToolStripSeparator3, Me.ToolStripLabel6, Me.cboBarangay, Me.ToolStripSeparator4, Me.ToolStripLabel7, Me.cboCluster, Me.ToolStripSeparator5, Me.lblTotalAccounts})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1194, 36)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(68, 33)
        Me.ToolStripLabel3.Text = "Province:"
        '
        'cboProvince
        '
        Me.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvince.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.Margin = New System.Windows.Forms.Padding(5)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(100, 26)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(89, 33)
        Me.ToolStripLabel4.Text = "Municipality"
        '
        'cboMunicipality
        '
        Me.cboMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMunicipality.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMunicipality.Margin = New System.Windows.Forms.Padding(5)
        Me.cboMunicipality.Name = "cboMunicipality"
        Me.cboMunicipality.Size = New System.Drawing.Size(100, 26)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(45, 33)
        Me.ToolStripLabel5.Text = "Zone:"
        '
        'cboZone
        '
        Me.cboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZone.Margin = New System.Windows.Forms.Padding(5)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(100, 26)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(74, 33)
        Me.ToolStripLabel6.Text = "Barangay:"
        '
        'cboBarangay
        '
        Me.cboBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBarangay.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarangay.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(100, 26)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
        Me.ToolStripSeparator4.Visible = False
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(59, 33)
        Me.ToolStripLabel7.Text = "Cluster:"
        Me.ToolStripLabel7.Visible = False
        '
        'cboCluster
        '
        Me.cboCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCluster.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCluster.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(100, 26)
        Me.cboCluster.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
        Me.ToolStripSeparator5.Visible = False
        '
        'lblTotalAccounts
        '
        Me.lblTotalAccounts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAccounts.ForeColor = System.Drawing.Color.White
        Me.lblTotalAccounts.Name = "lblTotalAccounts"
        Me.lblTotalAccounts.Size = New System.Drawing.Size(114, 33)
        Me.lblTotalAccounts.Text = "Total Accounts:"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.btnChangeClass, Me.btnOverpayment})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 72)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1194, 34)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton1.Size = New System.Drawing.Size(99, 24)
        Me.ToolStripButton1.Text = "View Account"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton2.Size = New System.Drawing.Size(135, 24)
        Me.ToolStripButton2.Text = "Transfer Ownership"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton3.Size = New System.Drawing.Size(106, 24)
        Me.ToolStripButton3.Text = "Transfer Meter"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton4.Size = New System.Drawing.Size(136, 24)
        Me.ToolStripButton4.Text = "Application Balance"
        '
        'btnChangeClass
        '
        Me.btnChangeClass.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChangeClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnChangeClass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeClass.ForeColor = System.Drawing.Color.Black
        Me.btnChangeClass.Image = CType(resources.GetObject("btnChangeClass.Image"), System.Drawing.Image)
        Me.btnChangeClass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChangeClass.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChangeClass.Name = "btnChangeClass"
        Me.btnChangeClass.Padding = New System.Windows.Forms.Padding(1)
        Me.btnChangeClass.Size = New System.Drawing.Size(144, 24)
        Me.btnChangeClass.Text = "Change Classification"
        Me.btnChangeClass.Visible = False
        '
        'btnOverpayment
        '
        Me.btnOverpayment.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOverpayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnOverpayment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverpayment.ForeColor = System.Drawing.Color.Black
        Me.btnOverpayment.Image = CType(resources.GetObject("btnOverpayment.Image"), System.Drawing.Image)
        Me.btnOverpayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOverpayment.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOverpayment.Name = "btnOverpayment"
        Me.btnOverpayment.Padding = New System.Windows.Forms.Padding(1)
        Me.btnOverpayment.Size = New System.Drawing.Size(99, 24)
        Me.btnOverpayment.Text = "Overpayment"
        '
        'frmAccountsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountsList"
        Me.ShowIcon = False
        Me.Text = "Accounts"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvwAccounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboProvince As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboMunicipality As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboZone As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboBarangay As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboCluster As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboFilterAccountStatus As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents lblTotalAccounts As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents btnChangeClass As ToolStripButton
    Friend WithEvents btnOverpayment As ToolStripButton
End Class
