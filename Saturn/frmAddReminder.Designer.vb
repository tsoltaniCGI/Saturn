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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddReminder))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(266, 72)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(247, 23)
        Me.txtSubject.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(154, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(154, 120)
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
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(154, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date and Time"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(323, 401)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(454, 401)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dttnPckTaskDate
        '
        Me.dttnPckTaskDate.CustomFormat = "MMMM dd, yyyy - dddd  hh:mi"
        Me.dttnPckTaskDate.Location = New System.Drawing.Point(266, 233)
        Me.dttnPckTaskDate.Name = "dttnPckTaskDate"
        Me.dttnPckTaskDate.Size = New System.Drawing.Size(206, 23)
        Me.dttnPckTaskDate.TabIndex = 9
        '
        'cmbTime
        '
        Me.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Location = New System.Drawing.Point(497, 233)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(121, 23)
        Me.cmbTime.TabIndex = 10
        '
        'btnRecurrence
        '
        Me.btnRecurrence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRecurrence.Location = New System.Drawing.Point(154, 281)
        Me.btnRecurrence.Name = "btnRecurrence"
        Me.btnRecurrence.Size = New System.Drawing.Size(108, 23)
        Me.btnRecurrence.TabIndex = 11
        Me.btnRecurrence.Text = "Add Recurrence"
        Me.btnRecurrence.UseVisualStyleBackColor = True
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblStartDate.Location = New System.Drawing.Point(266, 320)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(61, 15)
        Me.lblStartDate.TabIndex = 12
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblStartDateText
        '
        Me.lblStartDateText.AutoSize = True
        Me.lblStartDateText.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblStartDateText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblStartDateText.Location = New System.Drawing.Point(333, 320)
        Me.lblStartDateText.Name = "lblStartDateText"
        Me.lblStartDateText.Size = New System.Drawing.Size(61, 15)
        Me.lblStartDateText.TabIndex = 13
        Me.lblStartDateText.Text = "Start Date:"
        '
        'lblEndDateText
        '
        Me.lblEndDateText.AutoSize = True
        Me.lblEndDateText.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblEndDateText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblEndDateText.Location = New System.Drawing.Point(474, 320)
        Me.lblEndDateText.Name = "lblEndDateText"
        Me.lblEndDateText.Size = New System.Drawing.Size(78, 15)
        Me.lblEndDateText.TabIndex = 15
        Me.lblEndDateText.Text = "End Date Text"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblEndDate.Location = New System.Drawing.Point(406, 320)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(57, 15)
        Me.lblEndDate.TabIndex = 14
        Me.lblEndDate.Text = "End Date:"
        '
        'lblTaskTime
        '
        Me.lblTaskTime.AutoSize = True
        Me.lblTaskTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblTaskTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblTaskTime.Location = New System.Drawing.Point(576, 320)
        Me.lblTaskTime.Name = "lblTaskTime"
        Me.lblTaskTime.Size = New System.Drawing.Size(174, 15)
        Me.lblTaskTime.TabIndex = 16
        Me.lblTaskTime.Text = "Now is the time for all good me"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 426)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(98, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(665, 340)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(53, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 89)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'frmAddReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTaskTime)
        Me.Controls.Add(Me.lblEndDateText)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDateText)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.btnRecurrence)
        Me.Controls.Add(Me.cmbTime)
        Me.Controls.Add(Me.dttnPckTaskDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAddReminder"
        Me.Text = "Add Reminder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    'Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    'Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
