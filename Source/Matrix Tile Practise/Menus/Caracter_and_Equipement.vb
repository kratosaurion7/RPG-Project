Public Class frmCaracter_and_Equipement

    Dim characterSheet As clsPlayer

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

    Public Sub New(ByRef sheet As clsPlayer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        characterSheet = sheet 'Give the form the date it needs to show information on the character. Also needed to modify its equipement.
    End Sub
End Class