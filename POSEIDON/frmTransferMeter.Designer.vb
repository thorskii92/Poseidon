<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferMeter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.cboBar = New System.Windows.Forms.ComboBox()
        Me.cboCluster = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtOR = New System.Windows.Forms.TextBox()
        Me.lblConsName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCheckOR = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transfer Meter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Consumer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OR Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.cboCluster)
        Me.GroupBox1.Controls.Add(Me.cboBar)
        Me.GroupBox1.Controls.Add(Me.cboZone)
        Me.GroupBox1.Controls.Add(Me.cboMun)
        Me.GroupBox1.Controls.Add(Me.cboProv)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 256)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Province"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Municipality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Zone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Barangay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cluster"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Address"
        '
        'cboProv
        '
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(121, 24)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(348, 26)
        Me.cboProv.TabIndex = 6
        '
        'cboMun
        '
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(121, 55)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(348, 26)
        Me.cboMun.TabIndex = 7
        '
        'cboZone
        '
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(121, 87)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(348, 26)
        Me.cboZone.TabIndex = 8
        '
        'cboBar
        '
        Me.cboBar.FormattingEnabled = True
        Me.cboBar.Location = New System.Drawing.Point(121, 119)
        Me.cboBar.Name = "cboBar"
        Me.cboBar.Size = New System.Drawing.Size(348, 26)
        Me.cboBar.TabIndex = 9
        '
        'cboCluster
        '
        Me.cboCluster.FormattingEnabled = True
        Me.cboCluster.Location = New System.Drawing.Point(121, 151)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(348, 26)
        Me.cboCluster.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(121, 183)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(348, 62)
        Me.txtAddress.TabIndex = 11
        '
        'txtOR
        '
        Me.txtOR.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOR.Location = New System.Drawing.Point(159, 101)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(238, 27)
        Me.txtOR.TabIndex = 4
        '
        'lblConsName
        '
        Me.lblConsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsName.Location = New System.Drawing.Point(159, 28)
        Me.lblConsName.Name = "lblConsName"
        Me.lblConsName.Size = New System.Drawing.Size(332, 27)
        Me.lblConsName.TabIndex = 5
        Me.lblConsName.Text = "Consumer Name"
        Me.lblConsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(403, 428)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(309, 428)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(88, 40)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(403, 101)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(88, 27)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'lblAccount
        '
        Me.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(159, 59)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(332, 27)
        Me.lblAccount.TabIndex = 10
        Me.lblAccount.Text = "Account No"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(63, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Account No"
        '
        'lblCheckOR
        '
        Me.lblCheckOR.AutoSize = True
        Me.lblCheckOR.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOR.Location = New System.Drawing.Point(155, 131)
        Me.lblCheckOR.Name = "lblCheckOR"
        Me.lblCheckOR.Size = New System.Drawing.Size(65, 14)
        Me.lblCheckOR.TabIndex = 11
        Me.lblCheckOR.Text = "OR Number"
        '
        'frmTransferMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 484)
        Me.Controls.Add(Me.lblCheckOR)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblConsName)
        Me.Controls.Add(Me.txtOR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransferMeter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Meter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboCluster As System.Windows.Forms.ComboBox
    Friend WithEvents cboBar As System.Windows.Forms.ComboBox
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboMun As System.Windows.Forms.ComboBox
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents txtOR As System.Windows.Forms.TextBox
    Friend WithEvents lblConsName As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCheckOR As System.Windows.Forms.Label
End Class
