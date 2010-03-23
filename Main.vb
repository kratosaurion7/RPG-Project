Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.IO
Public Class SimplifiedForm

#Region "I/O Declaration"
    '######## Deletion? ########
    'Private TestArray1 As Array
    'Private TestArray2 As Array
    'Private TestArray3 As Array
    'Dim fStream As Stream = New FileStream("Maps.mp", FileMode.Create, FileAccess.Write, FileShare.None)
    'Dim binFormat As New BinaryFormatter()
    '######## Deletion? ########
#End Region

    Dim theOneMatrix(15, 15) As clsTile
    Dim TileRepo As New clsTerrain

    Dim tileSize As Integer = 32

    Dim heroPos_X As Integer = 7
    Dim heroPos_Y As Integer = 2

    Dim dialogMenu As New clsDialogMenu


    ''' <summary>
    ''' Scrolls through the matrix using the LIG/COL technique, make a new instance of them and assigns them a picture from the array
    ''' based on a counter that increase by one every interation. This is to make the array position match the position in the matrix.
    ''' It firsts applies the background image, that will be the tile and then the image property that will be the sprite. Gives every
    ''' sprite a tag for identification ## Will need a better detection system than tags ## 
    ''' </summary>
    ''' <param name="Matrix">The matrix of clsTilees that is used to store the tiles and sprites. Dim'ed as a (15, 15) matrix.</param>
    ''' <param name="tilesMap">The array containing the tiles data.</param>
    ''' <param name="spritesMap">The array containing the sprites data.</param>
    ''' <remarks></remarks>
    Private Sub fillMatrix(ByVal Matrix(,) As clsTile, ByVal tilesMap As Array, ByVal spritesMap As Array)
        Dim iCounter As Integer
        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(LIG, COL) = New clsTile
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
    ''' Using PosX and Pos_Y, this will scroll through the matrix using the LIG/COL technique and place the clsTilees from the 
    ''' matrix. After each iteration Pos_X will add up 32 ( the size of the tiles ) so the location of the next clsTile will be right in place
    ''' . After a column(COL) has been scrolled through X will be reset and Y will have +32. This will make the pointer skip to next line
    ''' and start at the first X.
    ''' </summary>
    ''' <param name="Matrix">The matrix containing the clsTilees.</param>
    ''' <remarks></remarks>
    Private Sub showMatrix(ByVal Matrix(,) As clsTile)
        Dim POS_X, POS_Y As Integer

        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(LIG, COL).Location = New Point(POS_X, POS_Y)
                Matrix(LIG, COL).Size = New Size(tileSize, tileSize)
                Me.Controls.Add(Matrix(LIG, COL))

                POS_X += 32 'Same as below
            Next
            POS_X = 0
            POS_Y += 32 'TODO: Should make this TilsSize rather than +32, have to add a parameter.
        Next

    End Sub

    ''' <summary>
    ''' This will spawn the hero at the tile specified by LOC_X and loc_Y by assiging the image of the the Matrix(X, Y) as Link. 
    ''' Will also bring to front so we can see it.
    ''' </summary>
    ''' <param name="Matrix">Matrix the hero will be placed inside.</param>
    ''' <param name="LOC_X">The Column in which to add the hero</param>
    ''' <param name="LOC_Y">The line in which to add the hero at.</param>
    ''' <remarks></remarks>
    Private Sub addHero(ByRef Matrix(,) As clsTile, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
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
    Private Sub moveUP(ByRef Matrix(,) As clsTile, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_Y > 0 Then
            If Matrix(LOC_X, LOC_Y - 1).Image Is Nothing Then
                Matrix(LOC_X, LOC_Y - 1).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_Y -= 1
                HideDialogPanel()

            End If

            Select Case Matrix(LOC_X, LOC_Y - 1).Tag
                Case "Megaman"
                    EnableDialogPanel("Hi whats up Link !")

            End Select
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
    Private Sub moveDOWN(ByRef Matrix(,) As clsTile, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_Y < 15 Then
            If Matrix(LOC_X, LOC_Y + 1).Image Is Nothing Then
                Matrix(LOC_X, LOC_Y + 1).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_Y += 1
                HideDialogPanel()

            End If

            Select Case Matrix(LOC_X, LOC_Y + 1).Tag
                Case "Megaman"
                    EnableDialogPanel("Hi whats up Link !")

            End Select
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
    Private Sub moveLEFT(ByRef Matrix(,) As clsTile, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_X > 0 Then

            If Matrix(LOC_X - 1, LOC_Y).Image Is Nothing Then
                Matrix(LOC_X - 1, LOC_Y).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_X -= 1

                HideDialogPanel()
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
    Private Sub moveRIGHT(ByRef Matrix(,) As clsTile, ByVal LOC_X As Integer, ByVal LOC_Y As Integer)
        If LOC_X < 15 Then
            If Matrix(LOC_X + 1, LOC_Y).Image Is Nothing Then
                Matrix(LOC_X + 1, LOC_Y).Image = My.Resources.Link
                Matrix(LOC_X, LOC_Y).Image = Nothing
                heroPos_X += 1
                HideDialogPanel()

            End If

            Select Case Matrix(LOC_X + 1, LOC_Y).Tag
                Case "Megaman"
                    EnableDialogPanel("Hi whats up Link !")

            End Select
        End If
    End Sub
#Region "I/O Methods"
    'Private Sub removeAllImages()
    '    Me.Controls.Clear()
    'End Sub

    'Private Sub saveArrays()
    '    Dim arrayFile As New clsBunchOfArrays
    '    binFormat.Serialize(fStream, arrayFile)
    '    fStream.Close()


    'End Sub

    'Private Sub loadArrays()
    '    removeAllImages()
    '    fStream = File.OpenRead("Maps.mp")

    '    Dim arrayClass As clsBunchOfArrays = CType(binFormat.Deserialize(fStream), clsBunchOfArrays)
    '    fStream.Close()

    '    TestArray1 = arrayClass.BasicRoad
    '    TestArray2 = arrayClass.grassMap
    '    TestArray3 = arrayClass.SpriteMap

    '    fillMatrix(theOneMatrix, TestArray1, SpriteMap)


    'End Sub
#End Region

    Private Sub GenerateTransitions(ByVal Matrix(,) As clsTile)

    End Sub

    Private Sub RemoveAndApplyTileSet(ByVal Matrix(,) As clsTile, ByVal tileset As Array, ByVal spriteSet As Array)
        Me.Controls.Clear()
        fillMatrix(Matrix, tileset, spriteSet)
        showMatrix(Matrix)
        addHero(Matrix, heroPos_X, heroPos_Y)

    End Sub

    ''' <summary>
    ''' That spawns the dialog box and using its mathod, will add the text "Test"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EnableDialogPanel(ByVal text As String)
        dialogMenu.showDialogPanel(text)
        Me.Controls.Add(dialogMenu)
        dialogMenu.BringToFront()


    End Sub

    Private Sub HideDialogPanel()
        Me.Controls.Remove(dialogMenu)

    End Sub

    Private Sub SimplifiedForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '######## Part 1 - Test ########
        fillMatrix(theOneMatrix, TileRepo.BasicRoad, TileRepo.SpriteMap)
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
            Case Keys.E
                dialogMenu.showDialogPanel("Test")
                Me.Controls.Add(dialogMenu)
                dialogMenu.BringToFront()
            Case Keys.R
                dialogMenu.hideDialogPanel()
            Case Keys.Q
                RemoveAndApplyTileSet(theOneMatrix, TileRepo.Village, TileRepo.SpriteMap)
            Case Keys.W
                RemoveAndApplyTileSet(theOneMatrix, TileRepo.BasicRoad, TileRepo.SpriteMap)

        End Select
    End Sub
End Class