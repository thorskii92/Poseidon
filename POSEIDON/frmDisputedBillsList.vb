Imports MySql.Data.MySqlClient
Public Class frmDisputedBillsList

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        LoadDisputedListReport(dtpFrom.Value, dtpTo.Value)
    End Sub

    Private Sub btnViewMemo_Click(sender As Object, e As EventArgs) Handles btnViewMemo.Click
        If lvwDisputedBills.SelectedItems.Count > 0 Then
            'frmDisputeMemoPrint.ReportDataSet.DisputeMemoAdapter.Clear()
            Cons()
            Dim dt As New DataTable
            Dim daM As New MySqlDataAdapter("SELECT MemoNo FROM tblDisputeMemo WHERE billID=" & arrBillDispMemo(lvwDisputedBills.FocusedItem.Index), con)
            daM.Fill(dt)
            Dim da As New MySqlDataAdapter("SELECT D.memoNo, C.ConsumerName, A.AccountNo, D.disdate, B.billID, B.classid, D.disreason, D.disasbilled, D.disprevmobal, D.disnewamt, D.dissurcharge, D.disdueamt, D.enviID, D.disconsump, D.prepID, U.fullname AS Preparee, D.apprvID, V.fullname AS Approver FROM tblDisputeMemo AS D LEFT JOIN consumerlist AS C ON D.consID=C.consID LEFT JOIN consumeraccounts AS A ON D.acctID=A.acctID LEFT JOIN tblBills as B ON D.billID=B.billID LEFT JOIN userlist AS U ON D.prepID=U.uID LEFT JOIN userlist AS V ON D.apprvID=V.uID WHERE D.MemoNo=" & dt.Rows(0).Item(0).ToString, con)
            da.Fill(frmDisputeMemoPrint.ReportDataSet.DisputeMemoAdapter)
            frmDisputeMemoPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            frmDisputeMemoPrint.ReportViewer1.ZoomPercent = 100%
            frmDisputeMemoPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            frmDisputeMemoPrint.ReportViewer1.Width = 75
            frmDisputeMemoPrint.WindowState = FormWindowState.Maximized
            frmDisputeMemoPrint.ReportViewer1.RefreshReport()
            frmDisputeMemoPrint.Show()
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Exclamation, "Nothing Selected")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If strQueryDisputed = "" Then
            MsgBox("No Report Generated", MsgBoxStyle.Exclamation, "No Report")
        Else
            If qDispCount > 0 Then
                Cons()
                Dim da As New MySqlDataAdapter(strQueryDisputed, con)
                da.Fill(frmDisputedBillsReport.ReportDataSet.AdjustedBills)
                frmDisputedBillsReport.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                frmDisputedBillsReport.ReportViewer1.ZoomPercent = 100%
                frmDisputedBillsReport.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                frmDisputedBillsReport.ReportViewer1.Width = 75
                frmDisputedBillsReport.WindowState = FormWindowState.Maximized
                frmDisputedBillsReport.Show()
            Else
                MsgBox("Nothing to Print", MsgBoxStyle.Exclamation, "No Report")
            End If
        End If
    End Sub
End Class