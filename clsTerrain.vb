Imports System.IO
Public Class clsTerrain

#Region "Directions"  'Has to be public else their derived classes won't see this property. Wierd ??
    Public ToTheTop As clsTerrain
    Public ToTheRight As clsTerrain
    Public ToTheBottom As clsTerrain
    Public ToTheLeft As clsTerrain
#End Region

#Region "Declarations"
    Dim mapName As String

    Public gridMap As Array
    Public spriteMap As Array
    Public transitionsMap As Array

    Public Position As Point
    'Public DefaultPosition As Point

#End Region

    Public Sub New()
    End Sub

    Public Sub New(ByVal Name As String, ByVal grid As Array, ByVal sprites As Array, ByVal transitions As Array)
        mapName = Name

        gridMap = grid
        spriteMap = sprites
        transitionsMap = transitions
    End Sub

    Public Sub initSurroundings(Optional ByVal top As clsTerrain = Nothing, Optional ByVal right As clsTerrain = Nothing, Optional ByVal bottom As clsTerrain = Nothing, Optional ByVal left As clsTerrain = Nothing)
        ToTheTop = top 'TODO: May want to check if they have a value of nothing before doing the attribution
        ToTheRight = right
        ToTheBottom = bottom
        ToTheLeft = left


    End Sub


#Region "Array I/O"

#End Region

End Class
