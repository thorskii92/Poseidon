<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportExcel))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblFilePath = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnImport = New System.Windows.Forms.ToolStripButton()
        Me.cbo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCheckAccount = New System.Windows.Forms.ToolStripButton()
        Me.btnRecheck = New System.Windows.Forms.ToolStripButton()
        Me.opPath = New System.Windows.Forms.OpenFileDialog()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.prb = New System.Windows.Forms.ToolStripProgressBar()
        Me.lbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblImp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1924, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(198, 22)
        Me.ToolStripLabel1.Text = "Import Accounts from Excel"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.lblFilePath, Me.ToolStripButton1, Me.btnImport, Me.cbo, Me.ToolStripLabel3, Me.btnSave, Me.btnCheckAccount, Me.btnRecheck})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1924, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabel2.Text = "Path"
        '
        'lblFilePath
        '
        Me.lblFilePath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.ReadOnly = True
        Me.lblFilePath.Size = New System.Drawing.Size(400, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "..."
        '
        'btnImport
        '
        Me.btnImport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnImport.Enabled = False
        Me.btnImport.ForeColor = System.Drawing.Color.White
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(74, 22)
        Me.btnImport.Text = "Start Import"
        '
        'cbo
        '
        Me.cbo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbo.Name = "cbo"
        Me.cbo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel3.Text = "Worksheet"
        '
        'btnSave
        '
        Me.btnSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Enabled = False
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 22)
        Me.btnSave.Text = "Save"
        '
        'btnCheckAccount
        '
        Me.btnCheckAccount.BackColor = System.Drawing.Color.Gray
        Me.btnCheckAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCheckAccount.Image = CType(resources.GetObject("btnCheckAccount.Image"), System.Drawing.Image)
        Me.btnCheckAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAccount.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.btnCheckAccount.Name = "btnCheckAccount"
        Me.btnCheckAccount.Size = New System.Drawing.Size(92, 22)
        Me.btnCheckAccount.Text = "Check Account"
        '
        'btnRecheck
        '
        Me.btnRecheck.BackColor = System.Drawing.Color.Gray
        Me.btnRecheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRecheck.Image = CType(resources.GetObject("btnRecheck.Image"), System.Drawing.Image)
        Me.btnRecheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRecheck.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.btnRecheck.Name = "btnRecheck"
        Me.btnRecheck.Size = New System.Drawing.Size(116, 22)
        Me.btnRecheck.Text = "Recheck Availability"
        '
        'opPath
        '
        Me.opPath.FileName = "Excel Path Selection"
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader27})
        Me.lvw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvw.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.HideSelection = False
        Me.lvw.Location = New System.Drawing.Point(0, 50)
        Me.lvw.MultiSelect = False
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(1924, 373)
        Me.lvw.TabIndex = 2
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account Code"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cluster"
        Me.ColumnHeader3.Width = 200
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prb, Me.lbl, Me.lblImp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 423)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1924, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'prb
        '
        Me.prb.Name = "prb"
        Me.prb.Size = New System.Drawing.Size(100, 16)
        Me.prb.Visible = False
        '
        'lbl
        '
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(112, 17)
        Me.lbl.Text = "Imported Accounts:"
        '
        'lblImp
        '
        Me.lblImp.Name = "lblImp"
        Me.lblImp.Size = New System.Drawing.Size(13, 17)
        Me.lblImp.Text = "0"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cluster ID"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Barangay"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Barangay ID"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Standpipe"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Category"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "ClassID"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Connection Date"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Meter No"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Reading"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Status"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "SC/PWD"
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Availability"
        '
        'frmImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 445)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImportExcel"
        Me.Text = "Import Excel"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblFilePath As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents opPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnImport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents prb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblImp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnCheckAccount As ToolStripButton
    Friend WithEvents btnRecheck As ToolStripButton
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
End Class
