<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.lblNewGame = New System.Windows.Forms.Label()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNewGame
        '
        Me.lblNewGame.AutoSize = True
        Me.lblNewGame.BackColor = System.Drawing.Color.Transparent
        Me.lblNewGame.Location = New System.Drawing.Point(27, 25)
        Me.lblNewGame.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.lblNewGame.Name = "lblNewGame"
        Me.lblNewGame.Size = New System.Drawing.Size(236, 51)
        Me.lblNewGame.TabIndex = 0
        Me.lblNewGame.Text = "New Game"
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.BackColor = System.Drawing.Color.Transparent
        Me.lblLoad.Location = New System.Drawing.Point(77, 113)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(118, 51)
        Me.lblLoad.TabIndex = 1
        Me.lblLoad.Text = "Load"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Location = New System.Drawing.Point(35, 201)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(214, 51)
        Me.lblExit.TabIndex = 2
        Me.lblExit.Text = "Exit game"
        Me.lblExit.UseWaitCursor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(25.0!, 51.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Matrix_Tile_Practise.My.Resources.Resources.WoodPlank_menu
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.lblNewGame)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(12)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 500)
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNewGame As System.Windows.Forms.Label
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
End Class
