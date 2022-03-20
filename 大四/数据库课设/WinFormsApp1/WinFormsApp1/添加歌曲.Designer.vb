<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 歌曲管理
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.歌曲表 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.歌曲编号 = New System.Windows.Forms.TextBox()
        Me.名称 = New System.Windows.Forms.TextBox()
        Me.语种 = New System.Windows.Forms.TextBox()
        Me.歌手编号 = New System.Windows.Forms.TextBox()
        Me.地区 = New System.Windows.Forms.TextBox()
        Me.歌曲拼写 = New System.Windows.Forms.TextBox()
        Me.文件路径 = New System.Windows.Forms.TextBox()
        Me.歌曲类型 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.歌手姓名 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.歌曲表, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '歌曲表
        '
        Me.歌曲表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.歌曲表.Location = New System.Drawing.Point(355, 41)
        Me.歌曲表.Name = "歌曲表"
        Me.歌曲表.RowHeadersWidth = 82
        Me.歌曲表.RowTemplate.Height = 40
        Me.歌曲表.Size = New System.Drawing.Size(957, 586)
        Me.歌曲表.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 687)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 78)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(651, 687)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 78)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "删除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1106, 687)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(206, 78)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        '歌曲编号
        '
        Me.歌曲编号.Location = New System.Drawing.Point(132, 41)
        Me.歌曲编号.Name = "歌曲编号"
        Me.歌曲编号.Size = New System.Drawing.Size(187, 38)
        Me.歌曲编号.TabIndex = 4
        '
        '名称
        '
        Me.名称.Location = New System.Drawing.Point(132, 115)
        Me.名称.Name = "名称"
        Me.名称.Size = New System.Drawing.Size(187, 38)
        Me.名称.TabIndex = 5
        '
        '语种
        '
        Me.语种.Location = New System.Drawing.Point(132, 306)
        Me.语种.Name = "语种"
        Me.语种.Size = New System.Drawing.Size(187, 38)
        Me.语种.TabIndex = 7
        '
        '歌手编号
        '
        Me.歌手编号.Location = New System.Drawing.Point(132, 180)
        Me.歌手编号.Name = "歌手编号"
        Me.歌手编号.Size = New System.Drawing.Size(187, 38)
        Me.歌手编号.TabIndex = 6
        '
        '地区
        '
        Me.地区.Location = New System.Drawing.Point(132, 592)
        Me.地区.Name = "地区"
        Me.地区.Size = New System.Drawing.Size(187, 38)
        Me.地区.TabIndex = 11
        '
        '歌曲拼写
        '
        Me.歌曲拼写.Location = New System.Drawing.Point(132, 518)
        Me.歌曲拼写.Name = "歌曲拼写"
        Me.歌曲拼写.Size = New System.Drawing.Size(187, 38)
        Me.歌曲拼写.TabIndex = 10
        '
        '文件路径
        '
        Me.文件路径.Location = New System.Drawing.Point(132, 442)
        Me.文件路径.Name = "文件路径"
        Me.文件路径.Size = New System.Drawing.Size(187, 38)
        Me.文件路径.TabIndex = 9
        '
        '歌曲类型
        '
        Me.歌曲类型.Location = New System.Drawing.Point(132, 375)
        Me.歌曲类型.Name = "歌曲类型"
        Me.歌曲类型.Size = New System.Drawing.Size(187, 38)
        Me.歌曲类型.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "歌曲编号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "名称"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "歌手编号"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 31)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "语种"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "歌曲类型"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 31)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "文件路径"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 521)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 31)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "歌曲拼写"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 595)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "地区"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(113, 687)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(206, 78)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "刷新"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 31)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "歌手姓名"
        '
        '歌手姓名
        '
        Me.歌手姓名.Location = New System.Drawing.Point(132, 242)
        Me.歌手姓名.Name = "歌手姓名"
        Me.歌手姓名.Size = New System.Drawing.Size(187, 38)
        Me.歌手姓名.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(880, 687)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(206, 78)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "修改"
        Me.Button5.UseVisualStyleBackColor = True
        '
        '歌曲管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 811)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.歌手姓名)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.地区)
        Me.Controls.Add(Me.歌曲拼写)
        Me.Controls.Add(Me.文件路径)
        Me.Controls.Add(Me.歌曲类型)
        Me.Controls.Add(Me.语种)
        Me.Controls.Add(Me.歌手编号)
        Me.Controls.Add(Me.名称)
        Me.Controls.Add(Me.歌曲编号)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.歌曲表)
        Me.Name = "歌曲管理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "歌曲管理"
        CType(Me.歌曲表, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 歌曲表 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents 歌曲编号 As TextBox
    Friend WithEvents 名称 As TextBox
    Friend WithEvents 语种 As TextBox
    Friend WithEvents 歌手编号 As TextBox
    Friend WithEvents 地区 As TextBox
    Friend WithEvents 歌曲拼写 As TextBox
    Friend WithEvents 文件路径 As TextBox
    Friend WithEvents 歌曲类型 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents 歌手姓名 As TextBox
    Friend WithEvents Button5 As Button
End Class
