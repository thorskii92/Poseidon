<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyReportDataGridViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthlyReportDataGridViewer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cboYear = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvMRep = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.January = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.February = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.March = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.April = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.May = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.June = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.July = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.August = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.September = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.October = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.November = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.December = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cboYear, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1074, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.Margin = New System.Windows.Forms.Padding(20, 5, 1, 0)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 34)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(5, 10, 0, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(58, 27)
        Me.ToolStripButton1.Text = "Generate"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvMRep)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 698)
        Me.Panel1.TabIndex = 1
        '
        'dgvMRep
        '
        Me.dgvMRep.AllowUserToAddRows = False
        Me.dgvMRep.AllowUserToDeleteRows = False
        Me.dgvMRep.AllowUserToResizeRows = False
        Me.dgvMRep.BackgroundColor = System.Drawing.Color.White
        Me.dgvMRep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMRep.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMRep.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.January, Me.February, Me.March, Me.April, Me.May, Me.June, Me.July, Me.August, Me.September, Me.October, Me.November, Me.December})
        Me.dgvMRep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMRep.Location = New System.Drawing.Point(0, 0)
        Me.dgvMRep.Name = "dgvMRep"
        Me.dgvMRep.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMRep.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMRep.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMRep.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMRep.Size = New System.Drawing.Size(1074, 698)
        Me.dgvMRep.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'January
        '
        Me.January.HeaderText = "January"
        Me.January.Name = "January"
        Me.January.ReadOnly = True
        Me.January.Width = 120
        '
        'February
        '
        Me.February.HeaderText = "February"
        Me.February.Name = "February"
        Me.February.ReadOnly = True
        Me.February.Width = 120
        '
        'March
        '
        Me.March.HeaderText = "March"
        Me.March.Name = "March"
        Me.March.ReadOnly = True
        Me.March.Width = 120
        '
        'April
        '
        Me.April.HeaderText = "April"
        Me.April.Name = "April"
        Me.April.ReadOnly = True
        Me.April.Width = 120
        '
        'May
        '
        Me.May.HeaderText = "May"
        Me.May.Name = "May"
        Me.May.ReadOnly = True
        Me.May.Width = 120
        '
        'June
        '
        Me.June.HeaderText = "June"
        Me.June.Name = "June"
        Me.June.ReadOnly = True
        Me.June.Width = 120
        '
        'July
        '
        Me.July.HeaderText = "July"
        Me.July.Name = "July"
        Me.July.ReadOnly = True
        Me.July.Width = 120
        '
        'August
        '
        Me.August.HeaderText = "August"
        Me.August.Name = "August"
        Me.August.ReadOnly = True
        Me.August.Width = 120
        '
        'September
        '
        Me.September.HeaderText = "September"
        Me.September.Name = "September"
        Me.September.ReadOnly = True
        Me.September.Width = 120
        '
        'October
        '
        Me.October.HeaderText = "October"
        Me.October.Name = "October"
        Me.October.ReadOnly = True
        Me.October.Width = 120
        '
        'November
        '
        Me.November.HeaderText = "November"
        Me.November.Name = "November"
        Me.November.ReadOnly = True
        Me.November.Width = 120
        '
        'December
        '
        Me.December.HeaderText = "December"
        Me.December.Name = "December"
        Me.December.ReadOnly = True
        Me.December.Width = 120
        '
        'frmMonthlyReportDataGridViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 737)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMonthlyReportDataGridViewer"
        Me.Text = "Monthly Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvMRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cboYear As ToolStripComboBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvMRep As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents January As DataGridViewTextBoxColumn
    Friend WithEvents February As DataGridViewTextBoxColumn
    Friend WithEvents March As DataGridViewTextBoxColumn
    Friend WithEvents April As DataGridViewTextBoxColumn
    Friend WithEvents May As DataGridViewTextBoxColumn
    Friend WithEvents June As DataGridViewTextBoxColumn
    Friend WithEvents July As DataGridViewTextBoxColumn
    Friend WithEvents August As DataGridViewTextBoxColumn
    Friend WithEvents September As DataGridViewTextBoxColumn
    Friend WithEvents October As DataGridViewTextBoxColumn
    Friend WithEvents November As DataGridViewTextBoxColumn
    Friend WithEvents December As DataGridViewTextBoxColumn
End Class
