<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemUsers))
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnDisableAccount = New System.Windows.Forms.Button()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnViewUserDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewUser
        '
        Me.btnNewUser.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNewUser.FlatAppearance.BorderSize = 0
        Me.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewUser.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.ForeColor = System.Drawing.Color.White
        Me.btnNewUser.Location = New System.Drawing.Point(12, 12)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(148, 34)
        Me.btnNewUser.TabIndex = 0
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = False
        '
        'btnDisableAccount
        '
        Me.btnDisableAccount.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDisableAccount.Enabled = False
        Me.btnDisableAccount.FlatAppearance.BorderSize = 0
        Me.btnDisableAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisableAccount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisableAccount.ForeColor = System.Drawing.Color.White
        Me.btnDisableAccount.Location = New System.Drawing.Point(166, 12)
        Me.btnDisableAccount.Name = "btnDisableAccount"
        Me.btnDisableAccount.Size = New System.Drawing.Size(148, 34)
        Me.btnDisableAccount.TabIndex = 1
        Me.btnDisableAccount.Text = "Deactivate Account"
        Me.btnDisableAccount.UseVisualStyleBackColor = False
        '
        'lvw
        '
        Me.lvw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvw.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.HideSelection = False
        Me.lvw.Location = New System.Drawing.Point(12, 52)
        Me.lvw.MultiSelect = False
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(770, 328)
        Me.lvw.TabIndex = 2
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User ID"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Log"
        Me.ColumnHeader4.Width = 178
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Log Type"
        Me.ColumnHeader5.Width = 200
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReset.Enabled = False
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(320, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(148, 34)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset User Password"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnViewUserDetails
        '
        Me.btnViewUserDetails.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewUserDetails.Enabled = False
        Me.btnViewUserDetails.FlatAppearance.BorderSize = 0
        Me.btnViewUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewUserDetails.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUserDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewUserDetails.Location = New System.Drawing.Point(634, 12)
        Me.btnViewUserDetails.Name = "btnViewUserDetails"
        Me.btnViewUserDetails.Size = New System.Drawing.Size(148, 34)
        Me.btnViewUserDetails.TabIndex = 4
        Me.btnViewUserDetails.Text = "View User Details"
        Me.btnViewUserDetails.UseVisualStyleBackColor = False
        '
        'frmSystemUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 421)
        Me.Controls.Add(Me.btnViewUserDetails)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.btnDisableAccount)
        Me.Controls.Add(Me.btnNewUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSystemUsers"
        Me.ShowIcon = False
        Me.Text = "System Users"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents btnDisableAccount As System.Windows.Forms.Button
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnViewUserDetails As System.Windows.Forms.Button
End Class
