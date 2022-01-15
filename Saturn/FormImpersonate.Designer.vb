<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImpersonate
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbUsers = New System.Windows.Forms.ComboBox()
        Me.btnImpersonateOK = New System.Windows.Forms.Button()
        Me.btnImpersonateCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(24, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 187)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmbUsers
        '
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Location = New System.Drawing.Point(43, 72)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(214, 23)
        Me.cmbUsers.TabIndex = 1
        '
        'btnImpersonateOK
        '
        Me.btnImpersonateOK.Location = New System.Drawing.Point(43, 138)
        Me.btnImpersonateOK.Name = "btnImpersonateOK"
        Me.btnImpersonateOK.Size = New System.Drawing.Size(75, 23)
        Me.btnImpersonateOK.TabIndex = 2
        Me.btnImpersonateOK.Text = "OK"
        Me.btnImpersonateOK.UseVisualStyleBackColor = True
        '
        'btnImpersonateCancel
        '
        Me.btnImpersonateCancel.Location = New System.Drawing.Point(164, 138)
        Me.btnImpersonateCancel.Name = "btnImpersonateCancel"
        Me.btnImpersonateCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnImpersonateCancel.TabIndex = 3
        Me.btnImpersonateCancel.Text = "Cancel"
        Me.btnImpersonateCancel.UseVisualStyleBackColor = True
        '
        'FormImpersonate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 227)
        Me.Controls.Add(Me.btnImpersonateCancel)
        Me.Controls.Add(Me.btnImpersonateOK)
        Me.Controls.Add(Me.cmbUsers)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormImpersonate"
        Me.Text = "ImpersonateUsesr"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbUsers As ComboBox
    Friend WithEvents btnImpersonateOK As Button
    Friend WithEvents btnImpersonateCancel As Button
End Class
