<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentCollection))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnBrowseMember = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lvwCollection = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtORNum = New System.Windows.Forms.TextBox()
        Me.lblAmountInWords = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDateP = New System.Windows.Forms.DateTimePicker()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtDBank = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCollectingOfficer = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnAddPayment = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(27, 27)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(398, 27)
        Me.lblName.TabIndex = 1
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddCustomer.FlatAppearance.BorderSize = 0
        Me.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomer.Location = New System.Drawing.Point(473, 22)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(36, 32)
        Me.btnAddCustomer.TabIndex = 2
        Me.btnAddCustomer.Text = "+"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'btnBrowseMember
        '
        Me.btnBrowseMember.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBrowseMember.FlatAppearance.BorderSize = 0
        Me.btnBrowseMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseMember.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseMember.ForeColor = System.Drawing.Color.White
        Me.btnBrowseMember.Location = New System.Drawing.Point(431, 22)
        Me.btnBrowseMember.Name = "btnBrowseMember"
        Me.btnBrowseMember.Size = New System.Drawing.Size(36, 32)
        Me.btnBrowseMember.TabIndex = 3
        Me.btnBrowseMember.Text = "..."
        Me.btnBrowseMember.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1333, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(1336, 27)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(199, 27)
        Me.dtpDate.TabIndex = 5
        '
        'lvwCollection
        '
        Me.lvwCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwCollection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCollection.FullRowSelect = True
        Me.lvwCollection.GridLines = True
        Me.lvwCollection.HideSelection = False
        Me.lvwCollection.Location = New System.Drawing.Point(27, 110)
        Me.lvwCollection.MultiSelect = False
        Me.lvwCollection.Name = "lvwCollection"
        Me.lvwCollection.Size = New System.Drawing.Size(1508, 415)
        Me.lvwCollection.TabIndex = 6
        Me.lvwCollection.UseCompatibleStateImageBehavior = False
        Me.lvwCollection.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nature of Collection"
        Me.ColumnHeader1.Width = 378
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Account Code"
        Me.ColumnHeader2.Width = 171
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amount"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Payment Type"
        Me.ColumnHeader4.Width = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 528)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(580, 528)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(146, 18)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Php 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1333, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "O.R. No."
        '
        'txtORNum
        '
        Me.txtORNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtORNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNum.Location = New System.Drawing.Point(1336, 78)
        Me.txtORNum.Name = "txtORNum"
        Me.txtORNum.Size = New System.Drawing.Size(199, 27)
        Me.txtORNum.TabIndex = 10
        '
        'lblAmountInWords
        '
        Me.lblAmountInWords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAmountInWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountInWords.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountInWords.Location = New System.Drawing.Point(24, 546)
        Me.lblAmountInWords.Name = "lblAmountInWords"
        Me.lblAmountInWords.Size = New System.Drawing.Size(702, 27)
        Me.lblAmountInWords.TabIndex = 11
        Me.lblAmountInWords.Text = "Amount in Words"
        Me.lblAmountInWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Amount in Words"
        '
        'cboPayment
        '
        Me.cboPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Items.AddRange(New Object() {"Cash", "Check", "Money Order"})
        Me.cboPayment.Location = New System.Drawing.Point(146, 598)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(206, 26)
        Me.cboPayment.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 601)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Type of Payment"
        '
        'lblNum
        '
        Me.lblNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(355, 577)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(59, 18)
        Me.lblNum.TabIndex = 15
        Me.lblNum.Text = "Number"
        '
        'txtNum
        '
        Me.txtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(358, 598)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(125, 26)
        Me.txtNum.TabIndex = 16
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(486, 577)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 18)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Date"
        '
        'dtpDateP
        '
        Me.dtpDateP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpDateP.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateP.Location = New System.Drawing.Point(489, 597)
        Me.dtpDateP.Name = "dtpDateP"
        Me.dtpDateP.Size = New System.Drawing.Size(110, 27)
        Me.dtpDateP.TabIndex = 18
        '
        'lblBank
        '
        Me.lblBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(602, 577)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(89, 18)
        Me.lblBank.TabIndex = 19
        Me.lblBank.Text = "Drawee Bank"
        '
        'txtDBank
        '
        Me.txtDBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDBank.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBank.Location = New System.Drawing.Point(605, 598)
        Me.txtDBank.Name = "txtDBank"
        Me.txtDBank.Size = New System.Drawing.Size(121, 26)
        Me.txtDBank.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 632)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Collecting Officer"
        '
        'lblCollectingOfficer
        '
        Me.lblCollectingOfficer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCollectingOfficer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCollectingOfficer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollectingOfficer.Location = New System.Drawing.Point(146, 627)
        Me.lblCollectingOfficer.Name = "lblCollectingOfficer"
        Me.lblCollectingOfficer.Size = New System.Drawing.Size(580, 27)
        Me.lblCollectingOfficer.TabIndex = 22
        Me.lblCollectingOfficer.Text = "Name"
        Me.lblCollectingOfficer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 668)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Position"
        '
        'lblPosition
        '
        Me.lblPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPosition.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(146, 663)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(580, 27)
        Me.lblPosition.TabIndex = 24
        Me.lblPosition.Text = "Position"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1430, 658)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 32)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(1430, 620)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(105, 32)
        Me.btnDone.TabIndex = 26
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnAddPayment
        '
        Me.btnAddPayment.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddPayment.FlatAppearance.BorderSize = 0
        Me.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPayment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPayment.ForeColor = System.Drawing.Color.White
        Me.btnAddPayment.Location = New System.Drawing.Point(27, 78)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(132, 27)
        Me.btnAddPayment.TabIndex = 27
        Me.btnAddPayment.Text = "Add Payment"
        Me.btnAddPayment.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(165, 78)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(132, 27)
        Me.btnRemove.TabIndex = 28
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'cID
        '
        Me.cID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cID.Location = New System.Drawing.Point(306, 9)
        Me.cID.Name = "cID"
        Me.cID.Size = New System.Drawing.Size(119, 18)
        Me.cID.TabIndex = 29
        Me.cID.Text = "00000"
        Me.cID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(757, 528)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cash Amount"
        '
        'txtCash
        '
        Me.txtCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCash.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(760, 546)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(394, 53)
        Me.txtCash.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(757, 601)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Change"
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(766, 620)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(121, 45)
        Me.lblChange.TabIndex = 33
        Me.lblChange.Text = "Label9"
        '
        'frmPaymentCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cID)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddPayment)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblCollectingOfficer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDBank)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.dtpDateP)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboPayment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAmountInWords)
        Me.Controls.Add(Me.txtORNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvwCollection)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBrowseMember)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPaymentCollection"
        Me.Text = "0.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents btnBrowseMember As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvwCollection As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtORNum As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAmountInWords As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDateP As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtDBank As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCollectingOfficer As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnAddPayment As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents cID As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblChange As Label
End Class
