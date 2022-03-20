
'' 导入命名空间
Imports System.Data.SqlClient
Public Class 旅行路线信息维护
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase


    Private Sub 旅行路线信息维护_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 建立一个连接字符串
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 路线编号,路线名称,简介,费用,公司名称  FROM 旅行路线"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        ' 将数据填入数据集
        myCommand.Fill(ds, "旅行路线")
        '指定绑定的数据源
        mybind = Me.BindingContext(ds, "旅行路线")
        '将TextBox 控件的Text 属性绑定至数据集ds 内的学生数据表的学号、姓名等字段
        TextBox路线编号.DataBindings.Add("Text", ds, "旅行路线.路线编号")
        TextBox路线名称.DataBindings.Add("Text", ds, "旅行路线.路线名称")
        TextBox简介.DataBindings.Add("Text", ds, "旅行路线.简介")
        TextBox费用.DataBindings.Add("Text", ds, "旅行路线.费用")
        TextBox公司名称.DataBindings.Add("Text", ds, "旅行路线.公司名称")
    End Sub
    ' 按下 第一条 按钮
    Private Sub ButtonFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFirst.Click
        ' 将 Position 属性设定成 0
        mybind.Position = 0
    End Sub
    ' 按下 上一条 按钮
    Private Sub ButtonUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUp.Click
        If mybind.Position > 0 Then
            ' 将 Position 属性递减 1
            mybind.Position -= 1
        End If
    End Sub
    ' 按下 下一条 按钮
    Private Sub ButtonDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDown.Click
        If mybind.Position < Me.mybind.Count - 1 Then
            ' 将 Position 属性递增 1
            mybind.Position += 1
        End If
    End Sub

    Private Sub ButtonLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLast.Click
        ' 按下 最后一条 按钮
        mybind.Position = mybind.Count - 1
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        '查询当前编号是否存在，存在则执行更新，否则提示请新建

        Dim cx As String = "select * from 旅行路线 where 路线编号='" + TextBox路线编号.Text + "'"
        Dim cxdb As New DataSet
        Dim cxadpter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cx, myConnection)
        cxadpter.Fill(cxdb, "1")
        If cxdb.Tables("1").Rows.Count = 0 Then
            MsgBox("路线编号不存在，请新建！")
        Else

            Dim gx = "update 旅行路线 set 路线编号 ='" + TextBox路线编号.Text + "',路线名称 = '" + TextBox路线名称.Text + "',简介 = '" + TextBox简介.Text + "',费用='" + TextBox费用.Text + "',公司名称 = '" + TextBox公司名称.Text + "' where 路线编号='" + TextBox路线编号.Text + "'"

            Dim gxadpter As New SqlClient.SqlCommand(gx, myConnection)
            myConnection.Open()
            Try

                gxadpter.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            myConnection.Close()
            MsgBox("修改成功！")
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Dim sc = "delete from 旅行路线  where 路线编号 = '" + TextBox路线编号.Text + "'"

        Dim scadpter As New SqlClient.SqlCommand(sc, myConnection)
        myConnection.Open()
        Try

            scadpter.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        myConnection.Close()
        MsgBox("删除成功！")



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)


        Dim cx As String = "select * from 旅行路线 where 路线编号='" + TextBox路线编号.Text + "'"
        Dim cxdb As New DataSet
        Dim cxadpter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cx, myConnection)
        cxadpter.Fill(cxdb, "2")
        If cxdb.Tables("2").Rows.Count <> 0 Then
            MsgBox("路线编号已存在！")
        Else
            Dim xj = "insert into 旅行路线 values('" + TextBox路线编号.Text + "','" + TextBox路线名称.Text + "','" + TextBox简介.Text + "','" + TextBox费用.Text + "','" + TextBox公司名称.Text + "')"
            Dim xjadpter As New SqlClient.SqlCommand(xj, myConnection)
            myConnection.Open()
            Try

                xjadpter.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            myConnection.Close()
            MsgBox("新建成功！")
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mybind.AddNew()
        bianshi = 7
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mybind.RemoveAt(mybind.Position)
        bianshi = 8
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mybind.EndCurrentEdit()
        bianshi = 9
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mybind.EndCurrentEdit()
        ' 建立一个连接字符串
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 路线编号,路线名称,简介,费用,公司名称  FROM 旅行路线"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        Dim SB As New SqlCommandBuilder(myCommand)
        ' 将数据填入数据集
        myCommand.Update(ds, "旅行路线")

        If bianshi = 7 Then
            MsgBox("添加成功！")
        ElseIf bianshi = 8 Then
            MsgBox("删除成功！")
        ElseIf bianshi = 9 Then
            MsgBox("更新成功！")
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        mybind.CancelCurrentEdit()
    End Sub
End Class