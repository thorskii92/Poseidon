<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSequencing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSequencing))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboBarangay = New System.Windows.Forms.ComboBox()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.cboMunicipality = New System.Windows.Forms.ComboBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lvwSeq = New System.Windows.Forms.ListView()
        Me.clmSeq = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCurSeq = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNewSeqNum = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSet = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboBarangay)
        Me.Panel1.Controls.Add(Me.cboZone)
        Me.Panel1.Controls.Add(Me.cboMunicipality)
        Me.Panel1.Controls.Add(Me.cboProvince)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 587)
        Me.Panel1.TabIndex = 0
        '
        'cboBarangay
        '
        Me.cboBarangay.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarangay.FormattingEnabled = True
        Me.cboBarangay.Location = New System.Drawing.Point(12, 187)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(209, 27)
        Me.cboBarangay.TabIndex = 10
        '
        'cboZone
        '
        Me.cboZone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(12, 135)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(209, 27)
        Me.cboZone.TabIndex = 9
        '
        'cboMunicipality
        '
        Me.cboMunicipality.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMunicipality.FormattingEnabled = True
        Me.cboMunicipality.Location = New System.Drawing.Point(12, 83)
        Me.cboMunicipality.Name = "cboMunicipality"
        Me.cboMunicipality.Size = New System.Drawing.Size(209, 27)
        Me.cboMunicipality.TabIndex = 8
        '
        'cboProvince
        '
        Me.cboProvince.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(12, 31)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(209, 27)
        Me.cboProvince.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Barangay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Zone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Municipality"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Province"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lvwSeq)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(229, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 587)
        Me.Panel2.TabIndex = 1
        '
        'lvwSeq
        '
        Me.lvwSeq.AllowDrop = True
        Me.lvwSeq.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmSeq, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwSeq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSeq.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwSeq.FullRowSelect = True
        Me.lvwSeq.GridLines = True
        Me.lvwSeq.HideSelection = False
        Me.lvwSeq.Location = New System.Drawing.Point(0, 38)
        Me.lvwSeq.MultiSelect = False
        Me.lvwSeq.Name = "lvwSeq"
        Me.lvwSeq.Size = New System.Drawing.Size(988, 549)
        Me.lvwSeq.TabIndex = 3
        Me.lvwSeq.UseCompatibleStateImageBehavior = False
        Me.lvwSeq.View = System.Windows.Forms.View.Details
        '
        'clmSeq
        '
        Me.clmSeq.Text = "Sequence #"
        Me.clmSeq.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account Number"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Consumer Name"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Street Address"
        Me.ColumnHeader3.Width = 500
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "AcctID"
        Me.ColumnHeader4.Width = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtCurSeq, Me.ToolStripLabel2, Me.txtNewSeqNum, Me.btnSet})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 38)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 28)
        Me.ToolStripLabel1.Text = "Sequence #"
        '
        'txtCurSeq
        '
        Me.txtCurSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurSeq.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.txtCurSeq.Name = "txtCurSeq"
        Me.txtCurSeq.ReadOnly = True
        Me.txtCurSeq.Size = New System.Drawing.Size(100, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(87, 35)
        Me.ToolStripLabel2.Text = "Set Sequence #"
        '
        'txtNewSeqNum
        '
        Me.txtNewSeqNum.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.txtNewSeqNum.Name = "txtNewSeqNum"
        Me.txtNewSeqNum.Size = New System.Drawing.Size(100, 28)
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Image = CType(resources.GetObject("btnSet.Image"), System.Drawing.Image)
        Me.btnSet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSet.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSet.Size = New System.Drawing.Size(39, 28)
        Me.btnSet.Text = "SET"
        '
        'frmSequencing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSequencing"
        Me.Text = "Sequence Setter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCurSeq As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lvwSeq As System.Windows.Forms.ListView
    Friend WithEvents clmSeq As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNewSeqNum As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnSet As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBarangay As System.Windows.Forms.ComboBox
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboMunicipality As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
