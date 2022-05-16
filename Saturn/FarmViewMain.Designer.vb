<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarmViewMain
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
        Me.lvVendors = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lvNotes = New System.Windows.Forms.ListView()
        Me.GrowerName = New System.Windows.Forms.ColumnHeader()
        Me.CreatedDate = New System.Windows.Forms.ColumnHeader()
        Me.Subject = New System.Windows.Forms.ColumnHeader()
        Me.CreatedBy = New System.Windows.Forms.ColumnHeader()
        Me.Note = New System.Windows.Forms.ColumnHeader()
        Me.ckGrower1 = New System.Windows.Forms.CheckBox()
        Me.ckGrower2 = New System.Windows.Forms.CheckBox()
        Me.ckGrower3 = New System.Windows.Forms.CheckBox()
        Me.ckGrower4 = New System.Windows.Forms.CheckBox()
        Me.ckGrower5 = New System.Windows.Forms.CheckBox()
        Me.ckGrower6 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvVendors
        '
        Me.lvVendors.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvVendors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvVendors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lvVendors.HideSelection = False
        Me.lvVendors.Location = New System.Drawing.Point(26, 76)
        Me.lvVendors.Name = "lvVendors"
        Me.lvVendors.Size = New System.Drawing.Size(240, 630)
        Me.lvVendors.TabIndex = 0
        Me.lvVendors.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Vendor Name"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "AgTech ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vendors"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1078, 728)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lvNotes
        '
        Me.lvNotes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GrowerName, Me.CreatedDate, Me.Subject, Me.CreatedBy, Me.Note})
        Me.lvNotes.HideSelection = False
        Me.lvNotes.Location = New System.Drawing.Point(335, 210)
        Me.lvNotes.Name = "lvNotes"
        Me.lvNotes.Size = New System.Drawing.Size(709, 496)
        Me.lvNotes.TabIndex = 4
        Me.lvNotes.UseCompatibleStateImageBehavior = False
        '
        'ckGrower1
        '
        Me.ckGrower1.AutoSize = True
        Me.ckGrower1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower1.Location = New System.Drawing.Point(335, 76)
        Me.ckGrower1.Name = "ckGrower1"
        Me.ckGrower1.Size = New System.Drawing.Size(70, 19)
        Me.ckGrower1.TabIndex = 5
        Me.ckGrower1.Text = "Grower1"
        Me.ckGrower1.UseVisualStyleBackColor = False
        '
        'ckGrower2
        '
        Me.ckGrower2.AutoSize = True
        Me.ckGrower2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower2.Location = New System.Drawing.Point(335, 116)
        Me.ckGrower2.Name = "ckGrower2"
        Me.ckGrower2.Size = New System.Drawing.Size(70, 19)
        Me.ckGrower2.TabIndex = 6
        Me.ckGrower2.Text = "Grower2"
        Me.ckGrower2.UseVisualStyleBackColor = False
        '
        'ckGrower3
        '
        Me.ckGrower3.AutoSize = True
        Me.ckGrower3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower3.Location = New System.Drawing.Point(635, 76)
        Me.ckGrower3.Name = "ckGrower3"
        Me.ckGrower3.Size = New System.Drawing.Size(70, 19)
        Me.ckGrower3.TabIndex = 7
        Me.ckGrower3.Text = "Grower3"
        Me.ckGrower3.UseVisualStyleBackColor = False
        '
        'ckGrower4
        '
        Me.ckGrower4.AutoSize = True
        Me.ckGrower4.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower4.Location = New System.Drawing.Point(635, 116)
        Me.ckGrower4.Name = "ckGrower4"
        Me.ckGrower4.Size = New System.Drawing.Size(70, 19)
        Me.ckGrower4.TabIndex = 8
        Me.ckGrower4.Text = "Grower4"
        Me.ckGrower4.UseVisualStyleBackColor = False
        '
        'ckGrower5
        '
        Me.ckGrower5.AutoSize = True
        Me.ckGrower5.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower5.Location = New System.Drawing.Point(933, 76)
        Me.ckGrower5.Name = "ckGrower5"
        Me.ckGrower5.Size = New System.Drawing.Size(70, 19)
        Me.ckGrower5.TabIndex = 9
        Me.ckGrower5.Text = "Grower5"
        Me.ckGrower5.UseVisualStyleBackColor = False
        '
        'ckGrower6
        '
        Me.ckGrower6.AutoSize = True
        Me.ckGrower6.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower6.Location = New System.Drawing.Point(933, 116)
        Me.ckGrower6.Name = "ckGrower6"
        Me.ckGrower6.Size = New System.Drawing.Size(70, 19)
        Me.ckGrower6.TabIndex = 10
        Me.ckGrower6.Text = "Grower6"
        Me.ckGrower6.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(335, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Notes"
        '
        'FarmViewMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 752)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckGrower6)
        Me.Controls.Add(Me.ckGrower5)
        Me.Controls.Add(Me.ckGrower4)
        Me.Controls.Add(Me.ckGrower3)
        Me.Controls.Add(Me.ckGrower2)
        Me.Controls.Add(Me.ckGrower1)
        Me.Controls.Add(Me.lvNotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvVendors)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FarmViewMain"
        Me.Text = "FarmViewMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvVendors As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lvNotes As ListView
    Friend WithEvents GrowerName As ColumnHeader
    Friend WithEvents CreatedDate As ColumnHeader
    Friend WithEvents Subject As ColumnHeader
    Friend WithEvents CreatedBy As ColumnHeader
    Friend WithEvents Note As ColumnHeader
    Friend WithEvents ckGrower1 As CheckBox
    Friend WithEvents ckGrower2 As CheckBox
    Friend WithEvents ckGrower3 As CheckBox
    Friend WithEvents ckGrower4 As CheckBox
    Friend WithEvents ckGrower5 As CheckBox
    Friend WithEvents ckGrower6 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
