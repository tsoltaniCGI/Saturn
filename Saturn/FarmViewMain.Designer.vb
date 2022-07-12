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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvVendors = New System.Windows.Forms.DataGridView()
        Me.Farm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AllowUserToDeleteRows = False
        Me.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Note, Me.DataGridViewTextBoxColumn1, Me.Author, Me.Grower})
        Me.dgvNotes.Location = New System.Drawing.Point(335, 202)
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.ReadOnly = True
        Me.dgvNotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNotes.RowHeadersVisible = False
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNotes.RowTemplate.Height = 25
        Me.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotes.Size = New System.Drawing.Size(725, 434)
        Me.dgvNotes.TabIndex = 13
        '
        'Note
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Note.DefaultCellStyle = DataGridViewCellStyle1
        Me.Note.Frozen = True
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.Width = 350
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Creation Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Author
        '
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'Grower
        '
        Me.Grower.HeaderText = "Grower"
        Me.Grower.Name = "Grower"
        Me.Grower.ReadOnly = True
        Me.Grower.Width = 200
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(517, 689)
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
        Me.dgvVendors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column1})
        Me.dgvVendors.Location = New System.Drawing.Point(26, 76)
        Me.dgvVendors.Name = "dgvVendors"
        Me.dgvVendors.ReadOnly = True
        Me.dgvVendors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvVendors.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendors.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVendors.RowTemplate.Height = 25
        Me.dgvVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendors.Size = New System.Drawing.Size(293, 560)
        Me.dgvVendors.TabIndex = 16
        '
        'Farm
        '
        Me.Farm.Frozen = True
        Me.Farm.HeaderText = "Farm"
        Me.Farm.Name = "Farm"
        Me.Farm.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Farm"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Agtech ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'FarmViewMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 752)
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
        Me.Text = "FarmViewMain"
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
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Grower As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvVendors As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Farm As DataGridViewTextBoxColumn
End Class
