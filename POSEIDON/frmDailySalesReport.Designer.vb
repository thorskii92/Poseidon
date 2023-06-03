<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailySalesReport))
        Me.rpvDaily = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DailyTransactionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New POSEIDON.ReportDataSet()
        Me.DailyTransactionDataSetTableAdapter = New POSEIDON.ReportDataSetTableAdapters.DailyTransactionDataSetTableAdapter()
        CType(Me.DailyTransactionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvDaily
        '
        Me.rpvDaily.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DailyTransaction"
        ReportDataSource1.Value = Me.DailyTransactionDataSetBindingSource
        Me.rpvDaily.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvDaily.LocalReport.ReportEmbeddedResource = "POSEIDON.Report9.rdlc"
        Me.rpvDaily.Location = New System.Drawing.Point(0, 0)
        Me.rpvDaily.Margin = New System.Windows.Forms.Padding(4)
        Me.rpvDaily.Name = "rpvDaily"
        Me.rpvDaily.Size = New System.Drawing.Size(1023, 528)
        Me.rpvDaily.TabIndex = 0
        '
        'DailyTransactionDataSetBindingSource
        '
        Me.DailyTransactionDataSetBindingSource.DataMember = "DailyTransactionDataSet"
        Me.DailyTransactionDataSetBindingSource.DataSource = Me.ReportDataSet
        '
        'ReportDataSet
        '
        Me.ReportDataSet.DataSetName = "ReportDataSet"
        Me.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DailyTransactionDataSetTableAdapter
        '
        Me.DailyTransactionDataSetTableAdapter.ClearBeforeFill = True
        '
        'frmDailySalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 528)
        Me.Controls.Add(Me.rpvDaily)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDailySalesReport"
        Me.Text = "Daily Sales Report"
        CType(Me.DailyTransactionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvDaily As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DailyTransactionDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As POSEIDON.ReportDataSet
    Friend WithEvents DailyTransactionDataSetTableAdapter As POSEIDON.ReportDataSetTableAdapters.DailyTransactionDataSetTableAdapter
End Class
