Imports System.Data.SqlClient
Public Class 读者个人信息修改界面
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub 读者个人信息修改界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSql As String = "SELECT 姓名,性别,工作单位,密码 FROM 读者 WHERE 借书证号='" & 登录界面.TextBox1.Text & "' "
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)

        myCommand.Fill(ds, "读者")
        mybind = Me.BindingContext(ds, "读者")
        TextBox2.DataBindings.Add("Text", ds, "读者.姓名")
        TextBox3.DataBindings.Add("Text", ds, "读者.性别")
        TextBox4.DataBindings.Add("Text", ds, "读者.工作单位")
        TextBox1.DataBindings.Add("Text", ds, "读者.密码")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim mycmd As New SqlCommand
        Dim myconn As New SqlConnection(strConnection)
        Dim strSql As String = "UPDATE 读者 SET 姓名='" & TextBox2.Text & "', 性别='" & TextBox3.Text & "',工作单位='" & TextBox4.Text & "',密码='" & TextBox1.Text & "'WHERE 借书证号 = '" & 读者界面.TextBox1.Text & "'"
        Dim myconnStr As New SqlCommand(strSql, myconn)
        myconn.Open()
        Try
            myconnStr.ExecuteScalar()
            读者界面.TextBox2.Text = TextBox2.Text
            读者界面.TextBox3.Text = TextBox3.Text
            读者界面.TextBox4.Text = TextBox4.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        Me.Close()
    End Sub
End Class