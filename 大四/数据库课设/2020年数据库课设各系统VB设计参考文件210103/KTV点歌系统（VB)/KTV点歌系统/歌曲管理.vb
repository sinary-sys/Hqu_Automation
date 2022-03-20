Imports System.Data.SqlClient
Public Class 歌曲管理
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mybind.AddNew()
        bianshi = 7
    End Sub

    Private Sub 歌曲管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 建立一个连接字符串
        Dim strConnection As String = "Data Source=localhost;Initial Catalog=KTV;Integrated Security=True"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 歌曲编号,歌曲时长,歌曲名称,歌手编号,歌曲类型,语种,拼音缩写 FROM 歌曲"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        ' 将数据填入数据集
        myCommand.Fill(ds, "歌曲")
        '指定绑定的数据源
        mybind = Me.BindingContext(ds, "歌曲")
        '将TextBox 控件的Text 属性绑定至数据集ds 内的学生数据表的学号、姓名等字段
        TextBox歌曲编号.DataBindings.Add("Text", ds, "歌曲.歌曲编号")
        TextBox歌曲时长.DataBindings.Add("Text", ds, "歌曲.歌曲时长")
        TextBox歌曲名称.DataBindings.Add("Text", ds, "歌曲.歌曲名称")
        TextBox歌手编号.DataBindings.Add("Text", ds, "歌曲.歌手编号")
        TextBox歌曲类型.DataBindings.Add("Text", ds, "歌曲.歌曲类型")
        TextBox语种.DataBindings.Add("Text", ds, "歌曲.语种")
        TextBox拼音缩写.DataBindings.Add("Text", ds, "歌曲.拼音缩写")
    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        mybind.Position = 0
    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        If mybind.Position > 0 Then
            ' 将 Position 属性递减 1
            mybind.Position -= 1
        End If
    End Sub

    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        If mybind.Position < Me.mybind.Count - 1 Then
            ' 将 Position 属性递增 1
            mybind.Position += 1
        End If
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
                mybind.Position = mybind.Count - 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mybind.RemoveAt(mybind.Position)
        bianshi = 8
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mybind.EndCurrentEdit()
        bianshi = 9
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mybind.EndCurrentEdit()
        ' 建立一个连接字符串
        Dim strConnection As String = "Data Source=localhost;Initial Catalog=KTV;Integrated Security=True"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 歌曲编号,歌曲时长,歌曲名称,歌手编号,歌曲类型,语种,拼音缩写 FROM 歌曲"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        Dim SB As New SqlCommandBuilder(myCommand)
        ' 将数据填入数据集
        myCommand.Update(ds, "歌曲")

        If bianshi = 7 Then
            MsgBox("添加成功！")
        ElseIf bianshi = 8 Then
            MsgBox("删除成功！")
        ElseIf bianshi = 9 Then
            MsgBox("更新成功！")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mybind.CancelCurrentEdit()
    End Sub

    Private Sub TextBox歌曲编号_TextChanged(sender As Object, e As EventArgs) Handles TextBox歌曲编号.TextChanged

    End Sub
End Class