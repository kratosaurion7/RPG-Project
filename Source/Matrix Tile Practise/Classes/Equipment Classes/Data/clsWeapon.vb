Public Class clsWeapon
    Inherits clsItem
    Public minDmg As Integer
    Public maxDmg As Integer

    Public Sub New(ByVal pName As String, ByVal min As Integer, ByVal max As Integer)
        MyBase.New(pName)

    End Sub

    Public Function findDamage(ByVal min As Integer, ByVal max As Integer)
        Randomize()
        Return CInt(Int((max * Rnd()) + min))
    End Function


End Class
