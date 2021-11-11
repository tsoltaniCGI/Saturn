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
    Private Sub ReloadNotes()
        Dim sNote As String

        Me.TestDataGrid.Rows.Clear()
        For Each oNote In oGrowerColl(ListBox1.SelectedIndex + 1).Notes
            'sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " " & oNote.GrowerNoteCreationDate.ToString("yyyy-MM-dd hh:mm:ss")
            'sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
            'sNote = sNote & DateTime.ParseExact(oNote.GrowerNoteCreationDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
            sNote = sNote & Month(oNote.GrowerNoteCreationDate).ToString() & "/"
            sNote = sNote & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString() & "/"
            sNote = sNote & Year(oNote.GrowerNoteCreationDate).ToString() & " "
            sNote = sNote & Hour(oNote.GrowerNoteCreationDate).ToString() & ":"
            sNote = sNote & Minute(oNote.GrowerNoteCreationDate).ToString & ":"
            sNote = sNote & Second(oNote.GrowerNoteCreationDate).ToString()
            TestDataGrid.Rows.Add(New String() {sNote})
        Next

    End Sub
    Private Sub BuildCommodityList()
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
        Dim loCollCheckedIndices As New Collection


        lbCommFound = False

        liCnt = 1
        liMax = 2
        If ckVendor1.Checked Then loCollCheckedIndices.Add(1)
        If ckVendor2.Checked Then loCollCheckedIndices.Add(2)
        If ckVendor3.Checked Then loCollCheckedIndices.Add(3)
        If ckVendor4.Checked Then loCollCheckedIndices.Add(4)
        If ckVendor5.Checked Then loCollCheckedIndices.Add(5)
        If ckVendor6.Checked Then loCollCheckedIndices.Add(6)
        If ckVendor7.Checked Then loCollCheckedIndices.Add(7)
        If ckVendor8.Checked Then loCollCheckedIndices.Add(8)


        'Do While liCnt <= liMax
        For Each liIndex In loCollCheckedIndices
            liCommCnt = 1
            liCommMax = oGrowerColl(Me.ListBox1.SelectedIndex + 1).Vendors(liIndex).CollCommodities.Count
            Do While liCommCnt <= liCommMax
                lsCurCommId = oGrowerColl(Me.ListBox1.SelectedIndex + 1).Vendors(liIndex).CollCommodities(liCommCnt).CommId
                lsCurCommName = oGrowerColl(Me.ListBox1.SelectedIndex + 1).Vendors(liIndex).CollCommodities(liCommCnt).CommName
                lsCurCropYear = oGrowerColl(Me.ListBox1.SelectedIndex + 1).Vendors(liIndex).CollCommodities(liCommCnt).CurrentCropYear.ToString()
                lsPrevCropYear = oGrowerColl(Me.ListBox1.SelectedIndex + 1).Vendors(liIndex).CollCommodities(liCommCnt).PreviousCropYear.ToString()
                lsPrev2CropYear = oGrowerColl(Me.ListBox1.SelectedIndex + 1).Vendors(liIndex).CollCommodities(liCommCnt).Previous2CropYear.ToString()
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
        '
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

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Dim sSql As String
        Dim iGrowerID As Integer
        Dim iVendorID As Integer
        Dim sCommID As String
        Dim oCollGrowVendComm As New Collection
        Dim oNoteMethods As New Collection
        Dim iMax As Integer
        Dim iCnt As Integer
        'Dim iNoteId As Integer
        Dim iNum As Integer
        Dim bAddNote As Boolean
        Dim sCaption As String
        'no fdg
        GlobalVariables.ResetNote = False

        sCaption = "Saturn" & " : " & "User: " & GlobalVariables.UserFirstName & " " & GlobalVariables.UserLastName & " : " & "Facilities: "
        For Each sFacility In GlobalVariables.UserFacilities
            sCaption = sCaption & sFacility & " "
        Next
        'Me.Text = "Saturn" & " : " & "User: " & GlobalVariables.UserFirstName & " " & GlobalVariables.UserLastName & " : " & "Facility: " & GlobalVariables.UserFacility
        Me.Text = Trim(sCaption)
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
        'NVL(current_crop_year_volume, 0), NVL(previous_crop_year_volume, 0), NVL(previous2_crop_year_volume, 0), NVL(grower_note_id, 0), NVL(grower_note_creation_date, ''), NVL(grower_note_subject), ''),
        'NVL(grower_note_method_id, 0), NVL(grower_note_text, ''), NVL(grower_note_created_by, 0)
        'From growers, growers_vendors, vendors, vendors_facilities, users, commodities, vendors_commodities, vendor_sales_volume, facilities, grower_notes, users_facilities
        'Where user_id = 339
        'And facilities.facility_id = users_facilities.facility_id
        'and users.user_id = users_facilities.user_id
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

        'sSql = "SELECT GROWERS.GROWER_ID, VENDORS.VENDOR_ID, ISNULL(GROWER_FIRST_NAME, ''), "
        'sSql = sSql & "ISNULL(GROWER_ADDRESS_LINE_1, ''), ISNULL(GROWER_CITY, ''), ISNULL(GROWER_COUNTY, ''), "
        'sSql = sSql & "ISNULL(GROWER_STATE, ''), ISNULL(GROWER_ZIP, ''), ISNULL(GROWER_COUNTRY, ''), "
        'sSql = sSql & "ISNULL(GROWER_PHONE1, ''), ISNULL(VENDOR_NAME, ''), ISNULL(COM.COMMODITY_ID, ''), "
        'sSql = sSql & "ISNULL(COMMODITY_NAME, ''), ISNULL(CURRENT_CROP_YEAR_VOLUME, 0), ISNULL(PREVIOUS_CROP_YEAR_VOLUME, 0), "
        'sSql = sSql & "ISNULL(PREVIOUS2_CROP_YEAR_VOLUME, 0), ISNULL(GROWER_NOTE_ID, 0), ISNULL(GROWER_NOTE_CREATION_DATE, ''), ISNULL(GROWER_NOTE_SUBJECT, ''),  "
        'sSql = sSql & "ISNULL(GROWER_NOTE_METHOD_ID, 0), ISNULL(GROWER_NOTE_TEXT, ''), ISNULL(GROWER_NOTE_CREATED_BY, 0) "
        'sSql = sSql & "FROM GROWERS "
        'sSql = sSql & "LEFT OUTER JOIN GROWER_NOTES "
        'sSql = sSql & "ON GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        'sSql = sSql & "INNER Join GROWERS_VENDORS "
        'sSql = sSql & "ON GROWERS_VENDORS.GROWER_ID = GROWERS.GROWER_ID "
        'sSql = sSql & "INNER JOIN( "
        'sSql = sSql & "VENDORS "
        'sSql = sSql & "LEFT OUTER JOIN VENDOR_SALES_VOLUME "
        'sSql = sSql & "ON VENDOR_SALES_VOLUME.AGTECH_VENDOR_ID = VENDORS.AGTECH_VENDOR_ID "
        'sSql = sSql & "INNER JOIN VENDORS_COMMODITIES "
        'sSql = sSql & "ON VENDORS.VENDOR_ID = VENDORS_COMMODITIES.VENDOR_ID "
        'sSql = sSql & "LEFT OUTER JOIN ( "
        'sSql = sSql & "VENDORS_FACILITIES "
        'sSql = sSql & "RIGHT OUTER JOIN FACILITIES "
        'sSql = sSql & "ON VENDORS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        'sSql = sSql & ") "
        'sSql = sSql & "ON VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        'sSql = sSql & ") "
        'sSql = sSql & "ON VENDORS.VENDOR_ID = GROWERS_VENDORS.VENDOR_ID "
        'sSql = sSql & "CROSS Join USERS "
        'sSql = sSql & "CROSS Join COMMODITIES com "
        'sSql = sSql & "WHERE( "
        'sSql = sSql & "USER_ID = " & GlobalVariables.UserId.ToString() & " "
        'sSql = sSql & "AND FACILITIES.FACILITY_ID = USER_FACILITY_ID "
        'sSql = sSql & "AND com.COMMODITY_ID = VENDORS_COMMODITIES.COMMODITY_ID "
        'sSql = sSql & "AND VENDOR_SALES_VOLUME.COMMODITY_ID = com.COMMODITY_ID "
        'sSql = sSql & ") "
        'sSql = sSql & "ORDER BY GROWERS.GROWER_ID, VENDORS.VENDOR_ID, COMMODITY_NAME, GROWER_NOTE_ID"

        sSql = "SELECT DISTINCT GROWERS.GROWER_ID, VENDORS.VENDOR_ID, ISNULL(GROWER_FIRST_NAME, '') AS 'First Name', ISNULL(GROWER_ADDRESS_LINE_1, '') AS Address, "
        sSql = sSql & "ISNULL(GROWER_CITY, '') AS City, ISNULL(GROWER_COUNTY, '') AS County, ISNULL(GROWER_STATE, '') AS State, "
        sSql = sSql & "ISNULL(GROWER_ZIP, '') AS 'Zip Code', ISNULL(GROWER_COUNTRY, '') AS Country, ISNULL(GROWER_PHONE1, '') AS 'Work Phone', "
        sSql = sSql & "ISNULL(VENDOR_NAME, '') AS 'Vendor Name', ISNULL(COMMODITIES.COMMODITY_ID, '') AS CommID, "
        sSql = sSql & "ISNULL(COMMODITIES.COMMODITY_NAME, '') AS Commodity, ISNULL(CURRENT_CROP_YEAR_VOLUME, 0) AS 'CCY Volume', "
        sSql = sSql & "ISNULL(PREVIOUS_CROP_YEAR_VOLUME, 0) AS 'PCY Volume', ISNULL(PREVIOUS2_CROP_YEAR_VOLUME, 0) AS 'P2CY Volume', "
        sSql = sSql & "ISNULL(GROWER_NOTE_ID, 0) AS NoteID, ISNULL(GROWER_NOTE_SUBJECT, '') AS 'Note Subject', "
        sSql = sSql & "ISNULL(GROWER_NOTE_METHOD_ID, 0) AS 'Note Method ID', ISNULL(GROWER_NOTE_TEXT, '') AS 'Note Text', "
        sSql = sSql & "ISNULL(GROWER_NOTE_CREATION_DATE, '') AS 'Note Creation Date', ISNULL(GROWER_NOTE_CREATED_BY, 0) AS 'Note Creator' "
        sSql = sSql & "FROM GROWERS "
        sSql = sSql & "LEFT OUTER JOIN GROWER_NOTES "
        sSql = sSql & "ON GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "INNER JOIN GROWERS_VENDORS "
        sSql = sSql & "ON GROWERS_VENDORS.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "INNER JOIN ( "
        sSql = sSql & "VENDORS "
        sSql = sSql & "LEFT OUTER JOIN ( "
        sSql = sSql & "VENDOR_SALES_VOLUME "
        sSql = sSql & "RIGHT OUTER JOIN COMMODITIES COM "
        sSql = sSql & "ON VENDOR_SALES_VOLUME.COMMODITY_ID = COM.COMMODITY_ID "
        sSql = sSql & " ) "
        sSql = sSql & "ON VENDOR_SALES_VOLUME.AGTECH_VENDOR_ID = VENDORS.AGTECH_VENDOR_ID "
        sSql = sSql & " ) "
        sSql = sSql & "ON VENDORS.VENDOR_ID = GROWERS_VENDORS.VENDOR_ID "
        sSql = sSql & "INNER JOIN ( "
        sSql = sSql & "VENDORS_FACILITIES "
        sSql = sSql & "INNER JOIN FACILITIES "
        sSql = sSql & "ON VENDORS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        sSql = sSql & "INNER JOIN USERS_FACILITIES "
        sSql = sSql & "ON FACILITIES.FACILITY_ID = USERS_FACILITIES.FACILITY_ID "
        sSql = sSql & "INNER JOIN USERS "
        sSql = sSql & "ON USERS.USER_ID = USERS_FACILITIES.USER_ID "
        sSql = sSql & " ) "
        sSql = sSql & "ON VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        sSql = sSql & "INNER JOIN ( "
        sSql = sSql & "VENDORS_COMMODITIES "
        sSql = sSql & "INNER JOIN COMMODITIES "
        sSql = sSql & "ON commodities.COMMODITY_ID = VENDORS_COMMODITIES.COMMODITY_ID "
        sSql = sSql & " ) "
        sSql = sSql & "ON VENDORS.VENDOR_ID = VENDORS_COMMODITIES.VENDOR_ID "
        sSql = sSql & "WHERE users.USER_ID = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "ORDER BY GROWERS.GROWER_ID, VENDORS.VENDOR_ID, CommID, 'Note Creation Date'"

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
                oGVC.GrowerNoteSubject = oReader.GetString(17)
                oGVC.GrowerNoteMethod = oReader.GetInt32(18)
                oGVC.GrowerNoteText = oReader.GetString(19)
                oGVC.GrowerNoteCreationDate = oReader.GetDateTime(20)
                oGVC.GrowerNoteCreatedBy = oReader.GetInt32(21)

                oCollGrowVendComm.Add(oGVC, oGVC.GrowerID.ToString() & oGVC.VendorId.ToString() & oGVC.CommID.ToString() & iNum.ToString())
                iNum = iNum + 1
            Loop
        End If
        sSql = "SELECT grower_note_method_id, grower_note_method_short_name "
        sSql = sSql & "FROM grower_note_methods "
        sSql = sSql & "ORDER BY grower_note_method_id"

        myCmd.CommandText = sSql
        oReader.Close()
        oReader = myCmd.ExecuteReader()
        If oReader.HasRows() Then
            Do While oReader.Read()
                oNoteMethods.Add(oReader.GetString(1), oReader.GetInt32(0).ToString())
            Loop
        End If
        oReader.Close()
        'oReader = Nothing
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
                            If Not oVendor.CollCommodities.Contains(sCommID) Then
                                Dim oComm As New Commodity
                                oComm.CommID = sCommID
                                oComm.CommName = oCollGrowVendComm(iCnt).CommName
                                oComm.CurrentCropYear = oCollGrowVendComm(iCnt).CurrentCropYear
                                oComm.PreviousCropYear = oCollGrowVendComm(iCnt).PreviousCropYear
                                oComm.Previous2CropYear = oCollGrowVendComm(iCnt).Previous2CropYear
                                oVendor.CollCommodities.Add(oComm, oComm.CommID)
                            End If
                            iCnt = iCnt + 1
                            If iCnt >= iMax Then

                                Exit Do
                            End If

                        Loop
                        oGrower.Vendors.Add(oVendor)

                    End If
                    iCnt = iCnt + 1
                    If iCnt >= iMax Then
                        If Not oGrowerColl.Contains(oGrower.GrowerID.ToString()) Then
                            oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())

                        End If
                        Exit Do
                    End If
                Loop
                If iCnt <= iMax Then
                    If iGrowerID <> oCollGrowVendComm(iCnt).GrowerId Then
                        If Not oGrowerColl.Contains(oGrower.GrowerID.ToString()) Then
                            oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())
                        End If
                        'iCnt = iCnt - 1 'Move the pointer back one so the outside loop can advance to the next record
                    End If
                End If
            Else
                iCnt = iCnt + 1
            End If
        Loop

        iCnt = 1
        iGrowerID = -1
        sSql = "SELECT user_id, user_login FROM users ORDER BY user_id"
        myCmd.CommandText = sSql
        oReader.Close()
        oReader = myCmd.ExecuteReader()

        If oReader.HasRows() Then
            Do While oReader.Read()
                GlobalVariables.UserList.Add(oReader.GetString(1), oReader.GetInt32(0).ToString())
            Loop
        End If
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
                            oNote.GrowerNoteCreatedByLogin = GlobalVariables.UserList(oNote.GrowerNoteCreatedBy)
                            oNote.GrowerNoteSubject = oCollGrowVendComm(iCnt).GrowerNoteSubject
                            oNote.GrowerNoteMethod = oCollGrowVendComm(iCnt).GrowerNoteMethod
                            oNote.GrowerNoteMethodText = oNoteMethods(oNote.GrowerNoteMethod.ToString())
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

        'oConn.Close()
        If ListBox1.Items.Count >= 1 Then
            ListBox1.SetSelected(0, True)
        End If

        TestDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        TestDataGrid.Columns(0).ReadOnly = True
        'DataGridView1.Rows.Add(New String(){Value1, Value2, Value3})
        'TestDataGrid.Rows.Add(New String() {"Once, I was a wanderer.  I wandered the entire country."})

        'set the WrapMode for the DataGridViewColumn to DataGridViewTriState.True

        'make sure you Set a height For the row, Or set the DataGridView's AutoSizeRowsMode to DataGridViewAutoSizeRowsMode.AllCells

        'If you Then don't want to edit that column - you can set DataGridView.Column.ReadOnly property to true.

        'Update:     It took me a while to find this property with the above information. In VS C# 2017 the WrapMode property Is located in the datagridview DefaultCellSytle dialog.

        '        Share
        '       Follow
        '      edited Jun 7 '19 at 14:48
        '
        '   MatthewD


        'In addition to this you need to set the WrapMode for the DataGridViewColumn to DataGridViewTriState.True And make sure you set a height for the row, Or set the DataGridView's AutoSizeRowsMode to DataGridViewAutoSizeRowsMode.AllCells – 

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
        Dim sNote As String
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
            ckVendor1.Visible = False
            ckVendor2.Visible = False
            ckVendor3.Visible = False
            ckVendor4.Visible = False
            ckVendor5.Visible = False
            ckVendor6.Visible = False
            ckVendor7.Visible = False
            ckVendor8.Visible = False
            Do While iCnt <= iMax
                If iCnt > 8 Then Exit Do 'There are only 8 checkboxes
                'oCurVendor = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt)
                Select Case iCnt
                    Case 1
                        ckVendor1.Visible = True
                        ckVendor1.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor1.Checked = True
                    Case 2
                        ckVendor2.Visible = True
                        ckVendor2.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor2.Checked = True
                    Case 3
                        ckVendor3.Visible = True
                        ckVendor3.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor3.Checked = True
                    Case 4
                        ckVendor4.Visible = True
                        ckVendor4.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor1.Checked = True
                    Case 5
                        ckVendor5.Visible = True
                        ckVendor5.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor5.Checked = True
                    Case 6
                        ckVendor6.Visible = True
                        ckVendor6.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor6.Checked = True
                    Case 7
                        ckVendor7.Visible = True
                        ckVendor7.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor7.Checked = True
                    Case 8
                        ckVendor8.Visible = True
                        ckVendor8.Text = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(iCnt).VendorName
                        ckVendor8.Checked = True
                End Select


                iCnt = iCnt + 1
            Loop


            'lvNotes.Clear()
            TestDataGrid.Rows.Clear()
            For Each oNote In oGrowerColl(ListBox1.SelectedIndex + 1).Notes

                'Dim oLVI As New ListViewItem

                'sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & "Note: " & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethod & "     " & "Created Bye: " & oNote.GrowerNoteCreatedBy
                sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
                sNote = sNote & Month(oNote.GrowerNoteCreationDate).ToString() & "/"
                sNote = sNote & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString() & "/"
                sNote = sNote & Year(oNote.GrowerNoteCreationDate).ToString() & " "
                sNote = sNote & Hour(oNote.GrowerNoteCreationDate).ToString() & ":"
                sNote = sNote & Minute(oNote.GrowerNoteCreationDate).ToString & ":"
                sNote = sNote & Second(oNote.GrowerNoteCreationDate).ToString()
                'DateTime.ParseExact(oNote.GrowerNoteCreationDate, "MM/dd/yyyy hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
                TestDataGrid.Rows.Add(New String() {sNote})
                'oLVI.SubItems(0).Text = oNote.GrowerNoteText

                'oLVI.SubItems.Add(oNote.GrowerNoteCreationDate)
                'oLVI.SubItems.Add(oNote.GrowerNoteCreatedBy)
                'oLVI.SubItems.Add(oNote.GrowerNoteSubject)
                'oLVI.SubItems.Add(oNote.GrowerNoteMethod)
                'lvNotes.Items.Add(oLVI)
            Next
        End If
        'If cbxVendors.Items.Count >= 1 Then
        'cbxVendors.SetSelected(0, True)

        'End If
        BuildCommodityList()

    End Sub




    Private Sub cbxVendors_ItemCheck(sender As Object, e As ItemCheckEventArgs)

        'Dim liIndex As Integer
        'Dim loCollCommList As New Collection
        'Dim loCurComm As Commodity
        'Dim liCnt As Integer
        'Dim liCommCnt As Integer
        'Dim liCommMax As Integer
        'Dim liMax As Integer
        'Dim lbCommFound As Boolean
        'Dim lsCurCommId As String
        'Dim lsCurCommName As String
        'Dim lsCurCropYear As String
        'Dim lsPrevCropYear As String
        'Dim lsPrev2CropYear As String


        'lbCommFound = False

        'liCnt = 1
        'liMax = 2

        ''Do While liCnt <= liMax
        'For Each liIndex In cbxVendors.CheckedIndices
        '    liCommCnt = 1
        '    liCommMax = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities.Count
        '    Do While liCommCnt <= liCommMax
        '        lsCurCommId = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommId
        '        lsCurCommName = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommName
        '        lsCurCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CurCropYear.ToString()
        '        lsPrevCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).PrevCropYear.ToString()
        '        lsPrev2CropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).Prev2CropYear.ToString()
        '        If Not loCollCommList.Contains(lsCurCommId) Then
        '            Dim loNewComm As New Commodity
        '            loNewComm.CommID = lsCurCommId
        '            loNewComm.CommName = lsCurCommName
        '            loNewComm.CurrentCropYear = lsCurCropYear
        '            loNewComm.PreviousCropYear = lsPrevCropYear
        '            loNewComm.Previous2CropYear = lsPrev2CropYear
        '            loCollCommList.Add(loNewComm, loNewComm.CommID)
        '        End If
        '        liCommCnt = liCommCnt + 1
        '    Loop
        'Next
        'liCnt = liCnt + 1
        ''Loop
        'lvCommoditySales.View = View.Details
        'lvCommoditySales.Items.Clear()
        'For Each loCurComm In loCollCommList
        '    Dim oLVI As New ListViewItem
        '    oLVI.SubItems(0).Text = loCurComm.CommName

        '    oLVI.SubItems.Add(loCurComm.CurrentCropYear)
        '    oLVI.SubItems.Add(loCurComm.PreviousCropYear)
        '    oLVI.SubItems.Add(loCurComm.Previous2CropYear)
        '    oLVI.SubItems.Add("CGI")
        '    lvCommoditySales.Items.Add(oLVI)
        'Next
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


    Private Sub cbxVendors_SelectedIndexChanged(sender As Object, e As EventArgs)

        'cbxVendors.ClearSelected()

        'Dim liIndex As Integer
        'Dim loCollCommList As New Collection
        'Dim loCurComm As Commodity
        'Dim liCnt As Integer
        'Dim liCommCnt As Integer
        'Dim liCommMax As Integer
        'Dim liMax As Integer
        'Dim lbCommFound As Boolean
        'Dim lsCurCommId As String
        'Dim lsCurCommName As String
        'Dim lsCurCropYear As String
        'Dim lsPrevCropYear As String
        'Dim lsPrev2CropYear As String


        'lbCommFound = False

        'liCnt = 1
        'liMax = 2

        ''Do While liCnt <= liMax
        'For Each liIndex In cbxVendors.CheckedIndices
        '    liCommCnt = 1
        '    liCommMax = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities.Count
        '    Do While liCommCnt <= liCommMax
        '        lsCurCommId = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommId
        '        lsCurCommName = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CommName
        '        lsCurCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).CurrentCropYear.ToString()
        '        lsPrevCropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).PreviousCropYear.ToString()
        '        lsPrev2CropYear = oGrowerColl(ListBox1.SelectedIndex + 1).Vendors(liIndex + 1).CollCommodities(liCommCnt).Previous2CropYear.ToString()
        '        If Not loCollCommList.Contains(lsCurCommId) Then
        '            Dim loNewComm As New Commodity
        '            loNewComm.CommID = lsCurCommId
        '            loNewComm.CommName = lsCurCommName
        '            loNewComm.CurrentCropYear = lsCurCropYear
        '            loNewComm.PreviousCropYear = lsPrevCropYear
        '            loNewComm.Previous2CropYear = lsPrev2CropYear
        '            loCollCommList.Add(loNewComm, loNewComm.CommID)
        '        End If
        '        liCommCnt = liCommCnt + 1
        '    Loop
        'Next
        'liCnt = liCnt + 1
        ''Loop
        'lvCommoditySales.View = View.Details
        'lvCommoditySales.Items.Clear()
        'For Each loCurComm In loCollCommList
        '    Dim oLVI As New ListViewItem
        '    oLVI.SubItems(0).Text = loCurComm.CommName

        '    oLVI.SubItems.Add(loCurComm.CurrentCropYear)
        '    oLVI.SubItems.Add(loCurComm.PreviousCropYear)
        '    oLVI.SubItems.Add(loCurComm.Previous2CropYear)
        '    oLVI.SubItems.Add("CGI")
        '    lvCommoditySales.Items.Add(oLVI)
        'Next
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

    Private Sub ckVendor2_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor2.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor6_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor6.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor1_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor1.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor3_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor3.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor4_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor4.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor5_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor5.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor7_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor7.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub ckVendor8_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor8.CheckedChanged
        BuildCommodityList()
    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        Dim sSql As String
        Dim oNewNote As New Note
        Me.TopMost = False
        Dim frmNote = New FormNote
        'Dim sDate As String
        Dim dDate As DateTime
        frmNote.ShowDialog()
        'frmNote.TopMost = True
        GlobalVariables.CurrentGrowerID = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerID
        GlobalVariables.GrowerFirstName = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerFirstName
        GlobalVariables.GrowerAddress1 = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerAddress1
        GlobalVariables.GrowerCity = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerCity
        GlobalVariables.GrowerState = oGrowerColl(ListBox1.SelectedIndex + 1).GrowerState
        If GlobalVariables.ResetNote Then
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
            myCmd = oConn.CreateCommand
            'sDate = Now().ToString("yyyy-MM-dd HH:mm:ss")
            dDate = Now()
            sSql = "INSERT INTO grower_notes "
            sSql = sSql & "(grower_note_subject, grower_note_method_id, grower_note_text, grower_note_creation_date, grower_note_created_by, grower_id) "
            sSql = sSql & "VALUES ('" & GlobalVariables.CurrentNoteSubject & "', " & GlobalVariables.CurrentNoteMethod.ToString() & ", "
            sSql = sSql & "'" & GlobalVariables.DQuot(GlobalVariables.CurrentNoteText.ToString()) & "', CONVERT(datetime, '" & dDate.ToString("yyyy-MM-dd HH:mm:ss") & "'), "
            sSql = sSql & GlobalVariables.UserId.ToString() & ", "
            sSql = sSql & GlobalVariables.CurrentGrowerID.ToString() & ")"
            sSql = Replace(sSql, "&", "")
            sSql = Replace(sSql, vbCrLf, "' + CHAR(13) + CHAR(10) + '")
            sSql = sSql
            myCmd.CommandText = sSql
            oConn.Open()
            myCmd.ExecuteNonQuery()
            'oGrowerColl.ListBox1.SelectedIndex + 1).
            oConn.Close()
            oNewNote.GrowerNoteSubject = GlobalVariables.CurrentNoteSubject
            oNewNote.GrowerNoteMethod = GlobalVariables.CurrentNoteMethod
            oNewNote.GrowerNoteMethodText = GlobalVariables.CurrentNoteMethodText
            oNewNote.GrowerNoteText = GlobalVariables.CurrentNoteText
            'Dim dDate As Date = Date.ParseExact(sDate, "yyyy-MM-dd hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            oNewNote.GrowerNoteCreationDate = dDate
            oNewNote.GrowerNoteCreatedBy = GlobalVariables.UserId
            oNewNote.GrowerNoteCreatedByLogin = GlobalVariables.CurrentUserLogin
            oGrowerColl(ListBox1.SelectedIndex + 1).Notes.Add(oNewNote)
            ReloadNotes()
            GlobalVariables.ResetNote = False
        End If
        'Public Shared GrowerZip As String
        ' Did the user click Save?
        'If frmNote.ShowDialog() = Windows.Forms.DialogResult.OK Then
        ' Yes, so grab the values you want from the dialog here
        'Dim textBoxValue As String = options.txtMyTextValue.Text
        'End If
    End Sub




    Private Sub TestDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TestDataGrid.CellContentClick

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub pbContact_Click(sender As Object, e As EventArgs) Handles pbContact.Click

    End Sub

    Private Sub btnAddGrower_ClientSizeChanged(sender As Object, e As EventArgs) Handles btnAddGrower.ClientSizeChanged

    End Sub

    Private Sub btnAddGrower_Click(sender As Object, e As EventArgs) Handles btnAddGrower.Click
        Dim sSql As String
        Dim oNewNote As New Note
        Me.TopMost = False
        Dim frmAddGrower = New FormAddGrower
        'Dim sDate As String
        Dim dDate As DateTime
        GlobalVariables.ResetGrower = False
        frmAddGrower.ShowDialog()



    End Sub

    Private Sub btnAddNote_ClientSizeChanged(sender As Object, e As EventArgs) Handles btnAddNote.ClientSizeChanged

    End Sub
End Class






