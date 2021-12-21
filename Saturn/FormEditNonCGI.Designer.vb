<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditNonCGI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditNonCGI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelNonCGI = New System.Windows.Forms.Button()
        Me.btnOKAddNonCGI = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblSoldTo = New System.Windows.Forms.Label()
        Me.txtSoldTo = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.cmbCommodity = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCommodityId = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblGrower = New System.Windows.Forms.Label()
        Me.lblGrowerName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(99, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Edit Non CGI"
        '
        'btnCancelNonCGI
        '
        Me.btnCancelNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCancelNonCGI.Location = New System.Drawing.Point(376, 400)
        Me.btnCancelNonCGI.Name = "btnCancelNonCGI"
        Me.btnCancelNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelNonCGI.TabIndex = 75
        Me.btnCancelNonCGI.Text = "Cancel"
        Me.btnCancelNonCGI.UseVisualStyleBackColor = True
        '
        'btnOKAddNonCGI
        '
        Me.btnOKAddNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnOKAddNonCGI.Location = New System.Drawing.Point(259, 400)
        Me.btnOKAddNonCGI.Name = "btnOKAddNonCGI"
        Me.btnOKAddNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnOKAddNonCGI.TabIndex = 71
        Me.btnOKAddNonCGI.Text = "&OK"
        Me.btnOKAddNonCGI.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(196, 387)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(318, 50)
        Me.PictureBox3.TabIndex = 74
        Me.PictureBox3.TabStop = False
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblVolume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblVolume.Location = New System.Drawing.Point(213, 162)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(47, 15)
        Me.lblVolume.TabIndex = 62
        Me.lblVolume.Text = "Volume"
        '
        'lblSoldTo
        '
        Me.lblSoldTo.AutoSize = True
        Me.lblSoldTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblSoldTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblSoldTo.Location = New System.Drawing.Point(213, 236)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(42, 15)
        Me.lblSoldTo.TabIndex = 64
        Me.lblSoldTo.Text = "SoldTo"
        '
        'txtSoldTo
        '
        Me.txtSoldTo.Location = New System.Drawing.Point(297, 234)
        Me.txtSoldTo.Name = "txtSoldTo"
        Me.txtSoldTo.Size = New System.Drawing.Size(100, 23)
        Me.txtSoldTo.TabIndex = 69
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(297, 158)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(100, 23)
        Me.txtVolume.TabIndex = 68
        '
        'cmbCommodity
        '
        Me.cmbCommodity.FormattingEnabled = True
        Me.cmbCommodity.Location = New System.Drawing.Point(297, 121)
        Me.cmbCommodity.Name = "cmbCommodity"
        Me.cmbCommodity.Size = New System.Drawing.Size(196, 23)
        Me.cmbCommodity.TabIndex = 66
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(297, 197)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(71, 23)
        Me.cmbStatus.TabIndex = 67
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(297, 273)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(125, 82)
        Me.txtLocation.TabIndex = 70
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblLocation.Location = New System.Drawing.Point(213, 273)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(53, 15)
        Me.lblLocation.TabIndex = 65
        Me.lblLocation.Text = "Location"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(213, 199)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 15)
        Me.lblStatus.TabIndex = 63
        Me.lblStatus.Text = "Status"
        '
        'lblCommodityId
        '
        Me.lblCommodityId.AutoSize = True
        Me.lblCommodityId.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblCommodityId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCommodityId.Location = New System.Drawing.Point(213, 125)
        Me.lblCommodityId.Name = "lblCommodityId"
        Me.lblCommodityId.Size = New System.Drawing.Size(71, 15)
        Me.lblCommodityId.TabIndex = 61
        Me.lblCommodityId.Text = "Commodity"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(196, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(318, 396)
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'lblGrower
        '
        Me.lblGrower.AutoSize = True
        Me.lblGrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrower.Location = New System.Drawing.Point(40, 199)
        Me.lblGrower.Name = "lblGrower"
        Me.lblGrower.Size = New System.Drawing.Size(59, 16)
        Me.lblGrower.TabIndex = 59
        Me.lblGrower.Text = "Grower"
        '
        'lblGrowerName
        '
        Me.lblGrowerName.AutoSize = True
        Me.lblGrowerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrowerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrowerName.Location = New System.Drawing.Point(40, 234)
        Me.lblGrowerName.Name = "lblGrowerName"
        Me.lblGrowerName.Size = New System.Drawing.Size(93, 14)
        Me.lblGrowerName.TabIndex = 60
        Me.lblGrowerName.Text = "Grower Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(16, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 439)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(93, 14)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(114, 130)
        Me.PictureBox6.TabIndex = 79
        Me.PictureBox6.TabStop = False
        '
        'FormEditNonCGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
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
        Me.Name = "FormEditNonCGI"
        Me.Text = "Form2"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelNonCGI As Button
    Friend WithEvents btnOKAddNonCGI As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblVolume As Label
    Friend WithEvents lblSoldTo As Label
    Friend WithEvents txtSoldTo As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents cmbCommodity As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCommodityId As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblGrower As Label
    Friend WithEvents lblGrowerName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
