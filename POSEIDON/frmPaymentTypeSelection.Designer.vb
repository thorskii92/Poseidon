<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaymentTypeSelection
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
        Me.cboPType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblORNum = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPaymentPeriod = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblConsName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.lblDrawee = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAccountNo = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblHide = New System.Windows.Forms.Label()
        Me.lblInstallment = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblPrevBalance = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblMeterReader = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblReq = New System.Windows.Forms.Label()
        Me.lblSCDis = New System.Windows.Forms.Label()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.lblEnviFee = New System.Windows.Forms.Label()
        Me.lblWSF = New System.Windows.Forms.Label()
        Me.lblConsump = New System.Windows.Forms.Label()
        Me.lblPresRead = New System.Windows.Forms.Label()
        Me.billPrevRead = New System.Windows.Forms.Label()
        Me.lblBillDate = New System.Windows.Forms.Label()
        Me.lblReadDate = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblBillPeriod = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboBillNum = New System.Windows.Forms.ComboBox()
        Me.lblTotalDiscount = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblTotalWSF = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblTotalEnvi = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblTotalPen = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.lblPrevBillDetails = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblStartMonth = New System.Windows.Forms.Label()
        Me.lblStartYear = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.lblPrevEF = New System.Windows.Forms.Label()
        Me.txtEF = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblPrevDiscount = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblOthers = New System.Windows.Forms.Label()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.lblPrevPen = New System.Windows.Forms.Label()
        Me.lblTotalInstallment = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblOverpayment = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblBulkAmount = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboPType
        '
        Me.cboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPType.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPType.FormattingEnabled = True
        Me.cboPType.Items.AddRange(New Object() {"Cash", "Check", "Money Order"})
        Me.cboPType.Location = New System.Drawing.Point(196, 467)
        Me.cboPType.Name = "cboPType"
        Me.cboPType.Size = New System.Drawing.Size(264, 31)
        Me.cboPType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payment Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 507)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(196, 504)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(423, 31)
        Me.txtAmount.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(28, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Amount to Pay"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.DimGray
        Me.lblTotalAmount.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.White
        Me.lblTotalAmount.Location = New System.Drawing.Point(196, 388)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(423, 67)
        Me.lblTotalAmount.TabIndex = 5
        Me.lblTotalAmount.Text = "0"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 558)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Change"
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Gray
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(196, 542)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(423, 55)
        Me.lblChange.TabIndex = 7
        Me.lblChange.Text = "0"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblORNum
        '
        Me.lblORNum.BackColor = System.Drawing.Color.Firebrick
        Me.lblORNum.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORNum.ForeColor = System.Drawing.Color.White
        Me.lblORNum.Location = New System.Drawing.Point(1154, 21)
        Me.lblORNum.Name = "lblORNum"
        Me.lblORNum.Size = New System.Drawing.Size(200, 30)
        Me.lblORNum.TabIndex = 9
        Me.lblORNum.Text = "0"
        Me.lblORNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1072, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "O.R. No."
        '
        'lblPaymentPeriod
        '
        Me.lblPaymentPeriod.BackColor = System.Drawing.Color.Silver
        Me.lblPaymentPeriod.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentPeriod.Location = New System.Drawing.Point(196, 346)
        Me.lblPaymentPeriod.Name = "lblPaymentPeriod"
        Me.lblPaymentPeriod.Size = New System.Drawing.Size(423, 30)
        Me.lblPaymentPeriod.TabIndex = 11
        Me.lblPaymentPeriod.Text = "0"
        Me.lblPaymentPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 346)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(182, 30)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Payment Period"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConsName
        '
        Me.lblConsName.BackColor = System.Drawing.Color.SteelBlue
        Me.lblConsName.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsName.ForeColor = System.Drawing.Color.White
        Me.lblConsName.Location = New System.Drawing.Point(99, 20)
        Me.lblConsName.Name = "lblConsName"
        Me.lblConsName.Size = New System.Drawing.Size(778, 29)
        Me.lblConsName.TabIndex = 13
        Me.lblConsName.Text = "Juan Dela Cruz"
        Me.lblConsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 29)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "NAME"
        '
        'txtBank
        '
        Me.txtBank.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBank.Location = New System.Drawing.Point(196, 605)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(264, 31)
        Me.txtBank.TabIndex = 15
        '
        'lblDrawee
        '
        Me.lblDrawee.AutoSize = True
        Me.lblDrawee.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrawee.Location = New System.Drawing.Point(78, 608)
        Me.lblDrawee.Name = "lblDrawee"
        Me.lblDrawee.Size = New System.Drawing.Size(112, 23)
        Me.lblDrawee.TabIndex = 14
        Me.lblDrawee.Text = "Drawee Bank"
        '
        'txtNumber
        '
        Me.txtNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumber.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(196, 642)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(264, 31)
        Me.txtNumber.TabIndex = 17
        '
        'lblNumber
        '
        Me.lblNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(121, 645)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(73, 23)
        Me.lblNumber.TabIndex = 16
        Me.lblNumber.Text = "Number"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(145, 685)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 23)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(196, 682)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(264, 31)
        Me.dtpDate.TabIndex = 19
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1197, 699)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 57)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1048, 699)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 57)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save Only"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSavePrint
        '
        Me.btnSavePrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSavePrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSavePrint.FlatAppearance.BorderSize = 0
        Me.btnSavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrint.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrint.ForeColor = System.Drawing.Color.White
        Me.btnSavePrint.Location = New System.Drawing.Point(898, 699)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(143, 57)
        Me.btnSavePrint.TabIndex = 22
        Me.btnSavePrint.Text = "Save and Print"
        Me.btnSavePrint.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Date of Payment"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDate.Location = New System.Drawing.Point(209, 77)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(124, 23)
        Me.lblPaymentDate.TabIndex = 24
        Me.lblPaymentDate.Text = "Juan Dela Cruz"
        Me.lblPaymentDate.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Snow
        Me.GroupBox1.Controls.Add(Me.lblAccountNo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.lblHide)
        Me.GroupBox1.Controls.Add(Me.lblInstallment)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblPrevBalance)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.lblMeterReader)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.lblReq)
        Me.GroupBox1.Controls.Add(Me.lblSCDis)
        Me.GroupBox1.Controls.Add(Me.lblPenalty)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmt)
        Me.GroupBox1.Controls.Add(Me.lblEnviFee)
        Me.GroupBox1.Controls.Add(Me.lblWSF)
        Me.GroupBox1.Controls.Add(Me.lblConsump)
        Me.GroupBox1.Controls.Add(Me.lblPresRead)
        Me.GroupBox1.Controls.Add(Me.billPrevRead)
        Me.GroupBox1.Controls.Add(Me.lblBillDate)
        Me.GroupBox1.Controls.Add(Me.lblReadDate)
        Me.GroupBox1.Controls.Add(Me.lblDueDate)
        Me.GroupBox1.Controls.Add(Me.lblBillPeriod)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboBillNum)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(625, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 522)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Details"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.AutoSize = True
        Me.lblAccountNo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNo.Location = New System.Drawing.Point(247, 57)
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(45, 23)
        Me.lblAccountNo.TabIndex = 72
        Me.lblAccountNo.Text = "0.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(114, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 23)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "Account #:"
        '
        'lblHide
        '
        Me.lblHide.Location = New System.Drawing.Point(247, 79)
        Me.lblHide.Name = "lblHide"
        Me.lblHide.Size = New System.Drawing.Size(250, 405)
        Me.lblHide.TabIndex = 70
        Me.lblHide.Visible = False
        '
        'lblInstallment
        '
        Me.lblInstallment.AutoSize = True
        Me.lblInstallment.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstallment.Location = New System.Drawing.Point(247, 400)
        Me.lblInstallment.Name = "lblInstallment"
        Me.lblInstallment.Size = New System.Drawing.Size(45, 23)
        Me.lblInstallment.TabIndex = 69
        Me.lblInstallment.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(69, 400)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 23)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Installment Fee:"
        '
        'lblPrevBalance
        '
        Me.lblPrevBalance.AutoSize = True
        Me.lblPrevBalance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevBalance.Location = New System.Drawing.Point(247, 454)
        Me.lblPrevBalance.Name = "lblPrevBalance"
        Me.lblPrevBalance.Size = New System.Drawing.Size(45, 23)
        Me.lblPrevBalance.TabIndex = 67
        Me.lblPrevBalance.Text = "0.00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(58, 454)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(150, 23)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = "Previous Balance:"
        '
        'lblMeterReader
        '
        Me.lblMeterReader.AutoSize = True
        Me.lblMeterReader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeterReader.Location = New System.Drawing.Point(247, 80)
        Me.lblMeterReader.Name = "lblMeterReader"
        Me.lblMeterReader.Size = New System.Drawing.Size(45, 23)
        Me.lblMeterReader.TabIndex = 65
        Me.lblMeterReader.Text = "0.00"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(80, 80)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(127, 23)
        Me.Label30.TabIndex = 64
        Me.Label30.Text = "Meter Reader:"
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Maroon
        Me.lblReq.Location = New System.Drawing.Point(246, 484)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(51, 26)
        Me.lblReq.TabIndex = 63
        Me.lblReq.Text = "0.00"
        '
        'lblSCDis
        '
        Me.lblSCDis.AutoSize = True
        Me.lblSCDis.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCDis.Location = New System.Drawing.Point(247, 375)
        Me.lblSCDis.Name = "lblSCDis"
        Me.lblSCDis.Size = New System.Drawing.Size(45, 23)
        Me.lblSCDis.TabIndex = 59
        Me.lblSCDis.Text = "0.00"
        '
        'lblPenalty
        '
        Me.lblPenalty.AutoSize = True
        Me.lblPenalty.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenalty.Location = New System.Drawing.Point(247, 352)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(45, 23)
        Me.lblPenalty.TabIndex = 58
        Me.lblPenalty.Text = "0.00"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmt.Location = New System.Drawing.Point(247, 423)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(45, 23)
        Me.lblTotalAmt.TabIndex = 57
        Me.lblTotalAmt.Text = "0.00"
        '
        'lblEnviFee
        '
        Me.lblEnviFee.AutoSize = True
        Me.lblEnviFee.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnviFee.Location = New System.Drawing.Point(247, 329)
        Me.lblEnviFee.Name = "lblEnviFee"
        Me.lblEnviFee.Size = New System.Drawing.Size(45, 23)
        Me.lblEnviFee.TabIndex = 54
        Me.lblEnviFee.Text = "0.00"
        '
        'lblWSF
        '
        Me.lblWSF.AutoSize = True
        Me.lblWSF.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWSF.Location = New System.Drawing.Point(247, 306)
        Me.lblWSF.Name = "lblWSF"
        Me.lblWSF.Size = New System.Drawing.Size(45, 23)
        Me.lblWSF.TabIndex = 53
        Me.lblWSF.Text = "0.00"
        '
        'lblConsump
        '
        Me.lblConsump.AutoSize = True
        Me.lblConsump.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsump.Location = New System.Drawing.Point(247, 268)
        Me.lblConsump.Name = "lblConsump"
        Me.lblConsump.Size = New System.Drawing.Size(45, 23)
        Me.lblConsump.TabIndex = 52
        Me.lblConsump.Text = "0.00"
        '
        'lblPresRead
        '
        Me.lblPresRead.AutoSize = True
        Me.lblPresRead.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresRead.Location = New System.Drawing.Point(247, 245)
        Me.lblPresRead.Name = "lblPresRead"
        Me.lblPresRead.Size = New System.Drawing.Size(45, 23)
        Me.lblPresRead.TabIndex = 51
        Me.lblPresRead.Text = "0.00"
        '
        'billPrevRead
        '
        Me.billPrevRead.AutoSize = True
        Me.billPrevRead.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billPrevRead.Location = New System.Drawing.Point(247, 222)
        Me.billPrevRead.Name = "billPrevRead"
        Me.billPrevRead.Size = New System.Drawing.Size(45, 23)
        Me.billPrevRead.TabIndex = 50
        Me.billPrevRead.Text = "0.00"
        '
        'lblBillDate
        '
        Me.lblBillDate.AutoSize = True
        Me.lblBillDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDate.Location = New System.Drawing.Point(247, 187)
        Me.lblBillDate.Name = "lblBillDate"
        Me.lblBillDate.Size = New System.Drawing.Size(45, 23)
        Me.lblBillDate.TabIndex = 49
        Me.lblBillDate.Text = "0.00"
        '
        'lblReadDate
        '
        Me.lblReadDate.AutoSize = True
        Me.lblReadDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadDate.Location = New System.Drawing.Point(247, 164)
        Me.lblReadDate.Name = "lblReadDate"
        Me.lblReadDate.Size = New System.Drawing.Size(45, 23)
        Me.lblReadDate.TabIndex = 48
        Me.lblReadDate.Text = "0.00"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(247, 141)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(45, 23)
        Me.lblDueDate.TabIndex = 47
        Me.lblDueDate.Text = "0.00"
        '
        'lblBillPeriod
        '
        Me.lblBillPeriod.AutoSize = True
        Me.lblBillPeriod.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillPeriod.Location = New System.Drawing.Point(247, 118)
        Me.lblBillPeriod.Name = "lblBillPeriod"
        Me.lblBillPeriod.Size = New System.Drawing.Size(45, 23)
        Me.lblBillPeriod.TabIndex = 46
        Me.lblBillPeriod.Text = "0.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(46, 486)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(162, 23)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Required Payment:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(53, 375)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(155, 23)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "SC/PWD Discount:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(133, 352)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 23)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Penalty:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(87, 423)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 23)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Total Amount:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(158, 306)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 23)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "WSF:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(44, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(164, 23)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Environmental Fee:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(89, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 23)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Consumption:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 23)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Present Reading:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 23)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Previous Reading:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(100, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Billing Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(118, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 23)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Due Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Reading Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 23)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Billing Period:"
        '
        'cboBillNum
        '
        Me.cboBillNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillNum.FormattingEnabled = True
        Me.cboBillNum.Location = New System.Drawing.Point(5, 26)
        Me.cboBillNum.Name = "cboBillNum"
        Me.cboBillNum.Size = New System.Drawing.Size(520, 27)
        Me.cboBillNum.TabIndex = 27
        '
        'lblTotalDiscount
        '
        Me.lblTotalDiscount.BackColor = System.Drawing.Color.Silver
        Me.lblTotalDiscount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDiscount.Location = New System.Drawing.Point(196, 166)
        Me.lblTotalDiscount.Name = "lblTotalDiscount"
        Me.lblTotalDiscount.Size = New System.Drawing.Size(423, 30)
        Me.lblTotalDiscount.TabIndex = 27
        Me.lblTotalDiscount.Text = "0"
        Me.lblTotalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Silver
        Me.Label29.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 166)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(182, 30)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Discount"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalWSF
        '
        Me.lblTotalWSF.BackColor = System.Drawing.Color.Silver
        Me.lblTotalWSF.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWSF.Location = New System.Drawing.Point(196, 106)
        Me.lblTotalWSF.Name = "lblTotalWSF"
        Me.lblTotalWSF.Size = New System.Drawing.Size(423, 30)
        Me.lblTotalWSF.TabIndex = 31
        Me.lblTotalWSF.Text = "0"
        Me.lblTotalWSF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Silver
        Me.Label31.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(12, 106)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(182, 30)
        Me.Label31.TabIndex = 30
        Me.Label31.Text = "WSF"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalEnvi
        '
        Me.lblTotalEnvi.BackColor = System.Drawing.Color.LightGray
        Me.lblTotalEnvi.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEnvi.Location = New System.Drawing.Point(196, 136)
        Me.lblTotalEnvi.Name = "lblTotalEnvi"
        Me.lblTotalEnvi.Size = New System.Drawing.Size(423, 30)
        Me.lblTotalEnvi.TabIndex = 29
        Me.lblTotalEnvi.Text = "0"
        Me.lblTotalEnvi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Silver
        Me.Label33.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(182, 30)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "Env Fee"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Silver
        Me.Label34.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 196)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(182, 30)
        Me.Label34.TabIndex = 32
        Me.Label34.Text = "Penalty"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPen
        '
        Me.lblTotalPen.BackColor = System.Drawing.Color.LightGray
        Me.lblTotalPen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPen.Location = New System.Drawing.Point(196, 196)
        Me.lblTotalPen.Name = "lblTotalPen"
        Me.lblTotalPen.Size = New System.Drawing.Size(423, 30)
        Me.lblTotalPen.TabIndex = 33
        Me.lblTotalPen.Text = "0"
        Me.lblTotalPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(21, 49)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 23)
        Me.Label32.TabIndex = 34
        Me.Label32.Text = "Address"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(100, 53)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 19)
        Me.lblAddress.TabIndex = 35
        Me.lblAddress.Text = "ADDRESS"
        '
        'tmr
        '
        Me.tmr.Interval = 500
        '
        'lblPrevBillDetails
        '
        Me.lblPrevBillDetails.AutoSize = True
        Me.lblPrevBillDetails.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevBillDetails.Location = New System.Drawing.Point(626, 628)
        Me.lblPrevBillDetails.Name = "lblPrevBillDetails"
        Me.lblPrevBillDetails.Size = New System.Drawing.Size(193, 23)
        Me.lblPrevBillDetails.TabIndex = 36
        Me.lblPrevBillDetails.Text = "PREVIOUS BILL DETAILS"
        '
        'cboMonth
        '
        Me.cboMonth.BackColor = System.Drawing.Color.White
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Enabled = False
        Me.cboMonth.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(636, 653)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(192, 31)
        Me.cboMonth.TabIndex = 37
        '
        'lblStartMonth
        '
        Me.lblStartMonth.AutoSize = True
        Me.lblStartMonth.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartMonth.Location = New System.Drawing.Point(503, 656)
        Me.lblStartMonth.Name = "lblStartMonth"
        Me.lblStartMonth.Size = New System.Drawing.Size(127, 23)
        Me.lblStartMonth.TabIndex = 38
        Me.lblStartMonth.Text = "Starting Month"
        '
        'lblStartYear
        '
        Me.lblStartYear.AutoSize = True
        Me.lblStartYear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartYear.Location = New System.Drawing.Point(834, 656)
        Me.lblStartYear.Name = "lblStartYear"
        Me.lblStartYear.Size = New System.Drawing.Size(43, 23)
        Me.lblStartYear.TabIndex = 39
        Me.lblStartYear.Text = "Year"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Enabled = False
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021"})
        Me.cboYear.Location = New System.Drawing.Point(883, 653)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(117, 31)
        Me.cboYear.TabIndex = 40
        '
        'lblPrevEF
        '
        Me.lblPrevEF.AutoSize = True
        Me.lblPrevEF.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevEF.Location = New System.Drawing.Point(1042, 628)
        Me.lblPrevEF.Name = "lblPrevEF"
        Me.lblPrevEF.Size = New System.Drawing.Size(36, 23)
        Me.lblPrevEF.TabIndex = 41
        Me.lblPrevEF.Text = "E.F."
        '
        'txtEF
        '
        Me.txtEF.Enabled = False
        Me.txtEF.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEF.Location = New System.Drawing.Point(1006, 653)
        Me.txtEF.Name = "txtEF"
        Me.txtEF.Size = New System.Drawing.Size(112, 31)
        Me.txtEF.TabIndex = 42
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(1124, 653)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(112, 31)
        Me.txtDiscount.TabIndex = 44
        '
        'lblPrevDiscount
        '
        Me.lblPrevDiscount.AutoSize = True
        Me.lblPrevDiscount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevDiscount.Location = New System.Drawing.Point(1142, 628)
        Me.lblPrevDiscount.Name = "lblPrevDiscount"
        Me.lblPrevDiscount.Size = New System.Drawing.Size(78, 23)
        Me.lblPrevDiscount.TabIndex = 43
        Me.lblPrevDiscount.Text = "Discount"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(196, 72)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(423, 31)
        Me.dtpPaymentDate.TabIndex = 45
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Silver
        Me.Label35.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(12, 256)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(182, 30)
        Me.Label35.TabIndex = 46
        Me.Label35.Text = "Other Fees"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOthers
        '
        Me.lblOthers.BackColor = System.Drawing.Color.LightGray
        Me.lblOthers.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOthers.Location = New System.Drawing.Point(196, 256)
        Me.lblOthers.Name = "lblOthers"
        Me.lblOthers.Size = New System.Drawing.Size(423, 30)
        Me.lblOthers.TabIndex = 47
        Me.lblOthers.Text = "0"
        Me.lblOthers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPenalty
        '
        Me.txtPenalty.Enabled = False
        Me.txtPenalty.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.Location = New System.Drawing.Point(1242, 653)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(112, 31)
        Me.txtPenalty.TabIndex = 49
        '
        'lblPrevPen
        '
        Me.lblPrevPen.AutoSize = True
        Me.lblPrevPen.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevPen.Location = New System.Drawing.Point(1263, 628)
        Me.lblPrevPen.Name = "lblPrevPen"
        Me.lblPrevPen.Size = New System.Drawing.Size(67, 23)
        Me.lblPrevPen.TabIndex = 48
        Me.lblPrevPen.Text = "Penalty"
        '
        'lblTotalInstallment
        '
        Me.lblTotalInstallment.BackColor = System.Drawing.Color.Silver
        Me.lblTotalInstallment.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInstallment.Location = New System.Drawing.Point(196, 226)
        Me.lblTotalInstallment.Name = "lblTotalInstallment"
        Me.lblTotalInstallment.Size = New System.Drawing.Size(423, 30)
        Me.lblTotalInstallment.TabIndex = 51
        Me.lblTotalInstallment.Text = "0"
        Me.lblTotalInstallment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(182, 30)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Installment Fee"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOverpayment
        '
        Me.lblOverpayment.BackColor = System.Drawing.Color.Silver
        Me.lblOverpayment.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverpayment.Location = New System.Drawing.Point(196, 286)
        Me.lblOverpayment.Name = "lblOverpayment"
        Me.lblOverpayment.Size = New System.Drawing.Size(423, 30)
        Me.lblOverpayment.TabIndex = 53
        Me.lblOverpayment.Text = "0"
        Me.lblOverpayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Silver
        Me.Label25.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 286)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(182, 30)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Overpayment"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBulkAmount
        '
        Me.lblBulkAmount.BackColor = System.Drawing.Color.LightGray
        Me.lblBulkAmount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBulkAmount.Location = New System.Drawing.Point(196, 316)
        Me.lblBulkAmount.Name = "lblBulkAmount"
        Me.lblBulkAmount.Size = New System.Drawing.Size(423, 30)
        Me.lblBulkAmount.TabIndex = 55
        Me.lblBulkAmount.Text = "0"
        Me.lblBulkAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Silver
        Me.Label26.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 316)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(182, 30)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "Bulk Order"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPaymentTypeSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblBulkAmount)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lblOverpayment)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblTotalInstallment)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.lblPrevPen)
        Me.Controls.Add(Me.lblOthers)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.lblPrevDiscount)
        Me.Controls.Add(Me.txtEF)
        Me.Controls.Add(Me.lblPrevEF)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lblStartYear)
        Me.Controls.Add(Me.lblStartMonth)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblPrevBillDetails)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.lblTotalPen)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lblTotalWSF)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lblTotalEnvi)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblTotalDiscount)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSavePrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.lblDrawee)
        Me.Controls.Add(Me.lblConsName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblPaymentPeriod)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblORNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaymentTypeSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPaymentTypeSelection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboPType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblORNum As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPaymentPeriod As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblConsName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBank As TextBox
    Friend WithEvents lblDrawee As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSavePrint As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboBillNum As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblReq As Label
    Friend WithEvents lblSCDis As Label
    Friend WithEvents lblPenalty As Label
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents lblEnviFee As Label
    Friend WithEvents lblWSF As Label
    Friend WithEvents lblConsump As Label
    Friend WithEvents lblPresRead As Label
    Friend WithEvents billPrevRead As Label
    Friend WithEvents lblBillDate As Label
    Friend WithEvents lblReadDate As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblBillPeriod As Label
    Friend WithEvents lblTotalDiscount As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblTotalWSF As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblTotalEnvi As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblTotalPen As Label
    Friend WithEvents lblMeterReader As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents tmr As Timer
    Friend WithEvents lblPrevBalance As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblPrevBillDetails As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblStartMonth As Label
    Friend WithEvents lblStartYear As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents lblPrevEF As Label
    Friend WithEvents txtEF As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblPrevDiscount As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents lblOthers As Label
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents lblPrevPen As Label
    Friend WithEvents lblInstallment As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotalInstallment As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblHide As Label
    Friend WithEvents lblAccountNo As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblOverpayment As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblBulkAmount As Label
    Friend WithEvents Label26 As Label
End Class
