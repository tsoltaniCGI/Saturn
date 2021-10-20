Public Class FormLogin
    Public Property bAppExit As Boolean
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.bAppExit = True
        Me.AcceptButton = btnLogin
        btnLogin.NotifyDefault(True)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Label4.Text = ""
        Me.bAppExit = False
        Label4.Visible = False

        If ValidateActiveDirectoryLogin("columbiagrain.com", txtUserName.Text.ToString(), txtPassword.Text.ToString()) Then
            Label4.Text = "Validated"
            Me.Close()
            Dim oFormMain As New FormMain
            oFormMain.Show()
            oFormMain.TopMost = True
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