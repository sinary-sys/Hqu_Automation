<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 旅行团信息维护
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox团队编号 = New System.Windows.Forms.TextBox()
        Me.TextBox联系人 = New System.Windows.Forms.TextBox()
        Me.TextBox团员人数 = New System.Windows.Forms.TextBox()
        Me.TextBox公司名称 = New System.Windows.Forms.TextBox()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "团队编号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "联系人"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "团员人数"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "公司名称"
        '
        'TextBox团队编号
        '
        Me.TextBox团队编号.Location = New System.Drawing.Point(214, 82)
        Me.TextBox团队编号.Name = "TextBox团队编号"
        Me.TextBox团队编号.Size = New System.Drawing.Size(100, 21)
        Me.TextBox团队编号.TabIndex = 4
        '
        'TextBox联系人
        '
        Me.TextBox联系人.Location = New System.Drawing.Point(214, 118)
        Me.TextBox联系人.Name = "TextBox联系人"
        Me.TextBox联系人.Size = New System.Drawing.Size(100, 21)
        Me.TextBox联系人.TabIndex = 5
        '
        'TextBox团员人数
        '
        Me.TextBox团员人数.Location = New System.Drawing.Point(214, 153)
        Me.TextBox团员人数.Name = "TextBox团员人数"
        Me.TextBox团员人数.Size = New System.Drawing.Size(100, 21)
        Me.TextBox团员人数.TabIndex = 6
        '
        'TextBox公司名称
        '
        Me.TextBox公司名称.Location = New System.Drawing.Point(214, 185)
        Me.TextBox公司名称.Name = "TextBox公司名称"
        Me.TextBox公司名称.Size = New System.Drawing.Size(100, 21)
        Me.TextBox公司名称.TabIndex = 7
        '
        'ButtonFirst
        '
        Me.ButtonFirst.Location = New System.Drawing.Point(76, 254)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(98, 47)
        Me.ButtonFirst.TabIndex = 16
        Me.ButtonFirst.Text = "第一条"
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(190, 254)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(89, 47)
        Me.ButtonUp.TabIndex = 17
        Me.ButtonUp.Text = "上一条"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(297, 254)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(96, 47)
        Me.ButtonDown.TabIndex = 18
        Me.ButtonDown.Text = "下一条"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.Location = New System.Drawing.Point(411, 254)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(89, 47)
        Me.ButtonLast.TabIndex = 19
        Me.ButtonLast.Text = "最后一条"
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(547, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 39)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(547, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 38)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "删除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(547, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 39)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "更新"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(547, 254)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 36)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "确认"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(547, 311)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 36)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "取消"
        Me.Button5.UseVisualStyleBackColor = True
        '
        '旅行团信息维护
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 448)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonDown)
        Me.Controls.Add(Me.ButtonUp)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.TextBox公司名称)
        Me.Controls.Add(Me.TextBox团员人数)
        Me.Controls.Add(Me.TextBox联系人)
        Me.Controls.Add(Me.TextBox团队编号)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "旅行团信息维护"
        Me.Text = "旅行团信息维护"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox团队编号 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox联系人 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox团员人数 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox公司名称 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents ButtonUp As System.Windows.Forms.Button
    Friend WithEvents ButtonDown As System.Windows.Forms.Button
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
