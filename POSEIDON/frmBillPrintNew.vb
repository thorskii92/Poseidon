Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmBillPrintNew

    Private Sub frmBillPrintNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

        recordBill()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin
        'recordBill()
        'remove comment after final
    End Sub
End Class