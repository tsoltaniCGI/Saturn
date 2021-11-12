Option Strict Off
Imports System.Data.SqlClient
'Imports


Public Class FormAddGrower
    Dim oVendIDs As New Collection
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtState.TextChanged

    End Sub

    Private Sub FormAddGrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oConn As New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        oConn.Open()
        Dim myCmd = oConn.CreateCommand
        Dim sSql As String
        Dim iCnt As Integer


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
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtCellPhone.TextChanged

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sSql As String
        Dim sDate As String
        Dim iGrowerID As Integer
        Dim iVendorID As Integer
        Dim bDataValidated As Boolean
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
        iVendorID = 0
        If bDataValidated Then
            If ckProspect.Checked Then
                sSql = "INSERT INTO vendors (vendor_name, vendor_dummy) "
                sSql = sSql & "VALUES ('" & Year(Now().ToString()) & Month(Now().ToString()) & DateTime.Now.Day().ToString()
                sSql = sSql & Hour(Now()).ToString() & Minute(Now()).ToString() & Second(Now()).ToString() & "', 'Y'); SELECT SCOPE_IDENTITY()"
                myCmd.CommandText = sSql
                iVendorID = myCmd.ExecuteScalar()
            End If
            sDate = Now().ToString("yyyy-MM-dd HH:mm:ss")

            sSql = "INSERT INTO growers (grower_first_name, grower_last_name, grower_address_line_1, grower_address_line_2, "
            sSql = sSql & "grower_city, grower_county, grower_state, grower_zip, grower_country, grower_phone1, grower_phone2, grower_fax, "
            sSql = sSql & "grower_email, grower_date_created, grower_created_by) "
            sSql = sSql & "VALUES ('" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & txtAddress1.Text & "', '" & txtAddress2.Text & "', '"
            sSql = sSql & txtCity.Text & "', '" & txtCounty.Text & "', '" & txtState.Text & "', '" & txtZip.Text & "', '" & "US" & "', '" & txtWorkPhone.Text & "', '"
            sSql = sSql & txtCellPhone.Text & "', '" & txtFax.Text & "', '" & txtEmail.Text & "', '" & sDate & "', " & GlobalVariables.UserId.ToString() & "); SELECT SCOPE_IDENTITY()"
            '"INSERT INTO table (Databasevalue) VALUES ('" + formvalue + "'); SELECT SCOPE_IDENTITY()"
            myCmd.CommandText = sSql

            iGrowerID = myCmd.ExecuteScalar()
            'sSql = "SELECT @@IDENTITY"
            'myCmd.CommandText = sSql
            'oReader = myCmd.ExecuteReader()
            'iGrowerID = oReader.GetInt32(0)

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
                For Each iIndex In lstVendors.SelectedIndices
                    sSql = "INSERT INTO growers_vendors (grower_id, vendor_id) "
                    sSql = sSql & "VALUES (" & iGrowerID.ToString() & ", " & oVendIDs(iIndex.ToString()).ToString() & ")"
                    myCmd.CommandText = sSql
                    myCmd.ExecuteNonQuery()
                Next
            End If
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
End Class