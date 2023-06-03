Imports MySql.Data.MySqlClient
Public Class frmNewConsumer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If TypeNewCons = 1 Then
            If Me.Text = "New Consumer" Then
                Cons()
                Dim cmd As New MySqlCommand("INSERT INTO consumerlist(consumername, caddress, contactnum, isSC, seniorID, agency, gender, jobtitle, Company) values(@cName,@cAdd,@cont,'" & If(CheckBox1.Checked = True, "YES", "NO") & "','" & txtSenID.Text & "','" & txtAgency.Text & "','" & cboGender.Text & "',@jTitle,@comp)", con)
                cmd.Parameters.AddWithValue("@cName", txtName.Text)
                cmd.Parameters.AddWithValue("@cAdd", txtAddress.Text)
                cmd.Parameters.AddWithValue("@cont", txtContact.Text)
                cmd.Parameters.AddWithValue("@jTitle", txtJobTitle.Text)
                cmd.Parameters.AddWithValue("@comp", txtCompany.Text)
                cmd.ExecuteNonQuery()

                Me.txtAddress.Text = ""
                Me.txtContact.Text = ""
                Me.txtName.Text = ""
                Me.txtAgency.Text = ""
                Me.txtSenID.Text = ""
                Try
                    ViewConsumerList(frmConsumerList.txtSearchConsumer.Text.Replace("'", "`"))

                    WaterBillConsumerList()
                Catch ex As Exception

                End Try
                Me.Close()
            Else
                Cons()
                Dim cmd As New MySqlCommand("UPDATE consumerlist SET consumername='" & (txtName.Text.Replace("'", "''")) & "', caddress='" & txtAddress.Text.Replace("'", "''") & "', contactnum='" & txtContact.Text.Replace("'", "''") & "', isSC='" & If(CheckBox1.Checked = True, "YES", "NO") & "', seniorID='" & txtSenID.Text & "', agency='" & txtAgency.Text & "', gender='" & cboGender.Text & "', jobtitle='" & txtJobTitle.Text & "', Company='" & txtCompany.Text & "' WHERE consID=" & selConsUpID, con)
                cmd.ExecuteNonQuery()
                Dim cmdUpdateAccountSen As New MySqlCommand("UPDATE consumeraccounts SET isSenior='" & If(CheckBox1.Checked = True, "YES", "NO") & "', seniorID='" & txtSenID.Text & "' WHERE consID=" & selConsUpID, con)
                cmdUpdateAccountSen.ExecuteNonQuery()
                Me.txtAddress.Text = ""
                Me.txtContact.Text = ""
                Me.txtName.Text = ""
                Me.txtAgency.Text = ""
                Me.txtSenID.Text = ""
                Try
                    ViewConsumerList(frmConsumerList.txtSearchConsumer.Text.Replace("'", "`"))
                WaterBillConsumerList()
                Catch ex As Exception

                End Try
                Me.Close()
            End If
        ElseIf TypeNewCons = 2 Then
            If Me.Text = "New Consumer" Then
                Cons()
                Dim cmd As New MySqlCommand("INSERT INTO consumerlist(consumername, caddress, contactnum, isSC, seniorID, agency, gender) values('" & (txtName.Text.Replace("'", "`")) & "','" & txtAddress.Text.Replace("'", "`") & "','" & txtContact.Text.Replace("'", "`") & "','" & If(CheckBox1.Checked = True, "YES", "NO") & "','" & txtSenID.Text & "','" & txtAgency.Text & "','" & cboGender.Text & "',@jTitle,@comp)", con)
                cmd.Parameters.AddWithValue("@jTitle", txtJobTitle.Text)
                cmd.Parameters.AddWithValue("@comp", txtCompany.Text)
                cmd.ExecuteNonQuery()
                LoadConsListTransferOwner()
                frmTransferOwner.cboNewOwner.Text = Me.txtName.Text
                Me.txtAddress.Text = ""
                Me.txtContact.Text = ""
                Me.txtName.Text = ""
                Me.txtAgency.Text = ""
                Me.txtSenID.Text = ""
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmNewConsumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cboGender.SelectedIndex = 0
    End Sub
End Class
