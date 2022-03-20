Public Class 用户主窗口

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub 歌手性别点歌ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 歌手性别点歌ToolStripMenuItem.Click
        Me.Hide()
        歌手性别点歌.Show()
    End Sub

    Private Sub 歌星点歌ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 歌星点歌ToolStripMenuItem.Click
        Me.Hide()
        歌星点歌.Show()
    End Sub

    Private Sub 公司致辞ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 公司致辞ToolStripMenuItem.Click
        Me.Hide()
        公司致辞.Show()
    End Sub

    Private Sub KTV介绍ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KTV介绍ToolStripMenuItem.Click
        KTV介绍.Show()
    End Sub

   
    Private Sub 数字点歌ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 数字点歌ToolStripMenuItem.Click
        Me.Hide()
        歌曲编号点歌.Show()
    End Sub

    Private Sub 拼音点歌ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 拼音点歌ToolStripMenuItem.Click
        拼音点歌.Show()
    End Sub

    Private Sub 歌名点歌ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 歌名点歌ToolStripMenuItem.Click

        歌名点歌.Show()
    End Sub

    Private Sub 语种点歌ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 语种点歌ToolStripMenuItem.Click
        Me.Hide()
        语种点歌.Show()
    End Sub

    Private Sub 总点击排行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 总点击排行ToolStripMenuItem.Click
        Me.Hide()
        点击榜.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Close()
        登入界面.Show()
    End Sub

    Private Sub 呼叫服务员ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 呼叫服务员ToolStripMenuItem.Click
        MsgBox("已呼叫服务员，请稍后")
    End Sub

    Private Sub 修改个人信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改个人信息ToolStripMenuItem.Click
        修改个人信息.Show()
    End Sub

    Private Sub 已点歌曲ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 已点歌曲ToolStripMenuItem.Click
        已点歌曲.Show()
    End Sub
End Class