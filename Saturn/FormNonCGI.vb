Option Strict Off
Imports System.Data.SqlClient
Public Class FormNonCGI
    Dim oCommIds As New Collection
    Dim iCommIndex As Integer
    Private Sub FormNonCGI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oConn As New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        Dim myCmd As New SqlCommand
        Dim sSql As String
        Dim oReader As SqlDataReader

        oConn.Open()
        myCmd = oConn.CreateCommand


        'dDate = Now()
        'cmbCommodity.Items.Add
        sSql = "SELECT commodity_id, commodity_name "
        sSql = sSql & "FROM commodities "
        sSql = sSql & "ORDER BY commodity_id"

        myCmd.CommandText = sSql
        oReader = myCmd.ExecuteReader()
        If oReader.HasRows Then
            Do While oReader.Read()
                cmbCommodity.Items.Add(oReader.GetString(1))
                oCommIds.Add(oReader.GetString(0))
            Loop
        End If
        cmbStatus.Items.Add("SOLD")
        cmbStatus.Items.Add("UNSOLD")

        oReader.Close()
        oConn.Close()

    End Sub



    Private Sub cmbCommodity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommodity.SelectedIndexChanged
        iCommIndex = cmbCommodity.SelectedIndex
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub

    Private Sub txtSoldTo_TextChanged(sender As Object, e As EventArgs) Handles txtSoldTo.TextChanged

    End Sub

    Private Sub btnOKAddNonCGI_Click(sender As Object, e As EventArgs) Handles btnOKAddNonCGI.Click
        Dim oConn As New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        Dim myCmd As New SqlCommand
        Dim sSql As String
        Dim dDate As Date

        myCmd = oConn.CreateCommand

        dDate = Now()

        sSql = "INSERT INTO nonCGIcrop "
        sSql = sSql & "(commodity_id, status, volume_bu, sold_to, updated_date, location, grower_id) "
        sSql = sSql & "VALUES ('"
        sSql = sSql & oCommIds(iCommIndex + 1).ToString() & "', "
        sSql = sSql & "'" & cmbStatus.SelectedItem.ToString() & "', "
        sSql = sSql & txtVolume.Text.ToString() & ", "
        sSql = sSql & "'" & txtSoldTo.Text.ToString() & "', "
        sSql = sSql & "Convert(DateTime, '" & dDate.ToString("yyyy-MM-dd HH:mm:ss") & "'), "
        sSql = sSql & "'" & txtLocation.Text.ToString() & "', "
        sSql = sSql & GlobalVariables.CurrentGrower.GrowerID.ToString() & ")"

        oConn.Open()
        myCmd.CommandText = sSql

        myCmd.ExecuteNonQuery()
        oConn.Close()
        Dim oNewNonCGI As New NonCGI

        oNewNonCGI.NonCGICommodity = oCommIds(iCommIndex + 1)
        oNewNonCGI.Status = cmbStatus.SelectedItem
        oNewNonCGI.UpdatedDate = dDate
        oNewNonCGI.Volume = txtVolume.Text
        oNewNonCGI.SoldTo = txtSoldTo.Text
        oNewNonCGI.Location = txtLocation.Text
        GlobalVariables.CurrentGrower.OtherCrops.Add(oNewNonCGI)
        'oGrowerColl(oSelItem.CollectionIndex).Notes.Add(oNewNonCGI)

        GlobalVariables.BuildNonCGI = True
        Me.Close()

    End Sub
End Class