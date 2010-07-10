Public Class frmCaracter_and_Equipement

    Public character As clsPlayer 'New ?
    Public itemSheet As clsItemData
    Public inventorySlots As New Collection 'The collection containing every slot of the inventory

    Private Sub frmCaracter_and_Equipement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '///// Info Attribution \\\\\
        lblHeroName.Text = character.pcname
        lblLevel.Text = character.pclevel
        lblClass.Text = character.pcClass.className
        lblStr.Text = character.Strength
        lblCon.Text = character.Constitution
        lblDex.Text = character.Dexterity
        lblInt.Text = character.Intelligence
        lblWis.Text = character.Wisdom
        lblCha.Text = character.Charisma

        _testFillItems()
    End Sub

    Public Sub initItemSlots()
        'Might be able to replace those with a ForEach but only if they are placed in order, else the third itemSlot might be given the key 4.
        inventorySlots.Add(isSlot0, 1)
        inventorySlots.Add(isSlot1, 2)
        inventorySlots.Add(isSlot2, 3)
        inventorySlots.Add(isSlot3, 4)
        inventorySlots.Add(isSlot4, 5)
        inventorySlots.Add(isSlot5, 6)
        inventorySlots.Add(isSlot6, 7)
        inventorySlots.Add(isSlot7, 8)
        inventorySlots.Add(isSlot8, 9)
        inventorySlots.Add(isSlot9, 10)
        inventorySlots.Add(isSlot10, 11)
        inventorySlots.Add(isSlot11, 12)
        inventorySlots.Add(isSlot12, 13)
        inventorySlots.Add(isSlot13, 14)
        inventorySlots.Add(isSlot14, 15)
        inventorySlots.Add(isSlot15, 16)

    End Sub

    ''' <summary>
    ''' Take the items in the character sheet and put them in slots inside the inventory.
    ''' </summary>
    ''' <param name="characterSheet">The clsPlayer instance</param>
    ''' <remarks></remarks>
    Public Sub showItems(ByRef characterSheet As clsPlayer)
        Dim i As Integer = 1 'Counter
        For Each e As clsItem In characterSheet.inventory
            inventorySlots.Item(i).itemIn = e
            i += 1
        Next

        updateInventory()
    End Sub

    ''' <summary>
    ''' Refresh the image of the itemSlots in the inventory panel
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub updateInventory()
        For Each e As ItemSlot In pnlInventory.Controls
            If e.itemIn Is Nothing Then
                'do nothing
            Else
                e.Image = e.itemIn.iPicture
            End If
        Next

    End Sub

    Public Sub _testFillItems()
        character.addItem(itemSheet.ironSword)
        character.addItem(itemSheet.squirePlate)
        showItems(character)
    End Sub

    Public Sub New(ByRef sheet As clsPlayer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        character = sheet 'Give the form the date it needs to show information on the character. Also needed to modify its equipement.
        initItemSlots() 'Put the item slots inside the inventory slots collection.
    End Sub
End Class