Public Class frmCaracter_and_Equipement

    Dim characterSheet As clsPlayer 'New ?
    Dim inventorySlots As Collection

    Private Sub frmCaracter_and_Equipement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Atribute the values to their respective labels.
        lblHeroName.Text = characterSheet.pcname
        lblLevel.Text = characterSheet.pclevel
        lblClass.Text = characterSheet.pcClass.className
        lblStr.Text = characterSheet.Strength
        lblCon.Text = characterSheet.Constitution
        lblDex.Text = characterSheet.Dexterity
        lblInt.Text = characterSheet.Intelligence
        lblWis.Text = characterSheet.Wisdom
        lblCha.Text = characterSheet.Charisma

    End Sub

    Public Sub initItemSlots()
        'Might be able to replace those with a ForEach but only if they are placed in order, else the third itemSlot might be given the key 4.
        inventorySlots.Add(isSlot0, 0)
        inventorySlots.Add(isSlot1, 1)
        inventorySlots.Add(isSlot2, 2)
        inventorySlots.Add(isSlot3, 3)
        inventorySlots.Add(isSlot4, 4)
        inventorySlots.Add(isSlot5, 5)
        inventorySlots.Add(isSlot6, 6)
        inventorySlots.Add(isSlot7, 7)
        inventorySlots.Add(isSlot8, 8)
        inventorySlots.Add(isSlot9, 9)
        inventorySlots.Add(isSlot10, 10)
        inventorySlots.Add(isSlot11, 11)
        inventorySlots.Add(isSlot12, 12)
        inventorySlots.Add(isSlot13, 13)
        inventorySlots.Add(isSlot14, 14)
        inventorySlots.Add(isSlot15, 15)

    End Sub

    Public Sub showItems(ByVal characterSheet As clsPlayer)
        For Each e As clsItem In characterSheet.inventory
            Dim i As Integer
            inventorySlots.Item(i).image = e.itemPicture
            i += 1
        Next
    End Sub

    Public Sub New(ByRef sheet As clsPlayer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        characterSheet = sheet 'Give the form the date it needs to show information on the character. Also needed to modify its equipement.
    End Sub
End Class