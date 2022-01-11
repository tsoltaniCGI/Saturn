Public Class FormLogin
    Public Property bAppExit As Boolean

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.bAppExit = True
        Me.AcceptButton = btnLogin
        btnLogin.NotifyDefault(True)
        Label4.Visible = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim oConn As New System.Data.SqlClient.SqlConnection
        Dim myCmd As System.Data.SqlClient.SqlCommand
        'Dim oGrwoerCmd As SqlCommand
        Dim oReader As System.Data.SqlClient.SqlDataReader
        Dim sSql As String
        Dim iUserId As Integer
        Dim bValidated As Boolean
        Dim bUserLoaded As Boolean

        Label4.Text = ""


        Label4.Visible = False
        bValidated = False
        If ValidateActiveDirectoryLogin("columbiagrain.com", txtUserName.Text.ToString(), txtPassword.Text.ToString()) Then


            Dim sTestProd As String
            sTestProd = "P"
            If sTestProd = "P" Then
                oConn = New System.Data.SqlClient.SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
            Else
                oConn = New System.Data.SqlClient.SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
            End If

            myCmd = oConn.CreateCommand
            sSql = "SELECT users.user_id, user_first_name, user_last_name, facility_name, facilities.facility_id, dummy_vendor_id "
            sSql = sSql & "FROM users, facilities, users_facilities "
            'sSql = sSql & "WHERE user_login = '" & GlobalVariables.DQuot(Trim(txtUserName.Text.ToString().ToUpper())) & "' "
            sSql = sSql & "WHERE user_login = 'ROSBORNE' "
            sSql = sSql & "AND users_facilities.user_id = users.user_id "
            sSql = sSql & "AND users_facilities.facility_id = facilities.facility_id"
            'facilities.facility_id = ISNULL(User_facility_id, 158)"
            myCmd.CommandText = sSql
            oConn.Open()

            oReader = myCmd.ExecuteReader()
            If oReader.HasRows Then
                Me.bAppExit = False
                bUserLoaded = False
                Do While oReader.Read()
                    If Not bUserLoaded Then
                        iUserId = oReader.GetInt32(0)
                        GlobalVariables.UserId = iUserId
                        GlobalVariables.CurrentUserLogin = GlobalVariables.DQuot(Trim(txtUserName.Text.ToString().ToUpper()))
                        GlobalVariables.UserFirstName = oReader.GetString(1)
                        GlobalVariables.UserLastName = oReader.GetString(2)
                        GlobalVariables.CurrentUVDID = oReader.GetInt32(5)
                        bUserLoaded = True
                    End If
                    GlobalVariables.UserFacilityIDs.Add(oReader.GetInt32(4))
                    If Not GlobalVariables.UserFacilities.Contains(oReader.GetString(3)) Then
                        GlobalVariables.UserFacilities.Add(oReader.GetString(3), oReader.GetString(3))
                    End If
                Loop
                Label4.Text = "Validated"
                'Me.BackgroundImage = 
                Me.Close()
                Dim oFormMain As New FormMain
                oFormMain.Show()
                GlobalVariables.oFrmBackground.WindowState = FormWindowState.Minimized
                'oFormMain.TopMost = True
            Else
                Label4.Visible = True
                Label4.Text = "You are not authorized for access to Saturn.  Please contact your supervisor."
            End If

        Else
            Label4.Visible = True
            Label4.Text = "Invalid Username/Password.  Try Again."
        End If
    End Sub

    Private Function ValidateActiveDirectoryLogin(ByVal Domain As String, ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = False
        Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & Domain, Username, Password)
        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
        Try
            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
            Success = Not (Results Is Nothing)
        Catch
            Success = False
        End Try
        Return Success
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.bAppExit Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class