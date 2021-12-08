Option Strict Off
Imports System.Data.SqlClient
Public Class FormEditGrower
    Dim oVendIDs As New Collection


    Private Sub FormEditGrower_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loCurrentGrower As Grower
        Dim oCurrentVendor As Vendor
        Dim oConn As New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        oConn.Open()
        Dim myCmd = oConn.CreateCommand
        Dim sSql As String
        Dim iCnt As Integer
        Dim iMax As Integer

        sSql = "SELECT DISTINCT vendors.vendor_id, vendors.vendor_name "
        sSql = sSql & "FROM vendors, vendors_facilities "
        sSql = sSql & "WHERE vendors_facilities.facility_id IN ("
        For Each iID In GlobalVariables.UserFacilityIDs
            sSql = sSql & iID.ToString() & ", "
        Next
        sSql = sSql & ")"
        sSql = Replace(sSql, ", )", " )")
        sSql = sSql & " "
        sSql = sSql & "AND vendors.vendor_id = vendors_facilities.vendor_id "
        sSql = sSql & "AND vendors.vendor_dummy = 'N'"
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
        oConn.Close()


        loCurrentGrower = GlobalVariables.CurrentGrower
        txtFirstName.Text = loCurrentGrower.GrowerFirstName
        txtLastName.Text = loCurrentGrower.GrowerLastName
        If loCurrentGrower.GrowerProspect = "Y" Then
            ckProspect.Checked = True
        Else
            ckProspect.Checked = False
        End If
        txtAddress1.Text = loCurrentGrower.GrowerAddress1
        txtAddress2.Text = loCurrentGrower.GrowerAddress2
        txtCity.Text = loCurrentGrower.GrowerCity
        txtCounty.Text = loCurrentGrower.GrowerCounty
        txtState.Text = loCurrentGrower.GrowerState
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
        Dim iGrowerID As Integer
        Dim iVendorID As Integer
        Dim bDataValidated As Boolean
        Dim sProspect As String
        GlobalVariables.iAddedGrowerID = 0
        GlobalVariables.ResetGrower = True
        'Dim iCnt As Integer
        'Dim iMax As Integer
        'Dim oReader As SqlDataReader
        Dim oConn As New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
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
        iVendorID = 0
        If bDataValidated Then
            'If ckProspect.Checked Then
            ' sSql = "INSERT INTO vendors (vendor_name, vendor_dummy) "
            ' sSql = sSql & "VALUES ('" & Year(Now().ToString()) & Month(Now().ToString()) & DateTime.Now.Day().ToString()
            ' sSql = sSql & Hour(Now()).ToString() & Minute(Now()).ToString() & Second(Now()).ToString() & "', 'Y'); SELECT SCOPE_IDENTITY()"
            ' myCmd.CommandText = sSql
            ' iVendorID = myCmd.ExecuteScalar()
            ' GlobalVariables.iAddedVendorID = iVendorID
            ' sProspect = "Y"
            ' End If
            sDate = Now().ToString("yyyy-MM-dd HH:mm:ss")
            'Start with Vendor List

            'sSql = "INSERT INTO growers (grower_prospect, grower_first_name, grower_last_name, grower_address_line_1, grower_address_line_2, "
            'sSql = sSql & "grower_city, grower_county, grower_state, grower_zip, grower_country, grower_phone1, grower_phone2, grower_fax, "
            'sSql = sSql & "grower_email, grower_date_created, grower_created_by) "
            'sSql = sSql & "VALUES ('" & sProspect & "', '" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & txtAddress1.Text & "', '" & txtAddress2.Text & "', '"
            'sSql = sSql & txtCity.Text & "', '" & txtCounty.Text & "', '" & txtState.Text & "', '" & txtZip.Text & "', '" & "US" & "', '" & txtWorkPhone.Text & "', '"
            'sSql = sSql & txtCellPhone.Text & "', '" & txtFax.Text & "', '" & txtEmail.Text & "', '" & sDate & "', " & GlobalVariables.UserId.ToString() & "); SELECT SCOPE_IDENTITY()"
            '"INSERT INTO table (Databasevalue) VALUES ('" + formvalue + "'); SELECT SCOPE_IDENTITY()"
            sSql = "UPDATE growers "
            sSql = sSql & "SET grower_prospect = '" & sProspect & "', "
            sSql = sSql & "grower_first_name = '" & GlobalVariables.DQuot(txtFirstName.Text.ToString()) & "', "
            sSql = sSql & "grower_last_name = '" & GlobalVariables.DQuot(txtLastName.Text.ToString()) & "', "
            sSql = sSql & "grower_address_line_1 = '" & GlobalVariables.DQuot(txtAddress1.Text.ToString()) & "', "
            sSql = sSql & "grower_address_line_2 = '" & GlobalVariables.DQuot(txtAddress2.Text.ToString()) & "', "
            sSql = sSql & "grower_city = '" & GlobalVariables.DQuot(txtCity.Text.ToString()) & "', "
            sSql = sSql & "grower_county = '" & GlobalVariables.DQuot(txtCounty.Text.ToString()) & "', "
            sSql = sSql & "grower_state = '" & GlobalVariables.DQuot(txtState.Text.ToString()) & "', "
            sSql = sSql & "grower_zip = '" & GlobalVariables.DQuot(txtZip.Text.ToString()) & "', "
            sSql = sSql & "grower_country = 'US', "
            sSql = sSql & "grower_phone1 = '" & GlobalVariables.DQuot(txtWorkPhone.Text.ToString()) & "', "
            sSql = sSql & "grower_phone2 = '" & GlobalVariables.DQuot(txtCellPhone.Text.ToString()) & "', "
            sSql = sSql & "grower_fax = '" & GlobalVariables.DQuot(txtFax.Text.ToString()) & "', "
            sSql = sSql & "grower_email = '" & GlobalVariables.DQuot(txtEmail.Text.ToString()) & "' "
            sSql = sSql & "WHERE grower_id = " & GlobalVariables.CurrentGrower.GrowerID.ToString()


            myCmd.CommandText = sSql

            myCmd.ExecuteNonQuery()
            'GlobalVariables.iAddedGrowerID = iGrowerID
            'sSql = "SELECT @@IDENTITY"
            'myCmd.CommandText = sSql
            'oReader = myCmd.ExecuteReader()
            'iGrowerID = oReader.GetInt32(0)

            sSql = "DELETE FROM growers_vendors "
            sSql = sSql & "WHERE grower_id = " & GlobalVariables.CurrentGrower.GrowerID.ToString()
            myCmd.CommandText = sSql
            myCmd.ExecuteNonQuery()

            If ckProspect.Checked Then
                For Each FacID In GlobalVariables.UserFacilityIDs
                    sSql = "INSERT INTO vendors_facilities (vendor_id, facility_id) "
                    sSql = sSql & "VALUES (" & iVendorID.ToString() & ", "
                    sSql = sSql & FacID.ToString() & ")"
                    myCmd.CommandText = sSql
                    myCmd.ExecuteNonQuery()
                Next
                sSql = "INSERT INTO growers_vendors (grower_id, vendor_id) "
                sSql = sSql & "VALUES (" & iGrowerID.ToString() & ", " & iVendorID.ToString() & ")"
                myCmd.CommandText = sSql
                myCmd.ExecuteNonQuery()
            Else
                GlobalVariables.CurrentGrower.Vendors.Clear()
                For Each iIndex In lstVendors.SelectedIndices
                    sSql = "INSERT INTO growers_vendors (grower_id, vendor_id) "
                    sSql = sSql & "VALUES (" & GlobalVariables.CurrentGrower.GrowerID.ToString() & ", " & oVendIDs(iIndex.ToString()).ToString() & ")"
                    myCmd.CommandText = sSql
                    myCmd.ExecuteNonQuery()
                    Dim oNewVendor As New Vendor
                    oNewVendor.VendorID = oVendIDs(iIndex.ToString()).ToString()
                    oNewVendor.VendorName = lstVendors.Items(iIndex)
                    oNewVendor.VendorDummy = "N"
                    GlobalVariables.CurrentGrower.Vendors.Add(oNewVendor)
                Next
            End If
        End If
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class