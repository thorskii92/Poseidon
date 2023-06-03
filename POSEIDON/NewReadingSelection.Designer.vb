<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewReadingSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewReadingSelection))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpReadDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.cboPeriodMonth = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.cboMunicipality = New System.Windows.Forms.ComboBox()
        Me.cboZone = New System.Windows.Forms.ComboBox()
        Me.cboBarangay = New System.Windows.Forms.ComboBox()
        Me.cboCluster = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reading Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Due Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Zone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(317, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Barangay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Province"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Municipality"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cluster"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Period Covered"
        '
        'dtpReadDate
        '
        Me.dtpReadDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReadDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReadDate.Location = New System.Drawing.Point(12, 30)
        Me.dtpReadDate.Name = "dtpReadDate"
        Me.dtpReadDate.Size = New System.Drawing.Size(253, 26)
        Me.dtpReadDate.TabIndex = 8
        '
        'dtpDue
        '
        Me.dtpDue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(12, 85)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(253, 26)
        Me.dtpDue.TabIndex = 9
        '
        'cboPeriodMonth
        '
        Me.cboPeriodMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodMonth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodMonth.FormattingEnabled = True
        Me.cboPeriodMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboPeriodMonth.Location = New System.Drawing.Point(12, 135)
        Me.cboPeriodMonth.Name = "cboPeriodMonth"
        Me.cboPeriodMonth.Size = New System.Drawing.Size(137, 26)
        Me.cboPeriodMonth.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(137, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "To"
        Me.Label9.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(165, 223)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(103, 26)
        Me.lblMonth.TabIndex = 13
        Me.lblMonth.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(159, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Year"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(155, 135)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(110, 26)
        Me.cboYear.TabIndex = 15
        '
        'cboProvince
        '
        Me.cboProvince.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(387, 12)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(215, 26)
        Me.cboProvince.TabIndex = 16
        '
        'cboMunicipality
        '
        Me.cboMunicipality.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMunicipality.FormattingEnabled = True
        Me.cboMunicipality.Location = New System.Drawing.Point(387, 44)
        Me.cboMunicipality.Name = "cboMunicipality"
        Me.cboMunicipality.Size = New System.Drawing.Size(215, 26)
        Me.cboMunicipality.TabIndex = 17
        '
        'cboZone
        '
        Me.cboZone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(387, 76)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(215, 26)
        Me.cboZone.TabIndex = 18
        '
        'cboBarangay
        '
        Me.cboBarangay.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarangay.FormattingEnabled = True
        Me.cboBarangay.Location = New System.Drawing.Point(387, 108)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(215, 26)
        Me.cboBarangay.TabIndex = 19
        '
        'cboCluster
        '
        Me.cboCluster.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCluster.FormattingEnabled = True
        Me.cboCluster.Location = New System.Drawing.Point(387, 140)
        Me.cboCluster.Name = "cboCluster"
        Me.cboCluster.Size = New System.Drawing.Size(215, 26)
        Me.cboCluster.TabIndex = 20
        Me.cboCluster.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.SteelBlue
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(413, 219)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(92, 39)
        Me.btnOk.TabIndex = 21
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(511, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 39)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(15, 194)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(104, 26)
        Me.dtpFrom.TabIndex = 23
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(164, 194)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(104, 26)
        Me.dtpTo.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(130, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Month"
        '
        'NewReadingSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 265)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cboCluster)
        Me.Controls.Add(Me.cboBarangay)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.cboMunicipality)
        Me.Controls.Add(Me.cboProvince)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboPeriodMonth)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.dtpReadDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewReadingSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Reading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpReadDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriodMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cboMunicipality As System.Windows.Forms.ComboBox
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboBarangay As System.Windows.Forms.ComboBox
    Friend WithEvents cboCluster As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As Label
End Class
