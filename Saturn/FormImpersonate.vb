Option Strict Off
Imports System.Data.SqlClient

Public Class FormImpersonate

    Inherits System.Windows.Forms.Form
    Dim oConn As New System.Data.SqlClient.SqlConnection
    Dim myCmd As New System.Data.SqlClient.SqlCommand
    Dim oReader As SqlDataReader
    Dim sSql As String
    Dim oCollImpLogin As New Collection



    Private Sub ImpersonateUsesr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sTestProd As String
        sTestProd = GlobalVariables.sEnv
        If sTestProd = "P" Then
            oConn = New SqlConnection("Server=pdx-sql14;Database=SATURN_PROD;UID=saturndba;PWD=saturndba")
        Else
            oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        End If

        oConn.Open()
        myCmd = oConn.CreateCommand
        sSql = "SELECT user_first_name, user_last_name, user_login "
        sSql = sSql & "FROM Users "
        sSql = sSql & "WHERE user_role <> 1 "
        sSql = sSql & "OR user_role IS NULL "
        sSql = sSql & "ORDER BY user_first_name, user_last_name "
        myCmd.CommandText = sSql



        oReader = myCmd.ExecuteReader()
        If oReader.HasRows() Then
            Do While oReader.Read()
                cmbUsers.Items.Add(oReader.GetString(0) & " " & oReader.GetString(1))
                oCollImpLogin.Add(oReader.GetString(2).ToString().ToUpper())
            Loop
        End If
    End Sub

    Private Sub btnImpersonateOK_Click(sender As Object, e As EventArgs) Handles btnImpersonateOK.Click

        GlobalVariables.ImpLogin = oCollImpLogin(cmbUsers.SelectedIndex + 1).ToString()

        Me.Close()


    End Sub

    Private Sub btnImpersonateCancel_Click(sender As Object, e As EventArgs) Handles btnImpersonateCancel.Click
        GlobalVariables.ImpLogin = ""
        Me.Close()
    End Sub
End Class