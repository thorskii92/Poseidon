Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmBillAdjustmentRequestForm
    Private Sub frmBillAdjustmentRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBillsForRequest()
    End Sub

    Private Sub lvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvw.SelectedIndexChanged
        If lvw.SelectedItems.Count > 0 Then
            If arrPendingBillStatID(lvw.FocusedItem.Index) = 1 Then
                btnRequestAdj.Visible = True
                btnRequestAdj.Text = "Request Adjustment"
            ElseIf arrPendingBillStatID(lvw.FocusedItem.Index) = 2 Then
                btnRequestAdj.Visible = True
                btnRequestAdj.Text = "Adjust Bill"
            End If
        Else
            btnRequestAdj.Visible = False
        End If
    End Sub

    Private Sub btnRequestAdj_Click(sender As Object, e As EventArgs) Handles btnRequestAdj.Click
        If lvw.SelectedItems.Count > 0 Then
            Cons()
            selectedPendingBIllID = arrPendingBillID(lvw.FocusedItem.Index)
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT B.billID, B.billNo, CL.consumername, A.accountname, A.accountno, BR.addbrgy, C.clustername, A.streetaddress, B.prevRead, B.presRead, B.consump, B.totalAmountDue FROM billing AS B LEFT JOIN consumerlist AS CL ON B.consID=CL.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN clusterlist AS C ON B.clusterID=C.clusterID LEFT JOIN brgylist AS BR ON C.brgyID=BR.brgyID WHERE billID=" & selectedPendingBIllID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                With frmAdjustBillRequestForm
                    .lblName.Text = dt.Rows(0).Item(2).ToString
                    .lblAccountName.Text = dt.Rows(0).Item(3).ToString
                    .lblAccountNum.Text = dt.Rows(0).Item(4).ToString
                    .lblCluster.Text = dt.Rows(0).Item(6).ToString
                    .lblBarangay.Text = dt.Rows(0).Item(5).ToString
                    .lblAddress.Text = dt.Rows(0).Item(7).ToString
                    .lblDate.Text = Today.Date.ToShortDateString
                    .lblBillNo.Text = dt.Rows(0).Item(1).ToString
                    .lblPrevRead.Text = dt.Rows(0).Item(8).ToString
                    .lblPresRead.Text = dt.Rows(0).Item(9).ToString
                    .lblConsumption.Text = dt.Rows(0).Item(10).ToString
                    .lblBillAmount.Text = Format(dt.Rows(0).Item(11), "#,##0.#0")
                    .lblRequestee.Text = dt.Rows(0).Item(2).ToString
                End With
            End If

            Dim dtP As New DataTable
            Dim daP As New MySqlDataAdapter("SELECT uID, fullname FROM userlist WHERE uID=" & loggedUserID, con)
            daP.Fill(dtP)
            If dtP.Rows.Count > 0 Then
                frmAdjustBillRequestForm.lblPreparee.Text = dtP.Rows(0).Item(1).ToString
                prepareeID = Val(dtP.Rows(0).Item(0).ToString)
            End If

            frmAdjustBillRequestForm.StartPosition = FormStartPosition.CenterScreen
            frmAdjustBillRequestForm.ShowDialog()
        End If
    End Sub
End Class