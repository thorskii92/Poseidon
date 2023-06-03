Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmMultipleBillEditor
    Dim arrMEBrgyID() As Integer
    Private Sub frmMultipleBillEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim str As String = "SELECT B.brgyID, B.classID, R.AddBrgy, A.AccountName, B.billmonth ,B.useAmount, B.consump, B.prevRead, B.presRead, B.prevTotal FROM narradb.billing AS B LEFT JOIN brgylist AS R ON B.brgyID=R.brgyID LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID where useAmount=0"
        LoadMEAllBrgy()
        LoadMonths()
        LoadYear()
        txtSearch.Text = ""
    End Sub

    Private Sub cboFilterType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterType.SelectedIndexChanged
        If cboFilterType.SelectedIndex = 0 Then 'NONE
            cboBarangay.Visible = False
            cboMonths.Visible = False
            cboYear.Visible = False
            txtSearch.Visible = False
            lblBarangay.Visible = False
            lblMonth.Visible = False
            lblYear.Visible = False
            lblSearch.Visible = False
        ElseIf cboFilterType.SelectedIndex = 1 Then 'AMOUNT
            cboBarangay.Visible = False
            cboMonths.Visible = False
            cboYear.Visible = False
            txtSearch.Visible = True
            lblBarangay.Visible = False
            lblMonth.Visible = False
            lblYear.Visible = False
            lblSearch.Visible = True
        ElseIf cboFilterType.SelectedIndex = 2 Then 'BARANGAY
            cboBarangay.Visible = True
            cboMonths.Visible = True
            cboYear.Visible = True
            txtSearch.Visible = False
            lblBarangay.Visible = True
            lblMonth.Visible = True
            lblYear.Visible = True
            lblSearch.Visible = False
        ElseIf cboFilterType.SelectedIndex = 3 Then 'MONTH
            cboBarangay.Visible = False
            cboMonths.Visible = True
            cboYear.Visible = True
            txtSearch.Visible = False
            lblBarangay.Visible = False
            lblMonth.Visible = True
            lblYear.Visible = True
            lblSearch.Visible = False
        ElseIf cboFilterType.SelectedIndex = 4 Then 'NAME
            cboBarangay.Visible = False
            cboMonths.Visible = False
            cboYear.Visible = False
            txtSearch.Visible = True

            lblBarangay.Visible = False
            lblMonth.Visible = False
            lblYear.Visible = False
            lblSearch.Visible = True
        End If
    End Sub

    Private Sub LoadMEAllBrgy()
        cboBarangay.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT brgyID, AddBrgy FROM brgylist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrMEBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrMEBrgyID(x) = Val(dt.Rows(x).Item(0).ToString)
                cboBarangay.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub

    Private Sub LoadMonths()
        cboMonths.Items.Clear()
        For x As Integer = 1 To 12
            cboMonths.Items.Add(MonthName(x))
        Next
    End Sub

    Private Sub LoadYear()
        cboYear.Items.Clear()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT min(billyear), max(billYear) FROM billing", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim i As Integer = Val(dt.Rows(0).Item(0).ToString)
            Dim j As Integer = Val(dt.Rows(0).Item(1).ToString)
            For x As Integer = i To j
                cboYear.Items.Add(x)
            Next
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        dgvBills.Rows.Clear()
        Dim dt As New DataTable
        If cboFilterType.SelectedIndex = 0 Then
        ElseIf cboFilterType.SelectedIndex = 1 Then
            dt = MultipleBillDataTable(" WHERE useAmount=" & Val(txtSearch.Text) & " or amount=" & Val(txtSearch.Text))
        End If

        If dt.Rows.Count > 0 Then
            DeclareRCVars(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                rcBillID(x) = Val(dt.Rows(x).Item(0).ToString())
                rcAcctID(x) = Val(dt.Rows(x).Item(1).ToString())
                rcConsID(x) = Val(dt.Rows(x).Item(2).ToString())
                rcClassID(x) = Val(dt.Rows(x).Item(3).ToString())
                rcBrgyID(x) = Val(dt.Rows(x).Item(4).ToString())
                rcAccountNo(x) = dt.Rows(x).Item(5).ToString()
                rcAccountName(x) = dt.Rows(x).Item(6).ToString()
                rcClassification(x) = dt.Rows(x).Item(7).ToString()
                rcType(x) = If(dt.Rows(x).Item(8).ToString() = "YES", "SC/PWD", "Regular")
                rcSAddress(x) = dt.Rows(x).Item(9).ToString()
                rcBrgy(x) = dt.Rows(x).Item(10).ToString()
                rcReadDate(x) = dt.Rows(x).Item(11)
                rcBillDate(x) = dt.Rows(x).Item(12)
                rcDueDate(x) = dt.Rows(x).Item(13)
                rcFromDate(x) = dt.Rows(x).Item(14)
                rcToDate(x) = dt.Rows(x).Item(15)
                rcBillMonth(x) = dt.Rows(x).Item(16).ToString()
                rcBillYear(x) = Val(dt.Rows(x).Item(17).ToString())
                rcPrevRead(x) = Val(dt.Rows(x).Item(18).ToString())
                rcPresRead(x) = Val(dt.Rows(x).Item(19).ToString())
                rcConsump(x) = Val(dt.Rows(x).Item(20).ToString())
                rcEF(x) = Val(dt.Rows(x).Item(22).ToString())
                rcDis(x) = Val(dt.Rows(x).Item(23).ToString())
                rcAmount(x) = Val(dt.Rows(x).Item(24).ToString())
                rcWSF(x) = rcAmount(x) - rcEF(x) + rcDis(x)
                rcPenalty(x) = Val(dt.Rows(x).Item(26).ToString())
                rcTotalAmount(x) = Val(dt.Rows(x).Item(28).ToString())
                rcPrevAmount(x) = Val(dt.Rows(x).Item(29).ToString())
                rcPrevPenalty(x) = Val(dt.Rows(x).Item(30).ToString())
                rcPrevTotal(x) = Val(dt.Rows(x).Item(31).ToString())
                rcOverpay(x) = Val(dt.Rows(x).Item(32).ToString())
                rcPeriod(x) = Month(rcFromDate(x)) & "/" & DateAndTime.Day(rcFromDate(x)) & "-" & DateAndTime.Day(rcToDate(x)) & "/" & Year(rcFromDate(x))
            Next
            For y As Integer = 0 To dt.Rows.Count - 1
                dgvBills.Rows.Add(rcAccountNo(y), rcAccountName(y), rcClassification(y), rcType(y), rcSAddress(y), rcBrgy(y), rcReadDate(y), rcBillDate(y), rcDueDate(y), rcFromDate(y), rcToDate(y), rcBillMonth(y), rcBillYear(y), rcPrevRead(y), rcPresRead(y), rcConsump(y), rcWSF(y), rcEF(y), rcDis(y), rcAmount(y), rcPenalty(y), rcTotalAmount(y), rcPrevAmount(y), rcPrevPenalty(y), rcPrevTotal(y))
            Next
        End If
    End Sub

    Private Sub dgvBills_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBills.CellContentClick

    End Sub

    Private Sub dgvBills_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvBills.DataError
        Dim handle As Boolean
        If Me.dgvBills.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.Equals(DBNull.Value) Then
            handle = True
        Else
            handle = False
        End If
        e.Cancel = handle
    End Sub

    Private Sub dgvBills_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBills.CellValueChanged

    End Sub
End Class