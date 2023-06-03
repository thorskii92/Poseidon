Imports System.ComponentModel

Public Class frmORReport

    Private Sub frmORReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'reportingdataset.ORDataTable' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'reportingdataset.ORDataset' table. You can move, or remove it, as needed.
        'Me.ORDatasetTableAdapter.Fill(Me.reportingdataset.ORDataset)

        Me.ORReport.RefreshReport()
    End Sub

    Private Sub frmORReport_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged

    End Sub

    Private Sub frmORReport_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frmORReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.ORReport.Clear()
    End Sub
End Class