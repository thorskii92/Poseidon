Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAccountNumberSeries

    Private Sub frmAccountNumberSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountSeries()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddAccountSeries.txtSerial.Text = ""
        frmAddAccountSeries.ShowInTaskbar = False
        frmAddAccountSeries.StartPosition = FormStartPosition.CenterScreen
        frmAddAccountSeries.ShowDialog()
    End Sub

    
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvw.SelectedItems.Count > 0 Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM acctcodegen AS G LEFT JOIN brgylist AS B ON G.brgyID=B.brgyID WHERE G.acctcodeid=" & arrAccCodeGID(lvw.FocusedItem.Index), con)
            da.Fill(dt)
            selBaraID = Val(dt.Rows(0).Item(1).ToString)
            frmEditAccountSeries.txtSearial.Text = Val(dt.Rows(0).Item(2).ToString) + 1
            frmEditAccountSeries.lblBarangay.Text = dt.Rows(0).Item(5).ToString
            'frmEditAccountSeries.lblClassification.Text = dt.Rows(0).Item(11).ToString
            frmEditAccountSeries.ShowInTaskbar = False
            frmEditAccountSeries.StartPosition = FormStartPosition.CenterScreen
            frmEditAccountSeries.ShowDialog()
        End If
    End Sub
End Class