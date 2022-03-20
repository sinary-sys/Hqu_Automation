Imports System.Data.SqlClient
Public Class 管理员登入界面
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconn As New SqlConnection("Data Source=localhost;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String
        mysql = "select * from 管理员 where 用户名='" + TextBox用户名.Text + "' and 密码='" + TextBox密码.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        Dim mydb As New DataSet
        myadapter.Fill(mydb, "1")
        If mydb.Tables("1").Rows.Count = 0 Then
            MsgBox("用户或密码错误！")
            TextBox用户名.Text = ""
            TextBox密码.Text = ""
        Else

            MsgBox(TextBox用户名.Text + "已登陆！")
            Me.Hide()
            管理员主窗口.Show()

        End If
    End Sub

    Private Sub TextBox用户名_TextChanged(sender As Object, e As EventArgs) Handles TextBox用户名.TextChanged

    End Sub

    Private Sub TextBox密码_TextChanged(sender As Object, e As EventArgs) Handles TextBox密码.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        登入界面.Show()
    End Sub
End Class