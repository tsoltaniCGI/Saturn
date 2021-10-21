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
        Label4.Text = ""


        Label4.Visible = False
        bValidated = False
        If ValidateActiveDirectoryLogin("columbiagrain.com", txtUserName.Text.ToString(), txtPassword.Text.ToString()) Then

            oConn = New System.Data.SqlClient.SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
            myCmd = oConn.CreateCommand
            sSql = "SELECT user_id "
            sSql = sSql & "FROM users "
            sSql = sSql & "WHERE user_login = '" & Trim(txtUserName.Text.ToString().ToUpper()) & "'"
            myCmd.CommandText = sSql
            oConn.Open()

            oReader = myCmd.ExecuteReader()
            If oReader.HasRows Then
                Me.bAppExit = False
                oReader.Read()
                iUserId = oReader.GetInt32(0)
                GlobalVariables.UserId = iUserId
                Label4.Text = "Validated"
                Me.Close()
                Dim oFormMain As New FormMain
                oFormMain.Show()
                oFormMain.TopMost = True
            Else
                Label4.Visible = True
                Label4.Text = "There is NO **** way you are getting into Saturn with those credentials!"
            End If

        Else
            Label4.Visible = True
            Label4.Text = "There is NO **** way you are getting into Saturn with those credentials!"
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
End Class