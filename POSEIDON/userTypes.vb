Imports MySql.Data.MySqlClient
Public Class userTypes

    Private Sub lvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvw.SelectedIndexChanged
        If lvw.SelectedItems.Count > 0 Then
            If lvw.FocusedItem.SubItems(1).Text = "Administrator" Then
                btnModify.Enabled = False
            Else
                btnModify.Enabled = True
            End If
        Else
            btnModify.Enabled = False
        End If
    End Sub

    Private Sub userTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModify.Enabled = False
        ViewUserTypes()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        selectedUtypeID = arrSelectedUTypeID(lvw.FocusedItem.Index)
        UserAccessCheckList(selectedUtypeID)
        accessCheckList.StartPosition = FormStartPosition.CenterScreen
        accessCheckList.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmNewUserType.txtUserType.Text = ""
        frmNewUserType.Text = "New User Type"
        frmNewUserType.StartPosition = FormStartPosition.CenterScreen
        frmNewUserType.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvw.SelectedItems.Count > 0 Then
            frmNewUserType.Text = "Edit User Type"
            Cons()
            selUTID = arrSelectedUTypeID(lvw.FocusedItem.Index)
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT utype FROM usertypes WHERE utypeID=" & selUTID, con)
            da.Fill(dt)
            frmNewUserType.txtUserType.Text = dt.Rows(0).Item(0).ToString
            frmNewUserType.StartPosition = FormStartPosition.CenterScreen
            frmNewUserType.ShowDialog()
            ' Dim da As New MySqlDataAdapter("Select utypeid FROM usertypes")
        Else
            MsgBox("Nothing selected", MsgBoxStyle.Exclamation, "Nothing selected")
        End If

    End Sub
End Class