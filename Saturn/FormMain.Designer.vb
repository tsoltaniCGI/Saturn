<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lvCommoditySales = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtGrowerName = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGrowerCity = New System.Windows.Forms.Label()
        Me.lblGrowerCountry = New System.Windows.Forms.Label()
        Me.lblGrowerZip = New System.Windows.Forms.Label()
        Me.lblGrowerPhone1 = New System.Windows.Forms.Label()
        Me.lblGrowerState = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pbContact = New System.Windows.Forms.PictureBox()
        Me.pbGrowerPicture = New System.Windows.Forms.PictureBox()
        Me.lvNotes = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ckVendor1 = New System.Windows.Forms.CheckBox()
        Me.ckVendor2 = New System.Windows.Forms.CheckBox()
        Me.ckVendor3 = New System.Windows.Forms.CheckBox()
        Me.ckVendor4 = New System.Windows.Forms.CheckBox()
        Me.ckVendor5 = New System.Windows.Forms.CheckBox()
        Me.ckVendor6 = New System.Windows.Forms.CheckBox()
        Me.ckVendor7 = New System.Windows.Forms.CheckBox()
        Me.ckVendor8 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGrowerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCommoditySales
        '
        Me.lvCommoditySales.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lvCommoditySales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvCommoditySales.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvCommoditySales.ForeColor = System.Drawing.Color.Snow
        Me.lvCommoditySales.GridLines = True
        Me.lvCommoditySales.HideSelection = False
        Me.lvCommoditySales.Location = New System.Drawing.Point(342, 641)
        Me.lvCommoditySales.Margin = New System.Windows.Forms.Padding(7)
        Me.lvCommoditySales.Name = "lvCommoditySales"
        Me.lvCommoditySales.Scrollable = False
        Me.lvCommoditySales.Size = New System.Drawing.Size(653, 230)
        Me.lvCommoditySales.TabIndex = 20
        Me.lvCommoditySales.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Commodity"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cur Crop Year"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prev Crop Year"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "2 Yrs Prev"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Buyer"
        Me.ColumnHeader5.Width = 100
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(243, 54)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 22
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(12, 54)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(225, 23)
        Me.txtSearch.TabIndex = 23
        '
        'txtGrowerName
        '
        Me.txtGrowerName.BackColor = System.Drawing.SystemColors.Control
        Me.txtGrowerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrowerName.Location = New System.Drawing.Point(281, 82)
        Me.txtGrowerName.Name = "txtGrowerName"
        Me.txtGrowerName.Size = New System.Drawing.Size(148, 16)
        Me.txtGrowerName.TabIndex = 25
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(8, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(315, 784)
        Me.ListBox1.TabIndex = 32
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(608, 212)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(110, 14)
        Me.lblAddress.TabIndex = 33
        Me.lblAddress.Text = "GrowerAddress"
        '
        'lblGrowerCity
        '
        Me.lblGrowerCity.AutoSize = True
        Me.lblGrowerCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrowerCity.Location = New System.Drawing.Point(609, 237)
        Me.lblGrowerCity.Name = "lblGrowerCity"
        Me.lblGrowerCity.Size = New System.Drawing.Size(83, 14)
        Me.lblGrowerCity.TabIndex = 34
        Me.lblGrowerCity.Text = "GrowerCity"
        '
        'lblGrowerCountry
        '
        Me.lblGrowerCountry.AutoSize = True
        Me.lblGrowerCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrowerCountry.Location = New System.Drawing.Point(609, 289)
        Me.lblGrowerCountry.Name = "lblGrowerCountry"
        Me.lblGrowerCountry.Size = New System.Drawing.Size(109, 14)
        Me.lblGrowerCountry.TabIndex = 35
        Me.lblGrowerCountry.Text = "GrowerCountry"
        '
        'lblGrowerZip
        '
        Me.lblGrowerZip.AutoSize = True
        Me.lblGrowerZip.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerZip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrowerZip.Location = New System.Drawing.Point(700, 289)
        Me.lblGrowerZip.Name = "lblGrowerZip"
        Me.lblGrowerZip.Size = New System.Drawing.Size(77, 14)
        Me.lblGrowerZip.TabIndex = 37
        Me.lblGrowerZip.Text = "GrowerZip"
        '
        'lblGrowerPhone1
        '
        Me.lblGrowerPhone1.AutoSize = True
        Me.lblGrowerPhone1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerPhone1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrowerPhone1.Location = New System.Drawing.Point(609, 314)
        Me.lblGrowerPhone1.Name = "lblGrowerPhone1"
        Me.lblGrowerPhone1.Size = New System.Drawing.Size(107, 14)
        Me.lblGrowerPhone1.TabIndex = 38
        Me.lblGrowerPhone1.Text = "GrowerPhone1"
        '
        'lblGrowerState
        '
        Me.lblGrowerState.AutoSize = True
        Me.lblGrowerState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGrowerState.Location = New System.Drawing.Point(608, 262)
        Me.lblGrowerState.Name = "lblGrowerState"
        Me.lblGrowerState.Size = New System.Drawing.Size(92, 14)
        Me.lblGrowerState.TabIndex = 39
        Me.lblGrowerState.Text = "GrowerState"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pbContact
        '
        Me.pbContact.Image = CType(resources.GetObject("pbContact.Image"), System.Drawing.Image)
        Me.pbContact.Location = New System.Drawing.Point(362, 54)
        Me.pbContact.Name = "pbContact"
        Me.pbContact.Size = New System.Drawing.Size(532, 346)
        Me.pbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbContact.TabIndex = 40
        Me.pbContact.TabStop = False
        '
        'pbGrowerPicture
        '
        Me.pbGrowerPicture.Image = CType(resources.GetObject("pbGrowerPicture.Image"), System.Drawing.Image)
        Me.pbGrowerPicture.Location = New System.Drawing.Point(453, 181)
        Me.pbGrowerPicture.Name = "pbGrowerPicture"
        Me.pbGrowerPicture.Size = New System.Drawing.Size(119, 134)
        Me.pbGrowerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbGrowerPicture.TabIndex = 41
        Me.pbGrowerPicture.TabStop = False
        '
        'lvNotes
        '
        Me.lvNotes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvNotes.HideSelection = False
        Me.lvNotes.Location = New System.Drawing.Point(1377, 35)
        Me.lvNotes.Name = "lvNotes"
        Me.lvNotes.Size = New System.Drawing.Size(448, 798)
        Me.lvNotes.TabIndex = 42
        Me.lvNotes.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GrowerNoteCreationDate"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "GrowerNoteSubject"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "GrowerNoteMethod"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "GrowerNoteSubject"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "GrowerNoteCreatedBy"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(609, 181)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 14)
        Me.lblName.TabIndex = 43
        Me.lblName.Text = "GrowerName"
        '
        'ckVendor1
        '
        Me.ckVendor1.AutoSize = True
        Me.ckVendor1.Location = New System.Drawing.Point(389, 430)
        Me.ckVendor1.Name = "ckVendor1"
        Me.ckVendor1.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor1.TabIndex = 44
        Me.ckVendor1.Text = "CheckBox1"
        Me.ckVendor1.UseVisualStyleBackColor = True
        '
        'ckVendor2
        '
        Me.ckVendor2.AutoSize = True
        Me.ckVendor2.Location = New System.Drawing.Point(389, 457)
        Me.ckVendor2.Name = "ckVendor2"
        Me.ckVendor2.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor2.TabIndex = 45
        Me.ckVendor2.Text = "CheckBox1"
        Me.ckVendor2.UseVisualStyleBackColor = True
        '
        'ckVendor3
        '
        Me.ckVendor3.AutoSize = True
        Me.ckVendor3.Location = New System.Drawing.Point(389, 487)
        Me.ckVendor3.Name = "ckVendor3"
        Me.ckVendor3.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor3.TabIndex = 46
        Me.ckVendor3.Text = "CheckBox1"
        Me.ckVendor3.UseVisualStyleBackColor = True
        '
        'ckVendor4
        '
        Me.ckVendor4.AutoSize = True
        Me.ckVendor4.Location = New System.Drawing.Point(389, 513)
        Me.ckVendor4.Name = "ckVendor4"
        Me.ckVendor4.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor4.TabIndex = 47
        Me.ckVendor4.Text = "CheckBox1"
        Me.ckVendor4.UseVisualStyleBackColor = True
        '
        'ckVendor5
        '
        Me.ckVendor5.AutoSize = True
        Me.ckVendor5.Location = New System.Drawing.Point(528, 430)
        Me.ckVendor5.Name = "ckVendor5"
        Me.ckVendor5.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor5.TabIndex = 48
        Me.ckVendor5.Text = "CheckBox1"
        Me.ckVendor5.UseVisualStyleBackColor = True
        '
        'ckVendor6
        '
        Me.ckVendor6.AutoSize = True
        Me.ckVendor6.Location = New System.Drawing.Point(528, 457)
        Me.ckVendor6.Name = "ckVendor6"
        Me.ckVendor6.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor6.TabIndex = 49
        Me.ckVendor6.Text = "CheckBox1"
        Me.ckVendor6.UseVisualStyleBackColor = True
        '
        'ckVendor7
        '
        Me.ckVendor7.AutoSize = True
        Me.ckVendor7.Location = New System.Drawing.Point(528, 487)
        Me.ckVendor7.Name = "ckVendor7"
        Me.ckVendor7.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor7.TabIndex = 50
        Me.ckVendor7.Text = "CheckBox1"
        Me.ckVendor7.UseVisualStyleBackColor = True
        '
        'ckVendor8
        '
        Me.ckVendor8.AutoSize = True
        Me.ckVendor8.Location = New System.Drawing.Point(528, 513)
        Me.ckVendor8.Name = "ckVendor8"
        Me.ckVendor8.Size = New System.Drawing.Size(85, 19)
        Me.ckVendor8.TabIndex = 51
        Me.ckVendor8.Text = "CheckBox1"
        Me.ckVendor8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(988, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Label1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1797, 887)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckVendor8)
        Me.Controls.Add(Me.ckVendor7)
        Me.Controls.Add(Me.ckVendor6)
        Me.Controls.Add(Me.ckVendor5)
        Me.Controls.Add(Me.ckVendor4)
        Me.Controls.Add(Me.ckVendor3)
        Me.Controls.Add(Me.ckVendor2)
        Me.Controls.Add(Me.ckVendor1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lvNotes)
        Me.Controls.Add(Me.lvCommoditySales)
        Me.Controls.Add(Me.pbGrowerPicture)
        Me.Controls.Add(Me.lblGrowerState)
        Me.Controls.Add(Me.lblGrowerPhone1)
        Me.Controls.Add(Me.lblGrowerZip)
        Me.Controls.Add(Me.lblGrowerCountry)
        Me.Controls.Add(Me.lblGrowerCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtGrowerName)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.pbContact)
        Me.Name = "FormMain"
        Me.Text = "Saturn"
        CType(Me.pbContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGrowerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtGrowerName As TextBox
    Friend WithEvents txtGrowerCountry As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGrowerCity As Label
    Friend WithEvents lblGrowerCountry As Label
    Friend WithEvents lblGrowerZip As Label
    Friend WithEvents lblGrowerPhone1 As Label
    Friend WithEvents lblGrowerState As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lvCommoditySales As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents pbContact As PictureBox
    Friend WithEvents pbGrowerPicture As PictureBox
    Friend WithEvents lvNotes As ListView
    Friend WithEvents lblName As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ckVendor1 As CheckBox
    Friend WithEvents ckVendor2 As CheckBox
    Friend WithEvents ckVendor3 As CheckBox
    Friend WithEvents ckVendor4 As CheckBox
    Friend WithEvents ckVendor5 As CheckBox
    Friend WithEvents ckVendor6 As CheckBox
    Friend WithEvents ckVendor7 As CheckBox
    Friend WithEvents ckVendor8 As CheckBox
    Friend WithEvents Label1 As Label
End Class
