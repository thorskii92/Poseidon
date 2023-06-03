Imports MySql.Data.MySqlClient
Public Class frmSequencing
    Dim curSeq As Integer
    Dim newSeq As Integer
    Private Sub frmSequencing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeqProvCombo()
        txtCurSeq.Enabled = False
        txtNewSeqNum.Enabled = False
        btnSet.Enabled = False
    End Sub

    Private Sub cboMunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipality.SelectedIndexChanged
        SeqZoneCombo(arrSeqMunID(cboMunicipality.SelectedIndex))
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        SeqMunCombo(arrSeqProvID(cboProvince.SelectedIndex))
    End Sub

    Private Sub cboZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZone.SelectedIndexChanged
        SeqBarangayCombo(arrSeqZoneID(cboZone.SelectedIndex))
    End Sub

    Private Sub cboBarangay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBarangay.SelectedIndexChanged
        SeqList(arrSeqBrgyID(cboBarangay.SelectedIndex))
        'SeqClusterCombo(arrSeqBrgyID(cboBarangay.SelectedIndex))
    End Sub

    Private Sub cboCluster_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvwSeq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSeq.SelectedIndexChanged
        If lvwSeq.SelectedItems.Count > 0 Then
            curSeq = Val(lvwSeq.FocusedItem.Text)
            selSeqAcctID = arrSeqAccID(lvwSeq.FocusedItem.Index)
            txtCurSeq.Text = curSeq
        End If
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        newSeq = Val(txtNewSeqNum.Text)
        If newSeq > maxSeqNum Then
            MsgBox("The Sequence Number you entered should't be higher than the Highest Sequence Value", MsgBoxStyle.Information, "Sequence Number of Of Range")
        Else
            If newSeq < curSeq Then
                'SET FIRST TO ZERO SEQUENCE
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET sequence=0 WHERE acctID=" & selSeqAcctID, con)
                cmd.ExecuteNonQuery()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT acctID, Sequence FROM consumeraccounts WHERE sequence BETWEEN " & newSeq & " AND " & curSeq - 1 & " AND brgyID=" & arrSeqBrgyID(cboBarangay.SelectedIndex), con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Dim arTeActID(dt.Rows.Count - 1) As Integer
                    Dim cSeq As Integer
                    Dim adSeq As Integer
                    For x As Integer = 0 To dt.Rows.Count - 1
                        arTeActID(x) = Val(dt.Rows(x).Item(0).ToString)
                        cSeq = Val(dt.Rows(x).Item(1).ToString)
                        adSeq = cSeq + 1
                        Dim cmdUpSeq As New MySqlCommand("UPDATE consumeraccounts SET sequence=" & adSeq & " WHERE acctID=" & arTeActID(x), con)
                        cmdUpSeq.ExecuteNonQuery()
                    Next
                    Dim cmdSet As New MySqlCommand("UPDATE consumeraccounts SET sequence=" & newSeq & " WHERE acctID=" & selSeqAcctID, con)
                    cmdSet.ExecuteNonQuery()
                    SeqList(arrSeqBrgyID(cboBarangay.SelectedIndex))
                End If
                txtNewSeqNum.Text = ""
                txtCurSeq.Text = ""
            ElseIf newSeq > curSeq Then
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET sequence=0 WHERE acctID=" & selSeqAcctID, con)
                cmd.ExecuteNonQuery()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT acctID, Sequence FROM consumeraccounts WHERE sequence BETWEEN " & curSeq + 1 & " AND " & newSeq & " AND brgyID=" & arrSeqBrgyID(cboBarangay.SelectedIndex), con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Dim arTeActID(dt.Rows.Count - 1) As Integer
                    Dim cSeq As Integer
                    Dim adSeq As Integer
                    For x As Integer = 0 To dt.Rows.Count - 1
                        arTeActID(x) = Val(dt.Rows(x).Item(0).ToString)
                        cSeq = Val(dt.Rows(x).Item(1).ToString)
                        adSeq = cSeq - 1
                        Dim cmdUpSeq As New MySqlCommand("UPDATE consumeraccounts SET sequence=" & adSeq & " WHERE acctID=" & arTeActID(x), con)
                        cmdUpSeq.ExecuteNonQuery()
                    Next
                    Dim cmdSet As New MySqlCommand("UPDATE consumeraccounts SET sequence=" & newSeq & " WHERE acctID=" & selSeqAcctID, con)
                    cmdSet.ExecuteNonQuery()
                    SeqList(arrSeqBrgyID(cboBarangay.SelectedIndex))
                End If
                txtNewSeqNum.Text = ""
                txtCurSeq.Text = ""
            ElseIf newSeq = curSeq Then
                MsgBox("New Sequence Number should not be equal to the Old Sequence Number", MsgBoxStyle.Information, "Same Sequence Number")
                Exit Sub
            Else
                MsgBox("The Data you enetered is Invalid", MsgBoxStyle.Exclamation, "Invalid Data")
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnAssignSeq_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Confirm Update", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            For x As Integer = 0 To lvwSeq.Items.Count - 1
                Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET sequence=" & x + 1 & " WHERE acctID=" & arrSeqAccID(x), con)
                cmd.ExecuteNonQuery()
            Next
            MessageBox.Show("Done Sequencing")
            SeqList(arrSeqBrgyID(cboBarangay.SelectedIndex))
        End If

    End Sub
End Class