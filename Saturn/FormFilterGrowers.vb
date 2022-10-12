Option Strict Off
Imports System.Data.SqlClient
Public Class FormFilterGrowers
    Dim oCommIds As New Collection
    Private Sub FormFilterGrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sTestProd As String

        Dim iIndex As Integer

        sTestProd = "P"
        Dim oCOnn As New SqlConnection
        If sTestProd = "P" Then
            oCOnn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oCOnn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        Dim myCmd As New SqlCommand
        Dim sSql As String
        Dim oReader As SqlDataReader
        Dim iCnt As Integer

        oCOnn.Open()
        myCmd = oCOnn.CreateCommand


        sSql = "SELECT commodity_id, commodity_name "
        sSql = sSql & "FROM commodities "
        sSql = sSql & "WHERE show = 'Y' "
        sSql = sSql & "ORDER BY commodity_name"

        myCmd.CommandText = sSql
        oReader = myCmd.ExecuteReader()
        If oReader.HasRows Then
            Do While oReader.Read()
                cmbCommodity.Items.Add(oReader.GetString(1))
                oCommIds.Add(oReader.GetString(0))
            Loop
        End If

        oReader.Close()
        oCOnn.Close()
        iIndex = -1
        txtFirstName.Text = GlobalVariables.CurrentFilters.FirstName
        txtLastName.Text = GlobalVariables.CurrentFilters.LastName
        txtCity.Text = GlobalVariables.CurrentFilters.City
        txtCounty.Text = GlobalVariables.CurrentFilters.County
        txtSubject.Text = GlobalVariables.CurrentFilters.NoteSubject
        txtKeyword.Text = GlobalVariables.CurrentFilters.NoteKeyword
        chkProspect.Checked = GlobalVariables.CurrentFilters.Prospect
        chkHasNotes.Checked = GlobalVariables.CurrentFilters.HasNotes

        iCnt = 0
        For Each sCommId In oCommIds
            If sCommId = GlobalVariables.CurrentFilters.CommodityID Then
                iIndex = iCnt
                Exit For
            End If
            iCnt = iCnt + 1
        Next
        If iIndex <> -1 Then
            cmbCommodity.SelectedIndex = iIndex
            ckFarmStorage.Visible = True
            ckFarmStorage.Enabled = True
            If GlobalVariables.CurrentFilters.FarmStorage = "Y" Then
                ckFarmStorage.Checked = True
            Else
                ckFarmStorage.Checked = False
            End If
        Else
            ckFarmStorage.Enabled = False
            ckFarmStorage.Visible = False
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        GlobalVariables.CurrentFilters.FirstName = txtFirstName.Text
        GlobalVariables.CurrentFilters.LastName = txtLastName.Text
        GlobalVariables.CurrentFilters.City = txtCity.Text
        GlobalVariables.CurrentFilters.County = txtCounty.Text
        If cmbCommodity.SelectedIndex >= 0 Then
            GlobalVariables.CurrentFilters.CommodityID = oCommIds(cmbCommodity.SelectedIndex + 1)
        Else
            GlobalVariables.CurrentFilters.CommodityID = ""
        End If
        GlobalVariables.CurrentFilters.Prospect = chkProspect.Checked
        GlobalVariables.CurrentFilters.HasNotes = chkHasNotes.Checked
        GlobalVariables.CurrentFilters.NoteSubject = txtSubject.Text
        GlobalVariables.CurrentFilters.NoteKeyword = txtKeyword.Text
        If ckFarmStorage.Checked = True Then
            GlobalVariables.CurrentFilters.FarmStorage = "Y"
        Else
            GlobalVariables.CurrentFilters.FarmStorage = "N"
        End If
        'MessageBox.Show(GlobalVariables.CurrentFilters.CommodityID)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtCity.Text = ""
        txtCounty.Text = ""
        cmbCommodity.SelectedIndex = -1
        chkProspect.Checked = False
        chkHasNotes.Checked = False
        txtSubject.Text = ""
        txtKeyword.Text = ""

    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSubject.TextChanged
        If Len(txtSubject.Text) > 0 Or Len(txtKeyword.Text) > 0 Then
            chkHasNotes.Checked = True
            chkHasNotes.Enabled = False
        Else
            chkHasNotes.Enabled = True
            chkHasNotes.Checked = False
        End If
    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged
        If Len(txtSubject.Text) > 0 Or Len(txtKeyword.Text) > 0 Then
            chkHasNotes.Checked = True
            chkHasNotes.Enabled = False
        Else
            chkHasNotes.Enabled = True
            chkHasNotes.Checked = False
        End If
    End Sub

    Private Sub cmbCommodity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommodity.SelectedIndexChanged
        If cmbCommodity.SelectedIndex > -1 Then
            ckFarmStorage.Visible = True
            ckFarmStorage.Enabled = True
        Else
            ckFarmStorage.Visible = False
            ckFarmStorage.Enabled = False
            ckFarmStorage.Checked = False
        End If
    End Sub
End Class