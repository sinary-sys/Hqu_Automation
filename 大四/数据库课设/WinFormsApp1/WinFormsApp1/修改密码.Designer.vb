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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(修改密码))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_用户名 = New System.Windows.Forms.TextBox()
        Me.TextBox_旧密码 = New System.Windows.Forms.TextBox()
        Me.TextBox_新密码 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("华文琥珀", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(264, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "密码修改"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(165, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "用户名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(165, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "旧密码"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(165, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "新密码"
        '
        'TextBox_用户名
        '
        Me.TextBox_用户名.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_用户名.Location = New System.Drawing.Point(339, 226)
        Me.TextBox_用户名.Name = "TextBox_用户名"
        Me.TextBox_用户名.Size = New System.Drawing.Size(262, 54)
        Me.TextBox_用户名.TabIndex = 4
        '
        'TextBox_旧密码
        '
        Me.TextBox_旧密码.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_旧密码.Location = New System.Drawing.Point(339, 330)
        Me.TextBox_旧密码.Name = "TextBox_旧密码"
        Me.TextBox_旧密码.Size = New System.Drawing.Size(262, 54)
        Me.TextBox_旧密码.TabIndex = 5
        '
        'TextBox_新密码
        '
        Me.TextBox_新密码.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_新密码.Location = New System.Drawing.Point(339, 433)
        Me.TextBox_新密码.Name = "TextBox_新密码"
        Me.TextBox_新密码.Size = New System.Drawing.Size(262, 54)
        Me.TextBox_新密码.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 78)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "确认修改"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(470, 569)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 78)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "关闭"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '修改密码
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 741)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_新密码)
        Me.Controls.Add(Me.TextBox_旧密码)
        Me.Controls.Add(Me.TextBox_用户名)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "修改密码"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "密码修改"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_用户名 As TextBox
    Friend WithEvents TextBox_旧密码 As TextBox
    Friend WithEvents TextBox_新密码 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
