Option Strict Off
Imports System.Data.SqlClient


Public Class FormAddGrower
    Dim oVendIDs As New Collection
    Dim oStates As New Collection
    Dim oProvinces As New Collection
    Dim oCountries As New Collection
    Dim iLastSelectedVendor As Integer
    Dim oCollGrowVendComm As New Collection

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblState.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormAddGrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oConn As SqlConnection
        Dim sTestProd As String
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


        sSql = "SELECT DISTINCT vendors.vendor_id, vendors.vendor_name "
        sSql = sSql & "FROM users, users_facilities, vendors, vendors_facilities, facilities "
        ' = sSql & "WHERE vendors_facilities.facility_id IN ("
        'For Each iID In GlobalVariables.UserFacilityIDs
        ' sSql = sSql & iID.ToString() & ", "
        'Next
        'sSql = sSql & ")"
        'sSql = Replace(sSql, ", )", " )")
        'sSql = sSql & " "
        sSql = sSql & "WHERE users.user_id = " & GlobalVariables.UserId.ToString() & " "
        sSql = sSql & "AND users_facilities.user_id = users.user_id "
        sSql = sSql & "AND users_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
        sSql = sSql & "AND vendors_facilities.facility_id = facilities.facility_id "
        sSql = sSql & "AND vendors.vendor_dummy = 'N' "
        sSql = sSql & "AND LEN(ISNULL(agtech_vendor_id, '')) > 4 "
        sSql = sSql & "ORDER BY vendors.vendor_name"
        myCmd.CommandText = sSql

        Dim oReader = myCmd.ExecuteReader()

        'lstVendors.Sorted = True
        'lstVendors.ValueMember = "VendorCollectionIndex"
        'lstVendors.DisplayMember = "VendorName"

        iMax = oCollGrowVendComm.Count
        iCnt = 1

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

        rbUSA.Checked = True
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sSql As String
        Dim sDate As String
        Dim iGrowerID As Integer
        Dim iVendorID As Integer
        Dim bDataValidated As Boolean
        Dim sProspect As String
        Dim sCurCountryCode As String
        Dim oConn As SqlConnection
        'Dim sProsVendorName As String

        sCurCountryCode = "US"
        If rbUSA.Checked Then
            sCurCountryCode = "US"
        End If

        If rbCanada.Checked Then
            sCurCountryCode = "CA"
        End If

        If rbOther.Checked Then
            sCurCountryCode = oCountries(cmbState.SelectedIndex + 1).CountryID
        End If

        GlobalVariables.iAddedGrowerID = 0
        GlobalVariables.ResetGrower = True
        'Dim iCnt As Integer
        'Dim iMax As Integer
        'Dim oReader As SqlDataReader

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

            If lstVendors.SelectedIndices.Count > 8 Then
                MessageBox.Show("Maximum number of Vendors (8) exceeded.")
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
            GlobalVariables.bGrowerAdd = True
            iVendorID = 0
            If ckProspect.Checked Then
                'sProsVendorName = Year(Now().ToString()) & Month(Now().ToString()) & DateTime.Now.Day().ToString()
                'sProsVendorName = sProsVendorName & Hour(Now()).ToString() & Minute(Now()).ToString() & Second(Now()).ToString()
                'sSql = "INSERT INTO vendors (vendor_name, vendor_dummy) "
                'sSql = sSql & "VALUES ('" & sProsVendorName
                'sSql = sSql & "', 'Y'); SELECT SCOPE_IDENTITY()"
                'myCmd.CommandText = sSql
                'iVendorID = myCmd.ExecuteScalar()
                'GlobalVariables.iAddedVendorID = iVendorID

                'Dim oNewVendor As New Vendor
                'oNewVendor.VendorID = iVendorID
                'oNewVendor.VendorName = sProsVendorName
                'oNewVendor.VendorDummy = "Y"
                'GlobalVariables.VendorList.Add(oNewVendor, oNewVendor.VendorID.ToString())
                iVendorID = GlobalVariables.CurrentUVDID
                GlobalVariables.iAddedVendorID = iVendorID
                sProspect = "Y"
            End If
            sDate = Now().ToString("yyyy-MM-dd HH:mm:ss")

            sSql = "INSERT INTO growers (grower_prospect, grower_first_name, grower_last_name, grower_address_line_1, grower_address_line_2, "
            sSql = sSql & "grower_city, grower_county, grower_state, grower_zip, grower_country, grower_phone1, grower_phone2, grower_fax, "
            sSql = sSql & "grower_email, grower_date_created, grower_created_by, grower_comment) "
            sSql = sSql & "VALUES ('" & sProspect & "', '" & GlobalVariables.DQuot(txtFirstName.Text) & "', '" & GlobalVariables.DQuot(txtLastName.Text) & "', '" & GlobalVariables.DQuot(txtAddress1.Text) & "', '" & GlobalVariables.DQuot(txtAddress2.Text) & "', '"
            'sSql = sSql & txtCity.Text & "', '" & txtCounty.Text & "', '" & txtState.Text & "', '" & txtZip.Text & "', '" & "US" & "', '" & txtWorkPhone.Text & "', '"
            sSql = sSql & GlobalVariables.DQuot(txtCity.Text) & "', '" & GlobalVariables.DQuot(txtCounty.Text) & "', '" & cmbState.SelectedItem.ToString() & "', '" & GlobalVariables.DQuot(txtZip.Text) & "', '" & GlobalVariables.DQuot(sCurCountryCode) & "', '" & GlobalVariables.DQuot(txtWorkPhone.Text) & "', '"
            sSql = sSql & GlobalVariables.DQuot(txtCellPhone.Text) & "', '" & GlobalVariables.DQuot(txtFax.Text) & "', '" & GlobalVariables.DQuot(txtEmail.Text) & "', '" & sDate & "', " & GlobalVariables.UserId.ToString() & ", "
            sSql = sSql & "'" & GlobalVariables.DQuot(txtComment.Text) & "'"
            sSql = sSql & "); SELECT SCOPE_IDENTITY()"
            '"INSERT INTO table (Databasevalue) VALUES ('" + formvalue + "'); SELECT SCOPE_IDENTITY()"
            myCmd.CommandText = sSql

            iGrowerID = myCmd.ExecuteScalar()
            GlobalVariables.iAddedGrowerID = iGrowerID
            'sSql = "SELECT @@IDENTITY"
            'myCmd.CommandText = sSql
            'oReader = myCmd.ExecuteReader()
            'iGrowerID = oReader.GetInt32(0)

            If ckProspect.Checked Then
                'For Each FacID In GlobalVariables.UserFacilityIDs
                'sSql = "INSERT INTO vendors_facilities (vendor_id, facility_id) "
                'sSql = sSql & "VALUES (" & iVendorID.ToString() & ", "
                'sSql = sSql & FacID.ToString() & "); SELECT SCOPE_IDENTITY()"
                'myCmd.CommandText = sSql
                'myCmd.ExecuteNonQuery()

                'Next
                sSql = "INSERT INTO growers_vendors (grower_id, vendor_id) "
                sSql = sSql & "VALUES (" & iGrowerID.ToString() & ", " & iVendorID.ToString() & ")"
                myCmd.CommandText = sSql
                myCmd.ExecuteNonQuery()
            Else
                For Each iIndex In lstVendors.SelectedIndices
                    sSql = "INSERT INTO growers_vendors (grower_id, vendor_id) "
                    sSql = sSql & "VALUES (" & iGrowerID.ToString() & ", " & oVendIDs(iIndex.ToString()).ToString() & ")"
                    myCmd.CommandText = sSql
                    myCmd.ExecuteNonQuery()
                Next
            End If
            Me.Close()
        End If

    End Sub

    Private Sub ckProspect_CheckedChanged(sender As Object, e As EventArgs) Handles ckProspect.CheckedChanged
        If Me.ckProspect.Checked Then
            lstVendors.ClearSelected()
            lstVendors.Enabled = False
        Else
            lstVendors.Enabled = True

        End If
    End Sub

    Private Sub txtCounty_TextChanged(sender As Object, e As EventArgs) Handles txtCounty.TextChanged

    End Sub

    Private Sub txtAddress1_TextChanged(sender As Object, e As EventArgs) Handles txtAddress1.TextChanged

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVariables.ResetGrower = False
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lstVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVendors.SelectedIndexChanged
        If lstVendors.SelectedIndices.Count > 8 Then
            MessageBox.Show("Limit of 8 Vendors per Grower.")
            lstVendors.SetSelected(lstVendors.SelectedIndex, False)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbUSA.CheckedChanged
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

    Private Sub txtWorkPhone_TextChanged(sender As Object, e As EventArgs)
    End Sub


End Class