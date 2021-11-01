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
        Me.cbxVendors = New System.Windows.Forms.CheckedListBox()
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
        Me.lvCommoditySales.Location = New System.Drawing.Point(909, 439)
        Me.lvCommoditySales.Margin = New System.Windows.Forms.Padding(7)
        Me.lvCommoditySales.Name = "lvCommoditySales"
        Me.lvCommoditySales.Scrollable = False
        Me.lvCommoditySales.Size = New System.Drawing.Size(876, 414)
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
        'cbxVendors
        '
        Me.cbxVendors.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cbxVendors.CheckOnClick = True
        Me.cbxVendors.ForeColor = System.Drawing.Color.Snow
        Me.cbxVendors.FormattingEnabled = True
        Me.cbxVendors.Location = New System.Drawing.Point(421, 481)
        Me.cbxVendors.Name = "cbxVendors"
        Me.cbxVendors.Size = New System.Drawing.Size(398, 148)
        Me.cbxVendors.TabIndex = 16
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
        Me.lblAddress.Location = New System.Drawing.Point(608, 151)
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
        Me.lblGrowerCity.Location = New System.Drawing.Point(609, 176)
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
        Me.lblGrowerCountry.Location = New System.Drawing.Point(609, 228)
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
        Me.lblGrowerZip.Location = New System.Drawing.Point(700, 228)
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
        Me.lblGrowerPhone1.Location = New System.Drawing.Point(609, 253)
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
        Me.lblGrowerState.Location = New System.Drawing.Point(608, 201)
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
        Me.pbContact.Location = New System.Drawing.Point(344, -16)
        Me.pbContact.Name = "pbContact"
        Me.pbContact.Size = New System.Drawing.Size(568, 424)
        Me.pbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbContact.TabIndex = 40
        Me.pbContact.TabStop = False
        '
        'pbGrowerPicture
        '
        Me.pbGrowerPicture.Image = CType(resources.GetObject("pbGrowerPicture.Image"), System.Drawing.Image)
        Me.pbGrowerPicture.Location = New System.Drawing.Point(443, 151)
        Me.pbGrowerPicture.Name = "pbGrowerPicture"
        Me.pbGrowerPicture.Size = New System.Drawing.Size(119, 134)
        Me.pbGrowerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbGrowerPicture.TabIndex = 41
        Me.pbGrowerPicture.TabStop = False
        '
        'lvNotes
        '
        Me.lvNotes.HideSelection = False
        Me.lvNotes.Location = New System.Drawing.Point(948, 23)
        Me.lvNotes.Name = "lvNotes"
        Me.lvNotes.Size = New System.Drawing.Size(458, 385)
        Me.lvNotes.TabIndex = 42
        Me.lvNotes.UseCompatibleStateImageBehavior = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1855, 887)
        Me.Controls.Add(Me.lvNotes)
        Me.Controls.Add(Me.lvCommoditySales)
        Me.Controls.Add(Me.cbxVendors)
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
    Friend WithEvents cbxVendors As CheckedListBox
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
End Class
