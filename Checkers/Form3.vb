Public Class Main

    Private Sub btnplay_Click(sender As System.Object, e As System.EventArgs) Handles btnplay.Click
        'brings players to setup form
        Me.Visible = False
        setup.Visible = True
    End Sub

    Private Sub btnhelp_Click(sender As System.Object, e As System.EventArgs) Handles btnhelp.Click
        'brings players to instructions/help form
        Me.Visible = False
        help.Visible = True
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class