<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNonCGI
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
        Me.lblGrower = New System.Windows.Forms.Label()
        Me.lblGrowerName = New System.Windows.Forms.Label()
        Me.lblCommodityId = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblSoldTo = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cmbCommodity = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.txtSoldTo = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnOKAddNonCGI = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCancelNonCGI = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGrower
        '
        Me.lblGrower.AutoSize = True
        Me.lblGrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrower.Location = New System.Drawing.Point(35, 221)
        Me.lblGrower.Name = "lblGrower"
        Me.lblGrower.Size = New System.Drawing.Size(59, 16)
        Me.lblGrower.TabIndex = 0
        Me.lblGrower.Text = "Grower"
        '
        'lblGrowerName
        '
        Me.lblGrowerName.AutoSize = True
        Me.lblGrowerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrowerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrowerName.Location = New System.Drawing.Point(35, 256)
        Me.lblGrowerName.Name = "lblGrowerName"
        Me.lblGrowerName.Size = New System.Drawing.Size(93, 14)
        Me.lblGrowerName.TabIndex = 1
        Me.lblGrowerName.Text = "Grower Name"
        '
        'lblCommodityId
        '
        Me.lblCommodityId.AutoSize = True
        Me.lblCommodityId.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblCommodityId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCommodityId.Location = New System.Drawing.Point(208, 147)
        Me.lblCommodityId.Name = "lblCommodityId"
        Me.lblCommodityId.Size = New System.Drawing.Size(71, 15)
        Me.lblCommodityId.TabIndex = 6
        Me.lblCommodityId.Text = "Commodity"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblVolume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblVolume.Location = New System.Drawing.Point(208, 181)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(47, 15)
        Me.lblVolume.TabIndex = 7
        Me.lblVolume.Text = "Volume"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(208, 215)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 15)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'lblSoldTo
        '
        Me.lblSoldTo.AutoSize = True
        Me.lblSoldTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblSoldTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblSoldTo.Location = New System.Drawing.Point(208, 249)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(42, 15)
        Me.lblSoldTo.TabIndex = 9
        Me.lblSoldTo.Text = "SoldTo"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblLocation.Location = New System.Drawing.Point(208, 283)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(53, 15)
        Me.lblLocation.TabIndex = 10
        Me.lblLocation.Text = "Location"
        '
        'cmbCommodity
        '
        Me.cmbCommodity.FormattingEnabled = True
        Me.cmbCommodity.Location = New System.Drawing.Point(292, 143)
        Me.cmbCommodity.Name = "cmbCommodity"
        Me.cmbCommodity.Size = New System.Drawing.Size(196, 23)
        Me.cmbCommodity.TabIndex = 11
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(292, 213)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(71, 23)
        Me.cmbStatus.TabIndex = 12
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(292, 178)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(100, 23)
        Me.txtVolume.TabIndex = 13
        '
        'txtSoldTo
        '
        Me.txtSoldTo.Location = New System.Drawing.Point(292, 248)
        Me.txtSoldTo.Name = "txtSoldTo"
        Me.txtSoldTo.Size = New System.Drawing.Size(100, 23)
        Me.txtSoldTo.TabIndex = 14
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(292, 283)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(125, 82)
        Me.txtLocation.TabIndex = 15
        '
        'btnOKAddNonCGI
        '
        Me.btnOKAddNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnOKAddNonCGI.Location = New System.Drawing.Point(258, 397)
        Me.btnOKAddNonCGI.Name = "btnOKAddNonCGI"
        Me.btnOKAddNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnOKAddNonCGI.TabIndex = 16
        Me.btnOKAddNonCGI.Text = "&OK"
        Me.btnOKAddNonCGI.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(23, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 451)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(191, 67)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 366)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(191, 383)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(306, 50)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'btnCancelNonCGI
        '
        Me.btnCancelNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCancelNonCGI.Location = New System.Drawing.Point(363, 397)
        Me.btnCancelNonCGI.Name = "btnCancelNonCGI"
        Me.btnCancelNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelNonCGI.TabIndex = 20
        Me.btnCancelNonCGI.Text = "Cancel"
        Me.btnCancelNonCGI.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(136, 67)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(114, 38)
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(172, 34)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(43, 104)
        Me.PictureBox5.TabIndex = 57
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(150, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Add Non CGI"
        '
        'FormNonCGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnCancelNonCGI)
        Me.Controls.Add(Me.btnOKAddNonCGI)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblSoldTo)
        Me.Controls.Add(Me.txtSoldTo)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.cmbCommodity)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblCommodityId)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblGrower)
        Me.Controls.Add(Me.lblGrowerName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormNonCGI"
        Me.Text = "FormNonCGI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGrower As Label
    Friend WithEvents lblGrowerName As Label
    Friend WithEvents lblCommodityId As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblSoldTo As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents cmbCommodity As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents txtSoldTo As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents btnOKAddNonCGI As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCancelNonCGI As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
End Class
