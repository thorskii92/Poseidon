Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmUpdateBillDetails
    Dim brgyID() As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmUpdateBillDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrgy()
    End Sub

    Private Sub LoadBrgy()
        dtpBillDate.Value = Date.Now
        dtpDueDate.Value = Date.Now
        dtpReadDate.Value = Date.Now
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        cboBrgy.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim brgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                brgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
        cboYear.Items.Clear()
        Dim dtY As New DataTable
        Dim daYr As New MySqlDataAdapter("SELECT min(billyear) as MinYear, max(billyear) as MaxYear FROM billing", con)
        daYr.Fill(dtY)
        If dtY.Rows.Count > 0 Then
            Dim minYear As Integer = Val(dtY.Rows(0).Item(0).ToString)
            Dim maxYear As Integer = Val(dtY.Rows(0).Item(1).ToString)
            For y As Integer = minYear To maxYear
                cboYear.Items.Add(y)
            Next
        End If

    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged
        LoadCounter(brgyID(cboBrgy.SelectedIndex), cboMonth.Text, Val(cboYear.Text))
    End Sub

    Private Sub LoadCounter(bID As Integer, mont As String, yea As Integer)
        lblBillCount.Text = ""
        If cboMonth.Text <> "" And cboYear.Text <> "" And cboBrgy.Text <> "" Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT count(*), billDate, readDate, dueDate FROM billing where brgyID=" & bID & " and billmonth='" & mont & "' and billyear=" & yea, con)
            da.Fill(dt)
            'MessageBox.Show(dt.Rows.Count & " " & bID & " " & mont & " " & yea)
            If dt.Rows.Count > 0 Then
                lblBillCount.Text = dt.Rows(0).Item(0).ToString & " Bills Found"
                Dim bCount As Integer = Val(dt.Rows(0).Item(0).ToString)
                If bCount > 0 Then
                    dtpBillDate.Value = dt.Rows(0).Item(1)
                    dtpReadDate.Value = dt.Rows(0).Item(2)
                    dtpDueDate.Value = dt.Rows(0).Item(3)
                    btnSave.Enabled = True
                End If
            Else
                lblBillCount.Text = "0 Bills Found"
                btnSave.Enabled = False
            End If
        End If
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        LoadCounter(brgyID(cboBrgy.SelectedIndex), cboMonth.Text, Val(cboYear.Text))
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        LoadCounter(brgyID(cboBrgy.SelectedIndex), cboMonth.Text, Val(cboYear.Text))
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Save?", "Save Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE billing SET billDate=@bDate, readDate=@rDate, dueDate=@dDate WHERE brgyID=" & brgyID(cboBrgy.SelectedIndex) & " and billmonth='" & cboMonth.Text & "' and billyear=" & cboYear.Text, con)
            cmd.Parameters.AddWithValue("@bDate", dtpBillDate.Value.Date)
            cmd.Parameters.AddWithValue("@rDate", dtpReadDate.Value.Date)
            cmd.Parameters.AddWithValue("@dDate", dtpDueDate.Value.Date)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully Saved", "Save Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class