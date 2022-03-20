<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 会员管理
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_注册时间 = New System.Windows.Forms.TextBox()
        Me.TextBox_用户名 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "返回页面"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 64)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "积分查询"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(205, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(276, 64)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "更改密码"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(205, 518)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(276, 64)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "退出账号"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "用户名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "注册时间"
        '
        'TextBox_注册时间
        '
        Me.TextBox_注册时间.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox_注册时间.Enabled = False
        Me.TextBox_注册时间.Location = New System.Drawing.Point(205, 126)
        Me.TextBox_注册时间.Name = "TextBox_注册时间"
        Me.TextBox_注册时间.ReadOnly = True
        Me.TextBox_注册时间.Size = New System.Drawing.Size(276, 38)
        Me.TextBox_注册时间.TabIndex = 5
        '
        'TextBox_用户名
        '
        Me.TextBox_用户名.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox_用户名.Enabled = False
        Me.TextBox_用户名.Location = New System.Drawing.Point(205, 48)
        Me.TextBox_用户名.Name = "TextBox_用户名"
        Me.TextBox_用户名.ReadOnly = True
        Me.TextBox_用户名.Size = New System.Drawing.Size(276, 38)
        Me.TextBox_用户名.TabIndex = 4
        '
        '会员管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 639)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_注册时间)
        Me.Controls.Add(Me.TextBox_用户名)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "会员管理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "会员管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_注册时间 As TextBox
    Friend WithEvents TextBox_用户名 As TextBox
End Class
