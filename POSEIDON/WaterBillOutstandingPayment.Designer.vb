<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaterBillOutstandingPayment
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.lblTotalPrevious = New System.Windows.Forms.Label()
        Me.txtAmtPayment = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEnvi = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboMonthFrom = New System.Windows.Forms.ComboBox()
        Me.cboYearFrom = New System.Windows.Forms.ComboBox()
        Me.cboMonthTo = New System.Windows.Forms.ComboBox()
        Me.cboYearTo = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboPType = New System.Windows.Forms.ComboBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblCheckDate = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCollector = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblConsType = New System.Windows.Forms.Label()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblRemEnvi = New System.Windows.Forms.Label()
        Me.lblRemDisc = New System.Windows.Forms.Label()
        Me.lblRemPenalty = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblRemainingAmount = New System.Windows.Forms.Label()
        Me.lblRemainingEnvi = New System.Windows.Forms.Label()
        Me.lblRemainingDiscount = New System.Windows.Forms.Label()
        Me.lblRemainingPenalty = New System.Windows.Forms.Label()
        Me.lblRemainingInstall = New System.Windows.Forms.Label()
        Me.lblRemInstall = New System.Windows.Forms.Label()
        Me.txtInstallment = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date of Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Consumer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(865, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "O.R. Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Previous Bill Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Amount to Pay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(865, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bill #"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 29)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Change"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(315, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(73, 29)
        Me.lblName.TabIndex = 27
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(315, 75)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(272, 50)
        Me.lblAddress.TabIndex = 28
        Me.lblAddress.Text = "Address"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOR.ForeColor = System.Drawing.Color.Firebrick
        Me.lblOR.Location = New System.Drawing.Point(1055, 20)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(110, 28)
        Me.lblOR.TabIndex = 29
        Me.lblOR.Text = "0000000"
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.Location = New System.Drawing.Point(1090, 49)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(25, 29)
        Me.lblBillNo.TabIndex = 30
        Me.lblBillNo.Text = "1"
        '
        'lblTotalPrevious
        '
        Me.lblTotalPrevious.AutoSize = True
        Me.lblTotalPrevious.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrevious.Location = New System.Drawing.Point(320, 141)
        Me.lblTotalPrevious.Name = "lblTotalPrevious"
        Me.lblTotalPrevious.Size = New System.Drawing.Size(68, 36)
        Me.lblTotalPrevious.TabIndex = 31
        Me.lblTotalPrevious.Text = "0.00"
        '
        'txtAmtPayment
        '
        Me.txtAmtPayment.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtPayment.Location = New System.Drawing.Point(320, 188)
        Me.txtAmtPayment.Name = "txtAmtPayment"
        Me.txtAmtPayment.Size = New System.Drawing.Size(194, 31)
        Me.txtAmtPayment.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 381)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 29)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Money Amount"
        '
        'txtMoney
        '
        Me.txtMoney.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoney.Location = New System.Drawing.Point(319, 383)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(194, 31)
        Me.txtMoney.TabIndex = 34
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(310, 432)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(110, 59)
        Me.lblChange.TabIndex = 35
        Me.lblChange.Text = "0.00"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1071, 548)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 46)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(941, 548)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 46)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save Only"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSavePrint
        '
        Me.btnSavePrint.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSavePrint.FlatAppearance.BorderSize = 0
        Me.btnSavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrint.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePrint.ForeColor = System.Drawing.Color.White
        Me.btnSavePrint.Location = New System.Drawing.Point(740, 548)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(195, 46)
        Me.btnSavePrint.TabIndex = 39
        Me.btnSavePrint.Text = "Save and Print"
        Me.btnSavePrint.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 29)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Envi Fee"
        '
        'txtEnvi
        '
        Me.txtEnvi.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvi.Location = New System.Drawing.Point(320, 225)
        Me.txtEnvi.Name = "txtEnvi"
        Me.txtEnvi.Size = New System.Drawing.Size(194, 31)
        Me.txtEnvi.TabIndex = 41
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(320, 262)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(194, 31)
        Me.txtDiscount.TabIndex = 43
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 259)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 29)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Discount"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(803, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(193, 29)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Period of Payment"
        '
        'cboMonthFrom
        '
        Me.cboMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthFrom.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthFrom.FormattingEnabled = True
        Me.cboMonthFrom.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonthFrom.Location = New System.Drawing.Point(1053, 157)
        Me.cboMonthFrom.Name = "cboMonthFrom"
        Me.cboMonthFrom.Size = New System.Drawing.Size(142, 31)
        Me.cboMonthFrom.TabIndex = 45
        '
        'cboYearFrom
        '
        Me.cboYearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearFrom.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearFrom.FormattingEnabled = True
        Me.cboYearFrom.Location = New System.Drawing.Point(947, 157)
        Me.cboYearFrom.Name = "cboYearFrom"
        Me.cboYearFrom.Size = New System.Drawing.Size(100, 31)
        Me.cboYearFrom.TabIndex = 46
        '
        'cboMonthTo
        '
        Me.cboMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthTo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthTo.FormattingEnabled = True
        Me.cboMonthTo.Items.AddRange(New Object() {"(None)", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonthTo.Location = New System.Drawing.Point(1053, 194)
        Me.cboMonthTo.Name = "cboMonthTo"
        Me.cboMonthTo.Size = New System.Drawing.Size(142, 31)
        Me.cboMonthTo.TabIndex = 47
        '
        'cboYearTo
        '
        Me.cboYearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearTo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearTo.FormattingEnabled = True
        Me.cboYearTo.Location = New System.Drawing.Point(947, 194)
        Me.cboYearTo.Name = "cboYearTo"
        Me.cboYearTo.Size = New System.Drawing.Size(100, 31)
        Me.cboYearTo.TabIndex = 48
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(899, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 19)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "From"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(916, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 19)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "To"
        '
        'tmr
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(803, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 29)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Payment Type"
        '
        'cboPType
        '
        Me.cboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPType.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPType.FormattingEnabled = True
        Me.cboPType.Items.AddRange(New Object() {"Cash", "Check", "Money Order"})
        Me.cboPType.Location = New System.Drawing.Point(960, 273)
        Me.cboPType.Name = "cboPType"
        Me.cboPType.Size = New System.Drawing.Size(235, 31)
        Me.cboPType.TabIndex = 52
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(803, 308)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(62, 29)
        Me.lblBank.TabIndex = 53
        Me.lblBank.Text = "Bank"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(803, 345)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(94, 29)
        Me.lblNum.TabIndex = 54
        Me.lblNum.Text = "Number"
        '
        'lblCheckDate
        '
        Me.lblCheckDate.AutoSize = True
        Me.lblCheckDate.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckDate.Location = New System.Drawing.Point(803, 385)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(60, 29)
        Me.lblCheckDate.TabIndex = 55
        Me.lblCheckDate.Text = "Date"
        '
        'txtBank
        '
        Me.txtBank.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBank.Location = New System.Drawing.Point(960, 310)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(235, 31)
        Me.txtBank.TabIndex = 56
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(960, 347)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(235, 31)
        Me.txtNum.TabIndex = 57
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(960, 385)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(235, 31)
        Me.dtpDate.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(169, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 15)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "(Discount Included)"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(319, 6)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(249, 31)
        Me.dtpPaymentDate.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 23)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Collector:"
        '
        'lblCollector
        '
        Me.lblCollector.AutoSize = True
        Me.lblCollector.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollector.Location = New System.Drawing.Point(102, 560)
        Me.lblCollector.Name = "lblCollector"
        Me.lblCollector.Size = New System.Drawing.Size(133, 23)
        Me.lblCollector.TabIndex = 62
        Me.lblCollector.Text = "Collector Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 509)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 29)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Balance"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(310, 486)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(110, 59)
        Me.lblBalance.TabIndex = 64
        Me.lblBalance.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(865, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 29)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Consumer Type:"
        '
        'lblConsType
        '
        Me.lblConsType.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsType.Location = New System.Drawing.Point(1042, 78)
        Me.lblConsType.Name = "lblConsType"
        Me.lblConsType.Size = New System.Drawing.Size(153, 29)
        Me.lblConsType.TabIndex = 66
        Me.lblConsType.Text = "SC/PWD"
        Me.lblConsType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPenalty
        '
        Me.txtPenalty.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.Location = New System.Drawing.Point(320, 299)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(194, 31)
        Me.txtPenalty.TabIndex = 68
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 296)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 29)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Penalty"
        '
        'lblRemEnvi
        '
        Me.lblRemEnvi.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemEnvi.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemEnvi.Location = New System.Drawing.Point(191, 228)
        Me.lblRemEnvi.Name = "lblRemEnvi"
        Me.lblRemEnvi.Size = New System.Drawing.Size(123, 23)
        Me.lblRemEnvi.TabIndex = 69
        Me.lblRemEnvi.Text = "0.0"
        Me.lblRemEnvi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRemDisc
        '
        Me.lblRemDisc.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemDisc.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemDisc.Location = New System.Drawing.Point(191, 265)
        Me.lblRemDisc.Name = "lblRemDisc"
        Me.lblRemDisc.Size = New System.Drawing.Size(123, 23)
        Me.lblRemDisc.TabIndex = 70
        Me.lblRemDisc.Text = "0.0"
        Me.lblRemDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRemPenalty
        '
        Me.lblRemPenalty.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemPenalty.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemPenalty.Location = New System.Drawing.Point(191, 302)
        Me.lblRemPenalty.Name = "lblRemPenalty"
        Me.lblRemPenalty.Size = New System.Drawing.Size(123, 23)
        Me.lblRemPenalty.TabIndex = 71
        Me.lblRemPenalty.Text = "0.0"
        Me.lblRemPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(520, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 26)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Remaining Balance"
        '
        'lblRemainingAmount
        '
        Me.lblRemainingAmount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemainingAmount.Location = New System.Drawing.Point(546, 191)
        Me.lblRemainingAmount.Name = "lblRemainingAmount"
        Me.lblRemainingAmount.Size = New System.Drawing.Size(123, 23)
        Me.lblRemainingAmount.TabIndex = 73
        Me.lblRemainingAmount.Text = "0.0"
        Me.lblRemainingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemainingEnvi
        '
        Me.lblRemainingEnvi.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingEnvi.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemainingEnvi.Location = New System.Drawing.Point(546, 228)
        Me.lblRemainingEnvi.Name = "lblRemainingEnvi"
        Me.lblRemainingEnvi.Size = New System.Drawing.Size(123, 23)
        Me.lblRemainingEnvi.TabIndex = 74
        Me.lblRemainingEnvi.Text = "0.0"
        Me.lblRemainingEnvi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemainingDiscount
        '
        Me.lblRemainingDiscount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemainingDiscount.Location = New System.Drawing.Point(546, 264)
        Me.lblRemainingDiscount.Name = "lblRemainingDiscount"
        Me.lblRemainingDiscount.Size = New System.Drawing.Size(123, 23)
        Me.lblRemainingDiscount.TabIndex = 75
        Me.lblRemainingDiscount.Text = "0.0"
        Me.lblRemainingDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemainingPenalty
        '
        Me.lblRemainingPenalty.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingPenalty.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemainingPenalty.Location = New System.Drawing.Point(546, 302)
        Me.lblRemainingPenalty.Name = "lblRemainingPenalty"
        Me.lblRemainingPenalty.Size = New System.Drawing.Size(123, 23)
        Me.lblRemainingPenalty.TabIndex = 76
        Me.lblRemainingPenalty.Text = "0.0"
        Me.lblRemainingPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemainingInstall
        '
        Me.lblRemainingInstall.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingInstall.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemainingInstall.Location = New System.Drawing.Point(546, 339)
        Me.lblRemainingInstall.Name = "lblRemainingInstall"
        Me.lblRemainingInstall.Size = New System.Drawing.Size(123, 23)
        Me.lblRemainingInstall.TabIndex = 80
        Me.lblRemainingInstall.Text = "0.0"
        Me.lblRemainingInstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemInstall
        '
        Me.lblRemInstall.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemInstall.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRemInstall.Location = New System.Drawing.Point(191, 339)
        Me.lblRemInstall.Name = "lblRemInstall"
        Me.lblRemInstall.Size = New System.Drawing.Size(123, 23)
        Me.lblRemInstall.TabIndex = 79
        Me.lblRemInstall.Text = "0.0"
        Me.lblRemInstall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInstallment
        '
        Me.txtInstallment.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallment.Location = New System.Drawing.Point(320, 336)
        Me.txtInstallment.Name = "txtInstallment"
        Me.txtInstallment.Size = New System.Drawing.Size(194, 31)
        Me.txtInstallment.TabIndex = 78
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 333)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(165, 29)
        Me.Label24.TabIndex = 77
        Me.Label24.Text = "Installment Fee"
        '
        'WaterBillOutstandingPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 606)
        Me.Controls.Add(Me.lblRemainingInstall)
        Me.Controls.Add(Me.lblRemInstall)
        Me.Controls.Add(Me.txtInstallment)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblRemainingPenalty)
        Me.Controls.Add(Me.lblRemainingDiscount)
        Me.Controls.Add(Me.lblRemainingEnvi)
        Me.Controls.Add(Me.lblRemainingAmount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblRemPenalty)
        Me.Controls.Add(Me.lblRemDisc)
        Me.Controls.Add(Me.lblRemEnvi)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblConsType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCollector)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.lblCheckDate)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.cboPType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboYearTo)
        Me.Controls.Add(Me.cboMonthTo)
        Me.Controls.Add(Me.cboYearFrom)
        Me.Controls.Add(Me.cboMonthFrom)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtEnvi)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnSavePrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmtPayment)
        Me.Controls.Add(Me.lblTotalPrevious)
        Me.Controls.Add(Me.lblBillNo)
        Me.Controls.Add(Me.lblOR)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WaterBillOutstandingPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment for Previous Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblOR As Label
    Friend WithEvents lblBillNo As Label
    Friend WithEvents lblTotalPrevious As Label
    Friend WithEvents txtAmtPayment As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSavePrint As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEnvi As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboMonthFrom As ComboBox
    Friend WithEvents cboYearFrom As ComboBox
    Friend WithEvents cboMonthTo As ComboBox
    Friend WithEvents cboYearTo As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tmr As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents cboPType As ComboBox
    Friend WithEvents lblBank As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblCheckDate As Label
    Friend WithEvents txtBank As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCollector As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblConsType As Label
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblRemEnvi As Label
    Friend WithEvents lblRemDisc As Label
    Friend WithEvents lblRemPenalty As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblRemainingAmount As Label
    Friend WithEvents lblRemainingEnvi As Label
    Friend WithEvents lblRemainingDiscount As Label
    Friend WithEvents lblRemainingPenalty As Label
    Friend WithEvents lblRemainingInstall As Label
    Friend WithEvents lblRemInstall As Label
    Friend WithEvents txtInstallment As TextBox
    Friend WithEvents Label24 As Label
End Class
