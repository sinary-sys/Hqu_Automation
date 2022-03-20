Public Class 管理员主窗口

    Private Sub 管理歌曲ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理歌曲ToolStripMenuItem.Click
        Me.Hide()

        歌曲管理.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Close()
        登入界面.Show()
    End Sub

    Private Sub 后台日记ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 后台日记ToolStripMenuItem.Click
        Close()
        后台日记.Show()
    End Sub
End Class