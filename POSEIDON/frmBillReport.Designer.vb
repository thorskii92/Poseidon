<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillReport))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvwGenList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lvwBills = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEditBill = New System.Windows.Forms.Button()
        Me.btnPrintSelected = New System.Windows.Forms.Button()
        Me.btnPrintBills = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvwGenList)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 495)
        Me.Panel1.TabIndex = 0
        '
        'lvwGenList
        '
        Me.lvwGenList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwGenList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwGenList.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwGenList.FullRowSelect = True
        Me.lvwGenList.GridLines = True
        Me.lvwGenList.HideSelection = False
        Me.lvwGenList.Location = New System.Drawing.Point(0, 32)
        Me.lvwGenList.MultiSelect = False
        Me.lvwGenList.Name = "lvwGenList"
        Me.lvwGenList.Size = New System.Drawing.Size(772, 463)
        Me.lvwGenList.TabIndex = 1
        Me.lvwGenList.UseCompatibleStateImageBehavior = False
        Me.lvwGenList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Barangay"
        Me.ColumnHeader2.Width = 220
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cluster"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Covered Period"
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No. of Bills"
        Me.ColumnHeader6.Width = 73
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Generated By"
        Me.ColumnHeader7.Width = 174
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 32)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Generated Bills"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lvwBills)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(772, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 495)
        Me.Panel3.TabIndex = 1
        '
        'lvwBills
        '
        Me.lvwBills.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader4, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvwBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwBills.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBills.FullRowSelect = True
        Me.lvwBills.GridLines = True
        Me.lvwBills.HideSelection = False
        Me.lvwBills.Location = New System.Drawing.Point(0, 32)
        Me.lvwBills.MultiSelect = False
        Me.lvwBills.Name = "lvwBills"
        Me.lvwBills.Size = New System.Drawing.Size(561, 463)
        Me.lvwBills.TabIndex = 0
        Me.lvwBills.UseCompatibleStateImageBehavior = False
        Me.lvwBills.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Bill No."
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Account No."
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Account Name"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Bill Status"
        Me.ColumnHeader11.Width = 80
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Consumption"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Bill AMount"
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "E.F"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Classification"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Consumer Type"
        Me.ColumnHeader15.Width = 120
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Discount"
        Me.ColumnHeader16.Width = 100
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Controls.Add(Me.btnEditBill)
        Me.Panel4.Controls.Add(Me.btnPrintSelected)
        Me.Panel4.Controls.Add(Me.btnPrintBills)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(561, 32)
        Me.Panel4.TabIndex = 1
        '
        'btnEditBill
        '
        Me.btnEditBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditBill.BackColor = System.Drawing.Color.White
        Me.btnEditBill.FlatAppearance.BorderSize = 0
        Me.btnEditBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBill.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBill.Location = New System.Drawing.Point(287, 3)
        Me.btnEditBill.Name = "btnEditBill"
        Me.btnEditBill.Size = New System.Drawing.Size(92, 26)
        Me.btnEditBill.TabIndex = 2
        Me.btnEditBill.Text = "Edit Bill"
        Me.btnEditBill.UseVisualStyleBackColor = False
        '
        'btnPrintSelected
        '
        Me.btnPrintSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintSelected.BackColor = System.Drawing.Color.White
        Me.btnPrintSelected.FlatAppearance.BorderSize = 0
        Me.btnPrintSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSelected.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSelected.Location = New System.Drawing.Point(385, 3)
        Me.btnPrintSelected.Name = "btnPrintSelected"
        Me.btnPrintSelected.Size = New System.Drawing.Size(92, 26)
        Me.btnPrintSelected.TabIndex = 1
        Me.btnPrintSelected.Text = "Print Selected"
        Me.btnPrintSelected.UseVisualStyleBackColor = False
        '
        'btnPrintBills
        '
        Me.btnPrintBills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBills.BackColor = System.Drawing.Color.White
        Me.btnPrintBills.FlatAppearance.BorderSize = 0
        Me.btnPrintBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBills.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBills.Location = New System.Drawing.Point(483, 3)
        Me.btnPrintBills.Name = "btnPrintBills"
        Me.btnPrintBills.Size = New System.Drawing.Size(75, 26)
        Me.btnPrintBills.TabIndex = 0
        Me.btnPrintBills.Text = "Print Bills"
        Me.btnPrintBills.UseVisualStyleBackColor = False
        '
        'frmBillReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 495)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBillReport"
        Me.Text = "Bill Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvwGenList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lvwBills As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents btnPrintBills As Button
    Friend WithEvents btnPrintSelected As Button
    Friend WithEvents btnEditBill As Button
End Class
