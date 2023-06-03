Imports MySql.Data.MySqlClient
Public Class frmRateValues
    Dim tempArrRate() As Double
    Dim tempArrMin() As Integer
    Dim tempArrCub() As Integer
    Dim totCount As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lvwCubits.Items.Count > 0 Then
            If lvwCubits.Items.Count = 1 Then
                frmRateAdder.txtCub.Text = lastCub + 1
                frmRateAdder.txtCub.ReadOnly = True
            Else
                frmRateAdder.txtCub.Text = ""
                frmRateAdder.txtCub.ReadOnly = False
            End If
            frmRateAdder.txtRate.Text = ""
            frmRateAdder.Text = "Rate"
            frmRateAdder.lblCubit.Text = "Cubic Min"
            frmRateAdder.StartPosition = FormStartPosition.CenterScreen
            frmRateAdder.ShowDialog()
        Else
            frmRateAdder.txtCub.ReadOnly = False
            frmRateAdder.txtCub.Text = ""
            frmRateAdder.txtRate.Text = ""
            frmRateAdder.Text = "Minimum Rate"
            frmRateAdder.lblCubit.Text = "Cubic Max"
            frmRateAdder.StartPosition = FormStartPosition.CenterScreen
            frmRateAdder.ShowDialog()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRateValues_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Cons()
        Dim cmd As New MySqlCommand("DELETE FROM tempclassrate", con)
        cmd.ExecuteNonQuery()
    End Sub

   

    Private Sub frmRateValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvwCubits.SelectedItems.Count > 0 Then
            If MsgBox("Delete Selected?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                Dim cmd As New MySqlCommand("DELETE FROM tempclassrate WHERE trateid=" & tempArrRateID(lvwCubits.FocusedItem.Index), con)
                cmd.ExecuteNonQuery()
                tempClassRate()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Confirm by Clicking 'Yes'", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
            Dim dtCheckCode As New DataTable
            Dim daCheckCode As New MySqlDataAdapter("SELECT * FROM classifications WHERE (classcode='" & txtClassCode.Text.Replace("'", "`") & "' or classification='" & txtClassName.Text.Replace("'", "`") & "') and ClassID <> " & getClassID, con)
            daCheckCode.Fill(dtCheckCode)
            If dtCheckCode.Rows.Count > 0 Then
                MsgBox("Classification Code already Existing, Please try another", MsgBoxStyle.Exclamation, "Classification Code Existing")
                Exit Sub
            Else
                Dim bulkBoolean As Integer
                If chkBulk.Checked = True Then
                    bulkBoolean = 1
                Else
                    bulkBoolean = 0
                End If
                If getClassID = 0 Then
                    Dim cmdAddClass As New MySqlCommand("INSERT INTO classifications(classification, classcode, isbulk) VALUES('" & txtClassName.Text.Replace("'", "`") & "','" & txtClassCode.Text.Replace("'", "`") & "'," & bulkBoolean & ")", con)
                    cmdAddClass.ExecuteNonQuery()
                Else
                    Dim cmdAddClass As New MySqlCommand("UPDATE classifications SET classification='" & txtClassName.Text.Replace("'", "`") & "', classcode='" & txtClassCode.Text.Replace("'", "`") & "',isbulk=" & bulkBoolean & " WHERE classID=" & getClassID, con)
                    cmdAddClass.ExecuteNonQuery()
                End If

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM tempclassrate", con)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    ReDim tempArrRate(dt.Rows.Count - 1)
                    ReDim tempArrMin(dt.Rows.Count - 1)
                    ReDim tempArrCub(dt.Rows.Count - 1)
                    totCount = dt.Rows.Count - 1
                    For x As Integer = 0 To dt.Rows.Count - 1
                        tempArrRate(x) = Val(dt.Rows(x).Item(1).ToString)
                        tempArrMin(x) = Val(dt.Rows(x).Item(2).ToString)
                        tempArrCub(x) = Val(dt.Rows(x).Item(3).ToString)
                    Next
                End If
                Dim dtGet As New DataTable
                Dim daGet As New MySqlDataAdapter("SELECT classid FROM classifications WHERE classcode = '" & txtClassCode.Text.Replace("'", "`") & "'", con)
                daGet.Fill(dtGet)
                Dim getCID As Integer = Val(dtGet.Rows(0).Item(0).ToString)
                Dim cmdDelRates As New MySqlCommand("DELETE FROM tblClassrates WHERE classID=" & getCID, con)
                cmdDelRates.ExecuteNonQuery()
                If dt.Rows.Count > 0 Then
                    For y As Integer = 0 To totCount
                        'ERROR
                        Dim cmdAddClassRates As New MySqlCommand("INSERT INTO tblClassrates(classID,Rate,ismin,cubits) VALUES(" & getCID & "," & tempArrRate(y) & "," & tempArrMin(y) & "," & tempArrCub(y) & ")", con)
                        cmdAddClassRates.ExecuteNonQuery()
                    Next
                End If
                

                Dim cmdClearTemp As New MySqlCommand("DELETE FROM tempclassrate", con)
                cmdClearTemp.ExecuteNonQuery()
                classificationList()
                Me.Close()
            End If
           
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)

    End Sub
End Class