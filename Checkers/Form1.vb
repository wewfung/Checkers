Public Class game
    Dim box() As PictureBox = {New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox}
    Dim red() As PictureBox = {New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox}
    Dim grey() As PictureBox = {New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox}
    Dim takengrey() As PictureBox = {New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox}
    Dim takenred() As PictureBox = {New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox, New PictureBox}

    Dim pieceselected As PictureBox
    Dim pieceselected2 As PictureBox

    'determines if piece taken is a grey of red piece
    Dim deadpiece As Integer = 0

    'keeps track of pieces taken of each color
    Dim inttakengrey As Integer = 0
    Dim inttakenred As Integer = 0

    'used to determine if a piece can be taken
    Dim takepiece As Boolean = False
    Dim checkgrey As Boolean = False
    Dim checkred As Boolean = False
    Dim checkpiece As Boolean = False
    Dim checkbox As Boolean = False

    'used for determining the location of the box to highlight or piece to take
    Dim piecelocation As Integer = 0

    'determines whether one will need to take a piece
    Dim forcetake As Boolean = False

    'keeps the location of the piece before jumping
    Dim oldlocationx As Integer = 0
    Dim oldlocationy As Integer = 0

    Dim intturn As Integer = 0

    Dim timetext As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        box(0) = box1
        box(1) = box2
        box(2) = box3
        box(3) = box4
        box(4) = box5
        box(5) = box6
        box(6) = box7
        box(7) = box8
        box(8) = box9
        box(9) = box10
        box(10) = box11
        box(11) = box12
        box(12) = box13
        box(13) = box14
        box(14) = box15
        box(15) = box16
        box(16) = box17
        box(17) = box18
        box(18) = box19
        box(19) = box20
        box(20) = box21
        box(21) = box22
        box(22) = box23
        box(23) = box24
        box(24) = box25
        box(25) = box26
        box(26) = box27
        box(27) = box28
        box(28) = box29
        box(29) = box30
        box(30) = box31
        box(31) = box32

        red(0) = red1
        red(1) = red2
        red(2) = red3
        red(3) = red4
        red(4) = red5
        red(5) = red6
        red(6) = red7
        red(7) = red8
        red(8) = red9
        red(9) = red10
        red(10) = red11
        red(11) = red12

        grey(0) = grey1
        grey(1) = grey2
        grey(2) = grey3
        grey(3) = grey4
        grey(4) = grey5
        grey(5) = grey6
        grey(6) = grey7
        grey(7) = grey8
        grey(8) = grey9
        grey(9) = grey10
        grey(10) = grey11
        grey(11) = grey12

        takenred(0) = deadred1
        takenred(1) = deadred2
        takenred(2) = deadred3
        takenred(3) = deadred4
        takenred(4) = deadred5
        takenred(5) = deadred6
        takenred(6) = deadred7
        takenred(7) = deadred8
        takenred(8) = deadred9
        takenred(9) = deadred10
        takenred(10) = deadred11
        takenred(11) = deadred12

        takengrey(0) = deadgrey1
        takengrey(1) = deadgrey2
        takengrey(2) = deadgrey3
        takengrey(3) = deadgrey4
        takengrey(4) = deadgrey5
        takengrey(5) = deadgrey6
        takengrey(6) = deadgrey7
        takengrey(7) = deadgrey8
        takengrey(8) = deadgrey9
        takengrey(9) = deadgrey10
        takengrey(10) = deadgrey11
        takengrey(11) = deadgrey12

    End Sub

    Sub reset()

        'resets variables
        inttakengrey = 0
        inttakenred = 0
        deadpiece = 0

        takepiece = False
        checkgrey = False
        checkred = False
        checkpiece = False
        checkbox = False

        piecelocation = 0
        forcetake = False

        oldlocationx = 0
        oldlocationy = 0

        boardblack()
        deselect()

        'resets captured total
        lblintcaptured1.Text = 0
        lblintcaptured2.Text = 0

        'resets board to original condition
        For z = 0 To 11
            takengrey(z).Visible = False
            takenred(z).Visible = False

            grey(z).Image = greymain.Image
            red(z).Image = redmain.Image

            grey(z).Tag = 0
            red(z).Tag = 0

            grey(z).Location = box(z).Location


            red(z).Location = box(z + 20).Location

        Next

        If setup.radplayer1.Checked = True Then
            lblvarturn.text = -1
        Else
            lblvarturn.text = 1
        End If

        'resets timer
        lbltime.Text = 60
        lblgamemin.Text = 20
        timetext = 0
        lblgamesec.Text = " : 0" & timetext

        Timer1.Enabled = False
        Timer1.Enabled = True

        Timer2.Enabled = False
        Timer2.Enabled = True

    End Sub

    Sub checkwin()

        'checks for if either color no longer has any pieces
        If inttakengrey = 12 Then
            MessageBox.Show(setup.txtname1.Text + " no longer has any pieces so " + setup.txtname2.Text + " wins!", "Game Over", MessageBoxButtons.OK)
            reset()
        End If

        If inttakenred = 12 Then
            MessageBox.Show(setup.txtname2.Text + " no longer has any pieces so " + setup.txtname1.Text + " wins!", "Game Over", MessageBoxButtons.OK)
            reset()
        End If

    End Sub

    Sub checkking()

        'checks for if a piece has reached the opposite end of board to become a king
        For z = 0 To 3
            For y = 0 To 11
                If red(y).Location = box(z).Location Then
                    red(y).Image = redkingmain.Image
                    red(y).Tag = 1
                End If
            Next
        Next

        For z = 29 To 31
            For y = 0 To 11
                If grey(y).Location = box(z).Location Then
                    grey(y).Image = greykingmain.Image
                    grey(y).Tag = 1
                End If
            Next
        Next
    End Sub

    Sub boardblack()

        'unhighlights all boxes
        For z = 0 To 31
            box(z).BackColor = Color.Black
        Next
    End Sub

    Sub checkjumpred()

        deadpiece = 0
        piecelocation = 0
        oldlocationx = 0
        oldlocationy = 0
        takepiece = False

        For y = 0 To 11

            checkbox = False
            checkgrey = False
            checkred = False
            checkpiece = False

            'checks for if a grey piece can be taken
            If grey(y).Location.Y = pieceselected.Location.Y - 40 Then

                If grey(y).Location.X = pieceselected.Location.X + 40 Or grey(y).Location.X = pieceselected.Location.X - 40 Then
                    piecelocation = (pieceselected.Location.X - grey(y).Location.X) * 2

                    'checks for if behing the grey piece there are no obstructions
                    For v = 0 To 11
                        If grey(v).Location.X = pieceselected.Location.X - piecelocation And grey(v).Location.Y = pieceselected.Location.Y - 80 Then
                            checkgrey = True
                        End If

                        If red(v).Location.X = pieceselected.Location.X - piecelocation And red(v).Location.Y = pieceselected.Location.Y - 80 Then
                            checkred = True
                        End If
                    Next

                    'checks for a space to move to
                    For w = 0 To 31
                        If box(w).Location.X = pieceselected.Location.X - piecelocation And box(w).Location.Y = pieceselected.Location.Y - 80 Then
                            checkbox = True
                        End If
                    Next

                    If checkred = True Or checkgrey = True Then
                        checkpiece = True
                    End If

                    'if a piece can be taken, highlights the correct boxes
                    If checkpiece = False And checkbox = True Then
                        takepiece = True
                        oldlocationx = pieceselected.Location.X
                        oldlocationy = pieceselected.Location.Y
                        deadpiece = 1

                        For q = 0 To 31
                            If box(q).Location.X = pieceselected.Location.X - piecelocation And box(q).Location.Y = pieceselected.Location.Y - 80 Then
                                box(q).BackColor = Color.LightPink
                            End If
                        Next
                    End If
                End If
            End If
        Next
    End Sub

    Sub checkjumpgrey()
        'similar to checkjumpred, but checks for red pieces in the opposite direction

        deadpiece = 0
        piecelocation = 0
        oldlocationx = 0
        oldlocationy = 0
        takepiece = False

        For y = 0 To 11

            checkbox = False
            checkgrey = False
            checkred = False
            checkpiece = False

            If red(y).Location.Y = pieceselected.Location.Y + 40 Then

                If red(y).Location.X = pieceselected.Location.X + 40 Or red(y).Location.X = pieceselected.Location.X - 40 Then
                    piecelocation = (pieceselected.Location.X - red(y).Location.X) * 2

                    For v = 0 To 11
                        If grey(v).Location.X = pieceselected.Location.X - piecelocation And grey(v).Location.Y = pieceselected.Location.Y + 80 Then
                            checkgrey = True
                        End If

                        If red(v).Location.X = pieceselected.Location.X - piecelocation And red(v).Location.Y = pieceselected.Location.Y + 80 Then
                            checkred = True
                        End If
                    Next

                    For w = 0 To 31
                        If box(w).Location.X = pieceselected.Location.X - piecelocation And box(w).Location.Y = pieceselected.Location.Y + 80 Then
                            checkbox = True
                        End If
                    Next

                    If checkred = True Or checkgrey = True Then
                        checkpiece = True
                    End If

                    If checkpiece = False And checkbox = True Then
                        takepiece = True
                        oldlocationx = pieceselected.Location.X
                        oldlocationy = pieceselected.Location.Y
                        deadpiece = 2

                        For q = 0 To 31
                            If box(q).Location.X = pieceselected.Location.X - piecelocation And box(q).Location.Y = pieceselected.Location.Y + 80 Then
                                box(q).BackColor = Color.LightPink
                            End If
                        Next
                    End If
                End If
            End If
        Next
    End Sub

    Sub checkjumpredking()
        'similar to checkjumpred but checks for grey pieces above and below the piece

        checkjumpred()

        For y = 0 To 11

            checkbox = False
            checkgrey = False
            checkred = False
            checkpiece = False

            If grey(y).Location.Y = pieceselected.Location.Y + 40 Then

                If grey(y).Location.X = pieceselected.Location.X + 40 Or grey(y).Location.X = pieceselected.Location.X - 40 Then
                    piecelocation = (pieceselected.Location.X - grey(y).Location.X) * 2

                    For v = 0 To 11
                        If grey(v).Location.X = pieceselected.Location.X - piecelocation And grey(v).Location.Y = pieceselected.Location.Y + 80 Then
                            checkgrey = True
                        End If

                        If red(v).Location.X = pieceselected.Location.X - piecelocation And red(v).Location.Y = pieceselected.Location.Y + 80 Then
                            checkred = True
                        End If
                    Next

                    For w = 0 To 31
                        If box(w).Location.X = pieceselected.Location.X - piecelocation And box(w).Location.Y = pieceselected.Location.Y + 80 Then
                            checkbox = True
                        End If
                    Next

                    If checkred = True Or checkgrey = True Then
                        checkpiece = True
                    End If

                    If checkpiece = False Xor checkbox = False Then
                        takepiece = True
                        deadpiece = 1
                        oldlocationx = pieceselected.Location.X
                        oldlocationy = pieceselected.Location.Y

                        For q = 0 To 31
                            If box(q).Location.X = pieceselected.Location.X - piecelocation And box(q).Location.Y = pieceselected.Location.Y + 80 Then
                                box(q).BackColor = Color.LightPink
                            End If
                        Next
                    End If
                End If
            End If

        Next
    End Sub

    Sub checkjumpgreyking()
        'similar to checkjumpred but checks for red pieces above and below the piece

        checkjumpgrey()

        For y = 0 To 11

            checkbox = False
            checkgrey = False
            checkred = False
            checkpiece = False

            If red(y).Location.Y = pieceselected.Location.Y - 40 Then

                If red(y).Location.X = pieceselected.Location.X + 40 Or red(y).Location.X = pieceselected.Location.X - 40 Then
                    piecelocation = (pieceselected.Location.X - red(y).Location.X) * 2

                    For v = 0 To 11
                        If grey(v).Location.X = pieceselected.Location.X - piecelocation And grey(v).Location.Y = pieceselected.Location.Y - 80 Then
                            checkgrey = True
                        End If

                        If red(v).Location.X = pieceselected.Location.X - piecelocation And red(v).Location.Y = pieceselected.Location.Y - 80 Then
                            checkred = True
                        End If
                    Next

                    For w = 0 To 31
                        If box(w).Location.X = pieceselected.Location.X - piecelocation And box(w).Location.Y = pieceselected.Location.Y - 80 Then
                            checkbox = True
                        End If
                    Next

                    If checkred = True Or checkgrey = True Then
                        checkpiece = True
                    End If

                    If checkpiece = False Xor checkbox = False Then
                        takepiece = True
                        deadpiece = 2
                        oldlocationx = pieceselected.Location.X
                        oldlocationy = pieceselected.Location.Y

                        For q = 0 To 31
                            If box(q).Location.X = pieceselected.Location.X - piecelocation And box(q).Location.Y = pieceselected.Location.Y - 80 Then
                                box(q).BackColor = Color.LightPink
                            End If
                        Next
                    End If
                End If
            End If
        Next
    End Sub

    Sub checkturn()

        If takepiece = False Then
            'resets the timer and changes the turn
            deselect()
            lblvarturn.Text = CInt(lblvarturn.Text) * -1
            lbltime.Text = 60
            Timer1.Enabled = False
            Timer1.Enabled = True

            'changes the person going to the appropriate name
            If lblvarturn.Text = -1 Then
                lblplayerturn.Text = setup.txtname1.Text
            Else
                lblplayerturn.Text = setup.txtname2.Text
            End If

            forcetake = False

            'checks for if a piece can be taken by the person who's turn it will be
            If lblvarturn.Text = -1 Then
                For z = 0 To 11
                    pieceselected = red(z)

                    If red(z).Tag = 0 Then
                        checkjumpred()

                        If takepiece = True Then
                            forcetake = True
                            red(z).Tag = 2
                            red(z).Image = possiblered.Image
                        End If
                    End If

                    If red(z).Tag = 1 Then
                        checkjumpredking()

                        If takepiece = True Then
                            forcetake = True
                            red(z).Tag = 3
                            red(z).Image = possibleredking.Image

                        End If
                    End If
                Next

            End If


            If lblvarturn.Text = 1 Then
                For z = 0 To 11
                    pieceselected = grey(z)

                    If grey(z).Tag = 0 Then
                        checkjumpgrey()

                        If takepiece = True Then
                            forcetake = True
                            grey(z).Tag = 2
                            grey(z).Image = possiblegrey.Image

                        End If
                    End If

                    If grey(z).Tag = 1 Then
                        checkjumpgreyking()

                        If takepiece = True Then
                            forcetake = True
                            grey(z).Tag = 3
                            grey(z).Image = possiblegreyking.Image

                        End If
                    End If
                Next
            End If

            boardblack()

        End If

    End Sub

    Sub deselect()

        'changes the images of the pieces to their "unselected image"
        For z = 0 To 11
            If grey(z).Tag = 0 Then
                grey(z).Image = greymain.Image
            Else
                grey(z).Image = greykingmain.Image
            End If

            If red(z).Tag = 0 Then
                red(z).Image = redmain.Image
            Else
                red(z).Image = redkingmain.Image
            End If
        Next
    End Sub

    Private Sub red1_Click(sender As System.Object, e As System.EventArgs) Handles red1.Click, red9.Click, red8.Click, red7.Click, red6.Click, red5.Click, red4.Click, red3.Click, red2.Click, red12.Click, red11.Click, red10.Click

        If lblvarturn.text = -1 And forcetake = False Then
            pieceselected = sender
            deselect()

            boardblack()

            'checks for if a piece can be taken
            If pieceselected.Tag = 0 Then
                pieceselected.Image = selectedred.Image

                'highlights boxes to move to
                For z = 0 To 31
                    If box(z).Location.Y = pieceselected.Location.Y - 40 Then

                        If box(z).Location.X = pieceselected.Location.X + 40 Or box(z).Location.X = pieceselected.Location.X - 40 Then
                            box(z).BackColor = Color.LightPink
                        End If
                    End If
                Next
            End If


            'highlights boxes for a king piece to move to
            If pieceselected.Tag = 1 Then
                pieceselected.Image = selectedredking.Image

                For z = 0 To 31
                    If box(z).Location.Y = pieceselected.Location.Y + 40 Or box(z).Location.Y = pieceselected.Location.Y - 40 Then

                        If box(z).Location.X = pieceselected.Location.X + 40 Or box(z).Location.X = pieceselected.Location.X - 40 Then
                            box(z).BackColor = Color.LightPink
                        End If
                    End If
                Next
            End If

        End If

        'sets up the taking process for the piece selected if it can take a piece
        If lblvarturn.Text = -1 And forcetake = True Then
            pieceselected = sender

            If pieceselected.Tag = 2 Then
                deselect()

                    For z = 0 To 11
                        If red(z).Tag = 2 Then
                            red(z).Image = possiblered.Image
                        End If

                        If red(z).Tag = 3 Then
                            red(z).Image = possibleredking.Image
                        End If
                    Next
                    pieceselected.Image = selectedred.Image

                    boardblack()
                    checkjumpred()
            End If

            If pieceselected.Tag = 3 Then
                deselect()

                    For z = 0 To 11
                        If red(z).Tag = 2 Then
                            red(z).Image = possiblered.Image
                        End If

                        If red(z).Tag = 3 Then
                            red(z).Image = possibleredking.Image
                        End If
                    Next

                    pieceselected.Image = selectedredking.Image

                    boardblack()
                    checkjumpredking()

            End If
        End If
    End Sub

    Private Sub grey1_Click(sender As System.Object, e As System.EventArgs) Handles grey1.Click, grey9.Click, grey8.Click, grey7.Click, grey6.Click, grey5.Click, grey4.Click, grey3.Click, grey2.Click, grey12.Click, grey11.Click, grey10.Click

        'similar to red click
        If lblvarturn.Text = 1 And forcetake = False Then
            pieceselected = sender
            deselect()

            boardblack()

            If pieceselected.Tag = 0 Then
                pieceselected.Image = selectedgrey.Image

                For z = 0 To 31
                    If box(z).Location.Y = pieceselected.Location.Y + 40 Then

                        If box(z).Location.X = pieceselected.Location.X + 40 Or box(z).Location.X = pieceselected.Location.X - 40 Then
                            box(z).BackColor = Color.LightPink
                        End If
                    End If
                Next
            End If

            If pieceselected.Tag = 1 Then
                pieceselected.Image = selectedgreyking.Image

                For z = 0 To 31
                    If box(z).Location.Y = pieceselected.Location.Y + 40 Or box(z).Location.Y = pieceselected.Location.Y - 40 Then

                        If box(z).Location.X = pieceselected.Location.X + 40 Or box(z).Location.X = pieceselected.Location.X - 40 Then
                            box(z).BackColor = Color.LightPink
                        End If
                    End If
                Next
            End If
        End If

        If lblvarturn.Text = 1 And forcetake = True Then
            pieceselected = sender

            If pieceselected.Tag = 2 Then
                deselect()

                For z = 0 To 11
                    If grey(z).Tag = 2 Then
                        grey(z).Image = possiblegrey.Image
                    End If

                    If grey(z).Tag = 3 Then
                        grey(z).Image = possiblegreyking.Image
                    End If
                Next
                pieceselected.Image = selectedgrey.Image

                boardblack()
                checkjumpgrey()
            End If

            If pieceselected.Tag = 3 Then
                deselect()

                For z = 0 To 11
                    If grey(z).Tag = 2 Then
                        grey(z).Image = possiblegrey.Image
                    End If

                    If grey(z).Tag = 3 Then
                        grey(z).Image = possiblegreyking.Image
                    End If
                Next

                pieceselected.Image = selectedredking.Image

                boardblack()
                checkjumpgreyking()

            End If
        End If

    End Sub

    Private Sub box1_Click(sender As System.Object, e As System.EventArgs) Handles box1.Click, redkingmain.Click, greykingmain.Click, box9.Click, box8.Click, box7.Click, box6.Click, box5.Click, box4.Click, box32.Click, box31.Click, box30.Click, box3.Click, box29.Click, box28.Click, box27.Click, box26.Click, box25.Click, box24.Click, box23.Click, box22.Click, box21.Click, box20.Click, box2.Click, box19.Click, box18.Click, box17.Click, box16.Click, box15.Click, box14.Click, box13.Click, box12.Click, box11.Click, box10.Click
        Dim boxclick As PictureBox = sender

        'moves piece to box position
        If boxclick.BackColor = Color.LightPink And takepiece = False And btnpause.Text = "Pause" Then
            pieceselected.Location = boxclick.Location
            boardblack()
            checkking()

            checkturn()
        End If


        If boxclick.BackColor = Color.LightPink And takepiece = True And btnpause.Text = "Pause" Then
            'resets the tags of those that are not kings
            For z = 0 To 11
                If grey(z).Tag = 3 Then
                    grey(z).Tag = 1
                End If

                If grey(z).Tag = 2 Then
                    grey(z).Tag = 0
                End If

                If red(z).Tag = 3 Then
                    red(z).Tag = 1
                End If

                If red(z).Tag = 2 Then
                    red(z).Tag = 0
                End If
            Next

            'moves piece to box position
            pieceselected.Location = boxclick.Location

            boardblack()
            checkking()

            'locates the piece to be taken
            piecelocation = (pieceselected.Location.X - oldlocationx) / 2
            oldlocationx = oldlocationx + piecelocation

            piecelocation = (pieceselected.Location.Y - oldlocationy) / 2
            oldlocationy = oldlocationy + piecelocation

            'moves appropriate piece off the board
            If lblvarturn.Text = 1 Then
                For z = 0 To 11
                    If red(z).Location.X = oldlocationx And red(z).Location.Y = oldlocationy Then
                        red(z).Location = offboard.Location
                    End If
                Next
            End If

            If lblvarturn.Text = -1 Then
                For z = 0 To 11
                    If grey(z).Location.X = oldlocationx And grey(z).Location.Y = oldlocationy Then
                        grey(z).Location = offboard.Location
                    End If
                Next
            End If


            If deadpiece = 1 Then
                'adds 1 to the captured count and displays the next taken piece image
                takengrey(inttakengrey).Visible = True
                inttakengrey = inttakengrey + 1
                lblintcaptured2.Text = inttakengrey

                'continues to check for if a piece can be taken
                If pieceselected.Tag = 0 Then
                    deselect()
                    pieceselected.Image = selectedred.Image

                    checkjumpred()
                Else
                    deselect()
                    pieceselected.Image = selectedredking.Image

                    checkjumpredking()
                End If
            End If

            If deadpiece = 2 Then
                'adds 1 to the captured count and displays the next taken piece image
                takenred(inttakenred).Visible = True
                inttakenred = inttakenred + 1
                lblintcaptured1.Text = inttakenred

                'continues to check for if a piece can be taken
                If pieceselected.Tag = 0 Then
                    deselect()
                    pieceselected.Image = selectedgrey.Image

                    checkjumpgrey()
                Else
                    deselect()
                    pieceselected.Image = selectedgreyking.Image

                    checkjumpgreyking()
                End If

            End If

            checkturn()
            checkwin()
        End If

    End Sub

    Private Sub btnpause_Click(sender As System.Object, e As System.EventArgs) Handles btnpause.Click

        If btnpause.Text = "Pause" Then
            btnpause.Text = "Continue"
            intturn = lblvarturn.Text
            lblvarturn.Text = 0
            Timer1.Enabled = False
            Timer2.Enabled = False

            btnmainmenu.Enabled = False
            btnsurrender.Enabled = False
            btnreset.Enabled = False
        Else
            btnpause.Text = "Pause"
            lblvarturn.Text = intturn
            Timer1.Enabled = True
            Timer2.Enabled = True

            btnmainmenu.Enabled = True
            btnsurrender.Enabled = True
            btnreset.Enabled = True
        End If
    End Sub

    Private Sub btnsurrender_Click(sender As System.Object, e As System.EventArgs) Handles btnsurrender.Click
        Timer1.Enabled = False
        Timer2.Enabled = False

        'displays correct message if player surrenders
        If lblvarturn.text = 1 Then
            MessageBox.Show(setup.txtname2.Text + " surrenders so " + setup.txtname1.Text + " wins!", "Surrender", MessageBoxButtons.OK)
        End If

        If lblvarturn.text = -1 Then
            MessageBox.Show(setup.txtname1.Text + " surrenders so " + setup.txtname2.Text + " wins!", "Surrender", MessageBoxButtons.OK)
        End If

        reset()
    End Sub

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Private Sub btnmainmenu_Click(sender As System.Object, e As System.EventArgs) Handles btnmainmenu.Click
        'goes back to main menu
        Me.Visible = False
        Main.Visible = True
        reset()

        'resets timer
        lbltime.Text = 60

        lblgamemin.Text = 20
        timetext = 0
        lblgamesec.Text = " : 0" & timetext

        Timer1.Enabled = False
        Timer2.Enabled = False

        'resets setup form
        setup.radplayer1.Checked = False
        setup.radplayer2.Checked = False
        setup.btnplay.Enabled = False
        setup.btnrandplayer.Enabled = True
        setup.radplayer2.Enabled = True
        setup.radplayer1.Enabled = True
        setup.txtname1.Text = "Player1"
        setup.txtname2.Text = "Player2"


    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'decreases time by 1 every second
        lbltime.Text = CInt(lbltime.Text) - 1

        'if time reaches 0, player forfeits
        If lbltime.Text = 0 Then
            If lblvarturn.text = 1 Then
                Timer1.Enabled = False
                MessageBox.Show(setup.txtname2.Text + " fails to move so " + setup.txtname1.Text + " wins!", "Surrender", MessageBoxButtons.OK)
            End If

            If lblvarturn.text = -1 Then
                Timer1.Enabled = False
                MessageBox.Show(setup.txtname1.Text + " fails to move so " + setup.txtname2.Text + " wins!", "Surrender", MessageBoxButtons.OK)
            End If

            reset()

        End If

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        If timetext = 0 Then
            If lblgamemin.Text <> 0 Then
                timetext = 60
                lblgamemin.Text = CInt(lblgamemin.Text) - 1
            Else
                Timer1.Enabled = False
                If inttakengrey < inttakenred Then
                    MessageBox.Show(setup.txtname2.Text + " has more pieces remaining than " + setup.txtname1.Text + "!" & vbNewLine & vbNewLine + setup.txtname2.Text + " wins!", "Game Over", MessageBoxButtons.OK)
                Else
                    MessageBox.Show(setup.txtname1.Text + " has more pieces remaining than " + setup.txtname2.Text + "!" & vbNewLine & vbNewLine + setup.txtname1.Text + " wins!", "Game Over", MessageBoxButtons.OK)
                End If

                reset()
            End If
        End If


        timetext = timetext - 1

        If timetext <= 9 Then
            lblgamesec.Text = " : 0" + CStr(timetext)
        Else
            lblgamesec.Text = " : " + CStr(timetext)
        End If
    End Sub


End Class

