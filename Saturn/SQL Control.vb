Imports System.Data.SqlClient

Public Class SQL_Control
    Private DBCon As New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
    Private DBCmd As SqlCommand


    'DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' Query Parameters
    Public Params As New List(Of SqlParameter)

    ' Query Statistics
    Public RecordCounts As Integer
    Public Exeption As String

    Public Sub New()

    End Sub


    'Allow Connection String Override
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub


    'Execute Query Sub
    Public Sub ExecQuery(Query As String)
        'Reset Query Stats
        RecordCounts = 0
        Exeption = ""

        Try
            DBCon.Open()
            'Create DB Command
            DBCmd = New SqlCommand(Query, DBCon)

            'Load Params Into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Clear Param List
            Params.Clear()


            'Execute Command & Fill Dataset
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCounts = DBDA.Fill(DBDT)

        Catch ex As Exception
            'Capture Error

            'Exception = "ExecQuery Error!" & vbNewLine & ex.Message

        Finally
            ' Close Connection
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try

    End Sub

    'Add Params
    Public Sub AddParam(Name As String, value As Object)
        Dim NewParam As New SqlParameter(Name, value)
        Params.Add(NewParam)
    End Sub


    'Error Checking
    'Public Function HasException(Optional Report As Boolean = False) As Boolean
    '    If String.IsNullOrEmpty(Exception) Then Return False
    '    If Report + True Then MsgBox(Exception, MsgBoxStyle.Critical, Exception)
    'End Function
End Class
