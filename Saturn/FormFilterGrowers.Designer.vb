<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilterGrowers
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
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblCommodity = New System.Windows.Forms.Label()
        Me.cmbCommodity = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkProspect = New System.Windows.Forms.CheckBox()
        Me.chkHasNotes = New System.Windows.Forms.CheckBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(17, 92)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(95, 25)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(17, 32)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(97, 25)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(126, 25)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(141, 31)
        Me.txtFirstName.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(124, 85)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(141, 31)
        Me.txtLastName.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(121, 148)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(141, 31)
        Me.txtCity.TabIndex = 8
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(14, 155)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(42, 25)
        Me.lblCity.TabIndex = 7
        Me.lblCity.Text = "City"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(120, 212)
        Me.txtCounty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(141, 31)
        Me.txtCounty.TabIndex = 10
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(17, 218)
        Me.lblCounty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(69, 25)
        Me.lblCounty.TabIndex = 9
        Me.lblCounty.Text = "County"
        '
        'lblCommodity
        '
        Me.lblCommodity.AutoSize = True
        Me.lblCommodity.Location = New System.Drawing.Point(11, 290)
        Me.lblCommodity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCommodity.Name = "lblCommodity"
        Me.lblCommodity.Size = New System.Drawing.Size(107, 25)
        Me.lblCommodity.TabIndex = 11
        Me.lblCommodity.Text = "Commodity"
        '
        'cmbCommodity
        '
        Me.cmbCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCommodity.FormattingEnabled = True
        Me.cmbCommodity.Location = New System.Drawing.Point(119, 282)
        Me.cmbCommodity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCommodity.Name = "cmbCommodity"
        Me.cmbCommodity.Size = New System.Drawing.Size(215, 33)
        Me.cmbCommodity.TabIndex = 12
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(16, 605)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(107, 38)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(157, 603)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 38)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(80, 546)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 38)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "C&lear Filters"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkProspect
        '
        Me.chkProspect.AutoSize = True
        Me.chkProspect.Location = New System.Drawing.Point(120, 350)
        Me.chkProspect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkProspect.Name = "chkProspect"
        Me.chkProspect.Size = New System.Drawing.Size(107, 29)
        Me.chkProspect.TabIndex = 16
        Me.chkProspect.Text = "Prospect"
        Me.chkProspect.UseVisualStyleBackColor = True
        '
        'chkHasNotes
        '
        Me.chkHasNotes.AutoSize = True
        Me.chkHasNotes.Location = New System.Drawing.Point(120, 384)
        Me.chkHasNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkHasNotes.Name = "chkHasNotes"
        Me.chkHasNotes.Size = New System.Drawing.Size(120, 29)
        Me.chkHasNotes.TabIndex = 17
        Me.chkHasNotes.Text = "Has Notes"
        Me.chkHasNotes.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(129, 427)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(141, 31)
        Me.txtSubject.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 430)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Note Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 479)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Note Keyword"
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(131, 476)
        Me.txtKeyword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(141, 31)
        Me.txtKeyword.TabIndex = 20
        '
        'FormFilterGrowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 667)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.chkHasNotes)
        Me.Controls.Add(Me.chkProspect)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbCommodity)
        Me.Controls.Add(Me.lblCommodity)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFilterGrowers"
        Me.Text = "Filter Growers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents lblCounty As Label
    Friend WithEvents lblCommodity As Label
    Friend WithEvents cmbCommodity As ComboBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents chkProspect As CheckBox
    Friend WithEvents chkHasNotes As CheckBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKeyword As TextBox
End Class
