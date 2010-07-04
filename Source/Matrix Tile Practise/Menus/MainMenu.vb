Public Class frmMainMenu

    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub lblLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLoad.Click
        MessageBox.Show("Not yet implemented")
    End Sub

    Private Sub lblNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNewGame.Click
        Dim gameForm As New frmSimplifiedForm
        gameForm.Show()
        Me.Hide()
    End Sub
End Class