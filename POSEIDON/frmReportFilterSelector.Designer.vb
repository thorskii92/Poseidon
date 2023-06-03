<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportFilterSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportFilterSelector))
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnAnnual = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDaily
        '
        Me.btnDaily.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDaily.FlatAppearance.BorderSize = 0
        Me.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaily.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaily.ForeColor = System.Drawing.Color.White
        Me.btnDaily.Location = New System.Drawing.Point(62, 94)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(174, 55)
        Me.btnDaily.TabIndex = 0
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.Color.SteelBlue
        Me.btnMonthly.FlatAppearance.BorderSize = 0
        Me.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthly.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.ForeColor = System.Drawing.Color.White
        Me.btnMonthly.Location = New System.Drawing.Point(62, 155)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(174, 55)
        Me.btnMonthly.TabIndex = 1
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        '
        'btnAnnual
        '
        Me.btnAnnual.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAnnual.FlatAppearance.BorderSize = 0
        Me.btnAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnual.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnual.ForeColor = System.Drawing.Color.White
        Me.btnAnnual.Location = New System.Drawing.Point(62, 216)
        Me.btnAnnual.Name = "btnAnnual"
        Me.btnAnnual.Size = New System.Drawing.Size(174, 55)
        Me.btnAnnual.TabIndex = 2
        Me.btnAnnual.Text = "Annual"
        Me.btnAnnual.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(79, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(143, 48)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Select Report Type"
        '
        'frmReportFilterSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 397)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAnnual)
        Me.Controls.Add(Me.btnMonthly)
        Me.Controls.Add(Me.btnDaily)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportFilterSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Report Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents btnAnnual As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
