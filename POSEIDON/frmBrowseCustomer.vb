Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmBrowseCustomer

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Cons()
        lvwCustomer.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist WHERE consumername like '%" & txtSearch.Text & "%'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(0).ToString
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lvwCustomer.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If lvwCustomer.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist WHERE consID=" & Val(lvwCustomer.FocusedItem.Text), con)
            da.Fill(dt)
            frmPaymentCollection.cID.Text = dt.Rows(0).Item(0).ToString
            frmPaymentCollection.lblName.Text = dt.Rows(0).Item(1).ToString
            Me.Close()
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Information, "Nothing is Selected")
        End If
    End Sub

    Private Sub lvwCustomer_DoubleClick(sender As Object, e As EventArgs) Handles lvwCustomer.DoubleClick
        If lvwCustomer.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist WHERE consID=" & Val(lvwCustomer.FocusedItem.Text), con)
            da.Fill(dt)
            frmPaymentCollection.cID.Text = dt.Rows(0).Item(0).ToString
            frmPaymentCollection.lblName.Text = dt.Rows(0).Item(1).ToString
            Me.Close()
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Information, "Nothing is Selected")
        End If
    End Sub

    Private Sub lvwCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCustomer.SelectedIndexChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class