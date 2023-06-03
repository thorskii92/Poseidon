Imports System.Management
Imports System.Threading
Imports System.IO.Ports.SerialPort
Module GSMModule
    Public rcvdata As String = ""
    Public ModemPortName As String = ""
    Dim startClock As Integer
    Public Sub smsProcedure()

    End Sub

    Public Sub loadSMSSettings()
        'frmSMSSettings.cboModem.Items.Clear()
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            'cboModem.Items.Add(ports(i))
            'frmSMSSettings.cboModem.Items.Add(ports(i))
        Next
        Try
            'frmSMSSettings.cboModem.SelectedIndex = 0
        Catch ex As Exception

        End Try

        Dim dt As New DataTable
        'Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM tblSerialPort WHERE sID=1", Connector)
        'da.Fill(dt)
        Try
            If dt.Rows.Count > 0 Then
                'If frmSMSSettings.cboModem.Items(0) = dt.Rows(0).Item(2).ToString Then
                '    frmSMSSettings.cboModem.SelectedIndex = 0
                'Else
                '    frmSMSSettings.cboModem.Items.Add(dt.Rows(0).Item(2).ToString)
                '    frmSMSSettings.cboModem.SelectedIndex = 1
                'End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Public Function ModemsConnected() As String
        Dim Modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                Dim checkObjPort As String
                checkObjPort = queryObj("Description") & "***"
                If checkObjPort.Contains("Bluetooth").ToString = False Then
                    If queryObj("Status") = "OK" Then
                        ModemPortName = queryObj("AttachedTo")
                        Modems = Modems & (ModemPortName & " - " & queryObj("Description") & "***")
                    End If
                End If

            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Return ""
        End Try
        Return Modems
    End Function

    Public Sub SendSMS()
        'lblSending.Text = "Sending."
        Try
            'tmrSending.Enabled = True
            'lblSending.Text = "Sending."
            'With serialPort
            'lblSending.Text = "Sending."
            '.Write("AT" & vbCrLf)
            'lblSending.Text = "Sending."
            Threading.Thread.Sleep(500)
            'pbr.Value = 30
            '.Write("AT+CMGF=1" & vbCrLf)
            'lblSending.Text = "Sending.."
            Threading.Thread.Sleep(500)
            'pbr.Value = 60
            '.Write("AT+CMGS=" & Chr(34) & txtNum.Text & Chr(34) & vbCrLf)
            'pbr.Value = 70
            '.Write(txtMes.Text & Chr(26))
            'lblSending.Text = "Sending..."
            Threading.Thread.Sleep(500)
            'pbr.Value = 90
            startClock = 0
            'MsgBox(rcvdata.ToString)
            'End With

            If rcvdata.ToString.Contains(">") Then
                'pbr.Value = 100
                'lblSending.Text = "Sent!"
                'tmrSending.Enabled = True
                'MsgBox("Messages Sent!")
                'pbr.Value = 0
            Else
                'lblSending.Text = "Sending failed!"
                'MsgBox("Messages not Sent!")
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub serialPort_datareceived(ByVal Sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived
    '    Dim datain As String = ""
    '    Dim numbytes As Integer = serialPort.BytesToRead

    '    For i As Integer = 1 To numbytes
    '        datain &= Chr(serialPort.ReadChar)
    '    Next
    '    test(datain)
    'End Sub

    Public Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub
End Module

