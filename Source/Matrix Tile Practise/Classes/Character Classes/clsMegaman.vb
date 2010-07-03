Public Class clsMegaman
    Inherits clsNPC

    ''' <summary>
    ''' Give the object a name, a location and a generic dialog text.
    ''' </summary>
    ''' <param name="npcName">Name of the object</param>
    ''' <param name="npcLocation">Location of the object.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal npcName As String, ByVal npcLocation As Point)
        MyBase.New(npcName, npcLocation)
        Conversation = "Hi Link. Glad to meet you !"
    End Sub

End Class
