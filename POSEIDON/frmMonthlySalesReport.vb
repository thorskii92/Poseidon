Imports MySql.Data.MySqlClient
Public Class frmMonthlySalesReport

    Private Sub frmMonthlySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboYear.Items.Clear()
        For x As Integer = 2010 To 2060
            cboYear.Items.Add(x)
        Next
        cboMonth.Text = Format(Now, "MMMM")
        cboYear.Text = Now.Year
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        MonthlySalesReport(cboMonth.Text, cboYear.Text)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If strMonthlySalesQuery = "" Then
            MsgBox("No report generated", MsgBoxStyle.Exclamation, "No Report")
        Else
            'Dim da As New MySqlDataAdapter("SELECT datepayment, billpayment, sum(installpayment), sum(meterpayment), sum(ownerpayment), sum(reconnectpayment), sum(servicepayment), sum(advancepayment) FROM tblpaymentlogs WHERE monthpayment='" & UCase(cboMonth.Text) & "' AND yearpayment='" & cboYear.Text & "' GROUP by datepayment", con)
            Dim da As New MySqlDataAdapter("SELECT SUM(billpayment) AS billpayment, SUM(installpayment) AS installpayment, SUM(meterpayment) as meterpayment, SUM(ownerpayment) as ownerpayment, SUM(reconnectpayment) as reconnectpayment, SUM(servicepayment) as servicepayment, SUM(advancepayment) as advancepayment, monthpayment, yearpayment, datepayment, SUM(EnviFee) As EnviFee FROM poseidondb.tblpaymentlogs WHERE monthpayment='" & cboMonth.Text & "' AND yearpayment='" & cboYear.Text & "' GROUP BY datepayment", con)
            da.Fill(frmMonthlySalesReportViewer.ReportDataSet.MonthlySales)
            frmMonthlySalesReportViewer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            frmMonthlySalesReportViewer.ReportViewer1.ZoomPercent = 100%
            frmMonthlySalesReportViewer.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            frmMonthlySalesReportViewer.ReportViewer1.Width = 75
            frmMonthlySalesReportViewer.WindowState = FormWindowState.Maximized
            frmMonthlySalesReportViewer.Show()
        End If
    End Sub
End Class