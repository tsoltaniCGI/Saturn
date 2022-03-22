<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddReminder
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
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dttnPckTaskDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.btnRecurrence = New System.Windows.Forms.Button()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblStartDateText = New System.Windows.Forms.Label()
        Me.lblEndDateText = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblTaskTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(266, 42)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(303, 23)
        Me.txtSubject.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Task"
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(266, 117)
        Me.txtTask.Multiline = True
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(247, 87)
        Me.txtTask.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date and Time"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(191, 356)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(428, 356)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dttnPckTaskDate
        '
        Me.dttnPckTaskDate.CustomFormat = "MMMM dd, yyyy - dddd  hh:mi"
        Me.dttnPckTaskDate.Location = New System.Drawing.Point(268, 268)
        Me.dttnPckTaskDate.Name = "dttnPckTaskDate"
        Me.dttnPckTaskDate.Size = New System.Drawing.Size(204, 23)
        Me.dttnPckTaskDate.TabIndex = 9
        '
        'cmbTime
        '
        Me.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Location = New System.Drawing.Point(509, 268)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(121, 23)
        Me.cmbTime.TabIndex = 10
        '
        'btnRecurrence
        '
        Me.btnRecurrence.Location = New System.Drawing.Point(50, 308)
        Me.btnRecurrence.Name = "btnRecurrence"
        Me.btnRecurrence.Size = New System.Drawing.Size(120, 23)
        Me.btnRecurrence.TabIndex = 11
        Me.btnRecurrence.Text = "Add Re&currence..."
        Me.btnRecurrence.UseVisualStyleBackColor = True
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(191, 313)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(61, 15)
        Me.lblStartDate.TabIndex = 12
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblStartDateText
        '
        Me.lblStartDateText.AutoSize = True
        Me.lblStartDateText.Location = New System.Drawing.Point(259, 313)
        Me.lblStartDateText.Name = "lblStartDateText"
        Me.lblStartDateText.Size = New System.Drawing.Size(61, 15)
        Me.lblStartDateText.TabIndex = 13
        Me.lblStartDateText.Text = "Start Date:"
        '
        'lblEndDateText
        '
        Me.lblEndDateText.AutoSize = True
        Me.lblEndDateText.Location = New System.Drawing.Point(410, 313)
        Me.lblEndDateText.Name = "lblEndDateText"
        Me.lblEndDateText.Size = New System.Drawing.Size(78, 15)
        Me.lblEndDateText.TabIndex = 15
        Me.lblEndDateText.Text = "End Date Text"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(342, 313)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(57, 15)
        Me.lblEndDate.TabIndex = 14
        Me.lblEndDate.Text = "End Date:"
        '
        'lblTaskTime
        '
        Me.lblTaskTime.AutoSize = True
        Me.lblTaskTime.Location = New System.Drawing.Point(512, 313)
        Me.lblTaskTime.Name = "lblTaskTime"
        Me.lblTaskTime.Size = New System.Drawing.Size(174, 15)
        Me.lblTaskTime.TabIndex = 16
        Me.lblTaskTime.Text = "Now is the time for all good me"
        '
        'frmAddReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTaskTime)
        Me.Controls.Add(Me.lblEndDateText)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDateText)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.btnRecurrence)
        Me.Controls.Add(Me.cmbTime)
        Me.Controls.Add(Me.dttnPckTaskDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubject)
        Me.Name = "frmAddReminder"
        Me.Text = "Add Reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents Label3 As Label
    'Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dttnPckTaskDate As DateTimePicker
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents btnRecurrence As Button
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblStartDateText As Label
    Friend WithEvents lblEndDateText As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblTaskTime As Label
    'Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    'Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
