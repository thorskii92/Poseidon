<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManuallyAddBill
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
        Me.rdbManual = New System.Windows.Forms.RadioButton()
        Me.txtAmountAfterDue = New System.Windows.Forms.TextBox()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtEF = New System.Windows.Forms.TextBox()
        Me.txtWSF = New System.Windows.Forms.TextBox()
        Me.rdbNew = New System.Windows.Forms.RadioButton()
        Me.txtPrevInstallment = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBillNote = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAppFee = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.dtpReadDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.cboBillMonth = New System.Windows.Forms.ComboBox()
        Me.cboAccountType = New System.Windows.Forms.ComboBox()
        Me.cboClassification = New System.Windows.Forms.ComboBox()
        Me.txtPrevTotal = New System.Windows.Forms.TextBox()
        Me.txtPrevPenalty = New System.Windows.Forms.TextBox()
        Me.txtPrevAmount = New System.Windows.Forms.TextBox()
        Me.txtPresRead = New System.Windows.Forms.TextBox()
        Me.txtPrevRead = New System.Windows.Forms.TextBox()
        Me.lblConsump = New System.Windows.Forms.Label()
        Me.lblAcctName = New System.Windows.Forms.Label()
        Me.lblConsumerName = New System.Windows.Forms.Label()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrevEF = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrevDiscount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'rdbManual
        '
        Me.rdbManual.AutoSize = True
        Me.rdbManual.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbManual.Location = New System.Drawing.Point(171, 154)
        Me.rdbManual.Name = "rdbManual"
        Me.rdbManual.Size = New System.Drawing.Size(73, 22)
        Me.rdbManual.TabIndex = 176
        Me.rdbManual.TabStop = True
        Me.rdbManual.Text = "Manual"
        Me.rdbManual.UseVisualStyleBackColor = True
        '
        'txtAmountAfterDue
        '
        Me.txtAmountAfterDue.Enabled = False
        Me.txtAmountAfterDue.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountAfterDue.Location = New System.Drawing.Point(174, 524)
        Me.txtAmountAfterDue.Name = "txtAmountAfterDue"
        Me.txtAmountAfterDue.ReadOnly = True
        Me.txtAmountAfterDue.Size = New System.Drawing.Size(231, 27)
        Me.txtAmountAfterDue.TabIndex = 175
        '
        'txtPenalty
        '
        Me.txtPenalty.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.Location = New System.Drawing.Point(175, 489)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(231, 27)
        Me.txtPenalty.TabIndex = 174
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Enabled = False
        Me.txtTotalAmt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmt.Location = New System.Drawing.Point(174, 458)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(231, 27)
        Me.txtTotalAmt.TabIndex = 173
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(174, 390)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(231, 27)
        Me.txtTotal.TabIndex = 172
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(174, 355)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(231, 27)
        Me.txtDiscount.TabIndex = 171
        '
        'txtEF
        '
        Me.txtEF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEF.Location = New System.Drawing.Point(174, 322)
        Me.txtEF.Name = "txtEF"
        Me.txtEF.Size = New System.Drawing.Size(231, 27)
        Me.txtEF.TabIndex = 170
        '
        'txtWSF
        '
        Me.txtWSF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWSF.Location = New System.Drawing.Point(175, 289)
        Me.txtWSF.Name = "txtWSF"
        Me.txtWSF.Size = New System.Drawing.Size(231, 27)
        Me.txtWSF.TabIndex = 169
        '
        'rdbNew
        '
        Me.rdbNew.AutoSize = True
        Me.rdbNew.Checked = True
        Me.rdbNew.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNew.Location = New System.Drawing.Point(250, 154)
        Me.rdbNew.Name = "rdbNew"
        Me.rdbNew.Size = New System.Drawing.Size(56, 22)
        Me.rdbNew.TabIndex = 168
        Me.rdbNew.TabStop = True
        Me.rdbNew.Text = "Auto"
        Me.rdbNew.UseVisualStyleBackColor = True
        '
        'txtPrevInstallment
        '
        Me.txtPrevInstallment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevInstallment.Location = New System.Drawing.Point(685, 426)
        Me.txtPrevInstallment.Name = "txtPrevInstallment"
        Me.txtPrevInstallment.Size = New System.Drawing.Size(215, 27)
        Me.txtPrevInstallment.TabIndex = 167
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(484, 429)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 19)
        Me.Label18.TabIndex = 166
        Me.Label18.Text = "Installment Fee"
        '
        'txtBillNote
        '
        Me.txtBillNote.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNote.Location = New System.Drawing.Point(482, 534)
        Me.txtBillNote.Multiline = True
        Me.txtBillNote.Name = "txtBillNote"
        Me.txtBillNote.Size = New System.Drawing.Size(418, 75)
        Me.txtBillNote.TabIndex = 165
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(472, 512)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 19)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Bill Note"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 459)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 19)
        Me.Label25.TabIndex = 163
        Me.Label25.Text = "Total Amount"
        '
        'txtAppFee
        '
        Me.txtAppFee.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppFee.Location = New System.Drawing.Point(175, 423)
        Me.txtAppFee.Name = "txtAppFee"
        Me.txtAppFee.Size = New System.Drawing.Size(230, 27)
        Me.txtAppFee.TabIndex = 162
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(13, 426)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(114, 19)
        Me.Label43.TabIndex = 161
        Me.Label43.Text = "Application Fee"
        '
        'dtpReadDate
        '
        Me.dtpReadDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReadDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReadDate.Location = New System.Drawing.Point(626, 37)
        Me.dtpReadDate.Name = "dtpReadDate"
        Me.dtpReadDate.Size = New System.Drawing.Size(274, 27)
        Me.dtpReadDate.TabIndex = 160
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(464, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 19)
        Me.Label20.TabIndex = 159
        Me.Label20.Text = "Reading Date"
        '
        'dtpBillDate
        '
        Me.dtpBillDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBillDate.Location = New System.Drawing.Point(626, 3)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.Size = New System.Drawing.Size(274, 27)
        Me.dtpBillDate.TabIndex = 156
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(464, 9)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(66, 19)
        Me.Label53.TabIndex = 155
        Me.Label53.Text = "Bill Date"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(626, 201)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(274, 27)
        Me.dtpToDate.TabIndex = 154
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(626, 168)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(274, 27)
        Me.dtpFromDate.TabIndex = 153
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(626, 70)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(274, 27)
        Me.dtpDueDate.TabIndex = 152
        '
        'cboBillMonth
        '
        Me.cboBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillMonth.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBillMonth.FormattingEnabled = True
        Me.cboBillMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboBillMonth.Location = New System.Drawing.Point(626, 102)
        Me.cboBillMonth.Name = "cboBillMonth"
        Me.cboBillMonth.Size = New System.Drawing.Size(274, 27)
        Me.cboBillMonth.TabIndex = 150
        '
        'cboAccountType
        '
        Me.cboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccountType.FormattingEnabled = True
        Me.cboAccountType.Items.AddRange(New Object() {"Regular", "SC/PWD"})
        Me.cboAccountType.Location = New System.Drawing.Point(174, 120)
        Me.cboAccountType.Name = "cboAccountType"
        Me.cboAccountType.Size = New System.Drawing.Size(231, 27)
        Me.cboAccountType.TabIndex = 149
        '
        'cboClassification
        '
        Me.cboClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClassification.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClassification.FormattingEnabled = True
        Me.cboClassification.Location = New System.Drawing.Point(174, 87)
        Me.cboClassification.Name = "cboClassification"
        Me.cboClassification.Size = New System.Drawing.Size(231, 27)
        Me.cboClassification.TabIndex = 148
        '
        'txtPrevTotal
        '
        Me.txtPrevTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevTotal.Location = New System.Drawing.Point(685, 459)
        Me.txtPrevTotal.Name = "txtPrevTotal"
        Me.txtPrevTotal.Size = New System.Drawing.Size(215, 27)
        Me.txtPrevTotal.TabIndex = 147
        '
        'txtPrevPenalty
        '
        Me.txtPrevPenalty.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevPenalty.Location = New System.Drawing.Point(685, 393)
        Me.txtPrevPenalty.Name = "txtPrevPenalty"
        Me.txtPrevPenalty.Size = New System.Drawing.Size(215, 27)
        Me.txtPrevPenalty.TabIndex = 146
        '
        'txtPrevAmount
        '
        Me.txtPrevAmount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevAmount.Location = New System.Drawing.Point(685, 294)
        Me.txtPrevAmount.Name = "txtPrevAmount"
        Me.txtPrevAmount.Size = New System.Drawing.Size(215, 27)
        Me.txtPrevAmount.TabIndex = 145
        '
        'txtPresRead
        '
        Me.txtPresRead.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresRead.Location = New System.Drawing.Point(178, 217)
        Me.txtPresRead.Name = "txtPresRead"
        Me.txtPresRead.Size = New System.Drawing.Size(227, 27)
        Me.txtPresRead.TabIndex = 144
        '
        'txtPrevRead
        '
        Me.txtPrevRead.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevRead.Location = New System.Drawing.Point(178, 184)
        Me.txtPrevRead.Name = "txtPrevRead"
        Me.txtPrevRead.Size = New System.Drawing.Size(227, 27)
        Me.txtPrevRead.TabIndex = 143
        '
        'lblConsump
        '
        Me.lblConsump.AutoSize = True
        Me.lblConsump.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsump.Location = New System.Drawing.Point(175, 260)
        Me.lblConsump.Name = "lblConsump"
        Me.lblConsump.Size = New System.Drawing.Size(99, 19)
        Me.lblConsump.TabIndex = 142
        Me.lblConsump.Text = "Consumption"
        '
        'lblAcctName
        '
        Me.lblAcctName.AutoSize = True
        Me.lblAcctName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctName.Location = New System.Drawing.Point(174, 47)
        Me.lblAcctName.Name = "lblAcctName"
        Me.lblAcctName.Size = New System.Drawing.Size(110, 19)
        Me.lblAcctName.TabIndex = 141
        Me.lblAcctName.Text = "Account Name"
        '
        'lblConsumerName
        '
        Me.lblConsumerName.AutoSize = True
        Me.lblConsumerName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsumerName.Location = New System.Drawing.Point(174, 28)
        Me.lblConsumerName.Name = "lblConsumerName"
        Me.lblConsumerName.Size = New System.Drawing.Size(121, 19)
        Me.lblConsumerName.TabIndex = 140
        Me.lblConsumerName.Text = "Consumer Name"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(174, 9)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(78, 19)
        Me.lblAccountNo.TabIndex = 139
        Me.lblAccountNo.Text = "Account #"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(13, 360)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(69, 19)
        Me.Label33.TabIndex = 138
        Me.Label33.Text = "Discount"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(12, 492)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(61, 19)
        Me.Label32.TabIndex = 137
        Me.Label32.Text = "Penalty"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(12, 525)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(134, 19)
        Me.Label31.TabIndex = 136
        Me.Label31.Text = "Amount After Due"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 393)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 19)
        Me.Label30.TabIndex = 135
        Me.Label30.Text = "Total Amount"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(13, 327)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 19)
        Me.Label29.TabIndex = 134
        Me.Label29.Text = "PES"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 297)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 19)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Amount(WSF)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(13, 260)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 19)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "Consumption"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(484, 297)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 19)
        Me.Label21.TabIndex = 131
        Me.Label21.Text = "WSF"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(484, 462)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 19)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "Total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(484, 396)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 19)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Penalty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 19)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "Present Reading"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 19)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Previous Reading"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(464, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Bill Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(464, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 19)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Bill Month"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(464, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "To Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(464, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "From Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(464, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Due Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Account Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Classification"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Account Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Consumer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Account #"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(632, 615)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 42)
        Me.btnSave.TabIndex = 178
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(769, 615)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 42)
        Me.btnCancel.TabIndex = 177
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 19)
        Me.Label15.TabIndex = 179
        Me.Label15.Text = "Computation"
        '
        'txtPrevEF
        '
        Me.txtPrevEF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevEF.Location = New System.Drawing.Point(685, 327)
        Me.txtPrevEF.Name = "txtPrevEF"
        Me.txtPrevEF.Size = New System.Drawing.Size(215, 27)
        Me.txtPrevEF.TabIndex = 181
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(484, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 19)
        Me.Label17.TabIndex = 180
        Me.Label17.Text = "PES"
        '
        'txtPrevDiscount
        '
        Me.txtPrevDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevDiscount.Location = New System.Drawing.Point(685, 360)
        Me.txtPrevDiscount.Name = "txtPrevDiscount"
        Me.txtPrevDiscount.Size = New System.Drawing.Size(215, 27)
        Me.txtPrevDiscount.TabIndex = 183
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(484, 363)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 19)
        Me.Label19.TabIndex = 182
        Me.Label19.Text = "Discount"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(464, 260)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 19)
        Me.Label24.TabIndex = 184
        Me.Label24.Text = "Bill Arrears Details"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboYear.Location = New System.Drawing.Point(626, 135)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(274, 27)
        Me.cboYear.TabIndex = 185
        '
        'frmManuallyAddBill
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(926, 669)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtPrevDiscount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPrevEF)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.rdbManual)
        Me.Controls.Add(Me.txtAmountAfterDue)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.txtTotalAmt)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtEF)
        Me.Controls.Add(Me.txtWSF)
        Me.Controls.Add(Me.rdbNew)
        Me.Controls.Add(Me.txtPrevInstallment)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBillNote)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtAppFee)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.dtpReadDate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dtpBillDate)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.cboBillMonth)
        Me.Controls.Add(Me.cboAccountType)
        Me.Controls.Add(Me.cboClassification)
        Me.Controls.Add(Me.txtPrevTotal)
        Me.Controls.Add(Me.txtPrevPenalty)
        Me.Controls.Add(Me.txtPrevAmount)
        Me.Controls.Add(Me.txtPresRead)
        Me.Controls.Add(Me.txtPrevRead)
        Me.Controls.Add(Me.lblConsump)
        Me.Controls.Add(Me.lblAcctName)
        Me.Controls.Add(Me.lblConsumerName)
        Me.Controls.Add(Me.lblAccountNo)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmManuallyAddBill"
        Me.Text = "Add Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbManual As RadioButton
    Friend WithEvents txtAmountAfterDue As TextBox
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents txtTotalAmt As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtEF As TextBox
    Friend WithEvents txtWSF As TextBox
    Friend WithEvents rdbNew As RadioButton
    Friend WithEvents txtPrevInstallment As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBillNote As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtAppFee As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents dtpReadDate As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpBillDate As DateTimePicker
    Friend WithEvents Label53 As Label
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents cboBillMonth As ComboBox
    Friend WithEvents cboAccountType As ComboBox
    Friend WithEvents cboClassification As ComboBox
    Friend WithEvents txtPrevTotal As TextBox
    Friend WithEvents txtPrevPenalty As TextBox
    Friend WithEvents txtPrevAmount As TextBox
    Friend WithEvents txtPresRead As TextBox
    Friend WithEvents txtPrevRead As TextBox
    Friend WithEvents lblConsump As Label
    Friend WithEvents lblAcctName As Label
    Friend WithEvents lblConsumerName As Label
    Friend WithEvents lblAccountNo As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPrevEF As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPrevDiscount As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cboYear As ComboBox
End Class
