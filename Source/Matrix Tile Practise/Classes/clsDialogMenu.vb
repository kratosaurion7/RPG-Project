Public Class clsDialogMenu 'I'm keeping this in case I need to make a small popup sometimes.
    Inherits Panel

    Dim btnOK As New Button
    Dim btnNO As New Button
    Dim lblText As New Label

    Dim myForm As Form

    ''' <summary>
    ''' Generate the controls associated to the form
    ''' </summary>
    ''' <remarks></remarks>
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


        btnNO.Parent = Me
        btnNO.Location = New Point(196, 70)
        btnNO.Size = New Size(75, 23)
        btnNO.Text = "No"
        AddHandler btnNO.Click, AddressOf hideDialogPanel

        lblText.Parent = Me
        lblText.Location = New Point(12, 12)
        lblText.Text = "This is a test"
        lblText.Width = Me.Width

    End Sub

    ''' <summary>
    ''' Change the text
    ''' </summary>
    ''' <param name="newText"></param>
    ''' <remarks></remarks>
    Public Sub changeText(ByVal newText As String)
        lblText.Text = newText
    End Sub

    ''' <summary>
    ''' Changes the visible and enabled property to true
    ''' </summary>
    ''' <param name="text"></param>
    ''' <remarks></remarks>
    Public Sub showDialogPanel(ByVal text As String)
        changeText(text)
        Me.Visible = True
        Me.Enabled = True

    End Sub

    ''' <summary>
    ''' Changes the visible and enabled property to false.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub hideDialogPanel()
        Me.Enabled = False
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        init()
    End Sub

    ' ?????
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
