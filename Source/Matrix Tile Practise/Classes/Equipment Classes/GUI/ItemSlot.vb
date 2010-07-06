Public Class ItemSlot
    Inherits PictureBox

    Public canFit As Collection 'The variable that dictates what kind of item can be fitted inside the slot

    Public Sub New()
        MyBase.New()
        Me.Size = New Size(64, 64)

    End Sub


End Class
