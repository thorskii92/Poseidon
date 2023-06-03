Imports MySql.Data.MySqlClient
Public Class frmTransferMeter
    Dim newSequenceNum As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.txtOR.Text = ""
        Me.Close()
    End Sub

    Private Sub frmTransferMeter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCheckOR.Visible = False
        GoodForMeterTransfer = False
        Me.txtOR.Text = ""
        Me.txtAddress.Text = ""
        LoadProvMeterCombo()
    End Sub

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        LoadMunMeterCombo(arrProvMeterTransID(cboProv.SelectedIndex))
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        LoadZoneMeterCombo(arrMunMeterTransID(cboMun.SelectedIndex))
    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged
        LoadBarMeterCombo(arrZoneMeterTransID(cboZone.SelectedIndex))
    End Sub

    Private Sub cboBar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBar.SelectedIndexChanged
        LoadClusMeterCombo(arrBarMeterTransID(cboBar.SelectedIndex))
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
            Dim da As New MySqlDataAdapter("SELECT consID, paymentType, Remark, pID FROM tblpayment WHERE ORNumber='" & txtOR.Text.Replace("'", "''") & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim checkConsID As Integer = Val(dt.Rows(0).Item(0).ToString)
                Dim checkPayType As String = dt.Rows(0).Item(1).ToString
                Dim checkRemark As String = dt.Rows(0).Item(2).ToString
                Dim checkPID As Integer = Val(dt.Rows(0).Item(3).ToString)
                If checkPayType = "Meter" Then
                    If checkRemark = "Unused" Then
                        If checkConsID = metTranConsID Then
                            lblCheckOR.Visible = True
                            lblCheckOR.ForeColor = Color.Green
                            lblCheckOR.Text = "OR is Available"
                            paymentID = checkPID
                            GoodForMeterTransfer = True
                        Else
                            lblCheckOR.Visible = True
                            lblCheckOR.ForeColor = Color.Red
                            lblCheckOR.Text = "The OR Used is not for this consumer"
                            GoodForMeterTransfer = False
                        End If
                    Else
                        lblCheckOR.Visible = True
                        lblCheckOR.ForeColor = Color.Red
                        lblCheckOR.Text = "OR has already been used."
                        GoodForMeterTransfer = False
                    End If
                Else
                    lblCheckOR.Visible = True
                    lblCheckOR.ForeColor = Color.Red
                    lblCheckOR.Text = "Payment should be for ownership."
                    GoodForMeterTransfer = False
                End If
            Else
                lblCheckOR.Visible = True
                lblCheckOR.ForeColor = Color.Red
                lblCheckOR.Text = "OR Number is unavailable"
                GoodForMeterTransfer = False
            End If

        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If txtOR.Text = "" Then
            MsgBox("OR Number is Missing", MsgBoxStyle.Exclamation, "No OR Number")
            Exit Sub
        Else
            If cboCluster.Text = "" Or txtAddress.Text = "" Then
                MsgBox("Please Fill Out Necessary Information", MsgBoxStyle.Exclamation, "Informations Missing")
            Else
                If MsgBox("Confirm Transfer?", MsgBoxStyle.YesNo, "Transfer Water Meter") = MsgBoxResult.Yes Then
                    If metTranBrgyID = arrBarMeterTransID(cboBar.SelectedIndex) And metTranClusID = Val(cboCluster.Text) Then
                        newSequenceNum = metTranSeqID
                    Else
                        Dim dtSeq As New DataTable
                        Dim daSeq As New MySqlDataAdapter("SELECT max(Sequence) FROM consumeraccounts WHERE brgyID=" & arrBarMeterTransID(cboBar.SelectedIndex) & " AND clusterID=" & Val(cboCluster.Text), con)
                        daSeq.Fill(dtSeq)
                        newSequenceNum = Val(dtSeq.Rows(0).Item(0).ToString) + 1
                    End If
                    Dim dtGetAddress As New DataTable
                    Dim daGetAddress As New MySqlDataAdapter("SELECT brgyID, streetaddress, clusterID FROM consumeraccounts WHERE acctID=" & metTranAcctID, con)
                    daGetAddress.Fill(dtGetAddress)
                    Dim cmdTM As New MySqlCommand("INSERT INTO tbltransfermeterlog(acctID, uID, dateOfTransfer, PreviousAddress, prevbrgyID, prevClusterID, PresentAddress, presentbrgyID, presClusterID) VALUES(@aID, @userID, current_date(), @prvAdd, @prvBID, @prvCID, @prsAdd, @prsBID, @prsCID)", con)
                    cmdTM.Parameters.AddWithValue("@aID", metTranAcctID)
                    cmdTM.Parameters.AddWithValue("@userID", loggedUserID)
                    cmdTM.Parameters.AddWithValue("@prvAdd", dtGetAddress.Rows(0).Item(1).ToString.Replace("'", "''"))
                    cmdTM.Parameters.AddWithValue("@prvBID", Val(dtGetAddress.Rows(0).Item(0).ToString))
                    cmdTM.Parameters.AddWithValue("@prvCID", Val(dtGetAddress.Rows(0).Item(2).ToString))
                    cmdTM.Parameters.AddWithValue("@prsAdd", txtAddress.Text.Replace("'", "''"))
                    cmdTM.Parameters.AddWithValue("@prsBID", arrBarMeterTransID(cboBar.SelectedIndex))
                    cmdTM.Parameters.AddWithValue("@prsCID", Val(cboCluster.Text))
                    cmdTM.ExecuteNonQuery()
                    Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET StreetAddress='" & txtAddress.Text.Replace("'", "''") & "',brgyID=" & arrBarMeterTransID(cboBar.SelectedIndex) & ", clusterID=" & Val(cboCluster.Text) & ", sequence=" & newSequenceNum & ", AcctStatus=5 WHERE acctID=" & metTranAcctID, con)
                    cmd.ExecuteNonQuery()
                    Dim cmdP As New MySqlCommand("UPDATE tblpayment SET Remark='Used', AcctID=" & metTranAcctID & " WHERE pID=" & paymentID, con)
                    cmdP.ExecuteNonQuery()
                    Dim cmdDR As New MySqlCommand("UPDATE tbldailytransaction SET acctID=" & metTranAcctID & " WHERE pID=" & paymentID, con)
                    cmdDR.ExecuteNonQuery()

                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter("SELECT plID FROM tblpayment WHERE pID=" & paymentID, con)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Dim cmdPL As New MySqlCommand("UPDATE tblpaymentlogs SET acctID=" & metTranAcctID & " WHERE plID=" & Val(dt.Rows(0).Item(0).ToString), con)
                        cmdPL.ExecuteNonQuery()
                    End If
                    MsgBox("Account is now set for Meter Transfer and will be listed to pending List", MsgBoxStyle.Information, "Meter is now Set for Transfer")
                    GoodForMeterTransfer = False
                    Me.txtOR.Text = ""
                    Me.txtAddress.Text = ""
                    ViewAccountList()
                    Me.Close()
                End If

            End If

        End If

    End Sub
End Class
