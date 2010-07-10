Public Class clsItemData

    Public ironSword As New clsWeapon("Iron Sword", 5, 10, {"Iron", "Sword", "Weapon"})
    Public squirePlate As New clsArmor("Plate of the Squire", {"Squire", "Plate", "Armor"})

    'Need to get the relative path for this one. At least get the path to the working directory and add from there.
    'Public directory as String = My.Application.Info.DirectoryPath
    Public directory As String = "C:\Users\Leroux\Documents\Visual Studio 2010\Projects\TFS_Root\Production\RPG_Project\Alpha Builds\RPG-Project.git\Source\Matrix Tile Practise\Textures\Items"

    Public Sub init()
        ironSword.description = "That is an iron sword"
        ironSword.iPicture = Image.FromFile(directory & "\sword_iron.png")

        squirePlate.description = "This is a plate armor of a squire"
        squirePlate.iPicture = Image.FromFile(directory & "\plate_squire.png")



    End Sub

    Public Sub New()
        init()
    End Sub


End Class
