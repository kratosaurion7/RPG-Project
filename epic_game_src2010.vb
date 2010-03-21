Public Class SimplifiedForm

    Private Basicroad As Array = _
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 3, 2, 2, 2, 2, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0}

    Private SpriteMap As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Dim theOneMatrix(15, 15) As PictureBox

    Dim tileSize As Integer = 32

    Dim heroPos_X As Integer = 7
    Dim heroPos_Y As Integer = 2


    Private Sub fillMatrix(ByVal Matrix(,) As PictureBox, ByVal tilesMap As Array, ByVal spritesMap As Array)
        Dim iCounter As Integer
        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
				Matrix(LIG, COL) = New PictureBox
                Select Case tilesMap.GetValue(iCounter)
                    Case 0
                        Matrix(LIG, COL).BackgroundImage = My.Resources.GrassTile2 
                    Case 1
                        Matrix(LIG, COL).BackgroundImage = My.Resources.Up_Down_Road
                    Case 2
                        Matrix(LIG, COL).BackgroundImage = My.Resources.left_right_Road
                    Case 3
                        Matrix(LIG, COL).BackgroundImage = My.Resources.Crossroad_Road
                End Select

                Select Case spritesMap.GetValue(iCounter)
                    Case 0
                    Case 1
                        Matrix(LIG, COL).Image = My.Resources.Megaman
                        Matrix(LIG, COL).BringToFront()
                    Case 2
                    Case 3
                    Case 4
                    Case 5
                        Matrix(LIG, COL).Image = My.Resources.Link
                End Select

                iCounter += 1
            Next
        Next


    End Sub

    Private Sub showMatrix(ByVal Matrix(,) As PictureBox)
        Dim POS_X, POS_Y As Integer

        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(LIG, COL).Location = New Point(POS_X, POS_Y)
                Matrix(LIG, COL).Size = New Size(tileSize, tileSize)
                Me.Controls.Add(Matrix(LIG, COL))

                POS_X += 32
            Next
            POS_X = 0
            POS_Y += 32
        Next

    End Sub

    Private Sub addHero(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        Matrix(LOC_X, LOC_Y).Image = My.Resources.Link
        Matrix(LOC_X, LOC_Y).BringToFront()

    End Sub

    Private Sub moveUP(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_Y > 0 Then
            If Matrix(LOC_X, LOC_Y - 1).Image Is Nothing Then
                Matrix(LOC_X, LOC_Y - 1).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_Y -= 1
            End If
        End If
    End Sub
    Private Sub moveDOWN(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If loc_Y < 15 Then
            If Matrix(LOC_X, LOC_Y + 1).Image Is Nothing Then
                Matrix(LOC_X, LOC_Y + 1).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_Y += 1
            End If
        End If
    End Sub
    Private Sub moveLEFT(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_X > 0 Then
            If Matrix(LOC_X - 1, LOC_Y).Image Is Nothing Then
                Matrix(LOC_X - 1, LOC_Y).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_X -= 1
            End If

        End If
    End Sub
    Private Sub moveRIGHT(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_X < 15 Then
            If Matrix(LOC_X + 1, LOC_Y).Image Is Nothing Then
                Matrix(LOC_X + 1, LOC_Y).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_X += 1
            End If
        End If
    End Sub

    Private Sub SimplifiedForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        '######## Test 2 - One Matrix ########
        fillMatrix(theOneMatrix, Basicroad, SpriteMap)
        showMatrix(theOneMatrix)
        addHero(theOneMatrix, heroPos_X, heroPos_Y)


    End Sub

    Public Sub SimplifiedForm_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Up
                moveUP(theOneMatrix, heroPos_X, heroPos_Y)
            Case Keys.Down
                moveDOWN(theOneMatrix, heroPos_X, heroPos_Y)
            Case Keys.Left
                moveLEFT(theOneMatrix, heroPos_X, heroPos_Y)
            Case Keys.Right
                moveRIGHT(theOneMatrix, heroPos_X, heroPos_Y)
            Case Keys.Escape
                Application.Exit()


        End Select
    End Sub
End Class