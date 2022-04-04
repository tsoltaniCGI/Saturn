Option Strict Off
Imports Outlook = Microsoft.Office.Interop.Outlook
'Imports Syncfusion.Windows.Forms

Public Class frmAddReminder
    Dim oApp As New Outlook.Application
    Dim oNS As Outlook.NameSpace
    Dim oTask As Outlook.TaskItem



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        oNS = Nothing
        oTask = Nothing

        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim bValidated As Boolean
        bValidated = True


        If Len(txtSubject.Text) = 0 Then
            MessageBox.Show("Subject cannot be blank")
            bValidated = False
        End If

        If bValidated Then
            ' Create an Outlook application.
            'oApp n = New Outlook.Application()

            ' Get NameSpace and Logon.
            'oNS = oApp.GetNamespace("mapi") 'oNS.Logon("Outlook", Missing.Value, False, True)

            ' TODO: ' Create a new TaskItem.
            'oTask = oApp.CreateItem(Outlook.OlItemType.olTaskItem)

            ' Assign the task
            'oTask.Assign()

            ' Add recipients to the task
            'OTask.Recipients.Add("sridhar@yahoo.com")

            ' Add the subject to the task
            oTask.Subject = txtSubject.Text

            'Add the body to the task
            oTask.Body = txtTask.Text

            'MessageBox.Show(dttnPckTaskDate.Text)
            Dim dtStr As String

            dtStr = dttnPckTaskDate.Text & " " & cmbTime.SelectedItem

            Dim dtTaskDate As DateTime = DateTime.Parse(dtStr, System.Globalization.CultureInfo.InvariantCulture)

            ' Add the Task duedate

            'oTask.DueDate = DateTime.Today
            oTask.DueDate = dtTaskDate


            ' Set the reminder to the task
            oTask.ReminderSet = True
            'oAppt1.ReminderSet = True

            ' Set the reminder time

            oTask.ReminderTime = dtTaskDate

            ' If you want to display the task uncomment the next line

            'OTask.Display(True)

            ' Save the task to outlook
            oTask.Save()

            ' Send the task
            'oAppt1.Send()

            ' Log off.
            'oNS.Logoff()

            Me.Close()

            ' Clean up.
        End If
        oApp = Nothing
        oNS = Nothing

    End Sub

    Private Sub cmbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTime.SelectedIndexChanged

    End Sub

    Private Sub frmAddReminder_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        oNS = oApp.GetNamespace("mapi") 'oNS.Logon("Outlook", Missing.Value, False, True)

        ' TODO: ' Create a new TaskItem.
        oTask = oApp.CreateItem(Outlook.OlItemType.olTaskItem)
        GlobalVariables.CurrentTasks.Clear()
        GlobalVariables.CurrentTasks.Add(oTask)
        cmbTime.Items.Add("12:00 AM")
        cmbTime.Items.Add("12:30 AM")
        cmbTime.Items.Add("01:00 AM")
        cmbTime.Items.Add("01:30 AM")
        cmbTime.Items.Add("02:00 AM")
        cmbTime.Items.Add("02:30 AM")
        cmbTime.Items.Add("03:00 AM")
        cmbTime.Items.Add("03:30 AM")
        cmbTime.Items.Add("04:00 AM")
        cmbTime.Items.Add("04:30 AM")
        cmbTime.Items.Add("05:00 AM")
        cmbTime.Items.Add("05:30 AM")
        cmbTime.Items.Add("06:00 AM")
        cmbTime.Items.Add("06:30 AM")
        cmbTime.Items.Add("07:00 AM")
        cmbTime.Items.Add("07:30 AM")
        cmbTime.Items.Add("08:00 AM")
        cmbTime.Items.Add("08:30 AM")
        cmbTime.Items.Add("09:00 AM")
        cmbTime.Items.Add("09:30 AM")
        cmbTime.Items.Add("10:00 AM")
        cmbTime.Items.Add("10:30 AM")
        cmbTime.Items.Add("11:00 AM")
        cmbTime.Items.Add("11:30 AM")
        cmbTime.Items.Add("12:00 PM")
        cmbTime.Items.Add("12:30 PM")
        cmbTime.Items.Add("01:00 PM")
        cmbTime.Items.Add("01:30 PM")
        cmbTime.Items.Add("02:00 PM")
        cmbTime.Items.Add("02:30 PM")
        cmbTime.Items.Add("03:00 PM")
        cmbTime.Items.Add("03:30 PM")
        cmbTime.Items.Add("04:00 PM")
        cmbTime.Items.Add("04:30 PM")
        cmbTime.Items.Add("05:00 PM")
        cmbTime.Items.Add("05:30 PM")
        cmbTime.Items.Add("06:00 PM")
        cmbTime.Items.Add("06:30 PM")
        cmbTime.Items.Add("07:00 PM")
        cmbTime.Items.Add("07:30 PM")
        cmbTime.Items.Add("08:00 PM")
        cmbTime.Items.Add("08:30 PM")
        cmbTime.Items.Add("09:00 PM")
        cmbTime.Items.Add("09:30 PM")
        cmbTime.Items.Add("10:00 PM")
        cmbTime.Items.Add("10:30 PM")
        cmbTime.Items.Add("11:00 PM")
        cmbTime.Items.Add("11:30 PM")

        lblStartDate.Visible = False
        lblStartDateText.Visible = False
        lblEndDate.Visible = False
        lblEndDateText.Visible = False
        lblTaskTime.Visible = False
        lblRecurrence.Visible = False
        LabelRecurrence.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRecurrence_Click(sender As Object, e As EventArgs) Handles btnRecurrence.Click
        Dim oFrmRec As New FormAddRecurrence
        Dim oPattern As Outlook.RecurrencePattern
        Dim dtStartDate As New DateTime
        Dim dtEndDate As New DateTime

        oFrmRec.ShowDialog()
        If oTask.IsRecurring Then
            dttnPckTaskDate.Enabled = False
            cmbTime.Enabled = False
            dttnPckTaskDate.Visible = False
            cmbTime.Visible = False

            oPattern = oTask.GetRecurrencePattern()
            dtStartDate = oPattern.PatternStartDate
            dtEndDate = oPattern.PatternEndDate

            lblStartDate.Visible = True
            lblStartDateText.Visible = True
            lblRecurrence.Visible = True
            LabelRecurrence.Visible = True
            lblStartDateText.Text = dtStartDate.ToString("mm/dd/yyyy")
            lblEndDate.Visible = True
            lblEndDateText.Visible = True
            lblEndDateText.Text = dtEndDate.ToString("mm/dd/yyyy")
            lblTaskTime.Visible = True
            lblTaskTime.Text = oTask.ReminderTime.ToString("t")
            Select Case oPattern.RecurrenceType
                Case Outlook.OlRecurrenceType.olRecursDaily
                    lblRecurrence.Text = "Daily"
            End Select

            Select Case oPattern.RecurrenceType
                Case Outlook.OlRecurrenceType.olRecursMonthly
                    lblRecurrence.Text = "Monthly"
            End Select

            Select Case oPattern.RecurrenceType
                Case Outlook.OlRecurrenceType.olRecursWeekly
                    lblRecurrence.Text = "Weekly"
            End Select

            Select Case oPattern.RecurrenceType
                Case Outlook.OlRecurrenceType.olRecursYearly
                    lblRecurrence.Text = "Yearly"
            End Select


        Else
            dttnPckTaskDate.Enabled = True
            cmbTime.Enabled = True
            dttnPckTaskDate.Visible = True
            cmbTime.Visible = True

            lblStartDate.Visible = False
            lblStartDateText.Visible = False
            lblEndDate.Visible = False
            lblEndDateText.Visible = False
            lblTaskTime.Visible = False



        End If
    End Sub

    Private Sub lblTaskTime_Click(sender As Object, e As EventArgs) Handles lblTaskTime.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dttnPckTaskDate_ValueChanged(sender As Object, e As EventArgs) Handles dttnPckTaskDate.ValueChanged

    End Sub
End Class