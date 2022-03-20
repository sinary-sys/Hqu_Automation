<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 团员信息输入
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "团员编号"
        '
        'TextBox团员编号
        '
        Me.TextBox团员编号.Location = New System.Drawing.Point(224, 105)
        Me.TextBox团员编号.Name = "TextBox团员编号"
        Me.TextBox团员编号.Size = New System.Drawing.Size(135, 21)
        Me.TextBox团员编号.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "姓名"
        '
        'TextBox姓名
        '
        Me.TextBox姓名.Location = New System.Drawing.Point(224, 136)
        Me.TextBox姓名.Name = "TextBox姓名"
        Me.TextBox姓名.Size = New System.Drawing.Size(135, 21)
        Me.TextBox姓名.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "性别"
        '
        'TextBox性别
        '
        Me.TextBox性别.Location = New System.Drawing.Point(224, 169)
        Me.TextBox性别.Name = "TextBox性别"
        Me.TextBox性别.Size = New System.Drawing.Size(135, 21)
        Me.TextBox性别.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "电话"
        '
        'TextBox电话
        '
        Me.TextBox电话.Location = New System.Drawing.Point(224, 201)
        Me.TextBox电话.Name = "TextBox电话"
        Me.TextBox电话.Size = New System.Drawing.Size(135, 21)
        Me.TextBox电话.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "身份证号"
        '
        'TextBox身份证号
        '
        Me.TextBox身份证号.Location = New System.Drawing.Point(224, 236)
        Me.TextBox身份证号.Name = "TextBox身份证号"
        Me.TextBox身份证号.Size = New System.Drawing.Size(135, 21)
        Me.TextBox身份证号.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "通讯地址"
        '
        'TextBox通讯地址
        '
        Me.TextBox通讯地址.Location = New System.Drawing.Point(224, 267)
        Me.TextBox通讯地址.Name = "TextBox通讯地址"
        Me.TextBox通讯地址.Size = New System.Drawing.Size(238, 21)
        Me.TextBox通讯地址.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "团队编号"
        '
        'TextBox团队编号
        '
        Me.TextBox团队编号.Location = New System.Drawing.Point(224, 297)
        Me.TextBox团队编号.Name = "TextBox团队编号"
        Me.TextBox团队编号.Size = New System.Drawing.Size(134, 21)
        Me.TextBox团队编号.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "确定输入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '团员信息输入
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 454)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "团员信息输入"
        Me.Text = "团员信息输入"
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
