<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovalRequests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApprovalRequests))
        Me.lvwRequests = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvwRequests
        '
        Me.lvwRequests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwRequests.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvwRequests.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwRequests.FullRowSelect = True
        Me.lvwRequests.GridLines = True
        Me.lvwRequests.HideSelection = False
        Me.lvwRequests.Location = New System.Drawing.Point(12, 12)
        Me.lvwRequests.MultiSelect = False
        Me.lvwRequests.Name = "lvwRequests"
        Me.lvwRequests.Size = New System.Drawing.Size(1103, 388)
        Me.lvwRequests.TabIndex = 0
        Me.lvwRequests.UseCompatibleStateImageBehavior = False
        Me.lvwRequests.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Bill #"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Account #"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Requester's Name"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Bill Date"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Original Amount"
        Me.ColumnHeader7.Width = 150
        '
        'btnDecline
        '
        Me.btnDecline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecline.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDecline.FlatAppearance.BorderSize = 0
        Me.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecline.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.ForeColor = System.Drawing.Color.White
        Me.btnDecline.Location = New System.Drawing.Point(969, 406)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(146, 31)
        Me.btnDecline.TabIndex = 3
        Me.btnDecline.Text = "View Request"
        Me.btnDecline.UseVisualStyleBackColor = False
        Me.btnDecline.Visible = False
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Request Date"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Prepared by"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Account Name"
        Me.ColumnHeader5.Width = 200
        '
        'frmApprovalRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 446)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.lvwRequests)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmApprovalRequests"
        Me.Text = "Approval Requests"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwRequests As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDecline As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
