Option Strict Off
Imports System.Data.SqlClient
Public Class FormEditGrower
    Dim oVendIDs As New Collection
    Dim oStates As New Collection
    Dim oProvinces As New Collection
    Dim oCountries As New Collection


    Private Sub FormEditGrower_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loCurrentGrower As Grower
        Dim oCurrentVendor As Vendor
        Dim sTestProd As String
        Dim oConn As SqlConnection
        sTestProd = GlobalVariables.sEnv
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If


        oConn.Open()
        Dim myCmd = oConn.CreateCommand
        Dim sSql As String
        Dim iCnt As Integer
        Dim iMax As Integer
        Dim sCurCountry As String
        Dim iCurIndex As Integer

        sSql = "SELECT DISTINCT vendors.vendor_id, vendors.vendor_name "
        sSql = sSql & "FROM vendors, vendors_facilities, users, users_facilities, facilities "
        sSql = sSql & "WHERE vendors_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
        sSql = sSql & "AND users_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND users.user_id = users_facilities.user_id "
        sSql = sSql & "AND vendors.vendor_dummy = 'N' "
        sSql = sSql & "AND users.user_id = " & GlobalVariables.UserId.ToString()
        'For Each iID In GlobalVariables.UserFacilityIDs
        ' sSql = sSql & iID.ToString() & ", "
        ' Next
        ' sSql = sSql & ")"
        ' sSql = Replace(sSql, ", )", " )")
        ' sSql = sSql & " "
        ' sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
        ' sSql = sSql & "AND vendors.vendor_dummy = 'N'"
        myCmd.CommandText = sSql

        Dim oReader = myCmd.ExecuteReader()

        If oReader.HasRows Then
            iCnt = 0
            Do While oReader.Read()
                lstVendors.Items.Add(oReader.GetString(1))
                oVendIDs.Add(oReader.GetInt32(0), iCnt.ToString())
                iCnt = iCnt + 1
            Loop
        End If
        oReader.Close()

        sSql = "SELECT state_code, state_name "
        sSql = sSql & "FROM states "
        sSql = sSql & "ORDER BY state_name"
        myCmd.CommandText = sSql

        oReader = myCmd.ExecuteReader()
        If oReader.HasRows Then
            Do While oReader.Read()
                Dim oCurState As New State
                oCurState.StateID = oReader.GetString(0)
                oCurState.StateName = oReader.GetString(1)
                If Not oStates.Contains(oCurState.StateID) Then
                    oStates.Add(oCurState, oCurState.StateID)
                End If
            Loop

        End If

        oReader.Close()

        sSql = "SELECT province_code, province_name "
        sSql = sSql & "FROM canadian_provinces "
        sSql = sSql & "ORDER BY province_name"
        myCmd.CommandText = sSql

        oReader = myCmd.ExecuteReader()
        If oReader.HasRows Then
            Do While oReader.Read()
                Dim oCurProvince As New Province
                oCurProvince.ProvinceID = oReader.GetString(0)
                oCurProvince.ProvinceName = oReader.GetString(1)
                If Not oProvinces.Contains(oCurProvince.ProvinceID) Then
                    oProvinces.Add(oCurProvince, oCurProvince.ProvinceID)
                End If
            Loop
        End If

        oReader.Close()

        sSql = "SELECT country_code, country_name "
        sSql = sSql & "FROM countries "
        sSql = sSql & "ORDER BY country_name"
        myCmd.CommandText = sSql

        oReader = myCmd.ExecuteReader()
        If oReader.HasRows Then
            Do While oReader.Read()
                Dim oCurCountry As New Country
                oCurCountry.CountryID = oReader.GetString(0)
                oCurCountry.CountryName = oReader.GetString(1)
                If Not oCountries.Contains(oCurCountry.CountryID) Then
                    oCountries.Add(oCurCountry, oCurCountry.CountryID)
                End If
            Loop
        End If

        oReader.Close()

        oConn.Close()


        loCurrentGrower = GlobalVariables.CurrentGrower
        txtFirstName.Text = loCurrentGrower.GrowerFirstName
        txtLastName.Text = loCurrentGrower.GrowerLastName
        If loCurrentGrower.GrowerProspect = "Y" Then
            ckProspect.Checked = True
        Else
            ckProspect.Checked = False
            ckProspect.Enabled = False
        End If
        txtAddress1.Text = loCurrentGrower.GrowerAddress1
        txtAddress2.Text = loCurrentGrower.GrowerAddress2
        txtCity.Text = loCurrentGrower.GrowerCity
        txtCounty.Text = loCurrentGrower.GrowerCounty
        sCurCountry = "US"

        If loCurrentGrower.GrowerCountry = "US" Then
            sCurCountry = "US"
            rbUSA.Checked = True

        End If

        If loCurrentGrower.GrowerCountry = "CA" Then
            sCurCountry = "CA"
            rbCanada.Checked = True
        End If

        If Len(loCurrentGrower.GrowerCountry) = 2 Then
            If (loCurrentGrower.GrowerCountry <> "US") And (loCurrentGrower.GrowerCountry <> "CA") Then
                sCurCountry = loCurrentGrower.GrowerCountry
                rbOther.Checked = True
            End If
        End If

        If Not (rbUSA.Checked Or rbCanada.Checked Or rbOther.Checked) Then
            rbUSA.Checked = True
        End If
        'txtState.Text = loCurrentGrower.GrowerState
        'If rbUSA.Checked Then Tnen
        's
        iCurIndex = cmbState.FindStringExact(loCurrentGrower.GrowerState)
        cmbState.SelectedIndex = iCurIndex
        'If loCurrentGrower.GrowerCountry Then
        txtZip.Text = loCurrentGrower.GrowerZip
        txtWorkPhone.Text = loCurrentGrower.GrowerPhone1
        txtCellPhone.Text = loCurrentGrower.GrowerPhone2
        For Each oCurrentVendor In loCurrentGrower.Vendors
            iCnt = 0
            iMax = lstVendors.Items.Count - 1
            Do While iCnt <= iMax
                If oVendIDs(iCnt.ToString()) = oCurrentVendor.VendorID Then
                    lstVendors.SelectedIndices.Add(iCnt)
                End If
                iCnt = iCnt + 1
            Loop

        Next
        'txtFax.Text = loCurrentGrower.Grower
        'txtEmail.Text = loCurrentGrower.

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sSql As String
        Dim sDate As String
        Dim bDataValidated As Boolean
        Dim sProspect As String
        Dim sCurCountry As String
        Dim loCurrentGrower As Grower
        Dim sCollIndex As String
        Dim oConn As SqlConnection

        loCurrentGrower = GlobalVariables.CurrentGrower
        GlobalVariables.iAddedGrowerID = 0
        GlobalVariables.ResetGrower = True

        Dim sTestProd As String
        sTestProd = GlobalVariables.sEnv
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        oConn.Open()
        Dim myCmd = oConn.CreateCommand
        bDataValidated = True
        If Len(txtFirstName.Text.ToString()) = 0 Then
            MessageBox.Show("First Name is required.")
            bDataValidated = False
        End If

        If Len(txtLastName.Text.ToString()) = 0 Then
            MessageBox.Show("Last Name is required.")
            bDataValidated = False
        End If
        sProspect = "N"
        If Not ckProspect.Checked Then
            If lstVendors.SelectedIndices.Count = 0 Then
                MessageBox.Show("If Grower is not a Prospect, at least one associated Vendor must be selected.")
                bDataValidated = False
            End If
        End If

        If cmbState.SelectedIndex <> -1 Then
            If Len(cmbState.SelectedItem.ToString()) = 0 Then
                MessageBox.Show("State must be selected.")
                bDataValidated = False
            End If
        Else
            MessageBox.Show("State must be selected.")
            bDataValidated = False
        End If

        If bDataValidated Then
            sDate = Now().ToString("yyyy-MM-dd HH:mm:ss")
            sCurCountry = "US"
            If rbUSA.Checked Then
                sCurCountry = "US"
            End If
            If rbCanada.Checked Then
                sCurCountry = "CA"
            End If
            If rbOther.Checked Then
                sCurCountry = oCountries(cmbState.SelectedIndex).CountryID
            End If
            sSql = "UPDATE growers "
            sSql = sSql & "SET grower_prospect = '" & sProspect & "', "
            sSql = sSql & "grower_first_name = '" & GlobalVariables.DQuot(txtFirstName.Text.ToString()) & "', "
            sSql = sSql & "grower_last_name = '" & GlobalVariables.DQuot(txtLastName.Text.ToString()) & "', "
            sSql = sSql & "grower_address_line_1 = '" & GlobalVariables.DQuot(txtAddress1.Text.ToString()) & "', "
            sSql = sSql & "grower_address_line_2 = '" & GlobalVariables.DQuot(txtAddress2.Text.ToString()) & "', "
            sSql = sSql & "grower_city = '" & GlobalVariables.DQuot(txtCity.Text.ToString()) & "', "
            sSql = sSql & "grower_county = '" & GlobalVariables.DQuot(txtCounty.Text.ToString()) & "', "
            sSql = sSql & "grower_state = '" & GlobalVariables.DQuot(cmbState.SelectedItem.ToString()) & "', "
            sSql = sSql & "grower_country = '" & sCurCountry & "', "
            sSql = sSql & "grower_zip = '" & GlobalVariables.DQuot(txtZip.Text.ToString()) & "', "
            sSql = sSql & "grower_phone1 = '" & GlobalVariables.DQuot(txtWorkPhone.Text.ToString()) & "', "
            sSql = sSql & "grower_phone2 = '" & GlobalVariables.DQuot(txtCellPhone.Text.ToString()) & "', "
            sSql = sSql & "grower_fax = '" & GlobalVariables.DQuot(txtFax.Text.ToString()) & "', "
            sSql = sSql & "grower_email = '" & GlobalVariables.DQuot(txtEmail.Text.ToString()) & "' "
            sSql = sSql & "WHERE grower_id = " & GlobalVariables.CurrentGrower.GrowerID.ToString()


            myCmd.CommandText = sSql

            myCmd.ExecuteNonQuery()
            GlobalVariables.CurrentGrower.GrowerProspect = sProspect
            GlobalVariables.CurrentGrower.GrowerFirstName = txtFirstName.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerLastName = txtLastName.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerAddress1 = txtAddress1.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerAddress2 = txtAddress2.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerCity = txtCity.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerCountry = txtCounty.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerState = cmbState.SelectedItem.ToString()
            GlobalVariables.CurrentGrower.GrowerCountry = sCurCountry
            GlobalVariables.CurrentGrower.GrowerZip = txtZip.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerPhone1 = txtWorkPhone.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerPhone2 = txtCellPhone.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerFax = txtFax.Text.ToString()
            GlobalVariables.CurrentGrower.GrowerEmail = txtEmail.Text.ToString()


            If ckProspect.Checked = False Then
                sSql = "DELETE FROM growers_vendors "
                sSql = sSql & "WHERE grower_id = " & GlobalVariables.CurrentGrower.GrowerID.ToString()
                myCmd.CommandText = sSql
                myCmd.ExecuteNonQuery()


                GlobalVariables.CurrentGrower.Vendors.Clear()
                For Each iIndex In lstVendors.SelectedIndices
                    sCollIndex = oVendIDs(iIndex.ToString()).ToString()
                    sSql = "INSERT INTO growers_vendors (grower_id, vendor_id) "
                    sSql = sSql & "VALUES (" & GlobalVariables.CurrentGrower.GrowerID.ToString() & ", " & oVendIDs(iIndex.ToString()).ToString() & ")"
                    myCmd.CommandText = sSql
                    myCmd.ExecuteNonQuery()
                    GlobalVariables.CurrentGrower.Vendors.Add(GlobalVariables.VendorList(sCollIndex))
                Next
            End If
            GlobalVariables.BuildComm = True
            Me.Close()
        End If


    End Sub

    Private Sub lstVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVendors.SelectedIndexChanged
        If lstVendors.SelectedIndices.Count > 8 Then
            If lstVendors.SelectedIndices.Count > 8 Then
                MessageBox.Show("Limit of 8 Vendors per Grower.")
                lstVendors.SetSelected(lstVendors.SelectedIndex, False)
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub txtCounty_TextChanged(sender As Object, e As EventArgs) Handles txtCounty.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub rbUSA_CheckedChanged(sender As Object, e As EventArgs) Handles rbUSA.CheckedChanged
        Dim iMax As Integer
        Dim iCnt As Integer

        If rbUSA.Checked Then
            iMax = oStates.Count
            iCnt = 1
            cmbState.Items.Clear()

            Do While iCnt <= iMax
                cmbState.Items.Add(oStates(iCnt).StateName)
                iCnt = iCnt + 1
            Loop

        End If
    End Sub

    Private Sub rbCanada_CheckedChanged(sender As Object, e As EventArgs) Handles rbCanada.CheckedChanged
        Dim iMax As Integer
        Dim iCnt As Integer

        If rbCanada.Checked Then
            iMax = oProvinces.Count
            iCnt = 1
            cmbState.Items.Clear()

            Do While iCnt <= iMax
                cmbState.Items.Add(oProvinces(iCnt).ProvinceName)
                iCnt = iCnt + 1
            Loop
        End If
    End Sub

    Private Sub rbOther_CheckedChanged(sender As Object, e As EventArgs) Handles rbOther.CheckedChanged
        Dim iMax As Integer
        Dim iCnt As Integer

        If rbOther.Checked Then
            iMax = oCountries.Count
            iCnt = 1
            cmbState.Items.Clear()

            Do While iCnt <= iMax
                cmbState.Items.Add(oCountries(iCnt).CountryName)
                iCnt = iCnt + 1
            Loop
        End If
    End Sub

    Private Sub txtCellPhone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCellPhone.MaskInputRejected

    End Sub

    Private Sub txtZip_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckProspect_CheckedChanged(sender As Object, e As EventArgs) Handles ckProspect.CheckedChanged
        If Me.ckProspect.Checked Then
            lstVendors.ClearSelected()
            lstVendors.Enabled = False
        Else
            lstVendors.Enabled = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class