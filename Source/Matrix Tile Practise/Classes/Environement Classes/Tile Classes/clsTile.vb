Public Class clsTile
    Inherits PictureBox


#Region "Transition Stuff"
    Public IsTransition As Boolean 'Indicate whether the tile is a transition
#End Region

#Region "NPC_Stuff"
    Public isNPC As Boolean 'Indicate whether a tile contains an NPC

    Public caracter As clsNPC 'NPC that is standing on the tile

#End Region

    ''' <summary>
    ''' Default constructor, runs the default picturebox constructor also.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New()
        Me.SizeMode = PictureBoxSizeMode.Normal
    End Sub

End Class