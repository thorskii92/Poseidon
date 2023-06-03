<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlySalesReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonthlySalesReportViewer))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MonthlySalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New POSEIDON.ReportDataSet()
        Me.MonthlySalesTableAdapter = New POSEIDON.ReportDataSetTableAdapters.MonthlySalesTableAdapter()
        CType(Me.MonthlySalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "monthlysalesdataset"
        ReportDataSource1.Value = Me.MonthlySalesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POSEIDON.Report12.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(557, 394)
        Me.ReportViewer1.TabIndex = 0
        '
        'MonthlySalesBindingSource
        '
        Me.MonthlySalesBindingSource.DataMember = "MonthlySales"
        Me.MonthlySalesBindingSource.DataSource = Me.ReportDataSet
        '
        'ReportDataSet
        '
        Me.ReportDataSet.DataSetName = "ReportDataSet"
        Me.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MonthlySalesTableAdapter
        '
        Me.MonthlySalesTableAdapter.ClearBeforeFill = True
        '
        'frmMonthlySalesReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 394)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMonthlySalesReportViewer"
        Me.Text = "Monthly Sales Report"
        CType(Me.MonthlySalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MonthlySalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As POSEIDON.ReportDataSet
    Friend WithEvents MonthlySalesTableAdapter As POSEIDON.ReportDataSetTableAdapters.MonthlySalesTableAdapter
End Class
