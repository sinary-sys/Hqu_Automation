Imports System.Data.SqlClient
Public Class 管理员个人信息修改界面
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub 管理员个人信息修改界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSql As String = "SELECT 密码,姓名,性别,电话 FROM 管理员 WHERE 工号='" & 登录界面.TextBox1.Text & "' "
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)

        myCommand.Fill(ds, "管理员")
        mybind = Me.BindingContext(ds, "管理员")
        TextBox3.DataBindings.Add("Text", ds, "管理员.姓名")
        TextBox4.DataBindings.Add("Text", ds, "管理员.性别")
        TextBox5.DataBindings.Add("Text", ds, "管理员.电话")
        TextBox1.DataBindings.Add("Text", ds, "管理员.密码")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim mycmd As New SqlCommand
        Dim myconn As New SqlConnection(strConnection)
        Dim strSql As String = "UPDATE 管理员 SET 姓名='" & TextBox3.Text & "', 性别='" & TextBox4.Text & "',电话='" & TextBox5.Text & "',密码='" & TextBox1.Text & "'WHERE 工号 = '" & 管理员界面.TextBox1.Text & "'"
        Dim myconnStr As New SqlCommand(strSql, myconn)
        myconn.Open()
        Try
            myconnStr.ExecuteScalar()
            管理员界面.TextBox2.Text = TextBox3.Text
            管理员界面.TextBox3.Text = TextBox4.Text
            管理员界面.TextBox4.Text = TextBox5.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        Me.Close()
    End Sub
End Class