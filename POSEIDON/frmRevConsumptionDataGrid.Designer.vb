<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevConsumptionDataGrid
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
        Me.dgvRev = New System.Windows.Forms.DataGridView()
        Me.brgyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddBrgy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResCub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsCub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComCub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndCub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billMonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRev
        '
        Me.dgvRev.AllowUserToAddRows = False
        Me.dgvRev.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRev.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRev.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.brgyID, Me.AddBrgy, Me.PlantName, Me.ResCub, Me.ResAmount, Me.InsCub, Me.InsAmount, Me.ComCub, Me.ComAmount, Me.IndCub, Me.IndAmount, Me.billMonth, Me.billYear})
        Me.dgvRev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRev.Location = New System.Drawing.Point(0, 0)
        Me.dgvRev.Name = "dgvRev"
        Me.dgvRev.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRev.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRev.Size = New System.Drawing.Size(1236, 763)
        Me.dgvRev.TabIndex = 0
        '
        'brgyID
        '
        Me.brgyID.HeaderText = "brgyID"
        Me.brgyID.Name = "brgyID"
        '
        'AddBrgy
        '
        Me.AddBrgy.HeaderText = "Barangay"
        Me.AddBrgy.Name = "AddBrgy"
        '
        'PlantName
        '
        Me.PlantName.HeaderText = "Plant Name"
        Me.PlantName.Name = "PlantName"
        '
        'ResCub
        '
        Me.ResCub.HeaderText = "Cubic - RES"
        Me.ResCub.Name = "ResCub"
        '
        'ResAmount
        '
        Me.ResAmount.HeaderText = "Amount - RES"
        Me.ResAmount.Name = "ResAmount"
        '
        'InsCub
        '
        Me.InsCub.HeaderText = "Cubic - INS"
        Me.InsCub.Name = "InsCub"
        '
        'InsAmount
        '
        Me.InsAmount.HeaderText = "Amount - INS"
        Me.InsAmount.Name = "InsAmount"
        '
        'ComCub
        '
        Me.ComCub.HeaderText = "Cubic - COM"
        Me.ComCub.Name = "ComCub"
        '
        'ComAmount
        '
        Me.ComAmount.HeaderText = "Amount - COM"
        Me.ComAmount.Name = "ComAmount"
        '
        'IndCub
        '
        Me.IndCub.HeaderText = "Cubic - IND"
        Me.IndCub.Name = "IndCub"
        '
        'IndAmount
        '
        Me.IndAmount.HeaderText = "Amount - IND"
        Me.IndAmount.Name = "IndAmount"
        '
        'billMonth
        '
        Me.billMonth.HeaderText = "Month"
        Me.billMonth.Name = "billMonth"
        '
        'billYear
        '
        Me.billYear.HeaderText = "Year"
        Me.billYear.Name = "billYear"
        '
        'frmRevConsumptionDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 763)
        Me.Controls.Add(Me.dgvRev)
        Me.Name = "frmRevConsumptionDataGrid"
        Me.Text = "Revenue From Consumption Data View"
        CType(Me.dgvRev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRev As DataGridView
    Friend WithEvents brgyID As DataGridViewTextBoxColumn
    Friend WithEvents AddBrgy As DataGridViewTextBoxColumn
    Friend WithEvents PlantName As DataGridViewTextBoxColumn
    Friend WithEvents ResCub As DataGridViewTextBoxColumn
    Friend WithEvents ResAmount As DataGridViewTextBoxColumn
    Friend WithEvents InsCub As DataGridViewTextBoxColumn
    Friend WithEvents InsAmount As DataGridViewTextBoxColumn
    Friend WithEvents ComCub As DataGridViewTextBoxColumn
    Friend WithEvents ComAmount As DataGridViewTextBoxColumn
    Friend WithEvents IndCub As DataGridViewTextBoxColumn
    Friend WithEvents IndAmount As DataGridViewTextBoxColumn
    Friend WithEvents billMonth As DataGridViewTextBoxColumn
    Friend WithEvents billYear As DataGridViewTextBoxColumn
End Class
