Public Class Game
    'an easy way to increase or decrease the
    'speed of the player and enemies
    Dim PlayerSpeed As Integer = 15
    Dim EnemySpeed As Integer = 2
    Dim PlayerSpeedIncreased As Boolean = False
    Dim PlayerSpeedUpdate As Date

    'the current button/s being pressed
    Dim UpPressed As Boolean
    Dim DownPressed As Boolean
    Dim LeftPressed As Boolean
    Dim RightPressed As Boolean

    'the players current stats
    'including lives and score
    Dim TotalHealth As Integer = 3
    Dim CurrentHealth As Integer = 3
    Dim Score As Integer = 0
    Dim CountdownRemaining As Integer = 30
    Dim Highscore As Integer = 0

    'create variables to store default pos
    Dim InitPlayerTop As Integer
    Dim InitPlayerLeft As Integer
    Dim InitEnemy1Top As Integer
    Dim InitEnemy1Left As Integer
    Dim InitEnemy2Top As Integer
    Dim InitEnemy2Left As Integer
    Dim InitOilTop As Integer
    Dim InitOilLeft As Integer
    Dim InitBoostTop As Integer
    Dim InitBoostLeft As Integer

    'when the form has loaded 
    Private Sub Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        'move the boost object out of the way
        Boost.Top = -100
        Boost.Left = -100

        'store the default positions
        InitPlayerTop = Player.Top
        InitPlayerLeft = Player.Left
        InitEnemy1Top = Enemy1.Top
        InitEnemy1Left = Enemy1.Left
        InitEnemy2Top = Enemy2.Top
        InitEnemy2Left = Enemy2.Left
        InitOilTop = Oil.Top
        InitOilLeft = Oil.Left
        InitBoostTop = Boost.Top
        InitBoostLeft = Boost.Left
    End Sub

    'when a key is pressed down, store True
    'to the var defining if it is being pressed
    Private Sub BaseKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            UpPressed = True
        ElseIf e.KeyCode = Keys.Down Then
            DownPressed = True
        ElseIf e.KeyCode = Keys.Left Then
            LeftPressed = True
        ElseIf e.KeyCode = Keys.Right Then
            RightPressed = True
        End If
    End Sub

    'when a key has stopped being pressed, store
    'False to the var defining if it is being
    'pressed
    Private Sub BaseKeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Up Then
            UpPressed = False
        ElseIf e.KeyCode = Keys.Down Then
            DownPressed = False
        ElseIf e.KeyCode = Keys.Left Then
            LeftPressed = False
        ElseIf e.KeyCode = Keys.Right Then
            RightPressed = False
        End If
    End Sub

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles Ticker.Tick
        'if the up key is being pressed,
        'move player up
        If UpPressed = True Then
            Player.Top -= PlayerSpeed
            InfiniteBorder()
        End If

        'if the down key is being pressed,
        'move player down
        If DownPressed = True Then
            Player.Top += PlayerSpeed
            InfiniteBorder()
        End If

        'if the left key is being pressed,
        'move player left
        If LeftPressed = True Then
            Player.Left -= PlayerSpeed
            InfiniteBorder()
        End If

        'if the up key is being pressed,
        'move player left
        If RightPressed = True Then
            Player.Left += PlayerSpeed
            InfiniteBorder()
        End If

        'check if the player picks up the oil
        If Collision(Player, Oil) = True Then
            Oil.Top = Int(Rnd() * Me.Height - Oil.Height)
            Oil.Left = Int(Rnd() * Me.Width - Oil.Width)

            'increase the score by one
            Score += 1
            CurrentScore.Text = Score
            'increase the enemies speed
            EnemySpeed += 0.5

            'reset the countdown
            CountdownRemaining = 30
            CurrentCountdown.Text = "30s"
        End If

        'make the enemy chase the player
        Chase(Player, Enemy1)
        Chase(Player, Enemy2)

        'when the enemy attacks the player remove
        'a part of their health, if the has no
        'health remaining end the game
        If (Collision(Player, Enemy1) = True) Or (Collision(Player, Enemy2) = True) Then
            LoseHealth()
        End If

        'if the player has picked up a boost
        If Collision(Player, Boost) Then
            'move the boost off screen
            Boost.Visible = False
            Boost.Top = -100
            Boost.Left = -100

            'increase player spped for five seconds
            PlayerSpeed *= 2
            PlayerSpeedIncreased = True
            PlayerSpeedUpdate = DateAdd("s", 5, Date.Now)
        End If

        'if the 5 seconds for the boost
        'has passed, decrease player speed
        If (PlayerSpeedIncreased = True) And (Date.Now > PlayerSpeedUpdate) Then
            PlayerSpeedIncreased = False
            PlayerSpeed /= 2
        End If
    End Sub

    'ensure the player gets a reward every 30 seconds
    'if they dont they will lose health
    'if they do reset the countdown
    Private Sub CountdownTick(sender As Object, e As EventArgs) Handles Countdown.Tick
        If CountdownRemaining > 1 Then
            'decrease countdown every second
            CountdownRemaining -= 1
            CurrentCountdown.Text = CountdownRemaining & "s"
        Else
            'if countdown reaches 0, lose
            'health and reset countdown
            LoseHealth()
            CountdownRemaining = 30
            CurrentCountdown.Text = "30s"
        End If
    End Sub

    'every 25 seconds, 'spawn' the boost
    'power up in a random spot
    Private Sub BoosterTick(sender As Object, e As EventArgs) Handles Booster.Tick
        Boost.Top = Int(Rnd() * Me.Height - Boost.Height)
        Boost.Left = Int(Rnd() * Me.Width - Boost.Width)
        Boost.Visible = True
    End Sub

    'check if two objects intersect
    Private Function Collision(Object1 As Object, Object2 As Object) As Boolean
        If Object1.Bounds.IntersectsWith(Object2.Bounds) Then
            Return True
        End If
        Return False
    End Function

    Private Function Chase(ByRef Player As Object, ByRef Enemy As Object) As Boolean
        'if the player is left or right of
        'the enemy, then move the enemy
        'towards the player
        If Player.Left < Enemy.Left Then
            Enemy.Left -= EnemySpeed
        End If
        If Player.Left > Enemy.Left Then
            Enemy.Left += EnemySpeed
        End If

        'if the player is up or down of
        'the enemy, then move the enemy
        'towards the player
        If Player.Top < Enemy.Top Then
            Enemy.Top -= EnemySpeed
        End If
        If Player.Top > Enemy.Top Then
            Enemy.Top += EnemySpeed
        End If

        Return True
    End Function

    'a function to remove health from the player
    Private Function LoseHealth() As Boolean
        'decrease the health by 1 and
        'set a new value for the healthbar
        CurrentHealth -= 1
        Dim NewHealthBarValue As Integer = 100 / TotalHealth * CurrentHealth
        If NewHealthBarValue < 0 Then
            NewHealthBarValue = 0
        End If
        HealthBar.Value = 100 / TotalHealth * CurrentHealth

        'if health is 0 then end the game
        If CurrentHealth = 0 Then
            EndGame()
        End If

        ResetObjects(False, False)

        Return True
    End Function

    'handles teleport the player from one
    'side of the window to the other
    Private Function InfiniteBorder() As Boolean
        Dim WindowWidth As Integer = Me.Width
        Dim WindowHeight As Integer = Me.Height - Player.Height

        'if the player reaches the left or right border
        'teleport them to the other side
        If Player.Left > WindowWidth Then
            Player.Left = 0
        ElseIf Player.Left < 0 Then
            Player.Left = WindowWidth
        End If

        'if the player reaches the top or bottom border
        'teleport them to the other side
        If Player.Top > WindowHeight Then
            Player.Top = 0
        ElseIf Player.Top < 0 Then
            Player.Top = WindowHeight
        End If

        Return True
    End Function

    'end the game, clear all health,
    'display the 'game over' labels
    'and stop the timers
    Private Function EndGame() As Boolean
        'set the healthbar to 0%
        CurrentHealth = 0
        HealthBar.Value = 0

        'show the game over ui
        PlayAgain.Visible = True
        GameOver.Visible = True
        EndScore.Visible = True
        EndScore.Text = "Score: " & Score
        EndHighscore.Visible = True

        'if score is a new highscore
        'set it as so and say so
        If Score > Highscore Then
            Highscore = Score
            EndHighscore.Text = "New Highscore!"
        Else
            EndHighscore.Text = "Highscore: " & Highscore
        End If

        'stop the timers
        Ticker.Stop()
        Countdown.Stop()
        Booster.Stop()
        Return True
    End Function

    'reset the positions of all objects
    'to their default
    Private Function ResetObjects(ResetOil As Boolean, ResetPowerUps As Boolean) As Boolean
        Player.Top = InitPlayerTop
        Player.Left = InitPlayerLeft
        Enemy1.Top = InitEnemy1Top
        Enemy1.Left = InitEnemy1Left
        Enemy2.Top = InitEnemy2Top
        Enemy2.Left = InitEnemy2Left

        If ResetOil = True Then
            Oil.Top = InitOilTop
            Oil.Left = InitOilLeft
        End If

        If ResetPowerUps = True Then
            Boost.Visible = False
            Boost.Top = InitBoostTop
            Boost.Left = InitBoostLeft
        End If

        Return True
    End Function

    Private Function Reset() As Boolean
        'reset the score, health and speed
        Score = 0
        CurrentScore.Text = 0
        CurrentHealth = TotalHealth
        HealthBar.Value = 100
        EnemySpeed = 2

        'move objects to init pos
        ResetObjects(True, True)

        'hide the game over screen
        PlayAgain.Visible = False
        GameOver.Visible = False
        EndScore.Visible = False
        EndHighscore.Visible = False

        'restart the timers
        Ticker.Start()
        CountdownRemaining = 30
        CurrentCountdown.Text = "30s"
        Countdown.Start()
        Booster.Start()

        Return True
    End Function

    'reset the form when the player
    'chooses to play again
    Private Sub ClickPlayAgain(sender As Object, e As EventArgs) Handles PlayAgain.Click
        Reset()
    End Sub
End Class
