Public Class clsPlayer
    '///// Player stuff \\\\\
    Dim pcname As String
    Dim pclevel As Integer
    Dim pcsprite As Image
    '///// Background stuff \\\\\
    Dim outputBox As MessageBar_Console.ctrMessageBar

#Region "Stats"
    Dim pcStrength
    Dim pcDexterity
    Dim pcConstitution
    Dim pcIntelligence
    Dim pcWisdom
    Dim pcCharisma
#End Region

    Public Sub changeName(ByVal newName As String)
        pcname = newName
    End Sub

    Public Sub levelUp()
        pclevel += 1
        Dim message As String = pcname + " has leveled ! You are now lv" + pclevel
        outputBox.AddMSG(message)
    End Sub

    Public Sub changeLevel(ByVal newLevel As Integer)
        pclevel = newLevel
    End Sub

    Public Sub New(ByRef paramOutputBox As MessageBar_Console.ctrMessageBar)
        outputBox = paramOutputBox
        pcsprite = My.Resources.Link
    End Sub

#Region "Properties"
    Public Property Strength
        Get
            Return pcStrength
        End Get
        Set(ByVal value)
            pcStrength = value
        End Set
    End Property
    Public Property Dexterity
        Get
            Return pcDexterity
        End Get
        Set(ByVal value)
            pcDexterity = value
        End Set
    End Property
    Public Property Constitution
        Get
            Return pcConstitution
        End Get
        Set(ByVal value)
            pcConstitution = value
        End Set
    End Property
    Public Property Intelligence
        Get
            Return pcIntelligence
        End Get
        Set(ByVal value)
            pcIntelligence = value
        End Set
    End Property
    Public Property Wisdom
        Get
            Return pcWisdom
        End Get
        Set(ByVal value)
            pcWisdom = value
        End Set
    End Property
    Public Property Charisma
        Get
            Return pcCharisma
        End Get
        Set(ByVal value)
            pcCharisma = value
        End Set
    End Property
#End Region

End Class
