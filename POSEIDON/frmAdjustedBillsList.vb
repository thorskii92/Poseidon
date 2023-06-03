Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAdjustedBillsList

    Private Sub btnAdjust_Click(sender As Object, e As EventArgs) Handles btnAdjust.Click
        LoadAdjustedBillsReport(dtpFrom.Value, dtpTo.Value)
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If strQueryAdjusted = "" Then
            MsgBox("No Report Generated", MsgBoxStyle.Exclamation, "No Report")
        Else
            If qAdjCount > 0 Then
                Cons()
                Dim da As New MySqlDataAdapter(strQueryAdjusted, con)
                da.Fill(frmAdjustedBillsReport.ReportDataSet.AdjustedBills)
                frmAdjustedBillsReport.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                frmAdjustedBillsReport.ReportViewer1.ZoomPercent = 100%
                frmAdjustedBillsReport.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                frmAdjustedBillsReport.ReportViewer1.Width = 75
                frmAdjustedBillsReport.WindowState = FormWindowState.Maximized
                frmAdjustedBillsReport.Show()
            Else
                MsgBox("Nothing to Print", MsgBoxStyle.Exclamation, "No Report")
            End If
        End If
    End Sub

    Private Sub btnViewMemo_Click(sender As Object, e As EventArgs) Handles btnViewMemo.Click
        If lvwAdjustedBills.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim daM As New MySqlDataAdapter("SELECT MemoNo FROM tblAdjMemo WHERE billID=" & arrBillAdjMemo(lvwAdjustedBills.FocusedItem.Index), con)
            daM.Fill(dt)
            SelectedAdjMemoID = Val(dt.Rows(0).Item(0).ToString)
            Dim da As New MySqlDataAdapter("SELECT M.memID, M.memoNo, C.consID, A.acctID, B.billID, M.adjDate, M.adjReason, M.adjAsbilled, M.adjPrevMoBal, M.adjNewAmt, M.adjSurcharge, M.adjDueAmt, M.adjIncDec, M.adjAmtIncDec, M.prepID, M.apprvID, A.AccountNo, C.consumername, M.adjasbilled, U.fullname AS Preparee, V.fullname AS Approver, M.envifee, M.adjconsump, M.envifee AS envifee1 FROM tblAdjMemo AS M LEFT JOIN consumerlist AS C ON M.consID=C.consID LEFT JOIN consumeraccounts AS A ON M.acctID=A.acctID LEFT JOIN tblBills AS B ON M.billID=B.billID LEFT JOIN userlist AS U ON M.prepID=U.uID LEFT JOIN userlist AS V ON B.adjApprover=V.uID WHERE M.memoNo=" & dt.Rows(0).Item(0).ToString, con)
            da.Fill(frmMemoPrint.ReportDataSet.BillAdjustment)
            frmMemoPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            frmMemoPrint.ReportViewer1.ZoomPercent = 100%
            frmMemoPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            frmMemoPrint.ReportViewer1.Width = 75
            frmMemoPrint.WindowState = FormWindowState.Maximized
            frmMemoPrint.ReportViewer1.RefreshReport()
            frmMemoPrint.Show()
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Exclamation, "Nothing Selected")
        End If
    End Sub
End Class