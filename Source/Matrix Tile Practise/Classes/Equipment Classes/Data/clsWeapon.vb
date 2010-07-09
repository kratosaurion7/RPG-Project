Public Class clsWeapon
    Inherits clsItem
    Public minDmg As Integer
    Public maxDmg As Integer

    Public Sub New(ByVal pName As String, ByVal min As Integer, ByVal max As Integer)
        MyBase.New(pName)

    End Sub

End Class
