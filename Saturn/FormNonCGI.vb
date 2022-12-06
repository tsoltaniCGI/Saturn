Option Strict Off
Imports System.Data.SqlClient
Public Class FormNonCGI
    Dim oCommIds As New Collection
    Dim iCommIndex As Integer
    Private Sub FormNonCGI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sTestProd As String
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

        GlobalVariables.ResetNote = False
        'ckFarmStorage.Checked = False
        'ckFarmStorage.Enabled = False
        'ckFarmStorage.Visible = False

        Me.lblNonCGIGrowerFirstName.Text = GlobalVariables.CurrentGrower.GrowerFirstName
        Me.lblNonCGIGrowerLastName.Text = GlobalVariables.CurrentGrower.GrowerLastName
        'Me.lblAddress.Text = GlobalVariables.CurrentGrower.GrowerAddress1
        'Me.lblAddress2.Text = GlobalVariables.CurrentGrower.GrowerAddress2
        'Me.lblGrowerCity.Text = GlobalVariables.CurrentGrower.GrowerCity
        'Me.lblGrowerState.Text = GlobalVariables.CurrentGrower.GrowerState

        oCOnn.Open()
        myCmd = oCOnn.CreateCommand


        'dDate = Now()
        'cmbCommodity.Items.Add
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
        cmbStatus.Items.Add("SOLD")
        cmbStatus.Items.Add("UNSOLD")

        oReader.Close()
        oCOnn.Close()

    End Sub



    Private Sub cmbCommodity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommodity.SelectedIndexChanged
        iCommIndex = cmbCommodity.SelectedIndex
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbStatus.SelectedItem = "UNSOLD" Then
            ckFarmStorage.Visible = True
            ckFarmStorage.Enabled = True
        Else
            ckFarmStorage.Visible = False
            ckFarmStorage.Enabled = False
            ckFarmStorage.Checked = False
        End If
    End Sub

    Private Sub txtSoldTo_TextChanged(sender As Object, e As EventArgs) Handles txtSoldTo.TextChanged

    End Sub

    Private Sub btnOKAddNonCGI_Click(sender As Object, e As EventArgs) Handles btnOKAddNonCGI.Click
        Dim oConn = New SqlConnection
        Dim sTestProd As String
        sTestProd = GlobalVariables.sEnv
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        Dim myCmd As New SqlCommand
        Dim sSql As String
        Dim dDate As Date
        Dim bValidated As Boolean
        Dim inonCGIID As Integer
        Dim sFarmStor As String
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
            If ckFarmStorage.Checked = True Then
                sFarmStor = "Y"
            Else
                sFarmStor = "N"
            End If
            myCmd = oConn.CreateCommand

            dDate = Now()

            sSql = "INSERT INTO nonCGIcrop "
            sSql = sSql & "(commodity_id, status, volume_bu, sold_to, updated_date, location, grower_id, farmstorage) "
            sSql = sSql & "VALUES ('"
            sSql = sSql & oCommIds(iCommIndex + 1).ToString() & "', "
            sSql = sSql & "'" & cmbStatus.SelectedItem.ToString() & "', "
            sSql = sSql & txtVolume.Text.ToString() & ", "
            sSql = sSql & "'" & GlobalVariables.DQuot(txtSoldTo.Text.ToString()) & "', "
            sSql = sSql & "Convert(DateTime, '" & dDate.ToString("yyyy-MM-dd HH:mm:ss") & "'), "
            sSql = sSql & "'" & GlobalVariables.DQuot(txtLocation.Text.ToString()) & "', "
            sSql = sSql & GlobalVariables.CurrentGrower.GrowerID.ToString() & ", "
            sSql = sSql & "'" & sFarmStor & "'"
            sSql = sSql & "); SELECT SCOPE_IDENTITY()"

            oConn.Open()
            myCmd.CommandText = sSql

            'myCmd.ExecuteNonQuery()
            inonCGIID = myCmd.ExecuteScalar()

            oConn.Close()
            Dim oNewNonCGI As New NonCGI

            'oNewNonCGI.NonCGICommodity = oCommIds(iCommIndex + 1)
            oNewNonCGI.NonCGICommodity = cmbCommodity.SelectedItem
            oNewNonCGI.Status = cmbStatus.SelectedItem
            oNewNonCGI.UpdatedDate = dDate
            oNewNonCGI.Volume = txtVolume.Text
            oNewNonCGI.SoldTo = txtSoldTo.Text
            oNewNonCGI.Location = txtLocation.Text
            oNewNonCGI.NonCGICropID = inonCGIID
            oNewNonCGI.FarmStorage = sFarmStor
            GlobalVariables.CurrentGrower.OtherCrops.Add(oNewNonCGI)
            'oGrowerColl(oSelItem.CollectionIndex).Notes.Add(oNewNonCGI)

            GlobalVariables.BuildNonCGI = True
            Me.Close()
        End If
    End Sub

    Private Sub txtVolume_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtVolume_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub lblSoldTo_Click(sender As Object, e As EventArgs) Handles lblSoldTo.Click

    End Sub

    Private Sub lblGrowerName_Click(sender As Object, e As EventArgs) Handles lblNonCGIGrowerFirstName.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnCancelNonCGI_Click(sender As Object, e As EventArgs) Handles btnCancelNonCGI.Click
        Me.Close()
    End Sub
End Class