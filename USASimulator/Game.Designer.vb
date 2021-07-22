<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Ticker = New System.Windows.Forms.Timer(Me.components)
        Me.Oil = New System.Windows.Forms.PictureBox()
        Me.HealthBar = New System.Windows.Forms.ProgressBar()
        Me.CurrentScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.PlayAgain = New System.Windows.Forms.Button()
        Me.GameOver = New System.Windows.Forms.Label()
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentCountdown = New System.Windows.Forms.Label()
        Me.EndHighscore = New System.Windows.Forms.Label()
        Me.EndScore = New System.Windows.Forms.Label()
        Me.Boost = New System.Windows.Forms.PictureBox()
        Me.Booster = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Oil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = CType(resources.GetObject("Player.Image"), System.Drawing.Image)
        Me.Player.Location = New System.Drawing.Point(501, 244)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(76, 87)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Ticker
        '
        Me.Ticker.Enabled = True
        Me.Ticker.Interval = 10
        '
        'Oil
        '
        Me.Oil.BackColor = System.Drawing.Color.Transparent
        Me.Oil.Image = CType(resources.GetObject("Oil.Image"), System.Drawing.Image)
        Me.Oil.Location = New System.Drawing.Point(516, 117)
        Me.Oil.Name = "Oil"
        Me.Oil.Size = New System.Drawing.Size(46, 45)
        Me.Oil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Oil.TabIndex = 1
        Me.Oil.TabStop = False
        '
        'HealthBar
        '
        Me.HealthBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HealthBar.ForeColor = System.Drawing.Color.Red
        Me.HealthBar.Location = New System.Drawing.Point(12, 490)
        Me.HealthBar.Name = "HealthBar"
        Me.HealthBar.Size = New System.Drawing.Size(296, 23)
        Me.HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.HealthBar.TabIndex = 2
        Me.HealthBar.Value = 100
        '
        'CurrentScore
        '
        Me.CurrentScore.AutoSize = True
        Me.CurrentScore.BackColor = System.Drawing.Color.Transparent
        Me.CurrentScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentScore.Location = New System.Drawing.Point(12, 455)
        Me.CurrentScore.Name = "CurrentScore"
        Me.CurrentScore.Size = New System.Drawing.Size(32, 32)
        Me.CurrentScore.TabIndex = 3
        Me.CurrentScore.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Score"
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Transparent
        Me.Enemy1.Enabled = False
        Me.Enemy1.Image = CType(resources.GetObject("Enemy1.Image"), System.Drawing.Image)
        Me.Enemy1.Location = New System.Drawing.Point(39, 33)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(82, 80)
        Me.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy1.TabIndex = 5
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Transparent
        Me.Enemy2.Enabled = False
        Me.Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), System.Drawing.Image)
        Me.Enemy2.Location = New System.Drawing.Point(968, 407)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(82, 80)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy2.TabIndex = 6
        Me.Enemy2.TabStop = False
        '
        'PlayAgain
        '
        Me.PlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.Location = New System.Drawing.Point(466, 455)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(142, 43)
        Me.PlayAgain.TabIndex = 7
        Me.PlayAgain.Text = "Play Again"
        Me.PlayAgain.UseVisualStyleBackColor = True
        Me.PlayAgain.Visible = False
        '
        'GameOver
        '
        Me.GameOver.AutoSize = True
        Me.GameOver.BackColor = System.Drawing.Color.Transparent
        Me.GameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOver.Location = New System.Drawing.Point(409, 343)
        Me.GameOver.Name = "GameOver"
        Me.GameOver.Size = New System.Drawing.Size(255, 51)
        Me.GameOver.TabIndex = 8
        Me.GameOver.Text = "Game Over!"
        Me.GameOver.Visible = False
        '
        'Countdown
        '
        Me.Countdown.Enabled = True
        Me.Countdown.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Countdown"
        '
        'CurrentCountdown
        '
        Me.CurrentCountdown.AutoSize = True
        Me.CurrentCountdown.BackColor = System.Drawing.Color.Transparent
        Me.CurrentCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentCountdown.Location = New System.Drawing.Point(159, 455)
        Me.CurrentCountdown.Name = "CurrentCountdown"
        Me.CurrentCountdown.Size = New System.Drawing.Size(64, 32)
        Me.CurrentCountdown.TabIndex = 10
        Me.CurrentCountdown.Text = "30s"
        '
        'EndHighscore
        '
        Me.EndHighscore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EndHighscore.BackColor = System.Drawing.Color.Transparent
        Me.EndHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndHighscore.Location = New System.Drawing.Point(436, 419)
        Me.EndHighscore.Name = "EndHighscore"
        Me.EndHighscore.Size = New System.Drawing.Size(200, 25)
        Me.EndHighscore.TabIndex = 11
        Me.EndHighscore.Text = "Highscore: 0"
        Me.EndHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EndHighscore.Visible = False
        '
        'EndScore
        '
        Me.EndScore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EndScore.BackColor = System.Drawing.Color.Transparent
        Me.EndScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndScore.Location = New System.Drawing.Point(436, 394)
        Me.EndScore.Name = "EndScore"
        Me.EndScore.Size = New System.Drawing.Size(200, 25)
        Me.EndScore.TabIndex = 12
        Me.EndScore.Text = "Score: 0"
        Me.EndScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EndScore.Visible = False
        '
        'Boost
        '
        Me.Boost.BackColor = System.Drawing.Color.Transparent
        Me.Boost.Image = CType(resources.GetObject("Boost.Image"), System.Drawing.Image)
        Me.Boost.Location = New System.Drawing.Point(739, 266)
        Me.Boost.Name = "Boost"
        Me.Boost.Size = New System.Drawing.Size(46, 45)
        Me.Boost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Boost.TabIndex = 13
        Me.Boost.TabStop = False
        Me.Boost.Visible = False
        '
        'Booster
        '
        Me.Booster.Enabled = True
        Me.Booster.Interval = 25000
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1108, 525)
        Me.Controls.Add(Me.EndScore)
        Me.Controls.Add(Me.EndHighscore)
        Me.Controls.Add(Me.CurrentCountdown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GameOver)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CurrentScore)
        Me.Controls.Add(Me.HealthBar)
        Me.Controls.Add(Me.Oil)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Boost)
        Me.KeyPreview = True
        Me.Name = "Game"
        Me.Text = "USA Simulator"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Oil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents Ticker As Timer
    Friend WithEvents Oil As PictureBox
    Friend WithEvents HealthBar As ProgressBar
    Friend WithEvents CurrentScore As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents PlayAgain As Button
    Friend WithEvents GameOver As Label
    Friend WithEvents Countdown As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents CurrentCountdown As Label
    Friend WithEvents EndHighscore As Label
    Friend WithEvents EndScore As Label
    Friend WithEvents Boost As PictureBox
    Friend WithEvents Booster As Timer
End Class
