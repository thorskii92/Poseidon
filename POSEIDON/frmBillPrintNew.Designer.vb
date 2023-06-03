<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillPrintNew
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
        Me.BillNoticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reportingdataset = New POSEIDON.reportingdataset()
        Me.BillNoticeTableAdapter = New POSEIDON.reportingdatasetTableAdapters.BillNoticeTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.BillNoticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BillNoticeTableAdapter
        '
        Me.BillNoticeTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BillData"
        ReportDataSource1.Value = Me.BillNoticeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POSEIDON.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1065, 443)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmBillPrintNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 443)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmBillPrintNew"
        Me.Text = "Print Bill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BillNoticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportingdataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BillNoticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents reportingdataset As POSEIDON.reportingdataset
    Friend WithEvents BillNoticeTableAdapter As POSEIDON.reportingdatasetTableAdapters.BillNoticeTableAdapter
    Public WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
