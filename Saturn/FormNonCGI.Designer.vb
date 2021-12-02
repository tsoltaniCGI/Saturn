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
        Me.SuspendLayout()
        '
        'lblGrower
        '
        Me.lblGrower.AutoSize = True
        Me.lblGrower.Location = New System.Drawing.Point(40, 29)
        Me.lblGrower.Name = "lblGrower"
        Me.lblGrower.Size = New System.Drawing.Size(45, 15)
        Me.lblGrower.TabIndex = 0
        Me.lblGrower.Text = "Grower"
        '
        'lblGrowerName
        '
        Me.lblGrowerName.AutoSize = True
        Me.lblGrowerName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerName.Location = New System.Drawing.Point(126, 29)
        Me.lblGrowerName.Name = "lblGrowerName"
        Me.lblGrowerName.Size = New System.Drawing.Size(86, 15)
        Me.lblGrowerName.TabIndex = 1
        Me.lblGrowerName.Text = "Grower Name"
        '
        'lblCommodityId
        '
        Me.lblCommodityId.AutoSize = True
        Me.lblCommodityId.Location = New System.Drawing.Point(5, 56)
        Me.lblCommodityId.Name = "lblCommodityId"
        Me.lblCommodityId.Size = New System.Drawing.Size(71, 15)
        Me.lblCommodityId.TabIndex = 6
        Me.lblCommodityId.Text = "Commodity"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(226, 59)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(47, 15)
        Me.lblVolume.TabIndex = 7
        Me.lblVolume.Text = "Volume"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 96)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 15)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'lblSoldTo
        '
        Me.lblSoldTo.AutoSize = True
        Me.lblSoldTo.Location = New System.Drawing.Point(226, 96)
        Me.lblSoldTo.Name = "lblSoldTo"
        Me.lblSoldTo.Size = New System.Drawing.Size(42, 15)
        Me.lblSoldTo.TabIndex = 9
        Me.lblSoldTo.Text = "SoldTo"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(12, 144)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(53, 15)
        Me.lblLocation.TabIndex = 10
        Me.lblLocation.Text = "Location"
        '
        'cmbCommodity
        '
        Me.cmbCommodity.FormattingEnabled = True
        Me.cmbCommodity.Location = New System.Drawing.Point(76, 57)
        Me.cmbCommodity.Name = "cmbCommodity"
        Me.cmbCommodity.Size = New System.Drawing.Size(121, 23)
        Me.cmbCommodity.TabIndex = 11
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(76, 92)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 23)
        Me.cmbStatus.TabIndex = 12
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(274, 55)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(100, 23)
        Me.txtVolume.TabIndex = 13
        '
        'txtSoldTo
        '
        Me.txtSoldTo.Location = New System.Drawing.Point(274, 91)
        Me.txtSoldTo.Name = "txtSoldTo"
        Me.txtSoldTo.Size = New System.Drawing.Size(100, 23)
        Me.txtSoldTo.TabIndex = 14
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(76, 125)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(125, 82)
        Me.txtLocation.TabIndex = 15
        '
        'btnOKAddNonCGI
        '
        Me.btnOKAddNonCGI.Location = New System.Drawing.Point(299, 201)
        Me.btnOKAddNonCGI.Name = "btnOKAddNonCGI"
        Me.btnOKAddNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnOKAddNonCGI.TabIndex = 16
        Me.btnOKAddNonCGI.Text = "&OK"
        Me.btnOKAddNonCGI.UseVisualStyleBackColor = True
        '
        'FormNonCGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 343)
        Me.Controls.Add(Me.btnOKAddNonCGI)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtSoldTo)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbCommodity)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblSoldTo)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblCommodityId)
        Me.Controls.Add(Me.lblGrowerName)
        Me.Controls.Add(Me.lblGrower)
        Me.Name = "FormNonCGI"
        Me.Text = "FormNonCGI"
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
End Class
