Imports MySql.Data.MySqlClient
Public Class frmDisputeForm

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If Me.txtReason.Text = "" Then
            MsgBox("Please Enter reason of Dispute", MsgBoxStyle.Exclamation, "Fill in Reason of Dispute")
        Else
            If MsgBox("Confirm Dispute of Bill?", MsgBoxStyle.YesNo, "Dispute Confirmation") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("UPDATE tblBills SET origamount=" & Val(lblBillAmount.Text) & ", adjustedamount=" & Val(lblNewAmount.Text) & ", adjprep=" & loggedUserID & ",adjconf='Pending',adjreason='" & txtReason.Text.Replace("'", "''") & "',adjdate=current_date(),adjsurcharge=" & Val(lblSurcharge.Text) & ",adjdueamount=" & Val(lblDueAmount.Text) & ",adjordisprmk='Dispute',envifee=" & Val(lblEnvi.Text) & ",consumption=" & Val(lblConsumption.Text) & " WHERE billID=" & lblBillNum.Text, con)
                cmd.ExecuteNonQuery()
                Dim cmdMem As New MySqlCommand("INSERT INTO tblDisputeMemo(memoNo, consID, acctID, billID, disDate, disReason, disAsBilled, disPrevMoBal, disNewAmt, disSurcharge, disDueAmt, enviID, disConsump, prepID) VALUES(@memNum, @cID, @aID, @bID, current_date(), @dReason, @dBilled, @pMonBal, @dNewAmt, @dScharge, @dDueAmt, @eID, @dConsump, @pID)", con)
                cmdMem.Parameters.AddWithValue("@memNum", lblMemoNum.Text)
                cmdMem.Parameters.AddWithValue("@cID", dispConID)
                cmdMem.Parameters.AddWithValue("@aID", dispAcctID)
                cmdMem.Parameters.AddWithValue("@bID", dispBillID)
                'cmdMem.Parameters.AddWithValue("@dDate", "")
                cmdMem.Parameters.AddWithValue("@dReason", txtReason.Text.Replace("'", "''"))
                cmdMem.Parameters.AddWithValue("@dBilled", Val(lblBillAmount.Text))
                cmdMem.Parameters.AddWithValue("@pMonBal", Val(lblPrevMonthBalance.Text))
                cmdMem.Parameters.AddWithValue("@dNewAmt", Val(lblNewAmount.Text))
                cmdMem.Parameters.AddWithValue("@dScharge", Val(lblSurcharge.Text))
                cmdMem.Parameters.AddWithValue("@dDueAmt", Val(lblDueAmount.Text))
                cmdMem.Parameters.AddWithValue("@eID", Val(lblEnvi.Text))
                cmdMem.Parameters.AddWithValue("@dConsump", Val(lblConsumption.Text))
                cmdMem.Parameters.AddWithValue("@pID", loggedUserID)
                cmdMem.ExecuteNonQuery()
                updateMemo(Now.Year)
                MsgBox("Bill has been disputed", MsgBoxStyle.Information, "Bill Dispute")
                Dim da As New MySqlDataAdapter("SELECT D.memoNo, C.ConsumerName, A.AccountNo, D.disdate, B.billID, B.classid, D.disreason, D.disasbilled, D.disprevmobal, D.disnewamt, D.dissurcharge, D.disdueamt, D.enviID, D.disconsump, D.prepID, U.fullname AS Preparee, D.apprvID, V.fullname AS Approver FROM tblDisputeMemo AS D LEFT JOIN consumerlist AS C ON D.consID=C.consID LEFT JOIN consumeraccounts AS A ON D.acctID=A.acctID LEFT JOIN tblBills as B ON D.billID=B.billID LEFT JOIN userlist AS U ON D.prepID=U.uID LEFT JOIN userlist AS V ON D.apprvID=V.uID WHERE D.MemoNo=" & Val(lblMemoNum.Text), con)
                da.Fill(frmDisputeMemoPrint.ReportDataSet.DisputeMemoAdapter)
                frmDisputeMemoPrint.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                frmDisputeMemoPrint.ReportViewer1.ZoomPercent = 100%
                frmDisputeMemoPrint.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                frmDisputeMemoPrint.ReportViewer1.Width = 75
                frmDisputeMemoPrint.WindowState = FormWindowState.Maximized
                frmDisputeMemoPrint.ReportViewer1.RefreshReport()
                frmDisputeMemoPrint.ShowDialog()
                If billAdjustForm = 1 Then
                    Try
                        WaterBillAccountsList(arrConsWaterID(WaterBillPayment.cboConsumerName.SelectedIndex))
                        Exit Try
                    Catch ex As Exception
                        WaterBillSpecNum(Val(WaterBillPayment.txtBill.Text))
                    End Try
                Else
                    WaterBillingQuery(strQueryBill)
                End If
                Me.txtReason.Text = ""
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmDisputeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMemoNum.Text = memoSeq(Now.Year)
    End Sub
End Class