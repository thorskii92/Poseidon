Imports MySql.Data.MySqlClient
Public Class frmNewAccount
    Dim intConf As Integer
    Dim intConA As Integer
    Dim getIDOfAccount As Integer
    Dim getPayID As Integer
    Dim getID As Integer
    Public senID As String
    Public isSen As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If intConf = 0 Then
            lblConfirmation.Text = "Please check Payment First before proceeding"
            Exit Sub
        ElseIf intConf = 1 And intConA = 1 Then
            If MsgBox("Add this new account?", MsgBoxStyle.YesNo, "New Account") = MsgBoxResult.Yes Then
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE accountNo='" & txtAccount.Text & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("Same Account Number Found, Please update series of accounts on settings.", MsgBoxStyle.Exclamation, "Account Number Conflict")
                    Exit Sub
                Else
                    Dim cmd As New MySqlCommand("INSERT INTO consumeraccounts(consID,classID,brgyID,clusterID,Sequence,AccountNo,receiptNo,StreetAddress,AcctStatus,CanDelete,isSenior,seniorID,AccountName) VALUES(@consumerID,@classificationID,@barangayID,@clusteNo,@SequenceNo,@AccountNumber,@receiptNumber,@StAddress,@AccountStatus,@CDelete,@isSC,@senID,@AcctName)", con)
                    cmd.Parameters.AddWithValue("@consumerID", selConsumerID)
                    cmd.Parameters.AddWithValue("@classificationID", selComCID)
                    cmd.Parameters.AddWithValue("@barangayID", selComBID)
                    cmd.Parameters.AddWithValue("@clusteNo", Val(cboCluster.Text))
                    cmd.Parameters.AddWithValue("@SequenceNo", Val(txtSeq.Text))
                    cmd.Parameters.AddWithValue("@AccountNumber", txtAccount.Text)
                    cmd.Parameters.AddWithValue("@receiptNumber", txtReceipt.Text)
                    cmd.Parameters.AddWithValue("@StAddress", txtStreetAddress.Text)
                    cmd.Parameters.AddWithValue("@AccountStatus", 3)
                    cmd.Parameters.AddWithValue("@CDelete", "YES")
                    cmd.Parameters.AddWithValue("@isSC", isSen)
                    cmd.Parameters.AddWithValue("@senID", senID)
                    cmd.Parameters.AddWithValue("@AcctName", txtName.Text)
                    cmd.ExecuteNonQuery()
                    Dim cmdUpdateUsage As New MySqlCommand("UPDATE tblorusage SET Status='Used' WHERE useID=" & getIDOfAccount, con)
                    cmdUpdateUsage.ExecuteNonQuery()
                    Dim cmdTL As New MySqlCommand("INSERT INTO transactionlog(acctID,logType,transactDate) VALUES(@aID, @lType,current_date())", con)
                    cmdTL.Parameters.AddWithValue("@aID", selectedPendingAccountID)
                    cmdTL.Parameters.AddWithValue("@lType", 1)
                    'cmdTL.Parameters.AddWithValue("@tDate", Format(dtpDate.Value.Date, "yyyy-MM-dd"))
                    cmdTL.ExecuteNonQuery()
                    'Dim cmdUpdateOR As New MySqlCommand("UPDATE tblpayment SET Remark='Used' WHERE pID=" & getIDOfAccount, con)
                    'cmdUpdateOR.ExecuteNonQuery()
                    Dim dtAID As New DataTable
                    Dim daAID As New MySqlDataAdapter("SELECT max(acctID) FROM consumeraccounts", con)
                    daAID.Fill(dtAID)
                    getID = Val(dtAID.Rows(0).Item(0).ToString)
                    Dim cmdDR As New MySqlCommand("UPDATE tbldailytransaction SET acctID=" & getID & " WHERE pID=" & getPayID, con)
                    cmdDR.ExecuteNonQuery()
                    Dim cmdApp As New MySqlCommand("INSERT INTO tblapplicantslog(uID, acctID, dateofapplication) VALUES(" & loggedUserID & "," & getID & ",current_date())", con)
                    cmdApp.ExecuteNonQuery()
                    'UpdateAccountCode()

                    'UPDATE ACCOUNT CODE
                    Dim dtCheckSer As New DataTable
                    Dim daCheckSer As New MySqlDataAdapter("SELECT * FROM acctcodegen WHERE brgyID=" & selBaraID, con)
                    daCheckSer.Fill(dtCheckSer)
                    If dtCheckSer.Rows.Count > 0 Then
                        Dim cmdUpSer As New MySqlCommand("UPDATE acctcodegen SET series=" & Val(Mid(txtAccount.Text, txtAccount.TextLength - 4, 4)) + 1 & " WHERE brgyid=" & selBaraID, con)
                        cmdUpSer.ExecuteNonQuery()
                    Else
                        Dim cmdAddSer As New MySqlCommand("INSERT INTO acctcodegen(brgyID, series) VALUES(" & selBaraID & "," & Val(Mid(txtAccount.Text, txtAccount.TextLength - 4, 4)) + 1 & ")", con)
                        cmdAddSer.ExecuteNonQuery()
                    End If

                    ViewConsumerList(frmConsumerList.txtSearchConsumer.Text.Replace("'", "`"))
                    MsgBox("Account Successfully Added! Account will be added to Pending List for Connection.", MsgBoxStyle.Information, "Succefful!")
                    Me.Close()
                End If
            End If
        ElseIf intConf = 2 Then
            MsgBox("Payment is already used! to Another Account", MsgBoxStyle.Information, "Payment Used")
            Exit Sub
        ElseIf intConf = 3 Then
            MsgBox("Receipt is invalid", MsgBoxStyle.Information, "Invalid Receipt")
            Exit Sub
        End If
    End Sub

    Private Sub UpdateAccountCode()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT series FROM acctcodegen WHERE acctcodeid=" & accdataID, con)
        da.Fill(dt)
        Dim mySer As Integer = Val(dt.Rows(0).Item(0).ToString)
        Dim newSer As Integer = mySer + 1
        Dim cmd As New MySqlCommand("UPDATE acctcodegen SET series=" & newSer & " WHERE acctcodeid=" & accdataID, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub cboClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClass.SelectedIndexChanged
        selComCID = arrCombiClassID(cboClass.SelectedIndex)
        CheckAccount()
    End Sub

    Private Sub cboClass_TextChanged(sender As Object, e As EventArgs) Handles cboClass.TextChanged
        selComCID = arrCombiClassID(cboClass.SelectedIndex)
        CheckAccount()
    End Sub

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        selComPID = arrComboProvsID(cboProv.SelectedIndex)
        nComboMunList(selComPID)
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        selComMID = arrComboMunsID(cboMun.SelectedIndex)
        nComboBrgyList(selComMID)
    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged
        selComBID = arrComboBrgyID(cboBrgy.SelectedIndex)
        nComboClusterList(selComBID)
        checkClusterSequence()
    End Sub

    Private Sub frmNewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intConf = 0
        lblConfirmation.Visible = False
        lblAccountConfirmation.Visible = False
    End Sub

    Private Sub AccountGen(brgID As Integer, clasID As Integer)
        txtAccount.Text = ""
    End Sub

    Private Sub CheckAccount()
        'txtAccount.Text = AccountCode(BrgyID As Integer, ClassID As Integer)
        If cboBrgy.Text = "" Or cboClass.Text = "" Then
            txtAccount.Text = ""
        Else
            'MessageBox.Show(selComBID & " " & selComCID)
            txtAccount.Text = GenerateAccountCode(selComBID, selClusID, selComCID)
        End If
        Exit Sub
    End Sub

    Private Sub cboBrgy_TextChanged(sender As Object, e As EventArgs) Handles cboBrgy.TextChanged
        Try
            selComBID = arrComboBrgyID(cboBrgy.SelectedIndex)
            CheckAccount()
            nComboClusterList(selComBID)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCluster.SelectedIndexChanged
        Try
            selClusID = arrComboClustID(cboCluster.SelectedIndex)
            checkClusterSequence()
            CheckAccount()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub checkClusterSequence()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT max(sequence) FROM consumeraccounts WHERE clusterID=" & selComBID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim x As Integer = Val(dt.Rows(0).Item(0).ToString)
            txtSeq.Text = x + 1
        Else
            txtSeq.Text = "1"
        End If
    End Sub

    Private Sub cboCluster_TextChanged(sender As Object, e As EventArgs) Handles cboCluster.TextChanged
        checkClusterSequence()
    End Sub

  
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        intConf = 0
        lblConfirmation.Visible = True
        If txtReceipt.Text = "" Then
            intConf = 3
            lblConfirmation.Text = "Enter OR Number"
            lblConfirmation.ForeColor = Color.Red
            Exit Sub
        Else
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT useID, Status, conID FROM tblorusage WHERE ORNum='" & txtReceipt.Text & "' AND FeeType='Installation' ORDER by Status", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim dtP As New DataTable
                Dim daP As New MySqlDataAdapter("SELECT pID FROM tblPayment WHERE ORNumber='" & txtReceipt.Text & "'", con)
                daP.Fill(dtP)
                getPayID = dtP.Rows(0).Item(0)
                Dim getConsID As Integer = Val(dt.Rows(0).Item(2).ToString)
                Dim myRemark As String = dt.Rows(0).Item(1).ToString
                getIDOfAccount = Val(dt.Rows(0).Item(0).ToString)
                If getConsID = selConsumerID Then
                    If myRemark = "Used" Then
                        intConf = 2
                        lblConfirmation.Text = "Payment Used"
                        lblConfirmation.ForeColor = Color.Red
                    ElseIf myRemark = "Unused" Then
                        intConf = 1
                        lblConfirmation.Text = "Payment Confirmed"
                        lblConfirmation.ForeColor = Color.Green
                    End If
                Else
                    MsgBox("The OR is not for this Consumer", MsgBoxStyle.Exclamation, "Invalid Consumer")
                    Exit Sub
                End If
            Else
                intConf = 3
                lblConfirmation.Text = "OR Number is Invalid"
                lblConfirmation.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub btnCheckAccount_Click(sender As Object, e As EventArgs) Handles btnCheckAccount.Click
        intConA = 0
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE accountno='" & txtAccount.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            lblAccountConfirmation.Visible = True
            intConA = 0
            lblAccountConfirmation.Text = "Same Account Found!"
            lblAccountConfirmation.ForeColor = Color.Red
        Else
            lblAccountConfirmation.Visible = True
            intConA = 1
            lblAccountConfirmation.Text = "Account Available"
            lblAccountConfirmation.ForeColor = Color.Green
        End If
    End Sub
End Class