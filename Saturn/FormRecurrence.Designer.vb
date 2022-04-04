<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddRecurrence
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbYearly = New System.Windows.Forms.RadioButton()
        Me.rbMonthly = New System.Windows.Forms.RadioButton()
        Me.rbWeekly = New System.Windows.Forms.RadioButton()
        Me.rbDaily = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.ckSaturday = New System.Windows.Forms.CheckBox()
        Me.ckFriday = New System.Windows.Forms.CheckBox()
        Me.ckThursday = New System.Windows.Forms.CheckBox()
        Me.ckWednesday = New System.Windows.Forms.CheckBox()
        Me.ckTuesday = New System.Windows.Forms.CheckBox()
        Me.ckMonday = New System.Windows.Forms.CheckBox()
        Me.ckSunday = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInterval = New System.Windows.Forms.MaskedTextBox()
        Me.lblRecurEvery = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRemoveRecurrence = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.dtTimePickEnd = New System.Windows.Forms.DateTimePicker()
        Me.rbNoEndDate = New System.Windows.Forms.RadioButton()
        Me.rbEndafter = New System.Windows.Forms.RadioButton()
        Me.rbEndBy = New System.Windows.Forms.RadioButton()
        Me.dtTmPckStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.rbYearly)
        Me.GroupBox1.Controls.Add(Me.rbMonthly)
        Me.GroupBox1.Controls.Add(Me.rbWeekly)
        Me.GroupBox1.Controls.Add(Me.rbDaily)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbYearly
        '
        Me.rbYearly.AutoSize = True
        Me.rbYearly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbYearly.Location = New System.Drawing.Point(20, 95)
        Me.rbYearly.Name = "rbYearly"
        Me.rbYearly.Size = New System.Drawing.Size(56, 19)
        Me.rbYearly.TabIndex = 3
        Me.rbYearly.TabStop = True
        Me.rbYearly.Text = "Yearly"
        Me.rbYearly.UseVisualStyleBackColor = True
        '
        'rbMonthly
        '
        Me.rbMonthly.AutoSize = True
        Me.rbMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbMonthly.Location = New System.Drawing.Point(20, 71)
        Me.rbMonthly.Name = "rbMonthly"
        Me.rbMonthly.Size = New System.Drawing.Size(70, 19)
        Me.rbMonthly.TabIndex = 2
        Me.rbMonthly.TabStop = True
        Me.rbMonthly.Text = "Monthly"
        Me.rbMonthly.UseVisualStyleBackColor = True
        '
        'rbWeekly
        '
        Me.rbWeekly.AutoSize = True
        Me.rbWeekly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbWeekly.Location = New System.Drawing.Point(20, 47)
        Me.rbWeekly.Name = "rbWeekly"
        Me.rbWeekly.Size = New System.Drawing.Size(63, 19)
        Me.rbWeekly.TabIndex = 1
        Me.rbWeekly.TabStop = True
        Me.rbWeekly.Text = "Weekly"
        Me.rbWeekly.UseVisualStyleBackColor = True
        '
        'rbDaily
        '
        Me.rbDaily.AutoSize = True
        Me.rbDaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbDaily.Location = New System.Drawing.Point(20, 23)
        Me.rbDaily.Name = "rbDaily"
        Me.rbDaily.Size = New System.Drawing.Size(51, 19)
        Me.rbDaily.TabIndex = 0
        Me.rbDaily.TabStop = True
        Me.rbDaily.Text = "Daily"
        Me.rbDaily.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbTime)
        Me.GroupBox2.Controls.Add(Me.ckSaturday)
        Me.GroupBox2.Controls.Add(Me.ckFriday)
        Me.GroupBox2.Controls.Add(Me.ckThursday)
        Me.GroupBox2.Controls.Add(Me.ckWednesday)
        Me.GroupBox2.Controls.Add(Me.ckTuesday)
        Me.GroupBox2.Controls.Add(Me.ckMonday)
        Me.GroupBox2.Controls.Add(Me.ckSunday)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtInterval)
        Me.GroupBox2.Controls.Add(Me.lblRecurEvery)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(727, 183)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recurrence Pattern"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(507, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Time:"
        '
        'cmbTime
        '
        Me.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Location = New System.Drawing.Point(557, 18)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(121, 23)
        Me.cmbTime.TabIndex = 10
        '
        'ckSaturday
        '
        Me.ckSaturday.AutoSize = True
        Me.ckSaturday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckSaturday.Location = New System.Drawing.Point(315, 85)
        Me.ckSaturday.Name = "ckSaturday"
        Me.ckSaturday.Size = New System.Drawing.Size(72, 19)
        Me.ckSaturday.TabIndex = 9
        Me.ckSaturday.Text = "Saturday"
        Me.ckSaturday.UseVisualStyleBackColor = True
        '
        'ckFriday
        '
        Me.ckFriday.AutoSize = True
        Me.ckFriday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckFriday.Location = New System.Drawing.Point(238, 85)
        Me.ckFriday.Name = "ckFriday"
        Me.ckFriday.Size = New System.Drawing.Size(58, 19)
        Me.ckFriday.TabIndex = 8
        Me.ckFriday.Text = "Friday"
        Me.ckFriday.UseVisualStyleBackColor = True
        '
        'ckThursday
        '
        Me.ckThursday.AutoSize = True
        Me.ckThursday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckThursday.Location = New System.Drawing.Point(166, 85)
        Me.ckThursday.Name = "ckThursday"
        Me.ckThursday.Size = New System.Drawing.Size(74, 19)
        Me.ckThursday.TabIndex = 7
        Me.ckThursday.Text = "Thursday"
        Me.ckThursday.UseVisualStyleBackColor = True
        '
        'ckWednesday
        '
        Me.ckWednesday.AutoSize = True
        Me.ckWednesday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckWednesday.Location = New System.Drawing.Point(391, 53)
        Me.ckWednesday.Name = "ckWednesday"
        Me.ckWednesday.Size = New System.Drawing.Size(87, 19)
        Me.ckWednesday.TabIndex = 6
        Me.ckWednesday.Text = "Wednesday"
        Me.ckWednesday.UseVisualStyleBackColor = True
        '
        'ckTuesday
        '
        Me.ckTuesday.AutoSize = True
        Me.ckTuesday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckTuesday.Location = New System.Drawing.Point(315, 53)
        Me.ckTuesday.Name = "ckTuesday"
        Me.ckTuesday.Size = New System.Drawing.Size(69, 19)
        Me.ckTuesday.TabIndex = 5
        Me.ckTuesday.Text = "Tuesday"
        Me.ckTuesday.UseVisualStyleBackColor = True
        '
        'ckMonday
        '
        Me.ckMonday.AutoSize = True
        Me.ckMonday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckMonday.Location = New System.Drawing.Point(238, 53)
        Me.ckMonday.Name = "ckMonday"
        Me.ckMonday.Size = New System.Drawing.Size(70, 19)
        Me.ckMonday.TabIndex = 4
        Me.ckMonday.Text = "Monday"
        Me.ckMonday.UseVisualStyleBackColor = True
        '
        'ckSunday
        '
        Me.ckSunday.AutoSize = True
        Me.ckSunday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckSunday.Location = New System.Drawing.Point(166, 53)
        Me.ckSunday.Name = "ckSunday"
        Me.ckSunday.Size = New System.Drawing.Size(65, 19)
        Me.ckSunday.TabIndex = 3
        Me.ckSunday.Text = "Sunday"
        Me.ckSunday.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(279, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "weeks on:"
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(235, 19)
        Me.txtInterval.Mask = "99"
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(30, 23)
        Me.txtInterval.TabIndex = 1
        '
        'lblRecurEvery
        '
        Me.lblRecurEvery.AutoSize = True
        Me.lblRecurEvery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblRecurEvery.Location = New System.Drawing.Point(157, 23)
        Me.lblRecurEvery.Name = "lblRecurEvery"
        Me.lblRecurEvery.Size = New System.Drawing.Size(71, 15)
        Me.lblRecurEvery.TabIndex = 0
        Me.lblRecurEvery.Text = "Recur every "
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Location = New System.Drawing.Point(191, 386)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(353, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRemoveRecurrence
        '
        Me.btnRemoveRecurrence.BackColor = System.Drawing.SystemColors.Control
        Me.btnRemoveRecurrence.Location = New System.Drawing.Point(516, 386)
        Me.btnRemoveRecurrence.Name = "btnRemoveRecurrence"
        Me.btnRemoveRecurrence.Size = New System.Drawing.Size(160, 23)
        Me.btnRemoveRecurrence.TabIndex = 4
        Me.btnRemoveRecurrence.Text = "R&emove Recurrence..."
        Me.btnRemoveRecurrence.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox3.Controls.Add(Me.dtTimePickEnd)
        Me.GroupBox3.Controls.Add(Me.rbNoEndDate)
        Me.GroupBox3.Controls.Add(Me.rbEndafter)
        Me.GroupBox3.Controls.Add(Me.rbEndBy)
        Me.GroupBox3.Controls.Add(Me.dtTmPckStart)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(727, 98)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Range of recurrence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(433, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "occurences"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(391, 45)
        Me.MaskedTextBox2.Mask = "99"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(30, 23)
        Me.MaskedTextBox2.TabIndex = 6
        '
        'dtTimePickEnd
        '
        Me.dtTimePickEnd.Location = New System.Drawing.Point(392, 22)
        Me.dtTimePickEnd.Name = "dtTimePickEnd"
        Me.dtTimePickEnd.Size = New System.Drawing.Size(200, 23)
        Me.dtTimePickEnd.TabIndex = 5
        '
        'rbNoEndDate
        '
        Me.rbNoEndDate.AutoSize = True
        Me.rbNoEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbNoEndDate.Location = New System.Drawing.Point(263, 72)
        Me.rbNoEndDate.Name = "rbNoEndDate"
        Me.rbNoEndDate.Size = New System.Drawing.Size(91, 19)
        Me.rbNoEndDate.TabIndex = 4
        Me.rbNoEndDate.TabStop = True
        Me.rbNoEndDate.Text = "No End Date"
        Me.rbNoEndDate.UseVisualStyleBackColor = True
        '
        'rbEndafter
        '
        Me.rbEndafter.AutoSize = True
        Me.rbEndafter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbEndafter.Location = New System.Drawing.Point(263, 47)
        Me.rbEndafter.Name = "rbEndafter"
        Me.rbEndafter.Size = New System.Drawing.Size(74, 19)
        Me.rbEndafter.TabIndex = 3
        Me.rbEndafter.TabStop = True
        Me.rbEndafter.Text = "End After"
        Me.rbEndafter.UseVisualStyleBackColor = True
        '
        'rbEndBy
        '
        Me.rbEndBy.AutoSize = True
        Me.rbEndBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.rbEndBy.Location = New System.Drawing.Point(263, 22)
        Me.rbEndBy.Name = "rbEndBy"
        Me.rbEndBy.Size = New System.Drawing.Size(61, 19)
        Me.rbEndBy.TabIndex = 2
        Me.rbEndBy.TabStop = True
        Me.rbEndBy.Text = "End by"
        Me.rbEndBy.UseVisualStyleBackColor = True
        '
        'dtTmPckStart
        '
        Me.dtTmPckStart.Location = New System.Drawing.Point(44, 19)
        Me.dtTmPckStart.Name = "dtTmPckStart"
        Me.dtTmPckStart.Size = New System.Drawing.Size(200, 23)
        Me.dtTmPckStart.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Start: "
        '
        'FormAddRecurrence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnRemoveRecurrence)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormAddRecurrence"
        Me.Text = "Add Reminder Recurrence"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbYearly As RadioButton
    Friend WithEvents rbMonthly As RadioButton
    Friend WithEvents rbWeekly As RadioButton
    Friend WithEvents rbDaily As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInterval As MaskedTextBox
    Friend WithEvents lblRecurEvery As Label
    Friend WithEvents ckSunday As CheckBox
    Friend WithEvents ckSaturday As CheckBox
    Friend WithEvents ckFriday As CheckBox
    Friend WithEvents ckThursday As CheckBox
    Friend WithEvents ckWednesday As CheckBox
    Friend WithEvents ckTuesday As CheckBox
    Friend WithEvents ckMonday As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRemoveRecurrence As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents dtTimePickEnd As DateTimePicker
    Friend WithEvents rbNoEndDate As RadioButton
    Friend WithEvents rbEndafter As RadioButton
    Friend WithEvents rbEndBy As RadioButton
    Friend WithEvents dtTmPckStart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTime As ComboBox
End Class
