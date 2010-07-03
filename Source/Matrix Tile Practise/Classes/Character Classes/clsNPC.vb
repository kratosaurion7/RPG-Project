Imports System.Text
Public Class clsNPC

    Public name As String
    Public location As Point
    Public canTalk As Boolean
    Public Conversation As String

#Region "Dialog Declarations"
    Dim DefaultDialog1 As String 'How about we make another 'string' type in which we add the property 'isSmallTalk' that we could on/off as we want
    Dim DefaultDialog2 As String
    Dim DefaultDialog3 As String

#End Region

    ''' <summary>
    ''' Defautl constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub
    ''' <summary>
    ''' Gives the object a name and a location
    ''' </summary>
    ''' <param name="npcName"></param>
    ''' <param name="npcLocation"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal npcName As String, ByVal npcLocation As Point)
        name = npcName
        location = npcLocation
    End Sub


End Class
