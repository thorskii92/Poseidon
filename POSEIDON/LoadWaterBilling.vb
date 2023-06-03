Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class LoadWaterBilling

    Private Sub cboFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFrom.SelectedIndexChanged
        SelectedMonth(cboFrom.SelectedIndex)
    End Sub

    Private Sub SelectedMonth(i As Integer)
        If i = 0 Then
            lblTo.Text = "February"
        ElseIf i = 1 Then
            lblTo.Text = "March"
        ElseIf i = 2 Then
            lblTo.Text = "April"
        ElseIf i = 3 Then
            lblTo.Text = "May"
        ElseIf i = 4 Then
            lblTo.Text = "June"
        ElseIf i = 5 Then
            lblTo.Text = "July"
        ElseIf i = 6 Then
            lblTo.Text = "August"
        ElseIf i = 7 Then
            lblTo.Text = "September"
        ElseIf i = 8 Then
            lblTo.Text = "October"
        ElseIf i = 9 Then
            lblTo.Text = "November"
        ElseIf i = 10 Then
            lblTo.Text = "December"
        ElseIf i = 11 Then
            lblTo.Text = "January"
        Else
            lblTo.Text = ""
        End If
    End Sub

    Private Sub LoadWaterBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BillSelectProvList()
        BillSelectBrgyList()
        setYears()
        LoadLatestMonth()
    End Sub

    Private Sub LoadLatestMonth()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT billMonth FROM billing ORDER BY billid DESC LIMIT 1;", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim latestMonth As String = dt.Rows(0).Item(0).ToString
            cboFrom.Text = latestMonth
        Else
            cboFrom.Text = MonthName(Now.Month)
        End If
    End Sub
    Private Sub setYears()
        cboYear.Items.Clear()
        For yearss As Integer = 2016 To Now.Year
            cboYear.Items.Add(yearss)
        Next
        cboYear.Text = Now.Year
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        BillSelectMunList(arrBillProvID(cboProvince.SelectedIndex))
    End Sub

    Private Sub cboMunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipality.SelectedIndexChanged
        BillSelectZoneList(arrBillMunID(cboMunicipality.SelectedIndex))
    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged
        'BillSelectBrgyList(arrBillZoneID(cboZone.SelectedIndex))
    End Sub

    Private Sub cboBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarangay.SelectedIndexChanged
        BillSelectClusterList(arrBillBrgyID(cboBarangay.SelectedIndex))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            ViewWaterBilling(cboFrom.Text, lblTo.Text, cboYear.Text, arrBillCLusterID(cboCluster.SelectedIndex))
            frmBilling.lblBillStat.Text = "Currently Billing: | Period: " & cboFrom.Text & " - " & lblTo.Text & " " & cboYear.Text & " | Prov: " & cboProvince.Text & " | Mun: " & cboMunicipality.Text & " | Zone: " & cboZone.Text & " | Brgy: " & cboBarangay.Text & " | Cluster: " & cboCluster.Text & " |"
            'MessageBox.Show(strQueryBill)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please select an Item", "Poseidon Database System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class