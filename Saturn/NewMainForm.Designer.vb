<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMainForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GrowerFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerProspect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerCounty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerPhone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerAddress1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerZip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerPhone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowerComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtvendors = New System.Windows.Forms.TextBox()
        Me.ckVendor8 = New System.Windows.Forms.CheckBox()
        Me.ckVendor6 = New System.Windows.Forms.CheckBox()
        Me.ckVendor7 = New System.Windows.Forms.CheckBox()
        Me.ckVendor5 = New System.Windows.Forms.CheckBox()
        Me.ckVendor4 = New System.Windows.Forms.CheckBox()
        Me.ckVendor3 = New System.Windows.Forms.CheckBox()
        Me.ckVendor2 = New System.Windows.Forms.CheckBox()
        Me.ckVendor1 = New System.Windows.Forms.CheckBox()
        Me.txtGrowers = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.TestDataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.lvCommoditySales = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.lvNonCGI = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.txtProspect = New System.Windows.Forms.TextBox()
        Me.btnDeleteNonCGI = New System.Windows.Forms.Button()
        Me.btnEditNonCGI = New System.Windows.Forms.Button()
        Me.btnAddNonCGI = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFarmView = New System.Windows.Forms.Button()
        Me.btnCreateReminder = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GrowerFirstName, Me.GrowerLastName, Me.GrowerProspect, Me.GrowerCity, Me.GrowerCounty, Me.GrowerPhone1, Me.GrowerAddress1, Me.GrowerState, Me.GrowerZip, Me.GrowerCountry, Me.GrowerPhone2, Me.GrowerEmail, Me.GrowerFax, Me.GrowerAddress2, Me.GrowerComment})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(648, 263)
        Me.DataGridView1.TabIndex = 0
        '
        'GrowerFirstName
        '
        Me.GrowerFirstName.HeaderText = "First Name"
        Me.GrowerFirstName.Name = "GrowerFirstName"
        '
        'GrowerLastName
        '
        Me.GrowerLastName.HeaderText = "Last Name"
        Me.GrowerLastName.Name = "GrowerLastName"
        '
        'GrowerProspect
        '
        Me.GrowerProspect.HeaderText = "Prospect"
        Me.GrowerProspect.Name = "GrowerProspect"
        Me.GrowerProspect.ReadOnly = True
        '
        'GrowerCity
        '
        Me.GrowerCity.HeaderText = "City"
        Me.GrowerCity.Name = "GrowerCity"
        Me.GrowerCity.ReadOnly = True
        '
        'GrowerCounty
        '
        Me.GrowerCounty.HeaderText = "County"
        Me.GrowerCounty.Name = "GrowerCounty"
        Me.GrowerCounty.ReadOnly = True
        '
        'GrowerPhone1
        '
        Me.GrowerPhone1.HeaderText = "Phone1"
        Me.GrowerPhone1.Name = "GrowerPhone1"
        Me.GrowerPhone1.ReadOnly = True
        '
        'GrowerAddress1
        '
        Me.GrowerAddress1.HeaderText = "Address1"
        Me.GrowerAddress1.Name = "GrowerAddress1"
        '
        'GrowerState
        '
        Me.GrowerState.HeaderText = "State"
        Me.GrowerState.Name = "GrowerState"
        Me.GrowerState.ReadOnly = True
        '
        'GrowerZip
        '
        Me.GrowerZip.HeaderText = "Zip Code"
        Me.GrowerZip.Name = "GrowerZip"
        Me.GrowerZip.ReadOnly = True
        '
        'GrowerCountry
        '
        Me.GrowerCountry.HeaderText = "Country"
        Me.GrowerCountry.Name = "GrowerCountry"
        Me.GrowerCountry.ReadOnly = True
        '
        'GrowerPhone2
        '
        Me.GrowerPhone2.HeaderText = "Phone2"
        Me.GrowerPhone2.Name = "GrowerPhone2"
        Me.GrowerPhone2.ReadOnly = True
        '
        'GrowerEmail
        '
        Me.GrowerEmail.HeaderText = "Email"
        Me.GrowerEmail.Name = "GrowerEmail"
        Me.GrowerEmail.ReadOnly = True
        '
        'GrowerFax
        '
        Me.GrowerFax.HeaderText = "Fax"
        Me.GrowerFax.Name = "GrowerFax"
        Me.GrowerFax.ReadOnly = True
        '
        'GrowerAddress2
        '
        Me.GrowerAddress2.HeaderText = "Address2"
        Me.GrowerAddress2.Name = "GrowerAddress2"
        Me.GrowerAddress2.ReadOnly = True
        '
        'GrowerComment
        '
        Me.GrowerComment.HeaderText = "Comment"
        Me.GrowerComment.Name = "GrowerComment"
        Me.GrowerComment.ReadOnly = True
        '
        'txtvendors
        '
        Me.txtvendors.BackColor = System.Drawing.SystemColors.Control
        Me.txtvendors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtvendors.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtvendors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtvendors.Location = New System.Drawing.Point(739, 60)
        Me.txtvendors.Name = "txtvendors"
        Me.txtvendors.Size = New System.Drawing.Size(132, 22)
        Me.txtvendors.TabIndex = 79
        Me.txtvendors.Text = "Farm Names"
        '
        'ckVendor8
        '
        Me.ckVendor8.AutoSize = True
        Me.ckVendor8.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor8.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor8.Location = New System.Drawing.Point(739, 331)
        Me.ckVendor8.Name = "ckVendor8"
        Me.ckVendor8.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor8.TabIndex = 87
        Me.ckVendor8.Text = "ckVendor8"
        Me.ckVendor8.UseVisualStyleBackColor = False
        '
        'ckVendor6
        '
        Me.ckVendor6.AutoSize = True
        Me.ckVendor6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor6.Location = New System.Drawing.Point(739, 265)
        Me.ckVendor6.Name = "ckVendor6"
        Me.ckVendor6.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor6.TabIndex = 85
        Me.ckVendor6.Text = "ckVendor6"
        Me.ckVendor6.UseVisualStyleBackColor = False
        '
        'ckVendor7
        '
        Me.ckVendor7.AutoSize = True
        Me.ckVendor7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor7.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor7.Location = New System.Drawing.Point(739, 298)
        Me.ckVendor7.Name = "ckVendor7"
        Me.ckVendor7.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor7.TabIndex = 86
        Me.ckVendor7.Text = "ckVendor7"
        Me.ckVendor7.UseVisualStyleBackColor = False
        '
        'ckVendor5
        '
        Me.ckVendor5.AutoSize = True
        Me.ckVendor5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor5.Location = New System.Drawing.Point(739, 232)
        Me.ckVendor5.Name = "ckVendor5"
        Me.ckVendor5.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor5.TabIndex = 84
        Me.ckVendor5.Text = "ckVendor5"
        Me.ckVendor5.UseVisualStyleBackColor = False
        '
        'ckVendor4
        '
        Me.ckVendor4.AutoSize = True
        Me.ckVendor4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor4.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor4.Location = New System.Drawing.Point(739, 199)
        Me.ckVendor4.Name = "ckVendor4"
        Me.ckVendor4.Size = New System.Drawing.Size(99, 22)
        Me.ckVendor4.TabIndex = 83
        Me.ckVendor4.Text = "ckVendor4"
        Me.ckVendor4.UseVisualStyleBackColor = False
        '
        'ckVendor3
        '
        Me.ckVendor3.AutoSize = True
        Me.ckVendor3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor3.Location = New System.Drawing.Point(739, 166)
        Me.ckVendor3.Name = "ckVendor3"
        Me.ckVendor3.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor3.TabIndex = 82
        Me.ckVendor3.Text = "ckVendor3"
        Me.ckVendor3.UseVisualStyleBackColor = False
        '
        'ckVendor2
        '
        Me.ckVendor2.AutoSize = True
        Me.ckVendor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor2.Location = New System.Drawing.Point(739, 133)
        Me.ckVendor2.Name = "ckVendor2"
        Me.ckVendor2.Size = New System.Drawing.Size(98, 22)
        Me.ckVendor2.TabIndex = 81
        Me.ckVendor2.Text = "ckVendor2"
        Me.ckVendor2.UseVisualStyleBackColor = False
        '
        'ckVendor1
        '
        Me.ckVendor1.AutoSize = True
        Me.ckVendor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ckVendor1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckVendor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ckVendor1.Location = New System.Drawing.Point(739, 100)
        Me.ckVendor1.Name = "ckVendor1"
        Me.ckVendor1.Size = New System.Drawing.Size(97, 22)
        Me.ckVendor1.TabIndex = 80
        Me.ckVendor1.Text = "ckVendor1"
        Me.ckVendor1.UseVisualStyleBackColor = False
        '
        'txtGrowers
        '
        Me.txtGrowers.BackColor = System.Drawing.SystemColors.Control
        Me.txtGrowers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrowers.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtGrowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtGrowers.Location = New System.Drawing.Point(19, 60)
        Me.txtGrowers.Name = "txtGrowers"
        Me.txtGrowers.Size = New System.Drawing.Size(168, 22)
        Me.txtGrowers.TabIndex = 88
        Me.txtGrowers.Text = "Growers"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Control
        Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotes.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtNotes.Location = New System.Drawing.Point(1044, 61)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(159, 22)
        Me.txtNotes.TabIndex = 92
        Me.txtNotes.Text = "Notes"
        '
        'TestDataGrid
        '
        Me.TestDataGrid.AllowUserToResizeColumns = False
        Me.TestDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TestDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.TestDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestDataGrid.ColumnHeadersVisible = False
        Me.TestDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.TestDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TestDataGrid.Location = New System.Drawing.Point(1002, 95)
        Me.TestDataGrid.Name = "TestDataGrid"
        Me.TestDataGrid.RowHeadersVisible = False
        Me.TestDataGrid.RowTemplate.Height = 25
        Me.TestDataGrid.Size = New System.Drawing.Size(317, 537)
        Me.TestDataGrid.TabIndex = 90
        '
        'Column1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 385
        '
        'btnAddNote
        '
        Me.btnAddNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAddNote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAddNote.Location = New System.Drawing.Point(1393, 30)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(83, 10)
        Me.btnAddNote.TabIndex = 89
        Me.btnAddNote.Text = "Add"
        Me.btnAddNote.UseVisualStyleBackColor = False
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
        Me.lvCommoditySales.Location = New System.Drawing.Point(16, 444)
        Me.lvCommoditySales.Margin = New System.Windows.Forms.Padding(7)
        Me.lvCommoditySales.Name = "lvCommoditySales"
        Me.lvCommoditySales.Scrollable = False
        Me.lvCommoditySales.Size = New System.Drawing.Size(445, 188)
        Me.lvCommoditySales.TabIndex = 93
        Me.lvCommoditySales.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Commodity"
        Me.ColumnHeader1.Width = 208
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cur Crop Year"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prev Crop Year"
        Me.ColumnHeader3.Width = 76
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "2 Yrs Prev"
        Me.ColumnHeader4.Width = 78
        '
        'lvNonCGI
        '
        Me.lvNonCGI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvNonCGI.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvNonCGI.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lvNonCGI.FullRowSelect = True
        Me.lvNonCGI.GridLines = True
        Me.lvNonCGI.HideSelection = False
        Me.lvNonCGI.Location = New System.Drawing.Point(481, 444)
        Me.lvNonCGI.MultiSelect = False
        Me.lvNonCGI.Name = "lvNonCGI"
        Me.lvNonCGI.ShowItemToolTips = True
        Me.lvNonCGI.Size = New System.Drawing.Size(536, 188)
        Me.lvNonCGI.TabIndex = 94
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
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Location"
        Me.ColumnHeader10.Width = 80
        '
        'txtSale
        '
        Me.txtSale.BackColor = System.Drawing.SystemColors.Control
        Me.txtSale.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSale.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtSale.Location = New System.Drawing.Point(28, 412)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(86, 22)
        Me.txtSale.TabIndex = 95
        Me.txtSale.Text = "Sales"
        '
        'txtProspect
        '
        Me.txtProspect.BackColor = System.Drawing.SystemColors.Control
        Me.txtProspect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProspect.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtProspect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.txtProspect.Location = New System.Drawing.Point(481, 412)
        Me.txtProspect.Name = "txtProspect"
        Me.txtProspect.Size = New System.Drawing.Size(183, 22)
        Me.txtProspect.TabIndex = 96
        Me.txtProspect.Text = "NonCGI Business"
        '
        'btnDeleteNonCGI
        '
        Me.btnDeleteNonCGI.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnDeleteNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnDeleteNonCGI.Location = New System.Drawing.Point(927, 411)
        Me.btnDeleteNonCGI.Name = "btnDeleteNonCGI"
        Me.btnDeleteNonCGI.Size = New System.Drawing.Size(85, 23)
        Me.btnDeleteNonCGI.TabIndex = 106
        Me.btnDeleteNonCGI.Text = "&Delete"
        Me.btnDeleteNonCGI.UseVisualStyleBackColor = False
        '
        'btnEditNonCGI
        '
        Me.btnEditNonCGI.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnEditNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnEditNonCGI.Location = New System.Drawing.Point(840, 411)
        Me.btnEditNonCGI.Name = "btnEditNonCGI"
        Me.btnEditNonCGI.Size = New System.Drawing.Size(85, 23)
        Me.btnEditNonCGI.TabIndex = 105
        Me.btnEditNonCGI.Text = "&Edit"
        Me.btnEditNonCGI.UseVisualStyleBackColor = False
        '
        'btnAddNonCGI
        '
        Me.btnAddNonCGI.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAddNonCGI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAddNonCGI.Location = New System.Drawing.Point(753, 411)
        Me.btnAddNonCGI.Name = "btnAddNonCGI"
        Me.btnAddNonCGI.Size = New System.Drawing.Size(85, 23)
        Me.btnAddNonCGI.TabIndex = 104
        Me.btnAddNonCGI.Text = "&Add"
        Me.btnAddNonCGI.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1271, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnFarmView
        '
        Me.btnFarmView.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnFarmView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnFarmView.Location = New System.Drawing.Point(997, 12)
        Me.btnFarmView.Name = "btnFarmView"
        Me.btnFarmView.Size = New System.Drawing.Size(115, 23)
        Me.btnFarmView.TabIndex = 111
        Me.btnFarmView.Text = "Farm View"
        Me.btnFarmView.UseVisualStyleBackColor = False
        '
        'btnCreateReminder
        '
        Me.btnCreateReminder.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnCreateReminder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCreateReminder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreateReminder.Location = New System.Drawing.Point(1144, 12)
        Me.btnCreateReminder.Name = "btnCreateReminder"
        Me.btnCreateReminder.Size = New System.Drawing.Size(115, 23)
        Me.btnCreateReminder.TabIndex = 110
        Me.btnCreateReminder.Text = "Create a Reminder"
        Me.btnCreateReminder.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCreateReminder.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnLogOut.Location = New System.Drawing.Point(1291, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 109
        Me.btnLogOut.Text = "Log Off"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'NewMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 644)
        Me.Controls.Add(Me.btnFarmView)
        Me.Controls.Add(Me.btnCreateReminder)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDeleteNonCGI)
        Me.Controls.Add(Me.btnEditNonCGI)
        Me.Controls.Add(Me.btnAddNonCGI)
        Me.Controls.Add(Me.txtProspect)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.lvNonCGI)
        Me.Controls.Add(Me.lvCommoditySales)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.TestDataGrid)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.txtGrowers)
        Me.Controls.Add(Me.ckVendor8)
        Me.Controls.Add(Me.ckVendor6)
        Me.Controls.Add(Me.ckVendor7)
        Me.Controls.Add(Me.ckVendor5)
        Me.Controls.Add(Me.ckVendor4)
        Me.Controls.Add(Me.ckVendor3)
        Me.Controls.Add(Me.ckVendor2)
        Me.Controls.Add(Me.ckVendor1)
        Me.Controls.Add(Me.txtvendors)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NewMainForm"
        Me.Text = "NewMainForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GrowerFirstName As DataGridViewTextBoxColumn
    Friend WithEvents GrowerLastName As DataGridViewTextBoxColumn
    Friend WithEvents GrowerProspect As DataGridViewTextBoxColumn
    Friend WithEvents GrowerCity As DataGridViewTextBoxColumn
    Friend WithEvents GrowerCounty As DataGridViewTextBoxColumn
    Friend WithEvents GrowerPhone1 As DataGridViewTextBoxColumn
    Friend WithEvents GrowerAddress1 As DataGridViewTextBoxColumn
    Friend WithEvents GrowerState As DataGridViewTextBoxColumn
    Friend WithEvents GrowerZip As DataGridViewTextBoxColumn
    Friend WithEvents GrowerCountry As DataGridViewTextBoxColumn
    Friend WithEvents GrowerPhone2 As DataGridViewTextBoxColumn
    Friend WithEvents GrowerEmail As DataGridViewTextBoxColumn
    Friend WithEvents GrowerFax As DataGridViewTextBoxColumn
    Friend WithEvents GrowerAddress2 As DataGridViewTextBoxColumn
    Friend WithEvents GrowerComment As DataGridViewTextBoxColumn
    Friend WithEvents txtvendors As TextBox
    Friend WithEvents ckVendor8 As CheckBox
    Friend WithEvents ckVendor6 As CheckBox
    Friend WithEvents ckVendor7 As CheckBox
    Friend WithEvents ckVendor5 As CheckBox
    Friend WithEvents ckVendor4 As CheckBox
    Friend WithEvents ckVendor3 As CheckBox
    Friend WithEvents ckVendor2 As CheckBox
    Friend WithEvents ckVendor1 As CheckBox
    Friend WithEvents txtGrowers As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents TestDataGrid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddNote As Button
    Friend WithEvents lvCommoditySales As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lvNonCGI As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents txtSale As TextBox
    Friend WithEvents txtProspect As TextBox
    Friend WithEvents btnDeleteNonCGI As Button
    Friend WithEvents btnEditNonCGI As Button
    Friend WithEvents btnAddNonCGI As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFarmView As Button
    Friend WithEvents btnCreateReminder As Button
    Friend WithEvents btnLogOut As Button
End Class
