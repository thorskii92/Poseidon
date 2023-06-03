<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultipleBillEditor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultipleBillEditor))
        Me.dgvBills = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFilterType = New System.Windows.Forms.ToolStripComboBox()
        Me.lblBarangay = New System.Windows.Forms.ToolStripLabel()
        Me.cboBarangay = New System.Windows.Forms.ToolStripComboBox()
        Me.lblMonth = New System.Windows.Forms.ToolStripLabel()
        Me.cboMonths = New System.Windows.Forms.ToolStripComboBox()
        Me.lblYear = New System.Windows.Forms.ToolStripLabel()
        Me.cboYear = New System.Windows.Forms.ToolStripComboBox()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnGenerate = New System.Windows.Forms.ToolStripButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBills
        '
        Me.dgvBills.AllowUserToAddRows = False
        Me.dgvBills.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBills.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column15, Me.Column14, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column26, Me.Column27, Me.Column28})
        Me.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBills.Location = New System.Drawing.Point(0, 25)
        Me.dgvBills.Name = "dgvBills"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBills.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBills.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBills.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBills.Size = New System.Drawing.Size(1254, 719)
        Me.dgvBills.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboFilterType, Me.lblBarangay, Me.cboBarangay, Me.lblMonth, Me.cboMonths, Me.lblYear, Me.cboYear, Me.lblSearch, Me.txtSearch, Me.btnGenerate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1254, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "Filter By:"
        '
        'cboFilterType
        '
        Me.cboFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterType.Items.AddRange(New Object() {"None", "Amount", "Barangay", "Month", "Name"})
        Me.cboFilterType.Name = "cboFilterType"
        Me.cboFilterType.Size = New System.Drawing.Size(121, 25)
        '
        'lblBarangay
        '
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(69, 22)
        Me.lblBarangay.Text = "Barangay"
        Me.lblBarangay.Visible = False
        '
        'cboBarangay
        '
        Me.cboBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBarangay.Items.AddRange(New Object() {"None", "Amount", "Barangay", "Month", "Name"})
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(121, 25)
        Me.cboBarangay.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(51, 22)
        Me.lblMonth.Text = "Month"
        Me.lblMonth.Visible = False
        '
        'cboMonths
        '
        Me.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonths.Items.AddRange(New Object() {"None", "Amount", "Barangay", "Month", "Name"})
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(121, 25)
        Me.cboMonths.Visible = False
        '
        'lblYear
        '
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(38, 22)
        Me.lblYear.Text = "Year"
        Me.lblYear.Visible = False
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Items.AddRange(New Object() {"None", "Amount", "Barangay", "Month", "Name"})
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 25)
        Me.cboYear.Visible = False
        '
        'lblSearch
        '
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(54, 22)
        Me.lblSearch.Text = "Search"
        Me.lblSearch.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 25)
        Me.txtSearch.Visible = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(72, 22)
        Me.btnGenerate.Text = "Generate"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account No"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 280
        '
        'Column3
        '
        Me.Column3.HeaderText = "Classification"
        Me.Column3.Items.AddRange(New Object() {"Residential", "Institutional", "Government", "Commercial", "Industrial"})
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "Account Type"
        Me.Column4.Items.AddRange(New Object() {"Regular", "SC/PWD"})
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "Street Address"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Barangay"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Reading Date"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Billing Date"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Due Date"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Period From"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Period To"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Billing Month"
        Me.Column12.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "Ocotber", "November", "December"})
        Me.Column12.Name = "Column12"
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column13
        '
        Me.Column13.HeaderText = "Billing Year"
        Me.Column13.Name = "Column13"
        '
        'Column15
        '
        Me.Column15.HeaderText = "Previous Reading"
        Me.Column15.Name = "Column15"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Present Reading"
        Me.Column14.Name = "Column14"
        '
        'Column16
        '
        Me.Column16.HeaderText = "Consumption"
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.HeaderText = "WSF"
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.HeaderText = "EF"
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        Me.Column19.HeaderText = "Discount"
        Me.Column19.Name = "Column19"
        '
        'Column20
        '
        Me.Column20.HeaderText = "Amount"
        Me.Column20.Name = "Column20"
        '
        'Column21
        '
        Me.Column21.HeaderText = "Penalty"
        Me.Column21.Name = "Column21"
        '
        'Column22
        '
        Me.Column22.HeaderText = "Amount After Due"
        Me.Column22.Name = "Column22"
        '
        'Column26
        '
        Me.Column26.HeaderText = "Previous Amount"
        Me.Column26.Name = "Column26"
        '
        'Column27
        '
        Me.Column27.HeaderText = "Previous Penalty"
        Me.Column27.Name = "Column27"
        '
        'Column28
        '
        Me.Column28.HeaderText = "Previous Total"
        Me.Column28.Name = "Column28"
        '
        'frmMultipleBillEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 744)
        Me.Controls.Add(Me.dgvBills)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMultipleBillEditor"
        Me.Text = "Multiple Bill Editor"
        CType(Me.dgvBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBills As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboFilterType As ToolStripComboBox
    Friend WithEvents cboBarangay As ToolStripComboBox
    Friend WithEvents cboMonths As ToolStripComboBox
    Friend WithEvents cboYear As ToolStripComboBox
    Friend WithEvents btnGenerate As ToolStripButton
    Friend WithEvents lblBarangay As ToolStripLabel
    Friend WithEvents lblMonth As ToolStripLabel
    Friend WithEvents lblYear As ToolStripLabel
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents lblSearch As ToolStripLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewComboBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
End Class
