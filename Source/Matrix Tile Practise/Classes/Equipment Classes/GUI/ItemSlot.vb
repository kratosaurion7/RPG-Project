''' <summary>
''' Class that represend a slot in which an item can be dropped
''' </summary>
''' <remarks></remarks>
Public Class ItemSlot
    Inherits PictureBox

    Public itemIn As clsItem 'The item contained in the slot
    'The execution skips here because the itemIn is not new'ed, not sure why I should new it but it works. That is bad.

    Public Sub New()
        MyBase.new()
        Me.Size = New Size(64, 64)

    End Sub

End Class
