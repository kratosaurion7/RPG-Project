Public Class clsItemData

    '///// Warrior Weapon Declaration \\\\\
    Public ironSword As New clsWeapon("Iron Sword", 3, 6, {"Iron", "Sword", "Weapon"})
    Public steelSword As New clsWeapon("Steel Sword", 5, 9, {"Steel", "Sword", "Weapon"})
    Public bronzeSword As New clsWeapon("Bronze Sword", 12, 15, {"Bronze", "Sword", "Weapon"})
    Public silverSword As New clsWeapon("Silver Sword", 14, 18, {"Silver", "Sword", "Weapon"})
    Public goldSword As New clsWeapon("Gold Sword", 17, 20, {"Gold", "Sword", "Weapon"})

    '///// Mage Weapon Declaration \\\\\
    Public splinteredStaff As New clsWeapon("Splintered Staff", 1, 8, {"Splintered", "Staff", "Weapon"})
    Public woodenStaff As New clsWeapon("Wooden Staff", 2, 13, {"Wooden", "Staff", "Weapon"})
    Public hardyStaff As New clsWeapon("Hardy Staff", 5, 17, {"Hardy", "Staff", "Weapon"})
    Public magicalStaff As New clsWeapon("Magical Staff", 6, 19, {"Magical", "Staff", "Weapon"})
    Public legendaryStaff As New clsWeapon("Legendary Staff", 10, 23, {"Legendary", "Staff", "Weapon"})

    '///// Thief Weapon Declaration \\\\\
    Public cheapDagger As New clsWeapon("Cheap Dagger", 4, 5, {"Cheap", "Dagger", "Weapon"})
    Public handyDagger As New clsWeapon("Handy Dagger", 6, 7, {"Handy", "Dagger", "Weapon"})
    Public quickDagger As New clsWeapon("Quick Dagger", 10, 13, {"Quick,", "Dagger", "Weapon"})
    Public violentDagger As New clsWeapon("Violent Dagger", 12, 15, {"Violent", "Dagger", "Weapon"})
    Public deadlyDagger As New clsWeapon("Deadly Dagger", 16, 19, {"Deadly", "Dagger", "weapon"})

    '///// End of Weapons Declarations \\\\\

    '///// Warrior Armor Declaration \\\\\
    Public squirePlate As New clsArmor("Plate armor of the Squire", {"Squire", "Plate", "Armor"})
    Public traineePlate As New clsArmor("Plate armor of the trainee", {"Trainee", "Plate", "Armor"})
    Public warriorPlate As New clsArmor("Plate armor of the Warrior", {"Warrior", "Plate", "Armor"})
    Public knightPlate As New clsArmor("Plate armor of the Knight", {"Knight", "Plate", "Armor"})
    Public wargodPlate As New clsArmor("Plate armor of the War God", {"Wargod", "Plate", "Armor"})

    '///// Mage Armor Declaration \\\\\
    Public apprenticeRobe As New clsArmor("Robes of the Apprentice", {"Apprentice", "Robe", "Armor"})
    Public studentRobe As New clsArmor("Robes of the Student", {"Student", "Robe", "Armor"})
    Public mageRobe As New clsArmor("Robes of the Mage", {"Mage", "Robe", "Armor"})
    Public masterRobe As New clsArmor("Robes of the Master", {"Master", "Robe", "Armor"})
    Public archmageRobe As New clsArmor("Robes of the Archmage", {"Archmage", "Robe", "Armor"})

    '///// Thief Armor Declaration \\\\\
    Public pickpocketCovers As New clsArmor("Covers of the pickpocket", {"Pickpocket", "Covers", "Armor"})
    Public thiefCovers As New clsArmor("Covers of the Thief", {"Thief", "Covers", "Armor"})
    Public rogueCovers As New clsArmor("Covers of the Rogue", {"Rogue", "Covers", "Armor"})
    Public shadowsCovers As New clsArmor("Covers of the Shadow", {"Shadows", "Covers", "Armor"})
    Public assassinCovers As New clsArmor("Covers of the Assassin", {"Assassin", "Covers", "Armor"})

    '///// End of Armor declaration \\\\\

    'Need to get the relative path for this one. At least get the path to the working directory and add from there.
    'Public directory as String = My.Application.Info.DirectoryPath
    Public directory As String = "C:\Users\Leroux\Documents\Visual Studio 2010\Projects\TFS_Root\Production\RPG_Project\Alpha Builds\RPG-Project.git\Source\Matrix Tile Practise\Textures\Items"

    Public Sub init()
        '///// Warrior Weapons Init \\\\\
        ironSword.description = "That is an iron sword"
        ironSword.iPicture = Image.FromFile(directory & "\sword_iron.png")



        squirePlate.description = "This is a plate armor of a squire"
        squirePlate.iPicture = Image.FromFile(directory & "\plate_squire.png")



    End Sub

    Public Sub New()
        init()
    End Sub


End Class
