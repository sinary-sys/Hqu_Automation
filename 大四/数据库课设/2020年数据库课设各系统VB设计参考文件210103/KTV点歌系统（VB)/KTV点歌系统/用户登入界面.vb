
Imports System.Data.SqlClient
Public Class 用户登入界面
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase

    Private Sub 主登录界面_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' Dim strConnection As String = "Data Source=localhost;Initial Catalog=KTV;Integrated Security=True"
        ' Dim strSql As String = "SELECT 登录名,密码 FROM 会员"

        'Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        ' Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)

        'myCommand.Fill(ds, "会员")

        'mybind = Me.BindingContext(ds, "会员")

        'TextBox用户名.DataBindings.Add("Text", ds, "会员.登录名")
        'TextBox密码.DataBindings.Add("Text", ds, "会员.密码")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox用户名_TextChanged(sender As Object, e As EventArgs) Handles TextBox用户名.TextChanged

    End Sub

    Private Sub TextBox密码_TextChanged(sender As Object, e As EventArgs) Handles TextBox密码.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        登入界面.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconn As New SqlConnection("Data Source=localhost;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String
        mysql = "select * from 会员 where 登录名='" + TextBox用户名.Text + "' and 密码='" + TextBox密码.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        Dim mydb As New DataSet
        myadapter.Fill(mydb, "1")
        If mydb.Tables("1").Rows.Count = 0 Then
            MsgBox("用户或密码错误！")
            TextBox用户名.Text = ""
            TextBox密码.Text = ""
        Else
            If (mydb.Tables("1").Rows(0).Item(2) = 1) Then
                MsgBox(TextBox用户名.Text + "已登陆！")
                Me.Hide()
                用户主窗口.Show()
            End If

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class