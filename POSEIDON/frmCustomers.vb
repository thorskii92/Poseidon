Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmCustomers
    Private Sub btnNewApplicant_Click(sender As Object, e As EventArgs) Handles btnNewApplicant.Click
        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        'da.Fill(dt)
        'frmNewApplicant.cboProv.Items.Clear()
        'If dt.Rows.Count > 0 Then
        '    ReDim arrComProvID(dt.Rows.Count - 1)
        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        arrComProvID(x) = dt.Rows(x).Item(0)
        '        frmNewApplicant.cboProv.Items.Add(dt.Rows(x).Item(1).ToString)
        '    Next
        'End If
        'frmNewApplicant.StartPosition = FormStartPosition.CenterScreen
        'frmNewApplicant.ShowInTaskbar = False
        'frmNewApplicant.ShowDialog()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        frmNewCustomer.cboProv.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrComProvID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrComProvID(x) = dt.Rows(x).Item(0)
                frmNewCustomer.cboProv.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
        frmNewCustomer.StartPosition = FormStartPosition.CenterScreen
        frmNewCustomer.ShowInTaskbar = False
        frmNewCustomer.ShowDialog()
    End Sub

    Private Sub lvwCustomerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCustomerList.SelectedIndexChanged

    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboProvCustomers()
    End Sub

    
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            CustomerList(arrCusBrgyID(cboBrgy.SelectedIndex), txtSearch.Text)
        Catch ex As Exception
            lvwCustomerList.Items.Clear()
        End Try

    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged
        Try
            CustomerList(arrCusBrgyID(cboBrgy.SelectedIndex), txtSearch.Text)
        Catch ex As Exception
            lvwCustomerList.Items.Clear()
        End Try
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        comboBrgyCustomers(arrCusMunID(cboMun.SelectedIndex))
    End Sub

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        ComboMunCustomers(arrCusProvID(cboProv.SelectedIndex))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lvwCustomerList.SelectedItems.Count > 0 Then
            selCusID = arrCusID(lvwCustomerList.FocusedItem.Index)
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM tblCustomer WHERE cID=" & selCusID, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmNewCustomer.txtFName.Text = dt.Rows(0).Item(1).ToString
                frmNewCustomer.txtMName.Text = dt.Rows(0).Item(2).ToString
                frmNewCustomer.txtLName.Text = dt.Rows(0).Item(3).ToString
                ComboProvCustomers()
                frmNewCustomer.txtConNum.Text = dt.Rows(0).Item(4).ToString
                frmNewCustomer.txtAddress.Text = dt.Rows(0).Item(5).ToString
                frmNewCustomer.Text = "Update Customer"
                frmNewCustomer.ShowDialog()
            Else
                MsgBox("No Details to show", MsgBoxStyle.Information, "No Details Found")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmCustomerLedger.ShowDialog()
    End Sub
End Class