Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmBatchReadingUpdate
    Dim arrBrgyID() As Integer
    Dim arrAcctID() As Integer
    Dim newRef() As Integer
    Private Sub frmBatchReadingUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.Rows.Clear()
        LoadBrgy()
    End Sub

    Private Sub LoadBrgy()
        cboBrgyList.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboBrgyList.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Private Sub GenerateBarangay(brgyID As Integer)
        Cons()
        dgv.Rows.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT AcctID, AccountNo, AccountName, MeterReference FROM consumeraccounts WHERE brgyID=" & brgyID, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrAcctID(dt.Rows.Count - 1)
            ReDim newRef(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrAcctID(x) = Val(dt.Rows(x).Item(0).ToString)
                newRef(x) = Val(dt.Rows(x).Item(3).ToString)
                dgv.Rows.Add(dt.Rows(x).Item(1).ToString, dt.Rows(x).Item(2).ToString, dt.Rows(x).Item(3).ToString, dt.Rows(x).Item(3).ToString)
            Next
        End If

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cboBrgyList.Selected = True Then
            GenerateBarangay(arrBrgyID(cboBrgyList.SelectedIndex))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Cons()
        If MessageBox.Show("Save New Meter Reference?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            For x As Integer = 0 To dgv.Rows.Count - 1
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET meterreference=" & newRef(x) & " WHERE acctID=" & arrAcctID(x), con)
                cmd.ExecuteNonQuery()
            Next
            MessageBox.Show("Saved Successful", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.Rows.Clear()
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        If dgv.Rows.Count > 0 Then
            If e.ColumnIndex = 3 Then
                newRef(e.RowIndex) = CInt(dgv.Rows(e.RowIndex).Cells(3).Value)
            End If
        End If
    End Sub
End Class