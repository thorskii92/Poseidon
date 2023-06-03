<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewDisconnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewDisconnection))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblAccountNum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.lblCluster = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNoticeDate = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblDueAmount = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblDisconnectionDate = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Disconnection Notice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account Information:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Account Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Account Number:"
        '
        'lblAccountName
        '
        Me.lblAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(149, 74)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(251, 18)
        Me.lblAccountName.TabIndex = 4
        Me.lblAccountName.Text = "Name"
        '
        'lblAccountNum
        '
        Me.lblAccountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNum.Location = New System.Drawing.Point(149, 101)
        Me.lblAccountNum.Name = "lblAccountNum"
        Me.lblAccountNum.Size = New System.Drawing.Size(251, 18)
        Me.lblAccountNum.TabIndex = 5
        Me.lblAccountNum.Text = "Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(406, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Account Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(406, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Zone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(491, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cluster:"
        '
        'lblAccountType
        '
        Me.lblAccountType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountType.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.Location = New System.Drawing.Point(506, 74)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(162, 18)
        Me.lblAccountType.TabIndex = 9
        Me.lblAccountType.Text = "Account Type"
        '
        'lblZone
        '
        Me.lblZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.Location = New System.Drawing.Point(455, 102)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(30, 18)
        Me.lblZone.TabIndex = 10
        Me.lblZone.Text = "0"
        '
        'lblCluster
        '
        Me.lblCluster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCluster.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCluster.Location = New System.Drawing.Point(553, 102)
        Me.lblCluster.Name = "lblCluster"
        Me.lblCluster.Size = New System.Drawing.Size(30, 18)
        Me.lblCluster.TabIndex = 11
        Me.lblCluster.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Service Address:"
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(149, 129)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(519, 18)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Notice Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(192, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 18)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Disconnection Date:"
        '
        'lblNoticeDate
        '
        Me.lblNoticeDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoticeDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoticeDate.Location = New System.Drawing.Point(102, 158)
        Me.lblNoticeDate.Name = "lblNoticeDate"
        Me.lblNoticeDate.Size = New System.Drawing.Size(84, 18)
        Me.lblNoticeDate.TabIndex = 16
        Me.lblNoticeDate.Text = "00/00/0000"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(419, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 18)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Due Amount"
        '
        'lblDueAmount
        '
        Me.lblDueAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueAmount.Location = New System.Drawing.Point(511, 158)
        Me.lblDueAmount.Name = "lblDueAmount"
        Me.lblDueAmount.Size = New System.Drawing.Size(157, 18)
        Me.lblDueAmount.TabIndex = 19
        Me.lblDueAmount.Text = "0,000.00"
        Me.lblDueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(583, 205)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 35)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(492, 205)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 35)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblDisconnectionDate
        '
        Me.lblDisconnectionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisconnectionDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisconnectionDate.Location = New System.Drawing.Point(329, 158)
        Me.lblDisconnectionDate.Name = "lblDisconnectionDate"
        Me.lblDisconnectionDate.Size = New System.Drawing.Size(84, 18)
        Me.lblDisconnectionDate.TabIndex = 22
        Me.lblDisconnectionDate.Text = "00/00/0000"
        '
        'frmViewDisconnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 257)
        Me.Controls.Add(Me.lblDisconnectionDate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDueAmount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblNoticeDate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblCluster)
        Me.Controls.Add(Me.lblZone)
        Me.Controls.Add(Me.lblAccountType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAccountNum)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewDisconnection"
        Me.Text = "View Disconnection Notice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAccountName As System.Windows.Forms.Label
    Friend WithEvents lblAccountNum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents lblCluster As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblNoticeDate As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblDueAmount As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblDisconnectionDate As System.Windows.Forms.Label
End Class
