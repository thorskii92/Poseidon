<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateAccountDetails
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
        Me.txtAccountNum = New System.Windows.Forms.TextBox()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.cboClassification = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBarangay = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.cboCluster = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Classification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Street Address"
        '
        'txtAccountNum
        '
        Me.txtAccountNum.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNum.Location = New System.Drawing.Point(126, 12)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(343, 27)
        Me.txtAccountNum.TabIndex = 4
        '
        'txtAccountName
        '
        Me.txtAccountName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.Location = New System.Drawing.Point(126, 45)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(343, 27)
        Me.txtAccountName.TabIndex = 5
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(126, 177)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(343, 27)
        Me.txtStreetAddress.TabIndex = 7
        '
        'cboClassification
        '
        Me.cboClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClassification.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClassification.FormattingEnabled = True
        Me.cboClassification.Location = New System.Drawing.Point(126, 78)
        Me.cboClassification.Name = "cboClassification"
        Me.cboClassification.Size = New System.Drawing.Size(343, 27)
        Me.cboClassification.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(386, 243)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 35)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(297, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 35)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Barangay"
        '
        'cboBarangay
        '
        Me.cboBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBarangay.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarangay.FormattingEnabled = True
        Me.cboBarangay.Location = New System.Drawing.Point(126, 144)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(343, 27)
        Me.cboBarangay.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Zone"
        '
        'cboZone
        '
        Me.cboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(126, 111)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(343, 27)
        Me.cboZone.TabIndex = 14
        '
        'cboCluster
        '
        Me.cboCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCluster.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCluster.FormattingEnabled = True
        Me.cboCluster.Location = New System.Drawing.Point(126, 210)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(343, 27)
        Me.cboCluster.TabIndex = 16
        Me.cboCluster.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cluster"
        Me.Label7.Visible = False
        '
        'frmUpdateAccountDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 294)
        Me.Controls.Add(Me.cboCluster)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboBarangay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cboClassification)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.txtAccountNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUpdateAccountDetails"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Update Account Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccountNum As TextBox
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents cboClassification As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBarangay As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboZone As ComboBox
    Friend WithEvents cboCluster As ComboBox
    Friend WithEvents Label7 As Label
End Class
