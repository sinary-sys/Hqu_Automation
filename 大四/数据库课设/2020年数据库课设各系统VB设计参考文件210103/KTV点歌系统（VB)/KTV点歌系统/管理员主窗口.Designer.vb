<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 管理员主窗口
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
        Me.管理歌曲ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理歌手ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会员信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会员个人信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会员点击信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会员搜索信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.后台日记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理员信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.管理歌曲ToolStripMenuItem, Me.管理歌手ToolStripMenuItem, Me.会员信息ToolStripMenuItem, Me.后台日记ToolStripMenuItem, Me.管理员信息ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '管理歌曲ToolStripMenuItem
        '
        Me.管理歌曲ToolStripMenuItem.Name = "管理歌曲ToolStripMenuItem"
        Me.管理歌曲ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.管理歌曲ToolStripMenuItem.Text = "管理歌曲"
        '
        '管理歌手ToolStripMenuItem
        '
        Me.管理歌手ToolStripMenuItem.Name = "管理歌手ToolStripMenuItem"
        Me.管理歌手ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.管理歌手ToolStripMenuItem.Text = "管理歌手"
        '
        '会员信息ToolStripMenuItem
        '
        Me.会员信息ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.会员个人信息ToolStripMenuItem, Me.会员点击信息ToolStripMenuItem, Me.会员搜索信息ToolStripMenuItem})
        Me.会员信息ToolStripMenuItem.Name = "会员信息ToolStripMenuItem"
        Me.会员信息ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.会员信息ToolStripMenuItem.Text = "会员信息"
        '
        '会员个人信息ToolStripMenuItem
        '
        Me.会员个人信息ToolStripMenuItem.Name = "会员个人信息ToolStripMenuItem"
        Me.会员个人信息ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.会员个人信息ToolStripMenuItem.Text = "会员个人信息"
        '
        '会员点击信息ToolStripMenuItem
        '
        Me.会员点击信息ToolStripMenuItem.Name = "会员点击信息ToolStripMenuItem"
        Me.会员点击信息ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.会员点击信息ToolStripMenuItem.Text = "会员点击信息"
        '
        '会员搜索信息ToolStripMenuItem
        '
        Me.会员搜索信息ToolStripMenuItem.Name = "会员搜索信息ToolStripMenuItem"
        Me.会员搜索信息ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.会员搜索信息ToolStripMenuItem.Text = "会员搜索信息"
        '
        '后台日记ToolStripMenuItem
        '
        Me.后台日记ToolStripMenuItem.Name = "后台日记ToolStripMenuItem"
        Me.后台日记ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.后台日记ToolStripMenuItem.Text = "后台日记"
        '
        '管理员信息ToolStripMenuItem
        '
        Me.管理员信息ToolStripMenuItem.Name = "管理员信息ToolStripMenuItem"
        Me.管理员信息ToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.管理员信息ToolStripMenuItem.Text = "管理员信息与操作信息"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(58, 28)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '管理员主窗口
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 637)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "管理员主窗口"
        Me.Text = "管理员主窗口"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 管理歌曲ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 管理歌手ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员个人信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员点击信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员搜索信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 后台日记ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 管理员信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
