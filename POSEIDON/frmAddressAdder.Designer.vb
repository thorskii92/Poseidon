<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddressAdder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddressAdder))
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkDef = New System.Windows.Forms.CheckBox()
        Me.txtBCode = New System.Windows.Forms.TextBox()
        Me.lblBCode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(12, 19)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(55, 18)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "_ Name"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(15, 48)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(331, 26)
        Me.txtAddress.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(190, 80)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(271, 80)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkDef
        '
        Me.chkDef.AutoSize = True
        Me.chkDef.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDef.Location = New System.Drawing.Point(487, 50)
        Me.chkDef.Name = "chkDef"
        Me.chkDef.Size = New System.Drawing.Size(73, 22)
        Me.chkDef.TabIndex = 4
        Me.chkDef.Text = "Default"
        Me.chkDef.UseVisualStyleBackColor = True
        '
        'txtBCode
        '
        Me.txtBCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBCode.Location = New System.Drawing.Point(352, 48)
        Me.txtBCode.Name = "txtBCode"
        Me.txtBCode.Size = New System.Drawing.Size(129, 26)
        Me.txtBCode.TabIndex = 2
        '
        'lblBCode
        '
        Me.lblBCode.AutoSize = True
        Me.lblBCode.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCode.Location = New System.Drawing.Point(349, 19)
        Me.lblBCode.Name = "lblBCode"
        Me.lblBCode.Size = New System.Drawing.Size(99, 18)
        Me.lblBCode.TabIndex = 6
        Me.lblBCode.Text = "Barangay Code"
        '
        'frmAddressAdder
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 120)
        Me.Controls.Add(Me.lblBCode)
        Me.Controls.Add(Me.txtBCode)
        Me.Controls.Add(Me.chkDef)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddressAdder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddressAdder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkDef As System.Windows.Forms.CheckBox
    Friend WithEvents txtBCode As System.Windows.Forms.TextBox
    Friend WithEvents lblBCode As System.Windows.Forms.Label
End Class
