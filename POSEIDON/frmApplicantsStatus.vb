Public Class frmApplicantsStatus

    Private Sub frmApplicantsStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLatestApplicants()
        lblAsOf.Text = "AS OF " & UCase(Format(Now.Date, "MMMM dd, yyyy"))
    End Sub

    Private Sub lblAsOf_Click(sender As Object, e As EventArgs) Handles lblAsOf.Click

    End Sub
End Class