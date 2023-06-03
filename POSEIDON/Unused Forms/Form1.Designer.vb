<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetReading
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
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.ans = New System.Windows.Forms.TextBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.ans2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ans3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(53, 64)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 0
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(175, 64)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(100, 20)
        Me.t2.TabIndex = 1
        '
        'ans
        '
        Me.ans.Location = New System.Drawing.Point(364, 64)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(100, 20)
        Me.ans.TabIndex = 2
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(389, 282)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 3
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'ans2
        '
        Me.ans2.Location = New System.Drawing.Point(364, 90)
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(100, 20)
        Me.ans2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "\"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MOD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "/"
        '
        'ans3
        '
        Me.ans3.Location = New System.Drawing.Point(364, 116)
        Me.ans3.Name = "ans3"
        Me.ans3.Size = New System.Drawing.Size(100, 20)
        Me.ans3.TabIndex = 7
        '
        'frmMetReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 433)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ans3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMetReading"
        Me.Text = "Water Rates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents ans As System.Windows.Forms.TextBox
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents ans2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ans3 As System.Windows.Forms.TextBox

End Class
