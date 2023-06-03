Imports MySql.Data.MySqlClient
Public Class frmNotes
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmNoteContent.txtContent.Text = ""
        frmNoteContent.txtTitle.Text = ""
        frmNoteContent.Text = "New Note"
        frmNoteContent.StartPosition = FormStartPosition.CenterScreen
        frmNoteContent.ShowDialog()
    End Sub

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotes(loggedUserID)
    End Sub

    Private Sub lvwNotes_DoubleClick(sender As Object, e As EventArgs) Handles lvwNotes.DoubleClick
        If lvwNotes.SelectedItems.Count > 0 Then
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT noteTitle, noteContent FROM tblNotes WHERE noteID=" & noteIDs(lvwNotes.FocusedItem.Index), con)
            da.Fill(dt)
            selectedNoteID = noteIDs(lvwNotes.FocusedItem.Index)
            frmNoteContent.txtTitle.Text = dt.Rows(0).Item(0).ToString.Replace("''", "'")
            frmNoteContent.txtContent.Text = dt.Rows(0).Item(1).ToString.Replace("''", "'")
            frmNoteContent.StartPosition = FormStartPosition.CenterScreen
            frmNoteContent.Text = "Edit Note"
            frmNoteContent.ShowDialog()
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Exclamation, "Nothing selected")
        End If
    End Sub

    Private Sub lvwNotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwNotes.SelectedIndexChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvwNotes.SelectedItems.Count > 0 Then
            If MsgBox("Are you sure you want to DELETE This Note?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM tblNotes WHERE noteID=" & noteIDs(lvwNotes.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                LoadNotes(loggedUserID)
                MsgBox("Done", MsgBoxStyle.Information, "Note Deleted")
            End If
        Else
            MsgBox("Please select an Item", MsgBoxStyle.Exclamation, "Nothing selected")
        End If
    End Sub
End Class