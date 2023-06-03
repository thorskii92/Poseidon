<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountLedger))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAccountUpdate = New System.Windows.Forms.Button()
        Me.btnPrevChange = New System.Windows.Forms.Button()
        Me.lblPrevBal = New System.Windows.Forms.Label()
        Me.lblLabelPrev = New System.Windows.Forms.Label()
        Me.btnUpdateMeter = New System.Windows.Forms.Button()
        Me.lblCurRead = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblCluster = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblConDate = New System.Windows.Forms.Label()
        Me.lblMetBrand = New System.Windows.Forms.Label()
        Me.lblMetSize = New System.Windows.Forms.Label()
        Me.lblMetNum = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lvwLedger = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBillStatement = New System.Windows.Forms.ToolStripButton()
        Me.btnEditBill = New System.Windows.Forms.ToolStripButton()
        Me.btnDelBill = New System.Windows.Forms.ToolStripButton()
        Me.btnEditOR = New System.Windows.Forms.ToolStripButton()
        Me.btnEditOutstanding = New System.Windows.Forms.ToolStripButton()
        Me.btnUnpaid = New System.Windows.Forms.ToolStripButton()
        Me.btnViewOR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnSOA = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblStat)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblAccountName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btnAccountUpdate)
        Me.Panel1.Controls.Add(Me.btnPrevChange)
        Me.Panel1.Controls.Add(Me.lblPrevBal)
        Me.Panel1.Controls.Add(Me.lblLabelPrev)
        Me.Panel1.Controls.Add(Me.btnUpdateMeter)
        Me.Panel1.Controls.Add(Me.lblCurRead)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.lblCluster)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lblConDate)
        Me.Panel1.Controls.Add(Me.lblMetBrand)
        Me.Panel1.Controls.Add(Me.lblMetSize)
        Me.Panel1.Controls.Add(Me.lblMetNum)
        Me.Panel1.Controls.Add(Me.lblClass)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblZone)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblAccount)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 766)
        Me.Panel1.TabIndex = 0
        '
        'lblStat
        '
        Me.lblStat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStat.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat.ForeColor = System.Drawing.Color.Black
        Me.lblStat.Location = New System.Drawing.Point(113, 7)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(171, 18)
        Me.lblStat.TabIndex = 27
        Me.lblStat.Text = "Account Status"
        Me.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(8, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Account Status"
        '
        'lblAccountName
        '
        Me.lblAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(4, 129)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(280, 25)
        Me.lblAccountName.TabIndex = 25
        Me.lblAccountName.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Account Name"
        '
        'btnAccountUpdate
        '
        Me.btnAccountUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAccountUpdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAccountUpdate.FlatAppearance.BorderSize = 0
        Me.btnAccountUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountUpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountUpdate.ForeColor = System.Drawing.Color.White
        Me.btnAccountUpdate.Location = New System.Drawing.Point(12, 727)
        Me.btnAccountUpdate.Name = "btnAccountUpdate"
        Me.btnAccountUpdate.Size = New System.Drawing.Size(272, 27)
        Me.btnAccountUpdate.TabIndex = 23
        Me.btnAccountUpdate.Text = "Update Account Details"
        Me.btnAccountUpdate.UseVisualStyleBackColor = False
        '
        'btnPrevChange
        '
        Me.btnPrevChange.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrevChange.FlatAppearance.BorderSize = 0
        Me.btnPrevChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevChange.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevChange.ForeColor = System.Drawing.Color.White
        Me.btnPrevChange.Location = New System.Drawing.Point(87, 649)
        Me.btnPrevChange.Name = "btnPrevChange"
        Me.btnPrevChange.Size = New System.Drawing.Size(119, 27)
        Me.btnPrevChange.TabIndex = 22
        Me.btnPrevChange.Text = "Change"
        Me.btnPrevChange.UseVisualStyleBackColor = False
        Me.btnPrevChange.Visible = False
        '
        'lblPrevBal
        '
        Me.lblPrevBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrevBal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevBal.Location = New System.Drawing.Point(4, 621)
        Me.lblPrevBal.Name = "lblPrevBal"
        Me.lblPrevBal.Size = New System.Drawing.Size(280, 25)
        Me.lblPrevBal.TabIndex = 21
        Me.lblPrevBal.Text = "0.00"
        Me.lblPrevBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrevBal.Visible = False
        '
        'lblLabelPrev
        '
        Me.lblLabelPrev.AutoSize = True
        Me.lblLabelPrev.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelPrev.Location = New System.Drawing.Point(12, 603)
        Me.lblLabelPrev.Name = "lblLabelPrev"
        Me.lblLabelPrev.Size = New System.Drawing.Size(192, 18)
        Me.lblLabelPrev.TabIndex = 20
        Me.lblLabelPrev.Text = "Previous Outstanding Balance"
        Me.lblLabelPrev.Visible = False
        '
        'btnUpdateMeter
        '
        Me.btnUpdateMeter.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdateMeter.FlatAppearance.BorderSize = 0
        Me.btnUpdateMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateMeter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateMeter.ForeColor = System.Drawing.Color.White
        Me.btnUpdateMeter.Location = New System.Drawing.Point(4, 543)
        Me.btnUpdateMeter.Name = "btnUpdateMeter"
        Me.btnUpdateMeter.Size = New System.Drawing.Size(119, 46)
        Me.btnUpdateMeter.TabIndex = 19
        Me.btnUpdateMeter.Text = "Update Meter Details"
        Me.btnUpdateMeter.UseVisualStyleBackColor = False
        '
        'lblCurRead
        '
        Me.lblCurRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurRead.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurRead.Location = New System.Drawing.Point(4, 505)
        Me.lblCurRead.Name = "lblCurRead"
        Me.lblCurRead.Size = New System.Drawing.Size(280, 25)
        Me.lblCurRead.TabIndex = 18
        Me.lblCurRead.Text = "Current Reading"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 487)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Current Reading"
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnImport.FlatAppearance.BorderSize = 0
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.White
        Me.btnImport.Location = New System.Drawing.Point(165, 543)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(119, 46)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'lblCluster
        '
        Me.lblCluster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCluster.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCluster.Location = New System.Drawing.Point(142, 181)
        Me.lblCluster.Name = "lblCluster"
        Me.lblCluster.Size = New System.Drawing.Size(142, 25)
        Me.lblCluster.TabIndex = 16
        Me.lblCluster.Text = "Cluster"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(139, 163)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 18)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Cluster"
        '
        'lblConDate
        '
        Me.lblConDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConDate.Location = New System.Drawing.Point(4, 462)
        Me.lblConDate.Name = "lblConDate"
        Me.lblConDate.Size = New System.Drawing.Size(280, 25)
        Me.lblConDate.TabIndex = 14
        Me.lblConDate.Text = "Connection Date"
        '
        'lblMetBrand
        '
        Me.lblMetBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMetBrand.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetBrand.Location = New System.Drawing.Point(4, 419)
        Me.lblMetBrand.Name = "lblMetBrand"
        Me.lblMetBrand.Size = New System.Drawing.Size(280, 25)
        Me.lblMetBrand.TabIndex = 13
        Me.lblMetBrand.Text = "Meter Brand"
        '
        'lblMetSize
        '
        Me.lblMetSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMetSize.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetSize.Location = New System.Drawing.Point(4, 376)
        Me.lblMetSize.Name = "lblMetSize"
        Me.lblMetSize.Size = New System.Drawing.Size(280, 25)
        Me.lblMetSize.TabIndex = 12
        Me.lblMetSize.Text = "Meter Size"
        '
        'lblMetNum
        '
        Me.lblMetNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMetNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetNum.Location = New System.Drawing.Point(4, 333)
        Me.lblMetNum.Name = "lblMetNum"
        Me.lblMetNum.Size = New System.Drawing.Size(280, 25)
        Me.lblMetNum.TabIndex = 11
        Me.lblMetNum.Text = "Meter #"
        '
        'lblClass
        '
        Me.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(4, 290)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(280, 25)
        Me.lblClass.TabIndex = 10
        Me.lblClass.Text = "Classification"
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(4, 224)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(280, 48)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'lblZone
        '
        Me.lblZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.Location = New System.Drawing.Point(4, 181)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(129, 25)
        Me.lblZone.TabIndex = 8
        Me.lblZone.Text = "Zone"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(4, 86)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(280, 25)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblAccount
        '
        Me.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(4, 43)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(280, 25)
        Me.lblAccount.TabIndex = 6
        Me.lblAccount.Text = "Account"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 444)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Connection Date Started"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Meter Brand"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Meter Size"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Meter Serial #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Classification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Zone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Consumer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account #"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(290, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1262, 766)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lvwLedger)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1262, 741)
        Me.Panel3.TabIndex = 1
        '
        'lvwLedger
        '
        Me.lvwLedger.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader13, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvwLedger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwLedger.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwLedger.FullRowSelect = True
        Me.lvwLedger.GridLines = True
        Me.lvwLedger.HideSelection = False
        Me.lvwLedger.Location = New System.Drawing.Point(0, 0)
        Me.lvwLedger.MultiSelect = False
        Me.lvwLedger.Name = "lvwLedger"
        Me.lvwLedger.Size = New System.Drawing.Size(1262, 741)
        Me.lvwLedger.TabIndex = 0
        Me.lvwLedger.UseCompatibleStateImageBehavior = False
        Me.lvwLedger.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Bill No"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Billing Period"
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Due Date"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Transaction Date"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Previous Reading"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Present Reading"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Consumption"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Bill Amount"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Penalty"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Payment"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Balance"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Receipt No."
        Me.ColumnHeader11.Width = 120
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Bill Status"
        Me.ColumnHeader12.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBillStatement, Me.btnEditBill, Me.btnDelBill, Me.btnEditOR, Me.btnEditOutstanding, Me.btnUnpaid, Me.btnViewOR, Me.ToolStripButton1, Me.btnSOA})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1262, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBillStatement
        '
        Me.btnBillStatement.BackColor = System.Drawing.Color.Silver
        Me.btnBillStatement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBillStatement.Image = CType(resources.GetObject("btnBillStatement.Image"), System.Drawing.Image)
        Me.btnBillStatement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBillStatement.Name = "btnBillStatement"
        Me.btnBillStatement.Size = New System.Drawing.Size(84, 22)
        Me.btnBillStatement.Text = "Bill Statement"
        Me.btnBillStatement.Visible = False
        '
        'btnEditBill
        '
        Me.btnEditBill.BackColor = System.Drawing.Color.Silver
        Me.btnEditBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEditBill.Image = CType(resources.GetObject("btnEditBill.Image"), System.Drawing.Image)
        Me.btnEditBill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditBill.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnEditBill.Name = "btnEditBill"
        Me.btnEditBill.Size = New System.Drawing.Size(50, 22)
        Me.btnEditBill.Text = "Edit Bill"
        Me.btnEditBill.Visible = False
        '
        'btnDelBill
        '
        Me.btnDelBill.BackColor = System.Drawing.Color.Silver
        Me.btnDelBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelBill.Image = CType(resources.GetObject("btnDelBill.Image"), System.Drawing.Image)
        Me.btnDelBill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelBill.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnDelBill.Name = "btnDelBill"
        Me.btnDelBill.Size = New System.Drawing.Size(63, 22)
        Me.btnDelBill.Text = "Delete Bill"
        Me.btnDelBill.Visible = False
        '
        'btnEditOR
        '
        Me.btnEditOR.BackColor = System.Drawing.Color.Silver
        Me.btnEditOR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEditOR.Image = CType(resources.GetObject("btnEditOR.Image"), System.Drawing.Image)
        Me.btnEditOR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditOR.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnEditOR.Name = "btnEditOR"
        Me.btnEditOR.Size = New System.Drawing.Size(56, 22)
        Me.btnEditOR.Text = "Edit O.R."
        Me.btnEditOR.Visible = False
        '
        'btnEditOutstanding
        '
        Me.btnEditOutstanding.BackColor = System.Drawing.Color.Silver
        Me.btnEditOutstanding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEditOutstanding.Image = CType(resources.GetObject("btnEditOutstanding.Image"), System.Drawing.Image)
        Me.btnEditOutstanding.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditOutstanding.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnEditOutstanding.Name = "btnEditOutstanding"
        Me.btnEditOutstanding.Size = New System.Drawing.Size(125, 22)
        Me.btnEditOutstanding.Text = "Edit Outstanding O.R."
        Me.btnEditOutstanding.Visible = False
        '
        'btnUnpaid
        '
        Me.btnUnpaid.BackColor = System.Drawing.Color.Silver
        Me.btnUnpaid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUnpaid.Image = CType(resources.GetObject("btnUnpaid.Image"), System.Drawing.Image)
        Me.btnUnpaid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnpaid.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnUnpaid.Name = "btnUnpaid"
        Me.btnUnpaid.Size = New System.Drawing.Size(101, 22)
        Me.btnUnpaid.Text = "Set Bill to Unpaid"
        Me.btnUnpaid.Visible = False
        '
        'btnViewOR
        '
        Me.btnViewOR.BackColor = System.Drawing.Color.Silver
        Me.btnViewOR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewOR.Image = CType(resources.GetObject("btnViewOR.Image"), System.Drawing.Image)
        Me.btnViewOR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewOR.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnViewOR.Name = "btnViewOR"
        Me.btnViewOR.Size = New System.Drawing.Size(55, 22)
        Me.btnViewOR.Text = "View OR"
        Me.btnViewOR.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Silver
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripButton1.Text = "Create New Bill"
        '
        'btnSOA
        '
        Me.btnSOA.BackColor = System.Drawing.Color.Silver
        Me.btnSOA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSOA.Image = CType(resources.GetObject("btnSOA.Image"), System.Drawing.Image)
        Me.btnSOA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSOA.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnSOA.Name = "btnSOA"
        Me.btnSOA.Size = New System.Drawing.Size(62, 22)
        Me.btnSOA.Text = "Print SOA"
        '
        'frmAccountLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 766)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccountLedger"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Account Ledger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblConDate As System.Windows.Forms.Label
    Friend WithEvents lblMetBrand As System.Windows.Forms.Label
    Friend WithEvents lblMetSize As System.Windows.Forms.Label
    Friend WithEvents lblMetNum As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblCluster As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lvwLedger As System.Windows.Forms.ListView
    Friend WithEvents btnBillStatement As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents lblCurRead As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateMeter As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents lblPrevBal As Label
    Friend WithEvents lblLabelPrev As Label
    Friend WithEvents btnPrevChange As Button
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents btnAccountUpdate As Button
    Friend WithEvents lblAccountName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEditBill As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents lblStat As Label
    Friend WithEvents btnDelBill As ToolStripButton
    Friend WithEvents btnEditOR As ToolStripButton
    Friend WithEvents btnEditOutstanding As ToolStripButton
    Friend WithEvents btnUnpaid As ToolStripButton
    Friend WithEvents btnViewOR As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents btnSOA As ToolStripButton
End Class
