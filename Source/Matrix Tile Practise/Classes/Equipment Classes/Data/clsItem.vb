Public Class clsItem
    Public name As String
    Public description As String
    Public iPicture As Image

    Public tags As New ArrayList

    Public Sub New(ByVal pName As String)
        name = pName
    End Sub

End Class
