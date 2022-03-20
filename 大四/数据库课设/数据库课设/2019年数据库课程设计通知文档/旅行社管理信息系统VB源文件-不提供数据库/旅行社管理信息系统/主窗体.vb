
Public Class 主窗体
   

    Private Sub 主窗体_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If qx = 2 Then

            团员信息维护ToolStripMenuItem.Visible = False
            旅行团信息维护ToolStripMenuItem.Visible = False
            旅行路线信息维护ToolStripMenuItem.Visible = False

        End If

    End Sub

    
    Private Sub 公司简介ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 公司简介ToolStripMenuItem.Click
        公司简介.Show()
    End Sub

    Private Sub 社长致辞ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 社长致辞ToolStripMenuItem.Click
        社长致辞.Show()
    End Sub

    Private Sub 团员信息维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 团员信息维护ToolStripMenuItem.Click
        团员信息维护.Show()
    End Sub

    Private Sub 团员信息查询ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 团员信息查询ToolStripMenuItem1.Click
        团员信息查询.Show()
    End Sub

    Private Sub 团员信息报表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 团员信息报表ToolStripMenuItem.Click
        团员信息报表.Show()
    End Sub

    Private Sub 修改密码ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 修改密码ToolStripMenuItem.Click
        修改密码.Show()
    End Sub

    Private Sub 旅行团信息维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 旅行团信息维护ToolStripMenuItem.Click
        旅行团信息维护.Show()
    End Sub

    Private Sub 旅行团信息查询ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 旅行团信息查询ToolStripMenuItem.Click
        旅行团信息查询.Show()
    End Sub

    Private Sub 旅行团ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 旅行团ToolStripMenuItem.Click
        旅行团信息报表.Show()
    End Sub

    Private Sub 出游信息查询ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 出游信息查询ToolStripMenuItem.Click
        出游信息查询.Show()
    End Sub

    Private Sub 旅行路线ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 旅行路线ToolStripMenuItem.Click
        旅行路线查询.Show()
    End Sub

    Private Sub 路线排行榜ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 路线排行榜ToolStripMenuItem.Click
        旅行路线排行榜.Show()
    End Sub

    Private Sub 旅行路线信息维护ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 旅行路线信息维护ToolStripMenuItem.Click
        旅行路线信息维护.Show()
    End Sub
End Class