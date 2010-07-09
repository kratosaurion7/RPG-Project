Public Class clsArmor
    Inherits clsItem

    Public defence As Integer
    Public iType As String

    Public Sub New(ByVal pname As String, ByVal pTags() As String)
        MyBase.New(pname)
        tags.Add(pTags)
    End Sub
End Class