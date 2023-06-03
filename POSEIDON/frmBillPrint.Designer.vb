<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillPrint))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BillNoticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportingdataset = New POSEIDON.reportingdataset()
        Me.CollectionNoticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollectionNoticeTableAdapter = New POSEIDON.reportingdatasetTableAdapters.CollectionNoticeTableAdapter()
        Me.BillNoticeTableAdapter = New POSEIDON.reportingdatasetTableAdapters.BillNoticeTableAdapter()
        CType(Me.BillNoticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectionNoticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BillDataSet"
        ReportDataSource1.Value = Me.BillNoticeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POSEIDON.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(809, 411)
        Me.ReportViewer1.TabIndex = 0
        '
        'BillNoticeBindingSource
        '
        Me.BillNoticeBindingSource.DataMember = "BillNotice"
        Me.BillNoticeBindingSource.DataSource = Me.reportingdataset
        '
        'reportingdataset
        '
        Me.reportingdataset.DataSetName = "reportingdataset"
        Me.reportingdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CollectionNoticeBindingSource
        '
        Me.CollectionNoticeBindingSource.DataMember = "CollectionNotice"
        Me.CollectionNoticeBindingSource.DataSource = Me.reportingdataset
        '
        'CollectionNoticeTableAdapter
        '
        Me.CollectionNoticeTableAdapter.ClearBeforeFill = True
        '
        'BillNoticeTableAdapter
        '
        Me.BillNoticeTableAdapter.ClearBeforeFill = True
        '
        'frmBillPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 411)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBillPrint"
        Me.Text = "Print Bills"
        CType(Me.BillNoticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectionNoticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CollectionNoticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportingdataset As POSEIDON.reportingdataset
    Friend WithEvents CollectionNoticeTableAdapter As POSEIDON.reportingdatasetTableAdapters.CollectionNoticeTableAdapter
    Friend WithEvents BillNoticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillNoticeTableAdapter As POSEIDON.reportingdatasetTableAdapters.BillNoticeTableAdapter
End Class
