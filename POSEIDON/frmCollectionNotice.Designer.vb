<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionNotice
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollectionNotice))
        Me.CollectionNoticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportingdataset = New POSEIDON.reportingdataset()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CollectionNoticeTableAdapter = New POSEIDON.reportingdatasetTableAdapters.CollectionNoticeTableAdapter()
        CType(Me.CollectionNoticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CollectionNoticeBindingSource
        '
        Me.CollectionNoticeBindingSource.DataMember = "CollectionNotice"
        Me.CollectionNoticeBindingSource.DataSource = Me.reportingdataset
        '
        'reportingdataset
        '
        Me.reportingdataset.DataSetName = "reportingdataset"
        Me.reportingdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CollectionNotice"
        ReportDataSource1.Value = Me.CollectionNoticeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POSEIDON.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(890, 489)
        Me.ReportViewer1.TabIndex = 0
        '
        'CollectionNoticeTableAdapter
        '
        Me.CollectionNoticeTableAdapter.ClearBeforeFill = True
        '
        'frmCollectionNotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 489)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCollectionNotice"
        Me.ShowIcon = False
        Me.Text = "Collection Notice"
        CType(Me.CollectionNoticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CollectionNoticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportingdataset As POSEIDON.reportingdataset
    Friend WithEvents CollectionNoticeTableAdapter As POSEIDON.reportingdatasetTableAdapters.CollectionNoticeTableAdapter
End Class
