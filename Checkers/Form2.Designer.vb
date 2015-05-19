<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnrandplayer = New System.Windows.Forms.Button()
        Me.radplayer2 = New System.Windows.Forms.RadioButton()
        Me.radplayer1 = New System.Windows.Forms.RadioButton()
        Me.lblchoose = New System.Windows.Forms.Label()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.lblname2 = New System.Windows.Forms.Label()
        Me.lblname1 = New System.Windows.Forms.Label()
        Me.btnplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnrandplayer
        '
        Me.btnrandplayer.Location = New System.Drawing.Point(142, 106)
        Me.btnrandplayer.Name = "btnrandplayer"
        Me.btnrandplayer.Size = New System.Drawing.Size(75, 23)
        Me.btnrandplayer.TabIndex = 17
        Me.btnrandplayer.Text = "Random"
        Me.btnrandplayer.UseVisualStyleBackColor = True
        '
        'radplayer2
        '
        Me.radplayer2.AutoSize = True
        Me.radplayer2.Location = New System.Drawing.Point(55, 125)
        Me.radplayer2.Name = "radplayer2"
        Me.radplayer2.Size = New System.Drawing.Size(60, 17)
        Me.radplayer2.TabIndex = 15
        Me.radplayer2.Text = "Player2"
        Me.radplayer2.UseVisualStyleBackColor = True
        '
        'radplayer1
        '
        Me.radplayer1.AutoSize = True
        Me.radplayer1.Location = New System.Drawing.Point(55, 102)
        Me.radplayer1.Name = "radplayer1"
        Me.radplayer1.Size = New System.Drawing.Size(60, 17)
        Me.radplayer1.TabIndex = 14
        Me.radplayer1.Text = "Player1"
        Me.radplayer1.UseVisualStyleBackColor = True
        '
        'lblchoose
        '
        Me.lblchoose.AutoSize = True
        Me.lblchoose.Location = New System.Drawing.Point(35, 81)
        Me.lblchoose.Name = "lblchoose"
        Me.lblchoose.Size = New System.Drawing.Size(61, 13)
        Me.lblchoose.TabIndex = 13
        Me.lblchoose.Text = "Who starts:"
        '
        'txtname2
        '
        Me.txtname2.Location = New System.Drawing.Point(144, 38)
        Me.txtname2.MaxLength = 10
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(100, 20)
        Me.txtname2.TabIndex = 12
        '
        'txtname1
        '
        Me.txtname1.Location = New System.Drawing.Point(22, 38)
        Me.txtname1.MaxLength = 10
        Me.txtname1.Name = "txtname1"
        Me.txtname1.Size = New System.Drawing.Size(100, 20)
        Me.txtname1.TabIndex = 11
        '
        'lblname2
        '
        Me.lblname2.AutoSize = True
        Me.lblname2.Location = New System.Drawing.Point(141, 22)
        Me.lblname2.Name = "lblname2"
        Me.lblname2.Size = New System.Drawing.Size(79, 13)
        Me.lblname2.TabIndex = 10
        Me.lblname2.Text = "Player 2 (Grey):"
        '
        'lblname1
        '
        Me.lblname1.AutoSize = True
        Me.lblname1.Location = New System.Drawing.Point(19, 22)
        Me.lblname1.Name = "lblname1"
        Me.lblname1.Size = New System.Drawing.Size(77, 13)
        Me.lblname1.TabIndex = 9
        Me.lblname1.Text = "Player 1 (Red):"
        '
        'btnplay
        '
        Me.btnplay.Enabled = False
        Me.btnplay.Location = New System.Drawing.Point(81, 157)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(97, 35)
        Me.btnplay.TabIndex = 16
        Me.btnplay.Text = "Play"
        Me.btnplay.UseVisualStyleBackColor = True
        '
        'setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 204)
        Me.Controls.Add(Me.btnrandplayer)
        Me.Controls.Add(Me.btnplay)
        Me.Controls.Add(Me.radplayer2)
        Me.Controls.Add(Me.radplayer1)
        Me.Controls.Add(Me.lblchoose)
        Me.Controls.Add(Me.txtname2)
        Me.Controls.Add(Me.txtname1)
        Me.Controls.Add(Me.lblname2)
        Me.Controls.Add(Me.lblname1)
        Me.Name = "setup"
        Me.Text = "Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnrandplayer As System.Windows.Forms.Button
    Friend WithEvents radplayer2 As System.Windows.Forms.RadioButton
    Friend WithEvents radplayer1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblchoose As System.Windows.Forms.Label
    Friend WithEvents txtname2 As System.Windows.Forms.TextBox
    Friend WithEvents txtname1 As System.Windows.Forms.TextBox
    Friend WithEvents lblname2 As System.Windows.Forms.Label
    Friend WithEvents lblname1 As System.Windows.Forms.Label
    Friend WithEvents btnplay As System.Windows.Forms.Button
End Class
