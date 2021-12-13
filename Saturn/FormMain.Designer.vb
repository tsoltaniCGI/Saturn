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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lvCommoditySales = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
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
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.TestDataGrid = New System.Windows.Forms.DataGridView()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnMissingButton = New System.Windows.Forms.Button()
        Me.btnEditGrower = New System.Windows.Forms.Button()
        Me.btnAddGrower = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.lvNonCGI = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.txtvendors = New System.Windows.Forms.TextBox()
        Me.txtProspect = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGrowers = New System.Windows.Forms.TextBox()
        Me.btnAddNonCGI = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.btnEditNonCGI = New System.Windows.Forms.Button()
        CType(Me.pbContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvCommoditySales
        '
        Me.lvCommoditySales.BackColor = System.Drawing.Color.White
        Me.lvCommoditySales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCommoditySales.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvCommoditySales.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lvCommoditySales.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lvCommoditySales.GridLines = True
        Me.lvCommoditySales.HideSelection = False
        Me.lvCommoditySales.Location = New System.Drawing.Point(403, 705)
        Me.lvCommoditySales.Margin = New System.Windows.Forms.Padding(7)
        Me.lvCommoditySales.Name = "lvCommoditySales"
        Me.lvCommoditySales.Scrollable = False
        Me.lvCommoditySales.Size = New System.Drawing.Size(394, 209)
        Me.lvCommoditySales.TabIndex = 20
        Me.lvCommoditySales.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Commodity"
        Me.ColumnHeader1.Width = 220
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cur Crop Year"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prev Crop Year"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "2 Yrs Prev"
        Me.ColumnHeader4.Width = 50
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(23, 148)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(308, 833)
        Me.ListBox1.TabIndex = 32
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblAddress.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(649, 243)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(95, 15)
        Me.lblAddress.TabIndex = 33
        Me.lblAddress.Text = "GrowerAddress"
        '
        'lblGrowerCity
        '
        Me.lblGrowerCity.AutoSize = True
        Me.lblGrowerCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblGrowerCity.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblGrowerCity.Location = New System.Drawing.Point(649, 268)
        Me.lblGrowerCity.Name = "lblGrowerCity"
        Me.lblGrowerCity.Size = New System.Drawing.Size(75, 15)
        Me.lblGrowerCity.TabIndex = 34
        Me.lblGrowerCity.Text = "GrowerCity"
        '
        'lblGrowerCountry
        '
        Me.lblGrowerCountry.AutoSize = True
        Me.lblGrowerCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblGrowerCountry.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblGrowerCountry.Location = New System.Drawing.Point(673, 316)
        Me.lblGrowerCountry.Name = "lblGrowerCountry"
        Me.lblGrowerCountry.Size = New System.Drawing.Size(99, 15)
        Me.lblGrowerCountry.TabIndex = 35
        Me.lblGrowerCountry.Text = "GrowerCountry"
        '
        'lblGrowerZip
        '
        Me.lblGrowerZip.AutoSize = True
        Me.lblGrowerZip.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblGrowerZip.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerZip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblGrowerZip.Location = New System.Drawing.Point(649, 315)
        Me.lblGrowerZip.Name = "lblGrowerZip"
        Me.lblGrowerZip.Size = New System.Drawing.Size(68, 15)
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
        Me.lblGrowerState.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblGrowerState.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrowerState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblGrowerState.Location = New System.Drawing.Point(649, 291)
        Me.lblGrowerState.Name = "lblGrowerState"
        Me.lblGrowerState.Size = New System.Drawing.Size(80, 15)
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
        Me.pbContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pbContact.Image = CType(resources.GetObject("pbContact.Image"), System.Drawing.Image)
        Me.pbContact.Location = New System.Drawing.Point(403, 104)
        Me.pbContact.Name = "pbContact"
        Me.pbContact.Size = New System.Drawing.Size(591, 383)
        Me.pbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbContact.TabIndex = 40
        Me.pbContact.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(636, 212)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 16)
        Me.lblName.TabIndex = 43
        Me.lblName.Text = "GrowerName"
        '
        'ckVendor1
        '
        Me.ckVendor1.AutoSize = True
        Me.ckVendor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor1.Location = New System.Drawing.Point(1117, 194)
        Me.ckVendor1.Name = "ckVendor1"
        Me.ckVendor1.Size = New System.Drawing.Size(97, 22)
        Me.ckVendor1.TabIndex = 44
        Me.ckVendor1.Text = "ckVendor1"
        Me.ckVendor1.UseVisualStyleBackColor = False
        '
        'ckVendor2
        '
        Me.ckVendor2.AutoSize = True
        Me.ckVendor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor2.Location = New System.Drawing.Point(1117, 227)
        Me.ckVendor2.Name = "ckVendor2"
        Me.ckVendor2.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor2.TabIndex = 45
        Me.ckVendor2.Text = "ckVendor2"
        Me.ckVendor2.UseVisualStyleBackColor = False
        '
        'ckVendor3
        '
        Me.ckVendor3.AutoSize = True
        Me.ckVendor3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor3.Location = New System.Drawing.Point(1117, 260)
        Me.ckVendor3.Name = "ckVendor3"
        Me.ckVendor3.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor3.TabIndex = 46
        Me.ckVendor3.Text = "ckVendor3"
        Me.ckVendor3.UseVisualStyleBackColor = False
        '
        'ckVendor4
        '
        Me.ckVendor4.AutoSize = True
        Me.ckVendor4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor4.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor4.Location = New System.Drawing.Point(1117, 293)
        Me.ckVendor4.Name = "ckVendor4"
        Me.ckVendor4.Size = New System.Drawing.Size(99, 22)
        Me.ckVendor4.TabIndex = 47
        Me.ckVendor4.Text = "ckVendor4"
        Me.ckVendor4.UseVisualStyleBackColor = False
        '
        'ckVendor5
        '
        Me.ckVendor5.AutoSize = True
        Me.ckVendor5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor5.Location = New System.Drawing.Point(1117, 326)
        Me.ckVendor5.Name = "ckVendor5"
        Me.ckVendor5.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor5.TabIndex = 48
        Me.ckVendor5.Text = "ckVendor5"
        Me.ckVendor5.UseVisualStyleBackColor = False
        '
        'ckVendor6
        '
        Me.ckVendor6.AutoSize = True
        Me.ckVendor6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor6.Location = New System.Drawing.Point(1117, 359)
        Me.ckVendor6.Name = "ckVendor6"
        Me.ckVendor6.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor6.TabIndex = 49
        Me.ckVendor6.Text = "ckVendor6"
        Me.ckVendor6.UseVisualStyleBackColor = False
        '
        'ckVendor7
        '
        Me.ckVendor7.AutoSize = True
        Me.ckVendor7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor7.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor7.Location = New System.Drawing.Point(1117, 392)
        Me.ckVendor7.Name = "ckVendor7"
        Me.ckVendor7.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor7.TabIndex = 50
        Me.ckVendor7.Text = "ckVendor7"
        Me.ckVendor7.UseVisualStyleBackColor = False
        '
        'ckVendor8
        '
        Me.ckVendor8.AutoSize = True
        Me.ckVendor8.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor8.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor8.Location = New System.Drawing.Point(1117, 425)
        Me.ckVendor8.Name = "ckVendor8"
        Me.ckVendor8.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor8.TabIndex = 51
        Me.ckVendor8.Text = "ckVendor8"
        Me.ckVendor8.UseVisualStyleBackColor = False
        '
        'btnAddNote
        '
        Me.btnAddNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAddNote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAddNote.Location = New System.Drawing.Point(1738, 147)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNote.TabIndex = 53
        Me.btnAddNote.Text = "Add"
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'TestDataGrid
        '
        Me.TestDataGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.TestDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDataGrid.ColumnHeadersVisible = False
        Me.TestDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Note})
        Me.TestDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TestDataGrid.Location = New System.Drawing.Point(1445, 212)
        Me.TestDataGrid.Name = "TestDataGrid"
        Me.TestDataGrid.RowHeadersVisible = False
        Me.TestDataGrid.RowTemplate.Height = 25
        Me.TestDataGrid.Size = New System.Drawing.Size(390, 659)
        Me.TestDataGrid.TabIndex = 54
        '
        'Note
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Note.DefaultCellStyle = DataGridViewCellStyle1
        Me.Note.HeaderText = ""
        Me.Note.MinimumWidth = 370
        Me.Note.Name = "Note"
        Me.Note.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Note.Width = 370
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(610, 241)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(610, 338)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 17)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(611, 364)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 19)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 58
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(448, 227)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(157, 154)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 59
        Me.PictureBox5.TabStop = False
        '
        'btnMissingButton
        '
        Me.btnMissingButton.Location = New System.Drawing.Point(13, 1000)
        Me.btnMissingButton.Name = "btnMissingButton"
        Me.btnMissingButton.Size = New System.Drawing.Size(95, 31)
        Me.btnMissingButton.TabIndex = 55
        Me.btnMissingButton.Text = "&Add Grower"
        Me.btnMissingButton.UseVisualStyleBackColor = True
        '
        'btnEditGrower
        '
        Me.btnEditGrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnEditGrower.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEditGrower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnEditGrower.Location = New System.Drawing.Point(150, 85)
        Me.btnEditGrower.Name = "btnEditGrower"
        Me.btnEditGrower.Size = New System.Drawing.Size(85, 23)
        Me.btnEditGrower.TabIndex = 70
        Me.btnEditGrower.Text = "Edit"
        Me.btnEditGrower.UseVisualStyleBackColor = False
        '
        'btnAddGrower
        '
        Me.btnAddGrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAddGrower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAddGrower.Location = New System.Drawing.Point(237, 85)
        Me.btnAddGrower.Name = "btnAddGrower"
        Me.btnAddGrower.Size = New System.Drawing.Size(91, 23)
        Me.btnAddGrower.TabIndex = 71
        Me.btnAddGrower.Text = "Add"
        Me.btnAddGrower.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Label1"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1415, 53)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(444, 916)
        Me.PictureBox6.TabIndex = 60
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(373, 604)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(454, 365)
        Me.PictureBox7.TabIndex = 73
        Me.PictureBox7.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(826, 605)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(602, 363)
        Me.PictureBox9.TabIndex = 75
        Me.PictureBox9.TabStop = False
        '
        'lvNonCGI
        '
        Me.lvNonCGI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvNonCGI.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvNonCGI.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lvNonCGI.HideSelection = False
        Me.lvNonCGI.Location = New System.Drawing.Point(857, 705)
        Me.lvNonCGI.MultiSelect = False
        Me.lvNonCGI.Name = "lvNonCGI"
        Me.lvNonCGI.ShowItemToolTips = True
        Me.lvNonCGI.Size = New System.Drawing.Size(536, 209)
        Me.lvNonCGI.TabIndex = 76
        Me.lvNonCGI.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Commodity"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Last Update"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sold To"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Volume"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Location"
        '
        'txtSale
        '
        Me.txtSale.BackColor = System.Drawing.Color.White
        Me.txtSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSale.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtSale.Location = New System.Drawing.Point(424, 658)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(86, 22)
        Me.txtSale.TabIndex = 77
        Me.txtSale.Text = "Sales"
        '
        'txtvendors
        '
        Me.txtvendors.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtvendors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtvendors.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtvendors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtvendors.Location = New System.Drawing.Point(1116, 148)
        Me.txtvendors.Name = "txtvendors"
        Me.txtvendors.Size = New System.Drawing.Size(100, 22)
        Me.txtvendors.TabIndex = 78
        Me.txtvendors.Text = "Vendors"
        '
        'txtProspect
        '
        Me.txtProspect.BackColor = System.Drawing.Color.White
        Me.txtProspect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProspect.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtProspect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtProspect.Location = New System.Drawing.Point(886, 658)
        Me.txtProspect.Name = "txtProspect"
        Me.txtProspect.Size = New System.Drawing.Size(183, 22)
        Me.txtProspect.TabIndex = 79
        Me.txtProspect.Text = "NonCGI Business"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotes.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtNotes.Location = New System.Drawing.Point(1469, 148)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(161, 22)
        Me.txtNotes.TabIndex = 80
        Me.txtNotes.Text = "Notes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(23, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 928)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'txtGrowers
        '
        Me.txtGrowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGrowers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrowers.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtGrowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtGrowers.Location = New System.Drawing.Point(32, 86)
        Me.txtGrowers.Name = "txtGrowers"
        Me.txtGrowers.Size = New System.Drawing.Size(161, 22)
        Me.txtGrowers.TabIndex = 82
        Me.txtGrowers.Text = "Growers"
        '
        'btnAddNonCGI
        '
        Me.btnAddNonCGI.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAddNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAddNonCGI.Location = New System.Drawing.Point(1296, 657)
        Me.btnAddNonCGI.Name = "btnAddNonCGI"
        Me.btnAddNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNonCGI.TabIndex = 83
        Me.btnAddNonCGI.Text = "&Add"
        Me.btnAddNonCGI.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PictureBox10.Location = New System.Drawing.Point(22, 53)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(1848, 928)
        Me.PictureBox10.TabIndex = 84
        Me.PictureBox10.TabStop = False
        '
        'btnEditNonCGI
        '
        Me.btnEditNonCGI.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnEditNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnEditNonCGI.Location = New System.Drawing.Point(1221, 657)
        Me.btnEditNonCGI.Name = "btnEditNonCGI"
        Me.btnEditNonCGI.Size = New System.Drawing.Size(75, 23)
        Me.btnEditNonCGI.TabIndex = 85
        Me.btnEditNonCGI.Text = "&Edit"
        Me.btnEditNonCGI.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1882, 982)
        Me.Controls.Add(Me.btnEditNonCGI)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.TestDataGrid)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.lvCommoditySales)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.txtvendors)
        Me.Controls.Add(Me.ckVendor8)
        Me.Controls.Add(Me.ckVendor6)
        Me.Controls.Add(Me.ckVendor7)
        Me.Controls.Add(Me.ckVendor5)
        Me.Controls.Add(Me.ckVendor4)
        Me.Controls.Add(Me.ckVendor3)
        Me.Controls.Add(Me.ckVendor2)
        Me.Controls.Add(Me.ckVendor1)
        Me.Controls.Add(Me.btnAddNonCGI)
        Me.Controls.Add(Me.txtProspect)
        Me.Controls.Add(Me.lvNonCGI)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblGrowerZip)
        Me.Controls.Add(Me.lblGrowerCountry)
        Me.Controls.Add(Me.lblGrowerState)
        Me.Controls.Add(Me.lblGrowerCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbContact)
        Me.Controls.Add(Me.btnEditGrower)
        Me.Controls.Add(Me.btnAddGrower)
        Me.Controls.Add(Me.txtGrowers)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGrowerPhone1)
        Me.Name = "FormMain"
        Me.Text = "Saturn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
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
    Friend WithEvents btnAddNote As Button
    Friend WithEvents TestDataGrid As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnMissingButton As Button
    Friend WithEvents btnEditGrower As Button
    Friend WithEvents btnAddGrower As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents lvNonCGI As ListView
    Friend WithEvents txtSale As TextBox
    Friend WithEvents txtvendors As TextBox
    Friend WithEvents txtProspect As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtGrowers As TextBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnAddNonCGI As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents btnEditNonCGI As Button
End Class
