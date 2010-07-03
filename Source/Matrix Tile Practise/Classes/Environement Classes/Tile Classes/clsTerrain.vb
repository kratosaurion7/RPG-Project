Public Class clsTerrain

#Region "Directions"  'Has to be public else their derived classes won't see this property. Wierd ??
    Public ToTheTop As clsTerrain
    Public ToTheRight As clsTerrain
    Public ToTheBottom As clsTerrain
    Public ToTheLeft As clsTerrain
#End Region

#Region "Declarations"
    Public mapName As String

    Public gridMap As Array
    Public spriteMap As Array
    Public transitionsMap As Array

    Public Position As Point

#End Region

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Give the object a name, an grid of tiles, a grid of sprites and a grid of transitions from arrays.
    ''' </summary>
    ''' <param name="Name">Name of the map</param>
    ''' <param name="grid">Array of numbers that can be translated into tile images.</param>
    ''' <param name="sprites">Array of numbers that can be translated into sprites images</param>
    ''' <param name="transitions">Array of numbers that can be translated into boolean values indicating a transition</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Name As String, ByVal grid As Array, ByVal sprites As Array, ByVal transitions As Array)
        mapName = Name

        gridMap = grid
        spriteMap = sprites
        transitionsMap = transitions
    End Sub

    ''' <summary>
    ''' Initializes the map's physical neighboors
    ''' </summary>
    ''' <param name="top">Map to the top of the current map</param>
    ''' <param name="right">Map to the right of the current map</param>
    ''' <param name="bottom">Map to the bottom of the current map</param>
    ''' <param name="left">Map to the left of the current map</param>
    ''' <remarks></remarks>
    Public Sub initSurroundings(Optional ByVal top As clsTerrain = Nothing, Optional ByVal right As clsTerrain = Nothing, Optional ByVal bottom As clsTerrain = Nothing, Optional ByVal left As clsTerrain = Nothing)
        ToTheTop = top 'TODO: May want to check if they have a value of nothing before doing the attribution
        ToTheRight = right
        ToTheBottom = bottom
        ToTheLeft = left


    End Sub
End Class
