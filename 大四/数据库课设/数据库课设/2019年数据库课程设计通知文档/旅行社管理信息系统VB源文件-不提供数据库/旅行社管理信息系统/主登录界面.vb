'' 导入命名空间
Imports System.Data.SqlClient

Public Class 主登录界面
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase

    Private Sub 主登录界面_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' Dim strSql As String = "SELECT 用户名,密码 FROM 用户表"

        'Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        ' Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)

        'myCommand.Fill(ds, "用户表")

        'mybind = Me.BindingContext(ds, "用户表")

        'TextBox用户名.DataBindings.Add("Text", ds, "用户表.用户名")
        'TextBox密码.DataBindings.Add("Text", ds, "用户表.密码")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Dim dl As New DataSet
        Dim denglu = "select * from 用户表 where 用户名='" + TextBox用户名.Text + "' and 密码='" + TextBox密码.Text + "'"
        Dim dengluadpter As New SqlClient.SqlDataAdapter(denglu, myConnection)
        dengluadpter.Fill(dl, "1")
          If dl.Tables("1").Rows.Count = 0 Then
            MsgBox("用户或密码错误！")
            TextBox用户名.Text = ""
            TextBox密码.Text = ""
        Else
            MsgBox("已登陆！")

            If dl.Tables("1").Rows(0).Item(2) = "1" Then
                qx = 1
                Me.Hide()
                主窗体.Show()
            Else
                qx = 2

                Me.Hide()
                主窗体.Show()

            End If

        End If


    End Sub

     
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
