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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ckGrower1 = New System.Windows.Forms.CheckBox()
        Me.ckGrower2 = New System.Windows.Forms.CheckBox()
        Me.ckGrower3 = New System.Windows.Forms.CheckBox()
        Me.ckGrower4 = New System.Windows.Forms.CheckBox()
        Me.ckGrower5 = New System.Windows.Forms.CheckBox()
        Me.ckGrower6 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvVendors = New System.Windows.Forms.DataGridView()
        Me.FarmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgTechID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Farms"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1165, 728)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ckGrower1
        '
        Me.ckGrower1.AutoSize = True
        Me.ckGrower1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckGrower1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower1.Location = New System.Drawing.Point(416, 76)
        Me.ckGrower1.Name = "ckGrower1"
        Me.ckGrower1.Size = New System.Drawing.Size(93, 25)
        Me.ckGrower1.TabIndex = 5
        Me.ckGrower1.Text = "Grower1"
        Me.ckGrower1.UseVisualStyleBackColor = False
        '
        'ckGrower2
        '
        Me.ckGrower2.AutoSize = True
        Me.ckGrower2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckGrower2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower2.Location = New System.Drawing.Point(416, 116)
        Me.ckGrower2.Name = "ckGrower2"
        Me.ckGrower2.Size = New System.Drawing.Size(93, 25)
        Me.ckGrower2.TabIndex = 6
        Me.ckGrower2.Text = "Grower2"
        Me.ckGrower2.UseVisualStyleBackColor = False
        '
        'ckGrower3
        '
        Me.ckGrower3.AutoSize = True
        Me.ckGrower3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckGrower3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower3.Location = New System.Drawing.Point(677, 76)
        Me.ckGrower3.Name = "ckGrower3"
        Me.ckGrower3.Size = New System.Drawing.Size(93, 25)
        Me.ckGrower3.TabIndex = 7
        Me.ckGrower3.Text = "Grower3"
        Me.ckGrower3.UseVisualStyleBackColor = False
        '
        'ckGrower4
        '
        Me.ckGrower4.AutoSize = True
        Me.ckGrower4.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckGrower4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower4.Location = New System.Drawing.Point(677, 116)
        Me.ckGrower4.Name = "ckGrower4"
        Me.ckGrower4.Size = New System.Drawing.Size(93, 25)
        Me.ckGrower4.TabIndex = 8
        Me.ckGrower4.Text = "Grower4"
        Me.ckGrower4.UseVisualStyleBackColor = False
        '
        'ckGrower5
        '
        Me.ckGrower5.AutoSize = True
        Me.ckGrower5.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckGrower5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower5.Location = New System.Drawing.Point(949, 76)
        Me.ckGrower5.Name = "ckGrower5"
        Me.ckGrower5.Size = New System.Drawing.Size(93, 25)
        Me.ckGrower5.TabIndex = 9
        Me.ckGrower5.Text = "Grower5"
        Me.ckGrower5.UseVisualStyleBackColor = False
        '
        'ckGrower6
        '
        Me.ckGrower6.AutoSize = True
        Me.ckGrower6.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ckGrower6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckGrower6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ckGrower6.Location = New System.Drawing.Point(949, 116)
        Me.ckGrower6.Name = "ckGrower6"
        Me.ckGrower6.Size = New System.Drawing.Size(93, 25)
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
        Me.Label2.Location = New System.Drawing.Point(408, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Notes"
        '
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AllowUserToDeleteRows = False
        Me.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNotes.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Note, Me.CreationDate, Me.Author, Me.Grower})
        Me.dgvNotes.Location = New System.Drawing.Point(405, 202)
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.ReadOnly = True
        Me.dgvNotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNotes.RowHeadersVisible = False
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvNotes.RowTemplate.Height = 25
        Me.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotes.Size = New System.Drawing.Size(733, 504)
        Me.dgvNotes.TabIndex = 13
        '
        'Note
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Note.DefaultCellStyle = DataGridViewCellStyle2
        Me.Note.Frozen = True
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.Width = 350
        '
        'CreationDate
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CreationDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.CreationDate.Frozen = True
        Me.CreationDate.HeaderText = "Creation Date"
        Me.CreationDate.Name = "CreationDate"
        Me.CreationDate.ReadOnly = True
        Me.CreationDate.Width = 150
        '
        'Author
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Author.DefaultCellStyle = DataGridViewCellStyle4
        Me.Author.Frozen = True
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'Grower
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grower.DefaultCellStyle = DataGridViewCellStyle5
        Me.Grower.Frozen = True
        Me.Grower.HeaderText = "Grower"
        Me.Grower.Name = "Grower"
        Me.Grower.ReadOnly = True
        Me.Grower.Width = 200
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1057, 25)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvVendors
        '
        Me.dgvVendors.AllowUserToAddRows = False
        Me.dgvVendors.AllowUserToDeleteRows = False
        Me.dgvVendors.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendors.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FarmName, Me.AgTechID})
        Me.dgvVendors.Location = New System.Drawing.Point(37, 87)
        Me.dgvVendors.Name = "dgvVendors"
        Me.dgvVendors.ReadOnly = True
        Me.dgvVendors.RowHeadersVisible = False
        Me.dgvVendors.RowTemplate.Height = 25
        Me.dgvVendors.Size = New System.Drawing.Size(304, 619)
        Me.dgvVendors.TabIndex = 16
        '
        'FarmName
        '
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.FarmName.DefaultCellStyle = DataGridViewCellStyle8
        Me.FarmName.Frozen = True
        Me.FarmName.HeaderText = "Farm Name"
        Me.FarmName.Name = "FarmName"
        Me.FarmName.ReadOnly = True
        Me.FarmName.Width = 200
        '
        'AgTechID
        '
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.AgTechID.DefaultCellStyle = DataGridViewCellStyle9
        Me.AgTechID.Frozen = True
        Me.AgTechID.HeaderText = "AGTech ID"
        Me.AgTechID.Name = "AgTechID"
        Me.AgTechID.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(405, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Growers"
        '
        'FarmViewMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 752)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvVendors)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvNotes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckGrower6)
        Me.Controls.Add(Me.ckGrower5)
        Me.Controls.Add(Me.ckGrower4)
        Me.Controls.Add(Me.ckGrower3)
        Me.Controls.Add(Me.ckGrower2)
        Me.Controls.Add(Me.ckGrower1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FarmViewMain"
        Me.Text = "Farm View"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVendors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ckGrower1 As CheckBox
    Friend WithEvents ckGrower2 As CheckBox
    Friend WithEvents ckGrower3 As CheckBox
    Friend WithEvents ckGrower4 As CheckBox
    Friend WithEvents ckGrower5 As CheckBox
    Friend WithEvents ckGrower6 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvNotes As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvVendors As DataGridView
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents CreationDate As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Grower As DataGridViewTextBoxColumn
    Friend WithEvents FarmName As DataGridViewTextBoxColumn
    Friend WithEvents AgTechID As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
