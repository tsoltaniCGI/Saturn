<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ckProspect = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lstVendors = New System.Windows.Forms.ListBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWorkPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ckProspect
        '
        Me.ckProspect.AutoSize = True
        Me.ckProspect.Location = New System.Drawing.Point(503, 52)
        Me.ckProspect.Name = "ckProspect"
        Me.ckProspect.Size = New System.Drawing.Size(77, 19)
        Me.ckProspect.TabIndex = 56
        Me.ckProspect.Text = "Prospect?"
        Me.ckProspect.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 567)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(270, 566)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 54
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lstVendors
        '
        Me.lstVendors.FormattingEnabled = True
        Me.lstVendors.ItemHeight = 15
        Me.lstVendors.Location = New System.Drawing.Point(99, 289)
        Me.lstVendors.Name = "lstVendors"
        Me.lstVendors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstVendors.Size = New System.Drawing.Size(261, 259)
        Me.lstVendors.TabIndex = 53
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(179, 243)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 23)
        Me.txtEmail.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 15)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Email"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(574, 204)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(100, 23)
        Me.txtFax.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(538, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 15)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Fax"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Location = New System.Drawing.Point(391, 204)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtCellPhone.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(296, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Cell Phone:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtWorkPhone
        '
        Me.txtWorkPhone.Location = New System.Drawing.Point(179, 204)
        Me.txtWorkPhone.Name = "txtWorkPhone"
        Me.txtWorkPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtWorkPhone.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Work Phone:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(344, 171)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(100, 23)
        Me.txtCounty.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "County:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(667, 170)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(57, 23)
        Me.txtZip.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(636, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Zip:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(566, 170)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(35, 23)
        Me.txtState.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "State:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(179, 169)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 23)
        Me.txtCity.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "City:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(177, 128)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(207, 23)
        Me.txtAddress2.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Address: Cont..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(175, 88)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(207, 23)
        Me.txtAddress1.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Address:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(174, 52)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 23)
        Me.txtLastName.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Last Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(174, 18)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 23)
        Me.txtFirstName.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "First Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 608)
        Me.Controls.Add(Me.ckProspect)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstVendors)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCellPhone)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtWorkPhone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ckProspect As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lstVendors As ListBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCellPhone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWorkPhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
End Class
