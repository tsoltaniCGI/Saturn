Option Strict Off
Imports System.Data.SqlClient



Public Class FarmViewMain
    Inherits System.Windows.Forms.Form
    Dim oConn As New SqlConnection
    Dim oCollVendors As New Collection
    Private Sub FarmViewMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sTestProd As String
        sTestProd = "P"
        If sTestProd = "P" Then
            oConn = New System.Data.SqlClient.SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New System.Data.SqlClient.SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        Dim mycmd = oConn.CreateCommand
        Dim oReader As SqlDataReader
        Dim sSql As String
        Dim oCollVendorGrower As New Collection
        Dim iNum As Integer
        Dim iVendorId As Integer
        Dim iGrowerID As Integer
        Dim iMax As Integer
        Dim iCnt As Integer
        Dim sGrowerName As String

        'sSql = "SELECT DISTINCT vendors.vendor_id, vendors.agtech_vendor_ID, vendors.vendor_name, ISNULL(growers_vendors.grower_id, 0), ISNULL(users.user_id, 0), "
        'sSql = sSql & "ISNULL(growers.grower_first_name, '') AS [Grower First Name],  ISNULL(growers.grower_last_name, '') AS [GROWER LAST NAME], "
        'sSql = sSql & "ISNULL(grower_note_creation_date, '') AS [Creation Date], ISNULL(grower_note_id, 0) AS [NoteID], "
        'sSql = sSql & "ISNULL(grower_note_subject, '') AS [Note Subject], ISNULL(grower_note_text, '') AS [Note Text], "
        'sSql = sSql & "ISNULL(user_first_name, '') AS [Creator First Name], ISNULL(user_last_name, '') AS [Creator last Name] "
        'sSql = sSql & "FROM vendors "
        'sSql = sSql & "LEFT OUTER JOIN growers_vendors ON vendors.vendor_id = growers_vendors.vendor_id "
        'sSql = sSql & "LEFT OUTER JOIN growers         ON growers.grower_id = growers_vendors.grower_id "
        'sSql = sSql & "LEFT OUTER JOIN grower_notes    ON growers.grower_id = grower_notes.grower_id "
        'sSql = sSql & "LEFT OUTER JOIN users           ON grower_notes.grower_note_created_by = users.user_id "
        'sSql = sSql & "WHERE Users.User_id = 333"
        ''sSql = sSql & "WHERE users.user_id = " & GlobalVariables.UserId.ToString() & " "
        'sSql = sSql & "AND vendor_dummy = 'N'"
        ''sSql = sSql & "And Users.User_id = " & GlobalVariables.UserId.ToString() & " "
        'sSql = sSql & "ORDER BY vendors.vendor_name "


        sSql = "SELECT DISTINCT vendors.vendor_id, coalesce(vendors.agtech_vendor_ID, ''), vendors.vendor_name, coalesce(growers.grower_id, 0),  coalesce(a.user_id, 0), "
        sSql = sSql & "coalesce(grower_first_name, '') AS [Grower First Name], coalesce(grower_last_name, '') AS [GROWER LAST NAME], "
        sSql = sSql & "coalesce(grower_note_creation_date, '') AS [Creation Date], coalesce(grower_note_id, 0) AS [NoteID], "
        sSql = sSql & "coalesce(grower_note_subject, '') AS [Note Subject], coalesce(grower_note_text, '') AS [Note Text], "
        sSql = sSql & "coalesce(b.user_login, '') AS [Creator] "
        sSql = sSql & "FROM vendors "
        sSql = sSql & "JOIN vendors_facilities ON vendors_facilities.vendor_id   = vendors.vendor_id "
        sSql = sSql & "CROSS JOIN (users a      JOIN users_facilities   ON users_facilities.user_id = a.user_id) "
        sSql = sSql & "CROSS JOIN (users b      JOIN  (grower_notes RIGHT OUTER JOIN growers ON GROWER_NOTES.GROWER_ID = GROWERS.GROWER_ID "
        sSql = sSql & "right outer join GROWERS_VENDORS growers_vendors on GROWERS.GROWER_ID = GROWERS_VENDORS.GROWER_ID) "
        sSql = sSql & "on B.USER_ID = GROWER_NOTES.grower_note_created_by) "
        sSql = sSql & "WHERE (VENDORS_FACILITIES.FACILITY_ID = USERS_FACILITIES.FACILITY_ID "
        sSql = sSql & "AND GROWERS_VENDORS.VENDOR_ID = VENDORS.VENDOR_ID "
        'sSql = sSql & "AND a.user_id = 367) "
        sSql = sSql & "AND a.user_id = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "   ) "
        sSql = sSql & "AND vendors.vendor_dummy = 'N'"
        sSql = sSql & "ORDER BY vendors.vendor_name, [GROWER LAST NAME], [Creation Date] "


        mycmd.CommandText = sSql
        oConn.Open()
        oReader = mycmd.ExecuteReader()
        oCollVendorGrower.Clear()


        If oReader.HasRows Then
            iNum = 1
            Do While oReader.Read()
                Dim oFRMV As New VendGrowNoteUser
                oFRMV.FrmViVendorID = oReader.GetInt32(0)
                oFRMV.FrmViAgtechVendorID = oReader.GetString(1)
                oFRMV.FrmViVendorName = oReader.GetString(2)
                oFRMV.FrmViGrowerID = oReader.GetInt32(3)
                oFRMV.FrmViUserId = oReader.GetInt32(4)
                oFRMV.FrmViGrowerFirstName = oReader.GetString(5)
                oFRMV.FrmViGrowerLastName = oReader.GetString(6)
                oFRMV.FrmViNoteDate = oReader.GetDateTime(7)
                oFRMV.FrmViNoteId = oReader.GetInt32(8)
                oFRMV.FrmViNoteSubject = oReader.GetString(9)
                oFRMV.FrmViNoteText = oReader.GetString(10)
                oFRMV.FrmViUserLogin = oReader.GetString(11)


                oCollVendorGrower.Add(oFRMV, oFRMV.FrmViVendorID.ToString() & oFRMV.FrmViGrowerID.ToString() & oFRMV.FrmViNoteId.ToString() & iNum.ToString())
                iNum = iNum + 1
            Loop
        End If

        oReader.Close()
        iMax = oCollVendorGrower.Count
        iCnt = 1

        iVendorId = -1
        oCollVendors.Clear()
        iGrowerID = -1
        Do While iCnt <= iMax
            If oCollVendorGrower(iCnt).FrmViVendorID <> iVendorId Then
                iVendorId = oCollVendorGrower(iCnt).FrmViVendorID

                Dim oFrmViVendor As New FarmViewVendor
                oFrmViVendor.FarmViewAgtechVendorID = oCollVendorGrower(iCnt).FrmViAgtechVendorID
                oFrmViVendor.FarmViewVendorName = oCollVendorGrower(iCnt).FrmViVendorName

                Do While iVendorId = oCollVendorGrower(iCnt).FrmViVendorID
                    'Dim oGrowerListItem As New fmIndexedGrower
                    'sGrowerName = Trim(oCollVendorGrower(iCnt).GrowerFirstName & " " & oCollVendorGrower(iCnt).GrowerLastName)
                    'oGrowerListItem.FMGrowerName = sGrowerName

                    Dim ofGrower As New FarmGrower

                    ofGrower.FarmGrowerID = oCollVendorGrower(iCnt).FrmViGrowerID
                    ofGrower.FarmGrowerFirstName = oCollVendorGrower(iCnt).FrmViGrowerFirstName
                    ofGrower.FarmGrowerLastName = oCollVendorGrower(iCnt).FrmViGrowerLastName


                    Do While iVendorId = oCollVendorGrower(iCnt).FrmViVendorID And iGrowerID = oCollVendorGrower(iCnt).FrmViGrowerID

                        Dim ofNote As New FarmViewNotes

                        ofNote.frviNoteDate = oCollVendorGrower(iCnt).FrmViNoteDate
                        ofNote.frviNoteSubject = oCollVendorGrower(iCnt).FrmViNoteSubject
                        ofNote.frviNoteText = oCollVendorGrower(iCnt).FrmViNoteText
                        ofNote.frviNoteCreator = oCollVendorGrower(iCnt).FrmViUserLogin

                        iCnt = iCnt + 1

                        If iCnt > iMax Then
                            Exit Do
                        End If
                        ofGrower.oFarmGrowerNotes.Add(ofNote)
                    Loop
                    iCnt = iCnt + 1
                    If iCnt > iMax Then
                        Exit Do
                    End If
                    oFrmViVendor.FarmViewGrowers.Add(ofGrower)
                Loop
                oCollVendors.Add(oFrmViVendor)

                If iCnt > iMax Then
                    Exit Do
                End If
            End If
        Loop


        lvVendors.View = View.Details
        lvVendors.Items.Clear()


        For Each oCurVendor In oCollVendors
            Dim oLVV As New ListViewItem
            oLVV.SubItems(0).Text = oCurVendor.FarmViewVendorName
            'oLVV.SubItems.Add(oCurVendor.FarmViewAgtechVendorID)
            lvVendors.Items.Add(oLVV)
        Next

        lvVendors.Columns(0).Text = "Vendor Name"
        'lvVendors.Columns(1).Text = "AgTech ID"




        'lvNotes.View = View.Details
        'lvNotes.Items.Clear()

        'For Each oCurNote In oCollVendors
        '    Dim oLVN As New ListViewItem
        '    oLVN.SubItems(0).Text = oCurNote.frviNoteSubject
        '    oLVN.SubItems.Add(oCurNote.frviNoteDate)
        '    oLVN.SubItems.Add(oCurNote.frviNoteText)
        '    oLVN.SubItems.Add(oCurNote.frviNoteCreator)
        '    lvNotes.Items.Add(oLVN)
        'Next

        'lvVendors.Columns(0).Text = "Note Subject"
        'lvVendors.Columns(1).Text = "Note Date"
        'lvVendors.Columns(2).Text = "Note Text"
        'lvVendors.Columns(3).Text = "Note Creator"

    End Sub

    Private Sub lvVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvVendors.SelectedIndexChanged
        Dim iCnt As Integer
        Dim iMax As Integer
        Dim sName As String
        'Dim rowIndex As Integer = lvVendors.FocusedItem.Index
        Dim iCurIndex As Integer = lvVendors.FocusedItem.Index



        If lvVendors.SelectedIndices.Count >= 1 Then

            'iMax = oCollVendors(lvVendors.SelectedIndices(0) + 1).FarmViewGrowers.Count
            iMax = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers.Count
            iCnt = 1
            lvNotes.Items.Clear()
            Do While iCnt <= iMax
                lvNotes.Items.Add(oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName & " " & oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerLastName)
                'lvNotes.SunItems(0).Text = Add(oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName & " " & oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerLastName)
                'For Each oCurNote In oCollVendors.
                '    Dim oLVN As New ListViewItem
                '    oLVN.SubItems(0).Text = oCurNote.frviNoteSubject
                '    oLVN.SubItems.Add(oCurNote.frviNoteDate)
                '    oLVN.SubItems.Add(oCurNote.frviNoteText)
                '    oLVN.SubItems.Add(oCurNote.frviNoteCreator)
                '    lvNotes.Items.Add(oLVN)
                'Next
                iCnt = iCnt + 1
            Loop
            iCnt = iCnt - 1
        End If

        ckGrower1.CheckState = CheckState.Unchecked
        ckGrower1.Visible = False

        ckGrower2.CheckState = CheckState.Unchecked
        ckGrower2.Visible = False

        ckGrower3.CheckState = CheckState.Unchecked
        ckGrower3.Visible = False

        ckGrower4.CheckState = CheckState.Unchecked
        ckGrower4.Visible = False

        ckGrower5.CheckState = CheckState.Unchecked
        ckGrower5.Visible = False

        ckGrower6.CheckState = CheckState.Unchecked
        ckGrower6.Visible = False



        Do While iCnt <= iMax
            If iCnt > 6 Then Exit Do
            'sName = Trim(oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName & " " & oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerLastName)

            Select Case iCnt
                Case 1
                    ckGrower1.Visible = True
                    ckGrower1.Text = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName
                    ckGrower1.Checked = True
                Case 2
                    ckGrower2.Visible = True
                    ckGrower2.Text = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName
                    ckGrower2.Checked = True
                Case 3
                    ckGrower3.Visible = True
                    ckGrower3.Text = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName
                    ckGrower3.Checked = True
                Case 4
                    ckGrower4.Visible = True
                    ckGrower4.Text = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName
                    ckGrower4.Checked = True
                Case 5
                    ckGrower5.Visible = True
                    ckGrower5.Text = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName
                    ckGrower5.Checked = True
                Case 6
                    ckGrower6.Visible = True
                    ckGrower6.Text = oCollVendors(lvVendors.SelectedIndices(0)).FarmViewGrowers(iCnt).FarmGrowerFirstName
                    ckGrower6.Checked = True
            End Select
            iCnt = iCnt + 1
        Loop
        'lvNotes.Clear()




    End Sub




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    'Private Sub ckGrower1_CheckedChanged(sender As Object, e As EventArgs) Handles ckGrower1.CheckedChanged
    '    Dim oSelItem As IndexedGrowerListItem = Me.lvVendors.SelectedIndices(0)
    '    If oGrowerColl(oSelItem.CollectionIndex).GrowerProspect = "N" Then
    '        BuildCommodityList(oSelItem.CollectionIndex)
    '    Else
    '        lvCommoditySales.Items.Clear()
    '    End If
    'End Sub
End Class