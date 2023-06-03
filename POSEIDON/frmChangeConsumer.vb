Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmChangeConsumer
    Dim arrConsumerIDList() As Integer
    Dim selConsumerIDList As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmChangeConsumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConsumers()
    End Sub

    Public Sub LoadConsumers()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM consumerlist", con)
        da.Fill(dt)
        Me.cboNewConsumer.Items.Clear()
        Me.cboNewConsumer.AutoCompleteCustomSource.Clear()
        If dt.Rows.Count > 0 Then
            ReDim arrConsumerIDList(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrConsumerIDList(x) = Val(dt.Rows(x).Item(0))
                Me.cboNewConsumer.Items.Add(dt.Rows(x).Item(1).ToString)
                Me.cboNewConsumer.AutoCompleteCustomSource.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If

    End Sub

    Private Sub cboNewConsumer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewConsumer.SelectedIndexChanged
        selConsumerIDList = arrConsumerIDList(cboNewConsumer.SelectedIndex)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Confirm Change of Consumer?", "Change Consumer Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim cmd As New MySqlCommand("UPDATE consumeraccounts SET consID=" & arrConsumerIDList(cboNewConsumer.SelectedIndex) & " WHERE acctID=" & selectedAcctIChangeConsumer, con)
            cmd.ExecuteNonQuery()
            cboNewConsumer.Items.Clear()
            Me.lblAccount.Text = ""
            Me.lblOriginal.Text = ""
            ViewLedger(selectedAcctIChangeConsumer)
            Me.Close()
        End If

    End Sub
End Class