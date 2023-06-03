<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWaterBill = New System.Windows.Forms.Button()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select a Payment Method"
        '
        'btnWaterBill
        '
        Me.btnWaterBill.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnWaterBill.FlatAppearance.BorderSize = 0
        Me.btnWaterBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWaterBill.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaterBill.Location = New System.Drawing.Point(16, 60)
        Me.btnWaterBill.Name = "btnWaterBill"
        Me.btnWaterBill.Size = New System.Drawing.Size(309, 60)
        Me.btnWaterBill.TabIndex = 1
        Me.btnWaterBill.Text = "Payment Of Water Bill"
        Me.btnWaterBill.UseVisualStyleBackColor = False
        '
        'btnOther
        '
        Me.btnOther.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOther.FlatAppearance.BorderSize = 0
        Me.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOther.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOther.Location = New System.Drawing.Point(16, 126)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(309, 60)
        Me.btnOther.TabIndex = 2
        Me.btnOther.Text = "Other Payments"
        Me.btnOther.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(530, 428)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(138, 33)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'paymentMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnWaterBill)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "paymentMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnWaterBill As System.Windows.Forms.Button
    Friend WithEvents btnOther As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
