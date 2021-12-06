<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNote
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
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGrowerState = New System.Windows.Forms.Label()
        Me.lblGrowerPhone1 = New System.Windows.Forms.Label()
        Me.lblGrowerCountry = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGrowerCity = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMethod
        '
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Location = New System.Drawing.Point(370, 176)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(121, 23)
        Me.cmbMethod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(298, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Method"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(237, 213)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(264, 157)
        Me.txtNote.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnOK.Location = New System.Drawing.Point(272, 410)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(406, 411)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(298, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Subject:"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(370, 136)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(121, 23)
        Me.txtSubject.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(32, 257)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 14)
        Me.lblName.TabIndex = 49
        Me.lblName.Text = "GrowerName"
        '
        'lblGrowerState
        '
        Me.lblGrowerState.AutoSize = True
        Me.lblGrowerState.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrowerState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrowerState.Location = New System.Drawing.Point(110, 315)
        Me.lblGrowerState.Name = "lblGrowerState"
        Me.lblGrowerState.Size = New System.Drawing.Size(87, 14)
        Me.lblGrowerState.TabIndex = 47
        Me.lblGrowerState.Text = "GrowerState"
        '
        'lblGrowerPhone1
        '
        Me.lblGrowerPhone1.AutoSize = True
        Me.lblGrowerPhone1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrowerPhone1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerPhone1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrowerPhone1.Location = New System.Drawing.Point(32, 367)
        Me.lblGrowerPhone1.Name = "lblGrowerPhone1"
        Me.lblGrowerPhone1.Size = New System.Drawing.Size(101, 14)
        Me.lblGrowerPhone1.TabIndex = 46
        Me.lblGrowerPhone1.Text = "GrowerPhone1"
        '
        'lblGrowerCountry
        '
        Me.lblGrowerCountry.AutoSize = True
        Me.lblGrowerCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrowerCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrowerCountry.Location = New System.Drawing.Point(32, 342)
        Me.lblGrowerCountry.Name = "lblGrowerCountry"
        Me.lblGrowerCountry.Size = New System.Drawing.Size(103, 14)
        Me.lblGrowerCountry.TabIndex = 45
        Me.lblGrowerCountry.Text = "GrowerCountry"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(31, 288)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(104, 14)
        Me.lblAddress.TabIndex = 44
        Me.lblAddress.Text = "GrowerAddress"
        '
        'lblGrowerCity
        '
        Me.lblGrowerCity.AutoSize = True
        Me.lblGrowerCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblGrowerCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrowerCity.Location = New System.Drawing.Point(32, 315)
        Me.lblGrowerCity.Name = "lblGrowerCity"
        Me.lblGrowerCity.Size = New System.Drawing.Size(77, 14)
        Me.lblGrowerCity.TabIndex = 50
        Me.lblGrowerCity.Text = "GrowerCity"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(24, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 451)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(218, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 366)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(218, 398)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(306, 50)
        Me.PictureBox3.TabIndex = 53
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(162, 79)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(114, 38)
        Me.PictureBox4.TabIndex = 54
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(198, 46)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(43, 104)
        Me.PictureBox5.TabIndex = 55
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(183, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Add Note"
        '
        'FormNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 502)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMethod)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblGrowerCity)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGrowerState)
        Me.Controls.Add(Me.lblGrowerPhone1)
        Me.Controls.Add(Me.lblGrowerCountry)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormNote"
        Me.Text = "Note"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMethod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblGrowerState As Label
    Friend WithEvents lblGrowerPhone1 As Label
    Friend WithEvents lblGrowerCountry As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGrowerCity As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
End Class
