Option Strict Off
Imports System.Data.SqlClient


Public Class FormMain

    Inherits System.Windows.Forms.Form


    Dim oConn As New SqlConnection
    Dim myCmd As SqlCommand
    Dim oGrwoerCmd As SqlCommand
    Dim oReader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable()
    Dim results As String
    'Dim oGrowerAddressColl As New Collection
    'Dim oGrowerCityColl As New Collection
    'Dim oGrowerStateColl As New Collection
    'Dim oGrowerCountryColl As New Collection
    'Dim oGrowerZipColl As New Collection
    'Dim oGrowerPhone1Coll As New Collection
    'Dim oVendorNameColl As New Collection
    'Dim oVendorIDColl As New Collection
    'Dim Params As New List(Of SqlParameter)



    Dim oGrowerColl As New Collection


    Public Property DataGridView1 As Object
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Dim sSql As String
        Dim iGrowerID As Integer
        Dim iVendorID As Integer
        Dim sCommID As String
        Dim oCollGrowVendComm As New Collection
        Dim iMax As Integer
        Dim iCnt As Integer
        'Dim iNoteId As Integer
        Dim iNum As Integer
        Dim bAddNote As Boolean



        Me.Text = "Saturn" & " : " & "User: " & GlobalVariables.UserFirstName & " " & GlobalVariables.UserLastName & " : " & "Facility: " & GlobalVariables.UserFacility
        oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        myCmd = oConn.CreateCommand
        'sSql = "SELECT growers.grower_id, vendors.vendor_id, ISNULL(grower_first_name,''), ISNULL(grower_address_line_1,''), "
        'sSql = sSql & "ISNULL(grower_city,''), ISNULL(grower_county,''), ISNULL(grower_state,''), ISNULL(grower_zip,''), ISNULL(grower_country,''), ISNULL(grower_phone1,''), "
        'sSql = sSql & "ISNULL(vendor_name,''), ISNULL(commodities.commodity_id,''), ISNULL(commodity_name,''), "
        'sSql = sSql & "ISNULL(current_crop_year_volume, 0), ISNULL(previous_crop_year_volume, 0), ISNULL(previous2_crop_year_volume, 0) "
        'sSql = sSql & "FROM growers, growers_vendors, vendors, vendors_facilities, users, commodities, vendors_commodities, vendor_sales_volume "
        'sSql = sSql & "WHERE user_id = " & GlobalVariables.UserId.ToString() & " "
        'sSql = sSql & "AND vendors_facilities.facility_id = User_facility_id "
        'sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
        'sSql = sSql & "AND growers_vendors.grower_id = growers.grower_id "
        'sSql = sSql & "AND vendors.vendor_id = growers_vendors.vendor_id "
        'sSql = sSql & "AND commodities.commodity_id = vendors_commodities.commodity_id "
        'sSql = sSql & "AND vendors.vendor_id = vendors_commodities.vendor_id "
        'sSql = sSql & "AND commodities.commodity_id = vendor_sales_volume.commodity_id "
        'sSql = sSql & "AND vendors.agtech_vendor_id= vendor_sales_volume.agtech_vendor_id "
        'sSql = sSql & "ORDER BY growers.grower_id, vendors.vendor_id, commodity_name"

        'Select Case growers.grower_id, vendors.vendor_id, NVL(grower_first_name,''), NVL(grower_address_line_1,''),
        'NVL(grower_city,''), NVL(grower_county,''), NVL(grower_state,''), NVL(grower_zip,''), NVL(grower_country,''), NVL(grower_phone1,''),
        'NVL(vendor_name,''), NVL(commodities.commodity_id,''), NVL(commodity_name,''),
        'NVL(current_crop_year_volume, 0), NVL(previous_crop_year_volume, 0), NVL(previous2_crop_year_volume, 0), NVL(grower_note_id, 0), NVL(grower_note_text, '')
        'From growers, growers_vendors, vendors, vendors_facilities, users, commodities, vendors_commodities, vendor_sales_volume, facilities, grower_notes
        'Where user_id = 339
        'And facilities.facility_id = User_facility_id
        'And vendors_facilities.facility_id (+)= facilities.facility_id
        'And vendors_facilities.vendor_id (+)= vendors.vendor_id
        'And growers_vendors.grower_id = growers.grower_id
        'And vendors.vendor_id = growers_vendors.vendor_id
        'And commodity_id = vendors_commodities.commodity_id
        'And vendors.vendor_id = vendors_commodities.vendor_id
        'And vendor_sales_volume.commodity_id (+)= commodity_id
        'And vendor_sales_volume.agtech_vendor_id (+)= vendors.agtech_vendor_id
        'And grower_notes.grower_id (+)= growers.grower_id
        'ORDER BY growers.grower_id, vendors.vendor_id, commodity_name, grower_note_id

        sSql = "SELECT GROWERS.GROWER_ID, VENDORS.VENDOR_ID, ISNULL(GROWER_FIRST_NAME, ''), "
        sSql = sSql & "ISNULL(GROWER_ADDRESS_LINE_1, ''), ISNULL(GROWER_CITY, ''), ISNULL(GROWER_COUNTY, ''), "
        sSql = sSql & "ISNULL(GROWER_STATE, ''), ISNULL(GROWER_ZIP, ''), ISNULL(GROWER_COUNTRY, ''), "
        sSql = sSql & "ISNULL(GROWER_PHONE1, ''), ISNULL(VENDOR_NAME, ''), ISNULL(COM.COMMODITY_ID, ''), "
        sSql = sSql & "ISNULL(COMMODITY_NAME, ''), ISNULL(CURRENT_CROP_YEAR_VOLUME, 0), ISNULL(PREVIOUS_CROP_YEAR_VOLUME, 0), "
        sSql = sSql & "ISNULL(PREVIOUS2_CROP_YEAR_VOLUME, 0), ISNULL(GROWER_NOTE_ID, 0), ISNULL(GROWER_NOTE_CREATION_DATE, ''), ISNULL(GROWER_NOTE_SUBJECT, ''),  "
        sSql = sSql & "ISNULL(GROWER_NOTE_METHOD, ''), ISNULL(GROWER_NOTE_TEXT, ''), ISNULL(GROWER_NOTE_CREATED_BY, 0) "
        sSql = sSql & "FROM GROWERS "
        sSql = sSql & "LEFT OUTER JOIN GROWER_NOTES "
        sSql = sSql & "ON GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "INNER Join GROWERS_VENDORS "
        sSql = sSql & "ON GROWERS_VENDORS.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "INNER JOIN( "
        sSql = sSql & "VENDORS "
        sSql = sSql & "LEFT OUTER JOIN VENDOR_SALES_VOLUME "
        sSql = sSql & "ON VENDOR_SALES_VOLUME.AGTECH_VENDOR_ID = VENDORS.AGTECH_VENDOR_ID "
        sSql = sSql & "INNER JOIN VENDORS_COMMODITIES "
        sSql = sSql & "ON VENDORS.VENDOR_ID = VENDORS_COMMODITIES.VENDOR_ID "
        sSql = sSql & "LEFT OUTER JOIN ( "
        sSql = sSql & "VENDORS_FACILITIES "
        sSql = sSql & "RIGHT OUTER JOIN FACILITIES "
        sSql = sSql & "ON VENDORS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        sSql = sSql & ") "
        sSql = sSql & "ON VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        sSql = sSql & ") "
        sSql = sSql & "ON VENDORS.VENDOR_ID = GROWERS_VENDORS.VENDOR_ID "
        sSql = sSql & "CROSS Join USERS "
        sSql = sSql & "CROSS Join COMMODITIES com "
        sSql = sSql & "WHERE( "
        sSql = sSql & "USER_ID = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "AND FACILITIES.FACILITY_ID = USER_FACILITY_ID "
        sSql = sSql & "AND com.COMMODITY_ID = VENDORS_COMMODITIES.COMMODITY_ID "
        sSql = sSql & "AND VENDOR_SALES_VOLUME.COMMODITY_ID = com.COMMODITY_ID "
        sSql = sSql & ") "
        sSql = sSql & "ORDER BY GROWERS.GROWER_ID, VENDORS.VENDOR_ID, COMMODITY_NAME, GROWER_NOTE_ID"

        myCmd.CommandText = sSql
        oConn.Open()

        oReader = myCmd.ExecuteReader()

        iGrowerID = -1

        If oReader.HasRows Then
            iNum = 1
            Do While oReader.Read()
                Dim oGVC As New GrowVendCom
                oGVC.GrowerID = oReader.GetInt32(0)
                oGVC.VendorId = oReader.GetInt32(1)
                oGVC.GrowerFirstName = oReader.GetString(2)
                oGVC.GrowerAddress1 = oReader.GetString(3)
                oGVC.GrowerCity = oReader.GetString(4)
                oGVC.GrowerCounty = oReader.GetString(5)
                oGVC.GrowerState = oReader.GetString(6)
                oGVC.GrowerZip = oReader.GetString(7)
                oGVC.GrowerCountry = oReader.GetString(8)
                oGVC.GrowerPhone1 = oReader.GetString(9)
                oGVC.VendorName = oReader.GetString(10)
                oGVC.CommID = oReader.GetString(11)
                oGVC.CommName = oReader.GetString(12)
                oGVC.CurrentCropYear = oReader.GetDecimal(13)
                oGVC.PreviousCropYear = oReader.GetDecimal(14)
                oGVC.Previous2CropYear = oReader.GetDecimal(15)
                oGVC.GrowerNoteId = oReader.GetInt32(16)
                oGVC.GrowerNoteCreationDate = oReader.GetDateTime(17)
                oGVC.GrowerNoteSubject = oReader.GetString(18)
                oGVC.GrowerNoteMethod = oReader.GetString(19)
                oGVC.GrowerNoteText = oReader.GetString(20)
                oGVC.GrowerNoteCreatedBy = oReader.GetInt32(21)

                oCollGrowVendComm.Add(oGVC, oGVC.GrowerID.ToString() & oGVC.VendorId.ToString() & oGVC.CommID.ToString() & iNum.ToString())
                iNum = iNum + 1
            Loop
        End If
        oReader.Close()
        oReader = Nothing
        iMax = oCollGrowVendComm.Count
        iCnt = 1

        Do While iCnt <= iMax
            If oCollGrowVendComm(iCnt).GrowerId <> iGrowerID Then
                ListBox1.Items.Add(oCollGrowVendComm(iCnt).GrowerFirstName)
                iGrowerID = oCollGrowVendComm(iCnt).GrowerId
                Dim oGrower As New Grower()
                oGrower.GrowerFirstName = oCollGrowVendComm(iCnt).GrowerFirstName
                oGrower.GrowerID = oCollGrowVendComm(iCnt).GrowerId
                oGrower.GrowerAddress1 = oCollGrowVendComm(iCnt).GrowerAddress1
                oGrower.GrowerCity = oCollGrowVendComm(iCnt).GrowerCity
                oGrower.GrowerState = oCollGrowVendComm(iCnt).GrowerState
                oGrower.GrowerCountry = oCollGrowVendComm(iCnt).GrowerCountry
                oGrower.GrowerZip = oCollGrowVendComm(iCnt).GrowerZip
                oGrower.GrowerPhone1 = oCollGrowVendComm(iCnt).GrowerPhone1


                iVendorID = -1
                Do While iGrowerID = oCollGrowVendComm(iCnt).GrowerId

                    If iVendorID <> oCollGrowVendComm(iCnt).VendorId Then
                        iVendorID = oCollGrowVendComm(iCnt).VendorId

                        Dim oVendor As New Vendor()
                        oVendor.VendorName = oCollGrowVendComm(iCnt).VendorName
                        oVendor.VendorID = iVendorID
                        'oGrower.Vendors.Add(oVendor)
                        sCommID = ""
                        Do While iVendorID = oCollGrowVendComm(iCnt).VendorID And iGrowerID = oCollGrowVendComm(iCnt).GrowerId

                            sCommID = oCollGrowVendComm(iCnt).CommID
                            Dim oComm As New Commodity
                            oComm.CommID = sCommID
                            oComm.CommName = oCollGrowVendComm(iCnt).CommName
                            oComm.CurrentCropYear = oCollGrowVendComm(iCnt).CurrentCropYear
                            oComm.PreviousCropYear = oCollGrowVendComm(iCnt).PreviousCropYear
                            oComm.Previous2CropYear = oCollGrowVendComm(iCnt).Previous2CropYear
                            oVendor.CollCommodities.Add(oComm)
                            iCnt = iCnt + 1
                            If iCnt >= iMax Then

                                Exit Do
                            End If

                        Loop
                        oGrower.Vendors.Add(oVendor)

                    End If
                    iCnt = iCnt + 1
                    If iCnt >= iMax Then
                        oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())
                        Exit Do
                    End If
                Loop
                If iCnt <= iMax Then
                    If iGrowerID <> oCollGrowVendComm(iCnt).GrowerId Then
                        oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())
                        'iCnt = iCnt - 1 'Move the pointer back one so the outside loop can advance to the next record
                    End If
                End If
            Else
                iCnt = iCnt + 1
            End If
        Loop

        iCnt = 1
        iGrowerID = -1
        Do While iCnt <= iMax
            If oCollGrowVendComm(iCnt).GrowerId <> iGrowerID Then
                iGrowerID = oCollGrowVendComm(iCnt).GrowerId
                Do While iGrowerID = oCollGrowVendComm(iCnt).GrowerId
                    Dim oNote As New Note
                    bAddNote = False
                    If oCollGrowVendComm(iCnt).GrowerNoteId <> 0 Then
                        '                    iNoteId = oCollGrowVendComm(iCnt).GrowerNoteId
                        If Not oGrowerColl(oCollGrowVendComm(iCnt).GrowerId.ToString()).Notes.Contains(oCollGrowVendComm(iCnt).GrowerNoteId.ToString()) Then
                            bAddNote = True
                            oNote.GrowerNoteId = oCollGrowVendComm(iCnt).GrowerNoteId
                            oNote.GrowerNoteCreationDate = oCollGrowVendComm(iCnt).GrowerNoteCreationDate
                            oNote.GrowerNoteCreatedBy = oCollGrowVendComm(iCnt).GrowerNoteCreatedBy
                            oNote.GrowerNoteSubject = oCollGrowVendComm(iCnt).GrowerNoteSubject
                            oNote.GrowerNoteMethod = oCollGrowVendComm(iCnt).GrowerNoteMethod
                            oNote.GrowerNoteText = oCollGrowVendComm(iCnt).GrowerNoteText
                            oGrowerColl(oCollGrowVendComm(iCnt).GrowerId.ToString()).Notes.Add(oNote, oNote.GrowerNoteId.ToString())

                        End If
                    End If
                    iCnt = iCnt + 1
                    If iCnt > iMax Then
                        If bAddNote Then
                            oGrowerColl(oCollGrowVendComm(iCnt).GrowerId.ToString()).Notes.Items.Add(oNote, oNote.GrowerNoteId.ToString())
                        End If
                        Exit Do
                    End If
                Loop
            End If
            iCnt = iCnt + 1
        Loop
        '                oGrowerAddressColl.Add(oReader.GetString(3))
        '            oGrowerCityColl.Add(oReader.GetString(4))
        '            oGrowerStateColl.Add(oReader.GetString(6))
        '            oGrowerCountryColl.Add(oReader.GetString(8))
        '            oGrowerZipColl.Add(oReader.GetString(7))
        '            oGrowerPhone1Coll.Add(oReader.GetString(9))
        '            iVendorID = -1
        '            If oReader.GetInt32(1) <> iVendorID Then
        '                iVendorID = oReader.GetInt32(1)
        '                oVendorNameColl.Add(oReader.GetString(10))
        '                oVendorIDColl.Add(oReader.GetString(1))
        '            End If

        '        End If

        '    Loop
        'End If

        'bNewGrower = False
        ' '        If oReader.HasRows Then
        ' '               Do While oReader.Read()
        ' 'If Not bNewGrower Then
        ' ' If oReader.Read() = False Then
        ' ' Exit Do
        ' ' End If
        ' ' End If
        '
        '        'Do While oReader.Read()
        '        If oReader.GetInt32(0) <> iGrowerID Then
        '        bNewGrower = True
        '        ListBox1.Items.Add(oReader.GetString(2))
        '        iGrowerID = oReader.GetInt32(0)
        '        Dim oGrower As New Grower()'
        '
        '        oGrower.GrowerAddress1 = oReader.GetString(3)
        '        oGrower.GrowerCity = oReader.GetString(4)
        '        oGrower.GrowerState = oReader.GetString(6)
        '        oGrower.GrowerCountry = oReader.GetString(8)
        '        oGrower.GrowerZip = oReader.GetString(7)
        '        oGrower.GrowerPhone1 = oReader.GetString(9)
        '        iVendorID = -1'
        '
        ''        Do While iGrowerID = oReader.GetInt32(0)
        '      bNewGrower = False
        '      If iVendorID <> oReader.GetInt32(1) Then
        '      iVendorID = oReader.GetInt32(1)
        '      Dim oVendor As New Vendor()
        '      oVendor.VandorName = oReader.GetString(10)
        '      oVendor.VendorID = iVendorID
        '      oGrower.Vendors.Add(oVendor)
        '
        '        End If
        '        If oReader.Read() = False Then
        '        Exit Do
        '        End If
        '        'iGrowerID = oReader.GetInt32(0)'

        'Loop
        ' oGrowerColl.Add(oGrower)
        ' bNewGrower = True
        ' End If
        ''


        '        Loop
        '        End If

        'oReader.Close()

        oConn.Close()
        If ListBox1.Items.Count >= 1 Then
            ListBox1.SetSelected(0, True)
        End If
    End Sub


    'Join growers_temp to vendors_tem using Relationships_temp table as intersection table 



    'adapter = New SqlDataAdapter("SELECT grower_first_name FROM growers_temp", oConn)
    'Dim table As New DataTable()
    'adapter.Fill(table)
    'dgvGrowers.DataSource = table






    'bValid = ValidateActiveDirectoryLogin("columbiagrain.com", "jschwartz", "")
    'If bValid Then
    'TextBox1.Text = "Valid"
    'Else
    ' TextBox1.Text = "Invalid"
    ' End If
    'sTest = "Tayebeh Soltaninejad" & vbCrLf & "503-452-3212" & vbCrLf & "tsoltani@columbiagrain.com"
    'ListBox1.Items.Add(sTest)



    '    myReader = myCmd.ExecuteReader()
    '    If myReader.HasRows Then

    '        Do While myReader.Read()
    '            Dim query_result As String
    '            query_result = myReader("grower_first_name")
    '            'MsgBox(query_result)
    '            MessageBox.Show(query_result)
    '        Loop
    '    Else
    '        MessageBox.Show("No results found.")
    '    End If
    'End Sub



    'Private Sub dgvGrowers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrowers.CellClick
    ' If e.RowIndex >= 0 Then
    ' Dim row As DataGridViewRow = dgvGrowers.Rows(e.RowIndex)
    '         txtGrowerName.Text = row.Cells(1).Value.ToString
    '         txtGrowerAddress.Text = row.Cells(3).Value.ToString & ","
    '         txtGrowerCity.Text = row.Cells(5).Value.ToString
    '         txtGrowerState.Text = row.Cells(7).Value.ToString
    '         txtGrowerZip.Text = row.Cells(8).Value.ToString
    '         txtGrowerCountry.Text = row.Cells(9).Value.ToString
    '         txtGrowerPhone.Text = row.Cells(10).Value.ToString
    ' End If
    ' End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim iCnt As Integer
        Dim iMax As Integer
        'Dim ilvCnt As Integer
        'Dim iLvMax As Integer
        'Dim oCurVendor As Vendor
        'MessageBox.Show(ListBox1.SelectedIndex.ToString())
        If ListBox1.SelectedIndex >= 0 Then
            lblName.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerFirstName.ToString()
            lblAddress.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerAddress1.ToString()
            lblGrowerCity.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerCity.ToString()
            lblGrowerState.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerState.ToString()
            lblGrowerCountry.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerCountry.ToString()
            lblGrowerZip.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerZip.ToString()
            lblGrowerPhone1.Text = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerPhone1.ToString()
            iCnt = 1
            iMax = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors.Count
            cbxVendors.Items.Clear()
            Do While iCnt <= iMax
                'oCurVendor = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt)
                cbxVendors.Items.Add(oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName)
                cbxVendors.SetItemChecked((iCnt - 1), True)
                'cbxVendors.Items.Add(oCurVendor.VendorName)
                iCnt = iCnt + 1
            Loop
            lvNotes.Clear()
            For Each oNote In oGrowerColl(ListBox1.SelectedIndex + 1).Notes
                Dim oLVI As New ListViewItem
                oLVI.SubItems(0).Text = oNote.GrowerNoteText

                oLVI.SubItems.Add(oNote.GrowerNoteCreationDate)
                oLVI.SubItems.Add(oNote.GrowerNoteCreatedBy)
                oLVI.SubItems.Add(oNote.GrowerNoteSubject)
                oLVI.SubItems.Add(oNote.GrowerNoteMethod)
                lvNotes.Items.Add(oLVI)
            Next
        End If
        If cbxVendors.Items.Count >= 1 Then
            cbxVendors.SetSelected(0, True)

        End If


    End Sub




    Private Sub cbxVendors_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles cbxVendors.ItemCheck

        Dim liIndex As Integer
        Dim loCollCommList As New Collection
        Dim loCurComm As Commodity
        Dim liCnt As Integer
        Dim liCommCnt As Integer
        Dim liCommMax As Integer
        Dim liMax As Integer
        Dim lbCommFound As Boolean
        Dim lsCurCommId As String
        Dim lsCurCommName As String
        Dim lsCurCropYear As String
        Dim lsPrevCropYear As String
        Dim lsPrev2CropYear As String


        lbCommFound = False

        liCnt = 1
        liMax = 2

        'Do While liCnt <= liMax
        For Each liIndex In cbxVendors.CheckedIndices
            liCommCnt = 1
            liCommMax = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities.Count
            Do While liCommCnt <= liCommMax
                lsCurCommId = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommId
                lsCurCommName = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommName
                lsCurCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CurCropYear.ToString()
                lsPrevCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).PrevCropYear.ToString()
                lsPrev2CropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).Prev2CropYear.ToString()
                If Not loCollCommList.Contains(lsCurCommId) Then
                    Dim loNewComm As New Commodity
                    loNewComm.CommID = lsCurCommId
                    loNewComm.CommName = lsCurCommName
                    loNewComm.CurrentCropYear = lsCurCropYear
                    loNewComm.PreviousCropYear = lsPrevCropYear
                    loNewComm.Previous2CropYear = lsPrev2CropYear
                    loCollCommList.Add(loNewComm, loNewComm.CommID)
                End If
                liCommCnt = liCommCnt + 1
            Loop
        Next
        liCnt = liCnt + 1
        'Loop
        lvCommoditySales.View = View.Details
        lvCommoditySales.Items.Clear()
        For Each loCurComm In loCollCommList
            Dim oLVI As New ListViewItem
            oLVI.SubItems(0).Text = loCurComm.CommName

            oLVI.SubItems.Add(loCurComm.CurrentCropYear)
            oLVI.SubItems.Add(loCurComm.PreviousCropYear)
            oLVI.SubItems.Add(loCurComm.Previous2CropYear)
            oLVI.SubItems.Add("CGI")
            lvCommoditySales.Items.Add(oLVI)
        Next
        'ListView2.Columns.Add("Commodity", 100, HorizontalAlignment.Center) 'Column 1
        'ListView2.Columns.Add("Current Crop Year", 100, HorizontalAlignment.Left) 'Column 2
        'ListView2.Columns.Add("Previous Crop Year", 100, HorizontalAlignment.Right) 'Column 3
        'ListView2.Columns.Add("Crop Year Previous", 100, HorizontalAlignment.Right) 'Column 4



        'Dim oHeader As New ColumnHeader
        'oHeader.Text = "Commodity"
        'oHeader.Width = 100
        'oHeader.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader)
        'Dim oHeader1 As New ColumnHeader
        'oHeader1.Text = "Current Crop Year"
        'oHeader1.Width = 100
        'oHeader1.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader1)
        'Dim oHeader2 As New ColumnHeader
        'oHeader2.Text = "Previous Crop Year"
        'oHeader2.Width = 100
        'oHeader2.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader2)
        'Dim oHeader3 As New ColumnHeader
        'oHeader3.Text = "Crop Year 2 yrs Previous"
        'oHeader3.Width = 100
        'oHeader3.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader3)
        'For Each loCurComm In loCollCommList
        ' Dim oLVI As New ListViewItem
        ' oLVI.SubItems(0).Text = loCurComm.CommName
        ' ListView2.Items.Add(oLVI)
        ' Next

    End Sub


    Private Sub cbxVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVendors.SelectedIndexChanged

        cbxVendors.ClearSelected()

        Dim liIndex As Integer
        Dim loCollCommList As New Collection
        Dim loCurComm As Commodity
        Dim liCnt As Integer
        Dim liCommCnt As Integer
        Dim liCommMax As Integer
        Dim liMax As Integer
        Dim lbCommFound As Boolean
        Dim lsCurCommId As String
        Dim lsCurCommName As String
        Dim lsCurCropYear As String
        Dim lsPrevCropYear As String
        Dim lsPrev2CropYear As String


        lbCommFound = False

        liCnt = 1
        liMax = 2

        'Do While liCnt <= liMax
        For Each liIndex In cbxVendors.CheckedIndices
                liCommCnt = 1
                liCommMax = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities.Count
                Do While liCommCnt <= liCommMax
                    lsCurCommId = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommId
                    lsCurCommName = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommName
                    lsCurCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CurrentCropYear.ToString()
                    lsPrevCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).PreviousCropYear.ToString()
                    lsPrev2CropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).Previous2CropYear.ToString()
                    If Not loCollCommList.Contains(lsCurCommId) Then
                        Dim loNewComm As New Commodity
                        loNewComm.CommID = lsCurCommId
                        loNewComm.CommName = lsCurCommName
                        loNewComm.CurrentCropYear = lsCurCropYear
                        loNewComm.PreviousCropYear = lsPrevCropYear
                        loNewComm.Previous2CropYear = lsPrev2CropYear
                        loCollCommList.Add(loNewComm, loNewComm.CommID)
                    End If
                    liCommCnt = liCommCnt + 1
                Loop
            Next
            liCnt = liCnt + 1
        'Loop
        lvCommoditySales.View = View.Details
        lvCommoditySales.Items.Clear()
        For Each loCurComm In loCollCommList
            Dim oLVI As New ListViewItem
            oLVI.SubItems(0).Text = loCurComm.CommName

            oLVI.SubItems.Add(loCurComm.CurrentCropYear)
            oLVI.SubItems.Add(loCurComm.PreviousCropYear)
            oLVI.SubItems.Add(loCurComm.Previous2CropYear)
            oLVI.SubItems.Add("CGI")
            lvCommoditySales.Items.Add(oLVI)
        Next
        'ListView2.Columns.Add("Commodity", 100, HorizontalAlignment.Center) 'Column 1
        'ListView2.Columns.Add("Current Crop Year", 100, HorizontalAlignment.Left) 'Column 2
        'ListView2.Columns.Add("Previous Crop Year", 100, HorizontalAlignment.Right) 'Column 3
        'ListView2.Columns.Add("Crop Year Previous", 100, HorizontalAlignment.Right) 'Column 4



        'Dim oHeader As New ColumnHeader
        'oHeader.Text = "Commodity"
        'oHeader.Width = 100
        'oHeader.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader)
        'Dim oHeader1 As New ColumnHeader
        'oHeader1.Text = "Current Crop Year"
        'oHeader1.Width = 100
        'oHeader1.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader1)
        'Dim oHeader2 As New ColumnHeader
        'oHeader2.Text = "Previous Crop Year"
        'oHeader2.Width = 100
        'oHeader2.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader2)
        'Dim oHeader3 As New ColumnHeader
        'oHeader3.Text = "Crop Year 2 yrs Previous"
        'oHeader3.Width = 100
        'oHeader3.TextAlign = HorizontalAlignment.Center
        'ListView1.Columns.Add(oHeader3)
        'For Each loCurComm In loCollCommList
        ' Dim oLVI As New ListViewItem
        ' oLVI.SubItems(0).Text = loCurComm.CommName
        ' ListView2.Items.Add(oLVI)
        ' Next

    End Sub


    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        Dim mybrush As New System.Drawing.SolidBrush(Color.FromArgb(25, 25, 25))
        mybrush.Color = Color.FromArgb(25, 25, 25)
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(mybrush, e.Bounds)
        End If
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items(e.Index)), e.Font, b, e.Bounds)
        End Using
        e.DrawFocusRectangle()
    End Sub


    Private Sub lvCommoditySales_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles lvCommoditySales.DrawItem
        e.DrawDefault = True

    End Sub

    Private Sub lvCommoditySales_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvCommoditySales.DrawColumnHeader
        'Dim strFormat As New StringFormat()

        'If e.Header.TextAlign = HorizontalAlignment.Center Then
        '    strFormat.Alignment = StringAlignment.Center
        'ElseIf e.Header.TextAlign = HorizontalAlignment.Right Then
        '    strFormat.Alignment = StringAlignment.Far
        'End If

        'e.DrawBackground()
        'e.Graphics.FillRectangle(Brushes.Red, e.Bounds)
        'Dim headerFont As New Font("Arial", 8, FontStyle.Bold)

        'e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Red, e.Bounds, strFormat)

        e.Graphics.FillRectangle(Brushes.Red, e.Bounds)
        e.DrawText()

    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

    End Sub

    Private Sub lblGrowerCity_Click(sender As Object, e As EventArgs) Handles lblGrowerCity.Click

    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub lblGrowerState_Click(sender As Object, e As EventArgs) Handles lblGrowerState.Click

    End Sub

    Private Sub pbContact_Click(sender As Object, e As EventArgs) Handles pbContact.Click

    End Sub

    Private Sub lblGrowerCountry_Click(sender As Object, e As EventArgs) Handles lblGrowerCountry.Click

    End Sub

    Private Sub lblGrowerZip_Click(sender As Object, e As EventArgs) Handles lblGrowerZip.Click

    End Sub
End Class






