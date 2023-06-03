Imports MySql.Data.MySqlClient
Public Class frmReconnection

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtOR.Text = "" Then
            lblCheckOR.Visible = True
            lblCheckOR.ForeColor = Color.Red
            lblCheckOR.Text = "Please enter OR Number"
            GoodForReconnection = False
        Else
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT O.conID, O.FeeType, O.Status, P.pID FROM tblorusage AS O LEFT JOIN tblpayment AS P ON O.ORNum=P.ORNumber WHERE O.ORNum='" & txtOR.Text.Replace("'", "''") & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim checkConsID As Integer = Val(dt.Rows(0).Item(0).ToString)
                Dim checkPayType As String = dt.Rows(0).Item(1).ToString
                Dim checkRemark As String = dt.Rows(0).Item(2).ToString
                Dim checkPID As Integer = Val(dt.Rows(0).Item(3).ToString)
                If checkPayType = "Reconnection" Then
                    If checkRemark = "Unused" Then
                        If checkConsID = RecConsID Then
                            lblCheckOR.Visible = True
                            lblCheckOR.ForeColor = Color.Green
                            lblCheckOR.Text = "OR is Available"
                            paymentID = checkPID
                            GoodForReconnection = True
                        Else
                            lblCheckOR.Visible = True
                            lblCheckOR.ForeColor = Color.Red
                            lblCheckOR.Text = "The OR Used is not for this consumer"
                            GoodForReconnection = False
                        End If
                    Else
                        lblCheckOR.Visible = True
                        lblCheckOR.ForeColor = Color.Red
                        lblCheckOR.Text = "OR has already been used."
                        GoodForReconnection = False
                    End If
                Else
                    lblCheckOR.Visible = True
                    lblCheckOR.ForeColor = Color.Red
                    lblCheckOR.Text = "Payment is not for Reconnection."
                    GoodForReconnection = False
                End If
            Else
                lblCheckOR.Visible = True
                lblCheckOR.ForeColor = Color.Red
                lblCheckOR.Text = "OR Number is unavailable"
                GoodForReconnection = False
            End If

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you want to cancel Reconnection?", MsgBoxStyle.YesNo, "Cancel Reconnection") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If txtOR.Text = "" Then
            MsgBox("Please enter OR Number", MsgBoxStyle.Information, "No OR Number")
        Else
            If GoodForReconnection = True Then
                If MsgBox("Confirm Reconnection?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    Cons()
                    Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET AcctStatus=7 WHERE acctID=" & RecAcctID, con)
                    cmd.ExecuteNonQuery()
                    'Dim cmdP As New MySqlCommand("UPDATE tblpayment SET Remark='Used', AcctID=" & RecAcctID & " WHERE pID=" & paymentID, con)
                    'cmdP.ExecuteNonQuery()
                    Dim cmdDR As New MySqlCommand("UPDATE tbldailytransaction SET acctID=" & RecAcctID & " WHERE pID=" & paymentID, con)
                    cmdDR.ExecuteNonQuery()
                    Dim cmdL As New MySqlCommand("INSERT INTO tblreconnectionlog(acctID, consID, uID, transactDate, recstat) VALUES(" & RecAcctID & "," & RecConsID & "," & loggedUserID & ",current_date(),2)", con)
                    cmdL.ExecuteNonQuery()
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter("SELECT plID FROM tblpayment WHERE pID=" & paymentID, con)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Dim cmdPL As New MySqlCommand("UPDATE tblpaymentlogs SET acctID=" & RecAcctID & " WHERE plID=" & Val(dt.Rows(0).Item(0).ToString), con)
                        cmdPL.ExecuteNonQuery()
                    End If

                    Me.txtOR.Text = ""
                    Me.Close()
                End If
            Else
                MsgBox("Please check Official Receipt", MsgBoxStyle.Exclamation, "Check Official Receipt")
                Exit Sub
            End If
        End If
    End Sub
End Class