Public Class 管理员系统
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        登录界面.Show()
        登录界面.TextBox_管理员用户名.Text = ""
        登录界面.TextBox_管理员密码.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        管理员修改密码.Show()
    End Sub

    Private Sub 管理员系统_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub 管理员系统_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        歌曲管理.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        会员信息.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        管理人员.Show()
    End Sub
End Class