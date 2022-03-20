Imports System.Data.SqlClient
Public Class 修改密码
    Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
    Dim mysql As String
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "学生" Then
            ComboBox1.Text = 2
        Else
            ComboBox1.Text = 1
        End If
        Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
        Dim mysql As String
        mysql = "select * from 用户表 where 用户编号='" & TextBox1.Text & "'and 用户密码='" & TextBox2.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        Dim mydb As New DataSet
        myadapter.Fill(mydb, "用户表")
        If mydb.Tables("用户表").Rows.Count = 0 Then
            MsgBox("用户名或密码错误！")
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
        Else
            If Val(TextBox2.Text) = Val(TextBox3.Text) Then
                MsgBox("两次密码相同！")
            Else
                Dim mysq = " update 用户 set 用户等级 = '" & ComboBox1.Text & "'where 用户编号 = '" & TextBox1.Text & "'update 用户 set 用户密码 = '" & TextBox3.Text & "'where 用户编号 = '" & TextBox1.Text & "'"
                Dim mycmd As New SqlClient.SqlCommand(mysq, myconn)
                myconn.Open()
                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()
                MsgBox("修改完毕")
            End If

        End If
        Me.Close()
    End Sub

    Private Sub 修改密码_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class