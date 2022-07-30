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
    End Sub
End Class