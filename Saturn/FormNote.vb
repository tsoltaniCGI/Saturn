Imports System.Data.SqlClient
Public Class FormNote
    Dim oConn As SqlConnection
    Private Sub FormNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSql As String
        Dim oReader As SqlDataReader
        Dim myCmd As SqlCommand

        'Me.DialogResult = Windows.Forms.DialogResult.OK
        GlobalVariables.ResetNote = False
        lblName.Text = GlobalVariables.GrowerFirstName
        lblAddress.Text = GlobalVariables.GrowerAddress1
        lblGrowerCity.Text = GlobalVariables.GrowerCity
        lblGrowerState.Text = GlobalVariables.GrowerState
        'oConn.Open("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        oConn = New SqlConnection("Server=pdx-sql16;Database=SATURN_DEV;UID=saturndba;PWD=saturndba")
        oConn.Open()
        myCmd = oConn.CreateCommand
        sSql = "SELECT grower_note_method_id, grower_note_method_short_name "
        sSql = sSql & "FROM grower_note_methods "
        sSql = sSql & "ORDER BY grower_note_method_id"
        myCmd = oConn.CreateCommand()
        myCmd.CommandText = sSql
        oReader = myCmd.ExecuteReader()

        If oReader.HasRows() Then
            Do While oReader.Read()
                If oReader.GetInt32(0) <> 0 Then
                    cmbMethod.Items.Add(oReader.GetString(1))
                Else
                    cmbMethod.Items.Add("")
                End If
            Loop
        End If

        oReader.Close()
        oConn.Close()
        'cmbMethod.Items.Add("")
        'cmbMethod.Items.Add("Phone - (Work)")
        'cmbMethod.Items.Add("Phone - Left Message (Work)")
        'cmbMethod.Items.Add("Phone - (Cell)")
        'cmbMethod.Items.Add("Phone - Left Message (Cell)")
        'cmbMethod.Items.Add("Text")
        'cmbMethod.Items.Add("Email")
        'sSql = "SELECT grower_note_method_short_name FROM grower_note_methods"
        'mycmd.COmmandText = sSql
        'cmbMethod.Items.Add.oReader.GetString(0)
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub lblGrowerState_Click(sender As Object, e As EventArgs) Handles lblGrowerState.Click

    End Sub

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        GlobalVariables.ResetNote = True
        GlobalVariables.CurrentNoteText = txtNote.Text
        GlobalVariables.CurrentNoteMethod = cmbMethod.SelectedIndex
        If GlobalVariables.CurrentNoteMethod = -1 Then
            GlobalVariables.CurrentNoteMethod = 0
        End If
        GlobalVariables.CurrentNoteMethodText = cmbMethod.Text
        GlobalVariables.CurrentNoteSubject = txtSubject.Text
        GlobalVariables.CurrentNoteCreationDate = Now()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtSubject_TextChanged(sender As Object, e As EventArgs) Handles txtSubject.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class