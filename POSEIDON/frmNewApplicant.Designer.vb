<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewApplicant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewApplicant))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOwnOther = New System.Windows.Forms.TextBox()
        Me.rdOwn3 = New System.Windows.Forms.RadioButton()
        Me.rdOwn2 = New System.Windows.Forms.RadioButton()
        Me.rdOwn1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdServ4 = New System.Windows.Forms.RadioButton()
        Me.rdServ3 = New System.Windows.Forms.RadioButton()
        Me.rdServ2 = New System.Windows.Forms.RadioButton()
        Me.rdServ1 = New System.Windows.Forms.RadioButton()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdCons4 = New System.Windows.Forms.RadioButton()
        Me.rdCons3 = New System.Windows.Forms.RadioButton()
        Me.rdCons2 = New System.Windows.Forms.RadioButton()
        Me.rdCons1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblRepName = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpAppDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMidName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAccountCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtORNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(153, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(271, 26)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Municipality"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Barangay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Province"
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(153, 146)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(271, 26)
        Me.cboProv.TabIndex = 5
        '
        'cboMun
        '
        Me.cboMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMun.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(153, 178)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(271, 26)
        Me.cboMun.TabIndex = 6
        '
        'cboBrgy
        '
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(153, 210)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(271, 26)
        Me.cboBrgy.TabIndex = 7
        '
        'txtCon
        '
        Me.txtCon.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCon.Location = New System.Drawing.Point(153, 242)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(271, 26)
        Me.txtCon.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contact No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOwnOther)
        Me.GroupBox1.Controls.Add(Me.rdOwn3)
        Me.GroupBox1.Controls.Add(Me.rdOwn2)
        Me.GroupBox1.Controls.Add(Me.rdOwn1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 117)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ownership"
        '
        'txtOwnOther
        '
        Me.txtOwnOther.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwnOther.Location = New System.Drawing.Point(113, 80)
        Me.txtOwnOther.Name = "txtOwnOther"
        Me.txtOwnOther.Size = New System.Drawing.Size(271, 26)
        Me.txtOwnOther.TabIndex = 12
        '
        'rdOwn3
        '
        Me.rdOwn3.AutoSize = True
        Me.rdOwn3.Location = New System.Drawing.Point(6, 81)
        Me.rdOwn3.Name = "rdOwn3"
        Me.rdOwn3.Size = New System.Drawing.Size(68, 22)
        Me.rdOwn3.TabIndex = 11
        Me.rdOwn3.Text = "Others"
        Me.rdOwn3.UseVisualStyleBackColor = True
        '
        'rdOwn2
        '
        Me.rdOwn2.AutoSize = True
        Me.rdOwn2.Location = New System.Drawing.Point(6, 53)
        Me.rdOwn2.Name = "rdOwn2"
        Me.rdOwn2.Size = New System.Drawing.Size(116, 22)
        Me.rdOwn2.TabIndex = 10
        Me.rdOwn2.Text = "Tenant/Border"
        Me.rdOwn2.UseVisualStyleBackColor = True
        '
        'rdOwn1
        '
        Me.rdOwn1.AutoSize = True
        Me.rdOwn1.Checked = True
        Me.rdOwn1.Location = New System.Drawing.Point(6, 25)
        Me.rdOwn1.Name = "rdOwn1"
        Me.rdOwn1.Size = New System.Drawing.Size(110, 22)
        Me.rdOwn1.TabIndex = 9
        Me.rdOwn1.TabStop = True
        Me.rdOwn1.Text = "House Owner"
        Me.rdOwn1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdServ4)
        Me.GroupBox2.Controls.Add(Me.rdServ3)
        Me.GroupBox2.Controls.Add(Me.rdServ2)
        Me.GroupBox2.Controls.Add(Me.rdServ1)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 397)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 140)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Water Service Applied"
        '
        'rdServ4
        '
        Me.rdServ4.AutoSize = True
        Me.rdServ4.Location = New System.Drawing.Point(6, 109)
        Me.rdServ4.Name = "rdServ4"
        Me.rdServ4.Size = New System.Drawing.Size(163, 22)
        Me.rdServ4.TabIndex = 16
        Me.rdServ4.Text = "Transfer of Ownership"
        Me.rdServ4.UseVisualStyleBackColor = True
        '
        'rdServ3
        '
        Me.rdServ3.AutoSize = True
        Me.rdServ3.Location = New System.Drawing.Point(6, 81)
        Me.rdServ3.Name = "rdServ3"
        Me.rdServ3.Size = New System.Drawing.Size(110, 22)
        Me.rdServ3.TabIndex = 15
        Me.rdServ3.Text = "Reconnection"
        Me.rdServ3.UseVisualStyleBackColor = True
        '
        'rdServ2
        '
        Me.rdServ2.AutoSize = True
        Me.rdServ2.Location = New System.Drawing.Point(6, 53)
        Me.rdServ2.Name = "rdServ2"
        Me.rdServ2.Size = New System.Drawing.Size(173, 22)
        Me.rdServ2.TabIndex = 14
        Me.rdServ2.Text = "Transfer of Water Meter"
        Me.rdServ2.UseVisualStyleBackColor = True
        '
        'rdServ1
        '
        Me.rdServ1.AutoSize = True
        Me.rdServ1.Checked = True
        Me.rdServ1.Location = New System.Drawing.Point(6, 25)
        Me.rdServ1.Name = "rdServ1"
        Me.rdServ1.Size = New System.Drawing.Size(222, 22)
        Me.rdServ1.TabIndex = 13
        Me.rdServ1.TabStop = True
        Me.rdServ1.Text = "Application for New Connection"
        Me.rdServ1.UseVisualStyleBackColor = True
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(577, 141)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(266, 26)
        Me.txtAmountPaid.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Amount Paid"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(451, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Date of Payment"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(577, 174)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(266, 26)
        Me.dtpPaymentDate.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(451, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Amount of Charges or Fees"
        '
        'lblAmount
        '
        Me.lblAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAmount.Location = New System.Drawing.Point(669, 82)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(174, 18)
        Me.lblAmount.TabIndex = 19
        Me.lblAmount.Text = "0.00"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdCons4)
        Me.GroupBox3.Controls.Add(Me.rdCons3)
        Me.GroupBox3.Controls.Add(Me.rdCons2)
        Me.GroupBox3.Controls.Add(Me.rdCons1)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(447, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 143)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Classification"
        '
        'rdCons4
        '
        Me.rdCons4.AutoSize = True
        Me.rdCons4.Location = New System.Drawing.Point(6, 109)
        Me.rdCons4.Name = "rdCons4"
        Me.rdCons4.Size = New System.Drawing.Size(321, 22)
        Me.rdCons4.TabIndex = 27
        Me.rdCons4.Text = "Water traders/Bulk sales domestic Consumption"
        Me.rdCons4.UseVisualStyleBackColor = True
        '
        'rdCons3
        '
        Me.rdCons3.AutoSize = True
        Me.rdCons3.Location = New System.Drawing.Point(6, 81)
        Me.rdCons3.Name = "rdCons3"
        Me.rdCons3.Size = New System.Drawing.Size(170, 22)
        Me.rdCons3.TabIndex = 26
        Me.rdCons3.Text = "Industrial Consumption"
        Me.rdCons3.UseVisualStyleBackColor = True
        '
        'rdCons2
        '
        Me.rdCons2.AutoSize = True
        Me.rdCons2.Location = New System.Drawing.Point(6, 53)
        Me.rdCons2.Name = "rdCons2"
        Me.rdCons2.Size = New System.Drawing.Size(185, 22)
        Me.rdCons2.TabIndex = 25
        Me.rdCons2.Text = "Commercial Consumption"
        Me.rdCons2.UseVisualStyleBackColor = True
        '
        'rdCons1
        '
        Me.rdCons1.AutoSize = True
        Me.rdCons1.Checked = True
        Me.rdCons1.Location = New System.Drawing.Point(6, 25)
        Me.rdCons1.Name = "rdCons1"
        Me.rdCons1.Size = New System.Drawing.Size(333, 22)
        Me.rdCons1.TabIndex = 24
        Me.rdCons1.TabStop = True
        Me.rdCons1.Text = "Residential/Institution/Government Consumption"
        Me.rdCons1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(559, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "NWSS Office Representative"
        '
        'lblRepName
        '
        Me.lblRepName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepName.Location = New System.Drawing.Point(499, 422)
        Me.lblRepName.Name = "lblRepName"
        Me.lblRepName.Size = New System.Drawing.Size(304, 18)
        Me.lblRepName.TabIndex = 22
        Me.lblRepName.Text = "Full Name"
        Me.lblRepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(856, 565)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 513
        Me.LineShape1.X2 = 784
        Me.LineShape1.Y1 = 444
        Me.LineShape1.Y2 = 444
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(645, 501)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(96, 35)
        Me.btnDone.TabIndex = 28
        Me.btnDone.Text = "OK"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(747, 502)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 35)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(451, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Date of Application"
        '
        'dtpAppDate
        '
        Me.dtpAppDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAppDate.Location = New System.Drawing.Point(577, 47)
        Me.dtpAppDate.Name = "dtpAppDate"
        Me.dtpAppDate.Size = New System.Drawing.Size(266, 26)
        Me.dtpAppDate.TabIndex = 20
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(153, 108)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(271, 26)
        Me.txtAddress.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Address"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Middle Name"
        '
        'txtMidName
        '
        Me.txtMidName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMidName.Location = New System.Drawing.Point(153, 44)
        Me.txtMidName.Name = "txtMidName"
        Me.txtMidName.Size = New System.Drawing.Size(271, 26)
        Me.txtMidName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(153, 76)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(271, 26)
        Me.txtLastName.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Last Name"
        '
        'txtAccountCode
        '
        Me.txtAccountCode.BackColor = System.Drawing.Color.White
        Me.txtAccountCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountCode.Location = New System.Drawing.Point(577, 12)
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.ReadOnly = True
        Me.txtAccountCode.Size = New System.Drawing.Size(266, 26)
        Me.txtAccountCode.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(450, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Accounting Code"
        '
        'txtORNum
        '
        Me.txtORNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNum.Location = New System.Drawing.Point(577, 109)
        Me.txtORNum.Name = "txtORNum"
        Me.txtORNum.Size = New System.Drawing.Size(266, 26)
        Me.txtORNum.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "O.R. Number"
        '
        'frmNewApplicant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 565)
        Me.Controls.Add(Me.txtORNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAccountCode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMidName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpAppDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblRepName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboBrgy)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.cboProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewApplicant"
        Me.Text = "Application Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents cboMun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrgy As System.Windows.Forms.ComboBox
    Friend WithEvents txtCon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOwnOther As System.Windows.Forms.TextBox
    Friend WithEvents rdOwn3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdOwn2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdOwn1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdServ4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdServ3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdServ2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdServ1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCons4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdCons3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdCons2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdCons1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblRepName As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpAppDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMidName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtORNum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
