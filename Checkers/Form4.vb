Public Class help

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        'brings players back to main menu
        Me.Visible = False
        Main.Visible = True
    End Sub

    Private Sub help_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class