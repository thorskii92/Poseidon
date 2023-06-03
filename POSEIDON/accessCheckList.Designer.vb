<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accessCheckList
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.chkTools = New System.Windows.Forms.CheckBox()
        Me.chkAccountingTab = New System.Windows.Forms.CheckBox()
        Me.chkBilling = New System.Windows.Forms.CheckBox()
        Me.chkCollection = New System.Windows.Forms.CheckBox()
        Me.chkMeterReading = New System.Windows.Forms.CheckBox()
        Me.chkReports = New System.Windows.Forms.CheckBox()
        Me.chkConsumers = New System.Windows.Forms.CheckBox()
        Me.chkAccounts = New System.Windows.Forms.CheckBox()
        Me.chkPending = New System.Windows.Forms.CheckBox()
        Me.chkSequencing = New System.Windows.Forms.CheckBox()
        Me.chkApprvls = New System.Windows.Forms.CheckBox()
        Me.chkSettings = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(346, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 29)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(255, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 29)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Check Boxes for Access"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Type:"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.Location = New System.Drawing.Point(92, 9)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(70, 18)
        Me.lblUserType.TabIndex = 4
        Me.lblUserType.Text = "User Type"
        '
        'chkTools
        '
        Me.chkTools.AutoSize = True
        Me.chkTools.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTools.Location = New System.Drawing.Point(31, 69)
        Me.chkTools.Name = "chkTools"
        Me.chkTools.Size = New System.Drawing.Size(55, 19)
        Me.chkTools.TabIndex = 5
        Me.chkTools.Text = "Tools"
        Me.chkTools.UseVisualStyleBackColor = True
        '
        'chkAccountingTab
        '
        Me.chkAccountingTab.AutoSize = True
        Me.chkAccountingTab.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccountingTab.Location = New System.Drawing.Point(31, 107)
        Me.chkAccountingTab.Name = "chkAccountingTab"
        Me.chkAccountingTab.Size = New System.Drawing.Size(108, 19)
        Me.chkAccountingTab.TabIndex = 6
        Me.chkAccountingTab.Text = "Accounting Tab"
        Me.chkAccountingTab.UseVisualStyleBackColor = True
        '
        'chkBilling
        '
        Me.chkBilling.AutoSize = True
        Me.chkBilling.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBilling.Location = New System.Drawing.Point(31, 147)
        Me.chkBilling.Name = "chkBilling"
        Me.chkBilling.Size = New System.Drawing.Size(84, 19)
        Me.chkBilling.TabIndex = 7
        Me.chkBilling.Text = "Billing Tab"
        Me.chkBilling.UseVisualStyleBackColor = True
        '
        'chkCollection
        '
        Me.chkCollection.AutoSize = True
        Me.chkCollection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCollection.Location = New System.Drawing.Point(31, 187)
        Me.chkCollection.Name = "chkCollection"
        Me.chkCollection.Size = New System.Drawing.Size(103, 19)
        Me.chkCollection.TabIndex = 8
        Me.chkCollection.Text = "Collection Tab"
        Me.chkCollection.UseVisualStyleBackColor = True
        '
        'chkMeterReading
        '
        Me.chkMeterReading.AutoSize = True
        Me.chkMeterReading.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMeterReading.Location = New System.Drawing.Point(31, 228)
        Me.chkMeterReading.Name = "chkMeterReading"
        Me.chkMeterReading.Size = New System.Drawing.Size(127, 19)
        Me.chkMeterReading.TabIndex = 9
        Me.chkMeterReading.Text = "Meter Reading Tab"
        Me.chkMeterReading.UseVisualStyleBackColor = True
        '
        'chkReports
        '
        Me.chkReports.AutoSize = True
        Me.chkReports.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReports.Location = New System.Drawing.Point(232, 69)
        Me.chkReports.Name = "chkReports"
        Me.chkReports.Size = New System.Drawing.Size(90, 19)
        Me.chkReports.TabIndex = 10
        Me.chkReports.Text = "Reports Tab"
        Me.chkReports.UseVisualStyleBackColor = True
        '
        'chkConsumers
        '
        Me.chkConsumers.AutoSize = True
        Me.chkConsumers.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConsumers.Location = New System.Drawing.Point(232, 107)
        Me.chkConsumers.Name = "chkConsumers"
        Me.chkConsumers.Size = New System.Drawing.Size(109, 19)
        Me.chkConsumers.TabIndex = 11
        Me.chkConsumers.Text = "Consumers Tab"
        Me.chkConsumers.UseVisualStyleBackColor = True
        '
        'chkAccounts
        '
        Me.chkAccounts.AutoSize = True
        Me.chkAccounts.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccounts.Location = New System.Drawing.Point(232, 147)
        Me.chkAccounts.Name = "chkAccounts"
        Me.chkAccounts.Size = New System.Drawing.Size(156, 19)
        Me.chkAccounts.TabIndex = 12
        Me.chkAccounts.Text = "Consumer Accounts Tab"
        Me.chkAccounts.UseVisualStyleBackColor = True
        '
        'chkPending
        '
        Me.chkPending.AutoSize = True
        Me.chkPending.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPending.Location = New System.Drawing.Point(232, 187)
        Me.chkPending.Name = "chkPending"
        Me.chkPending.Size = New System.Drawing.Size(114, 19)
        Me.chkPending.TabIndex = 13
        Me.chkPending.Text = "Pending List Tab"
        Me.chkPending.UseVisualStyleBackColor = True
        '
        'chkSequencing
        '
        Me.chkSequencing.AutoSize = True
        Me.chkSequencing.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSequencing.Location = New System.Drawing.Point(232, 228)
        Me.chkSequencing.Name = "chkSequencing"
        Me.chkSequencing.Size = New System.Drawing.Size(110, 19)
        Me.chkSequencing.TabIndex = 14
        Me.chkSequencing.Text = "Sequencing Tab"
        Me.chkSequencing.UseVisualStyleBackColor = True
        '
        'chkApprvls
        '
        Me.chkApprvls.AutoSize = True
        Me.chkApprvls.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkApprvls.Location = New System.Drawing.Point(31, 267)
        Me.chkApprvls.Name = "chkApprvls"
        Me.chkApprvls.Size = New System.Drawing.Size(104, 19)
        Me.chkApprvls.TabIndex = 15
        Me.chkApprvls.Text = "Approvals Tab"
        Me.chkApprvls.UseVisualStyleBackColor = True
        '
        'chkSettings
        '
        Me.chkSettings.AutoSize = True
        Me.chkSettings.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSettings.Location = New System.Drawing.Point(232, 267)
        Me.chkSettings.Name = "chkSettings"
        Me.chkSettings.Size = New System.Drawing.Size(68, 19)
        Me.chkSettings.TabIndex = 16
        Me.chkSettings.Text = "Settings"
        Me.chkSettings.UseVisualStyleBackColor = True
        '
        'accessCheckList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 360)
        Me.Controls.Add(Me.chkSettings)
        Me.Controls.Add(Me.chkApprvls)
        Me.Controls.Add(Me.chkSequencing)
        Me.Controls.Add(Me.chkPending)
        Me.Controls.Add(Me.chkAccounts)
        Me.Controls.Add(Me.chkConsumers)
        Me.Controls.Add(Me.chkReports)
        Me.Controls.Add(Me.chkMeterReading)
        Me.Controls.Add(Me.chkCollection)
        Me.Controls.Add(Me.chkBilling)
        Me.Controls.Add(Me.chkAccountingTab)
        Me.Controls.Add(Me.chkTools)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accessCheckList"
        Me.Text = "Access Checklist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents chkTools As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccountingTab As System.Windows.Forms.CheckBox
    Friend WithEvents chkBilling As System.Windows.Forms.CheckBox
    Friend WithEvents chkCollection As System.Windows.Forms.CheckBox
    Friend WithEvents chkMeterReading As System.Windows.Forms.CheckBox
    Friend WithEvents chkReports As System.Windows.Forms.CheckBox
    Friend WithEvents chkConsumers As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccounts As System.Windows.Forms.CheckBox
    Friend WithEvents chkPending As System.Windows.Forms.CheckBox
    Friend WithEvents chkSequencing As System.Windows.Forms.CheckBox
    Friend WithEvents chkApprvls As System.Windows.Forms.CheckBox
    Friend WithEvents chkSettings As System.Windows.Forms.CheckBox
End Class
