Public Class clsConsumable
    Inherits clsItem
    Public restoreHP As Integer
    Public restoreMP As Integer


    Public Sub New(ByVal pName As String, ByVal HP As Integer, ByVal MP As Integer)
        MyBase.New(pName)
        restoreHP = HP
        restoreMP = MP
    End Sub



End Class