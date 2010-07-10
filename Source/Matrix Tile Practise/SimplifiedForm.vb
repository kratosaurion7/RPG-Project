Imports System.IO
Public Class frmSimplifiedForm
#Region "Arrays"

#Region "BasicRoad"
    Public BasicRoad_Map As Array = _
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
    Public BasicRoad_Sprites As Array = _
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
    Public BasicRoad_Transitions As Array = _
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0}
#End Region
#Region "Village"
    Public Village_Map As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 2, 2, 2, 3, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 7, 7, 7, 7, 1, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 5, 5, 5, 5, 1, 0, _
2, 2, 3, 0, 0, 0, 0, 0, 0, 1, 6, 6, 4, 6, 1, 0, _
0, 0, 3, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 3, 2, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public Village_Sprites As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public Village_Transition As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
#End Region
#Region "GrassyKnoll"
    Public GrassyKnoll_Map As Array = _
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0}
    Public GrassyKnoll_Sprites As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public GrassyKnoll_Transition As Array = _
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0}
#End Region

#Region "Defaults"
    Public Blank As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
#End Region

#End Region


#Region "Map Declarations"

    'Declares maps of the world.
    Dim BasicRoad As New clsTerrain("BasicRoad", BasicRoad_Map, BasicRoad_Sprites, BasicRoad_Transitions)
    Dim GrassyKnoll As New clsTerrain("GrassyKnoll", GrassyKnoll_Map, GrassyKnoll_Sprites, GrassyKnoll_Transition)
    Dim Village As New clsTerrain("Village", Village_Map, Village_Sprites, Village_Transition)

    Dim currentMap As clsTerrain 'The map we are using. 

#End Region

    Dim NPC_Collection As New Collection 'Collection containing every clsNPC added by the FillMatrix

    Dim theOneMatrix(15, 15) As clsTile 'Matrix filled with pictureboxes to represend the map.

    Dim tileSize As Integer = 32 'Generic tile size

    Dim startingPosition As New Point(7, 2) 'TODO: Replace this by a function that scans the tiles for one marked StartingPosition and get the location from there,

    Dim characterSheet As New clsPlayer

    Friend itemSheet As New clsItemData
#Region "Temporary Forms declaration"
    Dim characterInfoScreen As New frmCaracter_and_Equipement(characterSheet)

