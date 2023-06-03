Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAddressList

    Private Sub btnAddProv_Click(sender As Object, e As EventArgs) Handles btnAddProv.Click
        frmAddressAdder.Text = "Add Province"
        frmAddressAdder.txtAddress.Text = ""
        frmAddressAdder.lbl.Text = "Province Name"
        frmAddressAdder.chkDef.Visible = True
        frmAddressAdder.chkDef.Checked = False
        frmAddressAdder.lblBCode.Visible = False
        frmAddressAdder.txtBCode.Visible = False
        frmAddressAdder.chkDef.Location = New Point(352, 51)
        frmAddressAdder.btnCancel.Location = New Point(271, 80)
        frmAddressAdder.btnOK.Location = New Point(190, 80)
        frmAddressAdder.Width = 443
        globalAddressIndex = 1
        frmAddressAdder.ShowDialog()
    End Sub

    Private Sub btnAddMun_Click(sender As Object, e As EventArgs) Handles btnAddMun.Click
        frmAddressAdder.Text = "Add Municipality"
        frmAddressAdder.txtAddress.Text = ""
        frmAddressAdder.lbl.Text = "Municipality Name"
        frmAddressAdder.chkDef.Visible = True
        frmAddressAdder.chkDef.Checked = False
        frmAddressAdder.Width = 443
        frmAddressAdder.lblBCode.Visible = False
        frmAddressAdder.txtBCode.Visible = False
        frmAddressAdder.chkDef.Location = New Point(352, 51)
        frmAddressAdder.btnCancel.Location = New Point(271, 80)
        frmAddressAdder.btnOK.Location = New Point(190, 80)
        globalAddressIndex = 2
        frmAddressAdder.ShowDialog()
    End Sub

    Private Sub btnAddBrgy_Click(sender As Object, e As EventArgs) Handles btnAddBrgy.Click
        NewBarangay.txtBrgyCode.Text = ""
        NewBarangay.txtBrgyName.Text = ""
        NewBarangay.txtCluster.Text = ""
        NewBarangay.Text = "New Barangay"
        NewBarangay.StartPosition = FormStartPosition.CenterScreen
        NewBarangay.ShowDialog()
    End Sub

    Private Sub lvwProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwProv.SelectedIndexChanged
        If lvwProv.SelectedItems.Count > 0 Then
            selectedProvID = arrProvID(lvwProv.FocusedItem.Index)
            btnAddMun.Enabled = True
            btnEditProv.Enabled = True
            btnDelProv.Enabled = True
            lvwBrgy.Items.Clear()
            ViewMunListSettings(selectedProvID)
        Else
            btnAddMun.Enabled = False
            btnEditProv.Enabled = False
            btnDelProv.Enabled = False
        End If
    End Sub

    Private Sub Enabler()

    End Sub

    Private Sub lvwMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwMun.SelectedIndexChanged

        If lvwMun.SelectedItems.Count > 0 Then
            selectedMunID = arrMunID(lvwMun.FocusedItem.Index)
            btnAddZone.Enabled = True
            btnEditMun.Enabled = True
            btnDelMun.Enabled = True
            ViewZoneSettings(selectedMunID)
        Else
            btnAddZone.Enabled = False
            btnEditMun.Enabled = False
            btnDelMun.Enabled = False
        End If

      
    End Sub

    Private Sub lstBrgy_LostFocus(sender As Object, e As EventArgs)
        'If lstBrgy.SelectedItems.Count > 0 Then
        '    btnEditBrgy.Enabled = True
        '    btnDelBrgy.Enabled = True
        'Else
        '    btnEditBrgy.Enabled = False
        '    btnDelBrgy.Enabled = False
        'End If
    End Sub

    Private Sub lstBrgy_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If lstBrgy.SelectedItems.Count > 0 Then
        '    btnEditBrgy.Enabled = True
        '    btnDelBrgy.Enabled = True
        'Else
        '    btnEditBrgy.Enabled = False
        '    btnDelBrgy.Enabled = False
        'End If
    End Sub

    Private Sub btnDelProv_Click(sender As Object, e As EventArgs) Handles btnDelProv.Click
        If lvwProv.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to Delete this Province?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.Yes Then
                Dim prvID As Integer
                prvID = arrProvID(lvwProv.FocusedItem.Index)
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM provlist where addprovid=" & prvID, con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Deleted Province", "Address List", "Deleted Province ID# " & prvID)
                MsgBox("Province has been removed from Database", MsgBoxStyle.Information, "Deletion Successful")
                ViewProvListSettings()
            End If
        End If
    End Sub

    Private Sub btnDelMun_Click(sender As Object, e As EventArgs) Handles btnDelMun.Click
        If lvwMun.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to Delete this Municipality?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.Yes Then
                Dim muID As Integer
                muID = arrMunID(lvwMun.FocusedItem.Index)
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM munlist WHERE addmunid=" & muID, con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Deleted Municipality", "Address List", "Deleted Municipality ID#" & muID)
                MsgBox("Municipality has been removed from Database", MsgBoxStyle.Information, "Deletion Successful")
                ViewMunListSettings(selectedProvID)
            End If
        End If
    End Sub

    Private Sub lvwBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwBrgy.SelectedIndexChanged
        If lvwBrgy.SelectedItems.Count > 0 Then
            ViewClusterSettings(arrBrgyID(lvwBrgy.FocusedItem.Index))
            btnEditBrgy.Enabled = True
            btnDelBrgy.Enabled = True
            btnAddCluster.Enabled = True
        Else
            btnEditBrgy.Enabled = False
            btnDelBrgy.Enabled = False
            btnAddCluster.Enabled = False
        End If
    End Sub

    Private Sub btnDelBrgy_Click(sender As Object, e As EventArgs) Handles btnDelBrgy.Click
        If lvwBrgy.SelectedItems.Count > 0 Then
            If MsgBox("Do you want to Delete this Barangay?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.Yes Then
                Dim baID As Integer
                baID = arrBrgyID(lvwBrgy.FocusedItem.Index)
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM brgylist WHERE brgyid=" & baID, con)
                cmd.ExecuteNonQuery()
                InsertLog(loggedUserID, "Deleted Barangay", "Address List", "Deleted Barangay ID# " & baID)
                MsgBox("Barangay has been removed from Database", MsgBoxStyle.Information, "Deletion Succesful")
                ViewZoneSettings(selectedMunID)
            End If
        End If
    End Sub

    
    Private Sub btnAddZone_Click(sender As Object, e As EventArgs) Handles btnAddZone.Click
        frmAddZone.Text = "New Zone"
        frmAddZone.txtZone.Text = ""
        frmAddZone.txtReading.Text = ""
        frmAddZone.StartPosition = FormStartPosition.CenterScreen
        frmAddZone.ShowDialog()
    End Sub

    Private Sub lvwZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwZone.SelectedIndexChanged
        Try
            If lvwZone.SelectedItems.Count > 0 Then
                selectedZoneID = arrZoneID(lvwZone.FocusedItem.Index)
                btnAddBrgy.Enabled = True
                btnEditZone.Enabled = True
                btnDeleteZone.Enabled = True
                ViewBrgySettings(selectedZoneID)
            Else
                btnAddBrgy.Enabled = False
                btnEditZone.Enabled = False
                btnDeleteZone.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEditProv_Click(sender As Object, e As EventArgs) Handles btnEditProv.Click
        frmAddressAdder.Text = "Edit Province"
        editProvID = arrProvID(lvwProv.FocusedItem.Index)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist WHERE addprovID=" & editProvID, con)
        da.Fill(dt)

        frmAddressAdder.chkDef.Visible = True
        frmAddressAdder.lbl.Text = "Province Name"
        frmAddressAdder.txtAddress.Text = dt.Rows(0).Item(1).ToString
        Dim checkDef As Integer = dt.Rows(0).Item(2)
        If checkDef = 1 Then
            frmAddressAdder.chkDef.Checked = True
        Else
            frmAddressAdder.chkDef.Checked = False
        End If
        globalAddressIndex = 3
        frmAddressAdder.lblBCode.Visible = False
        frmAddressAdder.txtBCode.Visible = False
        frmAddressAdder.chkDef.Location = New Point(352, 51)
        frmAddressAdder.btnCancel.Location = New Point(271, 80)
        frmAddressAdder.btnOK.Location = New Point(190, 80)
        frmAddressAdder.Width = 443
        frmAddressAdder.ShowDialog()
    End Sub

    Private Sub btnEditZone_Click(sender As Object, e As EventArgs) Handles btnEditZone.Click
        If lvwZone.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM zones WHERE zoneID=" & arrZoneID(lvwZone.FocusedItem.Index), con)
            da.Fill(dt)
            frmAddZone.Text = "Update Zone"
            selSetZoneID = Val(dt.Rows(0).Item(0).ToString)
            selSetMunID = Val(dt.Rows(0).Item(1).ToString)
            frmAddZone.txtZone.Text = dt.Rows(0).Item(2).ToString
            frmAddZone.txtReading.Text = dt.Rows(0).Item(3).ToString
            frmAddZone.StartPosition = FormStartPosition.CenterScreen
            frmAddZone.ShowDialog()
        End If
    End Sub

    Private Sub btnEditBrgy_Click(sender As Object, e As EventArgs) Handles btnEditBrgy.Click
        If lvwBrgy.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM brgylist WHERE brgyID=" & arrBrgyID(lvwBrgy.FocusedItem.Index), con)
            da.Fill(dt)
            NewBarangay.txtBrgyCode.Text = dt.Rows(0).Item(3).ToString
            NewBarangay.txtBrgyName.Text = dt.Rows(0).Item(2).ToString
            NewBarangay.txtCluster.Text = dt.Rows(0).Item(4).ToString
            NewBarangay.cboClass.Text = dt.Rows(0).Item(5).ToString
            selSetZoneID = Val(dt.Rows(0).Item(1).ToString)
            selSetBarID = Val(dt.Rows(0).Item(0).ToString)
            NewBarangay.Text = "Edit Barangay"
            NewBarangay.StartPosition = FormStartPosition.CenterScreen
            NewBarangay.ShowDialog()
        End If
    End Sub

    Private Sub btnEditMun_Click(sender As Object, e As EventArgs) Handles btnEditMun.Click

    End Sub

    Private Sub btnDeleteZone_Click(sender As Object, e As EventArgs) Handles btnDeleteZone.Click

    End Sub

    Private Sub btnAddCluster_Click(sender As Object, e As EventArgs) Handles btnAddCluster.Click
        If lvwBrgy.SelectedItems.Count > 0 Then
            globalAddressIndex = 4
            selectedBrgyID = arrBrgyID(lvwBrgy.FocusedItem.Index)
            frmAddressAdder.Width = 375
            frmAddressAdder.Text = "Add Cluster"
            frmAddressAdder.chkDef.Visible = False
            frmAddressAdder.txtAddress.Text = ""
            frmAddressAdder.txtBCode.Visible = False
            frmAddressAdder.lblBCode.Visible = False
            frmAddressAdder.lbl.Text = "Cluster Name"
            frmAddressAdder.StartPosition = FormStartPosition.CenterScreen
            frmAddressAdder.ShowDialog()
        End If
    End Sub

    Private Sub lvwCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCluster.SelectedIndexChanged
        If lvwCluster.SelectedItems.Count > 0 Then
            btnEditCluster.Enabled = True
            btnDeleteCluster.Enabled = True
        Else
            btnEditCluster.Enabled = False
            btnDeleteCluster.Enabled = False
        End If
    End Sub

    Private Sub btnDeleteCluster_Click(sender As Object, e As EventArgs) Handles btnDeleteCluster.Click
        If lvwCluster.SelectedItems.Count > 0 Then
            If MessageBox.Show("Delete selected Cluster?", "Delete Cluster", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM clusterlist WHERE clusterID=" & arrClusterID(lvwCluster.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                ViewClusterSettings(arrBrgyID(lvwBrgy.FocusedItem.Index))

            End If
        End If
    End Sub
End Class