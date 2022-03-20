<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 修改密码
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
        Me.TextBox用户名 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox旧密码 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox新密码 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户名"
        '
        'TextBox用户名
        '
        Me.TextBox用户名.Location = New System.Drawing.Point(256, 62)
        Me.TextBox用户名.Name = "TextBox用户名"
        Me.TextBox用户名.Size = New System.Drawing.Size(100, 21)
        Me.TextBox用户名.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "旧密码"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "确认"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox旧密码
        '
        Me.TextBox旧密码.Location = New System.Drawing.Point(256, 94)
        Me.TextBox旧密码.Name = "TextBox旧密码"
        Me.TextBox旧密码.Size = New System.Drawing.Size(100, 21)
        Me.TextBox旧密码.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "新密码"
        '
        'TextBox新密码
        '
        Me.TextBox新密码.Location = New System.Drawing.Point(256, 125)
        Me.TextBox新密码.Name = "TextBox新密码"
        Me.TextBox新密码.Size = New System.Drawing.Size(100, 21)
        Me.TextBox新密码.TabIndex = 6
        '
        '修改密码
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 369)
        Me.Controls.Add(Me.TextBox新密码)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox旧密码)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox用户名)
        Me.Controls.Add(Me.Label1)
        Me.Name = "修改密码"
        Me.Text = "修改密码"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox用户名 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox旧密码 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox新密码 As System.Windows.Forms.TextBox
End Class
