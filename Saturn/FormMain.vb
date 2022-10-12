Option Strict Off
Imports System.Data.SqlClient



Public Class FormMain

    'again
    Inherits System.Windows.Forms.Form
    Class CommoditySorter
        Implements IComparer
        Public Function CompareTo(ByVal o1 As Object,
            ByVal o2 As Object) As Integer _
            Implements System.Collections.IComparer.Compare
            Dim item1, item2 As ListViewItem
            item1 = CType(o1, ListViewItem)
            item2 = CType(o2, ListViewItem)
            If item1.ToString.ToUpper > item2.ToString.ToUpper Then
                Return 1
            Else
                If item1.ToString.ToUpper < item2.ToString.ToUpper Then
                    Return -1
                Else
                    Return 0
                End If
            End If
        End Function
    End Class

    Dim oConn As New SqlConnection
    Dim myCmd As SqlCommand
    Dim oGrwoerCmd As SqlCommand
    Dim oReader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable()
    Dim results As String
    Dim oCollGrowVendComm As New Collection
    Dim oNoteMethods As New Collection
    Dim oProspectRecs As New Collection
    Dim oProspectNoteRecs As New Collection
    Dim oOtherCropsRec As New Collection
    Dim oNonCgiCropIDs As New Collection
    Dim HiLiteBrush As New SolidBrush(Color.FromKnownColor(KnownColor.Control))
    'Dim HiLiteText As New te
    Dim clrSelectedText As Color = Color.Red    'Our color for selected text
    Dim clrHighlight As Color = Color.Yellow
    'Dim backColor = this.BackColor;         'Default BackColor*
    'Dim textColor = this.ForeColor;         'Default ForeColor*/
    'Dim txt = ListBox.GetItemText(ListBox.Items[e.Index])
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
    Public Property OtherCrops As Object

    Private Sub ReloadNotes()
        Dim sNote As String

        Dim iIndex As Integer
        Dim sBuildDate As String

        iIndex = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value
        'Me.TestDataGrid.Rows.Clear()
        'For Each oNote In oGrowerColl(oSelItem.CollectionIndex).Notes
        ' 'sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " " & oNote.GrowerNoteCreationDate.ToString("yyyy-MM-dd hh:mm:ss")
        ' 'sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
        ' 'sNote = sNote & DateTime.ParseExact(oNote.GrowerNoteCreationDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
        ' sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & "     " & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
        ' sNote = sNote & Month(oNote.GrowerNoteCreationDate).ToString() & "/"
        ' sNote = sNote & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString() & "/"
        ' sNote = sNote & Year(oNote.GrowerNoteCreationDate).ToString() & " "
        ' sNote = sNote & Hour(oNote.GrowerNoteCreationDate).ToString() & ":"
        ' sNote = sNote & Minute(oNote.GrowerNoteCreationDate).ToString & ":"
        ' sNote = sNote & Second(oNote.GrowerNoteCreationDate).ToString()
        ' TestDataGrid.Rows.Add(New String() {sNote})
        ' Next
        Dim oDict As New List(Of String)
        Dim oNoteRows As New Collection
        TestDataGrid.Rows.Clear()
        For Each oNote In oGrowerColl(iIndex).Notes
            sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & vbCrLf & vbCrLf & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
            sNote = sNote & Month(oNote.GrowerNoteCreationDate).ToString() & "/"
            sNote = sNote & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString() & "/"
            sNote = sNote & Year(oNote.GrowerNoteCreationDate).ToString() & " "
            sNote = sNote & Hour(oNote.GrowerNoteCreationDate).ToString() & ":"
            sNote = sNote & Minute(oNote.GrowerNoteCreationDate).ToString & ":"
            sNote = sNote & Second(oNote.GrowerNoteCreationDate).ToString()

            'sBuildDate = Year(oNote.GrowerNoteCreationDate).ToString()
            'sBuildDate = sBuildDate & Month(oNote.GrowerNoteCreationDate).ToString()
            'sBuildDate = sBuildDate & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString()
            'sBuildDate = sBuildDate & Hour(oNote.GrowerNoteCreationDate).ToString()
            'sBuildDate = sBuildDate & Minute(oNote.GrowerNoteCreationDate).ToString()
            'sBuildDate = sBuildDate & Second(oNote.GrowerNoteCreationDate).ToString()
            sBuildDate = Year(oNote.GrowerNoteCreationDate).ToString()
            sBuildDate = sBuildDate & Replace(Month(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
            sBuildDate = sBuildDate & Replace(Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
            sBuildDate = sBuildDate & Replace(Hour(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
            sBuildDate = sBuildDate & Replace(Minute(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
            sBuildDate = sBuildDate & Replace(Second(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")

            Dim oCurNoteItem As New NoteListItem
            oCurNoteItem.CreateDate = sBuildDate
            oCurNoteItem.NoteText = sNote
            If Not oNoteRows.Contains(oCurNoteItem.CreateDate) Then
                oNoteRows.Add(oCurNoteItem, oCurNoteItem.CreateDate)
            End If
            oDict.Add(sBuildDate)
        Next

        oDict.Sort()
        oDict.Reverse()
        For Each sDate In oDict
            TestDataGrid.Rows.Add(New String() {oNoteRows(sDate).NoteText})
        Next
        oDict = Nothing
        oNoteRows = Nothing

    End Sub

    Private Sub RebuildPage()
        Form1_Load(Me, EventArgs.Empty)
    End Sub
    Private Sub ClearFilters()
        Dim iCnt As Integer
        Dim iMax As Integer
        Dim sLastName As String
        Dim sFirstName As String
        Dim sProspect As String
        Dim sAddress As String
        Dim sCity As String
        Dim sState As String
        Dim sCounty As String
        Dim sZip As String
        Dim sCountry As String
        Dim sWorkPhone As String
        Dim sCellPhone As String
        Dim sFax As String
        Dim sEmail As String
        Dim sComment As String
        Dim sGrowerID As String
        Dim sAddress2 As String
        Dim sLastUpdate As String

        dgvGrowers.Rows.Clear()
        GlobalVariables.CurrentFilters.FirstName = ""
        GlobalVariables.CurrentFilters.LastName = ""
        GlobalVariables.CurrentFilters.City = ""
        GlobalVariables.CurrentFilters.County = ""
        GlobalVariables.CurrentFilters.CommodityID = ""
        GlobalVariables.CurrentFilters.Prospect = False
        GlobalVariables.CurrentFilters.HasNotes = False
        GlobalVariables.CurrentFilters.NoteSubject = ""
        GlobalVariables.CurrentFilters.NoteKeyword = ""
        iCnt = 1
        iMax = oGrowerColl.Count

        Do While iCnt <= iMax

            sLastName = oGrowerColl(iCnt).GrowerLastName
            sFirstName = oGrowerColl(iCnt).GrowerFirstName
            sProspect = oGrowerColl(iCnt).GrowerProspect
            If sProspect = "Y" Then
                sProspect = "P"
            Else
                sProspect = " "
            End If
            sAddress = oGrowerColl(iCnt).GrowerAddress1
            sAddress2 = Trim(oGrowerColl(iCnt).GrowerAddress2)
            If Len(sAddress2) > 0 Then
                sAddress = sAddress & vbCrLf & sAddress2
            End If
            sCity = oGrowerColl(iCnt).GrowerCity
            sState = oGrowerColl(iCnt).GrowerState
            sCounty = oGrowerColl(iCnt).GrowerCounty
            sZip = oGrowerColl(iCnt).GrowerZip
            sCountry = oGrowerColl(iCnt).GrowerCountry
            sWorkPhone = oGrowerColl(iCnt).GrowerPhone1
            sCellPhone = oGrowerColl(iCnt).GrowerPhone2
            sFax = oGrowerColl(iCnt).GrowerFax
            sEmail = oGrowerColl(iCnt).GrowerEmail
            sComment = oGrowerColl(iCnt).GrowerComment
            sGrowerID = oGrowerColl(iCnt).GrowerID.ToString()
            sLastUpdate = oGrowerColl(iCnt).GrowerLastUpdate.ToString()

            dgvGrowers.Rows.Add(sLastName, sFirstName, sLastUpdate, sProspect, sAddress, sCity, sState, sCounty, sZip, sCellPhone, sWorkPhone, sFax, sEmail, sComment, sCountry, sGrowerID)


            iCnt = iCnt + 1

        Loop

    End Sub
    Private Sub RefreshDataGrid()
        Dim sFilterFirstName As String
        Dim sFilterLastName As String
        Dim sFilterCity As String
        Dim sFilterCounty As String
        Dim sFilterCommodityID As String
        Dim iCnt As Integer
        Dim iMax As Integer
        Dim iCnt2 As Integer
        Dim iCnt3 As Integer
        Dim iMax3 As Integer
        Dim iMax2 As Integer
        Dim iCnt4 As Integer
        Dim iMax4 As Integer
        Dim bFirstNameFilter As Boolean
        Dim bLastNameFilter As Boolean
        Dim bCityFilter As Boolean
        Dim bCountyFilter As Boolean
        Dim bCommodityIDFilter As Boolean
        Dim bAddGrower As Boolean
        Dim bFarmStorage As Boolean
        Dim sLastName As String
        Dim sFirstName As String
        Dim sProspect As String
        Dim sAddress As String
        Dim sCity As String
        Dim sState As String
        Dim sCounty As String
        Dim sZip As String
        Dim sCountry As String
        Dim sWorkPhone As String
        Dim sCellPhone As String
        Dim sFax As String
        Dim sEmail As String
        Dim sComment As String
        Dim sLastUpdate As String
        Dim sGrowerID As String
        Dim sAddress2 As String
        Dim bCommFound As Boolean
        Dim bProspect As Boolean
        Dim bHasNotes As Boolean
        Dim bNoteSubjFilter As Boolean
        Dim bNoteKeyFilter As Boolean
        Dim sFilterNoteSubject As String
        Dim sFilterNoteKeyword As String
        Dim sHour As String

        If GlobalVariables.CurrentFilters.FarmStorage = "Y" Then
            bFarmStorage = True
        Else
            bFarmStorage = False
        End If
        bFirstNameFilter = False
        bLastNameFilter = False
        bCityFilter = False
        bCountyFilter = False
        bCommodityIDFilter = False
        bNoteSubjFilter = False
        bNoteKeyFilter = False




        dgvGrowers.Rows.Clear()
        sFilterFirstName = Trim(GlobalVariables.CurrentFilters.FirstName)
        sFilterLastName = Trim(GlobalVariables.CurrentFilters.LastName)
        sFilterCity = Trim(GlobalVariables.CurrentFilters.City)
        sFilterCounty = Trim(GlobalVariables.CurrentFilters.County)
        sFilterCommodityID = Trim(GlobalVariables.CurrentFilters.CommodityID)
        sFilterNoteSubject = Trim(GlobalVariables.CurrentFilters.NoteSubject)
        sFilterNoteKeyword = Trim(GlobalVariables.CurrentFilters.NoteKeyword)

        If Len(sFilterFirstName) > 0 Then bFirstNameFilter = True
        If Len(sFilterLastName) > 0 Then bLastNameFilter = True
        If Len(sFilterCity) > 0 Then bCityFilter = True
        If Len(sFilterCounty) > 0 Then bCountyFilter = True
        If Len(sFilterCommodityID) > 0 Then bCommodityIDFilter = True
        If Len(sFilterNoteSubject) > 0 Then bNoteSubjFilter = True
        If Len(sFilterNoteKeyword) > 0 Then bNoteKeyFilter = True
        bProspect = GlobalVariables.CurrentFilters.Prospect
        bHasNotes = GlobalVariables.CurrentFilters.HasNotes

        'just adding a comment

        iCnt = 1
        iMax = oGrowerColl.Count

        Do While iCnt <= iMax

            bAddGrower = True
            'If oGrowerColl(iCnt).GrowerFirstName = "Don" And oGrowerColl(iCnt).GrowerLastName = "Conley" Then
            ' MessageBox.Show("Don COnley Found!")
            'End If
            If bFirstNameFilter Then
                If oGrowerColl(iCnt).GrowerFirstName.Contains(sFilterFirstName) Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If
            End If

            If bLastNameFilter Then
                If oGrowerColl(iCnt).GrowerLastName.Contains(sFilterLastName) Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If
            End If

            If bCityFilter Then
                If oGrowerColl(iCnt).GrowerCity.Contains(sFilterCity) Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If
            End If

            If bCountyFilter Then
                If oGrowerColl(iCnt).GrowerCounty.Contains(sFilterCounty) Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If
            End If

            If bCommodityIDFilter Then
                iCnt2 = 1
                iMax2 = oGrowerColl(iCnt).OtherCrops.Count
                bCommFound = False
                Do While iCnt2 <= iMax2
                    If oGrowerColl(iCnt).OtherCrops(iCnt2).NonCGICommID = sFilterCommodityID Then
                        If bFarmStorage Then
                            If oGrowerColl(iCnt).OtherCrops(iCnt2).FarmStorage <> "Y" Then
                                'If the Farm Storage Filter is on and the commoditiy is not on the farm
                                'It is like we never found it and move on
                                bCommFound = False
                                Exit Do
                            End If
                        End If
                        bCommFound = True
                        Exit Do
                    End If
                    iCnt2 = iCnt2 + 1
                Loop
                If bCommFound Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If
            End If

            If bProspect Then
                If oGrowerColl(iCnt).GrowerProspect = "Y" Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If
            End If

            If bHasNotes Then
                If oGrowerColl(iCnt).Notes.Count >= 1 Then
                    'Do Nothing
                Else
                    bAddGrower = False
                End If

            End If

            If bNoteSubjFilter Then
                iCnt3 = 1
                iMax3 = oGrowerColl(iCnt).Notes.Count
                bAddGrower = False
                Do While iCnt3 <= iMax3
                    If oGrowerColl(iCnt).Notes(iCnt3).GrowerNoteSubject.Contains(sFilterNoteSubject) Then
                        bAddGrower = True
                    End If
                    iCnt3 = iCnt3 + 1
                Loop
            End If

            If bNoteKeyFilter Then
                iCnt4 = 1
                iMax4 = oGrowerColl(iCnt).Notes.Count
                bAddGrower = False
                Do While iCnt4 <= iMax4
                    If oGrowerColl(iCnt).Notes(iCnt4).GrowerNoteText.Contains(sFilterNoteKeyword) Then
                        bAddGrower = True
                    End If
                    iCnt4 = iCnt4 + 1
                Loop
            End If

            If bAddGrower Then
                sLastName = oGrowerColl(iCnt).GrowerLastName
                sFirstName = oGrowerColl(iCnt).GrowerFirstName
                sProspect = oGrowerColl(iCnt).GrowerProspect
                If sProspect = "Y" Then
                    sProspect = "P"
                Else
                    sProspect = " "
                End If
                sAddress = oGrowerColl(iCnt).GrowerAddress1
                sAddress2 = Trim(oGrowerColl(iCnt).GrowerAddress2)
                If Len(sAddress2) > 0 Then
                    sAddress = sAddress & vbCrLf & sAddress2
                End If
                sCity = oGrowerColl(iCnt).GrowerCity
                sState = oGrowerColl(iCnt).GrowerState
                sCounty = oGrowerColl(iCnt).GrowerCounty
                sZip = oGrowerColl(iCnt).GrowerZip
                sCountry = oGrowerColl(iCnt).GrowerCountry
                sWorkPhone = oGrowerColl(iCnt).GrowerPhone1
                sCellPhone = oGrowerColl(iCnt).GrowerPhone2
                sFax = oGrowerColl(iCnt).GrowerFax
                sEmail = oGrowerColl(iCnt).GrowerEmail
                sComment = oGrowerColl(iCnt).GrowerComment
                sGrowerID = oGrowerColl(iCnt).GrowerID.ToString()
                'sLastUpdate = oGrowerColl(iCnt).GrowerLastUpdate.ToString("yyyy-MM-dd hh:mm:ss")
                sLastUpdate = Year(oGrowerColl(iCnt).GrowerLastUpdate).ToString() & "-"
                If Month(oGrowerColl(iCnt).GrowerLastUpdate) < 10 Then sLastUpdate = sLastUpdate & "0"
                sLastUpdate = sLastUpdate & Month(oGrowerColl(iCnt).GrowerLastUpdate).ToString() & "-"
                If Microsoft.VisualBasic.DateAndTime.Day(oGrowerColl(iCnt).GrowerLastUpdate) < 10 Then sLastUpdate = sLastUpdate & "0"
                sLastUpdate = sLastUpdate & Microsoft.VisualBasic.DateAndTime.Day(oGrowerColl(iCnt).GrowerLastUpdate).ToString() & " "
                sHour = Hour(oGrowerColl(iCnt).GrowerLastUpdate).ToString()
                If Hour(oGrowerColl(iCnt).GrowerLastUpdate) < 10 Then sHour = "0" & sHour
                'If sHour = "00" And oGrowerColl(iCnt).GrowerLastUpdate.ToString("tt") = "PM" Then sHour = "12"
                'If Hour(oGrowerColl(iCnt).GrowerLastUpdate) < 10 Then sLastUpdate = sLastUpdate & "0"
                sLastUpdate = sLastUpdate & sHour & ":"
                If Minute(oGrowerColl(iCnt).GrowerLastUpdate) < 10 Then sLastUpdate = sLastUpdate & "0"
                sLastUpdate = sLastUpdate & Minute(oGrowerColl(iCnt).GrowerLastUpdate).ToString() & ":"
                If Second(oGrowerColl(iCnt).GrowerLastUpdate) < 10 Then sLastUpdate = sLastUpdate & "0"
                sLastUpdate = sLastUpdate & Second(oGrowerColl(iCnt).GrowerLastUpdate).ToString
                dgvGrowers.Rows.Add(sLastName, sFirstName, sLastUpdate, sProspect, sAddress, sCity, sState, sCounty, sZip, sCellPhone, sWorkPhone, sFax, sEmail, sComment, sCountry, sGrowerID)
            End If

            iCnt = iCnt + 1

        Loop

        If dgvGrowers.Rows.Count = 0 Then
            Dim result As DialogResult = MessageBox.Show("No Growers Found matching your filter criteria.  Clear Filters?", "No Growers Found", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ClearFilters()
            End If
            'If MsgBox("No Growers Found matching your filter criteria.  Clear Filters?", MsgBoxStyle.YesNo, "No Growers Found") = MsgBoxResult.Yes Then

        End If


    End Sub
    Private Sub BuildNonCGIList(lsKey As String)
        If Not GlobalVariables.BuildNonCGI Then Exit Sub
        lvNonCGI.View = View.Details
        lvNonCGI.Items.Clear()
        oNonCgiCropIDs.Clear()

        For Each oCurCrop In oGrowerColl(lsKey).OtherCrops
            Dim oCurlvi As New ListViewItem
            oCurlvi.SubItems(0).Text = oCurCrop.NonCGICommodity
            oCurlvi.SubItems.Add(oCurCrop.UpdatedDate.ToString())
            oCurlvi.SubItems.Add(oCurCrop.Status)
            oCurlvi.SubItems.Add(oCurCrop.SoldTo)
            oCurlvi.SubItems.Add(oCurCrop.Volume.ToString())
            oCurlvi.SubItems.Add(oCurCrop.FarmStorage)
            oCurlvi.SubItems.Add(oCurCrop.Location)
            lvNonCGI.Items.Add(oCurlvi)
            oNonCgiCropIDs.Add(oCurCrop.nonCGIcropID)
        Next
        If lvNonCGI.Items.Count >= 1 Then
            lvNonCGI.Items(0).Selected = True
        End If
    End Sub
    Private Sub BuildCommodityList(lsKey As String)
        Dim liIndex As Integer
        Dim loCollCommList As New Collection
        'Dim loCollSalesList As New Collection
        Dim loCurComm As Commodity
        Dim liCurVendorID As Integer
        Dim liCnt As Integer
        'Dim lsCommKey As String
        Dim liCommCnt As Integer
        Dim liCommMax As Integer
        Dim liSLCnt As Integer
        Dim liSLMax As Integer
        'Dim liMax As Integer
        Dim lbCommFound As Boolean
        Dim lbDuplicate As Boolean
        Dim lsCurCommId As String
        Dim lsCurCommName As String
        Dim lsCurCropYear As String
        Dim lsPrevCropYear As String
        Dim lsPrev2CropYear As String
        Dim loCollCheckedIndices As New Collection



        lbCommFound = False
        'If Not GlobalVariables.EditedGrower Then
        If Not GlobalVariables.BuildComm Then Exit Sub
        'End If
        liCnt = 1
        'liMax = 2
        loCollCheckedIndices.Clear()
        If ckVendor1.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(1)
        If ckVendor2.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(2)
        If ckVendor3.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(3)
        If ckVendor4.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(4)
        If ckVendor5.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(5)
        If ckVendor6.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(6)
        If ckVendor7.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(7)
        If ckVendor8.CheckState = CheckState.Checked Then loCollCheckedIndices.Add(8)


        'Do While liCnt <= liMax

        For Each liIndex In loCollCheckedIndices
            liCommCnt = 1
            liCommMax = oGrowerColl(lsKey).Vendors(liIndex).CollCommodities.Count
            Do While liCommCnt <= liCommMax
                lsCurCommId = oGrowerColl(lsKey).Vendors(liIndex).CollCommodities(liCommCnt).CommId
                liCurVendorID = oGrowerColl(lsKey).Vendors(liIndex).VendorId
                lsCurCommName = oGrowerColl(lsKey).Vendors(liIndex).CollCommodities(liCommCnt).CommName
                lsCurCropYear = oGrowerColl(lsKey).Vendors(liIndex).CollCommodities(liCommCnt).CurrentCropYear.ToString()
                lsPrevCropYear = oGrowerColl(lsKey).Vendors(liIndex).CollCommodities(liCommCnt).PreviousCropYear.ToString()
                lsPrev2CropYear = oGrowerColl(lsKey).Vendors(liIndex).CollCommodities(liCommCnt).Previous2CropYear.ToString()
                'If Not loCollCommList.Contains(lsCurCommId) Then
                Dim loNewComm As New Commodity
                loNewComm.CommID = lsCurCommId
                loNewComm.CommName = lsCurCommName
                loNewComm.VendorID = liCurVendorID
                loNewComm.CurrentCropYear = lsCurCropYear
                loNewComm.PreviousCropYear = lsPrevCropYear
                loNewComm.Previous2CropYear = lsPrev2CropYear
                'loCollCommList.Add(loNewComm, loNewComm.CommID)
                'lsCommKey = lsCurCommId & ":" & lsCurVendorID
                If Not loCollCommList.Contains(lsCurCommId) Then
                    loCollCommList.Add(loNewComm, lsCurCommId)
                    'loCollSalesList.Add(lsCurCommId, lsCurCommId)
                    loCollCommList(lsCurCommId).CurrentCropYear = CStr(CDbl(loCollCommList(lsCurCommId).CurrentCropYear))
                    loCollCommList(lsCurCommId).PreviousCropYear = CStr(CDbl(loCollCommList(lsCurCommId).PreviousCropYear))
                    loCollCommList(lsCurCommId).Previous2CropYear = CStr(CDbl(loCollCommList(lsCurCommId).Previous2CropYear))
                    'loCollCommList(lsCommKey).CurrentCropYear = CStr(CDbl(loCollCommList(lsCommKey).CurrentCropYear))
                    'loCollCommList(lsCommKey).PreviousCropYear = CStr(CDbl(loCollCommList(lsCommKey).PreviousCropYear))
                    'loCollCommList(lsCommKey).Previous2CropYear = CStr(CDbl(loCollCommList(lsCommKey).Previous2CropYear))

                Else
                    liSLCnt = 1
                    liSLMax = loCollCommList.Count
                    lbDuplicate = False
                    Do While liSLCnt <= liSLMax
                        If ((loCollCommList(liSLCnt).CommID = lsCurCommId) And (loCollCommList(liSLCnt).VendorID = liCurVendorID)) Then
                            lbDuplicate = True
                            Exit Do
                        End If
                        liSLCnt = liSLCnt + 1
                    Loop
                    If lbDuplicate Then
                        'Do Nothing
                    Else
                        loCollCommList(lsCurCommId).CurrentCropYear = CStr(CDbl(loCollCommList(lsCurCommId).CurrentCropYear + CDbl(lsCurCropYear)))
                        loCollCommList(lsCurCommId).PreviousCropYear = CStr(CDbl(loCollCommList(lsCurCommId).PreviousCropYear + CDbl(lsPrevCropYear)))
                        loCollCommList(lsCurCommId).Previous2CropYear = CStr(CDbl(loCollCommList(lsCurCommId).Previous2CropYear + CDbl(lsPrev2CropYear)))
                        'loCollCommList(lsCommKey).CurrentCropYear = CStr(CDbl(loCollCommList(lsCommKey).CurrentCropYear + CDbl(lsCurCropYear)))
                        'loCollCommList(lsCommKey).PreviousCropYear = CStr(CDbl(loCollCommList(lsCommKey).PreviousCropYear + CDbl(lsPrevCropYear)))
                        'loCollCommList(lsCommKey).Previous2CropYear = CStr(CDbl(loCollCommList(lsCommKey).Previous2CropYear + CDbl(lsPrev2CropYear)))

                    End If

                End If
                liCommCnt = liCommCnt + 1
            Loop
        Next
        liCnt = liCnt + 1
        'Loop
        '
        lvCommoditySales.View = View.Details
        lvCommoditySales.Items.Clear()
        lvCommoditySales.Sorting = SortOrder.Ascending
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
        'Me.TopMost = True
        Dim sSql As String
        Dim iGrowerID As Integer
        Dim iVendorID As Integer
        Dim sCommID As String
        Dim oVendor As Vendor
        Dim sLastName As String
        Dim sFirstName As String
        Dim sProspFlag As String
        Dim sAddress As String
        Dim sCity As String
        Dim sState As String
        Dim sZip As String
        Dim sCounty As String
        Dim sWorkPhone As String
        Dim sCellPhone As String
        Dim sFax As String
        Dim sEmail As String
        Dim sComment As String
        Dim sCountry As String
        Dim sLastUpdate As String

        oCollGrowVendComm.Clear()
        oNoteMethods.Clear()
        oProspectRecs.Clear()
        oProspectNoteRecs.Clear()
        oOtherCropsRec.Clear()
        'oGrowerColl.Clear()
        lvCommoditySales.ListViewItemSorter = New CommoditySorter
        lvCommoditySales.Sorting = SortOrder.Ascending
        dgvGrowers.Columns("LastUpdate").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
        If Not GlobalVariables.bGrowerAdd Then
            dgvGrowers.Rows.Clear()
        End If

        Dim iMax As Integer
        Dim iCnt As Integer
        'Dim iNoteId As Integer
        Dim iNum As Integer
        Dim bAddNote As Boolean
        Dim sCaption As String
        Dim sName As String
        Dim bDupComm As Boolean
        Dim iCommCnt As Integer
        Dim iCommMax As Integer
        Dim oReader As SqlClient.SqlDataReader
        'Dim slGrowers As New SortedList
        'no fdg
        GlobalVariables.ResetNote = False
        GlobalVariables.BuildComm = True
        sCaption = ""
        sCaption = "Saturn CRM" & " : " & "User: " & GlobalVariables.UserFirstName & " " & GlobalVariables.UserLastName & " : " & "Facilities: "
        For Each sFacility In GlobalVariables.UserFacilities
            sCaption = sCaption & sFacility & " "
        Next
        'Me.Text = "Saturn" & " : " & "User: " & GlobalVariables.UserFirstName & " " & GlobalVariables.UserLastName & " : " & "Facility: " & GlobalVariables.UserFacility
        Me.Text = Trim(sCaption)
        Dim sTestProd As String
        sTestProd = GlobalVariables.sEnv
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        oConn.Open()
        myCmd = oConn.CreateCommand
        If Not GlobalVariables.bFirstLoad Then
            GlobalVariables.VendorList.Clear()
            GlobalVariables.bFirstLoad = True
            sSql = "SELECT DISTINCT vendors.vendor_id, vendors.vendor_name, vendor_dummy "
            sSql = sSql & "FROM users, users_facilities, vendors, vendors_facilities, facilities "

            sSql = sSql & "WHERE users.user_id = " & GlobalVariables.UserId.ToString() & " "
            sSql = sSql & "AND users_facilities.user_id = users.user_id "
            sSql = sSql & "AND users_facilities.facility_id = facilities.facility_id "
            sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
            sSql = sSql & "AND vendors_facilities.facility_id = facilities.facility_id "
            'sSql = sSql & "AND LEN(ISNULL(agtech_vendor_id, '')) > 4"
            myCmd.CommandText = sSql

            oReader = myCmd.ExecuteReader()

            If oReader.HasRows Then
                Do While oReader.Read()
                    Dim oThisVendor As New Vendor
                    oThisVendor.VendorID = oReader.GetInt32(0)
                    oThisVendor.VendorName = oReader.GetString(1)
                    oThisVendor.VendorDummy = oReader.GetString(2)
                    'If oThisVendor.VendorID = 61 Then MessageBox.Show("61 Found!")
                    GlobalVariables.VendorList.Add(oThisVendor, oThisVendor.VendorID.ToString())

                Loop
            End If
            oReader.Close()
        End If


        'ORACLE QUERY
        'SELECT DISTINCT GROWERS.GROWER_ID, VENDORS.VENDOR_ID, NVL(GROWER_FIRST_NAME, '') AS 'First Name',
        'NVL(GROWER_ADDRESS_LINE_1, '') AS Address, NVL(GROWER_CITY, '') AS City, NVL(GROWER_COUNTY, '') AS County,
        'NVL(GROWER_STATE, '') AS State, NVL(GROWER_ZIP, '') AS 'Zip Code', NVL(GROWER_COUNTRY, '') AS Country,
        'NVL(GROWER_PHONE1, '') AS 'Work Phone', NVL(VENDOR_NAME, '') AS 'Vendor Name', NVL(COMMODITIES.COMMODITY_ID, '') AS CommID,
        'NVL(COMMODITIES.COMMODITY_NAME, '') AS Commodity, NVL(CURRENT_CROP_YEAR_VOLUME, 0) AS 'CCY Volume',
        'NVL(PREVIOUS_CROP_YEAR_VOLUME, 0) AS 'PCY Volume', NVL(PREVIOUS2_CROP_YEAR_VOLUME, 0) AS 'P2CY Volume',
        'NVL(GROWER_NOTE_ID, 0) AS NoteID, NVL(GROWER_NOTE_SUBJECT, '') AS 'Note Subject', NVL(GROWER_NOTE_METHOD_ID, 0) AS 'Note Method ID',
        'NVL(GROWER_NOTE_TEXT, '') AS 'Note Text', NVL(GROWER_NOTE_CREATION_DATE, '') AS 'Note Creation Date',
        'NVL(GROWER_NOTE_CREATED_BY, 0) AS 'Note Creator', NVL(VENDOR_DUMMY, 'N') AS 'Dummy (Y/N)?', NVL(GROWER_LAST_NAME, '') AS 'Last Name',
        'NVL(GROWER_FAX, '') AS Fax, NVL(GROWER_EMAIL, '') AS Email, NVL(GROWER_PHONE2, '') AS 'Cell Phone',
        'NVL(GROWER_ADDRESS_LINE_2, '') As 'Address 2'
        'FROM growers, grower_notes, growers_vendors, vendor_sales_volume, commodities, vendors, facilities, vendors_facilities, growers_vendors, users, users_facilities, vendors_commodities
        'WHERE growers.grower_id = growers_vendors.grower_id
        'AND vendors.vendor_id = growers_vendors.vendor_id
        'AND vendors_facilities.vendor_id = vendors.vendor_id
        'AND vendors_facilities.facility_id = facilities.facility_id
        'AND vendors_commodities.commodity_id = commodities.commodity_id
        'AND vendor_sales_volume.commodity_id = commoditites.commodity_id
        'AND vendors_facilities.vendor_id = vendors.vendor_id
        'AND users_facilities.facility_id = facilities.facility_id
        'AND users_facilities.user_id = users.user_id
        'AND grower_notes.grower_id (+)= growers.grower_id
        'AND vendors_commodities.vendor_id (+)= vendors.vendor_id
        'AND vendor_sales_volume.agtech_vendor_id (+)= vendors.agtech_vendor_id

        'OLD SQL SERVER QUERY
        'sSql = "SELECT DISTINCT GROWERS.GROWER_ID, VENDORS.VENDOR_ID, ISNULL(GROWER_FIRST_NAME, '') AS 'First Name', ISNULL(GROWER_ADDRESS_LINE_1, '') AS Address, "
        'sSql = sSql & "ISNULL(GROWER_CITY, '') AS City, ISNULL(GROWER_COUNTY, '') AS County, ISNULL(GROWER_STATE, '') AS State, "
        'sSql = sSql & "ISNULL(GROWER_ZIP, '') AS 'Zip Code', ISNULL(GROWER_COUNTRY, '') AS Country, ISNULL(GROWER_PHONE1, '') AS 'Work Phone', "
        'sSql = sSql & "ISNULL(VENDOR_NAME, '') AS 'Vendor Name', ISNULL(COMMODITIES.COMMODITY_ID, '') AS CommID, "
        'sSql = sSql & "ISNULL(COMMODITIES.COMMODITY_NAME, '') AS Commodity, ISNULL(CURRENT_CROP_YEAR_VOLUME, 0) AS 'CCY Volume', "
        'sSql = sSql & "ISNULL(PREVIOUS_CROP_YEAR_VOLUME, 0) AS 'PCY Volume', ISNULL(PREVIOUS2_CROP_YEAR_VOLUME, 0) AS 'P2CY Volume', "
        'sSql = sSql & "ISNULL(GROWER_NOTE_ID, 0) AS NoteID, ISNULL(GROWER_NOTE_SUBJECT, '') AS 'Note Subject', "
        'sSql = sSql & "ISNULL(GROWER_NOTE_METHOD_ID, 0) AS 'Note Method ID', ISNULL(GROWER_NOTE_TEXT, '') AS 'Note Text', "
        'sSql = sSql & "ISNULL(GROWER_NOTE_CREATION_DATE, '') AS 'Note Creation Date', ISNULL(GROWER_NOTE_CREATED_BY, 0) AS 'Note Creator', "
        'sSql = sSql & "ISNULL(VENDOR_DUMMY, 'N') AS 'Dummy (Y/N)?', ISNULL(GROWER_LAST_NAME, '') AS 'Last Name', "
        'sSql = sSql & "ISNULL(GROWER_FAX, '') AS Fax, ISNULL(GROWER_EMAIL, '') AS Email, ISNULL(GROWER_PHONE2, '') AS 'Cell Phone', "
        'sSql = sSql & "ISNULL(GROWER_ADDRESS_LINE_2, '') As 'Address 2' "
        'sSql = sSql & "FROM GROWERS "
        'sSql = sSql & "LEFT OUTER JOIN GROWER_NOTES "
        'sSql = sSql & "ON GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        'sSql = sSql & "INNER JOIN GROWERS_VENDORS "
        'sSql = sSql & "ON GROWERS_VENDORS.GROWER_ID = GROWERS.GROWER_ID "
        'sSql = sSql & "INNER JOIN ( "
        'sSql = sSql & "VENDORS "
        'sSql = sSql & "LEFT OUTER JOIN ( "
        'sSql = sSql & "VENDOR_SALES_VOLUME "
        'sSql = sSql & "RIGHT OUTER JOIN COMMODITIES COM "
        'sSql = sSql & "ON VENDOR_SALES_VOLUME.COMMODITY_ID = COM.COMMODITY_ID "
        'sSql = sSql & " ) "
        'sSql = sSql & "ON VENDOR_SALES_VOLUME.AGTECH_VENDOR_ID = VENDORS.AGTECH_VENDOR_ID "
        'sSql = sSql & " ) "
        'sSql = sSql & "ON VENDORS.VENDOR_ID = GROWERS_VENDORS.VENDOR_ID "
        'sSql = sSql & "INNER JOIN ( "
        'sSql = sSql & "VENDORS_FACILITIES "
        'sSql = sSql & "INNER JOIN FACILITIES "
        'sSql = sSql & "ON VENDORS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        'sSql = sSql & "INNER JOIN USERS_FACILITIES "
        'sSql = sSql & "ON FACILITIES.FACILITY_ID = USERS_FACILITIES.FACILITY_ID "
        'sSql = sSql & "INNER JOIN USERS "
        'sSql = sSql & "ON USERS.USER_ID = USERS_FACILITIES.USER_ID "
        'sSql = sSql & " ) "
        'sSql = sSql & "ON VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        'sSql = sSql & "INNER JOIN ( "
        'sSql = sSql & "VENDORS_COMMODITIES "
        'sSql = sSql & "INNER JOIN COMMODITIES "
        'sSql = sSql & "ON commodities.COMMODITY_ID = VENDORS_COMMODITIES.COMMODITY_ID "
        'sSql = sSql & " ) "
        'sSql = sSql & "ON VENDORS.VENDOR_ID = VENDORS_COMMODITIES.VENDOR_ID "
        'sSql = sSql & "WHERE users.USER_ID = " & GlobalVariables.UserId.ToString() & " "
        ''sSql = sSql & "WHERE users.USER_ID = 333 "
        'sSql = sSql & "AND growers.GROWER_PROSPECT = 'N' "
        ''sSql = sSql & "AND vendors.vendor_id = 131 "
        ''sSql = sSql & "AND growers.grower_id = 173"
        'sSql = sSql & "ORDER BY GROWERS.GROWER_ID, VENDORS.VENDOR_ID, CommID, 'Note Creation Date'"
        '
        'sSql = "SELECT DISTINCT "
        'sSql = sSql & "GROWERS.GROWER_ID,  VENDORS.VENDOR_ID,  coalesce(GROWER_FIRST_NAME, '') as [First Name], "
        'sSql = sSql & "coalesce(GROWER_ADDRESS_LINE_1, '') as ADDRESS, coalesce(GROWER_CITY, '') as CITY, "
        'sSql = sSql & "coalesce(GROWER_COUNTY, '') as COUNTY, coalesce(GROWER_STATE, '') as STATE, coalesce(GROWER_ZIP, '') as [Zip Code], "
        'sSql = sSql & "coalesce(GROWER_COUNTRY, '') as COUNTRY, coalesce(GROWER_PHONE1, '') as [Work Phone], coalesce(VENDOR_NAME, '') as [Vendor Name], "
        'sSql = sSql & "coalesce(COM.COMMODITY_ID, '') as COMMID, coalesce(COM.COMMODITY_NAME, '') as COMMODITY, coalesce(CURRENT_CROP_YEAR_VOLUME, 0) as [CCY Volume], "
        'sSql = sSql & "coalesce(PREVIOUS_CROP_YEAR_VOLUME, 0) as [PCY Volume], coalesce(PREVIOUS2_CROP_YEAR_VOLUME, 0) as [P2CY Volume], "
        'sSql = sSql & "coalesce(GROWER_NOTE_ID, 0) as NOTEID, coalesce(GROWER_NOTE_SUBJECT, '') as [Note Subject], coalesce(GROWER_NOTE_METHOD_ID, 0) as [Note Method ID], "
        'sSql = sSql & "coalesce(GROWER_NOTE_TEXT, '') as [Note Text], coalesce(GROWER_NOTE_CREATION_DATE, '') as [Note Creation Date], "
        'sSql = sSql & "coalesce(GROWER_NOTE_CREATED_BY, 0) as [Note Creator], coalesce(VENDOR_DUMMY, 'N') as [Dummy (Y/N)?], "
        'sSql = sSql & "coalesce(GROWER_LAST_NAME, '') as [Last Name], coalesce(GROWER_FAX, '') as FAX, coalesce(GROWER_EMAIL, '') as EMAIL, "
        'sSql = sSql & "coalesce(GROWER_PHONE2, '') as [Cell Phone], coalesce(GROWER_ADDRESS_LINE_2, '') as [Address 2], coalesce(GROWER_COMMENT, '') as [Comment], "
        'sSql = sSql & "coalesce(dt_last_update, GETDATE()) "
        'sSql = sSql & "FROM GROWERS "
        'sSql = sSql & "inner join GROWERS_VENDORS "
        'sSql = sSql & " On GROWERS.GROWER_ID = GROWERS_VENDORS.GROWER_ID "
        'sSql = sSql & " inner join ( "
        'sSql = sSql & "    VENDORS "
        'sSql = sSql & "    left outer join ( "
        'sSql = sSql & "     VENDORS_COMMODITIES "
        'sSql = sSql & "      inner join COMMODITIES As com "
        'sSql = sSql & "         On VENDORS_COMMODITIES.COMMODITY_ID = COM.COMMODITY_ID "
        'sSql = sSql & "     ) "
        'sSql = sSql & "        On VENDORS_COMMODITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        'sSql = sSql & "      left outer join VENDOR_SALES_VOLUME "
        'sSql = sSql & "        On VENDOR_SALES_VOLUME.AGTECH_VENDOR_ID = VENDORS.AGTECH_VENDOR_ID "
        'sSql = sSql & " ) "
        'sSql = sSql & "   On VENDORS.VENDOR_ID = GROWERS_VENDORS.VENDOR_ID "
        'sSql = sSql & " inner join ( "
        'sSql = sSql & "   VENDORS_FACILITIES "
        'sSql = sSql & "     inner join FACILITIES "
        'sSql = sSql & "       On VENDORS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        'sSql = sSql & "     inner join USERS_FACILITIES "
        'sSql = sSql & "       On USERS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        'sSql = sSql & "     inner join USERS "
        'sSql = sSql & "       On USERS_FACILITIES.USER_ID = USERS.USER_ID "
        'sSql = sSql & " ) "
        'sSql = sSql & "   On ( "
        'sSql = sSql & "     VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        'sSql = sSql & "     And VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        'sSql = sSql & "   ) "
        'sSql = sSql & " left outer join GROWER_NOTES "
        'sSql = sSql & "   On GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        'sSql = sSql & " cross join GROWERS_VENDORS As g_v "
        'sSql = sSql & "WHERE VENDOR_SALES_VOLUME.COMMODITY_ID = com.commodity_id "
        'sSql = sSql & "And Users.User_id = " & GlobalVariables.UserId.ToString() & " "
        'sSql = sSql & "ORDER BY GROWERS.GROWER_ID, VENDORS.VENDOR_ID, CommID, 'Note Creation Date'"
        '
        sSql = "SELECT DISTINCT "
        sSql = sSql & "GROWERS.GROWER_ID, VENDORS.VENDOR_ID, coalesce(GROWER_FIRST_NAME, '') [First Name], "
        sSql = sSql & "coalesce(GROWER_ADDRESS_LINE_1, '') ADDRESS, coalesce(GROWER_CITY, '') CITY, "
        sSql = sSql & "coalesce(GROWER_COUNTY, '') COUNTY, coalesce(GROWER_STATE, '') STATE, "
        sSql = sSql & "coalesce(GROWER_ZIP, '') [Zip Code], coalesce(GROWER_COUNTRY, '') COUNTRY, "
        sSql = sSql & "coalesce(GROWER_PHONE1, '') [Work Phone], coalesce(VENDOR_NAME, '') [Vendor Name], "
        sSql = sSql & "coalesce(COMMODITIES.COMMODITY_ID, '') COMMID, "
        sSql = sSql & "coalesce(COMMODITIES.COMMODITY_NAME, '') COMMODITY, coalesce(CURRENT_CROP_YEAR_VOLUME, 0) [CCY Volume], "
        sSql = sSql & "coalesce(PREVIOUS_CROP_YEAR_VOLUME, 0) [PCY Volume], coalesce(PREVIOUS2_CROP_YEAR_VOLUME, 0) [P2CY Volume], "
        sSql = sSql & "coalesce(GROWER_NOTE_ID, 0) NOTEID, coalesce(GROWER_NOTE_SUBJECT, '') [Note Subject], "
        sSql = sSql & "coalesce(GROWER_NOTE_METHOD_ID, 0) [Note Method ID], coalesce(GROWER_NOTE_TEXT, '') [Note Text], "
        sSql = sSql & "coalesce(GROWER_NOTE_CREATION_DATE, '') [Note Creation Date], coalesce(GROWER_NOTE_CREATED_BY, 0) [Note Creator], "
        sSql = sSql & "coalesce(VENDOR_DUMMY, 'N') [Dummy (Y/N)?], coalesce(GROWER_LAST_NAME, '') [Last Name], "
        sSql = sSql & "coalesce(GROWER_FAX, '') FAX, coalesce(GROWER_EMAIL, '') EMAIL, coalesce(GROWER_PHONE2, '') [Cell Phone], "
        sSql = sSql & "coalesce(GROWER_ADDRESS_LINE_2, '') [Address 2], coalesce(GROWER_COMMENT, ''), "
        sSql = sSql & "coalesce(DT_LAST_UPDATE, CONVERT(DATETIME,'01/01/1926',103)) "
        sSql = sSql & "FROM USERS "
        sSql = sSql & "  join USERS_FACILITIES "
        sSql = sSql & "    on USERS.USER_ID = USERS_FACILITIES.USER_ID "
        sSql = sSql & "  join FACILITIES "
        sSql = sSql & "    on FACILITIES.FACILITY_ID = USERS_FACILITIES.FACILITY_ID "
        sSql = sSql & "  join VENDORS_FACILITIES "
        sSql = sSql & "    on VENDORS_FACILITIES.FACILITY_ID = FACILITIES.FACILITY_ID "
        sSql = sSql & "  join ( "
        sSql = sSql & "    VENDORS "
        sSql = sSql & "      join GROWERS_VENDORS "
        sSql = sSql & "        on GROWERS_VENDORS.VENDOR_ID = VENDORS.VENDOR_ID "
        sSql = sSql & "      join ( "
        sSql = sSql & "        GROWERS "
        sSql = sSql & "          left outer join GROWER_NOTES "
        sSql = sSql & "            on GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "      ) "
        sSql = sSql & "        on GROWERS_VENDORS.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "      left outer join ( "
        sSql = sSql & "        VENDOR_SALES_VOLUME "
        sSql = sSql & "          join COMMODITIES "
        sSql = sSql & "            on VENDOR_SALES_VOLUME.COMMODITY_ID = COMMODITIES.COMMODITY_ID "
        sSql = sSql & "      ) "
        sSql = sSql & "        on VENDOR_SALES_VOLUME.AGTECH_VENDOR_ID = VENDORS.AGTECH_VENDOR_ID "
        sSql = sSql & "  ) "
        sSql = sSql & "    on VENDORS_FACILITIES.VENDOR_ID = VENDORS.VENDOR_ID "
        sSql = sSql & "WHERE Users.User_id = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "ORDER BY GROWERS.GROWER_ID, VENDORS.VENDOR_ID, COMMID, [Note Creation Date]"

        myCmd.CommandText = sSql
        'oConn.Open()
        'oComm


        oReader = myCmd.ExecuteReader()

        iGrowerID = -1
        oCollGrowVendComm.Clear()

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
                oGVC.VendorDummy = oReader.GetString(22)
                oGVC.GrowerLastName = oReader.GetString(23)
                oGVC.GrowerFax = oReader.GetString(24)
                oGVC.GrowerEmail = oReader.GetString(25)
                oGVC.GrowerPhone2 = oReader.GetString(26)
                oGVC.GrowerAddress2 = oReader.GetString(27)
                oGVC.GrowerComment = oReader.GetString(28)
                oGVC.GrowerLastUpdate = oReader.GetDateTime(29)

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
                If Not oNoteMethods.Contains(oReader.GetInt32(0).ToString()) Then
                    oNoteMethods.Add(oReader.GetString(1), oReader.GetInt32(0).ToString())
                End If
            Loop
        End If
        oReader.Close()
        'oReader = Nothing
        iMax = oCollGrowVendComm.Count
        iCnt = 1

        Do While iCnt <= iMax
            If oCollGrowVendComm(iCnt).GrowerId <> iGrowerID Then
                'Dim oGrowerListItem As New IndexedGrowerListItem


                iGrowerID = oCollGrowVendComm(iCnt).GrowerId

                Dim oGrower As New Grower()
                oGrower.GrowerFirstName = oCollGrowVendComm(iCnt).GrowerFirstName
                oGrower.GrowerLastName = oCollGrowVendComm(iCnt).GrowerLastName
                oGrower.GrowerID = oCollGrowVendComm(iCnt).GrowerId
                oGrower.GrowerAddress1 = oCollGrowVendComm(iCnt).GrowerAddress1
                oGrower.GrowerCity = oCollGrowVendComm(iCnt).GrowerCity
                oGrower.GrowerCounty = oCollGrowVendComm(iCnt).GrowerCounty
                oGrower.GrowerState = oCollGrowVendComm(iCnt).GrowerState
                oGrower.GrowerCountry = oCollGrowVendComm(iCnt).GrowerCountry
                oGrower.GrowerZip = oCollGrowVendComm(iCnt).GrowerZip
                oGrower.GrowerPhone1 = oCollGrowVendComm(iCnt).GrowerPhone1
                oGrower.GrowerPhone2 = oCollGrowVendComm(iCnt).GrowerPhone2
                oGrower.GrowerFax = oCollGrowVendComm(iCnt).GrowerFax
                oGrower.GrowerEmail = oCollGrowVendComm(iCnt).GrowerEmail
                oGrower.GrowerComment = oCollGrowVendComm(iCnt).GrowerComment
                oGrower.GrowerProspect = "N"
                oGrower.GrowerLastUpdate = oCollGrowVendComm(iCnt).GrowerLastUpdate

                sLastName = oCollGrowVendComm(iCnt).GrowerLastName
                sFirstName = oCollGrowVendComm(iCnt).GrowerFirstName
                sProspFlag = " "
                sAddress = oGrower.GrowerAddress1
                If Len(oGrower.GrowerAddress2) > 0 Then
                    sAddress = sAddress & vbCrLf & oGrower.GrowerAddress2
                End If
                sCity = oGrower.GrowerCity
                sState = oGrower.GrowerState
                sCounty = oGrower.GrowerCounty
                sZip = oGrower.GrowerZip
                sCountry = oGrower.GrowerCountry
                sWorkPhone = oGrower.GrowerPhone1
                sCellPhone = oGrower.GrowerPhone2
                sFax = oGrower.GrowerFax
                sEmail = oGrower.GrowerEmail
                sComment = oGrower.GrowerComment
                sLastUpdate = oGrower.GrowerLastUpdate.ToString("yyyy-MM-dd HH:mm:ss")


                iVendorID = -1
                Do While iGrowerID = oCollGrowVendComm(iCnt).GrowerId

                    If iVendorID <> oCollGrowVendComm(iCnt).VendorId Then
                        iVendorID = oCollGrowVendComm(iCnt).VendorId

                        'Dim oVendor As New Vendor()
                        oVendor = GlobalVariables.VendorList(iVendorID.ToString())


                        sCommID = ""
                        oVendor.CollCommodities.Clear()

                        Do While iVendorID = oCollGrowVendComm(iCnt).VendorID And iGrowerID = oCollGrowVendComm(iCnt).GrowerId

                            sCommID = oCollGrowVendComm(iCnt).CommID
                            Dim oComm As New Commodity
                            oComm.CommID = sCommID
                            If Not oVendor.CollCommodities.Contains(sCommID) Then
                                oComm.VendorID = iVendorID
                                oComm.CommName = oCollGrowVendComm(iCnt).CommName
                                oComm.CurrentCropYear = oCollGrowVendComm(iCnt).CurrentCropYear
                                oComm.PreviousCropYear = oCollGrowVendComm(iCnt).PreviousCropYear
                                oComm.Previous2CropYear = oCollGrowVendComm(iCnt).Previous2CropYear
                                oVendor.CollCommodities.Add(oComm, oComm.CommID)
                            Else
                                bDupComm = False
                                iCommCnt = 1
                                iCommMax = oVendor.CollCommodities.Count
                                Do While iCommCnt <= iCommMax
                                    If ((oVendor.CollCommodities(iCommCnt).Vendorid = iVendorID) And (oVendor.CollCommodities(iCommCnt).CommID = sCommID)) Then
                                        bDupComm = True
                                        Exit Do
                                    End If
                                    iCommCnt = iCommCnt + 1
                                Loop
                                If bDupComm Then
                                    'Do Nothing
                                Else
                                    oVendor.CollCommodities(sCommID).CurrentCropYear = oVendor.CollCommodities(sCommID).CurrentCropYear + oCollGrowVendComm(iCnt).CurrentCropYear
                                    oVendor.CollCommodities(sCommID).PreviousCropYear = oVendor.CollCommodities(sCommID).PreviousCropYear + oCollGrowVendComm(iCnt).PreviousCropYear
                                    oVendor.CollCommodities(sCommID).Previous2CropYear = oVendor.CollCommodities(sCommID).Previous2CropYear + oCollGrowVendComm(iCnt).PreviousCropYear

                                End If
                            End If
                            iCnt = iCnt + 1
                            If iCnt >= iMax Then

                                Exit Do
                            End If

                        Loop
                        oGrower.Vendors.Add(oVendor)
                    Else
                        iCnt = iCnt + 1
                    End If
                    'iCnt = iCnt + 1
                    If iCnt >= iMax Then
                        If Not oGrowerColl.Contains(oGrower.GrowerID.ToString()) Then
                            oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())
                            dgvGrowers.Rows.Add(sLastName, sFirstName, sLastUpdate, " ", sAddress, sCity, sState, sCounty, sZip, sCellPhone, sWorkPhone, sFax, sEmail, sComment, sCountry, oGrower.GrowerID.ToString())
                            'oGrowerListItem.CollectionIndex = oGrowerColl.Count
                            'ListBox1.Items.Add(oGrowerListItem)
                        End If
                        Exit Do
                    End If
                Loop
                If iCnt <= iMax Then
                    If iGrowerID <> oCollGrowVendComm(iCnt).GrowerId Then
                        If Not oGrowerColl.Contains(oGrower.GrowerID.ToString()) Then
                            oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())
                            dgvGrowers.Rows.Add(sLastName, sFirstName, sLastUpdate, " ", sAddress, sCity, sState, sCounty, sZip, sCellPhone, sWorkPhone, sFax, sEmail, sComment, sCountry, oGrower.GrowerID.ToString())

                            'oGrowerListItem.CollectionIndex = oGrowerColl.Count

                            'ListBox1.Items.Add(oGrowerListItem)
                        End If

                    End If
                    'iCnt = iCnt - 1 'Move the pointer back one so the outside loop can advance to the next record

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
            GlobalVariables.UserList.Clear()
            Do While oReader.Read()
                GlobalVariables.UserList.Add(oReader.GetString(1), oReader.GetInt32(0).ToString())
            Loop
        End If
        Do While iCnt <= iMax
            If oCollGrowVendComm(iCnt).GrowerId <> iGrowerID Then
                iGrowerID = oCollGrowVendComm(iCnt).GrowerId
                'If iGrowerID = 1183 Then MessageBox.Show("Found Mr. Rostad")
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
                            'oNote.GrowerNoteCreatedByLogin = GlobalVariables.UserList(oNote.GrowerNoteCreatedBy)
                            oNote.GrowerNoteCreatedByLogin = GlobalVariables.UserList(oCollGrowVendComm(iCnt).GrowerNoteCreatedBy.ToString())
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
                            If Not oGrowerColl(oCollGrowVendComm(iMax).GrowerId.ToString()).Notes.Contains(oNote.GrowerNoteId.ToString()) Then

                                oGrowerColl(oCollGrowVendComm(iMax).GrowerId.ToString()).Notes.Add(oNote, oNote.GrowerNoteId.ToString())
                            End If
                            Exit Do

                        End If

                    End If
                    If iCnt > iMax Then Exit Do
                Loop
            End If
            iCnt = iCnt + 1
        Loop

        sSql = "SELECT DISTINCT GROWERS.GROWER_ID, VENDORS.VENDOR_ID, ISNULL(GROWER_FIRST_NAME, '') AS 'First Name', ISNULL(GROWER_ADDRESS_LINE_1, '') AS Address, "
        sSql = sSql & "ISNULL(GROWER_CITY, '') AS City, ISNULL(GROWER_COUNTY, '') AS County, ISNULL(GROWER_STATE, '') AS State, "
        sSql = sSql & "ISNULL(GROWER_ZIP, '') AS 'Zip Code', ISNULL(GROWER_COUNTRY, '') AS Country, ISNULL(GROWER_PHONE1, '') AS 'Work Phone', "
        sSql = sSql & "ISNULL(VENDOR_NAME, '') AS 'Vendor Name', ISNULL(GROWER_PHONE2, '') AS 'Cell Phone', ISNULL(GROWER_FAX, '') AS Fax, "
        sSql = sSql & "ISNULL(GROWER_EMAIL, '') AS Email, "
        sSql = sSql & "ISNULL(VENDOR_DUMMY, 'N') AS 'Dummy (Y/N)?', ISNULL(GROWER_LAST_NAME, '') AS 'Last Name', "
        sSql = sSql & "ISNULL(GROWER_ADDRESS_LINE_2, '') As 'Address 2', ISNULL(GROWER_COMMENT, '') As 'Comment', "
        sSql = sSql & "ISNULL(dt_last_update, GETDATE()) "
        sSql = sSql & "FROM growers, growers_vendors, vendors, users, facilities, users_facilities, vendors_facilities "
        sSql = sSql & "WHERE growers_vendors.grower_id = growers.grower_id "
        sSql = sSql & "AND growers_vendors.vendor_id = vendors.vendor_id "
        sSql = sSql & "AND vendors_facilities.vendor_id = vendors.vendor_id "
        sSql = sSql & "AND vendors_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND users_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND users_facilities.user_id = users.user_id "
        sSql = sSql & "AND grower_prospect = 'Y' "
        sSql = sSql & "AND users.user_id = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "ORDER BY growers.grower_id, vendors.vendor_id"

        myCmd.CommandText = sSql
        oReader.Close()
        oReader = myCmd.ExecuteReader()
        If oReader.HasRows Then
            Do While oReader.Read()
                Dim oPRec As New ProspectRec
                oPRec.GrowerID = oReader.GetInt32(0)
                oPRec.GrowerFirstName = oReader.GetString(2)
                oPRec.GrowerLastName = oReader.GetString(15)
                oPRec.GrowerAddress = oReader.GetString(3)
                oPRec.GrowerAddress2 = oReader.GetString(16)
                oPRec.GrowerCity = oReader.GetString(4)
                oPRec.GrowerState = oReader.GetString(6)
                oPRec.GrowerCountry = oReader.GetString(8)
                oPRec.GrowerZip = oReader.GetString(7)
                oPRec.GrowerPhone1 = oReader.GetString(9)
                oPRec.GrowerPhone2 = oReader.GetString(11)
                oPRec.GrowerFax = oReader.GetString(12)
                oPRec.GrowerEmail = oReader.GetString(13)
                oPRec.VendorID = oReader.GetInt32(1)
                oPRec.VendorName = oReader.GetString(10)
                oPRec.VendorDummy = oReader.GetString(14)
                oPRec.GrowerComment = oReader.GetString(17)
                oPRec.GrowerLastUpdate = oReader.GetDateTime(18)
                oProspectRecs.Add(oPRec)
            Loop
        End If
        iCnt = 1
        iMax = oProspectRecs.Count
        iGrowerID = -1
        iVendorID = -1
        Do While iCnt <= iMax
            If iGrowerID <> oProspectRecs(iCnt).GrowerID Then
                iGrowerID = oProspectRecs(iCnt).GrowerID
                Dim oGrower As New Grower
                'Dim oGrowerListItem As New IndexedGrowerListItem
                sName = Trim(oProspectRecs(iCnt).GrowerFirstName & " " & oProspectRecs(iCnt).GrowerLastName)

                'oGrowerListItem.GrowerName = sName & " - PROSPECT"
                oGrower.GrowerFirstName = oProspectRecs(iCnt).GrowerFirstName
                oGrower.GrowerLastName = oProspectRecs(iCnt).GrowerLastName
                oGrower.GrowerID = iGrowerID
                oGrower.GrowerAddress1 = oProspectRecs(iCnt).GrowerAddress
                oGrower.GrowerAddress2 = oProspectRecs(iCnt).GrowerAddress2
                oGrower.GrowerCity = oProspectRecs(iCnt).GrowerCity
                oGrower.GrowerState = oProspectRecs(iCnt).GrowerState
                oGrower.GrowerCountry = oProspectRecs(iCnt).GrowerCountry
                oGrower.GrowerZip = oProspectRecs(iCnt).GrowerZip
                oGrower.GrowerPhone1 = oProspectRecs(iCnt).GrowerPhone1
                oGrower.GrowerPhone2 = oProspectRecs(iCnt).GrowerPhone2
                oGrower.GrowerFax = oProspectRecs(iCnt).GrowerFax
                oGrower.GrowerEmail = oProspectRecs(iCnt).GrowerEmail
                oGrower.GrowerComment = oProspectRecs(iCnt).GrowerComment
                oGrower.GrowerProspect = "Y"
                oGrower.GrowerLastUpdate = oProspectRecs(iCnt).GrowerLastUpdate
                sLastName = oGrower.GrowerLastName
                sFirstName = oGrower.GrowerFirstName
                sProspFlag = " "
                sAddress = oGrower.GrowerAddress1
                If Len(oGrower.GrowerAddress2) > 0 Then
                    sAddress = sAddress & vbCrLf & oGrower.GrowerAddress2
                End If
                sCity = oGrower.GrowerCity
                sState = oGrower.GrowerState
                sCounty = oGrower.GrowerCounty
                sZip = oGrower.GrowerZip
                sCountry = oGrower.GrowerCountry
                sWorkPhone = oGrower.GrowerPhone1
                sCellPhone = oGrower.GrowerPhone2
                sFax = oGrower.GrowerFax
                sEmail = oGrower.GrowerEmail
                sComment = oGrower.GrowerComment
                sLastUpdate = oGrower.GrowerLastUpdate.ToString()

                Do While iGrowerID = oProspectRecs(iCnt).GrowerID
                    'If iVendorID <> oProspectRecs(iCnt).VendorID Then
                    'Dim oVendor As New Vendor
                    oVendor = GlobalVariables.VendorList(oProspectRecs(iCnt).VendorID.ToString())
                    iVendorID = oProspectRecs(iCnt).VendorID
                    oVendor.VendorID = iVendorID
                    iVendorID = oProspectRecs(iCnt).VendorID
                    oVendor.VendorName = oProspectRecs(iCnt).VendorName
                    oVendor.VendorDummy = oProspectRecs(iCnt).VendorDummy
                    oGrower.Vendors.Add(oVendor)
                    'End If


                    If Not oGrowerColl.Contains(oGrower.GrowerID.ToString()) Then
                        oGrowerColl.Add(oGrower, oGrower.GrowerID.ToString())

                        dgvGrowers.Rows.Add(sLastName, sFirstName, sLastUpdate, "P", sAddress, sCity, sState, sCounty, sZip, sCellPhone, sWorkPhone, sFax, sEmail, sComment, sCountry, oGrower.GrowerID.ToString())

                        'oGrowerListItem.CollectionIndex = oGrowerColl.Count
                        'ListBox1.Items.Add(oGrowerListItem)
                    End If
                    iCnt = iCnt + 1
                    If iCnt > iMax Then Exit Do
                Loop
                If iCnt <= iMax Then
                    If iGrowerID <> oProspectRecs(iCnt).GrowerID Then
                        iCnt = iCnt - 1
                    End If

                    'iCnt = iCnt + 1
                    If iCnt > iMax Then Exit Do
                    'End If
                    iCnt = iCnt + 1
                End If

            Else
                iCnt = iCnt + 1
                If iCnt > iMax Then Exit Do
            End If
        Loop

        sSql = "SELECT growers.grower_id, ISNULL(GROWER_NOTE_SUBJECT, '') AS 'Note Subject', ISNULL(GROWER_NOTES.GROWER_NOTE_METHOD_ID, 0) AS 'Note Method ID', "
        sSql = sSql & "ISNULL(GROWER_NOTE_TEXT, '') AS 'Note Text', ISNULL(GROWER_NOTE_CREATION_DATE, '') AS 'Note Creation Date', ISNULL(GROWER_NOTE_CREATED_BY, 0) AS 'Grower Created By ID', "
        sSql = sSql & "b.user_login, grower_note_method_short_name, grower_note_id "
        sSql = sSql & "FROM growers, grower_notes, grower_note_methods, growers_vendors, vendors, users, facilities, users_facilities, vendors_facilities, users as b "
        sSql = sSql & "WHERE grower_notes.grower_id = growers.grower_id "
        sSql = sSql & "AND grower_note_methods.grower_note_method_id = grower_notes.grower_note_method_id "
        sSql = sSql & "AND growers_vendors.grower_id = growers.grower_id "
        sSql = sSql & "AND growers_vendors.vendor_id = vendors.vendor_id "
        sSql = sSql & "AND users_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND users_facilities.user_id = users.user_id "
        sSql = sSql & "AND vendors_facilities.vendor_id = vendors.vendor_id "
        sSql = sSql & "AND vendors_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND b.user_id = grower_notes.grower_note_created_by "
        sSql = sSql & "AND users.user_id = " & GlobalVariables.UserId.ToString() & " "
        'sSql = sSql & "AND users.user_id = 333 "
        sSql = sSql & "AND grower_prospect = 'Y' "
        sSql = sSql & "ORDER BY growers.grower_id, vendors.vendor_id, grower_note_id"

        myCmd.CommandText = sSql
        oReader.Close()
        oReader = myCmd.ExecuteReader()

        If oReader.HasRows Then
            Do While oReader.Read()
                Dim oPNoteRec As New ProspectNotesRec
                oPNoteRec.GrowerID = oReader.GetInt32(0)
                oPNoteRec.GrowerNoteSubject = oReader.GetString(1)
                oPNoteRec.GrowerNoteMethod = oReader.GetInt32(2)
                oPNoteRec.GrowerNoteMethodText = oReader.GetString(7)
                oPNoteRec.GrowerNoteText = oReader.GetString(3)
                'oPNoteRec.GrowerNoteID = oReader.GetInt32(11)
                oPNoteRec.GrowerNoteCreationDate = oReader.GetDateTime(4)
                oPNoteRec.GrowerNoteCreatedBy = oReader.GetInt32(5)
                oPNoteRec.GrowerNoteCreatedByLogin = oReader.GetString(6)
                oPNoteRec.GrowerNoteID = oReader.GetInt32(8)
                oProspectNoteRecs.Add(oPNoteRec)
            Loop
        End If
        '
        iCnt = 1
        iMax = oProspectNoteRecs.Count
        iGrowerID = -1
        Do While iCnt <= iMax
            If iGrowerID <> oProspectNoteRecs(iCnt).GrowerID Then
                iGrowerID = oProspectNoteRecs(iCnt).GrowerID
                oGrowerColl(oProspectNoteRecs(iCnt).GrowerID.ToString()).Notes.Clear()
                Do While iGrowerID = oProspectNoteRecs(iCnt).GrowerID
                    Dim oNote As New Note
                    oNote.GrowerId = oProspectNoteRecs(iCnt).GrowerID
                    oNote.GrowerNoteSubject = oProspectNoteRecs(iCnt).GrowerNoteSubject
                    oNote.GrowerNoteMethodText = oProspectNoteRecs(iCnt).GrowerNoteMethodText
                    oNote.GrowerNoteText = oProspectNoteRecs(iCnt).GrowerNoteText
                    oNote.GrowerNoteCreationDate = oProspectNoteRecs(iCnt).GrowerNoteCreationDate
                    oNote.GrowerNoteCreatedByLogin = oProspectNoteRecs(iCnt).GrowerNoteCreatedByLogin
                    oNote.GrowerNoteId = oProspectNoteRecs(iCnt).GrowerNoteID
                    If Not oGrowerColl(oProspectNoteRecs(iCnt).GrowerID.ToString()).Notes.Contains(oNote.GrowerNoteId.ToString()) Then
                        oGrowerColl(oProspectNoteRecs(iCnt).GrowerID.ToString()).Notes.Add(oNote, oNote.GrowerNoteId.ToString())
                    End If
                    iCnt = iCnt + 1
                    If iCnt > iMax Then Exit Do
                Loop
            End If


        Loop

        iGrowerID = -1
        sSql = "SELECT DISTINCT growers.grower_id, ISNULL(commodity_name, '') As CommName, ISNULL(status, '') As Status , ISNULL(sold_to, ''), volume_bu, updated_date, ISNULL(location, ''), "
        sSql = sSql & "nonCGIcrop_id, ISNULL(commodities.commodity_id, ''), ISNULL(farmstorage, 'N') "
        sSql = sSql & "FROM commodities, nonCGIcrop, users, facilities, users_facilities, vendors, vendors_facilities, growers, growers_vendors "
        sSql = sSql & "WHERE nonCGIcrop.commodity_id = commodities.commodity_id "
        sSql = sSql & "AND users_facilities.user_id = users.user_id "
        sSql = sSql & "AND facilities.facility_id = users_facilities.facility_id "
        sSql = sSql & "AND vendors_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
        sSql = sSql & "AND nonCGICrop.grower_id = growers.grower_id "
        sSql = sSql & "AND growers_vendors.grower_id = growers.grower_id "
        sSql = sSql & "AND growers_vendors.vendor_id = vendors.vendor_id "
        sSql = sSql & "AND users.user_id = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "ORDER BY grower_id, CommName, status"
        myCmd.CommandText = sSql
        oReader.Close()
        oReader = myCmd.ExecuteReader()
        oOtherCropsRec.Clear()
        If oReader.HasRows Then
            Do While oReader.Read()
                Dim oNonCGIRec As New NonCGIRec
                oNonCGIRec.GrowerID = oReader.GetInt32(0)
                oNonCGIRec.CommodityID = oReader.GetString(1)
                oNonCGIRec.Status = oReader.GetString(2)
                oNonCGIRec.SoldTo = oReader.GetString(3)
                oNonCGIRec.Volume = oReader.GetInt32(4)
                oNonCGIRec.UpdatedDate = oReader.GetDateTime(5)
                oNonCGIRec.Location = oReader.GetString(6)
                oNonCGIRec.nonCGIcrop_id = oReader.GetInt32(7)
                oNonCGIRec.AgCommID = oReader.GetString(8)
                oNonCGIRec.FarmStorage = oReader.GetString(9)
                oOtherCropsRec.Add(oNonCGIRec)

            Loop
        End If

        iCnt = 1
        iMax = oOtherCropsRec.Count

        Do While iCnt <= iMax
            If iGrowerID <> oOtherCropsRec(iCnt).GrowerID Then
                iGrowerID = oOtherCropsRec(iCnt).GrowerID
                oGrowerColl(iGrowerID.ToString()).OtherCrops.Clear()
                Do While iGrowerID = oOtherCropsRec(iCnt).GrowerID
                    Dim oNonCGI As New NonCGI
                    oNonCGI.UpdatedDate = oOtherCropsRec(iCnt).UpdatedDate
                    oNonCGI.NonCGICommodity = oOtherCropsRec(iCnt).CommodityID
                    oNonCGI.Status = oOtherCropsRec(iCnt).Status
                    oNonCGI.SoldTo = oOtherCropsRec(iCnt).SoldTo
                    oNonCGI.Volume = oOtherCropsRec(iCnt).Volume
                    oNonCGI.Location = oOtherCropsRec(iCnt).Location
                    oNonCGI.NonCGICropID = oOtherCropsRec(iCnt).nonCGIcrop_id
                    oNonCGI.NonCGICommID = oOtherCropsRec(iCnt).AgCommID
                    oNonCGI.FarmStorage = oOtherCropsRec(iCnt).FarmStorage
                    oGrowerColl(iGrowerID.ToString()).OtherCrops.Add(oNonCGI, oNonCGI.NonCGICropID.ToString())
                    iCnt = iCnt + 1
                    If iCnt > iMax Then Exit Do
                Loop
            End If
        Loop

        If Not GlobalVariables.ResetGrower Then
            'If ListBox1.Items.Count >= 1 Then
            If dgvGrowers.Rows.Count >= 1 Then
                btnEditGrower.Enabled = True
                'ListBox1.SetSelected(0, True)
                dgvGrowers.Rows(0).Selected = True
            Else
                ckVendor1.Visible = False
                ckVendor2.Visible = False
                ckVendor3.Visible = False
                ckVendor4.Visible = False
                ckVendor5.Visible = False
                ckVendor6.Visible = False
                ckVendor7.Visible = False
                ckVendor8.Visible = False
                btnAddNote.Enabled = False
                btnEditGrower.Enabled = False
            End If
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
        lvCommoditySales.Columns(0).Text = "Commodity"
        lvCommoditySales.Columns(1).Text = "C.C.Year"
        lvCommoditySales.Columns(2).Text = "P.C.Year"
        lvCommoditySales.Columns(3).Text = "P2.C.Year"

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        '        Dim iCnt As Integer
        '        Dim iMax As Integer
        '        Dim sNote As String
        '        Dim sBuildDate As String
        '        Dim oSelItem As IndexedGrowerListItem = ListBox1.SelectedItem'
        '
        '        If ListBox1.SelectedIndex >= 0 Then'
        '
        '        lblName.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerFirstName.ToString() & " " & oGrowerColl(oSelItem.CollectionIndex).GrowerLastName.ToString()
        '        'lblLastName.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerLastName.ToString()
        '        lblAddress.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerAddress1.ToString()
        '        lblGrowerCity.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerCity.ToString()
        '        lblGrowerState.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerState.ToString()
        '        lblGrowerCountry.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerCountry.ToString()
        '        lblGrowerZip.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerZip.ToString()
        '        lblWorkPhone.Text = "W: " & oGrowerColl(oSelItem.CollectionIndex).GrowerPhone1.ToString()
        '        lblCellPhone.Text = "C: " & oGrowerColl(oSelItem.CollectionIndex).GrowerPhone2.ToString()
        '        lblFax.Text = "F: " & oGrowerColl(oSelItem.CollectionIndex).GrowerFax.ToString()
        '        lblEmail.Text = oGrowerColl(oSelItem.CollectionIndex).GrowerEmail.ToString()
        '        txtComment.Text = oGrowerColl(oSelItem.CollectionIndex).Growercomment.ToString()'
        ''
        ''
        '
        '        iCnt = 1
        '        If Not GlobalVariables.EditedGrower Then
        '        GlobalVariables.BuildComm = False
        '        End If
        '        GlobalVariables.BuildNonCGI = False'
        '
        '        iMax = oGrowerColl(oSelItem.CollectionIndex).Vendors.Count
        '        'ckVendor1.Checked = False
        '        ckVendor1.CheckState = CheckState.Unchecked
        '        ckVendor1.Visible = False'
        '
        '        'ckVendor2.Checked = False
        '        ckVendor2.CheckState = CheckState.Unchecked
        '        ckVendor2.Visible = False'
        '
        '        'ckVendor3.Checked = False
        '        ckVendor3.CheckState = CheckState.Unchecked
        '        ckVendor3.Visible = False'
        '
        '        'ckVendor4.Checked = False
        '        ckVendor4.CheckState = CheckState.Unchecked
        '        ckVendor4.Visible = False'
        '
        '        'ckVendor5.Checked = False
        '        ckVendor5.CheckState = CheckState.Unchecked
        '        ckVendor5.Visible = False'
        '
        '        'ckVendor6.Checked = False
        '        ckVendor6.CheckState = CheckState.Unchecked
        '        ckVendor6.Visible = False'
        '
        '        'ckVendor7.Checked = False
        '        ckVendor7.CheckState = CheckState.Unchecked
        '        ckVendor7.Visible = False'
        '
        '        'ckVendor8.Checked = False
        '        ckVendor8.CheckState = CheckState.Unchecked
        '        ckVendor8.Visible = False
        '        If oGrowerColl(oSelItem.CollectionIndex).Vendors(1).VendorDummy = "N" Then
        '        Do While iCnt <= iMax'
        '
        '        If iCnt > 8 Then Exit Do 'There are only 8 checkboxes
        '        Select Case iCnt
        '        Case 1
        '        ckVendor1.Visible = True
        '        ckVendor1.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor1.Checked = True
        '       Case 2
        '       ckVendor2.Visible = True
        '       ckVendor2.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor2.Checked = True
        '       Case 3
        '       ckVendor3.Visible = True
        '       ckVendor3.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor3.Checked = True
        '       Case 4
        '       ckVendor4.Visible = True
        '       ckVendor4.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor4.Checked = True
        '       Case 5
        '       ckVendor5.Visible = True
        '       ckVendor5.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor5.Checked = True
        '       Case 6
        '       ckVendor6.Visible = True
        '       ckVendor6.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor6.Checked = True
        '       Case 7
        '       ckVendor7.Visible = True
        '       ckVendor7.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor7.Checked = True
        '       Case 8
        '       ckVendor8.Visible = True
        '       ckVendor8.Text = oGrowerColl(oSelItem.CollectionIndex).Vendors(iCnt).VendorName
        '       ckVendor8.Checked = True
        '       End Select
        '
        '
        '       iCnt = iCnt + 1
        '       Loop
        '
        '        End If
        '       GlobalVariables.BuildComm = True
        '       GlobalVariables.BuildNonCGI = True
        '
        '        TestDataGrid.Rows.Clear()
        '        Dim oDict As New List(Of String)
        '        Dim oNoteRows As New Collection
        '        For Each oNote In oGrowerColl(oSelItem.CollectionIndex).Notes
        '        sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & vbCrLf & vbCrLf & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
        '        sNote = sNote & Month(oNote.GrowerNoteCreationDate).ToString() & "/"
        '        sNote = sNote & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString() & "/"
        '        sNote = sNote & Year(oNote.GrowerNoteCreationDate).ToString() & " "
        '        sNote = sNote & Hour(oNote.GrowerNoteCreationDate).ToString() & ":"
        '        sNote = sNote & Minute(oNote.GrowerNoteCreationDate).ToString & ":"
        '        sNote = sNote & Second(oNote.GrowerNoteCreationDate).ToString()'
        '
        '        sBuildDate = Year(oNote.GrowerNoteCreationDate).ToString()
        '        sBuildDate = sBuildDate & Replace(Month(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
        '        sBuildDate = sBuildDate & Replace(Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
        '        sBuildDate = sBuildDate & Replace(Hour(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
        '        sBuildDate = sBuildDate & Replace(Minute(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
        '        sBuildDate = sBuildDate & Replace(Second(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
        '        Dim oCurNoteItem As New NoteListItem
        '        oCurNoteItem.CreateDate = sBuildDate
        '        oCurNoteItem.NoteText = sNote
        '        If Not oNoteRows.Contains(oCurNoteItem.CreateDate) Then
        '        oNoteRows.Add(oCurNoteItem, oCurNoteItem.CreateDate)
        '        End If
        '        oDict.Add(sBuildDate)
        '        Next'
        '
        '        oDict.Sort()
        '        oDict.Reverse()
        '        For Each sDate In oDict
        '        TestDataGrid.Rows.Add(New String() {oNoteRows(sDate).NoteText})
        '        Next
        '        oDict = Nothing
        '        oNoteRows = Nothing
        '        End If
        '        If oGrowerColl(oSelItem.CollectionIndex).GrowerProspect = "N" Then
        '        BuildCommodityList(oSelItem.CollectionIndex)
        '        End If

        '        BuildNonCGIList(oSelItem.CollectionIndex)
        '
    End Sub



    Private Sub lvCommoditySales_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles lvCommoditySales.DrawItem
        e.DrawDefault = True

    End Sub

    Private Sub lvCommoditySales_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvCommoditySales.DrawColumnHeader

        e.Graphics.FillRectangle(Brushes.Red, e.Bounds)
        e.DrawText()

    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub ckVendor2_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor2.CheckedChanged
        'Dim oSelItem As IndexedGrowerListItem = Me.ListBox1.SelectedItem
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor6_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor6.CheckedChanged
        'Dim oSelItem As IndexedGrowerListItem = Me.ListBox1.SelectedItem
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor1_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor1.CheckedChanged
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor3_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor3.CheckedChanged
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor4_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor4.CheckedChanged
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor5_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor5.CheckedChanged
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor7_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor7.CheckedChanged
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub ckVendor8_CheckedChanged(sender As Object, e As EventArgs) Handles ckVendor8.CheckedChanged
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        Else
            lvCommoditySales.Items.Clear()
        End If
    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        Dim sSql As String
        Dim oNewNote As New Note
        Me.TopMost = False
        Dim frmNote = New FormNote
        Dim iIndex As Integer
        Dim sKey As String

        'Dim sDate As String
        Dim dDate As DateTime
        'Dim oSelItem As IndexedGrowerListItem = ListBox1.SelectedItem
        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        iIndex = dgvGrowers.SelectedRows(0).Index
        GlobalVariables.CurrentGrower = oGrowerColl(sKey)
        frmNote.ShowDialog()
        'frmNote.TopMost = True
        GlobalVariables.CurrentGrowerID = oGrowerColl(sKey).GrowerID
        GlobalVariables.GrowerFirstName = oGrowerColl(sKey).GrowerFirstName
        GlobalVariables.GrowerAddress1 = oGrowerColl(sKey).GrowerAddress1
        GlobalVariables.GrowerCity = oGrowerColl(sKey).GrowerCity
        GlobalVariables.GrowerState = oGrowerColl(sKey).GrowerState
        If GlobalVariables.ResetNote Then
            Dim sTestProd As String
            sTestProd = GlobalVariables.sEnv
            If sTestProd = "P" Then
                oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
            Else
                oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
            End If

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
            'sSql = sSql
            myCmd.CommandText = sSql
            oConn.Open()
            myCmd.ExecuteNonQuery()
            'oGrowerColl.ListBox1.SelectedIndex + 1).
            sSql = "UPDATE growers "
            sSql = sSql & "SET dt_last_update = CONVERT(datetime, '" & dDate.ToString("yyyy-MM-dd HH:mm:ss") & "') "
            sSql = sSql & "WHERE grower_id = " & GlobalVariables.CurrentGrowerID.ToString()
            myCmd.ExecuteNonQuery()
            oConn.Close()

            oNewNote.GrowerNoteSubject = GlobalVariables.CurrentNoteSubject
            oNewNote.GrowerNoteMethod = GlobalVariables.CurrentNoteMethod
            oNewNote.GrowerNoteMethodText = GlobalVariables.CurrentNoteMethodText
            oNewNote.GrowerNoteText = GlobalVariables.CurrentNoteText
            'Dim dDate As Date = Date.ParseExact(sDate, "yyyy-MM-dd hh:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            oNewNote.GrowerNoteCreationDate = dDate
            oNewNote.GrowerNoteCreatedBy = GlobalVariables.UserId
            oNewNote.GrowerNoteCreatedByLogin = GlobalVariables.CurrentUserLogin
            oGrowerColl(sKey).Notes.Add(oNewNote)
            oGrowerColl(sKey).GrowerLastUpdate = dDate
            RefreshDataGrid()
            ReloadNotes()
            dgvGrowers.Rows(iIndex).Selected = True
            dgvGrowers.FirstDisplayedScrollingRowIndex = dgvGrowers.SelectedRows(0).Index
            GlobalVariables.ResetNote = False
        End If
    End Sub
    Private Function FindName(lsLastName As String, lsFirstName As String) As Integer
        Dim iCnt As Integer
        Dim iMax As Integer
        Dim iRet As Integer

        iCnt = 0
        iRet = -1
        iMax = dgvGrowers.Rows.Count - 1
        Do While iCnt <= iMax
            If dgvGrowers.Rows(iCnt).Cells(0).Value.ToString() = lsLastName And dgvGrowers.Rows(iCnt).Cells(1).Value.ToString() = lsFirstName Then
                iRet = iCnt
                Exit Do
            End If
            iCnt = iCnt + 1
        Loop

        FindName = iRet
    End Function

    Private Sub btnAddGrower_Click(sender As Object, e As EventArgs) Handles btnAddGrower.Click
        Dim iIndex As Integer

        Dim sLastName As String
        Dim sFirstname As String
        Dim oNewNote As New Note
        Me.TopMost = False
        Dim frmAddGrower = New FormAddGrower
        'Dim sDate As String
        'Dim sDate As String
        Me.TopMost = False
        GlobalVariables.ResetGrower = False
        frmAddGrower.ShowDialog()
        'Me.TopMost = True
        If GlobalVariables.ResetGrower Then
            'RebuildPage()
            oGrowerColl.Add(GlobalVariables.AddedGrower, GlobalVariables.AddedGrower.GrowerID.ToString())
            RefreshDataGrid()
            sLastName = oGrowerColl(GlobalVariables.iAddedGrowerID.ToString()).GrowerLastName
            sFirstname = oGrowerColl(GlobalVariables.iAddedGrowerID.ToString()).GrowerFirstName
            'sCurName = oGrowerColl(GlobalVariables.iAddedGrowerID.ToString()).GrowerFirstName
            'sCurName = sCurName & " "
            'sCurName = sCurName & oGrowerColl(GlobalVariables.iAddedGrowerID.ToString()).GrowerLastName

            'iIndex = ListBox1.FindString(sCurName)
            iIndex = FindName(sLastName, sFirstname)
            If dgvGrowers.Rows.Count >= 1 Then
                If iIndex >= 0 Then
                    dgvGrowers.Rows(iIndex).Selected = True
                    dgvGrowers.FirstDisplayedScrollingRowIndex = iIndex
                Else
                    dgvGrowers.Rows(0).Selected = True
                End If

            End If
        End If


    End Sub




    Private Sub btnEditGrower_Click(sender As Object, e As EventArgs) Handles btnEditGrower.Click
        Dim iCurIndex As Integer
        'Dim icnt As Integer
        'Dim iMax As Integer
        'Dim sCurGrowerName As String
        'Dim iIndex As Integer
        'Dim sPFlag As String
        Dim sLastName As String
        Dim sFirstName As String
        'Dim sProspFlag As String
        'Dim sAddress As String
        'Dim sCity As String
        'Dim sState As String
        'Dim sZip As String
        'Dim sCounty As String
        'Dim sWorkPhone As String
        'Dim sCellPhone As String
        'Dim sFax As String
        'Dim sEmail As String
        'Dim sComment As String
        'Dim sCountry As String
        Dim sKey As String

        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()

        Me.TopMost = False
        'iCurIndex = ListBox1.SelectedIndex
        'iCurIndex = dgvGrowers.SelectedRows(0).Index

        GlobalVariables.CurrentGrower = oGrowerColl(sKey)

        Dim frmEditGrower = New FormEditGrower
        GlobalVariables.ResetGrower = False
        frmEditGrower.ShowDialog()
        'oSelItem.GrowerName = sCurGrowerName
        Me.TopMost = False
        If GlobalVariables.ResetGrower Then
            'RebuildPage()
            RefreshDataGrid()
            'sCurGrowerName = GlobalVariables.CurrentGrower.GrowerFirstName & " " & GlobalVariables.CurrentGrower.GrowerLastName
            'icnt = 1
            'iMax = oGrowerColl.Count
            'dgvGrowers.Rows.Clear()
            ''ListBox1.Items.Clear()
            'sLastName = ""
            'sFirstName = ""
            'Do While icnt <= iMax
            ' 'Dim oNewGrowerListItem As New IndexedGrowerListItem
            ' 'oNewGrowerListItem.GrowerName = oGrowerColl(icnt).GrowerFirstName & " " & oGrowerColl(icnt).GrowerLastName
            ' If oGrowerColl(icnt).GrowerProspect = "Y" Then
            ' sPFlag = "P"
            ' 'oNewGrowerListItem.GrowerName = oNewGrowerListItem.GrowerName & " - PROSPECT"
            'Els 'e
            ' sPFlag = " "
            'End If
            'oNewGrowerListItem.CollectionIndex = icnt
            'sLastName = oGrowerColl(icnt).GrowerLastName
            ' sFirstName = oGrowerColl(icnt).GrowerFirstName
            ' 'sPFlag = " "
            ' sAddress = oGrowerColl(icnt).GrowerAddress1
            ' If Len(oGrowerColl(icnt).GrowerAddress2) > 0 Then
            ' sAddress = sAddress & vbCrLf & oGrowerColl(icnt).GrowerAddress2
            ' End If
            '     sCity = oGrowerColl(icnt).GrowerCity
            '     sState = oGrowerColl(icnt).GrowerState
            '     sCounty = oGrowerColl(icnt).GrowerCounty
            '     sZip = oGrowerColl(icnt).GrowerZip
            '     sCountry = oGrowerColl(icnt).GrowerCountry
            '     sWorkPhone = oGrowerColl(icnt).GrowerPhone1
            '     sCellPhone = oGrowerColl(icnt).GrowerPhone2
            '     sFax = oGrowerColl(icnt).GrowerFax
            '     sEmail = oGrowerColl(icnt).GrowerEmail
            '     sComment = oGrowerColl(icnt).GrowerComment
            '
            '            dgvGrowers.Rows.Add(sLastName, sFirstName, " ", sAddress, sCity, sState, sCounty, sZip, sCountry, sWorkPhone, sCellPhone, sFax, sEmail, sComment, oGrowerColl(icnt).GrowerID.ToString())'
            '
            'ListBox1.Items.Add(oNewGrowerListItem)
            '           icnt = icnt + 1
            '          Loop
            'iCurIndex = ListBox1.FindString(sCurGrowerName)
            'iCurIndex = 0
            sLastName = GlobalVariables.CurrentGrower.GrowerLastName
            sFirstName = GlobalVariables.CurrentGrower.GrowerFirstName
            iCurIndex = FindName(sLastName, sFirstName)
            If dgvGrowers.Rows.Count >= 1 Then
                dgvGrowers.Rows(iCurIndex).Selected = True
            Else
                iCurIndex = 0
                dgvGrowers.Rows(iCurIndex).Selected = True

            End If
            'dgvGrowers.Rows(iCurIndex).Selected = True
            dgvGrowers.FirstDisplayedScrollingRowIndex = iCurIndex
        End If
    End Sub

    Private Sub txtSale_TextChanged(sender As Object, e As EventArgs) Handles txtSale.TextChanged

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvNonCGI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvNonCGI.SelectedIndexChanged
        If lvNonCGI.SelectedItems.Count > 0 Then
            GlobalVariables.CurrentOtherCropIndex = lvNonCGI.SelectedIndices(0)
        End If
    End Sub

    Private Sub btnAddNonCGI_Click(sender As Object, e As EventArgs) Handles btnAddNonCGI.Click

        Dim oNewNonCGI As New NonCGI
        Me.TopMost = False
        Dim frmNonCGI = New FormNonCGI
        'Dim iCurIndex As Integer
        'Dim iIndex As Integer
        Dim sKey As String


        'iIndex = "-1"
        'iIndex = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value
        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()


        GlobalVariables.BuildNonCGI = False
        GlobalVariables.CurrentGrower = oGrowerColl(sKey)
        Me.TopMost = False
        frmNonCGI.ShowDialog()
        Me.TopMost = True
        If GlobalVariables.BuildNonCGI Then
            BuildNonCGIList(sKey)
            'RebuildPage()
            GlobalVariables.BuildNonCGI = False
            'iCurIndex = ListBox1.SelectedIndex
            'ListBox1.SetSelected(iCurIndex, False)
            'ListBox1.SetSelected(iCurIndex, True)
            dgvGrowers_SelectionChanged(Me, EventArgs.Empty)
            'ListBox1_SelectedIndexChanged(Me, EventArgs.Empty)
        End If

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditNonCGI.Click
        'Dim oSelItem As IndexedGrowerListItem = ListBox1.SelectedItem
        'Dim icurindex As Integer
        'Dim iIndex As Integer
        Dim sKey As String


        'iIndex = "-1"
        'iIndex = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value
        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()

        If lvNonCGI.SelectedItems.Count < 1 Then
            MessageBox.Show("No Item is Selected")
        Else
            GlobalVariables.CurrentGrower = oGrowerColl(sKey)
            GlobalVariables.CurrentNonCGIID = oNonCgiCropIDs(lvNonCGI.SelectedIndices(0) + 1)
            Dim oFrmEditnonCGI As New FormEditNonCGI
            Me.TopMost = False
            oFrmEditnonCGI.ShowDialog()
            Me.TopMost = True
            If GlobalVariables.BuildNonCGI Then
                BuildNonCGIList(sKey)
                'RebuildPage()
                GlobalVariables.BuildNonCGI = False
                'icurindex = ListBox1.SelectedIndex
                'ListBox1.SetSelected(iCurIndex, False)
                'ListBox1_SelectedIndexChanged(Me, EventArgs.Empty)
                dgvGrowers_SelectionChanged(Me, EventArgs.Empty)
            End If
        End If


    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblGrowerZip_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure you want to log off?", " ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs)


        'Dim iCnt As Integer
        'Dim iMax As Integer
        'Dim sItem As String
        'Dim sSearch As String
        'Dim bFound As Boolean
        ''
        ''
        '
        '        If Trim(txtSearch.Text.ToString()) <> "" Then
        '        bFound = False
        '        iCnt = 0
        '        iMax = ListBox1.Items.Count - 1
        '        sSearch = txtSearch.Text.ToString().ToUpper()'
        '
        '        Do While iCnt <= iMax
        '        sItem = ListBox1.Items(iCnt).GrowerName.ToString().ToUpper()'
        '
        '        If sItem.Contains(sSearch) Then
        '        ListBox1.SelectedIndex = iCnt
        '        bFound = True
        '        Exit Do
        '        End If'
        '
        '       iCnt = iCnt + 1

        '       Loop

        '       If bFound Then
        '       txtSearch.Text = ""
        '       Else
        '
        '        txtSearch.Text = "Not Found"
        '        End If'

        '        End If
    End Sub



    Private Sub txtGrowers_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvNonCGI_MouseDown(sender As Object, e As MouseEventArgs) Handles lvNonCGI.MouseDown

    End Sub

    Private Sub btnDeleteNonCGI_Click(sender As Object, e As EventArgs) Handles btnDeleteNonCGI.Click
        'Dim oSelItem As IndexedGrowerListItem = ListBox1.SelectedItem
        Dim sMessage As String
        Dim oDelConn As SqlConnection
        Dim oDelCMd As New SqlCommand
        'Dim iCurIndex As Integer
        Dim sSql As String
        'Dim iIndex As Integer
        Dim sKey As String


        'iIndex = "-1"
        'iIndex = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value
        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()

        If lvNonCGI.SelectedItems.Count < 1 Then
            MessageBox.Show("No Item is Selected")
        Else
            GlobalVariables.CurrentGrower = oGrowerColl(sKey)
            GlobalVariables.CurrentNonCGIID = oNonCgiCropIDs(lvNonCGI.SelectedIndices(0) + 1)
            sMessage = "Delete " & lvNonCGI.SelectedItems(0).SubItems(0).Text
            sMessage = sMessage & " " & lvNonCGI.SelectedItems(0).SubItems(4).Text & "?"
            If MessageBox.Show(sMessage, " ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sTestProd As String
                sTestProd = GlobalVariables.sEnv
                If sTestProd = "P" Then
                    oDelConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
                Else
                    oDelConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
                End If
                sSql = "DELETE FROM nonCGIcrop "
                sSql = sSql & "WHERE nonCGIcrop_id = " & GlobalVariables.CurrentNonCGIID.ToString()
                'oReader.Close
                oDelConn.Open()
                oDelCMd.Connection = oDelConn
                oDelCMd.CommandText = sSql
                oDelCMd.ExecuteNonQuery()
                oDelConn.Close()
                GlobalVariables.CurrentGrower.OtherCrops.Remove(lvNonCGI.SelectedIndices(0) + 1)
                'oDelcmd.Dispose()
                lvNonCGI.Items.RemoveAt(lvNonCGI.SelectedIndices(0))
                BuildNonCGIList(sKey)
                'iCurIndex = ListBox1.SelectedIndex
                'ListBox1.SetSelected(iCurIndex, False)
                'ListBox1_SelectedIndexChanged(Me, EventArgs.Empty)
                dgvGrowers_SelectionChanged(Me, EventArgs.Empty)
                'RebuildPage()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Dim oPSI = New ProcessStartInfo("mailto:" & lblEmail.Text)
        'oPSI.UseShellExecute = True
        'System.Diagnostics.Process.Start(oPSI)
        'new ProcessStartInfo("mailto:example@stackoverflow.com") { UseShellExecute = true }
    End Sub

    Private Sub xlblEmail_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCreateReminder_Click(sender As Object, e As EventArgs) Handles btnCreateReminder.Click
        Dim oFromAR As New frmAddReminder

        oFromAR.ShowDialog()

        GlobalVariables.CurrentTasks.Clear()

    End Sub

    Private Sub lvCommoditySales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCommoditySales.SelectedIndexChanged

    End Sub



    Private Sub btnFarmView_Click(sender As Object, e As EventArgs) Handles btnFarmView.Click
        Dim oFarmViewMain As New FarmViewMain
        oFarmViewMain.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub dgvGrowers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvGrowers.SelectionChanged
        Dim iCnt As Integer
        Dim iMax As Integer
        Dim sNote As String
        Dim sBuildDate As String
        Dim sKey As String


        'iIndex = -1
        If dgvGrowers.SelectedRows.Count = 0 Then Exit Sub
        sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
        If dgvGrowers.SelectedRows.Count > 0 Then
            'sKey = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value.ToString()
            'iIndex = dgvGrowers.SelectedRows(0).Cells("CollIndex").Value

            iCnt = 1
            If Not GlobalVariables.EditedGrower Then
                GlobalVariables.BuildComm = False
            End If
            GlobalVariables.BuildNonCGI = False

            iMax = oGrowerColl(sKey).Vendors.Count
            'ckVendor1.Checked = False
            ckVendor1.CheckState = CheckState.Unchecked
            ckVendor1.Visible = False

            'ckVendor2.Checked = False
            ckVendor2.CheckState = CheckState.Unchecked
            ckVendor2.Visible = False

            'ckVendor3.Checked = False
            ckVendor3.CheckState = CheckState.Unchecked
            ckVendor3.Visible = False

            'ckVendor4.Checked = False
            ckVendor4.CheckState = CheckState.Unchecked
            ckVendor4.Visible = False

            'ckVendor5.Checked = False
            ckVendor5.CheckState = CheckState.Unchecked
            ckVendor5.Visible = False

            'ckVendor6.Checked = False
            ckVendor6.CheckState = CheckState.Unchecked
            ckVendor6.Visible = False

            'ckVendor7.Checked = False
            ckVendor7.CheckState = CheckState.Unchecked
            ckVendor7.Visible = False

            'ckVendor8.Checked = False
            ckVendor8.CheckState = CheckState.Unchecked
            ckVendor8.Visible = False
            If oGrowerColl(sKey).Vendors(1).VendorDummy = "N" Then
                Do While iCnt <= iMax

                    If iCnt > 8 Then Exit Do 'There are only 8 checkboxes
                    Select Case iCnt
                        Case 1
                            ckVendor1.Visible = True
                            ckVendor1.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor1.Checked = True
                        Case 2
                            ckVendor2.Visible = True
                            ckVendor2.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor2.Checked = True
                        Case 3
                            ckVendor3.Visible = True
                            ckVendor3.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor3.Checked = True
                        Case 4
                            ckVendor4.Visible = True
                            ckVendor4.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor4.Checked = True
                        Case 5
                            ckVendor5.Visible = True
                            ckVendor5.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor5.Checked = True
                        Case 6
                            ckVendor6.Visible = True
                            ckVendor6.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor6.Checked = True
                        Case 7
                            ckVendor7.Visible = True
                            ckVendor7.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor7.Checked = True
                        Case 8
                            ckVendor8.Visible = True
                            ckVendor8.Text = oGrowerColl(sKey).Vendors(iCnt).VendorName
                            ckVendor8.Checked = True
                    End Select


                    iCnt = iCnt + 1
                Loop

            End If
            GlobalVariables.BuildComm = True
            GlobalVariables.BuildNonCGI = True

            TestDataGrid.Rows.Clear()
            Dim oDict As New List(Of String)
            Dim oNoteRows As New Collection
            For Each oNote In oGrowerColl(sKey).Notes
                sNote = "Subject: " & oNote.GrowerNoteSubject & vbCrLf & vbCrLf & vbCrLf & oNote.GrowerNoteText & vbCrLf & vbCrLf & "Method: " & oNote.GrowerNoteMethodText & vbCrLf & vbCrLf & "Created By: " & oNote.GrowerNoteCreatedByLogin & " "
                sNote = sNote & Month(oNote.GrowerNoteCreationDate).ToString() & "/"
                sNote = sNote & Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString() & "/"
                sNote = sNote & Year(oNote.GrowerNoteCreationDate).ToString() & " "
                sNote = sNote & Hour(oNote.GrowerNoteCreationDate).ToString() & ":"
                sNote = sNote & Minute(oNote.GrowerNoteCreationDate).ToString & ":"
                sNote = sNote & Second(oNote.GrowerNoteCreationDate).ToString()

                sBuildDate = Year(oNote.GrowerNoteCreationDate).ToString()
                sBuildDate = sBuildDate & Replace(Month(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
                sBuildDate = sBuildDate & Replace(Microsoft.VisualBasic.DateAndTime.Day(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
                sBuildDate = sBuildDate & Replace(Hour(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
                sBuildDate = sBuildDate & Replace(Minute(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
                sBuildDate = sBuildDate & Replace(Second(oNote.GrowerNoteCreationDate).ToString().PadLeft(2), " ", "0")
                Dim oCurNoteItem As New NoteListItem
                oCurNoteItem.CreateDate = sBuildDate
                oCurNoteItem.NoteText = sNote
                If Not oNoteRows.Contains(oCurNoteItem.CreateDate) Then
                    oNoteRows.Add(oCurNoteItem, oCurNoteItem.CreateDate)
                End If
                oDict.Add(sBuildDate)
            Next

            oDict.Sort()
            oDict.Reverse()
            For Each sDate In oDict
                TestDataGrid.Rows.Add(New String() {oNoteRows(sDate).NoteText})
            Next
            oDict = Nothing
            oNoteRows = Nothing
        End If
        If oGrowerColl(sKey).GrowerProspect = "N" Then
            BuildCommodityList(sKey)
        End If

        BuildNonCGIList(sKey)

    End Sub

    Private Sub FilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterToolStripMenuItem.Click
        Dim oFilterForm As New FormFilterGrowers
        Me.TopMost = False
        oFilterForm.ShowDialog()
        'Me.TopMost = True
        RefreshDataGrid()
    End Sub

    Private Sub ClearFilterStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearFilterStripMenuItem1.Click
        GlobalVariables.CurrentFilters.FirstName = ""
        GlobalVariables.CurrentFilters.LastName = ""
        GlobalVariables.CurrentFilters.City = ""
        GlobalVariables.CurrentFilters.County = ""
        GlobalVariables.CurrentFilters.CommodityID = ""
        GlobalVariables.CurrentFilters.NoteSubject = ""
        GlobalVariables.CurrentFilters.NoteKeyword = ""
        GlobalVariables.CurrentFilters.Prospect = False
        GlobalVariables.CurrentFilters.HasNotes = False
        RefreshDataGrid()
    End Sub

    Private Sub dgvGrowers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrowers.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub


    'Private Sub txtSearchNote_TextChanged(sender As Object, e As EventArgs)
    'Dim iCnt As Integer
    'Dim iMax As Integer
    'Dim sItem As String
    'Dim sSearch As String
    'Dim bFound As Boolean

    'Convert.ToInt32(DataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
    'dataGridView1.CurrentRow.Index
    'Convert.ToInt32(SelectedRow.ItemArray[0])
    'dataGridView1.Rows[i].cell[0].Value.ToString()

    'If Trim(txtSearchNote.Text.ToString()) <> "" Then
    '    bFound = False
    '    iCnt = 0
    '    iMax = TestDataGrid.Rows.Count - 1
    '    sSearch = txtSearchNote.Text.ToString().ToUpper()

    '    Do While iCnt <= iMax
    '        sItem = TestDataGrid.Rows(iCnt).Cell(0).GrowerNote.ToString().ToUpper()

    '        If sItem.Contains(sSearch) Then
    '            TestDataGrid.CurrentRow.Index = iCnt
    '            bFound = True
    '            Exit Do
    '        End If

    '        iCnt = iCnt + 1

    '    Loop

    '    If bFound Then
    '        txtSearchNote.Text = ""
    '    Else

    '        txtSearchNote.Text = "Not Found"
    '    End If

    'End If
    'End Sub


End Class





