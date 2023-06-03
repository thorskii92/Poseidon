Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmClassifications

    Private Sub frmClassifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnView.Enabled = False
        btnEdit.Enabled = False
        btnDel.Enabled = False
        Cons()
        Dim cmd As New MySqlCommand("DELETE FROM tempclassrate", con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        classRate(arrClassSetID(lvwClass.FocusedItem.Index))
        selectedClassListID = lvwClass.FocusedItem.Index
        If lvwClass.FocusedItem.Index = 0 Then
            frmViewClassRate.btnPrev.Enabled = False
        Else
            frmViewClassRate.btnPrev.Enabled = True
        End If

        If lvwClass.FocusedItem.Index = classListCount Then
            frmViewClassRate.btnNext.Enabled = False
        Else
            frmViewClassRate.btnNext.Enabled = True
        End If
        frmViewClassRate.ShowDialog()
    End Sub

    Private Sub lvwClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwClass.SelectedIndexChanged
        If lvwClass.SelectedItems.Count > 0 Then
            btnView.Enabled = True
            btnEdit.Enabled = True
            btnDel.Enabled = True
        Else
            btnView.Enabled = False
            btnEdit.Enabled = False
            btnDel.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Cons()
        Dim cmd As New MySqlCommand("DELETE FROM tempclassrate", con)
        cmd.ExecuteNonQuery()
        getClassID = 0
        frmRateValues.Text = "Add Classification"
        frmRateValues.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Cons()
        Dim tempARate() As Double
        Dim tempAMin() As Integer
        Dim tempACub() As Integer
        frmRateValues.lvwCubits.Items.Clear()
        getClassID = arrClassSetID(lvwClass.FocusedItem.Index)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM classifications WHERE classID=" & getClassID, con)
        da.Fill(dt)
        frmRateValues.txtClassName.Text = dt.Rows(0).Item(1).ToString
        frmRateValues.txtClassCode.Text = dt.Rows(0).Item(2).ToString
        Dim checkBulk As Integer = Val(dt.Rows(0).Item(3).ToString)
        If checkBulk = 0 Then
            frmRateValues.chkBulk.Checked = False
        Else
            frmRateValues.chkBulk.Checked = True
        End If
        Dim dtR As New DataTable
        Dim daR As New MySqlDataAdapter("SELECT * FROM tblClassrates WHERE classID=" & getClassID, con)
        daR.Fill(dtR)
        If dtR.Rows.Count > 0 Then
            ReDim tempARate(dtR.Rows.Count - 1)
            ReDim tempAMin(dtR.Rows.Count - 1)
            ReDim tempACub(dtR.Rows.Count - 1)
            Dim cmdClearTemp As New MySqlCommand("DELETE FROM tempclassrate", con)
            cmdClearTemp.ExecuteNonQuery()
            For y As Integer = 0 To dtR.Rows.Count - 1
                tempARate(y) = Val(dtR.Rows(y).Item(2).ToString)
                tempAMin(y) = Val(dtR.Rows(y).Item(3).ToString)
                tempACub(y) = Val(dtR.Rows(y).Item(4).ToString)
            Next
            For x As Integer = 0 To dtR.Rows.Count - 1
                Dim cmdAddTemp As New MySqlCommand("INSERT INTO tempclassrate(rate,ismin,cubitrange) VALUES(" & tempARate(x) & "," & tempAMin(x) & "," & tempACub(x) & ")", con)
                cmdAddTemp.ExecuteNonQuery()
            Next
            tempClassRate()
        End If
        frmRateValues.Text = "Update Classification"
        frmRateValues.ShowDialog()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Cons()
        If lvwClass.SelectedItems.Count > 0 Then
            If MsgBox("Do you wish to delete This Classification?", MsgBoxStyle.YesNo, "Delete?") = MsgBoxResult.Yes Then
                Dim cmd As New MySqlCommand("DELETE FROM classifications WHERE classID=" & arrClassSetID(lvwClass.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                classificationList()
            End If
        End If
    End Sub
End Class