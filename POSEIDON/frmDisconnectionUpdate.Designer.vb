<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisconnectionUpdate
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
        Me.btnConfirmDisconnection = New System.Windows.Forms.Button()
        Me.btnCancelDisconnection = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConfirmDisconnection
        '
        Me.btnConfirmDisconnection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmDisconnection.Location = New System.Drawing.Point(31, 12)
        Me.btnConfirmDisconnection.Name = "btnConfirmDisconnection"
        Me.btnConfirmDisconnection.Size = New System.Drawing.Size(453, 46)
        Me.btnConfirmDisconnection.TabIndex = 0
        Me.btnConfirmDisconnection.Text = "Confirm Disconnection"
        Me.btnConfirmDisconnection.UseVisualStyleBackColor = True
        '
        'btnCancelDisconnection
        '
        Me.btnCancelDisconnection.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDisconnection.Location = New System.Drawing.Point(31, 64)
        Me.btnCancelDisconnection.Name = "btnCancelDisconnection"
        Me.btnCancelDisconnection.Size = New System.Drawing.Size(453, 46)
        Me.btnCancelDisconnection.TabIndex = 1
        Me.btnCancelDisconnection.Text = "Cancel Disconnection"
        Me.btnCancelDisconnection.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(211, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmDisconnectionUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 191)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCancelDisconnection)
        Me.Controls.Add(Me.btnConfirmDisconnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDisconnectionUpdate"
        Me.Text = "Update Disconnection Selection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConfirmDisconnection As Button
    Friend WithEvents btnCancelDisconnection As Button
    Friend WithEvents btnCancel As Button
End Class
