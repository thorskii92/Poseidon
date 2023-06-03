Imports MySql.Data.MySqlClient
Public Class frmNewCustomer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If Me.Text = "New Customer" Then
            If MsgBox("Proceed?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM tblCustomer WHERE FName='" & txtFName.Text & "' and MName='" & txtMName.Text & "' and LName='" & txtLName.Text & "'", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    If MsgBox("Already have the same Customer Details, Do you want to Proceed for a Different ID?", MsgBoxStyle.YesNo, "Proceed?") = MsgBoxResult.Yes Then
                        Dim cmd As New MySqlCommand("INSERT INTO tblCustomer(FName, MName, LName, CNum, Address, brgyID, agency) VALUES(@FN, @MN, @LN, @CN, @AD, @bID, @ag)", con)
                        cmd.Parameters.AddWithValue("@FN", txtFName.Text)
                        cmd.Parameters.AddWithValue("@MN", txtMName.Text)
                        cmd.Parameters.AddWithValue("@LN", txtLName.Text)
                        cmd.Parameters.AddWithValue("@CN", txtConNum.Text)
                        cmd.Parameters.AddWithValue("@AD", txtAddress.Text)
                        cmd.Parameters.AddWithValue("@bID", arrComBrgyID(cboBrgy.SelectedIndex))
                        cmd.Parameters.AddWithValue("@ag", txtagency.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Succesfully Saved!", MsgBoxStyle.Information, "Saved!")
                        Me.Close()
                        Try
                            CustomerList(arrCusBrgyID(cboBrgy.SelectedIndex), frmCustomers.txtSearch.Text)
                        Catch ex As Exception
                            frmCustomers.lvwCustomerList.Items.Clear()
                        End Try
                    End If
                Else
                    Dim cmd As New MySqlCommand("INSERT INTO tblCustomer(FName, MName, LName, CNum, Address, brgyID, agency) VALUES(@FN, @MN, @LN, @CN, @AD, @bID, @ag)", con)
                    cmd.Parameters.AddWithValue("@FN", txtFName.Text)
                    cmd.Parameters.AddWithValue("@MN", txtMName.Text)
                    cmd.Parameters.AddWithValue("@LN", txtLName.Text)
                    cmd.Parameters.AddWithValue("@CN", txtConNum.Text)
                    cmd.Parameters.AddWithValue("@AD", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@bID", arrComBrgyID(cboBrgy.SelectedIndex))
                    cmd.Parameters.AddWithValue("@ag", txtagency.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Succesfully Saved!", MsgBoxStyle.Information, "Saved!")
                    Me.Close()
                    Try
                        CustomerList(arrCusBrgyID(cboBrgy.SelectedIndex), frmCustomers.txtSearch.Text)
                    Catch ex As Exception
                        frmCustomers.lvwCustomerList.Items.Clear()
                    End Try
                End If
            End If
        ElseIf Me.Text = "Update Customer" Then
            If MsgBox("Are you Done?", MsgBoxStyle.YesNo, "Done?") Then
                Dim cmd As New MySqlCommand("UPDATE tblCustomer SET FName='" & txtFName.Text & "', MName='" & txtMName.Text & "', LName='" & txtLName.Text & "', CNum='" & txtConNum.Text & "', Address='" & txtAddress.Text & "', brgyid=" & arrComBrgyID(cboBrgy.SelectedIndex) & ", agency='" & txtagency.Text & "' WHERE cID=" & selCusID, con)
                cmd.ExecuteNonQuery()
                Me.txtFName.Text = ""
                Me.txtMName.Text = ""
                Me.txtLName.Text = ""
                Me.txtConNum.Text = ""
                Me.txtAddress.Text = ""
                Me.cboBrgy.Items.Clear()
                Me.cboMun.Items.Clear()
                Me.cboProv.Items.Clear()
                MsgBox("Update Successful", MsgBoxStyle.Information, "Update Successful")
                Try
                    CustomerList(arrCusBrgyID(cboBrgy.SelectedIndex), frmCustomers.txtSearch.Text)
                Catch ex As Exception
                    frmCustomers.lvwCustomerList.Items.Clear()
                End Try
                Me.Close()            
            End If
        End If


    End Sub

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        selectedComProvID = arrComProvID(cboProv.SelectedIndex)
        ComboMunList(selectedComProvID)
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        selectedComMunID = arrComMunID(cboMun.SelectedIndex)
        ComboBrgyList(selectedComMunID)
    End Sub

    Private Sub frmNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class