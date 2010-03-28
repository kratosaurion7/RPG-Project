Public Class clsTile
    Inherits PictureBox


#Region "Transition Stuff"
    Public IsTransition As Boolean 'Is the tile a transition tile ?
    Public GoingTo As clsTerrain 'The tileset the transition is pointing to
    Public GoingToCoord As Point 'The coordinates it points to inside the GoingTo tilset
    Public Transition_Coordonate As Point 'The coordinates of the transition inside the currentTileset, might not be useful
#End Region

    Public Sub New()
        MyBase.New()
    End Sub

End Class
