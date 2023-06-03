Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAccountsList

    Private Sub cboProvince_Click(sender As Object, e As EventArgs) Handles cboProvince.Click
        acctFormMunListCombo(arrAcctListProvID(cboProvince.SelectedIndex))
    End Sub

    Private Sub cboMunicipality_Click(sender As Object, e As EventArgs) Handles cboMunicipality.Click

    End Sub

    Private Sub cboZone_Click(sender As Object, e As EventArgs) Handles cboZone.Click

    End Sub

    Private Sub cboBarangay_Click(sender As Object, e As EventArgs) Handles cboBarangay.Click

    End Sub

    Private Sub cboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        acctFormMunListCombo(arrAcctListProvID(cboProvince.SelectedIndex))
    End Sub

    Private Sub cboMunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipality.SelectedIndexChanged
        acctFormZoneListCombo(arrAcctListMunID(cboMunicipality.SelectedIndex))
    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged
        acctFormBrgyListCombo(arrAcctListZoneID(cboZone.SelectedIndex))
    End Sub

    Private Sub cboBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarangay.SelectedIndexChanged

        'acctFormClusterListCombo(arrAcctListBrgyID(cboBarangay.SelectedIndex))
        'accFormClusterList(arrAcctListBrgyID(cboBarangay.SelectedIndex))
        AccountFormList(arrAcctListBrgyID(cboBarangay.SelectedIndex), txtSearch.Text.Replace("'", "`"), acFilter)
    End Sub

    Private Sub cboCluster_Click(sender As Object, e As EventArgs) Handles cboCluster.Click

    End Sub

    Private Sub cboCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCluster.SelectedIndexChanged
        AccountFormList(arrAcctListBrgyID(cboBarangay.SelectedIndex), txtSearch.Text.Replace("'", "`"), acFilter)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            AccountFormList(arrAcctListBrgyID(cboBarangay.SelectedIndex), txtSearch.Text.Replace("'", "`"), acFilter)
        Catch ex As Exception
            MsgBox("Please specify filters.", MsgBoxStyle.Exclamation, "Poseidon")
            Exit Sub
        End Try

    End Sub

    Private Sub frmAccountsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalAccounts.Text = ""
        cboFilterAccountStatus.SelectedIndex = 0
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            selectedAcctIDLedger = arrAccountListAcctID(lvwAccounts.FocusedItem.Index)
            ViewLedger(arrAccountListAcctID(lvwAccounts.FocusedItem.Index))
            frmAccountLedger.StartPosition = FormStartPosition.CenterScreen
            frmAccountLedger.WindowState = FormWindowState.Maximized
            frmAccountLedger.Show()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            If CheckAccountBalance(arrAccountListAcctID(lvwAccounts.FocusedItem.Index), lvwAccounts.FocusedItem.Text) = True Then
                TransferShow(arrAccountListAcctID(lvwAccounts.FocusedItem.Index))
            Else
                MsgBox(lvwAccounts.FocusedItem.Text & " still has a balance of Php" & Format(consBalance, "#,###0.#0") & ", Please settle remaining balance before proceeding to Transfer of Ownership")
                Exit Sub
            End If
        Else
            MsgBox("Nothing Selected", MsgBoxStyle.Exclamation, "")
        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            If Me.lvwAccounts.SelectedItems.Count > 0 Then
                If CheckAccountBalance(arrAccountListAcctID(lvwAccounts.FocusedItem.Index), lvwAccounts.FocusedItem.Text) = True Then
                    TransMeterShow(arrAccountListAcctID(lvwAccounts.FocusedItem.Index))
                Else
                    MsgBox(lvwAccounts.FocusedItem.Text & " still has a balance of Php" & Format(consBalance, "#,###0.#0") & ", Please settle remaining balance before proceeding to Transfer of Water Meter")
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Nothing Selected", MsgBoxStyle.Exclamation, "")
        End If

    End Sub

    Private Sub cboFilterAccountStatus_Click(sender As Object, e As EventArgs) Handles cboFilterAccountStatus.Click

    End Sub

    Private Sub cboFilterAccountStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterAccountStatus.SelectedIndexChanged
        Select Case cboFilterAccountStatus.SelectedIndex
            Case 0
                acFilter = ""
            Case 1
                acFilter = " AND A.acctstatus=3"
            Case 2
                acFilter = " AND A.acctstatus=1"
            Case 3
                acFilter = " AND A.acctstatus=2"
            Case 4
                acFilter = " AND A.acctstatus=4"
            Case 5
                acFilter = " AND A.acctstatus=5"
            Case 6
                acFilter = " AND A.acctstatus=6"
            Case 7
                acFilter = " AND A.acctstatus=7"
            Case 8
                acFilter = " AND A.acctstatus=8"
        End Select
        If Not cboBarangay.Text = "" And Not cboCluster.Text = "" Then
            Try
                AccountFormList(arrAcctListBrgyID(cboBarangay.SelectedIndex), txtSearch.Text.Replace("'", "`"), acFilter)
                Exit Sub
            Catch ex As Exception
                MsgBox("Please specify filters.", MsgBoxStyle.Exclamation, "Poseidon")
                Exit Sub
            End Try
        End If


    End Sub

    Private Sub cboFilter_Click(sender As Object, e As EventArgs) Handles cboFilter.Click

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT A.acctID, A.accountNo, B.balance, A.consID FROM applicationfeetotalbalance AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID where B.acctID=" & arrAccountListAcctID(lvwAccounts.FocusedItem.Index), con)
            da.Fill(dt)
            AppFeeEditID = arrAccountListAcctID(lvwAccounts.FocusedItem.Index)
            AppFeeEditConsID = arrAccountListConsID(lvwAccounts.FocusedItem.Index)
            If dt.Rows.Count > 0 Then
                frmEditApplicationFeeBalance.lblAccountNum.Text = dt.Rows(0).Item(1).ToString
                frmEditApplicationFeeBalance.txtBalance.Text = dt.Rows(0).Item(2).ToString

            Else

                frmEditApplicationFeeBalance.lblAccountNum.Text = lvwAccounts.FocusedItem.Text
                frmEditApplicationFeeBalance.txtBalance.Text = 0
            End If
            frmEditApplicationFeeBalance.StartPosition = FormStartPosition.CenterScreen
            frmEditApplicationFeeBalance.ShowDialog()
        End If

        'appOpenForm = 1
        'Dim acID As Integer = arrAccountListAcctID(lvwAccounts.FocusedItem.Index)
        'LoadApplicationBalance(acID)


    End Sub

    Private Sub lvwAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwAccounts.SelectedIndexChanged
        If lvwAccounts.SelectedItems.Count > 0 Then
            btnChangeClass.Visible = True
        End If
    End Sub

    Private Sub btnChangeClass_Click(sender As Object, e As EventArgs) Handles btnChangeClass.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            selectedAcctIDLedger = arrAccountListAcctID(lvwAccounts.FocusedItem.Index)
            accountListIndex = lvwAccounts.FocusedItem.Index
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM classifications", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmChangeClass.cboClass.Items.Clear()
                ReDim arrChangeClassID(dt.Rows.Count - 1)
                For x As Integer = 0 To dt.Rows.Count - 1
                    arrChangeClassID(x) = Val(dt.Rows(x).Item(0))
                    frmChangeClass.cboClass.Items.Add(dt.Rows(x).Item(1).ToString)
                Next
                frmChangeClass.cboClass.Text = lvwAccounts.FocusedItem.SubItems(9).Text
                selectedChangeClassID = arrChangeClassID(frmChangeClass.cboClass.SelectedIndex)
                frmChangeClass.StartPosition = FormStartPosition.CenterScreen
                frmChangeClass.ShowDialog()
            Else
                MessageBox.Show("Classifications Unavailable", "No Class Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnOverpayment_Click(sender As Object, e As EventArgs) Handles btnOverpayment.Click
        If lvwAccounts.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT A.acctID, A.accountNo, O.balamt, O.opID, A.AccountName FROM tbloverpayment AS O LEFT JOIN consumeraccounts AS A ON O.acctID=A.acctID where O.acctID=" & arrAccountListAcctID(lvwAccounts.FocusedItem.Index), con)
            da.Fill(dt)
            OverpayEditID = arrAccountListAcctID(lvwAccounts.FocusedItem.Index)
            'OverpayID = arrAccountListConsID(lvwAccounts.FocusedItem.Index)
            If dt.Rows.Count > 0 Then
                frmEditOverpayment.lblAccountNum.Text = dt.Rows(0).Item(1).ToString
                frmEditOverpayment.txtBalance.Text = Val(dt.Rows(0).Item(2).ToString)
                frmEditOverpayment.lblName.Text = dt.Rows(0).Item(4).ToString
                OverpayID = Val(dt.Rows(0).Item(3).ToString)
                isNew = False
            Else

                frmEditOverpayment.lblAccountNum.Text = lvwAccounts.FocusedItem.Text
                frmEditOverpayment.txtBalance.Text = 0
                frmEditOverpayment.lblName.Text = lvwAccounts.FocusedItem.SubItems(1).Text
                isNew = True
                'OverpayID = Val(dt.Rows(0).Item(3).ToString)
            End If
            frmEditOverpayment.StartPosition = FormStartPosition.CenterScreen
            frmEditOverpayment.ShowDialog()
        End If
    End Sub
End Class