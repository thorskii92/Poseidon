<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmORReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmORReport))
        Me.ORReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ORDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportingdataset = New POSEIDON.reportingdataset()
        Me.ORDatasetTableAdapter = New POSEIDON.reportingdatasetTableAdapters.ORDatasetTableAdapter()
        Me.ORDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDataTableTableAdapter = New POSEIDON.reportingdatasetTableAdapters.ORDataTableTableAdapter()
        CType(Me.ORDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ORReport
        '
        Me.ORReport.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "OfficialReceiptData"
        ReportDataSource1.Value = Me.ORDataTableBindingSource
        Me.ORReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ORReport.LocalReport.ReportEmbeddedResource = "POSEIDON.Report8.rdlc"
        Me.ORReport.Location = New System.Drawing.Point(0, 0)
        Me.ORReport.Name = "ORReport"
        Me.ORReport.Size = New System.Drawing.Size(753, 594)
        Me.ORReport.TabIndex = 0
        '
        'ORDatasetBindingSource
        '
        Me.ORDatasetBindingSource.DataMember = "ORDataset"
        Me.ORDatasetBindingSource.DataSource = Me.reportingdataset
        '
        'reportingdataset
        '
        Me.reportingdataset.DataSetName = "reportingdataset"
        Me.reportingdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ORDatasetTableAdapter
        '
        Me.ORDatasetTableAdapter.ClearBeforeFill = True
        '
        'ORDataTableBindingSource
        '
        Me.ORDataTableBindingSource.DataMember = "ORDataTable"
        Me.ORDataTableBindingSource.DataSource = Me.reportingdataset
        '
        'ORDataTableTableAdapter
        '
        Me.ORDataTableTableAdapter.ClearBeforeFill = True
        '
        'frmORReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 594)
        Me.Controls.Add(Me.ORReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmORReport"
        Me.Text = "Print View Official Receipt"
        CType(Me.ORDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ORReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ORDatasetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportingdataset As POSEIDON.reportingdataset
    Friend WithEvents ORDatasetTableAdapter As POSEIDON.reportingdatasetTableAdapters.ORDatasetTableAdapter
    Friend WithEvents ORDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORDataTableTableAdapter As POSEIDON.reportingdatasetTableAdapters.ORDataTableTableAdapter
End Class
