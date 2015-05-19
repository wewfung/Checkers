<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class help
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(102, 232)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(100, 23)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Welcome to Checkers!", "", "GOAL:", "To take all or your opponents pieces", "", "HOW TO PLAY:", "", "Moving:", "The player who's turn it is will choose one of their own ", "pieces to move diagonally (towards opposite end of", "board) to an open black square. Turn ends and it is the", "opponent's turn to move", "", "Taking:", "Taking a piece occurs when it is your turn and a piece", "of the opposite color is in one of the boxes you would", "normally move to. Your piece can then ""jump over""", "that piece and remove it from the game.", "After jumping, if there are still pieces that can be taken, ", "jump again to take that piece.", "", "King:", "When a piece reaches the last row of boxes of the ", "opposite side, that piece becomes a king and can ", "now move up of down, as well as take pieces", "above and below them.", "", "Other:", "Players are given 60 seconds to perform their turn, ", "they will forfeit if that 60 seconds runs out", "", "You must take a piece when you can"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(287, 186)
        Me.ListBox1.TabIndex = 4
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(8, 5)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(166, 24)
        Me.lbltitle.TabIndex = 3
        Me.lbltitle.Text = "Instructions/Help"
        '
        'help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 262)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "help"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbltitle As System.Windows.Forms.Label
End Class
