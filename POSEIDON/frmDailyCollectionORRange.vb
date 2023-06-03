Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmDailyCollectionORRange
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txtFirst.Text = "" Or txtLast.Text = "" Then
            MessageBox.Show("Please enter values", "No Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim firstVal As Integer = txtFirst.Text
            Dim lastVal As Integer = txtLast.Text
            If firstVal < lastVal Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM poseidondb.tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE CAST(ORNum AS UNSIGNED) >= " & firstVal & " AND CAST(ORNum AS UNSIGNED)<=" & lastVal & " ORDER BY ORNum", con)
                da.Fill(dt)
                Dim report As New crptDailyCollection
                'report.SetParameterValue("txtRDNum", EnteredRD)
                report.SetDataSource(dt)
                frmDailyCollectionReport.CrystalReportViewer1.ReportSource = report
                frmDailyCollectionReport.CrystalReportViewer1.Zoom(100%)
                frmDailyCollectionReport.CrystalReportViewer1.Refresh()
                frmDailyCollectionReport.WindowState = FormWindowState.Maximized
                frmDailyCollectionReport.ShowDialog()
            Else
                MessageBox.Show("First values should be lower", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
End Class