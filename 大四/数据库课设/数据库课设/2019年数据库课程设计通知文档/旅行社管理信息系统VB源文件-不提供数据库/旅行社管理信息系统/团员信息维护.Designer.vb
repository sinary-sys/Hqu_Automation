<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 团员信息维护
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
        Me.TextBox团员编号 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox姓名 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox性别 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox电话 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox身份证号 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox通讯地址 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox团队编号 = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(154, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "团员编号"
        '
        'TextBox团员编号
        '
        Me.TextBox团员编号.Location = New System.Drawing.Point(213, 103)
        Me.TextBox团员编号.Name = "TextBox团员编号"
        Me.TextBox团员编号.Size = New System.Drawing.Size(100, 21)
        Me.TextBox团员编号.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "姓名"
        '
        'TextBox姓名
        '
        Me.TextBox姓名.Location = New System.Drawing.Point(213, 133)
        Me.TextBox姓名.Name = "TextBox姓名"
        Me.TextBox姓名.Size = New System.Drawing.Size(100, 21)
        Me.TextBox姓名.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "性别"
        '
        'TextBox性别
        '
        Me.TextBox性别.Location = New System.Drawing.Point(213, 160)
        Me.TextBox性别.Name = "TextBox性别"
        Me.TextBox性别.Size = New System.Drawing.Size(100, 21)
        Me.TextBox性别.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "电话"
        '
        'TextBox电话
        '
        Me.TextBox电话.Location = New System.Drawing.Point(213, 194)
        Me.TextBox电话.Name = "TextBox电话"
        Me.TextBox电话.Size = New System.Drawing.Size(100, 21)
        Me.TextBox电话.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "身份证号"
        '
        'TextBox身份证号
        '
        Me.TextBox身份证号.Location = New System.Drawing.Point(213, 225)
        Me.TextBox身份证号.Name = "TextBox身份证号"
        Me.TextBox身份证号.Size = New System.Drawing.Size(133, 21)
        Me.TextBox身份证号.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "通讯地址"
        '
        'TextBox通讯地址
        '
        Me.TextBox通讯地址.Location = New System.Drawing.Point(213, 251)
        Me.TextBox通讯地址.Name = "TextBox通讯地址"
        Me.TextBox通讯地址.Size = New System.Drawing.Size(268, 21)
        Me.TextBox通讯地址.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "团队编号"
        '
        'TextBox团队编号
        '
        Me.TextBox团队编号.Location = New System.Drawing.Point(213, 283)
        Me.TextBox团队编号.Name = "TextBox团队编号"
        Me.TextBox团队编号.Size = New System.Drawing.Size(100, 21)
        Me.TextBox团队编号.TabIndex = 13
        '
        'ButtonFirst
        '
        Me.ButtonFirst.Location = New System.Drawing.Point(84, 338)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(87, 38)
        Me.ButtonFirst.TabIndex = 21
        Me.ButtonFirst.Text = "|<"
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(180, 338)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(85, 38)
        Me.ButtonUp.TabIndex = 22
        Me.ButtonUp.Text = "<<"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(280, 338)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(83, 38)
        Me.ButtonDown.TabIndex = 23
        Me.ButtonDown.Text = ">>"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.Location = New System.Drawing.Point(378, 338)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(79, 38)
        Me.ButtonLast.TabIndex = 24
        Me.ButtonLast.Text = ">|"
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 48)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(509, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 49)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(509, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 44)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "删除"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(509, 278)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 43)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "确认"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(509, 225)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 36)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "更新"
        Me.Button5.UseVisualStyleBackColor = True
        '
        '团员信息维护
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 424)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonDown)
        Me.Controls.Add(Me.ButtonUp)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.TextBox团队编号)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox通讯地址)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox身份证号)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox电话)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox性别)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox姓名)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox团员编号)
        Me.Controls.Add(Me.Label1)
        Me.Name = "团员信息维护"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox团员编号 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox姓名 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox性别 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox电话 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox身份证号 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox通讯地址 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox团队编号 As System.Windows.Forms.TextBox
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
