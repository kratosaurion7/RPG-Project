Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.IO
Public Class SimplifiedForm

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
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, _
2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 3, 2, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public Village_Sprites As Array = _
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
    Public Village_Transition As Array = _
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
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
0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0}
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

    Dim BasicRoad As New clsTerrain("BasicRoad", BasicRoad_Map, BasicRoad_Sprites, BasicRoad_Transitions)
    Dim GrassyKnoll As New clsTerrain("GrassyKnoll", GrassyKnoll_Map, GrassyKnoll_Sprites, GrassyKnoll_Transition)
    Dim Village As New clsTerrain("Village", Village_Map, Village_Sprites, Village_Transition)

    Dim currentMap As clsTerrain

#End Region

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

    Dim tileSize As Integer = 32

    Dim dialogMenu As New clsDialogMenu


    ''' <summary>
    ''' Scrolls through the matrix using the LIG/COL technique, make a new instance of them and assigns them a picture from the array
    ''' based on a counter that increase by one every interation. This is to make the array position match the position in the matrix.
    ''' It firsts applies the background image, that will be the tile and then the image property that will be the sprite. Gives every
    ''' sprite a tag for identification ## Will need a better detection system than tags ## 
    ''' </summary>
    ''' <param name="Matrix">The matrix of clsTilees that is used to store the tiles and sprites. Dim'ed as a (15, 15) matrix.</param>
    ''' <remarks></remarks>
    Private Sub fillMatrix(ByVal Matrix(,) As clsTile, ByVal Map As clsTerrain)
        Dim iCounter As Integer
        For COL As Integer = Matrix.GetLowerBound(0) To Matrix.GetUpperBound(0)
            For LIG As Integer = Matrix.GetLowerBound(1) To Matrix.GetUpperBound(1)
                Matrix(LIG, COL) = New clsTile
                Select Case Map.gridMap.GetValue(iCounter)
                    Case 0
                        Matrix(LIG, COL).BackgroundImage = My.Resources.GrassTile2
                    Case 1
                        Matrix(LIG, COL).BackgroundImage = My.Resources.Up_Down_Road
                    Case 2
                        Matrix(LIG, COL).BackgroundImage = My.Resources.left_right_Road
                    Case 3
                        Matrix(LIG, COL).BackgroundImage = My.Resources.Crossroad_Road
                End Select

                Select Case Map.spriteMap.GetValue(iCounter)
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
    ''' <param name="Matrix">Matrix the hero will be placed inside.</param>
    ''' <param name="Map"></param>
    ''' <remarks></remarks>
    Private Sub addHero(ByRef Matrix(,) As clsTile, ByVal Map As clsTerrain)

        Matrix(Map.Position.X, Map.Position.Y).Image = My.Resources.Link
        Matrix(Map.Position.X, Map.Position.Y).BringToFront()

    End Sub

    Private Sub RemoveHero(ByRef Matrix(,) As clsTile, ByVal Map As clsTerrain)
        Matrix(Map.Position.X, Map.Position.Y).Image = Nothing
    End Sub

    ''' <summary>
    ''' This will check if the space directly on top of the hero is free. By checking in the matrix(x, y-1) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <remarks></remarks>
    Private Sub moveUP(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)

        Dim HeroPOS As Point = Map.Position 'This is to save keystrokes

        If CheckIfBorder(HeroPOS) = False And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then 'If the tile we're on is NOT on the border and is NOT a transition

            If Matrix(HeroPOS.X, HeroPOS.Y - 1).Image Is Nothing Then       'Check if the next tile is free
                Matrix(HeroPOS.X, HeroPOS.Y - 1).Image = My.Resources.Link  'Put our image on the next tile
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                HeroPOS.Y -= 1                                              'Update the coordinates
                HideDialogPanel()                                           'Hide the panel if its on
                Map.Position = HeroPOS                                      'Return the values of the variable to the class
            Else
                Select Case Matrix(HeroPOS.X, HeroPOS.Y - 1).Tag
                    Case "Megaman"
                        EnableDialogPanel("Hi, whats up Link !")

                End Select
            End If
        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = True Then 'If the tile we're on IS a transition and IS on the border of the map.
            If HeroPOS.Y - 1 < 0 Then
                If Map.ToTheTop Is Nothing = False Then 'Checks if there IS a map to the right, if there is:
                    currentMap = Map.ToTheTop
                    currentMap.Position = New Point(HeroPOS.X, HeroPOS.Y + 15)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                If Matrix(HeroPOS.X, HeroPOS.Y - 1).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X, HeroPOS.Y - 1).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.Y -= 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X, HeroPOS.Y - 1).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If

        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = False Then
            'Door Transition


        ElseIf CheckIfBorder(HeroPOS) = True And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then
            If HeroPOS.Y - 1 > 0 Then
                If Matrix(HeroPOS.X, HeroPOS.Y - 1).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X, HeroPOS.Y - 1).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.Y -= 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X, HeroPOS.Y - 1).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If
        End If




    End Sub
    ''' <summary>
    ''' This will check if the space directly on down of the hero is free. By checking in the matrix(x, y+1) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <remarks></remarks>
    Private Sub moveDOWN(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)

        Dim HeroPOS As Point = Map.Position 'This is to save keystrokes

        If CheckIfBorder(HeroPOS) = False And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then 'If the tile we're on is NOT on the border and is NOT a transition

            If Matrix(HeroPOS.X, HeroPOS.Y + 1).Image Is Nothing Then       'Check if the next tile is free
                Matrix(HeroPOS.X, HeroPOS.Y + 1).Image = My.Resources.Link  'Put our image on the next tile
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                HeroPOS.Y += 1                                              'Update the coordinates
                HideDialogPanel()                                           'Hide the panel if its on
                Map.Position = HeroPOS                                      'Return the values of the variable to the class
            Else
                Select Case Matrix(HeroPOS.X, HeroPOS.Y + 1).Tag
                    Case "Megaman"
                        EnableDialogPanel("Hi, whats up Link !")

                End Select
            End If
        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = True Then 'If the tile we're on IS a transition and IS on the border of the map.
            If HeroPOS.Y + 1 > 15 Then
                If Map.ToTheBottom Is Nothing = False Then 'Checks if there IS a map to the right, if there is:
                    currentMap = Map.ToTheBottom
                    currentMap.Position = New Point(HeroPOS.X, HeroPOS.Y - 15)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                If Matrix(HeroPOS.X, HeroPOS.Y + 1).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X, HeroPOS.Y + 1).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.Y += 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X, HeroPOS.Y + 1).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If

        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = False Then
            'Door Transition


        ElseIf CheckIfBorder(HeroPOS) = True And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then
            If HeroPOS.Y + 1 < 15 Then
                If Matrix(HeroPOS.X, HeroPOS.Y + 1).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X, HeroPOS.Y + 1).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.Y += 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X, HeroPOS.Y + 1).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If
        End If




    End Sub
    ''' <summary>
    ''' This will check if the space directly on the left of the hero is free. By checking in the matrix(x-1, y) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <remarks></remarks>
    Private Sub moveLEFT(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)
        Dim HeroPOS As Point = Map.Position 'This is to save keystrokes

        If CheckIfBorder(HeroPOS) = False And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then 'If the tile we're on is NOT on the border and is NOT a transition

            If Matrix(HeroPOS.X - 1, HeroPOS.Y).Image Is Nothing Then       'Check if the next tile is free
                Matrix(HeroPOS.X - 1, HeroPOS.Y).Image = My.Resources.Link  'Put our image on the next tile
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                HeroPOS.X -= 1                                              'Update the coordinates
                HideDialogPanel()                                           'Hide the panel if its on
                Map.Position = HeroPOS                                      'Return the values of the variable to the class
            Else
                Select Case Matrix(HeroPOS.X - 1, HeroPOS.Y).Tag
                    Case "Megaman"
                        EnableDialogPanel("Hi, whats up Link !")

                End Select
            End If
        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = True Then 'If the tile we're on IS a transition and IS on the border of the map.
            If HeroPOS.X - 1 < 0 Then
                If Map.ToTheLeft Is Nothing = False Then 'Checks if there IS a map to the right, if there is:
                    currentMap = Map.ToTheLeft
                    currentMap.Position = New Point(HeroPOS.X + 15, HeroPOS.Y)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                If Matrix(HeroPOS.X - 1, HeroPOS.Y).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X - 1, HeroPOS.Y).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.X -= 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X - 1, HeroPOS.Y).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If


        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = False Then
            'Door Transition


        ElseIf CheckIfBorder(HeroPOS) = True And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then
            If HeroPOS.X - 1 > 0 Then
                If Matrix(HeroPOS.X - 1, HeroPOS.Y).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X - 1, HeroPOS.Y).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.X -= 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X - 1, HeroPOS.Y).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If
        End If





    End Sub


    ''' <summary>
    '''  This will check if the space directly on the right of the hero is free. By checking in the matrix(x+1, y) to check if the image is nothing
    ''' (the absence of a sprite). If it IS nothing, the image of that tile will be our hero's and the tile our hero was will have its 
    ''' image reset. If there IS something, and its Tag correspond to an NPC the dialog box will open and a dialog will begin.
    ''' </summary>
    ''' <param name="Matrix"></param>
    ''' <remarks></remarks>
    Private Sub moveRIGHT(ByRef Matrix(,) As clsTile, ByRef Map As clsTerrain)
        Dim HeroPOS As Point = Map.Position 'This is to save keystrokes

        If CheckIfBorder(HeroPOS) = False And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then 'If the tile we're on is NOT on the border and is NOT a transition

            If Matrix(HeroPOS.X + 1, HeroPOS.Y).Image Is Nothing Then       'Check if the next tile is free
                Matrix(HeroPOS.X + 1, HeroPOS.Y).Image = My.Resources.Link  'Put our image on the next tile
                Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                HeroPOS.X += 1                                              'Update the coordinates
                HideDialogPanel()                                           'Hide the panel if its on
                Map.Position = HeroPOS                                      'Return the values of the variable to the class
            Else
                Select Case Matrix(HeroPOS.X + 1, HeroPOS.Y).Tag
                    Case "Megaman"
                        EnableDialogPanel("Hi, whats up Link !")

                End Select
            End If
        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = True And CheckIfBorder(HeroPOS) = True Then
            If HeroPOS.X + 1 > 15 Then
                If Map.ToTheRight Is Nothing = False Then 'Checks if there IS a map to the right, if there is:
                    currentMap = Map.ToTheRight
                    currentMap.Position = New Point(HeroPOS.X - 15, HeroPOS.Y)
                    RemoveAndApplyTileSet(theOneMatrix, currentMap)
                End If
            Else
                If Matrix(HeroPOS.X + 1, HeroPOS.Y).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X + 1, HeroPOS.Y).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.X += 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X + 1, HeroPOS.Y).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If

        ElseIf Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False And CheckIfBorder(HeroPOS) = False Then
            'Door Transition


        ElseIf CheckIfBorder(HeroPOS) = True And Matrix(HeroPOS.X, HeroPOS.Y).IsTransition = False Then
            If HeroPOS.X + 1 < 15 Then
                If Matrix(HeroPOS.X + 1, HeroPOS.Y).Image Is Nothing Then       'Check if the next tile is free
                    Matrix(HeroPOS.X + 1, HeroPOS.Y).Image = My.Resources.Link  'Put our image on the next tile
                    Matrix(HeroPOS.X, HeroPOS.Y).Image = Nothing                'Remove our image from the tile we're on
                    HeroPOS.X += 1                                              'Update the coordinates
                    HideDialogPanel()                                           'Hide the panel if its on
                    Map.Position = HeroPOS                                      'Return the values of the variable to the class
                Else
                    Select Case Matrix(HeroPOS.X + 1, HeroPOS.Y).Tag
                        Case "Megaman"
                            EnableDialogPanel("Hi, whats up Link !")

                    End Select
                End If
            End If
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

    Private Function CheckIfBorder(ByVal Location As Point) As Boolean
        If Location.X = 0 Or Location.X = 15 Or Location.Y = 0 Or Location.Y = 15 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Generer l'ebauche d'un plan pour initier les transitions. 
    'Could make it that if the array has anything else than 0, its going to be a transition. Values are the GoingTo Value, instead of hardcoding the 
    'values in the 
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

    Private Sub RemoveAndApplyTileSet(ByVal Matrix(,) As clsTile, ByVal Map As clsTerrain)
        Me.Controls.Clear()
        fillMatrix(Matrix, Map)
        GenerateTransitions(theOneMatrix, Map)
        showMatrix(Matrix)
        'Matrix(Map.Position.X, Map.Position.Y).Image = Nothing 'Needed anymore ?
        addHero(Matrix, Map)


    End Sub

    ''' <summary>
    ''' That spawns the dialog box and using its method, will add the text "Test"
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

        '######## Part 0 - Init ########         'Should put that in a sub ?
        BasicRoad.initSurroundings(, Village, , ) : BasicRoad.Position = New Point(7, 2)
        Village.initSurroundings(, , , BasicRoad) : Village.Position = New Point(0, 9)
        GrassyKnoll.initSurroundings(, , Village, ) : GrassyKnoll.Position = New Point(5, 15)

        currentMap = BasicRoad


        '######## Part 1 - Test ########
        fillMatrix(theOneMatrix, BasicRoad)
        showMatrix(theOneMatrix)
        addHero(theOneMatrix, BasicRoad)
        GenerateTransitions(theOneMatrix, BasicRoad)

        '######## Part 2 - Functionality Test ########

    End Sub


    Public Sub SimplifiedForm_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Up
                moveUP(theOneMatrix, currentMap)
            Case Keys.Down
                moveDOWN(theOneMatrix, currentMap)
            Case Keys.Left
                moveLEFT(theOneMatrix, currentMap)
            Case Keys.Right
                moveRIGHT(theOneMatrix, currentMap)
            Case Keys.Escape
                Application.Exit()
            Case Keys.E
                dialogMenu.showDialogPanel("Test")
                Me.Controls.Add(dialogMenu)
                dialogMenu.BringToFront()
            Case Keys.R
                dialogMenu.hideDialogPanel()
            Case Keys.Q
                RemoveAndApplyTileSet(theOneMatrix, Village)
            Case Keys.W
                RemoveAndApplyTileSet(theOneMatrix, Village)

        End Select
    End Sub

    Public Sub TEST(ByVal Border As Boolean, ByVal Transition As Boolean)
        If Border = False And Transition = False Then
            'Walk normaly

        ElseIf Border = False And Transition = True Then
            'Door transition

        ElseIf Border = True And Transition = False Then
            'Walk normaly

        ElseIf Border = True And Transition = True Then
            'Transition IF the right buttun is presses

        Else
            'Walk normaly

        End If

    End Sub



End Class
