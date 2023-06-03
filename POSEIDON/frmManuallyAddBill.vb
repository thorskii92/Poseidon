Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmManuallyAddBill
    Public consumerID As Integer
    Public clusterID As Integer
    Public brgyID As Integer

    Dim prevRead As Integer
    Dim presRead As Integer
    Dim consump As Integer
    Dim WSF As Decimal
    Dim PES As Decimal
    Dim discount As Decimal
    Dim totalAmount As Decimal
    Dim appFee As Decimal
    Dim penalty As Decimal
    Dim amtADue As Decimal

    Dim bDate As Date
    Dim rDate As Date
    Dim dueDate As Date
    Dim bMonth As String
    Dim bYear As Integer
    Dim bFromDate As Date
    Dim bToDate As Date

    Dim pWSF As Decimal
    Dim pEF As Decimal
    Dim pDis As Decimal
    Dim pPen As Decimal
    Dim pAppFee As Decimal
    Dim pTotal As Decimal

    Dim cNote As String

    Public conDate As Date
    Private Sub cboBillMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBillMonth.SelectedIndexChanged

    End Sub

    Private Function billChecker(acctID As Integer, billMonth As String, billYear As Integer) As Boolean
        Dim chk As Boolean = False
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM billing WHERE acctID=" & acctID & " and billMonth='" & billMonth & "' and billYear=" & billYear, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            chk = True
        Else
            chk = False
        End If
        Return chk
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Confirm saving new Bill?", "New bill creation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If billChecker(selectedAcctLedgerID, cboBillMonth.Text, cboYear.Text) = False Then
                Cons()
                Dim cmd As New MySqlCommand("INSERT INTO billing(acctID,consID,classID,dueDate,fromDate,toDate,billMonth,billYear,prevRead,presRead,prevConsump,prevEnv,prevPenalty,prevAmountDue,prevTotal,consump,amount,EnviFee,totalAmountDue,useAmount,useADue,penalty,AmountADue,isSC,SCDiscount,adjRemark,billStat,metReadID,billNote,uID,clusterID,billPeriod,billDate,readDate,prevSCDis,brgyID,applicationfee) VALUES(@aID,@cID,@clID,@dDate,@fDate,@tDate,@bMonth,@bYear,@pvRead,@psRead,@pvCons,@pvEF,@pvPen,@pvAmtD,@pvTot,@consmp,@amt,@EF,@tAmtDue,@useAmt,@uAfDue,@pen,@amtADue,@SCPWD,@SCDis,@adjRem,@bStat,@mRID,@bNote,@useID,@clusID,@bPer,@bDate,@rDate,@pvDis,@brgID,@appfee)", con)
                cmd.Parameters.AddWithValue("@aID", selectedAcctLedgerID)
                cmd.Parameters.AddWithValue("@cID", consumerID)
                cmd.Parameters.AddWithValue("@clID", ccManBill(cboClassification.SelectedIndex))
                cmd.Parameters.AddWithValue("@dDate", Format(dtpDueDate.Value.Date, "yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@fDate", Format(dtpFromDate.Value.Date, "yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@tDate", Format(dtpToDate.Value.Date, "yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@bMonth", cboBillMonth.Text)
                cmd.Parameters.AddWithValue("@bYear", cboYear.Text)
                cmd.Parameters.AddWithValue("@pvRead", Val(txtPrevRead.Text))
                cmd.Parameters.AddWithValue("@psRead", Val(txtPresRead.Text))
                cmd.Parameters.AddWithValue("@pvCons", Val(txtPrevEF.Text))
                cmd.Parameters.AddWithValue("@pvEF", Val(txtPrevEF.Text))
                cmd.Parameters.AddWithValue("@pvPen", Val(txtPrevPenalty.Text))
                cmd.Parameters.AddWithValue("@pvAmtD", Val(txtPrevAmount.Text) + Val(txtPrevEF.Text))
                cmd.Parameters.AddWithValue("@pvTot", Val(txtPrevTotal.Text))
                cmd.Parameters.AddWithValue("@consmp", Val(lblConsump.Text))
                cmd.Parameters.AddWithValue("@amt", Val(txtWSF.Text) + Val(txtEF.Text))
                cmd.Parameters.AddWithValue("@EF", Val(txtEF.Text))
                cmd.Parameters.AddWithValue("@tAmtDue", Val(txtTotalAmt.Text))
                cmd.Parameters.AddWithValue("@useAmt", Val(txtTotalAmt.Text))
                cmd.Parameters.AddWithValue("@uAfDue", Val(txtAmountAfterDue.Text))
                cmd.Parameters.AddWithValue("@pen", Val(txtPenalty.Text))
                cmd.Parameters.AddWithValue("@amtADue", Val(txtAmountAfterDue.Text))
                Dim getSC As String
                If cboAccountType.Text = "Regular" Then
                    getSC = "NO"
                Else
                    getSC = "YES"
                End If
                cmd.Parameters.AddWithValue("@SCPWD", getSC)
                cmd.Parameters.AddWithValue("@SCDis", Val(txtDiscount.Text))
                cmd.Parameters.AddWithValue("@adjRem", "None")
                cmd.Parameters.AddWithValue("@bStat", "UNPAID")
                cmd.Parameters.AddWithValue("@mRID", 1)
                cmd.Parameters.AddWithValue("@bNote", txtBillNote.Text)
                'cmd.Parameters.AddWithValue("@zoneID", "")
                cmd.Parameters.AddWithValue("@useID", loggedUserID)
                cmd.Parameters.AddWithValue("@clusID", clusterID)
                cmd.Parameters.AddWithValue("@bPer", Format(dtpFromDate.Value.Date, "MM/dd/yyyy") & " - " & Format(dtpToDate.Value.Date, "MM/dd/yyyy"))
                cmd.Parameters.AddWithValue("@bDate", Format(dtpBillDate.Value.Date, "yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@rDate", Format(dtpReadDate.Value.Date, "yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@pvDis", Val(txtPrevDiscount.Text))
                cmd.Parameters.AddWithValue("@brgID", brgyID)
                cmd.Parameters.AddWithValue("@appfee", Val(txtAppFee.Text))
                cmd.ExecuteNonQuery()
                MessageBox.Show("Bill has been Created", "Bill Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Bill Month and year for this Account has been existing, Please change bill month, or edit the current bill you're making", "Bill Existing", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub rdbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rdbManual.CheckedChanged
        If rdbManual.Checked = True Then
            txtPenalty.ReadOnly = False
            txtWSF.ReadOnly = False
            txtEF.ReadOnly = False
            txtDiscount.ReadOnly = False

            txtPenalty.Enabled = True
            txtWSF.Enabled = True
            txtEF.Enabled = True
            txtDiscount.Enabled = True
        End If
    End Sub

    Private Sub rdbNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNew.CheckedChanged
        If rdbNew.Checked = True Then
            txtPenalty.ReadOnly = True
            txtWSF.ReadOnly = True
            txtEF.ReadOnly = True
            txtDiscount.ReadOnly = True

            txtPenalty.Enabled = False
            txtWSF.Enabled = False
            txtEF.Enabled = False
            txtDiscount.Enabled = False
            'txtPrevRead.Text = "0"
            'txtPresRead.Text = "0"
            'lblConsump.Text = "0"
            'ComputeAmount()
        End If
    End Sub

    Public Sub LoadYear()
        cboYear.Items.Clear()

        For y As Integer = 2016 To Now.Year
            cboYear.Items.Add(y)
        Next
    End Sub
    Public Sub LoadClassification()

    End Sub

    Private Sub ComputeAmount()
        Dim amt As Decimal
        Dim getSC As String
        If cboAccountType.Text = "Regular" Then
            getSC = "NO"
        Else
            getSC = "YES"
        End If
        'Dim compT As Integer
        'If rdbOld.Checked = True Then
        '    compT = 1
        'Else
        '    compT = 2
        'End If

        'Dim sql As String = "("
        'Dim dtMinRate As New DataTable
        'Dim daMinRate As New MySqlDataAdapter("SELECT Rate FROM tblclassrates WHERE classID=" & arrBillEditorClassID(cboClassification.SelectedIndex) & " AND IsMin=1", con)
        'daMinRate.Fill(dtMinRate)
        'Dim dtMinCub As New DataTable
        'Dim daMinCub As New MySqlDataAdapter("SELECT Cubits FROM tblclassrates WHERE classID=" & arrBillEditorClassID(cboClassification.SelectedIndex) & " AND IsMin=1", con)
        'daMinCub.Fill(dtMinCub)
        'Dim MinCub As Integer = dtMinCub.Rows(0).Item(0)
        'Dim MinRate As Double = dtMinRate.Rows(0).Item(0)
        consump = Val(txtPresRead.Text) - Val(txtPrevRead.Text)
        lblConsump.Text = consump
        'RateAmount(cConsump, arrBillEditorClassID(cboClassification.SelectedIndex))
        If rdbManual.Checked = False Then
            amt = CalculateRate(ccManBill(cboClassification.SelectedIndex), consump)
            SingleVarMetCompute(consump, amt, getSC, Val(txtPrevTotal.Text), conDate, dtpBillDate.Value.Date)
            txtWSF.Text = Format(mAmt - mEF, "#,##0.#0")
            txtEF.Text = Format(mEF, "#,##0.#0")
            txtTotal.Text = Format(mAmt - mSC, "#,##0.#0")
            txtTotalAmt.Text = Format(mAmt - mSC, "#,##0.#0")
            txtPenalty.Text = Format(mP, "#,##0.#0")
            txtAmountAfterDue.Text = Format(mTP, "#,##0.#0")
            txtDiscount.Text = Format(mSC, "#,##0.#0")
        End If

    End Sub

    Private Sub txtPrevRead_TextChanged(sender As Object, e As EventArgs) Handles txtPrevRead.TextChanged

    End Sub

    Private Sub txtPrevRead_LostFocus(sender As Object, e As EventArgs) Handles txtPrevRead.LostFocus
        ComputeAmount()
    End Sub

    Private Sub txtPresRead_TextChanged(sender As Object, e As EventArgs) Handles txtPresRead.TextChanged

    End Sub

    Private Sub txtPresRead_LostFocus(sender As Object, e As EventArgs) Handles txtPresRead.LostFocus
        ComputeAmount()
    End Sub

    Private Sub frmManuallyAddBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadYear()
    End Sub
End Class