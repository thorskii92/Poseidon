Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmMeterReaderEditor
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If meterReaderSettingSavingType = 1 Then
            'NEW
            Cons()
            Dim cmd As New MySqlCommand("INSERT INTO meterreader(metName, metStat) VALUES(@mName,'Active')", con)
            cmd.Parameters.AddWithValue("@mName", txtName.Text)
            cmd.ExecuteNonQuery()
            txtName.Text = ""
            LoadMeterReaders()
            frmMeterReaders.btnChangeStat.Visible = False
            frmMeterReaders.btnEdit.Visible = False
            Me.Close()
        Else
            'UPDATE
            Cons()
            Dim cmd As New MySqlCommand("UPDATE meterreader SET metName=@mName WHERE metID=" & selSettingsMetReaderID, con)
            cmd.Parameters.AddWithValue("@mName", txtName.Text)
            cmd.ExecuteNonQuery()
            LoadMeterReaders()
            frmMeterReaders.btnChangeStat.Visible = False
            frmMeterReaders.btnEdit.Visible = False
            MessageBox.Show("Meter Reader has been Updated", "Meter Reader updated")
            txtName.Text = ""
            Me.Close()
        End If
    End Sub
End Class