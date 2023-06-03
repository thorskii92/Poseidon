Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Math
Public Class frmORGroup
    Dim gID() As Integer
    Dim selgID As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim firstNum As Integer = Val(txtORNumber.Text)
        Dim down As Integer = Floor(firstNum / 50) * 50 + 1
        Dim lastNum As Integer = Val(Val(txtORNumber.Text))
        Dim upper As Integer = Ceiling(lastNum / 50) * 50
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblORGroup WHERE Initial=" & down & " and Final=" & upper, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("A group for that receipt has already been created", "Group Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("Confirm creation of new OR Group?", "New Group", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim cmd As New MySqlCommand("INSERT INTO tblORGroup(GroupName, Initial, Final) VALUES(@gName, @init, @fina)", con)
                cmd.Parameters.AddWithValue("@gName", Format(down, "000000#") & " to " & Format(upper, "000000#"))
                cmd.Parameters.AddWithValue("@init", down)
                cmd.Parameters.AddWithValue("@fina", upper)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Group has been created", "Group creation successful.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGroup()
                LoadORGroup()
                txtORNumber.Text = ""
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lvwORGroup.SelectedItems.Count > 0 Then
            selgID = gID(lvwORGroup.FocusedItem.Index)
            If MessageBox.Show("Do you want to delete the selected group?", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cons()
                Dim cmd As New MySqlCommand("DELETE FROM tblORGroup where ogID=" & selgID, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Group has been deleted", "Group deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGroup()
                LoadORGroup()
            End If
        End If
    End Sub

    Private Sub LoadGroup()
        Cons()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM tblorgroup ORDER BY Initial ASC", con)
        da.Fill(dt)
        lvwORGroup.Items.Clear()
        If dt.Rows.Count > 0 Then
            ReDim gID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                Dim lst As New ListViewItem
                gID(x) = Val(dt.Rows(x).Item(0))
                lst.Text = dt.Rows(x).Item(1).ToString
                lst.SubItems.Add(dt.Rows(x).Item(2).ToString)
                lst.SubItems.Add(dt.Rows(x).Item(3).ToString)
                lvwORGroup.Items.Add(lst)
            Next
        End If
    End Sub

    Private Sub frmORGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGroup()
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If MessageBox.Show("Confirm Auto generation of OR Groups?", "Auto Generate OR Groups", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Cons()
            Dim ORSer() As Integer
            Dim ORStr() As String
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT ORNum FROM tblOR", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ReDim ORSer(dt.Rows.Count - 1)
                ReDim ORStr(dt.Rows.Count - 1)
                For x As Integer = 0 To dt.Rows.Count - 1
                    ORSer(x) = Val(dt.Rows(x).Item(0))
                    'ORStr(x) = dt.Rows(x).Item(0).ToString

                    Dim firstNum As Integer = Val(ORSer(x))
                    Dim modNum As Integer = firstNum Mod 50
                    Dim newNum As Integer = firstNum
                    If modNum = 0 Then
                        newNum = newNum - 1
                    End If
                    Dim down As Integer = Floor(newNum / 50) * 50 + 1
                    'Dim lastNum As Integer = Val(ORSer(x))
                    Dim upper As Integer = Ceiling(newNum / 50) * 50
                    'MessageBox.Show("First: " & firstNum & "Down: " & down & " Upper: " & upper)
                    Dim dtG As New DataTable
                    Dim daG As New MySqlDataAdapter("SELECT * FROM tblORGroup WHERE Initial=" & down & " and Final=" & upper, con)
                    daG.Fill(dtG)
                    If dtG.Rows.Count = 0 Then
                        Dim cmd As New MySqlCommand("INSERT INTO tblORGroup(GroupName, Initial, Final) VALUES(@gName, @init, @fina)", con)
                        cmd.Parameters.AddWithValue("@gName", Format(down, "000000#") & " to " & Format(upper, "000000#"))
                        cmd.Parameters.AddWithValue("@init", down)
                        cmd.Parameters.AddWithValue("@fina", upper)
                        cmd.ExecuteNonQuery()
                    End If

                    Dim dtU As New DataTable
                    Dim daU As New MySqlDataAdapter("SELECT * FROM tblORGroup WHERE Initial=" & down & " and Final=" & upper, con)
                    daU.Fill(dtU)
                    Dim getogID As Integer = dtU.Rows(0).Item(0)
                    Dim dtorog As New DataTable
                    Dim daorog As New MySqlDataAdapter("SELECT ifnull(ogID,0) from tblOR where ORNum='" & Val(dt.Rows(x).Item(0)) & "'", con)
                    daorog.Fill(dtorog)
                    Dim getorogID As Integer = 0
                    If dtorog.Rows.Count > 0 Then
                        getorogID = Val(dtorog.Rows(0).Item(0))
                    End If


                    If getorogID = getogID Or getorogID = 0 Then
                        Dim cmd As New MySqlCommand("UPDATE tblor SET ogID=" & getogID & " WHERE ORNum='" & Val(dt.Rows(x).Item(0)) & "'", con)
                        cmd.ExecuteNonQuery()
                    End If
                Next
                LoadGroup()
                LoadORGroup()
                MessageBox.Show("OR Groups has been generated", "OR Group Generation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class