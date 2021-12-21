Public Class SaturnBackground

    Private Sub SaturnBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formLogin As New FormLogin
        GlobalVariables.oFrmBackground = Me
        formLogin.TopLevel = True
        'formLogin.Parent = Me
        formLogin.ShowDialog()
    End Sub

    Private Sub SaturnBackground_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class