Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmUncollectibleDateSelection
    Dim arrBGID() As Integer

    Private Sub frmUncollectibleDateSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadYear()
        LoadBrgy()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        LoadUncollectibles(cboMonth.Text, cboYear.Text, arrBGID(cboBrgy.SelectedIndex))
        Me.Close()
    End Sub

    Private Sub LoadYear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT MAX(billYear) FROM billing", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            cboYear.Items.Clear()
            Dim mYear As Integer = dt.Rows(0).Item(0)
            For x As Integer = 2020 To mYear
                cboYear.Items.Add(x)
            Next
        End If
    End Sub

    Private Sub LoadBrgy()
        cboBrgy.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrBGID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrBGID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class