#End Region

    ''' <summary>
    ''' Take the matrix in parameter and fill it with required elements from the arrays contained in the class.
    ''' </summary>
    ''' <param name="Matrix">Matrix that will be filled.</param>
    ''' <param name="Map">Class containing the arrays used to populate the matrix.</param>
    ''' <remarks>Subject to re-arrangement in smaller pieces.</remarks>
    Private Sub fillMatrix(ByVal Matrix(,) As clsTile, ByVal Map As clsTerrain)
        Dim iCounter As Integer 'This is the counter used to remember which position we are on. It syncronizes the array with the Matrix coordinates
        For LIG As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For COl As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(COl, LIG) = New clsTile
                Select Case Map.gridMap.GetValue(iCounter) 'The number of iCounter represents the position we are in, arrays and matrix are of the same dimensions(usualy)
                    Case 0 'Grass
                        Matrix(COl, LIG).BackgroundImage = My.Resources.GrassTile2
                    Case 1 'North To South road
                        Matrix(COl, LIG).BackgroundImage = My.Resources.Up_Down_Road
                    Case 2 'East to west road
                        Matrix(COl, LIG).BackgroundImage = My.Resources.left_right_Road
                    Case 3 'Crossroad going in both axis
                        Matrix(COl, LIG).BackgroundImage = My.Resources.Crossroad_Road
                    Case 4 'Door
                        Matrix(COl, LIG).BackgroundImage = My.Resources.Door
                    Case 5 'Wall
                        Matrix(COl, LIG).Image = My.Resources.Normal_Wall
                    Case 6 'Lower Part of house walls
                        Matrix(COl, LIG).Image = My.Resources.Lower_Wall
                    Case 7 'Roof wall
                        Matrix(COl, LIG).Image = My.Resources.Roof_Wall
                End Select

                Select Case Map.spriteMap.GetValue(iCounter)
                    Case 0
                    Case 1
                        Dim megaman As New clsMegaman("Megaman", New Point(COl, LIG))
                        NPC_Collection.Add(megaman)
                        Matrix(COl, LIG).caracter = megaman

                        Matrix(COl, LIG).isNPC = True
                        Matrix(COl, LIG).Image = My.Resources.Megaman
                        Matrix(COl, LIG).BringToFront()

                    Case 2
                        Dim BobOmb As New clsBob_Omb("Bob-Omb", New Point(COl, LIG))
                        NPC_Collection.Add(BobOmb)
                        Matrix(COl, LIG).caracter = BobOmb

                        Matrix(COl, LIG).isNPC = True
                        Matrix(COl, LIG).Image = My.Resources.bob_omb
                        Matrix(COl, LIG).BringToFront()
                    Case 3
                        Matrix(COl, LIG).Tag = "Small_Mario"
                        Matrix(COl, LIG).Image = My.Resources.smario
                        Matrix(COl, LIG).BringToFront()
                    Case 4
                        Matrix(COl, LIG).Tag = "Red_Koopa"
                        Matrix(COl, LIG).Image = My.Resources.rkoopa
                        Matrix(COl, LIG).BringToFront()
                    Case 5
                        Matrix(COl, LIG).Tag = "Hero"
                        Matrix(COl, LIG).Image = My.Resources.Link
                End Select

                iCounter += 1
            Next
        Next


    End Sub

    ''' <summary>
    ''' Take the matrix in parameter and generate arranges it on the form.
    ''' </summary>
    ''' <param name="Matrix">Matrix containing the pic</param>
    ''' <remarks></remarks>
    Private Sub showMatrix(ByVal Matrix(,) As clsTile)
        Dim POS_X, POS_Y As Integer 'Values as the next locations(in pixels) to use

        For LIG As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For COL As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(COL, LIG).Location = New Point(POS_X, POS_Y)
                Matrix(COL, LIG).Size = New Size(tileSize, tileSize)
                Me.Controls.Add(Matrix(COL, LIG))

                POS_X += 32
            Next
            POS_X = 0
            POS_Y += 32
        Next

    End Sub

    ''' <summary>
    ''' Spawn the hero on a tile
    ''' </summary>
    ''' <param name="Matrix">Matrix in which to add the hero</param>
    ''' <param name="Map">Class containing the arrays and default position values</param>
    ''' <remarks>Un-used exept at first run time, subject to change.</remarks>
    Private Sub addHero(ByRef Matrix(,) As clsTile, ByVal Map As clsTerrain)

        Matrix(Map.Position.X, Map.Position.Y).Image = My.Resources.Link
        Matrix(Map.Position.X, Map.Position.Y).BringToFront()

    End Sub

    ''' <summary>
    ''' Remove the hero from the map by remove its associated picturebox 'picture' property.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="Map"></param>
    ''' <remarks>Un-used since Map.Position.* is not updated with hero's coordinates. </remarks>
    Private Sub RemoveHero(ByRef Matrix(,) As clsTile, ByVal Map As clsTerrain)
        Matrix(Map.Position.X, Map.Position.Y).Image = Nothing
    End Sub

    Private Sub MoveUp(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)
        Dim HeroPOS As Point = Map.Position 'HeroPOS is a shortcut, so instead of having Map.Position.Y we have HeroPOS.Y
        If CheckIfBorder(HeroPOS) = False Then 'Only enters if the hero is outside the border
            If Matrix(HeroPOS.X, HeroPOS.Y - 1).Image Is Nothing Then 'Checks the tile above the hero
                Matrix(HeroPOS.X, HeroPOS.Y - 1).Image = My.Resources.Link 'If its nothing, place the hero on said tile
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing 'Remvove the hero from the previous tile.
                HeroPOS.Y -= 1 'Update the position of our hero
                Map.Position = HeroPOS 'Gives back the modified coordinates to the variable
            Else 'If there IS something on the tile:
                If Matrix(HeroPOS.X, HeroPOS.Y - 1).isNPC = True Then 'And its an NPC
                    SayStuff(Matrix(HeroPOS.X, HeroPOS.Y - 1).caracter.Conversation) 'Initiate conversation
                End If
            End If
        Else 'If we are on the border tiles
            If HeroPOS.Y - 1 < 0 And _
                                Matrix(HeroPOS.X, HeroPOS.Y).IsTransition Then 'If the tile we are on is a transition
                If Map.ToTheTop Is Nothing = False Then 'If there is a map on top of us
                    currentMap = Map.ToTheTop 'Updates our current map to the one on top
                    currentMap.Position = New Point(HeroPOS.X, HeroPOS.Y + 15) 'Change our position from top tile to bottom tile
                    RemoveAndApplyTileSet(theOneMatrix, currentMap) 'Execute the transition
                End If
            Else 'If we're not on a transition
                Try 'TryCatch to protect from the IndexOutofRange
                    If Matrix(HeroPOS.X, HeroPOS.Y - 1).Image Is Nothing Then
                        Matrix(HeroPOS.X, HeroPOS.Y - 1).Image = My.Resources.Link
                        Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                        HeroPOS.Y -= 1
                        Map.Position = HeroPOS
                    Else
                        If Matrix(HeroPOS.X, HeroPOS.Y - 1).isNPC = True Then
                            SayStuff(Matrix(HeroPOS.X, HeroPOS.Y - 1).caracter.Conversation)
                        End If
                    End If
                Catch exeption As IndexOutOfRangeException 'Shows blocked when we try to go out of the map.
                    ctrMessageBar.AddMSG("Blocked !")
                End Try
            End If
        End If

        maintenance()
    End Sub
    Private Sub MoveDown(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)
        Dim HeroPOS As Point = Map.Position
        If CheckIfBorder(HeroPOS) = False Then
            If Matrix(HeroPOS.X, HeroPOS.Y + 1).Image Is Nothing Then
                Matrix(HeroPOS.X, HeroPOS.Y + 1).Image = My.Resources.Link
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                HeroPOS.Y += 1
                Map.Position = HeroPOS
            Else
                If Matrix(HeroPOS.X, HeroPOS.Y + 1).isNPC = True Then
                    SayStuff(Matrix(HeroPOS.X, HeroPOS.Y + 1).caracter.Conversation)
                End If
            End If
        Else
            If HeroPOS.Y + 1 > 15 And _
                                Matrix(HeroPOS.X, HeroPOS.Y).IsTransition Then
                If Map.ToTheBottom Is Nothing = False Then
                    currentMap = Map.ToTheBottom
                    currentMap.Position = New Point(HeroPOS.X, HeroPOS.Y - 15)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                Try
                    If Matrix(HeroPOS.X, HeroPOS.Y + 1).Image Is Nothing Then
                        Matrix(HeroPOS.X, HeroPOS.Y + 1).Image = My.Resources.Link
                        Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                        HeroPOS.Y += 1
                        Map.Position = HeroPOS
                    Else
                        If Matrix(HeroPOS.X, HeroPOS.Y + 1).isNPC = True Then
                            SayStuff(Matrix(HeroPOS.X, HeroPOS.Y + 1).caracter.Conversation)
                        End If
                    End If
                Catch exeption As IndexOutOfRangeException
                    ctrMessageBar.AddMSG("Blocked !")
                End Try
            End If
        End If

        maintenance()
    End Sub
    Private Sub MoveLeft(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)
        Dim HeroPOS As Point = Map.Position
        If CheckIfBorder(HeroPOS) = False Then
            If Matrix(HeroPOS.X - 1, HeroPOS.Y).Image Is Nothing Then
                Matrix(HeroPOS.X - 1, HeroPOS.Y).Image = My.Resources.Link
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                HeroPOS.X -= 1
                Map.Position = HeroPOS
            Else
                If Matrix(HeroPOS.X - 1, HeroPOS.Y).isNPC = True Then
                    SayStuff(Matrix(HeroPOS.X - 1, HeroPOS.Y).caracter.Conversation)
                End If
            End If
        Else
            If HeroPOS.X - 1 < 0 And _
                                Matrix(HeroPOS.X, HeroPOS.Y).IsTransition Then
                If Map.ToTheLeft Is Nothing = False Then
                    currentMap = Map.ToTheLeft
                    currentMap.Position = New Point(HeroPOS.X + 15, HeroPOS.Y)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                Try
                    If Matrix(HeroPOS.X - 1, HeroPOS.Y).Image Is Nothing Then
                        Matrix(HeroPOS.X - 1, HeroPOS.Y).Image = My.Resources.Link
                        Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                        HeroPOS.X -= 1
                        Map.Position = HeroPOS
                    Else
                        If Matrix(HeroPOS.X - 1, HeroPOS.Y).isNPC = True Then
                            SayStuff(Matrix(HeroPOS.X - 1, HeroPOS.Y).caracter.Conversation)
                        End If
                    End If
                Catch exeption As IndexOutOfRangeException
                    ctrMessageBar.AddMSG("Blocked !")
                End Try
            End If
        End If

        maintenance()
    End Sub
    Private Sub MoveRight(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)
        Dim HeroPOS As Point = Map.Position
        If CheckIfBorder(HeroPOS) = False Then
            If Matrix(HeroPOS.X + 1, HeroPOS.Y).Image Is Nothing Then
                Matrix(HeroPOS.X + 1, HeroPOS.Y).Image = My.Resources.Link
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                HeroPOS.X += 1
                Map.Position = HeroPOS
            Else
                If Matrix(HeroPOS.X + 1, HeroPOS.Y).isNPC = True Then
                    SayStuff(Matrix(HeroPOS.X + 1, HeroPOS.Y).caracter.Conversation)
                End If
            End If
        Else
            If HeroPOS.X + 1 > 15 And _
                                Matrix(HeroPOS.X, HeroPOS.Y).IsTransition Then
                If Map.ToTheRight Is Nothing = False Then
                    currentMap = Map.ToTheRight
                    currentMap.Position = New Point(HeroPOS.X - 15, HeroPOS.Y)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                Try
                    If Matrix(HeroPOS.X + 1, HeroPOS.Y).Image Is Nothing Then
                        Matrix(HeroPOS.X + 1, HeroPOS.Y).Image = My.Resources.Link
                        Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing
                        HeroPOS.X += 1
                        Map.Position = HeroPOS
                    Else
                        If Matrix(HeroPOS.X + 1, HeroPOS.Y).isNPC = True Then
                            SayStuff(Matrix(HeroPOS.X + 1, HeroPOS.Y).caracter.Conversation)
                        End If
                    End If
                Catch exeption As IndexOutOfRangeException
                    ctrMessageBar.AddMSG("Blocked !")
                End Try
            End If
        End If

        maintenance()
    End Sub

    ''' <summary>
    ''' This will check if we are on the border of the map.
    ''' </summary>
    ''' <param name="Location">The coordinates we are on</param>
    ''' <returns>Boolean indication true if we are on the border</returns>
    ''' <remarks></remarks>
    Private Function CheckIfBorder(ByVal Location As Point) As Boolean
        If Location.X = 0 Or Location.X = 15 Or Location.Y = 0 Or Location.Y = 15 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Searches through an array in the map class and populates the tiles with transitions based on the values in the array
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="Map"></param>
    ''' <remarks></remarks>
    Private Sub GenerateTransitions(ByVal Matrix(,) As clsTile, ByVal Map As clsTerrain)
        Dim iCounter As Integer
        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                If Map.transitionsMap(iCounter) = 1 Then
                    Matrix(LIG, COL).IsTransition = True

                End If
                iCounter += 1
            Next
        Next

    End Sub

    ''' <summary>
    ''' Removes the current tileset from the form.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <param name="Map"></param>
    ''' <remarks>This actually DELETES every tile and re-do the fill and show pair of subs</remarks>
    Private Sub RemoveAndApplyTileSet(ByVal Matrix(,) As clsTile, ByVal Map As clsTerrain)
        RemoveTiles()
        fillMatrix(Matrix, Map)
        GenerateTransitions(theOneMatrix, Map)
        showMatrix(Matrix)
        addHero(Matrix, Map)


    End Sub

    ''' <summary>
    ''' Remove every clsTile instances from the form.
    ''' </summary>
    ''' <remarks>That'l teach 'dem tiles/</remarks>
    Public Sub RemoveTiles()
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is clsTile Then
                Me.Controls.Remove(Me.Controls(i))
            End If
        Next
    End Sub


    ''' <summary>
    ''' This cleans up everything after a doing something. Will make sure the game state is ok.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub maintenance()
        ctrMessageBar.ReplaceCaret()
    End Sub

    ''' <summary>
    ''' Adds text to the messagebar.
    ''' </summary>
    ''' <param name="theMessage">Text to show in the messagebar</param>
    ''' <remarks></remarks>
    Private Sub SayStuff(ByVal theMessage As String)
        ctrMessageBar.AddMSG(theMessage)
        ctrMessageBar.ReplaceCaret()
    End Sub

    ''' <summary>
    ''' Filling up the sheet to test.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub _testFillPlayerSheet()
        characterSheet.changeName("Leroux")
        characterSheet.changeLevel(11)
        characterSheet.pcClass = New clsMage
        characterSheet.Strength = 9
        characterSheet.Constitution = 10
        characterSheet.Dexterity = 14
        characterSheet.Intelligence = 18
        characterSheet.Wisdom = 16
        characterSheet.Charisma = 15
    End Sub

    Private Sub SimplifiedForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '######## Part 0 - Init ########
        BasicRoad.initSurroundings(, Village, GrassyKnoll, ) : BasicRoad.Position = startingPosition
        Village.initSurroundings(, , , BasicRoad) : Village.Position = New Point(0, 9)
        GrassyKnoll.initSurroundings(BasicRoad, , Village, ) : GrassyKnoll.Position = New Point(5, 15)

        currentMap = BasicRoad

        fillMatrix(theOneMatrix, BasicRoad)
        showMatrix(theOneMatrix)
        addHero(theOneMatrix, BasicRoad)
        GenerateTransitions(theOneMatrix, BasicRoad)

        '######## Part 1 - Functionality Test ########
        _testFillPlayerSheet()
    End Sub

    Public Sub SimplifiedForm_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Up
                MoveUp(theOneMatrix, currentMap)
            Case Keys.Down
                moveDOWN(theOneMatrix, currentMap)
            Case Keys.Left
                moveLEFT(theOneMatrix, currentMap)
            Case Keys.Right
                moveRIGHT(theOneMatrix, currentMap)
            Case Keys.Escape
                Application.Exit()
            Case Keys.Q
                RemoveAndApplyTileSet(theOneMatrix, Village)
            Case Keys.W
                RemoveAndApplyTileSet(theOneMatrix, Village)
        End Select
    End Sub

#Region "StatusStrip Button Handling"
    ''' <summary>
    ''' Opens the Main menu.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Here, note that I did not New() each form as they appear. Only need one instance of a form. Or at least a single instance shown at once.</remarks>
    Private Sub stripMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stripMainMenu.Click
        frmMainMenu.ShowDialog()
    End Sub

    Private Sub GlobalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlobalToolStripMenuItem.Click
        frmMap.Show()
        'Insert parameter to generate the "Global" map
    End Sub

    Private Sub LocalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalToolStripMenuItem.Click
        frmMap.Show()
        'Insert parameter to generate the "Local" map
    End Sub

    Private Sub stripCaracter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stripCaracter.Click
        characterInfoScreen.character = characterSheet 'Same as below
        characterInfoScreen.itemSheet = itemSheet 'Take the item sheet and pass it to the character form using a pointer.
        characterInfoScreen.Show()
    End Sub
#End Region
End Class