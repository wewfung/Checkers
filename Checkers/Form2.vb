Public Class setup
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'puts defualt text in textboxes
        txtname1.Text = "Player1"
        txtname2.Text = "Player2"
    End Sub

    Private Sub txtname1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname1.TextChanged
        'makes the name chosen for player1 the same throughout the game
        radplayer1.Text = txtname1.Text

        If txtname1.Text = "" Then
            radplayer1.Text = "Player1"
        End If
    End Sub

    Private Sub txtname2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname2.TextChanged
        'makes the name chosen for player2 the same throughout the game
        radplayer2.Text = txtname2.Text

        If txtname2.Text = "" Then
            radplayer2.Text = "Player2"
        End If
    End Sub

    Private Sub btnrandplayer_Click(sender As System.Object, e As System.EventArgs) Handles btnrandplayer.Click
        'randomly determines which player to have the first turn
        Dim r As Random = New Random(Now.Millisecond)

        Dim randomnumb As Integer = 0

        randomnumb = r.Next(0, 2)

        If randomnumb = 1 Then
            radplayer1.Checked = True
        Else
            radplayer2.Checked = True
        End If

        radplayer1.Enabled = False
        radplayer2.Enabled = False
        btnrandplayer.Enabled = False

        'allows players to continue 
        btnplay.Enabled = True
    End Sub

    Private Sub btnbegin_Click(sender As System.Object, e As System.EventArgs) Handles btnplay.Click
        'brings players to game form
        Me.Visible = False
        game.Visible = True

        'starts game with the person chosen to first
        If radplayer1.Checked = True Then
            game.lblplayerturn.Text = txtname1.Text
            game.lblvarturn.Text = -1
        Else
            game.lblplayerturn.Text = txtname2.Text
            game.lblvarturn.Text = 1
        End If

        game.Timer1.Enabled = True
        game.Timer2.Enabled = True
    End Sub

    Private Sub radplayer1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radplayer1.CheckedChanged, radplayer2.CheckedChanged
        'players can only proceed if a person to go first has been decided
        btnplay.Enabled = True
    End Sub

End Class