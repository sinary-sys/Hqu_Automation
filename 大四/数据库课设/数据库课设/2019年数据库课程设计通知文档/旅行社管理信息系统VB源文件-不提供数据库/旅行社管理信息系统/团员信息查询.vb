'' 导入命名空间
Imports System.Data.SqlClient

Public Class 团员信息查询
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase


    Private Sub 团员信息查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 建立一个连接字符串
        '  Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        ' Dim strSql As String = "SELECT 团员编号,性别,姓名,电话,身份证号,通讯地址,团队编号 FROM 团员信息表"
        ' 建立一个数据连接
        '  Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        '  Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        ' 将数据填入数据集
        '  myCommand.Fill(ds, "旅行路线")
        '指定绑定的数据源
        '   mybind = Me.BindingContext(ds, "旅行路线")
        '将TextBox 控件的Text 属性绑定至数据集ds 内的学生数据表的学号、姓名等字段
        '  TextBox团员编号.DataBindings.Add("Text", ds, "团员信息表.团员编号")
        ' TextBox姓名.DataBindings.Add("Text", ds, "团员信息表.姓名")
        ' TextBox性别.DataBindings.Add("Text", ds, "团员信息表.性别")
        ' TextBox电话.DataBindings.Add("Text", ds, "团员信息表.电话")
        'TextBox身份证号.DataBindings.Add("Text", ds, "团员信息表.身份证号")
        ' TextBox通讯地址.DataBindings.Add("Text", ds, "团员信息表.通讯地址")
        'TextBox团队编号.DataBindings.Add("Text", ds, "团员信息表.团队编号")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ds.Clear()    '清空数据集Dt
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim sqlstr As String  '定义存放sql语句的字符串
        sqlstr = " select * From 团员信息表 Where 团员编号 like '" & _
           TextBox团员编号.Text & "%'" & " and 姓名 like '" & _
            TextBox姓名.Text & "%'" 'sql语句
        '创建adapter实例，并指定要执行的sql语句文本
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(sqlstr, myConnection)


        Try
            '根据查询条件填写数据集Dt
            myCommand.Fill(Me.ds, "团员信息表")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        '设置DataGrid1的数据源
        DataGridView1.DataSource = ds.Tables("团员信息表")








        ' Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        'Dim cx As String = "select * from 团员信息表 where 团员编号='" + TextBox团员编号.Text + "'"
        'Dim cxdb As New DataSet
        ' Dim cxadpter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cx, myConnection)
        'cxadpter.Fill(cxdb, "1")
        'If cxdb.Tables("1").Rows.Count = 0 Then
        'MsgBox("无记录")
        'Else
        'TextBox团员编号.Text = cxdb.Tables("1").Rows(0).Item(0)
        'TextBox姓名.Text = cxdb.Tables("1").Rows(0).Item(1)
        'TextBox性别.Text = cxdb.Tables("1").Rows(0).Item(2)
        'TextBox电话.Text = cxdb.Tables("1").Rows(0).Item(3)
        'TextBox身份证号.Text = cxdb.Tables("1").Rows(0).Item(4)
        'TextBox通讯地址.Text = cxdb.Tables("1").Rows(0).Item(5)
        'TextBox团队编号.Text = cxdb.Tables("1").Rows(0).Item(6)

        'End If
    End Sub
End Class