Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class frmImportExcel
    Dim xlApp As Excel.Application
    Dim xlWorkbook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlRange As Excel.Range
    Dim xlSheetNames As Excel.Sheets
    Dim rowCount As Integer
    Dim Data(0 To 100) As String
    Dim strDestination As String

    Public acctCode() As String
    Public arrimpName() As String
    Public arrimpIsSC() As String
    Public arrimpSenID() As String
    Public arrimpAddress() As String
    Public arrservAddress() As String
    Public arrimpBrgy() As String
    Public arrimpCluster() As String
    Public arrimpClusterID() As Integer
    Public arrimpBrgyID() As Integer
    Public arrimpZoneID() As Integer
    Public arrimpMun() As String
    Public arrimpProv() As String
    Public arrimpClass() As String
    Public arrimpCCID() As Integer
    Public arrimpConDate() As Date
    Public arrimpSerNum() As String
    Public arrimpMetBrand() As String
    Public arrimpMetSize() As String
    Public arrimpMetRef() As Integer
    Public arrimpContact() As String
    Public arrimpStat() As String
    Public arrimpGender() As String
    Public arrAvailability() As String
    Public arrSPipe() As String
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            With opPath
                .Filter = "Excel Office|*.xls;*.xlsx"
                .FileName = ""
                .ShowDialog()
                strDestination = .FileName
                lblFilePath.Text = .FileName
            End With
            cbo.Items.Clear()
            xlApp = New Excel.Application
            xlWorkbook = xlApp.Workbooks.Open(strDestination)
            For Each Sheets In xlWorkbook.Sheets
                cbo.Items.Add(Sheets.Name)
            Next
            cbo.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_Click(sender As Object, e As EventArgs) Handles cbo.Click

    End Sub

    Private Sub cbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo.SelectedIndexChanged
        Me.btnImport.Enabled = True
        Me.btnSave.Enabled = True
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If MsgBox("Do you want to start Importing the Accounts?", MsgBoxStyle.YesNo, "Poseidon Database System") = MsgBoxResult.Yes Then
            'Try
            lvw.Items.Clear()
            prb.Value = 0
            prb.Visible = True
            lbl.Visible = True
            lblImp.Visible = True
            lblImp.Text = 0
            'Dim xlCol As Integer
            Dim xlRow As Integer
            With lvw
                If strDestination <> "" And lblFilePath.Text <> "" Then
                    xlWorkSheet = DirectCast(xlWorkbook.Worksheets(cbo.Text), Excel.Worksheet)
                    xlRange = xlWorkSheet.UsedRange
                    If xlRange.Columns.Count > 0 Then
                        If xlRange.Rows.Count > 0 Then
                            Me.lblImp.Text = xlRange.Rows.Count - 1
                            rowCount = xlRange.Rows.Count - 1
                            ReDim arrimpAddress(rowCount)
                            ReDim acctCode(rowCount)
                            ReDim arrimpName(rowCount)
                            ReDim arrimpIsSC(rowCount)
                            ReDim arrimpSenID(rowCount)
                            ReDim arrservAddress(rowCount)
                            ReDim arrimpBrgy(rowCount)
                            ReDim arrimpCluster(rowCount)
                            ReDim arrimpClusterID(rowCount)
                            ReDim arrimpBrgyID(rowCount)
                            ReDim arrimpMun(rowCount)
                            ReDim arrimpProv(rowCount)
                            ReDim arrimpClass(rowCount)
                            ReDim arrimpCCID(rowCount)
                            ReDim arrimpConDate(rowCount)
                            ReDim arrimpSerNum(rowCount)
                            ReDim arrimpMetBrand(rowCount)
                            ReDim arrimpMetSize(rowCount)
                            ReDim arrimpMetRef(rowCount)
                            ReDim arrimpContact(rowCount)
                            ReDim arrimpStat(rowCount)
                            ReDim arrimpGender(rowCount)
                            ReDim arrAvailability(rowCount)
                            ReDim arrSPipe(rowCount)
                            'MessageBox.Show(rowCount)
                            For xlRow = 1 To (xlRange.Rows.Count - 1)
                                'MessageBox.Show(xlRow - 1)
                                acctCode(xlRow - 1) = xlRange.Cells(xlRow + 1, 1).text 'OK
                                arrAvailability(xlRow - 1) = AccountAvail(acctCode(xlRow - 1)) 'OK

                                arrimpName(xlRow - 1) = xlRange.Cells(xlRow + 1, 2).text 'OK
                                'MessageBox.Show(xlRange.Cells(xlRow + 1, 3).text)
                                arrimpIsSC(xlRow - 1) = xlRange.Cells(xlRow + 1, 14).text 'OK
                                arrimpSenID(xlRow - 1) = ""
                                'arrservAddress(xlRow - 1) = xlRange.Cells(xlRow + 1, 3).text
                                arrservAddress(xlRow - 1) = xlRange.Cells(xlRow + 1, 3).text 'OK
                                arrimpBrgy(xlRow - 1) = xlRange.Cells(xlRow + 1, 5).text 'OK
                                arrimpCluster(xlRow - 1) = xlRange.Cells(xlRow + 1, 3).text 'OK
                                arrimpClusterID(xlRow - 1) = xlRange.Cells(xlRow + 1, 4).text 'OK
                                arrimpBrgyID(xlRow - 1) = xlRange.Cells(xlRow + 1, 6).text 'OK
                                'arrimpZoneID(xlRow - 1) = xlRange.Cells(xlRow + 1, 15).text 'OK
                                arrimpMun(xlRow - 1) = 1
                                arrimpProv(xlRow - 1) = 3
                                arrSPipe(xlRow - 1) = xlRange.Cells(xlRow + 1, 7).text 'OK
                                arrimpClass(xlRow - 1) = xlRange.Cells(xlRow + 1, 8).text 'OK
                                arrimpCCID(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 9).text) 'OK
                                arrimpStat(xlRow - 1) = xlRange.Cells(xlRow + 1, 13).text 'OK
                                If arrimpStat(xlRow - 1) = "Installation" Then
                                    arrimpConDate(xlRow - 1) = Nothing
                                Else
                                    arrimpConDate(xlRow - 1) = Convert.ToDateTime(xlRange.Cells(xlRow + 1, 10).text) 'OK
                                End If

                                arrimpSerNum(xlRow - 1) = xlRange.Cells(xlRow + 1, 11).text 'OK
                                arrimpMetBrand(xlRow - 1) = ""
                                arrimpMetSize(xlRow - 1) = "1/2"
                                arrimpMetRef(xlRow - 1) = Val(xlRange.Cells(xlRow + 1, 12).text) 'OK
                                arrimpContact(xlRow - 1) = ""

                                arrimpGender(xlRow - 1) = ""

                                lbl.Text = "Import in progress: "
                                lblImp.Text = xlRow
                                prb.Value = (xlRow / rowCount) * 100
                            Next

                            For xlRow = 1 To xlRange.Rows.Count - 1
                                .Items.Add(acctCode(xlRow - 1)) '0
                                .Items(xlRow - 1).SubItems.Add(arrimpName(xlRow - 1)) '1
                                .Items(xlRow - 1).SubItems.Add(arrimpCluster(xlRow - 1)) '2
                                .Items(xlRow - 1).SubItems.Add(arrimpClusterID(xlRow - 1)) '3
                                .Items(xlRow - 1).SubItems.Add(arrimpBrgy(xlRow - 1)) '4
                                .Items(xlRow - 1).SubItems.Add(arrimpBrgyID(xlRow - 1)) '5
                                .Items(xlRow - 1).SubItems.Add(arrSPipe(xlRow - 1)) '6
                                .Items(xlRow - 1).SubItems.Add(arrimpClass(xlRow - 1)) '7
                                .Items(xlRow - 1).SubItems.Add(arrimpCCID(xlRow - 1)) '8
                                .Items(xlRow - 1).SubItems.Add(arrimpConDate(xlRow - 1)) '9
                                .Items(xlRow - 1).SubItems.Add(arrimpSerNum(xlRow - 1)) '10
                                .Items(xlRow - 1).SubItems.Add(arrimpMetRef(xlRow - 1)) '11
                                .Items(xlRow - 1).SubItems.Add(arrimpStat(xlRow - 1)) '12
                                .Items(xlRow - 1).SubItems.Add(arrimpIsSC(xlRow - 1)) '13
                                .Items(xlRow - 1).SubItems.Add(arrAvailability(xlRow - 1)) '14

                                lbl.Text = "Ready to Save: "
                                lblImp.Text = xlRow
                                prb.Value = (lvw.Items.Count / rowCount) * 100
                            Next
                            If prb.Value = 100 Then
                                prb.Visible = False
                                prb.Value = 0
                            End If

                            xlApp.Application.DisplayAlerts = False
                            If xlApp.ActiveWorkbook.Saved = False Then
                                xlApp.ActiveWorkbook.Save()
                            End If
                            xlWorkbook.Close()
                            xlApp.Quit()
                            releaseobject(xlApp)
                            releaseobject(xlWorkbook)
                            Me.lblFilePath.Text = ""
                            Me.cbo.Items.Clear()
                            Me.cbo.Text = ""
                            Me.btnImport.Enabled = False
                            Me.btnSave.Enabled = True
                        End If

                    End If
                    'OLDCODES///////////////////////////////////////////////////////////////////////////////
                    'xlApp = New Excel.Application
                    'xlWorkSheet = xlWorkbook.Worksheets(cbo.Text)
                    'xlRange = xlWorkSheet.UsedRange

                    'If xlRange.Columns.Count > 0 Then
                    '    If xlRange.Rows.Count > 0 Then
                    '        Me.lblImp.Text = xlRange.Rows.Count - 1
                    '        rowCount = xlRange.Rows.Count - 1
                    '        'Header

                    '        'Detail
                    '        For xlRow = 1 To xlRange.Rows.Count - 1
                    '            For xlCol = 1 To xlRange.Columns.Count
                    '                Data(xlCol) = xlRange.Cells(xlRow + 1, xlCol).text
                    '                If xlCol = 1 Then
                    '                    .Items.Add(Data(xlCol).ToString)
                    '                ElseIf xlCol = 19 Then
                    '                    .Items(xlRow - 1).SubItems.Add(Data(xlCol).ToString)
                    '                    .Items(xlRow - 1).SubItems.Add("")
                    '                Else
                    '                    'MsgBox(xlRow)
                    '                    .Items(xlRow - 1).SubItems.Add(Data(xlCol).ToString)
                    '                End If
                    '                prb.Value = (lvw.Items.Count / rowCount) * 100
                    '                lblImp.Text = lvw.Items.Count
                    '            Next
                    '        Next
                    '        If prb.Value = 100 Then
                    '            prb.Visible = False
                    '            prb.Value = 0
                    '        End If
                    '        codessplit()
                    '        xlApp.Application.DisplayAlerts = False
                    '        If xlApp.ActiveWorkbook.Saved = False Then
                    '            xlApp.ActiveWorkbook.Save()
                    '        End If
                    '        xlWorkbook.Close()
                    '        'xlApp.ActiveWorkbook.Close(SaveChanges:=False)
                    '        'xlApp.Application.DisplayAlerts = True
                    '        xlApp.Quit()
                    '        'xlApp = Nothing
                    '        releaseobject(xlApp)
                    '        releaseobject(xlWorkbook)
                    '        Me.lblFilePath.Text = ""
                    '        Me.cbo.Items.Clear()
                    '        Me.cbo.Text = ""
                    '        Me.btnImport.Enabled = False

                    '    End If
                    'End If
                    'OLDCODES///////////////////////////////////////////////////////////////////////////////
                Else
                    MessageBox.Show("Please input correct attributes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With

        End If
    End Sub

    Private Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Function AccountAvail(acctNum As String) As String
        Dim ava As String = ""
        If acctNum = "" Then
            ava = "Account No. is empty!"
        Else
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE accountNo='" & acctNum & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ava = "Unavailable"
            Else
                ava = "Available"
            End If
        End If

        Return ava
    End Function

    Private Sub codessplit()
        For x As Integer = 0 To Me.lvw.Items.Count - 1
            If lvw.Items(x).Text = "" Then
                lvw.Items(x).SubItems(19).Text = "Account No. Is Empty!"
            Else
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("Select * FROM consumeraccounts WHERE accountNo='" & Me.lvw.Items(x).Text & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    lvw.Items(x).SubItems(19).Text = "Unavailable"
                Else
                    lvw.Items(x).SubItems(19).Text = "Available"
                End If
                Conx()
            End If
        Next
    End Sub

    Private Sub frmImportExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCheckAccount.Visible = False
        btnRecheck.Visible = False
    End Sub

    Private Sub SaveAttribs()
        If MsgBox("Confirm Saving Imported Data to Database?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Cons()
            Dim countNotSaved As Integer
            Dim getConID As Integer
            Dim getBarID As Integer
            countNotSaved = 0

            Dim y As Integer = 0
            For x As Integer = 0 To lvw.Items.Count - 1
                If arrAvailability(x) = "Available" Then
                    Dim checkConsumer As String = arrimpName(x)
                    Dim checkBar As String = arrimpBrgy(x)
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist WHERE consumername='" & arrimpName(x).Replace("'", "''") & "'", con)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        getConID = Val(dt.Rows(0).Item(0).ToString)
                    Else
                        Dim cmd As New MySqlCommand("INSERT INTO consumerlist(consumername,contactNum,isSC,seniorID,gender) VALUES('" & arrimpName(x).Replace("'", "''") & "','" & arrimpContact(x).Replace("'", "") & "',@iSC,@iSen,@iGen)", con)
                        cmd.Parameters.AddWithValue("@iSC", arrimpIsSC(x))
                        cmd.Parameters.AddWithValue("@iSen", arrimpSenID(x))
                        cmd.Parameters.AddWithValue("@iGen", arrimpGender(x))
                        cmd.ExecuteNonQuery()
                        Dim dtGID As New DataTable
                        Dim daGID As New MySqlDataAdapter("SELECT consID FROM consumerlist WHERE consumername='" & arrimpName(x).Replace("'", "''") & "'", con)
                        daGID.Fill(dtGID)
                        getConID = Val(dtGID.Rows(0).Item(0).ToString)
                    End If
                    'Dim dtBar As New DataTable
                    'Dim daBar As New MySqlDataAdapter("SELECT brgyid FROM brgylist WHERE AddBrgy='" & checkBar & "' OR AddBrgy='" & UCase(checkBar) & "'", con)
                    'daBar.Fill(dtBar)
                    'If dtBar.Rows.Count > 0 Then
                    '    getBarID = Val(dtBar.Rows(0).Item(0).ToString)
                    'End If
                    getBarID = arrimpBrgyID(x)
                    'Dim GetSeqNum As Integer = clusterSequence(getBarID)

                    Dim strStat As String = (arrimpStat(x))
                    Dim dtStat As New DataTable
                    Dim daStat As New MySqlDataAdapter("SELECT * FROM accountstatus WHERE StatusName='" & strStat & "'", con)
                    'MessageBox.Show(strStat)
                    daStat.Fill(dtStat)
                    Dim cmdImpAccount As New MySqlCommand("INSERT INTO consumeraccounts(consID,classID,brgyID,clusterID,sequence,AccountNo,streetAddress,MeterNo,MeterReference,ConnectionDate,AcctStatus,CanDelete,isSenior,seniorID,AccountName,standpipe)VALUES(@CID,@CLID,@bID,@clusID,@seq,@AcctNo,@streetAdd,@MetNo,@MetReference,@ConDate,@ActStat,@CanDel,@isSen,@senID,@acctName,@spipe)", con)
                    cmdImpAccount.Parameters.AddWithValue("@CID", getConID)
                    cmdImpAccount.Parameters.AddWithValue("@CLID", arrimpCCID(x))
                    cmdImpAccount.Parameters.AddWithValue("@bID", arrimpBrgyID(x))
                    cmdImpAccount.Parameters.AddWithValue("@clusID", arrimpClusterID(x))
                    cmdImpAccount.Parameters.AddWithValue("@seq", Nothing)
                    cmdImpAccount.Parameters.AddWithValue("@AcctNo", acctCode(x))
                    cmdImpAccount.Parameters.AddWithValue("@streetAdd", arrservAddress(x))
                    cmdImpAccount.Parameters.AddWithValue("@MetNo", arrimpSerNum(x))

                    cmdImpAccount.Parameters.AddWithValue("@MetReference", arrimpMetRef(x))
                    'Dim coDate As Date = arrimpConDate(x)
                    If arrimpStat(x) = "Installation" Then
                        cmdImpAccount.Parameters.AddWithValue("@ConDate", Nothing)
                    Else
                        cmdImpAccount.Parameters.AddWithValue("@ConDate", Format(arrimpConDate(x), "yyyy-MM-dd"))
                    End If

                    cmdImpAccount.Parameters.AddWithValue("@ActStat", Val(dtStat.Rows(0).Item(0).ToString()))
                    cmdImpAccount.Parameters.AddWithValue("@CanDel", "YES")
                    cmdImpAccount.Parameters.AddWithValue("@isSen", arrimpIsSC(x))
                    cmdImpAccount.Parameters.AddWithValue("@senID", Nothing)
                    cmdImpAccount.Parameters.AddWithValue("@acctName", arrimpName(x).Replace("'", "''"))
                    cmdImpAccount.Parameters.AddWithValue("@spipe", arrSPipe(x))
                    cmdImpAccount.ExecuteNonQuery()
                    'Dim 
                End If
            Next
            lvw.Items.Clear()
            MsgBox("All Data has been saved Successfully!", MsgBoxStyle.Information, "POSEIDON DATABASE SYSTEM")
        End If
    End Sub

    Private Function clusterSequence(ByVal brgyID As Integer) As Integer
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT max(sequence) FROM consumeraccounts WHERE brgyID=" & brgyID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim x As Integer = Val(dt.Rows(0).Item(0).ToString)
            clusterSequence = x + 1
        Else
            clusterSequence = 1
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveAttribs()
    End Sub

    Private Sub lvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvw.SelectedIndexChanged
        If lvw.FocusedItem.SubItems(14).Text = "Unavailable" Then
            btnCheckAccount.Visible = True
            btnRecheck.Visible = True
        Else
            btnCheckAccount.Visible = False
            btnRecheck.Visible = False
        End If
    End Sub

    Private Sub btnCheckAccount_Click(sender As Object, e As EventArgs) Handles btnCheckAccount.Click
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT AccountNo, AccountName FROM consumeraccounts WHERE accountno='" & lvw.FocusedItem.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("The Account #'" & dt.Rows(0).Item(0).ToString & "' belongs to " & dt.Rows(0).Item(1).ToString)
        End If
    End Sub

    Private Sub btnRecheck_Click(sender As Object, e As EventArgs) Handles btnRecheck.Click
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumeraccounts WHERE AccountNo='" & lvw.FocusedItem.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Account is still Unavailable")
        Else
            lvw.FocusedItem.SubItems(19).Text = "Available"
            btnRecheck.Visible = False
            btnCheckAccount.Visible = False
        End If
    End Sub
End Class