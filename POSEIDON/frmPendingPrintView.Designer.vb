﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendingPrintView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPendingPrintView))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PendingListDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New POSEIDON.ReportDataSet()
        Me.PendingListDataSetTableAdapter = New POSEIDON.ReportDataSetTableAdapters.PendingListDataSetTableAdapter()
        CType(Me.PendingListDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PendingDataSet"
        ReportDataSource1.Value = Me.PendingListDataSetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POSEIDON.Report18.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(851, 452)
        Me.ReportViewer1.TabIndex = 0
        '
        'PendingListDataSetBindingSource
        '
        Me.PendingListDataSetBindingSource.DataMember = "PendingListDataSet"
        Me.PendingListDataSetBindingSource.DataSource = Me.ReportDataSet
        '
        'ReportDataSet
        '
        Me.ReportDataSet.DataSetName = "ReportDataSet"
        Me.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PendingListDataSetTableAdapter
        '
        Me.PendingListDataSetTableAdapter.ClearBeforeFill = True
        '
        'frmPendingPrintView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 452)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPendingPrintView"
        Me.Text = "Pending List"
        CType(Me.PendingListDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PendingListDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As POSEIDON.ReportDataSet
    Friend WithEvents PendingListDataSetTableAdapter As POSEIDON.ReportDataSetTableAdapters.PendingListDataSetTableAdapter
End Class
