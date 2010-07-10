Public Class clsWeapon
    Inherits clsItem
    Public minDmg As Integer
    Public maxDmg As Integer

    Public Sub New(ByVal pName As String, ByVal min As Integer, ByVal max As Integer, ByVal ptags() As String)
        MyBase.New(pName)
        tags.Add(ptags)
    End Sub

    Public Function findDamage(ByVal min As Integer, ByVal max As Integer)
        Randomize()
        Return CInt(Int((max * Rnd()) + min))
    End Function


End Class
