<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 注册账号
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(注册账号))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox_用户名 = New System.Windows.Forms.TextBox()
        Me.TextBox_密码 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_出生日期 = New System.Windows.Forms.TextBox()
        Me.TextBox_身份证号 = New System.Windows.Forms.TextBox()
        Me.ComboBox_性别 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(184, 687)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 87)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "注册"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(492, 687)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 87)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "关闭"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox_用户名
        '
        Me.TextBox_用户名.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_用户名.Location = New System.Drawing.Point(298, 171)
        Me.TextBox_用户名.Name = "TextBox_用户名"
        Me.TextBox_用户名.Size = New System.Drawing.Size(263, 54)
        Me.TextBox_用户名.TabIndex = 3
        '
        'TextBox_密码
        '
        Me.TextBox_密码.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_密码.Location = New System.Drawing.Point(298, 252)
        Me.TextBox_密码.Name = "TextBox_密码"
        Me.TextBox_密码.Size = New System.Drawing.Size(263, 54)
        Me.TextBox_密码.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(131, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "用户名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(148, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 48)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "密码"
        '
        'TextBox_出生日期
        '
        Me.TextBox_出生日期.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_出生日期.Location = New System.Drawing.Point(298, 427)
        Me.TextBox_出生日期.Name = "TextBox_出生日期"
        Me.TextBox_出生日期.Size = New System.Drawing.Size(263, 54)
        Me.TextBox_出生日期.TabIndex = 9
        '
        'TextBox_身份证号
        '
        Me.TextBox_身份证号.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_身份证号.Location = New System.Drawing.Point(298, 525)
        Me.TextBox_身份证号.Name = "TextBox_身份证号"
        Me.TextBox_身份证号.Size = New System.Drawing.Size(420, 54)
        Me.TextBox_身份证号.TabIndex = 10
        '
        'ComboBox_性别
        '
        Me.ComboBox_性别.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox_性别.FormattingEnabled = True
        Me.ComboBox_性别.Items.AddRange(New Object() {"男", "女"})
        Me.ComboBox_性别.Location = New System.Drawing.Point(298, 346)
        Me.ComboBox_性别.Name = "ComboBox_性别"
        Me.ComboBox_性别.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_性别.Size = New System.Drawing.Size(263, 39)
        Me.ComboBox_性别.TabIndex = 11
        Me.ComboBox_性别.Text = "男"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(148, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 48)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "性别"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(114, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 48)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "出生日期"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(114, 528)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 48)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "身份证号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("华文琥珀", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(280, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 61)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "注册账号"
        '
        '注册账号
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 882)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_性别)
        Me.Controls.Add(Me.TextBox_身份证号)
        Me.Controls.Add(Me.TextBox_出生日期)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_密码)
        Me.Controls.Add(Me.TextBox_用户名)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "注册账号"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "注册账号"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox_用户名 As TextBox
    Friend WithEvents TextBox_密码 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_出生日期 As TextBox
    Friend WithEvents TextBox_身份证号 As TextBox
    Friend WithEvents ComboBox_性别 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
