Option Strict Off
Imports System.Data.SqlClient
Public Class FormEditNonCGI
    Dim oConn As SqlConnection
    Dim oCommIDS As New Collection
    Dim iGrowerID As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSql As String
        Dim oReader As SqlDataReader
        Dim myCmd As SqlCommand


        Dim sTestProd As String
        sTestProd = "P"
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        Me.lblNonCGIGrowerFirstName.Text = GlobalVariables.CurrentGrower.GrowerFirstName
        Me.lblNonCGIGrowerLastName.Text = GlobalVariables.CurrentGrower.GrowerLastName

        oConn.Open()
        myCmd = oConn.CreateCommand
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
        oReader.Close()

        cmbStatus.Items.Add("SOLD")
        cmbStatus.Items.Add("UNSOLD")

        sSql = "SELECT grower_id, commodities.commodity_id, commodity_name, status, volume_bu, ISNULL(sold_to, ''), ISNULL(location, '') "
        sSql = sSql & "FROM noncgicrop, commodities "
        sSql = sSql & "WHERE commodities.commodity_id = noncgicrop.commodity_id "
        sSql = sSql & "AND nonCGICrop_id = " & GlobalVariables.CurrentNonCGIID.ToString()
        'myCmd = oConn.CreateCommand()
        myCmd.CommandText = sSql
        oReader = myCmd.ExecuteReader()

        If oReader.HasRows Then
            oReader.Read()
            iGrowerID = oReader.GetInt32(0)
            cmbCommodity.SelectedIndex = cmbCommodity.FindString(oReader.GetString(2))
            txtVolume.Text = oReader.GetInt32(4).ToString()
            cmbStatus.SelectedIndex = cmbStatus.FindString(oReader.GetString(3))
            txtSoldTo.Text = oReader.GetString(5)
            txtLocation.Text = oReader.GetString(6)
        End If
    End Sub

    Private Sub btnOKAddNonCGI_Click(sender As Object, e As EventArgs) Handles btnOKAddNonCGI.Click
        Dim oConn As SqlConnection
        Dim myCmd As New SqlCommand
        Dim sSql As String
        Dim dDate As Date
        Dim bValidated As Boolean
        Dim sTestProd As String
        sTestProd = "P"
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If


        bValidated = True

        If cmbCommodity.SelectedIndex = -1 Then
            MessageBox.Show("Commodity must be selected")
            bValidated = False
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Status must be selected")
            bValidated = False
        End If

        If txtVolume.Text.ToString().IndexOf(".") <> -1 Then
            MessageBox.Show("Bushel Volume must be a valid integer")
            bValidated = False
        End If

        If Not IsNumeric(Trim(txtVolume.Text.ToString())) Then
            MessageBox.Show("Bushel Volume must be a valid integer")
            bValidated = False
        End If

        If cmbStatus.SelectedItem = "SOLD" Then
            If Len(Trim(txtSoldTo.Text)) = 0 Then
                MessageBox.Show(Chr(34) & "SoldTo" & Chr(34) & " cannot be blank with a status of " & Chr(34) & "SOLD" & Chr(34))
                bValidated = False
            End If

            'If Len(Trim(txtLocation.Text)) > 0 Then
            'MessageBox.Show(Chr(34) & "Location" & Chr(34) & " not valid with a status of " & Chr(34) & "SOLD" & Chr(34))
            'bValidated = False
            'End If

        End If

        If bValidated Then
            myCmd = oConn.CreateCommand

            dDate = Now()

            sSql = "UPDATE nonCGIcrop "

            'sSql = sSql & "(commodity_id, status, volume_bu, sold_to, updated_date, Location, grower_id) "
            'sSql = sSql & "VALUES ('"
            sSql = sSql & "SET commodity_id = '" & oCommIDS(cmbCommodity.SelectedIndex + 1).ToString() & "', "
            sSql = sSql & "status = '" & cmbStatus.SelectedItem.ToString() & "', "
            sSql = sSql & "volume_bu = " & txtVolume.Text.ToString() & ", "
            sSql = sSql & "sold_to = '" & GlobalVariables.DQuot(txtSoldTo.Text.ToString()) & "', "
            sSql = sSql & "updated_date = Convert(DateTime, '" & dDate.ToString("yyyy-MM-dd HH:mm:ss") & "'), "
            sSql = sSql & "location = '" & GlobalVariables.DQuot(txtLocation.Text.ToString()) & "', "
            sSql = sSql & "grower_id = " & iGrowerID.ToString() & " "
            sSql = sSql & "WHERE nonCGIcrop_id = " & GlobalVariables.CurrentNonCGIID.ToString()

            oConn.Open()
            myCmd.CommandText = sSql

            myCmd.ExecuteNonQuery()
            oConn.Close()
            Dim oNewNonCGI As NonCGI
            '
            ''oNewNonCGI.NonCGICommodity = oCommIds(iCommIndex + 1)
            oNewNonCGI = GlobalVariables.CurrentGrower.OtherCrops(GlobalVariables.CurrentOtherCropIndex + 1)
            oNewNonCGI.NonCGICommodity = cmbCommodity.SelectedItem
            oNewNonCGI.Status = cmbStatus.SelectedItem
            oNewNonCGI.UpdatedDate = dDate
            oNewNonCGI.Volume = txtVolume.Text
            oNewNonCGI.SoldTo = txtSoldTo.Text
            oNewNonCGI.Location = txtLocation.Text
            ' GlobalVariables.CurrentGrower.OtherCrops.Add(oNewNonCGI)
            'oGrowerColl(oSelItem.CollectionIndex).Notes.Add(oNewNonCGI)

            GlobalVariables.BuildNonCGI = True
            Me.Close()
        End If
    End Sub

    Private Sub txtVolume_TextChanged(sender As Object, e As EventArgs) Handles txtVolume.TextChanged

    End Sub

    Private Sub txtVolume_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolume.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        'If Asc(e.KeyChar) <> 8 Then
        ' If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        ' e.Handled = True
        ' End If
        ' End If

    End Sub

    Private Sub btnCancelNonCGI_Click(sender As Object, e As EventArgs) Handles btnCancelNonCGI.Click
        Me.Close()
    End Sub
End Class