Public Class frmViewClassRate

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

  
    Private Sub frmViewClassRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        selectedClassListID = selectedClassListID - 1
        classRate(arrClassSetID(selectedClassListID))
        'selectedClassListID = 0
        If selectedClassListID = 0 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If

        If selectedClassListID = classListCount Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        selectedClassListID = selectedClassListID + 1
        classRate(arrClassSetID(selectedClassListID))
        If selectedClassListID = 0 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If

        If selectedClassListID = classListCount Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
    End Sub
End Class