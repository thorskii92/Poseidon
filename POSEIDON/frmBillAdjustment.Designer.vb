<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillAdjustment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMemoNum = New System.Windows.Forms.Label()
        Me.lblConsName = New System.Windows.Forms.Label()
        Me.lblAccNum = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.lblBillNum = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIncDec = New System.Windows.Forms.Label()
        Me.lblBillAmount = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPrepared = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSurcharge = New System.Windows.Forms.Label()
        Me.lblDueAmount = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPrevMonthBalance = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtConsumption = New System.Windows.Forms.TextBox()
        Me.lblEnvi = New System.Windows.Forms.Label()
        Me.lblNewAmount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.pbxDec = New System.Windows.Forms.PictureBox()
        Me.pbxIncDec = New System.Windows.Forms.PictureBox()
        CType(Me.pbxDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIncDec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Adjustment Form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Consumption Adjustment)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Req No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Consumer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Account No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Reason:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(462, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bill No.:"
        '
        'lblMemoNum
        '
        Me.lblMemoNum.AutoSize = True
        Me.lblMemoNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoNum.Location = New System.Drawing.Point(122, 64)
        Me.lblMemoNum.Name = "lblMemoNum"
        Me.lblMemoNum.Size = New System.Drawing.Size(121, 19)
        Me.lblMemoNum.TabIndex = 7
        Me.lblMemoNum.Text = "MEMO NUMBER"
        '
        'lblConsName
        '
        Me.lblConsName.AutoSize = True
        Me.lblConsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsName.Location = New System.Drawing.Point(122, 102)
        Me.lblConsName.Name = "lblConsName"
        Me.lblConsName.Size = New System.Drawing.Size(135, 19)
        Me.lblConsName.TabIndex = 8
        Me.lblConsName.Text = "CONSUMER NAME"
        '
        'lblAccNum
        '
        Me.lblAccNum.AutoSize = True
        Me.lblAccNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNum.Location = New System.Drawing.Point(122, 142)
        Me.lblAccNum.Name = "lblAccNum"
        Me.lblAccNum.Size = New System.Drawing.Size(101, 19)
        Me.lblAccNum.TabIndex = 9
        Me.lblAccNum.Text = "ACCOUNT NO"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(126, 184)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(516, 48)
        Me.txtReason.TabIndex = 10
        '
        'lblBillNum
        '
        Me.lblBillNum.AutoSize = True
        Me.lblBillNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNum.Location = New System.Drawing.Point(513, 105)
        Me.lblBillNum.Name = "lblBillNum"
        Me.lblBillNum.Size = New System.Drawing.Size(62, 19)
        Me.lblBillNum.TabIndex = 11
        Me.lblBillNum.Text = "BILL NO"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(513, 64)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 19)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(294, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "CONSUMPTION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "AS BILLED"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(247, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "SHOULD BE"
        '
        'lblIncDec
        '
        Me.lblIncDec.AutoSize = True
        Me.lblIncDec.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncDec.Location = New System.Drawing.Point(465, 285)
        Me.lblIncDec.Name = "lblIncDec"
        Me.lblIncDec.Size = New System.Drawing.Size(151, 19)
        Me.lblIncDec.TabIndex = 16
        Me.lblIncDec.Text = "INCREASE/DECREASE"
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmount.Location = New System.Drawing.Point(17, 323)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(68, 19)
        Me.lblBillAmount.TabIndex = 17
        Me.lblBillAmount.Text = "Php 0.00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(507, 304)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(68, 19)
        Me.lblChange.TabIndex = 19
        Me.lblChange.Text = "Php 0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 19)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Prepared By:"
        '
        'lblPrepared
        '
        Me.lblPrepared.AutoSize = True
        Me.lblPrepared.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrepared.Location = New System.Drawing.Point(61, 465)
        Me.lblPrepared.Name = "lblPrepared"
        Me.lblPrepared.Size = New System.Drawing.Size(115, 19)
        Me.lblPrepared.TabIndex = 22
        Me.lblPrepared.Text = "Preparee Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(537, 462)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 33)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(426, 462)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(105, 33)
        Me.btnDone.TabIndex = 25
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(247, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "SURCHARGE AMOUNT"
        '
        'lblSurcharge
        '
        Me.lblSurcharge.AutoSize = True
        Me.lblSurcharge.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurcharge.Location = New System.Drawing.Point(247, 361)
        Me.lblSurcharge.Name = "lblSurcharge"
        Me.lblSurcharge.Size = New System.Drawing.Size(68, 19)
        Me.lblSurcharge.TabIndex = 29
        Me.lblSurcharge.Text = "Php 0.00"
        '
        'lblDueAmount
        '
        Me.lblDueAmount.AutoSize = True
        Me.lblDueAmount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueAmount.Location = New System.Drawing.Point(247, 399)
        Me.lblDueAmount.Name = "lblDueAmount"
        Me.lblDueAmount.Size = New System.Drawing.Size(68, 19)
        Me.lblDueAmount.TabIndex = 31
        Me.lblDueAmount.Text = "Php 0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(247, 380)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 19)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "TOTAL DUE AMOUNT"
        '
        'lblPrevMonthBalance
        '
        Me.lblPrevMonthBalance.AutoSize = True
        Me.lblPrevMonthBalance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevMonthBalance.Location = New System.Drawing.Point(17, 361)
        Me.lblPrevMonthBalance.Name = "lblPrevMonthBalance"
        Me.lblPrevMonthBalance.Size = New System.Drawing.Size(68, 19)
        Me.lblPrevMonthBalance.TabIndex = 33
        Me.lblPrevMonthBalance.Text = "Php 0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(202, 19)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "PREVIOUS MONTH BALANCE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(465, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 19)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Environmental Fee"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(465, 339)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 19)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Consumption"
        '
        'txtConsumption
        '
        Me.txtConsumption.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsumption.Location = New System.Drawing.Point(469, 359)
        Me.txtConsumption.Name = "txtConsumption"
        Me.txtConsumption.Size = New System.Drawing.Size(171, 26)
        Me.txtConsumption.TabIndex = 37
        '
        'lblEnvi
        '
        Me.lblEnvi.AutoSize = True
        Me.lblEnvi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnvi.Location = New System.Drawing.Point(465, 407)
        Me.lblEnvi.Name = "lblEnvi"
        Me.lblEnvi.Size = New System.Drawing.Size(68, 19)
        Me.lblEnvi.TabIndex = 38
        Me.lblEnvi.Text = "Php 0.00"
        '
        'lblNewAmount
        '
        Me.lblNewAmount.AutoSize = True
        Me.lblNewAmount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewAmount.Location = New System.Drawing.Point(247, 304)
        Me.lblNewAmount.Name = "lblNewAmount"
        Me.lblNewAmount.Size = New System.Drawing.Size(68, 19)
        Me.lblNewAmount.TabIndex = 38
        Me.lblNewAmount.Text = "Php 0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(407, 142)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 19)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Classification:"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(513, 142)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(96, 19)
        Me.lblClass.TabIndex = 40
        Me.lblClass.Text = "Classification"
        '
        'pbxDec
        '
        Me.pbxDec.BackgroundImage = Global.POSEIDON.My.Resources.Resources.downarr
        Me.pbxDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDec.Location = New System.Drawing.Point(622, 285)
        Me.pbxDec.Name = "pbxDec"
        Me.pbxDec.Size = New System.Drawing.Size(20, 20)
        Me.pbxDec.TabIndex = 27
        Me.pbxDec.TabStop = False
        '
        'pbxIncDec
        '
        Me.pbxIncDec.BackgroundImage = Global.POSEIDON.My.Resources.Resources.uparr
        Me.pbxIncDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxIncDec.Location = New System.Drawing.Point(622, 284)
        Me.pbxIncDec.Name = "pbxIncDec"
        Me.pbxIncDec.Size = New System.Drawing.Size(20, 20)
        Me.pbxIncDec.TabIndex = 26
        Me.pbxIncDec.TabStop = False
        '
        'frmBillAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 516)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblNewAmount)
        Me.Controls.Add(Me.lblEnvi)
        Me.Controls.Add(Me.txtConsumption)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblPrevMonthBalance)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblDueAmount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblSurcharge)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pbxDec)
        Me.Controls.Add(Me.pbxIncDec)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblPrepared)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblBillAmount)
        Me.Controls.Add(Me.lblIncDec)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblBillNum)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.lblAccNum)
        Me.Controls.Add(Me.lblConsName)
        Me.Controls.Add(Me.lblMemoNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBillAdjustment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Bill Adjustment"
        CType(Me.pbxDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxIncDec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMemoNum As System.Windows.Forms.Label
    Friend WithEvents lblConsName As System.Windows.Forms.Label
    Friend WithEvents lblAccNum As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents lblBillNum As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblIncDec As System.Windows.Forms.Label
    Friend WithEvents lblBillAmount As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPrepared As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents pbxIncDec As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDec As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSurcharge As System.Windows.Forms.Label
    Friend WithEvents lblDueAmount As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblPrevMonthBalance As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtConsumption As System.Windows.Forms.TextBox
    Friend WithEvents lblEnvi As System.Windows.Forms.Label
    Friend WithEvents lblNewAmount As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
End Class
