Imports MySql.Data.MySqlClient
'Imports poseidondll.clsConvertionDll
Public Class frmPaymentCollection
    Dim totalAmount As Double
    Dim dnums As String
    Dim ddate As String
    Dim dbank As String
    Dim valnum As String
    Dim valdate As String
    Dim valbank As String
    Dim strQuer As String
    Dim payValue As Double
    Dim payCol As String
    Dim cashAmount As Double
    Dim changeAmount As Double

    Dim nature(7) As String
    Dim accountType(7) As String
    Dim perAmount(7) As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Cons()
        frmNewConsumer.txtAddress.Text = ""
        frmNewConsumer.txtContact.Text = ""
        frmNewConsumer.txtName.Text = ""
        frmNewConsumer.ShowDialog()
        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        'da.Fill(dt)
        'frmNewCustomer.cboProv.Items.Clear()
        'If dt.Rows.Count > 0 Then
        '    ReDim arrComProvID(dt.Rows.Count - 1)
        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        arrComProvID(x) = dt.Rows(x).Item(0)
        '        frmNewCustomer.cboProv.Items.Add(dt.Rows(x).Item(1).ToString)
        '    Next
        'End If
        'frmNewCustomer.cboBrgy.Items.Clear()
        'frmNewCustomer.cboMun.Items.Clear()
        'frmNewCustomer.txtAddress.Text = ""
        'frmNewCustomer.txtConNum.Text = ""
        'frmNewCustomer.txtFName.Text = ""
        'frmNewCustomer.txtLName.Text = ""
        'frmNewCustomer.txtMName.Text = ""
        'frmNewCustomer.Show()
    End Sub

    Private Sub btnBrowseMember_Click(sender As Object, e As EventArgs) Handles btnBrowseMember.Click
        BrowseCustomerList()
        frmBrowseCustomer.StartPosition = FormStartPosition.CenterScreen
        frmBrowseCustomer.ShowInTaskbar = False
        frmBrowseCustomer.ShowDialog()
    End Sub

    Private Sub cboPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayment.SelectedIndexChanged
        If cboPayment.SelectedIndex = 0 Then
            lblNum.Visible = False
            txtNum.Visible = False
            lblDate.Visible = False
            dtpDateP.Visible = False
            lblBank.Visible = False
            txtDBank.Visible = False
            txtNum.Text = ""
            txtDBank.Text = ""
        ElseIf cboPayment.SelectedIndex = 1 Then
            lblNum.Visible = True
            txtNum.Visible = True
            lblDate.Visible = True
            dtpDateP.Visible = True
            lblBank.Visible = True
            txtDBank.Visible = True
            txtNum.Text = ""
            txtDBank.Text = ""
        ElseIf cboPayment.SelectedIndex = 2 Then
            lblNum.Visible = True
            txtNum.Visible = True
            lblDate.Visible = True
            dtpDateP.Visible = True
            lblBank.Visible = False
            txtDBank.Visible = False
            txtNum.Text = ""
            txtDBank.Text = ""
        End If
    End Sub

    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        frmPaymentSelection.StartPosition = FormStartPosition.CenterScreen
        frmPaymentSelection.ShowInTaskbar = False
        frmPaymentSelection.ShowDialog()
    End Sub

    Private Sub frmPaymentCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCash.Text = 0
        cashAmount = 0
        totalCountAmount = 0
        changeAmount = 0
        cboPayment.SelectedIndex = 0
        clearFields()
    End Sub

  
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If txtORNum.Text = "" Then
            MsgBox("Please enter OR Number", MsgBoxStyle.Exclamation, "No OR Number")
        Else
            Dim dtChOR As New DataTable
            Dim daChOR As New MySqlDataAdapter("SELECT * FROM tblor WHERE ORNum='" & txtORNum.Text.Replace("'", "''") & "'", con)
            daChOR.Fill(dtChOR)
            If dtChOR.Rows.Count > 0 Then
                MsgBox("Same OR Number found", MsgBoxStyle.Exclamation, "Same OR Number Found")
                Exit Sub
            Else
                If Val(cID.Text) = 0 Then
                    MsgBox("Please Select a Consumer", MsgBoxStyle.Exclamation, "No Consumer Selected")
                    Exit Sub
                Else


                    If MsgBox("Press 'Yes' to Confirm Payment", MsgBoxStyle.YesNo, "Payment Confirmation") = MsgBoxResult.Yes Then
                        Cons()
                        For y As Integer = 0 To 7
                            nature(y) = ""
                            accountType(y) = ""
                            perAmount(y) = ""
                        Next
                        If lvwCollection.Items.Count > 0 Then
                            For x As Integer = 0 To lvwCollection.Items.Count - 1
                                Dim payType As String = lvwCollection.Items(x).SubItems(3).Text
                                If payType = "Installation" Then
                                    payCol = "installpayment"
                                ElseIf payType = "Meter" Then
                                    payCol = "meterpayment"
                                ElseIf payType = "Ownership" Then
                                    payCol = "ownerpayment"
                                ElseIf payType = "Reconnection" Then
                                    payCol = "reconnectpayment"
                                ElseIf payType = "Service" Then
                                    payCol = "servicepayment"
                                ElseIf payType = "Advance" Then
                                    payCol = "advancepayment"
                                End If
                                payValue = Val(lvwCollection.Items(x).SubItems(2).Text)
                                Dim cmdP As New MySqlCommand("INSERT INTO tblpaymentlogs(consID," & payCol & ",monthpayment,yearpayment,datepayment) VALUES(@cID,@pval,@mPay,@yPay,current_date())", con)
                                cmdP.Parameters.AddWithValue("@cID", Val(cID.Text))
                                cmdP.Parameters.AddWithValue("@pval", payValue)
                                cmdP.Parameters.AddWithValue("@mPay", UCase(Format(Now.Date, "MMMM")))
                                cmdP.Parameters.AddWithValue("@yPay", Now.Year)
                                'cmdP.Parameters.AddWithValue("@dPay", Format(Now.Date, "yyyy-MM-dd"))
                                cmdP.ExecuteNonQuery()

                                Dim dtLog As New DataTable
                                Dim daLog As New MySqlDataAdapter("SELECT max(plID) FROM tblpaymentlogs", con)
                                daLog.Fill(dtLog)

                                Dim cmd As New MySqlCommand("INSERT INTO tblpayment(consID,ORNumber,pAmount,AcctCode,collectionnature,remark,uID,paymenttype,MonthOfPayment,yearOfPayment,plID) VALUES(@cusID, @ORNum, @Amt, @actCode, @colnat,@rmk, @usID, @ptype, @mPay, @yPay, @ploID)", con)
                                cmd.Parameters.AddWithValue("@cusID", Val(cID.Text))
                                cmd.Parameters.AddWithValue("@ORNum", txtORNum.Text)
                                cmd.Parameters.AddWithValue("@amt", Val(lvwCollection.Items(x).SubItems(2).Text))
                                cmd.Parameters.AddWithValue("@actCode", lvwCollection.Items(x).SubItems(1).Text)
                                cmd.Parameters.AddWithValue("@colnat", lvwCollection.Items(x).SubItems(0).Text)
                                cmd.Parameters.AddWithValue("@rmk", "Unused")
                                cmd.Parameters.AddWithValue("usID", loggedUserID)
                                cmd.Parameters.AddWithValue("@ptype", lvwCollection.Items(x).SubItems(3).Text)
                                cmd.Parameters.AddWithValue("@mPay", UCase(Format(Now, "MMMM")))
                                cmd.Parameters.AddWithValue("@yPay", Now.Year)
                                cmd.Parameters.AddWithValue("@ploID", Val(dtLog.Rows(0).Item(0).ToString))
                                cmd.ExecuteNonQuery()
                                Dim dtPID As New DataTable
                                Dim daPID As New MySqlDataAdapter("SELECT max(pID) FROM tblpayment", con)
                                daPID.Fill(dtPID)

                                Dim cmdDR As New MySqlCommand("INSERT INTO tblDailytransaction(consID,ORNum,connectionfee,others,drdate,pID) VALUES(@cID,@ORn,@confee,@other,current_date(),@payID)", con)
                                cmdDR.Parameters.AddWithValue("@cID", Val(cID.Text))
                                cmdDR.Parameters.AddWithValue("@ORn", txtORNum.Text)
                                If lvwCollection.Items(x).SubItems(3).Text = "Installation" Then
                                    cmdDR.Parameters.AddWithValue("@confee", Val(lvwCollection.Items(x).SubItems(2).Text))
                                    cmdDR.Parameters.AddWithValue("@other", Nothing)
                                Else
                                    cmdDR.Parameters.AddWithValue("@confee", Nothing)
                                    cmdDR.Parameters.AddWithValue("@other", Val(lvwCollection.Items(x).SubItems(2).Text))
                                End If
                                'cmdDR.Parameters.AddWithValue("@ddate", Format(Now.Date, "yyyy-MM-dd"))
                                cmdDR.Parameters.AddWithValue("@payID", Val(dtPID.Rows(0).Item(0).ToString))
                                cmdDR.ExecuteNonQuery()
                                nature(x) = lvwCollection.Items(x).Text
                                accountType(x) = lvwCollection.Items(x).SubItems(1).Text
                                perAmount(x) = lvwCollection.Items(x).SubItems(2).Text
                            Next


                            Dim pTypeCash As String = ""
                            Dim pTypeCheck As String = ""
                            Dim pTypeMO As String = ""
                            Dim strCBank As String
                            Dim strCNum As String
                            Dim strCDate As String
                            Dim strMNum As String
                            Dim strMDate As String
                            strCBank = ""
                            strCNum = ""
                            strCDate = ""
                            strMNum = ""
                            strMDate = ""
                            If cboPayment.Text = "Cash" Then
                                pTypeCash = "✓"
                                pTypeCheck = ""
                                pTypeMO = ""

                                strCBank = ""
                                strCNum = ""
                                strCDate = ""
                                strMNum = ""
                                strMDate = ""
                            ElseIf cboPayment.Text = "Check" Then
                                pTypeCash = ""
                                pTypeCheck = "✓"
                                pTypeMO = ""
                                strCBank = txtDBank.Text
                                strCNum = txtNum.Text
                                strCDate = dtpDateP.Value.Date.ToShortDateString
                                strMNum = ""
                                strMDate = ""
                            ElseIf cboPayment.Text = "Money Order" Then
                                pTypeCash = ""
                                pTypeCheck = ""
                                pTypeMO = "✓"
                                strCBank = ""
                                strCNum = ""
                                strCDate = ""
                                strMNum = txtNum.Text
                                strMDate = dtpDateP.Value.Date.ToShortDateString
                            End If
                            Dim firstWords As String = ""
                            Dim secondWords As String = ""
                            Dim strWords() As String = Split(UCase(ConvertNumberToWords(totalCountAmount.ToString)), " ")
                            If strWords.Count > 5 Then
                                For x As Integer = 0 To 3
                                    firstWords = firstWords & " " & strWords(x)
                                Next
                                For y As Integer = 4 To strWords.Count - 1
                                    secondWords = secondWords & " " & strWords(y)
                                Next
                            Else
                                firstWords = UCase(ConvertNumberToWords(totalCountAmount.ToString))
                                secondWords = ""
                            End If

                            'InsertToOR(txtORNum.Text, totalCountAmount, cboPayment.Text, strCBank, strCNum, strCDate, firstWords, secondWords, loggedUserID, dtpDate.Value.Date, Val(cID.Text), "NO", "", 0, nature(0), nature(1), nature(2), nature(3), nature(4), nature(5), nature(6), nature(7), accountType(0), accountType(1), accountType(2), accountType(3), accountType(4), accountType(5), accountType(6), accountType(7), perAmount(0), perAmount(1), perAmount(2), perAmount(3), perAmount(4), perAmount(5), perAmount(6), perAmount(7), "Mark Anthony D. Macatangay", pTypeCash, pTypeCheck, pTypeMO, strMNum, strMDate)

                            'strQuer = "INSERT INTO tblorrecord(ORNUm, totalpayment, ptype " & dnums & ddate & dbank & ", uid, amountinwords, pdate, consID) VALUES(@ORN, @totp, @pt" & valnum & valdate & valbank & ", @userid, @amtword, @datepaid, @conID)"
                            'If cboPayment.SelectedIndex = 0 Then
                            '    dnums = ""
                            '    ddate = ""
                            '    dbank = ""
                            '    valnum = ""
                            '    valdate = ""
                            '    valbank = ""
                            'ElseIf cboPayment.SelectedIndex = 1 Then
                            '    dnums = ", numpayment"
                            '    ddate = ", datepayment"
                            '    dbank = ", draweepayent"
                            '    valnum = ", @nump"
                            '    valdate = ", @dp"
                            '    valbank = ", @drp"
                            'ElseIf cboPayment.SelectedIndex = 2 Then
                            '    dnums = ", numpayment"
                            '    ddate = ", datepayment"
                            '    dbank = ""
                            '    valnum = ", @nump"
                            '    valdate = ", @dp"
                            '    valbank = ""
                            'End If
                            'Dim cmdOR As New MySqlCommand(strQuer, con)
                            'cmdOR.Parameters.AddWithValue("@ORN", txtORNum.Text)
                            'cmdOR.Parameters.AddWithValue("@totp", Val(lblTotal.Text))
                            'cmdOR.Parameters.AddWithValue("@pt", cboPayment.Text)
                            'If cboPayment.SelectedIndex = 1 Then
                            '    cmdOR.Parameters.AddWithValue("@nump", txtNum.Text)
                            '    cmdOR.Parameters.AddWithValue("@dp", Format(dtpDateP.Value, "yyyy-MM-dd"))
                            '    cmdOR.Parameters.AddWithValue("@drp", txtDBank.Text)
                            'ElseIf cboPayment.SelectedIndex = 2 Then
                            '    cmdOR.Parameters.AddWithValue("@nump", txtNum.Text)
                            '    cmdOR.Parameters.AddWithValue("@dp", Format(dtpDateP.Value, "yyyy-MM-dd"))
                            'End If
                            'cmdOR.Parameters.AddWithValue("@userid", "1")
                            'cmdOR.Parameters.AddWithValue("@amtword", lblAmountInWords.Text)
                            'cmdOR.Parameters.AddWithValue("@datepaid", Format(dtpDate.Value, "yyyy-MM-dd"))
                            'cmdOR.Parameters.AddWithValue("@conID", Val(cID.Text))
                            'cmdOR.ExecuteNonQuery()

                            'Dim dt As New DataTable
                            'Dim da As New MySqlDataAdapter("SELECT * FROM tblpayment AS P LEFT JOIN tblorrecord AS R ON P.ORNumber=R.ORNum LEFT JOIN userlist AS U ON R.uID=U.uID LEFT JOIN consumerlist AS C ON P.consID=C.consID WHERE ORNUM=" & txtORNum.Text, con)
                            'da.Fill(frmORReport.reportingdataset.ORDataset)
                            If MsgBox("Print Receipt?", MsgBoxStyle.YesNo, "Print Receipt") = MsgBoxResult.Yes Then
                                'ShowORReport(txtORNum.Text)
                                'frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                                'frmORReport.ORReport.ZoomPercent = 100%
                                'frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                                'frmORReport.ORReport.Width = 75
                                'frmORReport.WindowState = FormWindowState.Maximized
                                'frmORReport.Show()
                                Dim dtR As New DataTable
                                Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & txtORNum.Text & "'", con)
                                daR.Fill(dtR)
                                daR.Fill(frmORReport.reportingdataset.ORDataTable)
                                frmORReport.ORReport.RefreshReport()
                                frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                                frmORReport.ORReport.ZoomPercent = 100%
                                frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                                frmORReport.ORReport.Width = 75
                                frmORReport.WindowState = FormWindowState.Maximized
                                frmORReport.ShowDialog()
                            End If
                        End If
                        'updateCurOR(currentORNum)
                        updateCurOR(Val(txtORNum.Text))
                        clearFields()
                    End If

                End If

            End If

        End If

    End Sub

    Private Sub clearFields()
        txtDBank.Text = ""
        txtNum.Text = ""
        txtORNum.Text = currentOR(loggedUserID)
        lblAmountInWords.Text = ""
        lblBank.Text = ""
        'lblDate.Text = Format(Now.Date, "yyyy-MM-dd")
        lblName.Text = ""
        lblNum.Text = ""
        lblTotal.Text = "0.00"
        txtCash.Text = "0.00"
        lblChange.Text = "0.00"
        cashAmount = 0
        changeAmount = 0
        totalCountAmount = 0
        cID.Text = "0000"
        lvwCollection.Items.Clear()
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        cashAmount = Val(txtCash.Text)
        changeAmount = cashAmount - totalCountAmount
        lblChange.Text = Format(changeAmount, "#,##0.#0")
    End Sub

    Private Sub frmPaymentCollection_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        lblChange.Location = New Point(lblChange.Location.X, Me.Size.Height - 120)
    End Sub
End Class
