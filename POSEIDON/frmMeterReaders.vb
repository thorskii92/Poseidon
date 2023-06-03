Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmMeterReaders
    Private Sub frmMeterReaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeterReaders()
    End Sub

    Private Sub lvwMet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwMet.SelectedIndexChanged
        If lvwMet.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT metstat FROM meterreader WHERE metID=" & arrSettingsMetReaderID(lvwMet.FocusedItem.Index), con)
            da.Fill(dt)
            Dim strStat As String = dt.Rows(0).Item(0).ToString()
            If strStat = "Active" Then
                btnChangeStat.Text = "Retire"
            Else
                btnChangeStat.Text = "Activate"
            End If
            btnChangeStat.Visible = True
            btnEdit.Visible = True
        Else
            btnChangeStat.Visible = False
            btnEdit.Visible = False
        End If
    End Sub
End Class