<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddressList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddressList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddProv = New System.Windows.Forms.Button()
        Me.btnAddMun = New System.Windows.Forms.Button()
        Me.btnAddBrgy = New System.Windows.Forms.Button()
        Me.lvwProv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwMun = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelProv = New System.Windows.Forms.Button()
        Me.btnEditBrgy = New System.Windows.Forms.Button()
        Me.btnEditMun = New System.Windows.Forms.Button()
        Me.btnEditProv = New System.Windows.Forms.Button()
        Me.btnDelMun = New System.Windows.Forms.Button()
        Me.btnDelBrgy = New System.Windows.Forms.Button()
        Me.lvwBrgy = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwZone = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDeleteZone = New System.Windows.Forms.Button()
        Me.btnEditZone = New System.Windows.Forms.Button()
        Me.btnAddZone = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lvwCluster = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDeleteCluster = New System.Windows.Forms.Button()
        Me.btnEditCluster = New System.Windows.Forms.Button()
        Me.btnAddCluster = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Province"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Municipality"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(692, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Barangay"
        '
        'btnAddProv
        '
        Me.btnAddProv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProv.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddProv.Location = New System.Drawing.Point(80, 9)
        Me.btnAddProv.Name = "btnAddProv"
        Me.btnAddProv.Size = New System.Drawing.Size(33, 28)
        Me.btnAddProv.TabIndex = 6
        Me.btnAddProv.Text = "+"
        Me.btnAddProv.UseVisualStyleBackColor = True
        '
        'btnAddMun
        '
        Me.btnAddMun.Enabled = False
        Me.btnAddMun.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMun.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddMun.Location = New System.Drawing.Point(358, 9)
        Me.btnAddMun.Name = "btnAddMun"
        Me.btnAddMun.Size = New System.Drawing.Size(33, 28)
        Me.btnAddMun.TabIndex = 7
        Me.btnAddMun.Text = "+"
        Me.btnAddMun.UseVisualStyleBackColor = True
        '
        'btnAddBrgy
        '
        Me.btnAddBrgy.Enabled = False
        Me.btnAddBrgy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBrgy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddBrgy.Location = New System.Drawing.Point(762, 9)
        Me.btnAddBrgy.Name = "btnAddBrgy"
        Me.btnAddBrgy.Size = New System.Drawing.Size(33, 28)
        Me.btnAddBrgy.TabIndex = 8
        Me.btnAddBrgy.Text = "+"
        Me.btnAddBrgy.UseVisualStyleBackColor = True
        '
        'lvwProv
        '
        Me.lvwProv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwProv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwProv.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwProv.FullRowSelect = True
        Me.lvwProv.GridLines = True
        Me.lvwProv.HideSelection = False
        Me.lvwProv.Location = New System.Drawing.Point(15, 43)
        Me.lvwProv.MultiSelect = False
        Me.lvwProv.Name = "lvwProv"
        Me.lvwProv.Size = New System.Drawing.Size(249, 500)
        Me.lvwProv.TabIndex = 9
        Me.lvwProv.UseCompatibleStateImageBehavior = False
        Me.lvwProv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Default"
        Me.ColumnHeader1.Width = 61
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Province List"
        Me.ColumnHeader2.Width = 199
        '
        'lvwMun
        '
        Me.lvwMun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwMun.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwMun.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwMun.FullRowSelect = True
        Me.lvwMun.GridLines = True
        Me.lvwMun.HideSelection = False
        Me.lvwMun.Location = New System.Drawing.Point(270, 43)
        Me.lvwMun.MultiSelect = False
        Me.lvwMun.Name = "lvwMun"
        Me.lvwMun.Size = New System.Drawing.Size(186, 500)
        Me.lvwMun.TabIndex = 10
        Me.lvwMun.UseCompatibleStateImageBehavior = False
        Me.lvwMun.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Default"
        Me.ColumnHeader3.Width = 58
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Municipality List"
        Me.ColumnHeader4.Width = 120
        '
        'btnDelProv
        '
        Me.btnDelProv.BackgroundImage = Global.POSEIDON.My.Resources.Resources.trash
        Me.btnDelProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelProv.Enabled = False
        Me.btnDelProv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelProv.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDelProv.Location = New System.Drawing.Point(158, 9)
        Me.btnDelProv.Name = "btnDelProv"
        Me.btnDelProv.Size = New System.Drawing.Size(33, 28)
        Me.btnDelProv.TabIndex = 14
        Me.btnDelProv.UseVisualStyleBackColor = True
        '
        'btnEditBrgy
        '
        Me.btnEditBrgy.BackgroundImage = Global.POSEIDON.My.Resources.Resources.pencil
        Me.btnEditBrgy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditBrgy.Enabled = False
        Me.btnEditBrgy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBrgy.Location = New System.Drawing.Point(801, 9)
        Me.btnEditBrgy.Name = "btnEditBrgy"
        Me.btnEditBrgy.Size = New System.Drawing.Size(33, 28)
        Me.btnEditBrgy.TabIndex = 13
        Me.btnEditBrgy.UseVisualStyleBackColor = True
        '
        'btnEditMun
        '
        Me.btnEditMun.BackgroundImage = Global.POSEIDON.My.Resources.Resources.pencil
        Me.btnEditMun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditMun.Enabled = False
        Me.btnEditMun.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMun.Location = New System.Drawing.Point(397, 9)
        Me.btnEditMun.Name = "btnEditMun"
        Me.btnEditMun.Size = New System.Drawing.Size(33, 28)
        Me.btnEditMun.TabIndex = 12
        Me.btnEditMun.UseVisualStyleBackColor = True
        '
        'btnEditProv
        '
        Me.btnEditProv.BackgroundImage = Global.POSEIDON.My.Resources.Resources.pencil
        Me.btnEditProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditProv.Enabled = False
        Me.btnEditProv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProv.Location = New System.Drawing.Point(119, 9)
        Me.btnEditProv.Name = "btnEditProv"
        Me.btnEditProv.Size = New System.Drawing.Size(33, 28)
        Me.btnEditProv.TabIndex = 11
        Me.btnEditProv.UseVisualStyleBackColor = True
        '
        'btnDelMun
        '
        Me.btnDelMun.BackgroundImage = Global.POSEIDON.My.Resources.Resources.trash
        Me.btnDelMun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelMun.Enabled = False
        Me.btnDelMun.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelMun.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDelMun.Location = New System.Drawing.Point(436, 9)
        Me.btnDelMun.Name = "btnDelMun"
        Me.btnDelMun.Size = New System.Drawing.Size(33, 28)
        Me.btnDelMun.TabIndex = 15
        Me.btnDelMun.UseVisualStyleBackColor = True
        '
        'btnDelBrgy
        '
        Me.btnDelBrgy.BackgroundImage = Global.POSEIDON.My.Resources.Resources.trash
        Me.btnDelBrgy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelBrgy.Enabled = False
        Me.btnDelBrgy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelBrgy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDelBrgy.Location = New System.Drawing.Point(840, 9)
        Me.btnDelBrgy.Name = "btnDelBrgy"
        Me.btnDelBrgy.Size = New System.Drawing.Size(33, 28)
        Me.btnDelBrgy.TabIndex = 16
        Me.btnDelBrgy.UseVisualStyleBackColor = True
        '
        'lvwBrgy
        '
        Me.lvwBrgy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBrgy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader10, Me.ColumnHeader8})
        Me.lvwBrgy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwBrgy.FullRowSelect = True
        Me.lvwBrgy.GridLines = True
        Me.lvwBrgy.HideSelection = False
        Me.lvwBrgy.LabelEdit = True
        Me.lvwBrgy.Location = New System.Drawing.Point(709, 43)
        Me.lvwBrgy.MultiSelect = False
        Me.lvwBrgy.Name = "lvwBrgy"
        Me.lvwBrgy.Size = New System.Drawing.Size(387, 500)
        Me.lvwBrgy.TabIndex = 17
        Me.lvwBrgy.UseCompatibleStateImageBehavior = False
        Me.lvwBrgy.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Barangay"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Class"
        Me.ColumnHeader10.Width = 100
        '
        'lvwZone
        '
        Me.lvwZone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwZone.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7})
        Me.lvwZone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwZone.FullRowSelect = True
        Me.lvwZone.GridLines = True
        Me.lvwZone.HideSelection = False
        Me.lvwZone.Location = New System.Drawing.Point(462, 43)
        Me.lvwZone.MultiSelect = False
        Me.lvwZone.Name = "lvwZone"
        Me.lvwZone.Size = New System.Drawing.Size(241, 500)
        Me.lvwZone.TabIndex = 18
        Me.lvwZone.UseCompatibleStateImageBehavior = False
        Me.lvwZone.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Zone Name"
        Me.ColumnHeader7.Width = 237
        '
        'btnDeleteZone
        '
        Me.btnDeleteZone.BackgroundImage = Global.POSEIDON.My.Resources.Resources.trash
        Me.btnDeleteZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteZone.Enabled = False
        Me.btnDeleteZone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteZone.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDeleteZone.Location = New System.Drawing.Point(645, 9)
        Me.btnDeleteZone.Name = "btnDeleteZone"
        Me.btnDeleteZone.Size = New System.Drawing.Size(33, 28)
        Me.btnDeleteZone.TabIndex = 22
        Me.btnDeleteZone.UseVisualStyleBackColor = True
        '
        'btnEditZone
        '
        Me.btnEditZone.BackgroundImage = Global.POSEIDON.My.Resources.Resources.pencil
        Me.btnEditZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditZone.Enabled = False
        Me.btnEditZone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditZone.Location = New System.Drawing.Point(606, 9)
        Me.btnEditZone.Name = "btnEditZone"
        Me.btnEditZone.Size = New System.Drawing.Size(33, 28)
        Me.btnEditZone.TabIndex = 21
        Me.btnEditZone.UseVisualStyleBackColor = True
        '
        'btnAddZone
        '
        Me.btnAddZone.Enabled = False
        Me.btnAddZone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddZone.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddZone.Location = New System.Drawing.Point(567, 9)
        Me.btnAddZone.Name = "btnAddZone"
        Me.btnAddZone.Size = New System.Drawing.Size(33, 28)
        Me.btnAddZone.TabIndex = 20
        Me.btnAddZone.Text = "+"
        Me.btnAddZone.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Zone"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'lvwCluster
        '
        Me.lvwCluster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCluster.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader11})
        Me.lvwCluster.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCluster.FullRowSelect = True
        Me.lvwCluster.GridLines = True
        Me.lvwCluster.HideSelection = False
        Me.lvwCluster.LabelEdit = True
        Me.lvwCluster.Location = New System.Drawing.Point(1102, 43)
        Me.lvwCluster.MultiSelect = False
        Me.lvwCluster.Name = "lvwCluster"
        Me.lvwCluster.Size = New System.Drawing.Size(292, 500)
        Me.lvwCluster.TabIndex = 27
        Me.lvwCluster.UseCompatibleStateImageBehavior = False
        Me.lvwCluster.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Cluster Name"
        Me.ColumnHeader9.Width = 189
        '
        'btnDeleteCluster
        '
        Me.btnDeleteCluster.BackgroundImage = Global.POSEIDON.My.Resources.Resources.trash
        Me.btnDeleteCluster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteCluster.Enabled = False
        Me.btnDeleteCluster.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCluster.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDeleteCluster.Location = New System.Drawing.Point(1180, 9)
        Me.btnDeleteCluster.Name = "btnDeleteCluster"
        Me.btnDeleteCluster.Size = New System.Drawing.Size(33, 28)
        Me.btnDeleteCluster.TabIndex = 26
        Me.btnDeleteCluster.UseVisualStyleBackColor = True
        '
        'btnEditCluster
        '
        Me.btnEditCluster.BackgroundImage = Global.POSEIDON.My.Resources.Resources.pencil
        Me.btnEditCluster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditCluster.Enabled = False
        Me.btnEditCluster.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCluster.Location = New System.Drawing.Point(1141, 9)
        Me.btnEditCluster.Name = "btnEditCluster"
        Me.btnEditCluster.Size = New System.Drawing.Size(33, 28)
        Me.btnEditCluster.TabIndex = 25
        Me.btnEditCluster.UseVisualStyleBackColor = True
        '
        'btnAddCluster
        '
        Me.btnAddCluster.Enabled = False
        Me.btnAddCluster.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCluster.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAddCluster.Location = New System.Drawing.Point(1102, 9)
        Me.btnAddCluster.Name = "btnAddCluster"
        Me.btnAddCluster.Size = New System.Drawing.Size(33, 28)
        Me.btnAddCluster.TabIndex = 24
        Me.btnAddCluster.Text = "+"
        Me.btnAddCluster.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1032, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cluster"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Status"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Code"
        '
        'frmAddressList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 555)
        Me.Controls.Add(Me.lvwCluster)
        Me.Controls.Add(Me.btnDeleteCluster)
        Me.Controls.Add(Me.btnEditCluster)
        Me.Controls.Add(Me.btnAddCluster)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDeleteZone)
        Me.Controls.Add(Me.btnEditZone)
        Me.Controls.Add(Me.btnAddZone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvwZone)
        Me.Controls.Add(Me.lvwBrgy)
        Me.Controls.Add(Me.btnDelBrgy)
        Me.Controls.Add(Me.btnDelMun)
        Me.Controls.Add(Me.btnDelProv)
        Me.Controls.Add(Me.btnEditBrgy)
        Me.Controls.Add(Me.btnEditMun)
        Me.Controls.Add(Me.btnEditProv)
        Me.Controls.Add(Me.lvwMun)
        Me.Controls.Add(Me.lvwProv)
        Me.Controls.Add(Me.btnAddBrgy)
        Me.Controls.Add(Me.btnAddMun)
        Me.Controls.Add(Me.btnAddProv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddressList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Address List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddProv As System.Windows.Forms.Button
    Friend WithEvents btnAddMun As System.Windows.Forms.Button
    Friend WithEvents btnAddBrgy As System.Windows.Forms.Button
    Friend WithEvents lvwProv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMun As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEditProv As System.Windows.Forms.Button
    Friend WithEvents btnEditMun As System.Windows.Forms.Button
    Friend WithEvents btnEditBrgy As System.Windows.Forms.Button
    Friend WithEvents btnDelProv As System.Windows.Forms.Button
    Friend WithEvents btnDelMun As System.Windows.Forms.Button
    Friend WithEvents btnDelBrgy As System.Windows.Forms.Button
    Friend WithEvents lvwBrgy As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwZone As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDeleteZone As System.Windows.Forms.Button
    Friend WithEvents btnEditZone As System.Windows.Forms.Button
    Friend WithEvents btnAddZone As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lvwCluster As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents btnDeleteCluster As Button
    Friend WithEvents btnEditCluster As Button
    Friend WithEvents btnAddCluster As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
