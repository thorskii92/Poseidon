Imports MySql.Data.MySqlClient
Public Class frmNewApplicant
    Dim rdowner As String
    Dim watservice As String
    Dim rdclass As Integer
    Dim pAmount As Double
    Dim tmpBrgyID As Integer
    Dim tmpClasID As Integer
    Private Sub frmNewApplicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAmount.Text = "Php " & Format(ServiceFees(0), "0.#0")
        pAmount = ServiceFees(0)
        checkAccCodes()
    End Sub

    Private Sub checkAccCodes()
            If cboBrgy.Text = "" Then
                txtAccountCode.Text = ""
            Else
                tmpBrgyID = arrComBrgyID(cboBrgy.SelectedIndex)
                If rdCons1.Checked = True Then
                    tmpClasID = 1
                ElseIf rdCons2.Checked = True Then
                    tmpClasID = 2
                ElseIf rdCons3.Checked = True Then
                    tmpClasID = 3
                ElseIf rdCons4.Checked = True Then
                    tmpClasID = 4
                End If
            txtAccountCode.Text = AccountCode(tmpBrgyID)
        End If
            Exit Sub

     
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If MsgBox("Save Applicant Details?", MsgBoxStyle.YesNo, "Save Details") Then
            Cons()
            Dim cmd As New MySqlCommand("INSERT INTO customerlist(firname, midname, lasname, optaddress, brgyid, contactno, ownership, waterservice, classification, status, accountingcode, applicationDate) values(@fname, @mname, @lname, @oadd, @bgyid, @cnum, @own, @watser, @class, @stat, @acc, @appdate)", con)
            cmd.Parameters.AddWithValue("@fname", txtName.Text)
            cmd.Parameters.AddWithValue("@mname", txtMidName.Text)
            cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@oadd", txtAddress.Text)
            cmd.Parameters.AddWithValue("@bgyid", arrComBrgyID(cboBrgy.SelectedIndex))
            cmd.Parameters.AddWithValue("@cnum", txtCon.Text)
            If rdOwn1.Checked = True Then
                rdowner = rdOwn1.Text
            ElseIf rdOwn2.Checked = True Then
                rdowner = rdOwn2.Text
            ElseIf rdOwn3.Checked = True Then
                rdowner = txtOwnOther.Text
            End If
            cmd.Parameters.AddWithValue("@own", rdowner)
            If rdServ1.Checked = True Then
                watservice = rdServ1.Text
            ElseIf rdServ2.Checked = True Then
                watservice = rdServ2.Text
            ElseIf rdServ3.Checked = True Then
                watservice = rdServ3.Text
            ElseIf rdServ4.Checked = True Then
                watservice = rdServ4.Text
            End If
            cmd.Parameters.AddWithValue("@watser", watservice)
            If rdCons1.Checked = True Then
                rdclass = 1
            ElseIf rdCons2.Checked = True Then
                rdclass = 2
            ElseIf rdCons3.Checked = True Then
                rdclass = 3
            ElseIf rdCons4.Checked = True Then
                rdclass = 4
            End If
            cmd.Parameters.AddWithValue("@class", rdclass)
            cmd.Parameters.AddWithValue("@stat", "Pending Connection")
            cmd.Parameters.AddWithValue("@acc", txtAccountCode.Text)
            cmd.Parameters.AddWithValue("@appdate", Format(dtpAppDate.Value, "yyyy-MM-dd"))
            cmd.ExecuteNonQuery()
            UpdateAccountCode()
            MsgBox("Saved!", MsgBoxStyle.Information, "Save Successful")
            LoadCustomerList()
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

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        checkAccCodes()
        selectedComProvID = arrComProvID(cboProv.SelectedIndex)
        ComboMunList(selectedComProvID)
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        checkAccCodes()
        selectedComMunID = arrComMunID(cboMun.SelectedIndex)
        ComboBrgyList(selectedComMunID)
    
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rdServ1_CheckedChanged(sender As Object, e As EventArgs) Handles rdServ1.CheckedChanged
        lblAmount.Text = "Php " & Format(ServiceFees(0), "0.#0")
        pAmount = ServiceFees(0)
    End Sub

    Private Sub rdServ2_CheckedChanged(sender As Object, e As EventArgs) Handles rdServ2.CheckedChanged
        lblAmount.Text = "Php " & Format(ServiceFees(1), "0.#0")
        pAmount = ServiceFees(1)
    End Sub

    Private Sub rdServ3_CheckedChanged(sender As Object, e As EventArgs) Handles rdServ3.CheckedChanged
        lblAmount.Text = "Php " & Format(ServiceFees(2), "0.#0")
        pAmount = ServiceFees(2)
    End Sub

    Private Sub rdServ4_CheckedChanged(sender As Object, e As EventArgs) Handles rdServ4.CheckedChanged
        lblAmount.Text = "Php " & Format(ServiceFees(3), "0.#0")
        pAmount = ServiceFees(3)
    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged
        checkAccCodes()
    End Sub

    Private Sub rdCons1_CheckedChanged(sender As Object, e As EventArgs) Handles rdCons1.CheckedChanged
        checkAccCodes()
    End Sub

    Private Sub rdCons2_CheckedChanged(sender As Object, e As EventArgs) Handles rdCons2.CheckedChanged
        checkAccCodes()
    End Sub

    Private Sub rdCons3_CheckedChanged(sender As Object, e As EventArgs) Handles rdCons3.CheckedChanged
        checkAccCodes()
    End Sub

    Private Sub rdCons4_CheckedChanged(sender As Object, e As EventArgs) Handles rdCons4.CheckedChanged
        checkAccCodes()
    End Sub
End Class