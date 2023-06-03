Imports MySql.Data.MySqlClient
Public Class frmEnterBillingNum

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Cons()
        strQueryBill = "SELECT * FROM tblbills AS B LEFT JOIN consumeraccounts AS A ON B.acctID=A.acctID LEFT JOIN consumerlist AS C ON B.consID=C.consID LEFT JOIN classifications AS CL ON B.classID=CL.classID LEFT JOIN brgylist AS BG ON A.brgyID=BG.brgyID LEFT JOIN userlist AS U ON B.uID=U.uID WHERE B.billID=" & Val(txtBillID.Text)
        WaterBillingQuery(strQueryBill)
        If billRowCount > 0 Then
            Me.Close()
        Else
            MsgBox("Billing Number Not Found", MsgBoxStyle.Exclamation, "Not Found")
            Exit Sub
        End If
    End Sub
End Class