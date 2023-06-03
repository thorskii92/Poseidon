<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUncollectiblesReport
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
        Me.lvwUncollectibles = New System.Windows.Forms.ListView()
        Me.cboCluster = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwUncollectibles
        '
        Me.lvwUncollectibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwUncollectibles.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUncollectibles.Location = New System.Drawing.Point(12, 68)
        Me.lvwUncollectibles.Name = "lvwUncollectibles"
        Me.lvwUncollectibles.Size = New System.Drawing.Size(1179, 585)
        Me.lvwUncollectibles.TabIndex = 0
        Me.lvwUncollectibles.UseCompatibleStateImageBehavior = False
        Me.lvwUncollectibles.View = System.Windows.Forms.View.Details
        '
        'cboCluster
        '
        Me.cboCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCluster.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCluster.FormattingEnabled = True
        Me.cboCluster.Location = New System.Drawing.Point(373, 31)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(248, 31)
        Me.cboCluster.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cluster"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Barangay"
        '
        'cboBrgy
        '
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(93, 31)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(212, 31)
        Me.cboBrgy.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Month"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(712, 31)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(177, 31)
        Me.cboMonth.TabIndex = 6
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(957, 31)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(177, 31)
        Me.cboYear.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(913, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Year"
        '
        'frmUncollectiblesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 665)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboBrgy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCluster)
        Me.Controls.Add(Me.lvwUncollectibles)
        Me.Name = "frmUncollectiblesReport"
        Me.Text = "Uncollectibles Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwUncollectibles As ListView
    Friend WithEvents cboCluster As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboBrgy As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label4 As Label
End Class
