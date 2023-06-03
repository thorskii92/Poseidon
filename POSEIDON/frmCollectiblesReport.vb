Public Class frmCollectiblesReport
    Private Sub frmCollectiblesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAsOf.Text = "AS OF " & Format(Now, "MM/dd/yyyy")
        CollectiblesReport()
    End Sub
End Class