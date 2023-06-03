
Public Class frmReportFilterSelector
    Dim filterIndex As Integer
    Private Sub frmReportFilterSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        filterIndex = 1
        ReportFilterSelector(filterIndex, formReportIndex)
        Me.Close()
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        filterIndex = 2
        ReportFilterSelector(filterIndex, formReportIndex)
        Me.Close()
    End Sub

    Private Sub btnAnnual_Click(sender As Object, e As EventArgs) Handles btnAnnual.Click
        filterIndex = 3
        ReportFilterSelector(filterIndex, formReportIndex)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class