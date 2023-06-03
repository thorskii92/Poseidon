<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billAdjustmentMenu
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
        Me.btnConsumption = New System.Windows.Forms.Button()
        Me.btnAmount = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConsumption
        '
        Me.btnConsumption.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsumption.Location = New System.Drawing.Point(12, 62)
        Me.btnConsumption.Name = "btnConsumption"
        Me.btnConsumption.Size = New System.Drawing.Size(390, 48)
        Me.btnConsumption.TabIndex = 0
        Me.btnConsumption.Text = "Consumption Adjustment"
        Me.btnConsumption.UseVisualStyleBackColor = True
        '
        'btnAmount
        '
        Me.btnAmount.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmount.Location = New System.Drawing.Point(12, 116)
        Me.btnAmount.Name = "btnAmount"
        Me.btnAmount.Size = New System.Drawing.Size(390, 48)
        Me.btnAmount.TabIndex = 1
        Me.btnAmount.Text = "Amount Adjustment"
        Me.btnAmount.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(163, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select type of Adjustment"
        '
        'billAdjustmentMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 263)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAmount)
        Me.Controls.Add(Me.btnConsumption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "billAdjustmentMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Ajustement Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsumption As Button
    Friend WithEvents btnAmount As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
End Class
