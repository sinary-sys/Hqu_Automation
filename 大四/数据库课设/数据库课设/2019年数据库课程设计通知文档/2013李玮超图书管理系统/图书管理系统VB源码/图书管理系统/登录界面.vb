Imports System.Data.SqlClient
Public Class 登录界面
    Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
    Dim mycmd As New SqlCommand
    Dim myconn As New SqlConnection(strConnection)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr1 As String
        Dim dr2 As String
        dr1 = TextBox1.Text
        dr2 = TextBox2.Text
        If dr1.Length > 10 Then
            MsgBox("用户名不能大于10位")
        Else
            If dr2.Length > 6 Then
                MsgBox("密码不能大于6位")
            Else
                If dr1 = "" Or dr2 = "" Then
                    MsgBox("请输入完整信息")
                Else
                End If
            End If
        End If

        Dim str1 As String = "select 工号,密码 from 管理员 where 工号='" & TextBox1.Text & "' and 密码='" & TextBox2.Text & "'"
        Dim str2 As String = "select 借书证号,密码 from 读者 where 借书证号='" & TextBox1.Text & "' and 密码='" & TextBox2.Text & "'"
        Dim newStr As String
        Dim newStr2 As String
        Dim myconnStr As New SqlCommand(str1, myconn)
        Dim myconnStr2 As New SqlCommand(str2, myconn)

        'myconn.Close()
        myconn.Open()
        newStr = myconnStr.ExecuteScalar()
        newStr2 = myconnStr2.ExecuteScalar()
        If newStr <> Nothing Then
            MessageBox.Show("欢迎进入")
            Me.Visible = False
            ' Me.Hide()
            管理员界面.ShowDialog()
        ElseIf newStr2 <> Nothing Then
            MessageBox.Show("欢迎进入")
            Me.Visible = False
            ' Me.Hide()
            读者界面.ShowDialog()
        Else
            MessageBox.Show("用户名或密码错误，登录失败")
        End If
        myconn.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class



