Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAnnualSales

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cboYear.Text = "" Then
            MsgBox("Please select a year", MsgBoxStyle.Exclamation, "Select a Year")
            Exit Sub
        Else
            LoadAnnualSalesReport("SELECT SUM(billpayment) AS billpayment, SUM(installpayment) AS installpayment, SUM(meterpayment) as meterpayment, SUM(ownerpayment) as ownerpayment, SUM(reconnectpayment) as reconnectpayment, SUM(servicepayment) as servicepayment, SUM(advancepayment) as advancepayment, monthpayment, yearpayment, date_format(datepayment, '%m') as dPay, SUM(enviFee) AS EnviFee FROM poseidondb.tblpaymentlogs WHERE yearpayment=" & cboYear.Text & "   GROUP BY dpay ORDER BY dpay ASC")
        End If

    End Sub

   

    Private Sub loadYears()
        cboYear.Items.Clear()
        For x As Integer = 2010 To Now.Year
            cboYear.Items.Add(x)
        Next
        cboYear.Text = Now.Year
    End Sub

    Private Sub frmAnnualSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadYears()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Cons()
        Dim da As New MySqlDataAdapter(AnnualSqlStr, con)
        'frmAnnualSalesReport.ReportDataSet.AnnualSales.Clear()
        da.Fill(frmAnnualSalesReport.ReportDataSet.AnnualSales)
        frmAnnualSalesReport.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        frmAnnualSalesReport.ReportViewer1.ZoomPercent = 100%
        frmAnnualSalesReport.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        frmAnnualSalesReport.ReportViewer1.Width = 75
        frmAnnualSalesReport.WindowState = FormWindowState.Maximized
        frmAnnualSalesReport.Show()
    End Sub
End Class