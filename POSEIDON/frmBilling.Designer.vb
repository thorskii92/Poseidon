<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilling))
        Me.lvw = New System.Windows.Forms.ListView()
        Me.acctNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnBillingNotice = New System.Windows.Forms.Button()
        Me.btnPrintSelBill = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblBillStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAdjust = New System.Windows.Forms.Button()
        Me.btnDispute = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdateBillBalance = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvw
        '
        Me.lvw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.acctNum, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.clmdate, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvw.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.HideSelection = False
        Me.lvw.Location = New System.Drawing.Point(12, 46)
        Me.lvw.MultiSelect = False
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(1425, 550)
        Me.lvw.TabIndex = 0
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'acctNum
        '
        Me.acctNum.Text = "Account #"
        Me.acctNum.Width = 130
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Previous Reading"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Current Reading"
        Me.ColumnHeader3.Width = 120
        '
        'clmdate
        '
        Me.clmdate.Text = "Consumption"
        Me.clmdate.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Covered"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Due Date"
        Me.ColumnHeader5.Width = 85
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount Due"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Amount After Due"
        Me.ColumnHeader7.Width = 133
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1110, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 28)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print Bills"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.SteelBlue
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(12, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(191, 28)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "Load Billing"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnBillingNotice
        '
        Me.btnBillingNotice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBillingNotice.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBillingNotice.Enabled = False
        Me.btnBillingNotice.FlatAppearance.BorderSize = 0
        Me.btnBillingNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBillingNotice.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingNotice.ForeColor = System.Drawing.Color.White
        Me.btnBillingNotice.Location = New System.Drawing.Point(707, 12)
        Me.btnBillingNotice.Name = "btnBillingNotice"
        Me.btnBillingNotice.Size = New System.Drawing.Size(191, 28)
        Me.btnBillingNotice.TabIndex = 3
        Me.btnBillingNotice.Text = "View Billing Notice"
        Me.btnBillingNotice.UseVisualStyleBackColor = False
        '
        'btnPrintSelBill
        '
        Me.btnPrintSelBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintSelBill.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrintSelBill.FlatAppearance.BorderSize = 0
        Me.btnPrintSelBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSelBill.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSelBill.ForeColor = System.Drawing.Color.White
        Me.btnPrintSelBill.Location = New System.Drawing.Point(904, 12)
        Me.btnPrintSelBill.Name = "btnPrintSelBill"
        Me.btnPrintSelBill.Size = New System.Drawing.Size(200, 28)
        Me.btnPrintSelBill.TabIndex = 5
        Me.btnPrintSelBill.Text = "Print Selected Bill"
        Me.btnPrintSelBill.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblBillStat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1449, 23)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblBillStat
        '
        Me.lblBillStat.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillStat.Name = "lblBillStat"
        Me.lblBillStat.Size = New System.Drawing.Size(112, 18)
        Me.lblBillStat.Text = "Currently Billing:"
        '
        'btnAdjust
        '
        Me.btnAdjust.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdjust.FlatAppearance.BorderSize = 0
        Me.btnAdjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdjust.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdjust.ForeColor = System.Drawing.Color.White
        Me.btnAdjust.Location = New System.Drawing.Point(231, 12)
        Me.btnAdjust.Name = "btnAdjust"
        Me.btnAdjust.Size = New System.Drawing.Size(150, 28)
        Me.btnAdjust.TabIndex = 7
        Me.btnAdjust.Text = "Adjust Bill"
        Me.btnAdjust.UseVisualStyleBackColor = False
        '
        'btnDispute
        '
        Me.btnDispute.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDispute.FlatAppearance.BorderSize = 0
        Me.btnDispute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispute.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispute.ForeColor = System.Drawing.Color.White
        Me.btnDispute.Location = New System.Drawing.Point(387, 12)
        Me.btnDispute.Name = "btnDispute"
        Me.btnDispute.Size = New System.Drawing.Size(150, 28)
        Me.btnDispute.TabIndex = 8
        Me.btnDispute.Text = "Dispute Bill"
        Me.btnDispute.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.BackgroundImage = Global.POSEIDON.My.Resources.Resources._95_2001
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1409, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(28, 28)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdateBillBalance
        '
        Me.btnUpdateBillBalance.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdateBillBalance.FlatAppearance.BorderSize = 0
        Me.btnUpdateBillBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateBillBalance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBillBalance.ForeColor = System.Drawing.Color.White
        Me.btnUpdateBillBalance.Location = New System.Drawing.Point(543, 12)
        Me.btnUpdateBillBalance.Name = "btnUpdateBillBalance"
        Me.btnUpdateBillBalance.Size = New System.Drawing.Size(150, 28)
        Me.btnUpdateBillBalance.TabIndex = 10
        Me.btnUpdateBillBalance.Text = "Update Bill Balance"
        Me.btnUpdateBillBalance.UseVisualStyleBackColor = False
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1449, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdateBillBalance)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDispute)
        Me.Controls.Add(Me.btnAdjust)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnPrintSelBill)
        Me.Controls.Add(Me.btnBillingNotice)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lvw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBilling"
        Me.Text = "Water Billing"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents acctNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnBillingNotice As System.Windows.Forms.Button
    Friend WithEvents btnPrintSelBill As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblBillStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAdjust As System.Windows.Forms.Button
    Friend WithEvents btnDispute As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBillBalance As Button
End Class
