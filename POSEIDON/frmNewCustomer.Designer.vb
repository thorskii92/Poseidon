<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewCustomer))
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConNum = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtagency = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(135, 18)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(271, 26)
        Me.txtFName.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Last Name"
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(135, 50)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(271, 26)
        Me.txtMName.TabIndex = 21
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(135, 82)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(271, 26)
        Me.txtLName.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Contact No."
        '
        'txtConNum
        '
        Me.txtConNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConNum.Location = New System.Drawing.Point(135, 146)
        Me.txtConNum.Name = "txtConNum"
        Me.txtConNum.Size = New System.Drawing.Size(271, 26)
        Me.txtConNum.TabIndex = 24
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(135, 178)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(271, 26)
        Me.txtAddress.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Address"
        '
        'cboBrgy
        '
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(135, 274)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(271, 26)
        Me.cboBrgy.TabIndex = 35
        '
        'cboMun
        '
        Me.cboMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMun.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(135, 242)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(271, 26)
        Me.cboMun.TabIndex = 34
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(135, 210)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(271, 26)
        Me.cboProv.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Province"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Barangay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Municipality"
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(234, 306)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(83, 32)
        Me.btnDone.TabIndex = 38
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(323, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 32)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Agency/Company"
        '
        'txtagency
        '
        Me.txtagency.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagency.Location = New System.Drawing.Point(135, 114)
        Me.txtagency.Name = "txtagency"
        Me.txtagency.Size = New System.Drawing.Size(271, 26)
        Me.txtagency.TabIndex = 40
        '
        'frmNewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 348)
        Me.Controls.Add(Me.txtagency)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboBrgy)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.cboProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewCustomer"
        Me.Text = "Register New Client Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConNum As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboBrgy As System.Windows.Forms.ComboBox
    Friend WithEvents cboMun As System.Windows.Forms.ComboBox
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtagency As System.Windows.Forms.TextBox
End Class
