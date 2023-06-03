Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class accessCheckList

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim btools As Integer = CInt(Int(chkTools.Checked))
        Dim baccounting As Integer = CInt(Int(chkAccountingTab.Checked))
        Dim bbilling As Integer = CInt(Int(chkBilling.Checked))
        Dim bcollection As Integer = CInt(Int(chkCollection.Checked))
        Dim breading As Integer = CInt(Int(chkMeterReading.Checked))
        Dim breports As Integer = CInt(Int(chkReports.Checked))
        Dim bconsumers As Integer = CInt(Int(chkConsumers.Checked))
        Dim baccounts As Integer = CInt(Int(chkAccounts.Checked))
        Dim bpending As Integer = CInt(Int(chkPending.Checked))
        Dim bsequence As Integer = CInt(Int(chkSequencing.Checked))
        Dim bapprvls As Integer = CInt(Int(chkApprvls.Checked))
        Dim bsettings As Integer = CInt(Int(chkApprvls.Checked))
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM accesslevel WHERE utypeID=" & selectedUtypeID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim cmd As New MySqlCommand("UPDATE accesslevel SET atools=" & btools & ", aaccounting=" & baccounting & ", abilling=" & bbilling & ", acollection=" & bcollection & ", areading=" & breading & ", areports=" & breports & ", aconsumers=" & bconsumers & ", aaccounts=" & baccounts & ", apending=" & bpending & ", asequence=" & bsequence & ", aapprvl=" & bapprvls & ", asettings=" & bsettings & " WHERE utypeid=" & selectedUtypeID, con)
            cmd.ExecuteNonQuery()
            InsertLog(loggedUserID, "Updated Access Level", "Access Checklist", "Access level Updated for User Type ID #" & selectedUtypeID)
            Me.Close()
        Else
            Dim cmd As New MySqlCommand("INSERT INTO accesslevel(utypeid, atools, aaccounting, abilling, acollection, areading, areports, aconsumers, aaccounts, apending, asequence, aapprvl, asettings) VALUES(" & selectedUtypeID & "," & btools & "," & baccounting & "," & bbilling & "," & bcollection & "," & breading & "," & breports & "," & bconsumers & "," & baccounts & "," & bpending & "," & bsequence & "," & bapprvls & "," & bsettings & ")", con)
            cmd.ExecuteNonQuery()
            InsertLog(loggedUserID, "New Access Level", "Access Checklist", "Entered New Access Level")
            Me.Close()
        End If

    End Sub
End Class