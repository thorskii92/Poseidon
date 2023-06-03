<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccount
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
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnEditName = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(15, 27)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(399, 33)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditName
        '
        Me.btnEditName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditName.Location = New System.Drawing.Point(420, 27)
        Me.btnEditName.Name = "btnEditName"
        Me.btnEditName.Size = New System.Drawing.Size(52, 33)
        Me.btnEditName.TabIndex = 2
        Me.btnEditName.Text = "Edit"
        Me.btnEditName.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username"
        '
        'lblUsername
        '
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(15, 78)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(396, 33)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditUser
        '
        Me.btnEditUser.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUser.Location = New System.Drawing.Point(420, 78)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(52, 33)
        Me.btnEditUser.TabIndex = 5
        Me.btnEditUser.Text = "Edit"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'lblUserType
        '
        Me.lblUserType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserType.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.Location = New System.Drawing.Point(15, 129)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(396, 33)
        Me.lblUserType.TabIndex = 6
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "User Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Position"
        '
        'lblPosition
        '
        Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPosition.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(15, 180)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(396, 33)
        Me.lblPosition.TabIndex = 9
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.Location = New System.Drawing.Point(15, 216)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(159, 33)
        Me.btnUpdatePassword.TabIndex = 10
        Me.btnUpdatePassword.Text = "Update my Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(372, 216)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(100, 33)
        Me.btnDone.TabIndex = 11
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'frmUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 266)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.btnEditUser)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEditName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUserAccount"
        Me.Text = "My Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents btnEditName As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents btnUpdatePassword As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
End Class
