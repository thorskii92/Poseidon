<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtSeq = New System.Windows.Forms.TextBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.cboCluster = New System.Windows.Forms.ComboBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnCheckAccount = New System.Windows.Forms.Button()
        Me.lblAccountConfirmation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consumer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Classification"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Province"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Municipality"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Barangay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cluster"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(293, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Account #"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(296, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Receipt #"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(296, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Street Address (Optional)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sequence #"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(23, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(263, 26)
        Me.txtName.TabIndex = 10
        '
        'txtAccount
        '
        Me.txtAccount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(296, 30)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(187, 26)
        Me.txtAccount.TabIndex = 16
        '
        'txtReceipt
        '
        Me.txtReceipt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(296, 130)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(187, 26)
        Me.txtReceipt.TabIndex = 17
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(296, 180)
        Me.txtStreetAddress.Multiline = True
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(263, 84)
        Me.txtStreetAddress.TabIndex = 18
        '
        'txtSeq
        '
        Me.txtSeq.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeq.Location = New System.Drawing.Point(296, 80)
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.ReadOnly = True
        Me.txtSeq.Size = New System.Drawing.Size(99, 26)
        Me.txtSeq.TabIndex = 19
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(23, 80)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(263, 26)
        Me.cboClass.TabIndex = 20
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(323, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 36)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(444, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 36)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(23, 130)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(263, 26)
        Me.cboProv.TabIndex = 27
        '
        'cboMun
        '
        Me.cboMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMun.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(23, 180)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(263, 26)
        Me.cboMun.TabIndex = 28
        '
        'cboBrgy
        '
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(23, 230)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(263, 26)
        Me.cboBrgy.TabIndex = 29
        '
        'cboCluster
        '
        Me.cboCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCluster.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCluster.FormattingEnabled = True
        Me.cboCluster.Location = New System.Drawing.Point(23, 280)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(263, 26)
        Me.cboCluster.TabIndex = 30
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(489, 124)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(70, 36)
        Me.btnCheck.TabIndex = 31
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(373, 113)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(110, 14)
        Me.lblConfirmation.TabIndex = 32
        Me.lblConfirmation.Text = "Payment Confirmed"
        Me.lblConfirmation.Visible = False
        '
        'btnCheckAccount
        '
        Me.btnCheckAccount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAccount.Location = New System.Drawing.Point(489, 24)
        Me.btnCheckAccount.Name = "btnCheckAccount"
        Me.btnCheckAccount.Size = New System.Drawing.Size(70, 36)
        Me.btnCheckAccount.TabIndex = 33
        Me.btnCheckAccount.Text = "Check"
        Me.btnCheckAccount.UseVisualStyleBackColor = True
        '
        'lblAccountConfirmation
        '
        Me.lblAccountConfirmation.AutoSize = True
        Me.lblAccountConfirmation.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountConfirmation.Location = New System.Drawing.Point(373, 13)
        Me.lblAccountConfirmation.Name = "lblAccountConfirmation"
        Me.lblAccountConfirmation.Size = New System.Drawing.Size(106, 14)
        Me.lblAccountConfirmation.TabIndex = 34
        Me.lblAccountConfirmation.Text = "Account Confirmed"
        Me.lblAccountConfirmation.Visible = False
        '
        'frmNewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 332)
        Me.Controls.Add(Me.lblAccountConfirmation)
        Me.Controls.Add(Me.btnCheckAccount)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.cboCluster)
        Me.Controls.Add(Me.cboBrgy)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.cboProv)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboClass)
        Me.Controls.Add(Me.txtSeq)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtReceipt)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.txtName)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewAccount"
        Me.Text = "New Account"
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSeq As System.Windows.Forms.TextBox
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents cboMun As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrgy As System.Windows.Forms.ComboBox
    Friend WithEvents cboCluster As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents btnCheckAccount As Button
    Friend WithEvents lblAccountConfirmation As Label
End Class
