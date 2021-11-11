Public Class FormNote
    Private Sub FormNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DialogResult = Windows.Forms.DialogResult.OK
        GlobalVariables.ResetNote = False
        lblName.Text = GlobalVariables.GrowerFirstName
        lblAddress.Text = GlobalVariables.GrowerAddress1
        lblGrowerCity.Text = GlobalVariables.GrowerCity
        lblGrowerState.Text = GlobalVariables.GrowerState
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
        GlobalVariables.CurrentNoteSubject = txtSubject.Text
        Me.Close()
    End Sub
End Class