Imports System.Data.SqlClient
Public Class 登录界面
    Dim n As Integer = 0
    Public user As String
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myconnection As New SqlConnection("server=8.135.57.27;uid=sa;pwd=sun@5211314;database=KTV")

        Dim mysql As String = "select * from vip where 会员用户名='" + TextBox_用户名.Text + "'and 密码='" + TextBox_密码.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "用户")
        If mydataset.Tables("用户").Rows.Count = 0 Then
            n += 1
            If n < 3 Then
                MsgBox("用户名或密码错误！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息提示")
                TextBox_用户名.Text = ""
                TextBox_密码.Text = ""
                TextBox_用户名.Focus()
            Else
                MsgBox("已登入失败3次！退出系统", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息提示")
                Me.Close()

            End If

        Else

            MsgBox("欢迎光临！")
            Me.Hide()
            user = TextBox_用户名.Text
            用户操作界面.GroupBox1.Visible = False
            用户操作界面.DataGridView1.DataSource = False
            用户操作界面.关键字.Text = ""
            用户操作界面.n = 0
            用户操作界面.Show()


        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_用户名.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        注册账号.Show()
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")

        Dim mysql As String = "select * from manager where 管理名='" + TextBox_管理员用户名.Text + "'and 密码='" + TextBox_管理员密码.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "管理员登录表")
        If mydataset.Tables("管理员登录表").Rows.Count = 0 Then
            n += 1
            If n < 3 Then
                MsgBox("用户名或密码错误！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息提示")
                TextBox_管理员用户名.Text = ""
                TextBox_管理员密码.Text = ""
                TextBox_管理员用户名.Focus()
            Else
                MsgBox("已登入失败3次！退出系统", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息提示")
                Me.Close()

            End If

        Else
            MsgBox("登录成功！")
            Me.Hide()
            管理员系统.Show()

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
End Class
