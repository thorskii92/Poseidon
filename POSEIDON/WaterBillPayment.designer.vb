<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WaterBillPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaterBillPayment))
        Me.cboConsumerName = New System.Windows.Forms.ComboBox()
        Me.lvwAccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCollectionOfficer = New System.Windows.Forms.Label()
        Me.txtORNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblConsumerID = New System.Windows.Forms.Label()
        Me.btnAdjust = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSeniorID = New System.Windows.Forms.TextBox()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.btnSearchBill = New System.Windows.Forms.Button()
        Me.btnPayPrev = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.btnAddReconnection = New System.Windows.Forms.Button()
        Me.btnAddTransferOwner = New System.Windows.Forms.Button()
        Me.btnAddTransferMeter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInstallmentFeeEdit = New System.Windows.Forms.Button()
        Me.gbxBill = New System.Windows.Forms.GroupBox()
        Me.lblAdjRem = New System.Windows.Forms.Label()
        Me.lblisADJ = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.lblAdjTot = New System.Windows.Forms.Label()
        Me.lblAdjPen = New System.Windows.Forms.Label()
        Me.lblAdjDis = New System.Windows.Forms.Label()
        Me.lblAdjEF = New System.Windows.Forms.Label()
        Me.lblAdjWSF = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lblPrevTotal = New System.Windows.Forms.Label()
        Me.lblPrevPen = New System.Windows.Forms.Label()
        Me.lblPrevIns = New System.Windows.Forms.Label()
        Me.lblPrevWSF = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblAmountADue = New System.Windows.Forms.Label()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.lblTotalAmountDue = New System.Windows.Forms.Label()
        Me.lblInstallmentFee = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblEF = New System.Windows.Forms.Label()
        Me.lblWSF = New System.Windows.Forms.Label()
        Me.lblConsump = New System.Windows.Forms.Label()
        Me.lblPresRead = New System.Windows.Forms.Label()
        Me.lblPrevRead = New System.Windows.Forms.Label()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblBillDate = New System.Windows.Forms.Label()
        Me.lblBillPer = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnOverpayment = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbxBill.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboConsumerName
        '
        Me.cboConsumerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboConsumerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboConsumerName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsumerName.FormattingEnabled = True
        Me.cboConsumerName.Location = New System.Drawing.Point(134, 12)
        Me.cboConsumerName.Name = "cboConsumerName"
        Me.cboConsumerName.Size = New System.Drawing.Size(365, 31)
        Me.cboConsumerName.TabIndex = 0
        '
        'lvwAccounts
        '
        Me.lvwAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwAccounts.CheckBoxes = True
        Me.lvwAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwAccounts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwAccounts.FullRowSelect = True
        Me.lvwAccounts.GridLines = True
        Me.lvwAccounts.HideSelection = False
        Me.lvwAccounts.Location = New System.Drawing.Point(12, 95)
        Me.lvwAccounts.MultiSelect = False
        Me.lvwAccounts.Name = "lvwAccounts"
        Me.lvwAccounts.Size = New System.Drawing.Size(1271, 220)
        Me.lvwAccounts.TabIndex = 1
        Me.lvwAccounts.UseCompatibleStateImageBehavior = False
        Me.lvwAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 25
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Collection Type"
        Me.ColumnHeader2.Width = 129
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Bill #"
        Me.ColumnHeader18.Width = 55
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Account #"
        Me.ColumnHeader19.Width = 120
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Account Name"
        Me.ColumnHeader20.Width = 200
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Bill Period"
        Me.ColumnHeader21.Width = 100
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Billing Month"
        Me.ColumnHeader22.Width = 101
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "WSF"
        Me.ColumnHeader23.Width = 70
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "EF"
        Me.ColumnHeader24.Width = 58
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Discount"
        Me.ColumnHeader25.Width = 68
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Install Fee"
        Me.ColumnHeader26.Width = 80
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Penalty"
        Me.ColumnHeader27.Width = 69
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Due Date"
        Me.ColumnHeader28.Width = 80
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Required Payment"
        Me.ColumnHeader29.Width = 127
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Adjusted"
        Me.ColumnHeader30.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Remarks"
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Outstanding"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Overpayment"
        Me.ColumnHeader5.Width = 100
        '
        'lblCollectionOfficer
        '
        Me.lblCollectionOfficer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCollectionOfficer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCollectionOfficer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollectionOfficer.Location = New System.Drawing.Point(825, 638)
        Me.lblCollectionOfficer.Name = "lblCollectionOfficer"
        Me.lblCollectionOfficer.Size = New System.Drawing.Size(264, 35)
        Me.lblCollectionOfficer.TabIndex = 2
        Me.lblCollectionOfficer.Text = "Collection Officer"
        Me.lblCollectionOfficer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtORNum
        '
        Me.txtORNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtORNum.BackColor = System.Drawing.Color.Firebrick
        Me.txtORNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtORNum.Font = New System.Drawing.Font("Calibri", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNum.ForeColor = System.Drawing.Color.White
        Me.txtORNum.Location = New System.Drawing.Point(1049, 53)
        Me.txtORNum.Multiline = True
        Me.txtORNum.Name = "txtORNum"
        Me.txtORNum.Size = New System.Drawing.Size(234, 31)
        Me.txtORNum.TabIndex = 3
        Me.txtORNum.Text = "0000000"
        Me.txtORNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(977, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OR No."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(901, 614)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Collection Officer"
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.BackColor = System.Drawing.Color.Maroon
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(1095, 571)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(188, 56)
        Me.btnDone.TabIndex = 6
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1095, 633)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Amount to Pay"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblTotalAmount.Font = New System.Drawing.Font("Bernard MT Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.White
        Me.lblTotalAmount.Location = New System.Drawing.Point(250, 321)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(489, 48)
        Me.lblTotalAmount.TabIndex = 8
        Me.lblTotalAmount.Text = "0.00"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Consumer Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Consumer ID"
        '
        'lblConsumerID
        '
        Me.lblConsumerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsumerID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsumerID.ForeColor = System.Drawing.Color.Red
        Me.lblConsumerID.Location = New System.Drawing.Point(603, 8)
        Me.lblConsumerID.Name = "lblConsumerID"
        Me.lblConsumerID.Size = New System.Drawing.Size(126, 35)
        Me.lblConsumerID.TabIndex = 12
        Me.lblConsumerID.Text = "0"
        Me.lblConsumerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdjust
        '
        Me.btnAdjust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdjust.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdjust.FlatAppearance.BorderSize = 0
        Me.btnAdjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdjust.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjust.ForeColor = System.Drawing.Color.White
        Me.btnAdjust.Location = New System.Drawing.Point(1123, 321)
        Me.btnAdjust.Name = "btnAdjust"
        Me.btnAdjust.Size = New System.Drawing.Size(160, 30)
        Me.btnAdjust.TabIndex = 14
        Me.btnAdjust.Text = "Request Adjustment"
        Me.btnAdjust.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSeniorID)
        Me.GroupBox1.Controls.Add(Me.chkDiscount)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(825, 517)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 94)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ID#"
        '
        'txtSeniorID
        '
        Me.txtSeniorID.Enabled = False
        Me.txtSeniorID.Location = New System.Drawing.Point(45, 50)
        Me.txtSeniorID.Name = "txtSeniorID"
        Me.txtSeniorID.Size = New System.Drawing.Size(213, 26)
        Me.txtSeniorID.TabIndex = 18
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Enabled = False
        Me.chkDiscount.Location = New System.Drawing.Point(6, 19)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(135, 22)
        Me.chkDiscount.TabIndex = 16
        Me.chkDiscount.Text = "SC/PWD Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Bill No.:"
        '
        'txtBill
        '
        Me.txtBill.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBill.Location = New System.Drawing.Point(134, 54)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(365, 27)
        Me.txtBill.TabIndex = 17
        '
        'btnSearchBill
        '
        Me.btnSearchBill.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearchBill.FlatAppearance.BorderSize = 0
        Me.btnSearchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBill.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBill.ForeColor = System.Drawing.Color.White
        Me.btnSearchBill.Location = New System.Drawing.Point(509, 49)
        Me.btnSearchBill.Name = "btnSearchBill"
        Me.btnSearchBill.Size = New System.Drawing.Size(220, 35)
        Me.btnSearchBill.TabIndex = 18
        Me.btnSearchBill.Text = "Search"
        Me.btnSearchBill.UseVisualStyleBackColor = False
        '
        'btnPayPrev
        '
        Me.btnPayPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayPrev.BackColor = System.Drawing.Color.Orange
        Me.btnPayPrev.FlatAppearance.BorderSize = 0
        Me.btnPayPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayPrev.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayPrev.ForeColor = System.Drawing.Color.White
        Me.btnPayPrev.Location = New System.Drawing.Point(1095, 525)
        Me.btnPayPrev.Name = "btnPayPrev"
        Me.btnPayPrev.Size = New System.Drawing.Size(188, 40)
        Me.btnPayPrev.TabIndex = 20
        Me.btnPayPrev.Text = "PAY PREVIOUS BALANCE"
        Me.btnPayPrev.UseVisualStyleBackColor = False
        Me.btnPayPrev.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(995, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Date"
        '
        'dtp
        '
        Me.dtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp.CalendarFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(1049, 15)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(234, 27)
        Me.dtp.TabIndex = 26
        '
        'btnAddReconnection
        '
        Me.btnAddReconnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddReconnection.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddReconnection.FlatAppearance.BorderSize = 0
        Me.btnAddReconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddReconnection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReconnection.ForeColor = System.Drawing.Color.White
        Me.btnAddReconnection.Location = New System.Drawing.Point(957, 429)
        Me.btnAddReconnection.Name = "btnAddReconnection"
        Me.btnAddReconnection.Size = New System.Drawing.Size(160, 30)
        Me.btnAddReconnection.TabIndex = 27
        Me.btnAddReconnection.Text = "Reconnection Fee"
        Me.btnAddReconnection.UseVisualStyleBackColor = False
        '
        'btnAddTransferOwner
        '
        Me.btnAddTransferOwner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTransferOwner.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddTransferOwner.FlatAppearance.BorderSize = 0
        Me.btnAddTransferOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTransferOwner.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTransferOwner.ForeColor = System.Drawing.Color.White
        Me.btnAddTransferOwner.Location = New System.Drawing.Point(957, 393)
        Me.btnAddTransferOwner.Name = "btnAddTransferOwner"
        Me.btnAddTransferOwner.Size = New System.Drawing.Size(160, 30)
        Me.btnAddTransferOwner.TabIndex = 28
        Me.btnAddTransferOwner.Text = "Transfer Owner Fee"
        Me.btnAddTransferOwner.UseVisualStyleBackColor = False
        '
        'btnAddTransferMeter
        '
        Me.btnAddTransferMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTransferMeter.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddTransferMeter.FlatAppearance.BorderSize = 0
        Me.btnAddTransferMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTransferMeter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTransferMeter.ForeColor = System.Drawing.Color.White
        Me.btnAddTransferMeter.Location = New System.Drawing.Point(957, 357)
        Me.btnAddTransferMeter.Name = "btnAddTransferMeter"
        Me.btnAddTransferMeter.Size = New System.Drawing.Size(160, 30)
        Me.btnAddTransferMeter.TabIndex = 29
        Me.btnAddTransferMeter.Text = "Transfer Meter Fee"
        Me.btnAddTransferMeter.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(957, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 30)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "New Application Fee"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnInstallmentFeeEdit
        '
        Me.btnInstallmentFeeEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstallmentFeeEdit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnInstallmentFeeEdit.FlatAppearance.BorderSize = 0
        Me.btnInstallmentFeeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstallmentFeeEdit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstallmentFeeEdit.ForeColor = System.Drawing.Color.White
        Me.btnInstallmentFeeEdit.Location = New System.Drawing.Point(1123, 393)
        Me.btnInstallmentFeeEdit.Name = "btnInstallmentFeeEdit"
        Me.btnInstallmentFeeEdit.Size = New System.Drawing.Size(160, 30)
        Me.btnInstallmentFeeEdit.TabIndex = 32
        Me.btnInstallmentFeeEdit.Text = "Edit Installment Fee"
        Me.btnInstallmentFeeEdit.UseVisualStyleBackColor = False
        Me.btnInstallmentFeeEdit.Visible = False
        '
        'gbxBill
        '
        Me.gbxBill.Controls.Add(Me.lblAdjRem)
        Me.gbxBill.Controls.Add(Me.lblisADJ)
        Me.gbxBill.Controls.Add(Me.Label64)
        Me.gbxBill.Controls.Add(Me.Label63)
        Me.gbxBill.Controls.Add(Me.lblAdjTot)
        Me.gbxBill.Controls.Add(Me.lblAdjPen)
        Me.gbxBill.Controls.Add(Me.lblAdjDis)
        Me.gbxBill.Controls.Add(Me.lblAdjEF)
        Me.gbxBill.Controls.Add(Me.lblAdjWSF)
        Me.gbxBill.Controls.Add(Me.Label58)
        Me.gbxBill.Controls.Add(Me.Label59)
        Me.gbxBill.Controls.Add(Me.Label60)
        Me.gbxBill.Controls.Add(Me.Label61)
        Me.gbxBill.Controls.Add(Me.Label62)
        Me.gbxBill.Controls.Add(Me.Label52)
        Me.gbxBill.Controls.Add(Me.lblPrevTotal)
        Me.gbxBill.Controls.Add(Me.lblPrevPen)
        Me.gbxBill.Controls.Add(Me.lblPrevIns)
        Me.gbxBill.Controls.Add(Me.lblPrevWSF)
        Me.gbxBill.Controls.Add(Me.Label45)
        Me.gbxBill.Controls.Add(Me.Label44)
        Me.gbxBill.Controls.Add(Me.Label43)
        Me.gbxBill.Controls.Add(Me.Label40)
        Me.gbxBill.Controls.Add(Me.Label39)
        Me.gbxBill.Controls.Add(Me.lblAmountADue)
        Me.gbxBill.Controls.Add(Me.lblPenalty)
        Me.gbxBill.Controls.Add(Me.lblTotalAmountDue)
        Me.gbxBill.Controls.Add(Me.lblInstallmentFee)
        Me.gbxBill.Controls.Add(Me.lblDiscount)
        Me.gbxBill.Controls.Add(Me.lblEF)
        Me.gbxBill.Controls.Add(Me.lblWSF)
        Me.gbxBill.Controls.Add(Me.lblConsump)
        Me.gbxBill.Controls.Add(Me.lblPresRead)
        Me.gbxBill.Controls.Add(Me.lblPrevRead)
        Me.gbxBill.Controls.Add(Me.lblAccountNo)
        Me.gbxBill.Controls.Add(Me.lblDueDate)
        Me.gbxBill.Controls.Add(Me.lblBillDate)
        Me.gbxBill.Controls.Add(Me.lblBillPer)
        Me.gbxBill.Controls.Add(Me.lblBillNo)
        Me.gbxBill.Controls.Add(Me.Label23)
        Me.gbxBill.Controls.Add(Me.Label22)
        Me.gbxBill.Controls.Add(Me.Label21)
        Me.gbxBill.Controls.Add(Me.Label20)
        Me.gbxBill.Controls.Add(Me.Label19)
        Me.gbxBill.Controls.Add(Me.Label18)
        Me.gbxBill.Controls.Add(Me.Label17)
        Me.gbxBill.Controls.Add(Me.Label16)
        Me.gbxBill.Controls.Add(Me.Label15)
        Me.gbxBill.Controls.Add(Me.Label14)
        Me.gbxBill.Controls.Add(Me.Label13)
        Me.gbxBill.Controls.Add(Me.Label12)
        Me.gbxBill.Controls.Add(Me.Label11)
        Me.gbxBill.Controls.Add(Me.Label10)
        Me.gbxBill.Controls.Add(Me.Label9)
        Me.gbxBill.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBill.Location = New System.Drawing.Point(12, 369)
        Me.gbxBill.Name = "gbxBill"
        Me.gbxBill.Size = New System.Drawing.Size(727, 302)
        Me.gbxBill.TabIndex = 33
        Me.gbxBill.TabStop = False
        Me.gbxBill.Text = "Bill Details"
        '
        'lblAdjRem
        '
        Me.lblAdjRem.BackColor = System.Drawing.Color.Lime
        Me.lblAdjRem.Location = New System.Drawing.Point(555, 255)
        Me.lblAdjRem.Name = "lblAdjRem"
        Me.lblAdjRem.Size = New System.Drawing.Size(91, 18)
        Me.lblAdjRem.TabIndex = 57
        Me.lblAdjRem.Text = "NONE"
        Me.lblAdjRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblisADJ
        '
        Me.lblisADJ.BackColor = System.Drawing.Color.Lime
        Me.lblisADJ.Location = New System.Drawing.Point(382, 256)
        Me.lblisADJ.Name = "lblisADJ"
        Me.lblisADJ.Size = New System.Drawing.Size(91, 18)
        Me.lblisADJ.TabIndex = 56
        Me.lblisADJ.Text = "NONE"
        Me.lblisADJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(489, 256)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(60, 18)
        Me.Label64.TabIndex = 55
        Me.Label64.Text = "REMARK"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(312, 256)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(70, 18)
        Me.Label63.TabIndex = 54
        Me.Label63.Text = "ADJUSTED"
        '
        'lblAdjTot
        '
        Me.lblAdjTot.AutoSize = True
        Me.lblAdjTot.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjTot.Location = New System.Drawing.Point(466, 220)
        Me.lblAdjTot.Name = "lblAdjTot"
        Me.lblAdjTot.Size = New System.Drawing.Size(91, 18)
        Me.lblAdjTot.TabIndex = 53
        Me.lblAdjTot.Text = "Total Amount"
        '
        'lblAdjPen
        '
        Me.lblAdjPen.AutoSize = True
        Me.lblAdjPen.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjPen.Location = New System.Drawing.Point(466, 202)
        Me.lblAdjPen.Name = "lblAdjPen"
        Me.lblAdjPen.Size = New System.Drawing.Size(55, 18)
        Me.lblAdjPen.TabIndex = 52
        Me.lblAdjPen.Text = "Penalty"
        '
        'lblAdjDis
        '
        Me.lblAdjDis.AutoSize = True
        Me.lblAdjDis.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjDis.Location = New System.Drawing.Point(466, 184)
        Me.lblAdjDis.Name = "lblAdjDis"
        Me.lblAdjDis.Size = New System.Drawing.Size(62, 18)
        Me.lblAdjDis.TabIndex = 51
        Me.lblAdjDis.Text = "Discount"
        '
        'lblAdjEF
        '
        Me.lblAdjEF.AutoSize = True
        Me.lblAdjEF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjEF.Location = New System.Drawing.Point(466, 166)
        Me.lblAdjEF.Name = "lblAdjEF"
        Me.lblAdjEF.Size = New System.Drawing.Size(22, 18)
        Me.lblAdjEF.TabIndex = 50
        Me.lblAdjEF.Text = "EF"
        '
        'lblAdjWSF
        '
        Me.lblAdjWSF.AutoSize = True
        Me.lblAdjWSF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjWSF.Location = New System.Drawing.Point(466, 148)
        Me.lblAdjWSF.Name = "lblAdjWSF"
        Me.lblAdjWSF.Size = New System.Drawing.Size(36, 18)
        Me.lblAdjWSF.TabIndex = 49
        Me.lblAdjWSF.Text = "WSF"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(349, 220)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(91, 18)
        Me.Label58.TabIndex = 48
        Me.Label58.Text = "Total Amount"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(349, 202)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(55, 18)
        Me.Label59.TabIndex = 47
        Me.Label59.Text = "Penalty"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(349, 184)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(62, 18)
        Me.Label60.TabIndex = 46
        Me.Label60.Text = "Discount"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(349, 166)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(22, 18)
        Me.Label61.TabIndex = 45
        Me.Label61.Text = "EF"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(349, 148)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(35, 18)
        Me.Label62.TabIndex = 44
        Me.Label62.Text = "WSF"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(312, 130)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(248, 18)
        Me.Label52.TabIndex = 43
        Me.Label52.Text = "Adjustment Details (Original Amounts)"
        '
        'lblPrevTotal
        '
        Me.lblPrevTotal.AutoSize = True
        Me.lblPrevTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevTotal.Location = New System.Drawing.Point(466, 94)
        Me.lblPrevTotal.Name = "lblPrevTotal"
        Me.lblPrevTotal.Size = New System.Drawing.Size(91, 18)
        Me.lblPrevTotal.TabIndex = 42
        Me.lblPrevTotal.Text = "Total Amount"
        '
        'lblPrevPen
        '
        Me.lblPrevPen.AutoSize = True
        Me.lblPrevPen.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevPen.Location = New System.Drawing.Point(466, 58)
        Me.lblPrevPen.Name = "lblPrevPen"
        Me.lblPrevPen.Size = New System.Drawing.Size(55, 18)
        Me.lblPrevPen.TabIndex = 41
        Me.lblPrevPen.Text = "Penalty"
        '
        'lblPrevIns
        '
        Me.lblPrevIns.AutoSize = True
        Me.lblPrevIns.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevIns.Location = New System.Drawing.Point(466, 76)
        Me.lblPrevIns.Name = "lblPrevIns"
        Me.lblPrevIns.Size = New System.Drawing.Size(105, 18)
        Me.lblPrevIns.TabIndex = 40
        Me.lblPrevIns.Text = "Installment Fee"
        '
        'lblPrevWSF
        '
        Me.lblPrevWSF.AutoSize = True
        Me.lblPrevWSF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevWSF.Location = New System.Drawing.Point(466, 40)
        Me.lblPrevWSF.Name = "lblPrevWSF"
        Me.lblPrevWSF.Size = New System.Drawing.Size(58, 18)
        Me.lblPrevWSF.TabIndex = 37
        Me.lblPrevWSF.Text = "Amount"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(349, 94)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(91, 18)
        Me.Label45.TabIndex = 36
        Me.Label45.Text = "Total Amount"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(349, 58)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(55, 18)
        Me.Label44.TabIndex = 35
        Me.Label44.Text = "Penalty"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(349, 76)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(105, 18)
        Me.Label43.TabIndex = 34
        Me.Label43.Text = "Installment Fee"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(349, 40)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(58, 18)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Amount"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(312, 22)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(159, 18)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "Previous Balance Details"
        '
        'lblAmountADue
        '
        Me.lblAmountADue.AutoSize = True
        Me.lblAmountADue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountADue.Location = New System.Drawing.Point(155, 274)
        Me.lblAmountADue.Name = "lblAmountADue"
        Me.lblAmountADue.Size = New System.Drawing.Size(121, 18)
        Me.lblAmountADue.TabIndex = 29
        Me.lblAmountADue.Text = "Amount After Due"
        '
        'lblPenalty
        '
        Me.lblPenalty.AutoSize = True
        Me.lblPenalty.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenalty.Location = New System.Drawing.Point(155, 256)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(55, 18)
        Me.lblPenalty.TabIndex = 28
        Me.lblPenalty.Text = "Penalty"
        '
        'lblTotalAmountDue
        '
        Me.lblTotalAmountDue.AutoSize = True
        Me.lblTotalAmountDue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountDue.Location = New System.Drawing.Point(155, 238)
        Me.lblTotalAmountDue.Name = "lblTotalAmountDue"
        Me.lblTotalAmountDue.Size = New System.Drawing.Size(119, 18)
        Me.lblTotalAmountDue.TabIndex = 27
        Me.lblTotalAmountDue.Text = "Total Amount Due"
        '
        'lblInstallmentFee
        '
        Me.lblInstallmentFee.AutoSize = True
        Me.lblInstallmentFee.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstallmentFee.Location = New System.Drawing.Point(155, 220)
        Me.lblInstallmentFee.Name = "lblInstallmentFee"
        Me.lblInstallmentFee.Size = New System.Drawing.Size(105, 18)
        Me.lblInstallmentFee.TabIndex = 26
        Me.lblInstallmentFee.Text = "Installment Fee"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(155, 202)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(62, 18)
        Me.lblDiscount.TabIndex = 25
        Me.lblDiscount.Text = "Discount"
        '
        'lblEF
        '
        Me.lblEF.AutoSize = True
        Me.lblEF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEF.Location = New System.Drawing.Point(155, 184)
        Me.lblEF.Name = "lblEF"
        Me.lblEF.Size = New System.Drawing.Size(22, 18)
        Me.lblEF.TabIndex = 24
        Me.lblEF.Text = "EF"
        '
        'lblWSF
        '
        Me.lblWSF.AutoSize = True
        Me.lblWSF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWSF.Location = New System.Drawing.Point(155, 166)
        Me.lblWSF.Name = "lblWSF"
        Me.lblWSF.Size = New System.Drawing.Size(36, 18)
        Me.lblWSF.TabIndex = 23
        Me.lblWSF.Text = "WSF"
        '
        'lblConsump
        '
        Me.lblConsump.AutoSize = True
        Me.lblConsump.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsump.Location = New System.Drawing.Point(155, 148)
        Me.lblConsump.Name = "lblConsump"
        Me.lblConsump.Size = New System.Drawing.Size(91, 18)
        Me.lblConsump.TabIndex = 22
        Me.lblConsump.Text = "Consumption"
        '
        'lblPresRead
        '
        Me.lblPresRead.AutoSize = True
        Me.lblPresRead.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresRead.Location = New System.Drawing.Point(155, 130)
        Me.lblPresRead.Name = "lblPresRead"
        Me.lblPresRead.Size = New System.Drawing.Size(109, 18)
        Me.lblPresRead.TabIndex = 21
        Me.lblPresRead.Text = "Present Reading"
        '
        'lblPrevRead
        '
        Me.lblPrevRead.AutoSize = True
        Me.lblPrevRead.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevRead.Location = New System.Drawing.Point(155, 112)
        Me.lblPrevRead.Name = "lblPrevRead"
        Me.lblPrevRead.Size = New System.Drawing.Size(115, 18)
        Me.lblPrevRead.TabIndex = 20
        Me.lblPrevRead.Text = "Previous Reading"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(155, 94)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(79, 18)
        Me.lblAccountNo.TabIndex = 19
        Me.lblAccountNo.Text = "Account No"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(155, 76)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(65, 18)
        Me.lblDueDate.TabIndex = 18
        Me.lblDueDate.Text = "Due Date"
        '
        'lblBillDate
        '
        Me.lblBillDate.AutoSize = True
        Me.lblBillDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDate.Location = New System.Drawing.Point(155, 58)
        Me.lblBillDate.Name = "lblBillDate"
        Me.lblBillDate.Size = New System.Drawing.Size(60, 18)
        Me.lblBillDate.TabIndex = 17
        Me.lblBillDate.Text = "Bill Date"
        '
        'lblBillPer
        '
        Me.lblBillPer.AutoSize = True
        Me.lblBillPer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillPer.Location = New System.Drawing.Point(155, 40)
        Me.lblBillPer.Name = "lblBillPer"
        Me.lblBillPer.Size = New System.Drawing.Size(72, 18)
        Me.lblBillPer.TabIndex = 16
        Me.lblBillPer.Text = "Bill Period"
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.Location = New System.Drawing.Point(155, 22)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(49, 18)
        Me.lblBillNo.TabIndex = 15
        Me.lblBillNo.Text = "Bill No"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(19, 274)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 18)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Amount After Due"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 256)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 18)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Penalty"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 238)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 18)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Total Amount Due"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 220)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Installment Fee"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 202)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 18)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Discount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "EF"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "WSF"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 18)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Consumption"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 18)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Present Reading"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 18)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Previous Reading"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Account No"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 18)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Due Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Bill Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Bill Period"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Bill No"
        '
        'btnOverpayment
        '
        Me.btnOverpayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOverpayment.BackColor = System.Drawing.Color.SteelBlue
        Me.btnOverpayment.FlatAppearance.BorderSize = 0
        Me.btnOverpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverpayment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverpayment.ForeColor = System.Drawing.Color.White
        Me.btnOverpayment.Location = New System.Drawing.Point(1123, 357)
        Me.btnOverpayment.Name = "btnOverpayment"
        Me.btnOverpayment.Size = New System.Drawing.Size(160, 30)
        Me.btnOverpayment.TabIndex = 35
        Me.btnOverpayment.Text = "Add Overpayment"
        Me.btnOverpayment.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(957, 465)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 30)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Meter Replacement"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'WaterBillPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnOverpayment)
        Me.Controls.Add(Me.btnAdjust)
        Me.Controls.Add(Me.gbxBill)
        Me.Controls.Add(Me.btnInstallmentFeeEdit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddTransferMeter)
        Me.Controls.Add(Me.btnAddTransferOwner)
        Me.Controls.Add(Me.btnAddReconnection)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPayPrev)
        Me.Controls.Add(Me.btnSearchBill)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblConsumerID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtORNum)
        Me.Controls.Add(Me.lblCollectionOfficer)
        Me.Controls.Add(Me.lvwAccounts)
        Me.Controls.Add(Me.cboConsumerName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WaterBillPayment"
        Me.Text = "WaterBillPayment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxBill.ResumeLayout(False)
        Me.gbxBill.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboConsumerName As System.Windows.Forms.ComboBox
    Friend WithEvents lvwAccounts As System.Windows.Forms.ListView
    Friend WithEvents lblCollectionOfficer As System.Windows.Forms.Label
    Friend WithEvents txtORNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblConsumerID As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdjust As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSeniorID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBill As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchBill As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnPayPrev As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents btnAddReconnection As Button
    Friend WithEvents btnAddTransferOwner As Button
    Friend WithEvents btnAddTransferMeter As Button
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnInstallmentFeeEdit As Button
    Friend WithEvents gbxBill As GroupBox
    Friend WithEvents lblAmountADue As Label
    Friend WithEvents lblPenalty As Label
    Friend WithEvents lblTotalAmountDue As Label
    Friend WithEvents lblInstallmentFee As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblEF As Label
    Friend WithEvents lblWSF As Label
    Friend WithEvents lblConsump As Label
    Friend WithEvents lblPresRead As Label
    Friend WithEvents lblPrevRead As Label
    Friend WithEvents lblAccountNo As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblBillDate As Label
    Friend WithEvents lblBillPer As Label
    Friend WithEvents lblBillNo As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAdjTot As Label
    Friend WithEvents lblAdjPen As Label
    Friend WithEvents lblAdjDis As Label
    Friend WithEvents lblAdjEF As Label
    Friend WithEvents lblAdjWSF As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents lblPrevTotal As Label
    Friend WithEvents lblPrevPen As Label
    Friend WithEvents lblPrevIns As Label
    Friend WithEvents lblPrevWSF As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lblAdjRem As Label
    Friend WithEvents lblisADJ As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents btnOverpayment As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Button4 As Button
End Class
