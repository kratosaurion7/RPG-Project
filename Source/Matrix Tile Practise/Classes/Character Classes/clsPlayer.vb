Public Class clsPlayer
    '///// Player stuff \\\\\
    Public pcname As String
    Public pclevel As Integer
    Public pcsprite As Image
    Public pcClass As clsClass
    '///// Inventory stuff \\\\\
    Public inventory As New Collection


#Region "Stats"
    Dim pcStrength
    Dim pcDexterity
    Dim pcConstitution
    Dim pcIntelligence
    Dim pcWisdom
    Dim pcCharisma
#End Region

#Region "Test Procedures"
    Public Sub fillInventory()


    End Sub
#End Region

    Public Sub changeName(ByVal newName As String)
        pcname = newName
    End Sub

    Public Sub levelUp()
        pclevel += 1
        Dim message As String = pcname + " has leveled ! You are now lv" + pclevel 'Need to process this message into the messagebar.
    End Sub

    Public Sub changeLevel(ByVal newLevel As Integer)
        pclevel = newLevel
    End Sub

    Public Sub New()
        pcsprite = My.Resources.Link
    End Sub

    ''' <summary>
    ''' Add an item to the inventory.
    ''' </summary>
    ''' <param name="paramItem">The item we wish to add</param>
    ''' <remarks>Won't add more items if there is already 15(16) elements in the inventory.</remarks>
    Public Sub addItem(ByVal paramItem As clsItem)
        If inventory.Count < 15 Then
            inventory.Add(paramItem, inventory.Count)
        Else
            'Output "Inventory is full" message
            MessageBox.Show("Inventory is full")
        End If
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
