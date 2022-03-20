<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 旅行路线信息维护
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox路线编号 = New System.Windows.Forms.TextBox()
        Me.TextBox路线名称 = New System.Windows.Forms.TextBox()
        Me.TextBox简介 = New System.Windows.Forms.TextBox()
        Me.TextBox费用 = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(122, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "路线编号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "路线名称"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "简介"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "费用"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "公司名称"
        '
        'TextBox路线编号
        '
        Me.TextBox路线编号.Location = New System.Drawing.Point(181, 58)
        Me.TextBox路线编号.Name = "TextBox路线编号"
        Me.TextBox路线编号.Size = New System.Drawing.Size(117, 21)
        Me.TextBox路线编号.TabIndex = 5
        '
        'TextBox路线名称
        '
        Me.TextBox路线名称.Location = New System.Drawing.Point(181, 93)
        Me.TextBox路线名称.Name = "TextBox路线名称"
        Me.TextBox路线名称.Size = New System.Drawing.Size(117, 21)
        Me.TextBox路线名称.TabIndex = 6
        '
        'TextBox简介
        '
        Me.TextBox简介.Location = New System.Drawing.Point(181, 129)
        Me.TextBox简介.Name = "TextBox简介"
        Me.TextBox简介.Size = New System.Drawing.Size(117, 21)
        Me.TextBox简介.TabIndex = 7
        '
        'TextBox费用
        '
        Me.TextBox费用.Location = New System.Drawing.Point(181, 164)
        Me.TextBox费用.Name = "TextBox费用"
        Me.TextBox费用.Size = New System.Drawing.Size(117, 21)
        Me.TextBox费用.TabIndex = 8
        '
        'TextBox公司名称
        '
        Me.TextBox公司名称.Location = New System.Drawing.Point(181, 198)
        Me.TextBox公司名称.Name = "TextBox公司名称"
        Me.TextBox公司名称.Size = New System.Drawing.Size(117, 21)
        Me.TextBox公司名称.TabIndex = 9
        '
        'ButtonFirst
        '
        Me.ButtonFirst.Location = New System.Drawing.Point(52, 276)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(81, 37)
        Me.ButtonFirst.TabIndex = 17
        Me.ButtonFirst.Text = "第一条"
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(148, 276)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(85, 37)
        Me.ButtonUp.TabIndex = 18
        Me.ButtonUp.Text = "上一条"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(248, 276)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(76, 37)
        Me.ButtonDown.TabIndex = 19
        Me.ButtonDown.Text = "下一条"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.Location = New System.Drawing.Point(345, 276)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(90, 37)
        Me.ButtonLast.TabIndex = 20
        Me.ButtonLast.Text = "最后一条"
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 49)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(465, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 46)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "删除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(465, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 48)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "更新"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(465, 270)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 43)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "确认"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(465, 338)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 37)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "取消"
        Me.Button5.UseVisualStyleBackColor = True
        '
        '旅行路线信息维护
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 387)
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
        Me.Controls.Add(Me.TextBox费用)
        Me.Controls.Add(Me.TextBox简介)
        Me.Controls.Add(Me.TextBox路线名称)
        Me.Controls.Add(Me.TextBox路线编号)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "旅行路线信息维护"
        Me.Text = "旅行路线信息维护"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox路线编号 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox路线名称 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox简介 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox费用 As System.Windows.Forms.TextBox
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
