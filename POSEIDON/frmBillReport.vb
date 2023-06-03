Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmBillReport

    Private Sub frmBillReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadGeneratedBills()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.clusterID, C.ClusterName, C.brgyID, BR.AddBrgy, Count(*) AS billCount, B.billPeriod, B.billMonth, B.billyear, U.fullname FROM billing AS B LEFT JOIN clusterlist AS C ON B.clusterID=C.clusterID LEFT JOIN brgylist AS BR ON C.brgyID=BR.brgyID LEFT JOIN userlist AS U ON U.uID=B.uID GROUP BY B.clusterID, B.billMonth, B.billYear ORDER BY B.billmonth, C.clustername", con)
        da.Fill(dt)
        lvwGenList.Items.Clear()
        lvwBills.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrBillRepBrgyID(dt.Rows.Count - 1)
            ReDim arrBillRepClusterID(dt.Rows.Count - 1)
            ReDim arrBillRepMonth(dt.Rows.Count - 1)
            ReDim arrBillRepYear(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillRepClusterID(x) = Val(dt.Rows(x).Item(0))
                arrBillRepBrgyID(x) = Val(dt.Rows(x).Item(2))
                arrBillRepMonth(x) = dt.Rows(x).Item(6)
                arrBillRepYear(x) = Val(dt.Rows(x).Item(7))
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString & " " & dt.Rows(x).Item(7).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(8).ToString)
                lvwGenList.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub lvwGenList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwGenList.SelectedIndexChanged
        If lvwGenList.SelectedItems.Count > 0 Then
            ShowSelectedBillReport(arrBillRepBrgyID(lvwGenList.FocusedItem.Index), arrBillRepClusterID(lvwGenList.FocusedItem.Index), arrBillRepMonth(lvwGenList.FocusedItem.Index), arrBillRepYear(lvwGenList.FocusedItem.Index))
            'SelectGeneratedBill(arrBrBillRepID(lvwGenList.FocusedItem.Index), arrMCluster(lvwGenList.FocusedItem.Index), arrMFromRep(lvwGenList.FocusedItem.Index), arrMToRep(lvwGenList.FocusedItem.Index), arrMyearRep(lvwGenList.FocusedItem.Index), arrRepIDBill(lvwGenList.FocusedItem.Index))
        Else
            lvwBills.Items.Clear()
        End If

    End Sub

    Private Sub btnPrintBills_Click(sender As Object, e As EventArgs) Handles btnPrintBills.Click
        If lvwGenList.SelectedItems.Count > 0 Then

        End If
    End Sub

    Private Sub btnPrintSelected_Click(sender As Object, e As EventArgs) Handles btnPrintSelected.Click

    End Sub

    Private Sub btnEditBill_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        If lvwBills.SelectedItems.Count > 0 Then
            authenticate = False
            frmEnterAdminPassword.ShowDialog()
            If authenticate = True Then
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT B.billID, A.acctID, L.consID, C.classID, A.AccountNo, L.consumername, A.accountName, C.classification, B.isSC, B.prevRead, B.presRead, B.consump, B.amount, B.enviFee, B.Amount, B.EnviFee, B.SCDiscount, B.ApplicationFee, B.Penalty, B.dueDate, B.billMonth, B.billYear, B.prevTotal, B.prevBal, B.prevPenalty, B.billDate, B.readDate, B.fromDate, B.toDate, B.prevOutstanding, B.prevOutPenalty, B.prevOutEF, B.prevStartMonth, B.prevStartYear, B.prevOutDiscount, B.billNote, prevInstallmentFee, outstandingInstallmentFee, outstandingInstallmentCount FROM billing AS B LEFT JOIN consumerlist AS L ON B.consID=L.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN classifications AS C ON B.classID=C.classID WHERE B.billID=" & arrBillRepBillID(lvwBills.FocusedItem.Index), con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    frmBillEditorvb.LoadClassifications()
                    frmBillEditorvb.LoadYear()

                    With frmBillEditorvb
                        selectedBillLedgerID = Val(dt.Rows(0).Item(0))
                        .lblBillNo.Text = dt.Rows(0).Item(0).ToString
                        .lblAccountNo.Text = dt.Rows(0).Item(4).ToString
                        .lblConsumerName.Text = dt.Rows(0).Item(5).ToString
                        .lblAcctName.Text = dt.Rows(0).Item(6).ToString
                        .cboClassification.Text = dt.Rows(0).Item(7).ToString
                        Dim scType As String = dt.Rows(0).Item(8).ToString
                        If scType = "YES" Then
                            .cboAccountType.Text = "SC/PWD"
                        Else
                            .cboAccountType.Text = "Regular"
                        End If
                        .cboStartingMonth.Items.Clear()
                        .cboStartingYear.Items.Clear()
                        For x As Integer = 1 To 12
                            .cboStartingMonth.Items.Add(DateAndTime.MonthName(x))
                        Next
                        For y As Integer = 2018 To 2022
                            .cboStartingYear.Items.Add(y)
                        Next
                        .cboBillMonth.Text = dt.Rows(0).Item(18).ToString
                        .cboBillYear.Text = dt.Rows(0).Item(19).ToString
                        .txtPrevRead.Text = dt.Rows(0).Item(9).ToString
                        .txtPresRead.Text = dt.Rows(0).Item(10).ToString
                        .dtpBillDate.Value = dt.Rows(0).Item(23)
                        .dtpReadDate.Value = dt.Rows(0).Item(24)
                        .dtpDueDate.Value = dt.Rows(0).Item(17)
                        .txtPrevAmount.Text = dt.Rows(0).Item(21).ToString
                        .txtPrevPenalty.Text = dt.Rows(0).Item(22).ToString
                        .txtPrevTotal.Text = dt.Rows(0).Item(20).ToString
                        .txtAppFee.Text = dt.Rows(0).Item(15).ToString
                        .dtpFromDate.Value = dt.Rows(0).Item(25)
                        .dtpToDate.Value = dt.Rows(0).Item(26)
                        .txtBillNote.Text = dt.Rows(0).Item(33)
                        '.txtEnviFee.Text = dt.Rows(0).Item(13).ToString
                        '.txtPrevAdjustment.Text = dt.Rows(0).Item(32).ToString
                        '.txtPrevAdjustedRate.Text = dt.Rows(0).Item(33).ToString
                        '.txtPrevPenalty.Text = dt.Rows(0).Item(34).ToString
                        '.txtPrevAmountDue.Text = dt.Rows(0).Item(35).ToString
                        '.txtOutstandingTotalBalance.Text = dt.Rows(0).Item(39).ToString
                        '.outTotPen.Text = dt.Rows(0).Item(40).ToString
                        '.outTotEF.Text = dt.Rows(0).Item(41).ToString
                        '.outTotDisc.Text = dt.Rows(0).Item(44).ToString
                        .cboStartingMonth.Text = dt.Rows(0).Item(30).ToString
                        .cboStartingYear.Text = dt.Rows(0).Item(31).ToString
                        .txtOutstandingAmount.Text = Val(dt.Rows(0).Item(27).ToString) - Val(dt.Rows(0).Item(28).ToString) + Val(dt.Rows(0).Item(32).ToString)
                        .outTotPen.Text = dt.Rows(0).Item(28)
                        .outTotEF.Text = dt.Rows(0).Item(29).ToString
                        .outTotDisc.Text = dt.Rows(0).Item(32).ToString
                        .txtTotalAmount.Text = dt.Rows(0).Item(27)
                        .txtPrevInstallment.Text = Val(dt.Rows(0).Item(34).ToString)
                        .txtOutInstallmentFee.Text = Val(dt.Rows(0).Item(35).ToString)
                        .cboInstallmentCount.Text = Val(dt.Rows(0).Item(36).ToString)
                        ''.txtAppFee.Text = dt.Rows(0).Item(45).ToString
                    End With
                    frmBillEditorvb.ComputeAll()
                    frmBillEditorvb.ShowDialog()
                End If
            End If
        Else
            MessageBox.Show("Please select a Bill to Edit", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

    End Sub
End Class