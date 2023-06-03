Imports MySql.Data.MySqlClient
Module NewAccountComboBoxList
    Public arrComboProvsID() As Integer
    Public arrComboMunsID() As Integer
    Public arrComboZonesID() As Integer
    Public arrComboBrgyID() As Integer
    Public arrCombiClassID() As Integer
    Public arrComboClustID() As Integer

    Public selComPID As Integer
    Public selComMID As Integer
    Public selComZID As Integer
    Public selComBID As Integer
    Public selComCID As Integer
    Public selClusID As Integer

    Public Sub nComboProvList()
        Cons()
        frmNewAccount.cboProv.Items.Clear()
        frmNewAccount.cboMun.Items.Clear()
        frmNewAccount.cboBrgy.Items.Clear()
        frmNewAccount.cboCluster.Items.Clear()

        frmNewAccount.cboProv.Text = ""
        frmNewAccount.cboMun.Text = ""
        frmNewAccount.cboBrgy.Text = ""
        frmNewAccount.cboCluster.Text = ""

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM provlist", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrComboProvsID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(2).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrComboProvsID(x) = Val(dt.Rows(x).Item(0).ToString)
                frmNewAccount.cboProv.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
            frmNewAccount.cboProv.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub nComboMunList(index As Integer)
        Cons()
        frmNewAccount.cboMun.Items.Clear()
        frmNewAccount.cboBrgy.Items.Clear()
        frmNewAccount.cboCluster.Items.Clear()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM munlist WHERE addprovid=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim getDefault As Integer
            Dim indexOfDefault As Integer
            ReDim arrComboMunsID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                getDefault = Val(dt.Rows(x).Item(3).ToString)
                If getDefault = 1 Then
                    indexOfDefault = x
                End If
                arrComboMunsID(x) = dt.Rows(x).Item(0).ToString
                frmNewAccount.cboMun.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
            frmNewAccount.cboMun.SelectedIndex = indexOfDefault
        End If
    End Sub

    Public Sub nComboBrgyList(index As Integer)
        Cons()
        frmNewAccount.cboBrgy.Items.Clear()
        frmNewAccount.cboCluster.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM brgylist AS B LEFT JOIN zones AS Z ON B.ZoneID=Z.ZoneID LEFT JOIN munlist AS M ON Z.addmunid=M.addmunID WHERE M.addmunID=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrComboBrgyID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrComboBrgyID(x) = dt.Rows(x).Item(0)
                frmNewAccount.cboBrgy.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub nComboClusterList(index As Integer)
        Cons()
        frmNewAccount.cboCluster.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM clusterlist WHERE brgyID=" & index, con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            ReDim arrComboClustID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrComboClustID(x) = dt.Rows(x).Item(0)
                frmNewAccount.cboCluster.Items.Add(dt.Rows(x).Item(2).ToString)
            Next
        End If
    End Sub

    Public Sub nComboClassification()
        Cons()
        frmNewAccount.cboClass.Items.Clear()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM classifications", con)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            ReDim arrCombiClassID(dt.Rows.Count - 1)
            For x As Integer = 0 To dt.Rows.Count - 1
                arrCombiClassID(x) = dt.Rows(x).Item(0).ToString
                frmNewAccount.cboClass.Items.Add(dt.Rows(x).Item(1).ToString)
            Next
        End If
    End Sub
End Module
