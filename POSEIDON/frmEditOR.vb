Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmEditOR
    Public selORID As Integer
    Public defOR As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rdbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCash.CheckedChanged
        txtBank.Text = ""
        txtNum.Text = ""
        txtCheckDate.Text = ""
        txtBank.Enabled = False
        txtNum.Enabled = False
        txtCheckDate.Enabled = False
    End Sub

    Private Sub rdbCheck_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCheck.CheckedChanged
        txtBank.Enabled = True
        txtNum.Enabled = True
        txtCheckDate.Enabled = True
    End Sub

    Private Sub rdbMO_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMO.CheckedChanged
        txtBank.Text = ""
        txtBank.Enabled = False
        txtNum.Enabled = True
        txtCheckDate.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Confirm Update to O.R.?", "Save O.R.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            If defOR = txtOR.Text Then
                SaveEditedValues()
                SaveORValues()

                If editORFromForm = 1 Then
                    If defOR = txtOR.Text Then
                        ORNumSelected(frmORList.lvwOR.FocusedItem.Text)
                    Else
                        frmORList.SelectedORGroupList(arrGrORID(frmORList.cboGroup.SelectedIndex))
                    End If
                ElseIf editORFromForm = 2 Then
                    ViewLedger(selectedAcctIDLedger)
                End If
                Me.Close()
            Else
                Dim dtGetSameOR As New DataTable
                Dim daGetSameOR As New MySqlDataAdapter("SELECT * FROM tblOR WHERE ORNum='" & txtOR.Text & "'", con)
                daGetSameOR.Fill(dtGetSameOR)
                If dtGetSameOR.Rows.Count > 0 Then
                    MessageBox.Show("Same O.R. Number Found, please check enetered O.R. Number", "Same O.R. Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    SaveEditedValues()
                    SaveORValues()

                    If editORFromForm = 1 Then
                        If defOR = txtOR.Text Then
                            ORNumSelected(frmORList.lvwOR.FocusedItem.Text)
                        Else
                            frmORList.SelectedORGroupList(arrGrORID(frmORList.cboGroup.SelectedIndex))
                        End If
                    ElseIf editORFromForm = 2 Then
                        ViewLedger(selectedAcctIDLedger)
                    End If
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Public Sub SaveEditedValues()
        Dim cmd As New MySqlCommand("UPDATE tblOR SET ORNum=@ORN, totalPayment=@totp, pType=@ptyp, draweebank=@dbank, draweenum=@dnum, draweedate=@ddate, amountinwords=@amtwords, amountinwords2=@amtwords2, pDate=@payDate, seniorrmk=@senrmk, seniorid=@senid, totaldiscount=@totdisc, nature1=@nat1, nature2=@nat2, nature3=@nat3, nature4=@nat4, nature5=@nat5, nature6=@nat6, nature7=@nat7, nature8=@nat8, code1=@cod1, code2=@cod2, code3=@cod3, code4=@cod4, code5=@cod5, code6=@cod6, code7=@cod7, code8=@cod8, amount1=@amt1, amount2=@amt2, amount3=@amt3, amount4=@amt4, amount5=@amt5, amount6=@amt6, amount7=@amt7, amount8=@amt8, collectorname=@colname, cashcheck=@cCHeck, checkCheck=@chCheck, moneyordercheck=@mocheck, moneyordernum=@moNum, moneyorderdate=@moDate WHERE orID=" & selORID, con)
        cmd.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmd.Parameters.AddWithValue("@totp", Val(txtTotal.Text.Replace(",", "")))
        Dim payType As String = ""
        Dim checkBank As String = ""
        Dim checkNum As String = ""
        Dim checkDate As String = ""
        Dim moNum As String = ""
        Dim moDate As String = ""
        Dim pTypeCash As String = ""
        Dim pTypeCheck As String = ""
        Dim pTypeMO As String = ""
        If rdbCash.Checked = True Then
            payType = "Cash"
            checkBank = ""
            checkNum = ""
            checkDate = ""
            moNum = ""
            moDate = ""
            pTypeCash = "✓"
            pTypeCheck = ""
            pTypeMO = ""
        ElseIf rdbCheck.Checked = True Then
            payType = "Check"
            checkBank = txtBank.Text
            checkNum = txtNum.Text
            checkDate = txtCheckDate.Text
            moNum = ""
            moDate = ""
            pTypeCash = ""
            pTypeCheck = "✓"
            pTypeMO = ""
        ElseIf rdbMO.Checked = True Then
            payType = "Money Order"
            checkBank = ""
            checkNum = ""
            checkDate = ""
            moNum = txtNum.Text
            moDate = txtCheckDate.Text
            pTypeCash = ""
            pTypeCheck = ""
            pTypeMO = "✓"
        End If
        Dim disctype As String = ""
        If cboDiscountType.Text = "Regular" Then
            disctype = "NO"
            txtSenID.Text = ""
            txtDiscount.Text = ""
        Else
            disctype = "YES"
        End If

        Dim firstWords As String = ""
        Dim secondWords As String = ""
        Dim strWords() As String = Split(UCase(ConvertNumberToWords(txtTotal.Text)), " ")
        If strWords.Count > 5 Then
            For x As Integer = 0 To 3
                firstWords = firstWords & " " & strWords(x)
            Next
            For y As Integer = 4 To strWords.Count - 1
                secondWords = secondWords & " " & strWords(y)
            Next
        Else
            firstWords = UCase(ConvertNumberToWords(txtTotal.Text))
            secondWords = ""
        End If

        cmd.Parameters.AddWithValue("@ptyp", payType)
        cmd.Parameters.AddWithValue("@dbank", checkBank)
        cmd.Parameters.AddWithValue("@dnum", checkNum)
        cmd.Parameters.AddWithValue("@ddate", checkDate)
        cmd.Parameters.AddWithValue("@amtwords", firstWords)
        cmd.Parameters.AddWithValue("@amtwords2", secondWords)
        cmd.Parameters.AddWithValue("@payDate", dtpDate.Value)
        cmd.Parameters.AddWithValue("@senrmk", disctype)
        cmd.Parameters.AddWithValue("@senid", txtSenID.Text)
        cmd.Parameters.AddWithValue("@totdisc", Val(txtDiscount.Text))
        cmd.Parameters.AddWithValue("@nat1", txtN1.Text)
        cmd.Parameters.AddWithValue("@nat2", txtN2.Text)
        cmd.Parameters.AddWithValue("@nat3", txtN3.Text)
        cmd.Parameters.AddWithValue("@nat4", txtN4.Text)
        cmd.Parameters.AddWithValue("@nat5", txtN5.Text)
        cmd.Parameters.AddWithValue("@nat6", txtN6.Text)
        cmd.Parameters.AddWithValue("@nat7", txtN7.Text)
        cmd.Parameters.AddWithValue("@nat8", txtN8.Text)
        cmd.Parameters.AddWithValue("@cod1", txtC1.Text)
        cmd.Parameters.AddWithValue("@cod2", txtC2.Text)
        cmd.Parameters.AddWithValue("@cod3", txtC3.Text)
        cmd.Parameters.AddWithValue("@cod4", txtC4.Text)
        cmd.Parameters.AddWithValue("@cod5", txtC5.Text)
        cmd.Parameters.AddWithValue("@cod6", txtC6.Text)
        cmd.Parameters.AddWithValue("@cod7", txtC7.Text)
        cmd.Parameters.AddWithValue("@cod8", txtC8.Text)
        cmd.Parameters.AddWithValue("@amt1", txtA1.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt2", txtA2.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt3", txtA3.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt4", txtA4.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt5", txtA5.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt6", txtA6.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt7", txtA7.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@amt8", txtA8.Text.Replace(",", ""))
        cmd.Parameters.AddWithValue("@colname", txtCollectionOfficer.Text)
        cmd.Parameters.AddWithValue("@cCheck", pTypeCash)
        cmd.Parameters.AddWithValue("@chCheck", pTypeCheck)
        cmd.Parameters.AddWithValue("@mocheck", pTypeMO)
        cmd.Parameters.AddWithValue("@moNum", moNum)
        cmd.Parameters.AddWithValue("@moDate", moDate)
        cmd.ExecuteNonQuery()
        MessageBox.Show("O.R. has been Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SaveORValues()
        Cons()
        Dim cmdUpdateBillOR As New MySqlCommand("UPDATE billing SET ORNumPaid=@ORN WHERE ORNumPaid=" & Val(defOR), con)
        cmdUpdateBillOR.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmdUpdateBillOR.ExecuteNonQuery()
        Dim cmdUpdatePrevBillOR As New MySqlCommand("UPDATE billing SET prevOutstandingOR=@ORN WHERE prevOutstandingOR='" & defOR & "'", con)
        cmdUpdatePrevBillOR.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmdUpdatePrevBillOR.ExecuteNonQuery()
        Dim cmdUpdatePayment As New MySqlCommand("UPDATE tblpayment SET ORNumber=@ORN, paymentDate=@pDate WHERE ORNumber='" & defOR & "'", con)
        cmdUpdatePayment.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmdUpdatePayment.Parameters.AddWithValue("@pDate", dtpDate.Value)
        cmdUpdatePayment.ExecuteNonQuery()
        Dim cmdUpdateDT As New MySqlCommand("UPDATE tbldailytransaction SET ORNum=@ORN WHERE ORNum='" & defOR & "'", con)
        cmdUpdateDT.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmdUpdateDT.ExecuteNonQuery()
        Dim cmdUpdateORUsage As New MySqlCommand("UPDATE tblorusage SET ORNum=@ORN WHERE ORNum='" & defOR & "'", con)
        cmdUpdateORUsage.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmdUpdateORUsage.ExecuteNonQuery()
        Dim cmdUpdatePaymentLogs As New MySqlCommand("UPDATE tblpaymentlogs SET ORNum=@ORN WHERE ORNum='" & defOR & "'", con)
        cmdUpdatePaymentLogs.Parameters.AddWithValue("@ORN", txtOR.Text)
        cmdUpdatePaymentLogs.ExecuteNonQuery()
    End Sub
End Class