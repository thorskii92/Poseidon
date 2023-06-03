<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewMeterReader
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboCluster = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpDisconnection = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUnselect = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.prb = New System.Windows.Forms.ProgressBar()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cboReader = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.cboYearRead = New System.Windows.Forms.ComboBox()
        Me.cboMonthRead = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpReadDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvReading = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcctName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PrevRead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.presRead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consump = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmtDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penalty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtADue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prevBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Overpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exclude = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvReading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cboCluster)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpDisconnection)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnUnselect)
        Me.Panel1.Controls.Add(Me.btnSelectAll)
        Me.Panel1.Controls.Add(Me.lblLoad)
        Me.Panel1.Controls.Add(Me.dtpBillDate)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnDone)
        Me.Panel1.Controls.Add(Me.prb)
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.cboReader)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cboBrgy)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Controls.Add(Me.cboYearRead)
        Me.Panel1.Controls.Add(Me.cboMonthRead)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpDueDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpReadDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1394, 163)
        Me.Panel1.TabIndex = 0
        '
        'cboCluster
        '
        Me.cboCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCluster.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCluster.FormattingEnabled = True
        Me.cboCluster.Location = New System.Drawing.Point(553, 100)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(162, 23)
        Me.cboCluster.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(495, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Cluster:"
        '
        'dtpDisconnection
        '
        Me.dtpDisconnection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDisconnection.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDisconnection.Location = New System.Drawing.Point(363, 122)
        Me.dtpDisconnection.Name = "dtpDisconnection"
        Me.dtpDisconnection.Size = New System.Drawing.Size(105, 23)
        Me.dtpDisconnection.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(238, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Disconnection Date:"
        '
        'btnUnselect
        '
        Me.btnUnselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUnselect.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUnselect.FlatAppearance.BorderSize = 0
        Me.btnUnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnselect.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnselect.ForeColor = System.Drawing.Color.White
        Me.btnUnselect.Location = New System.Drawing.Point(1162, 113)
        Me.btnUnselect.Name = "btnUnselect"
        Me.btnUnselect.Size = New System.Drawing.Size(107, 34)
        Me.btnUnselect.TabIndex = 26
        Me.btnUnselect.Text = "Unselect All"
        Me.btnUnselect.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectAll.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSelectAll.FlatAppearance.BorderSize = 0
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.Color.White
        Me.btnSelectAll.Location = New System.Drawing.Point(1275, 113)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(107, 34)
        Me.btnSelectAll.TabIndex = 25
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.Location = New System.Drawing.Point(908, 133)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(49, 15)
        Me.lblLoad.TabIndex = 24
        Me.lblLoad.Text = "loading"
        Me.lblLoad.Visible = False
        '
        'dtpBillDate
        '
        Me.dtpBillDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBillDate.Location = New System.Drawing.Point(114, 124)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.Size = New System.Drawing.Size(105, 23)
        Me.dtpBillDate.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Billing Date:"
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(1262, 12)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(120, 45)
        Me.btnDone.TabIndex = 21
        Me.btnDone.Text = "DONE READING"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'prb
        '
        Me.prb.Location = New System.Drawing.Point(742, 129)
        Me.prb.Name = "prb"
        Me.prb.Size = New System.Drawing.Size(160, 23)
        Me.prb.TabIndex = 20
        Me.prb.Visible = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(742, 84)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(120, 39)
        Me.btnGenerate.TabIndex = 19
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'cboReader
        '
        Me.cboReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReader.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReader.FormattingEnabled = True
        Me.cboReader.Location = New System.Drawing.Point(553, 129)
        Me.cboReader.Name = "cboReader"
        Me.cboReader.Size = New System.Drawing.Size(162, 23)
        Me.cboReader.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(496, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Reader:"
        '
        'cboBrgy
        '
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(553, 71)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(162, 23)
        Me.cboBrgy.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(482, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Barangay:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(479, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(504, 42)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(105, 23)
        Me.dtpTo.TabIndex = 11
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(368, 42)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(105, 23)
        Me.dtpFrom.TabIndex = 10
        '
        'cboYearRead
        '
        Me.cboYearRead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearRead.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearRead.FormattingEnabled = True
        Me.cboYearRead.Location = New System.Drawing.Point(241, 42)
        Me.cboYearRead.Name = "cboYearRead"
        Me.cboYearRead.Size = New System.Drawing.Size(121, 23)
        Me.cboYearRead.TabIndex = 9
        '
        'cboMonthRead
        '
        Me.cboMonthRead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthRead.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthRead.FormattingEnabled = True
        Me.cboMonthRead.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonthRead.Location = New System.Drawing.Point(114, 42)
        Me.cboMonthRead.Name = "cboMonthRead"
        Me.cboMonthRead.Size = New System.Drawing.Size(121, 23)
        Me.cboMonthRead.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Period Covered:"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(363, 95)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(105, 23)
        Me.dtpDueDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Due Date:"
        '
        'dtpReadDate
        '
        Me.dtpReadDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReadDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReadDate.Location = New System.Drawing.Point(114, 95)
        Me.dtpReadDate.Name = "dtpReadDate"
        Me.dtpReadDate.Size = New System.Drawing.Size(105, 23)
        Me.dtpReadDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reading Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Meter Reading"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvReading)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1394, 489)
        Me.Panel2.TabIndex = 1
        '
        'dgvReading
        '
        Me.dgvReading.AllowUserToAddRows = False
        Me.dgvReading.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvReading.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReading.BackgroundColor = System.Drawing.Color.White
        Me.dgvReading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReading.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReading.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.AcctNum, Me.AcctName, Me.Classification, Me.ConsType, Me.PrevRead, Me.presRead, Me.Consump, Me.Amount, Me.ef, Me.Disc, Me.totalamt, Me.InstallFee, Me.TotalAmtDue, Me.Penalty, Me.AmtADue, Me.prevBal, Me.Overpayment, Me.Exclude})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReading.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvReading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReading.Location = New System.Drawing.Point(0, 0)
        Me.dgvReading.Name = "dgvReading"
        Me.dgvReading.RowHeadersVisible = False
        Me.dgvReading.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver
        Me.dgvReading.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvReading.Size = New System.Drawing.Size(1394, 489)
        Me.dgvReading.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Standpipe"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'AcctNum
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcctNum.DefaultCellStyle = DataGridViewCellStyle3
        Me.AcctNum.Frozen = True
        Me.AcctNum.HeaderText = "Account #"
        Me.AcctNum.Name = "AcctNum"
        Me.AcctNum.ReadOnly = True
        Me.AcctNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AcctNum.Width = 160
        '
        'AcctName
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AcctName.DefaultCellStyle = DataGridViewCellStyle4
        Me.AcctName.Frozen = True
        Me.AcctName.HeaderText = "Account Name"
        Me.AcctName.Name = "AcctName"
        Me.AcctName.ReadOnly = True
        Me.AcctName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AcctName.Width = 200
        '
        'Classification
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Classification.DefaultCellStyle = DataGridViewCellStyle5
        Me.Classification.Frozen = True
        Me.Classification.HeaderText = "Classification"
        Me.Classification.Name = "Classification"
        Me.Classification.ReadOnly = True
        Me.Classification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ConsType
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.ConsType.DefaultCellStyle = DataGridViewCellStyle6
        Me.ConsType.Frozen = True
        Me.ConsType.HeaderText = "Consumer Type"
        Me.ConsType.Items.AddRange(New Object() {"Regular", "Senior/PWD"})
        Me.ConsType.Name = "ConsType"
        Me.ConsType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PrevRead
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.PrevRead.DefaultCellStyle = DataGridViewCellStyle7
        Me.PrevRead.Frozen = True
        Me.PrevRead.HeaderText = "Previous Reading"
        Me.PrevRead.Name = "PrevRead"
        Me.PrevRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'presRead
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.presRead.DefaultCellStyle = DataGridViewCellStyle8
        Me.presRead.Frozen = True
        Me.presRead.HeaderText = "Present Reading"
        Me.presRead.Name = "presRead"
        Me.presRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Consump
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Consump.DefaultCellStyle = DataGridViewCellStyle9
        Me.Consump.Frozen = True
        Me.Consump.HeaderText = "Consumption"
        Me.Consump.Name = "Consump"
        Me.Consump.ReadOnly = True
        '
        'Amount
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle10
        Me.Amount.HeaderText = "Amount (WSF)"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'ef
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ef.DefaultCellStyle = DataGridViewCellStyle11
        Me.ef.HeaderText = "Environmental Fee"
        Me.ef.Name = "ef"
        Me.ef.ReadOnly = True
        '
        'Disc
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Disc.DefaultCellStyle = DataGridViewCellStyle12
        Me.Disc.HeaderText = "Discount"
        Me.Disc.Name = "Disc"
        Me.Disc.ReadOnly = True
        '
        'totalamt
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.totalamt.DefaultCellStyle = DataGridViewCellStyle13
        Me.totalamt.HeaderText = "Total Amount"
        Me.totalamt.Name = "totalamt"
        Me.totalamt.ReadOnly = True
        Me.totalamt.Width = 120
        '
        'InstallFee
        '
        Me.InstallFee.HeaderText = "Install Fee"
        Me.InstallFee.Name = "InstallFee"
        Me.InstallFee.ReadOnly = True
        '
        'TotalAmtDue
        '
        Me.TotalAmtDue.HeaderText = "Total Amount Due"
        Me.TotalAmtDue.Name = "TotalAmtDue"
        Me.TotalAmtDue.ReadOnly = True
        '
        'Penalty
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Penalty.DefaultCellStyle = DataGridViewCellStyle14
        Me.Penalty.HeaderText = "Penalty"
        Me.Penalty.Name = "Penalty"
        Me.Penalty.ReadOnly = True
        '
        'AmtADue
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AmtADue.DefaultCellStyle = DataGridViewCellStyle15
        Me.AmtADue.HeaderText = "Amount After Due"
        Me.AmtADue.Name = "AmtADue"
        Me.AmtADue.ReadOnly = True
        Me.AmtADue.Width = 120
        '
        'prevBal
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.prevBal.DefaultCellStyle = DataGridViewCellStyle16
        Me.prevBal.HeaderText = "Previous Balance"
        Me.prevBal.Name = "prevBal"
        Me.prevBal.ReadOnly = True
        Me.prevBal.Width = 120
        '
        'Overpayment
        '
        Me.Overpayment.HeaderText = "Overpayment"
        Me.Overpayment.Name = "Overpayment"
        Me.Overpayment.ReadOnly = True
        '
        'Exclude
        '
        Me.Exclude.HeaderText = "Exclude"
        Me.Exclude.Name = "Exclude"
        Me.Exclude.Width = 60
        '
        'frmNewMeterReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1394, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewMeterReader"
        Me.Text = "New Meter Reader"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvReading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpReadDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboYearRead As ComboBox
    Friend WithEvents cboMonthRead As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents cboReader As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvReading As DataGridView
    Friend WithEvents cboBrgy As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents prb As ProgressBar
    Friend WithEvents btnDone As Button
    Friend WithEvents dtpBillDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents lblLoad As Label
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnUnselect As Button
    Friend WithEvents dtpDisconnection As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cboCluster As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents AcctNum As DataGridViewTextBoxColumn
    Friend WithEvents AcctName As DataGridViewTextBoxColumn
    Friend WithEvents Classification As DataGridViewTextBoxColumn
    Friend WithEvents ConsType As DataGridViewComboBoxColumn
    Friend WithEvents PrevRead As DataGridViewTextBoxColumn
    Friend WithEvents presRead As DataGridViewTextBoxColumn
    Friend WithEvents Consump As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents ef As DataGridViewTextBoxColumn
    Friend WithEvents Disc As DataGridViewTextBoxColumn
    Friend WithEvents totalamt As DataGridViewTextBoxColumn
    Friend WithEvents InstallFee As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmtDue As DataGridViewTextBoxColumn
    Friend WithEvents Penalty As DataGridViewTextBoxColumn
    Friend WithEvents AmtADue As DataGridViewTextBoxColumn
    Friend WithEvents prevBal As DataGridViewTextBoxColumn
    Friend WithEvents Overpayment As DataGridViewTextBoxColumn
    Friend WithEvents Exclude As DataGridViewCheckBoxColumn
End Class
