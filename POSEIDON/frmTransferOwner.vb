Imports MySql.Data.MySqlClient
Public Class frmTransferOwner

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Cons()
        If cboNewOwner.Text = "" Then
            MsgBox("No new owner Selected", MsgBoxStyle.Exclamation, "No Owner")
        Else
            If GoodForOwnerTransfer = True Then
                If MsgBox("Confirm Transfer?", MsgBoxStyle.YesNo, "Ownership Transfer Confirmation") = MsgBoxResult.Yes Then
                    Cons()
                    Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET consID=" & NewConsumerTransferID & ", AcctStatus=6 WHERE acctID=" & SelectedAccountIDTransfer, con)
                    cmd.ExecuteNonQuery()
                    Dim cmdP As New MySqlCommand("UPDATE tblorusage SET Status='Used' WHERE useID=" & ORUseID, con)
                    cmdP.ExecuteNonQuery()
                    Dim cmdDR As New MySqlCommand("UPDATE tbldailytransaction SET acctID=" & SelectedAccountIDTransfer & " WHERE pID=" & paymentID, con)
                    cmdDR.ExecuteNonQuery()
                    Dim cmdTransLog As New MySqlCommand("INSERT INTO tbltransferOwnlog(acctID, uID, prevConsID, newConsID, currentDate, transStat) VALUES(" & SelectedAccountIDTransfer & "," & loggedUserID & "," & SelectedConsumerIDTransfer & "," & NewConsumerTransferID & ",@cDate,2)", con)
                    cmdTransLog.Parameters.AddWithValue("@cDate", Format(dtpDate.Value.Date, "yyyy-MM-dd"))
                    cmdTransLog.ExecuteNonQuery()
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter("SELECT plID FROM tblpayment WHERE pID=" & paymentID, con)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Dim cmdPL As New MySqlCommand("UPDATE tblpaymentlogs SET acctID=" & SelectedAccountIDTransfer & " WHERE plID=" & Val(dt.Rows(0).Item(0).ToString), con)
                        cmdPL.ExecuteNonQuery()
                    End If


                    ViewAccountList()
                    Me.Close()
                End If
            Else
                MsgBox("Please check OR Number.", MsgBoxStyle.Exclamation, "No OR Number")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TypeNewCons = 2
        frmNewConsumer.Text = "New Consumer"
        frmNewConsumer.txtAddress.Text = ""
        frmNewConsumer.txtContact.Text = ""
        frmNewConsumer.txtName.Text = ""
        frmNewConsumer.ShowDialog()
    End Sub

    Private Sub frmTransferOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConsListTransferOwner()
    End Sub

    Private Sub cboNewOwner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewOwner.SelectedIndexChanged
        NewConsumerTransferID = arrTransConsID(cboNewOwner.SelectedIndex)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtOR.Text = "" Then
            lblCheckOR.Visible = True
            lblCheckOR.ForeColor = Color.Red
            lblCheckOR.Text = "Please enter OR Number"
            GoodForOwnerTransfer = False
        Else
            Cons()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT conID, FeeType, Status, useID FROM tblorusage WHERE ORNum='" & txtOR.Text.Replace("'", "''") & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim checkConsID As Integer = Val(dt.Rows(0).Item(0).ToString)
                Dim checkPayType As String = dt.Rows(0).Item(1).ToString
                Dim checkRemark As String = dt.Rows(0).Item(2).ToString
                Dim checkPID As Integer = Val(dt.Rows(0).Item(3).ToString)
                If checkPayType = "Ownership" Then
                    If checkRemark = "Unused" Then
                        If checkConsID = NewConsumerTransferID Or checkConsID = SelectedConsumerIDTransfer Then
                            'SelectedConsumerIDTransfer
                            lblCheckOR.Visible = True
                            lblCheckOR.ForeColor = Color.Green
                            lblCheckOR.Text = "OR is Available"
                            ORUseID = checkPID
                            Dim dtP As New DataTable
                            Dim daP As New MySqlDataAdapter("SELECT plID FROM tblPayment WHERE ORNumber='" & txtOR.Text.Replace("'", "''") & "'", con)
                            daP.Fill(dtP)
                            If dtP.Rows.Count > 0 Then
                                paymentID = Val(dtP(0).Item(0).ToString)
                            End If
                            GoodForOwnerTransfer = True
                        Else
                            lblCheckOR.Visible = True
                            lblCheckOR.ForeColor = Color.Red
                            lblCheckOR.Text = "The OR Used is not for this consumer"
                            GoodForOwnerTransfer = False
                        End If
                    Else
                        lblCheckOR.Visible = True
                        lblCheckOR.ForeColor = Color.Red
                        lblCheckOR.Text = "OR has already been used."
                        GoodForOwnerTransfer = False
                    End If
                Else
                    lblCheckOR.Visible = True
                    lblCheckOR.ForeColor = Color.Red
                    lblCheckOR.Text = "Payment should be for ownership."
                    GoodForOwnerTransfer = False
                End If
            Else
                lblCheckOR.Visible = True
                lblCheckOR.ForeColor = Color.Red
                lblCheckOR.Text = "OR Number is unavailable"
                GoodForOwnerTransfer = False
            End If

        End If
    End Sub
End Class