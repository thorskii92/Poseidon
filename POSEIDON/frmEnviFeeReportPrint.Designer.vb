<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviFeeReportPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnviFeeReportPrint))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EnvironmentalReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New POSEIDON.ReportDataSet()
        Me.EnvironmentalReportTableAdapter = New POSEIDON.ReportDataSetTableAdapters.EnvironmentalReportTableAdapter()
        CType(Me.EnvironmentalReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "EnvironmentalFeeDataSet"
        ReportDataSource1.Value = Me.EnvironmentalReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POSEIDON.Report17.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(659, 418)
        Me.ReportViewer1.TabIndex = 0
        '
        'EnvironmentalReportBindingSource
        '
        Me.EnvironmentalReportBindingSource.DataMember = "EnvironmentalReport"
        Me.EnvironmentalReportBindingSource.DataSource = Me.ReportDataSet
        '
        'ReportDataSet
        '
        Me.ReportDataSet.DataSetName = "ReportDataSet"
        Me.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnvironmentalReportTableAdapter
        '
        Me.EnvironmentalReportTableAdapter.ClearBeforeFill = True
        '
        'frmEnviFeeReportPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 418)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEnviFeeReportPrint"
        Me.Text = "Environmental Fee Report Print View"
        CType(Me.EnvironmentalReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EnvironmentalReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As POSEIDON.ReportDataSet
    Friend WithEvents EnvironmentalReportTableAdapter As POSEIDON.ReportDataSetTableAdapters.EnvironmentalReportTableAdapter
End Class
