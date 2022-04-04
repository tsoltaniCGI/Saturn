Option Strict Off
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports System
Public Class FormAddRecurrence
    Dim oTask As Outlook.TaskItem
    Dim oNS As Outlook.NameSpace

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ckSunday_CheckedChanged(sender As Object, e As EventArgs) Handles ckSunday.CheckedChanged

    End Sub
    Private Sub CalcDOWMask(loPattern As Outlook.RecurrencePattern, liTotal As Integer)



        Select Case liTotal
                    'SMTWTFS
                            'SMTWTFS
            Case 1  '0000001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSaturday

            Case 2  '0000010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olFriday

            Case 3  '0000011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 4  '0000100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olThursday

            Case 5  '0000101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 6  '0000110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 7  '0000111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 8  '0001000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday

            Case 9  '0001001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 10 '0001010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 11 '0001011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 12 '0001100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 13 '0001101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 14 '0001110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 15 '0001111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 16 '0010000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday

            Case 17 '0010001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 18 '0010010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday

            Case 19 '0010011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 20 '0010100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday

            Case 21 '0010101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 22 '0010110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 23 '0010111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 24 '0011000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday

            Case 25 '0011001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 26 '0011010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 27 '0011011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 28 '0011100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 29 '0011101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 30 '0011110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 31 '0011111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 32 '0100000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday

            Case 33 '0100001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olSaturday

            Case 34 '0100010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olFriday

            Case 35 '0100011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 36 '0100100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday

            Case 37 '0100101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 38 '0100110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 39 '0100111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 40 '0101000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday

            Case 41 '0101001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 42 '0101010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 43 '0101011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 44 '0101100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 45 '0101101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 46 '0101110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 47 '0101111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 48 '0110000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday

            Case 49 '0110001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 50 '0110010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday

            Case 51 '0110011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 52 '0110100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday

            Case 53 '0110101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 54 '0110110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 55 '0110111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 56 '0111000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday

            Case 57 '0111001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 58 '0111010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 59 '0111011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 60 '0111100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 61 '0111101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 62 '0111110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 63 '0111111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 64 '1000000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday

            Case 65 '1000001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olSaturday

            Case 66 '1000010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olFriday

            Case 67 '1000011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 68 '1000100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olThursday

            Case 69 '1000101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 70 '1000110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 71 '1000111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 72 '1001000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday

            Case 73 '1001001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 74 '1001010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 75 '1001011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 76 '1001100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 77 '1001101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 78 '1001110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 79 '1001111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 80 '1010000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday

            Case 81 '1010001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 82 '1010010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday

            Case 83 '1010011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 84 '1010100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday

            Case 85 '1010101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 86 '1010110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 87 '1010111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 88 '1011000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday

            Case 89 '1011001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 90 '1011010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 91 '1011011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 92 '1011100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 93 '1011101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 94 '1011110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 95 '1011111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 96 '1100000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday

            Case 97 '1100001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olSaturday

            Case 98 '1100010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olFriday

            Case 99 '1100011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 100    '1100100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday

            Case 101    '1100101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 102    '1100110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 103    '1100111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 104    '1101000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday

            Case 105    '1101001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 106    '1101010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 107    '1101011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 108    '1101100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 109    '1101101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 110    '1101110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 111    '1101111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 112    '1110000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday

            Case 113    '1110001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 114    '1110010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday

            Case 115    '1110011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 116    '1110100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday

            Case 117    '1110101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 118    '1110110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 119    '1110111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 120    '1111000
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday

            Case 121    '1111001
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olSaturday

            Case 122    '1111010
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday

            Case 123    '1111011
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday

            Case 124    '1111100
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday

            Case 125    '1111101
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olSaturday

            Case 126    '1111110
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday

            Case 127    '1111111
                loPattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olSunday Or Outlook.OlDaysOfWeek.olMonday Or Outlook.OlDaysOfWeek.olTuesday Or Outlook.OlDaysOfWeek.olWednesday Or Outlook.OlDaysOfWeek.olThursday Or Outlook.OlDaysOfWeek.olFriday Or Outlook.OlDaysOfWeek.olSaturday



        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim oPattern As Outlook.RecurrencePattern
        Dim iInterval As Integer
        Dim bValidated As Boolean
        Dim iMultSun As Integer
        Dim iMultMon As Integer
        Dim iMultTue As Integer
        Dim iMultWed As Integer
        Dim iMultThu As Integer
        Dim iMultFri As Integer
        Dim iMultSat As Integer
        Dim iTotal As Integer

        iMultSat = 1
        iMultFri = 2
        iMultThu = 4
        iMultWed = 8
        iMultTue = 16
        iMultMon = 32
        iMultSun = 64
        iTotal = 0

        bValidated = True
        oPattern = oTask.GetRecurrencePattern()

        oPattern.PatternStartDate = DateTime.Parse(dtTmPckStart.Text)
        oPattern.PatternEndDate = DateTime.Parse(dtTimePickEnd.Text)
        If rbDaily.Checked Then

            oPattern.RecurrenceType = Outlook.OlRecurrenceType.olRecursDaily
        End If

        If rbWeekly.Checked Then
            If Not (ckSunday.Checked Or ckMonday.Checked Or ckTuesday.Checked Or ckWednesday.Checked Or ckThursday.Checked Or ckFriday.Checked Or ckSaturday.Checked) Then
                MessageBox.Show("At least one day of the week must be checked")
                bValidated = False
                Exit Sub
            End If

            If bValidated Then
                oPattern.RecurrenceType = Outlook.OlRecurrenceType.olRecursWeekly
                If IsNumeric(Trim(txtInterval.Text)) Then
                    iInterval = CInt(Trim(txtInterval.Text))
                    oPattern.Interval = iInterval
                End If
                'SMTWTFS

                If ckSunday.Checked Then
                    iTotal = iTotal + iMultSun
                End If

                If ckMonday.Checked Then
                    iTotal = iTotal + iMultMon
                End If

                If ckTuesday.Checked Then
                    iTotal = iTotal + iMultTue
                End If

                If ckWednesday.Checked Then
                    iTotal = iTotal + iMultWed
                End If

                If ckThursday.Checked Then
                    iTotal = iTotal + iMultThu
                End If

                If ckFriday.Checked Then
                    iTotal = iTotal + iMultFri
                End If

                If ckSaturday.Checked Then
                    iTotal = iTotal + iMultSat
                End If

                CalcDOWMask(oPattern, iTotal)

                'End Select
                'recurrencePattern.DayOfWeekMask = Outlook.OlDaysOfWeek.olTuesday | Outlook.OlDaysOfWeek.olFriday

            End If
        End If

        If rbMonthly.Checked Then
            oPattern.RecurrenceType = Outlook.OlRecurrenceType.olRecursMonthly
        End If

        If rbYearly.Checked Then
            oPattern.RecurrenceType = Outlook.OlRecurrenceType.olRecursYearly
        End If

        If bValidated Then
            oTask.ReminderTime = DateTime.Parse(cmbTime.SelectedItem)
        End If

        Me.Close()
    End Sub


    Private Sub FormAddRecurrence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtCurdow As New DayOfWeek

        oTask = GlobalVariables.CurrentTasks(1)
        dtCurdow = Now.DayOfWeek

        If dtCurdow = DayOfWeek.Sunday Then
            ckSunday.Checked = True
        End If
        If dtCurdow = DayOfWeek.Monday Then
            ckMonday.Checked = True
        End If
        If dtCurdow = DayOfWeek.Tuesday Then
            ckTuesday.Checked = True
        End If
        If dtCurdow = DayOfWeek.Wednesday Then
            ckWednesday.Checked = True
        End If
        If dtCurdow = DayOfWeek.Thursday Then
            ckThursday.Checked = True
        End If
        If dtCurdow = DayOfWeek.Friday Then
            ckFriday.Checked = True
        End If
        If dtCurdow = DayOfWeek.Saturday Then
            ckSaturday.Checked = True
        End If

        rbWeekly.Checked = True
        rbEndBy.Checked = True
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

        cmbTime.SelectedIndex = 0
        dtTimePickEnd.Text = Now.AddMonths(6).ToString()
    End Sub

    Private Sub rbWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles rbWeekly.CheckedChanged
        If rbWeekly.Checked Then
            txtInterval.Enabled = True
            ckSunday.Enabled = True
            ckMonday.Enabled = True
            ckTuesday.Enabled = True
            ckWednesday.Enabled = True
            ckThursday.Enabled = True
            ckFriday.Enabled = True
            ckSaturday.Enabled = True
        Else
            txtInterval.Enabled = False
            ckSunday.Enabled = False
            ckMonday.Enabled = False
            ckTuesday.Enabled = False
            ckWednesday.Enabled = False
            ckThursday.Enabled = False
            ckFriday.Enabled = False
            ckSaturday.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        oNS = Nothing
        oTask = Nothing

        Me.Close()
    End Sub
End Class