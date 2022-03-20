'' 导入命名空间
Imports System.Data.SqlClient
Public Class 团员信息维护
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase

    Private Sub 团员信息维护_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 建立一个连接字符串
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 团员编号,姓名,性别,电话,身份证号,通讯地址,团队编号 FROM 团员信息表"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        ' 将数据填入数据集
        myCommand.Fill(ds, "团员信息表")
        '指定绑定的数据源
        mybind = Me.BindingContext(ds, "团员信息表")
        '将TextBox 控件的Text 属性绑定至数据集ds 内的学生数据表的学号、姓名等字段
        TextBox团员编号.DataBindings.Add("Text", ds, "团员信息表.团员编号")
        TextBox姓名.DataBindings.Add("Text", ds, "团员信息表.姓名")
        TextBox性别.DataBindings.Add("Text", ds, "团员信息表.性别")
        TextBox电话.DataBindings.Add("Text", ds, "团员信息表.电话")
        TextBox身份证号.DataBindings.Add("Text", ds, "团员信息表.身份证号")
        TextBox通讯地址.DataBindings.Add("Text", ds, "团员信息表.通讯地址")
        TextBox团队编号.DataBindings.Add("Text", ds, "团员信息表.团队编号")
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

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        'Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim myConnection As SqlConnection = New SqlConnection("Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI")
        ' 更新数据记录的 UPDATE 语句
        Dim updateStr As String = _
        "UPDATE dbo.团员信息表 " & _
        "  SET 团员编号=" & "'" & TextBox团员编号.Text & "'" & _
        "     ,姓名=" & "'" & TextBox姓名.Text & "'" & _
        "     ,性别=" & "'" & TextBox性别.Text & "'" & _
        "     ,电话=" & "'" & TextBox电话.Text & "'" & _
        "     ,身份证号=" & "'" & TextBox身份证号.Text & "'" & _
        "     ,通讯地址=" & "'" & TextBox通讯地址.Text & "'" & _
        "     ,团队编号=" & "'" & TextBox团队编号.Text & "'" & _
        "  WHERE 团员编号 = " & "'" & TextBox团员编号.Text & "'"

        ' 使用 SqlCommand 类的第三个构造函数来建立 SqlCommand 对象
        Dim updateCMD As New SqlCommand(updateStr, myConnection)

        Try
            ' 打开连接
            myConnection.Open()

            ' 执行数据命令来更新数据记录
            updateCMD.ExecuteNonQuery()

            MessageBox.Show("已经成功更新数据记录。", _
                            "恭喜您", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "请注意", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            ' 关闭连接
            myConnection.Close()
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Dim sc = "delete from 团员信息表  where 团员编号 = '" + TextBox团员编号.Text + "'"

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


        Dim cx As String = "select * from 团员信息表 where 团员编号='" + TextBox团员编号.Text + "'"
        Dim cxdb As New DataSet
        Dim cxadpter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cx, myConnection)
        cxadpter.Fill(cxdb, "2")
        If cxdb.Tables("2").Rows.Count > 0 Then
            MsgBox("团员编号已存在！")
        Else
            Dim xj = "insert into 团员信息表 values('" + TextBox团员编号.Text + "','" + TextBox姓名.Text + "','" + TextBox性别.Text + "','" + TextBox电话.Text + "','" + TextBox身份证号.Text + "','" + TextBox通讯地址.Text + "','" + TextBox团队编号.Text + "')"
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mybind.AddNew()
        bianshi = 1
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mybind.RemoveAt(mybind.Position)
        bianshi = 2
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        mybind.EndCurrentEdit()
        bianshi = 3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mybind.EndCurrentEdit()
        ' 建立一个连接字符串
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 团员编号,姓名,性别,电话,身份证号,通讯地址,团队编号 FROM 团员信息表"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        Dim SB As New SqlCommandBuilder(myCommand)
        ' 将数据填入数据集
        myCommand.Update(ds, "团员信息表")
        If bianshi = 1 Then
            MsgBox("添加成功！")
        ElseIf bianshi = 2 Then
            MsgBox("删除成功！")
        ElseIf bianshi = 3 Then
            MsgBox("更新成功！")
        End If



    End Sub
 

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mybind.CancelCurrentEdit()
    End Sub
End Class