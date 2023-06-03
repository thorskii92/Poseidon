Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmORGroupSelection
    Dim arrORGID() As Integer
    Dim firstOR As Integer
    Dim lastOR As Integer
    Private Sub frmORGroupSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ORGroupload()
    End Sub

    Private Sub ORGroupload()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblorgroup ORDER BY Initial ASC", con)
        da.Fill(dt)
        lvwOR.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrORGID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrORGID(x) = Val(dt.Rows(x).Item(0))
                Dim lst As New ListViewItem
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add("")
                lvwOR.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If lvwOR.SelectedItems.Count > 0 Then

            Dim dtG As New DataTable
            Dim daG As New MySqlDataAdapter("SELECT * FROM tblorgroup WHERE ogID=" & arrORGID(lvwOR.FocusedItem.Index), con)
            daG.Fill(dtG)
            firstOR = dtG.Rows(0).Item(2)
            lastOR = dtG.Rows(0).Item(3)
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM poseidondb.tblor AS O LEFT JOIN consumerlist AS C ON O.consID=C.consID WHERE CAST(ORNum AS UNSIGNED) >= " & firstOR & " AND CAST(ORNum AS UNSIGNED)<=" & lastOR & " ORDER BY ORNum", con)
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
            MessageBox.Show("Please select a group on the list", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class