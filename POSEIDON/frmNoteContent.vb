Imports MySql.Data.MySqlClient
Public Class frmNoteContent

    Private Sub frmNoteContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCharCount.Text = charCount(txtContent.TextLength)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "New Note" Then
            If MsgBox("Save Note?", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("INSERT INTO tblNotes(uID, noteTitle, noteContent, noteDate, noteTime, noteDateTime) VALUES(" & loggedUserID & ",'" & txtTitle.Text.Replace("'", "''") & "','" & txtContent.Text.Replace("'", "''") & "','" & Format(Now.Date, "yyyy-MM-dd") & "','" & Format(Now, "HH:MM:ss") & "','" & Format(Now, "yyyy-MM-dd HH:MM:ss") & "')", con)
                cmd.ExecuteNonQuery()
                Me.txtContent.Text = ""
                Me.txtTitle.Text = ""
                LoadNotes(loggedUserID)
                Me.Close()
            End If
        Else
            If MsgBox("Save Changes?", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("UPDATE tblNotes SET noteTitle='" & txtTitle.Text.Replace("'", "''") & "', noteContent='" & txtContent.Text.Replace("'", "''") & "', noteDate='" & Format(Now.Date, "yyyy-MM-dd") & "', noteTime='" & Format(Now, "HH:MM:ss") & "', noteDateTime='" & Format(Now, "yyyy-MM-dd HH:MM:ss") & "' WHERE noteID=" & selectedNoteID, con)
                cmd.ExecuteNonQuery()
                Me.txtContent.Text = ""
                Me.txtTitle.Text = ""
                LoadNotes(loggedUserID)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub txtContent_TextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        lblCharCount.Text = charCount(txtContent.TextLength)
    End Sub

    Private Function charCount(counts As Integer) As String
        Dim x As Integer = counts
        Dim y As Integer = 1000 - x
        charCount = y & "/1000"
    End Function
End Class