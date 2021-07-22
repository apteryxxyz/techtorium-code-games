Public Class Game
    'define the player and enemy speeds
    Dim PlayerSpeed As Integer = 30
    Dim EnemySpeed As Integer = 10

    'define players score and health
    Dim Score As Integer = 0
    Dim TotalHealth As Integer = 3
    Dim CurrentHealth As Integer = TotalHealth

    'declare varibales which will store
    'all objects starting positions
    Dim InitPlayerTop As Integer
    Dim InitPlayerLeft As Integer

    Dim InitEnemy1Top As Integer
    Dim InitEnemy1Left As Integer
    Dim InitEnemy2Top As Integer
    Dim InitEnemy2Left As Integer

    Dim InitRewardTop As Integer
    Dim InitRewardLeft As Integer

    'declare variables which will be used
    'to tell which arrow keys are being
    'pressed
    Dim UpPressed As Boolean
    Dim DownPressed As Boolean
    Dim LeftPressed As Boolean
    Dim RightPressed As Boolean

    'below are all the events, for
    'example when the page has loaded,
    'when a key is pressed etc

    Private Sub OnLoaded(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads, then it means all
        'the objects have loaded and therefore
        'the init positions can be stored
        InitPlayerTop = Player.Top
        InitPlayerLeft = Player.Left

        InitEnemy1Top = Enemy1.Top
        InitEnemy1Left = Enemy1.Left
        InitEnemy2Top = Enemy2.Top
        InitEnemy2Left = Enemy2.Left

        InitRewardTop = Reward.Top
        InitRewardLeft = Reward.Left
    End Sub

    'when a key is pressed down, store true
    'to the var defining if it is being pressed
    Private Sub OnArrowDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
    'false to the var defining if it is being pressed
    Private Sub OnArrowUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
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

    Private Sub OnTick(sender As Object, e As EventArgs) Handles Ticker.Tick
        'depending on the arrow being pressed,
        'move in the direction
        If UpPressed = True Then
            Player.Top -= PlayerSpeed
            InfiniteBorder()
        End If
        If DownPressed = True Then
            Player.Top += PlayerSpeed
            InfiniteBorder()
        End If
        If LeftPressed = True Then
            Player.Left -= PlayerSpeed
            InfiniteBorder()
        End If
        If RightPressed = True Then
            Player.Left += PlayerSpeed
            InfiniteBorder()
        End If

        'set the enemies to chase the player
        Chase(Player, Enemy1)
        Chase(Player, Enemy2)

        'if the player hits the reward
        'then add to the score
        If Collision(Player, Reward) = True Then
            AddScore(Reward)
        End If

        'if any of the enemies hit the
        'player then remove health
        If (Collision(Player, Enemy1) = True) Or (Collision(Player, Enemy2) = True) Then
            RemoveHealth()
        End If
    End Sub

    'check if two objects intersect
    Private Function Collision(Object1 As Object, Object2 As Object) As Boolean
        If Object1.Bounds.IntersectsWith(Object2.Bounds) Then
            Return True
        End If
        Return False
    End Function

    Private Function Chase(Chasee As Object, Chaser As Object) As Boolean
        'if the player is left or right of
        'the enemy, then move the enemy
        'towards the player
        If Chasee.Left < Chaser.Left Then
            Chaser.Left -= EnemySpeed
        End If
        If Chasee.Left > Chaser.Left Then
            Chaser.Left += EnemySpeed
        End If

        'if the player is up or down of
        'the enemy, then move the enemy
        'towards the player
        If Chasee.Top < Chaser.Top Then
            Chaser.Top -= EnemySpeed
        End If
        If Chasee.Top > Chaser.Top Then
            Chaser.Top += EnemySpeed
        End If

        Return True
    End Function

    'add score to the player and
    'move the reward
    Private Function AddScore(Object1 As Object) As Boolean
        Object1.Top = Int(Rnd() * Me.Height - Object1.Height)
        Object1.Left = Int(Rnd() * Me.Width - Object1.Width)

        Score += 1
        DisplayScore.Text = Score
        EnemySpeed += 0.5
        Return True
    End Function

    'remove health from the player
    Private Function RemoveHealth() As Boolean
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

        'reset the objects positions
        ResetObjects(False)

        Return True
    End Function

    'reset the positions of all objects
    'to their default
    Private Function ResetObjects(ResetReward As Boolean) As Boolean
        Player.Top = InitPlayerTop
        Player.Left = InitPlayerLeft
        Enemy1.Top = InitEnemy1Top
        Enemy1.Left = InitEnemy1Left
        Enemy2.Top = InitEnemy2Top
        Enemy2.Left = InitEnemy2Left

        If ResetReward = True Then
            Reward.Top = InitRewardTop
            Reward.Left = InitRewardLeft
        End If

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

    'reset the game to its original state
    Private Function Reset() As Boolean
        'reset the score, health and speed
        Score = 0
        DisplayScore.Text = 0
        CurrentHealth = TotalHealth
        HealthBar.Value = 100
        EnemySpeed = 2

        'move objects to init pos
        ResetObjects(True)

        'hide the game over screen
        PlayAgain.Visible = False
        GameOverLabel.Visible = False
        EndScoreLabel.Visible = False

        'restart the timer
        Ticker.Start()

        Return True
    End Function

    'end the game, clear all health,
    'display the 'game over' labels
    'and stop the timer
    Private Function EndGame() As Boolean
        'set the healthbar to 0%
        CurrentHealth = 0
        HealthBar.Value = 0

        'show the game over ui
        PlayAgain.Visible = True
        GameOverLabel.Visible = True
        EndScoreLabel.Visible = True
        EndScoreLabel.Text = "Score: " & Score

        'stop the timer
        Ticker.Stop()
        Return True
    End Function

    Private Sub OnPlayAgain(sender As Object, e As EventArgs) Handles PlayAgain.Click
        Reset()
    End Sub
End Class
