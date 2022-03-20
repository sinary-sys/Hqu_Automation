<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 主登录界面
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox用户名 = New System.Windows.Forms.TextBox()
        Me.TextBox密码 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "密码"
        '
        'TextBox用户名
        '
        Me.TextBox用户名.Location = New System.Drawing.Point(208, 88)
        Me.TextBox用户名.Name = "TextBox用户名"
        Me.TextBox用户名.Size = New System.Drawing.Size(148, 21)
        Me.TextBox用户名.TabIndex = 2
        '
        'TextBox密码
        '
        Me.TextBox密码.Location = New System.Drawing.Point(208, 132)
        Me.TextBox密码.Name = "TextBox密码"
        Me.TextBox密码.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox密码.Size = New System.Drawing.Size(148, 21)
        Me.TextBox密码.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "登录"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "退出"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '主登录界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 360)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox密码)
        Me.Controls.Add(Me.TextBox用户名)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "主登录界面"
        Me.Text = "用户登陆"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox用户名 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox密码 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
