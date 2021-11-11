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
    'dgfghfjfjhgkhgkj

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lvCommoditySales = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGrowerCity = New System.Windows.Forms.Label()
        Me.lblGrowerCountry = New System.Windows.Forms.Label()
        Me.lblGrowerZip = New System.Windows.Forms.Label()
        Me.lblGrowerPhone1 = New System.Windows.Forms.Label()
        Me.lblGrowerState = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pbContact = New System.Windows.Forms.PictureBox()
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
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.TestDataGrid = New System.Windows.Forms.DataGridView()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnAddGrower = New System.Windows.Forms.Button()
        CType(Me.pbContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCommoditySales
        '
        Me.lvCommoditySales.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.lvCommoditySales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvCommoditySales.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvCommoditySales.ForeColor = System.Drawing.Color.Snow
        Me.lvCommoditySales.GridLines = True
        Me.lvCommoditySales.HideSelection = False
        Me.lvCommoditySales.Location = New System.Drawing.Point(528, 641)
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
        Me.cmdSearch.Location = New System.Drawing.Point(321, 105)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 22
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(84, 103)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(225, 23)
        Me.txtSearch.TabIndex = 23
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(81, 136)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(315, 679)
        Me.ListBox1.TabIndex = 32
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(709, 272)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(110, 14)
        Me.lblAddress.TabIndex = 33
        Me.lblAddress.Text = "GrowerAddress"
        '
        'lblGrowerCity
        '
        Me.lblGrowerCity.AutoSize = True
        Me.lblGrowerCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblGrowerCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblGrowerCity.Location = New System.Drawing.Point(710, 294)
        Me.lblGrowerCity.Name = "lblGrowerCity"
        Me.lblGrowerCity.Size = New System.Drawing.Size(83, 14)
        Me.lblGrowerCity.TabIndex = 34
        Me.lblGrowerCity.Text = "GrowerCity"
        '
        'lblGrowerCountry
        '
        Me.lblGrowerCountry.AutoSize = True
        Me.lblGrowerCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblGrowerCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGrowerCountry.Location = New System.Drawing.Point(710, 341)
        Me.lblGrowerCountry.Name = "lblGrowerCountry"
        Me.lblGrowerCountry.Size = New System.Drawing.Size(109, 14)
        Me.lblGrowerCountry.TabIndex = 35
        Me.lblGrowerCountry.Text = "GrowerCountry"
        '
        'lblGrowerZip
        '
        Me.lblGrowerZip.AutoSize = True
        Me.lblGrowerZip.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblGrowerZip.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerZip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblGrowerZip.Location = New System.Drawing.Point(801, 343)
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
        Me.lblGrowerState.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblGrowerState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblGrowerState.Location = New System.Drawing.Point(709, 317)
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
        Me.pbContact.Location = New System.Drawing.Point(443, 83)
        Me.pbContact.Name = "pbContact"
        Me.pbContact.Size = New System.Drawing.Size(529, 426)
        Me.pbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbContact.TabIndex = 40
        Me.pbContact.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(710, 239)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 14)
        Me.lblName.TabIndex = 43
        Me.lblName.Text = "GrowerName"
        '
        'ckVendor1
        '
        Me.ckVendor1.AutoSize = True
        Me.ckVendor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ckVendor1.Location = New System.Drawing.Point(528, 601)
        Me.ckVendor1.Name = "ckVendor1"
        Me.ckVendor1.Size = New System.Drawing.Size(114, 24)
        Me.ckVendor1.TabIndex = 44
        Me.ckVendor1.Text = "ckVendor1"
        Me.ckVendor1.UseVisualStyleBackColor = False
        '
        'ckVendor2
        '
        Me.ckVendor2.AutoSize = True
        Me.ckVendor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor2.Location = New System.Drawing.Point(726, 601)
        Me.ckVendor2.Name = "ckVendor2"
        Me.ckVendor2.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor2.TabIndex = 45
        Me.ckVendor2.Text = "ckVendor2"
        Me.ckVendor2.UseVisualStyleBackColor = False
        '
        'ckVendor3
        '
        Me.ckVendor3.AutoSize = True
        Me.ckVendor3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor3.Location = New System.Drawing.Point(926, 601)
        Me.ckVendor3.Name = "ckVendor3"
        Me.ckVendor3.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor3.TabIndex = 46
        Me.ckVendor3.Text = "ckVendor3"
        Me.ckVendor3.UseVisualStyleBackColor = False
        '
        'ckVendor4
        '
        Me.ckVendor4.AutoSize = True
        Me.ckVendor4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor4.Location = New System.Drawing.Point(1100, 601)
        Me.ckVendor4.Name = "ckVendor4"
        Me.ckVendor4.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor4.TabIndex = 47
        Me.ckVendor4.Text = "ckVendor4"
        Me.ckVendor4.UseVisualStyleBackColor = False
        '
        'ckVendor5
        '
        Me.ckVendor5.AutoSize = True
        Me.ckVendor5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor5.Location = New System.Drawing.Point(528, 567)
        Me.ckVendor5.Name = "ckVendor5"
        Me.ckVendor5.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor5.TabIndex = 48
        Me.ckVendor5.Text = "ckVendor5"
        Me.ckVendor5.UseVisualStyleBackColor = False
        '
        'ckVendor6
        '
        Me.ckVendor6.AutoSize = True
        Me.ckVendor6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor6.Location = New System.Drawing.Point(726, 567)
        Me.ckVendor6.Name = "ckVendor6"
        Me.ckVendor6.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor6.TabIndex = 49
        Me.ckVendor6.Text = "ckVendor6"
        Me.ckVendor6.UseVisualStyleBackColor = False
        '
        'ckVendor7
        '
        Me.ckVendor7.AutoSize = True
        Me.ckVendor7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor7.Location = New System.Drawing.Point(926, 567)
        Me.ckVendor7.Name = "ckVendor7"
        Me.ckVendor7.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor7.TabIndex = 50
        Me.ckVendor7.Text = "ckVendor7"
        Me.ckVendor7.UseVisualStyleBackColor = False
        '
        'ckVendor8
        '
        Me.ckVendor8.AutoSize = True
        Me.ckVendor8.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ckVendor8.Location = New System.Drawing.Point(1100, 567)
        Me.ckVendor8.Name = "ckVendor8"
        Me.ckVendor8.Size = New System.Drawing.Size(81, 19)
        Me.ckVendor8.TabIndex = 51
        Me.ckVendor8.Text = "ckVendor8"
        Me.ckVendor8.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1005, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Label1"
        '
        'btnAddNote
        '
        Me.btnAddNote.Location = New System.Drawing.Point(1005, 198)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNote.TabIndex = 53
        Me.btnAddNote.Text = "Add Note..."
        Me.btnAddNote.UseVisualStyleBackColor = True
        '
        'TestDataGrid
        '
        Me.TestDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Note})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.TestDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.TestDataGrid.Location = New System.Drawing.Point(1254, 40)
        Me.TestDataGrid.Name = "TestDataGrid"
        Me.TestDataGrid.RowTemplate.Height = 25
        Me.TestDataGrid.Size = New System.Drawing.Size(447, 831)
        Me.TestDataGrid.TabIndex = 54
        '
        'Note
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Note.DefaultCellStyle = DataGridViewCellStyle1
        Me.Note.HeaderText = "Note"
        Me.Note.MinimumWidth = 400
        Me.Note.Name = "Note"
        Me.Note.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Note.Width = 400
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1716, 743)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(674, 267)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(674, 365)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(674, 403)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 58
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(499, 244)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(156, 138)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 59
        Me.PictureBox5.TabStop = False
        '
        'btnAddGrower
        '
        Me.btnAddGrower.Location = New System.Drawing.Point(13, 895)
        Me.btnAddGrower.Name = "btnAddGrower"
        Me.btnAddGrower.Size = New System.Drawing.Size(95, 31)
        Me.btnAddGrower.TabIndex = 55
        Me.btnAddGrower.Text = "&Add Grower"
        Me.btnAddGrower.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1792, 887)
        Me.Controls.Add(Me.TestDataGrid)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ckVendor1)
        Me.Controls.Add(Me.ckVendor2)
        Me.Controls.Add(Me.ckVendor3)
        Me.Controls.Add(Me.ckVendor4)
        Me.Controls.Add(Me.ckVendor8)
        Me.Controls.Add(Me.ckVendor7)
        Me.Controls.Add(Me.ckVendor6)
        Me.Controls.Add(Me.ckVendor5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.lvCommoditySales)
        Me.Controls.Add(Me.lblGrowerZip)
        Me.Controls.Add(Me.lblGrowerCountry)
        Me.Controls.Add(Me.lblGrowerState)
        Me.Controls.Add(Me.lblGrowerCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.pbContact)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGrowerPhone1)
        Me.Name = "FormMain"
        Me.Text = "Saturn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
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
    Friend WithEvents lblName As Label
    Friend WithEvents ckVendor1 As CheckBox
    Friend WithEvents ckVendor2 As CheckBox
    Friend WithEvents ckVendor3 As CheckBox
    Friend WithEvents ckVendor4 As CheckBox
    Friend WithEvents ckVendor5 As CheckBox
    Friend WithEvents ckVendor6 As CheckBox
    Friend WithEvents ckVendor7 As CheckBox
    Friend WithEvents ckVendor8 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNote As Button
    Friend WithEvents TestDataGrid As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents btnAddGrower As Button
End Class
