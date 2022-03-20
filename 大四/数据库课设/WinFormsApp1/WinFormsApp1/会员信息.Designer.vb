<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 会员信息
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.增加用户 = New System.Windows.Forms.Button()
        Me.删除用户 = New System.Windows.Forms.Button()
        Me.返回 = New System.Windows.Forms.Button()
        Me.修改用户 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.会员编号 = New System.Windows.Forms.TextBox()
        Me.会员用户名 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.身份证号 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.查询 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(371, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 604)
        Me.DataGridView1.TabIndex = 0
        '
        '增加用户
        '
        Me.增加用户.Location = New System.Drawing.Point(211, 701)
        Me.增加用户.Name = "增加用户"
        Me.增加用户.Size = New System.Drawing.Size(198, 63)
        Me.增加用户.TabIndex = 1
        Me.增加用户.Text = "增加用户"
        Me.增加用户.UseVisualStyleBackColor = True
        '
        '删除用户
        '
        Me.删除用户.Location = New System.Drawing.Point(562, 701)
        Me.删除用户.Name = "删除用户"
        Me.删除用户.Size = New System.Drawing.Size(198, 63)
        Me.删除用户.TabIndex = 2
        Me.删除用户.Text = "删除用户"
        Me.删除用户.UseVisualStyleBackColor = True
        '
        '返回
        '
        Me.返回.Location = New System.Drawing.Point(1266, 701)
        Me.返回.Name = "返回"
        Me.返回.Size = New System.Drawing.Size(198, 63)
        Me.返回.TabIndex = 3
        Me.返回.Text = "返回"
        Me.返回.UseVisualStyleBackColor = True
        '
        '修改用户
        '
        Me.修改用户.Location = New System.Drawing.Point(912, 701)
        Me.修改用户.Name = "修改用户"
        Me.修改用户.Size = New System.Drawing.Size(198, 63)
        Me.修改用户.TabIndex = 4
        Me.修改用户.Text = "修改用户"
        Me.修改用户.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "会员编号"
        '
        '会员编号
        '
        Me.会员编号.Location = New System.Drawing.Point(143, 81)
        Me.会员编号.Name = "会员编号"
        Me.会员编号.Size = New System.Drawing.Size(200, 38)
        Me.会员编号.TabIndex = 6
        '
        '会员用户名
        '
        Me.会员用户名.Location = New System.Drawing.Point(143, 234)
        Me.会员用户名.Name = "会员用户名"
        Me.会员用户名.Size = New System.Drawing.Size(200, 38)
        Me.会员用户名.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "会员用户名"
        '
        '身份证号
        '
        Me.身份证号.Location = New System.Drawing.Point(143, 375)
        Me.身份证号.Name = "身份证号"
        Me.身份证号.Size = New System.Drawing.Size(200, 38)
        Me.身份证号.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "身份证号"
        '
        '查询
        '
        Me.查询.Location = New System.Drawing.Point(90, 520)
        Me.查询.Name = "查询"
        Me.查询.Size = New System.Drawing.Size(198, 63)
        Me.查询.TabIndex = 13
        Me.查询.Text = "查询"
        Me.查询.UseVisualStyleBackColor = True
        '
        '会员信息
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 800)
        Me.Controls.Add(Me.查询)
        Me.Controls.Add(Me.身份证号)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.会员用户名)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.会员编号)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.修改用户)
        Me.Controls.Add(Me.返回)
        Me.Controls.Add(Me.删除用户)
        Me.Controls.Add(Me.增加用户)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "会员信息"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "会员信息"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 增加用户 As Button
    Friend WithEvents 删除用户 As Button
    Friend WithEvents 返回 As Button
    Friend WithEvents 修改用户 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents 会员编号 As TextBox
    Friend WithEvents 会员用户名 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents 身份证号 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents 查询 As Button
End Class
