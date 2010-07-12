Public Class clsItemData

#Region "Weapon Declaration"
    'Definition: (Name, minDmg, maxDmg, {Tags:<Quality>,<Type>,<Slot>})

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
#End Region
#Region "Armor Declaration"
    'Definition: (Name,{Tags:<Quality>,<Type>,<Slot>})

    '///// Warrior Armor Declaration \\\\\
    Public squirePlate As New clsArmor("Plate armor of the Squire", {"Squire", "Plate", "Chest"})
    Public traineePlate As New clsArmor("Plate armor of the trainee", {"Trainee", "Plate", "Chest"})
    Public warriorPlate As New clsArmor("Plate armor of the Warrior", {"Warrior", "Plate", "Chest"})
    Public knightPlate As New clsArmor("Plate armor of the Knight", {"Knight", "Plate", "Chest"})
    Public wargodPlate As New clsArmor("Plate armor of the War God", {"Wargod", "Plate", "Chest"})

    '///// Mage Armor Declaration \\\\\
    Public apprenticeRobe As New clsArmor("Robes of the Apprentice", {"Apprentice", "Robe", "Chest"})
    Public studentRobe As New clsArmor("Robes of the Student", {"Student", "Robe", "Chest"})
    Public mageRobe As New clsArmor("Robes of the Mage", {"Mage", "Robe", "Chest"})
    Public masterRobe As New clsArmor("Robes of the Master", {"Master", "Robe", "Chest"})
    Public archmageRobe As New clsArmor("Robes of the Archmage", {"Archmage", "Robe", "Chest"})

    '///// Thief Armor Declaration \\\\\
    Public pickpocketCovers As New clsArmor("Covers of the pickpocket", {"Pickpocket", "Covers", "Chest"})
    Public thiefCovers As New clsArmor("Covers of the Thief", {"Thief", "Covers", "Chest"})
    Public rogueCovers As New clsArmor("Covers of the Rogue", {"Rogue", "Covers", "Chest"})
    Public shadowsCovers As New clsArmor("Covers of the Shadow", {"Shadows", "Covers", "Chest"})
    Public assassinCovers As New clsArmor("Covers of the Assassin", {"Assassin", "Covers", "Chest"})
#End Region

    'Need to get the relative path for this one. At least get the path to the working directory and add from there.
    'Public directory as String = My.Application.Info.DirectoryPath
    Public directory As String = "C:\Users\Leroux\Documents\Visual Studio 2010\Projects\TFS_Root\Production\RPG_Project\Alpha Builds\RPG-Project.git\Source\Matrix Tile Practise\Textures\Items"

    Public Sub init()
        '///// Warrior Weapons Init \\\\\
        ironSword.description = "A simple iron sword. This sword has seen better days."
        ironSword.iPicture = Image.FromFile(directory & "\sword_iron.png")

        steelSword.description = "A sword made of solid steel."
        steelSword.iPicture = Image.FromFile(directory & "\sword_steel.png")

        bronzeSword.description = "This bronze sword can slash through an ox !"
        bronzeSword.iPicture = Image.FromFile(directory & "\sword_bronze.png")

        silverSword.description = "This magnificent sword is made of pure silver."
        silverSword.iPicture = Image.FromFile(directory & "\sword_silver.png")

        goldSword.description = "The dream of every warrior, a gold tempered sword."
        goldSword.iPicture = Image.FromFile(directory & "\sword_gold.png")

        '///// Mage Weapon Init \\\\\
        splinteredStaff.description = "This splintered staff, served more than one mage before."
        splinteredStaff.iPicture = Image.FromFile(directory & "\staff_splintered.png")

        woodenStaff.description = "This staff was made of good strong wood."
        woodenStaff.iPicture = Image.FromFile(directory & "\staff_wooden.png")

        hardyStaff.description = "A hardy staff, it's got a lot of blunt power."
        hardyStaff.iPicture = Image.FromFile(directory & "\staff_hardy.png")

        magicalStaff.description = "You can feel the magical pulse of this staff."
        magicalStaff.iPicture = Image.FromFile(directory & "\staff_magical.png")

        legendaryStaff.description = "This legendary staff was the key factor in a number of battles."
        legendaryStaff.iPicture = Image.FromFile(directory & "\staff_legendary.png")

        '///// Thief Weapon Init \\\\\
        cheapDagger.description = "This is a dagger bought on the cheap. Not very useful."
        cheapDagger.iPicture = Image.FromFile(directory & "\dagger_cheap.png")

        handyDagger.description = "A handy little dagger."
        handyDagger.iPicture = Image.FromFile(directory & "\dagger_handy.png")




        squirePlate.description = "This is a plate armor of a squire"
        squirePlate.iPicture = Image.FromFile(directory & "\plate_squire.png")



    End Sub

    Public Sub New()
        init()
    End Sub


End Class
