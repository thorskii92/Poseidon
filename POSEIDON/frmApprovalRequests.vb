Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmApprovalRequests
    Dim appReqNum As Integer

    Private Sub frmApprovalRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appReqNum = 0
        LoadBillAdjustmentRequest()
    End Sub

    Private Sub lvwRequests_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwRequests.SelectedIndexChanged
        'If lvwRequests.SelectedItems.Count > 0 Then
        '    btnApprove.Visible = True
        '    btnDecline.Visible = True
        'Else
        '    btnApprove.Visible = False
        '    btnDecline.Visible = False
        'End If
    End Sub

    Private Sub btnAdjustments_Click(sender As Object, e As EventArgs)
        'appReqNum = 1
        'ApprovalRequests(appReqNum)
    End Sub

    Private Sub btnDisputes_Click(sender As Object, e As EventArgs)
        'appReqNum = 2
        'ApprovalRequests(appReqNum)
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs)
        If lvwRequests.SelectedItems.Count > 0 Then
            If MsgBox("Confirm Approval?", MsgBoxStyle.YesNo, "Approve Request") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("UPDATE tblbills SET adjConf='Approved', adjApprover='" & loggedUserID & "' WHERE billID=" & arrAppBillID(lvwRequests.FocusedItem.Index), con)
                If adjIndex = 1 Then
                    Dim cmdAdj As New MySqlCommand("UPDATE tblAdjMemo SET apprvID=" & loggedUserID & " WHERE billID=" & arrAppBillID(lvwRequests.FocusedItem.Index), con)
                    cmdAdj.ExecuteNonQuery()
                ElseIf adjIndex = 2 Then
                    Dim cmdDis As New MySqlCommand("UPDATE tbldisputememo SET apprvID=" & loggedUserID & " WHERE billID=" & arrAppBillID(lvwRequests.FocusedItem.Index), con)
                    cmdDis.ExecuteNonQuery()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Approved!", MsgBoxStyle.Information, "Approved")
                ApprovalRequests(appReqNum)
            End If
        End If
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        If lvwRequests.SelectedItems.Count > 0 Then
            selectedBillApprovalID = arrBillApprovalID(lvwRequests.FocusedItem.Index)
            MessageBox.Show("")
            'Cons()
            'Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT B.billID, B.billNo, A.accountName, A.accountno, C.clusterid, C.clustername, BR.addbrgy, A.streetaddress, F.requestdate, B.prevread, B.presread, B.consump, B.totalamountdue, F.adjreason, F.preparedby, F.requestedby, CO.consID, CO.consumername FROM billing AS B LEFT JOIN consumerlist AS L LEFT JOIN consumeraccounts AS A LEFT JOIN  WHERE billID=" & selectedBillApprovalID, con)
            'da.Fill(dt)
        End If

        'If lvwRequests.SelectedItems.Count > 0 Then
        '    If MsgBox("Confirm Rejection?", MsgBoxStyle.YesNo, "Reject Request") = MsgBoxResult.Yes Then
        '        Cons()
        '        Dim cmd As New MySqlCommand("UPDATE tblbills SET origamount=null, adjustedamount=null, adjapprover=null, adjconf=null, adjreason=null, adjdate=null, adjsurcharge=null, adjdueamount=null, adjordisprmk='None' WHERE billID=" & arrAppBillID(lvwRequests.FocusedItem.Index), con)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Rejected!", MsgBoxStyle.Information, "Rejected")
        '        ApprovalRequests(appReqNum)
        '    End If
        'End If
    End Sub

    Public Sub LoadBillAdjustmentRequest()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT B.billID, B.billNo, CL.consumername, A.accountname, A.accountno, B.consump, B.totalamountdue, A.streetaddress, BR.addbrgy, C.clustername, B.isAdjusted, B.adjRemark, R.requestdate, R.preparedby, R.reqID, R.requestedby, B.billDate FROM billing AS B LEFT JOIN consumerlist AS CL ON B.consID=CL.consID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN clusterlist AS C ON B.clusterID=C.clusterID LEFT JOIN brgylist AS BR ON C.brgyID=BR.brgyID LEFT JOIN tblbilladjustmentrequestform AS R ON B.billID=R.billID WHERE B.isAdjusted='Yes' and (B.adjRemark='Request' or B.adjRemark='Pending') ", con)
        da.Fill(dt)
        lvwRequests.Items.Clear()

        If dt.Rows.Count > 0 Then
            ReDim arrBillApprovalID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBillApprovalID(x) = Val(dt.Rows(x).Item(0))
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString 'BILL NO
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(15).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(16).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(15).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(12).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(13).ToString)
                lvwRequests.Items.Add(lst)
            Next
        End If
    End Sub
End Class