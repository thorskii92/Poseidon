Imports MySql.Data
Imports MySql.Data.MySqlClient
Module CommandsMod
    Public globalAddressIndex As Integer
    Public globalProvID As Integer
    Public globalMunID As Integer
    Public brgyCode As String
    Public brgID As Integer
    Public brgStr As String
    Public claID As Integer
    Public claStr As String
    Public serNum As Integer
    Public accdataID As Integer
    Public selCusID As Integer
    Public selConsumerID As Integer
    Public serRepBill As Integer
    Public selectedAcctIDforDC As Integer
    Public totalCountAmount As Double
    Public Function NameOfCollector(userID As Integer) As String
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fullname FROM userlist WHERE uID=" & userID, con)
        da.Fill(dt)
        Dim getFullName As String = dt.Rows(0).Item(0).ToString
        Return getFullName
    End Function
    Public Sub recordBill()
        If BdateGen <> "" And BCount > 0 Then
            getSerial()
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM tblbillreport WHERE brgyID=" & BBgyID & " AND clusterID=" & BClus & " AND monthfrom='" & BmonthFrom & "' AND monthto='" & BmonthTo & "' AND billyear=" & BBYear, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
            Else
                Cons()
                Dim cmd As New MySqlCommand("INSERT INTO tblbillreport(dategenerated, monthfrom, monthto, billyear, billdate, billcount, brgyID, clusterid, uID, repID) VALUES(current_date(),'" & BmonthFrom & "','" & BmonthTo & "'," & BBYear & ",'" & Format(BBillDate, "yyyy-MM-dd") & "'," & BCount & "," & BBgyID & "," & BClus & "," & loggedUserID & "," & serRepBill & ")", con)
                cmd.ExecuteNonQuery()
                Dim cmdU As New MySqlCommand("UPDATE tblbills AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID  LEFT JOIN brgylist AS BG ON A.brgyID=BG.brgyID SET uID=" & loggedUserID & ", billRepID=" & serRepBill & " WHERE B.monthfrom='" & BmonthFrom & "' AND B.monthto='" & BmonthTo & "' AND B.billyear='" & BBYear & "' AND A.brgyID=" & BBgyID & " AND A.clusterID=" & BClus & " AND A.AcctStatus=1", con)
                cmdU.ExecuteNonQuery()
            End If
        End If
    End Sub

    Public Sub getSerial()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT max(repID) FROM tblbillreport", con)
        da.Fill(dt)
        Dim ch As Integer = Val(dt.Rows(0).Item(0).ToString)
        If ch = 0 Then
            serRepBill = 1
        Else
            serRepBill = serRepBill + 1
        End If
    End Sub


    Public Sub NewAddress(index As Integer, AddressName As String, chkVal As Boolean)
        If index = 1 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM provlist where provname='" & AddressName & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Province Name already Existing", MsgBoxStyle.Exclamation, "Same Province Name Found")
                Exit Sub
            Else
                Dim cmd As New MySqlCommand("INSERT INTO provlist(Provname) VALUES('" & AddressName & "')", con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "New Province", "Address Adder", "New Province " & AddressName & "")
                If chkVal = True Then
                    Cons()
                    Dim cmdDefZero As New MySqlCommand("UPDATE provlist SET provdefault=0", con)
                    cmdDefZero.ExecuteNonQuery()
                    Dim cmdDefNew As New MySqlCommand("UPDATE provlist SET provdefault=1 WHERE provname='" & AddressName & "'", con)
                    cmdDefNew.ExecuteNonQuery()
                End If
                ViewProvListSettings()
                frmAddressAdder.Close()
            End If
        ElseIf index = 2 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM munlist where municipality='" & AddressName & "' and addprovid=" & selectedProvID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Municipality Name already Existing", MsgBoxStyle.Exclamation, "Same Province Name Found")
                Exit Sub
            Else
                Dim cmd As New MySqlCommand("INSERT INTO munlist(addprovid, municipality) VALUES(" & selectedProvID & ",'" & AddressName & "')", con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "New Municipality", "Address Adder", "New Municipality '" & AddressName & "'")
                If chkVal = True Then
                    Cons()
                    Dim cmdDefZero As New MySqlCommand("UPDATE munlist SET default=0 WHERE addprovid=" & selectedProvID, con)
                    cmdDefZero.ExecuteNonQuery()
                    Dim cmdDefNew As New MySqlCommand("UPDATE munlist SET default=1 WHERE municipality='" & AddressName & "' and addprovid=" & selectedProvID, con)
                    cmdDefNew.ExecuteNonQuery()
                End If
                ViewMunListSettings(selectedProvID)
                frmAddressAdder.Close()
            End If
        ElseIf index = 3 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM provlist WHERE AddProvID <> " & editProvID & " AND ProvName='" & AddressName & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Already have the Same Provincial Name, Please try Another", MsgBoxStyle.Information, "Same Province Found")
                Exit Sub
            Else
                Dim dVal As Integer
                If chkVal = True Then
                    dVal = 1
                Else
                    dVal = 0
                End If
                Dim cmd As New MySqlCommand("UPDATE provlist SET provName='" & AddressName & "', provdefault=" & dVal & " WHERE addprovID=" & editProvID, con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Update Province", "Address Adder", "Updated Province Name of ProvID# " & editProvID & " to '" & AddressName & "'")
                ViewProvListSettings()
                frmAddressAdder.Close()
            End If

        ElseIf index = 4 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE clustername='" & AddressName & "' AND brgyID=" & selectedBrgyID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If MessageBox.Show("Same cluster name has been found in the same barangay, Do you want to Continue?", "Same Cluster Name Found", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim cmd As New MySqlCommand("INSERT INTO  clusterlist(brgyid, clustername) VALUES(@bgID, @clName)", con)
                    cmd.Parameters.AddWithValue("@bgID", selectedBrgyID)
                    cmd.Parameters.AddWithValue("@clName", AddressName)
                    cmd.ExecuteNonQuery()
                End If
            Else
                Dim cmd As New MySqlCommand("INSERT INTO  clusterlist(brgyid, clustername) VALUES(@bgID, @clName)", con)
                cmd.Parameters.AddWithValue("@bgID", selectedBrgyID)
                cmd.Parameters.AddWithValue("@clName", AddressName)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Insert New Cluster", "Address Adder", "Inserted new cluster name: " & AddressName & " with Brgy ID: " & selectedBrgyID & "")
                ViewClusterSettings(selectedBrgyID)
                frmAddressAdder.Close()
            End If
        End If
    End Sub

    Public Function AccountCode(BrgyID As Integer) As String
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT a.acctcodeid, a.brgyid, a.series, b.addbrgy, b.brgycode  FROM acctcodegen AS a LEFT JOIN brgylist AS b ON a.brgyid=b.brgyid WHERE a.brgyID=" & BrgyID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            serNum = Val(dt.Rows(0).Item(2)) + 1
            brgStr = dt.Rows(0).Item(4).ToString.Replace("-", "")
            accdataID = Val(dt.Rows(0).Item(0).ToString)
        Else
            Dim dtB As New DataTable
            Dim daB As New MySqlDataAdapter("SELECT brgyid, brgyCode FROM brgylist WHERE brgyID=" & BrgyID, con)
            daB.Fill(dtB)
            'If dtB.Rows.Count > 0 Then
            brgStr = dtB.Rows(0).Item(1).ToString.Replace("-", "")
            Dim cmd As New MySqlCommand("INSERT INTO acctcodegen(brgyid, series) VALUES(" & BrgyID & ",0)", con)
            cmd.ExecuteNonQuery()
            InsertLog(loggedUserID, "New Account Code", "AccountCode", "Inserted New Account Code for brgyID# " & BrgyID)
            Dim dtS As New DataTable
            Dim daS As New MySqlDataAdapter("SELECT * FROM acctcodegen WHERE brgyid=" & BrgyID, con)
            daS.Fill(dtS)
            serNum = Val(dtS.Rows(0).Item(2).ToString)
            accdataID = Val(dtS.Rows(0).Item(0).ToString)
        End If

        Dim tempAcct As String = Format(Val(serNum), "000#")
        Return tempAcct
    End Function

    Public Function GenerateAccountCode(brgyID As Integer, clusterID As Integer, classID As Integer) As String
        Dim sernum As Integer
        Dim clustercode As String = ""
        Dim classcode As String = ""
        Dim brCode As String = ""
        Dim datecode As String = Now.Month * Now.Year
        'Try
        Cons()

        Dim dtB As New DataTable
        Dim daB As New MySqlDataAdapter("SELECT * FROM brgylist WHERE brgyID=" & brgyID, con)
        daB.Fill(dtB)
        If dtB.Rows.Count > 0 Then
            brCode = dtB.Rows(0).Item(3).ToString
        End If

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT series FROM acctcodegen WHERE acctcodeid=1", con)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            sernum = Val(dt.Rows(0).Item(0)) + 1
        End If

        Dim dtL As New DataTable
        Dim daL As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE clusterID=" & clusterID, con)
        daL.Fill(dtL)
        If dtL.Rows.Count > 0 Then
            clustercode = dtL.Rows(0).Item(3).ToString
        End If

        Dim dtC As New DataTable
        Dim daC As New MySqlDataAdapter("SELECT * FROM classifications WHERE classID=" & classID, con)
        daC.Fill(dtC)
        If dtC.Rows.Count > 0 Then
            classcode = dtC.Rows(0).Item(2).ToString
        End If
        'Catch ex As Exception
        'End Try
        Dim tempAcct As String = brCode & "-" & clustercode & "-" & classcode & "-" & datecode & "-" & Format(sernum, "000#")
        Return tempAcct
    End Function

    Public Function LatestAcctCode(brgyID As Integer) As String
        'Dim tempAcct As String = Format(Val(serNum), "000#")
        Dim tempAcct As String
        Dim dtN As New DataTable
        Dim daN As New MySqlDataAdapter("SELECT max(accountno) FROM consumeraccounts where brgyid=" & brgyID, con)
        daN.Fill(dtN)
        If dtN.Rows.Count > 0 Then
            tempAcct = Val(dtN.Rows(0).Item(0)) + 1
            'serNum = serNum + 1
        Else
            tempAcct = "0000"
        End If
        Return tempAcct
    End Function

    Public Function SetAccountCode(BrgyID As Integer, ClassID As Integer, series As Integer) As String
        Cons()
        Dim dtB As New DataTable
        Dim daB As New MySqlDataAdapter("SELECT brgyid, brgyCode FROM brgylist WHERE brgyID=" & BrgyID, con)
        daB.Fill(dtB)
        brgStr = dtB.Rows(0).Item(1).ToString.Replace("-", "")
        Dim dtC As New DataTable
        Dim daC As New MySqlDataAdapter("SELECT classid, classcode FROM classifications WHERE classID=" & ClassID, con)
        daC.Fill(dtC)
        claStr = dtC.Rows(0).Item(1).ToString
        serNum = series
        SetAccountCode = brgStr & "-" & claStr & "-" & Format(Val(serNum), "000#")
    End Function

    Public Sub CountAmount()
        totalCountAmount = 0
        Dim amount As Double
        For x As Integer = 0 To frmPaymentCollection.lvwCollection.Items.Count - 1
            amount = amount + Val(frmPaymentCollection.lvwCollection.Items(x).SubItems(2).Text.ToString)
        Next
        totalCountAmount = amount
        frmPaymentCollection.lblTotal.Text = Format(amount, "0.#0")
        frmPaymentCollection.lblAmountInWords.Text = ConvertNumberToWords(amount.ToString)
        frmPaymentCollection.lblChange.Text = Format(Val(frmPaymentCollection.txtCash.Text) - totalCountAmount, "#,##0.#0")
    End Sub

    Public Sub UpdateDisconnection()
        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT MR.AcctID,MR.metid ,MR.DueDate,(SELECT Count(*) FROM meterreading AS MA WHERE MA.acctid=MR.acctID AND (MA.metstatus='UNPAID' OR MA.metstatus='LAPSE') GROUP BY MA.acctID) AS COUNTAcct, datediff(now(), MR.duedate) AS dateDifference FROM meterreading AS MR LEFT JOIN consumeraccounts as A ON MR.acctID=A.AcctID WHERE  (SELECT Count(*) FROM meterreading AS MA WHERE MA.acctid=MR.acctID AND (MA.metstatus='UNPAID' OR MA.metstatus='LAPSE') GROUP BY MA.acctID)>=2 AND MR.metstatus='UNPAID' AND (datediff(now(), MR.duedate))>=6 AND A.acctStatus='CONNECTED' GROUP BY MR.acctID", con)
        'da.Fill(dt)

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT BR.acctID, (select count(*) FROM billing AS BA WHERE BA.acctID=BR.acctID AND (BA.billstat='UNPAID' OR BA.billstat='LAPSE') GROUP BY BA.acctID) AS CountBills, datediff(now(), BR.duedate) AS dateDifference FROM billing AS BR LEFT JOIN consumeraccounts AS A ON BR.acctID=A.acctID WHERE (select count(*) FROM billing AS BA WHERE BA.acctID=BR.acctID AND (BA.billstat='UNPAID' OR BA.billstat='LAPSE') GROUP BY BA.acctID)>=2 AND (BR.billstat='UNPAID' OR BR.billstat='LAPSE') AND (datediff(now(), BR.duedate))>=6 AND A.acctStatus=1 GROUP BY BR.acctID", con)
        da.Fill(dt)



        If dt.Rows.Count > 0 Then
            Dim getAcctID(dt.Rows.Count - 1) As Integer
            For x As Integer = 0 To dt.Rows.Count - 1
                getAcctID(x) = Val(dt.Rows(x).Item(0).ToString)
            Next
            For y As Integer = 0 To dt.Rows.Count - 1
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET Acctstatus=4 WHERE acctID=" & getAcctID(y), con)
                cmd.ExecuteNonQuery()
            Next
            InsertLog(loggedUserID, "Disconnection", "Main System", "Updated System for Disconnection of Unpaid bills. Number of for Disconenction Accounts " & dt.Rows.Count & "")
            MsgBox(dt.Rows.Count.ToString & " Have been set for Disconnection", MsgBoxStyle.Information, "Disconnection Notice")
        Else
            MsgBox("There are No Accounts to be Disconnected", MsgBoxStyle.Information, "Disconnection Notice")
        End If
    End Sub

    Public Function PublicDataTable(Query As String) As DataTable
        Cons()
        PublicDataTable = New DataTable
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(Query, con)
        da.Fill(dt)
        'PublicDataTable = dt
        Return dt
    End Function

    Public Sub UpdateInstallment(acctID As Integer, amt As Decimal, payDate As Date)
        'MessageBox.Show(acctID & " " & amt & " " & payDate & " " & c)
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM applicationfeetotalbalance WHERE acctID=" & acctID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim gAmt As Decimal = Val(dt.Rows(0).Item(2).ToString)
            'Dim gRem As Integer = Val(dt.Rows(0).Item(3).ToString)
            Dim gID As Integer = Val(dt.Rows(0).Item(0).ToString)
            Dim newAmt As Decimal = gAmt - amt
            'Dim newRem As Integer = gRem - c
            Dim cmd As New MySqlCommand("UPDATE applicationfeetotalbalance SET balance=" & newAmt & " WHERE acctID=" & acctID, con)
            cmd.ExecuteNonQuery()
            Dim cmdAdd As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotID,Amount,paymentDate) VALUES(@fID,@amt,@pD)", con)
            cmdAdd.Parameters.AddWithValue("@fID", gID)
            cmdAdd.Parameters.AddWithValue("@amt", amt)
            cmdAdd.Parameters.AddWithValue("@pD", Format(payDate, "yyyy-MM-dd"))
            cmdAdd.ExecuteNonQuery()
        Else
            Dim gAmt As Decimal = 1500 - amt
            'Dim gRem As Integer = 12 - c
            Dim cmd As New MySqlCommand("INSERT INTO applicationfeetotalbalance(acctID,balance)VALUES(@aID,@bal)", con)
            cmd.Parameters.AddWithValue("@aID", acctID)
            cmd.Parameters.AddWithValue("@bal", gAmt)
            'cmd.Parameters.AddWithValue("@rem", gRem)
            cmd.ExecuteNonQuery()
            Dim dtB As New DataTable
            Dim daB As New MySqlDataAdapter("SELECT * FROM applicationfeetotalbalance WHERE acctID=" & acctID, con)
            daB.Fill(dtB)
            Dim gID As Integer = Val(dtB.Rows(0).Item(0).ToString)
            Dim cmdAdd As New MySqlCommand("INSERT INTO applicationfeebalance(afeetotID,Amount,paymentDate) VALUES(@fID,@amt,@pD)", con)
            cmdAdd.Parameters.AddWithValue("@fID", gID)
            cmdAdd.Parameters.AddWithValue("@amt", amt)
            cmdAdd.Parameters.AddWithValue("@pD", Format(payDate, "yyyy-MM-dd"))
            cmdAdd.ExecuteNonQuery()
        End If
    End Sub

End Module

