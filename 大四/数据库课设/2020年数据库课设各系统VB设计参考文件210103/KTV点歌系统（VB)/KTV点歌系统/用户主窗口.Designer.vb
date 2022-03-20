<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 用户主窗口
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.首页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KTV介绍ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.公司致辞ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.歌星点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数字点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.拼音点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.歌名点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.歌手性别点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.语种点歌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.点击排行榜ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.总点击排行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.已点歌曲ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.我的收藏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.呼叫服务员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改个人信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.首页ToolStripMenuItem, Me.点歌ToolStripMenuItem, Me.点击排行榜ToolStripMenuItem, Me.已点歌曲ToolStripMenuItem, Me.我的收藏ToolStripMenuItem, Me.呼叫服务员ToolStripMenuItem, Me.修改个人信息ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '首页ToolStripMenuItem
        '
        Me.首页ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KTV介绍ToolStripMenuItem, Me.公司致辞ToolStripMenuItem})
        Me.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem"
        Me.首页ToolStripMenuItem.Size = New System.Drawing.Size(58, 28)
        Me.首页ToolStripMenuItem.Text = "首页"
        '
        'KTV介绍ToolStripMenuItem
        '
        Me.KTV介绍ToolStripMenuItem.Name = "KTV介绍ToolStripMenuItem"
        Me.KTV介绍ToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.KTV介绍ToolStripMenuItem.Text = "KTV介绍"
        '
        '公司致辞ToolStripMenuItem
        '
        Me.公司致辞ToolStripMenuItem.Name = "公司致辞ToolStripMenuItem"
        Me.公司致辞ToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.公司致辞ToolStripMenuItem.Text = "公司致辞"
        '
        '点歌ToolStripMenuItem
        '
        Me.点歌ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.歌星点歌ToolStripMenuItem, Me.数字点歌ToolStripMenuItem, Me.拼音点歌ToolStripMenuItem, Me.歌名点歌ToolStripMenuItem, Me.歌手性别点歌ToolStripMenuItem, Me.语种点歌ToolStripMenuItem})
        Me.点歌ToolStripMenuItem.Name = "点歌ToolStripMenuItem"
        Me.点歌ToolStripMenuItem.Size = New System.Drawing.Size(58, 28)
        Me.点歌ToolStripMenuItem.Text = "点歌"
        '
        '歌星点歌ToolStripMenuItem
        '
        Me.歌星点歌ToolStripMenuItem.Name = "歌星点歌ToolStripMenuItem"
        Me.歌星点歌ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.歌星点歌ToolStripMenuItem.Text = "歌星"
        '
        '数字点歌ToolStripMenuItem
        '
        Me.数字点歌ToolStripMenuItem.Name = "数字点歌ToolStripMenuItem"
        Me.数字点歌ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.数字点歌ToolStripMenuItem.Text = "歌曲编号"
        '
        '拼音点歌ToolStripMenuItem
        '
        Me.拼音点歌ToolStripMenuItem.Name = "拼音点歌ToolStripMenuItem"
        Me.拼音点歌ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.拼音点歌ToolStripMenuItem.Text = "拼音"
        '
        '歌名点歌ToolStripMenuItem
        '
        Me.歌名点歌ToolStripMenuItem.Name = "歌名点歌ToolStripMenuItem"
        Me.歌名点歌ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.歌名点歌ToolStripMenuItem.Text = "歌名"
        '
        '歌手性别点歌ToolStripMenuItem
        '
        Me.歌手性别点歌ToolStripMenuItem.Name = "歌手性别点歌ToolStripMenuItem"
        Me.歌手性别点歌ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.歌手性别点歌ToolStripMenuItem.Text = "性别"
        '
        '语种点歌ToolStripMenuItem
        '
        Me.语种点歌ToolStripMenuItem.Name = "语种点歌ToolStripMenuItem"
        Me.语种点歌ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.语种点歌ToolStripMenuItem.Text = "语种"
        '
        '点击排行榜ToolStripMenuItem
        '
        Me.点击排行榜ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.总点击排行ToolStripMenuItem})
        Me.点击排行榜ToolStripMenuItem.Name = "点击排行榜ToolStripMenuItem"
        Me.点击排行榜ToolStripMenuItem.Size = New System.Drawing.Size(76, 28)
        Me.点击排行榜ToolStripMenuItem.Text = "排行榜"
        '
        '总点击排行ToolStripMenuItem
        '
        Me.总点击排行ToolStripMenuItem.Name = "总点击排行ToolStripMenuItem"
        Me.总点击排行ToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.总点击排行ToolStripMenuItem.Text = "点击排行"
        '
        '已点歌曲ToolStripMenuItem
        '
        Me.已点歌曲ToolStripMenuItem.Name = "已点歌曲ToolStripMenuItem"
        Me.已点歌曲ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.已点歌曲ToolStripMenuItem.Text = "已点歌曲"
        '
        '我的收藏ToolStripMenuItem
        '
        Me.我的收藏ToolStripMenuItem.Name = "我的收藏ToolStripMenuItem"
        Me.我的收藏ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.我的收藏ToolStripMenuItem.Text = "我的收藏"
        '
        '呼叫服务员ToolStripMenuItem
        '
        Me.呼叫服务员ToolStripMenuItem.Name = "呼叫服务员ToolStripMenuItem"
        Me.呼叫服务员ToolStripMenuItem.Size = New System.Drawing.Size(112, 28)
        Me.呼叫服务员ToolStripMenuItem.Text = "呼叫服务员"
        '
        '修改个人信息ToolStripMenuItem
        '
        Me.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem"
        Me.修改个人信息ToolStripMenuItem.Size = New System.Drawing.Size(130, 28)
        Me.修改个人信息ToolStripMenuItem.Text = "修改个人信息"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(58, 28)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '用户主窗口
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 637)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "用户主窗口"
        Me.Text = "主窗口"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 歌星点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 数字点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 拼音点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 歌名点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 歌手性别点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 语种点歌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 点击排行榜ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 首页ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KTV介绍ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 公司致辞ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 总点击排行ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 呼叫服务员ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改个人信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 已点歌曲ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 我的收藏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
