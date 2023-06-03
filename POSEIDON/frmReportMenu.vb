Public Class frmReportMenu

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frmDailySales.lvwDaily.Items.Clear()
        frmDailySales.ShowInTaskbar = False
        frmDailySales.WindowState = FormWindowState.Maximized
        frmDailySales.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmMonthlySalesReport.lvwMonthly.Items.Clear()
        frmMonthlySalesReport.ShowInTaskbar = False
        frmMonthlySalesReport.WindowState = FormWindowState.Maximized
        frmMonthlySalesReport.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmAnnualSales.lvwMonthly.Items.Clear()
        frmAnnualSales.ShowInTaskbar = False
        frmAnnualSales.WindowState = FormWindowState.Maximized
        frmAnnualSales.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmApplicantsStatus.ShowInTaskbar = False
        frmApplicantsStatus.WindowState = FormWindowState.Maximized
        frmApplicantsStatus.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        frmAdjustedBillsList.lvwAdjustedBills.Items.Clear()
        strQueryAdjusted = ""
        frmAdjustedBillsList.ShowInTaskbar = False
        frmAdjustedBillsList.WindowState = FormWindowState.Maximized
        frmAdjustedBillsList.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmDisputedBillsList.lvwDisputedBills.Items.Clear()
        strQueryDisputed = ""
        frmDisputedBillsList.ShowInTaskbar = False
        frmDisputedBillsList.WindowState = FormWindowState.Maximized
        frmDisputedBillsList.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmBillReport.ShowInTaskbar = False
        frmBillReport.StartPosition = FormStartPosition.CenterScreen
        frmBillReport.WindowState = FormWindowState.Maximized
        frmBillReport.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmORList.ShowInTaskbar = False
        frmORList.StartPosition = FormStartPosition.CenterScreen
        frmORList.WindowState = FormWindowState.Maximized
        frmORList.ShowDialog()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        frmEnviFeeReport.StartPosition = FormStartPosition.CenterScreen
        frmEnviFeeReport.WindowState = FormWindowState.Maximized
        frmEnviFeeReport.ShowDialog()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        frmUncollectibleDateSelection.StartPosition = FormStartPosition.CenterScreen
        frmUncollectibleDateSelection.ShowDialog()
        'frmCollectiblesReport.StartPosition = FormStartPosition.CenterScreen
        'frmCollectiblesReport.WindowState = FormWindowState.Maximized
        'frmCollectiblesReport.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formReportIndex = 1
        showReportFilterForm()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formReportIndex = 2
        showReportFilterForm
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        formReportIndex = 3
       showReportFilterForm
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        formReportIndex = 4
       showReportFilterForm
    End Sub
    Private Sub showReportFilterForm()
        frmReportFilterSelector.ShowInTaskbar = False
        frmReportFilterSelector.StartPosition = FormStartPosition.CenterScreen
        frmReportFilterSelector.ShowDialog()
    End Sub



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        frmDailyCollectionSelection.StartPosition = FormStartPosition.CenterScreen
        frmDailyCollectionSelection.ShowDialog()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        frmMonthlyReportDataGridViewer.WindowState = FormWindowState.Maximized
        frmMonthlyReportDataGridViewer.ShowDialog()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        frmPrintReadingSelection.StartPosition = FormStartPosition.CenterScreen
        frmPrintReadingSelection.ShowDialog()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        frmAccountsReceivableReport.WindowState = FormWindowState.Maximized
        frmAccountsReceivableReport.ShowDialog()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        frmRevFromConsumpSelect.StartPosition = FormStartPosition.CenterScreen
        frmRevFromConsumpSelect.ShowDialog()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        frmConsumpSummarySelect.StartPosition = FormStartPosition.CenterScreen
        frmConsumpSummarySelect.ShowDialog()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        frmSCDSSelect.StartPosition = FormStartPosition.CenterScreen
        frmSCDSSelect.ShowDialog()
    End Sub
End Class