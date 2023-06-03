Imports MySql.Data.MySqlClient
Module ConnectionModule
    Public loggedUserID As Integer
    Public con As New MySqlConnection("server=localhost;user id=root;password=root;database=poseidondb;sslmode=none;persistsecurityinfo=true; default command timeout=100000")

    Public Sub Cons()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
    End Sub

    Public Sub Conx()
        If Not con.State = ConnectionState.Closed Then
            con.Close()
        End If
    End Sub
End Module
