<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSOAMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.lblYear = New System.Windows.Forms.ToolStripLabel()
        Me.cboYear = New System.Windows.Forms.ToolStripComboBox()
        Me.lblMonthFrom = New System.Windows.Forms.ToolStripLabel()
        Me.cboMonthFrom = New System.Windows.Forms.ToolStripComboBox()
        Me.lblYearFrom = New System.Windows.Forms.ToolStripLabel()
        Me.cboYearFrom = New System.Windows.Forms.ToolStripComboBox()
        Me.lblMonthTo = New System.Windows.Forms.ToolStripLabel()
        Me.cboMonthTo = New System.Windows.Forms.ToolStripComboBox()
        Me.lblYearTo = New System.Windows.Forms.ToolStripLabel()
        Me.cboYearTo = New System.Windows.Forms.ToolStripComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblName = New System.Windows.Forms.ToolStripLabel()
        Me.lblConsumerName = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblAccountNo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboFilter, Me.lblYear, Me.cboYear, Me.lblMonthFrom, Me.cboMonthFrom, Me.lblYearFrom, Me.cboYearFrom, Me.lblMonthTo, Me.cboMonthTo, Me.lblYearTo, Me.cboYearTo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1297, 26)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 23)
        Me.ToolStripLabel1.Text = "Select By:"
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilter.Items.AddRange(New Object() {"Full Statement", "Annual", "Range of Months"})
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(200, 26)
        '
        'lblYear
        '
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(79, 23)
        Me.lblYear.Text = "Select Year:"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 26)
        '
        'lblMonthFrom
        '
        Me.lblMonthFrom.Name = "lblMonthFrom"
        Me.lblMonthFrom.Size = New System.Drawing.Size(84, 23)
        Me.lblMonthFrom.Text = "Month From"
        '
        'cboMonthFrom
        '
        Me.cboMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthFrom.Name = "cboMonthFrom"
        Me.cboMonthFrom.Size = New System.Drawing.Size(121, 26)
        '
        'lblYearFrom
        '
        Me.lblYearFrom.Name = "lblYearFrom"
        Me.lblYearFrom.Size = New System.Drawing.Size(34, 23)
        Me.lblYearFrom.Text = "Year"
        '
        'cboYearFrom
        '
        Me.cboYearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearFrom.Name = "cboYearFrom"
        Me.cboYearFrom.Size = New System.Drawing.Size(121, 26)
        '
        'lblMonthTo
        '
        Me.lblMonthTo.Name = "lblMonthTo"
        Me.lblMonthTo.Size = New System.Drawing.Size(66, 23)
        Me.lblMonthTo.Text = "Month To"
        '
        'cboMonthTo
        '
        Me.cboMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthTo.Name = "cboMonthTo"
        Me.cboMonthTo.Size = New System.Drawing.Size(121, 26)
        '
        'lblYearTo
        '
        Me.lblYearTo.Name = "lblYearTo"
        Me.lblYearTo.Size = New System.Drawing.Size(34, 23)
        Me.lblYearTo.Text = "Year"
        '
        'cboYearTo
        '
        Me.cboYearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearTo.Name = "cboYearTo"
        Me.cboYearTo.Size = New System.Drawing.Size(121, 26)
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1297, 732)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblName, Me.lblConsumerName, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblAccountNo})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1297, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblName
        '
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 22)
        Me.lblName.Text = "Name:"
        '
        'lblConsumerName
        '
        Me.lblConsumerName.Name = "lblConsumerName"
        Me.lblConsumerName.Size = New System.Drawing.Size(39, 22)
        Me.lblConsumerName.Text = "Name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripLabel2.Text = "Account No.:"
        '
        'lblAccountNo
        '
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Size = New System.Drawing.Size(68, 22)
        Me.lblAccountNo.Text = "AccountNo"
        '
        'frmSOAMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 783)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSOAMenu"
        Me.Text = "Menu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboFilter As ToolStripComboBox
    Friend WithEvents lblYear As ToolStripLabel
    Friend WithEvents cboYear As ToolStripComboBox
    Friend WithEvents lblMonthFrom As ToolStripLabel
    Friend WithEvents cboMonthFrom As ToolStripComboBox
    Friend WithEvents lblYearFrom As ToolStripLabel
    Friend WithEvents cboYearFrom As ToolStripComboBox
    Friend WithEvents lblMonthTo As ToolStripLabel
    Friend WithEvents cboMonthTo As ToolStripComboBox
    Friend WithEvents lblYearTo As ToolStripLabel
    Friend WithEvents cboYearTo As ToolStripComboBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lblName As ToolStripLabel
    Friend WithEvents lblConsumerName As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblAccountNo As ToolStripLabel
End Class
