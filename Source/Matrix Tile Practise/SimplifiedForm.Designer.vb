<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimplifiedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimplifiedForm))
        Me.ctrMessageBar = New MessageBar_Console.ctrMessageBar()
        Me.stripInfoBar = New System.Windows.Forms.StatusStrip()
        Me.stripCaracter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripMap = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMainMenu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stripInfoBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctrMessageBar
        '
        Me.ctrMessageBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ctrMessageBar.Location = New System.Drawing.Point(0, 534)
        Me.ctrMessageBar.Name = "ctrMessageBar"
        Me.ctrMessageBar.Size = New System.Drawing.Size(509, 50)
        Me.ctrMessageBar.TabIndex = 0
        '
        'stripInfoBar
        '
        Me.stripInfoBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripCaracter, Me.stripMap, Me.stripMainMenu})
        Me.stripInfoBar.Location = New System.Drawing.Point(0, 512)
        Me.stripInfoBar.Name = "stripInfoBar"
        Me.stripInfoBar.Size = New System.Drawing.Size(509, 22)
        Me.stripInfoBar.SizingGrip = False
        Me.stripInfoBar.TabIndex = 1
        '
        'stripCaracter
        '
        Me.stripCaracter.Name = "stripCaracter"
        Me.stripCaracter.Size = New System.Drawing.Size(51, 17)
        Me.stripCaracter.Text = "Caracter"
        '
        'stripMap
        '
        Me.stripMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stripMap.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GlobalToolStripMenuItem, Me.LocalToolStripMenuItem})
        Me.stripMap.Image = CType(resources.GetObject("stripMap.Image"), System.Drawing.Image)
        Me.stripMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stripMap.Name = "stripMap"
        Me.stripMap.Size = New System.Drawing.Size(44, 20)
        Me.stripMap.Text = "Map"
        '
        'GlobalToolStripMenuItem
        '
        Me.GlobalToolStripMenuItem.Name = "GlobalToolStripMenuItem"
        Me.GlobalToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.GlobalToolStripMenuItem.Text = "Global"
        '
        'LocalToolStripMenuItem
        '
        Me.LocalToolStripMenuItem.Name = "LocalToolStripMenuItem"
        Me.LocalToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.LocalToolStripMenuItem.Text = "Local"
        '
        'stripMainMenu
        '
        Me.stripMainMenu.Name = "stripMainMenu"
        Me.stripMainMenu.Size = New System.Drawing.Size(68, 17)
        Me.stripMainMenu.Text = "Main Menu"
        '
        'frmSimplifiedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 584)
        Me.Controls.Add(Me.stripInfoBar)
        Me.Controls.Add(Me.ctrMessageBar)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(525, 622)
        Me.MinimumSize = New System.Drawing.Size(525, 622)
        Me.Name = "frmSimplifiedForm"
        Me.Text = "SimplifiedForm"
        Me.stripInfoBar.ResumeLayout(False)
        Me.stripInfoBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctrMessageBar As MessageBar_Console.ctrMessageBar
    Friend WithEvents stripInfoBar As System.Windows.Forms.StatusStrip
    Friend WithEvents stripMap As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GlobalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stripMainMenu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stripCaracter As System.Windows.Forms.ToolStripStatusLabel
End Class
