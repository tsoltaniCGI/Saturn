Public Class SaturnBackground
    Private Sub SaturnBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formLogin As New FormLogin
        formLogin.TopLevel = True
        'formLogin.Parent = Me
        formLogin.ShowDialog()
    End Sub
End Class