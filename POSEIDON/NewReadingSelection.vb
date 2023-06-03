Public Class NewReadingSelection

    Private Sub NewReadingSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setYears()
        'MessageBox.Show(Now.Month)
        cboPeriodMonth.SelectedIndex = Now.Month - 1

        NewReadProvList()

        dtpDue.Value = dtpReadDate.Value.AddDays(15)
        'dtpFrom.Value = Now.AddDays(-30)

        'cboYear.Text = Now.Year
        cboYear.Text = Now.Year
    End Sub

    Private Sub setYears()
        cboYear.Items.Clear()
        For yearss As Integer = 2000 To 2050
            cboYear.Items.Add(yearss)
        Next
        'cboYear.Text = Now.Year
    End Sub

    Private Sub SelectedMonth(i As Integer)
        If i = 0 Then
            lblMonth.Text = "February"
        ElseIf i = 1 Then
            lblMonth.Text = "March"
        ElseIf i = 2 Then
            lblMonth.Text = "April"
        ElseIf i = 3 Then
            lblMonth.Text = "May"
        ElseIf i = 4 Then
            lblMonth.Text = "June"
        ElseIf i = 5 Then
            lblMonth.Text = "July"
        ElseIf i = 6 Then
            lblMonth.Text = "August"
        ElseIf i = 7 Then
            lblMonth.Text = "September"
        ElseIf i = 8 Then
            lblMonth.Text = "October"
        ElseIf i = 9 Then
            lblMonth.Text = "November"
        ElseIf i = 10 Then
            lblMonth.Text = "December"
        ElseIf i = 11 Then
            lblMonth.Text = "January"
        Else
            lblMonth.Text = ""
        End If
    End Sub

    Private Sub cboPeriodMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodMonth.SelectedIndexChanged
        Try
            SelectedMonth(cboPeriodMonth.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboYear.Text, cboPeriodMonth.SelectedIndex + 1)
            Dim d As DateTime
            d = New DateTime(cboYear.Text, cboPeriodMonth.SelectedIndex + 1, 1)
            Dim f As DateTime
            f = New DateTime(cboYear.Text, cboPeriodMonth.SelectedIndex + 1, finalday)
            dtpFrom.Value = d
            dtpTo.Value = f
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboPeriodMonth_TextChanged(sender As Object, e As EventArgs) Handles cboPeriodMonth.TextChanged
        Try
            SelectedMonth(cboPeriodMonth.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboYear.Text, cboPeriodMonth.SelectedIndex + 1)
            'MessageBox.Show(System.DateTime.DaysInMonth(cboYear.Text, cboPeriodMonth.SelectedIndex + 1))
            Dim d As DateTime
            d = New DateTime(cboYear.Text, cboPeriodMonth.SelectedIndex + 1, 1)
            Dim f As DateTime
            f = New DateTime(cboYear.Text, cboPeriodMonth.SelectedIndex + 1, finalday)

            dtpFrom.Value = d
            dtpTo.Value = f
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtpReadDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReadDate.ValueChanged
        dtpDue.Value = dtpReadDate.Value.AddDays(15)
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        NewReadMunList(arrNewReadProvID(cboProvince.SelectedIndex))
    End Sub

    Private Sub cboProvince_TextChanged(sender As Object, e As EventArgs) Handles cboProvince.TextChanged
        ' NewReadMunList(arrNewReadMunID(cboProvince.SelectedIndex))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboMunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipality.SelectedIndexChanged
        NewReadZoneList(arrNewReadMunID(cboMunicipality.SelectedIndex))
    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged
        NewReadBrgyList(arrNewReadZoneID(cboZone.SelectedIndex))
    End Sub

    Private Sub cboBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarangay.SelectedIndexChanged
        NewReadClusterList(arrNewReadBrgyID(cboBarangay.SelectedIndex))
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        frmMeterReading.lblProv.Text = cboProvince.Text
        frmMeterReading.lblMunicipality.Text = cboMunicipality.Text
        frmMeterReading.lblZone.Text = "Z:" & cboZone.Text
        mZone = Val(cboZone.Text)
        disconDate = dtpDue.Value.AddDays(6)
        frmMeterReading.lblBrgy.Text = "Brgy:" & cboBarangay.Text
        frmMeterReading.lblCluster.Text = "C:" & cboCluster.Text
        'mCluster = Val(arrReadClusterID(cboCluster.SelectedIndex))
        frmMeterReading.lblReadDate.Text = "Reading Date:" & Format(dtpReadDate.Value, "yyyy-MM-dd")
        readingDate = Format(dtpReadDate.Value, "yyyy-MM-dd")
        frmMeterReading.lblDueDate.Text = "Due Date:" & Format(dtpDue.Value, "yyyy-MM-dd")
        readingDue = Format(dtpDue.Value, "yyyy-MM-dd")
        frmMeterReading.lblPerCovered.Text = "Period Covered: " & cboPeriodMonth.Text & " to " & lblMonth.Text & " " & cboYear.Text
        MonthReadFrom = cboPeriodMonth.Text
        MonthReadTo = lblMonth.Text
        MonthReadYear = cboYear.Text
        perFromDate = dtpFrom.Value
        perToDate = dtpTo.Value
        Dim finalday As Integer = System.DateTime.DaysInMonth(cboYear.Text, cboPeriodMonth.SelectedIndex + 1)
        billperiod = Format(dtpFrom.Value.Date, "MM/dd/yyyy") & " - " & Format(dtpTo.Value.Date, "MM/dd/yyyy")
        'MessageBox.Show(billperiod)
        MeterReadList(arrNewReadBrgyID(cboBarangay.SelectedIndex), cboPeriodMonth.Text, lblMonth.Text, cboYear.Text)
        MeterReadingBool = True
        Me.Close()
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        'dtpTo.Value = dtpFrom.Value.AddDays(30)
        'cboPeriodMonth.Text = Format(dtpFrom.Value, "MMMM")
        'SelectedMonth(cboPeriodMonth.SelectedIndex)
        ''MsgBox(Val(dtpFrom.Value.Month) - 1)
        'cboYear.Text = dtpTo.Value.Year
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        'cboPeriodMonth.Text = Format(dtpFrom.Value, "MMMM")
        'SelectedMonth(cboPeriodMonth.SelectedIndex)
        ''MsgBox(Val(dtpFrom.Value.Month) - 1)
        'cboYear.Text = dtpTo.Value.Year
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        Try
            SelectedMonth(cboPeriodMonth.SelectedIndex)
            Dim finalday As Integer = System.DateTime.DaysInMonth(cboYear.Text, cboPeriodMonth.SelectedIndex + 1)
            Dim d As DateTime
            d = New DateTime(cboYear.Text, cboPeriodMonth.SelectedIndex + 1, 1)
            Dim f As DateTime
            f = New DateTime(cboYear.Text, cboPeriodMonth.SelectedIndex + 1, finalday)
            dtpFrom.Value = d
            dtpTo.Value = f
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboCluster_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCluster.SelectedIndexChanged

    End Sub
End Class