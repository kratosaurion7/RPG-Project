Public Class clsDialogMenu
    Inherits Panel

    Dim btnOK As New Button
    Dim btnNO As New Button
    Dim lblText As New Label

    Dim myForm As Form

    Private Sub init()

        myForm = Me.FindForm

        Me.BackColor = Color.LemonChiffon
        Me.Enabled = False
        Me.Visible = False

        'myForm.BackColor = Color.Black
        Me.Location = New Point(40, 350)
        Me.Size = New Size(360, 100)

        btnOK.Parent = Me
        btnOK.Location = New Point(277, 70)
        btnOK.Size = New Size(75, 23)
        btnOK.Text = "Ok"

        ' TODO: Add a handler to close the conversation when clicked NO, so we can move again. Addhandler ?
        btnNO.Parent = Me
        btnNO.Location = New Point(196, 70)
        btnNO.Size = New Size(75, 23)
        btnNO.Text = "No"


        lblText.Parent = Me
        lblText.Location = New Point(12, 12)
        lblText.Text = "This is a test"

    End Sub


    Public Sub changeText(ByVal newText As String)
        lblText.Text = newText
    End Sub

    Public Sub showDialogPanel(ByVal text As String)
        changeText(text)
        Me.Visible = True
        Me.Enabled = True

    End Sub

    Public Sub hideDialogPanel()
        Me.Enabled = False
        Me.Visible = False
    End Sub

    Public Sub New()
        init()
    End Sub

    ' ?????
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
