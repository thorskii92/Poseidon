Imports MySql.Data.MySqlClient
Imports System.Math
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmORList
    Dim maxOr As Integer
    Dim arrORID() As Integer
    Dim arrORGroup() As Integer
    Dim arrORGroupID() As Integer
    Public DRFirstNum As Integer
    Public DRFinalNum As Integer
    Private Sub frmORList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadORGroup()
        ClearFields()
        DRFirstNum = 0
        DRFinalNum = 0
        'LoadOR()
        btnPrint.Visible = False
        btnCancel.Visible = False
        btnDelete.Visible = False
        btnEditOR.Visible = False
        'ORNumSelected("")
        LoadLastOR()
        'cboGroup.Text = ""
        'castPage()
    End Sub

    Private Sub LoadLastOR()
        Dim dtLast As New DataTable
        Dim daLast As New MySqlDataAdapter("SELECT ORNum FROM tblOR where orID=(select max(orID) FROM tblOR)", con)
        daLast.Fill(dtLast)
        If dtLast.Rows.Count > 0 Then

            Dim ORnumSearch As String = dtLast.Rows(0).Item(0).ToString
            'MessageBox.Show(ORnumSearch)
            'ORStr(x) = dt.Rows(x).Item(0).ToString

            Dim firstNum As Integer = Val(ORnumSearch)
            Dim modNum As Integer = firstNum Mod 50
            Dim newNum As Integer = firstNum
            If modNum = 0 Then
                newNum = newNum - 1
            End If
            Dim down As Integer = Floor(newNum / 50) * 50 + 1
            'Dim lastNum As Integer = Val(ORSer(x))
            Dim upper As Integer = Ceiling(newNum / 50) * 50
            Dim strORSearch As String = Format(down, "000000#") & " to " & Format(upper, "000000#")
            Try
                cboGroup.Text = strORSearch
                'ORNumSelected(txtSearch.Text)
                For Each lvi As ListViewItem In lvwOR.Items
                    For Each lvwSub As ListViewItem.ListViewSubItem In lvi.SubItems
                        If lvwSub.Text = ORnumSearch Then
                            lvwOR.SelectedIndices.Add(lvi.Index)
                            Exit For
                        End If
                    Next
                Next
                lvwOR.Focus()

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM tblOR WHERE ORNum='" & ORnumSearch & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    ORNumSelected(ORnumSearch)
                Else
                    MessageBox.Show("O.R. Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                'lvwOR.Select
            Catch ex As Exception
                'MessageBox.Show("O.R. Not Found", "No found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If


    End Sub


    Private Sub castPage()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT MAX(cast(ORNum as unsigned)) FROM tblorrecord", con)
        da.Fill(dt)
        maxOr = 0
        cboGroup.Items.Clear()
        lvwOR.Items.Clear()
        If dt.Rows.Count > 0 Then
            maxOr = Val(dt.Rows(0).Item(0).ToString)
            Dim pageCount As Integer = (maxOr \ 50) + 1
            For x As Integer = 0 To pageCount - 1
                cboGroup.Items.Add((x * 50) + 1 & " TO " & (x * 50) + 50)
            Next
        End If
    End Sub



    Private Sub cboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroup.SelectedIndexChanged
        If Not IsNothing(cboGroup.SelectedText) Then
            SelectedORGroupList(arrGrORID(cboGroup.SelectedIndex))

            'lvwOR.Items.Clear()
            'For x As Integer = ((cboGroup.SelectedIndex * 50) + 1) To ((cboGroup.SelectedIndex * 50) + 50)
            '    Dim lst As New ListViewItem
            '    lst.Text = Format(x, "000000#")
            '    Dim dt As New DataTable
            '    Dim da As New MySqlDataAdapter("SELECT C.consumername, O.totalpayment, U.fullname FROM tblORRecord AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE ORNum='" & Format(x, "000000#") & "'", con)
            '    da.Fill(dt)
            '    If dt.Rows.Count > 0 Then
            '        lst.SubItems.Add(dt.Rows(0).Item(0).ToString)
            '        lst.SubItems.Add(Format(Val(dt.Rows(0).Item(1).ToString), "#,##0.#0"))
            '        lst.SubItems.Add(dt.Rows(0).Item(2).ToString)
            '    Else
            '        lst.SubItems.Add("")
            '        lst.SubItems.Add("")
            '        lst.SubItems.Add("")
            '    End If
            '    lvwOR.Items.Add(lst)
            'Next
            'Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID", con)
            'da.Fill(dt)
        Else
            lvwOR.Items.Clear()

        End If
    End Sub

    Public Sub SelectedORGroupList(groupID As Integer)
        ClearFields()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblorgroup WHERE ogID=" & groupID, con)
        da.Fill(dt)
        lvwOR.Items.Clear()
        Dim firstNum As Integer = Val(dt.Rows(0).Item(2))
        Dim finalNum As Integer = Val(dt.Rows(0).Item(3))
        DRFirstNum = firstNum
        DRFinalNum = finalNum
        If dt.Rows.Count > 0 Then
            ReDim arrORGroupID(49)
            For x As Integer = firstNum To finalNum
                Dim lst As New ListViewItem
                lst.Text = Format(x, "000000#")

                Dim dtGro As New DataTable
                Dim daGro As New MySqlDataAdapter("SELECT orID FROM tblOR WHERE ORNum='" & Format(x, "000000#") & "'", con)
                daGro.Fill(dtGro)
                If dtGro.Rows.Count > 0 Then
                    Dim cmd As New MySqlCommand("UPDATE tblOR SET ogID=" & groupID & " WHERE ORNum='" & Format(x, "000000#") & "'", con)
                    cmd.ExecuteNonQuery()
                End If
                Dim dtGetOR As New DataTable
                Dim daGetOR As New MySqlDataAdapter("SELECT O.orID, O.ORNum, C.consumername, O.totalPayment, O.collectorname, O.orRemark, O.pDate, O.ogID FROM tblOR AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE ORNum='" & Format(x, "000000#") & "'", con)
                daGetOR.Fill(dtGetOR)
                'MessageBox.Show(x)

                If dtGetOR.Rows.Count > 0 Then

                    Dim isRMK As String = dtGetOR.Rows(0).Item(5).ToString
                    If isRMK = "Cancelled" Then
                        lst.BackColor = Color.Red
                        lst.SubItems.Add("Cancelled O.R.")
                        lst.SubItems.Add("")
                        Try
                            lst.SubItems.Add(Format(dtGetOR.Rows(0).Item(6), "MM-dd-yyyy"))
                        Catch ex As Exception
                            lst.SubItems.Add("")
                        End Try

                        lst.SubItems.Add("")
                        lst.SubItems.Add(dtGetOR.Rows(0).Item(7).ToString)
                    Else
                        lst.BackColor = Color.White
                        arrORGroupID(x - firstNum) = Val(dtGetOR.Rows(0).Item(0).ToString)
                        lst.SubItems.Add(dtGetOR.Rows(0).Item(2).ToString)
                        lst.SubItems.Add(Format(Val(dtGetOR.Rows(0).Item(3)), "#,##0.#0"))
                        lst.SubItems.Add(Format(dtGetOR.Rows(0).Item(6), "MM-dd-yyyy"))
                        lst.SubItems.Add(dtGetOR.Rows(0).Item(4).ToString)
                        lst.SubItems.Add(dtGetOR.Rows(0).Item(7).ToString)
                    End If


                Else
                    arrORGroupID(x - firstNum) = 0
                    lst.SubItems.Add("")
                    lst.SubItems.Add("")
                    lst.SubItems.Add("")
                    lst.SubItems.Add("")
                    lst.SubItems.Add("")
                    lst.BackColor = Color.White
                End If
                lvwOR.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub LoadOR()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT O.orID, O.ORNum, C.consumername, O.totalpayment, O.collectorname FROM tblOR AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID", con)
        da.Fill(dt)
        lvwOR.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrORID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                arrORID(x) = Val(dt.Rows(x).Item(0).ToString)
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lvwOR.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub lvwOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwOR.SelectedIndexChanged
        'ClearFields()
        Try
            If lvwOR.SelectedItems.Count > 0 Then
                ORNum = lvwOR.FocusedItem.Text
                ORNumSelected(lvwOR.FocusedItem.Text)
                btnCancel.Visible = True
            Else
                ORNumSelected("")
                btnPrint.Visible = False
                btnCancel.Visible = False
                btnDelete.Visible = False
                btnEditOR.Visible = False
            End If
        Catch ex As Exception
            ORNumSelected("")
            btnPrint.Visible = False
            btnCancel.Visible = False
            btnDelete.Visible = False
            btnEditOR.Visible = False
        End Try


    End Sub

    Private Sub ClearFields()
        lblOR.Text = ""
        lblDate.Text = ""
        lblConsumer.Text = ""
        lvw.Items.Clear()
        lblType.Text = ""
        lblAmount.Text = ""
        lblWords.Text = ""
        lblDraweeNum.Text = ""
        lblDrawee.Text = ""
        lblDraweeDate.Text = ""
        lblDiscType.Text = ""
        lblHolder.Text = ""
        lblID.Text = ""
        lblDiscount.Text = ""
    End Sub

    Private Sub btnNewGroup_Click(sender As Object, e As EventArgs) Handles btnNewGroup.Click
        frmORGroup.StartPosition = FormStartPosition.CenterScreen
        frmORGroup.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Dim dtR As New DataTable
        'Dim daR As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lblOR.Text & "'", con)
        'daR.Fill(dtR)
        'daR.Fill(frmORReport.reportingdataset.ORDataTable)
        'frmORReport.ORReport.RefreshReport()
        'frmORReport.ORReport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'frmORReport.ORReport.ZoomPercent = 100%
        'frmORReport.ORReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        'frmORReport.ORReport.Width = 75
        'frmORReport.WindowState = FormWindowState.Maximized
        'frmORReport.ShowDialog()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN userlist AS U ON O.uID=U.uID WHERE O.ORNum='" & lblOR.Text & "'", con)
        Dim dSet As New reportingdataset
        'da.Fill(dSet)
        da.Fill(dt)
        Dim report As New crptOR
        report.SetDataSource(dt)
        frmCrystalOR.CrystalReportViewer1.ReportSource = report
        frmCrystalOR.CrystalReportViewer1.Zoom(100%)
        frmCrystalOR.CrystalReportViewer1.Refresh()
        'frmCrystalOR.CrystalReportViewer1.RefreshReport()
        frmCrystalOR.WindowState = FormWindowState.Maximized
        frmCrystalOR.ShowDialog()
    End Sub


    'Private Sub UpdateORPayment(ornum As String)
    '    Cons()
    '    Dim cmdPayment As New MySqlCommand("DELETE FROM tblPayment WHERE ORNumber='" & ornum & "'", con)
    '    cmdPayment.ExecuteNonQuery()
    '    Dim cmdPL As New MySqlCommand("DELETE FROM tblpaymentlogs WHERE ORNum='" & ornum & "'", con)
    '    cmdPL.ExecuteNonQuery()
    '    Dim cmdDT As New MySqlCommand("DELETE FROM tbldailytransaction WHERE ORNum='" & ornum & "'", con)
    '    cmdDT.ExecuteNonQuery()
    '    Dim cmdORUsage As New MySqlCommand("DELETE FROM tblorusage WHERE ORNum='" & ornum & "'", con)
    '    cmdORUsage.ExecuteNonQuery()
    '    Dim cmdUpdateBill As New MySqlCommand("UPDATE billing SET ORNumPaid=NULL, billStat='UNPAID' WHERE ORNumPaid=" & Val(ornum), con)
    '    cmdUpdateBill.ExecuteNonQuery()
    '    Dim cmdUpdateOutstand As New MySqlCommand("UPDATE billing SET prevOutstandingOR=NULL, prevOutstandingStat='UNPAID' WHERE prevOutstandingOR='" & ornum & "' and billMonth='November'", con)
    '    cmdUpdateOutstand.ExecuteNonQuery()
    'End Sub

    Private Sub btnEditOR_Click(sender As Object, e As EventArgs) Handles btnEditOR.Click
        'MessageBox.Show(arrORGroupID(lvwOR.FocusedItem.Index))
        Cons()
        editORFromForm = 1
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblOR AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE orID=" & arrORGroupID(lvwOR.FocusedItem.Index), con)
        da.Fill(dt)
        With frmEditOR

            .defOR = dt.Rows(0).Item(1).ToString
            .selORID = arrORGroupID(lvwOR.FocusedItem.Index)
            .txtOR.Text = dt.Rows(0).Item(1).ToString
            .dtpDate.Value = dt.Rows(0).Item(10)
            .lblConsumerName.Text = dt.Rows(0).Item(47).ToString
            .txtN1.Text = dt.Rows(0).Item(15).ToString
            .txtN2.Text = dt.Rows(0).Item(16).ToString
            .txtN3.Text = dt.Rows(0).Item(17).ToString
            .txtN4.Text = dt.Rows(0).Item(18).ToString
            .txtN5.Text = dt.Rows(0).Item(19).ToString
            .txtN6.Text = dt.Rows(0).Item(20).ToString
            .txtN7.Text = dt.Rows(0).Item(21).ToString
            .txtN8.Text = dt.Rows(0).Item(22).ToString
            .txtC1.Text = dt.Rows(0).Item(23).ToString
            .txtC2.Text = dt.Rows(0).Item(24).ToString
            .txtC3.Text = dt.Rows(0).Item(25).ToString
            .txtC4.Text = dt.Rows(0).Item(26).ToString
            .txtC5.Text = dt.Rows(0).Item(27).ToString
            .txtC6.Text = dt.Rows(0).Item(28).ToString
            .txtC7.Text = dt.Rows(0).Item(29).ToString
            .txtC8.Text = dt.Rows(0).Item(30).ToString
            .txtA1.Text = dt.Rows(0).Item(31).ToString.Replace(",", "")
            .txtA2.Text = dt.Rows(0).Item(32).ToString.Replace(",", "")
            .txtA3.Text = dt.Rows(0).Item(33).ToString.Replace(",", "")
            .txtA4.Text = dt.Rows(0).Item(34).ToString.Replace(",", "")
            .txtA5.Text = dt.Rows(0).Item(35).ToString.Replace(",", "")
            .txtA6.Text = dt.Rows(0).Item(36).ToString.Replace(",", "")
            .txtA7.Text = dt.Rows(0).Item(37).ToString.Replace(",", "")
            .txtA8.Text = dt.Rows(0).Item(38).ToString.Replace(",", "")
            .txtCollectionOfficer.Text = dt.Rows(0).Item(39).ToString
            Dim pType As String = dt.Rows(0).Item(3).ToString
            If pType = "Cash" Then
                .rdbCash.Checked = True
                .rdbCheck.Checked = False
                .rdbMO.Checked = False
                .txtBank.Text = ""
                .txtNum.Text = ""
                .txtCheckDate.Text = ""
                .txtBank.Enabled = False
                .txtNum.Enabled = False
                .txtCheckDate.Enabled = False
            ElseIf pType = "Check" Then
                .rdbCash.Checked = False
                .rdbCheck.Checked = True
                .rdbMO.Checked = False
                .txtBank.Text = dt.Rows(0).Item(4).ToString
                .txtNum.Text = dt.Rows(0).Item(5).ToString
                .txtCheckDate.Text = dt.Rows(0).Item(6).ToString
                .txtBank.Enabled = True
                .txtNum.Enabled = True
                .txtCheckDate.Enabled = True
            Else
                .rdbCash.Checked = False
                .rdbCheck.Checked = False
                .rdbMO.Checked = True
                .txtBank.Text = ""
                .txtNum.Text = dt.Rows(0).Item(43).ToString
                .txtCheckDate.Text = dt.Rows(0).Item(44).ToString
                .txtBank.Enabled = False
                .txtNum.Enabled = True
                .txtCheckDate.Enabled = True
            End If
            Dim disType As String = dt.Rows(0).Item(12).ToString
            If disType = "NO" Then
                .cboDiscountType.Text = "Regular"
                .txtSenID.Text = ""
                .txtDiscount.Text = ""
                .txtSenID.Enabled = False
                .txtDiscount.Enabled = False
            Else
                .cboDiscountType.Text = "Senior/PWD"
                .txtSenID.Text = dt.Rows(0).Item(13).ToString
                .txtDiscount.Text = dt.Rows(0).Item(14).ToString
                .txtSenID.Enabled = True
                .txtDiscount.Enabled = True
            End If
            '.cboDiscountType.Text = ""

            .txtTotal.Text = Format(Val(dt.Rows(0).Item(2).ToString), "#,##0.#0")
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()

        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Confirm Cancelling O.R.? Please note that this is irreversible.", "Cancel O.R.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM tblOR where ORNum='" & lvwOR.FocusedItem.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim strRem As String = dt.Rows(0).Item(45).ToString
                If strRem = "Cancelled" Then
                    frmCancellationDate.orNum = lvwOR.FocusedItem.Text
                    frmCancellationDate.ShowDialog()
                Else
                    Cons()
                    'UpdateORPayment(lblOR.Text)
                    Dim cmd As New MySqlCommand("UPDATE tblOR SET orRemark='Cancelled', totalpayment=NULL, ptype=NULL, draweebank=NULL, draweeNum=NULL, draweedate=NULL, amountinwords=NULL, amountinwords2=NULL, consID=NULL, seniorrmk=NULL, seniorID=NULL, totaldiscount=NULL, nature1=NULL, nature2=NULL, nature3=NULL, nature4=NULL, nature5=NULL, nature6=NULL, nature7=NULL, nature8=NULL, code1=NULL, code2=NULL, code3=NULL, code4=NULL, code5=NULL, code6=NULL, code7=NULL, code8=NULL, amount1=NULL, amount2=NULL, amount3=NULL, amount4=NULL, amount5=NULL, amount6=NULL, amount7=NULL, amount8=NULL, collectorname=NULL, cashCheck=NULL, checkCheck=NULL, MoneyOrderCheck=NULL, moneyordernum=NULL, moneyorderdate=NULL, billAmount=NULL, adjustmentAmount=NULL, penaltyAmt=NULL, EFAmt=NULL, ApplicationFee=NULL, ReconnectionFee=NULL, TransferFee=NULL  WHERE ORNum='" & lvwOR.FocusedItem.Text & "'", con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("O.R. has been cancelled", "O.R. Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SelectedORGroupList(arrGrORID(cboGroup.SelectedIndex))
                End If
            Else
                frmCancellationDate.orNum = lvwOR.FocusedItem.Text
                frmCancellationDate.ShowDialog()
            End If

        End If
    End Sub

    Private Sub btnDailyCollection_Click(sender As Object, e As EventArgs) Handles btnDailyCollection.Click
        If DRFirstNum = 0 Or DRFinalNum = 0 Then
            MessageBox.Show("Please select a Group", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'frmEnterRDNum.txtRDNum.Text = ""
            'frmEnterRDNum.StartPosition = FormStartPosition.CenterScreen
            'frmEnterRDNum.ShowDialog()
            Dim dt As New DataTable
            'Dim da As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE CAST(ORNum AS UNSIGNED) >= " & DRFirstNum & " AND CAST(ORNum AS UNSIGNED)<=" & DRFinalNum & " ORDER BY ORNum", con)
            Dim da As New MySqlDataAdapter("SELECT * FROM tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID LEFT JOIN consumeraccounts AS A ON O.acctID=A.acctID WHERE CAST(ORNum AS UNSIGNED) >= " & DRFirstNum & " AND CAST(ORNum AS UNSIGNED)<=" & DRFinalNum & " ORDER BY ORNum", con)
            da.Fill(dt)
            'Dim report As New crptDailyCollection
            Dim report As New crptNarraDailyCollection
            'report.SetParameterValue("txtRDNum", EnteredRD)
            report.SetDataSource(dt)

            'frmDailyCollectionReport.CrystalReportViewer1.ReportSource = report
            'frmDailyCollectionReport.CrystalReportViewer1.Zoom(100%)
            'frmDailyCollectionReport.CrystalReportViewer1.Refresh()
            ''frmCrystalOR.CrystalReportViewer1.RefreshReport()
            'frmDailyCollectionReport.WindowState = FormWindowState.Maximized
            'frmDailyCollectionReport.ShowDialog()
            frmNarraDailyCollection.CrystalReportViewer1.ReportSource = report
            frmNarraDailyCollection.CrystalReportViewer1.Zoom(100%)
            frmNarraDailyCollection.CrystalReportViewer1.Refresh()
            'frmCrystalOR.CrystalReportViewer1.RefreshReport()
            frmNarraDailyCollection.WindowState = FormWindowState.Maximized
            frmNarraDailyCollection.ShowDialog()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("Textbox is Empty", "Empty text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else

            Dim ORnumSearch As String = txtSearch.Text
            'ORStr(x) = dt.Rows(x).Item(0).ToString

            Dim firstNum As Integer = Val(ORnumSearch)
            Dim modNum As Integer = firstNum Mod 50
            Dim newNum As Integer = firstNum
            If modNum = 0 Then
                newNum = newNum - 1
            End If
            Dim down As Integer = Floor(newNum / 50) * 50 + 1
            'Dim lastNum As Integer = Val(ORSer(x))
            Dim upper As Integer = Ceiling(newNum / 50) * 50
            Dim strORSearch As String = Format(down, "000000#") & " to " & Format(upper, "000000#")
            Try
                cboGroup.Text = strORSearch
                'ORNumSelected(txtSearch.Text)
                For Each lvi As ListViewItem In lvwOR.Items
                    For Each lvwSub As ListViewItem.ListViewSubItem In lvi.SubItems
                        If lvwSub.Text = txtSearch.Text Then
                            lvwOR.SelectedIndices.Add(lvi.Index)
                            Exit For
                        End If
                    Next
                Next
                lvwOR.Focus()

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM tblOR WHERE ORNum='" & txtSearch.Text & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    ORNumSelected(txtSearch.Text)
                Else
                    MessageBox.Show("O.R. Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                'lvwOR.Select
            Catch ex As Exception
                'MessageBox.Show("O.R. Not Found", "No found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try


        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call btnSearch_Click(sender, e)
        End If

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvwOR.SelectedItems.Count > 0 Then
            If MessageBox.Show("Delete Selected OR Number " & lvwOR.FocusedItem.Text & "?", "Delete OR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cons()
                Dim cmdOR As New MySqlCommand("DELETE FROM tblOR WHERE ORNum='" & lvwOR.FocusedItem.Text & "'", con)
                cmdOR.ExecuteNonQuery()
                Dim cmdDelP As New MySqlCommand("DELETE FROM tblpayment WHERE ORNumber='" & lvwOR.FocusedItem.Text & "'", con)
                cmdDelP.ExecuteNonQuery()
                Dim cmdDelPL As New MySqlCommand("DELETE FROM tblpaymentlogs WHERE ORNum='" & lvwOR.FocusedItem.Text & "'", con)
                cmdDelPL.ExecuteNonQuery()
                Dim cmdDelOUse As New MySqlCommand("DELETE FROM tblorusage WHERE ORNum='" & lvwOR.FocusedItem.Text & "'", con)
                cmdDelOUse.ExecuteNonQuery()
                Dim cmdUpdateBill As New MySqlCommand("UPDATE billing SET ORNumPaid=NULL, billStat='UNPAID' WHERE ORNumPaid=" & Val(lvwOR.FocusedItem.Text), con)
                cmdUpdateBill.ExecuteNonQuery()
                Dim cmdUpdateOutstand As New MySqlCommand("UPDATE billing SET prevOutstandingOR=NULL, prevOutstandingStat='UNPAID' WHERE prevOutstandingOR='" & lvwOR.FocusedItem.Text & "' and billMonth='November'", con)
                cmdUpdateOutstand.ExecuteNonQuery()
                'UpdateORPayment(lblOR.Text)
                MessageBox.Show("O.R. has been deleted", "O.R. Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SelectedORGroupList(arrGrORID(cboGroup.SelectedIndex))
            End If

        End If
    End Sub
End Class