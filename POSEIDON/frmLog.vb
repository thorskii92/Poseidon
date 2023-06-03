Imports MySql.Data.MySqlClient
Public Class frmLog

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadTypes()
        GetDateTime()
        setDefaults()
    End Sub
    Private Sub LoadTypes()
        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT * FROM usertypes", con)
        'da.Fill(dt)
        'Me.cboType.Items.Clear()
        'If dt.Rows.Count > 0 Then
        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        cboType.Items.Add(dt.Rows(x).Item(1).ToString)
        '    Next
        'End If
    End Sub

    Private Sub GetDateTime()
        'Cons()
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter("SELECT now()", con)
        'da.Fill(dt)
        'Dim tim As DateTime = Format(dt.Rows(0).Item(0), "HH:mm:ss")
        'Dim tDate As Date = DateValue(dt.Rows(0).Item(0))
        'Try
        '    Microsoft.VisualBasic.TimeOfDay = tim
        '    Microsoft.VisualBasic.DateString = New Date(tDate.Year, tDate.Month, tDate.Day)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'MsgBox(tim & " " & tDate)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Invalid Access! Please Try again!", MsgBoxStyle.Exclamation, "Invalid Access")
            Exit Sub
        Else
            If txtUser.ForeColor = Color.Black And txtPass.ForeColor = Color.Black Then
                Cons()
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter("SELECT * FROM userlist AS L LEFT JOIN usertypes AS T ON L.utypeID=T.utypeID WHERE uname=@loguser and upass=@logpass", con)
                da.SelectCommand.Parameters.AddWithValue("@loguser", txtUser.Text)
                da.SelectCommand.Parameters.AddWithValue("@logpass", txtPass.Text)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    loggedID = Val(dt.Rows(0).Item(0))
                    loggedUserID = Val(dt.Rows(0).Item(0))
                    UserLogData(Val(dt.Rows(0).Item(0).ToString), "Login")
                    closingSelect = 1
                    frmAdminPanel.statlblUser.Text = "User: " & dt.Rows(0).Item(3).ToString & " | "
                    AccessEnabler(Val(dt.Rows(0).Item(4).ToString))
                    InsertLog(loggedUserID, "Log", "Main System Access", "Login Only")
                    Dim strType As String = dt.Rows(0).Item(9).ToString
                    frmAdminPanel.Text = strType & " Panel"
                    frmAdminPanel.Show()
                    Me.Close()
                Else
                    MsgBox("User or Password is Invalid, Please try again", MsgBoxStyle.Exclamation, "Invalid Access")
                    txtPass.Text = ""
                    txtPass.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("User or Password is Invalid, Please try again", MsgBoxStyle.Exclamation, "Invalid Access")
                Exit Sub
            End If



        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub setDefaults()
        txtUser.Text = "Username"
        txtPass.Text = "Password"
        txtPass.PasswordChar = ""
        txtUser.ForeColor = Color.Gray
        txtPass.ForeColor = Color.Gray
    End Sub

    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        If txtUser.Text = "Username" And txtUser.ForeColor = Color.Gray Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        If txtUser.Text = "" Then
            txtUser.Text = "Username"
            txtUser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        If txtPass.Text = "Password" And txtPass.ForeColor = Color.Gray Then
            txtPass.Text = ""
            txtPass.PasswordChar = "*"
            txtPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus
        If txtPass.Text = "" Then
            txtPass.Text = "Password"
            txtPass.PasswordChar = ""
            txtPass.ForeColor = Color.Gray
        End If
    End Sub
End Class