Imports MySql.Data.MySqlClient
Public Class frmDailySales
    Dim genSql As String
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        lvwDaily.Items.Clear()
        Cons()
        Dim dt As New DataTable
        'genSql = "SELECT C.consumername, BL.addbrgy, P.ORNumber, If(P.paymentType='Bill Payment', Concat(Date_format(BI.fromdate, '%m-%d-%Y'), ' to ',Date_format(BI.todate, '%m-%d-%Y')), '') AS DatesRange, If(P.paymentType='Bill Payment', format(P.pAmount-P.surCharge, 2),'') AS payAmount , If(P.paymentType='Bill Payment', BI.consumption,'') AS Consumption, If(P.paymentType='Bill Payment', format(P.surcharge,2), '') AS Surcharge, P.paymentType, If(P.paymentType='Installation',P.pamount,'') AS Installation, If(P.paymentType<>'Installation' AND P.paymentType<>'Bill Payment', P.pAmount, '') AS OTHERS FROM tblPayment AS P LEFT JOIN tblBills AS BI ON P.billID=BI.billID LEFT JOIN consumerlist AS C ON P.consID=C.consID LEFT JOIN consumeraccounts AS A ON C.consID=A.consID LEFT JOIN brgylist AS BL ON A.brgyID=BL.brgyID LEFT JOIN tblorrecord AS O ON P.ORNumber=O.ORNum WHERE O.pdate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "'"
        genSql = "SELECT D.drID, D.ORNum, C.consumername, B.addbrgy, D.periodcovered, D.collection, D.consumption, D.surcharge, D.connectionfee, D.others, D.drDate, P.pID, C.consID FROM tblDailytransaction AS D LEFT JOIN consumeraccounts AS A ON D.acctID=A.AcctID LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN consumerlist AS C ON D.consID=C.consID LEFT JOIN tblpayment AS P ON D.pID=P.pID WHERE drDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "' ORDER BY D.ORNum ASC"
        Dim da As New MySqlDataAdapter(genSql, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                lst.Text = x + 1
                lst.SubItems.Add(dt.Rows(x).Item(1).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(4).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(5).ToString), "#,##0.#0"))
                lst.SubItems.Add(dt.Rows(x).Item(6).ToString)
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(7).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(8).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(9).ToString), "#,##0.#0"))
                lst.SubItems.Add(Format(Val(dt.Rows(x).Item(6).ToString), "#,##0.#0"))
                lvwDaily.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Cons()
        Dim da As New MySqlDataAdapter("SELECT D.drID, C.consumername, B.addbrgy, D.ORNum, D.periodcovered, D.collection, D.consumption, D.surcharge, D.connectionfee, D.others, D.drDate, P.pID, C.consID FROM tblDailytransaction AS D LEFT JOIN consumeraccounts AS A ON D.acctID=A.AcctID LEFT JOIN brgylist AS B ON A.brgyID=B.brgyID LEFT JOIN consumerlist AS C ON D.consID=C.consID LEFT JOIN tblpayment AS P ON D.pID=P.pID WHERE D.drDate='" & Format(dtpDate.Value, "yyyy-MM-dd") & "'", con)
        da.Fill(frmDailySalesReport.ReportDataSet.DailyTransactionDataSet)
        frmDailySalesReport.rpvDaily.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        frmDailySalesReport.rpvDaily.ZoomPercent = 100%
        frmDailySalesReport.rpvDaily.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        frmDailySalesReport.rpvDaily.Width = 75
        frmDailySalesReport.WindowState = FormWindowState.Maximized
        frmDailySalesReport.Show()
    End Sub

    Private Sub frmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genSql = ""
    End Sub
End Class