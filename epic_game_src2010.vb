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
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, _
4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, _
0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
3, 2, 0, 2, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 3}

    Dim theOneMatrix(15, 15) As PictureBox

    Dim tileSize As Integer = 32

    Dim heroPos_X As Integer = 7
    Dim heroPos_Y As Integer = 2

    Dim dialogMenu As New clsDialogMenu(Me)

    ''' <summary>
    ''' Scrolls through the matrix using the LIG/COL technique, make a new instance of them and assigns them a picture from the array
    ''' based on a counter that increase by one every interation. This is to make the array position match the position in the matrix.
    ''' It firsts applies the background image, that will be the tile and then the image property that will be the sprite. Gives every
    ''' sprite a tag for identification ## Will need a better detection system than tags ## 
    ''' </summary>
    ''' <param name="Matrix">The matrix of pictureboxes that is used to store the tiles and sprites. Dim'ed as a (15, 15) matrix.</param>
    ''' <param name="tilesMap">The array containing the tiles data.</param>
    ''' <param name="spritesMap">The array containing the sprites data.</param>
    ''' <remarks></remarks>
    Private Sub fillMatrix(ByVal Matrix(,) As PictureBox, ByVal tilesMap As Array, ByVal spritesMap As Array)
        Dim iCounter As Integer
        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0) 'TODO: ASK WTF IS HAPPENING !
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(LIG, COL) = New PictureBox
                Select Case tilesMap.GetValue(iCounter)
                    Case 0
                        Matrix(LIG, COL).BackgroundImage = My.Resources.GrassTile2 'Gets stuck whenever an image is assigned. YArrrr
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
                        Matrix(LIG, COL).Tag = "Megaman"
                        Matrix(LIG, COL).Image = My.Resources.Megaman
                        Matrix(LIG, COL).BringToFront()
                    Case 2
                        Matrix(LIG, COL).Tag = "Bob_Omb"
                        Matrix(LIG, COL).Image = My.Resources.bob_omb
                        Matrix(LIG, COL).BringToFront()
                    Case 3
                        Matrix(LIG, COL).Tag = "Small_Mario"
                        Matrix(LIG, COL).Image = My.Resources.smario
                        Matrix(LIG, COL).BringToFront()
                    Case 4
                        Matrix(LIG, COL).Tag = "Red_Koopa"
                        Matrix(LIG, COL).Image = My.Resources.rkoopa
                        Matrix(LIG, COL).BringToFront()
                    Case 5
                        Matrix(LIG, COL).Tag = "Hero"
                        Matrix(LIG, COL).Image = My.Resources.Link
                End Select

                iCounter += 1
            Next
        Next


    End Sub

    ''' <summary>
    ''' Using PosX and Pos_Y, this will scroll through the matrix using the LIG/COL technique and place the pictureboxes from the 
    ''' matrix. After each iteration Pos_X will add up 32 ( the size of the tiles ) so the location of the next picturebox will be right in place
    ''' . After a column(COL) has been scrolled through X will be reset and Y will have +32. This will make the pointer skip to next line
    ''' and start at the first X.
    ''' </summary>
    ''' <param name="Matrix">The matrix containing the pictureboxes.</param>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' This will spawn the hero at the tile specified by LOC_X and loc_Y by assiging the image of the the Matrix(X, Y) as Link. 
    ''' Will also bring to front so we can see it.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="LOC_X">The Column in which to add the hero</param>
    ''' <param name="LOC_Y">The line in which to add the hero at.</param>
    ''' <remarks></remarks>
    Private Sub addHero(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        Matrix(LOC_X, LOC_Y).Image = My.Resources.Link
        Matrix(LOC_X, LOC_Y).BringToFront()

    End Sub

    ''' <summary>
    ''' This will check if the space directly on top of the hero is free. By checking in the matrix(x, y-1) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="LOC_X"></param>
    ''' <param name="LOC_Y"></param>
    ''' <remarks></remarks>
    Private Sub moveUP(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_Y > 0 Then
            If Matrix(LOC_X, LOC_Y - 1).Image Is Nothing Then
                Matrix(LOC_X, LOC_Y - 1).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_Y -= 1
                HideDialogPanel()

            ElseIf Matrix(LOC_X, LOC_Y - 1).Tag = "Megaman" Then
                EnableDialogPanel("Hi whats up Link !")
            End If
        End If
    End Sub
    ''' <summary>
    ''' This will check if the space directly on down of the hero is free. By checking in the matrix(x, y+1) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="LOC_X"></param>
    ''' <param name="LOC_Y"></param>
    ''' <remarks></remarks>
    Private Sub moveDOWN(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_Y < 15 Then
            If Matrix(LOC_X, LOC_Y + 1).Image Is Nothing Then
                Matrix(LOC_X, LOC_Y + 1).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_Y += 1
                HideDialogPanel()
            ElseIf Matrix(LOC_X, LOC_Y + 1).Tag = "Megaman" Then
                EnableDialogPanel("Hi whats up Link !")

            End If
        End If
    End Sub
    ''' <summary>
    ''' This will check if the space directly on the left of the hero is free. By checking in the matrix(x-1, y) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="LOC_X"></param>
    ''' <param name="LOC_Y"></param>
    ''' <remarks></remarks>
    Private Sub moveLEFT(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_X > 0 Then

            If Matrix(LOC_X - 1, LOC_Y).Image Is Nothing Then
                Matrix(LOC_X - 1, LOC_Y).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_X -= 1

                HideDialogPanel()
                'ElseIf Matrix(LOC_X - 1, LOC_Y).Tag = "Megaman" Then
                '    EnableDialogPanel("Hi whats up Link !")
            End If

            Select Case Matrix(LOC_X - 1, LOC_Y).Tag
                Case "Megaman"
                    EnableDialogPanel("Hi whats up Link !")


            End Select

        End If
    End Sub
    ''' <summary>
    '''  This will check if the space directly on the right of the hero is free. By checking in the matrix(x+1, y) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="LOC_X"></param>
    ''' <param name="LOC_Y"></param>
    ''' <remarks></remarks>
    Private Sub moveRIGHT(ByRef Matrix(,) As PictureBox, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_X < 15 Then
            If Matrix(LOC_X + 1, LOC_Y).Image Is Nothing Then
                Matrix(LOC_X + 1, LOC_Y).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_X += 1
                HideDialogPanel()
            ElseIf Matrix(LOC_X + 1, LOC_Y).Tag = "Megaman" Then
                EnableDialogPanel("Hi, whats up Link !")
            End If
        End If
    End Sub

    ''' <summary>
    ''' That spawns the dialog box and using its mathod, will add the text "Test"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EnableDialogPanel(ByVal text As String)
        dialogMenu.showDialogPanel(text)
    End Sub

    Private Sub HideDialogPanel()
        dialogMenu.hideDialogPanel()
    End Sub

    Private Sub SimplifiedForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        '######## Part 1 - Test ########
        fillMatrix(theOneMatrix, Basicroad, SpriteMap)
        showMatrix(theOneMatrix)
        addHero(theOneMatrix, heroPos_X, heroPos_Y)

        '######## Part 2 - Functionality Test ########

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
            Case Keys.D
                dialogMenu.showDialogPanel("Test")
            Case Keys.Z
                dialogMenu.hideDialogPanel()

        End Select
    End Sub
End Class