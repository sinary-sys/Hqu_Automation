Imports System.Data.SqlClient

Public Class 登录
    Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
    Dim mysql As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
        Dim mysql As String
        mysql = "select * from 用户表 where 用户名='" & UsernameTextBox.Text & "'and 用户密码='" & PasswordTextBox.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        Dim mydb As New DataSet
        myadapter.Fill(mydb, "用户表")
        If mydb.Tables("用户表").Rows.Count = 0 Then
            MsgBox("用户名或密码错误！")
            Me.UsernameTextBox.Text = ""
            Me.PasswordTextBox.Text = ""
        Else
            If (mydb.Tables("用户表").Rows(0).Item(2) = 1) Then
                MsgBox("登录成功")
                Me.Hide()
                管理员管理.Show()
            End If
            If (mydb.Tables("用户表").Rows(0).Item(2) = 2) Then
                MsgBox("登录成功")
                Me.Hide()
                宿舍水电费查询.Show()
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quxiao.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        用户注册.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub 登录_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

