<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaracter_and_Equipement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeroName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.eqpHands = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpNecklace = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpOffHand = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpHead = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpMainHand = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpLegs = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpChest = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpRing2 = New Matrix_Tile_Practise.Equip_Slot()
        Me.eqpRing1 = New Matrix_Tile_Practise.Equip_Slot()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.eqpHands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpNecklace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpOffHand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpMainHand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpLegs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpChest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpRing2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eqpRing1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeroName
        '
        Me.lblHeroName.AutoSize = True
        Me.lblHeroName.Font = New System.Drawing.Font("Angelic War", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroName.Location = New System.Drawing.Point(133, 9)
        Me.lblHeroName.Name = "lblHeroName"
        Me.lblHeroName.Size = New System.Drawing.Size(304, 64)
        Me.lblHeroName.TabIndex = 0
        Me.lblHeroName.Text = "<Hero Name>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.eqpHands)
        Me.GroupBox1.Controls.Add(Me.eqpNecklace)
        Me.GroupBox1.Controls.Add(Me.eqpOffHand)
        Me.GroupBox1.Controls.Add(Me.eqpHead)
        Me.GroupBox1.Controls.Add(Me.eqpMainHand)
        Me.GroupBox1.Controls.Add(Me.eqpLegs)
        Me.GroupBox1.Controls.Add(Me.eqpChest)
        Me.GroupBox1.Controls.Add(Me.eqpRing2)
        Me.GroupBox1.Controls.Add(Me.eqpRing1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 334)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipment"
        '
        'eqpHands
        '
        Me.eqpHands.Location = New System.Drawing.Point(40, 103)
        Me.eqpHands.Name = "eqpHands"
        Me.eqpHands.Size = New System.Drawing.Size(64, 64)
        Me.eqpHands.TabIndex = 8
        Me.eqpHands.TabStop = False
        '
        'eqpNecklace
        '
        Me.eqpNecklace.Location = New System.Drawing.Point(180, 33)
        Me.eqpNecklace.Name = "eqpNecklace"
        Me.eqpNecklace.Size = New System.Drawing.Size(64, 64)
        Me.eqpNecklace.TabIndex = 7
        Me.eqpNecklace.TabStop = False
        '
        'eqpOffHand
        '
        Me.eqpOffHand.Location = New System.Drawing.Point(76, 264)
        Me.eqpOffHand.Name = "eqpOffHand"
        Me.eqpOffHand.Size = New System.Drawing.Size(64, 64)
        Me.eqpOffHand.TabIndex = 6
        Me.eqpOffHand.TabStop = False
        '
        'eqpHead
        '
        Me.eqpHead.Location = New System.Drawing.Point(110, 33)
        Me.eqpHead.Name = "eqpHead"
        Me.eqpHead.Size = New System.Drawing.Size(64, 64)
        Me.eqpHead.TabIndex = 5
        Me.eqpHead.TabStop = False
        '
        'eqpMainHand
        '
        Me.eqpMainHand.Location = New System.Drawing.Point(6, 264)
        Me.eqpMainHand.Name = "eqpMainHand"
        Me.eqpMainHand.Size = New System.Drawing.Size(64, 64)
        Me.eqpMainHand.TabIndex = 4
        Me.eqpMainHand.TabStop = False
        '
        'eqpLegs
        '
        Me.eqpLegs.Location = New System.Drawing.Point(110, 173)
        Me.eqpLegs.Name = "eqpLegs"
        Me.eqpLegs.Size = New System.Drawing.Size(64, 64)
        Me.eqpLegs.TabIndex = 3
        Me.eqpLegs.TabStop = False
        '
        'eqpChest
        '
        Me.eqpChest.Location = New System.Drawing.Point(110, 103)
        Me.eqpChest.Name = "eqpChest"
        Me.eqpChest.Size = New System.Drawing.Size(64, 64)
        Me.eqpChest.TabIndex = 2
        Me.eqpChest.TabStop = False
        '
        'eqpRing2
        '
        Me.eqpRing2.Location = New System.Drawing.Point(265, 103)
        Me.eqpRing2.Name = "eqpRing2"
        Me.eqpRing2.Size = New System.Drawing.Size(64, 64)
        Me.eqpRing2.TabIndex = 1
        Me.eqpRing2.TabStop = False
        '
        'eqpRing1
        '
        Me.eqpRing1.Location = New System.Drawing.Point(195, 103)
        Me.eqpRing1.Name = "eqpRing1"
        Me.eqpRing1.Size = New System.Drawing.Size(64, 64)
        Me.eqpRing1.TabIndex = 0
        Me.eqpRing1.TabStop = False
        '
        'pnlInventory
        '
        Me.pnlInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInventory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInventory.Location = New System.Drawing.Point(0, 416)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(584, 146)
        Me.pnlInventory.TabIndex = 2
        '
        'grpInfo
        '
        Me.grpInfo.Location = New System.Drawing.Point(353, 263)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(219, 147)
        Me.grpInfo.TabIndex = 3
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Item Info"
        '
        'grpStats
        '
        Me.grpStats.Location = New System.Drawing.Point(353, 76)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(219, 181)
        Me.grpStats.TabIndex = 4
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "Hero Stats"
        '
        'frmCaracter_and_Equipement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblHeroName)
        Me.Name = "frmCaracter_and_Equipement"
        Me.Text = "Caracter Screen"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.eqpHands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpNecklace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpOffHand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpMainHand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpLegs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpChest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpRing2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eqpRing1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeroName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlInventory As System.Windows.Forms.Panel
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpStats As System.Windows.Forms.GroupBox
    Friend WithEvents eqpRing1 As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpHands As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpNecklace As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpOffHand As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpHead As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpMainHand As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpLegs As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpChest As Matrix_Tile_Practise.Equip_Slot
    Friend WithEvents eqpRing2 As Matrix_Tile_Practise.Equip_Slot
End Class
