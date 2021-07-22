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
        Me.HealthBar = New System.Windows.Forms.ProgressBar()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Reward = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayScore = New System.Windows.Forms.Label()
        Me.Ticker = New System.Windows.Forms.Timer(Me.components)
        Me.GameOverLabel = New System.Windows.Forms.Label()
        Me.EndScoreLabel = New System.Windows.Forms.Label()
        Me.PlayAgain = New System.Windows.Forms.Button()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HealthBar
        '
        Me.HealthBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HealthBar.Enabled = False
        Me.HealthBar.ForeColor = System.Drawing.Color.Red
        Me.HealthBar.Location = New System.Drawing.Point(12, 12)
        Me.HealthBar.Name = "HealthBar"
        Me.HealthBar.Size = New System.Drawing.Size(228, 23)
        Me.HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.HealthBar.TabIndex = 0
        Me.HealthBar.Value = 100
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = CType(resources.GetObject("Player.Image"), System.Drawing.Image)
        Me.Player.Location = New System.Drawing.Point(528, 263)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(86, 85)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 1
        Me.Player.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Transparent
        Me.Enemy1.Image = CType(resources.GetObject("Enemy1.Image"), System.Drawing.Image)
        Me.Enemy1.Location = New System.Drawing.Point(1023, 26)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(86, 85)
        Me.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy1.TabIndex = 2
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Transparent
        Me.Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), System.Drawing.Image)
        Me.Enemy2.Location = New System.Drawing.Point(43, 476)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(86, 85)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy2.TabIndex = 3
        Me.Enemy2.TabStop = False
        '
        'Reward
        '
        Me.Reward.BackColor = System.Drawing.Color.Transparent
        Me.Reward.Image = CType(resources.GetObject("Reward.Image"), System.Drawing.Image)
        Me.Reward.Location = New System.Drawing.Point(943, 436)
        Me.Reward.Name = "Reward"
        Me.Reward.Size = New System.Drawing.Size(69, 79)
        Me.Reward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Reward.TabIndex = 4
        Me.Reward.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Settled"
        '
        'DisplayScore
        '
        Me.DisplayScore.AutoSize = True
        Me.DisplayScore.BackColor = System.Drawing.Color.Transparent
        Me.DisplayScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayScore.ForeColor = System.Drawing.Color.White
        Me.DisplayScore.Location = New System.Drawing.Point(12, 63)
        Me.DisplayScore.Name = "DisplayScore"
        Me.DisplayScore.Size = New System.Drawing.Size(32, 32)
        Me.DisplayScore.TabIndex = 6
        Me.DisplayScore.Text = "0"
        '
        'Ticker
        '
        Me.Ticker.Enabled = True
        Me.Ticker.Interval = 10
        '
        'GameOverLabel
        '
        Me.GameOverLabel.AutoSize = True
        Me.GameOverLabel.BackColor = System.Drawing.Color.Transparent
        Me.GameOverLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverLabel.ForeColor = System.Drawing.Color.White
        Me.GameOverLabel.Location = New System.Drawing.Point(457, 368)
        Me.GameOverLabel.Name = "GameOverLabel"
        Me.GameOverLabel.Size = New System.Drawing.Size(235, 46)
        Me.GameOverLabel.TabIndex = 7
        Me.GameOverLabel.Text = "Game Over!"
        Me.GameOverLabel.Visible = False
        '
        'EndScoreLabel
        '
        Me.EndScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EndScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.EndScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndScoreLabel.ForeColor = System.Drawing.Color.White
        Me.EndScoreLabel.Location = New System.Drawing.Point(468, 414)
        Me.EndScoreLabel.Name = "EndScoreLabel"
        Me.EndScoreLabel.Size = New System.Drawing.Size(200, 50)
        Me.EndScoreLabel.TabIndex = 8
        Me.EndScoreLabel.Text = "Score: 0"
        Me.EndScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EndScoreLabel.Visible = False
        '
        'PlayAgain
        '
        Me.PlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.Location = New System.Drawing.Point(493, 475)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(157, 40)
        Me.PlayAgain.TabIndex = 9
        Me.PlayAgain.Text = "Play Again"
        Me.PlayAgain.UseVisualStyleBackColor = True
        Me.PlayAgain.Visible = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1142, 589)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.EndScoreLabel)
        Me.Controls.Add(Me.GameOverLabel)
        Me.Controls.Add(Me.DisplayScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Reward)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.HealthBar)
        Me.Name = "Game"
        Me.Text = "United Kingdom Simulator"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HealthBar As ProgressBar
    Friend WithEvents Player As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Reward As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DisplayScore As Label
    Friend WithEvents Ticker As Timer
    Friend WithEvents GameOverLabel As Label
    Friend WithEvents EndScoreLabel As Label
    Friend WithEvents PlayAgain As Button
End Class
